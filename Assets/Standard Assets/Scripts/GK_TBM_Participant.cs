using UnityEngine;
public class GK_TBM_Participant
{
    // Fields
    private string _PlayerId;
    private string _MatchId;
    private System.DateTime _TimeoutDate;
    private System.DateTime _LastTurnDate;
    private GK_TurnBasedParticipantStatus _Status;
    private GK_TurnBasedMatchOutcome _MatchOutcome;
    
    // Properties
    public string PlayerId { get; }
    public GK_Player Player { get; }
    public string MatchId { get; }
    public System.DateTime TimeoutDate { get; }
    public System.DateTime LastTurnDate { get; }
    public GK_TurnBasedParticipantStatus Status { get; }
    public GK_TurnBasedMatchOutcome MatchOutcome { get; }
    
    // Methods
    public GK_TBM_Participant(string playerId, string status, string outcome, string timeoutDate, string lastTurnDate)
    {
        val_1 = new System.Object();
        this._PlayerId = playerId;
        System.DateTime val_2 = System.DateTime.Parse(s:  0);
        this._TimeoutDate = val_2;
        mem[1152921510255987048] = val_2.kind;
        System.DateTime val_3 = System.DateTime.Parse(s:  0);
        this._LastTurnDate = val_3;
        mem[1152921510255987064] = val_3.kind;
        this._Status = System.Convert.ToInt32(value:  0);
        this._MatchOutcome = System.Convert.ToInt32(value:  0);
    }
    public void SetOutcome(GK_TurnBasedMatchOutcome outcome)
    {
        if(this.Player == null)
        {
                return;
        }
        
        this._MatchOutcome = outcome;
        if((SA.Common.Pattern.Singleton<SA_EditorAd>.Instance) != null)
        {
                return;
        }
    
    }
    public void SetMatchId(string matchId)
    {
        this._MatchId = matchId;
    }
    public string get_PlayerId()
    {
        return (string)this._PlayerId;
    }
    public GK_Player get_Player()
    {
        return GameCenterManager.GetPlayerById(playerID:  null);
    }
    public string get_MatchId()
    {
        return (string)this._MatchId;
    }
    public System.DateTime get_TimeoutDate()
    {
        return new System.DateTime() {ticks = new System.TimeSpan() {_ticks = this._TimeoutDate}};
    }
    public System.DateTime get_LastTurnDate()
    {
        return new System.DateTime() {ticks = new System.TimeSpan() {_ticks = this._LastTurnDate}};
    }
    public GK_TurnBasedParticipantStatus get_Status()
    {
        return (GK_TurnBasedParticipantStatus)this._Status;
    }
    public GK_TurnBasedMatchOutcome get_MatchOutcome()
    {
        return (GK_TurnBasedMatchOutcome)this._MatchOutcome;
    }

}
