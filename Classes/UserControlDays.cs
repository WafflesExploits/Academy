using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace Academy
{
    public partial class UserControlDays : UserControl
    {
        int dayofweek = 1;
        DateTime dayweek;
        bool isToday = false;
        FCalendar fcal;
        Color COriginal;
        Color CReverse;
        
        public UserControlDays(FCalendar fcal1)
        {
            InitializeComponent();
            fcal = fcal1;
        }

        private void GetToday()
        {
            DateTime now = DateTime.Now;
            int today = now.Day;
            string tomonth = now.ToString("MMMM");
            string toyear = now.Year.ToString();
            string month = (fcal.LB_Date.Text.Remove(4)).Trim();
            string year = (fcal.LB_Date.Text.Remove(0, 4)).Trim();
           
            int day = Convert.ToInt32(LB_Day.Text);
            //fcal.LB_Date.Text
            if (today == day  && tomonth == month && toyear == year)
            {
                isToday=true;
            }
            else
            {
                isToday = false;
            }
            
        }
        private void UserControlDays_Load(object sender, EventArgs e)
        {
            this.Anchor =  AnchorStyles.Top & AnchorStyles.Bottom & AnchorStyles.Left & AnchorStyles.Right ;
            GetToday();
            if (isToday)
            {
                LB_Today.Visible = true;
                this.BackColor = Color.FromArgb(12, 92, 196);
                LB_Day.ForeColor = Color.WhiteSmoke;
                LB_WORKOUT.ForeColor = Color.WhiteSmoke;
                LB_TIME1.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                LB_Today.Visible = false;
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
        
        public void Days(int numday, int year, int month, int index)
        {
            dayweek = new DateTime(year, month, numday);
            LB_Day.Text = numday + "";
            dayofweek = Convert.ToInt32(dayweek.DayOfWeek.ToString("d"));
            CheckEvent();
            if (Global.N_isSYNC == 1)
            {
                DataTable da = Banco.dql($"SELECT N_IDWORKOUT,N_IDTIME from tb_schedule WHERE N_IDDAY='{dayofweek}' AND T_Username='{Global.name}'");
                if(da.Rows.Count > 0) { 
                    int IDW = Convert.ToInt32(da.Rows[0].ItemArray[0].ToString());
                    DataTable dt = Banco.dql($"Select WName from Default2 where ID='{IDW}'");
                    int IDT = Convert.ToInt32(da.Rows[0].ItemArray[1].ToString());
                    DataTable ds = Banco.dql($"Select T_HORARIO from tb_time where N_IDTIME='{IDT}'");
                    LB_WORKOUT.Text = dt.Rows[0].ItemArray[0].ToString();
                    LB_TIME1.Text = ds.Rows[0].ItemArray[0].ToString().Remove(5);
                }
            }
            else
            {
                DataTable da = Banco.dql($"SELECT N_IDWORKOUT,N_IDTIME from tb_asyncschedule WHERE N_INDEX='{index}' AND T_Username='{Global.name}'");
                if (da.Rows.Count > 0)
                {
                    int ID = Convert.ToInt32(da.Rows[0].ItemArray[0].ToString());
                    DataTable dt = Banco.dql($"Select WName from Default2 where ID='{ID}'");
                    int IDT = Convert.ToInt32(da.Rows[0].ItemArray[1].ToString());
                    DataTable ds = Banco.dql($"Select T_HORARIO from tb_time where N_IDTIME='{IDT}'");
                    if(ds.Rows.Count == 0) { return; }
                    if(dt.Rows.Count == 0) { return;  }
                    LB_WORKOUT.Text = dt.Rows[0].ItemArray[0].ToString();
                    LB_TIME1.Text = ds.Rows[0].ItemArray[0].ToString().Remove(5);
                }
            }
                
            //LB_Dayofweek.Text = DateTimeFormatInfo.CurrentInfo.GetDayName(dayweek.DayOfWeek) + " \n"+ dayofweek.ToString();
            
        }
      
        private void MouseHover1(object sender, EventArgs e)
        {
            if (isToday) { return; }
            
            this.BackColor = Color.FromArgb(12, 92, 196);
            LB_Day.ForeColor = Color.WhiteSmoke;
            LB_WORKOUT.ForeColor = Color.WhiteSmoke;
            LB_TIME1.ForeColor = Color.WhiteSmoke;
            if(LB_Event.Text != "")
            {
                LB_Event.ForeColor = Color.WhiteSmoke;
            }
            
        }
        private void MouseLeave1(object sender, EventArgs e)
        {
            if (isToday) { return; }
            this.BackColor = Color.WhiteSmoke;
            LB_Day.ForeColor = Color.FromArgb(9, 69, 148); 
            LB_WORKOUT.ForeColor = Color.FromArgb(1, 94, 234);
            LB_TIME1.ForeColor = Color.FromArgb(1, 94, 234);
            if (LB_Event.Text != "")
            {
                LB_Event.ForeColor = COriginal; 
            }
        }

        private void LB_Event_Click(object sender, EventArgs e)
        {
            
        }
        private void CheckEvent()
        {
            LB_Event.Text = " ";
            string day2 = dayweek.Day.ToString();
            string month2 = dayweek.Month.ToString();
            string year2 = dayweek.Year.ToString();
            DataTable dt = Banco.dql($"SELECT T_EVENT, T_RGB from tb_events as tbe Where T_USERNAME = '{Global.name}' AND N_DAY = '{day2}' AND N_MONTH = '{month2}' AND N_YEAR = '{year2}'");
            if (dt.Rows.Count > 0)
            {
                int r = GetRBG(1);
                int g = GetRBG(2);
                int b = GetRBG(3);
                
                LB_Event.ForeColor = Color.FromArgb(r,g,b);
                COriginal = Color.FromArgb(r, g, b);
                LB_Event.Text = dt.Rows[0].ItemArray[0].ToString();
                return;
            }
            
        }

        public int GetRBG(int color)
        {
            int value = 0;
            string rgb;
            string day2 = dayweek.Day.ToString();
            string month2 = dayweek.Month.ToString();
            string year2 = dayweek.Year.ToString();
           
            if (color == 1)
            {
                DataTable dt = Banco.dql($"SELECT T_RGB from tb_events as tbe Where T_USERNAME = '{Global.name}' AND N_DAY = '{day2}' AND N_MONTH = '{month2}' AND N_YEAR = '{year2}'");
                rgb = dt.Rows[0].ItemArray[0].ToString().Remove(2);
                value = Convert.ToInt32(rgb); // 000,000,000
                return value;
            }
            else if (color == 2)
            {
                DataTable dt = Banco.dql($"SELECT T_RGB from tb_events as tbe Where T_USERNAME = '{Global.name}' AND N_DAY = '{day2}' AND N_MONTH = '{month2}' AND N_YEAR = '{year2}'");
                rgb = dt.Rows[0].ItemArray[0].ToString().Remove(7);
                rgb = rgb.Remove(0, 4);
                value = Convert.ToInt32(rgb); // 000,000,000
                return value;
                
            }
            else if (color == 3)
            {
                DataTable dt = Banco.dql($"SELECT T_RGB from tb_events as tbe Where T_USERNAME = '{Global.name}' AND N_DAY = '{day2}' AND N_MONTH = '{month2}' AND N_YEAR = '{year2}'");
                rgb = dt.Rows[0].ItemArray[0].ToString().Remove(0, 8);
                
                value = Convert.ToInt32(rgb); // 000,000,000
                return value;
                
            }
            else
            {
                return 0;
            }
        }

        private void UC_Click(object sender, EventArgs e)
        {
            string day2 = dayweek.Day.ToString();
            string month2 = dayweek.Month.ToString();
            string year2 = dayweek.Year.ToString();
            DataTable dt = Banco.dql($"SELECT T_EVENT from tb_events as tbe Where T_USERNAME = '{Global.name}' AND N_DAY = '{day2}' AND N_MONTH = '{month2}' AND N_YEAR = '{year2}'");
            if (dt.Rows.Count > 0)
            {
                FEE fe = new FEE(dayweek, true, this, fcal);
                fe.ShowDialog();
                return;
            }
            else 
            {
                FEE fe = new FEE(dayweek, false, this, fcal);
                fe.ShowDialog();
            }
            
            CheckEvent();
        }
    }
}
