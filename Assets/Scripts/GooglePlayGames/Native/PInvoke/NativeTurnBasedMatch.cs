using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class NativeTurnBasedMatch : BaseReferenceHolder
    {
        // Methods
        internal NativeTurnBasedMatch(IntPtr selfPointer)
        {
        
        }
        internal uint AvailableAutomatchSlots()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.TurnBasedMatch.TurnBasedMatch_AutomatchingSlotsAvailable(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal ulong CreationTime()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.TurnBasedMatch.TurnBasedMatch_CreationTime(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal System.Collections.Generic.IEnumerable<GooglePlayGames.Native.PInvoke.MultiplayerParticipant> Participants()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            System.Func<System.UIntPtr, GooglePlayGames.Native.PInvoke.MultiplayerParticipant> val_3 = new System.Func<System.UIntPtr, GooglePlayGames.Native.PInvoke.MultiplayerParticipant>(object:  this, method:  GooglePlayGames.Native.PInvoke.MultiplayerParticipant GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch::<Participants>m__0(UIntPtr index));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.ToEnumerable<GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch>(size:  0, getElement:  GooglePlayGames.Native.Cwrapper.TurnBasedMatch.TurnBasedMatch_Participants_Length(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
        }
        internal uint Version()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.TurnBasedMatch.TurnBasedMatch_Version(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal uint Variant()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.TurnBasedMatch.TurnBasedMatch_Variant(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal GooglePlayGames.Native.PInvoke.ParticipantResults Results()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return (GooglePlayGames.Native.PInvoke.ParticipantResults)new GooglePlayGames.Native.PInvoke.ParticipantResults(selfPointer:  GooglePlayGames.Native.Cwrapper.TurnBasedMatch.TurnBasedMatch_ParticipantResults(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
        }
        internal GooglePlayGames.Native.PInvoke.MultiplayerParticipant ParticipantWithId(string participantId)
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            System.Collections.Generic.IEnumerable<GooglePlayGames.Native.PInvoke.MultiplayerParticipant> val_1 = this.Participants();
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_10 = val_1;
            label_21:
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_11 = val_1;
            if(((val_1 & 1) & 1) == 0)
            {
                goto label_31;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_12 = val_1;
            if((val_1.Id().Equals(value:  participantId)) == true)
            {
                goto label_31;
            }
            
            val_1.Dispose(fromFinalizer:  false);
            System.GC.SuppressFinalize(obj:  0);
            goto label_21;
            label_31:
            if(val_1 != null)
            {
                    var val_13 = 0;
                val_13 = val_13 + 1;
                val_14 = val_1;
            }
            
            if(0 != 83)
            {
                    if(0 == 85)
            {
                    return (GooglePlayGames.Native.PInvoke.MultiplayerParticipant)val_13;
            }
            
            }
            
            val_13 = 0;
            return (GooglePlayGames.Native.PInvoke.MultiplayerParticipant)val_13;
        }
        internal GooglePlayGames.Native.PInvoke.MultiplayerParticipant PendingParticipant()
        {
            var val_7;
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            GooglePlayGames.Native.PInvoke.MultiplayerParticipant val_3 = null;
            val_7 = val_3;
            val_3 = new GooglePlayGames.Native.PInvoke.MultiplayerParticipant(selfPointer:  GooglePlayGames.Native.Cwrapper.TurnBasedMatch.TurnBasedMatch_PendingParticipant(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}));
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
        internal GooglePlayGames.Native.Cwrapper.Types.MatchStatus MatchStatus()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.TurnBasedMatch.TurnBasedMatch_Status(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        internal string Description()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch::<Description>m__1(byte[] out_string, UIntPtr size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        internal bool HasRematchId()
        {
            var val_6;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    val_6 = 1;
            }
            else
            {
                    bool val_4 = this.RematchId().Equals(value:  "(null)");
                val_6 = val_4 ^ 1;
            }
            
            val_4 = val_6;
            return (bool)val_4;
        }
        internal string RematchId()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch::<RematchId>m__2(byte[] out_string, UIntPtr size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        internal byte[] Data()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            if((GooglePlayGames.Native.Cwrapper.TurnBasedMatch.TurnBasedMatch_HasData(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper})) != false)
            {
                    PInvokeUtilities.OutMethod<System.Byte> val_4 = new PInvokeUtilities.OutMethod<System.Byte>(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch::<Data>m__3(byte[] bytes, UIntPtr size));
                return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToArray<System.Byte>(outMethod:  0);
            }
            
            GooglePlayGames.OurUtils.Logger.d(msg:  0);
            return 0;
        }
        internal string Id()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch::<Id>m__4(byte[] out_string, UIntPtr size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.TurnBasedMatch.TurnBasedMatch_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        internal GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch AsTurnBasedMatch(string selfPlayerId)
        {
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            var val_47;
            var val_48;
            var val_49;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            MatchStatus val_54;
            GooglePlayGames.Native.PInvoke.MultiplayerParticipant val_2 = this.PendingParticipant();
            if(val_2 == null)
            {
                goto label_9;
            }
            
            string val_3 = val_2.Id();
            val_43 = 0;
            var val_43 = 0;
            val_43 = val_43 + 1;
            val_44 = val_2;
            if(48 != 48)
            {
                goto label_7;
            }
            
            goto label_8;
            label_7:
            label_9:
            val_43 = 0;
            label_8:
            System.Collections.Generic.IEnumerable<GooglePlayGames.Native.PInvoke.MultiplayerParticipant> val_5 = this.Participants();
            var val_44 = 0;
            val_44 = val_44 + 1;
            val_45 = val_5;
            goto label_44;
            label_54:
            var val_45 = 0;
            val_45 = val_45 + 1;
            val_46 = val_5;
            GooglePlayGames.Native.PInvoke.NativePlayer val_8 = val_5.Player();
            if(val_8 != null)
            {
                    if((val_8.Id().Equals(value:  selfPlayerId)) != false)
            {
                    val_47 = 141;
            }
            else
            {
                    val_47 = 141;
            }
            
                var val_46 = 0;
                val_46 = val_46 + 1;
                val_48 = val_8;
                if(141 == 141)
            {
                
            }
            else
            {
                    if(val_43 != 0)
            {
                    val_49 = 0;
            }
            else
            {
                    val_49 = 0;
            }
            
            }
            
            }
            
            Add(item:  val_5.AsParticipant());
            if(val_5 != null)
            {
                    var val_47 = 0;
                val_47 = val_47 + 1;
                val_50 = val_5;
            }
            
            val_43 = val_49;
            if(174 != 174)
            {
                    val_43 = 0;
                if(val_49 != 0)
            {
                    val_43 = 0;
            }
            
            }
            
            label_44:
            var val_48 = 0;
            val_48 = val_48 + 1;
            val_51 = val_5;
            if(((val_5 & 1) & 1) != 0)
            {
                goto label_54;
            }
            
            if(val_5 != null)
            {
                    var val_49 = 0;
                val_49 = val_49 + 1;
                val_52 = val_5;
            }
            
            System.Runtime.InteropServices.HandleRef val_19 = this.SelfPtr();
            if((GooglePlayGames.Native.Cwrapper.TurnBasedMatch.TurnBasedMatch_Status(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_19.wrapper})) == 5)
            {
                    val_53 = this.HasRematchId() ^ 1;
            }
            else
            {
                    val_53 = 0;
            }
            
            System.Runtime.InteropServices.HandleRef val_24 = this.SelfPtr();
            System.Runtime.InteropServices.HandleRef val_26 = this.SelfPtr();
            MatchStatus val_27 = GooglePlayGames.Native.Cwrapper.TurnBasedMatch.TurnBasedMatch_Status(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_26.wrapper});
            var val_30 = ((val_27 - 1) < 7) ? ((long)val_27 + 2) : 0;
            System.Runtime.InteropServices.HandleRef val_31 = this.SelfPtr();
            MatchStatus val_32 = GooglePlayGames.Native.Cwrapper.TurnBasedMatch.TurnBasedMatch_Status(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_31.wrapper});
            val_54 = 2;
            if((((val_32 - 1) < 7) ? (val_32 + 2) : 0) <= 9)
            {
                    var val_50 = 25808492 + (val_33 < 0x7 ? (val_32 + 2) : 0) << 2;
                val_50 = val_50 + 25808492;
            }
            else
            {
                    System.Runtime.InteropServices.HandleRef val_37 = this.SelfPtr();
                System.Runtime.InteropServices.HandleRef val_39 = this.SelfPtr();
                GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch val_42 = new GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch(matchId:  this.Id(), data:  this.Data(), canRematch:  val_53 & 1, selfParticipantId:  val_5.Id(), participants:  new System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant>(), availableAutomatchSlots:  GooglePlayGames.Native.Cwrapper.TurnBasedMatch.TurnBasedMatch_AutomatchingSlotsAvailable(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_24.wrapper}), pendingParticipantId:  0, turnStatus:  25808960 + (val_28 < 0x7 ? (long)(int)((val_27 + 2)) : 0) << 2, matchStatus:  null, variant:  GooglePlayGames.Native.Cwrapper.TurnBasedMatch.TurnBasedMatch_Variant(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_37.wrapper}), version:  GooglePlayGames.Native.Cwrapper.TurnBasedMatch.TurnBasedMatch_Version(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_39.wrapper}));
                return val_42;
            }
        
        }
        private static GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchTurnStatus ToTurnStatus(GooglePlayGames.Native.Cwrapper.Types.MatchStatus status)
        {
            var val_3 = ((W1 - 1) < 7) ? ((long)W1 + 2) : 0;
            return (MatchTurnStatus)25808960 + (val_1 < 0x7 ? (long)(int)((W1 + 2)) : 0) << 2;
        }
        private static GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchStatus ToMatchStatus(string pendingParticipantId, GooglePlayGames.Native.Cwrapper.Types.MatchStatus status)
        {
            var val_4 = 2;
            if((((W2 - 1) < 7) ? (W2 + 2) : 0) > 9)
            {
                    return 5;
            }
            
            var val_4 = 25808572 + (val_1 < 0x7 ? (W2 + 2) : 0) << 2;
            val_4 = val_4 + 25808572;
            goto (25808572 + (val_1 < 0x7 ? (W2 + 2) : 0) << 2 + 25808572);
        }
        internal static GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch FromPointer(IntPtr selfPointer)
        {
            if((GooglePlayGames.Native.PInvoke.PInvokeUtilities.IsNull(pointer:  0)) == true)
            {
                    return (GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch)0;
            }
            
            GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch val_3 = null;
            0 = val_3;
            val_3 = new GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch(selfPointer:  X1);
            return (GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch)0;
        }
        private GooglePlayGames.Native.PInvoke.MultiplayerParticipant <Participants>m__0(UIntPtr index)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return (GooglePlayGames.Native.PInvoke.MultiplayerParticipant)new GooglePlayGames.Native.PInvoke.MultiplayerParticipant(selfPointer:  GooglePlayGames.Native.Cwrapper.TurnBasedMatch.TurnBasedMatch_Participants_GetElement(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, index:  val_1.handle));
        }
        private UIntPtr <Description>m__1(byte[] out_string, UIntPtr size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.TurnBasedMatch.TurnBasedMatch_Description(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_string);
        }
        private UIntPtr <RematchId>m__2(byte[] out_string, UIntPtr size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.TurnBasedMatch.TurnBasedMatch_RematchId(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_string);
        }
        private UIntPtr <Data>m__3(byte[] bytes, UIntPtr size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.TurnBasedMatch.TurnBasedMatch_Data(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  bytes);
        }
        private UIntPtr <Id>m__4(byte[] out_string, UIntPtr size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.TurnBasedMatch.TurnBasedMatch_Id(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_string);
        }
    
    }

}
