using UnityEngine;
public class GK_SaveResult : Result
{
    // Fields
    private GK_SavedGame _SavedGame;
    
    // Properties
    public GK_SavedGame SavedGame { get; }
    
    // Methods
    public GK_SaveResult(GK_SavedGame save)
    {
        this._SavedGame = save;
    }
    public GK_SaveResult(string errorData)
    {
        SA.Common.Models.Error val_1 = new SA.Common.Models.Error(errorData:  errorData);
    }
    public GK_SaveResult(SA.Common.Models.Error error)
    {
    
    }
    public GK_SavedGame get_SavedGame()
    {
        return (GK_SavedGame)this._SavedGame;
    }

}
