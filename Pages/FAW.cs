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
    public partial class FAW : Form
    {
        FWorkout fworkout;
        bool add;
        int ID;
        public FAW(FWorkout form, int id)
        {
            InitializeComponent();
            fworkout = form;
            if (id != 0)
            {
                ID = id;
            }
            else
            {
                add = true;
            }
        }

        private void FAW_Load(object sender, EventArgs e)
        {
            if (!add)
            {
                B_Add.Text = "Save Exercise";
                TB_Exercise.Text = fworkout.DGV.SelectedCells[0].Value.ToString();
                TB_Sets.Text = fworkout.DGV.SelectedCells[1].Value.ToString();
                TB_Reps.Text = fworkout.DGV.SelectedCells[2].Value.ToString();
                TB_Info.Text = fworkout.DGV.SelectedCells[3].Value.ToString();
            }
            else
            {
                B_Add.Text = "Add Exercise";
            }
            TB_Exercise.Focus();
        }
        private bool HasSpecialChars(string yourString)
        {
            return yourString.Any(ch => !Char.IsLetterOrDigit(ch));
        }
        private void B_Add_Click(object sender, EventArgs e)
        {
           /* if(HasSpecialChars(TB_Exercise.Text))
            {
                Banco.MError("Invalid name for workout ( Special Characters).");
                return;
            }
           */
            if (add) //add
            {
                if (TB_Exercise.Text == "")
                {
                    Banco.MError("Invalid name for Exercise.");
                    TB_Exercise.Focus();
                }
                else if (TB_Reps.Text == "")
                {
                    Banco.MError("Invalid number of Reps.");
                    TB_Reps.Focus();
                }
                else if (TB_Sets.Text == "")
                {
                    Banco.MError("Invalid number of Sets.");
                    TB_Sets.Focus();
                }
                else
                {

                    Banco.dml($"Insert into Default2 (Exercise, Reps, Sets, Info, WName, Username) Values ('{TB_Exercise.Text}','{TB_Reps.Text}','{TB_Sets.Text}','{TB_Info.Text}','{fworkout.CB_Workouts.Text}', '{Global.name}')", "Exercise added with Sucess!");
                    fworkout.DGVGetTables(fworkout.CB_Workouts.Text);
                    this.Close();
                }
            }else // edit
            {
                if (TB_Exercise.Text == "")
                {
                    Banco.MError("Invalid name for Exercise.");
                    TB_Exercise.Focus();
                }
                else if (TB_Reps.Text == "")
                {
                    Banco.MError("Invalid number of Reps.");
                    TB_Reps.Focus();
                }
                else if (TB_Sets.Text == "")
                {
                    Banco.MError("Invalid number of Sets.");
                    TB_Sets.Focus();
                }
                else
                {

                    Banco.dml($"UPDATE Default2 SET Exercise ='{TB_Exercise.Text}', Reps='{TB_Reps.Text}', Sets='{TB_Sets.Text}', Info='{TB_Info.Text}' where WName = '{fworkout.CB_Workouts.Text}' AND Username = '{Global.name}' AND ID='{ID.ToString()}' ", "Exercise saved with Sucess!");
                    
                    fworkout.DGVGetTables(fworkout.CB_Workouts.Text);
                    this.Close();
                }
            }
        }
    }
}
