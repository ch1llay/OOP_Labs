using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        CompareForm compareForm1;

        Dictionary<string, OnlineStore> onlineStores = new Dictionary<string, OnlineStore>();
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (Regex.IsMatch(titleTextBox.Text, @"[а-яa-z]+\d*", RegexOptions.IgnoreCase) )
            {
                if (!onlineStores.Keys.Contains(titleTextBox.Text))
                {
                    comboBox1.Items.Add(titleTextBox.Text);
                    onlineStores.Add(titleTextBox.Text,
                        new OnlineStore(
                            addressTextBox.Text, titleTextBox.Text, (int)soldProductsNumericUpDown.Value,
                            (int)amountKindNumericUpDown.Value, profitNumericUpDown.Value,
                            (int)onlineNumericUpDown.Value, (int)regNumericUpDown.Value));
                }
            }
            else
            {
                
                MessageBox.Show("Ошибка в названии");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (onlineStores.ContainsKey(comboBox1.Text))
            {
                onlineStores[comboBox1.Text].currentProfit = profitNumericUpDown.Value;
                onlineStores[comboBox1.Text].adress = addressTextBox.Text;
                onlineStores[comboBox1.Text].amountKindProducts = (int)amountKindNumericUpDown.Value;
                onlineStores[comboBox1.Text].amountSoldProducts = (int)soldProductsNumericUpDown.Value;
                onlineStores[comboBox1.Text].amountOlineUsers = (int)onlineNumericUpDown.Value;
                onlineStores[comboBox1.Text].amountRegUsers = (int)regNumericUpDown.Value;
                richTextBox1.Text = $"Количество созданных объектов: {OnlineStore.objectCount}\n" + onlineStores[comboBox1.Text].ToString();
            }
            else
            {
                MessageBox.Show("Ошибка, такого элемента нет");
            }



        }

        private void amountKindNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text
                = $"Количество созданных объектов: {OnlineStore.objectCount}\n"
                + onlineStores[comboBox1.Text].ToString();
        }

        // удаление
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (onlineStores.ContainsKey(comboBox1.Text))
            {
                onlineStores.Remove(comboBox1.Text);
                comboBox1.Items.Remove(comboBox1.Text);
                richTextBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Ошибка, такого элемента нет");
            }
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            compareForm1 = new CompareForm();
            compareForm1.Show();
        }
    }
}