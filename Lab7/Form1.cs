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
            onlineStore.ProductAdded += DisplayMessage;
        }

        void DisplayMessage(string message) => MessageBox.Show(message, "���������");

        private void button1_Click(object sender, EventArgs e)
        {
            onlineStore.AddProduct(new Product(productName.Text, productPrice.Value));
        }
    }
}