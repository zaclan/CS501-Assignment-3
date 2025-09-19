namespace FruitStand
{
    partial class form_fruitStand
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
            this.picture_banana = new System.Windows.Forms.PictureBox();
            this.text_bananaPrice = new System.Windows.Forms.TextBox();
            this.picture_apple = new System.Windows.Forms.PictureBox();
            this.text_applePrice = new System.Windows.Forms.TextBox();
            this.picture_orange = new System.Windows.Forms.PictureBox();
            this.text_orangePrice = new System.Windows.Forms.TextBox();
            this.picture_pear = new System.Windows.Forms.PictureBox();
            this.text_pearPrice = new System.Windows.Forms.TextBox();
            this.text_totalTitle = new System.Windows.Forms.TextBox();
            this.text_totalAmount = new System.Windows.Forms.TextBox();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_banana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_apple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_orange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_pear)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_banana
            // 
            this.picture_banana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_banana.Image = global::FruitStand.Properties.Resources.Banana;
            this.picture_banana.Location = new System.Drawing.Point(34, 34);
            this.picture_banana.Name = "picture_banana";
            this.picture_banana.Size = new System.Drawing.Size(178, 149);
            this.picture_banana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_banana.TabIndex = 0;
            this.picture_banana.TabStop = false;
            this.picture_banana.Click += new System.EventHandler(this.picture_banana_Click);
            // 
            // text_bananaPrice
            // 
            this.text_bananaPrice.BackColor = System.Drawing.SystemColors.WindowText;
            this.text_bananaPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.text_bananaPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.text_bananaPrice.Location = new System.Drawing.Point(34, 181);
            this.text_bananaPrice.Name = "text_bananaPrice";
            this.text_bananaPrice.ReadOnly = true;
            this.text_bananaPrice.Size = new System.Drawing.Size(178, 36);
            this.text_bananaPrice.TabIndex = 1;
            this.text_bananaPrice.Text = "$0.65/lb";
            this.text_bananaPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picture_apple
            // 
            this.picture_apple.Image = global::FruitStand.Properties.Resources.Apple;
            this.picture_apple.Location = new System.Drawing.Point(255, 34);
            this.picture_apple.Name = "picture_apple";
            this.picture_apple.Size = new System.Drawing.Size(178, 149);
            this.picture_apple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_apple.TabIndex = 2;
            this.picture_apple.TabStop = false;
            this.picture_apple.Click += new System.EventHandler(this.picture_apple_Click);
            // 
            // text_applePrice
            // 
            this.text_applePrice.BackColor = System.Drawing.SystemColors.WindowText;
            this.text_applePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.text_applePrice.ForeColor = System.Drawing.SystemColors.Window;
            this.text_applePrice.Location = new System.Drawing.Point(255, 181);
            this.text_applePrice.Name = "text_applePrice";
            this.text_applePrice.ReadOnly = true;
            this.text_applePrice.Size = new System.Drawing.Size(178, 36);
            this.text_applePrice.TabIndex = 3;
            this.text_applePrice.Text = "$1.35/lb";
            this.text_applePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picture_orange
            // 
            this.picture_orange.Image = global::FruitStand.Properties.Resources.Orange;
            this.picture_orange.Location = new System.Drawing.Point(34, 250);
            this.picture_orange.Name = "picture_orange";
            this.picture_orange.Size = new System.Drawing.Size(178, 149);
            this.picture_orange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_orange.TabIndex = 4;
            this.picture_orange.TabStop = false;
            this.picture_orange.Click += new System.EventHandler(this.picture_orange_Click);
            // 
            // text_orangePrice
            // 
            this.text_orangePrice.BackColor = System.Drawing.SystemColors.WindowText;
            this.text_orangePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.text_orangePrice.ForeColor = System.Drawing.SystemColors.Window;
            this.text_orangePrice.Location = new System.Drawing.Point(34, 397);
            this.text_orangePrice.Name = "text_orangePrice";
            this.text_orangePrice.ReadOnly = true;
            this.text_orangePrice.Size = new System.Drawing.Size(178, 36);
            this.text_orangePrice.TabIndex = 5;
            this.text_orangePrice.Text = "$1.60/lb";
            this.text_orangePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picture_pear
            // 
            this.picture_pear.Image = global::FruitStand.Properties.Resources.Pear;
            this.picture_pear.Location = new System.Drawing.Point(255, 250);
            this.picture_pear.Name = "picture_pear";
            this.picture_pear.Size = new System.Drawing.Size(178, 149);
            this.picture_pear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_pear.TabIndex = 6;
            this.picture_pear.TabStop = false;
            this.picture_pear.Click += new System.EventHandler(this.picture_pear_Click);
            // 
            // text_pearPrice
            // 
            this.text_pearPrice.BackColor = System.Drawing.SystemColors.WindowText;
            this.text_pearPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.text_pearPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.text_pearPrice.Location = new System.Drawing.Point(255, 397);
            this.text_pearPrice.Name = "text_pearPrice";
            this.text_pearPrice.ReadOnly = true;
            this.text_pearPrice.Size = new System.Drawing.Size(178, 36);
            this.text_pearPrice.TabIndex = 7;
            this.text_pearPrice.Text = "$1.20/lb";
            this.text_pearPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_totalTitle
            // 
            this.text_totalTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.text_totalTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text_totalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.text_totalTitle.Location = new System.Drawing.Point(563, 34);
            this.text_totalTitle.Name = "text_totalTitle";
            this.text_totalTitle.ReadOnly = true;
            this.text_totalTitle.Size = new System.Drawing.Size(100, 29);
            this.text_totalTitle.TabIndex = 8;
            this.text_totalTitle.Text = "Total:";
            this.text_totalTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // text_totalAmount
            // 
            this.text_totalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.text_totalAmount.Location = new System.Drawing.Point(517, 69);
            this.text_totalAmount.Name = "text_totalAmount";
            this.text_totalAmount.ReadOnly = true;
            this.text_totalAmount.Size = new System.Drawing.Size(189, 41);
            this.text_totalAmount.TabIndex = 9;
            this.text_totalAmount.Text = "$0.00";
            this.text_totalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(531, 355);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(158, 37);
            this.button_reset.TabIndex = 10;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(531, 397);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(158, 35);
            this.button_exit.TabIndex = 11;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // form_fruitStand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 500);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.text_totalAmount);
            this.Controls.Add(this.text_totalTitle);
            this.Controls.Add(this.picture_pear);
            this.Controls.Add(this.text_pearPrice);
            this.Controls.Add(this.picture_orange);
            this.Controls.Add(this.text_orangePrice);
            this.Controls.Add(this.picture_apple);
            this.Controls.Add(this.text_applePrice);
            this.Controls.Add(this.picture_banana);
            this.Controls.Add(this.text_bananaPrice);
            this.Name = "form_fruitStand";
            this.Text = "Fruit Stand";
            ((System.ComponentModel.ISupportInitialize)(this.picture_banana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_apple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_orange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_pear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_banana;
        private System.Windows.Forms.TextBox text_bananaPrice;
        private System.Windows.Forms.PictureBox picture_apple;
        private System.Windows.Forms.TextBox text_applePrice;
        private System.Windows.Forms.PictureBox picture_orange;
        private System.Windows.Forms.TextBox text_orangePrice;
        private System.Windows.Forms.PictureBox picture_pear;
        private System.Windows.Forms.TextBox text_pearPrice;
        private System.Windows.Forms.TextBox text_totalTitle;
        private System.Windows.Forms.TextBox text_totalAmount;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_exit;
    }
}

