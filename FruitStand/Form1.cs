using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitStand
{
    public partial class form_fruitStand : Form
    {
        double totalPrice = 0.0;    //Stores the total price. Whenever the price changes, the price textbox changes to reflect this
        public form_fruitStand()
        {
            InitializeComponent();
        }

        private void picture_banana_Click(object sender, EventArgs e)
        {
            //whenever updating price, change the totalPrice value and convert it to a string
            totalPrice += .65;
            text_totalAmount.Text = "$"+totalPrice.ToString("F2");  //ensure 2 decimal places since it is a price
        }

        private void picture_apple_Click(object sender, EventArgs e)
        {
            totalPrice += 1.35;
            text_totalAmount.Text = "$" + totalPrice.ToString("F2");
        }

        private void picture_orange_Click(object sender, EventArgs e)
        {
            totalPrice += 1.60;
            text_totalAmount.Text = "$" + totalPrice.ToString("F2");
        }

        private void picture_pear_Click(object sender, EventArgs e)
        {
            totalPrice += 1.20;
            text_totalAmount.Text = "$" + totalPrice.ToString("F2");
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            totalPrice = 0.0;
            text_totalAmount.Text = "$" + totalPrice.ToString("F2");
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            //end the application
            Application.Exit();
        }
    }
}
