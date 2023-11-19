using UnityEngine;
[System.Runtime.CompilerServices.ExtensionAttribute]
public static class TurnExtensions
{
    // Fields
    public static readonly string TurnPropKey;
    public static readonly string TurnStartPropKey;
    public static readonly string FinishedTurnPropKey;
    
    // Methods
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static void SetTurn(Room room, int turn, bool setStartTime = False)
    {
        string val_4;
        var val_5;
        var val_6;
        val_4 = W3;
        if(turn == 0)
        {
                return;
        }
        
        if(turn.CustomProperties == null)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        set_Item(key:  TurnExtensions.TurnPropKey, value:  setStartTime);
        if((val_4 & 1) != 0)
        {
                val_6 = null;
            val_6 = null;
            val_4 = TurnExtensions.TurnStartPropKey;
            set_Item(key:  val_4, value:  PhotonNetwork.ServerTimestamp);
        }
        
        turn.SetCustomProperties(propertiesToSet:  new ExitGames.Client.Photon.Hashtable(), expectedValues:  0, webForward:  false);
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static int GetTurn(RoomInfo room)
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_8 = X1;
        if((val_8 != 0) && (val_8.CustomProperties != null))
        {
                val_9 = null;
            val_9 = null;
            if((val_8.CustomProperties.ContainsKey(key:  TurnExtensions.TurnPropKey)) != false)
        {
                val_10 = null;
            val_10 = null;
            object val_5 = val_8.CustomProperties.Item[TurnExtensions.TurnPropKey];
            val_8 = null;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            return (int)val_11;
        }
        
        }
        
        val_11 = 0;
        return (int)val_11;
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static int GetTurnStart(RoomInfo room)
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_8 = X1;
        if((val_8 != 0) && (val_8.CustomProperties != null))
        {
                val_9 = null;
            val_9 = null;
            if((val_8.CustomProperties.ContainsKey(key:  TurnExtensions.TurnStartPropKey)) != false)
        {
                val_10 = null;
            val_10 = null;
            object val_5 = val_8.CustomProperties.Item[TurnExtensions.TurnStartPropKey];
            val_8 = null;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            return (int)val_11;
        }
        
        }
        
        val_11 = 0;
        return (int)val_11;
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static int GetFinishedTurn(PhotonPlayer player)
    {
        var val_11;
        string val_12;
        var val_13;
        var val_14;
        var val_15;
        val_11 = PhotonNetwork.room;
        if((val_11 != null) && (val_11.CustomProperties != null))
        {
                val_12 = val_11.CustomProperties;
            val_13 = null;
            val_13 = null;
            if((val_12.ContainsKey(key:  TurnExtensions.TurnPropKey)) != false)
        {
                val_14 = null;
            val_14 = null;
            val_12 = TurnExtensions.FinishedTurnPropKey;
            int val_5 = X1.ID;
            object val_8 = val_11.CustomProperties.Item[0 + val_12];
            val_11 = null;
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            return (int)val_15;
        }
        
        }
        
        val_15 = 0;
        return (int)val_15;
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static void SetFinishedTurn(PhotonPlayer player, int turn)
    {
        object val_6;
        ExitGames.Client.Photon.Hashtable val_7;
        var val_8;
        val_6 = W2;
        val_7 = turn;
        Room val_1 = PhotonNetwork.room;
        if(val_1 == null)
        {
                return;
        }
        
        if(val_1.CustomProperties == null)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        int val_3 = val_7.ID;
        ExitGames.Client.Photon.Hashtable val_5 = null;
        val_7 = val_5;
        val_5 = new ExitGames.Client.Photon.Hashtable();
        val_6 = val_6;
        set_Item(key:  0 + TurnExtensions.FinishedTurnPropKey, value:  val_6);
        val_1.SetCustomProperties(propertiesToSet:  val_7, expectedValues:  0, webForward:  false);
    }
    private static TurnExtensions()
    {
        TurnExtensions.TurnPropKey = "Turn";
        TurnExtensions.TurnStartPropKey = "TStart";
        TurnExtensions.FinishedTurnPropKey = "FToA";
    }

}
