namespace Academy
{
    partial class FMS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMS));
            this.DGV = new System.Windows.Forms.DataGridView();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.LB_Name = new System.Windows.Forms.Label();
            this.TB_Quant = new System.Windows.Forms.TextBox();
            this.LB_Time = new System.Windows.Forms.Label();
            this.CB_Time = new System.Windows.Forms.ComboBox();
            this.LB_Igdt = new System.Windows.Forms.Label();
            this.CB_Igdt = new System.Windows.Forms.ComboBox();
            this.LB_Quant = new System.Windows.Forms.Label();
            this.B_Remove = new System.Windows.Forms.Button();
            this.B_Add = new System.Windows.Forms.Button();
            this.B_Save = new System.Windows.Forms.Button();
            this.B_SIng = new System.Windows.Forms.Button();
            this.LB_Macros = new System.Windows.Forms.Label();
            this.LB_Carbs = new System.Windows.Forms.Label();
            this.LB_Calories = new System.Windows.Forms.Label();
            this.LB_Protein = new System.Windows.Forms.Label();
            this.LB_Fat = new System.Windows.Forms.Label();
            this.B_Delete = new System.Windows.Forms.Button();
            this.B_Copy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeColumns = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(69)))), ((int)(((byte)(148)))));
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(92)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(69)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(92)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV.EnableHeadersVisualStyles = false;
            this.DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.DGV.Location = new System.Drawing.Point(403, 6);
            this.DGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(69)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(92)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV.RowHeadersWidth = 62;
            this.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV.RowTemplate.Height = 28;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.ShowCellErrors = false;
            this.DGV.ShowCellToolTips = false;
            this.DGV.ShowEditingIcon = false;
            this.DGV.ShowRowErrors = false;
            this.DGV.Size = new System.Drawing.Size(832, 560);
            this.DGV.TabIndex = 65;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // TB_Name
            // 
            this.TB_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_Name.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Name.Location = new System.Drawing.Point(222, 41);
            this.TB_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_Name.MaxLength = 9;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(134, 26);
            this.TB_Name.TabIndex = 122;
            // 
            // LB_Name
            // 
            this.LB_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Name.AutoSize = true;
            this.LB_Name.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Name.Location = new System.Drawing.Point(216, 6);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(140, 32);
            this.LB_Name.TabIndex = 121;
            this.LB_Name.Text = "Meal Name";
            // 
            // TB_Quant
            // 
            this.TB_Quant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_Quant.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Quant.Location = new System.Drawing.Point(222, 128);
            this.TB_Quant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_Quant.MaxLength = 12;
            this.TB_Quant.Name = "TB_Quant";
            this.TB_Quant.Size = new System.Drawing.Size(134, 26);
            this.TB_Quant.TabIndex = 124;
            this.TB_Quant.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LB_Time
            // 
            this.LB_Time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Time.AutoSize = true;
            this.LB_Time.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Time.Location = new System.Drawing.Point(18, 6);
            this.LB_Time.Name = "LB_Time";
            this.LB_Time.Size = new System.Drawing.Size(140, 32);
            this.LB_Time.TabIndex = 123;
            this.LB_Time.Text = "Meal Time";
            // 
            // CB_Time
            // 
            this.CB_Time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(69)))), ((int)(((byte)(148)))));
            this.CB_Time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Time.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Time.ForeColor = System.Drawing.SystemColors.Window;
            this.CB_Time.FormattingEnabled = true;
            this.CB_Time.Items.AddRange(new object[] {
            "Select Time"});
            this.CB_Time.Location = new System.Drawing.Point(21, 41);
            this.CB_Time.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_Time.Name = "CB_Time";
            this.CB_Time.Size = new System.Drawing.Size(134, 29);
            this.CB_Time.TabIndex = 125;
            this.CB_Time.SelectedIndexChanged += new System.EventHandler(this.CB_Time_SelectedIndexChanged);
            // 
            // LB_Igdt
            // 
            this.LB_Igdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Igdt.AutoSize = true;
            this.LB_Igdt.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Igdt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Igdt.Location = new System.Drawing.Point(18, 92);
            this.LB_Igdt.Name = "LB_Igdt";
            this.LB_Igdt.Size = new System.Drawing.Size(168, 32);
            this.LB_Igdt.TabIndex = 126;
            this.LB_Igdt.Text = "Ingredients";
            // 
            // CB_Igdt
            // 
            this.CB_Igdt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(69)))), ((int)(((byte)(148)))));
            this.CB_Igdt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Igdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Igdt.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Igdt.ForeColor = System.Drawing.SystemColors.Window;
            this.CB_Igdt.FormattingEnabled = true;
            this.CB_Igdt.Items.AddRange(new object[] {
            "Select Piece"});
            this.CB_Igdt.Location = new System.Drawing.Point(21, 128);
            this.CB_Igdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_Igdt.Name = "CB_Igdt";
            this.CB_Igdt.Size = new System.Drawing.Size(149, 29);
            this.CB_Igdt.TabIndex = 127;
            this.CB_Igdt.SelectedIndexChanged += new System.EventHandler(this.CB_Igdt_SelectedIndexChanged);
            // 
            // LB_Quant
            // 
            this.LB_Quant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Quant.AutoSize = true;
            this.LB_Quant.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Quant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Quant.Location = new System.Drawing.Point(216, 92);
            this.LB_Quant.Name = "LB_Quant";
            this.LB_Quant.Size = new System.Drawing.Size(168, 32);
            this.LB_Quant.TabIndex = 128;
            this.LB_Quant.Text = "Quantity(g)";
            // 
            // B_Remove
            // 
            this.B_Remove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.B_Remove.Enabled = false;
            this.B_Remove.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.B_Remove.FlatAppearance.BorderSize = 2;
            this.B_Remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Remove.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Remove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.B_Remove.Location = new System.Drawing.Point(55, 296);
            this.B_Remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_Remove.Name = "B_Remove";
            this.B_Remove.Size = new System.Drawing.Size(272, 50);
            this.B_Remove.TabIndex = 130;
            this.B_Remove.Text = "Remove Ingredient";
            this.B_Remove.UseVisualStyleBackColor = false;
            this.B_Remove.Click += new System.EventHandler(this.B_Remove_Click);
            // 
            // B_Add
            // 
            this.B_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.B_Add.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.B_Add.FlatAppearance.BorderSize = 2;
            this.B_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Add.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.B_Add.Location = new System.Drawing.Point(55, 185);
            this.B_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(272, 50);
            this.B_Add.TabIndex = 129;
            this.B_Add.Text = "Add Ingredient";
            this.B_Add.UseVisualStyleBackColor = false;
            this.B_Add.Click += new System.EventHandler(this.B_Add_Click);
            // 
            // B_Save
            // 
            this.B_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.B_Save.Enabled = false;
            this.B_Save.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.B_Save.FlatAppearance.BorderSize = 2;
            this.B_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Save.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.B_Save.Location = new System.Drawing.Point(4, 352);
            this.B_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(130, 50);
            this.B_Save.TabIndex = 131;
            this.B_Save.Text = "Save";
            this.B_Save.UseVisualStyleBackColor = false;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // B_SIng
            // 
            this.B_SIng.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_SIng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_SIng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.B_SIng.Enabled = false;
            this.B_SIng.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.B_SIng.FlatAppearance.BorderSize = 2;
            this.B_SIng.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_SIng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_SIng.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_SIng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.B_SIng.Location = new System.Drawing.Point(55, 240);
            this.B_SIng.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_SIng.Name = "B_SIng";
            this.B_SIng.Size = new System.Drawing.Size(272, 50);
            this.B_SIng.TabIndex = 132;
            this.B_SIng.Text = "Save Ingredient";
            this.B_SIng.UseVisualStyleBackColor = false;
            this.B_SIng.Click += new System.EventHandler(this.B_SIng_Click);
            // 
            // LB_Macros
            // 
            this.LB_Macros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Macros.AutoSize = true;
            this.LB_Macros.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Macros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Macros.Location = new System.Drawing.Point(12, 409);
            this.LB_Macros.Name = "LB_Macros";
            this.LB_Macros.Size = new System.Drawing.Size(112, 32);
            this.LB_Macros.TabIndex = 133;
            this.LB_Macros.Text = "Macros:";
            // 
            // LB_Carbs
            // 
            this.LB_Carbs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Carbs.AutoSize = true;
            this.LB_Carbs.Font = new System.Drawing.Font("Cascadia Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Carbs.ForeColor = System.Drawing.Color.White;
            this.LB_Carbs.Location = new System.Drawing.Point(16, 445);
            this.LB_Carbs.Name = "LB_Carbs";
            this.LB_Carbs.Size = new System.Drawing.Size(144, 27);
            this.LB_Carbs.TabIndex = 134;
            this.LB_Carbs.Text = "Carbs - [ ]";
            // 
            // LB_Calories
            // 
            this.LB_Calories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Calories.AutoSize = true;
            this.LB_Calories.Font = new System.Drawing.Font("Cascadia Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Calories.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Calories.Location = new System.Drawing.Point(16, 526);
            this.LB_Calories.Name = "LB_Calories";
            this.LB_Calories.Size = new System.Drawing.Size(180, 27);
            this.LB_Calories.TabIndex = 135;
            this.LB_Calories.Text = "Calories - [ ]";
            // 
            // LB_Protein
            // 
            this.LB_Protein.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Protein.AutoSize = true;
            this.LB_Protein.Font = new System.Drawing.Font("Cascadia Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Protein.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Protein.Location = new System.Drawing.Point(16, 472);
            this.LB_Protein.Name = "LB_Protein";
            this.LB_Protein.Size = new System.Drawing.Size(168, 27);
            this.LB_Protein.TabIndex = 135;
            this.LB_Protein.Text = "Protein - [ ]";
            // 
            // LB_Fat
            // 
            this.LB_Fat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Fat.AutoSize = true;
            this.LB_Fat.Font = new System.Drawing.Font("Cascadia Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Fat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Fat.Location = new System.Drawing.Point(16, 499);
            this.LB_Fat.Name = "LB_Fat";
            this.LB_Fat.Size = new System.Drawing.Size(120, 27);
            this.LB_Fat.TabIndex = 136;
            this.LB_Fat.Text = "Fat - [ ]";
            // 
            // B_Delete
            // 
            this.B_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.B_Delete.Enabled = false;
            this.B_Delete.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.B_Delete.FlatAppearance.BorderSize = 2;
            this.B_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Delete.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.B_Delete.Location = new System.Drawing.Point(269, 352);
            this.B_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_Delete.Name = "B_Delete";
            this.B_Delete.Size = new System.Drawing.Size(130, 50);
            this.B_Delete.TabIndex = 177;
            this.B_Delete.Text = "Reset Meal";
            this.B_Delete.UseVisualStyleBackColor = false;
            this.B_Delete.Click += new System.EventHandler(this.B_Delete_Click);
            // 
            // B_Copy
            // 
            this.B_Copy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_Copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Copy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.B_Copy.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.B_Copy.FlatAppearance.BorderSize = 2;
            this.B_Copy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Copy.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Copy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.B_Copy.Location = new System.Drawing.Point(136, 352);
            this.B_Copy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_Copy.Name = "B_Copy";
            this.B_Copy.Size = new System.Drawing.Size(130, 50);
            this.B_Copy.TabIndex = 180;
            this.B_Copy.Text = "Copy";
            this.B_Copy.UseVisualStyleBackColor = false;
            this.B_Copy.Click += new System.EventHandler(this.B_Copy_Click);
            // 
            // FMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1242, 572);
            this.Controls.Add(this.B_Copy);
            this.Controls.Add(this.B_Delete);
            this.Controls.Add(this.LB_Macros);
            this.Controls.Add(this.B_SIng);
            this.Controls.Add(this.B_Remove);
            this.Controls.Add(this.B_Add);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.LB_Quant);
            this.Controls.Add(this.CB_Igdt);
            this.Controls.Add(this.LB_Igdt);
            this.Controls.Add(this.CB_Time);
            this.Controls.Add(this.TB_Quant);
            this.Controls.Add(this.LB_Time);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.LB_Name);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.LB_Fat);
            this.Controls.Add(this.LB_Protein);
            this.Controls.Add(this.LB_Calories);
            this.Controls.Add(this.LB_Carbs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "- [Academy]";
            this.Load += new System.EventHandler(this.FMS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.TextBox TB_Name;
        public System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.TextBox TB_Quant;
        public System.Windows.Forms.Label LB_Time;
        public System.Windows.Forms.ComboBox CB_Time;
        public System.Windows.Forms.Label LB_Igdt;
        public System.Windows.Forms.ComboBox CB_Igdt;
        public System.Windows.Forms.Label LB_Quant;
        private System.Windows.Forms.Button B_Remove;
        private System.Windows.Forms.Button B_Add;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.Button B_SIng;
        public System.Windows.Forms.Label LB_Macros;
        public System.Windows.Forms.Label LB_Carbs;
        public System.Windows.Forms.Label LB_Calories;
        public System.Windows.Forms.Label LB_Protein;
        public System.Windows.Forms.Label LB_Fat;
        private System.Windows.Forms.Button B_Delete;
        private System.Windows.Forms.Button B_Copy;
    }
}