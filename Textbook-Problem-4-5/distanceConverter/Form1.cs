namespace distanceConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            double num = double.Parse(inputTxt.Text);
            // Grabs number to be converted

            if (convertBox1.Text == convertBox2.Text) // If they chose the same metric throw back the same number
            {
                outputTxt.Text = inputTxt.Text;
            }
            else if (convertBox1.Text == "Inches") // If they choose inches
            {
                if (convertBox2.Text == "Feet")
                {
                    outputTxt.Text = (num / 12).ToString();
                }
                else if (convertBox2.Text == "Yards")
                {
                    outputTxt.Text = (num / 36).ToString();
                }
            }

            else if (convertBox1.Text == "Feet") // If they choose feet
            {
                if (convertBox2.Text == "Inches")
                {
                    outputTxt.Text = (num * 12).ToString();
                }
                else if (convertBox2.Text == "Yards")
                {
                    outputTxt.Text = (num / 3).ToString();
                }
            }

            else if (convertBox1.Text == "Yards") // If they choose yards
            {
                if (convertBox2.Text == "Inches")
                {
                    outputTxt.Text = (num * 36).ToString();
                }
                else if (convertBox2.Text == "Feet")
                {
                    outputTxt.Text = (num * 3).ToString();
                }
            }
        }
    }
}
