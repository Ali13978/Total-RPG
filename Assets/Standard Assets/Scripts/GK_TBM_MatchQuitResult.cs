using UnityEngine;
public class GK_TBM_MatchQuitResult : Result
{
    // Fields
    private string _MatchId;
    
    // Properties
    public string MatchId { get; }
    
    // Methods
    public GK_TBM_MatchQuitResult(string matchId)
    {
        this._MatchId = matchId;
    }
    public GK_TBM_MatchQuitResult()
    {
        SA.Common.Models.Error val_1 = new SA.Common.Models.Error();
    }
    public string get_MatchId()
    {
        return (string)this._MatchId;
    }

}
