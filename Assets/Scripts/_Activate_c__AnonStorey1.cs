using UnityEngine;
private sealed class Way.<Activate>c__AnonStorey1
{
    // Fields
    internal TzarGames.Endless.Gate nextGate;
    internal TzarGames.Endless.Gate gate;
    internal TzarGames.Endless.Way $this;
    
    // Methods
    public Way.<Activate>c__AnonStorey1()
    {
    
    }
    internal void <>m__0()
    {
        this.nextGate.SetBlocked(blocked:  false);
    }
    internal void <>m__1()
    {
        if(0 == this.gate)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
        {
                return;
        }
        
        this.gate.SetBlocked(blocked:  false);
    }
    internal void <>m__2()
    {
        CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
        this.$this.isWayFinished = val_1;
        mem2[0] = val_1.inited;
        mem[1] = val_1.fakeValue;
        mem[2] = val_1.fakeValueActive;
        this.$this.finishTrigger.gameObject.SetActive(value:  true);
    }

}
