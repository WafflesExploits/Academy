using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
    public partial class FMS : Form
    {
        public FMS(int n_IDMEAL, int n_IDDAY)
        {
            InitializeComponent();
            N_IDMEAL = n_IDMEAL;
            N_IDDAY = n_IDDAY;
        }

        bool FirstTime1 = true;
        bool FirstTime2 = true;
        bool FirstTime3 = true;
        int N_IDMEAL;
        int N_IDDAY;
        bool Save = false;
        
        decimal Protein= 0;
        decimal Fat = 0;
        decimal Carbs = 0;
        decimal Calories = 0;

        private void FMS_Load(object sender, EventArgs e)
        {
            CB_Time.SelectedItem = "Select Time";
            CB_Igdt.SelectedItem = "Select Piece";
            DGVGetTables();
            CB_Load();
            GetMeal();
            GetSelected();
            

        }
        private void GetMeal ()
        {
            DataTable dt = Banco.dql($"SELECT T_NAME, N_IDTIME FROM tb_meals Where T_USERNAME = '{Global.name}' AND N_IDDAY = '{N_IDDAY}' AND N_IDMEAL = '{N_IDMEAL}'");
            if(dt.Rows.Count > 0)
            {
                Save = true;
                B_Delete.Enabled = true;
                TB_Name.Text = dt.Rows[0].ItemArray[0].ToString();
                DataTable dt1 = Banco.dql($"SELECT T_HORARIO from tb_time where N_IDTIME='{dt.Rows[0].ItemArray[1].ToString()}'");
                CB_Time.Text = (dt1.Rows[0].ItemArray[0].ToString()).Remove(5);
            }
            else
            {
                Save = false;
                B_Delete.Enabled = false;
            }
        }
        private void CB_Load()
        {
           
                DataTable dt1 = Banco.dql($@"Select T_HORARIO as 'Time' from tb_time ");
                if (dt1.Rows.Count > 0) // adicionar Workouts à ComboBox
                {
                   
                    for (int v = dt1.Rows.Count - 1; v >= 0; v--)
                    {
                        CB_Time.Items.Add(dt1.Rows[v].ItemArray[0].ToString().Remove(5));
                    }
                }
           
                DataTable dt2 = Banco.dql($@"Select T_NAME as 'Ingredients' from tb_stuff where T_USERNAME='{Global.name}'");
                if (dt2.Rows.Count > 0) // adicionar Workouts à ComboBox
                {
                    
                    for (int v = dt2.Rows.Count - 1; v >= 0; v--)
                    {
                        CB_Igdt.Items.Add(dt2.Rows[v].ItemArray[0].ToString());
                    }
                }
               

            }

      

        private void CB_Click(object sender, EventArgs e)
        {
            if (FirstTime1)
            {
                CB_Time.Items.Remove("Select Time");
                FirstTime1 = false;
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void DGVGetTables()
        {
            //NECESSÁRIO FAZER INNER JOIN DAS TABLES PARA MOSTRAR 
            DataTable dl = Banco.dql($"Select tbs.T_NAME as 'Ingredient', tbms.N_QUANT as 'Quantity', tbms.N_CARBS as 'Carbs', tbms.N_PROTEIN as 'Protein', tbms.N_FAT as 'Fats', tbms.N_CALORIES as 'Calories' from tb_mealstuff as tbms INNER JOIN tb_stuff as tbs on tbms.N_IDING = tbs.N_ID Where tbms.T_USERNAME='{Global.name}' and tbms.N_IDDAY ='{N_IDDAY}' and tbms.N_IDMEAL='{N_IDMEAL}'");
            if (FirstTime3)
            {
                if (dl.Rows.Count > 0) 
                {
                    GetMacros();
                    B_Remove.Enabled = true;
                    B_SIng.Enabled = true;
                    B_Save.Enabled = true;
                }
            }
            DGV.DataSource = dl;
            DGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void GetMacros()
        {
            Carbs = 0;
            Protein = 0;
            Fat = 0;
            Calories = 0;
            DataTable dl = Banco.dql($"Select tbs.T_NAME as 'Ingredient', tbms.N_QUANT as 'Quantity', tbms.N_CARBS as 'Carbs', tbms.N_PROTEIN as 'Protein', tbms.N_FAT as 'Fats', tbms.N_CALORIES as 'Calories' from tb_mealstuff as tbms INNER JOIN tb_stuff as tbs on tbms.N_IDING = tbs.N_ID Where tbms.T_USERNAME='{Global.name}' and tbms.N_IDDAY ='{N_IDDAY}' and tbms.N_IDMEAL='{N_IDMEAL}'");
            foreach (DataRow v in dl.Rows)
            {
                Carbs += decimal.Parse(v.ItemArray[2].ToString());
                Protein += decimal.Parse(v.ItemArray[3].ToString());
                Fat += decimal.Parse(v.ItemArray[4].ToString());
                Calories += decimal.Parse(v.ItemArray[5].ToString());
            }
            LB_Carbs.Text = $"Carbs - [{Carbs.ToString()}g]";
            LB_Protein.Text = $"Protein - [{Protein.ToString()}g]";
            LB_Fat.Text = $"Fat - [{Fat.ToString()}g]";
            LB_Calories.Text = $"Calories - [{Calories.ToString()}]";
           
        }
        private void B_Add_Click(object sender, EventArgs e)
        {
            decimal N_QUANT = 0;
            if(!(decimal.TryParse(TB_Quant.Text, out N_QUANT)))
            {
                Banco.MError("Invalid amount for quantity.");
                return;
            }
            

            DataTable dt2 = Banco.dql($@"Select N_ID, N_PROTEIN, N_CARBS, N_FAT, N_CALORIES as 'Ingredients' from tb_stuff where T_USERNAME='{Global.name}' AND T_NAME='{CB_Igdt.Text}'");
            if (dt2.Rows.Count == 0) { Banco.MError("Select an ingredient."); return; }            
            decimal N_IDING = Convert.ToInt32(dt2.Rows[0].ItemArray[0].ToString());
            decimal N_PROTEIN = Convert.ToInt32(dt2.Rows[0].ItemArray[1].ToString());
            decimal N_CARBS = Convert.ToInt32(dt2.Rows[0].ItemArray[2].ToString());
            decimal N_FAT = Convert.ToInt32(dt2.Rows[0].ItemArray[3].ToString());
            decimal N_CALORIES = Convert.ToInt32(dt2.Rows[0].ItemArray[4].ToString());
            decimal PQuant = (N_QUANT/100);
            

            DataTable dt = Banco.dql($"SELECT T_USERNAME, N_IDDAY, N_IDMEAL, N_IDING FROM tb_mealstuff Where T_USERNAME = '{Global.name}' AND N_IDDAY = '{N_IDDAY}' AND N_IDMEAL = '{N_IDMEAL}' AND N_IDING = '{N_IDING}'");
            if (dt.Rows.Count > 0)
            {
                Banco.MError("Ingredient has already been inserted.");
                return;
            }
            Banco.dml($"INSERT INTO tb_mealstuff (T_USERNAME, N_IDDAY, N_IDMEAL, N_IDING, N_QUANT, N_PROTEIN, N_CARBS, N_FAT, N_CALORIES) VALUES ('{Global.name}', '{N_IDDAY}', '{N_IDMEAL}', '{N_IDING}', '{N_QUANT}', '{N_PROTEIN * PQuant}', '{N_CARBS * PQuant}', '{N_FAT * PQuant}', '{N_CALORIES * PQuant}')", $"'{CB_Igdt.Text}' has been successfully added. ");
            DGVGetTables();
            B_Remove.Enabled = true;
            B_SIng.Enabled = true;
            B_Save.Enabled = true;
            GetMacros();
        }

        private void B_SIng_Click(object sender, EventArgs e)
        {
            decimal N_QUANT = 0;
            if (!(decimal.TryParse(TB_Quant.Text, out N_QUANT)))
            {
                Banco.MError("Invalid amount for quantity.");
                return;
            }


            DataTable dt2 = Banco.dql($@"Select N_ID, N_PROTEIN, N_CARBS, N_FAT, N_CALORIES as 'Ingredients' from tb_stuff where T_USERNAME='{Global.name}' AND T_NAME='{CB_Igdt.Text}'");
            if (dt2.Rows.Count == 0) { Banco.MError("Select an ingredient."); return; }
            decimal N_IDING = Convert.ToInt32(dt2.Rows[0].ItemArray[0].ToString());
            decimal N_PROTEIN = Convert.ToInt32(dt2.Rows[0].ItemArray[1].ToString());
            decimal N_CARBS = Convert.ToInt32(dt2.Rows[0].ItemArray[2].ToString());
            decimal N_FAT = Convert.ToInt32(dt2.Rows[0].ItemArray[3].ToString());
            decimal N_CALORIES = Convert.ToInt32(dt2.Rows[0].ItemArray[4].ToString());
            decimal PQuant = (N_QUANT / 100);
            

            DataTable dt = Banco.dql($"SELECT T_USERNAME, N_IDDAY, N_IDMEAL, N_IDING FROM tb_mealstuff Where T_USERNAME = '{Global.name}' AND N_IDDAY = '{N_IDDAY}' AND N_IDMEAL = '{N_IDMEAL}' AND N_IDING = '{N_IDING}'");
            if (dt.Rows.Count == 0) { return; }
            Banco.dml($"UPDATE tb_mealstuff SET N_QUANT = '{N_QUANT}', N_PROTEIN = '{N_PROTEIN * PQuant}', N_CARBS = '{N_CARBS * PQuant}', N_FAT = '{N_FAT * PQuant}', N_CALORIES = '{N_CALORIES * PQuant}' WHERE T_USERNAME = '{Global.name}' AND N_IDING = '{N_IDING}'", $"'Changes to {CB_Igdt.Text} have been successfully saved.'. ");
            DGVGetTables();
            GetMacros();
        }
        private void GetSelected()
        {
            if(DGV.SelectedRows.Count == 0) { return; }
            if (FirstTime2)
            {
                CB_Igdt.Items.Remove("Select Piece");
                FirstTime2 = false;
            }
            CB_Igdt.Text = DGV.SelectedRows[0].Cells[0].Value.ToString();
            TB_Quant.Text = DGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetSelected();
        }

      
        public int GetTime(string cu)
        {
            DataTable dt = Banco.dql($"SELECT N_IDTIME from tb_time where T_HORARIO='{cu}:00'");
            if (dt.Rows.Count > 0)
            {
                int ID = Convert.ToInt32(dt.Rows[0].ItemArray[0].ToString());
                return ID;
            }
            else
            {
                return 0;
            }

        }

        private void B_Save_Click(object sender, EventArgs e)
        {
            string cbtime = CB_Time.Text;
            if (cbtime == "Select Time" || cbtime == "")
            {
                Banco.MError("Select a time for the meal.");
                return;
            }
           
            string Meal = TB_Name.Text;
            if (Meal == "" )
            {
                Banco.MError("Invalid name for a meal.");
                return;
            }
            DataTable dt2 = Banco.dql($@"Select N_ID from tb_mealstuff where T_USERNAME='{Global.name}' AND N_IDDAY='{N_IDDAY}' AND N_IDMEAL='{N_IDMEAL}' ");
            if (dt2.Rows.Count == 0) { Banco.MError("Add ingredients before saving meal."); return; }


            
            if (!Save) //Add MEAL
            {
                Banco.dml($"INSERT INTO tb_meals (T_NAME, N_IDTIME, N_IDDAY, N_IDMEAL, N_PROTEIN, N_CARBS, N_FAT, N_CALORIES, T_USERNAME) VALUES ('{Meal}', '{GetTime(cbtime)}' , '{N_IDDAY}' , '{N_IDMEAL}', '{Protein}', '{Carbs}', '{Fat}', '{Calories}', '{Global.name}' ) ", $"'{Meal}' has been successfully saved as a meal.");
                GetMacros();
            }
            else // Save MEAL
            {
                Banco.dml($"UPDATE tb_meals SET T_NAME='{Meal}', N_IDTIME='{GetTime(cbtime)}', N_PROTEIN='{Protein}', N_CARBS='{Carbs}', N_FAT='{Fat}', N_CALORIES='{Calories}' WHERE T_USERNAME='{Global.name}' AND N_IDDAY='{N_IDDAY}' AND N_IDMEAL='{N_IDMEAL}' ", $"Changes to '{Meal}' have been saved.");
                GetMacros();
            }
            this.Close();
        }

        private void B_Remove_Click(object sender, EventArgs e)
        {
            DataTable dt = Banco.dql($"SELECT N_ID from tb_stuff where T_NAME='{CB_Igdt.Text}'");
            int N_IDING = int.Parse(dt.Rows[0].ItemArray[0].ToString());
            Banco.dml($"DELETE FROM tb_mealstuff WHERE T_USERNAME = '{Global.name}' AND N_IDDAY = '{N_IDDAY}' AND N_IDMEAL = '{N_IDMEAL}' and N_IDING = '{N_IDING}'", $"{CB_Igdt.Text} has been sucessfully removed.");
            DGVGetTables();
            GetMacros();
        }

        private void CB1_Click(object sender, EventArgs e)
        {
            if (FirstTime2)
            {
                CB_Igdt.Items.Remove("Select Piece");
                FirstTime2 = false;
            }
        }

        private void B_Delete_Click(object sender, EventArgs e)
        {
            if(!Banco.MQuestion("Are you sure you want to delete this meal?")) { return; }
            Save = false;
            B_Save.Enabled = false;
            Banco.dml($"DELETE FROM tb_meals WHERE T_USERNAME='{Global.name}' AND N_IDMEAL='{N_IDMEAL}' AND N_IDDAY ='{N_IDDAY}'");
            Banco.dml($"DELETE FROM tb_mealstuff WHERE T_USERNAME='{Global.name}' AND N_IDMEAL='{N_IDMEAL}' AND N_IDDAY ='{N_IDDAY}'", "Meal has been reset with sucess.");
            CB_Time.Items.Add("Select Time");
            CB_Time.SelectedItem = "Select Time";
            CB_Igdt.Items.Add("Select Piece");
            CB_Igdt.SelectedItem = "Select Piece";
            DGVGetTables();
            CB_Load();
            GetMeal();
            GetSelected();
            TB_Name.Clear();
            TB_Quant.Clear();

        }

        private void B_Copy_Click(object sender, EventArgs e)
        {
            FCMeals fcm = new FCMeals();
            fcm.ShowDialog();
            string name=fcm.name;
            int N_idmeal=fcm.N_IDMEAL, N_idday=fcm.N_IDDAY;
            DataTable dt = Banco.dql($"Select N_IDING, N_QUANT,N_CARBS, N_PROTEIN, N_FAT, N_CALORIES from tb_mealstuff where N_IDMEAL ='{N_idmeal}' AND N_IDDAY='{N_idday}' AND T_USERNAME='{Global.name}'");
            foreach( DataRow dr in dt.Rows)
            {
                decimal N_IDING= decimal.Parse(dr.ItemArray[0].ToString()), N_QUANT = decimal.Parse(dr.ItemArray[1].ToString()), N_CARBS = decimal.Parse(dr.ItemArray[2].ToString()), N_PROTEIN = decimal.Parse(dr.ItemArray[3].ToString()), N_FAT = decimal.Parse(dr.ItemArray[4].ToString()), N_CALORIES = decimal.Parse(dr.ItemArray[5].ToString());
                Banco.dml($"INSERT INTO tb_mealstuff (N_IDMEAL, N_IDDAY, T_USERNAME, N_IDING, N_QUANT, N_CARBS, N_PROTEIN, N_FAT, N_CALORIES) VALUES ('{N_IDMEAL}', '{N_IDDAY}', '{Global.name}', '{N_IDING}', '{N_QUANT}', '{N_CARBS}', '{N_PROTEIN}', '{N_FAT}', '{N_CALORIES}') ");
            }
            TB_Name.Text = name;
            DGVGetTables();
            B_Remove.Enabled = true;
            B_SIng.Enabled = true;
            B_Save.Enabled = true;
            GetMacros();
            GetSelected();
        }

    

        private void CB_Time_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_Time.Items.Remove("Select Time");
        }

        private void CB_Igdt_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_Igdt.Items.Remove("Select Piece");
        }
    }
}
