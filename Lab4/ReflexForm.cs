namespace Lab4
{
    public partial class ReflexForm : Form
    {
        public ReflexForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode baseClassTreeNode = new TreeNode();
            baseClassTreeNode.Text = "Online Store";
            TreeNode musicClassTreeNode = new TreeNode();
            musicClassTreeNode.Text = "MusicInternetShop";
/*            musicClassTreeNode.Nodes.Add();
*/            // пройтись по всем полям, методам, свойствам класса, добавить как узлы
            TreeNode hardwareClassTreeNode = new TreeNode();
            hardwareClassTreeNode.Text = "HardwareInternetShop";
/*            hardwareClassTreeNode.Nodes.Add();
*/            
            // пройтись по всем полям, методам, свойствам класса, добавить как узлы
        }
    }
}