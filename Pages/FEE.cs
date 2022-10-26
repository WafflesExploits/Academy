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
    public partial class FEE : Form
    {
        DateTime day;
        bool save = false;
        string day2;
        string month2;
        string year2;
        UserControlDays ucd;
        FCalendar fcal;

        public FEE(DateTime day1, bool save1, UserControlDays ucd1, FCalendar fcal1)
        {
            InitializeComponent();
            day = day1;
            save = save1;
            ucd = ucd1;
            day2 = day.Day.ToString();
            month2 = day.Month.ToString();
            year2 = day.Year.ToString();
            fcal = fcal1;
        }

        
        private void FEE_Load(object sender, EventArgs e)
        {
            
            TB_Date.Text = day2 + "/" + month2 + "/" + year2;
            if (save){
                B_Remove.Enabled = true;
                B_Add.Text = "Save";
                int red = ucd.GetRBG(1);
                int blue = ucd.GetRBG(2);
                int green = ucd.GetRBG(3);
                LB_Color.ForeColor = Color.FromArgb(red, blue, green);
                TB_Event.Text = ucd.LB_Event.Text;
            }
        }

        private void B_Add_Click(object sender, EventArgs e)
        {
            if (TB_Event.Text == null) { Banco.MError("Invalid Name for Event."); return; }

            if (save)
            {
                
                DataTable dt = Banco.dql($"SELECT T_EVENT FROM tb_events as tbe Where T_USERNAME = '{Global.name}' AND N_DAY = '{day2}' AND N_MONTH = '{month2}' AND N_YEAR = '{year2}'");
                string prevEvent = dt.Rows[0].ItemArray[0].ToString();
                Banco.dml($"UPDATE tb_events set T_EVENT='{TB_Event.Text}', T_RGB='{GetForeColor()}' Where T_USERNAME = '{Global.name}' AND N_DAY = '{day2}' AND N_MONTH = '{month2}' AND N_YEAR = '{year2}'", $"Successfully changed '{prevEvent}' to '{TB_Event.Text}'");
                ucd.LB_Event.Text = TB_Event.Text;
                this.Close();
            }
            else
            {
                DataTable dt = Banco.dql($"SELECT T_USERNAME, N_DAY, N_MONTH, N_YEAR FROM tb_events as tbe Where T_USERNAME = '{Global.name}' AND N_DAY = '{day2}' AND N_MONTH = '{month2}' AND N_YEAR = '{year2}'");
                if (dt.Rows.Count > 0)
                {
                    Banco.MError("Day already assigned with an Event");
                    return;
                }
                Banco.dml($"INSERT INTO tb_events (T_USERNAME, T_EVENT, T_RGB, N_DAY, N_MONTH, N_YEAR) VALUES ('{Global.name}', '{TB_Event.Text}', '{GetForeColor()}', '{day2}', '{month2}', '{year2}')", $"'{TB_Event.Text}' was successfully added as an Event. ");
                
                this.Close();
            }
        }
        private string GetForeColor()
        {
            string r = LB_Color.ForeColor.R.ToString();
            if (r.Length == 1)
            {
                r = "00" + r;
            }
            else if (r.Length == 2) 
            {
                r = "0" + r;
            } 
            
            string b = LB_Color.ForeColor.B.ToString();
            if (b.Length == 1)
            {
                b = "00" + b;
            }
            else if (b.Length == 2)
            {
                b = "0" + b;
            }
            
            string g = LB_Color.ForeColor.G.ToString();
            if (g.Length == 1)
            {
                g = "00" + g;
            }
            else if (g.Length == 2)
            {
                g = "0" + g;
            }
            

            return (r+","+g+","+b);
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LB_Time_Click(object sender, EventArgs e)
        {

        }

        private void TB_Workout_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                LB_Color.ForeColor = colorDialog1.Color;
            }
        }

        private void B_Remove_Click(object sender, EventArgs e)
        {
            if (!Banco.MQuestion("Are you sure you want to delete this event?")) { return; }
            DataTable dt = Banco.dql($"SELECT T_EVENT FROM tb_events as tbe Where T_USERNAME = '{Global.name}' AND N_DAY = '{day2}' AND N_MONTH = '{month2}' AND N_YEAR = '{year2}'");
            string prevEvent = dt.Rows[0].ItemArray[0].ToString();
            Banco.dml($"DELETE FROM tb_events WHERE T_USERNAME = '{Global.name}' AND N_DAY = '{day2}' AND N_MONTH = '{month2}' AND N_YEAR = '{year2}'", $"Sucessfully removed '{prevEvent}'");
            ucd.LB_Event.Text = " ";
            this.Close();
        }

        private void TB_Event_TextChanged(object sender, EventArgs e)
        {
            if(TB_Event.Text.Length == 0)
            {
                LB_Color.Text = "Event Example";
                return;
            }
            LB_Color.Text = TB_Event.Text;
        }

        private void TB_Event_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void CB_Sync_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Black.Checked)
            {

                CB_White.Checked = false;

                P_Background.BackColor = Color.Black;
                return;
            }
            else
            {
                
                CB_White.Checked = true;
                P_Background.BackColor = Color.White;
                return;
            }
        }

       

        private void CB_White_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_White.Checked)
            {
                CB_Black.Checked = false;

                P_Background.BackColor = Color.White;
                return;
                
            }
            else
            {
                CB_Black.Checked = true;
                P_Background.BackColor = Color.Black;
                return;
            }
        }

        private void FEE_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void FEE_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
