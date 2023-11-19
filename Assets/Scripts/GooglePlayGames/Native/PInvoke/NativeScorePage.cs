using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class NativeScorePage : BaseReferenceHolder
    {
        // Methods
        internal NativeScorePage(IntPtr selfPtr)
        {
        
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.ScorePage.ScorePage_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal GooglePlayGames.Native.Cwrapper.Types.LeaderboardCollection GetCollection()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.ScorePage.ScorePage_Collection(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        private UIntPtr Length()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.ScorePage.ScorePage_Entries_Length(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        private GooglePlayGames.Native.PInvoke.NativeScoreEntry GetElement(UIntPtr index)
        {
            System.Runtime.InteropServices.HandleRef val_2 = this.SelfPtr();
            if(index.ToUInt64() < (GooglePlayGames.Native.Cwrapper.ScorePage.ScorePage_Entries_Length(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_2.wrapper}).ToUInt64()))
            {
                    System.Runtime.InteropServices.HandleRef val_5 = this.SelfPtr();
                return (GooglePlayGames.Native.PInvoke.NativeScoreEntry)new GooglePlayGames.Native.PInvoke.NativeScoreEntry(selfPtr:  GooglePlayGames.Native.Cwrapper.ScorePage.ScorePage_Entries_GetElement(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_5.wrapper}, index:  val_5.handle));
            }
            
            System.ArgumentOutOfRangeException val_8 = new System.ArgumentOutOfRangeException();
        }
        public System.Collections.Generic.IEnumerator<GooglePlayGames.Native.PInvoke.NativeScoreEntry> GetEnumerator()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            System.Func<System.UIntPtr, GooglePlayGames.Native.PInvoke.NativeScoreEntry> val_3 = new System.Func<System.UIntPtr, GooglePlayGames.Native.PInvoke.NativeScoreEntry>(object:  this, method:  GooglePlayGames.Native.PInvoke.NativeScoreEntry GooglePlayGames.Native.PInvoke.NativeScorePage::<GetEnumerator>m__0(UIntPtr index));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.ToEnumerator<System.String>(size:  0, getElement:  GooglePlayGames.Native.Cwrapper.ScorePage.ScorePage_Entries_Length(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
        }
        internal bool HasNextScorePage()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.ScorePage.ScorePage_HasNextScorePage(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal bool HasPrevScorePage()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.ScorePage.ScorePage_HasPreviousScorePage(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal GooglePlayGames.Native.PInvoke.NativeScorePageToken GetNextScorePageToken()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return (GooglePlayGames.Native.PInvoke.NativeScorePageToken)new GooglePlayGames.Native.PInvoke.NativeScorePageToken(selfPtr:  GooglePlayGames.Native.Cwrapper.ScorePage.ScorePage_NextScorePageToken(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
        }
        internal GooglePlayGames.Native.PInvoke.NativeScorePageToken GetPreviousScorePageToken()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return (GooglePlayGames.Native.PInvoke.NativeScorePageToken)new GooglePlayGames.Native.PInvoke.NativeScorePageToken(selfPtr:  GooglePlayGames.Native.Cwrapper.ScorePage.ScorePage_PreviousScorePageToken(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
        }
        internal bool Valid()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.ScorePage.ScorePage_Valid(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal GooglePlayGames.Native.Cwrapper.Types.LeaderboardTimeSpan GetTimeSpan()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.ScorePage.ScorePage_TimeSpan(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal GooglePlayGames.Native.Cwrapper.Types.LeaderboardStart GetStart()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.ScorePage.ScorePage_Start(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal string GetLeaderboardId()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeScorePage::<GetLeaderboardId>m__1(byte[] out_string, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        internal static GooglePlayGames.Native.PInvoke.NativeScorePage FromPointer(IntPtr pointer)
        {
            var val_2;
            val_2 = 0;
            if((0 & 1) != 0)
            {
                    return (GooglePlayGames.Native.PInvoke.NativeScorePage)val_2;
            }
            
            GooglePlayGames.Native.PInvoke.NativeScorePage val_1 = null;
            val_2 = val_1;
            val_1 = new GooglePlayGames.Native.PInvoke.NativeScorePage(selfPtr:  ???);
            return (GooglePlayGames.Native.PInvoke.NativeScorePage)val_2;
        }
        private GooglePlayGames.Native.PInvoke.NativeScoreEntry <GetEnumerator>m__0(UIntPtr index)
        {
            return this.GetElement(index:  index);
        }
        private UIntPtr <GetLeaderboardId>m__1(byte[] out_string, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.ScorePage.ScorePage_LeaderboardId(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_string);
        }
    
    }

}
