using UnityEngine;
private sealed class MoveCharacterToPosition.<moveRoutine>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.TzarHero.TH_Character currentCharacter;
    internal UnityEngine.Vector3 position;
    internal System.Action<bool> callback;
    internal TzarGames.Endless.MoveCharacterToPosition $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    private TzarGames.Endless.MoveCharacterToPosition.<moveRoutine>c__Iterator1.<moveRoutine>c__AnonStorey2 $locvar0;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public MoveCharacterToPosition.<moveRoutine>c__Iterator1()
    {
    
    }
    public bool MoveNext()
    {
        int val_6;
        System.Action<System.Boolean> val_7;
        int val_6 = this.$PC;
        this.$PC = 0;
        val_6 = ((val_6 == 1) ? 1 : 0) << 2;
        var val_2 = (val_6 == 0) ? 3 : (val_6);
        if(val_2 != 4)
        {
                val_6 = 0;
            if(val_2 != 3)
        {
                return (bool)val_6;
        }
        
            this.$locvar0 = new System.Object();
            typeof(MoveCharacterToPosition.<moveRoutine>c__Iterator1.<moveRoutine>c__AnonStorey2).__il2cppRuntimeField_18 = this;
            val_7 = this.callback;
            this.$locvar0.callback = val_7;
            val_6 = 1;
            this.$current = 0;
            if(this.$disposing == true)
        {
                return (bool)val_6;
        }
        
            this.$PC = val_6;
            return (bool)val_6;
        }
        
        this.$this.moveCoroutine = 0;
        this.currentCharacter.StopAttack();
        this.currentCharacter.Target = 0;
        this.currentCharacter.ResetToDefaultState();
        System.Action<TzarGames.TzarHero.TH_Character, System.Boolean> val_4 = null;
        val_7 = val_4;
        val_4 = new System.Action<TzarGames.TzarHero.TH_Character, System.Boolean>(object:  this.$locvar0, method:  System.Void MoveCharacterToPosition.<moveRoutine>c__Iterator1.<moveRoutine>c__AnonStorey2::<>m__0(TzarGames.TzarHero.TH_Character ch, bool result));
        bool val_5 = this.currentCharacter.GoToPosition(targetPosition:  new UnityEngine.Vector3() {x = this.position, y = V9.16B, z = V10.16B}, reachPositionHandler:  val_7, stoppingDistance:  0f);
        val_6 = 0;
        this.$PC = 0;
        return (bool)val_6;
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
