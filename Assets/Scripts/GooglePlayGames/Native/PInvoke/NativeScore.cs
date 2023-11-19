using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class NativeScore : BaseReferenceHolder
    {
        // Fields
        private const ulong MinusOne = 18446744073709551615;
        
        // Methods
        internal NativeScore(IntPtr selfPtr)
        {
        
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.Cwrapper.Score.Score_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal ulong GetDate()
        {
            return 0;
        }
        internal string GetMetadata()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeScore::<GetMetadata>m__0(byte[] out_string, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        internal ulong GetRank()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.Score.Score_Rank(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal ulong GetValue()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.Score.Score_Value(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal GooglePlayGames.PlayGamesScore AsScore(string leaderboardId, string selfPlayerId)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            System.Runtime.InteropServices.HandleRef val_3 = this.SelfPtr();
            return (GooglePlayGames.PlayGamesScore)new GooglePlayGames.PlayGamesScore(date:  new System.DateTime() {ticks = new System.TimeSpan() {}}, leaderboardId:  leaderboardId, rank:  GooglePlayGames.Native.Cwrapper.Score.Score_Rank(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}), playerId:  selfPlayerId, value:  GooglePlayGames.Native.Cwrapper.Score.Score_Value(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_3.wrapper}), metadata:  this.GetMetadata());
        }
        internal static GooglePlayGames.Native.PInvoke.NativeScore FromPointer(IntPtr pointer)
        {
            var val_2;
            val_2 = 0;
            if((0 & 1) != 0)
            {
                    return (GooglePlayGames.Native.PInvoke.NativeScore)val_2;
            }
            
            GooglePlayGames.Native.PInvoke.NativeScore val_1 = null;
            val_2 = val_1;
            val_1 = new GooglePlayGames.Native.PInvoke.NativeScore(selfPtr:  ???);
            return (GooglePlayGames.Native.PInvoke.NativeScore)val_2;
        }
        private UIntPtr <GetMetadata>m__0(byte[] out_string, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.Score.Score_Metadata(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_string);
        }
    
    }

}
