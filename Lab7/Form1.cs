using System.Text.RegularExpressions;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OnlineStore onlineStore;
        private void Form1_Load(object sender, EventArgs e)
        {
            onlineStore = new OnlineStore("�������� �������");
            onlineStore.ProductsWork += DisplayMessage;
        }
        string namePattern = @"[�-��-�]+[0-9]*";
        bool CheckName(string name)
        {
            return Regex.IsMatch(name, namePattern);
        }
        void DisplayMessage(string message) => MessageBox.Show(message, "���������");

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckName(productName.Text))
            {
                onlineStore.AddProduct(new Product(productName.Text, productPrice.Value));
            }
            else
            {
                MessageBox.Show("������ � �������� ��������", "���������");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (CheckName(productName.Text))
            {
                onlineStore.DeleteProduct(new Product(productName.Text, productPrice.Value));
            }
            else
            {
                MessageBox.Show("������ � �������� ��������", "���������");
            }
            
        }
    }
}