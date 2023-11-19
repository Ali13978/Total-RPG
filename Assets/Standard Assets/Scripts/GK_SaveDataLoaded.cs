using UnityEngine;
public class GK_SaveDataLoaded : Result
{
    // Fields
    private GK_SavedGame _SavedGame;
    
    // Properties
    public GK_SavedGame SavedGame { get; }
    
    // Methods
    public GK_SaveDataLoaded(GK_SavedGame save)
    {
        this._SavedGame = save;
    }
    public GK_SaveDataLoaded(SA.Common.Models.Error error)
    {
    
    }
    public GK_SavedGame get_SavedGame()
    {
        return (GK_SavedGame)this._SavedGame;
    }

}
