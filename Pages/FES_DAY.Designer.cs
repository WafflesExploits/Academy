
namespace Academy
{
    partial class FES_DAY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FES_DAY));
            this.CB_Time = new System.Windows.Forms.ComboBox();
            this.LB_Time = new System.Windows.Forms.Label();
            this.LB_Day = new System.Windows.Forms.Label();
            this.LB_Workout = new System.Windows.Forms.Label();
            this.CB_Workout = new System.Windows.Forms.ComboBox();
            this.B_Add = new System.Windows.Forms.Button();
            this.LB_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.CB_Time.Location = new System.Drawing.Point(26, 100);
            this.CB_Time.Name = "CB_Time";
            this.CB_Time.Size = new System.Drawing.Size(201, 29);
            this.CB_Time.TabIndex = 71;
            this.CB_Time.DropDown += new System.EventHandler(this.CB_Time_DropDown);
            this.CB_Time.SelectedValueChanged += new System.EventHandler(this.CB_Time_SelectedValueChanged);
            this.CB_Time.Enter += new System.EventHandler(this.CB_Time_Enter);
            this.CB_Time.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CB_Time_MouseClick);
            this.CB_Time.MouseHover += new System.EventHandler(this.CB_Time_MouseHover);
            // 
            // LB_Time
            // 
            this.LB_Time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Time.AutoSize = true;
            this.LB_Time.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Time.Location = new System.Drawing.Point(20, 65);
            this.LB_Time.Name = "LB_Time";
            this.LB_Time.Size = new System.Drawing.Size(70, 32);
            this.LB_Time.TabIndex = 70;
            this.LB_Time.Text = "Time";
            // 
            // LB_Day
            // 
            this.LB_Day.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Day.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Day.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Day.Location = new System.Drawing.Point(153, -3);
            this.LB_Day.Name = "LB_Day";
            this.LB_Day.Size = new System.Drawing.Size(201, 56);
            this.LB_Day.TabIndex = 66;
            this.LB_Day.Text = "Wednesday";
            this.LB_Day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_Workout
            // 
            this.LB_Workout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Workout.AutoSize = true;
            this.LB_Workout.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Workout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Workout.Location = new System.Drawing.Point(275, 65);
            this.LB_Workout.Name = "LB_Workout";
            this.LB_Workout.Size = new System.Drawing.Size(112, 32);
            this.LB_Workout.TabIndex = 68;
            this.LB_Workout.Text = "Workout";
            // 
            // CB_Workout
            // 
            this.CB_Workout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(69)))), ((int)(((byte)(148)))));
            this.CB_Workout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Workout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Workout.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Workout.ForeColor = System.Drawing.SystemColors.Window;
            this.CB_Workout.FormattingEnabled = true;
            this.CB_Workout.Location = new System.Drawing.Point(281, 100);
            this.CB_Workout.Name = "CB_Workout";
            this.CB_Workout.Size = new System.Drawing.Size(201, 29);
            this.CB_Workout.TabIndex = 72;
            this.CB_Workout.SelectedValueChanged += new System.EventHandler(this.CB_Workouts_SelectedValueChanged);
            this.CB_Workout.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CB_Workout_MouseClick);
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
            this.B_Add.Location = new System.Drawing.Point(26, 169);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(202, 46);
            this.B_Add.TabIndex = 64;
            this.B_Add.Text = "Add Workout";
            this.B_Add.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.B_Add.UseVisualStyleBackColor = false;
            this.B_Add.Click += new System.EventHandler(this.B_Add_Click);
            // 
            // LB_Clear
            // 
            this.LB_Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.LB_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LB_Clear.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.LB_Clear.FlatAppearance.BorderSize = 2;
            this.LB_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.LB_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LB_Clear.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.LB_Clear.Location = new System.Drawing.Point(280, 169);
            this.LB_Clear.Name = "LB_Clear";
            this.LB_Clear.Size = new System.Drawing.Size(202, 46);
            this.LB_Clear.TabIndex = 80;
            this.LB_Clear.Text = "Remove";
            this.LB_Clear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LB_Clear.UseVisualStyleBackColor = false;
            this.LB_Clear.Click += new System.EventHandler(this.LB_Clear_Click);
            // 
            // FES_DAY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(503, 227);
            this.Controls.Add(this.LB_Clear);
            this.Controls.Add(this.CB_Workout);
            this.Controls.Add(this.CB_Time);
            this.Controls.Add(this.LB_Day);
            this.Controls.Add(this.LB_Time);
            this.Controls.Add(this.LB_Workout);
            this.Controls.Add(this.B_Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FES_DAY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "- [Academy]";
            this.Load += new System.EventHandler(this.FES_DAY_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox CB_Time;
        public System.Windows.Forms.Label LB_Time;
        public System.Windows.Forms.Label LB_Day;
        public System.Windows.Forms.Label LB_Workout;
        public System.Windows.Forms.ComboBox CB_Workout;
        public System.Windows.Forms.Button B_Add;
        public System.Windows.Forms.Button LB_Clear;
    }
}