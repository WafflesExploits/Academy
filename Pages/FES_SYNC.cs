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
    public partial class FES_SYNC : Form
    {
        string dayw;
        FES_DAY fesD;
        bool empty=false;
        string workout;
        string time;
        public FES_SYNC()
        {
            InitializeComponent();
        }

        private void P_Sunday_Paint(object sender, PaintEventArgs e)
        {

        }

        public void CheckDays()
        {
            for (int i = 0; i < 7; i++){
                DataTable dt = Banco.dql($"SELECT T_USERNAME, N_IDDAY, N_IDTIME, N_IDWORKOUT FROM tb_schedule as tbs Where T_USERNAME = '{Global.name}' AND N_IDDAY = '{i}'");
                if(dt.Rows.Count > 0)
                {
                    foreach (Control b in this.Controls)
                    {
                        if(!(b is Panel))
                        {
                            return;
                        }
                        Panel b1 = b as Panel;
                        foreach (Control c in b1.Controls)
                        {
                            if (c is Label)
                            {
                                
                                Label v = c as Label;
                                if (v.Name == "LB_Workout" + i.ToString())
                                {
                                   
                                    int idw = Convert.ToInt32(dt.Rows[0].ItemArray[3].ToString());
                                    DataTable dtw = Banco.dql($"SELECT WName from Default2 where ID = '{idw}' ");
                                    v.Text = dtw.Rows[0].ItemArray[0].ToString();
                                }
                                else if (v.Name == "LB_TIME" + i.ToString())
                                {
                                    
                                    int idt = int.Parse(dt.Rows[0].ItemArray[2].ToString());
                                    DataTable dtt = Banco.dql($"SELECT T_HORARIO from tb_time where N_IDTIME = '{idt}' ");
                                    string time = dtt.Rows[0].ItemArray[0].ToString();
                                    v.Text = time.Remove(5);
                                }

                            }
                        }
                    }
                }
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

        private void AddDay(object sender, EventArgs e)
        {
            
            if (sender is Panel)
            {
                Panel day = sender as Panel;
                dayw = (string)day.Tag;
            }
            else if (sender is Label)
            {
                Label day = sender as Label;
                if (day.Name == "LB_TIME0" || day.Name == "LB_TIME1" || day.Name == "LB_TIME2" || day.Name == "LB_TIME3" || day.Name == "LB_TIME4" || day.Name == "LB_TIME5" || day.Name == "LB_TIME6")
                {
                    string day2 = (string)day.Tag;
                    dayw = day2.Remove(day2.Length - 1);
                }
                else
                {
                    dayw = (string)day.Tag;
                }
            }
            
            int numday = GetDay(dayw);
            foreach(Control b in this.Controls)
            {
                foreach(Control v in b.Controls)
                {
                    if(v is Label && v.Name == "LB_Workout" + numday)
                    {
                        if (v.Text == "Empty")
                        {
                            empty = true;
                            workout = null;
                        }
                        else
                        {
                            workout = v.Text;
                        }
                    }
                    if (v is Label && v.Name == "LB_TIME" + numday)
                    {
                        if (v.Text == "--:--")
                        {
                            empty = true;
                            time = null;
                        }
                        else
                        {
                            time = v.Text;
                        }
                    }
                }
            }
            FES_DAY fes1 = new FES_DAY(dayw, this, workout, time);
            if (empty)
            {
                fes1.ShowDialog();
                fesD = fes1;
                CheckDays();
                empty = false;
                return;
            }


            fes1.ShowDialog();
            fesD = fes1;
            CheckDays();
        }

        private void FES_SYNC_Load(object sender, EventArgs e)
        {
            CheckDays();
        }
    }
}
