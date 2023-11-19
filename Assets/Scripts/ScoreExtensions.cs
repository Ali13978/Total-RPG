using UnityEngine;
[System.Runtime.CompilerServices.ExtensionAttribute]
public static class ScoreExtensions
{
    // Methods
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static void SetScore(PhotonPlayer player, int newScore)
    {
        set_Item(key:  "score", value:  W2);
        newScore.SetCustomProperties(propertiesToSet:  new ExitGames.Client.Photon.Hashtable(), expectedValues:  0, webForward:  false);
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static void AddScore(PhotonPlayer player, int scoreToAddToCurrent)
    {
        set_Item(key:  "score", value:  (ScoreExtensions.GetScore(player:  22394)) + W2);
        scoreToAddToCurrent.SetCustomProperties(propertiesToSet:  new ExitGames.Client.Photon.Hashtable(), expectedValues:  0, webForward:  false);
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static int GetScore(PhotonPlayer player)
    {
        var val_5;
        var val_6;
        val_5 = mem[X1 + 48];
        val_5 = X1 + 48;
        if((val_5.TryGetValue(key:  "score", value: out  0)) != false)
        {
                val_5 = null;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            val_6 = 1179403647;
            return (int)val_6;
        }
        
        val_6 = 0;
        return (int)val_6;
    }

}
