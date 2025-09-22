using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem_5_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int current_year = DateTime.Now.Year;
            int count;
            double ocean_increase = 1.5;


            for (count = 1; count <=10; count++)
            {
               current_year++;
               year_ListBox.Items.Add(current_year);
               ocean_ListBox.Items.Add(ocean_increase);
                ocean_increase += 1.5;
            }


        }
    }
}
