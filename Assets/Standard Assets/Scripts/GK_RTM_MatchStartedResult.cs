using UnityEngine;
public class GK_RTM_MatchStartedResult : Result
{
    // Fields
    private GK_RTM_Match _Match;
    
    // Properties
    public GK_RTM_Match Match { get; }
    
    // Methods
    public GK_RTM_MatchStartedResult(GK_RTM_Match match)
    {
        this._Match = match;
    }
    public GK_RTM_MatchStartedResult(string errorData)
    {
        SA.Common.Models.Error val_1 = new SA.Common.Models.Error(errorData:  errorData);
    }
    public GK_RTM_Match get_Match()
    {
        return (GK_RTM_Match)this._Match;
    }

}
