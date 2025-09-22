namespace distanceConverter
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
            From = new GroupBox();
            convertBox1 = new ListBox();
            groupBox2 = new GroupBox();
            convertBox2 = new ListBox();
            inputTxt = new TextBox();
            outputTxt = new TextBox();
            convertBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            From.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // From
            // 
            From.Controls.Add(convertBox1);
            From.Location = new Point(195, 191);
            From.Name = "From";
            From.Size = new Size(200, 100);
            From.TabIndex = 0;
            From.TabStop = false;
            From.Text = "From";
            // 
            // convertBox1
            // 
            convertBox1.FormattingEnabled = true;
            convertBox1.ItemHeight = 15;
            convertBox1.Items.AddRange(new object[] { "Inches", "Feet", "Yards" });
            convertBox1.Location = new Point(39, 22);
            convertBox1.Name = "convertBox1";
            convertBox1.Size = new Size(125, 64);
            convertBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(convertBox2);
            groupBox2.Location = new Point(411, 191);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "To";
            // 
            // convertBox2
            // 
            convertBox2.FormattingEnabled = true;
            convertBox2.ItemHeight = 15;
            convertBox2.Items.AddRange(new object[] { "Inches", "Feet", "Yards" });
            convertBox2.Location = new Point(32, 22);
            convertBox2.Name = "convertBox2";
            convertBox2.Size = new Size(129, 64);
            convertBox2.TabIndex = 0;
            // 
            // inputTxt
            // 
            inputTxt.Location = new Point(311, 162);
            inputTxt.Name = "inputTxt";
            inputTxt.Size = new Size(187, 23);
            inputTxt.TabIndex = 2;
            // 
            // outputTxt
            // 
            outputTxt.Location = new Point(342, 315);
            outputTxt.Name = "outputTxt";
            outputTxt.Size = new Size(131, 23);
            outputTxt.TabIndex = 3;
            // 
            // convertBtn
            // 
            convertBtn.Location = new Point(368, 344);
            convertBtn.Name = "convertBtn";
            convertBtn.Size = new Size(75, 23);
            convertBtn.TabIndex = 4;
            convertBtn.Text = "Convert!";
            convertBtn.UseVisualStyleBackColor = true;
            convertBtn.Click += convertBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 144);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 5;
            label1.Text = "Distance to be converted";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(342, 297);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 6;
            label2.Text = "Converted Number";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(convertBtn);
            Controls.Add(outputTxt);
            Controls.Add(inputTxt);
            Controls.Add(groupBox2);
            Controls.Add(From);
            Name = "Form1";
            Text = "Form1";
            From.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox From;
        private ListBox convertBox1;
        private GroupBox groupBox2;
        private ListBox convertBox2;
        private TextBox inputTxt;
        private TextBox outputTxt;
        private Button convertBtn;
        private Label label1;
        private Label label2;
    }
}
