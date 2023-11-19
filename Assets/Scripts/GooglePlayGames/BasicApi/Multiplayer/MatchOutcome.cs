using UnityEngine;

namespace GooglePlayGames.BasicApi.Multiplayer
{
    public class MatchOutcome
    {
        // Fields
        public const uint PlacementUnset = 0;
        private System.Collections.Generic.List<string> mParticipantIds;
        private System.Collections.Generic.Dictionary<string, uint> mPlacements;
        private System.Collections.Generic.Dictionary<string, GooglePlayGames.BasicApi.Multiplayer.MatchOutcome.ParticipantResult> mResults;
        
        // Properties
        public System.Collections.Generic.List<string> ParticipantIds { get; }
        
        // Methods
        public MatchOutcome()
        {
            this.mParticipantIds = new System.Collections.Generic.List<System.String>();
            this.mPlacements = new System.Collections.Generic.Dictionary<System.String, System.UInt32>();
            this.mResults = new System.Collections.Generic.Dictionary<System.String, ParticipantResult>();
        }
        public void SetParticipantResult(string participantId, GooglePlayGames.BasicApi.Multiplayer.MatchOutcome.ParticipantResult result, uint placement)
        {
            if((this.mParticipantIds.Contains(item:  participantId)) != true)
            {
                    this.mParticipantIds.Add(item:  participantId);
            }
            
            this.mPlacements.set_Item(key:  participantId, value:  placement);
            this.mResults.set_Item(key:  participantId, value:  result);
        }
        public void SetParticipantResult(string participantId, GooglePlayGames.BasicApi.Multiplayer.MatchOutcome.ParticipantResult result)
        {
            this.SetParticipantResult(participantId:  participantId, result:  result, placement:  0);
        }
        public void SetParticipantResult(string participantId, uint placement)
        {
            this.SetParticipantResult(participantId:  participantId, result:  0, placement:  placement);
        }
        public System.Collections.Generic.List<string> get_ParticipantIds()
        {
            return (System.Collections.Generic.List<System.String>)this.mParticipantIds;
        }
        public GooglePlayGames.BasicApi.Multiplayer.MatchOutcome.ParticipantResult GetResultFor(string participantId)
        {
            if((this.mResults.ContainsKey(key:  participantId)) == false)
            {
                    return 0;
            }
            
            if(this.mResults != null)
            {
                    return this.mResults.Item[participantId];
            }
            
            return this.mResults.Item[participantId];
        }
        public uint GetPlacementFor(string participantId)
        {
            if((this.mPlacements.ContainsKey(key:  participantId)) == false)
            {
                    return 0;
            }
            
            if(this.mPlacements != null)
            {
                    return this.mPlacements.Item[participantId];
            }
            
            return this.mPlacements.Item[participantId];
        }
        public override string ToString()
        {
            List.Enumerator<T> val_1 = this.mParticipantIds.GetEnumerator();
            goto label_2;
            label_6:
            "[MatchOutcome" = val_1.current;
            label_2:
            if((0 & 1) == 0)
            {
                goto label_11;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_2 = 0.InitializationCallback;
            uint val_4 = this.GetPlacementFor(participantId:  val_2);
            string val_5 = System.String.Format(format:  0, arg0:  " {0}->({1},{2})", arg1:  val_2, arg2:  this.GetResultFor(participantId:  val_2));
            string val_6 = 0 + "[MatchOutcome";
            goto label_6;
            label_11:
            0.Dispose();
            return (string)0 + "[MatchOutcome";
        }
    
    }

}
