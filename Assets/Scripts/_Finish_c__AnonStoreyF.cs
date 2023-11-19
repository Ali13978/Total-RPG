using UnityEngine;
private sealed class NativeTurnBasedMultiplayerClient.<Finish>c__AnonStoreyF
{
    // Fields
    internal GooglePlayGames.BasicApi.Multiplayer.MatchOutcome outcome;
    internal System.Action<bool> callback;
    internal byte[] data;
    internal GooglePlayGames.Native.NativeTurnBasedMultiplayerClient $this;
    
    // Methods
    public NativeTurnBasedMultiplayerClient.<Finish>c__AnonStoreyF()
    {
    
    }
    internal void <>m__0(GooglePlayGames.Native.PInvoke.NativeTurnBasedMatch foundMatch)
    {
        var val_5;
        GooglePlayGames.Native.PInvoke.ParticipantResults val_1 = foundMatch.Results();
        List.Enumerator<T> val_3 = this.outcome.ParticipantIds.GetEnumerator();
        label_16:
        label_12:
        if((0 & 1) == 0)
        {
            goto label_4;
        }
        
        System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_6 = val_5.InitializationCallback;
        MatchResult val_8 = GooglePlayGames.Native.NativeTurnBasedMultiplayerClient.ResultToMatchResult(result:  this.outcome.GetResultFor(participantId:  val_6));
        uint val_9 = this.outcome.GetPlacementFor(participantId:  val_6);
        if((val_1.HasResultsForParticipant(participantId:  val_6)) == false)
        {
            goto label_8;
        }
        
        uint val_13 = val_1.PlacingForParticipant(participantId:  val_6);
        if(val_8 != (val_1.ResultsForParticipant(participantId:  val_6)))
        {
            goto label_13;
        }
        
        if(val_9 == val_13)
        {
            goto label_12;
        }
        
        goto label_13;
        label_8:
        GooglePlayGames.Native.PInvoke.ParticipantResults val_14 = val_1.WithResult(participantId:  val_6, placing:  val_9, result:  val_8);
        val_1.Dispose(fromFinalizer:  false);
        System.GC.SuppressFinalize(obj:  0);
        goto label_16;
        label_21:
        this.$this.mTurnBasedManager.FinishMatchDuringMyTurn(match:  foundMatch, data:  this.data, results:  null, callback:  new System.Action<TurnBasedMatchResponse>(object:  this, method:  System.Void NativeTurnBasedMultiplayerClient.<Finish>c__AnonStoreyF::<>m__1(GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchResponse response)));
        return;
        label_4:
        val_5.Dispose();
        goto label_21;
        label_13:
        string val_16 = System.String.Format(format:  0, arg0:  "Attempted to override existing results for participant {0}: Placing {1}, Result {2}", arg1:  val_6, arg2:  val_13);
        GooglePlayGames.OurUtils.Logger.e(msg:  0);
        this.callback.Invoke(obj:  false);
        val_5.Dispose();
    }
    internal void <>m__1(GooglePlayGames.Native.PInvoke.TurnBasedManager.TurnBasedMatchResponse response)
    {
        this.callback.Invoke(obj:  response.RequestSucceeded());
    }

}
