using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class NativeScoreEntry : BaseReferenceHolder
    {
        // Fields
        private const ulong MinusOne = 18446744073709551615;
        
        // Methods
        internal NativeScoreEntry(IntPtr selfPtr)
        {
        
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.ScorePage.ScorePage_Entry_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal ulong GetLastModifiedTime()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.ScorePage.ScorePage_Entry_LastModifiedTime(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal string GetPlayerId()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeScoreEntry::<GetPlayerId>m__0(byte[] out_string, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        internal GooglePlayGames.Native.PInvoke.NativeScore GetScore()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return (GooglePlayGames.Native.PInvoke.NativeScore)new GooglePlayGames.Native.PInvoke.NativeScore(selfPtr:  GooglePlayGames.Native.Cwrapper.ScorePage.ScorePage_Entry_Score(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
        }
        internal GooglePlayGames.PlayGamesScore AsScore(string leaderboardId)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            ulong val_2 = GooglePlayGames.Native.Cwrapper.ScorePage.ScorePage_Entry_LastModifiedTime(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
            var val_3 = (val_2 == 1) ? 0 : ((double)val_2);
            System.Runtime.InteropServices.HandleRef val_5 = this.GetScore().SelfPtr();
            System.Runtime.InteropServices.HandleRef val_9 = this.GetScore().SelfPtr();
            return (GooglePlayGames.PlayGamesScore)new GooglePlayGames.PlayGamesScore(date:  new System.DateTime() {ticks = new System.TimeSpan() {}}, leaderboardId:  leaderboardId, rank:  GooglePlayGames.Native.Cwrapper.Score.Score_Rank(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_5.wrapper}), playerId:  this.GetPlayerId(), value:  GooglePlayGames.Native.Cwrapper.Score.Score_Value(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_9.wrapper}), metadata:  this.GetScore().GetMetadata());
        }
        private UIntPtr <GetPlayerId>m__0(byte[] out_string, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.ScorePage.ScorePage_Entry_PlayerId(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_string);
        }
    
    }

}
