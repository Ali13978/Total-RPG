using UnityEngine;
public class GK_TBM_MatchRemovedResult : Result
{
    // Fields
    private string _MatchId;
    
    // Properties
    public string MatchId { get; }
    
    // Methods
    public GK_TBM_MatchRemovedResult(string matchId)
    {
        this._MatchId = matchId;
    }
    public GK_TBM_MatchRemovedResult()
    {
        SA.Common.Models.Error val_1 = new SA.Common.Models.Error();
    }
    public string get_MatchId()
    {
        return (string)this._MatchId;
    }

}
