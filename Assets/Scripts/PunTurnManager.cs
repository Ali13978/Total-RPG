using UnityEngine;
public class PunTurnManager : PunBehaviour
{
    // Fields
    public float TurnDuration;
    public IPunTurnManagerCallbacks TurnManagerListener;
    private readonly System.Collections.Generic.HashSet<PhotonPlayer> finishedPlayers;
    public const byte TurnManagerEventOffset = 0;
    public const byte EvMove = 1;
    public const byte EvFinalMove = 2;
    private bool _isOverCallProcessed;
    
    // Properties
    public int Turn { get; set; }
    public float ElapsedTimeInTurn { get; }
    public float RemainingSecondsInTurn { get; }
    public bool IsCompletedByAll { get; }
    public bool IsFinishedByMe { get; }
    public bool IsOver { get; }
    
    // Methods
    public PunTurnManager()
    {
        this.TurnDuration = 20f;
        this.finishedPlayers = new System.Collections.Generic.HashSet<PhotonPlayer>();
        this = new UnityEngine.MonoBehaviour();
    }
    public int get_Turn()
    {
        Room val_1 = PhotonNetwork.room;
        return TurnExtensions.GetTurn(room:  0);
    }
    private void set_Turn(int value)
    {
        this._isOverCallProcessed = false;
        TurnExtensions.SetTurn(room:  0, turn:  PhotonNetwork.room, setStartTime:  value);
    }
    public float get_ElapsedTimeInTurn()
    {
        Room val_2 = PhotonNetwork.room;
        float val_5 = 1000f;
        val_5 = ((float)PhotonNetwork.ServerTimestamp - (TurnExtensions.GetTurnStart(room:  0))) / val_5;
        return (float)val_5;
    }
    public float get_RemainingSecondsInTurn()
    {
        return UnityEngine.Mathf.Max(a:  0f, b:  this.TurnDuration - this.ElapsedTimeInTurn);
    }
    public bool get_IsCompletedByAll()
    {
        var val_7;
        var val_8;
        val_7 = this;
        Room val_1 = PhotonNetwork.room;
        if(val_1 != null)
        {
                if(val_1.Turn >= 1)
        {
                val_7 = this.finishedPlayers.Count;
            var val_6 = (val_7 == PhotonNetwork.room.PlayerCount) ? 1 : 0;
            return (bool)val_8;
        }
        
        }
        
        val_8 = 0;
        return (bool)val_8;
    }
    public bool get_IsFinishedByMe()
    {
        if(this.finishedPlayers != null)
        {
                return this.finishedPlayers.Contains(item:  PhotonNetwork.player);
        }
        
        return this.finishedPlayers.Contains(item:  PhotonNetwork.player);
    }
    public bool get_IsOver()
    {
        return (bool)(this.RemainingSecondsInTurn <= 0f) ? 1 : 0;
    }
    private void Start()
    {
        var val_1;
        typeof(PhotonNetwork.EventCallback).__il2cppRuntimeField_20 = this;
        typeof(PhotonNetwork.EventCallback).__il2cppRuntimeField_28 = public System.Void PunTurnManager::OnEvent(byte eventCode, object content, int senderId);
        typeof(PhotonNetwork.EventCallback).__il2cppRuntimeField_10 = public System.Void PunTurnManager::OnEvent(byte eventCode, object content, int senderId);
        val_1 = null;
        val_1 = null;
        PhotonNetwork.OnEventCall = null;
    }
    private void Update()
    {
        var val_5;
        if(this.Turn < 1)
        {
                return;
        }
        
        if(this.RemainingSecondsInTurn > 0f)
        {
                return;
        }
        
        if(this._isOverCallProcessed != false)
        {
                return;
        }
        
        this._isOverCallProcessed = true;
        int val_3 = this.Turn;
        var val_5 = 0;
        val_5 = val_5 + 1;
        val_5 = this.TurnManagerListener;
        goto val_3;
    }
    public void BeginTurn()
    {
        this.Turn = this.Turn + 1;
    }
    public void SendMove(object move, bool finished)
    {
        var val_10;
        if(this.IsFinishedByMe != false)
        {
                UnityEngine.Debug.LogWarning(message:  0);
            return;
        }
        
        ExitGames.Client.Photon.Hashtable val_2 = new ExitGames.Client.Photon.Hashtable();
        int val_3 = val_2.Turn;
        if(null != 0)
        {
                Add(key:  "turn", value:  val_3);
        }
        else
        {
                0.Add(key:  "turn", value:  val_3);
        }
        
        0.Add(key:  "move", value:  move);
        object val_5 = null;
        object val_4 = (finished != true) ? (1 + 1) : 1;
        val_10 = val_5;
        val_5 = new System.Object();
        typeof(RaiseEventOptions).__il2cppRuntimeField_10 = 4;
        bool val_6 = PhotonNetwork.RaiseEvent(eventCode:  0, eventContent:  val_4, sendReliable:  false, options:  1);
        if(finished != false)
        {
                PhotonPlayer val_7 = PhotonNetwork.player;
            val_10 = val_7.Turn;
            TurnExtensions.SetFinishedTurn(player:  0, turn:  val_7);
        }
        
        PhotonPlayer val_9 = PhotonNetwork.player;
        this.OnEvent(eventCode:  val_4, content:  val_2, senderId:  val_9.actorID);
    }
    public bool GetPlayerFinishedTurn(PhotonPlayer player)
    {
        var val_3;
        if((player != null) && (this.finishedPlayers != null))
        {
                if((this.finishedPlayers.Contains(item:  player)) != false)
        {
                val_3 = 1;
            return (bool)val_3;
        }
        
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    public void OnEvent(byte eventCode, object content, int senderId)
    {
        var val_19;
        IPunTurnManagerCallbacks val_20;
        var val_21;
        var val_22;
        PhotonPlayer val_23;
        var val_24;
        var val_25;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        val_21 = content;
        val_22 = this;
        val_23 = PhotonPlayer.Find(ID:  20224);
        byte val_2 = eventCode & 255;
        if(val_2 == 2)
        {
            goto label_1;
        }
        
        if(val_2 != 1)
        {
                return;
        }
        
        object val_3 = 0.Item["turn"];
        val_25 = null;
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        object val_5 = 0.Item["move"];
        var val_17 = 0;
        val_24 = 1152921504977489928;
        val_17 = val_17 + 1;
        val_24 = 1152921504977489944;
        val_27 = this.TurnManagerListener;
        goto label_13;
        label_1:
        val_20 = 0.Item["turn"];
        val_25 = null;
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        val_29 = 0;
        object val_8 = 0.Item["move"];
        val_21 = val_8;
        if(null != val_8.Turn)
        {
            goto label_20;
        }
        
        bool val_10 = this.finishedPlayers.Add(item:  val_23);
        val_20 = this.TurnManagerListener;
        var val_18 = 0;
        val_24 = 1152921504977489928;
        val_18 = val_18 + 1;
        val_30 = val_20;
        goto label_26;
        label_13:
        val_19 = ???;
        val_22 = ???;
        val_23 = ???;
        val_28 = ???;
        val_21 = ???;
        val_20 = ???;
        val_24 = val_24 + 3;
        label_26:
        val_29 = val_28;
        label_20:
        bool val_12 = val_22.IsCompletedByAll;
        if(val_12 == false)
        {
                return;
        }
        
        int val_13 = val_12.Turn;
        var val_22 = val_22 + 40;
        if((val_22 + 40 + 258) == 0)
        {
            goto label_29;
        }
        
        var val_19 = val_22 + 40 + 152;
        var val_20 = 0;
        val_19 = val_19 + 8;
        label_31:
        if(((val_22 + 40 + 152 + 8) + -8) == null)
        {
            goto label_30;
        }
        
        val_20 = val_20 + 1;
        val_19 = val_19 + 16;
        if(val_20 < (val_22 + 40 + 258))
        {
            goto label_31;
        }
        
        label_29:
        val_29 = 1;
        val_31 = val_22 + 40;
        goto label_32;
        label_30:
        var val_21 = val_19;
        val_21 = val_21 + 1;
        val_22 = val_22 + val_21;
        val_31 = val_22 + 272;
        label_32:
        var val_14 = val_19 - 48;
        goto ((val_22 + 40 + ((val_22 + 40 + 152 + 8) + 1)) + 272);
    }
    public override void OnPhotonCustomRoomPropertiesChanged(ExitGames.Client.Photon.Hashtable propertiesThatChanged)
    {
        var val_4;
        var val_5;
        val_4 = public System.Boolean System.Collections.Generic.Dictionary<System.Object, System.Object>::ContainsKey(System.Object key);
        if((propertiesThatChanged.ContainsKey(key:  "Turn")) == false)
        {
                return;
        }
        
        this._isOverCallProcessed = false;
        this.finishedPlayers.Clear();
        int val_2 = this.finishedPlayers.Turn;
        var val_4 = 0;
        val_4 = val_4 + 1;
        val_4 = 0;
        val_5 = this.TurnManagerListener;
        goto val_2;
    }

}
