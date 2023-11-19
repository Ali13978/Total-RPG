using UnityEngine;
public class VertexPool.VertexSegment
{
    // Fields
    public int VertStart;
    public int IndexStart;
    public int VertCount;
    public int IndexCount;
    public XftWeapon.VertexPool Pool;
    
    // Methods
    public VertexPool.VertexSegment(int start, int count, int istart, int icount, XftWeapon.VertexPool pool)
    {
        val_1 = new System.Object();
        this.VertStart = start;
        this.IndexStart = istart;
        this.VertCount = count;
        this.IndexCount = icount;
        this.Pool = val_1;
    }
    public void ClearIndices()
    {
        int val_3;
        var val_4;
        val_3 = this.IndexStart;
        val_4 = val_3;
        goto label_0;
        label_5:
        var val_1 = X21 + ((X22) << 2);
        mem2[0] = 0;
        val_3 = this.IndexStart;
        val_4 = val_4 + 1;
        label_0:
        if(val_4 >= (this.IndexCount + val_3))
        {
            goto label_2;
        }
        
        if(val_4 < this.Pool.Indices.Length)
        {
            goto label_5;
        }
        
        goto label_5;
        label_2:
        this.Pool.IndiceChanged = true;
    }

}
