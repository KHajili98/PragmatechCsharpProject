
namespace CalculatorForAmountPayable
{
    partial class CalculatorForAmountPayable
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.PriceInput = new System.Windows.Forms.TextBox();
            this.studentCard = new System.Windows.Forms.CheckBox();
            this.pensionable = new System.Windows.Forms.CheckBox();
            this.productListBox = new System.Windows.Forms.ListBox();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CashLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(42, 34);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(42, 79);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(41, 20);
            this.priceLabel.TabIndex = 1;
            this.priceLabel.Text = "Price";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(128, 34);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(125, 27);
            this.NameInput.TabIndex = 2;
            // 
            // PriceInput
            // 
            this.PriceInput.Location = new System.Drawing.Point(128, 79);
            this.PriceInput.Name = "PriceInput";
            this.PriceInput.Size = new System.Drawing.Size(125, 27);
            this.PriceInput.TabIndex = 3;
            // 
            // studentCard
            // 
            this.studentCard.AutoSize = true;
            this.studentCard.Location = new System.Drawing.Point(42, 266);
            this.studentCard.Name = "studentCard";
            this.studentCard.Size = new System.Drawing.Size(119, 24);
            this.studentCard.TabIndex = 4;
            this.studentCard.Text = "Student-Card";
            this.studentCard.UseVisualStyleBackColor = true;
            // 
            // pensionable
            // 
            this.pensionable.AutoSize = true;
            this.pensionable.Location = new System.Drawing.Point(42, 297);
            this.pensionable.Name = "pensionable";
            this.pensionable.Size = new System.Drawing.Size(110, 24);
            this.pensionable.TabIndex = 5;
            this.pensionable.Text = "Pensionable";
            this.pensionable.UseVisualStyleBackColor = true;
            // 
            // productListBox
            // 
            this.productListBox.FormattingEnabled = true;
            this.productListBox.ItemHeight = 20;
            this.productListBox.Location = new System.Drawing.Point(338, 34);
            this.productListBox.Name = "productListBox";
            this.productListBox.Size = new System.Drawing.Size(284, 284);
            this.productListBox.TabIndex = 6;
            // 
            // addProductBtn
            // 
            this.addProductBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addProductBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addProductBtn.Location = new System.Drawing.Point(42, 149);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(194, 29);
            this.addProductBtn.TabIndex = 7;
            this.addProductBtn.Text = "ADD PRODUCT";
            this.addProductBtn.UseVisualStyleBackColor = false;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.SystemColors.Info;
            this.CalculateButton.Location = new System.Drawing.Point(42, 336);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(194, 29);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate Receipt";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearList
            // 
            this.ClearList.BackColor = System.Drawing.Color.Red;
            this.ClearList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClearList.Location = new System.Drawing.Point(42, 371);
            this.ClearList.Name = "ClearList";
            this.ClearList.Size = new System.Drawing.Size(194, 29);
            this.ClearList.TabIndex = 9;
            this.ClearList.Text = "Clear List";
            this.ClearList.UseVisualStyleBackColor = false;
            this.ClearList.Click += new System.EventHandler(this.ClearList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Amount : ";
            // 
            // CashLabel
            // 
            this.CashLabel.AutoSize = true;
            this.CashLabel.Location = new System.Drawing.Point(428, 345);
            this.CashLabel.Name = "CashLabel";
            this.CashLabel.Size = new System.Drawing.Size(28, 20);
            this.CashLabel.TabIndex = 11;
            this.CashLabel.Text = "0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "( 20% endirim )";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "( 30% endirim )";
            // 
            // CalculatorForAmountPayable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 456);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CashLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearList);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.productListBox);
            this.Controls.Add(this.pensionable);
            this.Controls.Add(this.studentCard);
            this.Controls.Add(this.PriceInput);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CalculatorForAmountPayable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculatorForAmountPayable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox PriceInput;
        private System.Windows.Forms.CheckBox studentCard;
        private System.Windows.Forms.CheckBox pensionable;
        private System.Windows.Forms.ListBox productListBox;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CashLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

