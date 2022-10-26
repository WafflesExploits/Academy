
namespace Academy
{
    partial class FEE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEE));
            this.TB_Date = new System.Windows.Forms.TextBox();
            this.LB_Date = new System.Windows.Forms.Label();
            this.LB_Event = new System.Windows.Forms.Label();
            this.TB_Event = new System.Windows.Forms.TextBox();
            this.B_Add = new System.Windows.Forms.Button();
            this.LB_Color = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.B_Color = new System.Windows.Forms.Button();
            this.B_Remove = new System.Windows.Forms.Button();
            this.CB_Black = new System.Windows.Forms.CheckBox();
            this.CB_White = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.P_Background = new System.Windows.Forms.Panel();
            this.P_Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_Date
            // 
            this.TB_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_Date.Enabled = false;
            this.TB_Date.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Date.Location = new System.Drawing.Point(15, 42);
            this.TB_Date.Name = "TB_Date";
            this.TB_Date.ReadOnly = true;
            this.TB_Date.Size = new System.Drawing.Size(219, 26);
            this.TB_Date.TabIndex = 53;
            this.TB_Date.TextChanged += new System.EventHandler(this.TB_Workout_TextChanged);
            // 
            // LB_Date
            // 
            this.LB_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Date.AutoSize = true;
            this.LB_Date.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Date.Location = new System.Drawing.Point(9, 7);
            this.LB_Date.Name = "LB_Date";
            this.LB_Date.Size = new System.Drawing.Size(70, 32);
            this.LB_Date.TabIndex = 77;
            this.LB_Date.Text = "Date";
            this.LB_Date.Click += new System.EventHandler(this.LB_Time_Click);
            // 
            // LB_Event
            // 
            this.LB_Event.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Event.AutoSize = true;
            this.LB_Event.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Event.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Event.Location = new System.Drawing.Point(9, 78);
            this.LB_Event.Name = "LB_Event";
            this.LB_Event.Size = new System.Drawing.Size(84, 32);
            this.LB_Event.TabIndex = 79;
            this.LB_Event.Text = "Event";
            this.LB_Event.Click += new System.EventHandler(this.label1_Click);
            // 
            // TB_Event
            // 
            this.TB_Event.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_Event.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Event.Location = new System.Drawing.Point(15, 113);
            this.TB_Event.MaxLength = 12;
            this.TB_Event.Name = "TB_Event";
            this.TB_Event.Size = new System.Drawing.Size(219, 26);
            this.TB_Event.TabIndex = 78;
            this.TB_Event.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TB_Event_MouseClick);
            this.TB_Event.TextChanged += new System.EventHandler(this.TB_Event_TextChanged);
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
            this.B_Add.Location = new System.Drawing.Point(12, 152);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(120, 45);
            this.B_Add.TabIndex = 80;
            this.B_Add.Text = "Add Exercise";
            this.B_Add.UseVisualStyleBackColor = false;
            this.B_Add.Click += new System.EventHandler(this.B_Add_Click);
            // 
            // LB_Color
            // 
            this.LB_Color.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Color.BackColor = System.Drawing.Color.Transparent;
            this.LB_Color.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Color.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Color.Location = new System.Drawing.Point(1, 4);
            this.LB_Color.Name = "LB_Color";
            this.LB_Color.Size = new System.Drawing.Size(197, 32);
            this.LB_Color.TabIndex = 81;
            this.LB_Color.Text = "Event Example";
            this.LB_Color.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // B_Color
            // 
            this.B_Color.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.B_Color.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.B_Color.FlatAppearance.BorderSize = 2;
            this.B_Color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Color.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Color.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.B_Color.Location = new System.Drawing.Point(269, 152);
            this.B_Color.Name = "B_Color";
            this.B_Color.Size = new System.Drawing.Size(196, 45);
            this.B_Color.TabIndex = 82;
            this.B_Color.Text = "Select Color";
            this.B_Color.UseVisualStyleBackColor = false;
            this.B_Color.Click += new System.EventHandler(this.button1_Click);
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
            this.B_Remove.Location = new System.Drawing.Point(140, 152);
            this.B_Remove.Name = "B_Remove";
            this.B_Remove.Size = new System.Drawing.Size(120, 45);
            this.B_Remove.TabIndex = 87;
            this.B_Remove.Text = "Remove";
            this.B_Remove.UseVisualStyleBackColor = false;
            this.B_Remove.Click += new System.EventHandler(this.B_Remove_Click);
            // 
            // CB_Black
            // 
            this.CB_Black.AutoSize = true;
            this.CB_Black.Checked = true;
            this.CB_Black.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_Black.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Black.ForeColor = System.Drawing.SystemColors.Control;
            this.CB_Black.Location = new System.Drawing.Point(250, 38);
            this.CB_Black.Name = "CB_Black";
            this.CB_Black.Size = new System.Drawing.Size(110, 36);
            this.CB_Black.TabIndex = 88;
            this.CB_Black.Text = "Black";
            this.CB_Black.UseVisualStyleBackColor = true;
            this.CB_Black.CheckedChanged += new System.EventHandler(this.CB_Sync_CheckedChanged);
            // 
            // CB_White
            // 
            this.CB_White.AutoSize = true;
            this.CB_White.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_White.ForeColor = System.Drawing.SystemColors.Control;
            this.CB_White.Location = new System.Drawing.Point(367, 38);
            this.CB_White.Name = "CB_White";
            this.CB_White.Size = new System.Drawing.Size(110, 36);
            this.CB_White.TabIndex = 89;
            this.CB_White.Text = "White";
            this.CB_White.UseVisualStyleBackColor = true;
            this.CB_White.CheckedChanged += new System.EventHandler(this.CB_White_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(244, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 32);
            this.label1.TabIndex = 90;
            this.label1.Text = "Background";
            // 
            // P_Background
            // 
            this.P_Background.BackColor = System.Drawing.Color.Black;
            this.P_Background.Controls.Add(this.LB_Color);
            this.P_Background.Location = new System.Drawing.Point(269, 95);
            this.P_Background.Name = "P_Background";
            this.P_Background.Size = new System.Drawing.Size(196, 44);
            this.P_Background.TabIndex = 91;
            // 
            // FEE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(474, 240);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_White);
            this.Controls.Add(this.CB_Black);
            this.Controls.Add(this.B_Remove);
            this.Controls.Add(this.B_Color);
            this.Controls.Add(this.B_Add);
            this.Controls.Add(this.LB_Event);
            this.Controls.Add(this.TB_Event);
            this.Controls.Add(this.LB_Date);
            this.Controls.Add(this.TB_Date);
            this.Controls.Add(this.P_Background);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FEE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "- [Academy]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FEE_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FEE_FormClosed);
            this.Load += new System.EventHandler(this.FEE_Load);
            this.P_Background.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Date;
        public System.Windows.Forms.Label LB_Date;
        public System.Windows.Forms.Label LB_Event;
        private System.Windows.Forms.TextBox TB_Event;
        private System.Windows.Forms.Button B_Add;
        public System.Windows.Forms.Label LB_Color;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button B_Color;
        private System.Windows.Forms.Button B_Remove;
        private System.Windows.Forms.CheckBox CB_Black;
        private System.Windows.Forms.CheckBox CB_White;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel P_Background;
    }
}