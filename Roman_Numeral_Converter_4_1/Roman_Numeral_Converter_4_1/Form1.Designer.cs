namespace Roman_Numeral_Converter_4_1
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
            romOutputTxt = new TextBox();
            numInputTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // romOutputTxt
            // 
            romOutputTxt.Location = new Point(449, 119);
            romOutputTxt.Name = "romOutputTxt";
            romOutputTxt.Size = new Size(100, 23);
            romOutputTxt.TabIndex = 0;
            // 
            // numInputTxt
            // 
            numInputTxt.Location = new Point(206, 119);
            numInputTxt.Name = "numInputTxt";
            numInputTxt.Size = new Size(100, 23);
            numInputTxt.TabIndex = 1;
            numInputTxt.TextChanged += numInputTxt_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 101);
            label1.Name = "label1";
            label1.Size = new Size(285, 15);
            label1.TabIndex = 2;
            label1.Text = "Enter a number to be converted to a roman numerial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(386, 145);
            label2.Name = "label2";
            label2.Size = new Size(215, 15);
            label2.TabIndex = 3;
            label2.Text = "Converted number in Roman Numerals";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numInputTxt);
            Controls.Add(romOutputTxt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox romOutputTxt;
        private TextBox numInputTxt;
        private Label label1;
        private Label label2;
    }
}
