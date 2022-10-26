using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Academy
{
    public partial class FAnalytics : Form
    {
        public FAnalytics()
        {
            InitializeComponent();
        }

        int n_IDMEAL;
        int n_IDDAY;
        int IdealWeight;
        int BMI;
        bool Physique = false;
        Color Bad = Color.FromArgb(255, 0, 0); // < 25
        Color Ins = Color.FromArgb(255, 80, 0); // 25 <= Ins < 50
        Color Suf = Color.FromArgb(255, 215, 0);// 50 <= Suf < 75
        Color God = Color.FromArgb(221, 255, 0); // 75 <= God < 90 
        Color Exc = Color.FromArgb(0, 255, 0); // 90 <= Exc 
        Color Over = Color.SlateBlue;
        //6 cores - Bad, Insufficient, Sufficient, Good, Excelent, OverMax
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void B_Events_Click(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void FAnalytics_Load(object sender, EventArgs e)
        {
            ReloadMeals();
            CheckSets();
            GetCalMacros();
            GetMacrosAverage();
        }

        string Goal;
        char goal;
        decimal TDEE, PI, FI, BMRM, TW, PROTEIN, FAT, CARBS;

        
        private void GetCalMacros()
        {
            DataTable dt = Banco.dql($"SELECT N_PROTEINTAKE, N_FATTAKE,  N_TARGETWEIGHT, N_TDEE, T_GOAL  FROM tb_calmacros where T_USERNAME='{Global.name}' ");
            if (dt.Rows.Count > 0)
            {
                PI = decimal.Parse(dt.Rows[0].ItemArray[0].ToString());
                FI = decimal.Parse(dt.Rows[0].ItemArray[1].ToString());
                TW = decimal.Parse(dt.Rows[0].ItemArray[2].ToString());
                TDEE = decimal.Parse(dt.Rows[0].ItemArray[3].ToString());
                goal = char.Parse(dt.Rows[0].ItemArray[4].ToString());
                Goal = GetDBGoals(goal);
                GetMacros();
                LB_CMCarbs1.Text = $"Carbs - [{Math.Round(CARBS, 1).ToString()}g]";
                LB_CMProtein1.Text = $"Protein - [{Math.Round(PROTEIN,1).ToString()}g]";
                LB_CMFat1.Text = $"Fats - [{Math.Round(FAT, 1).ToString()}g]";
                LB_CMCalories1.Text = $"Calories - [{Math.Round(TDEE, 0).ToString()}]";

                LB_CMCarbs2.Text = $"Carbs - [{Math.Round((CARBS * 7),1).ToString()}g]";
                LB_CMProtein2.Text = $"Protein - [{Math.Round((PROTEIN * 7),1).ToString()}g]";
                LB_CMFat2.Text = $"Fats - [{Math.Round((FAT * 7),1).ToString()}g]";
                LB_CMCalories2.Text = $"Calories - [{Math.Round((TDEE * 7),1).ToString()}]";

                LB_Goal.Text = Goal;
            }
        }
        private void GetMacros()
        {
            DataTable dt = Banco.dql($"SELECT N_WEIGHT FROM tb_physique where T_USERNAME='{Global.name}'");
            if (dt.Rows.Count == 0) { return; }
            decimal Weight = decimal.Parse(dt.Rows[0].ItemArray[0].ToString());
            decimal Cprotein, Cfat, Ccarbs;
            PROTEIN = PI * Weight;
            Cprotein = PROTEIN * 4m;
            Cfat = (FI / 100m) * TDEE;
            FAT = Cfat / 9;
            Ccarbs = TDEE - (Cprotein + Cfat);
            CARBS = Ccarbs / 4;

        }
        private string GetDBGoals(char goal)
        {

            if (goal == 'B')
            {
                return "Bulking";
            }
            else
            if (goal == 'R')
            {
                return "Recomp";
            }
            else
            if (goal == 'C')
            {
                return "Cutting";
            }
            else
            {
                return null;
            }
        }


        private string CalculateIWeight(decimal cm, string gender)
        {
            decimal Weight;
            if (gender == "M") {
                Weight = 50m + (0.91m * (cm - 152.4m));
            } else
            {
                Weight = 45.5m + (0.91m * (cm - 152.4m));
            }
            return (Math.Round(Weight, 2)).ToString();
        }
        private string CalculateBMI(decimal cm, decimal Weight)
        {

            decimal cm2 = cm * cm;
            decimal BMI = (Weight / cm2);
            string bmi = (Math.Round(BMI, 1)).ToString();

            return bmi;

        }

        private void CheckSets()
        {
            DataTable dt = Banco.dql($"SELECT N_AGE, N_HEIGHT, N_WEIGHT, T_GENDER FROM tb_physique where T_USERNAME='{Global.name}'");
            if (dt.Rows.Count > 0) {
                B_SetPhy.Text = "Edit Physique";
                string Age = dt.Rows[0].ItemArray[0].ToString();
                string gender = dt.Rows[0].ItemArray[3].ToString();
                decimal Height = decimal.Parse(dt.Rows[0].ItemArray[1].ToString());
                decimal Weight = decimal.Parse(dt.Rows[0].ItemArray[2].ToString());
                string BMI = CalculateBMI((Height / 100), Weight);
                string IWeight = CalculateIWeight(Height, gender);

                LB_ValueAge.Text = Age;
                if (gender == "M") { LB_ValueGender.Text = "Male"; } else { LB_ValueGender.Text = "Female"; }
                LB_ValueHeight.Text = Height + " cm";
                LB_ValueWeight.Text = Weight.ToString() + " kg";
                LB_ValueBMI.Text = BMI;
                LB_ValueIdealWeight.Text = IWeight + " kg";

                decimal bmi = decimal.Parse(BMI);
                if (bmi < 16) { LB_BMIType.Text = "- Severe Thinness"; LB_BMIType.ForeColor = Bad; }
                else if (16 <= bmi && bmi < 17) { LB_BMIType.Text = "- Moderate Thinness"; LB_BMIType.ForeColor = Ins; }
                else if (17 <= bmi && bmi < 18) { LB_BMIType.Text = "- Mild Thinness"; LB_BMIType.ForeColor = Ins; }
                else if (18 <= bmi && bmi < 25) { LB_BMIType.Text = "- Normal"; LB_BMIType.ForeColor = Exc; }
                else if (25 <= bmi && bmi < 30) { LB_BMIType.Text = "- Overweight"; LB_BMIType.ForeColor = Ins; }
                else if (30 <= bmi && bmi < 35) { LB_BMIType.Text = "- Obese Class I"; LB_BMIType.ForeColor = Ins; }
                else if (35 <= bmi && bmi < 40) { LB_BMIType.Text = "- Obese Class II"; LB_BMIType.ForeColor = Bad; }
                else if (40 <= bmi) { LB_BMIType.Text = "- Obese Class III"; LB_BMIType.ForeColor = Bad; }

                decimal ouncesConstat = 0.029573529562462m;
                LB_ValueWIntake.Text = (Math.Round((Weight * ouncesConstat), 2)).ToString() + " L/Day";


                Physique = true;
            }
            else
            {
                Physique = false;
            }
            DataTable dt1 = Banco.dql($"SELECT T_USERNAME FROM tb_calmacros where T_USERNAME='{Global.name}'");
            if (dt1.Rows.Count > 0) { B_SetMacros.Text = "Edit Goal"; }
        }
        private void B_Schedule_Click(object sender, EventArgs e)
        {
            FAEI fas = new FAEI();
            fas.ShowDialog();
            ReloadMeals();
            CheckSets();
            GetCalMacros();
            GetMacrosAverage();

        }
        private void ReloadMeals()
        {
            DataTable dl = Banco.dql($"Select N_MealDays from tb_users where T_Username = '{Global.name}' ");
            NUP_MealDays.Value = int.Parse(dl.Rows[0].ItemArray[0].ToString());
            MealDaysSelect(NUP_MealDays.Value);
        }
        private void ChooseLabel(Control obs, bool Enabled)
        {
            foreach (Control obs1 in obs.Controls)
            {
                obs1.Text = "--:--";
            }
            foreach (Control obs1 in obs.Controls)
            {
                string obs1_tag = (string)obs1.Tag;
                GetIDs(obs1_tag);
                string LabelType = obs1_tag.Remove(0, 2); //25T -> T

                if (Enabled)
                {
                    if (LabelType == "T") // Time Label
                    {

                        DataTable dt = Banco.dql($"SELECT N_IDTIME, T_NAME from tb_meals WHERE T_USERNAME='{Global.name}' AND N_IDDAY = '{n_IDDAY}' AND N_IDMEAL = '{n_IDMEAL}' ");

                        if (dt.Rows.Count == 0) { obs1.Text = "--:--"; return; }
                        DataTable dt1 = Banco.dql($"SELECT T_HORARIO from tb_time WHERE N_IDTIME ='{dt.Rows[0].ItemArray[0].ToString()}'");
                        obs1.Text = (dt1.Rows[0].ItemArray[0].ToString()).Remove(5);
                    }
                    else if (LabelType == "D") // Meal Label
                    {
                        DataTable dt = Banco.dql($"SELECT T_NAME from tb_meals WHERE T_USERNAME='{Global.name}' AND N_IDDAY = '{n_IDDAY}' AND N_IDMEAL = '{n_IDMEAL}' ");
                        if (dt.Rows.Count == 0) { obs1.Text = "Empty"; return; }
                        obs1.Text = dt.Rows[0].ItemArray[0].ToString();
                    }
                }
                else
                {
                    if (LabelType == "D")
                    {
                        obs1.Text = "Empty";
                    }
                    else if (LabelType == "T")
                    {

                        obs1.Text = "--:--";
                    }
                }
            }
        }
        private void MealDaysSelect(decimal nday)
        {
            int Nday = Convert.ToInt32(nday);
            switch (Nday)
            {
                case 2:
                    foreach (Control obs in this.P_MealP.Controls)
                    {
                        string obs_Tag = obs.Tag.ToString();
                        if (obs_Tag.Length != 2) { return; }
                        int day = int.Parse(obs_Tag.Remove(0, 1));
                        if (day > 2)
                        {
                            ChooseLabel(obs, false);
                            obs.Enabled = false;
                        } else
                        {
                            ChooseLabel(obs, true);
                            obs.Enabled = true;
                        }
                    }
                    break;
                case 3:
                    foreach (Control obs in this.P_MealP.Controls)
                    {
                        string obs_Tag = obs.Tag.ToString();
                        if (obs_Tag.Length != 2) { return; }
                        int day = int.Parse(obs_Tag.Remove(0, 1));
                        if (day > 3)
                        {
                            ChooseLabel(obs, false);
                            obs.Enabled = false;
                        }
                        else
                        {
                            ChooseLabel(obs, true);
                            obs.Enabled = true;
                        }
                    }
                    break;
                case 4:
                    foreach (Control obs in this.P_MealP.Controls)
                    {
                        string obs_Tag = obs.Tag.ToString();
                        if (obs_Tag.Length != 2) { return; }
                        int day = int.Parse(obs_Tag.Remove(0, 1));
                        if (day > 4)
                        {
                            ChooseLabel(obs, false);
                            obs.Enabled = false;
                        }
                        else
                        {
                            ChooseLabel(obs, true);
                            obs.Enabled = true;
                        }
                    }
                    break;
                case 5:
                    foreach (Control obs in this.P_MealP.Controls)
                    {
                        string obs_Tag = obs.Tag.ToString();
                        if (obs_Tag.Length != 2) { return; }
                        int day = int.Parse(obs_Tag.Remove(0, 1));
                        if (day > 5)
                        {
                            ChooseLabel(obs, false);
                            obs.Enabled = false;
                        }
                        else
                        {
                            obs.Enabled = true;
                            ChooseLabel(obs, true);
                        }
                    }
                    break;
                case 6:
                    foreach (Control obs in this.P_MealP.Controls)
                    {
                        string obs_Tag = obs.Tag.ToString();
                        if (obs_Tag.Length != 2) { return; }
                        int day = int.Parse(obs_Tag.Remove(0, 1));
                        if (day > 6)
                        {
                            ChooseLabel(obs, false);
                            obs.Enabled = false;
                        }
                        else
                        {
                            ChooseLabel(obs, true);
                            obs.Enabled = true;
                        }
                    }
                    break;

            }
        }
        private void NUP_MealDays_ValueChanged(object sender, EventArgs e)
        {
            Banco.dml($"Update tb_users SET N_MealDays = '{NUP_MealDays.Value}' where T_Username = '{Global.name}' ");
            MealDaysSelect(NUP_MealDays.Value);
            ReloadMeals();
            CheckSets();
            GetCalMacros();
            GetMacrosAverage();

        }
        private void GetIDs(string Tag)
        {

            n_IDDAY = int.Parse(Tag.Remove(1));    // 01T - DML (DAY - MEAL - LABEL) 
            n_IDMEAL = int.Parse((Tag.Remove(0, 1)).Remove(1)); // 012 (3 total)
        }

        private void DayClick(object sender, EventArgs e)
        {
            if (sender is Panel)
            {
                Panel panel = (Panel)sender;
                GetIDs((string)panel.Tag + "D");

            }
            else if (sender is Label)
            {
                Label label = (Label)sender;
                GetIDs((string)label.Tag);

            }
            FMS fms = new FMS(n_IDMEAL, n_IDDAY);
            fms.ShowDialog();
            ReloadMeals();
            CheckSets();
            GetCalMacros();
            GetMacrosAverage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Physique) { Banco.MInformation("Insert your physique first, to unlock this feature."); return; }
            if (goal == 'R'){Banco.MInformation("Choose a goal other than 'Recomp' to unlock this feature."); return;}
            if (TW==0){Banco.MInformation("Select your target weight to unlock this feature."); return;}
            FWT fwt = new FWT();
            fwt.ShowDialog();
            CheckSets();
            GetCalMacros();
            GetMacrosAverage();
        }

        private void DayMacro(object sender, EventArgs e)
        {
            Label senderu = sender as Label;
            int Nday = Convert.ToInt32(senderu.Tag.ToString());
            int MealPDay = int.Parse(NUP_MealDays.Value.ToString());
            FAM fam = new FAM(Nday, MealPDay);
            fam.ShowDialog();

        }

        private void GetMacrosAverage()
        {
            decimal Carbs = 0, Protein = 0, Fat = 0, Calories = 0, Pcar = 0, Ppro = 0, Pfat = 0, Pcal = 0;
            int i = 0;
            DataTable dl = Banco.dql($"Select tbms.N_IDMEAL, tbms.N_CARBS as 'Carbs', tbms.N_PROTEIN as 'Protein', tbms.N_FAT as 'Fats', tbms.N_CALORIES as 'Calories' from tb_meals as tbms Where tbms.T_USERNAME='{Global.name}' and tbms.N_IDDAY ='{i}'");
            
            if (dl.Rows.Count == 0) { return; }
            for (i = 0; i <= 6; i++)
            {
                foreach (DataRow v in dl.Rows)
                {
                    int MealPDay = Convert.ToInt32(NUP_MealDays.Value);
                    int N_IDMEAL = int.Parse(v.ItemArray[0].ToString());
                    if (N_IDMEAL <= MealPDay)
                    {
                        Carbs += decimal.Parse(v.ItemArray[1].ToString());
                        Protein += decimal.Parse(v.ItemArray[2].ToString());
                        Fat += decimal.Parse(v.ItemArray[3].ToString());
                        Calories += decimal.Parse(v.ItemArray[4].ToString());
                    }
                }
            }


            GetMacros();
            DataTable dt = Banco.dql($"SELECT N_WEIGHT FROM tb_physique where T_USERNAME='{Global.name}'");
            if (dt.Rows.Count == 0) { return; }

            Pcar = (Carbs / (CARBS*7)) * 100;
            Pcar = Math.Round(Pcar, 0);
            Pfat = (Fat / (FAT*7)) * 100;
            Pfat = Math.Round(Pfat, 0);
            Ppro = (Protein / (PROTEIN*7)) * 100;
            Ppro = Math.Round(Ppro, 0);
            Pcal = (Calories / (TDEE*7)) * 100;
            Pcal = Math.Round(Pcal, 0);

            Carbs = Math.Round(Carbs, 1);
            Protein = Math.Round(Protein, 1);
            Fat = Math.Round(Fat, 1);
            Calories = Math.Round(Calories, 0);
            LB_MCarbs2.Text = $"Carbs - [{Carbs.ToString()}g]";
            LB_MProtein2.Text = $"Protein - [{Protein.ToString()}g]";
            LB_MFat2.Text = $"Fat - [{Fat.ToString()}g]";
            LB_MCalories2.Text = $"Calories - [{Calories.ToString()}]";

            LB_PM5.Text = Pcar.ToString() + "%";
            LB_PM5.ForeColor = GetColor(Convert.ToInt32(Pcar));
            LB_PM6.Text = Ppro.ToString() + "%";
            LB_PM6.ForeColor = GetColor(Convert.ToInt32(Ppro));
            LB_PM7.Text = Pfat.ToString() + "%";
            LB_PM7.ForeColor = GetColor(Convert.ToInt32(Pfat));
            LB_PM8.Text = Pcal.ToString() + "%";
            LB_PM8.ForeColor = GetColor(Convert.ToInt32(Pcal));

          


             

            Carbs = Carbs / 7;
            Protein = Protein / 7;
            Fat = Fat / 7;
            Calories = Calories / 7;


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

            Carbs = Math.Round(Carbs, 1);
            Protein = Math.Round(Protein, 1);
            Fat = Math.Round(Fat, 1);
            Calories = Math.Round(Calories, 0);

            LB_MCarbs1.Text = $"Carbs - [{Carbs.ToString()}g]";
            LB_MProtein1.Text = $"Protein - [{Protein.ToString()}g]";
            LB_MFat1.Text = $"Fat - [{Fat.ToString()}g]";
            LB_MCalories1.Text = $"Calories - [{Calories.ToString()}]";


           

        }

        private void LB_TPhysique_Click(object sender, EventArgs e)
        {

        }

        private void B_Reset_Click(object sender, EventArgs e)
        {
            if (!Banco.MQuestion("Are you sure you want to delete this exercise?")) { return; }
            Banco.dml($"Delete from tb_meals where T_USERNAME='{Global.name}'");
            Banco.dml($"Delete from tb_mealstuff where T_USERNAME='{Global.name}'");
            ReloadMeals();
            CheckSets();
            GetCalMacros();
            GetMacrosAverage();
        }

        private Color GetColor(int Percentage)
        {
            /* Color Bad = Color.FromArgb(255, 0, 0); // < 25
             Color Ins = Color.FromArgb(255, 80, 0); // 25 <= Ins < 50
             Color Suf = Color.FromArgb(255, 215, 0);// 50 <= Suf < 75
             Color God = Color.FromArgb(221, 255, 0); // 75 <= God < 90 
             Color Exc = Color.FromArgb(0, 255, 0); // 90 <= Exc 

             */
            if (Percentage < 25 )
            {
                return Bad;
            }
            else if (Percentage >= 25 && Percentage < 50)
            {
                return Ins;
            }else if(Percentage >= 50 && Percentage < 75)
            {
                return Suf;
            }else if(Percentage >= 75 && Percentage < 90)
            {
                return God;
            }
            else if(Percentage >=90 && Percentage <= 100)
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void B_EditPhy_Click(object sender, EventArgs e)
        {
            FEP fep = new FEP();
            fep.ShowDialog();
            CheckSets();
            GetCalMacros();
            GetMacrosAverage();
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Print to PDF Meal Plan with Macros and Maybe all meal recipes?
        }

        private void B_SetMacros_Click(object sender, EventArgs e)
        {
            if (!Physique) {Banco.MInformation("Insert your physique first, to unlock this feature."); return; }
            FACM2 fACM = new FACM2();
            fACM.ShowDialog();
            GetCalMacros();
        }
    }
}
