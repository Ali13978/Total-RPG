using UnityEngine;
public class CellTreeNode
{
    // Fields
    public byte Id;
    public UnityEngine.Vector3 Center;
    public UnityEngine.Vector3 Size;
    public UnityEngine.Vector3 TopLeft;
    public UnityEngine.Vector3 BottomRight;
    public CellTreeNode.ENodeType NodeType;
    public CellTreeNode Parent;
    public System.Collections.Generic.List<CellTreeNode> Childs;
    private float maxDistance;
    
    // Methods
    public CellTreeNode()
    {
    
    }
    public CellTreeNode(byte id, CellTreeNode.ENodeType nodeType, CellTreeNode parent)
    {
        val_1 = new System.Object();
        this.Parent = val_1;
        this.Id = id;
        this.NodeType = nodeType;
    }
    public void AddChild(CellTreeNode child)
    {
        System.Collections.Generic.List<CellTreeNode> val_2 = this.Childs;
        if(val_2 == null)
        {
                System.Collections.Generic.List<CellTreeNode> val_1 = null;
            val_2 = val_1;
            val_1 = new System.Collections.Generic.List<CellTreeNode>(capacity:  1);
            this.Childs = val_2;
            if(null == 0)
        {
                val_2 = 0;
        }
        
        }
        
        val_2.Add(item:  child);
    }
    public void Draw()
    {
    
    }
    public void GetActiveCells(System.Collections.Generic.List<byte> activeCells, bool yIsUpAxis, UnityEngine.Vector3 position)
    {
        var val_6;
        CellTreeNode val_7;
        var val_8;
        val_6 = activeCells;
        val_7 = this;
        if(this.NodeType != 2)
        {
            goto label_1;
        }
        
        if((this.IsPointNearCell(yIsUpAxis:  false, point:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z})) == false)
        {
                return;
        }
        
        if((this.IsPointInsideCell(yIsUpAxis:  yIsUpAxis, point:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z})) == false)
        {
            goto label_4;
        }
        
        goto label_7;
        label_8:
        do
        {
            label_7:
            val_6.Insert(index:  0, item:  this.Id);
            val_7 = this.Parent;
            if(val_7 == null)
        {
                return;
        }
        
        }
        while(val_6 != null);
        
        goto label_8;
        label_1:
        val_7 = this.Childs;
        List.Enumerator<T> val_4 = val_7.GetEnumerator();
        label_13:
        if((0 & 1) == 0)
        {
            goto label_10;
        }
        
        System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_5 = 0.InitializationCallback;
        yIsUpAxis = yIsUpAxis;
        goto label_13;
        label_4:
        val_6.Add(item:  this.Id);
        return;
        label_10:
        val_6 = 0;
        val_8 = 1;
        0.Dispose();
        if((val_8 & 1) != 0)
        {
                return;
        }
        
        if(val_6 == 0)
        {
                return;
        }
    
    }
    public bool IsPointInsideCell(bool yIsUpAxis, UnityEngine.Vector3 point)
    {
        if(point.x < 0)
        {
                return false;
        }
        
        if(point.x > this.BottomRight)
        {
                return false;
        }
        
        if(yIsUpAxis != false)
        {
                if(point.y < point.x)
        {
                return false;
        }
        
            if(point.y > point.x)
        {
                return false;
        }
        
            return true;
        }
        
        if(point.z < point.x)
        {
                return false;
        }
        
        if(point.z <= point.x)
        {
                return true;
        }
        
        return false;
    }
    public bool IsPointNearCell(bool yIsUpAxis, UnityEngine.Vector3 point)
    {
        if(this.maxDistance == 0f)
        {
                UnityEngine.Vector3 val_3 = this.Size;
            val_3 = val_3 + point.y;
            val_3 = val_3 + point.z;
            val_3 = val_3 * 0.5f;
            this.maxDistance = val_3;
        }
        
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z}, b:  new UnityEngine.Vector3() {x = this.Center, y = V12.16B, z = V11.16B});
        float val_4 = this.maxDistance;
        val_4 = val_4 * val_4;
        return (bool)(val_1.x <= val_4) ? 1 : 0;
    }

}
