using UnityEngine;
private sealed class TextMeshProFloatingText.<DisplayTextMeshFloatingText>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal float <CountDuration>__0;
    internal float <starting_Count>__0;
    internal float <current_Count>__0;
    internal UnityEngine.Vector3 <start_pos>__0;
    internal UnityEngine.Color32 <start_color>__0;
    internal float <alpha>__0;
    internal int <int_counter>__0;
    internal float <fadeDuration>__0;
    internal TMPro.Examples.TextMeshProFloatingText $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public TextMeshProFloatingText.<DisplayTextMeshFloatingText>c__Iterator1()
    {
    
    }
    public bool MoveNext()
    {
        int val_30;
        float val_31;
        float val_32;
        float val_33;
        float val_34;
        float val_35;
        float val_36;
        TMPro.Examples.TextMeshProFloatingText val_37;
        float val_39;
        float val_40;
        float val_41;
        float val_42;
        TMPro.Examples.TextMeshProFloatingText val_43;
        TMPro.Examples.TextMeshProFloatingText val_44;
        int val_30 = this.$PC;
        this.$PC = 0;
        val_30 = (val_30 < 3) ? (val_30 + 3) : 0;
        if(val_30 == 3)
        {
            goto label_1;
        }
        
        if(val_30 == 5)
        {
            goto label_2;
        }
        
        val_30 = 0;
        if(val_30 != 4)
        {
                return (bool)val_30;
        }
        
        val_31 = this.<current_Count>__0;
        goto label_4;
        label_1:
        this.<CountDuration>__0 = 2f;
        float val_2 = UnityEngine.Random.Range(min:  5f, max:  20f);
        this.<starting_Count>__0 = val_2;
        this.<current_Count>__0 = val_2;
        UnityEngine.Vector3 val_3 = this.$this.m_floatingText_Transform.position;
        this.<start_pos>__0 = val_3;
        mem[1152921512525952528] = val_3.y;
        mem[1152921512525952532] = val_3.z;
        val_31 = this.<current_Count>__0;
        UnityEngine.Color val_4 = this.$this.m_textMesh.color;
        UnityEngine.Color32 val_5 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a});
        this.<start_color>__0 = val_5;
        float val_32 = this.<CountDuration>__0;
        float val_31 = this.<starting_Count>__0;
        this.<alpha>__0 = 255f;
        this.<int_counter>__0 = 0;
        val_31 = 3f / val_31;
        val_32 = val_31 * val_32;
        this.<fadeDuration>__0 = val_32;
        label_4:
        if(val_31 > 0f)
        {
            goto label_9;
        }
        
        val_32 = UnityEngine.Random.Range(min:  0.1f, max:  1f);
        this.$current = new UnityEngine.WaitForSeconds(seconds:  val_32);
        if(this.$disposing != true)
        {
                this.$PC = 2;
        }
        
        val_30 = 1;
        return (bool)val_30;
        label_2:
        val_32 = this.<start_pos>__0;
        this.$this.m_floatingText_Transform.position = new UnityEngine.Vector3() {x = val_32, y = V9.16B, z = V10.16B};
        if(this.$this == null)
        {
            goto label_14;
        }
        
        val_31 = this.$this.DisplayTextMeshFloatingText();
        goto label_15;
        label_9:
        float val_9 = UnityEngine.Time.deltaTime;
        val_34 = this.<starting_Count>__0;
        val_9 = val_9 / (this.<CountDuration>__0);
        val_9 = val_9 * val_34;
        val_35 = val_31 - val_9;
        this.<current_Count>__0 = val_35;
        if(val_35 <= 3f)
        {
                float val_10 = UnityEngine.Time.deltaTime;
            val_34 = 255f;
            val_10 = val_10 / (this.<fadeDuration>__0);
            val_10 = val_10 * val_34;
            val_10 = (this.<alpha>__0) - val_10;
            val_35 = this.<current_Count>__0;
            this.<alpha>__0 = UnityEngine.Mathf.Clamp(value:  val_10, min:  0f, max:  val_34);
        }
        
        this.<int_counter>__0 = (int)val_35;
        this.$this.m_textMesh.text = this.<int_counter>__0;
        UnityEngine.Color32 val_12 = (this.<start_color>__0) >> 16;
        UnityEngine.Color val_13 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
        this.$this.m_textMesh.color = new UnityEngine.Color() {r = val_13.r, g = val_13.g, b = val_13.b, a = val_13.a};
        UnityEngine.Vector3 val_14 = this.$this.m_floatingText_Transform.position;
        val_36 = this.<starting_Count>__0;
        float val_16 = val_36 * UnityEngine.Time.deltaTime;
        val_31 = 1152921504719785984;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.$this.m_floatingText_Transform.position = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
        val_37 = this.$this;
        if(this.$this == null)
        {
                val_37 = this.$this;
        }
        
        UnityEngine.Vector3 val_18 = this.$this.m_cameraTransform.position;
        val_39 = val_18.x;
        val_40 = this.$this.lastPOS;
        val_41 = val_17.y;
        val_42 = val_17.z;
        if((TMPro.TMPro_ExtensionMethods.Compare(v1:  new UnityEngine.Vector3() {x = val_40, y = val_41, z = val_42}, v2:  new UnityEngine.Vector3() {x = val_39, y = val_18.y, z = val_18.z}, accuracy:  0)) == false)
        {
            goto label_31;
        }
        
        val_43 = this.$this;
        if(this.$this == null)
        {
                val_43 = this.$this;
        }
        
        val_32 = this.$this.lastRotation;
        UnityEngine.Quaternion val_20 = this.$this.m_cameraTransform.rotation;
        val_40 = val_32;
        val_41 = val_17.y;
        val_42 = val_17.z;
        val_39 = val_36;
        if((TMPro.TMPro_ExtensionMethods.Compare(q1:  new UnityEngine.Quaternion() {x = val_40, y = val_41, z = val_42, w = val_39}, q2:  new UnityEngine.Quaternion() {x = val_20.x, y = val_20.y, z = val_20.z, w = val_20.w}, accuracy:  0)) == true)
        {
            goto label_35;
        }
        
        label_31:
        UnityEngine.Vector3 val_23 = this.$this.m_cameraTransform.position;
        this.$this.lastPOS = val_23;
        mem2[0] = val_23.y;
        mem2[0] = val_23.z;
        UnityEngine.Quaternion val_24 = this.$this.m_cameraTransform.rotation;
        this.$this.lastRotation = val_24;
        mem2[0] = val_24.y;
        mem2[0] = val_24.z;
        mem2[0] = val_24.w;
        val_44 = this.$this;
        if(this.$this != null)
        {
            goto label_40;
        }
        
        val_44 = this.$this;
        if(val_44 == null)
        {
            goto label_41;
        }
        
        label_40:
        this.$this.m_floatingText_Transform.rotation = new UnityEngine.Quaternion() {x = this.$this.lastRotation, y = val_17.y, z = val_17.z, w = val_36};
        UnityEngine.Vector3 val_25 = this.$this.m_transform.position;
        val_33 = val_25.z;
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_33}, b:  new UnityEngine.Vector3() {x = this.$this.lastPOS, y = V12.16B, z = val_36});
        val_32 = val_26.x;
        this.$this.m_transform.forward = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        label_35:
        val_30 = 1;
        this.$current = new UnityEngine.WaitForEndOfFrame();
        if(this.$disposing == true)
        {
                return (bool)val_30;
        }
        
        this.$PC = val_30;
        return (bool)val_30;
        label_14:
        val_31 = 0.DisplayTextMeshFloatingText();
        label_15:
        UnityEngine.Coroutine val_29 = this.$this.StartCoroutine(routine:  val_31);
        val_30 = 0;
        this.$PC = 0;
        return (bool)val_30;
        label_41:
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
