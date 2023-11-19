using UnityEngine;
public class CellTree
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private CellTreeNode <RootNode>k__BackingField;
    
    // Properties
    public CellTreeNode RootNode { get; set; }
    
    // Methods
    public CellTree()
    {
    
    }
    public CellTree(CellTreeNode root)
    {
        this.<RootNode>k__BackingField = root;
    }
    public CellTreeNode get_RootNode()
    {
        return (CellTreeNode)this.<RootNode>k__BackingField;
    }
    private void set_RootNode(CellTreeNode value)
    {
        this.<RootNode>k__BackingField = value;
    }

}
