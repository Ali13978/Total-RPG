using UnityEngine;
[Serializable]
public class GK_LeaderBoardInfo
{
    // Fields
    public string Title;
    public string Description;
    public string Identifier;
    public UnityEngine.Texture2D Texture;
    public int MaxRange;
    
    // Methods
    public GK_LeaderBoardInfo()
    {
        var val_1;
        this.Title = "New Leaderboard";
        val_1 = null;
        val_1 = null;
        this.Description = System.String.Empty;
        this.Identifier = System.String.Empty;
    }

}
