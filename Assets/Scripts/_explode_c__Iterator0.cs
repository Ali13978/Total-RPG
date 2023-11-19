using UnityEngine;
private sealed class ExplosionPhysicsForce.<explode>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal UnityEngine.Collider[] <cols>__0;
    internal System.Collections.Generic.List<UnityEngine.Rigidbody> <rigidbodies>__0;
    internal UnityEngine.Collider[] $locvar0;
    internal int $locvar1;
    internal System.Collections.Generic.List.Enumerator<UnityEngine.Rigidbody> $locvar2;
    internal TzarGames.GameFramework.ExplosionPhysicsForce $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public ExplosionPhysicsForce.<explode>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        var val_15;
        List.Enumerator<UnityEngine.Rigidbody> val_16;
        int val_23;
        TzarGames.GameFramework.ExplosionPhysicsForce val_24;
        float val_25;
        UnityEngine.Collider[] val_26;
        int val_27;
        TzarGames.GameFramework.ExplosionPhysicsForce val_28;
        float val_29;
        TzarGames.GameFramework.ExplosionPhysicsForce val_30;
        float val_31;
        int val_22 = this.$PC;
        this.$PC = 0;
        val_22 = ((val_22 == 1) ? 1 : 0) << 2;
        var val_2 = (val_22 == 0) ? 3 : (val_22);
        if(val_2 != 4)
        {
                val_23 = 0;
            if(val_2 != 3)
        {
                return (bool)val_23;
        }
        
            val_23 = 1;
            this.$current = 0;
            if(this.$disposing == true)
        {
                return (bool)val_23;
        }
        
            this.$PC = val_23;
            return (bool)val_23;
        }
        
        UnityEngine.Vector3 val_4 = this.$this.transform.position;
        val_24 = this.$this;
        if(val_24 != null)
        {
                val_25 = this.$this.Radius;
        }
        else
        {
                val_25 = this.$this.Radius;
            if(this.$this != null)
        {
                val_24 = this.$this;
        }
        else
        {
                val_24 = 0;
        }
        
        }
        
        int val_5 = 32.value;
        this.<cols>__0 = UnityEngine.Physics.OverlapSphere(position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, radius:  val_25, layerMask:  0);
        val_26 = this.<cols>__0;
        this.<rigidbodies>__0 = new System.Collections.Generic.List<UnityEngine.Rigidbody>();
        this.$locvar0 = val_26;
        val_27 = 0;
        goto label_11;
        label_25:
        val_26 = this.$locvar0;
        val_27 = this.$locvar1 + 1;
        label_11:
        this.$locvar1 = val_27;
        if(val_27 >= this.$locvar0.Length)
        {
            goto label_13;
        }
        
        UnityEngine.Collider val_23 = this.$locvar0[this.$locvar1];
        if((0 == val_23.attachedRigidbody) || ((this.<rigidbodies>__0.Contains(item:  val_23.attachedRigidbody)) == true))
        {
            goto label_25;
        }
        
        this.<rigidbodies>__0.Add(item:  val_23.attachedRigidbody);
        goto label_25;
        label_13:
        List.Enumerator<T> val_14 = this.<rigidbodies>__0.GetEnumerator();
        mem[1152921511324518800] = val_15;
        this.$locvar2 = val_16;
        label_39:
        if(((this.$locvar2 & 1) & 1) == 0)
        {
            goto label_42;
        }
        
        val_28 = this.$this;
        if(val_28 == null)
        {
            goto label_28;
        }
        
        val_29 = this.$this.ExplosionForce;
        goto label_29;
        label_28:
        val_29 = this.$this.ExplosionForce;
        if(this.$this == null)
        {
            goto label_30;
        }
        
        val_28 = this.$this;
        label_29:
        label_37:
        UnityEngine.Vector3 val_20 = val_28.transform.position;
        val_30 = this.$this;
        if(val_30 == null)
        {
            goto label_32;
        }
        
        val_31 = this.$this.Radius;
        goto label_35;
        label_32:
        val_31 = this.$this.Radius;
        if(this.$this == null)
        {
            goto label_34;
        }
        
        val_30 = this.$this;
        goto label_35;
        label_30:
        if(this.$this != null)
        {
            goto label_37;
        }
        
        goto label_37;
        label_34:
        val_30 = 0;
        label_35:
        this.$locvar2.InitializationCallback.AddExplosionForce(explosionForce:  val_29 * this.$this.Radius, explosionPosition:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, explosionRadius:  val_31, upwardsModifier:  0f, mode:  1);
        goto label_39;
        label_42:
        this.$locvar2.Dispose();
        val_23 = 0;
        this.$PC = 0;
        return (bool)val_23;
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
