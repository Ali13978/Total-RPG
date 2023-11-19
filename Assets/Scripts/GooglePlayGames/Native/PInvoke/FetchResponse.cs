using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class FetchResponse : BaseReferenceHolder
    {
        // Methods
        internal FetchResponse(IntPtr selfPointer)
        {
        
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchResponse_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal GooglePlayGames.Native.PInvoke.NativeLeaderboard Leaderboard()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.PInvoke.NativeLeaderboard.FromPointer(pointer:  GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchResponse_GetData(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
        }
        internal GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus GetStatus()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal static GooglePlayGames.Native.PInvoke.FetchResponse FromPointer(IntPtr pointer)
        {
            var val_2;
            val_2 = 0;
            if((0 & 1) != 0)
            {
                    return (GooglePlayGames.Native.PInvoke.FetchResponse)val_2;
            }
            
            GooglePlayGames.Native.PInvoke.FetchResponse val_1 = null;
            val_2 = val_1;
            val_1 = new GooglePlayGames.Native.PInvoke.FetchResponse(selfPointer:  ???);
            return (GooglePlayGames.Native.PInvoke.FetchResponse)val_2;
        }
    
    }

}
