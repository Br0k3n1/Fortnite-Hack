namespace Feet2Meters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(inputBox.Text, out number)) {
                double meters = number * 0.3;
                int output = (int)Math.Round(meters, MidpointRounding.AwayFromZero);
                outputLabel.Text = number.ToString() + " Feet is " + output.ToString() + " Meters";
            }
            else {
                outputLabel.Text = "ERROR: You Inputed a Non Interger Value";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Input Feet";
            inputBox.Text = string.Empty;
        }
    }
}