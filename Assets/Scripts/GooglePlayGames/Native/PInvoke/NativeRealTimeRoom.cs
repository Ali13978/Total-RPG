using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class NativeRealTimeRoom : BaseReferenceHolder
    {
        // Methods
        internal NativeRealTimeRoom(IntPtr selfPointer)
        {
        
        }
        internal string Id()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeRealTimeRoom::<Id>m__0(byte[] out_string, UIntPtr size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        internal System.Collections.Generic.IEnumerable<GooglePlayGames.Native.PInvoke.MultiplayerParticipant> Participants()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            System.Func<System.UIntPtr, GooglePlayGames.Native.PInvoke.MultiplayerParticipant> val_3 = new System.Func<System.UIntPtr, GooglePlayGames.Native.PInvoke.MultiplayerParticipant>(object:  this, method:  GooglePlayGames.Native.PInvoke.MultiplayerParticipant GooglePlayGames.Native.PInvoke.NativeRealTimeRoom::<Participants>m__1(UIntPtr index));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.ToEnumerable<GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch>(size:  0, getElement:  GooglePlayGames.Native.Cwrapper.RealTimeRoom.RealTimeRoom_Participants_Length(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
        }
        internal uint ParticipantCount()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return (uint)GooglePlayGames.Native.Cwrapper.RealTimeRoom.RealTimeRoom_Participants_Length(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}).Status;
        }
        internal GooglePlayGames.Native.Cwrapper.Types.RealTimeRoomStatus Status()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.RealTimeRoom.RealTimeRoom_Status(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.RealTimeRoom.RealTimeRoom_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal static GooglePlayGames.Native.PInvoke.NativeRealTimeRoom FromPointer(IntPtr selfPointer)
        {
            var val_2;
            val_2 = 0;
            if((0 & 1) != 0)
            {
                    return (GooglePlayGames.Native.PInvoke.NativeRealTimeRoom)val_2;
            }
            
            GooglePlayGames.Native.PInvoke.NativeRealTimeRoom val_1 = null;
            val_2 = val_1;
            val_1 = new GooglePlayGames.Native.PInvoke.NativeRealTimeRoom(selfPointer:  ???);
            return (GooglePlayGames.Native.PInvoke.NativeRealTimeRoom)val_2;
        }
        private UIntPtr <Id>m__0(byte[] out_string, UIntPtr size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.RealTimeRoom.RealTimeRoom_Id(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_string);
        }
        private GooglePlayGames.Native.PInvoke.MultiplayerParticipant <Participants>m__1(UIntPtr index)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return (GooglePlayGames.Native.PInvoke.MultiplayerParticipant)new GooglePlayGames.Native.PInvoke.MultiplayerParticipant(selfPointer:  GooglePlayGames.Native.Cwrapper.RealTimeRoom.RealTimeRoom_Participants_GetElement(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, index:  val_1.handle));
        }
    
    }

}
