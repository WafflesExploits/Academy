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
    public partial class FES_ASYNC : Form
    {
        int dayi;
        FES_ASDAY fesD;
        bool empty = false;
        string workout;
        string time;
        public FES_ASYNC()
        {
            InitializeComponent();
        }

        public void GetEnabledDays()
        {
            foreach (Control v in this.Controls)
            {
                if (v is Panel)
                {
                    v.Enabled = false;
                }
            }
            foreach (Control v in this.Controls)
            {
                if (v is Panel) 
                {
                    for (int i = Global.N_AsyncDays; i > 0; i--)
                    {
                        if ((string)v.Tag == i.ToString())
                        {
                            v.Enabled = true;
                        }
                    }
                }
            }
        }
        private void FES_ASYNC_Load(object sender, EventArgs e)
        {
            NUP_AsyncDays.Value = Global.N_AsyncDays;
            GetEnabledDays();
            CheckDays();
        }
        public void CheckDays()
        {
            CheckDays1(1);
            CheckDays1(2);
            CheckDays1(3);
            CheckDays1(4);
            CheckDays1(5);
            CheckDays1(6);
            CheckDays1(7);
        }

        public void CheckDays1(int i)
        {
            DataTable dt = Banco.dql($"SELECT T_USERNAME, N_INDEX, N_IDTIME, N_IDWORKOUT FROM tb_asyncschedule Where T_USERNAME = '{Global.name}' AND N_INDEX = '{i}'");
            if (dt.Rows.Count > 0)
            {
                
                foreach (Control b in this.Controls)
                {
                    if (b is Panel)
                    {
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
        private void AddDay(object sender, EventArgs e)
        {

            if (sender is Panel)
            {
                Panel day = sender as Panel;
                dayi = Convert.ToInt32((string)day.Tag);
            }
            else if (sender is Label)
            {
                Label day = sender as Label;
                dayi = Convert.ToInt32((string)day.Tag);
            }

            int numday = dayi;
            foreach (Control b in this.Controls)
            {
                foreach (Control v in b.Controls)
                {
                    if (v is Label && v.Name == "LB_Workout" + numday)
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
            FES_ASDAY fes1 = new FES_ASDAY(dayi, this, workout, time);
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

        private void NUP_AsyncDays_ValueChanged(object sender, EventArgs e)
        {
            Global.N_AsyncDays = Convert.ToInt32(NUP_AsyncDays.Value);
            GetEnabledDays();
        }

        public void CloseAsync()
        {
            Banco.dml($"UPDATE tb_users SET N_AsyncDays='{Global.N_AsyncDays}' where T_USERNAME='{Global.name}'");

        }
        private void FES_ASYNC_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FES_ASYNC_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
