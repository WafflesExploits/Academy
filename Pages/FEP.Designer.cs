namespace Academy
{
    partial class FEP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEP));
            this.LB_Physique = new System.Windows.Forms.Label();
            this.LB_Height = new System.Windows.Forms.Label();
            this.LB_Age = new System.Windows.Forms.Label();
            this.LB_Weight = new System.Windows.Forms.Label();
            this.NUP_Age = new System.Windows.Forms.NumericUpDown();
            this.NUP_Height = new System.Windows.Forms.NumericUpDown();
            this.NUP_Weight = new System.Windows.Forms.NumericUpDown();
            this.LB_Wkg = new System.Windows.Forms.Label();
            this.LB_Gender = new System.Windows.Forms.Label();
            this.CB_Male = new System.Windows.Forms.CheckBox();
            this.CB_Female = new System.Windows.Forms.CheckBox();
            this.B_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUP_Age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUP_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUP_Weight)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Physique
            // 
            this.LB_Physique.AutoSize = true;
            this.LB_Physique.Font = new System.Drawing.Font("Cascadia Mono Light", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Physique.ForeColor = System.Drawing.Color.White;
            this.LB_Physique.Location = new System.Drawing.Point(61, 9);
            this.LB_Physique.Name = "LB_Physique";
            this.LB_Physique.Size = new System.Drawing.Size(270, 69);
            this.LB_Physique.TabIndex = 182;
            this.LB_Physique.Text = "Physique";
            this.LB_Physique.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_Height
            // 
            this.LB_Height.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Height.AutoSize = true;
            this.LB_Height.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Height.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Height.Location = new System.Drawing.Point(139, 87);
            this.LB_Height.Name = "LB_Height";
            this.LB_Height.Size = new System.Drawing.Size(98, 32);
            this.LB_Height.TabIndex = 186;
            this.LB_Height.Text = "Height";
            // 
            // LB_Age
            // 
            this.LB_Age.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Age.AutoSize = true;
            this.LB_Age.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Age.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Age.Location = new System.Drawing.Point(24, 87);
            this.LB_Age.Name = "LB_Age";
            this.LB_Age.Size = new System.Drawing.Size(56, 32);
            this.LB_Age.TabIndex = 184;
            this.LB_Age.Text = "Age";
            // 
            // LB_Weight
            // 
            this.LB_Weight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Weight.AutoSize = true;
            this.LB_Weight.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Weight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Weight.Location = new System.Drawing.Point(256, 87);
            this.LB_Weight.Name = "LB_Weight";
            this.LB_Weight.Size = new System.Drawing.Size(98, 32);
            this.LB_Weight.TabIndex = 188;
            this.LB_Weight.Text = "Weight";
            // 
            // NUP_Age
            // 
            this.NUP_Age.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUP_Age.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUP_Age.Location = new System.Drawing.Point(30, 124);
            this.NUP_Age.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.NUP_Age.Name = "NUP_Age";
            this.NUP_Age.Size = new System.Drawing.Size(95, 26);
            this.NUP_Age.TabIndex = 189;
            this.NUP_Age.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // NUP_Height
            // 
            this.NUP_Height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUP_Height.DecimalPlaces = 2;
            this.NUP_Height.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUP_Height.Location = new System.Drawing.Point(146, 124);
            this.NUP_Height.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.NUP_Height.Name = "NUP_Height";
            this.NUP_Height.Size = new System.Drawing.Size(95, 26);
            this.NUP_Height.TabIndex = 190;
            // 
            // NUP_Weight
            // 
            this.NUP_Weight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUP_Weight.DecimalPlaces = 2;
            this.NUP_Weight.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUP_Weight.Location = new System.Drawing.Point(262, 124);
            this.NUP_Weight.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.NUP_Weight.Name = "NUP_Weight";
            this.NUP_Weight.Size = new System.Drawing.Size(95, 26);
            this.NUP_Weight.TabIndex = 191;
            // 
            // LB_Wkg
            // 
            this.LB_Wkg.BackColor = System.Drawing.Color.White;
            this.LB_Wkg.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Wkg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LB_Wkg.Location = new System.Drawing.Point(326, 126);
            this.LB_Wkg.Name = "LB_Wkg";
            this.LB_Wkg.Size = new System.Drawing.Size(28, 28);
            this.LB_Wkg.TabIndex = 192;
            this.LB_Wkg.Text = "kg";
            this.LB_Wkg.Click += new System.EventHandler(this.LB_Wkg_Click);
            // 
            // LB_Gender
            // 
            this.LB_Gender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Gender.AutoSize = true;
            this.LB_Gender.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Gender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Gender.Location = new System.Drawing.Point(148, 164);
            this.LB_Gender.Name = "LB_Gender";
            this.LB_Gender.Size = new System.Drawing.Size(112, 32);
            this.LB_Gender.TabIndex = 194;
            this.LB_Gender.Text = "Gender:";
            // 
            // CB_Male
            // 
            this.CB_Male.AutoSize = true;
            this.CB_Male.Checked = true;
            this.CB_Male.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_Male.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Male.ForeColor = System.Drawing.SystemColors.Control;
            this.CB_Male.Location = new System.Drawing.Point(30, 193);
            this.CB_Male.Name = "CB_Male";
            this.CB_Male.Size = new System.Drawing.Size(96, 36);
            this.CB_Male.TabIndex = 195;
            this.CB_Male.Text = "Male";
            this.CB_Male.UseVisualStyleBackColor = true;
            this.CB_Male.CheckedChanged += new System.EventHandler(this.CB_Male_CheckedChanged);
            // 
            // CB_Female
            // 
            this.CB_Female.AutoSize = true;
            this.CB_Female.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Female.ForeColor = System.Drawing.SystemColors.Control;
            this.CB_Female.Location = new System.Drawing.Point(269, 193);
            this.CB_Female.Name = "CB_Female";
            this.CB_Female.Size = new System.Drawing.Size(124, 36);
            this.CB_Female.TabIndex = 196;
            this.CB_Female.Text = "Female";
            this.CB_Female.UseVisualStyleBackColor = true;
            this.CB_Female.CheckedChanged += new System.EventHandler(this.CB_Female_CheckedChanged);
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
            this.B_Save.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.B_Save.Location = new System.Drawing.Point(139, 230);
            this.B_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(115, 48);
            this.B_Save.TabIndex = 197;
            this.B_Save.Text = "Save";
            this.B_Save.UseVisualStyleBackColor = false;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(212, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 28);
            this.label1.TabIndex = 198;
            this.label1.Text = "cm";
            // 
            // FEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(392, 292);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.CB_Male);
            this.Controls.Add(this.CB_Female);
            this.Controls.Add(this.LB_Gender);
            this.Controls.Add(this.LB_Wkg);
            this.Controls.Add(this.NUP_Weight);
            this.Controls.Add(this.NUP_Height);
            this.Controls.Add(this.NUP_Age);
            this.Controls.Add(this.LB_Physique);
            this.Controls.Add(this.LB_Age);
            this.Controls.Add(this.LB_Weight);
            this.Controls.Add(this.LB_Height);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FEP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "- [Academy]";
            this.Load += new System.EventHandler(this.FEP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUP_Age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUP_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUP_Weight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LB_Physique;
        public System.Windows.Forms.Label LB_Height;
        public System.Windows.Forms.Label LB_Age;
        public System.Windows.Forms.Label LB_Weight;
        private System.Windows.Forms.NumericUpDown NUP_Age;
        private System.Windows.Forms.NumericUpDown NUP_Height;
        private System.Windows.Forms.NumericUpDown NUP_Weight;
        private System.Windows.Forms.Label LB_Wkg;
        public System.Windows.Forms.Label LB_Gender;
        private System.Windows.Forms.CheckBox CB_Male;
        private System.Windows.Forms.CheckBox CB_Female;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.Label label1;
    }
}