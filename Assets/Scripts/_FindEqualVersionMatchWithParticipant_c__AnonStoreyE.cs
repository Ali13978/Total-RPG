using UnityEngine;
private sealed class NativeTurnBasedMultiplayerClient.<FindEqualVersionMatchWithParticipant>c__AnonStoreyE
{
    // Fields
    internal string participantId;
    internal System.Action<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch> onFoundParticipantAndMatch;
    internal GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match;
    internal System.Action<bool> onFailure;
    
    // Methods
    public NativeTurnBasedMultiplayerClient.<FindEqualVersionMatchWithParticipant>c__AnonStoreyE()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch foundMatch)
    {
        GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch val_15;
        var val_16;
        var val_17;
        GooglePlayGames.Native.PInvoke.MultiplayerParticipant val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        val_15 = foundMatch;
        val_16 = this;
        if(this.participantId == null)
        {
            goto label_1;
        }
        
        label_29:
        GooglePlayGames.Native.PInvoke.MultiplayerParticipant val_1 = val_15.ParticipantWithId(participantId:  this.participantId);
        if(val_1 == null)
        {
            goto label_3;
        }
        
        val_17 = 1152921512114532752;
        this.onFoundParticipantAndMatch.Invoke(arg1:  val_1, arg2:  val_15);
        goto label_5;
        label_1:
        val_18 = GooglePlayGames.Native.PInvoke.MultiplayerParticipant.AutomatchingSentinel();
        this.onFoundParticipantAndMatch.Invoke(arg1:  val_18, arg2:  val_15);
        val_19 = 0;
        val_20 = 147;
        if(val_18 == null)
        {
            goto label_9;
        }
        
        val_21 = null;
        var val_15 = 0;
        val_22 = 1152921504960344072;
        val_15 = val_15 + 1;
        val_23 = val_18;
        goto label_13;
        label_3:
        val_15 = System.String.Format(format:  0, arg0:  "Located match {0} but desired participant with ID {1} could not be found", arg1:  this.match.MatchId);
        GooglePlayGames.OurUtils.Logger.e(msg:  0);
        val_17 = 1152921509318476944;
        this.onFailure.Invoke(obj:  false);
        label_5:
        val_16 = 0;
        val_20 = 147;
        if(val_1 != null)
        {
                var val_16 = 0;
            val_22 = 1152921504960344072;
            val_16 = val_16 + 1;
            val_22 = 1152921504960344088;
            val_24 = val_1;
        }
        
        if(147 == 147)
        {
                return;
        }
        
        if(val_16 == 0)
        {
                return;
        }
        
        val_18 = ???;
        val_16 = ???;
        val_19 = ???;
        val_15 = ???;
        val_21 = 0;
        val_20 = ???;
        label_13:
        label_9:
        if(val_20 == 147)
        {
                return;
        }
        
        if(val_19 == 0)
        {
            goto label_29;
        }
        
        goto label_29;
    }

}
