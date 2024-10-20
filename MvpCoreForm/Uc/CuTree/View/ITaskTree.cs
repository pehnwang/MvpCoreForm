namespace MvpCoreForm.Uc.CuTree.View;

public interface ITaskTree
{
    event EventHandler AddNodeClicked;
    event EventHandler DeleteNodeClicked;
    TreeNode SelectedNode { get; }
    void AddRootNode(string text);
    void AddChildNode(TreeNode parent, string text);
    void RemoveNode(TreeNode node);
    string GetNewNodeName(); // 新增方法，用于获取新节点的名称
}