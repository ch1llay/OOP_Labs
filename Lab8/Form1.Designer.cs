
namespace Lab8
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
            this.editOnlineStoreButton = new System.Windows.Forms.Button();
            this.onlineStoreRichBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addOnlineStoreButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.regNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.soldProductsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.deleteOnlineStoreButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.productsComboBox = new System.Windows.Forms.ComboBox();
            this.productName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.editProductButton = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.findOnlineStoreByAmountProductsButton = new System.Windows.Forms.Button();
            this.findOnlineStoreByMaxAmountProductsButton = new System.Windows.Forms.Button();
            this.findOnlineStoreByMinAmountProductsButton = new System.Windows.Forms.Button();
            this.amountProductsForSearch = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.saveToFileButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.onlineStoresComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.amountProductForSearch = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.regNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldProductsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountProductsForSearch)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountProductForSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // editOnlineStoreButton
            // 
            this.editOnlineStoreButton.Location = new System.Drawing.Point(4, 318);
            this.editOnlineStoreButton.Margin = new System.Windows.Forms.Padding(4);
            this.editOnlineStoreButton.Name = "editOnlineStoreButton";
            this.editOnlineStoreButton.Size = new System.Drawing.Size(356, 51);
            this.editOnlineStoreButton.TabIndex = 0;
            this.editOnlineStoreButton.Text = "Редактировать интернет магазин";
            this.editOnlineStoreButton.UseVisualStyleBackColor = true;
            this.editOnlineStoreButton.Click += new System.EventHandler(this.editOnlineStoreButton_Click);
            // 
            // onlineStoreRichBox
            // 
            this.onlineStoreRichBox.Location = new System.Drawing.Point(16, 44);
            this.onlineStoreRichBox.Margin = new System.Windows.Forms.Padding(4);
            this.onlineStoreRichBox.Name = "onlineStoreRichBox";
            this.onlineStoreRichBox.Size = new System.Drawing.Size(527, 238);
            this.onlineStoreRichBox.TabIndex = 1;
            this.onlineStoreRichBox.Text = "";
            this.onlineStoreRichBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(186, 7);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(170, 29);
            this.titleTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 63);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество\rпроданных \nтоваров";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 63);
            this.label4.TabIndex = 13;
            this.label4.Text = "количество\r\nзарегистрированных\r\nпользователей";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(186, 60);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(170, 29);
            this.addressTextBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Информация";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // addOnlineStoreButton
            // 
            this.addOnlineStoreButton.Location = new System.Drawing.Point(7, 253);
            this.addOnlineStoreButton.Margin = new System.Windows.Forms.Padding(4);
            this.addOnlineStoreButton.Name = "addOnlineStoreButton";
            this.addOnlineStoreButton.Size = new System.Drawing.Size(349, 51);
            this.addOnlineStoreButton.TabIndex = 17;
            this.addOnlineStoreButton.Text = "Добавить интернет магазин";
            this.addOnlineStoreButton.UseVisualStyleBackColor = true;
            this.addOnlineStoreButton.Click += new System.EventHandler(this.addOnlineStoreButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Адрес";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // regNumericUpDown
            // 
            this.regNumericUpDown.Location = new System.Drawing.Point(190, 192);
            this.regNumericUpDown.Name = "regNumericUpDown";
            this.regNumericUpDown.Size = new System.Drawing.Size(170, 29);
            this.regNumericUpDown.TabIndex = 21;
            // 
            // soldProductsNumericUpDown
            // 
            this.soldProductsNumericUpDown.Location = new System.Drawing.Point(186, 115);
            this.soldProductsNumericUpDown.Name = "soldProductsNumericUpDown";
            this.soldProductsNumericUpDown.Size = new System.Drawing.Size(170, 29);
            this.soldProductsNumericUpDown.TabIndex = 23;
            // 
            // deleteOnlineStoreButton
            // 
            this.deleteOnlineStoreButton.Location = new System.Drawing.Point(4, 392);
            this.deleteOnlineStoreButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteOnlineStoreButton.Name = "deleteOnlineStoreButton";
            this.deleteOnlineStoreButton.Size = new System.Drawing.Size(349, 49);
            this.deleteOnlineStoreButton.TabIndex = 24;
            this.deleteOnlineStoreButton.Text = "Удалить интернет магазин";
            this.deleteOnlineStoreButton.UseVisualStyleBackColor = true;
            this.deleteOnlineStoreButton.Click += new System.EventHandler(this.deleteOnlineStoreButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "Товары";
            // 
            // productsComboBox
            // 
            this.productsComboBox.Location = new System.Drawing.Point(436, 24);
            this.productsComboBox.Name = "productsComboBox";
            this.productsComboBox.Size = new System.Drawing.Size(292, 29);
            this.productsComboBox.TabIndex = 26;
            this.productsComboBox.SelectedIndexChanged += new System.EventHandler(this.productsCombobox_SelectedIndexChanged);
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(538, 102);
            this.productName.Margin = new System.Windows.Forms.Padding(4);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(170, 29);
            this.productName.TabIndex = 29;
            this.productName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(436, 102);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 42);
            this.label9.TabIndex = 28;
            this.label9.Text = "Название\r\n товара";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(545, 166);
            this.productPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.productPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(170, 29);
            this.productPrice.TabIndex = 31;
            this.productPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(436, 174);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 21);
            this.label10.TabIndex = 30;
            this.label10.Text = "Цена товара";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(429, 250);
            this.addProductButton.Margin = new System.Windows.Forms.Padding(4);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(314, 54);
            this.addProductButton.TabIndex = 32;
            this.addProductButton.Text = "Добавить товар";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // editProductButton
            // 
            this.editProductButton.Location = new System.Drawing.Point(429, 312);
            this.editProductButton.Margin = new System.Windows.Forms.Padding(4);
            this.editProductButton.Name = "editProductButton";
            this.editProductButton.Size = new System.Drawing.Size(314, 57);
            this.editProductButton.TabIndex = 33;
            this.editProductButton.Text = "Редактировать товар";
            this.editProductButton.UseVisualStyleBackColor = true;
            this.editProductButton.Click += new System.EventHandler(this.editProductButton_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(429, 392);
            this.deleteProductButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(307, 49);
            this.deleteProductButton.TabIndex = 34;
            this.deleteProductButton.Text = "Удалить товар";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // findOnlineStoreByAmountProductsButton
            // 
            this.findOnlineStoreByAmountProductsButton.Location = new System.Drawing.Point(7, 290);
            this.findOnlineStoreByAmountProductsButton.Margin = new System.Windows.Forms.Padding(4);
            this.findOnlineStoreByAmountProductsButton.Name = "findOnlineStoreByAmountProductsButton";
            this.findOnlineStoreByAmountProductsButton.Size = new System.Drawing.Size(188, 100);
            this.findOnlineStoreByAmountProductsButton.TabIndex = 35;
            this.findOnlineStoreByAmountProductsButton.Text = "Найти интернет магазины по количеству товаров в них";
            this.findOnlineStoreByAmountProductsButton.UseVisualStyleBackColor = true;
            this.findOnlineStoreByAmountProductsButton.Click += new System.EventHandler(this.findOnlineStoreByAmountProductsButton_Click);
            // 
            // findOnlineStoreByMaxAmountProductsButton
            // 
            this.findOnlineStoreByMaxAmountProductsButton.Location = new System.Drawing.Point(399, 291);
            this.findOnlineStoreByMaxAmountProductsButton.Margin = new System.Windows.Forms.Padding(4);
            this.findOnlineStoreByMaxAmountProductsButton.Name = "findOnlineStoreByMaxAmountProductsButton";
            this.findOnlineStoreByMaxAmountProductsButton.Size = new System.Drawing.Size(168, 99);
            this.findOnlineStoreByMaxAmountProductsButton.TabIndex = 36;
            this.findOnlineStoreByMaxAmountProductsButton.Text = "Найти интернет\r\nмагазин с наибольшим\r\nчислом товаров";
            this.findOnlineStoreByMaxAmountProductsButton.UseVisualStyleBackColor = true;
            this.findOnlineStoreByMaxAmountProductsButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // findOnlineStoreByMinAmountProductsButton
            // 
            this.findOnlineStoreByMinAmountProductsButton.Location = new System.Drawing.Point(203, 290);
            this.findOnlineStoreByMinAmountProductsButton.Margin = new System.Windows.Forms.Padding(4);
            this.findOnlineStoreByMinAmountProductsButton.Name = "findOnlineStoreByMinAmountProductsButton";
            this.findOnlineStoreByMinAmountProductsButton.Size = new System.Drawing.Size(188, 100);
            this.findOnlineStoreByMinAmountProductsButton.TabIndex = 37;
            this.findOnlineStoreByMinAmountProductsButton.Text = "Найти интернет\r\nмагазин с наименьшим числом товаров";
            this.findOnlineStoreByMinAmountProductsButton.UseVisualStyleBackColor = true;
            this.findOnlineStoreByMinAmountProductsButton.Click += new System.EventHandler(this.findOnlineStoreByMinAmountProductsButton_Click);
            // 
            // amountProductsForSearch
            // 
            this.amountProductsForSearch.Location = new System.Drawing.Point(523, 320);
            this.amountProductsForSearch.Name = "amountProductsForSearch";
            this.amountProductsForSearch.Size = new System.Drawing.Size(170, 29);
            this.amountProductsForSearch.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(362, 320);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 42);
            this.label11.TabIndex = 40;
            this.label11.Text = "Введите количество\r\nтоваров для поиска";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1001, 482);
            this.tabControl1.TabIndex = 41;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.saveToFileButton);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.onlineStoresComboBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.titleTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.addressTextBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.deleteOnlineStoreButton);
            this.tabPage1.Controls.Add(this.deleteProductButton);
            this.tabPage1.Controls.Add(this.addOnlineStoreButton);
            this.tabPage1.Controls.Add(this.regNumericUpDown);
            this.tabPage1.Controls.Add(this.editProductButton);
            this.tabPage1.Controls.Add(this.soldProductsNumericUpDown);
            this.tabPage1.Controls.Add(this.addProductButton);
            this.tabPage1.Controls.Add(this.editOnlineStoreButton);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.productPrice);
            this.tabPage1.Controls.Add(this.productsComboBox);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.productName);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(993, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавление";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // saveToFileButton
            // 
            this.saveToFileButton.Location = new System.Drawing.Point(796, 304);
            this.saveToFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveToFileButton.Name = "saveToFileButton";
            this.saveToFileButton.Size = new System.Drawing.Size(152, 78);
            this.saveToFileButton.TabIndex = 37;
            this.saveToFileButton.Text = "Сохранить в файл";
            this.saveToFileButton.UseVisualStyleBackColor = true;
            this.saveToFileButton.Click += new System.EventHandler(this.saveToFileButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(782, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Интернет магазины";
            // 
            // onlineStoresComboBox
            // 
            this.onlineStoresComboBox.Location = new System.Drawing.Point(768, 27);
            this.onlineStoresComboBox.Name = "onlineStoresComboBox";
            this.onlineStoresComboBox.Size = new System.Drawing.Size(202, 29);
            this.onlineStoresComboBox.TabIndex = 35;
            this.onlineStoresComboBox.SelectedIndexChanged += new System.EventHandler(this.onlineStoresComboBox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.amountProductForSearch);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.onlineStoreRichBox);
            this.tabPage2.Controls.Add(this.findOnlineStoreByMaxAmountProductsButton);
            this.tabPage2.Controls.Add(this.findOnlineStoreByMinAmountProductsButton);
            this.tabPage2.Controls.Add(this.findOnlineStoreByAmountProductsButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(993, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Поиск";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(586, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 21);
            this.label6.TabIndex = 39;
            this.label6.Text = "Количество товаров для поиска";
            // 
            // amountProductForSearch
            // 
            this.amountProductForSearch.Location = new System.Drawing.Point(586, 169);
            this.amountProductForSearch.Name = "amountProductForSearch";
            this.amountProductForSearch.Size = new System.Drawing.Size(201, 29);
            this.amountProductForSearch.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 493);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.amountProductsForSearch);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Лабораторная работа № 8 LINQ Вариант 11 Интернет магазин Чапаев Илья";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.regNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldProductsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountProductsForSearch)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountProductForSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editOnlineStoreButton;
        private System.Windows.Forms.RichTextBox onlineStoreRichBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addOnlineStoreButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown regNumericUpDown;
        private System.Windows.Forms.NumericUpDown soldProductsNumericUpDown;
        private Button deleteOnlineStoreButton;
        private Label label5;
        private ComboBox productsComboBox;
        private TextBox productName;
        private Label label9;
        private NumericUpDown productPrice;
        private Label label10;
        private Button addProductButton;
        private Button editProductButton;
        private Button deleteProductButton;
        private Button findOnlineStoreByAmountProductsButton;
        private Button findOnlineStoreByMaxAmountProductsButton;
        private Button findOnlineStoreByMinAmountProductsButton;
        private NumericUpDown amountProductsForSearch;
        private Label label11;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label3;
        private ComboBox onlineStoresComboBox;
        private NumericUpDown amountProductForSearch;
        private Label label6;
        private Button saveToFileButton;
    }
}

