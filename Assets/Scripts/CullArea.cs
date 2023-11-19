using UnityEngine;
[UnityEngine.HelpURLAttribute]
public class CullArea : MonoBehaviour
{
    // Fields
    private const int MAX_NUMBER_OF_ALLOWED_CELLS = 250;
    public const int MAX_NUMBER_OF_SUBDIVISIONS = 3;
    public readonly byte FIRST_GROUP_ID;
    public readonly int[] SUBDIVISION_FIRST_LEVEL_ORDER;
    public readonly int[] SUBDIVISION_SECOND_LEVEL_ORDER;
    public readonly int[] SUBDIVISION_THIRD_LEVEL_ORDER;
    public UnityEngine.Vector2 Center;
    public UnityEngine.Vector2 Size;
    public UnityEngine.Vector2[] Subdivisions;
    public int NumberOfSubdivisions;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private int <CellCount>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private CellTree <CellTree>k__BackingField;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private System.Collections.Generic.Dictionary<int, UnityEngine.GameObject> <Map>k__BackingField;
    public bool YIsUpAxis;
    public bool RecreateCellHierarchy;
    private byte idCounter;
    
    // Properties
    public int CellCount { get; set; }
    public CellTree CellTree { get; set; }
    public System.Collections.Generic.Dictionary<int, UnityEngine.GameObject> Map { get; set; }
    
