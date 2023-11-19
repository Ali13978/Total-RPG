using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class MultiplayerInvitation : BaseReferenceHolder
    {
        // Methods
        internal MultiplayerInvitation(IntPtr selfPointer)
        {
        
        }
        internal GooglePlayGames.Native.PInvoke.MultiplayerParticipant Inviter()
        {
            var val_7;
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.PInvoke.MultiplayerParticipant val_3 = null;
            val_7 = val_3;
            val_3 = new GooglePlayGames.Native.PInvoke.MultiplayerParticipant(selfPointer:  GooglePlayGames.Native.Cwrapper.MultiplayerInvitation.MultiplayerInvitation_InvitingParticipant(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
            System.Runtime.InteropServices.HandleRef val_4 = SelfPtr();
            if((GooglePlayGames.Native.Cwrapper.MultiplayerParticipant.MultiplayerParticipant_Valid(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_4.wrapper})) == true)
            {
                    return (GooglePlayGames.Native.PInvoke.MultiplayerParticipant)val_7;
            }
            
            Dispose(fromFinalizer:  false);
            System.GC.SuppressFinalize(obj:  0);
            val_7 = 0;
            return (GooglePlayGames.Native.PInvoke.MultiplayerParticipant)val_7;
        }
        internal uint Variant()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.MultiplayerInvitation.MultiplayerInvitation_Variant(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal GooglePlayGames.Native.Cwrapper.Types.MultiplayerInvitationType Type()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.MultiplayerInvitation.MultiplayerInvitation_Type(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal string Id()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.MultiplayerInvitation::<Id>m__0(byte[] out_string, UIntPtr size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.MultiplayerInvitation.MultiplayerInvitation_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal uint AutomatchingSlots()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.MultiplayerInvitation.MultiplayerInvitation_AutomatchingSlotsAvailable(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal uint ParticipantCount()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return (uint)GooglePlayGames.Native.Cwrapper.MultiplayerInvitation.MultiplayerInvitation_Participants_Length(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}).Status;
        }
        private static GooglePlayGames.BasicApi.Multiplayer.Invitation.InvType ToInvType(GooglePlayGames.Native.Cwrapper.Types.MultiplayerInvitationType invitationType)
        {
            var val_2;
            var val_3;
            val_2 = W1;
            if(val_2 == 2)
            {
                    val_3 = 0;
                return (InvType)val_3;
            }
            
            if(val_2 == 1)
            {
                    val_3 = 1;
                return (InvType)val_3;
            }
            
            val_2 = 0 + "Found unknown invitation type: "("Found unknown invitation type: ");
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            val_3 = 2;
            return (InvType)val_3;
        }
        internal GooglePlayGames.BasicApi.Multiplayer.Invitation AsInvitation()
        {
            GooglePlayGames.BasicApi.Multiplayer.Participant val_11;
            var val_12;
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            System.Runtime.InteropServices.HandleRef val_5 = this.SelfPtr();
            GooglePlayGames.Native.PInvoke.MultiplayerParticipant val_7 = this.Inviter();
            val_11 = 0;
            if(val_7 == null)
            {
                    return (GooglePlayGames.BasicApi.Multiplayer.Invitation)new GooglePlayGames.BasicApi.Multiplayer.Invitation(invType:  GooglePlayGames.Native.PInvoke.MultiplayerInvitation.ToInvType(invitationType:  GooglePlayGames.Native.Cwrapper.MultiplayerInvitation.MultiplayerInvitation_Type(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper})), invId:  this.Id(), inviter:  val_11 = val_7.AsParticipant(), variant:  GooglePlayGames.Native.Cwrapper.MultiplayerInvitation.MultiplayerInvitation_Variant(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_5.wrapper}));
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_12 = val_7;
            return (GooglePlayGames.BasicApi.Multiplayer.Invitation)new GooglePlayGames.BasicApi.Multiplayer.Invitation(invType:  GooglePlayGames.Native.PInvoke.MultiplayerInvitation.ToInvType(invitationType:  GooglePlayGames.Native.Cwrapper.MultiplayerInvitation.MultiplayerInvitation_Type(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper})), invId:  this.Id(), inviter:  val_11, variant:  GooglePlayGames.Native.Cwrapper.MultiplayerInvitation.MultiplayerInvitation_Variant(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_5.wrapper}));
        }
        internal static GooglePlayGames.Native.PInvoke.MultiplayerInvitation FromPointer(IntPtr selfPointer)
        {
            if((GooglePlayGames.Native.PInvoke.PInvokeUtilities.IsNull(pointer:  0)) == true)
            {
                    return (GooglePlayGames.Native.PInvoke.MultiplayerInvitation)0;
            }
            
            GooglePlayGames.Native.PInvoke.MultiplayerInvitation val_3 = null;
            0 = val_3;
            val_3 = new GooglePlayGames.Native.PInvoke.MultiplayerInvitation(selfPointer:  X1);
            return (GooglePlayGames.Native.PInvoke.MultiplayerInvitation)0;
        }
        private UIntPtr <Id>m__0(byte[] out_string, UIntPtr size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.MultiplayerInvitation.MultiplayerInvitation_Id(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_string);
        }
    
    }

}
