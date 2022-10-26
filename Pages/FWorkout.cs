using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
    public partial class FWorkout : Form
    {
        bool WSelected;
        public FWorkout()
        {
            InitializeComponent();
        }

        private void FWorkout_Load(object sender, EventArgs e)
        {
            DataTable dt = Banco.dql($@"Select WName as 'Workout' from Default2 where Username = '{Global.name}' and Info = 'mainwork';");
            if (dt.Rows.Count > 0) // adicionar Workouts à ComboBox
            {
                CB_Workouts.Items.Clear();
                for (int v = 0; v < dt.Rows.Count; v++)
                {
                    
                    CB_Workouts.Items.Add(dt.Rows[v].ItemArray[0].ToString());

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FEW few = new FEW(this);
            few.ShowDialog();
        }



        public void DGVGetTables(string workout)
        {
            if (workout != null)
            {
                DGV.Columns.Clear();
                DataTable dt = Banco.dql($@"Select  Exercise, Sets, Reps, Info as 'Desc' from Default2 where Username = '{Global.name}' and WName = '{workout}' and Info not like 'mainwork'");
                DGV.DataSource = null;
                DGV.DataSource = dt;
                DGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                DGV.Columns[0].FillWeight = 30;
                DGV.Columns[1].Width = 70;
                DGV.Columns[2].Width = 70;
                DGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DGV.Columns[3].FillWeight = 70;
            }
        }

        private void CB_Workouts_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CB_Workouts.SelectedText != null)
            {
                WSelected = true;
                string workout = CB_Workouts.Text ;
                DGVGetTables(workout);
            }
        }

        private void B_novo_Click(object sender, EventArgs e)
        {
            if (!WSelected) { Banco.MInformation("Select a workout first (Top corner of the screen)."); return; }
            DGVGetTables(CB_Workouts.Text);
            FAW faw = new FAW(this, 0);
            faw.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void B_ExEdit_Click(object sender, EventArgs e)
        {
            if (!WSelected) { Banco.MInformation("Select a workout first (Top corner of the screen)."); return; }
            if ( DGV.SelectedRows.Count < 0) { return; } 
                string exercise = DGV.SelectedCells[0].Value.ToString();
                string sets = DGV.SelectedCells[1].Value.ToString();
                string reps = DGV.SelectedCells[2].Value.ToString();
                string info = DGV.SelectedCells[3].Value.ToString();
                
                DataTable dt = Banco.dql($"Select ID from Default2 where Exercise='{exercise}' AND Sets='{sets}' AND Reps='{reps}' AND Info='{info}' AND WName='{CB_Workouts.Text}' AND Username='{Global.name}'");
                int id = int.Parse(dt.Rows[0].ItemArray[0].ToString());
                FAW faw = new FAW(this, id);
                faw.ShowDialog();
        }

        private void B_Remove_Click(object sender, EventArgs e)
        {
            if (!Banco.MQuestion("Are you sure you want to delete this exercise?")) { return; }
            if (!WSelected) { Banco.MInformation("Select a workout first (Top corner of the screen)."); return; }
            if (DGV.SelectedRows.Count < 0) { return; }
            string exercise = DGV.SelectedCells[0].Value.ToString();
                string sets = DGV.SelectedCells[1].Value.ToString();
                string reps = DGV.SelectedCells[2].Value.ToString();
                string info = DGV.SelectedCells[3].Value.ToString();
                Banco.dml($"DELETE FROM Default2 where Exercise='{exercise}' AND Sets='{sets}' AND Reps='{reps}' AND Info='{info}' AND WName='{CB_Workouts.Text}' AND Username='{Global.name}'", "Exercise Removed With Success!");
                DGVGetTables(CB_Workouts.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Print to pdf all workouts with respective exercises 
            if (!WSelected) { Banco.MInformation("Select a workout first (Top corner of the screen)."); return; }
            if (DGV.SelectedRows.Count < 0) { return; }
        }
    }
}
