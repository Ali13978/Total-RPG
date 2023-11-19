using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class MultiplayerParticipant : BaseReferenceHolder
    {
        // Fields
        private static readonly System.Collections.Generic.Dictionary<GooglePlayGames.Native.Cwrapper.Types.ParticipantStatus, GooglePlayGames.BasicApi.Multiplayer.Participant.ParticipantStatus> StatusConversion;
        
        // Methods
        internal MultiplayerParticipant(IntPtr selfPointer)
        {
        
        }
        internal GooglePlayGames.Native.Cwrapper.Types.ParticipantStatus Status()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.MultiplayerParticipant.MultiplayerParticipant_Status(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal bool IsConnectedToRoom()
        {
            var val_7;
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            if((GooglePlayGames.Native.Cwrapper.MultiplayerParticipant.MultiplayerParticipant_IsConnectedToRoom(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper})) != false)
            {
                    val_7 = 1;
                return (bool)((GooglePlayGames.Native.Cwrapper.MultiplayerParticipant.MultiplayerParticipant_Status(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_4.wrapper})) == 2) ? 1 : 0;
            }
            
            System.Runtime.InteropServices.HandleRef val_4 = this.SelfPtr();
            return (bool)((GooglePlayGames.Native.Cwrapper.MultiplayerParticipant.MultiplayerParticipant_Status(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_4.wrapper})) == 2) ? 1 : 0;
        }
        internal string DisplayName()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.MultiplayerParticipant::<DisplayName>m__0(byte[] out_string, UIntPtr size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        internal GooglePlayGames.Native.PInvoke.NativePlayer Player()
        {
            IntPtr val_6;
            var val_7;
            val_6 = this;
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            val_7 = 0;
            if((GooglePlayGames.Native.Cwrapper.MultiplayerParticipant.MultiplayerParticipant_HasPlayer(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper})) == false)
            {
                    return (GooglePlayGames.Native.PInvoke.NativePlayer)val_7;
            }
            
            System.Runtime.InteropServices.HandleRef val_3 = this.SelfPtr();
            val_6 = GooglePlayGames.Native.Cwrapper.MultiplayerParticipant.MultiplayerParticipant_Player(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_3.wrapper});
            GooglePlayGames.Native.PInvoke.NativePlayer val_5 = null;
            val_7 = val_5;
            val_5 = new GooglePlayGames.Native.PInvoke.NativePlayer(selfPointer:  val_6);
            return (GooglePlayGames.Native.PInvoke.NativePlayer)val_7;
        }
        internal string Id()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.MultiplayerParticipant::<Id>m__1(byte[] out_string, UIntPtr size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        internal bool Valid()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.MultiplayerParticipant.MultiplayerParticipant_Valid(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.MultiplayerParticipant.MultiplayerParticipant_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal GooglePlayGames.BasicApi.Multiplayer.Participant AsParticipant()
        {
            var val_11;
            GooglePlayGames.BasicApi.Multiplayer.Player val_12;
            GooglePlayGames.Native.PInvoke.NativePlayer val_1 = this.Player();
            val_11 = null;
            val_11 = null;
            System.Runtime.InteropServices.HandleRef val_4 = this.SelfPtr();
            if(val_1 != null)
            {
                    val_12 = val_1.AsPlayer();
            }
            else
            {
                    val_12 = 0;
            }
            
            return (GooglePlayGames.BasicApi.Multiplayer.Participant)new GooglePlayGames.BasicApi.Multiplayer.Participant(displayName:  this.DisplayName(), participantId:  this.Id(), status:  GooglePlayGames.Native.PInvoke.MultiplayerParticipant.StatusConversion.Item[GooglePlayGames.Native.Cwrapper.MultiplayerParticipant.MultiplayerParticipant_Status(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_4.wrapper})], player:  val_12, connectedToRoom:  this.IsConnectedToRoom());
        }
        internal static GooglePlayGames.Native.PInvoke.MultiplayerParticipant FromPointer(IntPtr pointer)
        {
            if((GooglePlayGames.Native.PInvoke.PInvokeUtilities.IsNull(pointer:  0)) == true)
            {
                    return (GooglePlayGames.Native.PInvoke.MultiplayerParticipant)0;
            }
            
            GooglePlayGames.Native.PInvoke.MultiplayerParticipant val_3 = null;
            0 = val_3;
            val_3 = new GooglePlayGames.Native.PInvoke.MultiplayerParticipant(selfPointer:  X1);
            return (GooglePlayGames.Native.PInvoke.MultiplayerParticipant)0;
        }
        internal static GooglePlayGames.Native.PInvoke.MultiplayerParticipant AutomatchingSentinel()
        {
            return (GooglePlayGames.Native.PInvoke.MultiplayerParticipant)new GooglePlayGames.Native.PInvoke.MultiplayerParticipant(selfPointer:  GooglePlayGames.Native.Cwrapper.Sentinels.Sentinels_AutomatchingParticipant());
        }
        private static MultiplayerParticipant()
        {
            if(null != 0)
            {
                    Add(key:  1, value:  1);
                Add(key:  2, value:  2);
                Add(key:  3, value:  3);
                Add(key:  4, value:  4);
                Add(key:  5, value:  0);
                Add(key:  6, value:  5);
            }
            else
            {
                    Add(key:  1, value:  1);
                Add(key:  2, value:  2);
                Add(key:  3, value:  3);
                Add(key:  4, value:  4);
                Add(key:  5, value:  0);
                Add(key:  6, value:  5);
            }
            
            Add(key:  7, value:  6);
            GooglePlayGames.Native.PInvoke.MultiplayerParticipant.StatusConversion = new System.Collections.Generic.Dictionary<ParticipantStatus, ParticipantStatus>();
        }
        private UIntPtr <DisplayName>m__0(byte[] out_string, UIntPtr size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.MultiplayerParticipant.MultiplayerParticipant_DisplayName(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_string);
        }
        private UIntPtr <Id>m__1(byte[] out_string, UIntPtr size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.MultiplayerParticipant.MultiplayerParticipant_Id(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_string);
        }
    
    }

}
