namespace TestStack.White.UIItems.TreeItems
{
    public class SelectedNodeVisitor : ITreeNodeVisitor
    {
        private TreeNode selectedNode;

        public virtual TreeNode SelectedNode
        {
            get { return selectedNode; }
        }

        public virtual void Accept(TreeNode treeNode)
        {
            if (treeNode.IsSelected) selectedNode = treeNode;
        }
    }
}