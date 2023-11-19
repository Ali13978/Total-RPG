using UnityEngine;
public class GameCenter_TBM : Singleton<GameCenter_TBM>
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_TBM_LoadMatchResult> ActionMatchInfoLoaded;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_TBM_LoadMatchesResult> ActionMatchesInfoLoaded;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_TBM_MatchDataUpdateResult> ActionMatchDataUpdated;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_TBM_MatchInitResult> ActionMatchFound;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_TBM_MatchQuitResult> ActionMatchQuit;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_TBM_EndTrunResult> ActionTrunEnded;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_TBM_MatchEndResult> ActionMacthEnded;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_TBM_RematchResult> ActionRematched;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_TBM_MatchRemovedResult> ActionMatchRemoved;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_TBM_MatchInitResult> ActionMatchInvitationAccepted;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_TBM_MatchRemovedResult> ActionMatchInvitationDeclined;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_TBM_Match> ActionPlayerQuitForMatch;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private static System.Action<GK_TBM_MatchTurnResult> ActionTrunReceived;
    private System.Collections.Generic.Dictionary<string, GK_TBM_Match> _Matches;
    
    // Properties
    public System.Collections.Generic.Dictionary<string, GK_TBM_Match> Matches { get; }
    public System.Collections.Generic.List<GK_TBM_Match> MatchesList { get; }
    
    // Methods
    public GameCenter_TBM()
    {
        this._Matches = new System.Collections.Generic.Dictionary<System.String, GK_TBM_Match>();
    }
    public static void add_ActionMatchInfoLoaded(System.Action<GK_TBM_LoadMatchResult> value)
    {
        var val_3;
        System.Action<GK_TBM_LoadMatchResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_TBM.ActionMatchInfoLoaded;
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
    public static void remove_ActionMatchInfoLoaded(System.Action<GK_TBM_LoadMatchResult> value)
    {
        var val_3;
        System.Action<GK_TBM_LoadMatchResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_TBM.ActionMatchInfoLoaded;
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
    public static void add_ActionMatchesInfoLoaded(System.Action<GK_TBM_LoadMatchesResult> value)
    {
        var val_3;
        System.Action<GK_TBM_LoadMatchesResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_TBM.ActionMatchesInfoLoaded;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_TBM.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504840982536 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionMatchesInfoLoaded(System.Action<GK_TBM_LoadMatchesResult> value)
    {
        var val_3;
        System.Action<GK_TBM_LoadMatchesResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_TBM.ActionMatchesInfoLoaded;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_TBM.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504840982536 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_ActionMatchDataUpdated(System.Action<GK_TBM_MatchDataUpdateResult> value)
    {
        var val_3;
        System.Action<GK_TBM_MatchDataUpdateResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_TBM.ActionMatchDataUpdated;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_TBM.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504840982544 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionMatchDataUpdated(System.Action<GK_TBM_MatchDataUpdateResult> value)
    {
        var val_3;
        System.Action<GK_TBM_MatchDataUpdateResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_TBM.ActionMatchDataUpdated;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_TBM.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504840982544 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_ActionMatchFound(System.Action<GK_TBM_MatchInitResult> value)
    {
        var val_3;
        System.Action<GK_TBM_MatchInitResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_TBM.ActionMatchFound;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_TBM.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504840982552 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionMatchFound(System.Action<GK_TBM_MatchInitResult> value)
    {
        var val_3;
        System.Action<GK_TBM_MatchInitResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_TBM.ActionMatchFound;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_TBM.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504840982552 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_ActionMatchQuit(System.Action<GK_TBM_MatchQuitResult> value)
    {
        var val_3;
        System.Action<GK_TBM_MatchQuitResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_TBM.ActionMatchQuit;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_TBM.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504840982560 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionMatchQuit(System.Action<GK_TBM_MatchQuitResult> value)
    {
        var val_3;
        System.Action<GK_TBM_MatchQuitResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_TBM.ActionMatchQuit;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_TBM.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504840982560 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_ActionTrunEnded(System.Action<GK_TBM_EndTrunResult> value)
    {
        var val_3;
        System.Action<GK_TBM_EndTrunResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_TBM.ActionTrunEnded;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_TBM.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504840982568 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionTrunEnded(System.Action<GK_TBM_EndTrunResult> value)
    {
        var val_3;
        System.Action<GK_TBM_EndTrunResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_TBM.ActionTrunEnded;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_TBM.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504840982568 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_ActionMacthEnded(System.Action<GK_TBM_MatchEndResult> value)
    {
        var val_3;
        System.Action<GK_TBM_MatchEndResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_TBM.ActionMacthEnded;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_TBM.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504840982576 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionMacthEnded(System.Action<GK_TBM_MatchEndResult> value)
    {
        var val_3;
        System.Action<GK_TBM_MatchEndResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_TBM.ActionMacthEnded;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_TBM.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504840982576 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_ActionRematched(System.Action<GK_TBM_RematchResult> value)
    {
        var val_3;
        System.Action<GK_TBM_RematchResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_TBM.ActionRematched;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_TBM.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504840982584 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionRematched(System.Action<GK_TBM_RematchResult> value)
    {
        var val_3;
        System.Action<GK_TBM_RematchResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_TBM.ActionRematched;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_TBM.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504840982584 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_ActionMatchRemoved(System.Action<GK_TBM_MatchRemovedResult> value)
    {
        var val_3;
        System.Action<GK_TBM_MatchRemovedResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_TBM.ActionMatchRemoved;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_TBM.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504840982592 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionMatchRemoved(System.Action<GK_TBM_MatchRemovedResult> value)
    {
        var val_3;
        System.Action<GK_TBM_MatchRemovedResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_TBM.ActionMatchRemoved;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_TBM.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504840982592 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_ActionMatchInvitationAccepted(System.Action<GK_TBM_MatchInitResult> value)
    {
        var val_3;
        System.Action<GK_TBM_MatchInitResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_TBM.ActionMatchInvitationAccepted;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_TBM.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504840982600 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionMatchInvitationAccepted(System.Action<GK_TBM_MatchInitResult> value)
    {
        var val_3;
        System.Action<GK_TBM_MatchInitResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_TBM.ActionMatchInvitationAccepted;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_TBM.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504840982600 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_ActionMatchInvitationDeclined(System.Action<GK_TBM_MatchRemovedResult> value)
    {
        var val_3;
        System.Action<GK_TBM_MatchRemovedResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_TBM.ActionMatchInvitationDeclined;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_TBM.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504840982608 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionMatchInvitationDeclined(System.Action<GK_TBM_MatchRemovedResult> value)
    {
        var val_3;
        System.Action<GK_TBM_MatchRemovedResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_TBM.ActionMatchInvitationDeclined;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_TBM.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504840982608 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_ActionPlayerQuitForMatch(System.Action<GK_TBM_Match> value)
    {
        var val_3;
        System.Action<GK_TBM_Match> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_TBM.ActionPlayerQuitForMatch;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_TBM.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504840982616 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionPlayerQuitForMatch(System.Action<GK_TBM_Match> value)
    {
        var val_3;
        System.Action<GK_TBM_Match> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_TBM.ActionPlayerQuitForMatch;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_TBM.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504840982616 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void add_ActionTrunReceived(System.Action<GK_TBM_MatchTurnResult> value)
    {
        var val_3;
        System.Action<GK_TBM_MatchTurnResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_TBM.ActionTrunReceived;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_TBM.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504840982624 != val_4)
        {
            goto label_8;
        }
    
    }
    public static void remove_ActionTrunReceived(System.Action<GK_TBM_MatchTurnResult> value)
    {
        var val_3;
        System.Action<GK_TBM_MatchTurnResult> val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = GameCenter_TBM.ActionTrunReceived;
        goto label_3;
        label_8:
        val_3 = null;
        val_4 = GameCenter_TBM.__il2cppRuntimeField_static_fields;
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
        
        if(1152921504840982624 != val_4)
        {
            goto label_8;
        }
    
    }
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
    }
    public void LoadMatchesInfo()
    {
    
    }
    public void LoadMatch(string matchId)
    {
    
    }
    public void FindMatch(int minPlayers, int maxPlayers, string msg = "", string[] playersToInvite)
    {
    
    }
    public void FindMatchWithNativeUI(int minPlayers, int maxPlayers, string msg = "", string[] playersToInvite)
    {
    
    }
    public void SetPlayerGroup(int group)
    {
    
    }
    public void SetPlayerAttributes(int attributes)
    {
    
    }
    public void SaveCurrentTurn(string matchId, byte[] matchData)
    {
    
    }
    public void EndTurn(string matchId, byte[] matchData, string nextPlayerId)
    {
    
    }
    public void QuitInTurn(string matchId, GK_TurnBasedMatchOutcome outcome, string nextPlayerId, byte[] matchData)
    {
    
    }
    public void QuitOutOfTurn(string matchId, GK_TurnBasedMatchOutcome outcome)
    {
    
    }
    public void EndMatch(string matchId, byte[] matchData)
    {
    
    }
    public void Rematch(string matchId)
    {
    
    }
    public void RemoveMatch(string matchId)
    {
    
    }
    public void AcceptInvite(string matchId)
    {
    
    }
    public void DeclineInvite(string matchId)
    {
    
    }
    public void UpdateParticipantOutcome(string matchId, int outcome, string playerId)
    {
    
    }
    public GK_TBM_Match GetMatchById(string matchId)
    {
        var val_3;
        if((this._Matches.ContainsKey(key:  matchId)) != false)
        {
                GK_TBM_Match val_2 = this._Matches.Item[matchId];
            return (GK_TBM_Match)val_3;
        }
        
        val_3 = 0;
        return (GK_TBM_Match)val_3;
    }
    public static void PrintMatchInfo(GK_TBM_Match match)
    {
        var val_27;
        string val_29;
        val_27 = null;
        val_27 = null;
        typeof(System.Object[]).__il2cppRuntimeField_20 = 0 + 0 + 0 + System.String.Empty(0 + System.String.Empty)(0 + 0 + System.String.Empty(0 + System.String.Empty)) + "Match ID: "("Match ID: ") + X1 + 16(X1 + 16);
        typeof(System.Object[]).__il2cppRuntimeField_28 = "Status:";
        typeof(System.Object[]).__il2cppRuntimeField_30 = X1 + 64;
        typeof(System.Object[]).__il2cppRuntimeField_38 = "\n";
        string val_4 = +0;
        if(((X1 + 32) != 0) && ((X1 + 32.Player) != null))
        {
                GK_Player val_6 = X1 + 32.Player;
            string val_7 = 0 + val_4 + "CurrentPlayerID: "("CurrentPlayerID: ") + val_6._PlayerId;
        }
        
        val_29 = 0 + 0 + 0 + val_4(0 + val_4) + "Data: "("Data: ") + X1.UTF8StringData(0 + 0 + val_4(0 + val_4) + "Data: "("Data: ") + X1.UTF8StringData);
        List.Enumerator<T> val_12 = X1 + 72.GetEnumerator();
        goto label_33;
        label_75:
        val_29 = val_12.current;
        label_33:
        if((0 & 1) == 0)
        {
            goto label_80;
        }
        
        System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_14 = X1 + 64.InitializationCallback;
        if(val_14.Player != null)
        {
                GK_Player val_16 = val_14.Player;
            string val_17 = 0 + val_29 + "PlayerId: "("PlayerId: ") + val_16._PlayerId;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_20 = 0 + val_29;
        typeof(System.Object[]).__il2cppRuntimeField_28 = "Status: ";
        typeof(System.Object[]).__il2cppRuntimeField_30 = System.Object[].__il2cppRuntimeField_namespaze;
        typeof(System.Object[]).__il2cppRuntimeField_38 = "\n";
        typeof(System.Object[]).__il2cppRuntimeField_20 = +0;
        typeof(System.Object[]).__il2cppRuntimeField_28 = "MatchOutcome: ";
        typeof(System.Object[]).__il2cppRuntimeField_30 = System.Object[].__il2cppRuntimeField_namespaze;
        typeof(System.Object[]).__il2cppRuntimeField_38 = "\n";
        string val_24 = 0 + 0 + +0(+0) + "TimeoutDate: "("TimeoutDate: ") + System.Object[].__il2cppRuntimeField_namespaze.ToString(format:  "DD MMM YYYY HH:mm:ss")(System.Object[].__il2cppRuntimeField_namespaze.ToString(format:  "DD MMM YYYY HH:mm:ss"))(0 + +0(+0) + "TimeoutDate: "("TimeoutDate: ") + System.Object[].__il2cppRuntimeField_namespaze.ToString(format:  "DD MMM YYYY HH:mm:ss")(System.Object[].__il2cppRuntimeField_namespaze.ToString(format:  "DD MMM YYYY HH:mm:ss"))) + "LastTurnDate: "("LastTurnDate: ") + "TimeoutDate: ".ToString(format:  "DD MMM YYYY HH:mm:ss")("TimeoutDate: ".ToString(format:  "DD MMM YYYY HH:mm:ss"));
        string val_25 = 0 + val_24;
        goto label_75;
        label_80:
        X1 + 64.Dispose();
        ISN_Logger.Log(message:  0, logType:  0 + val_24);
    }
    public System.Collections.Generic.Dictionary<string, GK_TBM_Match> get_Matches()
    {
        return (System.Collections.Generic.Dictionary<System.String, GK_TBM_Match>)this._Matches;
    }
    public System.Collections.Generic.List<GK_TBM_Match> get_MatchesList()
    {
        System.Collections.Generic.List<T> val_4;
        var val_5;
        Dictionary.Enumerator<TKey, TValue> val_2 = this._Matches.GetEnumerator();
        label_4:
        if((0 & 1) == 0)
        {
            goto label_2;
        }
        
        UnityEngine.Playables.PlayableHandle val_3 = 0.GetHandle();
        Add(item:  val_3.m_Handle);
        goto label_4;
        label_2:
        val_4 = 0;
        val_5 = 1;
        0.Dispose();
        if((val_5 & 1) != 0)
        {
                return (System.Collections.Generic.List<GK_TBM_Match>)new System.Collections.Generic.List<GK_TBM_Match>();
        }
        
        if(val_4 == 0)
        {
                return (System.Collections.Generic.List<GK_TBM_Match>)new System.Collections.Generic.List<GK_TBM_Match>();
        }
        
        return (System.Collections.Generic.List<GK_TBM_Match>)new System.Collections.Generic.List<GK_TBM_Match>();
    }
    public void OnLoadMatchesResult(string data)
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_10 = data;
        ISN_Logger.Log(message:  0, logType:  0 + "TBM::OnLoadMatchesResult: "("TBM::OnLoadMatchesResult: "));
        val_11 = 1152921504616644608;
        this._Matches = new System.Collections.Generic.Dictionary<System.String, GK_TBM_Match>();
        if(val_10.Length == 0)
        {
            goto label_19;
        }
        
        val_12 = "|%|";
        typeof(System.String[]).__il2cppRuntimeField_20 = val_12;
        val_10 = val_10.Split(separator:  null, options:  0);
        if(val_5.Length < 1)
        {
            goto label_19;
        }
        
        System.Collections.Generic.Dictionary<System.String, GK_TBM_Match> val_6 = new System.Collections.Generic.Dictionary<System.String, GK_TBM_Match>();
        typeof(GK_TBM_LoadMatchesResult).__il2cppRuntimeField_18 = val_6;
        val_12 = 1152921510200311088;
        val_13 = 0;
        goto label_13;
        label_27:
        Add(key:  1152921510193553680, value:  val_6);
        val_13 = 1;
        label_13:
        if(val_13 >= val_5.Length)
        {
            goto label_19;
        }
        
        if((System.String.op_Equality(a:  0, b:  val_10[1])) == true)
        {
            goto label_19;
        }
        
        this.UpdateMatchInfo(match:  GameCenter_TBM.ParceMatchInfo(data:  null));
        if(null != 0)
        {
            goto label_27;
        }
        
        goto label_27;
        label_19:
        val_14 = null;
        val_14 = null;
        GameCenter_TBM.ActionMatchesInfoLoaded.Invoke(obj:  new GK_TBM_LoadMatchesResult(IsResultSucceeded:  false));
    }
    private void OnLoadMatchesResultFailed(string errorData)
    {
        var val_2 = null;
        GameCenter_TBM.ActionMatchesInfoLoaded.Invoke(obj:  new GK_TBM_LoadMatchesResult(errorData:  errorData));
    }
    private void OnLoadMatchResult(string data)
    {
        typeof(GK_TBM_LoadMatchResult).__il2cppRuntimeField_18 = GameCenter_TBM.ParceMatchInfo(data:  null);
        GameCenter_TBM.ActionMatchInfoLoaded.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void OnLoadMatchResultFailed(string errorData)
    {
        var val_2 = null;
        GameCenter_TBM.ActionMatchInfoLoaded.Invoke(obj:  new GK_TBM_LoadMatchResult(errorData:  errorData));
    }
    private void OnUpdateMatchResult(string data)
    {
        GK_TBM_MatchDataUpdateResult val_7;
        var val_8;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        System.String[] val_1 = data.Split(separator:  null);
        string val_7 = val_1[0];
        GK_TBM_Match val_2 = this.GetMatchById(matchId:  val_7);
        if(val_2 != null)
        {
                val_2.SetData(val:  val_1[1]);
            SA.Common.Models.Result val_3 = null;
            val_7 = val_3;
            val_3 = new SA.Common.Models.Result();
            typeof(GK_TBM_MatchDataUpdateResult).__il2cppRuntimeField_18 = val_2;
        }
        else
        {
                SA.Common.Models.Result val_6 = null;
            val_7 = val_6;
            val_6 = new SA.Common.Models.Result(error:  new SA.Common.Models.Error(code:  0, message:  0 + "Match with id: "("Match with id: ") + val_7));
        }
        
        val_8 = null;
        val_8 = null;
        GameCenter_TBM.ActionMatchDataUpdated.Invoke(obj:  val_7);
    }
    private void OnUpdateMatchResultFailed(string errorData)
    {
        var val_2 = null;
        GameCenter_TBM.ActionMatchDataUpdated.Invoke(obj:  new GK_TBM_MatchDataUpdateResult(errorData:  errorData));
    }
    private void OnMatchFoundResult(string data)
    {
        GK_TBM_Match val_1 = GameCenter_TBM.ParceMatchInfo(data:  null);
        this.UpdateMatchInfo(match:  val_1);
        typeof(GK_TBM_MatchInitResult).__il2cppRuntimeField_18 = val_1;
        GameCenter_TBM.ActionMatchFound.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void OnMatchFoundResultFailed(string errorData)
    {
        var val_2 = null;
        GameCenter_TBM.ActionMatchFound.Invoke(obj:  new GK_TBM_MatchInitResult(errorData:  errorData));
    }
    private void OnPlayerQuitForMatch(string data)
    {
        GK_TBM_Match val_1 = GameCenter_TBM.ParceMatchInfo(data:  null);
        this.UpdateMatchInfo(match:  val_1);
        GameCenter_TBM.ActionPlayerQuitForMatch.Invoke(obj:  val_1);
    }
    private void OnMatchQuitResult(string matchId)
    {
        var val_2;
        typeof(GK_TBM_MatchQuitResult).__il2cppRuntimeField_18 = matchId;
        val_2 = null;
        val_2 = null;
        GameCenter_TBM.ActionMatchQuit.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void OnMatchQuitResultFailed(string errorData)
    {
        var val_2;
        typeof(GK_TBM_MatchQuitResult).__il2cppRuntimeField_18 = errorData;
        val_2 = null;
        val_2 = null;
        GameCenter_TBM.ActionMatchQuit.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void OnEndTurnResult(string data)
    {
        GK_TBM_Match val_1 = GameCenter_TBM.ParceMatchInfo(data:  null);
        this.UpdateMatchInfo(match:  val_1);
        typeof(GK_TBM_EndTrunResult).__il2cppRuntimeField_18 = val_1;
        GameCenter_TBM.ActionTrunEnded.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void OnEndTurnResultFailed(string errorData)
    {
        var val_2 = null;
        GameCenter_TBM.ActionTrunEnded.Invoke(obj:  new GK_TBM_EndTrunResult(errorData:  errorData));
    }
    private void OnEndMatch(string data)
    {
        GK_TBM_Match val_1 = GameCenter_TBM.ParceMatchInfo(data:  null);
        this.UpdateMatchInfo(match:  val_1);
        typeof(GK_TBM_MatchEndResult).__il2cppRuntimeField_18 = val_1;
        GameCenter_TBM.ActionMacthEnded.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void OnEndMatchResult(string errorData)
    {
        var val_2 = null;
        GameCenter_TBM.ActionMacthEnded.Invoke(obj:  new GK_TBM_MatchEndResult(errorData:  errorData));
    }
    private void OnRematchResult(string data)
    {
        GK_TBM_Match val_1 = GameCenter_TBM.ParceMatchInfo(data:  null);
        this.UpdateMatchInfo(match:  val_1);
        typeof(GK_TBM_RematchResult).__il2cppRuntimeField_18 = val_1;
        GameCenter_TBM.ActionRematched.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void OnRematchFailed(string errorData)
    {
        var val_2 = null;
        GameCenter_TBM.ActionRematched.Invoke(obj:  new GK_TBM_RematchResult(errorData:  errorData));
    }
    private void OnMatchRemoved(string matchId)
    {
        System.Collections.Generic.Dictionary<System.String, GK_TBM_Match> val_4;
        var val_5;
        val_4 = this;
        typeof(GK_TBM_MatchRemovedResult).__il2cppRuntimeField_18 = matchId;
        if((this._Matches.ContainsKey(key:  matchId)) != false)
        {
                val_4 = this._Matches;
            bool val_3 = val_4.Remove(key:  matchId);
        }
        
        val_5 = null;
        val_5 = null;
        GameCenter_TBM.ActionMatchRemoved.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void OnMatchRemoveFailed(string errorData)
    {
        var val_2;
        typeof(GK_TBM_MatchRemovedResult).__il2cppRuntimeField_18 = errorData;
        val_2 = null;
        val_2 = null;
        GameCenter_TBM.ActionMatchRemoved.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void OnMatchInvitationAccepted(string data)
    {
        GK_TBM_Match val_1 = GameCenter_TBM.ParceMatchInfo(data:  null);
        this.UpdateMatchInfo(match:  val_1);
        typeof(GK_TBM_MatchInitResult).__il2cppRuntimeField_18 = val_1;
        GameCenter_TBM.ActionMatchInvitationAccepted.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void OnMatchInvitationAcceptedFailed(string errorData)
    {
        var val_2 = null;
        GameCenter_TBM.ActionMatchInvitationAccepted.Invoke(obj:  new GK_TBM_MatchInitResult(errorData:  errorData));
    }
    private void OnMatchInvitationDeclined(string matchId)
    {
        System.Collections.Generic.Dictionary<System.String, GK_TBM_Match> val_4;
        var val_5;
        val_4 = this;
        typeof(GK_TBM_MatchRemovedResult).__il2cppRuntimeField_18 = matchId;
        if((this._Matches.ContainsKey(key:  matchId)) != false)
        {
                val_4 = this._Matches;
            bool val_3 = val_4.Remove(key:  matchId);
        }
        
        val_5 = null;
        val_5 = null;
        GameCenter_TBM.ActionMatchInvitationDeclined.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void OnMatchInvitationDeclineFailed(string errorData)
    {
        var val_2;
        typeof(GK_TBM_MatchRemovedResult).__il2cppRuntimeField_18 = errorData;
        val_2 = null;
        val_2 = null;
        GameCenter_TBM.ActionMatchInvitationDeclined.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void OnTrunReceived(string data)
    {
        GK_TBM_Match val_1 = GameCenter_TBM.ParceMatchInfo(data:  null);
        this.UpdateMatchInfo(match:  val_1);
        typeof(GK_TBM_MatchTurnResult).__il2cppRuntimeField_18 = val_1;
        GameCenter_TBM.ActionTrunReceived.Invoke(obj:  new SA.Common.Models.Result());
    }
    private void UpdateMatchInfo(GK_TBM_Match match)
    {
        if((this._Matches.ContainsKey(key:  match.Id)) != false)
        {
                this._Matches.set_Item(key:  match.Id, value:  match);
            return;
        }
        
        this._Matches.Add(key:  match.Id, value:  match);
    }
    private static GK_TBM_Match ParceMatchInfo(string data)
    {
        System.String[] val_2;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
        val_2 = null;
        return GameCenter_TBM.ParceMatchInfo(MatchData:  val_2, index:  X1.Split(separator:  null));
    }
    public static GK_TBM_Match ParceMatchInfo(string[] MatchData, int index)
    {
        System.Collections.Generic.List<GK_TBM_Participant> val_21;
        var val_22;
        var val_23;
        GK_TBM_Participant val_24;
        int val_2 = index + (((long)(int)(W2)) << 3);
        typeof(GK_TBM_Match).__il2cppRuntimeField_10 = (index + ((long)(int)(W2)) << 3) + 32;
        var val_3 = W2 + 1;
        int val_4 = index + (((long)(int)((W2 + 1))) << 3);
        typeof(GK_TBM_Match).__il2cppRuntimeField_40 = System.Convert.ToInt64(value:  0);
        var val_6 = W2 + 2;
        int val_7 = index + (((long)(int)((W2 + 2))) << 3);
        typeof(GK_TBM_Match).__il2cppRuntimeField_18 = (index + ((long)(int)((W2 + 2))) << 3) + 32;
        var val_8 = W2 + 3;
        int val_9 = index + (((long)(int)((W2 + 3))) << 3);
        System.DateTime val_10 = System.DateTime.Parse(s:  0);
        typeof(GK_TBM_Match).__il2cppRuntimeField_28 = val_10.ticks._ticks;
        typeof(GK_TBM_Match).__il2cppRuntimeField_30 = val_10.kind;
        var val_11 = W2 + 4;
        int val_12 = index + (((long)(int)((W2 + 4))) << 3);
        SetData(val:  (index + ((long)(int)((W2 + 4))) << 3) + 32);
        var val_13 = W2 + 5;
        int val_14 = index + (((long)(int)((W2 + 5))) << 3);
        var val_15 = W2 + 6;
        val_21 = GameCenterManager.ParseParticipantsData(data:  null, index:  index);
        if(null != 0)
        {
                typeof(GK_TBM_Match).__il2cppRuntimeField_48 = val_21;
        }
        else
        {
                mem[72] = val_21;
            val_21 = mem[72];
        }
        
        List.Enumerator<T> val_17 = val_21.GetEnumerator();
        goto label_24;
        label_28:
        mem2[0] = ???;
        label_24:
        if((0 & 1) == 0)
        {
            goto label_25;
        }
        
        if(0.InitializationCallback != null)
        {
            goto label_28;
        }
        
        goto label_28;
        label_25:
        val_22 = 0;
        val_23 = 1;
        0.Dispose();
        if(null != 0)
        {
                val_24 = GetParticipantByPlayerId(playerId:  (index + ((long)(int)((W2 + 5))) << 3) + 32);
        }
        else
        {
                val_24 = GetParticipantByPlayerId(playerId:  (index + ((long)(int)((W2 + 5))) << 3) + 32);
        }
        
        typeof(GK_TBM_Match).__il2cppRuntimeField_20 = val_24;
        return (GK_TBM_Match)new System.Object();
    }
    private static GameCenter_TBM()
    {
        GameCenter_TBM.ActionMatchInfoLoaded = new System.Action<GK_TBM_LoadMatchResult>(object:  0, method:  static System.Void GameCenter_TBM::<ActionMatchInfoLoaded>m__0(GK_TBM_LoadMatchResult ));
        GameCenter_TBM.ActionMatchesInfoLoaded = new System.Action<GK_TBM_LoadMatchesResult>(object:  0, method:  static System.Void GameCenter_TBM::<ActionMatchesInfoLoaded>m__1(GK_TBM_LoadMatchesResult ));
        GameCenter_TBM.ActionMatchDataUpdated = new System.Action<GK_TBM_MatchDataUpdateResult>(object:  0, method:  static System.Void GameCenter_TBM::<ActionMatchDataUpdated>m__2(GK_TBM_MatchDataUpdateResult ));
        GameCenter_TBM.ActionMatchFound = new System.Action<GK_TBM_MatchInitResult>(object:  0, method:  static System.Void GameCenter_TBM::<ActionMatchFound>m__3(GK_TBM_MatchInitResult ));
        GameCenter_TBM.ActionMatchQuit = new System.Action<GK_TBM_MatchQuitResult>(object:  0, method:  static System.Void GameCenter_TBM::<ActionMatchQuit>m__4(GK_TBM_MatchQuitResult ));
        GameCenter_TBM.ActionTrunEnded = new System.Action<GK_TBM_EndTrunResult>(object:  0, method:  static System.Void GameCenter_TBM::<ActionTrunEnded>m__5(GK_TBM_EndTrunResult ));
        GameCenter_TBM.ActionMacthEnded = new System.Action<GK_TBM_MatchEndResult>(object:  0, method:  static System.Void GameCenter_TBM::<ActionMacthEnded>m__6(GK_TBM_MatchEndResult ));
        GameCenter_TBM.ActionRematched = new System.Action<GK_TBM_RematchResult>(object:  0, method:  static System.Void GameCenter_TBM::<ActionRematched>m__7(GK_TBM_RematchResult ));
        GameCenter_TBM.ActionMatchRemoved = new System.Action<GK_TBM_MatchRemovedResult>(object:  0, method:  static System.Void GameCenter_TBM::<ActionMatchRemoved>m__8(GK_TBM_MatchRemovedResult ));
        GameCenter_TBM.ActionMatchInvitationAccepted = new System.Action<GK_TBM_MatchInitResult>(object:  0, method:  static System.Void GameCenter_TBM::<ActionMatchInvitationAccepted>m__9(GK_TBM_MatchInitResult ));
        GameCenter_TBM.ActionMatchInvitationDeclined = new System.Action<GK_TBM_MatchRemovedResult>(object:  0, method:  static System.Void GameCenter_TBM::<ActionMatchInvitationDeclined>m__A(GK_TBM_MatchRemovedResult ));
        GameCenter_TBM.ActionPlayerQuitForMatch = new System.Action<GK_TBM_Match>(object:  0, method:  static System.Void GameCenter_TBM::<ActionPlayerQuitForMatch>m__B(GK_TBM_Match ));
        GameCenter_TBM.ActionTrunReceived = new System.Action<GK_TBM_MatchTurnResult>(object:  0, method:  static System.Void GameCenter_TBM::<ActionTrunReceived>m__C(GK_TBM_MatchTurnResult ));
    }
    private static void <ActionMatchInfoLoaded>m__0(GK_TBM_LoadMatchResult )
    {
    
    }
    private static void <ActionMatchesInfoLoaded>m__1(GK_TBM_LoadMatchesResult )
    {
    
    }
    private static void <ActionMatchDataUpdated>m__2(GK_TBM_MatchDataUpdateResult )
    {
    
    }
    private static void <ActionMatchFound>m__3(GK_TBM_MatchInitResult )
    {
    
    }
    private static void <ActionMatchQuit>m__4(GK_TBM_MatchQuitResult )
    {
    
    }
    private static void <ActionTrunEnded>m__5(GK_TBM_EndTrunResult )
    {
    
    }
    private static void <ActionMacthEnded>m__6(GK_TBM_MatchEndResult )
    {
    
    }
    private static void <ActionRematched>m__7(GK_TBM_RematchResult )
    {
    
    }
    private static void <ActionMatchRemoved>m__8(GK_TBM_MatchRemovedResult )
    {
    
    }
    private static void <ActionMatchInvitationAccepted>m__9(GK_TBM_MatchInitResult )
    {
    
    }
    private static void <ActionMatchInvitationDeclined>m__A(GK_TBM_MatchRemovedResult )
    {
    
    }
    private static void <ActionPlayerQuitForMatch>m__B(GK_TBM_Match )
    {
    
    }
    private static void <ActionTrunReceived>m__C(GK_TBM_MatchTurnResult )
    {
    
    }

}
