using UnityEngine;
private sealed class TurnBasedMatchConfig.<PlayerIdAtIndex>c__AnonStorey0
{
    // Fields
    internal UIntPtr index;
    internal GooglePlayGames.Native.PInvoke.TurnBasedMatchConfig $this;
    
    // Methods
    public TurnBasedMatchConfig.<PlayerIdAtIndex>c__AnonStorey0()
    {
    
    }
    internal UIntPtr <>m__0(byte[] out_string, UIntPtr size)
    {
        System.Runtime.InteropServices.HandleRef val_1 = this.$this.SelfPtr();
        return GooglePlayGames.Native.Cwrapper.TurnBasedMatchConfig.TurnBasedMatchConfig_PlayerIdsToInvite_GetElement(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, index:  val_1.handle, out_arg:  this.index, out_size:  out_string);
    }

}
