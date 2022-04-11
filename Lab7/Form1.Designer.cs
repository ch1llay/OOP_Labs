namespace Lab7
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
            this.addProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.productPrice = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(13, 90);
            this.addProduct.Margin = new System.Windows.Forms.Padding(4);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(149, 57);
            this.addProduct.TabIndex = 0;
            this.addProduct.Text = "Добавить продукт";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цена товара";
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(13, 50);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(149, 29);
            this.productName.TabIndex = 3;
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(209, 51);
            this.productPrice.Margin = new System.Windows.Forms.Padding(4);
            this.productPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(152, 29);
            this.productPrice.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 90);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Удалить продукт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 155);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addProduct);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "#7 Чапаев Илья вариант 11 Делегаты и события";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addProduct;
        private Label label1;
        private Label label2;
        private TextBox productName;
        private NumericUpDown productPrice;
        private Button button1;
    }
}