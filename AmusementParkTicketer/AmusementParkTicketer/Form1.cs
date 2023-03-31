namespace AmusementParkTicketer
{
    public partial class Form1 : Form
    {
        bool promoCodeActivated = false;
        double total;

        int singleDayTotal = 0;
        int goldPassTotal = 0;
        int platPassTotal = 0;
        double totalProfit = 0;
        public Form1()
        {
            InitializeComponent();
            activateButton(ticketButton);

            ticketPanel.Visible = true;
            checkoutPanel.Visible = false;

            ticketPanel.Enabled = true;
            checkoutPanel.Enabled = false;
        }

        public void activateButton(Button button)
        {
            ticketButton.BackColor = SystemColors.ActiveBorder;
            checkoutButton.BackColor = SystemColors.ActiveBorder;
            managerButton.BackColor = SystemColors.ActiveBorder;
            button.BackColor = SystemColors.ButtonShadow;
        }

        private void ticketButton_Click(object sender, EventArgs e)
        {
            activateButton(ticketButton);

            fakeManagerPanel.Visible = true;
            trueManagerPanel.Visible = false;

            fakeManagerPanel.Enabled = true;
            trueManagerPanel.Enabled = false;
            passwordTextBox.Text = "";

            ticketPanel.Visible = true;
            checkoutPanel.Visible = false;
            managerPanel.Visible = false;

            ticketPanel.Enabled = true;
            checkoutPanel.Enabled = false;
            managerPanel.Enabled = false;

            outputLabel.Text = "";
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            activateButton(checkoutButton);

            fakeManagerPanel.Visible = true;
            trueManagerPanel.Visible = false;

            fakeManagerPanel.Enabled = true;
            trueManagerPanel.Enabled = false;
            passwordTextBox.Text = "";

            checkoutPanel.Visible = true;
            ticketPanel.Visible = false;
            managerPanel.Visible = false;

            checkoutPanel.Enabled = true;
            ticketPanel.Enabled = false;
            managerPanel.Enabled = false;

            singleLabel.Text = "You Have " + singleAmount.Value + " Single Day Passes Which Comes to $" + (singleAmount.Value * 50);
            goldLabel.Text = "You Have " + goldAmount.Value + " Gold Passes Which Comes to $" + (goldAmount.Value * 100);
            platLabel.Text = "You Have " + platAmount.Value + " Platinum Passes Which Comes to $" + (platAmount.Value * 150);

            if (promoCodeActivated)
            {
                int totalBefMath = ((int)singleAmount.Value * 50) + ((int)goldAmount.Value * 100) + ((int)platAmount.Value * 150);
                total = totalBefMath - (totalBefMath * 0.10);
                total = Math.Round((total + (total * 0.06626)) + 15, 2);
                totalLabel.Text = "Total: $" + total.ToString();
            }
            else
            {
                int totalBefMath = ((int)singleAmount.Value * 50) + ((int)goldAmount.Value * 100) + ((int)platAmount.Value * 150);
                total = Math.Round((totalBefMath + (totalBefMath * 0.06626)) + 15, 2);
                totalLabel.Text = "Total: $" + total.ToString();
            }
        }

        private void managerButton_Click(object sender, EventArgs e)
        {
            activateButton(managerButton);

            fakeManagerPanel.Visible = true;
            trueManagerPanel.Visible = false;

            fakeManagerPanel.Enabled = true;
            trueManagerPanel.Enabled = false;
            passwordTextBox.Text = "";

            managerPanel.Visible = true;
            ticketPanel.Visible = false;
            checkoutPanel.Visible = false;

            managerPanel.Enabled = true;
            ticketPanel.Enabled = false;
            checkoutPanel.Enabled = false;

            outputLabel.Text = "";
        }

        private void promoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (promoTextBox.Text == "2023Discount")
            {
                promoOutputLabel.Text = "Promo Code is Activated";
                promoCodeActivated = true;
            }
            else
            {
                promoOutputLabel.Text = "";
                promoCodeActivated = false;
            }
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            double payment;
            if (double.TryParse(paymentTextBox.Text, out payment))
            {
                if (payment - total >= 0)
                {
                    singleDayTotal = singleDayTotal + (int)singleAmount.Value;
                    goldPassTotal = goldPassTotal + (int)goldAmount.Value;
                    platPassTotal = platPassTotal + (int)platAmount.Value;
                    totalProfit = totalProfit + total;

                    outputLabel.Text = "Your Change is $" + Math.Round(payment - total, 2);

                    paymentTextBox.Text = "";
                    singleAmount.Value = 0;
                    goldAmount.Value = 0;
                    platAmount.Value = 0;

                    singleLabel.Text = "You Have " + singleAmount.Value + " Single Day Passes Which Comes to $" + (singleAmount.Value * 50);
                    goldLabel.Text = "You Have " + goldAmount.Value + " Gold Passes Which Comes to $" + (goldAmount.Value * 100);
                    platLabel.Text = "You Have " + platAmount.Value + " Platinum Passes Which Comes to $" + (platAmount.Value * 150);

                    promoOutputLabel.Text = "";
                    totalLabel.Text = "Total: $15";
                }
                else
                {
                    outputLabel.Text = "ERROR: The Payment You Put In Is Not Valid";
                }

            }
            else
            {
                outputLabel.Text = "ERROR: The Payment You Put In Is Not Valid";
            }
        }

        private void passwordButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "7777")
            {
                fakeManagerPanel.Visible = false;
                trueManagerPanel.Visible = true;

                fakeManagerPanel.Enabled = false;
                trueManagerPanel.Enabled = true;

                managerSingleLabel.Text = "Single Day: " + singleDayTotal + " Sold";
                managerGoldLabel.Text = "Gold Pass: " + goldPassTotal + " Sold";
                managerPlatLabel.Text = "Platinum Pass: " + platPassTotal + " Sold";
                managerTotalLabel.Text = "Todays Profit: $" + totalProfit;
            }
        }
    }
}