namespace Academy
{
    partial class FAEI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAEI));
            this.DGV = new System.Windows.Forms.DataGridView();
            this.LB_Name = new System.Windows.Forms.Label();
            this.B_Remove = new System.Windows.Forms.Button();
            this.B_Add = new System.Windows.Forms.Button();
            this.B_Save = new System.Windows.Forms.Button();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_Carbs = new System.Windows.Forms.TextBox();
            this.LB_Carbs = new System.Windows.Forms.Label();
            this.TB_Protein = new System.Windows.Forms.TextBox();
            this.LB_Protein = new System.Windows.Forms.Label();
            this.TB_Fats = new System.Windows.Forms.TextBox();
            this.LB_Fat = new System.Windows.Forms.Label();
            this.LB_Calories = new System.Windows.Forms.Label();
            this.TB_Calories = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.DGV.Location = new System.Drawing.Point(6, 6);
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
            this.DGV.Size = new System.Drawing.Size(750, 398);
            this.DGV.TabIndex = 64;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // LB_Name
            // 
            this.LB_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Name.AutoSize = true;
            this.LB_Name.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Name.Location = new System.Drawing.Point(757, 9);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(70, 32);
            this.LB_Name.TabIndex = 109;
            this.LB_Name.Text = "Name";
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
            this.B_Remove.Location = new System.Drawing.Point(1015, 355);
            this.B_Remove.Name = "B_Remove";
            this.B_Remove.Size = new System.Drawing.Size(120, 45);
            this.B_Remove.TabIndex = 114;
            this.B_Remove.Text = "Remove";
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
            this.B_Add.Location = new System.Drawing.Point(763, 355);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(120, 45);
            this.B_Add.TabIndex = 112;
            this.B_Add.Text = "Add Exercise";
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
            this.B_Save.Location = new System.Drawing.Point(889, 355);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(120, 45);
            this.B_Save.TabIndex = 119;
            this.B_Save.Text = "Save";
            this.B_Save.UseVisualStyleBackColor = false;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // TB_Name
            // 
            this.TB_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_Name.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Name.Location = new System.Drawing.Point(763, 44);
            this.TB_Name.MaxLength = 11;
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(274, 26);
            this.TB_Name.TabIndex = 120;
            // 
            // TB_Carbs
            // 
            this.TB_Carbs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_Carbs.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Carbs.Location = new System.Drawing.Point(763, 111);
            this.TB_Carbs.MaxLength = 12;
            this.TB_Carbs.Name = "TB_Carbs";
            this.TB_Carbs.Size = new System.Drawing.Size(274, 26);
            this.TB_Carbs.TabIndex = 122;
            // 
            // LB_Carbs
            // 
            this.LB_Carbs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Carbs.AutoSize = true;
            this.LB_Carbs.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Carbs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Carbs.Location = new System.Drawing.Point(757, 76);
            this.LB_Carbs.Name = "LB_Carbs";
            this.LB_Carbs.Size = new System.Drawing.Size(154, 32);
            this.LB_Carbs.TabIndex = 121;
            this.LB_Carbs.Text = "Carbs/100g";
            // 
            // TB_Protein
            // 
            this.TB_Protein.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_Protein.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Protein.Location = new System.Drawing.Point(763, 179);
            this.TB_Protein.MaxLength = 12;
            this.TB_Protein.Name = "TB_Protein";
            this.TB_Protein.Size = new System.Drawing.Size(274, 26);
            this.TB_Protein.TabIndex = 124;
            // 
            // LB_Protein
            // 
            this.LB_Protein.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Protein.AutoSize = true;
            this.LB_Protein.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Protein.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Protein.Location = new System.Drawing.Point(757, 144);
            this.LB_Protein.Name = "LB_Protein";
            this.LB_Protein.Size = new System.Drawing.Size(182, 32);
            this.LB_Protein.TabIndex = 123;
            this.LB_Protein.Text = "Protein/100g";
            // 
            // TB_Fats
            // 
            this.TB_Fats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_Fats.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Fats.Location = new System.Drawing.Point(763, 245);
            this.TB_Fats.MaxLength = 12;
            this.TB_Fats.Name = "TB_Fats";
            this.TB_Fats.Size = new System.Drawing.Size(274, 26);
            this.TB_Fats.TabIndex = 126;
            // 
            // LB_Fat
            // 
            this.LB_Fat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Fat.AutoSize = true;
            this.LB_Fat.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Fat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Fat.Location = new System.Drawing.Point(757, 210);
            this.LB_Fat.Name = "LB_Fat";
            this.LB_Fat.Size = new System.Drawing.Size(126, 32);
            this.LB_Fat.TabIndex = 125;
            this.LB_Fat.Text = "Fat/100g";
            // 
            // LB_Calories
            // 
            this.LB_Calories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Calories.AutoSize = true;
            this.LB_Calories.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Calories.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Calories.Location = new System.Drawing.Point(757, 277);
            this.LB_Calories.Name = "LB_Calories";
            this.LB_Calories.Size = new System.Drawing.Size(196, 32);
            this.LB_Calories.TabIndex = 111;
            this.LB_Calories.Text = "Calories/100g";
            // 
            // TB_Calories
            // 
            this.TB_Calories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_Calories.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Calories.Location = new System.Drawing.Point(763, 312);
            this.TB_Calories.MaxLength = 12;
            this.TB_Calories.Name = "TB_Calories";
            this.TB_Calories.Size = new System.Drawing.Size(274, 26);
            this.TB_Calories.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1017, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 21);
            this.label1.TabIndex = 193;
            this.label1.Text = "g";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1017, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 194;
            this.label2.Text = "g";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(1017, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 21);
            this.label3.TabIndex = 195;
            this.label3.Text = "g";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(991, 314);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 196;
            this.label4.Text = "kcal";
            // 
            // FAEI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1145, 410);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Fats);
            this.Controls.Add(this.LB_Fat);
            this.Controls.Add(this.TB_Protein);
            this.Controls.Add(this.LB_Protein);
            this.Controls.Add(this.TB_Carbs);
            this.Controls.Add(this.LB_Carbs);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.LB_Name);
            this.Controls.Add(this.B_Remove);
            this.Controls.Add(this.TB_Calories);
            this.Controls.Add(this.B_Add);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.LB_Calories);
            this.Controls.Add(this.DGV);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FAEI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "- [Academy]";
            this.Load += new System.EventHandler(this.FAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DGV;
        public System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.Button B_Remove;
        private System.Windows.Forms.Button B_Add;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_Carbs;
        public System.Windows.Forms.Label LB_Carbs;
        private System.Windows.Forms.TextBox TB_Protein;
        public System.Windows.Forms.Label LB_Protein;
        private System.Windows.Forms.TextBox TB_Fats;
        public System.Windows.Forms.Label LB_Fat;
        public System.Windows.Forms.Label LB_Calories;
        private System.Windows.Forms.TextBox TB_Calories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}