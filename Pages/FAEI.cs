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
    public partial class FAEI : Form
    {
        string TName, NCarbs, NProtein, NFat, NCalories;

        

        public FAEI()
        {
            InitializeComponent();
        }

       

        private void FAS_Load(object sender, EventArgs e)
        {
            DGVGetTables();
        }
        public void DGVGetTables()
        {
            DataTable dl = Banco.dql($"Select T_NAME as 'Name', N_CARBS as 'Carbs', N_PROTEIN as 'Protein', N_FAT as 'Fats', N_CALORIES as 'Calories' from tb_stuff Where T_USERNAME='{Global.name}'");
            DGV.DataSource = dl;
            DGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

       

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV.SelectedCells.Count < 0) { return; }
            if (DGV.SelectedRows.Count < 0) { return; }
            B_Remove.Enabled = true;
            B_Save.Enabled = true;
            
            TName = DGV.SelectedCells[0].Value.ToString();
            NCarbs = DGV.SelectedCells[1].Value.ToString();
            NProtein = DGV.SelectedCells[2].Value.ToString();
            NFat = DGV.SelectedCells[3].Value.ToString();
            NCalories = DGV.SelectedCells[4].Value.ToString();

            TB_Name.Text = TName;
            TB_Carbs.Text = NCarbs;
            TB_Protein.Text = NProtein;
            TB_Fats.Text = NFat;
            TB_Calories.Text = NCalories;

        }

        private void B_Add_Click(object sender, EventArgs e)
        {
            if (TB_Name.Text.Length > 11) { Banco.MError("Ingredient name too long, maximum of 11 characters."); return; }
            if (TB_Name.Text == "") { Banco.MError("Invalid Name"); TB_Name.Focus(); return; }
            DataTable dl = Banco.dql($"Select T_NAME from tb_stuff where T_NAME='{TB_Name.Text}' AND T_USERNAME='{Global.name}'");
            if (dl.Rows.Count > 0) { Banco.MError("Ingredient has already been created."); return; }
            if (CheckValues()) { return; }

            Banco.dml($"INSERT INTO tb_stuff (T_NAME, T_USERNAME, N_CARBS, N_PROTEIN, N_FAT, N_CALORIES) VALUES ('{TB_Name.Text}', '{Global.name}','{TB_Carbs.Text}', '{TB_Protein.Text}', '{TB_Fats.Text}', '{TB_Calories.Text}') ", $"'{TB_Name.Text}' was successfully added as an Ingredient. ");
            DGVGetTables();
        }
        private bool CheckValues()
        {
            int result;
            int.TryParse(TB_Carbs.Text, out result);
            if (result == 0) { Banco.MError("Invalid value for Carbs."); return true; };
            int.TryParse(TB_Protein.Text, out result);
            if (result == 0) { Banco.MError("Invalid value for Protein."); return true; };
            int.TryParse(TB_Fats.Text, out result);
            if (result == 0) { Banco.MError("Invalid value for Fat."); return true; };
            int.TryParse(TB_Calories.Text, out result);
            if (result == 0) { Banco.MError("Invalid value for Calories."); return true; };
            return false;
        }
        private void B_Save_Click(object sender, EventArgs e)
        {
            if(TB_Name.Text.Length > 11) {Banco.MError("Ingredient name too long, maximum of 11 characters."); return; }
            CheckValues();
            
            Banco.dml($"Update tb_stuff SET T_NAME = '{TB_Name.Text}',N_CARBS= '{TB_Carbs.Text}', N_PROTEIN = '{TB_Protein.Text}', N_FAT = '{TB_Fats.Text}', N_CALORIES = '{TB_Calories.Text}' WHERE T_NAME = '{TName}' AND T_USERNAME = '{Global.name}' ", $"'{TB_Name.Text}' Saved with sucess.");
            DGVGetTables();
        }
        private void B_Remove_Click(object sender, EventArgs e)
        {
            if (!Banco.MQuestion("Are you sure you want to delete this ingredient?")) { return; }
            Banco.dml($"DELETE FROM tb_stuff where T_NAME= '{TName}' AND T_USERNAME = '{Global.name}'", $"'{TName}' was sucessfully removed.");
            DGVGetTables();
        }

    }
}
