
namespace Academy
{
    partial class FWorkout
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.B_novo = new System.Windows.Forms.Button();
            this.B_ExEdit = new System.Windows.Forms.Button();
            this.CB_Workouts = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.B_Remove = new System.Windows.Forms.Button();
            this.B_Edit = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Exercise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // B_novo
            // 
            this.B_novo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.B_novo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_novo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.B_novo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.B_novo.FlatAppearance.BorderSize = 2;
            this.B_novo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_novo.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_novo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.B_novo.Location = new System.Drawing.Point(21, 720);
            this.B_novo.Name = "B_novo";
            this.B_novo.Size = new System.Drawing.Size(234, 40);
            this.B_novo.TabIndex = 33;
            this.B_novo.Text = "Add Exercise";
            this.B_novo.UseVisualStyleBackColor = false;
            this.B_novo.Click += new System.EventHandler(this.B_novo_Click);
            // 
            // B_ExEdit
            // 
            this.B_ExEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.B_ExEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_ExEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.B_ExEdit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.B_ExEdit.FlatAppearance.BorderSize = 2;
            this.B_ExEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_ExEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_ExEdit.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_ExEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.B_ExEdit.Location = new System.Drawing.Point(287, 720);
            this.B_ExEdit.Name = "B_ExEdit";
            this.B_ExEdit.Size = new System.Drawing.Size(234, 40);
            this.B_ExEdit.TabIndex = 34;
            this.B_ExEdit.Text = "Edit Exercise";
            this.B_ExEdit.UseVisualStyleBackColor = false;
            this.B_ExEdit.Click += new System.EventHandler(this.B_ExEdit_Click);
            // 
            // CB_Workouts
            // 
            this.CB_Workouts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(69)))), ((int)(((byte)(148)))));
            this.CB_Workouts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Workouts.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Workouts.ForeColor = System.Drawing.SystemColors.Window;
            this.CB_Workouts.FormattingEnabled = true;
            this.CB_Workouts.Location = new System.Drawing.Point(21, 11);
            this.CB_Workouts.Name = "CB_Workouts";
            this.CB_Workouts.Size = new System.Drawing.Size(201, 29);
            this.CB_Workouts.TabIndex = 35;
            this.CB_Workouts.Text = "Select Workout";
            this.CB_Workouts.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.CB_Workouts.SelectedValueChanged += new System.EventHandler(this.CB_Workouts_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.B_Remove);
            this.panel1.Controls.Add(this.B_Edit);
            this.panel1.Controls.Add(this.B_novo);
            this.panel1.Controls.Add(this.CB_Workouts);
            this.panel1.Controls.Add(this.B_ExEdit);
            this.panel1.Controls.Add(this.DGV);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 774);
            this.panel1.TabIndex = 36;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // B_Remove
            // 
            this.B_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.B_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.B_Remove.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.B_Remove.FlatAppearance.BorderSize = 2;
            this.B_Remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Remove.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Remove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.B_Remove.Location = new System.Drawing.Point(550, 720);
            this.B_Remove.Name = "B_Remove";
            this.B_Remove.Size = new System.Drawing.Size(234, 40);
            this.B_Remove.TabIndex = 39;
            this.B_Remove.Text = "Remove Exercise";
            this.B_Remove.UseVisualStyleBackColor = false;
            this.B_Remove.Click += new System.EventHandler(this.B_Remove_Click);
            // 
            // B_Edit
            // 
            this.B_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.B_Edit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.B_Edit.FlatAppearance.BorderSize = 2;
            this.B_Edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Edit.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.B_Edit.Location = new System.Drawing.Point(245, 7);
            this.B_Edit.Name = "B_Edit";
            this.B_Edit.Size = new System.Drawing.Size(92, 37);
            this.B_Edit.TabIndex = 38;
            this.B_Edit.Text = "Edit";
            this.B_Edit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.B_Edit.UseVisualStyleBackColor = false;
            this.B_Edit.Click += new System.EventHandler(this.button2_Click);
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(92)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Exercise,
            this.Sets,
            this.Reps,
            this.Desc});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(69)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(92)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle11;
            this.DGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV.EnableHeadersVisualStyles = false;
            this.DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.DGV.Location = new System.Drawing.Point(21, 61);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(69)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(92)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DGV.RowHeadersWidth = 62;
            this.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV.RowTemplate.Height = 28;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.ShowCellErrors = false;
            this.DGV.ShowCellToolTips = false;
            this.DGV.ShowEditingIcon = false;
            this.DGV.ShowRowErrors = false;
            this.DGV.Size = new System.Drawing.Size(1029, 639);
            this.DGV.TabIndex = 37;
            // 
            // Exercise
            // 
            this.Exercise.HeaderText = "Exercise";
            this.Exercise.MinimumWidth = 320;
            this.Exercise.Name = "Exercise";
            this.Exercise.ReadOnly = true;
            this.Exercise.Width = 320;
            // 
            // Sets
            // 
            this.Sets.HeaderText = "Sets";
            this.Sets.MinimumWidth = 90;
            this.Sets.Name = "Sets";
            this.Sets.ReadOnly = true;
            this.Sets.Width = 90;
            // 
            // Reps
            // 
            this.Reps.HeaderText = "Reps";
            this.Reps.MinimumWidth = 90;
            this.Reps.Name = "Reps";
            this.Reps.ReadOnly = true;
            this.Reps.Width = 90;
            // 
            // Desc
            // 
            this.Desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Desc.HeaderText = "Desc";
            this.Desc.MinimumWidth = 410;
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.button1.Location = new System.Drawing.Point(816, 720);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 40);
            this.button1.TabIndex = 40;
            this.button1.Text = "Print To PDF";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FWorkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1074, 773);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FWorkout";
            this.Text = "FWorkout";
            this.Load += new System.EventHandler(this.FWorkout_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button B_novo;
        private System.Windows.Forms.Button B_ExEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button B_Edit;
        public System.Windows.Forms.ComboBox CB_Workouts;
        public System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button B_Remove;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exercise;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sets;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reps;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.Button button1;
    }
}