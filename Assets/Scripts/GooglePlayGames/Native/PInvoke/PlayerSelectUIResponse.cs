using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class PlayerSelectUIResponse : BaseReferenceHolder, IEnumerable<string>, IEnumerable
    {
        // Methods
        internal PlayerSelectUIResponse(IntPtr selfPointer)
        {
        
        }
        internal GooglePlayGames.Native.Cwrapper.CommonErrorStatus.UIStatus Status()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_PlayerSelectUIResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        private string PlayerIdAtIndex(UIntPtr index)
        {
            if(null != 0)
            {
                    typeof(PlayerSelectUIResponse.<PlayerIdAtIndex>c__AnonStorey0).__il2cppRuntimeField_10 = index;
            }
            else
            {
                    mem[16] = index;
            }
            
            typeof(PlayerSelectUIResponse.<PlayerIdAtIndex>c__AnonStorey0).__il2cppRuntimeField_18 = this;
            typeof(PInvokeUtilities.OutStringMethod).__il2cppRuntimeField_20 = new System.Object();
            typeof(PInvokeUtilities.OutStringMethod).__il2cppRuntimeField_28 = System.UIntPtr PlayerSelectUIResponse.<PlayerIdAtIndex>c__AnonStorey0::<>m__0(byte[] out_string, UIntPtr size);
            typeof(PInvokeUtilities.OutStringMethod).__il2cppRuntimeField_10 = System.UIntPtr PlayerSelectUIResponse.<PlayerIdAtIndex>c__AnonStorey0::<>m__0(byte[] out_string, UIntPtr size);
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  null);
        }
        public System.Collections.Generic.IEnumerator<string> GetEnumerator()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            System.Func<System.UIntPtr, System.String> val_3 = new System.Func<System.UIntPtr, System.String>(object:  this, method:  System.String GooglePlayGames.Native.PInvoke.PlayerSelectUIResponse::PlayerIdAtIndex(UIntPtr index));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.ToEnumerator<System.String>(size:  0, getElement:  GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_PlayerSelectUIResponse_GetPlayerIds_Length(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
        }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        internal uint MinimumAutomatchingPlayers()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_PlayerSelectUIResponse_GetMinimumAutomatchingPlayers(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal uint MaximumAutomatchingPlayers()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_PlayerSelectUIResponse_GetMaximumAutomatchingPlayers(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.TurnBasedMultiplayerManager.TurnBasedMultiplayerManager_PlayerSelectUIResponse_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal static GooglePlayGames.Native.PInvoke.PlayerSelectUIResponse FromPointer(IntPtr pointer)
        {
            var val_4;
            if((GooglePlayGames.Native.PInvoke.PInvokeUtilities.IsNull(pointer:  null)) != false)
            {
                    val_4 = 0;
                return (GooglePlayGames.Native.PInvoke.PlayerSelectUIResponse)val_4;
            }
            
            GooglePlayGames.Native.PInvoke.PlayerSelectUIResponse val_3 = null;
            val_4 = val_3;
            val_3 = new GooglePlayGames.Native.PInvoke.PlayerSelectUIResponse(selfPointer:  X1);
            return (GooglePlayGames.Native.PInvoke.PlayerSelectUIResponse)val_4;
        }
    
    }

}
