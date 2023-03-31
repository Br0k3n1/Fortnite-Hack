namespace Feet2Meters
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
            calcButton = new Button();
            outputLabel = new Label();
            clearButton = new Button();
            inputBox = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)inputBox).BeginInit();
            SuspendLayout();
            // 
            // calcButton
            // 
            calcButton.Location = new Point(12, 16);
            calcButton.Margin = new Padding(3, 4, 3, 4);
            calcButton.Name = "calcButton";
            calcButton.Size = new Size(103, 31);
            calcButton.TabIndex = 1;
            calcButton.Text = "Calculate";
            calcButton.UseVisualStyleBackColor = true;
            calcButton.Click += calcButton_Click;
            // 
            // outputLabel
            // 
            outputLabel.Location = new Point(12, 51);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(295, 101);
            outputLabel.TabIndex = 2;
            outputLabel.Text = "Enter Amount of Feet";
            outputLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(115, 156);
            clearButton.Margin = new Padding(3, 4, 3, 4);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(86, 31);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // inputBox
            // 
            inputBox.Location = new Point(133, 20);
            inputBox.Margin = new Padding(3, 4, 3, 4);
            inputBox.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(174, 27);
            inputBox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 203);
            Controls.Add(inputBox);
            Controls.Add(clearButton);
            Controls.Add(outputLabel);
            Controls.Add(calcButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Feet2Meters";
            ((System.ComponentModel.ISupportInitialize)inputBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button calcButton;
        private Label outputLabel;
        private Button clearButton;
        private NumericUpDown inputBox;
    }
}