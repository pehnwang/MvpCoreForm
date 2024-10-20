using System.Windows.Forms;
using MvpCoreForm.Uc.CuTree.View;

namespace MvpCoreForm.Uc.CuTree.Presenter;

public class TaskTreePresenter
{
    private ITaskTree _treeView;

    public TaskTreePresenter(ITaskTree treeView)
    {
        _treeView = treeView;
        _treeView.AddNodeClicked += OnAddNodeClicked;
        _treeView.DeleteNodeClicked += OnDeleteNodeClicked;
    }

    private void OnDeleteNodeClicked(object? sender, EventArgs e)
    {
        var selectedNode = _treeView.SelectedNode;
        if (selectedNode != null)
        {
            _treeView.RemoveNode(selectedNode);
        }
    }

    private void OnAddNodeClicked(object? sender, EventArgs e)
    {
        var selectedNode = _treeView.SelectedNode;
        if (selectedNode == null)
        {
            // 未选中任何节点，添加默认主节点
            string nodeName = _treeView.GetNewNodeName();
            _treeView.AddRootNode(nodeName);
        }
        else if (selectedNode.Level == 0)
        {
            _treeView.AddChildNode(selectedNode, "默认子节点");
        }
        else
        {
            // 子节点下不允许添加节点
            MessageBox.Show("子节点下不允许创建任何节点。");
        }
    }
}