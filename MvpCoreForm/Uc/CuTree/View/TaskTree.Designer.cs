namespace MvpCoreForm.Uc.CuTree.View
{
    partial class TaskTree
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            treeView1 = new TreeView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SubMenu_Add = new ToolStripMenuItem();
            SubMenu_Remove = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Fill;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(228, 483);
            treeView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { SubMenu_Add, SubMenu_Remove });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(124, 48);
            // 
            // SubMenu_Add
            // 
            SubMenu_Add.Name = "SubMenu_Add";
            SubMenu_Add.Size = new Size(123, 22);
            SubMenu_Add.Text = "Add";
            SubMenu_Add.Click += SubMenu_Add_Click;
            // 
            // SubMenu_Remove
            // 
            SubMenu_Remove.Name = "SubMenu_Remove";
            SubMenu_Remove.Size = new Size(123, 22);
            SubMenu_Remove.Text = "Remove";
            SubMenu_Remove.Click += SubMenu_Remove_Click;
            // 
            // TaskTree
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(treeView1);
            Name = "TaskTree";
            Size = new Size(228, 483);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem SubMenu_Add;
        private ToolStripMenuItem SubMenu_Remove;
    }
}
