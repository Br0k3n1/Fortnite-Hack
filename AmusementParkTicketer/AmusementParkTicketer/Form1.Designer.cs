namespace AmusementParkTicketer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            managerButton = new Button();
            checkoutButton = new Button();
            ticketButton = new Button();
            pictureBox1 = new PictureBox();
            ticketPanel = new Panel();
            panel2 = new Panel();
            promoOutputLabel = new Label();
            label4 = new Label();
            promoTextBox = new TextBox();
            platAmount = new NumericUpDown();
            label3 = new Label();
            goldAmount = new NumericUpDown();
            label2 = new Label();
            singleAmount = new NumericUpDown();
            label1 = new Label();
            checkoutPanel = new Panel();
            panel4 = new Panel();
            outputLabel = new Label();
            paymentButton = new Button();
            label9 = new Label();
            paymentTextBox = new TextBox();
            totalLabel = new Label();
            platLabel = new Label();
            goldLabel = new Label();
            singleLabel = new Label();
            managerPanel = new Panel();
            trueManagerPanel = new Panel();
            managerTotalLabel = new Label();
            managerPlatLabel = new Label();
            managerGoldLabel = new Label();
            managerSingleLabel = new Label();
            label7 = new Label();
            fakeManagerPanel = new Panel();
            label5 = new Label();
            passwordButton = new Button();
            label6 = new Label();
            passwordTextBox = new TextBox();
            panel6 = new Panel();
            panel7 = new Panel();
            label12 = new Label();
            label13 = new Label();
            textBox2 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            label14 = new Label();
            numericUpDown2 = new NumericUpDown();
            label15 = new Label();
            numericUpDown3 = new NumericUpDown();
            label16 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ticketPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)platAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goldAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)singleAmount).BeginInit();
            checkoutPanel.SuspendLayout();
            panel4.SuspendLayout();
            managerPanel.SuspendLayout();
            trueManagerPanel.SuspendLayout();
            fakeManagerPanel.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(managerButton);
            panel1.Controls.Add(checkoutButton);
            panel1.Controls.Add(ticketButton);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 817);
            panel1.TabIndex = 0;
            // 
            // managerButton
            // 
            managerButton.BackColor = SystemColors.ActiveBorder;
            managerButton.Font = new Font("Segoe UI Semibold", 32F, FontStyle.Regular, GraphicsUnit.Point);
            managerButton.Location = new Point(-14, 477);
            managerButton.Margin = new Padding(3, 4, 3, 4);
            managerButton.Name = "managerButton";
            managerButton.Size = new Size(325, 132);
            managerButton.TabIndex = 3;
            managerButton.Text = "Manager";
            managerButton.UseVisualStyleBackColor = false;
            managerButton.Click += managerButton_Click;
            // 
            // checkoutButton
            // 
            checkoutButton.BackColor = SystemColors.ActiveBorder;
            checkoutButton.Font = new Font("Segoe UI Semibold", 32F, FontStyle.Regular, GraphicsUnit.Point);
            checkoutButton.Location = new Point(-14, 337);
            checkoutButton.Margin = new Padding(3, 4, 3, 4);
            checkoutButton.Name = "checkoutButton";
            checkoutButton.Size = new Size(325, 132);
            checkoutButton.TabIndex = 2;
            checkoutButton.Text = "Checkout";
            checkoutButton.UseVisualStyleBackColor = false;
            checkoutButton.Click += checkoutButton_Click;
            // 
            // ticketButton
            // 
            ticketButton.BackColor = SystemColors.ActiveBorder;
            ticketButton.Font = new Font("Segoe UI Semibold", 32F, FontStyle.Regular, GraphicsUnit.Point);
            ticketButton.Location = new Point(-14, 197);
            ticketButton.Margin = new Padding(3, 4, 3, 4);
            ticketButton.Name = "ticketButton";
            ticketButton.Size = new Size(325, 132);
            ticketButton.TabIndex = 1;
            ticketButton.Text = "Tickets";
            ticketButton.UseVisualStyleBackColor = false;
            ticketButton.Click += ticketButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -89);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 372);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ticketPanel
            // 
            ticketPanel.Controls.Add(panel2);
            ticketPanel.Location = new Point(317, 33);
            ticketPanel.Margin = new Padding(3, 4, 3, 4);
            ticketPanel.Name = "ticketPanel";
            ticketPanel.Size = new Size(946, 764);
            ticketPanel.TabIndex = 1;
            ticketPanel.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(promoOutputLabel);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(promoTextBox);
            panel2.Controls.Add(platAmount);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(goldAmount);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(singleAmount);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(127, 77);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(679, 621);
            panel2.TabIndex = 0;
            // 
            // promoOutputLabel
            // 
            promoOutputLabel.AutoSize = true;
            promoOutputLabel.Location = new Point(248, 517);
            promoOutputLabel.Name = "promoOutputLabel";
            promoOutputLabel.Size = new Size(0, 20);
            promoOutputLabel.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(214, 411);
            label4.Name = "label4";
            label4.Size = new Size(126, 28);
            label4.TabIndex = 7;
            label4.Text = "Promo Code:";
            // 
            // promoTextBox
            // 
            promoTextBox.Location = new Point(338, 411);
            promoTextBox.Margin = new Padding(3, 4, 3, 4);
            promoTextBox.Name = "promoTextBox";
            promoTextBox.Size = new Size(114, 27);
            promoTextBox.TabIndex = 6;
            promoTextBox.TextChanged += promoTextBox_TextChanged;
            // 
            // platAmount
            // 
            platAmount.Location = new Point(413, 259);
            platAmount.Margin = new Padding(3, 4, 3, 4);
            platAmount.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            platAmount.Name = "platAmount";
            platAmount.Size = new Size(40, 27);
            platAmount.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(217, 255);
            label3.Name = "label3";
            label3.Size = new Size(192, 28);
            label3.TabIndex = 4;
            label3.Text = "$150 - Platinum Pass";
            // 
            // goldAmount
            // 
            goldAmount.Location = new Point(413, 184);
            goldAmount.Margin = new Padding(3, 4, 3, 4);
            goldAmount.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            goldAmount.Name = "goldAmount";
            goldAmount.Size = new Size(40, 27);
            goldAmount.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(248, 180);
            label2.Name = "label2";
            label2.Size = new Size(158, 28);
            label2.TabIndex = 2;
            label2.Text = "$100 - Gold Pass";
            // 
            // singleAmount
            // 
            singleAmount.Location = new Point(413, 105);
            singleAmount.Margin = new Padding(3, 4, 3, 4);
            singleAmount.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            singleAmount.Name = "singleAmount";
            singleAmount.Size = new Size(40, 27);
            singleAmount.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(248, 101);
            label1.Name = "label1";
            label1.Size = new Size(156, 28);
            label1.TabIndex = 0;
            label1.Text = "$50 - Single Day";
            // 
            // checkoutPanel
            // 
            checkoutPanel.Controls.Add(panel4);
            checkoutPanel.Location = new Point(317, 33);
            checkoutPanel.Margin = new Padding(3, 4, 3, 4);
            checkoutPanel.Name = "checkoutPanel";
            checkoutPanel.Size = new Size(899, 764);
            checkoutPanel.TabIndex = 2;
            checkoutPanel.Visible = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveBorder;
            panel4.Controls.Add(outputLabel);
            panel4.Controls.Add(paymentButton);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(paymentTextBox);
            panel4.Controls.Add(totalLabel);
            panel4.Controls.Add(platLabel);
            panel4.Controls.Add(goldLabel);
            panel4.Controls.Add(singleLabel);
            panel4.Location = new Point(127, 77);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(679, 621);
            panel4.TabIndex = 0;
            // 
            // outputLabel
            // 
            outputLabel.Location = new Point(139, 497);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(391, 20);
            outputLabel.TabIndex = 7;
            outputLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // paymentButton
            // 
            paymentButton.Location = new Point(429, 419);
            paymentButton.Margin = new Padding(3, 4, 3, 4);
            paymentButton.Name = "paymentButton";
            paymentButton.Size = new Size(86, 31);
            paymentButton.TabIndex = 6;
            paymentButton.Text = "Enter";
            paymentButton.UseVisualStyleBackColor = true;
            paymentButton.Click += paymentButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(134, 418);
            label9.Name = "label9";
            label9.Size = new Size(167, 28);
            label9.TabIndex = 5;
            label9.Text = "Payment Amount:";
            // 
            // paymentTextBox
            // 
            paymentTextBox.Location = new Point(307, 419);
            paymentTextBox.Margin = new Padding(3, 4, 3, 4);
            paymentTextBox.Name = "paymentTextBox";
            paymentTextBox.Size = new Size(114, 27);
            paymentTextBox.TabIndex = 4;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            totalLabel.Location = new Point(307, 315);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(58, 28);
            totalLabel.TabIndex = 3;
            totalLabel.Text = "Total:";
            // 
            // platLabel
            // 
            platLabel.AutoSize = true;
            platLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            platLabel.Location = new Point(139, 227);
            platLabel.Name = "platLabel";
            platLabel.Size = new Size(425, 28);
            platLabel.TabIndex = 2;
            platLabel.Text = "You Have 0 Platinum Passes Which Comes to $0";
            // 
            // goldLabel
            // 
            goldLabel.AutoSize = true;
            goldLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            goldLabel.Location = new Point(139, 153);
            goldLabel.Name = "goldLabel";
            goldLabel.Size = new Size(391, 28);
            goldLabel.TabIndex = 1;
            goldLabel.Text = "You Have 0 Gold Passes Which Comes to $0";
            // 
            // singleLabel
            // 
            singleLabel.AutoSize = true;
            singleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            singleLabel.Location = new Point(139, 73);
            singleLabel.Name = "singleLabel";
            singleLabel.Size = new Size(441, 28);
            singleLabel.TabIndex = 0;
            singleLabel.Text = "You Have 0 Single Day Passes Which Comes to $0";
            // 
            // managerPanel
            // 
            managerPanel.Controls.Add(trueManagerPanel);
            managerPanel.Controls.Add(fakeManagerPanel);
            managerPanel.Location = new Point(317, 33);
            managerPanel.Margin = new Padding(3, 4, 3, 4);
            managerPanel.Name = "managerPanel";
            managerPanel.Size = new Size(803, 764);
            managerPanel.TabIndex = 4;
            managerPanel.Visible = false;
            // 
            // trueManagerPanel
            // 
            trueManagerPanel.BackColor = SystemColors.ActiveBorder;
            trueManagerPanel.Controls.Add(managerTotalLabel);
            trueManagerPanel.Controls.Add(managerPlatLabel);
            trueManagerPanel.Controls.Add(managerGoldLabel);
            trueManagerPanel.Controls.Add(managerSingleLabel);
            trueManagerPanel.Controls.Add(label7);
            trueManagerPanel.Enabled = false;
            trueManagerPanel.Location = new Point(127, 77);
            trueManagerPanel.Margin = new Padding(3, 4, 3, 4);
            trueManagerPanel.Name = "trueManagerPanel";
            trueManagerPanel.Size = new Size(679, 621);
            trueManagerPanel.TabIndex = 8;
            trueManagerPanel.Visible = false;
            // 
            // managerTotalLabel
            // 
            managerTotalLabel.AutoSize = true;
            managerTotalLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            managerTotalLabel.Location = new Point(248, 391);
            managerTotalLabel.Name = "managerTotalLabel";
            managerTotalLabel.Size = new Size(156, 28);
            managerTotalLabel.TabIndex = 11;
            managerTotalLabel.Text = "Todays Profit: $0";
            // 
            // managerPlatLabel
            // 
            managerPlatLabel.AutoSize = true;
            managerPlatLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            managerPlatLabel.Location = new Point(248, 315);
            managerPlatLabel.Name = "managerPlatLabel";
            managerPlatLabel.Size = new Size(195, 28);
            managerPlatLabel.TabIndex = 10;
            managerPlatLabel.Text = "Platinum Pass: 0 Sold";
            // 
            // managerGoldLabel
            // 
            managerGoldLabel.AutoSize = true;
            managerGoldLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            managerGoldLabel.Location = new Point(248, 241);
            managerGoldLabel.Name = "managerGoldLabel";
            managerGoldLabel.Size = new Size(161, 28);
            managerGoldLabel.TabIndex = 9;
            managerGoldLabel.Text = "Gold Pass: 0 Sold";
            // 
            // managerSingleLabel
            // 
            managerSingleLabel.AutoSize = true;
            managerSingleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            managerSingleLabel.Location = new Point(248, 165);
            managerSingleLabel.Name = "managerSingleLabel";
            managerSingleLabel.Size = new Size(170, 28);
            managerSingleLabel.TabIndex = 8;
            managerSingleLabel.Text = "Single Day: 0 Sold";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(199, 497);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 7;
            // 
            // fakeManagerPanel
            // 
            fakeManagerPanel.BackColor = SystemColors.ActiveBorder;
            fakeManagerPanel.Controls.Add(label5);
            fakeManagerPanel.Controls.Add(passwordButton);
            fakeManagerPanel.Controls.Add(label6);
            fakeManagerPanel.Controls.Add(passwordTextBox);
            fakeManagerPanel.Location = new Point(127, 77);
            fakeManagerPanel.Margin = new Padding(3, 4, 3, 4);
            fakeManagerPanel.Name = "fakeManagerPanel";
            fakeManagerPanel.Size = new Size(679, 621);
            fakeManagerPanel.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(199, 497);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 7;
            // 
            // passwordButton
            // 
            passwordButton.Location = new Point(427, 269);
            passwordButton.Margin = new Padding(3, 4, 3, 4);
            passwordButton.Name = "passwordButton";
            passwordButton.Size = new Size(86, 31);
            passwordButton.TabIndex = 6;
            passwordButton.Text = "Enter";
            passwordButton.UseVisualStyleBackColor = true;
            passwordButton.Click += passwordButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(205, 267);
            label6.Name = "label6";
            label6.Size = new Size(102, 28);
            label6.TabIndex = 5;
            label6.Text = "Password: ";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(306, 269);
            passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(114, 27);
            passwordTextBox.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(317, 33);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(233, 764);
            panel6.TabIndex = 3;
            panel6.Visible = false;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveBorder;
            panel7.Controls.Add(label12);
            panel7.Controls.Add(label13);
            panel7.Controls.Add(textBox2);
            panel7.Controls.Add(numericUpDown1);
            panel7.Controls.Add(label14);
            panel7.Controls.Add(numericUpDown2);
            panel7.Controls.Add(label15);
            panel7.Controls.Add(numericUpDown3);
            panel7.Controls.Add(label16);
            panel7.Location = new Point(127, 77);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(679, 621);
            panel7.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(248, 517);
            label12.Name = "label12";
            label12.Size = new Size(0, 20);
            label12.TabIndex = 8;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(214, 411);
            label13.Name = "label13";
            label13.Size = new Size(126, 28);
            label13.TabIndex = 7;
            label13.Text = "Promo Code:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(338, 411);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(413, 259);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(40, 27);
            numericUpDown1.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(227, 255);
            label14.Name = "label14";
            label14.Size = new Size(192, 28);
            label14.TabIndex = 4;
            label14.Text = "$150 - Platinum Pass";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(413, 184);
            numericUpDown2.Margin = new Padding(3, 4, 3, 4);
            numericUpDown2.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(40, 27);
            numericUpDown2.TabIndex = 3;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(248, 180);
            label15.Name = "label15";
            label15.Size = new Size(158, 28);
            label15.TabIndex = 2;
            label15.Text = "$100 - Gold Pass";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(413, 105);
            numericUpDown3.Margin = new Padding(3, 4, 3, 4);
            numericUpDown3.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(40, 27);
            numericUpDown3.TabIndex = 1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(248, 101);
            label16.Name = "label16";
            label16.Size = new Size(156, 28);
            label16.TabIndex = 0;
            label16.Text = "$50 - Single Day";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 813);
            Controls.Add(managerPanel);
            Controls.Add(panel6);
            Controls.Add(checkoutPanel);
            Controls.Add(ticketPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Amusement Park Ticketer";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ticketPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)platAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)goldAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)singleAmount).EndInit();
            checkoutPanel.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            managerPanel.ResumeLayout(false);
            trueManagerPanel.ResumeLayout(false);
            trueManagerPanel.PerformLayout();
            fakeManagerPanel.ResumeLayout(false);
            fakeManagerPanel.PerformLayout();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button ticketButton;
        private Button managerButton;
        private Button checkoutButton;
        private Panel ticketPanel;
        private Panel panel2;
        private NumericUpDown platAmount;
        private Label label3;
        private NumericUpDown goldAmount;
        private Label label2;
        private NumericUpDown singleAmount;
        private Label label1;
        private Label label4;
        private TextBox promoTextBox;
        private Panel checkoutPanel;
        private Panel panel4;
        private TextBox paymentTextBox;
        private Label label9;
        private Label totalLabel;
        private Label platLabel;
        private Label goldLabel;
        private Label singleLabel;
        private Button paymentButton;
        private Label promoOutputLabel;
        private Label outputLabel;
        private Panel managerPanel;
        private Panel fakeManagerPanel;
        private Label label5;
        private Button passwordButton;
        private Label label6;
        private TextBox passwordTextBox;
        private Panel panel6;
        private Panel panel7;
        private Label label12;
        private Label label13;
        private TextBox textBox2;
        private NumericUpDown numericUpDown1;
        private Label label14;
        private NumericUpDown numericUpDown2;
        private Label label15;
        private NumericUpDown numericUpDown3;
        private Label label16;
        private Panel trueManagerPanel;
        private Label label7;
        private Label managerTotalLabel;
        private Label managerPlatLabel;
        private Label managerGoldLabel;
        private Label managerSingleLabel;
    }
}