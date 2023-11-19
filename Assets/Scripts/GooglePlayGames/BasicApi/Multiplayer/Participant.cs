using UnityEngine;

namespace GooglePlayGames.BasicApi.Multiplayer
{
    public class Participant : IComparable<GooglePlayGames.BasicApi.Multiplayer.Participant>
    {
        // Fields
        private string mDisplayName;
        private readonly string mParticipantId;
        private GooglePlayGames.BasicApi.Multiplayer.Participant.ParticipantStatus mStatus;
        private GooglePlayGames.BasicApi.Multiplayer.Player mPlayer;
        private bool mIsConnectedToRoom;
        
        // Properties
        public string DisplayName { get; }
        public string ParticipantId { get; }
        public GooglePlayGames.BasicApi.Multiplayer.Participant.ParticipantStatus Status { get; }
        public GooglePlayGames.BasicApi.Multiplayer.Player Player { get; }
        public bool IsConnectedToRoom { get; }
        public bool IsAutomatch { get; }
        
        // Methods
        internal Participant(string displayName, string participantId, GooglePlayGames.BasicApi.Multiplayer.Participant.ParticipantStatus status, GooglePlayGames.BasicApi.Multiplayer.Player player, bool connectedToRoom)
        {
            null = null;
            this.mDisplayName = System.String.Empty;
            this.mStatus = 7;
            this.mParticipantId = System.String.Empty;
            val_1 = new System.Object();
            this.mDisplayName = displayName;
            this.mParticipantId = val_1;
            this.mIsConnectedToRoom = connectedToRoom;
            this.mStatus = status;
            this.mPlayer = player;
        }
        public string get_DisplayName()
        {
            return (string)this.mDisplayName;
        }
        public string get_ParticipantId()
        {
            return (string)this.mParticipantId;
        }
        public GooglePlayGames.BasicApi.Multiplayer.Participant.ParticipantStatus get_Status()
        {
            return (ParticipantStatus)this.mStatus;
        }
        public GooglePlayGames.BasicApi.Multiplayer.Player get_Player()
        {
            return (GooglePlayGames.BasicApi.Multiplayer.Player)this.mPlayer;
        }
        public bool get_IsConnectedToRoom()
        {
            return (bool)this.mIsConnectedToRoom;
        }
        public bool get_IsAutomatch()
        {
            return (bool)(this.mPlayer == 0) ? 1 : 0;
        }
        public override string ToString()
        {
            var val_4;
            var val_5;
            var val_6;
            val_4 = null;
            typeof(System.Object[]).__il2cppRuntimeField_20 = this.mDisplayName;
            typeof(System.Object[]).__il2cppRuntimeField_28 = this.mParticipantId;
            val_5 = public System.String System.Enum::ToString();
            string val_1 = this.mStatus.ToString();
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            mem2[0] = null;
            if(val_1 != null)
            {
                    val_5 = mem[null + 48];
                if(val_1 == null)
            {
                    val_5 = 0;
            }
            
            }
            
            val_5 = 0;
            typeof(System.Object[]).__il2cppRuntimeField_30 = val_1;
            if(this.mPlayer != null)
            {
                    val_6 = this.mPlayer;
                if(this.mPlayer != null)
            {
                    if(null != null)
            {
                goto label_17;
            }
            
            }
            
                val_4 = 0;
            }
            else
            {
                    val_6 = "NULL";
            }
            
            label_17:
            typeof(System.Object[]).__il2cppRuntimeField_38 = val_6;
            typeof(System.Object[]).__il2cppRuntimeField_40 = this.mIsConnectedToRoom;
            typeof(System.Object[]).__il2cppRuntimeField_41 = 28376775;
            return (string)System.String.Format(format:  0, args:  "[Participant: \'{0}\' (id {1}), status={2}, player={3}, connected={4}]");
        }
        public int CompareTo(GooglePlayGames.BasicApi.Multiplayer.Participant other)
        {
            return System.String.Compare(strA:  0, strB:  this.mParticipantId, comparisonType:  other.mParticipantId);
        }
        public override bool Equals(object obj)
        {
            var val_9;
            string val_10;
            var val_11;
            val_10 = obj;
            if(val_10 == null)
            {
                goto label_1;
            }
            
            if((System.Object.ReferenceEquals(objA:  0, objB:  this)) != false)
            {
                    val_11 = 1;
                return (bool)val_11.Equals(value:  val_10);
            }
            
            val_9 = val_10.GetType();
            if(val_9 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_6;
            }
            
            label_1:
            val_11 = 0;
            return (bool)val_11.Equals(value:  val_10);
            label_6:
            val_11 = this.mParticipantId;
            return (bool)val_11.Equals(value:  val_10);
        }
        public override int GetHashCode()
        {
            if(this.mParticipantId == null)
            {
                    return 0;
            }
            
            goto typeof(System.String).__il2cppRuntimeField_130;
        }
    
    }

}
