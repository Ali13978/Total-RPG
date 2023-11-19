using UnityEngine;
[Serializable]
private class EndlessGameManager_Deathmatch.PlayerData : IDeatchmatchPlayerScore
{
    // Fields
    [UnityEngine.SerializeField]
    private int playerID;
    [UnityEngine.SerializeField]
    private int score;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private TzarGames.GameFramework.Player <Player>k__BackingField;
    
    // Properties
    public TzarGames.GameFramework.Player Player { get; set; }
    public int PlayerID { get; }
    public int Score { get; set; }
    
    // Methods
    public EndlessGameManager_Deathmatch.PlayerData(TzarGames.GameFramework.Player player)
    {
        this.<Player>k__BackingField = player;
        this.playerID = player.NetworkPlayer;
    }
    public TzarGames.GameFramework.Player get_Player()
    {
        return (TzarGames.GameFramework.Player)this.<Player>k__BackingField;
    }
    private void set_Player(TzarGames.GameFramework.Player value)
    {
        this.<Player>k__BackingField = value;
    }
    public int get_PlayerID()
    {
        return (int)this.playerID;
    }
    public int get_Score()
    {
        return (int)this.score;
    }
    public void set_Score(int value)
    {
        this.score = value;
    }

}
