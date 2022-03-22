namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int productNumber = 0;
        OnlineStore onlineStore;
        OnlineStore musicOnlineStore;
        OnlineStore hardwareOnlineStore;
        private void Form1_Load(object sender, EventArgs e)
        {
            onlineStore = new OnlineStore("shop", "www.shop.ru");
            musicOnlineStore = new MusicInternetShop("shop", "www.shop.ru");
            hardwareOnlineStore = new HardwareInternetShop("shop", "www.shop.ru");
            timer1.Enabled = true;
        }
        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            ListViewItem item = new ListViewItem();
            var product = new Product();
            onlineStore = (rnd.Next(0, 2) == 1) ? musicOnlineStore : hardwareOnlineStore;
            onlineStore += product;
            item.Text = product.Name;
            item.SubItems.Add($"{product.Price} ð");
            item.SubItems.Add($"{onlineStore.PlaceAnOrder()}");
            listView1.Items.Add(item);
        }
    }
}