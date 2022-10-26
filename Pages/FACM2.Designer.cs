namespace Academy
{
    partial class FACM2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FACM2));
            this.LB_TGoal = new System.Windows.Forms.Label();
            this.CB_Goal = new System.Windows.Forms.ComboBox();
            this.LB_PI = new System.Windows.Forms.Label();
            this.LB_MealsDay = new System.Windows.Forms.Label();
            this.TRB_PI = new System.Windows.Forms.TrackBar();
            this.LB_PIMin = new System.Windows.Forms.Label();
            this.LB_PIMax = new System.Windows.Forms.Label();
            this.LB_FIMax = new System.Windows.Forms.Label();
            this.LB_FIMin = new System.Windows.Forms.Label();
            this.TRB_FI = new System.Windows.Forms.TrackBar();
            this.LB_FI = new System.Windows.Forms.Label();
            this.LB_MDCalories = new System.Windows.Forms.Label();
            this.LB_MDFats = new System.Windows.Forms.Label();
            this.LB_MDProtein = new System.Windows.Forms.Label();
            this.LB_MDCarbs = new System.Windows.Forms.Label();
            this.LB_MealsWeek = new System.Windows.Forms.Label();
            this.LB_MWCalories = new System.Windows.Forms.Label();
            this.LB_MWFat = new System.Windows.Forms.Label();
            this.LB_MWProtein = new System.Windows.Forms.Label();
            this.LB_MWCarbs = new System.Windows.Forms.Label();
            this.CB_AL = new System.Windows.Forms.ComboBox();
            this.LB_AL = new System.Windows.Forms.Label();
            this.LB_Wkg = new System.Windows.Forms.Label();
            this.NUP_Weight = new System.Windows.Forms.NumericUpDown();
            this.LB_TW = new System.Windows.Forms.Label();
            this.B_Save = new System.Windows.Forms.Button();
            this.CB_XP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TRB_PI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRB_FI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUP_Weight)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_TGoal
            // 
            this.LB_TGoal.AutoSize = true;
            this.LB_TGoal.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(180)))), ((int)(((byte)(252)))));
            this.LB_TGoal.Location = new System.Drawing.Point(12, 9);
            this.LB_TGoal.Name = "LB_TGoal";
            this.LB_TGoal.Size = new System.Drawing.Size(146, 47);
            this.LB_TGoal.TabIndex = 194;
            this.LB_TGoal.Text = "[Goal]";
            this.LB_TGoal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CB_Goal
            // 
            this.CB_Goal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(69)))), ((int)(((byte)(148)))));
            this.CB_Goal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Goal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Goal.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Goal.ForeColor = System.Drawing.SystemColors.Window;
            this.CB_Goal.FormattingEnabled = true;
            this.CB_Goal.Items.AddRange(new object[] {
            "Select a Goal",
            "Bulking",
            "Recomp",
            "Cutting"});
            this.CB_Goal.Location = new System.Drawing.Point(158, 22);
            this.CB_Goal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_Goal.Name = "CB_Goal";
            this.CB_Goal.Size = new System.Drawing.Size(201, 29);
            this.CB_Goal.TabIndex = 195;
            this.CB_Goal.SelectedIndexChanged += new System.EventHandler(this.CB_Goal_SelectedIndexChanged);
            this.CB_Goal.Click += new System.EventHandler(this.CB_Goal_Click);
            // 
            // LB_PI
            // 
            this.LB_PI.AutoSize = true;
            this.LB_PI.Font = new System.Drawing.Font("Cascadia Mono", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_PI.Location = new System.Drawing.Point(14, 172);
            this.LB_PI.Name = "LB_PI";
            this.LB_PI.Size = new System.Drawing.Size(337, 37);
            this.LB_PI.TabIndex = 196;
            this.LB_PI.Text = "Protein Intake - [ ]";
            // 
            // LB_MealsDay
            // 
            this.LB_MealsDay.AutoSize = true;
            this.LB_MealsDay.Font = new System.Drawing.Font("Cascadia Mono", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MealsDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(180)))), ((int)(((byte)(252)))));
            this.LB_MealsDay.Location = new System.Drawing.Point(394, 172);
            this.LB_MealsDay.Name = "LB_MealsDay";
            this.LB_MealsDay.Size = new System.Drawing.Size(193, 37);
            this.LB_MealsDay.TabIndex = 197;
            this.LB_MealsDay.Text = "- Meals/Day";
            this.LB_MealsDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TRB_PI
            // 
            this.TRB_PI.Enabled = false;
            this.TRB_PI.LargeChange = 10;
            this.TRB_PI.Location = new System.Drawing.Point(20, 232);
            this.TRB_PI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TRB_PI.Maximum = 270;
            this.TRB_PI.Minimum = 180;
            this.TRB_PI.Name = "TRB_PI";
            this.TRB_PI.Size = new System.Drawing.Size(331, 69);
            this.TRB_PI.TabIndex = 207;
            this.TRB_PI.TickFrequency = 10;
            this.TRB_PI.Value = 180;
            this.TRB_PI.Scroll += new System.EventHandler(this.TRB_PI_Scroll);
            // 
            // LB_PIMin
            // 
            this.LB_PIMin.AutoSize = true;
            this.LB_PIMin.Font = new System.Drawing.Font("Cascadia Mono", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PIMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_PIMin.Location = new System.Drawing.Point(8, 269);
            this.LB_PIMin.Name = "LB_PIMin";
            this.LB_PIMin.Size = new System.Drawing.Size(65, 37);
            this.LB_PIMin.TabIndex = 208;
            this.LB_PIMin.Text = "1.8";
            this.LB_PIMin.Visible = false;
            // 
            // LB_PIMax
            // 
            this.LB_PIMax.AutoSize = true;
            this.LB_PIMax.Font = new System.Drawing.Font("Cascadia Mono", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_PIMax.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_PIMax.Location = new System.Drawing.Point(300, 269);
            this.LB_PIMax.Name = "LB_PIMax";
            this.LB_PIMax.Size = new System.Drawing.Size(65, 37);
            this.LB_PIMax.TabIndex = 209;
            this.LB_PIMax.Text = "2.7";
            this.LB_PIMax.Visible = false;
            // 
            // LB_FIMax
            // 
            this.LB_FIMax.AutoSize = true;
            this.LB_FIMax.Font = new System.Drawing.Font("Cascadia Mono", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_FIMax.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_FIMax.Location = new System.Drawing.Point(300, 438);
            this.LB_FIMax.Name = "LB_FIMax";
            this.LB_FIMax.Size = new System.Drawing.Size(65, 37);
            this.LB_FIMax.TabIndex = 213;
            this.LB_FIMax.Text = "25%";
            this.LB_FIMax.Visible = false;
            // 
            // LB_FIMin
            // 
            this.LB_FIMin.AutoSize = true;
            this.LB_FIMin.Font = new System.Drawing.Font("Cascadia Mono", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_FIMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_FIMin.Location = new System.Drawing.Point(14, 438);
            this.LB_FIMin.Name = "LB_FIMin";
            this.LB_FIMin.Size = new System.Drawing.Size(65, 37);
            this.LB_FIMin.TabIndex = 212;
            this.LB_FIMin.Text = "20%";
            this.LB_FIMin.Visible = false;
            // 
            // TRB_FI
            // 
            this.TRB_FI.Enabled = false;
            this.TRB_FI.LargeChange = 1;
            this.TRB_FI.Location = new System.Drawing.Point(20, 400);
            this.TRB_FI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TRB_FI.Maximum = 25;
            this.TRB_FI.Minimum = 20;
            this.TRB_FI.Name = "TRB_FI";
            this.TRB_FI.Size = new System.Drawing.Size(331, 69);
            this.TRB_FI.TabIndex = 211;
            this.TRB_FI.Value = 20;
            this.TRB_FI.Scroll += new System.EventHandler(this.TRB_FI_Scroll);
            // 
            // LB_FI
            // 
            this.LB_FI.AutoSize = true;
            this.LB_FI.Font = new System.Drawing.Font("Cascadia Mono", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_FI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_FI.Location = new System.Drawing.Point(14, 340);
            this.LB_FI.Name = "LB_FI";
            this.LB_FI.Size = new System.Drawing.Size(273, 37);
            this.LB_FI.TabIndex = 210;
            this.LB_FI.Text = "Fat Intake - [ ]";
            // 
            // LB_MDCalories
            // 
            this.LB_MDCalories.AutoSize = true;
            this.LB_MDCalories.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MDCalories.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_MDCalories.Location = new System.Drawing.Point(428, 296);
            this.LB_MDCalories.Name = "LB_MDCalories";
            this.LB_MDCalories.Size = new System.Drawing.Size(210, 32);
            this.LB_MDCalories.TabIndex = 216;
            this.LB_MDCalories.Text = "Calories - [ ]";
            this.LB_MDCalories.Click += new System.EventHandler(this.label1_Click);
            // 
            // LB_MDFats
            // 
            this.LB_MDFats.AutoSize = true;
            this.LB_MDFats.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MDFats.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_MDFats.Location = new System.Drawing.Point(428, 268);
            this.LB_MDFats.Name = "LB_MDFats";
            this.LB_MDFats.Size = new System.Drawing.Size(154, 32);
            this.LB_MDFats.TabIndex = 217;
            this.LB_MDFats.Text = "Fat - [ ] ";
            this.LB_MDFats.Click += new System.EventHandler(this.label2_Click);
            // 
            // LB_MDProtein
            // 
            this.LB_MDProtein.AutoSize = true;
            this.LB_MDProtein.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MDProtein.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_MDProtein.Location = new System.Drawing.Point(428, 238);
            this.LB_MDProtein.Name = "LB_MDProtein";
            this.LB_MDProtein.Size = new System.Drawing.Size(196, 32);
            this.LB_MDProtein.TabIndex = 215;
            this.LB_MDProtein.Text = "Protein - [ ]";
            this.LB_MDProtein.Click += new System.EventHandler(this.label3_Click);
            // 
            // LB_MDCarbs
            // 
            this.LB_MDCarbs.AutoSize = true;
            this.LB_MDCarbs.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MDCarbs.ForeColor = System.Drawing.Color.White;
            this.LB_MDCarbs.Location = new System.Drawing.Point(428, 208);
            this.LB_MDCarbs.Name = "LB_MDCarbs";
            this.LB_MDCarbs.Size = new System.Drawing.Size(168, 32);
            this.LB_MDCarbs.TabIndex = 214;
            this.LB_MDCarbs.Text = "Carbs - [ ]";
            this.LB_MDCarbs.Click += new System.EventHandler(this.label4_Click);
            // 
            // LB_MealsWeek
            // 
            this.LB_MealsWeek.AutoSize = true;
            this.LB_MealsWeek.Font = new System.Drawing.Font("Cascadia Mono", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MealsWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(180)))), ((int)(((byte)(252)))));
            this.LB_MealsWeek.Location = new System.Drawing.Point(394, 340);
            this.LB_MealsWeek.Name = "LB_MealsWeek";
            this.LB_MealsWeek.Size = new System.Drawing.Size(209, 37);
            this.LB_MealsWeek.TabIndex = 218;
            this.LB_MealsWeek.Text = "- Meals/Week";
            this.LB_MealsWeek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_MWCalories
            // 
            this.LB_MWCalories.AutoSize = true;
            this.LB_MWCalories.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MWCalories.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_MWCalories.Location = new System.Drawing.Point(428, 464);
            this.LB_MWCalories.Name = "LB_MWCalories";
            this.LB_MWCalories.Size = new System.Drawing.Size(210, 32);
            this.LB_MWCalories.TabIndex = 221;
            this.LB_MWCalories.Text = "Calories - [ ]";
            // 
            // LB_MWFat
            // 
            this.LB_MWFat.AutoSize = true;
            this.LB_MWFat.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MWFat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_MWFat.Location = new System.Drawing.Point(428, 435);
            this.LB_MWFat.Name = "LB_MWFat";
            this.LB_MWFat.Size = new System.Drawing.Size(154, 32);
            this.LB_MWFat.TabIndex = 222;
            this.LB_MWFat.Text = "Fat - [ ] ";
            // 
            // LB_MWProtein
            // 
            this.LB_MWProtein.AutoSize = true;
            this.LB_MWProtein.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MWProtein.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_MWProtein.Location = new System.Drawing.Point(428, 405);
            this.LB_MWProtein.Name = "LB_MWProtein";
            this.LB_MWProtein.Size = new System.Drawing.Size(196, 32);
            this.LB_MWProtein.TabIndex = 220;
            this.LB_MWProtein.Text = "Protein - [ ]";
            // 
            // LB_MWCarbs
            // 
            this.LB_MWCarbs.AutoSize = true;
            this.LB_MWCarbs.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MWCarbs.ForeColor = System.Drawing.Color.White;
            this.LB_MWCarbs.Location = new System.Drawing.Point(428, 376);
            this.LB_MWCarbs.Name = "LB_MWCarbs";
            this.LB_MWCarbs.Size = new System.Drawing.Size(168, 32);
            this.LB_MWCarbs.TabIndex = 219;
            this.LB_MWCarbs.Text = "Carbs - [ ]";
            // 
            // CB_AL
            // 
            this.CB_AL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(69)))), ((int)(((byte)(148)))));
            this.CB_AL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_AL.Enabled = false;
            this.CB_AL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_AL.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_AL.ForeColor = System.Drawing.SystemColors.Window;
            this.CB_AL.FormattingEnabled = true;
            this.CB_AL.Items.AddRange(new object[] {
            "Select a Level",
            "Sedentary little to no exercise",
            "Light exercise 1-3 days/week",
            "Moderate exercise 3-4 days/week",
            "Intense exercise 4-5 days/week",
            "Very Intense exercise 6-7 days/week",
            "Extra Intense exercise 7 days/week"});
            this.CB_AL.Location = new System.Drawing.Point(21, 119);
            this.CB_AL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_AL.Name = "CB_AL";
            this.CB_AL.Size = new System.Drawing.Size(337, 29);
            this.CB_AL.TabIndex = 223;
            this.CB_AL.SelectedIndexChanged += new System.EventHandler(this.CB_AL_SelectedIndexChanged);
            // 
            // LB_AL
            // 
            this.LB_AL.AutoSize = true;
            this.LB_AL.Font = new System.Drawing.Font("Cascadia Mono", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_AL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_AL.Location = new System.Drawing.Point(14, 79);
            this.LB_AL.Name = "LB_AL";
            this.LB_AL.Size = new System.Drawing.Size(257, 37);
            this.LB_AL.TabIndex = 224;
            this.LB_AL.Text = "Activity Level:";
            // 
            // LB_Wkg
            // 
            this.LB_Wkg.BackColor = System.Drawing.Color.White;
            this.LB_Wkg.Enabled = false;
            this.LB_Wkg.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Wkg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LB_Wkg.Location = new System.Drawing.Point(615, 120);
            this.LB_Wkg.Name = "LB_Wkg";
            this.LB_Wkg.Size = new System.Drawing.Size(28, 28);
            this.LB_Wkg.TabIndex = 226;
            this.LB_Wkg.Text = "kg";
            // 
            // NUP_Weight
            // 
            this.NUP_Weight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUP_Weight.DecimalPlaces = 1;
            this.NUP_Weight.Enabled = false;
            this.NUP_Weight.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUP_Weight.Location = new System.Drawing.Point(433, 119);
            this.NUP_Weight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NUP_Weight.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.NUP_Weight.Name = "NUP_Weight";
            this.NUP_Weight.Size = new System.Drawing.Size(212, 26);
            this.NUP_Weight.TabIndex = 225;
            // 
            // LB_TW
            // 
            this.LB_TW.AutoSize = true;
            this.LB_TW.Font = new System.Drawing.Font("Cascadia Mono", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TW.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_TW.Location = new System.Drawing.Point(426, 79);
            this.LB_TW.Name = "LB_TW";
            this.LB_TW.Size = new System.Drawing.Size(241, 37);
            this.LB_TW.TabIndex = 227;
            this.LB_TW.Text = "Target Weight:";
            // 
            // B_Save
            // 
            this.B_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.B_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.B_Save.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.B_Save.FlatAppearance.BorderSize = 2;
            this.B_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Save.Font = new System.Drawing.Font("Cascadia Mono", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.B_Save.Location = new System.Drawing.Point(276, 508);
            this.B_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(225, 61);
            this.B_Save.TabIndex = 228;
            this.B_Save.Text = "Save";
            this.B_Save.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.B_Save.UseVisualStyleBackColor = false;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // CB_XP
            // 
            this.CB_XP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(69)))), ((int)(((byte)(148)))));
            this.CB_XP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_XP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_XP.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_XP.ForeColor = System.Drawing.SystemColors.Window;
            this.CB_XP.FormattingEnabled = true;
            this.CB_XP.Items.AddRange(new object[] {
            "Select a Level",
            "Beginner (<2 years)",
            "Intermediate (2-5 years)",
            "Advanced (>5 years)"});
            this.CB_XP.Location = new System.Drawing.Point(485, 22);
            this.CB_XP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_XP.Name = "CB_XP";
            this.CB_XP.Size = new System.Drawing.Size(260, 29);
            this.CB_XP.TabIndex = 230;
            this.CB_XP.SelectedIndexChanged += new System.EventHandler(this.CB_XP_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(180)))), ((int)(((byte)(252)))));
            this.label1.Location = new System.Drawing.Point(386, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 47);
            this.label1.TabIndex = 229;
            this.label1.Text = "[XP]";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FACM2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(776, 580);
            this.Controls.Add(this.CB_XP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.LB_TW);
            this.Controls.Add(this.LB_Wkg);
            this.Controls.Add(this.NUP_Weight);
            this.Controls.Add(this.LB_AL);
            this.Controls.Add(this.CB_AL);
            this.Controls.Add(this.LB_MealsWeek);
            this.Controls.Add(this.LB_MWCalories);
            this.Controls.Add(this.LB_MWFat);
            this.Controls.Add(this.LB_MWProtein);
            this.Controls.Add(this.LB_MWCarbs);
            this.Controls.Add(this.LB_FIMax);
            this.Controls.Add(this.LB_FIMin);
            this.Controls.Add(this.TRB_FI);
            this.Controls.Add(this.LB_FI);
            this.Controls.Add(this.LB_PIMax);
            this.Controls.Add(this.LB_PIMin);
            this.Controls.Add(this.TRB_PI);
            this.Controls.Add(this.LB_MealsDay);
            this.Controls.Add(this.LB_PI);
            this.Controls.Add(this.CB_Goal);
            this.Controls.Add(this.LB_TGoal);
            this.Controls.Add(this.LB_MDCalories);
            this.Controls.Add(this.LB_MDFats);
            this.Controls.Add(this.LB_MDProtein);
            this.Controls.Add(this.LB_MDCarbs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FACM2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "- [Academy]";
            this.Load += new System.EventHandler(this.FACM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TRB_PI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRB_FI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUP_Weight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LB_TGoal;
        public System.Windows.Forms.ComboBox CB_Goal;
        public System.Windows.Forms.Label LB_PI;
        public System.Windows.Forms.Label LB_MealsDay;
        private System.Windows.Forms.TrackBar TRB_PI;
        public System.Windows.Forms.Label LB_PIMin;
        public System.Windows.Forms.Label LB_PIMax;
        public System.Windows.Forms.Label LB_FIMax;
        public System.Windows.Forms.Label LB_FIMin;
        private System.Windows.Forms.TrackBar TRB_FI;
        public System.Windows.Forms.Label LB_FI;
        public System.Windows.Forms.Label LB_MDCalories;
        public System.Windows.Forms.Label LB_MDFats;
        public System.Windows.Forms.Label LB_MDProtein;
        public System.Windows.Forms.Label LB_MDCarbs;
        public System.Windows.Forms.Label LB_MealsWeek;
        public System.Windows.Forms.Label LB_MWCalories;
        public System.Windows.Forms.Label LB_MWFat;
        public System.Windows.Forms.Label LB_MWProtein;
        public System.Windows.Forms.Label LB_MWCarbs;
        public System.Windows.Forms.ComboBox CB_AL;
        public System.Windows.Forms.Label LB_AL;
        private System.Windows.Forms.Label LB_Wkg;
        private System.Windows.Forms.NumericUpDown NUP_Weight;
        public System.Windows.Forms.Label LB_TW;
        private System.Windows.Forms.Button B_Save;
        public System.Windows.Forms.ComboBox CB_XP;
        public System.Windows.Forms.Label label1;
    }
}