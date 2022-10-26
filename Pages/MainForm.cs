using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Academy
{
    public partial class MainForm : Form
    {
   


        public MainForm()
        {
            InitializeComponent();
            
            this.Hide();
            FLogin flogin = new FLogin(this);
            flogin.ShowDialog();
            
            this.Show();
            checkuser();
            this.Opacity = 0;
            timer1.Start();

        }
        
        public void checkuser()
        {
            LB_Username.Text = Global.displayname;
        }
        bool mouseDown;
        private Point offset;

        private Form activeForm = null;
        private void openChildForm(Form childform)
        {
            if(activeForm != null)
            {
                    activeForm.Close();
            }
            activeForm = childform;
            this.P_Formloader.Controls.Clear();
            childform.Dock = DockStyle.Fill;
            childform.TopLevel = false; 
            childform.TopMost = true ;
            childform.FormBorderStyle = FormBorderStyle.None;
            this.P_Formloader.Controls.Add(childform);
            this.P_Formloader.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }


        

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                Point currentscreenpos = PointToScreen(e.Location);
                Location = new Point(currentscreenpos.X - offset.X, currentscreenpos.Y - offset.Y);
            }
        }

        private void panel5_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer2.Start();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                Global.maximized = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                Global.maximized = false;
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += .35;
            if (this.Opacity == 1)
            {
                timer1.Stop();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Global.cancel)
            {
                this.Close();
            }
            FHome f = new FHome();
            openChildForm(f);
            P_Nav.Height = B_Home.Height;
            P_Nav.Top = B_Home.Top;
            P_Nav.Left = B_Home.Left;
            P_Nav.BackColor = Color.FromArgb(39, 119, 213);
            B_Home.BackColor = Color.FromArgb(55, 62, 84);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= .35;
            if (this.Opacity <= 0)
            {
                Application.ExitThread();
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void B_Calendar_Click(object sender, EventArgs e)
        {
            
            B_Home.BackColor = Color.FromArgb(13, 22, 31);
            B_Settings.BackColor = Color.FromArgb(13, 22, 31);
            B_Analytics.BackColor = Color.FromArgb(13, 22, 31);
            B_Workouts.BackColor = Color.FromArgb(13, 22, 31);
            
            FCalendar f = new FCalendar();
            openChildForm(f);
        }

        private void B_Analytics_Click(object sender, EventArgs e)
        {
            B_Home.BackColor = Color.FromArgb(13, 22, 31);
            B_Workouts.BackColor = Color.FromArgb(13, 22, 31);
            B_Calendar.BackColor = Color.FromArgb(13, 22, 31);
            B_Settings.BackColor = Color.FromArgb(13, 22, 31);

            FAnalytics f = new FAnalytics();
            openChildForm(f);
        }

        private void B_Settings_Click(object sender, EventArgs e)
        {
            B_Home.BackColor = Color.FromArgb(13, 22, 31);
            B_Workouts.BackColor = Color.FromArgb(13, 22, 31);
            B_Calendar.BackColor = Color.FromArgb(13, 22, 31);
            B_Analytics.BackColor = Color.FromArgb(13, 22, 31);

            FSettings f = new FSettings(this);
            openChildForm(f);
        }

        private void B_Workout_Leave(object sender, EventArgs e)
        {
            B_Workouts.BackColor = Color.FromArgb(13, 22, 31);
        }

        private void B_Calendar_Leave(object sender, EventArgs e)
        {
            B_Calendar.BackColor = Color.FromArgb(13, 22, 31);
        }

        private void B_Analytics_Leave(object sender, EventArgs e)
        {
            B_Analytics.BackColor = Color.FromArgb(13, 22, 31);
        }

        private void B_Workouts_Click(object sender, EventArgs e)
        {

            B_Calendar.BackColor = Color.FromArgb(13, 22, 31);
            B_Settings.BackColor = Color.FromArgb(13, 22, 31);
            B_Home.BackColor = Color.FromArgb(13, 22, 31);
            B_Analytics.BackColor = Color.FromArgb(13, 22, 31);

            FWorkout f = new FWorkout();
            openChildForm(f);
        }
        private void B_Workout_Enter(object sender, EventArgs e)
        {
            P_Nav.Height = B_Workouts.Height;
            P_Nav.Top = B_Workouts.Top;
            P_Nav.Left = B_Workouts.Left;
            P_Nav.BackColor = Color.FromArgb(39, 119, 213);
            B_Workouts.BackColor = Color.FromArgb(55, 62, 84);
        }

        private void B_Calendar_Enter(object sender, EventArgs e)
        {
            P_Nav.Height = B_Calendar.Height;
            P_Nav.Top = B_Calendar.Top;
            P_Nav.Left = B_Calendar.Left;
            P_Nav.BackColor = Color.FromArgb(39, 119, 213);
            B_Calendar.BackColor = Color.FromArgb(13, 22, 31);
            
        }

        private void B_Analytics_Enter(object sender, EventArgs e)
        {
            P_Nav.Height = B_Analytics.Height;
            P_Nav.Top = B_Analytics.Top;
            P_Nav.Left = B_Analytics.Left;
            P_Nav.BackColor = Color.FromArgb(39, 119, 213);
            B_Analytics.BackColor = Color.FromArgb(55, 62, 84);

        }

        private void B_Settings_Enter(object sender, EventArgs e)
        {
            P_Nav.Height = B_Settings.Height;
            P_Nav.Top = B_Settings.Top;
            P_Nav.Left = B_Settings.Left;
            P_Nav.BackColor = Color.FromArgb(39, 119, 213);
            B_Settings.BackColor = Color.FromArgb(55, 62, 84);

        }

        private void B_Settings_Leave(object sender, EventArgs e)
        {
            B_Settings.BackColor = Color.FromArgb(13, 22, 31);
        }

        private void P_Formloader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void B_Help_Click(object sender, EventArgs e)
        {
            FCredits f1 = new FCredits();
            f1.ShowDialog();
        }

        private void B_Home_Enter(object sender, EventArgs e)
        {
            P_Nav.Height = B_Home.Height;
            P_Nav.Top = B_Home.Top;
            P_Nav.Left = B_Home.Left;
            P_Nav.BackColor = Color.FromArgb(39, 119, 213);
            B_Home.BackColor = Color.FromArgb(55, 62, 84);
        }

        private void B_Home_Click(object sender, EventArgs e)
        {
            B_Workouts.BackColor = Color.FromArgb(13, 22, 31);
            B_Calendar.BackColor = Color.FromArgb(13, 22, 31);
            B_Analytics.BackColor = Color.FromArgb(13, 22, 31);
            B_Settings.BackColor = Color.FromArgb(13, 22, 31);

            FHome f = new FHome();
            openChildForm(f);
        }

        private void B_Home_Leave(object sender, EventArgs e)
        {
            B_Home.BackColor = Color.FromArgb(13, 22, 31);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            Global.N_isSYNC = 1;
            Global.N_AsyncDays = 6;
            Global.name = null;
            Global.displayname = null;
            FLogin flogin = new FLogin(this);
            this.Hide();
            flogin.ShowDialog();
            if (Global.exit) { return; }
            this.Show();
            this.checkuser();
            this.Opacity = 0;
            this.timer1.Start();
            B_Workouts.BackColor = Color.FromArgb(13, 22, 31);
            B_Calendar.BackColor = Color.FromArgb(13, 22, 31);
            B_Analytics.BackColor = Color.FromArgb(13, 22, 31);
            B_Settings.BackColor = Color.FromArgb(13, 22, 31);
            P_Nav.Height = B_Home.Height;
            P_Nav.Top = B_Home.Top;
            P_Nav.Left = B_Home.Left;
            P_Nav.BackColor = Color.FromArgb(39, 119, 213);
            B_Home.BackColor = Color.FromArgb(55, 62, 84);
            FHome fHome = new FHome();
            openChildForm(fHome);
        }
    }
}
