using UnityEngine;
public class GK_TBM_LoadMatchesResult : Result
{
    // Fields
    public System.Collections.Generic.Dictionary<string, GK_TBM_Match> LoadedMatches;
    
    // Methods
    public GK_TBM_LoadMatchesResult(bool IsResultSucceeded)
    {
        this.LoadedMatches = new System.Collections.Generic.Dictionary<System.String, GK_TBM_Match>();
    }
    public GK_TBM_LoadMatchesResult(string errorData)
    {
        this.LoadedMatches = new System.Collections.Generic.Dictionary<System.String, GK_TBM_Match>();
        SA.Common.Models.Error val_2 = new SA.Common.Models.Error(errorData:  errorData);
    }

}
