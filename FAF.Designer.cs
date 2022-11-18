namespace Academy
{
    partial class FAF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAF));
            this.LB_Macros = new System.Windows.Forms.Label();
            this.LB_Fat = new System.Windows.Forms.Label();
            this.LB_Protein = new System.Windows.Forms.Label();
            this.LB_Carbs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LB_Macros
            // 
            this.LB_Macros.AutoSize = true;
            this.LB_Macros.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Macros.ForeColor = System.Drawing.Color.White;
            this.LB_Macros.Location = new System.Drawing.Point(12, 9);
            this.LB_Macros.Name = "LB_Macros";
            this.LB_Macros.Size = new System.Drawing.Size(161, 40);
            this.LB_Macros.TabIndex = 158;
            this.LB_Macros.Text = "Fats: 0g";
            this.LB_Macros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_Fat
            // 
            this.LB_Fat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Fat.AutoSize = true;
            this.LB_Fat.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Fat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Fat.Location = new System.Drawing.Point(13, 108);
            this.LB_Fat.Name = "LB_Fat";
            this.LB_Fat.Size = new System.Drawing.Size(168, 32);
            this.LB_Fat.TabIndex = 162;
            this.LB_Fat.Text = "Trans - [ ]";
            // 
            // LB_Protein
            // 
            this.LB_Protein.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Protein.AutoSize = true;
            this.LB_Protein.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Protein.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Protein.Location = new System.Drawing.Point(13, 78);
            this.LB_Protein.Name = "LB_Protein";
            this.LB_Protein.Size = new System.Drawing.Size(224, 32);
            this.LB_Protein.TabIndex = 160;
            this.LB_Protein.Text = "Saturated - [ ]";
            // 
            // LB_Carbs
            // 
            this.LB_Carbs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Carbs.AutoSize = true;
            this.LB_Carbs.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Carbs.ForeColor = System.Drawing.Color.White;
            this.LB_Carbs.Location = new System.Drawing.Point(13, 49);
            this.LB_Carbs.Name = "LB_Carbs";
            this.LB_Carbs.Size = new System.Drawing.Size(350, 32);
            this.LB_Carbs.TabIndex = 159;
            this.LB_Carbs.Text = "Mono/Polysaturated - [ ]";
            // 
            // FAF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(436, 193);
            this.Controls.Add(this.LB_Macros);
            this.Controls.Add(this.LB_Fat);
            this.Controls.Add(this.LB_Protein);
            this.Controls.Add(this.LB_Carbs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FAF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "- [Academy]";
            this.Load += new System.EventHandler(this.FAF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LB_Macros;
        public System.Windows.Forms.Label LB_Fat;
        public System.Windows.Forms.Label LB_Protein;
        public System.Windows.Forms.Label LB_Carbs;
    }
}