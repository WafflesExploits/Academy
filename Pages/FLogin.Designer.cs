
namespace Academy
{
    partial class FLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.B_Signin = new System.Windows.Forms.Button();
            this.B_Register = new System.Windows.Forms.Button();
            this.Pnl_view = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.TB_Pass = new ZBobb.AlphaBlendTextBox();
            this.TB_User = new ZBobb.AlphaBlendTextBox();
            this.Pnl_lock = new System.Windows.Forms.Panel();
            this.Pnl_user = new System.Windows.Forms.Panel();
            this.B_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_drag = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BackgroundImage = global::Academy.Properties.Resources.login2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.B_Signin);
            this.panel1.Controls.Add(this.B_Register);
            this.panel1.Controls.Add(this.Pnl_view);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.TB_Pass);
            this.panel1.Controls.Add(this.TB_User);
            this.panel1.Controls.Add(this.Pnl_lock);
            this.panel1.Controls.Add(this.Pnl_user);
            this.panel1.Controls.Add(this.B_Exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Pnl_drag);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 353);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // B_Signin
            // 
            this.B_Signin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(180)))), ((int)(((byte)(252)))));
            this.B_Signin.FlatAppearance.BorderSize = 0;
            this.B_Signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Signin.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Signin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Signin.Location = new System.Drawing.Point(34, 237);
            this.B_Signin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_Signin.Name = "B_Signin";
            this.B_Signin.Size = new System.Drawing.Size(252, 38);
            this.B_Signin.TabIndex = 0;
            this.B_Signin.Text = "Sign In";
            this.B_Signin.UseVisualStyleBackColor = false;
            this.B_Signin.Click += new System.EventHandler(this.button1_Click);
            // 
            // B_Register
            // 
            this.B_Register.BackColor = System.Drawing.Color.Transparent;
            this.B_Register.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.B_Register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(137)))), ((int)(((byte)(241)))));
            this.B_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Register.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Register.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.B_Register.Location = new System.Drawing.Point(34, 286);
            this.B_Register.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_Register.Name = "B_Register";
            this.B_Register.Size = new System.Drawing.Size(252, 38);
            this.B_Register.TabIndex = 1;
            this.B_Register.Text = "Register";
            this.B_Register.UseVisualStyleBackColor = false;
            this.B_Register.Click += new System.EventHandler(this.B_Register_Click);
            // 
            // Pnl_view
            // 
            this.Pnl_view.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_view.BackgroundImage = global::Academy.Properties.Resources.hidden11;
            this.Pnl_view.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pnl_view.Location = new System.Drawing.Point(240, 160);
            this.Pnl_view.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_view.Name = "Pnl_view";
            this.Pnl_view.Size = new System.Drawing.Size(38, 28);
            this.Pnl_view.TabIndex = 6;
            this.Pnl_view.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            this.Pnl_view.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(34, 198);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 4);
            this.panel3.TabIndex = 12;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel8.Location = new System.Drawing.Point(34, 126);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(244, 4);
            this.panel8.TabIndex = 9;
            // 
            // TB_Pass
            // 
            this.TB_Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_Pass.BackAlpha = 0;
            this.TB_Pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TB_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Pass.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Pass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TB_Pass.Location = new System.Drawing.Point(85, 162);
            this.TB_Pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_Pass.Name = "TB_Pass";
            this.TB_Pass.Size = new System.Drawing.Size(145, 28);
            this.TB_Pass.TabIndex = 11;
            this.TB_Pass.Text = "Password";
            this.TB_Pass.TextChanged += new System.EventHandler(this.TB_Pass_TextChanged);
            this.TB_Pass.Enter += new System.EventHandler(this.alphaBlendTextBox1_Enter);
            this.TB_Pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Pass_KeyDown);
            // 
            // TB_User
            // 
            this.TB_User.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_User.BackAlpha = 0;
            this.TB_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TB_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_User.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_User.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TB_User.Location = new System.Drawing.Point(85, 90);
            this.TB_User.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_User.Name = "TB_User";
            this.TB_User.Size = new System.Drawing.Size(145, 28);
            this.TB_User.TabIndex = 8;
            this.TB_User.Text = "Username";
            this.TB_User.MouseClick += new System.Windows.Forms.MouseEventHandler(this.alphaBlendTextBox1_MouseClick);
            this.TB_User.TextChanged += new System.EventHandler(this.alphaBlendTextBox1_TextChanged);
            this.TB_User.Enter += new System.EventHandler(this.TB_User_Enter);
            this.TB_User.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_User_KeyDown);
            this.TB_User.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_User_KeyPress);
            // 
            // Pnl_lock
            // 
            this.Pnl_lock.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_lock.BackgroundImage = global::Academy.Properties.Resources._lock;
            this.Pnl_lock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pnl_lock.Location = new System.Drawing.Point(42, 150);
            this.Pnl_lock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_lock.Name = "Pnl_lock";
            this.Pnl_lock.Size = new System.Drawing.Size(38, 42);
            this.Pnl_lock.TabIndex = 10;
            // 
            // Pnl_user
            // 
            this.Pnl_user.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_user.BackgroundImage = global::Academy.Properties.Resources.user11;
            this.Pnl_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pnl_user.Location = new System.Drawing.Point(42, 78);
            this.Pnl_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_user.Name = "Pnl_user";
            this.Pnl_user.Size = new System.Drawing.Size(38, 42);
            this.Pnl_user.TabIndex = 5;
            // 
            // B_Exit
            // 
            this.B_Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_Exit.BackColor = System.Drawing.Color.Transparent;
            this.B_Exit.BackgroundImage = global::Academy.Properties.Resources.exit1;
            this.B_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_Exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(171)))));
            this.B_Exit.FlatAppearance.BorderSize = 0;
            this.B_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(55)))), ((int)(((byte)(81)))));
            this.B_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Exit.Font = new System.Drawing.Font("Corbel", 12F);
            this.B_Exit.ForeColor = System.Drawing.Color.White;
            this.B_Exit.Location = new System.Drawing.Point(284, 4);
            this.B_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(31, 26);
            this.B_Exit.TabIndex = 4;
            this.B_Exit.UseVisualStyleBackColor = false;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(180)))), ((int)(((byte)(252)))));
            this.label1.Location = new System.Drawing.Point(92, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "[Academy]";
            // 
            // Pnl_drag
            // 
            this.Pnl_drag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pnl_drag.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_drag.ForeColor = System.Drawing.Color.Transparent;
            this.Pnl_drag.Location = new System.Drawing.Point(0, 0);
            this.Pnl_drag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_drag.Name = "Pnl_drag";
            this.Pnl_drag.Size = new System.Drawing.Size(322, 30);
            this.Pnl_drag.TabIndex = 13;
            this.Pnl_drag.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_drag_Paint);
            this.Pnl_drag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_drag_MouseDown);
            this.Pnl_drag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pnl_drag_MouseMove);
            this.Pnl_drag.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pnl_drag_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 353);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Academy]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FLogin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.Panel Pnl_user;
        private ZBobb.AlphaBlendTextBox TB_User;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel3;
        private ZBobb.AlphaBlendTextBox TB_Pass;
        private System.Windows.Forms.Panel Pnl_lock;
        private System.Windows.Forms.Panel Pnl_view;
        private System.Windows.Forms.Button B_Signin;
        private System.Windows.Forms.Button B_Register;
        private System.Windows.Forms.Panel Pnl_drag;
        private System.Windows.Forms.Timer timer1;
    }
}