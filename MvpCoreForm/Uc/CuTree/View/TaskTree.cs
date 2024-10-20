namespace MvpCoreForm.Uc.CuTree.View
{
    public partial class TaskTree : UserControl, ITaskTree
    {
        public TaskTree()
        {
            InitializeComponent();
            InitializeTreeView();
        }

        private void InitializeTreeView()
        {
            treeView1.ContextMenuStrip = contextMenuStrip1;
            treeView1.AfterSelect += TreeView1_AfterSelect;
            treeView1.MouseDown += TreeView1_MouseDown; // 添加此行
        }

        private void TreeView1_MouseDown(object? sender, MouseEventArgs e)
        {
            if (treeView1.GetNodeAt(e.Location) == null)
            {
                treeView1.SelectedNode = null; // 取消选中节点
            }
        }

        private void TreeView1_AfterSelect(object? sender, TreeViewEventArgs e)
        {
            // 可以根据需要处理节点选择事件
        }

        public event EventHandler? AddNodeClicked;

        public event EventHandler? DeleteNodeClicked;

        public TreeNode SelectedNode => treeView1.SelectedNode;

        public void AddRootNode(string text)
        {
            var node = new TreeNode(text);
            treeView1.Nodes.Add(node);
        }

        public void AddChildNode(TreeNode parent, string text)
        {
            var node = new TreeNode(text);
            parent.Nodes.Add(node);
            parent.Expand();
        }

        public void RemoveNode(TreeNode node)
        {
            if (node.Parent != null)
            {
                node.Parent.Nodes.Remove(node);
            }
            else
            {
                treeView1.Nodes.Remove(node);
            }
        }

        public string GetNewNodeName()
        {
            using (var inputForm = new Form())
            {
                inputForm.Text = "输入新节点名称";
                inputForm.Width = 300;
                inputForm.Height = 150;
                inputForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                inputForm.StartPosition = FormStartPosition.CenterScreen;
                inputForm.MinimizeBox = false;
                inputForm.MaximizeBox = false;

                var textBox = new TextBox() { Left = 50, Top = 20, Width = 200 };
                var buttonOk = new Button()
                    { Text = "确定", Left = 50, Width = 100, Top = 50, DialogResult = DialogResult.OK };
                var buttonCancel = new Button()
                    { Text = "取消", Left = 150, Width = 100, Top = 50, DialogResult = DialogResult.Cancel };

                buttonOk.Click += (sender, e) =>
                {
                    inputForm.DialogResult = DialogResult.OK;
                    inputForm.Close();
                };
                buttonCancel.Click += (sender, e) =>
                {
                    inputForm.DialogResult = DialogResult.Cancel;
                    inputForm.Close();
                };

                inputForm.Controls.Add(textBox);
                inputForm.Controls.Add(buttonOk);
                inputForm.Controls.Add(buttonCancel);
                inputForm.AcceptButton = buttonOk;
                inputForm.CancelButton = buttonCancel;

                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    return textBox.Text;
                }
                else
                {
                    return ""; // 用户取消输入
                }
            }
        }

        private void SubMenu_Add_Click(object sender, EventArgs e)
        {
            AddNodeClicked?.Invoke(this, EventArgs.Empty);
        }

        private void SubMenu_Remove_Click(object sender, EventArgs e)
        {
            DeleteNodeClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}