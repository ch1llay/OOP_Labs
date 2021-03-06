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

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


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
    }
}