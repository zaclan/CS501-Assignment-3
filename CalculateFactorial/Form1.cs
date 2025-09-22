using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CalculateFactorial
{
    public partial class form_calculateFactorial : Form
    {
        public form_calculateFactorial()
        {
            InitializeComponent();
        }

        //On click, the factorial is calculated via loop and displayed.
        private void button_calculate_Click(object sender, EventArgs e)
        {
            int input = (int) Math.Round(nup_selectNumber.Value);
            long result = 1;
            while(input > 0)
            {
                result *= input--;
            }
            text_result.Text = result.ToString();
        }
    }
}
