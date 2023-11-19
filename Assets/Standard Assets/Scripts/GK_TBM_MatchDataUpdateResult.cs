using UnityEngine;
public class GK_TBM_MatchDataUpdateResult : Result
{
    // Fields
    private GK_TBM_Match _Match;
    
    // Properties
    public GK_TBM_Match Match { get; }
    
    // Methods
    public GK_TBM_MatchDataUpdateResult(GK_TBM_Match updatedMatch)
    {
        this._Match = updatedMatch;
    }
    public GK_TBM_MatchDataUpdateResult(string errorData)
    {
        SA.Common.Models.Error val_1 = new SA.Common.Models.Error(errorData:  errorData);
    }
    public GK_TBM_MatchDataUpdateResult(SA.Common.Models.Error error)
    {
    
    }
    public GK_TBM_Match get_Match()
    {
        return (GK_TBM_Match)this._Match;
    }

}
