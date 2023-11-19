using UnityEngine;
private sealed class FbxExporter.<ExportToFile>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal System.IO.StreamWriter <writer>__0;
    internal System.IO.StreamReader <reader>__0;
    internal FbxDataNode[] <allNodes>__0;
    internal int <objNodeIndex>__0;
    internal string <animBaseLayerId>__0;
    internal int <i>__1;
    internal TransformTracker <objTracker>__2;
    internal string <objName>__2;
    internal string <objId>__2;
    internal string <animCurveNodeT_id>__2;
    internal string <animCurveNodeR_id>__2;
    internal string <animCurveNodeS_id>__2;
    internal string <curveT_X_id>__2;
    internal string <curveT_Y_id>__2;
    internal string <curveT_Z_id>__2;
    internal string <curveR_X_id>__2;
    internal string <curveR_Y_id>__2;
    internal string <curveR_Z_id>__2;
    internal string <curveS_X_id>__2;
    internal string <curveS_Y_id>__2;
    internal string <curveS_Z_id>__2;
    internal float[] <xData>__2;
    internal float[] <yData>__2;
    internal float[] <zData>__2;
    internal int <dataCount>__2;
    internal FbxExporter $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public FbxExporter.<ExportToFile>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_45;
        string val_46;
        string val_47;
        System.IO.StreamReader val_48;
        var val_50;
        string val_51;
        FbxDataNode[] val_53;
        int val_55;
        var val_57;
        string val_59;
        string val_60;
        var val_61;
        var val_62;
        var val_63;
        var val_64;
        string val_65;
        int val_44 = this.$PC;
        val_45 = 0;
        this.$PC = 0;
        val_44 = (val_44 < 7) ? (val_44 + 3) : 0;
        val_44 = val_44 - 3;
        if(val_44 > 6)
        {
                return (bool)val_45;
        }
        
        var val_45 = 25822312 + ((this.$PC < 7 ? (this.$PC + 3) : 0 - 3)) << 2;
        val_45 = val_45 + 25822312;
        goto (25822312 + ((this.$PC < 7 ? (this.$PC + 3) : 0 - 3)) << 2 + 25822312);
        label_24:
        val_47 = ;
        val_48 = this.<reader>__0;
        if(val_48 == 1)
        {
            goto label_8;
        }
        
        if((this.<reader>__0.IndexOf(value:  "PreRotation")) == 1)
        {
            goto label_11;
        }
        
        val_50 = null;
        int val_46 = this.<reader>__0.IndexOf(value:  "P:");
        val_50 = null;
        val_51 = System.String.Empty;
        if((val_46 + 1) >= 1)
        {
                val_46 = val_46 + 1;
            do
        {
            val_50 = null;
            val_51 = 0 + val_51;
            val_46 = val_46 - 1;
        }
        while(val_46 != 0);
        
        }
        
        string val_8 = 0 + val_51;
        if((this.<writer>__0) != null)
        {
            goto label_24;
        }
        
        goto label_24;
        label_11:
        if((this.<writer>__0) != null)
        {
            goto label_24;
        }
        
        goto label_24;
        label_39:
        val_53 = this.<allNodes>__0;
        val_46 = 1;
        if(val_46 >= (this.<allNodes>__0.Length))
        {
            goto label_32;
        }
        
        FbxDataNode val_47 = this.<allNodes>__0[1];
        if((System.String.op_Equality(a:  0, b:  this.<allNodes>__0[0x1][0].nodeName)) == false)
        {
            goto label_39;
        }
        
        this.<objNodeIndex>__0 = val_46;
        goto label_39;
        label_8:
        val_45 = 1;
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_45;
        }
        
        this.$PC = val_45;
        return (bool)val_45;
        label_32:
        this.$current = 0;
        if(this.$disposing == true)
        {
            goto label_231;
        }
        
        val_57 = 2;
        goto label_232;
        label_231:
        val_45 = 1;
        return (bool)val_45;
        label_232:
        this.$PC = 5;
        goto label_231;
        label_88:
        var val_16 = (mem[this.$this] + 64) + ((this.<i>__1) << 3);
        UnityEngine.Transform val_17 = mem[this.$this].transform;
        if(0 != ((mem[this.$this] + 64 + (this.<i>__1) << 3) + 32))
        {
            goto label_85;
        }
        
        val_55 = (this.<i>__1) + 1;
        mem2[0] = val_55;
        if(val_55 < (mem[this.$this] + 64 + 24))
        {
            goto label_88;
        }
        
        UnityEngine.Debug.Log(message:  0);
        if(mem[this.$this] == 0)
        {
            goto label_91;
        }
        
        val_59 = mem[mem[this.$this] + 40];
        val_59 = mem[this.$this] + 40;
        goto label_92;
        label_85:
        var val_20 = (mem[this.$this] + 72) + ((this.<i>__1) << 3);
        this.<objTracker>__2 = (mem[this.$this] + 72 + (this.<i>__1) << 3) + 32;
        var val_21 = (mem[this.$this] + 64) + ((this.<i>__1) << 3);
        val_60 = (mem[this.$this] + 64 + (this.<i>__1) << 3) + 32.name;
        this.<objName>__2 = val_60;
        if(mem[this.$this] == 0)
        {
                val_60 = this.<objName>__2;
        }
        
        this.<objId>__2 = mem[this.$this] + 56.searchObjectId(objectName:  val_60);
        string val_48 = mem[this.$this] + 100;
        val_48 = val_48 + 1;
        mem2[0] = val_48;
        this.<animCurveNodeT_id>__2 = val_48;
        string val_49 = mem[this.$this] + 100;
        val_49 = val_49 + 1;
        mem2[0] = val_49;
        this.<animCurveNodeR_id>__2 = val_49;
        string val_50 = mem[this.$this] + 100;
        val_50 = val_50 + 1;
        mem2[0] = val_50;
        this.<animCurveNodeS_id>__2 = val_50;
        string val_51 = mem[this.$this] + 100;
        val_51 = val_51 + 1;
        mem2[0] = val_51;
        this.<curveT_X_id>__2 = val_51;
        string val_52 = mem[this.$this] + 100;
        val_52 = val_52 + 1;
        mem2[0] = val_52;
        this.<curveT_Y_id>__2 = val_52;
        string val_53 = mem[this.$this] + 100;
        val_53 = val_53 + 1;
        mem2[0] = val_53;
        this.<curveT_Z_id>__2 = val_53;
        string val_54 = mem[this.$this] + 100;
        val_54 = val_54 + 1;
        mem2[0] = val_54;
        this.<curveR_X_id>__2 = val_54;
        string val_55 = mem[this.$this] + 100;
        val_55 = val_55 + 1;
        mem2[0] = val_55;
        this.<curveR_Y_id>__2 = val_55;
        string val_56 = mem[this.$this] + 100;
        val_56 = val_56 + 1;
        mem2[0] = val_56;
        this.<curveR_Z_id>__2 = val_56;
        string val_57 = mem[this.$this] + 100;
        val_57 = val_57 + 1;
        mem2[0] = val_57;
        this.<curveS_X_id>__2 = val_57;
        string val_58 = mem[this.$this] + 100;
        val_58 = val_58 + 1;
        mem2[0] = val_58;
        this.<curveS_Y_id>__2 = val_58;
        string val_59 = mem[this.$this] + 100;
        val_59 = val_59 + 1;
        mem2[0] = val_59;
        this.<curveS_Z_id>__2 = val_59;
        string val_24 = 0 + "Generating Node [" + this.<objName>__2(this.<objName>__2);
        UnityEngine.Debug.Log(message:  0);
        val_61 = mem[this.$this];
        if(mem[this.$this] != 0)
        {
            goto label_118;
        }
        
        val_61 = mem[this.$this];
        if(val_61 == 0)
        {
            goto label_131;
        }
        
        label_118:
        var val_25 = (mem[this.$this] + 64) + ((this.<i>__1) << 3);
        UnityEngine.Vector3 val_26 = (mem[this.$this] + 64 + (this.<i>__1) << 3) + 32.localPosition;
        UnityEngine.Vector3 val_27 = ExportHelper.UnityToMayaPosition(t:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
        mem[this.$this] + 48.AddAnimationCurveNode(inputId:  this.<animCurveNodeT_id>__2, animCurveType:  0, initData:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
        val_62 = mem[this.$this];
        if(mem[this.$this] != 0)
        {
            goto label_124;
        }
        
        val_62 = mem[this.$this];
        if(val_62 == 0)
        {
            goto label_131;
        }
        
        label_124:
        var val_28 = (mem[this.$this] + 64) + ((this.<i>__1) << 3);
        UnityEngine.Quaternion val_29 = (mem[this.$this] + 64 + (this.<i>__1) << 3) + 32.localRotation;
        UnityEngine.Vector3 val_30 = ExportHelper.UnityToMayaRotation(q:  new UnityEngine.Quaternion() {x = val_29.x, y = val_29.y, z = val_29.z, w = val_29.w});
        mem[this.$this] + 48.AddAnimationCurveNode(inputId:  this.<animCurveNodeR_id>__2, animCurveType:  1, initData:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z});
        val_63 = mem[this.$this];
        if(mem[this.$this] != 0)
        {
            goto label_130;
        }
        
        val_63 = mem[this.$this];
        if(val_63 == 0)
        {
            goto label_131;
        }
        
        label_130:
        var val_31 = (mem[this.$this] + 64) + ((this.<i>__1) << 3);
        UnityEngine.Vector3 val_32 = (mem[this.$this] + 64 + (this.<i>__1) << 3) + 32.localScale;
        mem[this.$this] + 48.AddAnimationCurveNode(inputId:  this.<animCurveNodeS_id>__2, animCurveType:  2, initData:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z});
        int val_33 = this.<objTracker>__2.posDataList.Count;
        this.<xData>__2 = null;
        int val_34 = this.<objTracker>__2.posDataList.Count;
        this.<yData>__2 = null;
        int val_35 = this.<objTracker>__2.posDataList.Count;
        this.<zData>__2 = null;
        int val_36 = this.<objTracker>__2.posDataList.Count;
        this.<dataCount>__2 = val_36;
        if(val_36 >= 1)
        {
                var val_60 = 0;
            do
        {
            UnityEngine.Vector3 val_37 = this.<objTracker>__2.posDataList.Item[0];
            UnityEngine.Vector3 val_38 = ExportHelper.UnityToMayaPosition(t:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z});
            this.<xData>__2[0] = val_38.x;
            this.<yData>__2[0] = val_38.y;
            this.<zData>__2[0] = val_38.z;
            val_60 = val_60 + 1;
        }
        while(val_60 < (this.<dataCount>__2));
        
        }
        
        mem[this.$this] + 48.AddAnimationCurve(inputId:  this.<curveT_X_id>__2, curveData:  this.<xData>__2);
        mem[this.$this] + 48.AddAnimationCurve(inputId:  this.<curveT_Y_id>__2, curveData:  this.<yData>__2);
        mem[this.$this] + 48.AddAnimationCurve(inputId:  this.<curveT_Z_id>__2, curveData:  this.<zData>__2);
        if((this.<dataCount>__2) >= 1)
        {
                var val_61 = 0;
            do
        {
            UnityEngine.Quaternion val_39 = this.<objTracker>__2.rotDataList.Item[0];
            UnityEngine.Vector3 val_40 = ExportHelper.UnityToMayaRotation(q:  new UnityEngine.Quaternion() {x = val_39.x, y = val_39.y, z = val_39.z, w = val_39.w});
            this.<xData>__2[0] = val_40.x;
            this.<yData>__2[0] = val_40.y;
            this.<zData>__2[0] = val_40.z;
            val_61 = val_61 + 1;
        }
        while(val_61 < (this.<dataCount>__2));
        
        }
        
        mem[this.$this] + 48.AddAnimationCurve(inputId:  this.<curveR_X_id>__2, curveData:  this.<xData>__2);
        mem[this.$this] + 48.AddAnimationCurve(inputId:  this.<curveR_Y_id>__2, curveData:  this.<yData>__2);
        mem[this.$this] + 48.AddAnimationCurve(inputId:  this.<curveR_Z_id>__2, curveData:  this.<zData>__2);
        if((this.<dataCount>__2) >= 1)
        {
                var val_62 = 0;
            do
        {
            UnityEngine.Vector3 val_41 = this.<objTracker>__2.scaleDataList.Item[0];
            this.<xData>__2[0] = val_41.x;
            UnityEngine.Vector3 val_42 = this.<objTracker>__2.scaleDataList.Item[0];
            this.<yData>__2[0] = val_42.y;
            UnityEngine.Vector3 val_43 = this.<objTracker>__2.scaleDataList.Item[0];
            this.<zData>__2[0] = val_43.z;
            val_62 = val_62 + 1;
        }
        while(val_62 < (this.<dataCount>__2));
        
        }
        
        mem[this.$this] + 48.AddAnimationCurve(inputId:  this.<curveS_X_id>__2, curveData:  this.<xData>__2);
        mem[this.$this] + 48.AddAnimationCurve(inputId:  this.<curveS_Y_id>__2, curveData:  this.<yData>__2);
        mem[this.$this] + 48.AddAnimationCurve(inputId:  this.<curveS_Z_id>__2, curveData:  this.<zData>__2);
        mem[this.$this] + 56.AddConnectionItem(type1:  "AnimCurveNode", name1:  "T", id1:  this.<animCurveNodeT_id>__2, type2:  "Model", name2:  this.<objName>__2, id2:  this.<objId>__2, relation:  "OP", relationDesc:  "Lcl Translation");
        mem[this.$this] + 56.AddConnectionItem(type1:  "AnimCurveNode", name1:  "R", id1:  this.<animCurveNodeR_id>__2, type2:  "Model", name2:  this.<objName>__2, id2:  this.<objId>__2, relation:  "OP", relationDesc:  "Lcl Rotation");
        mem[this.$this] + 56.AddConnectionItem(type1:  "AnimCurveNode", name1:  "S", id1:  this.<animCurveNodeS_id>__2, type2:  "Model", name2:  this.<objName>__2, id2:  this.<objId>__2, relation:  "OP", relationDesc:  "Lcl Scaling");
        val_64 = null;
        val_65 = "AnimCurveNode";
        goto label_207;
        label_91:
        val_59 = 34460624;
        label_92:
        mem[this.$this].ModifyDefinitions(targetFilePath:  val_59);
        this.$current = 0;
        if(this.$disposing == true)
        {
            goto label_231;
        }
        
        goto label_232;
        label_207:
        mem[this.$this] + 56.AddConnectionItem(type1:  null, name1:  "T", id1:  this.<animCurveNodeT_id>__2, type2:  "AnimLayer", name2:  "BaseLayer", id2:  this.<animBaseLayerId>__0, relation:  "OO", relationDesc:  System.String.Empty);
        mem[this.$this] + 56.AddConnectionItem(type1:  "AnimCurveNode", name1:  "R", id1:  this.<animCurveNodeR_id>__2, type2:  "AnimLayer", name2:  "BaseLayer", id2:  this.<animBaseLayerId>__0, relation:  "OO", relationDesc:  System.String.Empty);
        mem[this.$this] + 56.AddConnectionItem(type1:  "AnimCurveNode", name1:  "S", id1:  this.<animCurveNodeS_id>__2, type2:  "AnimLayer", name2:  "BaseLayer", id2:  this.<animBaseLayerId>__0, relation:  "OO", relationDesc:  System.String.Empty);
        mem[this.$this] + 56.AddConnectionItem(type1:  "AnimCurve", name1:  System.String.Empty, id1:  this.<curveT_X_id>__2, type2:  "AnimCurveNode", name2:  "T", id2:  this.<animCurveNodeT_id>__2, relation:  "OP", relationDesc:  "d|X");
        mem[this.$this] + 56.AddConnectionItem(type1:  "AnimCurve", name1:  System.String.Empty, id1:  this.<curveT_Y_id>__2, type2:  "AnimCurveNode", name2:  "T", id2:  this.<animCurveNodeT_id>__2, relation:  "OP", relationDesc:  "d|Y");
        mem[this.$this] + 56.AddConnectionItem(type1:  "AnimCurve", name1:  System.String.Empty, id1:  this.<curveT_Z_id>__2, type2:  "AnimCurveNode", name2:  "T", id2:  this.<animCurveNodeT_id>__2, relation:  "OP", relationDesc:  "d|Z");
        mem[this.$this] + 56.AddConnectionItem(type1:  "AnimCurve", name1:  System.String.Empty, id1:  this.<curveR_X_id>__2, type2:  "AnimCurveNode", name2:  "R", id2:  this.<animCurveNodeR_id>__2, relation:  "OP", relationDesc:  "d|X");
        mem[this.$this] + 56.AddConnectionItem(type1:  "AnimCurve", name1:  System.String.Empty, id1:  this.<curveR_Y_id>__2, type2:  "AnimCurveNode", name2:  "R", id2:  this.<animCurveNodeR_id>__2, relation:  "OP", relationDesc:  "d|Y");
        mem[this.$this] + 56.AddConnectionItem(type1:  "AnimCurve", name1:  System.String.Empty, id1:  this.<curveR_Z_id>__2, type2:  "AnimCurveNode", name2:  "R", id2:  this.<animCurveNodeR_id>__2, relation:  "OP", relationDesc:  "d|Z");
        mem[this.$this] + 56.AddConnectionItem(type1:  "AnimCurve", name1:  System.String.Empty, id1:  this.<curveS_X_id>__2, type2:  "AnimCurveNode", name2:  "S", id2:  this.<animCurveNodeS_id>__2, relation:  "OP", relationDesc:  "d|X");
        mem[this.$this] + 56.AddConnectionItem(type1:  "AnimCurve", name1:  System.String.Empty, id1:  this.<curveS_Y_id>__2, type2:  "AnimCurveNode", name2:  "S", id2:  this.<animCurveNodeS_id>__2, relation:  "OP", relationDesc:  "d|Y");
        mem[this.$this] + 56.AddConnectionItem(type1:  "AnimCurve", name1:  System.String.Empty, id1:  this.<curveS_Z_id>__2, type2:  "AnimCurveNode", name2:  "S", id2:  this.<animCurveNodeS_id>__2, relation:  "OP", relationDesc:  "d|Z");
        this.$current = 0;
        if(this.$disposing == true)
        {
            goto label_231;
        }
        
        goto label_232;
        label_131:
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private object System.Collections.Generic.IEnumerator<object>.get_Current()
    {
        return (object)this.$current;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.$current;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public void Dispose()
    {
        this.$disposing = true;
        this.$PC = 0;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public void Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }

}
