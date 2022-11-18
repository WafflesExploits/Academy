using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iText.Svg.SvgConstants;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Academy
{
    public partial class FACM2 : Form
    {
        public FACM2()
        {
            InitializeComponent();
        }
        int FirstTime1 = 1, FirstTime2 = 1, FirstTime3=1, Update=0, Age;
        decimal FI, PI, BMRM, BMR, Height, Weight, TDEE, CARBS, PROTEIN, FAT;
        char Goal, Gender, XP;

        private void GetPhysique()
        {
            DataTable dt = Banco.dql($"SELECT N_AGE, N_HEIGHT, N_WEIGHT, T_GENDER FROM tb_physique where T_USERNAME='{Global.name}'");
            if (dt.Rows.Count > 0)
            {
                 Age = int.Parse(dt.Rows[0].ItemArray[0].ToString());
                 Gender = Char.Parse(dt.Rows[0].ItemArray[3].ToString());
                 Height = decimal.Parse(dt.Rows[0].ItemArray[1].ToString());
                 Weight = decimal.Parse(dt.Rows[0].ItemArray[2].ToString());
            }
        }
        private void CB_Goal_Click(object sender, EventArgs e)
        {
            
        }
        private void FACM_Load(object sender, EventArgs e)
        {
            CB_Goal.SelectedItem = "Select a Goal";
            CB_AL.SelectedItem = "Select a Level";
            CB_XP.SelectedItem = "Select a Level";
            GetPhysique();
            GetCalMacros();
        }
        private void GetCalMacros()
        {
            DataTable dt = Banco.dql($"SELECT T_GOAL,N_PROTEINTAKE, N_FATTAKE, N_BMRM, N_TARGETWEIGHT, N_TDEE, T_XP  FROM tb_calmacros where T_USERNAME='{Global.name}' ");
            if (dt.Rows.Count > 0)
            {
                Update = 1;
                Goal = char.Parse(dt.Rows[0].ItemArray[0].ToString());
                GetDBGoals(Goal);
                XP = char.Parse(dt.Rows[0].ItemArray[6].ToString());
                GetDBXP(XP);
                TDEE = decimal.Parse(dt.Rows[0].ItemArray[5].ToString());
                PI = decimal.Parse(dt.Rows[0].ItemArray[1].ToString());
                FI = decimal.Parse(dt.Rows[0].ItemArray[2].ToString());
                BMRM = decimal.Parse(dt.Rows[0].ItemArray[3].ToString());
                NUP_Weight.Value = decimal.Parse(dt.Rows[0].ItemArray[4].ToString());
                GetDBSwitchGoals(Goal);
                
                



                LB_Wkg.Enabled = true;
                CB_AL.Enabled = true;
                NUP_Weight.Enabled = true;
                LB_PIMax.Visible = true;
                LB_PIMin.Visible = true;
                LB_FIMax.Visible = true;
                LB_FIMin.Visible = true;
                GetDBAL(BMRM);
                
                GetMacros();
                Update = 0;
            }
        }
        private void GetDBSwitchGoals(char goal) 
        {
            switch (goal)
            {
                case 'R':
                    TRB_PI.Maximum = 320;
                    TRB_PI.Minimum = 180;
                    LB_PIMax.Text = "3.2";
                    LB_PIMin.Text = "1.8";

                    TRB_FI.Maximum = 25;
                    TRB_FI.Minimum = 20;
                    LB_FIMax.Text = "25%";
                    LB_FIMin.Text = "20%";

                    TRB_FI.Enabled = true;
                    TRB_PI.Enabled = true;
                    TRB_FI.Value = Convert.ToInt32(FI);
                    TRB_PI.Value = Convert.ToInt32(PI*100);
                  
                    LB_FI.Text = $"Fat Intake - [{FI}%]";
                    LB_PI.Text = $"Protein Intake - [{PI}g/kg]";
                    break;
                case 'B':

                    TRB_PI.Maximum = 320;
                    TRB_PI.Minimum = 160;
                    LB_PIMax.Text = "3.2";
                    LB_PIMin.Text = "1.6";

                    TRB_FI.Maximum = 25;
                    TRB_FI.Minimum = 20;
                    LB_FIMax.Text = "25%";
                    LB_FIMin.Text = "20%";

                    TRB_FI.Enabled = true;
                    TRB_PI.Enabled = true;
                    TRB_FI.Value = Convert.ToInt32(FI);
                    TRB_PI.Value = Convert.ToInt32(PI * 100);
                    LB_FI.Text = $"Fat Intake - [{FI}%]";
                    LB_PI.Text = $"Protein Intake - [{PI}g/kg]";
                    break;
                case 'C':
                    TRB_PI.Maximum = 270;
                    TRB_PI.Minimum = 180;
                    LB_PIMax.Text = "2.7";
                    LB_PIMin.Text = "1.8";

                    TRB_FI.Enabled = false;
                    TRB_PI.Enabled = true;
                    TRB_FI.Value = Convert.ToInt32(FI);
                    TRB_PI.Value = Convert.ToInt32(PI * 100);
                    LB_FI.Text = $"Fat Intake - [{FI}%]";
                    LB_PI.Text = $"Protein Intake - [{PI}g/kg]";
                    break;
            }
        }
        private void GetDBXP(char XP) 
        {



            if (XP == 'B')
            {
                CB_XP.SelectedItem = "Beginner (<2 years)";
            }else if(XP == 'I')
            {
                CB_XP.SelectedItem = "Intermediate (2-5 years)";
            }
            else if (XP == 'A')
            {
                CB_XP.SelectedItem = "Advanced (>5 years)";
            }
        }
        private void GetDBAL(decimal BMRM)
        {
            CB_AL.Items.Remove("Select a Level");
            if (BMRM == 1.2m)
            {
                CB_AL.SelectedItem = "Sedentary little to no exercise";
            }else
            if (BMRM == 1.375m)
            {
                CB_AL.SelectedItem = "Light exercise 1-3 days/week";
            }
            else
            if (BMRM == 1.465m)
            {
                CB_AL.SelectedItem = "Moderate exercise 3-4 days/week";
            }
            else
            if (BMRM == 1.55m)
            {
                CB_AL.SelectedItem = "Intense exercise 4-5 days/week";
            }
            else
            if (BMRM == 1.725m)
            {
                CB_AL.SelectedItem = "Very Intense exercise 6-7 days/week";
            }
            else
            if (BMRM == 1.9m)
            {
                CB_AL.SelectedItem = "Extra Intense exercise 7 days/week";
            }
        }
        private void GetDBGoals(char goal)
        {
            Goal = goal;
            if(Goal == 'B')
            {
                CB_Goal.SelectedItem = "Bulking";
            }else
            if (Goal == 'R')
            {
                CB_Goal.SelectedItem = "Recomp";
                NUP_Weight.Enabled = false;
            }else
            if (Goal == 'C')
            {
                CB_Goal.SelectedItem = "Cutting";
            }

        }
        private void TRB_PI_Scroll(object sender, EventArgs e)
        {
            decimal Pi = TRB_PI.Value;
            PI = Pi / 100;
            LB_PI.Text = $"Protein Intake - [{PI.ToString()}g/kg]";
            if(CB_AL.SelectedItem != "Select a Level")
            {
                GetMacros();
            }
        }

        private void B_Save_Click(object sender, EventArgs e)
        {
            if(CB_AL.SelectedItem == "Select a Level") {Banco.MError("Select a Activity Level before saving."); return; }
            DataTable dt = Banco.dql($"SELECT T_GOAL FROM tb_calmacros where T_USERNAME='{Global.name}' ");
            if(NUP_Weight.Value == 0) { }
            else if (Goal == 'C') { if (NUP_Weight.Value >= Weight) {Banco.MError("Target weight needs to be lower than your current weight when cutting."); return; } }
            else if (Goal == 'B') { if (NUP_Weight.Value <= Weight) { Banco.MError("Target weight needs to be higher than your current weight when cutting."); return; } }

            if (dt.Rows.Count > 0)
            {
                Banco.dml($"UPDATE tb_calmacros SET T_XP='{XP}',T_GOAL='{Goal}', N_PROTEINTAKE='{PI}', N_FATTAKE='{FI}', N_BMRM='{BMRM}', N_TARGETWEIGHT='{NUP_Weight.Value}', N_TDEE='{TDEE}' WHERE T_USERNAME ='{Global.name}'", "Calculated Macros have been saved.");
                GetTWT();
                this.Close();
                return;
            }
            Banco.dml($"INSERT INTO tb_calmacros (T_XP ,T_GOAL,N_PROTEINTAKE, N_FATTAKE, N_BMRM, N_TARGETWEIGHT, N_TDEE, T_USERNAME) VALUES ('{XP}','{Goal}','{PI}', '{FI}', '{BMRM}', '{NUP_Weight.Value}', '{TDEE}', '{Global.name}') ", "Calculated Macros have been saved.");
            //Weight Gain Table
            GetTWT();
            this.Close();
        }

        private void GetTWT()
        {
            DataTable dt = Banco.dql($"Select N_WEIGHT from tb_targetweight where T_USERNAME='{Global.name}'");
            if(dt.Rows.Count > 0) { Banco.dml($"Delete from tb_targetweight where T_USERNAME='{Global.name}'"); }
            
            decimal TW = NUP_Weight.Value;
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
        private decimal GetMacritos(decimal calories, decimal weight,char Macro) 
        {
            
            decimal Cprotein, Cfat, Ccarbs;
            decimal protein, fatsu, carbsu;
            protein = PI * weight;
            Cprotein = protein * 4m;
            Cfat = (FI / 100m) * calories;
            fatsu = Cfat / 9;
            Ccarbs = calories - (Cprotein + Cfat);
            carbsu = Ccarbs / 4;

            protein = Math.Round(protein, 1);
            carbsu = Math.Round(carbsu, 1);
            fatsu = Math.Round(fatsu, 1);
            if(Macro == 'P')
            {
                return protein;
            }else if(Macro == 'C')
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
            GetBMRM();


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
                return (10m * weight) + (6.25m * Height) - (5m * Age) + 5m;
            }
            else //Female
            {
               return (10m * weight) + (6.25m * Height) - (5m * Age) - 161m;
            }
        }

        private void GetBMR()
        {
            if (Gender == 'M') //Male
            {
                BMR = (10m * Weight) + (6.25m * Height) - (5m * Age) + 5m;
            }
            else //Female
            {
                BMR = (10m * Weight) + (6.25m * Height) - (5m * Age) - 161m;
            }
        }

        private void CB_XP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_XP.SelectedItem != "Select a Level" && FirstTime3 == 2) { CB_XP.Items.Remove("Select a Level"); FirstTime3 = 0; }
            else if (FirstTime3 == 0) { }
            else { FirstTime3 = 2; return; }
           
            if (CB_XP.SelectedItem == "Beginner (<2 years)")
            {
                XP = 'B';
            }else if(CB_XP.SelectedItem == "Intermediate (2-5 years)")
            {
                XP = 'I';
            }
            else if (CB_XP.SelectedItem == "Advanced (>5 years)")
            {
                XP = 'A';
            }
            if (CB_Goal.SelectedItem != "Select a Goal")
            {
                CB_AL.Enabled = true;
            }
            if (CB_AL.SelectedItem != "Select a Level")
            {
                GetTDEE();
                GetMacros();
            }
        }

        private void GetMacros()
        {
            decimal Cprotein, Cfat, Ccarbs;
            PROTEIN = PI * Weight;
            Cprotein = PROTEIN * 4m;
            Cfat = (FI / 100m) * TDEE;
            FAT = Cfat / 9;
            Ccarbs = TDEE - (Cprotein + Cfat);
            CARBS = Ccarbs / 4;

            PROTEIN = Math.Round(PROTEIN, 1);
            CARBS = Math.Round(CARBS, 1);
            FAT = Math.Round(FAT, 1);
            TDEE = Math.Round(TDEE, 0);
            LB_MDCarbs.Text = $"Carbs - [{CARBS.ToString()}g]";
            LB_MDProtein.Text = $"Protein - [{PROTEIN.ToString()}g]";
            LB_MDFats.Text = $"Fats - [{FAT.ToString()}g]";
            LB_MDCalories.Text = $"Calories - [{TDEE.ToString()}]";

            LB_MWCarbs.Text = $"Carbs - [{ (CARBS*7).ToString() }g]";
            LB_MWProtein.Text = $"Protein - [{(PROTEIN*7).ToString()}g]";
            LB_MWFat.Text = $"Fats - [{(FAT*7).ToString()}g]";
            LB_MWCalories.Text = $"Calories - [{(TDEE*7).ToString()}]";
        }
       
        private void GetGoal(string goal)
        {
            
            if(goal == "Recomp")
            {
                Goal = 'R';
            }else if(goal == "Bulking")
            {
                Goal = 'B';
            }
            else
            {
                Goal = 'C';
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CB_Goal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Goal.SelectedItem != "Select a Goal" && FirstTime1==2) { CB_Goal.Items.Remove("Select a Goal"); FirstTime1 = 0; }
            else if (FirstTime1 == 0) { } 
            else{ FirstTime1 = 2; return; }
            GetGoal(CB_Goal.Text);
            if (CB_XP.SelectedItem != "Select a Level")
            {  
                CB_AL.Enabled = true;
            }
            if (CB_AL.SelectedItem != "Select a Level" && Update == 0)
            {
                SwitchGoals(Goal);
            }
        }

        private void SwitchGoals(char goal)
        {
            switch (goal)
            {
                case 'R':
                    GetTDEE();
                    
                    TRB_PI.Maximum = 320;
                    TRB_PI.Minimum = 180;
                    LB_PIMax.Text = "3.2";
                    LB_PIMin.Text = "1.8";

                    TRB_FI.Maximum = 25;
                    TRB_FI.Minimum = 20;
                    LB_FIMax.Text = "25%";
                    LB_FIMin.Text = "20%";

                    NUP_Weight.Enabled = false;
                    TRB_FI.Enabled = true;
                    TRB_PI.Enabled = true;
                    TRB_FI.Value = 20;
                    FI = 20;
                    LB_FI.Text = $"Fat Intake - [{FI}%]";
                    PI = 1.8M;
                    LB_PI.Text = $"Protein Intake - [{PI}g/kg]";
                    GetMacros();
                    break;
                case 'B':
                    GetTDEE();
                    
                    TRB_PI.Maximum = 320;
                    TRB_PI.Minimum = 160;
                    LB_PIMax.Text = "3.2";
                    LB_PIMin.Text = "1.6";

                    TRB_FI.Maximum = 25;
                    TRB_FI.Minimum = 20;
                    LB_FIMax.Text = "25%";
                    LB_FIMin.Text = "20%";

                    NUP_Weight.Enabled = true;
                    TRB_FI.Enabled = true;
                    TRB_PI.Enabled = true;
                    TRB_FI.Value = 20;
                    TRB_PI.Value = 160;
                    FI = 20;
                    LB_FI.Text = $"Fat Intake - [{FI}%]";
                    PI = 1.6M;
                    LB_PI.Text = $"Protein Intake - [{PI}g/kg]";
                    GetMacros();
                    break;
                case 'C':
                    GetTDEE();
                    
                    TRB_PI.Maximum = 270;
                    TRB_PI.Minimum = 180;
                    LB_PIMax.Text = "2.7";
                    LB_PIMin.Text = "1.8";

                    NUP_Weight.Enabled = true;
                    TRB_FI.Enabled = false;
                    TRB_PI.Enabled = true;
                    TRB_FI.Value = 20;
                    FI = 20;
                    LB_FI.Text = $"Fat Intake - [{FI}%]";
                    PI = 1.8M;
                    LB_PI.Text = $"Protein Intake - [{PI}g/kg]";
                    GetMacros();
                    break;
            }
        }
        private void CB_AL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_AL.SelectedItem != "Select a Level" && FirstTime2 == 2) { CB_AL.Items.Remove("Select a Level"); FirstTime2 = 0; }
            else if (FirstTime2 == 0) { }
            else { FirstTime2 = 2; return; }
            if (Update == 0)
            {
                LB_Wkg.Enabled = true;
                NUP_Weight.Enabled = true;
                LB_PIMax.Visible = true;
                LB_PIMin.Visible = true;
                LB_FIMax.Visible = true;
                LB_FIMin.Visible = true;
                SwitchGoals(Goal);
                GetTDEE();
                GetMacros();
            }

        }

        private void GetTDEE()
        {
            decimal Surplus=0.1m;
            GetBMRM();
            GetBMR();
            TDEE = BMR * BMRM;
            if(XP == 'B')
            {
                Surplus = 0.2m;
            }else if(XP == 'I')
            {
                Surplus = 0.15m;
            }
            else if(XP == 'A')
            {
                Surplus = 0.1m;
            }
            if(Goal == 'B')
            {
                decimal surpluss = TDEE * Surplus;
                TDEE = TDEE + surpluss;
            }else if(Goal == 'C')
            {
                decimal surdowns = TDEE * 0.1m;
                TDEE = TDEE - surdowns;
            }

        }
        private void GetBMRM()
        {
            /*
                Sedentary little to no exercise
                Light exercise 1-3 days/week
                Moderate exercise 3-4 days/week
                Intense exercise 4-5 days/week
                Very Intense exercise 6-7 days/week
                Extra Intense exercise 7 days/week
             */
            string AL = CB_AL.SelectedItem.ToString();
            if(AL == "Sedentary little to no exercise")
            {
                BMRM = 1.2m;
            }
            else if (AL == "Light exercise 1-3 days/week")
            {
                BMRM = 1.375m;
            }
            else if(AL == "Moderate exercise 3-4 days/week")
            {
                BMRM = 1.465m;
            }
            else if(AL == "Intense exercise 4-5 days/week")
            {
                BMRM = 1.55m;
            }
            else if(AL == "Very Intense exercise 6-7 days/week")
            {
                BMRM = 1.725m;
            }
            else if(AL == "Extra Intense exercise 7 days/week")
            {
                BMRM = 1.9m;
            }
        }
        private void CB_Goal_SelectedValueChanged(object sender, EventArgs e)
        {
            
            
        }

        private void TRB_FI_Scroll(object sender, EventArgs e)
        {
            int Fi = TRB_FI.Value;
            FI = Fi;
            LB_FI.Text = $"Fat Intake - [{FI}%]";
            if (CB_AL.SelectedItem != "Select a Level")
            {
                GetMacros();
            }
        }
    }
}
