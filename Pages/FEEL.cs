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
    public partial class FEEL : Form
    {
        DateTime now = DateTime.Now;
        int Red, Green, Blue, start;
        FCalendar fCalendar;
        public FEEL(FCalendar formis)
        {
            InitializeComponent();
            fCalendar = formis;
        }

        private void FEEL_Load(object sender, EventArgs e)
        {
            DGVGetTables();
            NUP_YEAR.Value = now.Year;
            NUP_DAY.Value = now.Day;
            NUP_MONTH.Value = now.Month;
        }

        public void DGVGetTables()
        {
            DataTable dl = Banco.dql($"Select T_EVENT as 'Event', N_DAY as 'Day', N_MONTH as 'Month', N_YEAR as 'Year' from tb_events Where T_USERNAME='{Global.name}'");
            DGV.DataSource = dl;
            DGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void NUP_YEAR_ValueChanged(object sender, EventArgs e)
        {

        }
        public bool GetEven(string type)
        {
            if (type == "y")
            {
                if( (NUP_YEAR.Value %2) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }else if (type == "m")
            {
                if ((NUP_MONTH.Value % 2) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else if (type == "d")
            {
                if ((NUP_DAY.Value % 2) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else if (type == "b")
            {
                if ((NUP_YEAR.Value % 4) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

        private void NUP_MONTH_ValueChanged(object sender, EventArgs e)
        {
            if(NUP_MONTH.Value == 2 )
            {
                NUP_DAY.Maximum = 28;
            }else if(NUP_MONTH.Value == 2 && GetEven("y") )
            {

            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (DGV.SelectedCells.Count < 0) { return; }
            if (DGV.SelectedRows.Count < 0) { return; }
            B_Remove.Enabled = true;
            B_Save.Enabled = true;
            string TEvent, NDay, NMonth, NYear, TRGB;
            TEvent = DGV.SelectedCells[0].Value.ToString();
            NDay = DGV.SelectedCells[1].Value.ToString();
            NMonth = DGV.SelectedCells[2].Value.ToString();
            NYear = DGV.SelectedCells[3].Value.ToString();

            DataTable dl = Banco.dql($"Select T_RGB from tb_events Where T_USERNAME='{Global.name}' AND T_EVENT='{TEvent}' AND N_DAY ='{NDay}' AND N_MONTH='{NMonth}' AND N_YEAR='{NYear}'");
            if (dl.Rows.Count == 0) { return; }
            TRGB = dl.Rows[0].ItemArray[0].ToString();
            ReverseForeColor(TRGB);
            TB_Event.Text = TEvent;
            LB_Color.Text = TEvent;
            NUP_DAY.Value = Int32.Parse(NDay);
            NUP_MONTH.Value = Int32.Parse(NMonth);
            NUP_YEAR.Value = Int32.Parse(NYear);
            LB_Color.ForeColor = Color.FromArgb(Red, Green, Blue);
        }

        private void B_Color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                LB_Color.ForeColor = colorDialog1.Color;
            }
        }

        private void B_Add_Click(object sender, EventArgs e)
        {
            if (TB_Event.Text == null) { Banco.MError("Invalid Name for Event."); return; }

           
                DataTable dt = Banco.dql($"SELECT T_USERNAME, N_DAY, N_MONTH, N_YEAR FROM tb_events as tbe Where T_USERNAME = '{Global.name}' AND N_DAY = '{NUP_DAY.Value}' AND N_MONTH = '{NUP_MONTH.Value}' AND N_YEAR = '{NUP_YEAR.Value}'");
                if (dt.Rows.Count > 0)
                {
                    Banco.MError("Day already assigned with an Event");
                    return;
                }
                Banco.dml($"INSERT INTO tb_events (T_USERNAME, T_EVENT, T_RGB, N_DAY, N_MONTH, N_YEAR) VALUES ('{Global.name}', '{TB_Event.Text}', '{GetForeColor()}', '{NUP_DAY.Value}', '{NUP_MONTH.Value}', '{NUP_YEAR.Value}')", $"'{TB_Event.Text}' was successfully added as an Event. ");
                DGVGetTables();
                

        }

        private void B_Save_Click(object sender, EventArgs e)
        {
            if (TB_Event.Text == null) { Banco.MError("Invalid Name for Event."); return; }
            string NDay, NMonth, NYear;
            NDay = DGV.SelectedCells[1].Value.ToString();
            NMonth = DGV.SelectedCells[2].Value.ToString();
            NYear = DGV.SelectedCells[3].Value.ToString();
            DataTable dt = Banco.dql($"SELECT T_EVENT FROM tb_events as tbe Where T_USERNAME = '{Global.name}' AND N_DAY = '{NDay}' AND N_MONTH = '{NMonth}' AND N_YEAR = '{NYear}'");
            string prevEvent = dt.Rows[0].ItemArray[0].ToString();
            Banco.dml($"UPDATE tb_events set T_EVENT='{TB_Event.Text}', T_RGB='{GetForeColor()}', N_DAY = '{NUP_DAY.Value}', N_MONTH = '{NUP_MONTH.Value}', N_YEAR = '{NUP_YEAR.Value}' Where T_USERNAME = '{Global.name}' AND N_DAY = '{NDay}' AND N_MONTH = '{NMonth}' AND N_YEAR = '{NYear}'", $"Successfully changed '{prevEvent}' to '{TB_Event.Text}'");
            DGVGetTables();
            
        }

        private void B_Remove_Click(object sender, EventArgs e)
        {
            if (!Banco.MQuestion("Are you sure you want to delete this event?")) { return; }
            string TEvent, NDay, NMonth, NYear;
            TEvent = DGV.SelectedCells[0].Value.ToString();
            NDay = DGV.SelectedCells[1].Value.ToString();
            NMonth = DGV.SelectedCells[2].Value.ToString();
            NYear = DGV.SelectedCells[3].Value.ToString();
            Banco.dml($"DELETE FROM tb_events WHERE T_USERNAME = '{Global.name}' AND N_DAY = '{NDay}' AND N_MONTH = '{NMonth}' AND N_YEAR = '{NYear}'", $"Sucessfully removed '{TEvent}'");
            DGVGetTables();
            
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


            return (r + "," + g + "," + b);
        }

        private void FEEL_FormClosing(object sender, FormClosingEventArgs e)
        {
            fCalendar.DisplayDays(now.Month, now.Year);
        }

        private void ReverseForeColor(string TRGB)
        {
            string red = TRGB.Remove(3);
            string green = (TRGB.Remove(0, 4)).Remove(3);
            string blue = TRGB.Remove(0, 8);
            Red = Int32.Parse(red);
            Green = Int32.Parse(green);
            Blue = Int32.Parse(blue);
        }

        private void CB_Black_CheckedChanged(object sender, EventArgs e)
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

    }
}
