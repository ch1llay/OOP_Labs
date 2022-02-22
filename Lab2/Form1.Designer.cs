
namespace Lab2
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
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.amountKindNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.regNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.profitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.onlineNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.soldProductsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.amountKindNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldProductsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 409);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(369, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "Применить изменения для выбранного объекта";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(748, 80);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(433, 319);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(10, 80);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(170, 34);
            this.titleTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 84);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество\rпроданных \nтоваров";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Текущая прибыль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 260);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 56);
            this.label4.TabIndex = 13;
            this.label4.Text = "количество\r\nзарегистрированных пользователей";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(560, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 56);
            this.label5.TabIndex = 11;
            this.label5.Text = "Количество \r\nвидов товаров";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(280, 80);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(170, 34);
            this.addressTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 141);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 56);
            this.label6.TabIndex = 9;
            this.label6.Text = "текущий\r\nонлайн пользователей";
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(748, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 36);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(766, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "Объекты";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 409);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(369, 74);
            this.button2.TabIndex = 17;
            this.button2.Text = "Добавить объект";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 28);
            this.label8.TabIndex = 19;
            this.label8.Text = "Адрес";
            // 
            // amountKindNumericUpDown
            // 
            this.amountKindNumericUpDown.Location = new System.Drawing.Point(560, 93);
            this.amountKindNumericUpDown.Name = "amountKindNumericUpDown";
            this.amountKindNumericUpDown.Size = new System.Drawing.Size(150, 34);
            this.amountKindNumericUpDown.TabIndex = 20;
            this.amountKindNumericUpDown.ValueChanged += new System.EventHandler(this.amountKindNumericUpDown_ValueChanged);
            // 
            // regNumericUpDown
            // 
            this.regNumericUpDown.Location = new System.Drawing.Point(280, 321);
            this.regNumericUpDown.Name = "regNumericUpDown";
            this.regNumericUpDown.Size = new System.Drawing.Size(150, 34);
            this.regNumericUpDown.TabIndex = 21;
            // 
            // profitNumericUpDown
            // 
            this.profitNumericUpDown.Location = new System.Drawing.Point(16, 321);
            this.profitNumericUpDown.Name = "profitNumericUpDown";
            this.profitNumericUpDown.Size = new System.Drawing.Size(150, 34);
            this.profitNumericUpDown.TabIndex = 22;
            // 
            // onlineNumericUpDown
            // 
            this.onlineNumericUpDown.Location = new System.Drawing.Point(286, 216);
            this.onlineNumericUpDown.Name = "onlineNumericUpDown";
            this.onlineNumericUpDown.Size = new System.Drawing.Size(150, 34);
            this.onlineNumericUpDown.TabIndex = 21;
            // 
            // soldProductsNumericUpDown
            // 
            this.soldProductsNumericUpDown.Location = new System.Drawing.Point(10, 216);
            this.soldProductsNumericUpDown.Name = "soldProductsNumericUpDown";
            this.soldProductsNumericUpDown.Size = new System.Drawing.Size(150, 34);
            this.soldProductsNumericUpDown.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 496);
            this.Controls.Add(this.soldProductsNumericUpDown);
            this.Controls.Add(this.profitNumericUpDown);
            this.Controls.Add(this.onlineNumericUpDown);
            this.Controls.Add(this.regNumericUpDown);
            this.Controls.Add(this.amountKindNumericUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Лабораторная работа № 2  Статические члены класса. Вариант 11 Интернет магазин Ча" +
    "паев Илья";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amountKindNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldProductsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown amountKindNumericUpDown;
        private System.Windows.Forms.NumericUpDown regNumericUpDown;
        private System.Windows.Forms.NumericUpDown profitNumericUpDown;
        private System.Windows.Forms.NumericUpDown onlineNumericUpDown;
        private System.Windows.Forms.NumericUpDown soldProductsNumericUpDown;
    }
}