    // Methods
    public CullArea()
    {
        this.FIRST_GROUP_ID = 1;
        this.SUBDIVISION_FIRST_LEVEL_ORDER = null;
        this.SUBDIVISION_SECOND_LEVEL_ORDER = null;
        this.SUBDIVISION_THIRD_LEVEL_ORDER = null;
        CinemachineFreeLook.Orbit val_1 = new CinemachineFreeLook.Orbit(h:  25f, r:  25f);
        this.Size = val_1.m_Height;
        mem[1152921512464243428] = val_1.m_Height >> 32;
        this.Subdivisions = null;
    }
    public int get_CellCount()
    {
        return (int)this.<CellCount>k__BackingField;
    }
    private void set_CellCount(int value)
    {
        this.<CellCount>k__BackingField = value;
    }
    public CellTree get_CellTree()
    {
        return (CellTree)this.<CellTree>k__BackingField;
    }
    private void set_CellTree(CellTree value)
    {
        this.<CellTree>k__BackingField = value;
    }
    public System.Collections.Generic.Dictionary<int, UnityEngine.GameObject> get_Map()
    {
        return (System.Collections.Generic.Dictionary<System.Int32, UnityEngine.GameObject>)this.<Map>k__BackingField;
    }
    private void set_Map(System.Collections.Generic.Dictionary<int, UnityEngine.GameObject> value)
    {
        this.<Map>k__BackingField = value;
    }
    private void Awake()
    {
        this.idCounter = this.FIRST_GROUP_ID;
        this.CreateCellHierarchy();
    }
    public void OnDrawGizmos()
    {
        this.idCounter = this.FIRST_GROUP_ID;
        if(this.RecreateCellHierarchy != false)
        {
                this.CreateCellHierarchy();
        }
        
        this.DrawCells();
    }
    private void CreateCellHierarchy()
    {
        var val_33;
        CellTree val_34;
        float val_35;
        val_33 = this;
        if(this.IsCellCountAllowed() != true)
        {
                if(UnityEngine.Debug.isDebugBuild != false)
        {
                typeof(System.Object[]).__il2cppRuntimeField_20 = "There are too many cells created by your subdivision options. Maximum allowed number of cells is ";
            byte val_33 = this.FIRST_GROUP_ID;
            val_33 = 250 - val_33;
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_33;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            val_34 = ". Current number of cells is ";
            typeof(System.Object[]).__il2cppRuntimeField_30 = val_34;
            typeof(System.Object[]).__il2cppRuntimeField_38 = this.<CellCount>k__BackingField;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_40 = ".";
            val_33 = +0;
            UnityEngine.Debug.LogError(message:  0);
            return;
        }
        
            UnityEngine.Application.Quit();
        }
        
        this.idCounter = this.idCounter + 1;
        CellTreeNode val_6 = new CellTreeNode(id:  this.idCounter, nodeType:  0, parent:  0);
        UnityEngine.Vector3 val_8 = this.transform.position;
        UnityEngine.Transform val_9 = this.transform;
        if(this.YIsUpAxis != false)
        {
                UnityEngine.Vector3 val_10 = val_9.position;
            CinemachineFreeLook.Orbit val_11 = new CinemachineFreeLook.Orbit(h:  val_8.x, r:  val_10.y);
            this.Center = val_11.m_Height;
            mem[1152921512465321452] = val_11.m_Height >> 32;
            UnityEngine.Vector3 val_14 = this.transform.localScale;
            UnityEngine.Vector3 val_16 = this.transform.localScale;
            CinemachineFreeLook.Orbit val_17 = new CinemachineFreeLook.Orbit(h:  val_14.x, r:  val_16.y);
            this.Size = val_17.m_Height;
            mem[1152921512465321460] = val_17.m_Height >> 32;
            typeof(CellTreeNode).__il2cppRuntimeField_14 = 0;
            typeof(CellTreeNode).__il2cppRuntimeField_18 = 0;
            typeof(CellTreeNode).__il2cppRuntimeField_1C = 0;
            val_35 = 0.5f;
            typeof(CellTreeNode).__il2cppRuntimeField_20 = 0;
            typeof(CellTreeNode).__il2cppRuntimeField_24 = 0;
            typeof(CellTreeNode).__il2cppRuntimeField_28 = 0;
            UnityEngine.Vector2 val_35 = this.Center;
            UnityEngine.Vector2 val_34 = this.Size;
            val_34 = val_34 * val_35;
            float val_19 = S3 * val_35;
            val_35 = val_35 - val_34;
            val_16.y = val_16.y - val_19;
            typeof(CellTreeNode).__il2cppRuntimeField_34 = 0;
            typeof(CellTreeNode).__il2cppRuntimeField_2C = 0;
            UnityEngine.Vector2 val_37 = this.Center;
            UnityEngine.Vector2 val_36 = this.Size;
            val_36 = val_36 * val_35;
            val_19 = val_19 * val_35;
            val_37 = val_37 + val_36;
            val_16.y = val_16.y + val_19;
        }
        else
        {
                UnityEngine.Vector3 val_20 = val_9.position;
            CinemachineFreeLook.Orbit val_21 = new CinemachineFreeLook.Orbit(h:  val_8.x, r:  val_20.z);
            this.Center = val_21.m_Height;
            mem[1152921512465321452] = val_21.m_Height >> 32;
            UnityEngine.Vector3 val_24 = this.transform.localScale;
            UnityEngine.Vector3 val_26 = this.transform.localScale;
            CinemachineFreeLook.Orbit val_27 = new CinemachineFreeLook.Orbit(h:  val_24.x, r:  val_26.z);
            this.Size = val_27.m_Height;
            mem[1152921512465321460] = val_27.m_Height >> 32;
            typeof(CellTreeNode).__il2cppRuntimeField_14 = 0;
            typeof(CellTreeNode).__il2cppRuntimeField_18 = 0;
            typeof(CellTreeNode).__il2cppRuntimeField_1C = 0;
            val_35 = 0.5f;
            typeof(CellTreeNode).__il2cppRuntimeField_20 = 0;
            typeof(CellTreeNode).__il2cppRuntimeField_24 = 0;
            typeof(CellTreeNode).__il2cppRuntimeField_28 = 0;
            UnityEngine.Vector2 val_39 = this.Center;
            UnityEngine.Vector2 val_38 = this.Size;
            val_38 = val_38 * val_35;
            float val_29 = S3 * val_35;
            val_39 = val_39 - val_38;
            float val_30 = 0f - val_29;
            typeof(CellTreeNode).__il2cppRuntimeField_34 = 0;
            typeof(CellTreeNode).__il2cppRuntimeField_2C = 0;
            UnityEngine.Vector2 val_41 = this.Center;
            UnityEngine.Vector2 val_40 = this.Size;
            val_40 = val_40 * val_35;
            val_29 = val_29 * val_35;
            val_41 = val_41 + val_40;
            float val_31 = 0f + val_29;
        }
        
        typeof(CellTreeNode).__il2cppRuntimeField_38 = 0;
        typeof(CellTreeNode).__il2cppRuntimeField_3C = 0;
        typeof(CellTreeNode).__il2cppRuntimeField_40 = 0;
        this.CreateChildCells(parent:  val_6, cellLevelInHierarchy:  1);
        CellTree val_32 = null;
        val_34 = val_32;
        val_32 = new CellTree(root:  val_6);
        this.<CellTree>k__BackingField = val_34;
        this.RecreateCellHierarchy = false;
    }
    private void CreateChildCells(CellTreeNode parent, int cellLevelInHierarchy)
    {
        var val_21;
        UnityEngine.Vector2[] val_22;
        UnityEngine.Vector2 val_23;
        UnityEngine.Vector3 val_24;
        var val_26;
        var val_28;
        float val_29;
        if(this.NumberOfSubdivisions < cellLevelInHierarchy)
        {
                return;
        }
        
        val_21 = cellLevelInHierarchy - 1;
        val_22 = this.Subdivisions;
        val_23 = val_22[(long)val_21];
        if(parent != null)
        {
                val_24 = parent.Size;
            UnityEngine.Vector3 val_20 = parent.Center;
            float val_19 = -0.5f;
            val_19 = val_24 * val_19;
            val_20 = val_20 + val_19;
        }
        else
        {
                float val_21 = 8.96831E-44f;
            val_21 = val_21 * (-0.5f);
            val_21 = (1.401298E-45f) + val_21;
            val_24 = 8.96831E-44f;
        }
        
        if((int)this.Subdivisions[(long)val_21] < 1)
        {
                return;
        }
        
        val_23 = 0.5f;
        val_24 = val_24 / (float)(int)this.Subdivisions[(long)val_21];
        val_24 = val_24 * val_23;
        int val_1 = cellLevelInHierarchy + 1;
        label_27:
        if((int)val_23 < 1)
        {
            goto label_9;
        }
        
        var val_25 = 0;
        float val_22 = 0f;
        val_22 = val_24 * val_22;
        val_22 = val_21 + val_22;
        float val_2 = val_24 + val_22;
        float val_3 = val_2 - val_24;
        float val_4 = val_24 + val_2;
        label_26:
        this.idCounter = this.idCounter + 1;
        CellTreeNode val_7 = null;
        val_22 = val_7;
        val_7 = new CellTreeNode(id:  this.idCounter, nodeType:  (this.NumberOfSubdivisions == cellLevelInHierarchy) ? (1 + 1) : 1, parent:  parent);
        if(this.YIsUpAxis == false)
        {
            goto label_11;
        }
        
        if(parent == null)
        {
            goto label_12;
        }
        
        val_26 = val_22;
        goto label_13;
        label_11:
        if(parent == null)
        {
            goto label_14;
        }
        
        val_28 = val_22;
        goto label_15;
        label_12:
        label_13:
        float val_8 = S14 * val_23;
        val_8 = S13 - val_8;
        val_29 = val_22 / (float)(int)val_23;
        float val_23 = 0f;
        val_23 = val_23 * val_29;
        float val_9 = val_29 * val_23;
        val_23 = val_8 + val_23;
        float val_10 = val_9 + val_23;
        typeof(CellTreeNode).__il2cppRuntimeField_14 = 0;
        typeof(CellTreeNode).__il2cppRuntimeField_18 = 0;
        typeof(CellTreeNode).__il2cppRuntimeField_1C = 0;
        float val_11 = val_10 - val_9;
        typeof(CellTreeNode).__il2cppRuntimeField_20 = 0;
        typeof(CellTreeNode).__il2cppRuntimeField_24 = 0;
        typeof(CellTreeNode).__il2cppRuntimeField_28 = 0;
        float val_12 = val_9 + val_10;
        typeof(CellTreeNode).__il2cppRuntimeField_2C = 0;
        typeof(CellTreeNode).__il2cppRuntimeField_34 = 0;
        goto label_19;
        label_14:
        label_15:
        float val_13 = S14 * val_23;
        val_13 = S13 - val_13;
        val_29 = val_22 / (float)(int)val_23;
        float val_24 = 0f;
        val_24 = val_24 * val_29;
        float val_14 = val_29 * val_23;
        val_24 = val_13 + val_24;
        float val_15 = val_14 + val_24;
        typeof(CellTreeNode).__il2cppRuntimeField_14 = 0;
        typeof(CellTreeNode).__il2cppRuntimeField_18 = 0;
        typeof(CellTreeNode).__il2cppRuntimeField_1C = 0;
        float val_16 = val_15 - val_14;
        typeof(CellTreeNode).__il2cppRuntimeField_20 = 0;
        typeof(CellTreeNode).__il2cppRuntimeField_24 = 0;
        typeof(CellTreeNode).__il2cppRuntimeField_28 = 0;
        float val_17 = val_14 + val_15;
        typeof(CellTreeNode).__il2cppRuntimeField_2C = 0;
        typeof(CellTreeNode).__il2cppRuntimeField_34 = 0;
        label_19:
        val_21 = 0;
        typeof(CellTreeNode).__il2cppRuntimeField_38 = 0;
        typeof(CellTreeNode).__il2cppRuntimeField_3C = val_21;
        typeof(CellTreeNode).__il2cppRuntimeField_40 = 0;
        parent.AddChild(child:  val_22);
        val_25 = val_25 + 1;
        if((int)val_23 != val_25)
        {
            goto label_26;
        }
        
        label_9:
        var val_26 = 0;
        val_26 = val_26 + 1;
        if(val_26 != (int)this.Subdivisions[(long)val_21])
        {
            goto label_27;
        }
    
    }
    private void DrawCells()
    {
        if((this.<CellTree>k__BackingField) != null)
        {
                if((this.<CellTree>k__BackingField.RootNode) != null)
        {
                this.<CellTree>k__BackingField.RootNode.Draw();
            return;
        }
        
        }
        
        this.RecreateCellHierarchy = true;
    }
    private bool IsCellCountAllowed()
    {
        var val_2;
        var val_3;
        var val_4;
        val_2 = 0;
        val_3 = 1;
        val_4 = 1;
        goto label_0;
        label_4:
        val_2 = 1;
        int val_4 = (int);
        val_4 = (int) * val_4;
        val_3 = val_4 * val_3;
        label_0:
        if(val_2 >= this.Subdivisions.Length)
        {
            goto label_2;
        }
        
        if(val_2 < this.Subdivisions.Length)
        {
            goto label_4;
        }
        
        goto label_4;
        label_2:
        byte val_5 = this.FIRST_GROUP_ID;
        val_4 = val_4 * val_3;
        this.<CellCount>k__BackingField = val_4;
        val_5 = 250 - val_5;
        return (bool)(val_4 <= val_5) ? 1 : 0;
    }
    public System.Collections.Generic.List<byte> GetActiveCells(UnityEngine.Vector3 position)
    {
        System.Collections.Generic.List<System.Byte> val_1 = new System.Collections.Generic.List<System.Byte>(capacity:  0);
        this.<CellTree>k__BackingField.RootNode.GetActiveCells(activeCells:  val_1, yIsUpAxis:  (this.YIsUpAxis == true) ? 1 : 0, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
        return val_1;
    }

}
