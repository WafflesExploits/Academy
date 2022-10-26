
namespace Academy
{
    partial class FES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FES));
            this.P_Formloader = new System.Windows.Forms.Panel();
            this.CB_Sync = new System.Windows.Forms.CheckBox();
            this.CB_ASync = new System.Windows.Forms.CheckBox();
            this.P_FormLoader2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // P_Formloader
            // 
            this.P_Formloader.Location = new System.Drawing.Point(12, 49);
            this.P_Formloader.Name = "P_Formloader";
            this.P_Formloader.Size = new System.Drawing.Size(1000, 145);
            this.P_Formloader.TabIndex = 0;
            this.P_Formloader.Paint += new System.Windows.Forms.PaintEventHandler(this.P_Formloader_Paint);
            // 
            // CB_Sync
            // 
            this.CB_Sync.AutoSize = true;
            this.CB_Sync.Checked = true;
            this.CB_Sync.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_Sync.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Sync.ForeColor = System.Drawing.SystemColors.Control;
            this.CB_Sync.Location = new System.Drawing.Point(12, 7);
            this.CB_Sync.Name = "CB_Sync";
            this.CB_Sync.Size = new System.Drawing.Size(194, 36);
            this.CB_Sync.TabIndex = 40;
            this.CB_Sync.Text = "Synchronous";
            this.CB_Sync.UseVisualStyleBackColor = true;
            this.CB_Sync.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CB_ASync
            // 
            this.CB_ASync.AutoSize = true;
            this.CB_ASync.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_ASync.ForeColor = System.Drawing.SystemColors.Control;
            this.CB_ASync.Location = new System.Drawing.Point(7, 218);
            this.CB_ASync.Name = "CB_ASync";
            this.CB_ASync.Size = new System.Drawing.Size(222, 36);
            this.CB_ASync.TabIndex = 41;
            this.CB_ASync.Text = "Assynchronous";
            this.CB_ASync.UseVisualStyleBackColor = true;
            this.CB_ASync.CheckedChanged += new System.EventHandler(this.AsyncCheckbox);
            // 
            // P_FormLoader2
            // 
            this.P_FormLoader2.Location = new System.Drawing.Point(12, 263);
            this.P_FormLoader2.Name = "P_FormLoader2";
            this.P_FormLoader2.Size = new System.Drawing.Size(1000, 172);
            this.P_FormLoader2.TabIndex = 1;
            // 
            // FES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1025, 447);
            this.Controls.Add(this.P_FormLoader2);
            this.Controls.Add(this.CB_ASync);
            this.Controls.Add(this.CB_Sync);
            this.Controls.Add(this.P_Formloader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "- [Academy]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FES_FormClosed);
            this.Load += new System.EventHandler(this.FES_Load);
            this.Leave += new System.EventHandler(this.FES_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel P_Formloader;
        private System.Windows.Forms.CheckBox CB_Sync;
        private System.Windows.Forms.CheckBox CB_ASync;
        private System.Windows.Forms.Panel P_FormLoader2;
    }
}