using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class NativeScoreSummary : BaseReferenceHolder
    {
        // Methods
        internal NativeScoreSummary(IntPtr selfPtr)
        {
        
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.ScoreSummary.ScoreSummary_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal ulong ApproximateResults()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.ScoreSummary.ScoreSummary_ApproximateNumberOfScores(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal GooglePlayGames.Native.PInvoke.NativeScore LocalUserScore()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.PInvoke.NativeScore.FromPointer(pointer:  GooglePlayGames.Native.Cwrapper.ScoreSummary.ScoreSummary_CurrentPlayerScore(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
        }
        internal static GooglePlayGames.Native.PInvoke.NativeScoreSummary FromPointer(IntPtr pointer)
        {
            var val_2;
            val_2 = 0;
            if((0 & 1) != 0)
            {
                    return (GooglePlayGames.Native.PInvoke.NativeScoreSummary)val_2;
            }
            
            GooglePlayGames.Native.PInvoke.NativeScoreSummary val_1 = null;
            val_2 = val_1;
            val_1 = new GooglePlayGames.Native.PInvoke.NativeScoreSummary(selfPtr:  ???);
            return (GooglePlayGames.Native.PInvoke.NativeScoreSummary)val_2;
        }
    
    }

}
