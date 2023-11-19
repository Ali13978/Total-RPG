using UnityEngine;
private sealed class TextMeshProFloatingText.<DisplayTextMeshProFloatingText>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal float <CountDuration>__0;
    internal float <starting_Count>__0;
    internal float <current_Count>__0;
    internal UnityEngine.Vector3 <start_pos>__0;
    internal UnityEngine.Color32 <start_color>__0;
    internal float <alpha>__0;
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
    public TextMeshProFloatingText.<DisplayTextMeshProFloatingText>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_29;
        float val_30;
        float val_31;
        float val_32;
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
        int val_29 = this.$PC;
        this.$PC = 0;
        val_29 = (val_29 < 3) ? (val_29 + 3) : 0;
        if(val_29 == 3)
        {
            goto label_1;
        }
        
        if(val_29 == 5)
        {
            goto label_2;
        }
        
        val_29 = 0;
        if(val_29 != 4)
        {
                return (bool)val_29;
        }
        
        val_30 = this.<current_Count>__0;
        goto label_4;
        label_1:
        this.<CountDuration>__0 = 2f;
        float val_2 = UnityEngine.Random.Range(min:  5f, max:  20f);
        this.<starting_Count>__0 = val_2;
        this.<current_Count>__0 = val_2;
        UnityEngine.Vector3 val_3 = this.$this.m_floatingText_Transform.position;
        this.<start_pos>__0 = val_3;
        mem[1152921512524988688] = val_3.y;
        mem[1152921512524988692] = val_3.z;
        val_30 = this.<current_Count>__0;
        UnityEngine.Color32 val_4 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_3.x, g = val_3.y, b = val_3.z});
        this.<start_color>__0 = val_4;
        float val_31 = this.<CountDuration>__0;
        float val_30 = this.<starting_Count>__0;
        this.<alpha>__0 = 255f;
        val_30 = 3f / val_30;
        val_31 = val_30 * val_31;
        this.<fadeDuration>__0 = val_31;
        label_4:
        if(val_30 > 0f)
        {
            goto label_9;
        }
        
        val_31 = UnityEngine.Random.Range(min:  0.1f, max:  1f);
        this.$current = new UnityEngine.WaitForSeconds(seconds:  val_31);
        if(this.$disposing != true)
        {
                this.$PC = 2;
        }
        
        val_29 = 1;
        return (bool)val_29;
        label_2:
        val_31 = this.<start_pos>__0;
        this.$this.m_floatingText_Transform.position = new UnityEngine.Vector3() {x = val_31, y = V9.16B, z = V10.16B};
        if(this.$this == null)
        {
            goto label_14;
        }
        
        val_30 = this.$this.DisplayTextMeshProFloatingText();
        goto label_15;
        label_9:
        float val_8 = UnityEngine.Time.deltaTime;
        val_34 = this.<CountDuration>__0;
        val_35 = this.<starting_Count>__0;
        val_8 = val_8 / val_34;
        val_8 = val_8 * val_35;
        val_8 = val_30 - val_8;
        this.<current_Count>__0 = val_8;
        if(val_8 <= 3f)
        {
                float val_9 = UnityEngine.Time.deltaTime;
            val_35 = 255f;
            val_9 = val_9 / (this.<fadeDuration>__0);
            val_9 = val_9 * val_35;
            val_9 = (this.<alpha>__0) - val_9;
            val_34 = 0f;
            this.<alpha>__0 = UnityEngine.Mathf.Clamp(value:  val_9, min:  val_34, max:  val_35);
        }
        
        this.$this.m_textMeshPro.SetText(text:  "{0}", arg0:  (float)(int)val_30);
        UnityEngine.Color32 val_11 = (this.<start_color>__0) >> 16;
        UnityEngine.Color val_12 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
        UnityEngine.Vector3 val_13 = this.$this.m_floatingText_Transform.position;
        val_36 = this.<starting_Count>__0;
        float val_15 = val_36 * UnityEngine.Time.deltaTime;
        val_30 = 1152921504719785984;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.$this.m_floatingText_Transform.position = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
        val_37 = this.$this;
        if(this.$this == null)
        {
                val_37 = this.$this;
        }
        
        UnityEngine.Vector3 val_17 = this.$this.m_cameraTransform.position;
        val_39 = val_17.x;
        val_40 = this.$this.lastPOS;
        val_41 = val_16.y;
        val_42 = val_16.z;
        if((TMPro.TMPro_ExtensionMethods.Compare(v1:  new UnityEngine.Vector3() {x = val_40, y = val_41, z = val_42}, v2:  new UnityEngine.Vector3() {x = val_39, y = val_17.y, z = val_17.z}, accuracy:  0)) == false)
        {
            goto label_31;
        }
        
        val_43 = this.$this;
        if(this.$this == null)
        {
                val_43 = this.$this;
        }
        
        val_31 = this.$this.lastRotation;
        UnityEngine.Quaternion val_19 = this.$this.m_cameraTransform.rotation;
        val_40 = val_31;
        val_41 = val_16.y;
        val_42 = val_16.z;
        val_39 = val_36;
        if((TMPro.TMPro_ExtensionMethods.Compare(q1:  new UnityEngine.Quaternion() {x = val_40, y = val_41, z = val_42, w = val_39}, q2:  new UnityEngine.Quaternion() {x = val_19.x, y = val_19.y, z = val_19.z, w = val_19.w}, accuracy:  0)) == true)
        {
            goto label_35;
        }
        
        label_31:
        UnityEngine.Vector3 val_22 = this.$this.m_cameraTransform.position;
        this.$this.lastPOS = val_22;
        mem2[0] = val_22.y;
        mem2[0] = val_22.z;
        UnityEngine.Quaternion val_23 = this.$this.m_cameraTransform.rotation;
        this.$this.lastRotation = val_23;
        mem2[0] = val_23.y;
        mem2[0] = val_23.z;
        mem2[0] = val_23.w;
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
        this.$this.m_floatingText_Transform.rotation = new UnityEngine.Quaternion() {x = this.$this.lastRotation, y = val_16.y, z = val_16.z, w = val_36};
        UnityEngine.Vector3 val_24 = this.$this.m_transform.position;
        val_32 = val_24.z;
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_32}, b:  new UnityEngine.Vector3() {x = this.$this.lastPOS, y = V12.16B, z = val_36});
        val_31 = val_25.x;
        this.$this.m_transform.forward = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        label_35:
        val_29 = 1;
        this.$current = new UnityEngine.WaitForEndOfFrame();
        if(this.$disposing == true)
        {
                return (bool)val_29;
        }
        
        this.$PC = val_29;
        return (bool)val_29;
        label_14:
        val_30 = 0.DisplayTextMeshProFloatingText();
        label_15:
        UnityEngine.Coroutine val_28 = this.$this.StartCoroutine(routine:  val_30);
        val_29 = 0;
        this.$PC = 0;
        return (bool)val_29;
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
