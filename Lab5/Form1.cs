namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int productNumber = 0;
        OnlineStore onlineStore; // ��������� ����
        OnlineStore musicOnlineStore;
        OnlineStore hardwareOnlineStore;
        private void Form1_Load(object sender, EventArgs e)
        {
            musicOnlineStore = new MusicInternetShop("musicShop", "www.musicShop.ru");
            hardwareOnlineStore = new HardwareInternetShop("hardwareShop", "www.hardwareshop.ru");
            timer1.Enabled = true;
        }
        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            ListViewItem item = new ListViewItem(); // ������� � �������
            onlineStore = (rnd.Next(0, 2) == 1) ? musicOnlineStore : hardwareOnlineStore; // �������� �������� � ������ ������ ������ ����� ����������� �������
            var product = new Product(onlineStore.ProductCount+1); // �������� �������� � ��������� ����� {����� ������} � �������� �������� �����
            onlineStore += product; // ������������� ��������
            item.Text = product.Name;
            item.SubItems.Add($"{product.Price} �");
            item.SubItems.Add($"{onlineStore.PlaceAnOrder()}");
            listView1.Items.Add(item);
        }
    }
}