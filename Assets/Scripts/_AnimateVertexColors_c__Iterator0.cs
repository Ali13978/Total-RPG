using UnityEngine;
private sealed class VertexZoom.<AnimateVertexColors>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TMPro.TMP_TextInfo <textInfo>__0;
    internal TMPro.TMP_MeshInfo[] <cachedMeshInfoVertexData>__0;
    internal System.Collections.Generic.List<int> <scaleSortingOrder>__0;
    internal int <characterCount>__1;
    internal UnityEngine.Matrix4x4 <matrix>__2;
    internal TMPro.Examples.VertexZoom $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    private TMPro.Examples.VertexZoom.<AnimateVertexColors>c__Iterator0.<AnimateVertexColors>c__AnonStorey1 $locvar0;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public VertexZoom.<AnimateVertexColors>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        VertexZoom.<AnimateVertexColors>c__Iterator0 val_34;
        int val_35;
        TMPro.Examples.VertexZoom val_36;
        var val_37;
        var val_38;
        var val_39;
        val_34 = this;
        int val_80 = this.$PC;
        this.$PC = 0;
        int val_1 = val_80 + 3;
        val_80 = (val_80 < 3) ? (val_1) : 0;
        val_1 = val_80 - 4;
        if(val_1 >= 2)
        {
                val_35 = 0;
            if(val_80 != 3)
        {
                return (bool)val_35;
        }
        
            this.$locvar0 = new System.Object();
            typeof(VertexZoom.<AnimateVertexColors>c__Iterator0.<AnimateVertexColors>c__AnonStorey1).__il2cppRuntimeField_18 = val_34;
            TMPro.TMP_TextInfo val_3 = this.$this.m_TextComponent.textInfo;
            this.<textInfo>__0 = val_3;
            this.<cachedMeshInfoVertexData>__0 = val_3.CopyMeshInfoVertexData();
            this.$locvar0.modifiedCharScale = new System.Collections.Generic.List<System.Single>();
            val_36 = this.$this;
            this.<scaleSortingOrder>__0 = new System.Collections.Generic.List<System.Int32>();
            this.$this.hasTextChanged = true;
        }
        
        if(this.$this.hasTextChanged != false)
        {
                this.<cachedMeshInfoVertexData>__0 = this.<textInfo>__0.CopyMeshInfoVertexData();
            this.$this.hasTextChanged = false;
        }
        
        this.<characterCount>__1 = this.<textInfo>__0.characterCount;
        if((this.<textInfo>__0.characterCount) == 0)
        {
            goto label_16;
        }
        
        this.$locvar0.modifiedCharScale.Clear();
        this.<scaleSortingOrder>__0.Clear();
        if((this.<characterCount>__1) < 1)
        {
            goto label_20;
        }
        
        val_37 = 0;
        val_38 = 328;
        do
        {
            var val_8 = (this.<textInfo>__0.characterInfo) + (0 * 328);
            if(((0 * 328) + this.<textInfo>__0.characterInfo + 356) != 0)
        {
                var val_9 = (this.<textInfo>__0.characterInfo) + (0 * 328);
            var val_10 = (this.<textInfo>__0.characterInfo) + (0 * 328);
            var val_11 = (this.<cachedMeshInfoVertexData>__0) + (((0 * 328) + this.<textInfo>__0.characterInfo + 80) * 72);
            val_39 = mem[((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<cachedMeshInfoVertexData>__0 + 48 + 24];
            val_39 = ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<cachedMeshInfoVertexData>__0 + 48 + 24;
            if(((0 * 328) + this.<textInfo>__0.characterInfo + 96) >= val_39)
        {
                val_39 = mem[((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<cachedMeshInfoVertexData>__0 + 48 + 24];
            val_39 = ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<cachedMeshInfoVertexData>__0 + 48 + 24;
        }
        
            var val_12 = (((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<cachedMeshInfoVertexData>__0 + 48) + (((0 * 328) + this.<textInfo>__0.characterInfo + 96) * 12);
            var val_14 = (((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<cachedMeshInfoVertexData>__0 + 48) + (((long)((0 * 328) + this.<textInfo>__0.characterInfo + 96) + 2) * 12);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ((0 * 328) + this.<textInfo>__0.characterInfo + 96 * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<cachedMeshInfoVertexData>__0 + 48 + 32, y = ((0 * 328) + this.<textInfo>__0.characterInfo + 96 * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<cachedMeshInfoVertexData>__0 + 48 + 32 + 4, z = ((0 * 328) + this.<textInfo>__0.characterInfo + 96 * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<cachedMeshInfoVertexData>__0 + 48 + 32 + 8}, b:  new UnityEngine.Vector3() {x = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 2)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<cachedMeshInfoVertexData>__0 + 48 + 32, y = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 2)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<cachedMeshInfoVertexData>__0 + 48 + 32 + 4, z = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 2)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<cachedMeshInfoVertexData>__0 + 48 + 32 + 8});
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, d:  2f);
            UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
            UnityEngine.Vector3 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
            var val_19 = (this.<textInfo>__0.meshInfo) + (((0 * 328) + this.<textInfo>__0.characterInfo + 80) * 72);
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = ((0 * 328) + this.<textInfo>__0.characterInfo + 96 * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<cachedMeshInfoVertexData>__0 + 48 + 32, y = ((0 * 328) + this.<textInfo>__0.characterInfo + 96 * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<cachedMeshInfoVertexData>__0 + 48 + 32 + 4, z = ((0 * 328) + this.<textInfo>__0.characterInfo + 96 * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<cachedMeshInfoVertexData>__0 + 48 + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            var val_81 = 12;
            var val_21 = (((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<textInfo>__0.meshInfo + 48) + (((0 * 328) + this.<textInfo>__0.characterInfo + 96) * val_81);
            mem2[0] = val_20.x;
            mem2[0] = val_20.y;
            mem2[0] = val_20.z;
            var val_23 = (((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<cachedMeshInfoVertexData>__0 + 48) + (((long)((0 * 328) + this.<textInfo>__0.characterInfo + 96) + 1) * val_81);
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 1)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<cachedMeshInfoVertexData>__0 + 48 + 32, y = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 1)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<cachedMeshInfoVertexData>__0 + 48 + 32 + 4, z = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 1)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<cachedMeshInfoVertexData>__0 + 48 + 40}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            val_81 = (((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<textInfo>__0.meshInfo + 48) + (((long)((0 * 328) + this.<textInfo>__0.characterInfo + 96) + 1) * val_81);
            mem2[0] = val_24.x;
            mem2[0] = val_24.y;
            mem2[0] = val_24.z;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 2)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<cachedMeshInfoVertexData>__0 + 48 + 32, y = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 2)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<cachedMeshInfoVertexData>__0 + 48 + 32 + 4, z = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 2)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<cachedMeshInfoVertexData>__0 + 48 + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            var val_26 = (((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<textInfo>__0.meshInfo + 48) + (((long)((0 * 328) + this.<textInfo>__0.characterInfo + 96) + 2) * 12);
            var val_82 = (0 * 328) + this.<textInfo>__0.characterInfo + 96;
            mem2[0] = val_25.x;
            mem2[0] = val_25.y;
            mem2[0] = val_25.z;
            val_82 = val_82 + 3;
            var val_27 = (((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<cachedMeshInfoVertexData>__0 + 48) + ((long)val_82 * 12);
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 3)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<cachedMeshInfoVertexData>__0 + 48 + 32, y = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 3)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<cachedMeshInfoVertexData>__0 + 48 + 32 + 4, z = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 3)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<cachedMeshInfoVertexData>__0 + 48 + 40}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            var val_29 = (((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<textInfo>__0.meshInfo + 48) + ((long)val_82 * 12);
            mem2[0] = val_28.x;
            mem2[0] = val_28.y;
            mem2[0] = val_28.z;
            float val_30 = UnityEngine.Random.Range(min:  1f, max:  1.5f);
            this.$locvar0.modifiedCharScale.Add(item:  val_30);
            this.<scaleSortingOrder>__0.Add(item:  this.$locvar0.modifiedCharScale.Count - 1);
            UnityEngine.Quaternion val_33 = UnityEngine.Quaternion.identity;
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z}, d:  val_30);
            UnityEngine.Matrix4x4 val_36 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, q:  new UnityEngine.Quaternion() {x = val_33.x, y = val_33.y, z = val_33.z, w = val_33.w}, s:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.z});
            mem2[0] = val_37;
            mem2[0] = val_38;
            mem2[0] = val_39;
            mem2[0] = val_40;
            mem2[0] = ((0 * 328) + this.<textInfo>__0.characterInfo + 96 * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<textInfo>__0.meshInfo + 48 + 32;
            mem2[0] = ((0 * 328) + this.<textInfo>__0.characterInfo + 96 * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<textInfo>__0.meshInfo + 48 + 36;
            mem2[0] = ((0 * 328) + this.<textInfo>__0.characterInfo + 96 * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<textInfo>__0.meshInfo + 48 + 40;
            mem2[0] = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 1)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<textInfo>__0.meshInfo + 48 + 32;
            mem2[0] = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 1)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<textInfo>__0.meshInfo + 48 + 36;
            mem2[0] = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 1)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<textInfo>__0.meshInfo + 48 + 40;
            val_34 = val_34;
            mem2[0] = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 2)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<textInfo>__0.meshInfo + 48 + 32;
            mem2[0] = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 2)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<textInfo>__0.meshInfo + 48 + 36;
            mem2[0] = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 2)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<textInfo>__0.meshInfo + 48 + 40;
            mem2[0] = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 3)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<textInfo>__0.meshInfo + 48 + 32;
            mem2[0] = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 3)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<textInfo>__0.meshInfo + 48 + 36;
            mem2[0] = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 3)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<textInfo>__0.meshInfo + 48 + 40;
            UnityEngine.Vector3 val_41 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ((0 * 328) + this.<textInfo>__0.characterInfo + 96 * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<textInfo>__0.meshInfo + 48 + 32, y = ((0 * 328) + this.<textInfo>__0.characterInfo + 96 * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<textInfo>__0.meshInfo + 48 + 36, z = ((0 * 328) + this.<textInfo>__0.characterInfo + 96 * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<textInfo>__0.meshInfo + 48 + 40}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            mem2[0] = val_41.x;
            mem2[0] = val_41.y;
            mem2[0] = val_41.z;
            UnityEngine.Vector3 val_42 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 1)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<textInfo>__0.meshInfo + 48 + 32, y = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 1)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<textInfo>__0.meshInfo + 48 + 36, z = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 1)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<textInfo>__0.meshInfo + 48 + 40}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            mem2[0] = val_42.x;
            mem2[0] = val_42.y;
            mem2[0] = val_42.z;
            UnityEngine.Vector3 val_43 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 2)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<textInfo>__0.meshInfo + 48 + 32, y = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 2)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<textInfo>__0.meshInfo + 48 + 36, z = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 2)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<textInfo>__0.meshInfo + 48 + 40}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            mem2[0] = val_43.x;
            mem2[0] = val_43.y;
            mem2[0] = val_43.z;
            UnityEngine.Vector3 val_44 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 3)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<textInfo>__0.meshInfo + 48 + 32, y = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 3)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<textInfo>__0.meshInfo + 48 + 36, z = ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 3)) * 12) + ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + this.<textInfo>__0.meshInfo + 48 + 40}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            mem2[0] = val_44.x;
            mem2[0] = val_44.y;
            mem2[0] = val_44.z;
            var val_45 = (this.<cachedMeshInfoVertexData>__0) + (((0 * 328) + this.<textInfo>__0.characterInfo + 80) * 72);
            var val_46 = val_3.meshInfo + (((0 * 328) + this.<textInfo>__0.characterInfo + 80) * 72);
            var val_83 = ((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + val_3.meshInfo + 72;
            var val_48 = (val_83 + (((0 * 328) + this.<textInfo>__0.characterInfo + 96) << 3)) + 32;
            var val_49 = (((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + val_7 + 72) + (((0 * 328) + this.<textInfo>__0.characterInfo + 96) << 3);
            mem2[0] = (((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + val_7 + 72 + ((0 * 328) + this.<textInfo>__0.characterInfo + 96) << 3) + 32;
            var val_51 = (val_83 + (((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 1))) << 3)) + 32;
            var val_52 = (((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + val_7 + 72) + (((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 1))) << 3);
            mem2[0] = (((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + val_7 + 72 + ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 1))) << 3) + 32;
            var val_54 = (val_83 + (((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 2))) << 3)) + 32;
            var val_55 = (((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + val_7 + 72) + (((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 2))) << 3);
            mem2[0] = (((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + val_7 + 72 + ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 2))) << 3) + 32;
            val_37 = val_37;
            val_83 = (val_83 + (((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 3))) << 3)) + 32;
            var val_57 = (((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + val_7 + 72) + (((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 3))) << 3);
            mem2[0] = (((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + val_7 + 72 + ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 3))) << 3) + 32;
            var val_58 = (this.<cachedMeshInfoVertexData>__0) + (((0 * 328) + this.<textInfo>__0.characterInfo + 80) * 72);
            var val_59 = val_3.meshInfo + (((0 * 328) + this.<textInfo>__0.characterInfo + 80) * 72);
            var val_60 = (((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + val_7 + 88) + (((0 * 328) + this.<textInfo>__0.characterInfo + 96) << 2);
            var val_61 = (((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + val_3.meshInfo + 88) + (((0 * 328) + this.<textInfo>__0.characterInfo + 96) << 2);
            mem2[0] = (((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + val_7 + 88 + ((0 * 328) + this.<textInfo>__0.characterInfo + 96) << 2) + 32;
            var val_62 = (((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + val_7 + 88) + (((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 1))) << 2);
            var val_63 = (((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + val_3.meshInfo + 88) + (((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 1))) << 2);
            mem2[0] = (((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + val_7 + 88 + ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 1))) << 2) + 32;
            val_38 = 328;
            var val_64 = (((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + val_7 + 88) + (((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 2))) << 2);
            var val_65 = (((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + val_3.meshInfo + 88) + (((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 2))) << 2);
            mem2[0] = (((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + val_7 + 88 + ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 2))) << 2) + 32;
            var val_66 = (((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + val_7 + 88) + (((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 3))) << 2);
            var val_67 = (((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + val_3.meshInfo + 88) + (((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 3))) << 2);
            mem2[0] = (((0 * 328) + this.<textInfo>__0.characterInfo + 80 * 72) + val_7 + 88 + ((long)(int)(((0 * 328) + this.<textInfo>__0.characterInfo + 96 + 3))) << 2) + 32;
        }
        
            val_36 = 0;
            val_37 = val_37 + 1;
        }
        while(val_37 < (this.<characterCount>__1));
        
        goto label_115;
        label_16:
        val_35 = 1;
        this.$current = new UnityEngine.WaitForSeconds(seconds:  0.25f);
        if(this.$disposing == true)
        {
                return (bool)val_35;
        }
        
        this.$PC = val_35;
        return (bool)val_35;
        label_20:
        val_36 = 0;
        goto label_115;
        label_149:
        val_36 = 1;
        label_115:
        if(val_36 >= (this.<textInfo>__0.meshInfo.Length))
        {
            goto label_118;
        }
        
        this.<scaleSortingOrder>__0.Sort(comparison:  new System.Comparison<System.Int32>(object:  this.$locvar0, method:  System.Int32 VertexZoom.<AnimateVertexColors>c__Iterator0.<AnimateVertexColors>c__AnonStorey1::<>m__0(int a, int b)));
        var val_71 = ((this.<textInfo>__0.meshInfo) + (1 * 72)) + 32;
        var val_72 = (this.<textInfo>__0.meshInfo) + (1 * 72);
        var val_73 = (this.<textInfo>__0.meshInfo) + (1 * 72);
        (1 * 72) + this.<textInfo>__0.meshInfo + 32.vertices = (1 * 72) + this.<textInfo>__0.meshInfo + 48;
        var val_74 = (this.<textInfo>__0.meshInfo) + (1 * 72);
        var val_75 = (this.<textInfo>__0.meshInfo) + (1 * 72);
        (1 * 72) + this.<textInfo>__0.meshInfo + 32.uv = (1 * 72) + this.<textInfo>__0.meshInfo + 72;
        var val_76 = (this.<textInfo>__0.meshInfo) + (1 * 72);
        var val_77 = (this.<textInfo>__0.meshInfo) + (1 * 72);
        (1 * 72) + this.<textInfo>__0.meshInfo + 32.colors32 = (1 * 72) + this.<textInfo>__0.meshInfo + 88;
        var val_78 = (this.<textInfo>__0.meshInfo) + (1 * 72);
        if(this.$this.m_TextComponent != null)
        {
            goto label_149;
        }
        
        goto label_149;
        label_118:
        this.$current = new UnityEngine.WaitForSeconds(seconds:  0.1f);
        if(this.$disposing != true)
        {
                this.$PC = 2;
        }
        
        val_35 = 1;
        return (bool)val_35;
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
