using UnityEngine;
public class GK_FetchResult : Result
{
    // Fields
    private System.Collections.Generic.List<GK_SavedGame> _SavedGames;
    
    // Properties
    public System.Collections.Generic.List<GK_SavedGame> SavedGames { get; }
    
    // Methods
    public GK_FetchResult(System.Collections.Generic.List<GK_SavedGame> saves)
    {
        this._SavedGames = new System.Collections.Generic.List<GK_SavedGame>();
        this._SavedGames = saves;
    }
    public GK_FetchResult(string errorData)
    {
        this._SavedGames = new System.Collections.Generic.List<GK_SavedGame>();
        SA.Common.Models.Error val_2 = new SA.Common.Models.Error(errorData:  errorData);
    }
    public System.Collections.Generic.List<GK_SavedGame> get_SavedGames()
    {
        return (System.Collections.Generic.List<GK_SavedGame>)this._SavedGames;
    }

}
