using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class TurnBasedMatchConfig : BaseReferenceHolder
    {
        // Methods
        internal TurnBasedMatchConfig(IntPtr selfPointer)
        {
        
        }
        private string PlayerIdAtIndex(UIntPtr index)
        {
            if(null != 0)
            {
                    typeof(TurnBasedMatchConfig.<PlayerIdAtIndex>c__AnonStorey0).__il2cppRuntimeField_10 = index;
            }
            else
            {
                    mem[16] = index;
            }
            
            typeof(TurnBasedMatchConfig.<PlayerIdAtIndex>c__AnonStorey0).__il2cppRuntimeField_18 = this;
            typeof(PInvokeUtilities.OutStringMethod).__il2cppRuntimeField_20 = new System.Object();
            typeof(PInvokeUtilities.OutStringMethod).__il2cppRuntimeField_28 = System.UIntPtr TurnBasedMatchConfig.<PlayerIdAtIndex>c__AnonStorey0::<>m__0(byte[] out_string, UIntPtr size);
            typeof(PInvokeUtilities.OutStringMethod).__il2cppRuntimeField_10 = System.UIntPtr TurnBasedMatchConfig.<PlayerIdAtIndex>c__AnonStorey0::<>m__0(byte[] out_string, UIntPtr size);
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  null);
        }
        internal System.Collections.Generic.IEnumerator<string> PlayerIdsToInvite()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            System.Func<System.UIntPtr, System.String> val_3 = new System.Func<System.UIntPtr, System.String>(object:  this, method:  System.String GooglePlayGames.Native.PInvoke.TurnBasedMatchConfig::PlayerIdAtIndex(UIntPtr index));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.ToEnumerator<System.String>(size:  0, getElement:  GooglePlayGames.Native.Cwrapper.TurnBasedMatchConfig.TurnBasedMatchConfig_PlayerIdsToInvite_Length(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
        }
        internal uint Variant()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.TurnBasedMatchConfig.TurnBasedMatchConfig_Variant(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal long ExclusiveBitMask()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.TurnBasedMatchConfig.TurnBasedMatchConfig_ExclusiveBitMask(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal uint MinimumAutomatchingPlayers()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.TurnBasedMatchConfig.TurnBasedMatchConfig_MinimumAutomatchingPlayers(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal uint MaximumAutomatchingPlayers()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.TurnBasedMatchConfig.TurnBasedMatchConfig_MaximumAutomatchingPlayers(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.TurnBasedMatchConfig.TurnBasedMatchConfig_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
    
    }

}
