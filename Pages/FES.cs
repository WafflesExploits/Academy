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
    public partial class FES : Form
    {
        public FES()
        {
            InitializeComponent();
        }

        private void FES_Load(object sender, EventArgs e)
        {
            
            
            FES_SYNC fes1 = new FES_SYNC();
            FES_ASYNC fes2 = new FES_ASYNC();
            
            openChildForm(fes1);
            openChildForm1(fes2);
            if (Global.N_isSYNC == 1)
            {
                fes1.Enabled = true;
                fes2.Enabled = false;
                CB_ASync.Checked = false;
                CB_Sync.Checked = true;
            }
            else
            {
                fes1.Enabled = false;
                fes2.Enabled = true;
                CB_ASync.Checked = true;
                CB_Sync.Checked = false;
            }

        }

        private Form activeForm = null;
        private Form activeForm1 = null;
        public void openChildForm(Form childform)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childform;
            this.P_Formloader.Controls.Clear();
            childform.Dock = DockStyle.Fill;
            childform.TopLevel = false;
            childform.TopMost = true;
            childform.FormBorderStyle = FormBorderStyle.None;
            this.P_Formloader.Controls.Add(childform);
            this.P_Formloader.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        public void openChildForm1(Form childform)
        {
            if (activeForm1 != null)
            {
                activeForm1.Close();
            }
            activeForm1 = childform;
            this.P_FormLoader2.Controls.Clear();
            childform.Dock = DockStyle.Fill;
            childform.TopLevel = false;
            childform.TopMost = true;
            childform.FormBorderStyle = FormBorderStyle.None;
            this.P_FormLoader2.Controls.Add(childform);
            this.P_FormLoader2.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            FES_SYNC fes1 = new FES_SYNC();
            FES_ASYNC fes2 = new FES_ASYNC();
            if (CB_Sync.Checked)
            {
                fes1.Enabled = true;
                fes2.Enabled = false;
                CB_ASync.Checked = false;
                Global.N_isSYNC = 1;
                Banco.dml($"UPDATE tb_users SET N_isSync ='1' WHERE T_Username ='{Global.name}'");
            }
            else
            {
                fes1.Enabled = false;
                fes2.Enabled = true;
                CB_ASync.Checked = true;
            }
            openChildForm(fes1);
            openChildForm1(fes2);
        }

        private void AsyncCheckbox(object sender, EventArgs e)
        {
            FES_SYNC fes1 = new FES_SYNC();
            FES_ASYNC fes2 = new FES_ASYNC();
            if (CB_ASync.Checked)
            {
                fes2.Enabled = true;
                fes1.Enabled = false;
                CB_Sync.Checked = false;
                Global.N_isSYNC = 0;
                Banco.dml($"UPDATE tb_users SET N_isSync ='0' WHERE T_Username ='{Global.name}'");
            }
            else
            {
                fes2.Enabled = false;
                fes1.Enabled = true;
                CB_Sync.Checked = true;
            }
            openChildForm(fes1);
            openChildForm1(fes2);
        }

        private void FES_Leave(object sender, EventArgs e)
        {
            
        }

        private void FES_FormClosed(object sender, FormClosedEventArgs e)
        {
            FES_ASYNC fes2 = new FES_ASYNC();
            fes2.CloseAsync();
            
        }

        private void P_Formloader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
