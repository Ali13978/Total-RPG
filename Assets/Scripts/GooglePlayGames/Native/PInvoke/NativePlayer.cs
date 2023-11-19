using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class NativePlayer : BaseReferenceHolder
    {
        // Methods
        internal NativePlayer(IntPtr selfPointer)
        {
        
        }
        internal string Id()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativePlayer::<Id>m__0(byte[] out_string, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        internal string Name()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativePlayer::<Name>m__1(byte[] out_string, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        internal string AvatarURL()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativePlayer::<AvatarURL>m__2(byte[] out_string, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.Player.Player_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal GooglePlayGames.BasicApi.Multiplayer.Player AsPlayer()
        {
            return (GooglePlayGames.BasicApi.Multiplayer.Player)new GooglePlayGames.BasicApi.Multiplayer.Player(displayName:  this.Name(), playerId:  this.Id(), avatarUrl:  this.AvatarURL());
        }
        private UIntPtr <Id>m__0(byte[] out_string, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.Player.Player_Id(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_string);
        }
        private UIntPtr <Name>m__1(byte[] out_string, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.Player.Player_Name(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_string);
        }
        private UIntPtr <AvatarURL>m__2(byte[] out_string, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.Player.Player_AvatarUrl(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, resolution:  val_1.handle, out_arg:  1, out_size:  out_string);
        }
    
    }

}
