using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class FetchScoreSummaryResponse : BaseReferenceHolder
    {
        // Methods
        internal FetchScoreSummaryResponse(IntPtr selfPointer)
        {
        
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchScoreSummaryResponse_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal GooglePlayGames.Native.Cwrapper.CommonErrorStatus.ResponseStatus GetStatus()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchScoreSummaryResponse_GetStatus(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal GooglePlayGames.Native.PInvoke.NativeScoreSummary GetScoreSummary()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.PInvoke.NativeScoreSummary.FromPointer(pointer:  GooglePlayGames.Native.Cwrapper.LeaderboardManager.LeaderboardManager_FetchScoreSummaryResponse_GetData(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
        }
        internal static GooglePlayGames.Native.PInvoke.FetchScoreSummaryResponse FromPointer(IntPtr pointer)
        {
            var val_2;
            val_2 = 0;
            if((0 & 1) != 0)
            {
                    return (GooglePlayGames.Native.PInvoke.FetchScoreSummaryResponse)val_2;
            }
            
            GooglePlayGames.Native.PInvoke.FetchScoreSummaryResponse val_1 = null;
            val_2 = val_1;
            val_1 = new GooglePlayGames.Native.PInvoke.FetchScoreSummaryResponse(selfPointer:  ???);
            return (GooglePlayGames.Native.PInvoke.FetchScoreSummaryResponse)val_2;
        }
    
    }

}
