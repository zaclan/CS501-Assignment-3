using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem_3_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            try
            {

                int tickets_b;
                int tickets_a;
                int tickets_c;

                tickets_a = int.Parse(Tickets_A.Text);
                tickets_b = int.Parse(Tickets_B.Text);
                tickets_c = int.Parse(Tickets_C.Text);

                double rev_A = tickets_a * 15.0;
                double rev_B = tickets_b * 12.0;
                double rev_C = tickets_c * 9.0; 
                double total_rev = rev_A + rev_B + rev_C;  

                Revenue_A.Text = rev_A.ToString("C");
                Revenue_B.Text = rev_B.ToString("C");
                Revenue_C.Text = rev_C.ToString("C");
                Revenue_Total.Text = total_rev.ToString("C");

                

                
            } catch (Exception ex) 
            {
                MessageBox.Show("Please enter a valid ticket number.");
            }

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            foreach(Control control in Tickets_Box.Controls)    //Looping through Ticket GroupBox
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = string.Empty;
                }
            }

            foreach (Control control in Revenue_Box.Controls)   //Looping through Revenue GroupBox 
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = string.Empty;
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
