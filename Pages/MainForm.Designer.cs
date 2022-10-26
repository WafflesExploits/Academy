
namespace Academy
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.P_Nav = new System.Windows.Forms.Panel();
            this.B_Analytics = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.B_Settings = new System.Windows.Forms.Button();
            this.B_Calendar = new System.Windows.Forms.Button();
            this.B_Workouts = new System.Windows.Forms.Button();
            this.B_Home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LB_Username = new System.Windows.Forms.Label();
            this.Panel_Icon = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.B_Help = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.B_Minimize = new System.Windows.Forms.Button();
            this.B_Maximize = new System.Windows.Forms.Button();
            this.B_Exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.P_Formloader = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.P_Nav);
            this.panel1.Controls.Add(this.B_Analytics);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.B_Settings);
            this.panel1.Controls.Add(this.B_Calendar);
            this.panel1.Controls.Add(this.B_Workouts);
            this.panel1.Controls.Add(this.B_Home);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 857);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // P_Nav
            // 
            this.P_Nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(119)))), ((int)(((byte)(213)))));
            this.P_Nav.ForeColor = System.Drawing.Color.White;
            this.P_Nav.Location = new System.Drawing.Point(0, 209);
            this.P_Nav.Name = "P_Nav";
            this.P_Nav.Size = new System.Drawing.Size(5, 69);
            this.P_Nav.TabIndex = 3;
            // 
            // B_Analytics
            // 
            this.B_Analytics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Analytics.Dock = System.Windows.Forms.DockStyle.Top;
            this.B_Analytics.FlatAppearance.BorderSize = 0;
            this.B_Analytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Analytics.Font = new System.Drawing.Font("Cascadia Mono", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Analytics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.B_Analytics.Image = global::Academy.Properties.Resources.analytics8;
            this.B_Analytics.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B_Analytics.Location = new System.Drawing.Point(0, 416);
            this.B_Analytics.Name = "B_Analytics";
            this.B_Analytics.Size = new System.Drawing.Size(250, 69);
            this.B_Analytics.TabIndex = 8;
            this.B_Analytics.Text = "Analytics     ";
            this.B_Analytics.UseVisualStyleBackColor = false;
            this.B_Analytics.Click += new System.EventHandler(this.B_Analytics_Click);
            this.B_Analytics.Enter += new System.EventHandler(this.B_Analytics_Enter);
            this.B_Analytics.Leave += new System.EventHandler(this.B_Analytics_Leave);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(247)))));
            this.panel4.Controls.Add(this.panel6);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 785);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 3);
            this.panel4.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(250, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1074, 69);
            this.panel6.TabIndex = 3;
            // 
            // B_Settings
            // 
            this.B_Settings.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.B_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Settings.FlatAppearance.BorderSize = 0;
            this.B_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Settings.Font = new System.Drawing.Font("Cascadia Mono", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.B_Settings.Image = global::Academy.Properties.Resources.settings;
            this.B_Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B_Settings.Location = new System.Drawing.Point(0, 788);
            this.B_Settings.Name = "B_Settings";
            this.B_Settings.Size = new System.Drawing.Size(250, 69);
            this.B_Settings.TabIndex = 7;
            this.B_Settings.Text = "Settings    ";
            this.B_Settings.UseVisualStyleBackColor = false;
            this.B_Settings.Click += new System.EventHandler(this.B_Settings_Click);
            this.B_Settings.Enter += new System.EventHandler(this.B_Settings_Enter);
            this.B_Settings.Leave += new System.EventHandler(this.B_Settings_Leave);
            // 
            // B_Calendar
            // 
            this.B_Calendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Calendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.B_Calendar.FlatAppearance.BorderSize = 0;
            this.B_Calendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Calendar.Font = new System.Drawing.Font("Cascadia Mono", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.B_Calendar.Image = global::Academy.Properties.Resources.calendar1;
            this.B_Calendar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B_Calendar.Location = new System.Drawing.Point(0, 347);
            this.B_Calendar.Name = "B_Calendar";
            this.B_Calendar.Size = new System.Drawing.Size(250, 69);
            this.B_Calendar.TabIndex = 5;
            this.B_Calendar.Text = "Calendar    ";
            this.B_Calendar.UseVisualStyleBackColor = false;
            this.B_Calendar.Click += new System.EventHandler(this.B_Calendar_Click);
            this.B_Calendar.Enter += new System.EventHandler(this.B_Calendar_Enter);
            this.B_Calendar.Leave += new System.EventHandler(this.B_Calendar_Leave);
            // 
            // B_Workouts
            // 
            this.B_Workouts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Workouts.Dock = System.Windows.Forms.DockStyle.Top;
            this.B_Workouts.FlatAppearance.BorderSize = 0;
            this.B_Workouts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Workouts.Font = new System.Drawing.Font("Cascadia Mono", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Workouts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.B_Workouts.Image = global::Academy.Properties.Resources.dumbbell1;
            this.B_Workouts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B_Workouts.Location = new System.Drawing.Point(0, 278);
            this.B_Workouts.Name = "B_Workouts";
            this.B_Workouts.Size = new System.Drawing.Size(250, 69);
            this.B_Workouts.TabIndex = 4;
            this.B_Workouts.Text = "Workouts     ";
            this.B_Workouts.UseVisualStyleBackColor = false;
            this.B_Workouts.Click += new System.EventHandler(this.B_Workouts_Click);
            this.B_Workouts.Enter += new System.EventHandler(this.B_Workout_Enter);
            this.B_Workouts.Leave += new System.EventHandler(this.B_Workout_Leave);
            // 
            // B_Home
            // 
            this.B_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.B_Home.FlatAppearance.BorderSize = 0;
            this.B_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Home.Font = new System.Drawing.Font("Cascadia Mono", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.B_Home.Image = global::Academy.Properties.Resources.home;
            this.B_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.B_Home.Location = new System.Drawing.Point(0, 209);
            this.B_Home.Name = "B_Home";
            this.B_Home.Size = new System.Drawing.Size(250, 69);
            this.B_Home.TabIndex = 2;
            this.B_Home.Text = "Home     ";
            this.B_Home.UseVisualStyleBackColor = false;
            this.B_Home.Click += new System.EventHandler(this.B_Home_Click);
            this.B_Home.Enter += new System.EventHandler(this.B_Home_Enter);
            this.B_Home.Leave += new System.EventHandler(this.B_Home_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.LB_Username);
            this.panel2.Controls.Add(this.Panel_Icon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 209);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(247)))));
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(-2, 208);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 3);
            this.panel3.TabIndex = 1;
            // 
            // LB_Username
            // 
            this.LB_Username.Font = new System.Drawing.Font("Corbel", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Username.ForeColor = System.Drawing.SystemColors.Control;
            this.LB_Username.Location = new System.Drawing.Point(-27, 130);
            this.LB_Username.Name = "LB_Username";
            this.LB_Username.Size = new System.Drawing.Size(303, 52);
            this.LB_Username.TabIndex = 2;
            this.LB_Username.Text = "Waflisanfwefwef\r\n";
            this.LB_Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Username.UseCompatibleTextRendering = true;
            this.LB_Username.Click += new System.EventHandler(this.label1_Click);
            // 
            // Panel_Icon
            // 
            this.Panel_Icon.BackgroundImage = global::Academy.Properties.Resources.user2;
            this.Panel_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Panel_Icon.Location = new System.Drawing.Point(77, 28);
            this.Panel_Icon.Name = "Panel_Icon";
            this.Panel_Icon.Size = new System.Drawing.Size(98, 100);
            this.Panel_Icon.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(33)))), ((int)(((byte)(51)))));
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.B_Help);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.B_Minimize);
            this.panel5.Controls.Add(this.B_Maximize);
            this.panel5.Controls.Add(this.B_Exit);
            this.panel5.Controls.Add(this.button1);
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(33)))), ((int)(((byte)(51)))));
            this.panel5.Location = new System.Drawing.Point(-11, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1339, 25);
            this.panel5.TabIndex = 1;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            this.panel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseMove);
            this.panel5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseUp);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(24)))), ((int)(((byte)(43)))));
            this.panel8.Location = new System.Drawing.Point(11, 23);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1324, 11);
            this.panel8.TabIndex = 0;
            // 
            // B_Help
            // 
            this.B_Help.BackgroundImage = global::Academy.Properties.Resources.credits;
            this.B_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Help.Dock = System.Windows.Forms.DockStyle.Right;
            this.B_Help.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(171)))));
            this.B_Help.FlatAppearance.BorderSize = 0;
            this.B_Help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(171)))));
            this.B_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Help.Font = new System.Drawing.Font("Corbel", 12F);
            this.B_Help.ForeColor = System.Drawing.Color.White;
            this.B_Help.Location = new System.Drawing.Point(1183, 0);
            this.B_Help.Name = "B_Help";
            this.B_Help.Size = new System.Drawing.Size(39, 25);
            this.B_Help.TabIndex = 3;
            this.B_Help.UseVisualStyleBackColor = true;
            this.B_Help.Click += new System.EventHandler(this.B_Help_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(176)))), ((int)(((byte)(248)))));
            this.label1.Location = new System.Drawing.Point(14, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "[Academy]";
            // 
            // B_Minimize
            // 
            this.B_Minimize.BackgroundImage = global::Academy.Properties.Resources.minus1;
            this.B_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.B_Minimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(171)))));
            this.B_Minimize.FlatAppearance.BorderSize = 0;
            this.B_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(171)))));
            this.B_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Minimize.Font = new System.Drawing.Font("Corbel", 12F);
            this.B_Minimize.ForeColor = System.Drawing.Color.White;
            this.B_Minimize.Location = new System.Drawing.Point(1222, 0);
            this.B_Minimize.Name = "B_Minimize";
            this.B_Minimize.Size = new System.Drawing.Size(39, 25);
            this.B_Minimize.TabIndex = 2;
            this.B_Minimize.UseVisualStyleBackColor = true;
            this.B_Minimize.Click += new System.EventHandler(this.button7_Click);
            // 
            // B_Maximize
            // 
            this.B_Maximize.BackgroundImage = global::Academy.Properties.Resources.maximize11;
            this.B_Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Maximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.B_Maximize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(171)))));
            this.B_Maximize.FlatAppearance.BorderSize = 0;
            this.B_Maximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(171)))));
            this.B_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Maximize.Font = new System.Drawing.Font("Corbel", 12F);
            this.B_Maximize.ForeColor = System.Drawing.Color.White;
            this.B_Maximize.Location = new System.Drawing.Point(1261, 0);
            this.B_Maximize.Name = "B_Maximize";
            this.B_Maximize.Size = new System.Drawing.Size(39, 25);
            this.B_Maximize.TabIndex = 1;
            this.B_Maximize.UseVisualStyleBackColor = true;
            this.B_Maximize.Click += new System.EventHandler(this.button6_Click);
            // 
            // B_Exit
            // 
            this.B_Exit.BackgroundImage = global::Academy.Properties.Resources.exit1;
            this.B_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.B_Exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(171)))));
            this.B_Exit.FlatAppearance.BorderSize = 0;
            this.B_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(171)))));
            this.B_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Exit.Font = new System.Drawing.Font("Corbel", 12F);
            this.B_Exit.ForeColor = System.Drawing.Color.White;
            this.B_Exit.Location = new System.Drawing.Point(1300, 0);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(39, 25);
            this.B_Exit.TabIndex = 0;
            this.B_Exit.UseVisualStyleBackColor = true;
            this.B_Exit.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::Academy.Properties.Resources.Logout11;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(171)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(171)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Corbel", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1144, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 25);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 57;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 47;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // P_Formloader
            // 
            this.P_Formloader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P_Formloader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.P_Formloader.Location = new System.Drawing.Point(250, 28);
            this.P_Formloader.Name = "P_Formloader";
            this.P_Formloader.Size = new System.Drawing.Size(1074, 760);
            this.P_Formloader.TabIndex = 2;
            this.P_Formloader.Paint += new System.Windows.Forms.PaintEventHandler(this.P_Formloader_Paint);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(43)))), ((int)(((byte)(72)))));
            this.panel7.Location = new System.Drawing.Point(250, 785);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1074, 72);
            this.panel7.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1324, 857);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.P_Formloader);
            this.Font = new System.Drawing.Font("Cascadia Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1074, 760);
            this.Name = "MainForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\\";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button B_Home;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button B_Workouts;
        private System.Windows.Forms.Panel Panel_Icon;
        private System.Windows.Forms.Label LB_Username;
        private System.Windows.Forms.Button B_Settings;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.Button B_Maximize;
        private System.Windows.Forms.Button B_Minimize;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel P_Nav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel P_Formloader;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button B_Help;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button B_Analytics;
        private System.Windows.Forms.Button B_Calendar;
        private System.Windows.Forms.Button button1;
    }
}

