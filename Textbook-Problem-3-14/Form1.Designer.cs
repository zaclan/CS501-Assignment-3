namespace Problem_3_14
{
    partial class Form1
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
            this.Tickets_Box = new System.Windows.Forms.GroupBox();
            this.Tickets_A = new System.Windows.Forms.TextBox();
            this.Tickets_B = new System.Windows.Forms.TextBox();
            this.Tickets_C = new System.Windows.Forms.TextBox();
            this.Description_1 = new System.Windows.Forms.Label();
            this.A_1 = new System.Windows.Forms.Label();
            this.B_1 = new System.Windows.Forms.Label();
            this.C_1 = new System.Windows.Forms.Label();
            this.Revenue_Box = new System.Windows.Forms.GroupBox();
            this.C_2 = new System.Windows.Forms.Label();
            this.B_2 = new System.Windows.Forms.Label();
            this.A_2 = new System.Windows.Forms.Label();
            this.Revenue_C = new System.Windows.Forms.TextBox();
            this.Revenue_B = new System.Windows.Forms.TextBox();
            this.Revenue_A = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Revenue_Total = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.Tickets_Box.SuspendLayout();
            this.Revenue_Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tickets_Box
            // 
            this.Tickets_Box.Controls.Add(this.C_1);
            this.Tickets_Box.Controls.Add(this.B_1);
            this.Tickets_Box.Controls.Add(this.A_1);
            this.Tickets_Box.Controls.Add(this.Description_1);
            this.Tickets_Box.Controls.Add(this.Tickets_C);
            this.Tickets_Box.Controls.Add(this.Tickets_B);
            this.Tickets_Box.Controls.Add(this.Tickets_A);
            this.Tickets_Box.Location = new System.Drawing.Point(147, 106);
            this.Tickets_Box.Name = "Tickets_Box";
            this.Tickets_Box.Size = new System.Drawing.Size(200, 136);
            this.Tickets_Box.TabIndex = 0;
            this.Tickets_Box.TabStop = false;
            this.Tickets_Box.Text = "Tickets Sold";
            // 
            // Tickets_A
            // 
            this.Tickets_A.Location = new System.Drawing.Point(85, 58);
            this.Tickets_A.Name = "Tickets_A";
            this.Tickets_A.Size = new System.Drawing.Size(100, 20);
            this.Tickets_A.TabIndex = 0;
            // 
            // Tickets_B
            // 
            this.Tickets_B.Location = new System.Drawing.Point(85, 84);
            this.Tickets_B.Name = "Tickets_B";
            this.Tickets_B.Size = new System.Drawing.Size(100, 20);
            this.Tickets_B.TabIndex = 1;
            // 
            // Tickets_C
            // 
            this.Tickets_C.Location = new System.Drawing.Point(85, 110);
            this.Tickets_C.Name = "Tickets_C";
            this.Tickets_C.Size = new System.Drawing.Size(100, 20);
            this.Tickets_C.TabIndex = 2;
            // 
            // Description_1
            // 
            this.Description_1.Location = new System.Drawing.Point(6, 16);
            this.Description_1.Name = "Description_1";
            this.Description_1.Size = new System.Drawing.Size(179, 39);
            this.Description_1.TabIndex = 3;
            this.Description_1.Text = "Enter the number of tickets sold for each class of seats.";
            // 
            // A_1
            // 
            this.A_1.AutoSize = true;
            this.A_1.Location = new System.Drawing.Point(9, 59);
            this.A_1.Name = "A_1";
            this.A_1.Size = new System.Drawing.Size(42, 13);
            this.A_1.TabIndex = 4;
            this.A_1.Text = "Class A";
            // 
            // B_1
            // 
            this.B_1.AutoSize = true;
            this.B_1.Location = new System.Drawing.Point(9, 84);
            this.B_1.Name = "B_1";
            this.B_1.Size = new System.Drawing.Size(42, 13);
            this.B_1.TabIndex = 5;
            this.B_1.Text = "Class B";
            // 
            // C_1
            // 
            this.C_1.AutoSize = true;
            this.C_1.Location = new System.Drawing.Point(9, 113);
            this.C_1.Name = "C_1";
            this.C_1.Size = new System.Drawing.Size(42, 13);
            this.C_1.TabIndex = 6;
            this.C_1.Text = "Class C";
            // 
            // Revenue_Box
            // 
            this.Revenue_Box.Controls.Add(this.Revenue_Total);
            this.Revenue_Box.Controls.Add(this.label4);
            this.Revenue_Box.Controls.Add(this.C_2);
            this.Revenue_Box.Controls.Add(this.B_2);
            this.Revenue_Box.Controls.Add(this.A_2);
            this.Revenue_Box.Controls.Add(this.Revenue_C);
            this.Revenue_Box.Controls.Add(this.Revenue_B);
            this.Revenue_Box.Controls.Add(this.Revenue_A);
            this.Revenue_Box.Location = new System.Drawing.Point(385, 106);
            this.Revenue_Box.Name = "Revenue_Box";
            this.Revenue_Box.Size = new System.Drawing.Size(200, 136);
            this.Revenue_Box.TabIndex = 7;
            this.Revenue_Box.TabStop = false;
            this.Revenue_Box.Text = "Revenue Generated";
            // 
            // C_2
            // 
            this.C_2.AutoSize = true;
            this.C_2.Location = new System.Drawing.Point(9, 74);
            this.C_2.Name = "C_2";
            this.C_2.Size = new System.Drawing.Size(42, 13);
            this.C_2.TabIndex = 6;
            this.C_2.Text = "Class C";
            // 
            // B_2
            // 
            this.B_2.AutoSize = true;
            this.B_2.Location = new System.Drawing.Point(9, 45);
            this.B_2.Name = "B_2";
            this.B_2.Size = new System.Drawing.Size(42, 13);
            this.B_2.TabIndex = 5;
            this.B_2.Text = "Class B";
            // 
            // A_2
            // 
            this.A_2.AutoSize = true;
            this.A_2.Location = new System.Drawing.Point(9, 20);
            this.A_2.Name = "A_2";
            this.A_2.Size = new System.Drawing.Size(42, 13);
            this.A_2.TabIndex = 4;
            this.A_2.Text = "Class A";
            // 
            // Revenue_C
            // 
            this.Revenue_C.Location = new System.Drawing.Point(85, 71);
            this.Revenue_C.Name = "Revenue_C";
            this.Revenue_C.Size = new System.Drawing.Size(100, 20);
            this.Revenue_C.TabIndex = 2;
            // 
            // Revenue_B
            // 
            this.Revenue_B.Location = new System.Drawing.Point(85, 45);
            this.Revenue_B.Name = "Revenue_B";
            this.Revenue_B.Size = new System.Drawing.Size(100, 20);
            this.Revenue_B.TabIndex = 1;
            // 
            // Revenue_A
            // 
            this.Revenue_A.Location = new System.Drawing.Point(85, 19);
            this.Revenue_A.Name = "Revenue_A";
            this.Revenue_A.Size = new System.Drawing.Size(100, 20);
            this.Revenue_A.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total";
            // 
            // Revenue_Total
            // 
            this.Revenue_Total.Location = new System.Drawing.Point(85, 97);
            this.Revenue_Total.Name = "Revenue_Total";
            this.Revenue_Total.Size = new System.Drawing.Size(100, 20);
            this.Revenue_Total.TabIndex = 8;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(227, 260);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(90, 53);
            this.Calculate.TabIndex = 8;
            this.Calculate.Text = "Calculate Revenue";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(323, 260);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(87, 53);
            this.Clear.TabIndex = 9;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(416, 260);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(95, 53);
            this.exit.TabIndex = 10;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Revenue_Box);
            this.Controls.Add(this.Tickets_Box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Tickets_Box.ResumeLayout(false);
            this.Tickets_Box.PerformLayout();
            this.Revenue_Box.ResumeLayout(false);
            this.Revenue_Box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Tickets_Box;
        private System.Windows.Forms.Label Description_1;
        private System.Windows.Forms.TextBox Tickets_C;
        private System.Windows.Forms.TextBox Tickets_B;
        private System.Windows.Forms.TextBox Tickets_A;
        private System.Windows.Forms.Label A_1;
        private System.Windows.Forms.Label C_1;
        private System.Windows.Forms.Label B_1;
        private System.Windows.Forms.GroupBox Revenue_Box;
        private System.Windows.Forms.Label C_2;
        private System.Windows.Forms.Label B_2;
        private System.Windows.Forms.Label A_2;
        private System.Windows.Forms.TextBox Revenue_C;
        private System.Windows.Forms.TextBox Revenue_B;
        private System.Windows.Forms.TextBox Revenue_A;
        private System.Windows.Forms.TextBox Revenue_Total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button exit;
    }
}

