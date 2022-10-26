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
    public partial class FEP : Form
    {
        public FEP()
        {
            InitializeComponent();
        }
        char gender='M';
        
        private void FEP_Load(object sender, EventArgs e)
        {
            DataTable dt = Banco.dql($"SELECT N_AGE, N_HEIGHT, N_WEIGHT, T_GENDER FROM tb_physique where T_USERNAME='{Global.name}' ");
            if (dt.Rows.Count > 0)
            {
                NUP_Age.Value = decimal.Parse(dt.Rows[0].ItemArray[0].ToString());
                NUP_Height.Value = decimal.Parse(dt.Rows[0].ItemArray[1].ToString());
                NUP_Weight.Value = decimal.Parse(dt.Rows[0].ItemArray[2].ToString());
                string Gender = dt.Rows[0].ItemArray[3].ToString();
                if (Gender == "M")
                {
                    CB_Male.Checked = true;
                    CB_Female.Checked = false;
                    gender = 'M';
                }
                else
                {
                    CB_Male.Checked = false;
                    CB_Female.Checked = true;
                    gender = 'F';
                }
            }
        }

        private void CB_Male_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Male.Checked)
            {
                gender = 'M';
                CB_Female.Checked = false;
            }
            else
            {
                gender = 'F';
                CB_Female.Checked = true;
            }
        }

        private void CB_Female_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Female.Checked)
            {
                gender = 'F';
                CB_Male.Checked = false;
            }
            else
            {
                gender = 'M';
                CB_Male.Checked = true;
            }
        }

        private void B_Save_Click(object sender, EventArgs e)
        {
            if (NUP_Height.Value == 0) { Banco.MError("Select a valid height."); return; }
            if (NUP_Weight.Value == 0) { Banco.MError("Select a valid weight."); return; }
            if(!CB_Female.Checked && !CB_Male.Checked) { Banco.MError("Select a gender."); return; }
            DataTable dt = Banco.dql($"SELECT N_AGE FROM tb_physique where T_USERNAME='{Global.name}' ");
            if (dt.Rows.Count > 0)
            {
                Banco.dml($"UPDATE tb_physique SET N_AGE='{NUP_Age.Value}', N_HEIGHT='{NUP_Height.Value}', N_WEIGHT='{NUP_Weight.Value}', T_GENDER='{gender}' where T_USERNAME ='{Global.name}' ", "Physique has been saved.");
                this.Close();
                return;
            }
            Banco.dml($"INSERT INTO tb_physique (T_USERNAME,N_AGE, N_HEIGHT, N_WEIGHT, T_GENDER) VALUES ('{Global.name}','{NUP_Age.Value}', '{NUP_Height.Value}', '{NUP_Weight.Value}', '{gender}') ", "Physique has been saved.");
            this.Close();
        }

        private void LB_Wkg_Click(object sender, EventArgs e)
        {

        }
    }
}
