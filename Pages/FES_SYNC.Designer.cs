
namespace Academy
{
    partial class FES_SYNC
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
            this.P_Sunday = new System.Windows.Forms.Panel();
            this.LB_TIME0 = new System.Windows.Forms.Label();
            this.LB_Workout0 = new System.Windows.Forms.Label();
            this.LB_Sunday = new System.Windows.Forms.Label();
            this.P_Monday = new System.Windows.Forms.Panel();
            this.LB_TIME1 = new System.Windows.Forms.Label();
            this.LB_Workout1 = new System.Windows.Forms.Label();
            this.LB_Monday = new System.Windows.Forms.Label();
            this.P_Tuesday = new System.Windows.Forms.Panel();
            this.LB_TIME2 = new System.Windows.Forms.Label();
            this.LB_Workout2 = new System.Windows.Forms.Label();
            this.LB_Tuesday = new System.Windows.Forms.Label();
            this.P_Wednesday = new System.Windows.Forms.Panel();
            this.LB_TIME3 = new System.Windows.Forms.Label();
            this.LB_Workout3 = new System.Windows.Forms.Label();
            this.LB_Wednesday = new System.Windows.Forms.Label();
            this.P_Thursday = new System.Windows.Forms.Panel();
            this.LB_TIME4 = new System.Windows.Forms.Label();
            this.LB_Workout4 = new System.Windows.Forms.Label();
            this.LB_Thursday = new System.Windows.Forms.Label();
            this.P_Friday = new System.Windows.Forms.Panel();
            this.LB_TIME5 = new System.Windows.Forms.Label();
            this.LB_Workout5 = new System.Windows.Forms.Label();
            this.LB_Friday = new System.Windows.Forms.Label();
            this.P_Saturday = new System.Windows.Forms.Panel();
            this.LB_TIME6 = new System.Windows.Forms.Label();
            this.LB_Workout6 = new System.Windows.Forms.Label();
            this.LB_Saturday = new System.Windows.Forms.Label();
            this.P_Sunday.SuspendLayout();
            this.P_Monday.SuspendLayout();
            this.P_Tuesday.SuspendLayout();
            this.P_Wednesday.SuspendLayout();
            this.P_Thursday.SuspendLayout();
            this.P_Friday.SuspendLayout();
            this.P_Saturday.SuspendLayout();
            this.SuspendLayout();
            // 
            // P_Sunday
            // 
            this.P_Sunday.BackColor = System.Drawing.Color.WhiteSmoke;
            this.P_Sunday.Controls.Add(this.LB_TIME0);
            this.P_Sunday.Controls.Add(this.LB_Workout0);
            this.P_Sunday.Controls.Add(this.LB_Sunday);
            this.P_Sunday.Location = new System.Drawing.Point(12, 12);
            this.P_Sunday.Name = "P_Sunday";
            this.P_Sunday.Size = new System.Drawing.Size(134, 121);
            this.P_Sunday.TabIndex = 5;
            this.P_Sunday.Tag = "Sunday";
            this.P_Sunday.Click += new System.EventHandler(this.AddDay);
            this.P_Sunday.Paint += new System.Windows.Forms.PaintEventHandler(this.P_Sunday_Paint);
            // 
            // LB_TIME0
            // 
            this.LB_TIME0.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TIME0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(94)))), ((int)(((byte)(234)))));
            this.LB_TIME0.Location = new System.Drawing.Point(0, 96);
            this.LB_TIME0.Name = "LB_TIME0";
            this.LB_TIME0.Size = new System.Drawing.Size(134, 25);
            this.LB_TIME0.TabIndex = 4;
            this.LB_TIME0.Tag = "SundayT";
            this.LB_TIME0.Text = "--:--";
            this.LB_TIME0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_TIME0.Click += new System.EventHandler(this.AddDay);
            // 
            // LB_Workout0
            // 
            this.LB_Workout0.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Workout0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(94)))), ((int)(((byte)(234)))));
            this.LB_Workout0.Location = new System.Drawing.Point(0, 47);
            this.LB_Workout0.Name = "LB_Workout0";
            this.LB_Workout0.Size = new System.Drawing.Size(134, 49);
            this.LB_Workout0.TabIndex = 3;
            this.LB_Workout0.Tag = "Sunday";
            this.LB_Workout0.Text = "Empty";
            this.LB_Workout0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Workout0.Click += new System.EventHandler(this.AddDay);
            // 
            // LB_Sunday
            // 
            this.LB_Sunday.BackColor = System.Drawing.Color.Transparent;
            this.LB_Sunday.Font = new System.Drawing.Font("Cascadia Code", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Sunday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(69)))), ((int)(((byte)(148)))));
            this.LB_Sunday.Location = new System.Drawing.Point(0, 0);
            this.LB_Sunday.Name = "LB_Sunday";
            this.LB_Sunday.Size = new System.Drawing.Size(134, 47);
            this.LB_Sunday.TabIndex = 2;
            this.LB_Sunday.Tag = "Sunday";
            this.LB_Sunday.Text = "Sunday";
            this.LB_Sunday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Sunday.Click += new System.EventHandler(this.AddDay);
            // 
            // P_Monday
            // 
            this.P_Monday.BackColor = System.Drawing.Color.WhiteSmoke;
            this.P_Monday.Controls.Add(this.LB_Monday);
            this.P_Monday.Controls.Add(this.LB_TIME1);
            this.P_Monday.Controls.Add(this.LB_Workout1);
            this.P_Monday.Location = new System.Drawing.Point(152, 12);
            this.P_Monday.Name = "P_Monday";
            this.P_Monday.Size = new System.Drawing.Size(134, 121);
            this.P_Monday.TabIndex = 6;
            this.P_Monday.Tag = "Monday";
            this.P_Monday.Click += new System.EventHandler(this.AddDay);
            // 
            // LB_TIME1
            // 
            this.LB_TIME1.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TIME1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(94)))), ((int)(((byte)(234)))));
            this.LB_TIME1.Location = new System.Drawing.Point(0, 96);
            this.LB_TIME1.Name = "LB_TIME1";
            this.LB_TIME1.Size = new System.Drawing.Size(134, 25);
            this.LB_TIME1.TabIndex = 5;
            this.LB_TIME1.Tag = "MondayT";
            this.LB_TIME1.Text = "--:--";
            this.LB_TIME1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_TIME1.Click += new System.EventHandler(this.AddDay);
            // 
            // LB_Workout1
            // 
            this.LB_Workout1.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Workout1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(94)))), ((int)(((byte)(234)))));
            this.LB_Workout1.Location = new System.Drawing.Point(0, 47);
            this.LB_Workout1.Name = "LB_Workout1";
            this.LB_Workout1.Size = new System.Drawing.Size(134, 49);
            this.LB_Workout1.TabIndex = 4;
            this.LB_Workout1.Tag = "Monday";
            this.LB_Workout1.Text = "Empty";
            this.LB_Workout1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Workout1.Click += new System.EventHandler(this.AddDay);
            // 
            // LB_Monday
            // 
            this.LB_Monday.BackColor = System.Drawing.Color.Transparent;
            this.LB_Monday.Font = new System.Drawing.Font("Cascadia Code", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Monday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(69)))), ((int)(((byte)(148)))));
            this.LB_Monday.Location = new System.Drawing.Point(0, 0);
            this.LB_Monday.Name = "LB_Monday";
            this.LB_Monday.Size = new System.Drawing.Size(134, 47);
            this.LB_Monday.TabIndex = 2;
            this.LB_Monday.Tag = "Monday";
            this.LB_Monday.Text = "Monday";
            this.LB_Monday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Monday.Click += new System.EventHandler(this.AddDay);
            // 
            // P_Tuesday
            // 
            this.P_Tuesday.BackColor = System.Drawing.Color.WhiteSmoke;
            this.P_Tuesday.Controls.Add(this.LB_TIME2);
            this.P_Tuesday.Controls.Add(this.LB_Workout2);
            this.P_Tuesday.Controls.Add(this.LB_Tuesday);
            this.P_Tuesday.Location = new System.Drawing.Point(292, 12);
            this.P_Tuesday.Name = "P_Tuesday";
            this.P_Tuesday.Size = new System.Drawing.Size(134, 121);
            this.P_Tuesday.TabIndex = 6;
            this.P_Tuesday.Tag = "Tuesday";
            this.P_Tuesday.Click += new System.EventHandler(this.AddDay);
            // 
            // LB_TIME2
            // 
            this.LB_TIME2.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TIME2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(94)))), ((int)(((byte)(234)))));
            this.LB_TIME2.Location = new System.Drawing.Point(0, 96);
            this.LB_TIME2.Name = "LB_TIME2";
            this.LB_TIME2.Size = new System.Drawing.Size(134, 25);
            this.LB_TIME2.TabIndex = 6;
            this.LB_TIME2.Tag = "TuesdayT";
            this.LB_TIME2.Text = "--:--";
            this.LB_TIME2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_TIME2.Click += new System.EventHandler(this.AddDay);
            // 
            // LB_Workout2
            // 
            this.LB_Workout2.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Workout2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(94)))), ((int)(((byte)(234)))));
            this.LB_Workout2.Location = new System.Drawing.Point(1, 47);
            this.LB_Workout2.Name = "LB_Workout2";
            this.LB_Workout2.Size = new System.Drawing.Size(134, 49);
            this.LB_Workout2.TabIndex = 5;
            this.LB_Workout2.Tag = "Tuesday";
            this.LB_Workout2.Text = "Empty";
            this.LB_Workout2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Workout2.Click += new System.EventHandler(this.AddDay);
            // 
            // LB_Tuesday
            // 
            this.LB_Tuesday.BackColor = System.Drawing.Color.Transparent;
            this.LB_Tuesday.Font = new System.Drawing.Font("Cascadia Code", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Tuesday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(69)))), ((int)(((byte)(148)))));
            this.LB_Tuesday.Location = new System.Drawing.Point(0, 0);
            this.LB_Tuesday.Name = "LB_Tuesday";
            this.LB_Tuesday.Size = new System.Drawing.Size(134, 47);
            this.LB_Tuesday.TabIndex = 2;
            this.LB_Tuesday.Tag = "Tuesday";
            this.LB_Tuesday.Text = "Tuesday";
            this.LB_Tuesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Tuesday.Click += new System.EventHandler(this.AddDay);
            // 
            // P_Wednesday
            // 
            this.P_Wednesday.BackColor = System.Drawing.Color.WhiteSmoke;
            this.P_Wednesday.Controls.Add(this.LB_TIME3);
            this.P_Wednesday.Controls.Add(this.LB_Workout3);
            this.P_Wednesday.Controls.Add(this.LB_Wednesday);
            this.P_Wednesday.Location = new System.Drawing.Point(432, 12);
            this.P_Wednesday.Name = "P_Wednesday";
            this.P_Wednesday.Size = new System.Drawing.Size(134, 121);
            this.P_Wednesday.TabIndex = 6;
            this.P_Wednesday.Tag = "Wednesday";
            this.P_Wednesday.Click += new System.EventHandler(this.AddDay);
            // 
            // LB_TIME3
            // 
            this.LB_TIME3.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TIME3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(94)))), ((int)(((byte)(234)))));
            this.LB_TIME3.Location = new System.Drawing.Point(0, 96);
            this.LB_TIME3.Name = "LB_TIME3";
            this.LB_TIME3.Size = new System.Drawing.Size(134, 25);
            this.LB_TIME3.TabIndex = 7;
            this.LB_TIME3.Tag = "WednesdayT";
            this.LB_TIME3.Text = "--:--";
            this.LB_TIME3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_TIME3.Click += new System.EventHandler(this.AddDay);
            // 
            // LB_Workout3
            // 
            this.LB_Workout3.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Workout3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(94)))), ((int)(((byte)(234)))));
            this.LB_Workout3.Location = new System.Drawing.Point(0, 47);
            this.LB_Workout3.Name = "LB_Workout3";
            this.LB_Workout3.Size = new System.Drawing.Size(134, 49);
            this.LB_Workout3.TabIndex = 6;
            this.LB_Workout3.Tag = "Wednesday";
            this.LB_Workout3.Text = "Empty";
            this.LB_Workout3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Workout3.Click += new System.EventHandler(this.AddDay);
            // 
            // LB_Wednesday
            // 
            this.LB_Wednesday.BackColor = System.Drawing.Color.Transparent;
            this.LB_Wednesday.Font = new System.Drawing.Font("Cascadia Code", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Wednesday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(69)))), ((int)(((byte)(148)))));
            this.LB_Wednesday.Location = new System.Drawing.Point(-4, 0);
            this.LB_Wednesday.Name = "LB_Wednesday";
            this.LB_Wednesday.Size = new System.Drawing.Size(147, 47);
            this.LB_Wednesday.TabIndex = 2;
            this.LB_Wednesday.Tag = "Wednesday";
            this.LB_Wednesday.Text = "Wednesday";
            this.LB_Wednesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Wednesday.Click += new System.EventHandler(this.AddDay);
            // 
            // P_Thursday
            // 
            this.P_Thursday.BackColor = System.Drawing.Color.WhiteSmoke;
            this.P_Thursday.Controls.Add(this.LB_TIME4);
            this.P_Thursday.Controls.Add(this.LB_Workout4);
            this.P_Thursday.Controls.Add(this.LB_Thursday);
            this.P_Thursday.Location = new System.Drawing.Point(572, 12);
            this.P_Thursday.Name = "P_Thursday";
            this.P_Thursday.Size = new System.Drawing.Size(134, 121);
            this.P_Thursday.TabIndex = 6;
            this.P_Thursday.Tag = "Thursday";
            this.P_Thursday.Click += new System.EventHandler(this.AddDay);
            // 
            // LB_TIME4
            // 
            this.LB_TIME4.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TIME4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(94)))), ((int)(((byte)(234)))));
            this.LB_TIME4.Location = new System.Drawing.Point(0, 96);
            this.LB_TIME4.Name = "LB_TIME4";
            this.LB_TIME4.Size = new System.Drawing.Size(134, 25);
            this.LB_TIME4.TabIndex = 8;
            this.LB_TIME4.Tag = "ThursdayT";
            this.LB_TIME4.Text = "--:--";
            this.LB_TIME4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_TIME4.Click += new System.EventHandler(this.AddDay);
            // 
            // LB_Workout4
            // 
            this.LB_Workout4.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Workout4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(94)))), ((int)(((byte)(234)))));
            this.LB_Workout4.Location = new System.Drawing.Point(0, 47);
            this.LB_Workout4.Name = "LB_Workout4";
            this.LB_Workout4.Size = new System.Drawing.Size(134, 49);
            this.LB_Workout4.TabIndex = 7;
            this.LB_Workout4.Tag = "Thursday";
            this.LB_Workout4.Text = "Empty";
            this.LB_Workout4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Workout4.Click += new System.EventHandler(this.AddDay);
            // 
            // LB_Thursday
            // 
            this.LB_Thursday.BackColor = System.Drawing.Color.Transparent;
            this.LB_Thursday.Font = new System.Drawing.Font("Cascadia Code", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Thursday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(69)))), ((int)(((byte)(148)))));
            this.LB_Thursday.Location = new System.Drawing.Point(0, 0);
            this.LB_Thursday.Name = "LB_Thursday";
            this.LB_Thursday.Size = new System.Drawing.Size(134, 47);
            this.LB_Thursday.TabIndex = 2;
            this.LB_Thursday.Tag = "Thursday";
            this.LB_Thursday.Text = "Thursday";
            this.LB_Thursday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Thursday.Click += new System.EventHandler(this.AddDay);
            // 
            // P_Friday
            // 
            this.P_Friday.BackColor = System.Drawing.Color.WhiteSmoke;
            this.P_Friday.Controls.Add(this.LB_TIME5);
            this.P_Friday.Controls.Add(this.LB_Workout5);
            this.P_Friday.Controls.Add(this.LB_Friday);
            this.P_Friday.Location = new System.Drawing.Point(712, 12);
            this.P_Friday.Name = "P_Friday";
            this.P_Friday.Size = new System.Drawing.Size(134, 121);
            this.P_Friday.TabIndex = 7;
            this.P_Friday.Tag = "Friday";
            this.P_Friday.Click += new System.EventHandler(this.AddDay);
            // 
            // LB_TIME5
            // 
            this.LB_TIME5.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TIME5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(94)))), ((int)(((byte)(234)))));
            this.LB_TIME5.Location = new System.Drawing.Point(0, 96);
            this.LB_TIME5.Name = "LB_TIME5";
            this.LB_TIME5.Size = new System.Drawing.Size(134, 25);
            this.LB_TIME5.TabIndex = 9;
            this.LB_TIME5.Tag = "FridayT";
            this.LB_TIME5.Text = "--:--";
            this.LB_TIME5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_TIME5.Click += new System.EventHandler(this.AddDay);
            // 
            // LB_Workout5
            // 
            this.LB_Workout5.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Workout5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(94)))), ((int)(((byte)(234)))));
            this.LB_Workout5.Location = new System.Drawing.Point(0, 47);
            this.LB_Workout5.Name = "LB_Workout5";
            this.LB_Workout5.Size = new System.Drawing.Size(134, 49);
            this.LB_Workout5.TabIndex = 8;
            this.LB_Workout5.Tag = "Friday";
            this.LB_Workout5.Text = "Empty";
            this.LB_Workout5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Workout5.Click += new System.EventHandler(this.AddDay);
            // 
            // LB_Friday
            // 
            this.LB_Friday.BackColor = System.Drawing.Color.Transparent;
            this.LB_Friday.Font = new System.Drawing.Font("Cascadia Code", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Friday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(69)))), ((int)(((byte)(148)))));
            this.LB_Friday.Location = new System.Drawing.Point(0, 0);
            this.LB_Friday.Name = "LB_Friday";
            this.LB_Friday.Size = new System.Drawing.Size(134, 47);
            this.LB_Friday.TabIndex = 2;
            this.LB_Friday.Tag = "Friday";
            this.LB_Friday.Text = "Friday";
            this.LB_Friday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Friday.Click += new System.EventHandler(this.AddDay);
            // 
            // P_Saturday
            // 
            this.P_Saturday.BackColor = System.Drawing.Color.WhiteSmoke;
            this.P_Saturday.Controls.Add(this.LB_TIME6);
            this.P_Saturday.Controls.Add(this.LB_Workout6);
            this.P_Saturday.Controls.Add(this.LB_Saturday);
            this.P_Saturday.Location = new System.Drawing.Point(852, 12);
            this.P_Saturday.Name = "P_Saturday";
            this.P_Saturday.Size = new System.Drawing.Size(134, 121);
            this.P_Saturday.TabIndex = 8;
            this.P_Saturday.Tag = "Saturday";
            this.P_Saturday.Click += new System.EventHandler(this.AddDay);
            // 
            // LB_TIME6
            // 
            this.LB_TIME6.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TIME6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(94)))), ((int)(((byte)(234)))));
            this.LB_TIME6.Location = new System.Drawing.Point(0, 96);
            this.LB_TIME6.Name = "LB_TIME6";
            this.LB_TIME6.Size = new System.Drawing.Size(134, 25);
            this.LB_TIME6.TabIndex = 10;
            this.LB_TIME6.Tag = "SaturdayT";
            this.LB_TIME6.Text = "--:--";
            this.LB_TIME6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_TIME6.Click += new System.EventHandler(this.AddDay);
            // 
            // LB_Workout6
            // 
            this.LB_Workout6.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Workout6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(94)))), ((int)(((byte)(234)))));
            this.LB_Workout6.Location = new System.Drawing.Point(0, 47);
            this.LB_Workout6.Name = "LB_Workout6";
            this.LB_Workout6.Size = new System.Drawing.Size(134, 49);
            this.LB_Workout6.TabIndex = 9;
            this.LB_Workout6.Tag = "Saturday";
            this.LB_Workout6.Text = "Empty";
            this.LB_Workout6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Workout6.Click += new System.EventHandler(this.AddDay);
            // 
            // LB_Saturday
            // 
            this.LB_Saturday.BackColor = System.Drawing.Color.Transparent;
            this.LB_Saturday.Font = new System.Drawing.Font("Cascadia Code", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Saturday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(69)))), ((int)(((byte)(148)))));
            this.LB_Saturday.Location = new System.Drawing.Point(0, 0);
            this.LB_Saturday.Name = "LB_Saturday";
            this.LB_Saturday.Size = new System.Drawing.Size(134, 47);
            this.LB_Saturday.TabIndex = 2;
            this.LB_Saturday.Tag = "Saturday";
            this.LB_Saturday.Text = "Saturday";
            this.LB_Saturday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Saturday.Click += new System.EventHandler(this.AddDay);
            // 
            // FES_SYNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1000, 145);
            this.Controls.Add(this.P_Saturday);
            this.Controls.Add(this.P_Friday);
            this.Controls.Add(this.P_Thursday);
            this.Controls.Add(this.P_Wednesday);
            this.Controls.Add(this.P_Tuesday);
            this.Controls.Add(this.P_Monday);
            this.Controls.Add(this.P_Sunday);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FES_SYNC";
            this.Text = "[Academy]";
            this.Load += new System.EventHandler(this.FES_SYNC_Load);
            this.P_Sunday.ResumeLayout(false);
            this.P_Monday.ResumeLayout(false);
            this.P_Tuesday.ResumeLayout(false);
            this.P_Wednesday.ResumeLayout(false);
            this.P_Thursday.ResumeLayout(false);
            this.P_Friday.ResumeLayout(false);
            this.P_Saturday.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LB_Sunday;
        private System.Windows.Forms.Label LB_Monday;
        private System.Windows.Forms.Label LB_Tuesday;
        private System.Windows.Forms.Label LB_Wednesday;
        private System.Windows.Forms.Label LB_Thursday;
        private System.Windows.Forms.Label LB_Friday;
        private System.Windows.Forms.Label LB_Saturday;
        private System.Windows.Forms.Label LB_Workout0;
        private System.Windows.Forms.Label LB_Workout1;
        private System.Windows.Forms.Label LB_Workout2;
        private System.Windows.Forms.Label LB_Workout3;
        private System.Windows.Forms.Label LB_Workout4;
        private System.Windows.Forms.Label LB_Workout5;
        private System.Windows.Forms.Label LB_Workout6;
        public System.Windows.Forms.Panel P_Sunday;
        public System.Windows.Forms.Panel P_Monday;
        public System.Windows.Forms.Panel P_Tuesday;
        public System.Windows.Forms.Panel P_Wednesday;
        public System.Windows.Forms.Panel P_Thursday;
        public System.Windows.Forms.Panel P_Friday;
        public System.Windows.Forms.Panel P_Saturday;
        private System.Windows.Forms.Label LB_TIME0;
        private System.Windows.Forms.Label LB_TIME1;
        private System.Windows.Forms.Label LB_TIME2;
        private System.Windows.Forms.Label LB_TIME3;
        private System.Windows.Forms.Label LB_TIME4;
        private System.Windows.Forms.Label LB_TIME5;
        private System.Windows.Forms.Label LB_TIME6;
    }
}