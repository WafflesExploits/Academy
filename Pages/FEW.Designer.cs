
namespace Academy
{
    partial class FEW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEW));
            this.TB_Workout = new System.Windows.Forms.TextBox();
            this.B_Save = new System.Windows.Forms.Button();
            this.B_Remove = new System.Windows.Forms.Button();
            this.B_ADD = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Workout
            // 
            this.TB_Workout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_Workout.Font = new System.Drawing.Font("Cascadia Mono", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Workout.Location = new System.Drawing.Point(362, 35);
            this.TB_Workout.MaxLength = 12;
            this.TB_Workout.Name = "TB_Workout";
            this.TB_Workout.Size = new System.Drawing.Size(219, 26);
            this.TB_Workout.TabIndex = 52;
            // 
            // B_Save
            // 
            this.B_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.B_Save.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.B_Save.FlatAppearance.BorderSize = 2;
            this.B_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Save.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.B_Save.Location = new System.Drawing.Point(362, 202);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(219, 46);
            this.B_Save.TabIndex = 51;
            this.B_Save.Text = "Save Name";
            this.B_Save.UseVisualStyleBackColor = false;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // B_Remove
            // 
            this.B_Remove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.B_Remove.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.B_Remove.FlatAppearance.BorderSize = 2;
            this.B_Remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Remove.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Remove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.B_Remove.Location = new System.Drawing.Point(362, 145);
            this.B_Remove.Name = "B_Remove";
            this.B_Remove.Size = new System.Drawing.Size(219, 46);
            this.B_Remove.TabIndex = 50;
            this.B_Remove.Text = "Remove Workout";
            this.B_Remove.UseVisualStyleBackColor = false;
            this.B_Remove.Click += new System.EventHandler(this.B_Remove_Click);
            // 
            // B_ADD
            // 
            this.B_ADD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_ADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_ADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.B_ADD.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.B_ADD.FlatAppearance.BorderSize = 2;
            this.B_ADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.B_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_ADD.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_ADD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.B_ADD.Location = new System.Drawing.Point(362, 85);
            this.B_ADD.Name = "B_ADD";
            this.B_ADD.Size = new System.Drawing.Size(219, 46);
            this.B_ADD.TabIndex = 54;
            this.B_ADD.Text = "Add Workout";
            this.B_ADD.UseVisualStyleBackColor = false;
            this.B_ADD.Click += new System.EventHandler(this.B_ADD_Click);
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
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(92)))), ((int)(((byte)(196)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV.EnableHeadersVisualStyles = false;
            this.DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.DGV.Location = new System.Drawing.Point(12, 12);
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
            this.DGV.Size = new System.Drawing.Size(330, 348);
            this.DGV.TabIndex = 58;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // FEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(594, 372);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.TB_Workout);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.B_Remove);
            this.Controls.Add(this.B_ADD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(12, 12);
            this.MaximizeBox = false;
            this.Name = "FEW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "- [Academy]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FEW_FormClosing);
            this.Load += new System.EventHandler(this.FEW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Workout;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.Button B_Remove;
        private System.Windows.Forms.Button B_ADD;
        public System.Windows.Forms.DataGridView DGV;
    }
}