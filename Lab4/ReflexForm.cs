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
            void Fill(TreeNode node, Type type)
            {
                foreach (var member in type.GetMembers())
                {
                    string memberType = $"{member.MemberType}";
                    memberType = (memberType == "Method") ? "Метод" : memberType;
                    node.Nodes.Add($"{memberType} {member.Name}");
                }
            }
            TreeNode baseClassTreeNode = new TreeNode();
            baseClassTreeNode.Text = "Online Store";
            Fill(baseClassTreeNode, typeof(OnlineStore));
            TreeNode musicClassTreeNode = new TreeNode();
            musicClassTreeNode.Text = "MusicInternetShop";
            Fill(musicClassTreeNode, typeof(MusicInternetShop));
            baseClassTreeNode.Nodes.Add(musicClassTreeNode);
            TreeNode hardwareClassTreeNode = new TreeNode();
            hardwareClassTreeNode.Text = "HardwareInternetShop";
            Fill(hardwareClassTreeNode, typeof(HardwareInternetShop));
            baseClassTreeNode.Nodes.Add(hardwareClassTreeNode);
            treeView1.Nodes.Add(baseClassTreeNode);

        }
    }
}