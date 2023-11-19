using UnityEngine;
private sealed class CharacterMovementU.<clientUpdatePositionRoutine>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.GameFramework.FNetworkPredictionData_Client_Character <ClientData>__0;
    internal TzarGames.GameFramework.CharacterMovementU $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public CharacterMovementU.<clientUpdatePositionRoutine>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_5;
        TzarGames.GameFramework.CharacterMovementU val_6;
        int val_5 = this.$PC;
        this.$PC = 0;
        val_5 = ((val_5 == 1) ? 1 : 0) << 2;
        var val_2 = (val_5 == 0) ? 3 : (val_5);
        if(val_2 != 4)
        {
                val_5 = 0;
            if(val_2 != 3)
        {
                return (bool)val_5;
        }
        
            val_5 = 1;
            this.$current = new UnityEngine.WaitForFixedUpdate();
            if(this.$disposing == true)
        {
                return (bool)val_5;
        }
        
            this.$PC = val_5;
            return (bool)val_5;
        }
        
        val_6 = this.$this;
        if(this.$this != null)
        {
            goto label_5;
        }
        
        val_6 = this.$this;
        if(val_6 == null)
        {
            goto label_6;
        }
        
        label_5:
        this.$this.cachedTransform.position = new UnityEngine.Vector3() {x = this.$this.serverCorrectLocation, y = V9.16B, z = V10.16B};
        this.<ClientData>__0 = this.$this.GetPredictionData_Client_Character();
        val_5 = 0;
        val_4.bUpdatePosition = 1;
        this.$PC = 0;
        return (bool)val_5;
        label_6:
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
        if(null == 0)
        {
            goto label_1;
        }
        
        if(((mem[null] + 266) & 4) != 0)
        {
            goto label_2;
        }
        
        public System.Void CharacterMovementU.<clientUpdatePositionRoutine>c__Iterator0::Reset().__il2cppRuntimeField_FFFFFFFFFFFFFFFF = null;
        goto label_5;
        label_1:
        public System.Void CharacterMovementU.<clientUpdatePositionRoutine>c__Iterator0::Reset().__il2cppRuntimeField_FFFFFFFFFFFFFFFF = 0;
        goto label_5;
        label_2:
        label_5:
        public System.Void CharacterMovementU.<clientUpdatePositionRoutine>c__Iterator0::Reset().__il2cppRuntimeField_8 = System.NotSupportedException.__il2cppRuntimeField_gc_desc;
    }

}
