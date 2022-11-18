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
    public partial class FWT : Form
    {
        public FWT()
        {
            InitializeComponent();
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DGVSize()
        {
            DGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
        }
        
        private void DGVReload()
        {
            DataTable dt = Banco.dql($"Select N_WEIGHT as 'Weight', N_CALORIES as 'Calories', N_PROTEIN as 'Protein', N_CARBS as 'Carbs', N_FAT as 'Fat' from tb_targetweight where T_USERNAME='{Global.name}'");
            DGV.DataSource = dt;
            DGVSize();
        }

        private void FWT_Load(object sender, EventArgs e)
        {
            GetThings();
            GetTWT();
            DGVReload();
        }

        private void B_Copy_Click(object sender, EventArgs e)
        {
            if(DGV.Rows.Count == 0) { return; }
            if(DGV.SelectedRows.Count == 0) { return; }
            
            Weight = decimal.Parse(DGV.SelectedRows[0].Cells[0].Value.ToString());
            decimal Fat = decimal.Parse(DGV.SelectedRows[0].Cells[1].Value.ToString());
            Banco.dml($"Update tb_physique SET N_WEIGHT='{Weight}'");
            Banco.dml($"Update tb_calmacros SET N_TDEE='{Fat}'");
            GetThings();
            GetTWT();
            DGVReload();
            Banco.MInformation($"{Weight}kg has been set as the new weight with success.");
        }
        decimal BMRM, BMR, Age, Weight, HHeight, TW, PI, FI;
        char Goal, XP, Gender;
        private void GetThings()
        {
            DataTable dt = Banco.dql($"Select T_GOAL, N_PROTEINTAKE, N_FATTAKE, N_BMRM, N_TARGETWEIGHT, T_XP from tb_calmacros where T_USERNAME='{Global.name}'");
            Goal = char.Parse(dt.Rows[0].ItemArray[0].ToString());
            PI = decimal.Parse(dt.Rows[0].ItemArray[1].ToString());
            FI = decimal.Parse(dt.Rows[0].ItemArray[2].ToString());
            BMRM = decimal.Parse(dt.Rows[0].ItemArray[3].ToString());
            TW = decimal.Parse(dt.Rows[0].ItemArray[4].ToString());
            XP = char.Parse(dt.Rows[0].ItemArray[5].ToString());

            DataTable dt1 = Banco.dql($"Select N_AGE, T_GENDER, N_WEIGHT, N_HEIGHT from tb_physique where T_USERNAME='{Global.name}'");
            Age = decimal.Parse(dt1.Rows[0].ItemArray[0].ToString());
            Gender = char.Parse(dt1.Rows[0].ItemArray[1].ToString());
            Weight = decimal.Parse(dt1.Rows[0].ItemArray[2].ToString());
            HHeight = decimal.Parse(dt1.Rows[0].ItemArray[3].ToString());
        }
        private void GetTWT()
        {
            DataTable dt = Banco.dql($"Select N_WEIGHT from tb_targetweight where T_USERNAME='{Global.name}'");
            if (dt.Rows.Count > 0) { Banco.dml($"Delete from tb_targetweight where T_USERNAME='{Global.name}'"); }

            if (TW == 0) { return; }
            if (Goal == 'B')
            {

                for (decimal i = Weight; i <= TW; i += 0.5m)
                {
                    Banco.dml($"Insert into tb_targetweight (N_WEIGHT, N_CALORIES, N_PROTEIN, N_CARBS, N_FAT, T_USERNAME) VALUES('{i}', '{Math.Round(GetCalories(i))}', '{GetMacritos(GetCalories(i), i, 'P')}', '{GetMacritos(GetCalories(i), i, 'C')}', '{GetMacritos(GetCalories(i), i, 'F')}', '{Global.name}')");

                }
            }
            else if (Goal == 'C')
            {
                for (decimal i = Weight; i >= TW; i -= 0.5m)
                {
                    Banco.dml($"Insert into tb_targetweight (N_WEIGHT, N_CALORIES, N_PROTEIN, N_CARBS, N_FAT, T_USERNAME) VALUES('{i}', '{Math.Round(GetCalories(i))}', '{GetMacritos(GetCalories(i), i, 'P')}', '{GetMacritos(GetCalories(i), i, 'C')}', '{GetMacritos(GetCalories(i), i, 'F')}', '{Global.name}')");
                }
            }

        }
        private decimal RoundCalories(decimal weight)
        {
            return Math.Round(GetCalories(weight));
        }
        private decimal GetMacritos(decimal calories, decimal weight, char Macro)
        {

            decimal Cprotein=0, Cfat=0, Ccarbs=0;
            decimal protein=0, fatsu=0, carbsu=0;
            protein = PI * weight;
            Cprotein = protein * 4m;
            Cfat = (FI / 100m) * calories;
            fatsu = Cfat / 9;
            Ccarbs = calories - (Cprotein + Cfat);
            carbsu = Ccarbs / 4;

            protein = Math.Round(protein, 1);
            carbsu = Math.Round(carbsu, 1);
            fatsu = Math.Round(fatsu, 1);
            if (Macro == 'P')
            {
                return protein;
            }
            else if (Macro == 'C')
            {
                return carbsu;
            }
            else
            {
                return fatsu;
            }

        }
        private decimal GetCalories(decimal weight)
        {
            decimal Surplus = 0.1m;
            decimal tdee = 0;
            


            BMR = Get1BMR(weight);
            tdee = BMR * BMRM;
            if (XP == 'B')
            {
                Surplus = 0.2m;
            }
            else if (XP == 'I')
            {
                Surplus = 0.15m;
            }
            else if (XP == 'A')
            {
                Surplus = 0.1m;
            }
            if (Goal == 'B')
            {
                decimal surpluss = tdee * Surplus;
                tdee = tdee + surpluss;
            }
            else if (Goal == 'C')
            {
                decimal surdowns = tdee * 0.1m;
                tdee = tdee - surdowns;
            }
            return tdee;
        }

        private decimal Get1BMR(decimal weight)
        {
            if (Gender == 'M') //Male
            {
                return (10m * weight) + (6.25m * HHeight) - (5m * Age) + 5m;
            }
            else //Female
            {
                return (10m * weight) + (6.25m * HHeight) - (5m * Age) - 161m;
            }
        }
        
    }
}
