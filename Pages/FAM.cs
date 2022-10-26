using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Academy
{
    public partial class FAM : Form
    {
        int Nday, MealPDay;

        
        public FAM(int nday, int mealpday)
        {
            InitializeComponent();
            Nday = nday;
            MealPDay = mealpday;
        }
        decimal Carbs = 0, Protein = 0, Fat = 0, Calories = 0, CARBS, PROTEIN, FAT, TDEE;
        decimal PI = 0, FI = 0, TW = 0, goal = 0, Goal = 0;
        private void GetCalMacros() { 
        DataTable dt = Banco.dql($"SELECT N_PROTEINTAKE, N_FATTAKE,  N_TARGETWEIGHT, N_TDEE, T_GOAL  FROM tb_calmacros where T_USERNAME='{Global.name}' ");
            if (dt.Rows.Count > 0)
            {
                PI = decimal.Parse(dt.Rows[0].ItemArray[0].ToString());
                FI = decimal.Parse(dt.Rows[0].ItemArray[1].ToString());
                TW = decimal.Parse(dt.Rows[0].ItemArray[2].ToString());
                TDEE = decimal.Parse(dt.Rows[0].ItemArray[3].ToString());
                GetMacros();

            }
        }
        private void GetMacros()
        {
            DataTable dt = Banco.dql($"SELECT N_WEIGHT FROM tb_physique where T_USERNAME='{Global.name}'");
            decimal Weight = decimal.Parse(dt.Rows[0].ItemArray[0].ToString());
            decimal Cprotein, Cfat, Ccarbs;
            PROTEIN = PI * Weight;
            Cprotein = PROTEIN * 4m;
            Cfat = (FI / 100m) * TDEE;
            FAT = Cfat / 9;
            Ccarbs = TDEE - (Cprotein + Cfat);
            CARBS = Ccarbs / 4;

           
        }
        private void FAM_Load(object sender, EventArgs e)
        {
            GetCalMacros();
            decimal Pcar = 0, Pfat = 0, Ppro = 0, Pcal = 0;
            Carbs = 0;
            Protein = 0;
            Fat = 0;
            Calories = 0;
            DataTable dl = Banco.dql($"Select tbms.N_IDMEAL, tbms.N_CARBS as 'Carbs', tbms.N_PROTEIN as 'Protein', tbms.N_FAT as 'Fats', tbms.N_CALORIES as 'Calories' from tb_meals as tbms Where tbms.T_USERNAME='{Global.name}' and tbms.N_IDDAY ='{Nday}'");
            foreach (DataRow v in dl.Rows)
            {
                int N_IDMEAL = int.Parse(v.ItemArray[0].ToString());
                if (N_IDMEAL <= MealPDay)
                {
                    Carbs += decimal.Parse(v.ItemArray[1].ToString());
                    Protein += decimal.Parse(v.ItemArray[2].ToString());
                    Fat += decimal.Parse(v.ItemArray[3].ToString());
                    Calories += decimal.Parse(v.ItemArray[4].ToString());
                    
                }
            }
            
            
            Pcar = (Carbs / CARBS) * 100;
            Pcar = Math.Round(Pcar, 0);
            Pfat = (Fat / FAT) * 100;
            Pfat = Math.Round(Pfat, 0);
            Ppro = (Protein / PROTEIN) * 100;
            Ppro = Math.Round(Ppro, 0);
            Pcal = (Calories / TDEE) * 100;
            Pcal = Math.Round(Pcal, 0);

            LB_PM1.Text = Pcar.ToString() + "%";
            LB_PM1.ForeColor = GetColor(Convert.ToInt32(Pcar));
            LB_PM2.Text = Ppro.ToString() + "%";
            LB_PM2.ForeColor = GetColor(Convert.ToInt32(Ppro));
            LB_PM3.Text = Pfat.ToString() + "%";
            LB_PM3.ForeColor = GetColor(Convert.ToInt32(Pfat));
            LB_PM4.Text = Pcal.ToString() + "%";
            LB_PM4.ForeColor = GetColor(Convert.ToInt32(Pcal));



            LB_Carbs.Text = $"Carbs - [{Math.Round(Carbs,1).ToString()}g]";
            LB_Protein.Text = $"Protein - [{Math.Round(Protein,1).ToString()}g]";
            LB_Fat.Text = $"Fat - [{Math.Round(Fat,1).ToString()}g]";
            LB_Calories.Text = $"Calories - [{Math.Round(Calories,0).ToString()}]";
        }
        private Color GetColor(int Percentage)
        {
             Color Bad = Color.FromArgb(255, 0, 0); // < 25
             Color Ins = Color.FromArgb(255, 80, 0); // 25 <= Ins < 50
             Color Suf = Color.FromArgb(255, 215, 0);// 50 <= Suf < 75
             Color God = Color.FromArgb(221, 255, 0); // 75 <= God < 90 
             Color Exc = Color.FromArgb(0, 255, 0); // 90 <= Exc 
             Color Over = Color.SlateBlue;
            if (Percentage < 25)
            {
                return Bad;
            }
            else if (Percentage >= 25 && Percentage < 50)
            {
                return Ins;
            }
            else if (Percentage >= 50 && Percentage < 75)
            {
                return Suf;
            }
            else if (Percentage >= 75 && Percentage < 90)
            {
                return God;
            }
            else if (Percentage >= 90 && Percentage <= 100)
            {
                return Exc;
            }
            else if (Percentage >= 101 && Percentage < 115)
            {
                return Suf;
            }
            else
            {
                return Over;
            }
        }
    }
}
