
namespace Academy
{
    partial class FAW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAW));
            this.TB_Exercise = new System.Windows.Forms.TextBox();
            this.B_Add = new System.Windows.Forms.Button();
            this.LB_Exercise = new System.Windows.Forms.Label();
            this.LB_Info = new System.Windows.Forms.Label();
            this.TB_Info = new System.Windows.Forms.TextBox();
            this.LB_Reps = new System.Windows.Forms.Label();
            this.TB_Reps = new System.Windows.Forms.TextBox();
            this.LB_Sets = new System.Windows.Forms.Label();
            this.TB_Sets = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TB_Exercise
            // 
            this.TB_Exercise.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_Exercise.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Exercise.Location = new System.Drawing.Point(18, 49);
            this.TB_Exercise.Name = "TB_Exercise";
            this.TB_Exercise.Size = new System.Drawing.Size(219, 26);
            this.TB_Exercise.TabIndex = 56;
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
            this.B_Add.Location = new System.Drawing.Point(150, 169);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(202, 46);
            this.B_Add.TabIndex = 54;
            this.B_Add.Text = "Add Exercise";
            this.B_Add.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.B_Add.UseVisualStyleBackColor = false;
            this.B_Add.Click += new System.EventHandler(this.B_Add_Click);
            // 
            // LB_Exercise
            // 
            this.LB_Exercise.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Exercise.AutoSize = true;
            this.LB_Exercise.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Exercise.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Exercise.Location = new System.Drawing.Point(12, 14);
            this.LB_Exercise.Name = "LB_Exercise";
            this.LB_Exercise.Size = new System.Drawing.Size(126, 32);
            this.LB_Exercise.TabIndex = 57;
            this.LB_Exercise.Text = "Exercise";
            // 
            // LB_Info
            // 
            this.LB_Info.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Info.AutoSize = true;
            this.LB_Info.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Info.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Info.Location = new System.Drawing.Point(261, 14);
            this.LB_Info.Name = "LB_Info";
            this.LB_Info.Size = new System.Drawing.Size(70, 32);
            this.LB_Info.TabIndex = 59;
            this.LB_Info.Text = "Desc";
            // 
            // TB_Info
            // 
            this.TB_Info.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_Info.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Info.Location = new System.Drawing.Point(267, 49);
            this.TB_Info.Name = "TB_Info";
            this.TB_Info.Size = new System.Drawing.Size(219, 26);
            this.TB_Info.TabIndex = 58;
            // 
            // LB_Reps
            // 
            this.LB_Reps.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Reps.AutoSize = true;
            this.LB_Reps.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Reps.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Reps.Location = new System.Drawing.Point(261, 87);
            this.LB_Reps.Name = "LB_Reps";
            this.LB_Reps.Size = new System.Drawing.Size(70, 32);
            this.LB_Reps.TabIndex = 63;
            this.LB_Reps.Text = "Reps";
            // 
            // TB_Reps
            // 
            this.TB_Reps.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_Reps.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Reps.Location = new System.Drawing.Point(267, 122);
            this.TB_Reps.Name = "TB_Reps";
            this.TB_Reps.Size = new System.Drawing.Size(219, 26);
            this.TB_Reps.TabIndex = 62;
            // 
            // LB_Sets
            // 
            this.LB_Sets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Sets.AutoSize = true;
            this.LB_Sets.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Sets.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Sets.Location = new System.Drawing.Point(12, 87);
            this.LB_Sets.Name = "LB_Sets";
            this.LB_Sets.Size = new System.Drawing.Size(70, 32);
            this.LB_Sets.TabIndex = 61;
            this.LB_Sets.Text = "Sets";
            // 
            // TB_Sets
            // 
            this.TB_Sets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_Sets.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Sets.Location = new System.Drawing.Point(18, 122);
            this.TB_Sets.Name = "TB_Sets";
            this.TB_Sets.Size = new System.Drawing.Size(219, 26);
            this.TB_Sets.TabIndex = 60;
            // 
            // FAW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(503, 227);
            this.Controls.Add(this.LB_Reps);
            this.Controls.Add(this.TB_Reps);
            this.Controls.Add(this.LB_Sets);
            this.Controls.Add(this.TB_Sets);
            this.Controls.Add(this.LB_Info);
            this.Controls.Add(this.TB_Info);
            this.Controls.Add(this.LB_Exercise);
            this.Controls.Add(this.TB_Exercise);
            this.Controls.Add(this.B_Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FAW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "- [Academy]";
            this.Load += new System.EventHandler(this.FAW_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Exercise;
        private System.Windows.Forms.Button B_Add;
        private System.Windows.Forms.Label LB_Exercise;
        private System.Windows.Forms.Label LB_Info;
        private System.Windows.Forms.TextBox TB_Info;
        private System.Windows.Forms.Label LB_Reps;
        private System.Windows.Forms.TextBox TB_Reps;
        private System.Windows.Forms.Label LB_Sets;
        private System.Windows.Forms.TextBox TB_Sets;
    }
}