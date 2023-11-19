using UnityEngine;
public class DebugDraw.MeshCreator
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.Vector3> positions;
    private System.Collections.Generic.List<UnityEngine.Vector2> uvs;
    private int index;
    private System.Collections.Generic.Dictionary<long, int> middlePointIndexCache;
    
    // Methods
    public DebugDraw.MeshCreator()
    {
    
    }
    private int addVertex(UnityEngine.Vector3 p, UnityEngine.Vector2 uv)
    {
        this.positions.Add(item:  new UnityEngine.Vector3() {x = p.x, y = p.y, z = p.z});
        this.uvs.Add(item:  new UnityEngine.Vector2() {x = uv.x, y = uv.y});
        this.index = this.index + 1;
        return (int)this.index;
    }
    private int getMiddlePoint(int p1, int p2)
    {
        int val_12;
        System.Collections.Generic.Dictionary<System.Int64, System.Int32> val_13;
        int val_14;
        val_12 = p2;
        int val_4 = 0;
        val_13 = this.middlePointIndexCache;
        var val_1 = (p1 < val_12) ? p1 : (val_12);
        val_1 = val_1 << 32;
        long val_3 = val_1 + (((p1 < val_12) ? (val_12) : p1) << );
        if((val_13.TryGetValue(key:  val_3, value: out  val_4)) != false)
        {
                val_14 = val_4;
            return val_14;
        }
        
        UnityEngine.Vector3 val_6 = this.positions.Item[p1];
        UnityEngine.Vector3 val_7 = this.positions.Item[val_12];
        val_7.x = val_6.x + val_7.x;
        val_7.y = val_6.y + val_7.y;
        val_7.z = val_6.z + val_7.z;
        val_7.x = val_7.x * 0.5f;
        val_7.y = val_7.y * 0.5f;
        val_7.z = val_7.z * 0.5f;
        val_13 = this.uvs;
        UnityEngine.Vector2 val_8 = val_13.Item[p1];
        UnityEngine.Vector2 val_9 = this.uvs.Item[val_12];
        val_9.x = val_8.x + val_9.x;
        val_9.y = val_8.y + val_9.y;
        val_9.x = val_9.x * 0.5f;
        val_9.y = val_9.y * 0.5f;
        CinemachineFreeLook.Orbit val_10 = new CinemachineFreeLook.Orbit(h:  val_9.x, r:  val_9.y);
        val_12 = this.middlePointIndexCache;
        val_14 = this.addVertex(p:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, uv:  new UnityEngine.Vector2() {x = val_10.m_Height, y = val_10.m_Radius});
        val_12.Add(key:  val_3, value:  val_14);
        return val_14;
    }
    public UnityEngine.Mesh CreateCube(int subdivisions)
    {
        var val_76;
        DebugDraw.MeshCreator val_77;
        var val_78;
        var val_79;
        DebugDraw.MeshCreator val_80;
        var val_81;
        int val_82;
        int val_83;
        var val_84;
        int val_85;
        var val_86;
        var val_87;
        this.positions = new System.Collections.Generic.List<UnityEngine.Vector3>();
        this.uvs = new System.Collections.Generic.List<UnityEngine.Vector2>();
        this.index = 0;
        this.middlePointIndexCache = new System.Collections.Generic.Dictionary<System.Int64, System.Int32>();
        System.Collections.Generic.List<System.Int32> val_4 = null;
        val_76 = val_4;
        val_4 = new System.Collections.Generic.List<System.Int32>();
        CinemachineFreeLook.Orbit val_5 = new CinemachineFreeLook.Orbit(h:  1f, r:  0f);
        int val_6 = this.addVertex(p:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, uv:  new UnityEngine.Vector2() {x = val_5.m_Height, y = val_5.m_Radius});
        CinemachineFreeLook.Orbit val_7 = new CinemachineFreeLook.Orbit(h:  1f, r:  1f);
        int val_8 = this.addVertex(p:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, uv:  new UnityEngine.Vector2() {x = val_7.m_Height, y = val_7.m_Radius});
        CinemachineFreeLook.Orbit val_9 = new CinemachineFreeLook.Orbit(h:  0f, r:  1f);
        int val_10 = this.addVertex(p:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, uv:  new UnityEngine.Vector2() {x = val_9.m_Height, y = val_9.m_Radius});
        CinemachineFreeLook.Orbit val_11 = new CinemachineFreeLook.Orbit(h:  0f, r:  0f);
        int val_12 = this.addVertex(p:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, uv:  new UnityEngine.Vector2() {x = val_11.m_Height, y = val_11.m_Radius});
        if(null != 0)
        {
                Add(item:  0);
            Add(item:  3);
            Add(item:  2);
            Add(item:  2);
            Add(item:  1);
        }
        else
        {
                Add(item:  0);
            Add(item:  3);
            Add(item:  2);
            Add(item:  2);
            Add(item:  1);
        }
        
        Add(item:  0);
        CinemachineFreeLook.Orbit val_13 = new CinemachineFreeLook.Orbit(h:  1f, r:  0f);
        int val_14 = this.addVertex(p:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, uv:  new UnityEngine.Vector2() {x = val_13.m_Height, y = val_13.m_Radius});
        CinemachineFreeLook.Orbit val_15 = new CinemachineFreeLook.Orbit(h:  1f, r:  1f);
        int val_16 = this.addVertex(p:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, uv:  new UnityEngine.Vector2() {x = val_15.m_Height, y = val_15.m_Radius});
        CinemachineFreeLook.Orbit val_17 = new CinemachineFreeLook.Orbit(h:  0f, r:  1f);
        int val_18 = this.addVertex(p:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, uv:  new UnityEngine.Vector2() {x = val_17.m_Height, y = val_17.m_Radius});
        CinemachineFreeLook.Orbit val_19 = new CinemachineFreeLook.Orbit(h:  0f, r:  0f);
        int val_20 = this.addVertex(p:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, uv:  new UnityEngine.Vector2() {x = val_19.m_Height, y = val_19.m_Radius});
        if(null != 0)
        {
                Add(item:  4);
            Add(item:  7);
            Add(item:  6);
            Add(item:  6);
            Add(item:  5);
        }
        else
        {
                Add(item:  4);
            Add(item:  7);
            Add(item:  6);
            Add(item:  6);
            Add(item:  5);
        }
        
        Add(item:  4);
        CinemachineFreeLook.Orbit val_21 = new CinemachineFreeLook.Orbit(h:  1f, r:  0f);
        int val_22 = this.addVertex(p:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, uv:  new UnityEngine.Vector2() {x = val_21.m_Height, y = val_21.m_Radius});
        CinemachineFreeLook.Orbit val_23 = new CinemachineFreeLook.Orbit(h:  1f, r:  1f);
        int val_24 = this.addVertex(p:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, uv:  new UnityEngine.Vector2() {x = val_23.m_Height, y = val_23.m_Radius});
        CinemachineFreeLook.Orbit val_25 = new CinemachineFreeLook.Orbit(h:  0f, r:  1f);
        int val_26 = this.addVertex(p:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, uv:  new UnityEngine.Vector2() {x = val_25.m_Height, y = val_25.m_Radius});
        CinemachineFreeLook.Orbit val_27 = new CinemachineFreeLook.Orbit(h:  0f, r:  0f);
        int val_28 = this.addVertex(p:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, uv:  new UnityEngine.Vector2() {x = val_27.m_Height, y = val_27.m_Radius});
        if(null != 0)
        {
                Add(item:  8);
            Add(item:  11);
            Add(item:  10);
            Add(item:  10);
            Add(item:  9);
        }
        else
        {
                Add(item:  8);
            Add(item:  11);
            Add(item:  10);
            Add(item:  10);
            Add(item:  9);
        }
        
        Add(item:  8);
        CinemachineFreeLook.Orbit val_29 = new CinemachineFreeLook.Orbit(h:  1f, r:  0f);
        int val_30 = this.addVertex(p:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, uv:  new UnityEngine.Vector2() {x = val_29.m_Height, y = val_29.m_Radius});
        CinemachineFreeLook.Orbit val_31 = new CinemachineFreeLook.Orbit(h:  1f, r:  1f);
        int val_32 = this.addVertex(p:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, uv:  new UnityEngine.Vector2() {x = val_31.m_Height, y = val_31.m_Radius});
        CinemachineFreeLook.Orbit val_33 = new CinemachineFreeLook.Orbit(h:  0f, r:  1f);
        int val_34 = this.addVertex(p:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, uv:  new UnityEngine.Vector2() {x = val_33.m_Height, y = val_33.m_Radius});
        CinemachineFreeLook.Orbit val_35 = new CinemachineFreeLook.Orbit(h:  0f, r:  0f);
        int val_36 = this.addVertex(p:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, uv:  new UnityEngine.Vector2() {x = val_35.m_Height, y = val_35.m_Radius});
        if(null != 0)
        {
                Add(item:  12);
            Add(item:  15);
            Add(item:  14);
            Add(item:  14);
            Add(item:  13);
        }
        else
        {
                Add(item:  12);
            Add(item:  15);
            Add(item:  14);
            Add(item:  14);
            Add(item:  13);
        }
        
        Add(item:  12);
        CinemachineFreeLook.Orbit val_37 = new CinemachineFreeLook.Orbit(h:  0f, r:  0f);
        int val_38 = this.addVertex(p:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, uv:  new UnityEngine.Vector2() {x = val_37.m_Height, y = val_37.m_Radius});
        CinemachineFreeLook.Orbit val_39 = new CinemachineFreeLook.Orbit(h:  0f, r:  1f);
        int val_40 = this.addVertex(p:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, uv:  new UnityEngine.Vector2() {x = val_39.m_Height, y = val_39.m_Radius});
        CinemachineFreeLook.Orbit val_41 = new CinemachineFreeLook.Orbit(h:  1f, r:  1f);
        int val_42 = this.addVertex(p:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, uv:  new UnityEngine.Vector2() {x = val_41.m_Height, y = val_41.m_Radius});
        CinemachineFreeLook.Orbit val_43 = new CinemachineFreeLook.Orbit(h:  1f, r:  0f);
        int val_44 = this.addVertex(p:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, uv:  new UnityEngine.Vector2() {x = val_43.m_Height, y = val_43.m_Radius});
        if(null != 0)
        {
                Add(item:  16);
            Add(item:  17);
            Add(item:  18);
            Add(item:  18);
            Add(item:  19);
        }
        else
        {
                Add(item:  16);
            Add(item:  17);
            Add(item:  18);
            Add(item:  18);
            Add(item:  19);
        }
        
        Add(item:  16);
        CinemachineFreeLook.Orbit val_45 = new CinemachineFreeLook.Orbit(h:  1f, r:  0f);
        int val_46 = this.addVertex(p:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, uv:  new UnityEngine.Vector2() {x = val_45.m_Height, y = val_45.m_Radius});
        CinemachineFreeLook.Orbit val_47 = new CinemachineFreeLook.Orbit(h:  1f, r:  1f);
        int val_48 = this.addVertex(p:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, uv:  new UnityEngine.Vector2() {x = val_47.m_Height, y = val_47.m_Radius});
        CinemachineFreeLook.Orbit val_49 = new CinemachineFreeLook.Orbit(h:  0f, r:  1f);
        int val_50 = this.addVertex(p:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, uv:  new UnityEngine.Vector2() {x = val_49.m_Height, y = val_49.m_Radius});
        CinemachineFreeLook.Orbit val_51 = new CinemachineFreeLook.Orbit(h:  0f, r:  0f);
        int val_52 = this.addVertex(p:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, uv:  new UnityEngine.Vector2() {x = val_51.m_Height, y = val_51.m_Radius});
        if(null != 0)
        {
                Add(item:  21);
            Add(item:  20);
            Add(item:  23);
            Add(item:  23);
            Add(item:  22);
        }
        else
        {
                Add(item:  21);
            Add(item:  20);
            Add(item:  23);
            Add(item:  23);
            Add(item:  22);
        }
        
        val_77 = this;
        Add(item:  21);
        if(subdivisions < 1)
        {
            goto label_13;
        }
        
        label_33:
        System.Collections.Generic.List<System.Int32> val_53 = null;
        val_78 = val_53;
        val_53 = new System.Collections.Generic.List<System.Int32>();
        val_79 = 0;
        val_80 = val_77;
        goto label_14;
        label_32:
        val_80 = val_77;
        Add(item:  10649600);
        val_79 = 3;
        val_76 = val_77;
        label_14:
        if(val_79 >= this.Count)
        {
            goto label_16;
        }
        
        if(this != null)
        {
                val_81 = 1152921509956145392;
            val_82 = this.Item[3];
        }
        else
        {
                val_81 = 1152921509956145392;
            val_82 = 0.Item[3];
        }
        
        int val_57 = val_79 + 1;
        int val_59 = this.getMiddlePoint(p1:  val_82, p2:  this.Item[val_57]);
        if(this != null)
        {
                val_83 = this.Item[val_57];
        }
        else
        {
                val_83 = 0.Item[val_57];
        }
        
        int val_62 = val_79 + 2;
        int val_64 = this.getMiddlePoint(p1:  val_83, p2:  this.Item[val_62]);
        if(this != null)
        {
                val_84 = val_76;
            val_85 = this.Item[val_62];
        }
        else
        {
                val_84 = val_76;
            val_85 = 0.Item[val_62];
        }
        
        int val_68 = this.getMiddlePoint(p1:  val_85, p2:  this.Item[3]);
        int val_69 = this.Item[3];
        if(null != 0)
        {
                Add(item:  val_69);
            Add(item:  val_59);
        }
        else
        {
                Add(item:  val_69);
            Add(item:  val_59);
        }
        
        Add(item:  val_68);
        int val_70 = this.Item[val_57];
        if(null != 0)
        {
                val_86 = val_81;
            Add(item:  val_70);
            Add(item:  val_64);
        }
        else
        {
                val_86 = val_81;
            Add(item:  val_70);
            Add(item:  val_64);
        }
        
        Add(item:  val_59);
        int val_71 = this.Item[val_62];
        if(null == 0)
        {
            goto label_30;
        }
        
        Add(item:  val_71);
        Add(item:  val_68);
        Add(item:  val_64);
        Add(item:  val_59);
        Add(item:  val_64);
        goto label_32;
        label_30:
        Add(item:  val_71);
        Add(item:  val_68);
        Add(item:  val_64);
        Add(item:  val_59);
        Add(item:  val_64);
        goto label_32;
        label_16:
        var val_77 = 0;
        val_77 = val_80;
        val_77 = val_77 + 1;
        if(val_77 != subdivisions)
        {
            goto label_33;
        }
        
        goto label_34;
        label_13:
        val_78 = val_76;
        label_34:
        UnityEngine.Mesh val_72 = new UnityEngine.Mesh();
        vertices = this.positions.ToArray();
        triangles = ToArray();
        T[] val_75 = this.uvs.ToArray();
        if(null != 0)
        {
                uv = val_75;
            RecalculateNormals();
        }
        else
        {
                uv = val_75;
            RecalculateNormals();
        }
        
        int val_76 = vertexCount;
        val_87 = 0;
        goto label_42;
        label_46:
        val_87 = 1;
        mem[1152921506078131888] = 0;
        label_42:
        if(null != null)
        {
            goto label_46;
        }
        
        goto label_46;
    }
    public UnityEngine.Mesh CreateSphere(int subdivisions)
    {
        var val_8;
        UnityEngine.Mesh val_1 = this.CreateCube(subdivisions:  subdivisions);
        System.Collections.Generic.List<UnityEngine.Vector3> val_3 = new System.Collections.Generic.List<UnityEngine.Vector3>(collection:  val_1.vertices);
        val_8 = 0;
        goto label_2;
        label_8:
        set_Item(index:  0, value:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B});
        val_8 = 1;
        label_2:
        if(null == 0)
        {
            goto label_3;
        }
        
        if(val_8 < Count)
        {
            goto label_4;
        }
        
        goto label_6;
        label_3:
        if(val_8 >= Count)
        {
            goto label_6;
        }
        
        label_4:
        UnityEngine.Vector3 val_6 = Item[1];
        if(null != 0)
        {
            goto label_8;
        }
        
        goto label_8;
        label_6:
        T[] val_7 = ToArray();
        if(val_1 != null)
        {
                val_1.vertices = val_7;
        }
        else
        {
                0.vertices = val_7;
        }
        
        val_1.RecalculateNormals();
        DebugDraw.MeshCreator.RecalculateTangents(mesh:  val_1);
        return val_1;
    }
    public static void RecalculateTangents(UnityEngine.Mesh mesh)
    {
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        int val_1 = X1.vertexCount;
        int val_2 = X1.vertexCount;
        val_56 = 0;
        goto label_3;
        label_45:
        var val_3 = null + (X28 * 12);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (X28 * 12) + null + 32, y = (X28 * 12) + null + 32 + 4, z = (X28 * 12) + null + 40}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_56 = 1;
        mem2[0] = val_4.x;
        mem2[0] = val_4.y;
        mem2[0] = val_4.z;
        label_3:
        System.Int32[] val_5 = X1.triangles;
        if(val_56 >= val_5.Length)
        {
            goto label_7;
        }
        
        int val_58 = X1.triangles[1];
        int val_59 = X1.triangles[(long)val_56 + 1];
        val_56 = ((long)val_56 + 1) + 1;
        int val_60 = X1.triangles[(long)val_56 + 2];
        int val_12 = X1.vertices + (val_58 * 12);
        int val_14 = X1.vertices + (val_59 * 12);
        float val_65 = (val_7[(long)(int)((val_56 + 1))][0] * 12) + val_13 + 32;
        int val_16 = X1.vertices + (val_60 * 12);
        float val_66 = (val_9[(long)(int)((val_56 + 2))][0] * 12) + val_15 + 32;
        float val_67 = (val_9[(long)(int)((val_56 + 2))][0] * 12) + val_15 + 32 + 4;
        UnityEngine.Vector2 val_61 = X1.uv[val_58];
        UnityEngine.Vector2 val_63 = X1.uv[val_59];
        val_65 = val_65 - ((val_6[0x1][0] * 12) + val_11 + 32);
        val_66 = val_66 - ((val_6[0x1][0] * 12) + val_11 + 32);
        val_67 = val_67 - ((val_6[0x1][0] * 12) + val_11 + 32 + 4);
        float val_20 = ((val_7[(long)(int)((val_56 + 1))][0] * 12) + val_13 + 32 + 4) - ((val_6[0x1][0] * 12) + val_11 + 32 + 4);
        UnityEngine.Vector2 val_70 = X1.uv[val_58];
        val_63 = val_63 - val_61;
        float val_21 = ((val_7[(long)(int)((val_56 + 1))][0] * 12) + val_13 + 40) - ((val_6[0x1][0] * 12) + val_11 + 40);
        float val_22 = ((val_9[(long)(int)((val_56 + 2))][0] * 12) + val_15 + 40) - ((val_6[0x1][0] * 12) + val_11 + 40);
        UnityEngine.Vector2 val_69 = X1.uv[val_60];
        float val_23 = X1.uv[val_59] - val_70;
        float val_24 = val_66 * val_23;
        float val_26 = X1.uv[val_60] - val_61;
        float val_27 = val_69 - val_70;
        val_22 = val_22 * val_23;
        val_69 = val_63 * val_27;
        val_23 = val_23 * val_26;
        val_70 = val_65 * val_27;
        val_23 = val_69 - val_23;
        float val_28 = val_20 * val_27;
        val_27 = val_21 * val_27;
        val_28 = val_28 - (val_67 * val_23);
        float val_71 = 1f;
        val_24 = val_70 - val_24;
        val_61 = val_71 / val_23;
        val_23 = val_24 * val_61;
        val_71 = val_28 * val_61;
        float val_30 = (val_27 - val_22) * val_61;
        float val_72 = val_22;
        float val_31 = val_66 * val_63;
        val_72 = val_72 * val_63;
        val_31 = val_31 - (val_65 * val_26);
        float val_36 = (val_67 * val_63) - (val_20 * val_26);
        float val_37 = val_72 - (val_21 * val_26);
        val_31 = val_31 * val_61;
        val_36 = val_36 * val_61;
        val_37 = val_37 * val_61;
        int val_38 = null + (val_58 * 12);
        UnityEngine.Vector3 val_39 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (val_6[0x1][0] * 12) + null + 32, y = (val_6[0x1][0] * 12) + null + 32 + 4, z = (val_6[0x1][0] * 12) + null + 40}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        mem2[0] = val_39.x;
        mem2[0] = val_39.y;
        mem2[0] = val_39.z;
        int val_40 = null + (val_59 * 12);
        UnityEngine.Vector3 val_41 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (val_7[(long)(int)((val_56 + 1))][0] * 12) + null + 32, y = (val_7[(long)(int)((val_56 + 1))][0] * 12) + null + 32 + 4, z = (val_7[(long)(int)((val_56 + 1))][0] * 12) + null + 40}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        mem2[0] = val_41.x;
        mem2[0] = val_41.y;
        mem2[0] = val_41.z;
        int val_42 = null + (val_60 * 12);
        UnityEngine.Vector3 val_43 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (val_9[(long)(int)((val_56 + 2))][0] * 12) + null + 32, y = (val_9[(long)(int)((val_56 + 2))][0] * 12) + null + 32 + 4, z = (val_9[(long)(int)((val_56 + 2))][0] * 12) + null + 40}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        mem2[0] = val_43.x;
        mem2[0] = val_43.y;
        mem2[0] = val_43.z;
        int val_44 = null + (val_58 * 12);
        UnityEngine.Vector3 val_45 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (val_6[0x1][0] * 12) + null + 32, y = (val_6[0x1][0] * 12) + null + 32 + 4, z = (val_6[0x1][0] * 12) + null + 40}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        mem2[0] = val_45.x;
        mem2[0] = val_45.y;
        mem2[0] = val_45.z;
        int val_46 = null + (val_59 * 12);
        UnityEngine.Vector3 val_47 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (val_7[(long)(int)((val_56 + 1))][0] * 12) + null + 32, y = (val_7[(long)(int)((val_56 + 1))][0] * 12) + null + 32 + 4, z = (val_7[(long)(int)((val_56 + 1))][0] * 12) + null + 40}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        mem2[0] = val_47.x;
        mem2[0] = val_47.y;
        mem2[0] = val_47.z;
        goto label_45;
        label_7:
        int val_48 = X1.vertexCount;
        val_57 = 0;
        val_58 = 0;
        val_59 = 1152921505938976480;
        goto label_46;
        label_67:
        UnityEngine.Vector4[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_C = val_4.x;
        val_58 = 1;
        val_57 = 12;
        val_59 = 1152921505938976496;
        label_46:
        if(X1 == 0)
        {
            goto label_47;
        }
        
        if(val_58 < (X1.vertexCount << ))
        {
            goto label_48;
        }
        
        goto label_50;
        label_47:
        if(val_58 >= (X1.vertexCount << ))
        {
            goto label_50;
        }
        
        label_48:
        UnityEngine.Vector3 val_73 = X1.normals[val_57];
        UnityEngine.Vector3 val_74 = X1.normals[val_57];
        UnityEngine.Vector3 val_75 = X1.normals[val_57];
        UnityEngine.Vector3 val_53 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_73, y = val_74, z = val_75}, d:  UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_73, y = val_74, z = val_75}, rhs:  new UnityEngine.Vector3() {x = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_2C, y = UnityEngine.Vector3[].__il2cppRuntimeField_element_class, z = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_34}));
        UnityEngine.Vector3 val_54 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_2C, y = UnityEngine.Vector3[].__il2cppRuntimeField_element_class, z = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_34}, b:  new UnityEngine.Vector3() {x = val_53.x, y = val_53.y, z = val_53.z});
        UnityEngine.Vector4 val_55 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = val_54.x, y = val_54.y, z = val_54.z});
        UnityEngine.Vector4[].__il2cppRuntimeField_element_class.__il2cppRuntimeField_FFFFFFFFFFFFFFFF = val_55.x;
        UnityEngine.Vector4[].__il2cppRuntimeField_element_class.__il2cppRuntimeField_4 = val_55.y;
        UnityEngine.Vector4[].__il2cppRuntimeField_element_class.__il2cppRuntimeField_8 = val_55.z;
        UnityEngine.Vector4[].__il2cppRuntimeField_element_class.__il2cppRuntimeField_C = val_55.w;
        UnityEngine.Vector3 val_56 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_73, y = val_74, z = val_75}, rhs:  new UnityEngine.Vector3() {x = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_2C, y = UnityEngine.Vector3[].__il2cppRuntimeField_element_class, z = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_34});
        if((UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_56.x, y = val_56.y, z = val_56.z}, rhs:  new UnityEngine.Vector3() {x = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_2C, y = UnityEngine.Vector3[].__il2cppRuntimeField_element_class, z = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_34})) < 0)
        {
            goto label_67;
        }
        
        goto label_67;
        label_50:
        X1.tangents = null;
    }

}
