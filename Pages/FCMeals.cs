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
    public partial class FCMeals : Form
    {
        public FCMeals()
        {
            InitializeComponent();
        }

        public int N_IDDAY, N_IDMEAL;
        public string name;
        private void FCMeals_Load(object sender, EventArgs e)
        {
            DGVGetTables();
        }
        private void DGVGetTables()
        {
           DGV.Columns.Clear();
            DataTable dt = Banco.dql($@"Select T_Name as 'Name', 
                CASE
                    WHEN N_IDDAY = '0' THEN 'Sunday'
                    WHEN N_IDDAY = '1' THEN 'Monday'
                    WHEN N_IDDAY= '2' THEN 'Tuesday'
                    WHEN N_IDDAY= '3' THEN 'Wednesday'
                    WHEN N_IDDAY= '4' THEN 'Thursday'
                    WHEN N_IDDAY= '5' THEN 'Friday'
                    WHEN N_IDDAY= '6' THEN 'Saturday'
                END as 'Day', 
                N_IDMEAL as 'Meal' from tb_meals where T_USERNAME ='{Global.name}'
            ");
            DGV.DataSource = dt;
            DGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void B_Copy_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count == 0) { return; }
            name = DGV.SelectedRows[0].Cells[0].Value.ToString();
            N_IDDAY = GetDay(DGV.SelectedRows[0].Cells[1].Value.ToString());
            N_IDMEAL = int.Parse(DGV.SelectedRows[0].Cells[2].Value.ToString());
            this.Close();
        }
        private int GetDay(string day)
        {
             if (day == "Monday")
            {
                return 1;
            }
            else if (day == "Tuesday")
            {
                return 2;
            }
            else if (day == "Wednesday")
            {
                return 3;
            }
            else if (day == "Thursday")
            {
                return 4;
            }
            else if (day == "Friday")
            {
                return 5;
            }
            else if (day == "Saturday")
            {
                return 6;
            }
            else
            {
                return 0;
            }
        }
    }
}
