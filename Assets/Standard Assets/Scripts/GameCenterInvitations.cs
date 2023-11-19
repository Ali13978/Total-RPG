using UnityEngine;
public class GameCenterInvitations : Singleton<GameCenterInvitations>
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_Player, GK_InviteRecipientResponse> ActionInviteeResponse;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_MatchType, GK_Invite> ActionPlayerAcceptedInvitation;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_MatchType, string[], GK_Player[]> ActionPlayerRequestedMatchWithRecipients;
    
    // Methods
    public GameCenterInvitations()
    {
    
    }
    public static void add_ActionInviteeResponse(System.Action<GK_Player, GK_InviteRecipientResponse> value)
    {
        var val_3;
        System.Action<GK_Player, GK_InviteRecipientResponse> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterInvitations.ActionInviteeResponse;
        System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  null);
        val_5 = 0;
        if(val_1 == null)
        {
                return;
        }
        
        val_5 = val_1;
        if(null == null)
        {
                return;
        }
        
        val_5 = 0;
    }
    public static void remove_ActionInviteeResponse(System.Action<GK_Player, GK_InviteRecipientResponse> value)
    {
        var val_3;
        System.Action<GK_Player, GK_InviteRecipientResponse> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterInvitations.ActionInviteeResponse;
        System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  null);
        val_5 = 0;
        if(val_1 == null)
        {
                return;
        }
        
        val_5 = val_1;
        if(null == null)
        {
                return;
        }
        
        val_5 = 0;
    }
    public static void add_ActionPlayerAcceptedInvitation(System.Action<GK_MatchType, GK_Invite> value)
    {
        var val_3;
        System.Action<GK_MatchType, GK_Invite> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterInvitations.ActionPlayerAcceptedInvitation;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenterInvitations.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504841035784 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionPlayerAcceptedInvitation(System.Action<GK_MatchType, GK_Invite> value)
    {
        var val_3;
        System.Action<GK_MatchType, GK_Invite> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterInvitations.ActionPlayerAcceptedInvitation;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenterInvitations.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504841035784 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_ActionPlayerRequestedMatchWithRecipients(System.Action<GK_MatchType, string[], GK_Player[]> value)
    {
        var val_3;
        System.Action<GK_MatchType, System.String[], GK_Player[]> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterInvitations.ActionPlayerRequestedMatchWithRecipients;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenterInvitations.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504841035792 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionPlayerRequestedMatchWithRecipients(System.Action<GK_MatchType, string[], GK_Player[]> value)
    {
        var val_3;
        System.Action<GK_MatchType, System.String[], GK_Player[]> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenterInvitations.ActionPlayerRequestedMatchWithRecipients;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenterInvitations.__il2cppRuntimeField_static_fields;
        label_3:
        System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
        val_5 = 0;
        if(val_1 != null)
        {
                val_5 = val_1;
            if(null != null)
        {
                val_5 = 0;
        }
        
        }
        
        if(1152921504841035792 != val_4)
        {
            goto label_8;
        }
    
    }
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
    }
    public void Init()
    {
    
    }
    private void OnInviteeResponse(string data)
    {
        var val_4;
        ISN_Logger.Log(message:  0, logType:  "OnInviteeResponse");
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        System.String[] val_1 = data.Split(separator:  null);
        string val_4 = val_1[0];
        string val_5 = val_1[1];
        val_4 = null;
        val_4 = null;
        GameCenterInvitations.ActionInviteeResponse.Invoke(arg1:  GameCenterManager.GetPlayerById(playerID:  null), arg2:  System.Convert.ToInt32(value:  0));
    }
    private void OnPlayerAcceptedInvitation_RTM(string data)
    {
        var val_2;
        ISN_Logger.Log(message:  0, logType:  "OnPlayerAcceptedInvitation_RTM");
        val_2 = null;
        val_2 = null;
        GameCenterInvitations.ActionPlayerAcceptedInvitation.Invoke(arg1:  1, arg2:  new GK_Invite(inviteData:  data));
    }
    private void OnPlayerRequestedMatchWithRecipients_RTM(string data)
    {
        var val_5;
        var val_6;
        ISN_Logger.Log(message:  0, logType:  "OnPlayerRequestedMatchWithRecipients_RTM");
        System.String[] val_1 = SA.Common.Data.Converter.ParseArray(arrayData:  0, splitter:  data);
        System.Collections.Generic.List<GK_Player> val_2 = new System.Collections.Generic.List<GK_Player>();
        val_5 = 0;
        goto label_1;
        label_8:
        Add(item:  X21);
        val_5 = 1;
        label_1:
        if(val_5 >= val_1.Length)
        {
            goto label_3;
        }
        
        string val_5 = val_1[1];
        GK_Player val_3 = GameCenterManager.GetPlayerById(playerID:  null);
        if(null != 0)
        {
            goto label_8;
        }
        
        goto label_8;
        label_3:
        val_6 = null;
        val_6 = null;
        GameCenterInvitations.ActionPlayerRequestedMatchWithRecipients.Invoke(arg1:  1, arg2:  val_1, arg3:  ToArray());
    }
    private void OnPlayerAcceptedInvitation_TBM(string data)
    {
        var val_2;
        ISN_Logger.Log(message:  0, logType:  "OnPlayerAcceptedInvitation_TBM");
        val_2 = null;
        val_2 = null;
        GameCenterInvitations.ActionPlayerAcceptedInvitation.Invoke(arg1:  0, arg2:  new GK_Invite(inviteData:  data));
    }
    private void OnPlayerRequestedMatchWithRecipients_TBM(string data)
    {
        var val_5;
        var val_6;
        ISN_Logger.Log(message:  0, logType:  "OnPlayerRequestedMatchWithRecipients_TBM");
        System.String[] val_1 = SA.Common.Data.Converter.ParseArray(arrayData:  0, splitter:  data);
        System.Collections.Generic.List<GK_Player> val_2 = new System.Collections.Generic.List<GK_Player>();
        val_5 = 0;
        goto label_1;
        label_8:
        Add(item:  X21);
        val_5 = 1;
        label_1:
        if(val_5 >= val_1.Length)
        {
            goto label_3;
        }
        
        string val_5 = val_1[1];
        GK_Player val_3 = GameCenterManager.GetPlayerById(playerID:  null);
        if(null != 0)
        {
            goto label_8;
        }
        
        goto label_8;
        label_3:
        val_6 = null;
        val_6 = null;
        GameCenterInvitations.ActionPlayerRequestedMatchWithRecipients.Invoke(arg1:  1, arg2:  val_1, arg3:  ToArray());
    }
    private static GameCenterInvitations()
    {
        GameCenterInvitations.ActionInviteeResponse = new System.Action<GK_Player, GK_InviteRecipientResponse>(object:  0, method:  static System.Void GameCenterInvitations::<ActionInviteeResponse>m__0(GK_Player , GK_InviteRecipientResponse ));
        GameCenterInvitations.ActionPlayerAcceptedInvitation = new System.Action<GK_MatchType, GK_Invite>(object:  0, method:  static System.Void GameCenterInvitations::<ActionPlayerAcceptedInvitation>m__1(GK_MatchType , GK_Invite ));
        GameCenterInvitations.ActionPlayerRequestedMatchWithRecipients = new System.Action<GK_MatchType, System.String[], GK_Player[]>(object:  0, method:  static System.Void GameCenterInvitations::<ActionPlayerRequestedMatchWithRecipients>m__2(GK_MatchType , string[] , GK_Player[] ));
    }
    private static void <ActionInviteeResponse>m__0(GK_Player , GK_InviteRecipientResponse )
    {
    
    }
    private static void <ActionPlayerAcceptedInvitation>m__1(GK_MatchType , GK_Invite )
    {
    
    }
    private static void <ActionPlayerRequestedMatchWithRecipients>m__2(GK_MatchType , string[] , GK_Player[] )
    {
    
    }

}
