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
            onlineStore = new OnlineStore("Интернет магазин");
            onlineStore.ProductsWork += DisplayMessage;
        }

        void DisplayMessage(string message) => MessageBox.Show(message, "Сообщение");

        private void button1_Click(object sender, EventArgs e)
        {
            onlineStore.AddProduct(new Product(productName.Text, productPrice.Value));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            onlineStore.DeleteProduct(new Product(productName.Text, productPrice.Value));
        }
    }
}