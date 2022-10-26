using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
    public partial class FCalendar : Form
    {
        int month1=4, year1=2022;
        public FCalendar()
        {
            InitializeComponent();
        }

     
        private void FCalendar_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DisplayDays(now.Month, now.Year);
        }
        public void DisplayDays(int month, int year)
        {
           
            if (month <= 0)
            {
                month = 12;
                year--;
            }else if(month >= 13)
            {
                month = 1;
                year++;
            }
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LB_Date.Text = $"{monthname} {year}";
            FLP_DaysContainer.Controls.Clear();
            
            DateTime Monthstart = new DateTime(year, month, 1);
            
            int days = DateTime.DaysInMonth(year, month);
            int daysoftheweek = Convert.ToInt32(Monthstart.DayOfWeek.ToString("d"));
            int index = 0;

            
            for (int i = 1; i <= daysoftheweek; i++)
            {
                UserControlblank ucblank = new UserControlblank();
                FLP_DaysContainer.Controls.Add(ucblank);
            }
            for(int i=1; i<=days; i++)
            {
                
                UserControlDays ucdays = new UserControlDays(this);
                if (Global.N_isSYNC == 1) {
                    ucdays.Days(i, year, month, index);
                }
                else
                {
                    index++;
                    if( index > Global.N_AsyncDays){
                        index = 1;
                    }
                    ucdays.Days(i, year, month, index);
                    
                }
                FLP_DaysContainer.Controls.Add(ucdays);
            }
            month1 = month;
            year1 = year;
        }
        
        private void B_Previous_Click(object sender, EventArgs e)
        {
            month1--;
            DisplayDays(month1, year1);
        }

        private void B_Next_y_Click(object sender, EventArgs e)
        {
            month1+=6;
            if (month1 > 12)
            {
                year1++;
                month1 = month1-12;
            }
            DisplayDays(month1, year1);
        }

        private void B_Next_m_Click(object sender, EventArgs e)
        {
            month1++;
            DisplayDays(month1, year1);
        }

        private void B_Previous_m_Click(object sender, EventArgs e)
        {
            month1--;
            DisplayDays(month1, year1);
        }

        private void B_Previous_y_Click(object sender, EventArgs e)
        {
            month1 -= 6;
            if (month1 < 0)
            {
                year1--;
                month1 = 12 - month1*-1;
            }
            DisplayDays(month1, year1);
        }

        private void Arrow_Down(object sender, MouseEventArgs e)
        {
            PictureBox Button = sender as PictureBox;
            if (Button.Name == "B_Next_y") { Button.Image = Properties.Resources.Clicked_Next_y; }
            if (Button.Name == "B_Next_m") { Button.Image = Properties.Resources.Clicked_Next_m; }
            if (Button.Name == "B_Previous_y") { Button.Image = Properties.Resources.Clicked_Previous_y; }
            if (Button.Name == "B_Previous_m") { Button.Image = Properties.Resources.Clicked_Previous_m; }
        }

        private void Arrow_UP(object sender, MouseEventArgs e)
        {
            PictureBox Button = sender as PictureBox;
            if (Button.Name == "B_Next_y") { Button.Image = Properties.Resources.Next_y; }
            if (Button.Name == "B_Next_m") { Button.Image = Properties.Resources.Next_m; }
            if (Button.Name == "B_Previous_y") { Button.Image = Properties.Resources.Previous_y; }
            if (Button.Name == "B_Previous_m") { Button.Image = Properties.Resources.Previous_m; }
        }

        private void B_Schedule_Click(object sender, EventArgs e)
        {
            FES fes = new FES();
            fes.ShowDialog();
            DateTime now = DateTime.Now;
            DisplayDays(now.Month, now.Year);
        }

        private void B_Events_Click(object sender, EventArgs e)
        {
            FEEL fEEL = new FEEL(this);
            fEEL.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Print To PDF month being viewed
        }

        private void B_Next_Click(object sender, EventArgs e)
        {
            month1++;
            DisplayDays(month1, year1);
        }
    }
}
