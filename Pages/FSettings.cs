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
    public partial class FSettings : Form
    {
        MainForm mf;
        public FSettings(MainForm mf1)
        {
            InitializeComponent();
            mf = mf1;
        }

        private void B_Logout_Click(object sender, EventArgs e)
        {
           
            
            Global.N_isSYNC = 1;
            Global.N_AsyncDays = 6;
            Global.name = null;
            Global.displayname = null;
            FLogin flogin = new FLogin(mf);
            mf.Hide();
            flogin.ShowDialog();
            if (Global.exit) { return; }
            mf.Show();
            mf.checkuser();
            mf.Opacity = 0;
            mf.timer1.Start();
        }

        private void FSettings_Load(object sender, EventArgs e)
        {
            LB_Username.Text = Global.name;
            LB_Displayname.Text = Global.displayname;

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
