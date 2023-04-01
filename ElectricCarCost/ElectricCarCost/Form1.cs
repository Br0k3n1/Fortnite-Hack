namespace ElectricCarCost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Hide Final Bill
            headerLabel.Visible = false;
            nameLabel.Visible = false; 
            addressLabel.Visible = false;
            hoursLabel.Visible = false;
            billLabel.Visible = false;
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            int finalBill;
            if (hoursInput.Value > 4)
            {
                finalBill = (((int)hoursInput.Value - 4) * 25) + 8; // $25 Every Hour
            }
            else if (hoursInput.Value > 2)
            {
                finalBill = (((int)hoursInput.Value - 2) * 3) + 2; // $3 Every Hour
            }
            else
            {
                finalBill = (int)hoursInput.Value; // $1 Every Hour
            }

            // Make Final Bill
            nameLabel.Text = "Name: " + nameInput.Text;
            addressLabel.Text = "Address: " + addressInput.Text;
            hoursLabel.Text = "Hours Spent Charging: " + hoursInput.Value;
            billLabel.Text = "Final Bill: $" + finalBill;

            headerLabel.Visible = true;
            nameLabel.Visible = true;
            addressLabel.Visible = true;
            hoursLabel.Visible = true;
            billLabel.Visible = true;
        }

        // Reset Everything
        private void clearButton_Click(object sender, EventArgs e)
        {
            nameInput.Text = "";
            addressInput.Text = "";
            hoursInput.Value = 0;
            
            nameLabel.Text = "Name: ";
            addressLabel.Text = "Address: ";
            hoursLabel.Text = "Hours Spent Charging: ";
            billLabel.Text = "Final Bill: ";

            headerLabel.Visible = false;
            nameLabel.Visible = false;
            addressLabel.Visible = false;
            hoursLabel.Visible = false;
            billLabel.Visible = false;
        }
    }
}