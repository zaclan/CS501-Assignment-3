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
            lbTryNumber = new Label();
            lbEnterAnswer = new Label();
            btnSubmitAnswer = new Button();
            btnContinue = new Button();
            tbAnswerInput = new TextBox();
            lbSubmissionStatus = new Label();
            lbInvalidInput = new Label();
            lbScoreText = new Label();
            lbScoreValue = new Label();
            btnRetry = new Button();
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
            lbNumberOne.Size = new Size(20, 195);
            lbNumberOne.TabIndex = 0;
            lbNumberOne.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbNumberTwo
            // 
            lbNumberTwo.AutoSize = true;
            lbNumberTwo.BackColor = SystemColors.ActiveBorder;
            lbNumberTwo.Font = new Font("Segoe UI", 49.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNumberTwo.Location = new Point(591, 382);
            lbNumberTwo.Name = "lbNumberTwo";
            lbNumberTwo.Padding = new Padding(10);
            lbNumberTwo.Size = new Size(20, 195);
            lbNumberTwo.TabIndex = 1;
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
            lbOperator.Size = new Size(20, 109);
            lbOperator.TabIndex = 2;
            lbOperator.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbProblemNumber
            // 
            lbProblemNumber.AutoSize = true;
            lbProblemNumber.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbProblemNumber.Location = new Point(60, 55);
            lbProblemNumber.Name = "lbProblemNumber";
            lbProblemNumber.Size = new Size(0, 51);
            lbProblemNumber.TabIndex = 3;
            // 
            // lbTryNumber
            // 
            lbTryNumber.AutoSize = true;
            lbTryNumber.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbTryNumber.Location = new Point(60, 137);
            lbTryNumber.Name = "lbTryNumber";
            lbTryNumber.Size = new Size(0, 51);
            lbTryNumber.TabIndex = 4;
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
            btnSubmitAnswer.Click += btnSubmitAnswer_Click;
            // 
            // btnContinue
            // 
            btnContinue.BackColor = SystemColors.ActiveCaption;
            btnContinue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContinue.Location = new Point(490, 931);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(150, 46);
            btnContinue.TabIndex = 9;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Visible = false;
            btnContinue.Click += btnContinue_Click;
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
            lbSubmissionStatus.Location = new Point(213, 847);
            lbSubmissionStatus.Name = "lbSubmissionStatus";
            lbSubmissionStatus.Size = new Size(0, 51);
            lbSubmissionStatus.TabIndex = 8;
            // 
            // lbInvalidInput
            // 
            lbInvalidInput.AutoSize = true;
            lbInvalidInput.ForeColor = Color.Crimson;
            lbInvalidInput.Location = new Point(462, 674);
            lbInvalidInput.Name = "lbInvalidInput";
            lbInvalidInput.Size = new Size(0, 32);
            lbInvalidInput.TabIndex = 10;
            // 
            // lbScoreText
            // 
            lbScoreText.AutoSize = true;
            lbScoreText.Font = new Font("Segoe UI", 70.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbScoreText.Location = new Point(213, 100);
            lbScoreText.Name = "lbScoreText";
            lbScoreText.Size = new Size(688, 248);
            lbScoreText.TabIndex = 11;
            lbScoreText.Text = "SCORE";
            lbScoreText.Visible = false;
            // 
            // lbScoreValue
            // 
            lbScoreValue.AutoSize = true;
            lbScoreValue.Font = new Font("Segoe UI", 70.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbScoreValue.Location = new Point(326, 440);
            lbScoreValue.Name = "lbScoreValue";
            lbScoreValue.Size = new Size(482, 248);
            lbScoreValue.TabIndex = 12;
            lbScoreValue.Text = "90%";
            lbScoreValue.Visible = false;
            // 
            // btnRetry
            // 
            btnRetry.BackColor = SystemColors.ActiveCaption;
            btnRetry.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetry.Location = new Point(490, 816);
            btnRetry.Name = "btnRetry";
            btnRetry.Size = new Size(150, 46);
            btnRetry.TabIndex = 13;
            btnRetry.Text = "Retry";
            btnRetry.UseVisualStyleBackColor = false;
            btnRetry.Visible = false;
            btnRetry.Click += btnRetry_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 1027);
            Controls.Add(btnRetry);
            Controls.Add(lbScoreValue);
            Controls.Add(lbScoreText);
            Controls.Add(lbInvalidInput);
            Controls.Add(btnContinue);
            Controls.Add(lbSubmissionStatus);
            Controls.Add(btnSubmitAnswer);
            Controls.Add(tbAnswerInput);
            Controls.Add(lbEnterAnswer);
            Controls.Add(lbTryNumber);
            Controls.Add(lbProblemNumber);
            Controls.Add(lbOperator);
            Controls.Add(lbNumberTwo);
            Controls.Add(lbNumberOne);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNumberOne;
        private Label lbNumberTwo;
        private Label lbOperator;
        private Label lbProblemNumber;
        private Label lbTryNumber;
        private Label lbEnterAnswer;
        private Button btnSubmitAnswer;
        private Button btnContinue;
        private TextBox tbAnswerInput;
        private Label lbSubmissionStatus;
        private Label lbInvalidInput;
        private Label lbScoreText;
        private Label lbScoreValue;
        private Button btnRetry;
    }
}
