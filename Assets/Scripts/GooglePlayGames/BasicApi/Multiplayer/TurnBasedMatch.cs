using UnityEngine;

namespace GooglePlayGames.BasicApi.Multiplayer
{
    public class TurnBasedMatch
    {
        // Fields
        private string mMatchId;
        private byte[] mData;
        private bool mCanRematch;
        private uint mAvailableAutomatchSlots;
        private string mSelfParticipantId;
        private System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant> mParticipants;
        private string mPendingParticipantId;
        private GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchTurnStatus mTurnStatus;
        private GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchStatus mMatchStatus;
        private uint mVariant;
        private uint mVersion;
        private static System.Func<GooglePlayGames.BasicApi.Multiplayer.Participant, string> <>f__am$cache0;
        
        // Properties
        public string MatchId { get; }
        public byte[] Data { get; }
        public bool CanRematch { get; }
        public string SelfParticipantId { get; }
        public GooglePlayGames.BasicApi.Multiplayer.Participant Self { get; }
        public System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant> Participants { get; }
        public string PendingParticipantId { get; }
        public GooglePlayGames.BasicApi.Multiplayer.Participant PendingParticipant { get; }
        public GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchTurnStatus TurnStatus { get; }
        public GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchStatus Status { get; }
        public uint Variant { get; }
        public uint Version { get; }
        public uint AvailableAutomatchSlots { get; }
        
        // Methods
        internal TurnBasedMatch(string matchId, byte[] data, bool canRematch, string selfParticipantId, System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant> participants, uint availableAutomatchSlots, string pendingParticipantId, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchTurnStatus turnStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchStatus matchStatus, uint variant, uint version)
        {
            val_1 = new System.Object();
            this.mMatchId = matchId;
            this.mData = data;
            this.mSelfParticipantId = val_1;
            this.mParticipants = participants;
            this.mCanRematch = canRematch;
            participants.Sort();
            this.mAvailableAutomatchSlots = availableAutomatchSlots;
            this.mPendingParticipantId = pendingParticipantId;
            this.mTurnStatus = turnStatus;
            this.mMatchStatus = matchStatus;
            this.mVariant = variant;
            this.mVersion = version;
        }
        public string get_MatchId()
        {
            return (string)this.mMatchId;
        }
        public byte[] get_Data()
        {
            return (System.Byte[])this.mData;
        }
        public bool get_CanRematch()
        {
            return (bool)this.mCanRematch;
        }
        public string get_SelfParticipantId()
        {
            return (string)this.mSelfParticipantId;
        }
        public GooglePlayGames.BasicApi.Multiplayer.Participant get_Self()
        {
            return this.GetParticipant(participantId:  this.mSelfParticipantId);
        }
        public GooglePlayGames.BasicApi.Multiplayer.Participant GetParticipant(string participantId)
        {
            string val_6;
            var val_7;
            val_6 = participantId;
            List.Enumerator<T> val_1 = this.mParticipants.GetEnumerator();
            label_5:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            val_7 = 0.InitializationCallback;
            if((Equals(value:  val_6)) == false)
            {
                goto label_5;
            }
            
            0.Dispose();
            return (GooglePlayGames.BasicApi.Multiplayer.Participant)val_7;
            label_2:
            0.Dispose();
            val_6 = 0 + "Participant not found in turn-based match: "("Participant not found in turn-based match: ");
            GooglePlayGames.OurUtils.Logger.w(msg:  0);
            val_7 = 0;
            return (GooglePlayGames.BasicApi.Multiplayer.Participant)val_7;
        }
        public System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant> get_Participants()
        {
            return (System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant>)this.mParticipants;
        }
        public string get_PendingParticipantId()
        {
            return (string)this.mPendingParticipantId;
        }
        public GooglePlayGames.BasicApi.Multiplayer.Participant get_PendingParticipant()
        {
            if(this.mPendingParticipantId == null)
            {
                    return 0;
            }
            
            return this.GetParticipant(participantId:  this.mPendingParticipantId);
        }
        public GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchTurnStatus get_TurnStatus()
        {
            return (MatchTurnStatus)this.mTurnStatus;
        }
        public GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchStatus get_Status()
        {
            return (MatchStatus)this.mMatchStatus;
        }
        public uint get_Variant()
        {
            return (uint)this.mVariant;
        }
        public uint get_Version()
        {
            return (uint)this.mVersion;
        }
        public uint get_AvailableAutomatchSlots()
        {
            return (uint)this.mAvailableAutomatchSlots;
        }
        public override string ToString()
        {
            var val_6;
            typeof(System.Object[]).__il2cppRuntimeField_20 = this.mMatchId;
            typeof(System.Object[]).__il2cppRuntimeField_28 = this.mData;
            typeof(System.Object[]).__il2cppRuntimeField_30 = this.mCanRematch;
            typeof(System.Object[]).__il2cppRuntimeField_31 = 28387767;
            typeof(System.Object[]).__il2cppRuntimeField_38 = this.mSelfParticipantId;
            val_6 = null;
            if((GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.<>f__am$cache0) == null)
            {
                    GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.<>f__am$cache0 = new System.Func<GooglePlayGames.BasicApi.Multiplayer.Participant, System.String>(object:  0, method:  static System.String GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch::<ToString>m__0(GooglePlayGames.BasicApi.Multiplayer.Participant p));
                val_6 = null;
            }
            
            System.Collections.Generic.IEnumerable<TResult> val_2 = System.Linq.Enumerable.Select<System.Type, System.String>(source:  0, selector:  this.mParticipants);
            TSource[] val_3 = System.Linq.Enumerable.ToArray<System.Type>(source:  0);
            typeof(System.Object[]).__il2cppRuntimeField_40 = System.String.Join(separator:  0, value:  ",");
            typeof(System.Object[]).__il2cppRuntimeField_48 = this.mPendingParticipantId;
            typeof(System.Object[]).__il2cppRuntimeField_50 = this.mTurnStatus;
            typeof(System.Object[]).__il2cppRuntimeField_58 = this.mMatchStatus;
            typeof(System.Object[]).__il2cppRuntimeField_60 = this.mVariant;
            typeof(System.Object[]).__il2cppRuntimeField_64 = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_68 = this.mVersion;
            typeof(System.Object[]).__il2cppRuntimeField_6C = 268435457;
            return (string)System.String.Format(format:  0, args:  "[TurnBasedMatch: mMatchId={0}, mData={1}, mCanRematch={2}, mSelfParticipantId={3}, mParticipants={4}, mPendingParticipantId={5}, mTurnStatus={6}, mMatchStatus={7}, mVariant={8}, mVersion={9}]");
        }
        private static string <ToString>m__0(GooglePlayGames.BasicApi.Multiplayer.Participant p)
        {
            if(X1 == 0)
            {
                
            }
        
        }
    
    }

}
