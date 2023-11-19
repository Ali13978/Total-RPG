using UnityEngine;

namespace GooglePlayGames.BasicApi.Multiplayer
{
    public class Invitation
    {
        // Fields
        private GooglePlayGames.BasicApi.Multiplayer.Invitation.InvType mInvitationType;
        private string mInvitationId;
        private GooglePlayGames.BasicApi.Multiplayer.Participant mInviter;
        private int mVariant;
        
        // Properties
        public GooglePlayGames.BasicApi.Multiplayer.Invitation.InvType InvitationType { get; }
        public string InvitationId { get; }
        public GooglePlayGames.BasicApi.Multiplayer.Participant Inviter { get; }
        public int Variant { get; }
        
        // Methods
        internal Invitation(GooglePlayGames.BasicApi.Multiplayer.Invitation.InvType invType, string invId, GooglePlayGames.BasicApi.Multiplayer.Participant inviter, int variant)
        {
            val_1 = new System.Object();
            this.mInvitationType = invType;
            this.mInvitationId = val_1;
            this.mInviter = inviter;
            this.mVariant = variant;
        }
        public GooglePlayGames.BasicApi.Multiplayer.Invitation.InvType get_InvitationType()
        {
            return (InvType)this.mInvitationType;
        }
        public string get_InvitationId()
        {
            return (string)this.mInvitationId;
        }
        public GooglePlayGames.BasicApi.Multiplayer.Participant get_Inviter()
        {
            return (GooglePlayGames.BasicApi.Multiplayer.Participant)this.mInviter;
        }
        public int get_Variant()
        {
            return (int)this.mVariant;
        }
        public override string ToString()
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = this.mInvitationType;
            typeof(System.Object[]).__il2cppRuntimeField_28 = this.mInvitationId;
            typeof(System.Object[]).__il2cppRuntimeField_30 = this.mInviter;
            typeof(System.Object[]).__il2cppRuntimeField_38 = this.mVariant;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            return (string)System.String.Format(format:  0, args:  "[Invitation: InvitationType={0}, InvitationId={1}, Inviter={2}, Variant={3}]");
        }
    
    }

}
