namespace CalculateFactorial
{
    partial class form_calculateFactorial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nup_selectNumber = new System.Windows.Forms.NumericUpDown();
            this.label_selectNumber = new System.Windows.Forms.Label();
            this.label_factorial = new System.Windows.Forms.Label();
            this.text_result = new System.Windows.Forms.TextBox();
            this.button_calculate = new System.Windows.Forms.Button();
            this.label_instructions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nup_selectNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // nup_selectNumber
            // 
            this.nup_selectNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nup_selectNumber.Location = new System.Drawing.Point(211, 25);
            this.nup_selectNumber.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nup_selectNumber.Name = "nup_selectNumber";
            this.nup_selectNumber.Size = new System.Drawing.Size(315, 36);
            this.nup_selectNumber.TabIndex = 0;
            // 
            // label_selectNumber
            // 
            this.label_selectNumber.AutoSize = true;
            this.label_selectNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_selectNumber.Location = new System.Drawing.Point(10, 27);
            this.label_selectNumber.Name = "label_selectNumber";
            this.label_selectNumber.Size = new System.Drawing.Size(188, 29);
            this.label_selectNumber.TabIndex = 1;
            this.label_selectNumber.Text = "Select Number:";
            // 
            // label_factorial
            // 
            this.label_factorial.AutoSize = true;
            this.label_factorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_factorial.Location = new System.Drawing.Point(81, 141);
            this.label_factorial.Name = "label_factorial";
            this.label_factorial.Size = new System.Drawing.Size(117, 29);
            this.label_factorial.TabIndex = 3;
            this.label_factorial.Text = "Factorial:";
            // 
            // text_result
            // 
            this.text_result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.text_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.text_result.Location = new System.Drawing.Point(211, 138);
            this.text_result.Name = "text_result";
            this.text_result.ReadOnly = true;
            this.text_result.Size = new System.Drawing.Size(315, 36);
            this.text_result.TabIndex = 4;
            // 
            // button_calculate
            // 
            this.button_calculate.Location = new System.Drawing.Point(211, 218);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(160, 44);
            this.button_calculate.TabIndex = 5;
            this.button_calculate.Text = "Calculate!";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // label_instructions
            // 
            this.label_instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic);
            this.label_instructions.Location = new System.Drawing.Point(12, 64);
            this.label_instructions.Name = "label_instructions";
            this.label_instructions.Size = new System.Drawing.Size(186, 77);
            this.label_instructions.TabIndex = 6;
            this.label_instructions.Text = "No negatives or fractional values.\r\nThis calculator only takes up to 20.\r\n";
            // 
            // form_calculateFactorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 308);
            this.Controls.Add(this.label_instructions);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.text_result);
            this.Controls.Add(this.label_factorial);
            this.Controls.Add(this.label_selectNumber);
            this.Controls.Add(this.nup_selectNumber);
            this.Name = "form_calculateFactorial";
            this.Text = "Calculate Factorial";
            ((System.ComponentModel.ISupportInitialize)(this.nup_selectNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nup_selectNumber;
        private System.Windows.Forms.Label label_selectNumber;
        private System.Windows.Forms.Label label_factorial;
        private System.Windows.Forms.TextBox text_result;
        private System.Windows.Forms.Button button_calculate;
        private System.Windows.Forms.Label label_instructions;
    }
}

