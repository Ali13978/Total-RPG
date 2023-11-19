using UnityEngine;
public class GK_SavesResolveResult : Result
{
    // Fields
    private System.Collections.Generic.List<GK_SavedGame> _ResolvedSaves;
    
    // Properties
    public System.Collections.Generic.List<GK_SavedGame> SavedGames { get; }
    
    // Methods
    public GK_SavesResolveResult(System.Collections.Generic.List<GK_SavedGame> saves)
    {
        this._ResolvedSaves = new System.Collections.Generic.List<GK_SavedGame>();
        this._ResolvedSaves = saves;
    }
    public GK_SavesResolveResult(SA.Common.Models.Error error)
    {
        this._ResolvedSaves = new System.Collections.Generic.List<GK_SavedGame>();
    }
    public GK_SavesResolveResult(string errorData)
    {
        this._ResolvedSaves = new System.Collections.Generic.List<GK_SavedGame>();
        SA.Common.Models.Error val_2 = new SA.Common.Models.Error(errorData:  errorData);
    }
    public System.Collections.Generic.List<GK_SavedGame> get_SavedGames()
    {
        return (System.Collections.Generic.List<GK_SavedGame>)this._ResolvedSaves;
    }

}
