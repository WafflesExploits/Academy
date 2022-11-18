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
            this.LB_Fats = new System.Windows.Forms.Label();
            this.LB_Trans = new System.Windows.Forms.Label();
            this.LB_Saturated = new System.Windows.Forms.Label();
            this.LB_MoPoly = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LB_Fats
            // 
            this.LB_Fats.AutoSize = true;
            this.LB_Fats.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Fats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(180)))), ((int)(((byte)(252)))));
            this.LB_Fats.Location = new System.Drawing.Point(12, 9);
            this.LB_Fats.Name = "LB_Fats";
            this.LB_Fats.Size = new System.Drawing.Size(161, 40);
            this.LB_Fats.TabIndex = 158;
            this.LB_Fats.Text = "Fats: 0g";
            this.LB_Fats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_Trans
            // 
            this.LB_Trans.AutoSize = true;
            this.LB_Trans.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Trans.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Trans.Location = new System.Drawing.Point(13, 108);
            this.LB_Trans.Name = "LB_Trans";
            this.LB_Trans.Size = new System.Drawing.Size(168, 32);
            this.LB_Trans.TabIndex = 162;
            this.LB_Trans.Text = "Trans - [ ]";
            // 
            // LB_Saturated
            // 
            this.LB_Saturated.AutoSize = true;
            this.LB_Saturated.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Saturated.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Saturated.Location = new System.Drawing.Point(13, 78);
            this.LB_Saturated.Name = "LB_Saturated";
            this.LB_Saturated.Size = new System.Drawing.Size(224, 32);
            this.LB_Saturated.TabIndex = 160;
            this.LB_Saturated.Text = "Saturated - [ ]";
            // 
            // LB_MoPoly
            // 
            this.LB_MoPoly.AutoSize = true;
            this.LB_MoPoly.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MoPoly.ForeColor = System.Drawing.Color.White;
            this.LB_MoPoly.Location = new System.Drawing.Point(13, 49);
            this.LB_MoPoly.Name = "LB_MoPoly";
            this.LB_MoPoly.Size = new System.Drawing.Size(350, 32);
            this.LB_MoPoly.TabIndex = 159;
            this.LB_MoPoly.Text = "Mono/Polysaturated - [ ]";
            // 
            // FAF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(475, 235);
            this.Controls.Add(this.LB_Fats);
            this.Controls.Add(this.LB_MoPoly);
            this.Controls.Add(this.LB_Saturated);
            this.Controls.Add(this.LB_Trans);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(493, 282);
            this.Name = "FAF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "- [Academy]";
            this.Load += new System.EventHandler(this.FAF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LB_Fats;
        public System.Windows.Forms.Label LB_Trans;
        public System.Windows.Forms.Label LB_Saturated;
        public System.Windows.Forms.Label LB_MoPoly;
    }
}