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

namespace Lab8
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
            onlineStoresComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            productsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (Regex.IsMatch(titleTextBox.Text, @"[а-яa-z]+\d*", RegexOptions.IgnoreCase))
            {
                if (!onlineStores.Keys.Contains(titleTextBox.Text))
                {
                    onlineStoresComboBox.Items.Add(titleTextBox.Text);
                    onlineStores.Add(titleTextBox.Text,
                        new
                        OnlineStore(
                            addressTextBox.Text, titleTextBox.Text, (int)soldProductsNumericUpDown.Value, (int)regNumericUpDown.Value)
                        );
                }
            }
            else
            {

                MessageBox.Show("Ошибка в названии");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (onlineStores.ContainsKey(onlineStoresComboBox.Text))
            {
                onlineStores[onlineStoresComboBox.Text].Address = addressTextBox.Text;
                onlineStores[onlineStoresComboBox.Text].AmountSoldProducts = (int)soldProductsNumericUpDown.Value;
                onlineStores[onlineStoresComboBox.Text].AmountRegUsers = (int)regNumericUpDown.Value;
                richTextBox1.Text = onlineStores[onlineStoresComboBox.Text].ToString();
            }
            else
            {
                MessageBox.Show("Ошибка, такого элемента нет");
            }



        }

        private void amountKindNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }


        // удаление
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (onlineStores.ContainsKey(onlineStoresComboBox.Text))
            {
                onlineStores.Remove(onlineStoresComboBox.Text);
                onlineStoresComboBox.Items.Remove(onlineStoresComboBox.Text);
                richTextBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Ошибка, такого элемента нет");
            }
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void productsCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("");
           var products = onlineStores[onlineStoresComboBox.Text].Products;
           var product = products.First(x => x.Name == productsComboBox.Text);
           productName.Text = product.Name;
           productPrice.Value = product.Price;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void addOnlineStoreButton_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(titleTextBox.Text, @"[а-яa-z]+\d*", RegexOptions.IgnoreCase))
            {
                if (!onlineStores.Keys.Contains(titleTextBox.Text))
                {
                    onlineStoresComboBox.Items.Add(titleTextBox.Text);
                    onlineStores.Add(titleTextBox.Text,
                        new
                        OnlineStore(
                            addressTextBox.Text, titleTextBox.Text, (int)soldProductsNumericUpDown.Value, (int)regNumericUpDown.Value)
                        );
                }
                else
                {
                    MessageBox.Show("Такой элемент уже есть");
                }
            }
            else
            {

                MessageBox.Show("Ошибка в названии");
            }
        }

        private void deleteOnlineStoreButton_Click(object sender, EventArgs e)
        {
            if (onlineStores.ContainsKey(onlineStoresComboBox.Text))
            {
                onlineStores.Remove(onlineStoresComboBox.Text);
                onlineStoresComboBox.Items.Remove(onlineStoresComboBox.Text);
                richTextBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Ошибка, такого элемента нет");
            }
        }

        private void editOnlineStoreButton_Click(object sender, EventArgs e)
        {
            if (onlineStores.ContainsKey(onlineStoresComboBox.Text))
            {
                onlineStores[onlineStoresComboBox.Text].Address = addressTextBox.Text;
                onlineStores[onlineStoresComboBox.Text].AmountSoldProducts = (int)soldProductsNumericUpDown.Value;
                onlineStores[onlineStoresComboBox.Text].AmountRegUsers = (int)regNumericUpDown.Value;
                richTextBox1.Text = onlineStores[onlineStoresComboBox.Text].ToString();
            }
            else
            {
                MessageBox.Show("Ошибка, такого элемента нет");
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {

            if (onlineStores.Keys.Contains(onlineStoresComboBox.Text) )
            {
                if (Regex.IsMatch(productName.Text, @"[а-яa-z]+\d*", RegexOptions.IgnoreCase))
                {
                    var products = onlineStores[onlineStoresComboBox.Text].Products;
                    if (products.FirstOrDefault(x => x.Name == productName.Text) == null)
                    {
                        products.Add(new Product(productName.Text, productPrice.Value));
                        productsComboBox.Items.Add(productName.Text);
                    }
                    else
                    {
                        MessageBox.Show("Продукт с таким именем уже есть");
                    }
                }
                else
                {

                    MessageBox.Show("Ошибка в названии");
                }

            }
            else
            {
                MessageBox.Show("Интернет магазина с таким названием нет");
            }
        }

        private void editProductButton_Click(object sender, EventArgs e)
        {
            var products = onlineStores[onlineStoresComboBox.Text].Products;
            Product? product = products.FirstOrDefault(x => x.Name == productName.Text);
            if (product != null)
            {
                product.Name = productName.Text;
                product.Price = productPrice.Value;
            }
            else
            {
                MessageBox.Show("Продукта с таким именем нет");
            }
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            var products = onlineStores[onlineStoresComboBox.Text].Products;
            Product? product = products.FirstOrDefault(x => x.Name == productName.Text);
            if (product != null)
            {
                products.Remove(product);
            }
            else
            {
                MessageBox.Show("Продукта с таким именем нет");
            }
        }

        private void onlineStoresComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = onlineStores[onlineStoresComboBox.Text];
            addressTextBox.Text = item.Address;
            titleTextBox.Text = item.Title;
            regNumericUpDown.Value = item.AmountRegUsers;
        }
    }
}