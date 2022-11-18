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
    public partial class FAF : Form
    {
        decimal Fat, Trans, Saturated, MoPoly, Calories;
        public FAF(decimal FAT, decimal CALORIES, bool PERWEEK)
        {
            if (PERWEEK)
            {
                Fat = FAT*7;
                Calories = CALORIES*7;
                InitializeComponent();
            }
            else
            {
                Fat = FAT;
                Calories = CALORIES;
                InitializeComponent();
            }
        }

        private void FAF_Load(object sender, EventArgs e)
        {
            SetTB();

        }
        
        private void SetTB()
        {
            CalculateFats();
            LB_Fats.Text = $"Fats: {Fat}g";
            LB_MoPoly.Text = $"Mono/Polysaturated - [{MoPoly}g]";
            LB_Saturated.Text = $"Saturated - [{Saturated}g]";
            LB_Trans.Text = $"Trans - [{Trans}g]";
        }

       
        private void CalculateFats()
        {

            /* Energy Intake: 
             *  Trans fat: 0-1% 
             *  Saturated fat: 5-6%
             *  Mono/Poly fat: Remaining fats or all fat energy
            */
            Trans = 0.01m * Calories;
            Saturated = 0.06m * Calories;
            Trans = Trans / 9m;
            Saturated = Saturated / 9m;
            MoPoly = Fat - (Saturated + Trans);

        }
    }
}
