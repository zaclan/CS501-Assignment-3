namespace Second_Grade_Flash_Card_App
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
            lbNumberOne = new Label();
            lbNumberTwo = new Label();
            lbOperator = new Label();
            lbProblemNumber = new Label();
            label1 = new Label();
            lbEnterAnswer = new Label();
            btnSubmitAnswer = new Button();
            button1 = new Button();
            tbAnswerInput = new TextBox();
            lbSubmissionStatus = new Label();
            SuspendLayout();
            // 
            // lbNumberOne
            // 
            lbNumberOne.AutoSize = true;
            lbNumberOne.BackColor = SystemColors.ActiveBorder;
            lbNumberOne.Font = new Font("Segoe UI", 49.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNumberOne.Location = new Point(591, 130);
            lbNumberOne.Name = "lbNumberOne";
            lbNumberOne.Padding = new Padding(10);
            lbNumberOne.Size = new Size(171, 195);
            lbNumberOne.TabIndex = 0;
            lbNumberOne.Text = "9";
            lbNumberOne.TextAlign = ContentAlignment.MiddleCenter;
            lbNumberOne.Click += lbNumberOne_Click;
            // 
            // lbNumberTwo
            // 
            lbNumberTwo.AutoSize = true;
            lbNumberTwo.BackColor = SystemColors.ActiveBorder;
            lbNumberTwo.Font = new Font("Segoe UI", 49.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNumberTwo.Location = new Point(591, 382);
            lbNumberTwo.Name = "lbNumberTwo";
            lbNumberTwo.Padding = new Padding(10);
            lbNumberTwo.Size = new Size(248, 195);
            lbNumberTwo.TabIndex = 1;
            lbNumberTwo.Text = "12";
            lbNumberTwo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbOperator
            // 
            lbOperator.AutoSize = true;
            lbOperator.BackColor = SystemColors.ActiveBorder;
            lbOperator.Font = new Font("Segoe UI", 25.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbOperator.Location = new Point(309, 468);
            lbOperator.Name = "lbOperator";
            lbOperator.Padding = new Padding(10);
            lbOperator.Size = new Size(105, 109);
            lbOperator.TabIndex = 2;
            lbOperator.Text = "+";
            lbOperator.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbProblemNumber
            // 
            lbProblemNumber.AutoSize = true;
            lbProblemNumber.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbProblemNumber.Location = new Point(60, 55);
            lbProblemNumber.Name = "lbProblemNumber";
            lbProblemNumber.Size = new Size(229, 51);
            lbProblemNumber.TabIndex = 3;
            lbProblemNumber.Text = "Problem #1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(60, 137);
            label1.Name = "label1";
            label1.Size = new Size(133, 51);
            label1.TabIndex = 4;
            label1.Text = "Try #1";
            // 
            // lbEnterAnswer
            // 
            lbEnterAnswer.AutoSize = true;
            lbEnterAnswer.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbEnterAnswer.Location = new Point(84, 717);
            lbEnterAnswer.Name = "lbEnterAnswer";
            lbEnterAnswer.Size = new Size(355, 51);
            lbEnterAnswer.TabIndex = 5;
            lbEnterAnswer.Text = "Enter your answer:";
            lbEnterAnswer.Click += label2_Click;
            // 
            // btnSubmitAnswer
            // 
            btnSubmitAnswer.BackColor = SystemColors.ActiveCaption;
            btnSubmitAnswer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitAnswer.Location = new Point(847, 724);
            btnSubmitAnswer.Name = "btnSubmitAnswer";
            btnSubmitAnswer.Size = new Size(150, 46);
            btnSubmitAnswer.TabIndex = 7;
            btnSubmitAnswer.Text = "Submit";
            btnSubmitAnswer.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(490, 931);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 9;
            button1.Text = "Continue";
            button1.UseVisualStyleBackColor = false;
            // 
            // tbAnswerInput
            // 
            tbAnswerInput.Location = new Point(462, 729);
            tbAnswerInput.Name = "tbAnswerInput";
            tbAnswerInput.Size = new Size(346, 39);
            tbAnswerInput.TabIndex = 6;
            // 
            // lbSubmissionStatus
            // 
            lbSubmissionStatus.AutoSize = true;
            lbSubmissionStatus.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbSubmissionStatus.ForeColor = SystemColors.MenuHighlight;
            lbSubmissionStatus.Location = new Point(487, 837);
            lbSubmissionStatus.Name = "lbSubmissionStatus";
            lbSubmissionStatus.Size = new Size(153, 51);
            lbSubmissionStatus.TabIndex = 8;
            lbSubmissionStatus.Text = "Correct";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 1027);
            Controls.Add(button1);
            Controls.Add(lbSubmissionStatus);
            Controls.Add(btnSubmitAnswer);
            Controls.Add(tbAnswerInput);
            Controls.Add(lbEnterAnswer);
            Controls.Add(label1);
            Controls.Add(lbProblemNumber);
            Controls.Add(lbOperator);
            Controls.Add(lbNumberTwo);
            Controls.Add(lbNumberOne);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNumberOne;
        private Label lbNumberTwo;
        private Label lbOperator;
        private Label lbProblemNumber;
        private Label label1;
        private Label lbEnterAnswer;
        private Button btnSubmitAnswer;
        private Button button1;
        private TextBox tbAnswerInput;
        private Label lbSubmissionStatus;
    }
}
