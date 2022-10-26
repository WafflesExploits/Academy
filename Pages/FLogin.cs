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
    public partial class FLogin : Form
    {
        Form mainform;
        DataTable dt = new DataTable();
        public bool FirstU = false;
        public bool FirstP = false;
        public bool Hidden = false;
        bool mouseDown = false;
        private Point offset;
        public FLogin(Form f)
        {
            InitializeComponent();
            mainform = f;
            this.Opacity = 0;
        }
        private bool HasSpecialChars(string yourString)
        {
            return yourString.Any(ch => !Char.IsLetterOrDigit(ch));
        }
        private void getuser(int a)
        {
            DataTable da, dt;
            string user = Usuario.T_Username;
            string pass = Usuario.T_Password;
            string disp = Usuario.T_Displayname;
            Int32 Sync;
            Int32 id = Usuario.N_ID;

            if (HasSpecialChars(TB_User.Text))
            {
                Banco.MError("Invalid username (Special Characters).");
                return;
            }
            
            if (TB_User.Text == "" || TB_User.Text == "Username")
            {
                MessageBox.Show("Invalid Username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TB_User.Focus();
                return;
            }
            else if (TB_Pass.Text == "" || TB_User.Text == "Password")
            {
                MessageBox.Show("Invalid Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TB_Pass.Focus();
                return;
            }
            else
            {

                if (a == 0) // Register
                {
                    dt = Banco.U_dql($"Select T_Username from tb_users where T_Username='{TB_User.Text}'");
                    if (dt.Rows.Count <= 0)
                    {

                        user = TB_User.Text.Replace(" ", "");
                        if(user.Length > 16) { Banco.MError("Username has too many characters ( 16 characters max)."); return; }
                        pass = TB_Pass.Text;
                        disp = TB_User.Text;
                        Banco.U_dml($"Insert INTO tb_users (T_Username, T_Password, T_Displayname) Values ( '{TB_User.Text}', '{TB_Pass.Text}' , '{TB_User.Text}')");
                        da = Banco.U_dql($"Select N_ID from tb_users where T_Username = '{TB_User.Text}'");
                        id = Convert.ToInt32(da.Rows[0].ItemArray[0].ToString());
                        MessageBox.Show("Successfully Registered!", "Academy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        Global.displayname = disp;
                        Global.name = user;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username already taken!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TB_User.Focus();
                    }
                }
                else if (a == 1) // Sign in
                {
                    dt = Banco.U_dql($"Select T_Username from tb_users where T_Username='{TB_User.Text}' and T_Password='{TB_Pass.Text}'");
                    if (dt.Rows.Count <= 0)
                    {
                        MessageBox.Show("Invalid Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TB_User.Focus();
                    }
                    else
                    {
                        da = Banco.U_dql($"Select * from tb_users where T_Username = '{TB_User.Text}'");
                        id = Convert.ToInt32(da.Rows[0].ItemArray[0].ToString());
                        user = da.Rows[0].ItemArray[1].ToString();
                        pass = da.Rows[0].ItemArray[2].ToString();
                        disp = da.Rows[0].ItemArray[3].ToString();
                        Global.N_isSYNC = Convert.ToInt32(da.Rows[0].ItemArray[4].ToString());
                        Global.N_AsyncDays = Convert.ToInt32(da.Rows[0].ItemArray[5].ToString());
                        Global.name = user;
                        Global.displayname = disp;
                        this.Close();
                    }
                }
            }
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {

        }

        private void alphaBlendTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void alphaBlendTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void B_Exit_Click_1(object sender, EventArgs e)
        {
            Global.exit = true;
            Application.ExitThread();
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TB_User_Enter(object sender, EventArgs e)
        {
            if (FirstU == false)
            {
                FirstU = true;
                TB_User.Text = "";

            }
        }

        private void alphaBlendTextBox1_Enter(object sender, EventArgs e)
        {
            if (FirstP == false)
            {
                FirstP = true;
                TB_Pass.Text = "";
                TB_Pass.PasswordChar = '*';
            }
        }

        private void TB_Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            
                if (!Hidden)
                {
                    Hidden = true;
                    Pnl_view.BackgroundImage = Properties.Resources.view1;
                    if (FirstP)
                    {
                        TB_Pass.PasswordChar = '\0';
                        TB_Pass.Text = TB_Pass.Text + 'r';
                        TB_Pass.Text = TB_Pass.Text.Remove(TB_Pass.Text.Length-1,1);
                        TB_Pass.Focus();
                        TB_Pass.Focus(); 
                    }

                }
                else
                {
                    Hidden = false;
                    Pnl_view.BackgroundImage = Properties.Resources.hidden11;
                    if (FirstP)
                    {
                        TB_Pass.PasswordChar = '*';
                    TB_Pass.Text = TB_Pass.Text+ 'r';
                    TB_Pass.Text = TB_Pass.Text.Remove(TB_Pass.Text.Length - 1, 1);
                    TB_Pass.Focus();
                    
                }
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            getuser(1);
        }

        private void B_Register_Click(object sender, EventArgs e)
        {
            getuser(0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void Pnl_drag_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pnl_drag_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentscreenpos = PointToScreen(e.Location);
                Location = new Point(currentscreenpos.X - offset.X, currentscreenpos.Y - offset.Y);
            }
        }

        private void Pnl_drag_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void Pnl_drag_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += .35;
            if (this.Opacity == 1)
            {
                timer1.Stop();
            }
        }

        private void TB_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TB_User_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && TB_User.Text != "")
            {
                TB_Pass.Focus();
            }
        }

        private void TB_Pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && TB_Pass.Text != "")
            {
                getuser(1);
            }
        }

        private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Global.name=="" || Global.name == null)
            {
                Application.ExitThread();
            }
        }
    }
}
