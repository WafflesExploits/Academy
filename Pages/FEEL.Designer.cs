
namespace Academy
{
    partial class FEEL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEEL));
            this.DGV = new System.Windows.Forms.DataGridView();
            this.B_Remove = new System.Windows.Forms.Button();
            this.B_Add = new System.Windows.Forms.Button();
            this.TB_Event = new System.Windows.Forms.TextBox();
            this.B_Save = new System.Windows.Forms.Button();
            this.LB_Event = new System.Windows.Forms.Label();
            this.NUP_DAY = new System.Windows.Forms.NumericUpDown();
            this.LB_Background = new System.Windows.Forms.Label();
            this.NUP_MONTH = new System.Windows.Forms.NumericUpDown();
            this.CB_White = new System.Windows.Forms.CheckBox();
            this.NUP_YEAR = new System.Windows.Forms.NumericUpDown();
            this.CB_Black = new System.Windows.Forms.CheckBox();
            this.LB_Color = new System.Windows.Forms.Label();
            this.P_Background = new System.Windows.Forms.Panel();
            this.LB_Day = new System.Windows.Forms.Label();
            this.LB_Month = new System.Windows.Forms.Label();
            this.B_Color = new System.Windows.Forms.Button();
            this.LB_Year = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUP_DAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUP_MONTH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUP_YEAR)).BeginInit();
            this.P_Background.SuspendLayout();
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
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(92)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV.EnableHeadersVisualStyles = false;
            this.DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.DGV.Location = new System.Drawing.Point(8, 7);
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
            this.DGV.Size = new System.Drawing.Size(493, 374);
            this.DGV.TabIndex = 63;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
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
            this.B_Remove.Location = new System.Drawing.Point(770, 327);
            this.B_Remove.Name = "B_Remove";
            this.B_Remove.Size = new System.Drawing.Size(120, 45);
            this.B_Remove.TabIndex = 98;
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
            this.B_Add.Location = new System.Drawing.Point(518, 327);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(120, 45);
            this.B_Add.TabIndex = 96;
            this.B_Add.Text = "Add Exercise";
            this.B_Add.UseVisualStyleBackColor = false;
            this.B_Add.Click += new System.EventHandler(this.B_Add_Click);
            // 
            // TB_Event
            // 
            this.TB_Event.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_Event.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Event.Location = new System.Drawing.Point(518, 294);
            this.TB_Event.MaxLength = 12;
            this.TB_Event.Name = "TB_Event";
            this.TB_Event.Size = new System.Drawing.Size(219, 26);
            this.TB_Event.TabIndex = 94;
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
            this.B_Save.Location = new System.Drawing.Point(644, 327);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(120, 45);
            this.B_Save.TabIndex = 103;
            this.B_Save.Text = "Save";
            this.B_Save.UseVisualStyleBackColor = false;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // LB_Event
            // 
            this.LB_Event.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Event.AutoSize = true;
            this.LB_Event.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Event.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Event.Location = new System.Drawing.Point(512, 259);
            this.LB_Event.Name = "LB_Event";
            this.LB_Event.Size = new System.Drawing.Size(84, 32);
            this.LB_Event.TabIndex = 95;
            this.LB_Event.Text = "Event";
            // 
            // NUP_DAY
            // 
            this.NUP_DAY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUP_DAY.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUP_DAY.Location = new System.Drawing.Point(520, 50);
            this.NUP_DAY.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.NUP_DAY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUP_DAY.Name = "NUP_DAY";
            this.NUP_DAY.Size = new System.Drawing.Size(71, 26);
            this.NUP_DAY.TabIndex = 104;
            this.NUP_DAY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LB_Background
            // 
            this.LB_Background.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Background.AutoSize = true;
            this.LB_Background.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Background.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Background.Location = new System.Drawing.Point(512, 84);
            this.LB_Background.Name = "LB_Background";
            this.LB_Background.Size = new System.Drawing.Size(154, 32);
            this.LB_Background.TabIndex = 101;
            this.LB_Background.Text = "Background";
            // 
            // NUP_MONTH
            // 
            this.NUP_MONTH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUP_MONTH.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUP_MONTH.Location = new System.Drawing.Point(604, 50);
            this.NUP_MONTH.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NUP_MONTH.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUP_MONTH.Name = "NUP_MONTH";
            this.NUP_MONTH.Size = new System.Drawing.Size(71, 26);
            this.NUP_MONTH.TabIndex = 105;
            this.NUP_MONTH.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NUP_MONTH.ValueChanged += new System.EventHandler(this.NUP_MONTH_ValueChanged);
            // 
            // CB_White
            // 
            this.CB_White.AutoSize = true;
            this.CB_White.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_White.ForeColor = System.Drawing.SystemColors.Control;
            this.CB_White.Location = new System.Drawing.Point(636, 119);
            this.CB_White.Name = "CB_White";
            this.CB_White.Size = new System.Drawing.Size(110, 36);
            this.CB_White.TabIndex = 100;
            this.CB_White.Text = "White";
            this.CB_White.UseVisualStyleBackColor = true;
            this.CB_White.CheckedChanged += new System.EventHandler(this.CB_White_CheckedChanged);
            // 
            // NUP_YEAR
            // 
            this.NUP_YEAR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUP_YEAR.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUP_YEAR.Location = new System.Drawing.Point(692, 50);
            this.NUP_YEAR.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.NUP_YEAR.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.NUP_YEAR.Name = "NUP_YEAR";
            this.NUP_YEAR.Size = new System.Drawing.Size(65, 26);
            this.NUP_YEAR.TabIndex = 106;
            this.NUP_YEAR.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.NUP_YEAR.ValueChanged += new System.EventHandler(this.NUP_YEAR_ValueChanged);
            // 
            // CB_Black
            // 
            this.CB_Black.AutoSize = true;
            this.CB_Black.Checked = true;
            this.CB_Black.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_Black.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Black.ForeColor = System.Drawing.SystemColors.Control;
            this.CB_Black.Location = new System.Drawing.Point(520, 119);
            this.CB_Black.Name = "CB_Black";
            this.CB_Black.Size = new System.Drawing.Size(110, 36);
            this.CB_Black.TabIndex = 99;
            this.CB_Black.Text = "Black";
            this.CB_Black.UseVisualStyleBackColor = true;
            this.CB_Black.CheckedChanged += new System.EventHandler(this.CB_Black_CheckedChanged);
            // 
            // LB_Color
            // 
            this.LB_Color.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Color.BackColor = System.Drawing.Color.Transparent;
            this.LB_Color.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Color.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Color.Location = new System.Drawing.Point(3, 4);
            this.LB_Color.Name = "LB_Color";
            this.LB_Color.Size = new System.Drawing.Size(197, 32);
            this.LB_Color.TabIndex = 81;
            this.LB_Color.Text = "Event Example";
            this.LB_Color.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P_Background
            // 
            this.P_Background.BackColor = System.Drawing.Color.Black;
            this.P_Background.Controls.Add(this.LB_Color);
            this.P_Background.Location = new System.Drawing.Point(518, 161);
            this.P_Background.Name = "P_Background";
            this.P_Background.Size = new System.Drawing.Size(196, 44);
            this.P_Background.TabIndex = 102;
            // 
            // LB_Day
            // 
            this.LB_Day.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Day.AutoSize = true;
            this.LB_Day.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Day.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Day.Location = new System.Drawing.Point(514, 12);
            this.LB_Day.Name = "LB_Day";
            this.LB_Day.Size = new System.Drawing.Size(56, 32);
            this.LB_Day.TabIndex = 93;
            this.LB_Day.Text = "Day";
            // 
            // LB_Month
            // 
            this.LB_Month.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Month.AutoSize = true;
            this.LB_Month.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Month.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Month.Location = new System.Drawing.Point(598, 15);
            this.LB_Month.Name = "LB_Month";
            this.LB_Month.Size = new System.Drawing.Size(84, 32);
            this.LB_Month.TabIndex = 107;
            this.LB_Month.Text = "Month";
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
            this.B_Color.Location = new System.Drawing.Point(518, 211);
            this.B_Color.Name = "B_Color";
            this.B_Color.Size = new System.Drawing.Size(196, 45);
            this.B_Color.TabIndex = 97;
            this.B_Color.Text = "Select Color";
            this.B_Color.UseVisualStyleBackColor = false;
            this.B_Color.Click += new System.EventHandler(this.B_Color_Click);
            // 
            // LB_Year
            // 
            this.LB_Year.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_Year.AutoSize = true;
            this.LB_Year.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Year.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LB_Year.Location = new System.Drawing.Point(688, 15);
            this.LB_Year.Name = "LB_Year";
            this.LB_Year.Size = new System.Drawing.Size(70, 32);
            this.LB_Year.TabIndex = 108;
            this.LB_Year.Text = "Year";
            // 
            // FEEL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(956, 387);
            this.Controls.Add(this.LB_Year);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.B_Color);
            this.Controls.Add(this.LB_Month);
            this.Controls.Add(this.LB_Day);
            this.Controls.Add(this.P_Background);
            this.Controls.Add(this.CB_Black);
            this.Controls.Add(this.NUP_YEAR);
            this.Controls.Add(this.CB_White);
            this.Controls.Add(this.B_Remove);
            this.Controls.Add(this.NUP_MONTH);
            this.Controls.Add(this.LB_Background);
            this.Controls.Add(this.TB_Event);
            this.Controls.Add(this.B_Add);
            this.Controls.Add(this.NUP_DAY);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.LB_Event);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FEEL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "- [Academy]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FEEL_FormClosing);
            this.Load += new System.EventHandler(this.FEEL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUP_DAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUP_MONTH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUP_YEAR)).EndInit();
            this.P_Background.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button B_Remove;
        private System.Windows.Forms.Button B_Add;
        private System.Windows.Forms.TextBox TB_Event;
        private System.Windows.Forms.Button B_Save;
        public System.Windows.Forms.Label LB_Event;
        private System.Windows.Forms.NumericUpDown NUP_DAY;
        public System.Windows.Forms.Label LB_Background;
        private System.Windows.Forms.NumericUpDown NUP_MONTH;
        private System.Windows.Forms.CheckBox CB_White;
        private System.Windows.Forms.NumericUpDown NUP_YEAR;
        private System.Windows.Forms.CheckBox CB_Black;
        public System.Windows.Forms.Label LB_Color;
        private System.Windows.Forms.Panel P_Background;
        public System.Windows.Forms.Label LB_Day;
        public System.Windows.Forms.Label LB_Month;
        private System.Windows.Forms.Button B_Color;
        public System.Windows.Forms.Label LB_Year;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}