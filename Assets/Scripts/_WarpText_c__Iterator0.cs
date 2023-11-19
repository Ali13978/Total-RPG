using UnityEngine;
private sealed class WarpTextExample.<WarpText>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal float <old_CurveScale>__0;
    internal UnityEngine.AnimationCurve <old_curve>__0;
    internal TMPro.TMP_TextInfo <textInfo>__1;
    internal int <characterCount>__1;
    internal float <boundsMinX>__1;
    internal float <boundsMaxX>__1;
    internal UnityEngine.Vector3[] <vertices>__2;
    internal UnityEngine.Matrix4x4 <matrix>__2;
    internal TMPro.Examples.WarpTextExample $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public WarpTextExample.<WarpText>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        float val_10;
        float val_11;
        float val_14;
        float val_38;
        float val_39;
        var val_44;
        float val_45;
        var val_46;
        var val_47;
        float val_48;
        TMPro.TMP_CharacterInfo[] val_49;
        TMPro.Examples.WarpTextExample val_50;
        UnityEngine.Vector3[] val_51;
        UnityEngine.Vector3[] val_52;
        UnityEngine.Vector3[] val_53;
        int val_53 = this.$PC;
        this.$PC = 0;
        int val_1 = val_53 + 3;
        val_53 = (val_53 < 3) ? (val_1) : 0;
        val_1 = val_53 - 4;
        if(val_1 < 2)
        {
            goto label_1;
        }
        
        val_44 = 0;
        if(val_53 != 3)
        {
                return (bool)val_44;
        }
        
        this.$this.VertexCurve.preWrapMode = 1;
        this.$this.VertexCurve.postWrapMode = 1;
        this.$this.m_TextComponent.havePropertiesChanged = true;
        if(this.$this != null)
        {
                val_45 = this.$this.CurveScale;
        }
        else
        {
                val_45 = 0f;
        }
        
        float val_54 = 10f;
        val_54 = val_45 * val_54;
        mem[48] = val_54;
        if(this.$this != null)
        {
                this.<old_CurveScale>__0 = this.$this.CurveScale;
        }
        else
        {
                this.<old_CurveScale>__0 = this.$this.CurveScale;
            if(this.$this == null)
        {
            goto label_119;
        }
        
        }
        
        label_119:
        this.<old_curve>__0 = this.$this.m_TextComponent.CopyAnimationCurve(curve:  this.$this.VertexCurve);
        label_1:
        val_46 = 32;
        label_37:
        if(this.$this.m_TextComponent.havePropertiesChanged == true)
        {
            goto label_20;
        }
        
        val_45 = this.<old_CurveScale>__0;
        if(val_45 != this.$this.CurveScale)
        {
            goto label_20;
        }
        
        val_45 = this.$this.CurveScale;
        if(val_45 == this.$this.CurveScale)
        {
            goto label_28;
        }
        
        label_20:
        if(this.$this != null)
        {
                this.<old_CurveScale>__0 = this.$this.CurveScale;
        }
        else
        {
                this.<old_CurveScale>__0 = this.$this.CurveScale;
            if(this.$this == null)
        {
            goto label_15;
        }
        
        }
        
        label_15:
        this.<old_curve>__0 = this.$this.VertexCurve.keys[48].CopyAnimationCurve(curve:  this.$this.VertexCurve);
        this.<textInfo>__1 = this.$this.m_TextComponent.textInfo;
        this.<characterCount>__1 = val_8.characterCount;
        if(val_8.characterCount == 0)
        {
            goto label_37;
        }
        
        UnityEngine.Bounds val_9 = this.$this.m_TextComponent.bounds;
        this.<boundsMinX>__1 = val_11;
        UnityEngine.Bounds val_12 = this.$this.m_TextComponent.bounds;
        this.<boundsMaxX>__1 = val_14;
        if((this.<characterCount>__1) < 1)
        {
            goto label_42;
        }
        
        var val_66 = 0;
        val_47 = 328;
        val_48 = 0f;
        label_113:
        val_49 = this.<textInfo>__1.characterInfo;
        val_46 = 0;
        if(0 == 0)
        {
            goto label_46;
        }
        
        this.<vertices>__2 = mem[48];
        float val_15 = mem[378171968] + mem[378171992];
        val_15 = val_15 * 0.5f;
        CinemachineFreeLook.Orbit val_16 = new CinemachineFreeLook.Orbit(h:  val_15, r:  0f);
        UnityEngine.Vector3 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_16.m_Height, y = val_16.m_Radius});
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = mem[378171968], y = mem[378171972], z = mem[378171976]}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
        mem[378171968] = val_19.x;
        mem[378171972] = val_19.y;
        mem[378171976] = val_19.z;
        UnityEngine.Vector3[] val_55 = this.<vertices>__2;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
        val_55 = val_55 + (31514329 * 12);
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (31514329 * 12) + this.<vertices>__2 + 32, y = (31514329 * 12) + this.<vertices>__2 + 32 + 4, z = (31514329 * 12) + this.<vertices>__2 + 40}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
        mem2[0] = val_21.x;
        mem2[0] = val_21.y;
        mem2[0] = val_21.z;
        UnityEngine.Vector3[] val_56 = this.<vertices>__2;
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
        val_56 = val_56 + (31514330 * 12);
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (31514330 * 12) + this.<vertices>__2 + 32, y = (31514330 * 12) + this.<vertices>__2 + 32 + 4, z = (31514330 * 12) + this.<vertices>__2 + 40}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
        mem2[0] = val_23.x;
        mem2[0] = val_23.y;
        mem2[0] = val_23.z;
        UnityEngine.Vector3[] val_57 = this.<vertices>__2;
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
        val_57 = val_57 + (((long)31514328 + 3) * 12);
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ((long)(int)((31514328 + 3)) * 12) + this.<vertices>__2 + 32, y = ((long)(int)((31514328 + 3)) * 12) + this.<vertices>__2 + 32 + 4, z = ((long)(int)((31514328 + 3)) * 12) + this.<vertices>__2 + 40}, b:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
        mem2[0] = val_26.x;
        mem2[0] = val_26.y;
        mem2[0] = val_26.z;
        float val_27 = val_17.x - (this.<boundsMinX>__1);
        val_27 = val_27 / ((this.<boundsMaxX>__1) - (this.<boundsMinX>__1));
        val_50 = this.$this;
        if(this.$this != null)
        {
            goto label_77;
        }
        
        val_50 = this.$this;
        if(val_50 == null)
        {
            goto label_102;
        }
        
        label_77:
        val_27 = val_27 + 0.0001f;
        float val_30 = (this.$this.VertexCurve.Evaluate(time:  val_27)) * this.$this.CurveScale;
        float val_58 = this.$this.VertexCurve.Evaluate(time:  val_27);
        val_58 = val_58 * this.$this.CurveScale;
        float val_60 = this.<boundsMinX>__1;
        float val_59 = this.<boundsMaxX>__1;
        val_59 = val_59 - val_60;
        val_59 = val_27 * val_59;
        val_60 = val_60 + val_59;
        val_11 = 0;
        val_14 = 0;
        UnityEngine.Vector3 val_32 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        float val_61 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rhs:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z});
        val_61 = val_61 * 57.29578f;
        UnityEngine.Vector3 val_34 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rhs:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z});
        float val_62 = 360f;
        val_62 = val_62 - val_61;
        val_61 = (val_34.z > 0f) ? (val_61) : (val_62);
        val_14 = 0;
        UnityEngine.Quaternion val_35 = UnityEngine.Quaternion.Euler(x:  val_48, y:  val_48, z:  val_61);
        UnityEngine.Vector3 val_36 = UnityEngine.Vector3.one;
        UnityEngine.Matrix4x4 val_37 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, q:  new UnityEngine.Quaternion() {x = val_35.x, y = val_35.y, z = val_35.z, w = val_35.w}, s:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.z});
        m03 = val_38;
        m02 = val_39;
        m01 = val_10;
        mem2[0] = val_11;
        val_51 = this.<vertices>__2;
        if((this.<vertices>__2) != null)
        {
            goto label_89;
        }
        
        val_51 = this.<vertices>__2;
        if(val_51 == null)
        {
            goto label_102;
        }
        
        label_89:
        val_48 = val_48;
        var val_40 = val_51 + (31514328 * 12);
        var val_41 = (this.<vertices>__2) + (31514328 * 12);
        mem2[0] = (31514328 * 12) + this.<vertices>__2 + 32;
        mem2[0] = (31514328 * 12) + this.<vertices>__2 + 32 + 4;
        mem2[0] = (31514328 * 12) + this.<vertices>__2 + 40;
        val_52 = this.<vertices>__2;
        if((this.<vertices>__2) != null)
        {
            goto label_93;
        }
        
        val_52 = this.<vertices>__2;
        if(val_52 == null)
        {
            goto label_102;
        }
        
        label_93:
        var val_42 = val_52 + (31514329 * 12);
        var val_43 = (this.<vertices>__2) + (31514329 * 12);
        mem2[0] = (31514329 * 12) + this.<vertices>__2 + 32;
        mem2[0] = (31514329 * 12) + this.<vertices>__2 + 32 + 4;
        mem2[0] = (31514329 * 12) + this.<vertices>__2 + 40;
        val_53 = this.<vertices>__2;
        if((this.<vertices>__2) != null)
        {
            goto label_97;
        }
        
        val_53 = this.<vertices>__2;
        if(val_53 == null)
        {
            goto label_102;
        }
        
        label_97:
        var val_44 = val_53 + (31514330 * 12);
        var val_45 = (this.<vertices>__2) + (31514330 * 12);
        mem2[0] = (31514330 * 12) + this.<vertices>__2 + 32;
        mem2[0] = (31514330 * 12) + this.<vertices>__2 + 32 + 4;
        mem2[0] = (31514330 * 12) + this.<vertices>__2 + 40;
        val_49 = this.<vertices>__2;
        if((this.<vertices>__2) != null)
        {
            goto label_101;
        }
        
        val_49 = this.<vertices>__2;
        if(val_49 == null)
        {
            goto label_102;
        }
        
        label_101:
        var val_46 = val_49 + (((long)31514328 + 3) * 12);
        var val_47 = (this.<vertices>__2) + (((long)31514328 + 3) * 12);
        mem2[0] = ((long)(int)((31514328 + 3)) * 12) + this.<vertices>__2 + 32;
        mem2[0] = ((long)(int)((31514328 + 3)) * 12) + this.<vertices>__2 + 32 + 4;
        mem2[0] = ((long)(int)((31514328 + 3)) * 12) + this.<vertices>__2 + 40;
        UnityEngine.Vector3[] val_63 = this.<vertices>__2;
        val_45 = val_17.y;
        val_63 = val_63 + (31514328 * 12);
        UnityEngine.Vector3 val_48 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (31514328 * 12) + this.<vertices>__2 + 32, y = (31514328 * 12) + this.<vertices>__2 + 32 + 4, z = (31514328 * 12) + this.<vertices>__2 + 40}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_45, z = val_17.z});
        mem2[0] = val_48.x;
        mem2[0] = val_48.y;
        mem2[0] = val_48.z;
        UnityEngine.Vector3[] val_64 = this.<vertices>__2;
        val_64 = val_64 + (31514329 * 12);
        UnityEngine.Vector3 val_49 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (31514329 * 12) + this.<vertices>__2 + 32, y = (31514329 * 12) + this.<vertices>__2 + 32 + 4, z = (31514329 * 12) + this.<vertices>__2 + 40}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_45, z = val_17.z});
        mem2[0] = val_49.x;
        mem2[0] = val_49.y;
        mem2[0] = val_49.z;
        UnityEngine.Vector3[] val_65 = this.<vertices>__2;
        val_65 = val_65 + (31514330 * 12);
        UnityEngine.Vector3 val_50 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (31514330 * 12) + this.<vertices>__2 + 32, y = (31514330 * 12) + this.<vertices>__2 + 32 + 4, z = (31514330 * 12) + this.<vertices>__2 + 40}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_45, z = val_17.z});
        mem2[0] = val_50.x;
        mem2[0] = val_50.y;
        mem2[0] = val_50.z;
        val_46 = (this.<vertices>__2) + (((long)31514328 + 3) * 12);
        UnityEngine.Vector3 val_51 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ((long)(int)((31514328 + 3)) * 12) + this.<vertices>__2 + 32, y = ((long)(int)((31514328 + 3)) * 12) + this.<vertices>__2 + 32 + 4, z = ((long)(int)((31514328 + 3)) * 12) + this.<vertices>__2 + 40}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_45, z = val_17.z});
        val_47 = 328;
        mem2[0] = val_51.x;
        mem2[0] = val_51.y;
        mem2[0] = val_51.z;
        label_46:
        val_66 = val_66 + 1;
        if(val_66 < (this.<characterCount>__1))
        {
            goto label_113;
        }
        
        label_42:
        this.$current = new UnityEngine.WaitForSeconds(seconds:  0.025f);
        if(this.$disposing != true)
        {
                this.$PC = 2;
        }
        
        val_44 = 1;
        return (bool)val_44;
        label_28:
        this.$current = 0;
        if(this.$disposing == true)
        {
                return (bool)val_44;
        }
        
        this.$PC = 1;
        return (bool)val_44;
        label_102:
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
