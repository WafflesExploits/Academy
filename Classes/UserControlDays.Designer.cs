
namespace Academy
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LB_Day = new System.Windows.Forms.Label();
            this.LB_WORKOUT = new System.Windows.Forms.Label();
            this.LB_TIME1 = new System.Windows.Forms.Label();
            this.LB_Today = new System.Windows.Forms.Label();
            this.LB_Event = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LB_Day
            // 
            this.LB_Day.AutoSize = true;
            this.LB_Day.BackColor = System.Drawing.Color.Transparent;
            this.LB_Day.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Day.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(69)))), ((int)(((byte)(148)))));
            this.LB_Day.Location = new System.Drawing.Point(4, 0);
            this.LB_Day.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Day.Name = "LB_Day";
            this.LB_Day.Size = new System.Drawing.Size(74, 56);
            this.LB_Day.TabIndex = 1;
            this.LB_Day.Text = "14";
            this.LB_Day.Click += new System.EventHandler(this.UC_Click);
            this.LB_Day.MouseLeave += new System.EventHandler(this.MouseLeave1);
            this.LB_Day.MouseHover += new System.EventHandler(this.MouseHover1);
            // 
            // LB_WORKOUT
            // 
            this.LB_WORKOUT.BackColor = System.Drawing.Color.Transparent;
            this.LB_WORKOUT.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_WORKOUT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(94)))), ((int)(((byte)(234)))));
            this.LB_WORKOUT.Location = new System.Drawing.Point(-24, 70);
            this.LB_WORKOUT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_WORKOUT.Name = "LB_WORKOUT";
            this.LB_WORKOUT.Size = new System.Drawing.Size(241, 46);
            this.LB_WORKOUT.TabIndex = 2;
            this.LB_WORKOUT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_WORKOUT.Click += new System.EventHandler(this.UC_Click);
            this.LB_WORKOUT.MouseLeave += new System.EventHandler(this.MouseLeave1);
            this.LB_WORKOUT.MouseHover += new System.EventHandler(this.MouseHover1);
            // 
            // LB_TIME1
            // 
            this.LB_TIME1.Font = new System.Drawing.Font("Cascadia Code SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TIME1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(94)))), ((int)(((byte)(234)))));
            this.LB_TIME1.Location = new System.Drawing.Point(-24, 108);
            this.LB_TIME1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_TIME1.Name = "LB_TIME1";
            this.LB_TIME1.Size = new System.Drawing.Size(241, 30);
            this.LB_TIME1.TabIndex = 6;
            this.LB_TIME1.Tag = "MondayT";
            this.LB_TIME1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_TIME1.Click += new System.EventHandler(this.UC_Click);
            this.LB_TIME1.MouseLeave += new System.EventHandler(this.MouseLeave1);
            this.LB_TIME1.MouseHover += new System.EventHandler(this.MouseHover1);
            // 
            // LB_Today
            // 
            this.LB_Today.BackColor = System.Drawing.Color.Transparent;
            this.LB_Today.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Today.ForeColor = System.Drawing.Color.White;
            this.LB_Today.Location = new System.Drawing.Point(-24, 0);
            this.LB_Today.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Today.Name = "LB_Today";
            this.LB_Today.Size = new System.Drawing.Size(241, 46);
            this.LB_Today.TabIndex = 7;
            this.LB_Today.Text = "Today";
            this.LB_Today.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Today.Click += new System.EventHandler(this.UC_Click);
            this.LB_Today.MouseLeave += new System.EventHandler(this.MouseLeave1);
            this.LB_Today.MouseHover += new System.EventHandler(this.MouseHover1);
            // 
            // LB_Event
            // 
            this.LB_Event.BackColor = System.Drawing.Color.Transparent;
            this.LB_Event.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Event.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LB_Event.Location = new System.Drawing.Point(-26, 37);
            this.LB_Event.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Event.Name = "LB_Event";
            this.LB_Event.Size = new System.Drawing.Size(241, 46);
            this.LB_Event.TabIndex = 8;
            this.LB_Event.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Event.Click += new System.EventHandler(this.UC_Click);
            this.LB_Event.MouseLeave += new System.EventHandler(this.MouseLeave1);
            this.LB_Event.MouseHover += new System.EventHandler(this.MouseHover1);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.LB_TIME1);
            this.Controls.Add(this.LB_WORKOUT);
            this.Controls.Add(this.LB_Event);
            this.Controls.Add(this.LB_Day);
            this.Controls.Add(this.LB_Today);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(189, 138);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.MouseLeave += new System.EventHandler(this.MouseLeave1);
            this.MouseHover += new System.EventHandler(this.MouseHover1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LB_Day;
        public System.Windows.Forms.Label LB_WORKOUT;
        public System.Windows.Forms.Label LB_TIME1;
        public System.Windows.Forms.Label LB_Today;
        public System.Windows.Forms.Label LB_Event;
    }
}
