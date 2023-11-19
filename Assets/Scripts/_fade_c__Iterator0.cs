using UnityEngine;
private sealed class MaterialFader.<fade>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal System.Collections.Generic.List<UnityEngine.Material> <materialsList>__0;
    internal float <currentAlpha>__0;
    internal bool setCustomStartFade;
    internal float customStartFade;
    internal float <startFade>__1;
    internal float timeTofade;
    internal float <fadeSpeedMult>__2;
    internal bool <working>__0;
    internal float targetFade;
    internal float <currentFading>__3;
    internal bool doRevertMaterials;
    internal TzarGames.Endless.MaterialFader $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public MaterialFader.<fade>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        TzarGames.Endless.MaterialFader val_17;
        int val_18;
        var val_19;
        var val_20;
        UnityEngine.Material val_21;
        var val_22;
        float val_23;
        float val_24;
        var val_25;
        val_17 = this;
        int val_17 = this.$PC;
        this.$PC = 0;
        val_17 = ((val_17 == 1) ? 1 : 0) << 2;
        var val_2 = (val_17 == 0) ? 3 : (val_17);
        if(val_2 == 4)
        {
            goto label_1;
        }
        
        val_18 = 0;
        if(val_2 != 3)
        {
                return (bool)val_18;
        }
        
        val_19 = 0;
        this.<materialsList>__0 = this.$this.newMaterials;
        goto label_4;
        label_43:
        val_19 = 1;
        label_4:
        if(val_19 >= this.$this.renderers.Length)
        {
            goto label_7;
        }
        
        if(val_3.Length == 0)
        {
            goto label_43;
        }
        
        val_20 = 0;
        goto label_14;
        label_41:
        val_20 = 1;
        label_14:
        val_21 = this.$this.renderers[1].sharedMaterials[1];
        this.$this.renderers[1].sharedMaterials[1] = this.<materialsList>__0.Contains(item:  val_21);
        if(this.$this.renderers[1].sharedMaterials[1] == true)
        {
            goto label_20;
        }
        
        UnityEngine.Material val_5 = this.$this.getReplacement(original:  val_21);
        if(0 != val_5)
        {
                if(0 != val_5)
        {
            goto label_27;
        }
        
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_20 = val_21;
        UnityEngine.Debug.LogErrorFormat(format:  0, args:  "Replacement material not found for {0}");
        goto label_41;
        label_27:
        UnityEngine.Material val_9 = null;
        val_21 = val_9;
        val_9 = new UnityEngine.Material(source:  val_5);
        this.<materialsList>__0.Add(item:  val_21);
        label_20:
        UnityEngine.Material[].__il2cppRuntimeField_gc_desc.__il2cppRuntimeField_20 = val_21;
        this.<materialsList>__0.Add(item:  val_21);
        goto label_41;
        label_1:
        val_22 = val_17;
        if((this.<working>__0) == true)
        {
            goto label_44;
        }
        
        goto label_65;
        label_7:
        if((this.<materialsList>__0.Count) == 0)
        {
            goto label_47;
        }
        
        this.<currentAlpha>__0 = 0f;
        if(this.setCustomStartFade == false)
        {
            goto label_48;
        }
        
        this.<startFade>__1 = this.customStartFade;
        goto label_49;
        label_47:
        val_17 = this.$this;
        val_18 = 0;
        this.$this.fadingRoutine = 0;
        return (bool)val_18;
        label_48:
        this.<startFade>__1 = this.<materialsList>__0.Item[0].GetFloat(name:  "_Fading");
        label_49:
        if(this.timeTofade > 0f)
        {
                val_23 = 1f / this.timeTofade;
        }
        else
        {
                val_23 = 0f;
            this.<currentAlpha>__0 = 1f;
        }
        
        val_22 = val_17;
        this.<fadeSpeedMult>__2 = val_23;
        this.<working>__0 = true;
        label_44:
        float val_13 = UnityEngine.Time.deltaTime;
        val_13 = val_13 * (this.<fadeSpeedMult>__2);
        val_24 = (this.<currentAlpha>__0) + val_13;
        this.<currentAlpha>__0 = val_24;
        if(val_24 >= 1f)
        {
                val_24 = 1f;
            this.<currentAlpha>__0 = 1f;
            this.<working>__0 = false;
        }
        
        this.<currentFading>__3 = UnityEngine.Mathf.Lerp(a:  this.<startFade>__1, b:  this.targetFade, t:  val_24);
        val_19 = 1152921511100713136;
        val_25 = 0;
        goto label_59;
        label_64:
        X21.SetFloat(name:  "_Fading", value:  val_24);
        val_25 = 1;
        label_59:
        if(val_25 >= (this.<materialsList>__0.Count))
        {
            goto label_61;
        }
        
        if((this.<materialsList>__0.Item[1]) != null)
        {
            goto label_64;
        }
        
        goto label_64;
        label_61:
        if((this.<working>__0) != false)
        {
                val_18 = 1;
            this.$current = 0;
            if(this.$disposing == true)
        {
                return (bool)val_18;
        }
        
            this.$PC = val_18;
            return (bool)val_18;
        }
        
        label_65:
        if(this.doRevertMaterials != false)
        {
                this.$this.revertMaterials();
        }
        
        val_18 = 0;
        this.$this.fadingRoutine = 0;
        this.$PC = 0;
        return (bool)val_18;
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
