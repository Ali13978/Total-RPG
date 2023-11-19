using UnityEngine;
public class GK_TBM_MatchEndResult : Result
{
    // Fields
    private GK_TBM_Match _Match;
    
    // Properties
    public GK_TBM_Match Match { get; }
    
    // Methods
    public GK_TBM_MatchEndResult(GK_TBM_Match match)
    {
        this._Match = match;
    }
    public GK_TBM_MatchEndResult(string errorData)
    {
        SA.Common.Models.Error val_1 = new SA.Common.Models.Error(errorData:  errorData);
    }
    public GK_TBM_Match get_Match()
    {
        return (GK_TBM_Match)this._Match;
    }

}
