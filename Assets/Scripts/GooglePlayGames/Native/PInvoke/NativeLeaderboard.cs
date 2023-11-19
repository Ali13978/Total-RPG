using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class NativeLeaderboard : BaseReferenceHolder
    {
        // Methods
        internal NativeLeaderboard(IntPtr selfPtr)
        {
        
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.Leaderboard.Leaderboard_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal string Title()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeLeaderboard::<Title>m__0(byte[] out_string, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        internal static GooglePlayGames.Native.PInvoke.NativeLeaderboard FromPointer(IntPtr pointer)
        {
            var val_2;
            val_2 = 0;
            if((0 & 1) != 0)
            {
                    return (GooglePlayGames.Native.PInvoke.NativeLeaderboard)val_2;
            }
            
            GooglePlayGames.Native.PInvoke.NativeLeaderboard val_1 = null;
            val_2 = val_1;
            val_1 = new GooglePlayGames.Native.PInvoke.NativeLeaderboard(selfPtr:  ???);
            return (GooglePlayGames.Native.PInvoke.NativeLeaderboard)val_2;
        }
        private UIntPtr <Title>m__0(byte[] out_string, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.Leaderboard.Leaderboard_Name(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_string);
        }
    
    }

}
