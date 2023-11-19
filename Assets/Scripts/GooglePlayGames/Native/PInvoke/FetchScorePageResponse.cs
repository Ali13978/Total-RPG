using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class FetchScorePageResponse : BaseReferenceHolder
    {
        // Methods
        internal FetchScorePageResponse(IntPtr selfPointer)
        {
        
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchScorePageResponse_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus GetStatus()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchScorePageResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal GooglePlayGames.Native.PInvoke.NativeScorePage GetScorePage()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.PInvoke.NativeScorePage.FromPointer(pointer:  GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchScorePageResponse_GetData(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
        }
        internal static GooglePlayGames.Native.PInvoke.FetchScorePageResponse FromPointer(IntPtr pointer)
        {
            var val_2;
            val_2 = 0;
            if((0 & 1) != 0)
            {
                    return (GooglePlayGames.Native.PInvoke.FetchScorePageResponse)val_2;
            }
            
            GooglePlayGames.Native.PInvoke.FetchScorePageResponse val_1 = null;
            val_2 = val_1;
            val_1 = new GooglePlayGames.Native.PInvoke.FetchScorePageResponse(selfPointer:  ???);
            return (GooglePlayGames.Native.PInvoke.FetchScorePageResponse)val_2;
        }
    
    }

}
