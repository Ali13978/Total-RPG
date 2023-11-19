using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class NativeScorePageToken : BaseReferenceHolder
    {
        // Methods
        internal NativeScorePageToken(IntPtr selfPtr)
        {
        
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.ScorePage.ScorePage_ScorePageToken_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
    
    }

}
