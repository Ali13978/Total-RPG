using UnityEngine;
[Serializable]
private class EndlessGameManager_Deathmatch.MatchState
{
    // Fields
    public double MatchStartTime;
    public System.Collections.Generic.List<TzarGames.Endless.EndlessGameManager_Deathmatch.PlayerData> PlayerDatas;
    
    // Methods
    public EndlessGameManager_Deathmatch.MatchState()
    {
        this.PlayerDatas = new System.Collections.Generic.List<PlayerData>();
    }
    public TzarGames.Endless.EndlessGameManager_Deathmatch.PlayerData GetPlayerData(TzarGames.GameFramework.Player player)
    {
        TzarGames.GameFramework.NetworkPlayer val_3;
        var val_4;
        var val_5;
        val_4 = player;
        if(player.NetworkPlayer == null)
        {
            goto label_11;
        }
        
        List.Enumerator<T> val_1 = this.PlayerDatas.GetEnumerator();
        label_8:
        if((0 & 1) == 0)
        {
            goto label_4;
        }
        
        val_5 = 0.InitializationCallback;
        val_3 = player.NetworkPlayer;
        if(W24 != val_3)
        {
            goto label_8;
        }
        
        0.Dispose();
        return (PlayerData)val_5;
        label_4:
        0.Dispose();
        label_11:
        val_5 = 0;
        return (PlayerData)val_5;
    }

}
