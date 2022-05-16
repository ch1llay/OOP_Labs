namespace Lab6
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sizeOfArray = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.setupButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.getProductButton = new System.Windows.Forms.Button();
            this.indexOfArrayOnUsing = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.usingButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeOfArray)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indexOfArrayOnUsing)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(539, 321);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.sizeOfArray);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.setupButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(531, 288);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Setup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // sizeOfArray
            // 
            this.sizeOfArray.Location = new System.Drawing.Point(189, 69);
            this.sizeOfArray.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sizeOfArray.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sizeOfArray.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.sizeOfArray.Name = "sizeOfArray";
            this.sizeOfArray.Size = new System.Drawing.Size(160, 27);
            this.sizeOfArray.TabIndex = 2;
            this.sizeOfArray.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Задайте максимальное количество товаров на сайте";
            // 
            // setupButton
            // 
            this.setupButton.Location = new System.Drawing.Point(189, 123);
            this.setupButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.setupButton.Name = "setupButton";
            this.setupButton.Size = new System.Drawing.Size(160, 31);
            this.setupButton.TabIndex = 0;
            this.setupButton.Text = "Задать";
            this.setupButton.UseVisualStyleBackColor = true;
            this.setupButton.Click += new System.EventHandler(this.setupButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.getProductButton);
            this.tabPage2.Controls.Add(this.indexOfArrayOnUsing);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.usingButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(531, 288);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Using";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // getProductButton
            // 
            this.getProductButton.Location = new System.Drawing.Point(72, 169);
            this.getProductButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.getProductButton.Name = "getProductButton";
            this.getProductButton.Size = new System.Drawing.Size(160, 31);
            this.getProductButton.TabIndex = 7;
            this.getProductButton.Text = "Получить";
            this.getProductButton.UseVisualStyleBackColor = true;
            this.getProductButton.Click += new System.EventHandler(this.getProductButton_Click);
            // 
            // indexOfArrayOnUsing
            // 
            this.indexOfArrayOnUsing.Location = new System.Drawing.Point(147, 116);
            this.indexOfArrayOnUsing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.indexOfArrayOnUsing.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.indexOfArrayOnUsing.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.indexOfArrayOnUsing.Name = "indexOfArrayOnUsing";
            this.indexOfArrayOnUsing.Size = new System.Drawing.Size(242, 27);
            this.indexOfArrayOnUsing.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 60);
            this.label2.TabIndex = 4;
            this.label2.Text = "добавить продукт \r\nсо случайными данными \r\nпо индексу в массив";
            // 
            // usingButton
            // 
            this.usingButton.Location = new System.Drawing.Point(328, 169);
            this.usingButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usingButton.Name = "usingButton";
            this.usingButton.Size = new System.Drawing.Size(160, 31);
            this.usingButton.TabIndex = 3;
            this.usingButton.Text = "Задать";
            this.usingButton.UseVisualStyleBackColor = true;
            this.usingButton.Click += new System.EventHandler(this.usingPutButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 360);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "#6 Чапаев Илья Обработка ислючительных ситуаций";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeOfArray)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indexOfArrayOnUsing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private NumericUpDown sizeOfArray;
        private Label label1;
        private Button setupButton;
        private TabPage tabPage2;
        private Label label2;
        private NumericUpDown indexOfArrayOnUsing;
        private Button usingButton;
        private Button getProductButton;
    }
}