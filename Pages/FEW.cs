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
    public partial class FEW : Form
    {
        FWorkout Mainform;
       
        private void DGVGetTables()
        {
            DataTable dt = Banco.dql($@"Select WName as 'Workout' from Default2 where Username = '{Global.name}' and Info = 'mainwork';");
            DGV.DataSource = null;
            DGV.DataSource = dt;
            DGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        
        public FEW(FWorkout form)
        {
            Mainform = form;
            InitializeComponent();
            DGVGetTables();
        }

        private bool ExistsWorkout(string workout)
        {
            DataTable dtt = Banco.dql($"Select WName from Default2 Where Username='{Global.name}' AND WName = '{workout}' ;");

            if(dtt.Rows.Count <=0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private void FEW_Load(object sender, EventArgs e)
        {

        }

        private void B_ADD_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count > 0)
            {
                string workout = DGV.SelectedCells[0].Value.ToString();
            }
            if(TB_Workout.TextLength > 12)
            {
                Banco.MError("Workout name has too many characters.");
                return;
            }
            if (TB_Workout.Text != "" && !ExistsWorkout(TB_Workout.Text))
            {
                Banco.dml($"Insert INTO Default2 (Info, WName, Username) Values('mainwork', '{TB_Workout.Text}', '{Global.name}')");
                Banco.MInformation($"Successfully created '{TB_Workout.Text}'!");
            }else if(TB_Workout.Text == "")
            {
                Banco.MError("Type a name for the workout.");
            }else if (ExistsWorkout(TB_Workout.Text))
            {
                Banco.MError("Workout has already been created.");
            }
            
            DGVGetTables();
            TB_Workout.Clear();
            TB_Workout.Focus();
        }

        private void B_Remove_Click(object sender, EventArgs e)
        {
            if (!Banco.MQuestion("Are you sure you want to delete this workout?")) { return; }
            if (DGV.SelectedCells.Count > 0 && DGV.SelectedCells[0].Value.ToString() != null)
            {
                string workout = DGV.SelectedCells[0].Value.ToString();
                Banco.dml($"DELETE FROM Default2 where WName = '{workout}' AND Username = '{Global.name}'", $"Successfully removed '{workout}'!");
                DGVGetTables();
            }
        }

        private void B_Save_Click(object sender, EventArgs e)
        {
            
            if(TB_Workout.Text != "" && DGV.SelectedCells.Count>0 && DGV.SelectedCells[0].Value.ToString() != null) 
            {
                string workout = DGV.SelectedCells[0].Value.ToString();
                Banco.dml($"UPDATE Default2 SET WName = '{TB_Workout.Text}' WHERE WName = '{workout}' AND Username = '{Global.name}' ", $"Successfully changed '{workout}' to '{TB_Workout.Text}'!");
                DGVGetTables();
            }
        }

        private void DGV_DoubleClick(object sender, EventArgs e)
        {
        
        }

        private void FEW_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataTable dt = Banco.dql($@"Select WName as 'Workout' from Default2 where Username = '{Global.name}' and Info = 'mainwork';");
            if (dt.Rows.Count > 0)
            {
                Mainform.CB_Workouts.Items.Clear();
                for (int v=0; v < dt.Rows.Count; v++) {

                    Mainform.CB_Workouts.Items.Add(dt.Rows[v].ItemArray[0].ToString());

                }
            }
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
