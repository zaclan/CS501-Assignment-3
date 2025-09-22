namespace Roman_Numeral_Converter_4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numInputTxt_TextChanged(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(numInputTxt.Text);
            // Takes in the users number 
            string[] romnum = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };
            // Array of strings to easily allow us to choose which roman numerial they want 
            if (num < 1 || num > 10)
            {
                romOutputTxt.Text = "Please enter a number between 1 and 10";
            } // Error handling for invalid numbers
            else
            {
                romOutputTxt.Text = romnum[num - 1];
            }
        }

    }
}
