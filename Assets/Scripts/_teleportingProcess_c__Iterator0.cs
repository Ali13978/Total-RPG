using UnityEngine;
private sealed class Teleport.<teleportingProcess>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.GameFramework.PathfinderBase <pathfinder>__0;
    internal UnityEngine.Vector3 <characterForward>__0;
    internal UnityEngine.Vector3 <direction>__0;
    internal UnityEngine.Vector3 <characterGroundPos>__0;
    internal TzarGames.TzarHero.TH_InteractiveObject <target>__0;
    internal bool <doRandomAngle>__0;
    internal float <initialAngle>__0;
    internal int <angleStep>__0;
    internal int <steps>__0;
    internal UnityEngine.Vector3 <resultPosition>__0;
    internal bool <canTeleport>__0;
    internal int <i>__1;
    internal float <angle>__2;
    internal UnityEngine.Quaternion <angleRot>__2;
    internal UnityEngine.Vector3 <shift>__2;
    internal UnityEngine.Vector3 <targetPos>__2;
    internal UnityEngine.Vector3 <currentNearestPosition>__2;
    internal TzarGames.Endless.Skills.Teleport $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public Teleport.<teleportingProcess>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        int val_37;
        int val_37 = this.$PC;
        val_37 = 0;
        this.$PC = 0;
        val_37 = (val_37 < 7) ? (val_37 + 3) : 0;
        val_37 = val_37 - 3;
        if(val_37 > 6)
        {
                return (bool);
        }
        
        var val_38 = 25486528 + ((this.$PC < 7 ? (this.$PC + 3) : 0 - 3)) << 2;
        val_38 = val_38 + 25486528;
        goto (25486528 + ((this.$PC < 7 ? (this.$PC + 3) : 0 - 3)) << 2 + 25486528);
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
