using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Academy
{
    public partial class FES_ASDAY : Form
    {
        int dayi;
        FES_ASYNC fes1;
        string workout;
        string time;
        bool save = false;
        bool first = false;
        Label Senderu;

        public FES_ASDAY(int day1, FES_ASYNC fes, string wok, string tim)
        {
            InitializeComponent();
            dayi = day1;
            fes1 = fes;
            workout = wok;
            time = tim;
            if (workout != null)
            {
                save = true;
            }
        }
        private void CBReset()
        {
            CB_Workout.Items.Clear();
            CB_Time.Items.Clear();
            CB_Workout.Items.Add("Select Workout");
            CB_Time.Items.Add("Select Time");
            CB_Workout.SelectedItem = "Select Workout";
            CB_Time.SelectedItem = "Select Time";

        }
        private void CBLoad()
        {

            DataTable dt = Banco.dql($"Select WName as 'Workout' from Default2 where Username = '{Global.name}' and Info = 'mainwork';");
            if (dt.Rows.Count > 0) // adicionar Workouts à ComboBox
            {
                CB_Workout.Items.Clear();
                for (int v = 0; v < dt.Rows.Count; v++)
                {
                    CB_Workout.Items.Add(dt.Rows[v].ItemArray[0].ToString());
                }
            }

            DataTable dt1 = Banco.dql($@"Select T_HORARIO as 'Time' from tb_time ");
            if (dt1.Rows.Count > 0) // adicionar Workouts à ComboBox
            {
                CB_Time.Items.Clear();
                for (int v = dt1.Rows.Count - 1; v >= 0; v--)
                {
                    CB_Time.Items.Add(dt1.Rows[v].ItemArray[0].ToString().Remove(5));
                }
            }

            if (save && time != null && workout != null)
            {

                if (!CB_Time.Items.Contains(time))
                {
                    Banco.MError("Invalid time for workout.");
                    this.Close();
                    return;
                }
                if (!CB_Workout.Items.Contains(workout))
                {
                    Banco.MError("Invalid Workout name.");
                    this.Close();
                    return;
                }
                CB_Time.SelectedItem = time;
                CB_Workout.SelectedItem = workout;
            }

        }
        private void CB_Workouts_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void CB_Time_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void FES_ASDAY_Load(object sender, EventArgs e)
        {
            if (save)
            {
                B_Add.Text = "Save Workout";
                first = true;
                CBLoad();
            }
            else { CBReset(); }
            LB_Day.Text = "Day "+dayi;
            if (sender is Label)
            {
                Senderu = sender as Label;
            }


        }

        public int GetDay(string wday)
        {

            if (wday == "Sunday") { return 0; }
            if (wday == "Monday") { return 1; }
            if (wday == "Tuesday") { return 2; }
            if (wday == "Wednesday") { return 3; }
            if (wday == "Thursday") { return 4; }
            if (wday == "Friday") { return 5; }
            if (wday == "Saturday") { return 6; }
            else { return 0; }
        }
        public int GetTime(string cu)
        {
            DataTable dt = Banco.dql($"SELECT N_IDTIME from tb_time where T_HORARIO='{cu}'");
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
        public int GetWorkout(string cu)
        {
            DataTable dt = Banco.dql($"Select ID from Default2 where WName = '{cu}' AND Username = '{Global.name}' AND Info = 'mainwork'");
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
        private void B_Add_Click(object sender, EventArgs e)
        {
            if (!save)
            {
                if (CB_Time.Text == "Select Time" || CB_Time.Text == null) { Banco.MError("Invalid Time."); return; }
                if (CB_Workout.Text == "Select Workout" || CB_Workout.Text == null) { Banco.MError("Invalid Workout."); return; }


                int numday = dayi;
                int ID_Time = GetTime(CB_Time.Text + ":00");
                int ID_Workout = GetWorkout(CB_Workout.Text);
                DataTable dt = Banco.dql($"SELECT T_USERNAME, N_INDEX, N_IDTIME, N_IDWORKOUT FROM tb_asyncschedule as tbs Where T_USERNAME = '{Global.name}' AND N_INDEX = '{numday}'");
                if (dt.Rows.Count > 0)
                {
                    Banco.MError("Day already assigned with a workout");
                    return;
                }
                Banco.dml($"INSERT INTO tb_asyncschedule (T_USERNAME, N_INDEX, N_IDTIME, N_IDWORKOUT) VALUES ('{Global.name}', '{numday}', '{ID_Time}','{ID_Workout}') ", "Workout added with Sucess!");
                this.Close();
            }
            else
            {
                if (CB_Time.Text == "Select Time" || CB_Time.Text == null) { Banco.MError("Invalid Time."); return; }
                if (CB_Workout.Text == "Select Workout" || CB_Workout.Text == null) { Banco.MError("Invalid Workout."); return; }


                int numday = dayi;
                int ID_Time = GetTime(CB_Time.Text + ":00");
                int ID_Workout = GetWorkout(CB_Workout.Text);

                Banco.dml($"UPDATE tb_asyncschedule SET N_IDTIME='{ID_Time}', N_IDWORKOUT='{ID_Workout}' WHERE T_USERNAME = '{Global.name}' AND N_INDEX = '{numday}'", "Workout saved with Sucess!");
                this.Close();
            }

        }

        private void CB_Time_DropDown(object sender, EventArgs e)
        {

        }

        private void CB_Time_MouseClick(object sender, MouseEventArgs e)
        {
            if (!first)
            {

                CBLoad();
                first = true;
            }
        }

        private void CB_Time_MouseHover(object sender, EventArgs e)
        {

        }

        private void CB_Time_Enter(object sender, EventArgs e)
        {

        }

        private void CB_Workout_MouseClick(object sender, MouseEventArgs e)
        {
            if (!first)
            {

                CBLoad();
                first = true;
            }
        }

        private void LB_Clear_Click(object sender, EventArgs e)
        {
            
            DataTable dt = Banco.dql($"SELECT T_USERNAME, N_INDEX, N_IDTIME, N_IDWORKOUT FROM tb_asyncschedule as tbs Where T_USERNAME = '{Global.name}' AND N_INDEX = '{dayi}'");
            if (dt.Rows.Count > 0)
            {
                DataTable da = Banco.dql($"Select WName from Default2 where ID = '{dt.Rows[0].ItemArray[3]}'");
                string workout = "" + da.Rows[0].ItemArray[0].ToString();
                Banco.dml($"DELETE from tb_asyncschedule where T_USERNAME = '{Global.name}' AND N_INDEX = '{dayi}'", $"'{workout}' has been Successfully removed.", $"There is no workout to remove.");
                foreach(Control b in fes1.Controls)
                {
                    if(b is Panel && (string)b.Tag==dayi.ToString())
                    {
                        Panel b1 = b as Panel;
                        foreach(Control c in b1.Controls)
                        {
                            Label c1 = c as Label;
                            if(c1.Name == "LB_Workout" + (dayi))
                            {
                                c1.Text = "Empty";
                            }
                            else if(c1.Name == "LB_TIME" + (dayi))
                            {
                                c1.Text = "--:--";
                            }
                        }
                    }
                }
                this.Close();
                

            }
            else
            {
                Banco.MError("There is no workout to remove.");
            }
        }
    }
}
