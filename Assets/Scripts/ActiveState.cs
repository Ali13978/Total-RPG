using UnityEngine;
private class NativeRealtimeMultiplayerClient.ActiveState : NativeRealtimeMultiplayerClient.MessagingEnabledState
{
    // Fields
    private static System.Func<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, string> <>f__am$cache0;
    private static System.Func<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, GooglePlayGames.BasicApi.Multiplayer.Participant> <>f__am$cache1;
    private static System.Func<GooglePlayGames.BasicApi.Multiplayer.Participant, string> <>f__am$cache2;
    private static System.Func<GooglePlayGames.BasicApi.Multiplayer.Participant, string> <>f__am$cache3;
    
    // Methods
    internal NativeRealtimeMultiplayerClient.ActiveState(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room, GooglePlayGames.Native.NativeRealtimeMultiplayerClient.RoomSession session)
    {
    
    }
    internal override void OnStateEntered()
    {
        if(this != null)
        {
                return;
        }
        
        GooglePlayGames.OurUtils.Logger.e(msg:  0);
        goto typeof(NativeRealtimeMultiplayerClient.ActiveState).__il2cppRuntimeField_170;
    }
    internal override bool IsRoomConnected()
    {
        return true;
    }
    internal override GooglePlayGames.BasicApi.Multiplayer.Participant GetParticipant(string participantId)
    {
        string val_5;
        var val_6;
        val_5 = participantId;
        if((ContainsKey(key:  val_5)) != false)
        {
                GooglePlayGames.BasicApi.Multiplayer.Participant val_3 = this.Item[val_5];
            return (GooglePlayGames.BasicApi.Multiplayer.Participant)val_6;
        }
        
        val_5 = 0 + "Attempted to retrieve unknown participant ";
        GooglePlayGames.OurUtils.Logger.e(msg:  0);
        val_6 = 0;
        return (GooglePlayGames.BasicApi.Multiplayer.Participant)val_6;
    }
    internal override GooglePlayGames.BasicApi.Multiplayer.Participant GetSelf()
    {
        var val_7;
        var val_8;
        val_7 = this;
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = Values.GetEnumerator();
        label_10:
        if((0 & 1) == 0)
        {
            goto label_3;
        }
        
        val_8 = ;
        if((0.Player == null) || ((0.Player.id.Equals(value:  X22 + 40)) == false))
        {
            goto label_10;
        }
        
        return (GooglePlayGames.BasicApi.Multiplayer.Participant)val_8;
        label_3:
        val_8 = 0;
        return (GooglePlayGames.BasicApi.Multiplayer.Participant)val_8;
    }
    internal override void HandleConnectedSetChanged(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room)
    {
        string val_9;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_56;
        IntPtr val_57;
        val_48 = this;
        object val_1 = new System.Object();
        val_49 = null;
        if((NativeRealtimeMultiplayerClient.ActiveState.<>f__am$cache0) == null)
        {
                NativeRealtimeMultiplayerClient.ActiveState.<>f__am$cache0 = new System.Func<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, System.String>(object:  0, method:  static System.String NativeRealtimeMultiplayerClient.ActiveState::<HandleConnectedSetChanged>m__0(GooglePlayGames.Native.PInvoke.MultiplayerParticipant p));
            val_49 = null;
        }
        
        System.Collections.Generic.Dictionary<TKey, TSource> val_6 = System.Linq.Enumerable.ToDictionary<UnityEngine.Object, System.String>(source:  0, keySelector:  room.Participants());
        Dictionary.KeyCollection<TKey, TValue> val_7 = Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_8 = val_7.GetEnumerator();
        label_16:
        if((0 & 1) == 0)
        {
            goto label_5;
        }
        
        GooglePlayGames.Native.PInvoke.MultiplayerParticipant val_11 = val_6.Item[val_9];
        if(val_11.IsConnectedToRoom() != true)
        {
                Add(item:  val_9);
        }
        
        if((X26.Item[val_9].IsConnectedToRoom() == true) || (val_11.IsConnectedToRoom() == false))
        {
            goto label_16;
        }
        
        Add(item:  val_9);
        goto label_16;
        label_5:
        val_50 = 1152921504955301888;
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_19 = val_7.Values.GetEnumerator();
        label_23:
        if((0 & 1) == 0)
        {
            goto label_21;
        }
        
        val_9.Dispose(fromFinalizer:  false);
        System.GC.SuppressFinalize(obj:  0);
        goto label_23;
        label_21:
        val_51 = 0;
        val_52 = 1;
        mem[1152921512088613136] = val_6;
        if((NativeRealtimeMultiplayerClient.ActiveState.<>f__am$cache1) == null)
        {
                NativeRealtimeMultiplayerClient.ActiveState.<>f__am$cache1 = new System.Func<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, GooglePlayGames.BasicApi.Multiplayer.Participant>(object:  0, method:  static GooglePlayGames.BasicApi.Multiplayer.Participant NativeRealtimeMultiplayerClient.ActiveState::<HandleConnectedSetChanged>m__1(GooglePlayGames.Native.PInvoke.MultiplayerParticipant p));
        }
        
        if((NativeRealtimeMultiplayerClient.ActiveState.<>f__am$cache2) == null)
        {
                NativeRealtimeMultiplayerClient.ActiveState.<>f__am$cache2 = new System.Func<GooglePlayGames.BasicApi.Multiplayer.Participant, System.String>(object:  0, method:  static System.String NativeRealtimeMultiplayerClient.ActiveState::<HandleConnectedSetChanged>m__2(GooglePlayGames.BasicApi.Multiplayer.Participant p));
        }
        
        System.Collections.Generic.Dictionary<TKey, TSource> val_24 = System.Linq.Enumerable.ToDictionary<UnityEngine.Object, System.String>(source:  0, keySelector:  System.Linq.Enumerable.Select<System.Type, System.String>(source:  0, selector:  val_6.Values));
        mem[1152921512088613144] = val_24;
        if((NativeRealtimeMultiplayerClient.ActiveState.<>f__am$cache3) == null)
        {
                NativeRealtimeMultiplayerClient.ActiveState.<>f__am$cache3 = new System.Func<GooglePlayGames.BasicApi.Multiplayer.Participant, System.String>(object:  0, method:  static System.String NativeRealtimeMultiplayerClient.ActiveState::<HandleConnectedSetChanged>m__3(GooglePlayGames.BasicApi.Multiplayer.Participant p));
        }
        
        System.Collections.Generic.IEnumerable<TResult> val_27 = System.Linq.Enumerable.Select<System.Type, System.String>(source:  0, selector:  val_24.Values);
        val_56 = System.Linq.Enumerable.ToArray<System.Type>(source:  0);
        string val_29 = System.String.Join(separator:  0, value:  ",");
        string val_30 = 0 + "Updated participant statuses: "("Updated participant statuses: ");
        GooglePlayGames.OurUtils.Logger.d(msg:  0);
        if((Contains(item:  this.ParticipantId)) != false)
        {
                GooglePlayGames.OurUtils.Logger.w(msg:  0);
        }
        
        typeof(NativeRealtimeMultiplayerClient.ActiveState.<HandleConnectedSetChanged>c__AnonStorey0).__il2cppRuntimeField_10 = this.ParticipantId;
        System.Func<System.String, System.Boolean> val_34 = new System.Func<System.String, System.Boolean>(object:  val_1, method:  System.Boolean NativeRealtimeMultiplayerClient.ActiveState.<HandleConnectedSetChanged>c__AnonStorey0::<>m__0(string peerId));
        System.Collections.Generic.IEnumerable<TSource> val_35 = System.Linq.Enumerable.Where<UnityEngine.UI.ExtensionsToggle>(source:  0, predicate:  new System.Collections.Generic.List<System.String>());
        System.Collections.Generic.List<TSource> val_36 = System.Linq.Enumerable.ToList<UnityEngine.Component>(source:  0);
        val_57 = System.Boolean NativeRealtimeMultiplayerClient.ActiveState.<HandleConnectedSetChanged>c__AnonStorey0::<>m__1(string peerId);
        System.Func<System.String, System.Boolean> val_37 = new System.Func<System.String, System.Boolean>(object:  val_1, method:  val_57);
        System.Collections.Generic.IEnumerable<TSource> val_38 = System.Linq.Enumerable.Where<UnityEngine.UI.ExtensionsToggle>(source:  0, predicate:  new System.Collections.Generic.List<System.String>());
        System.Collections.Generic.List<TSource> val_39 = System.Linq.Enumerable.ToList<UnityEngine.Component>(source:  0);
        if(val_36.Count >= 1)
        {
                val_36.Sort();
            System.Func<System.String, System.Boolean> val_41 = null;
            val_56 = val_41;
            val_41 = new System.Func<System.String, System.Boolean>(object:  val_1, method:  System.Boolean NativeRealtimeMultiplayerClient.ActiveState.<HandleConnectedSetChanged>c__AnonStorey0::<>m__2(string peer));
            System.Collections.Generic.IEnumerable<TSource> val_42 = System.Linq.Enumerable.Where<UnityEngine.UI.ExtensionsToggle>(source:  0, predicate:  val_36);
            System.Boolean NativeRealtimeMultiplayerClient.ActiveState.<HandleConnectedSetChanged>c__AnonStorey0::<>m__1(string peerId).__il2cppRuntimeField_18.PeersConnected(participantIds:  System.Linq.Enumerable.ToArray<System.Type>(source:  0));
        }
        
        if(val_39.Count < 1)
        {
                return;
        }
        
        val_39.Sort();
        System.Func<System.String, System.Boolean> val_45 = null;
        val_57 = val_45;
        val_45 = new System.Func<System.String, System.Boolean>(object:  val_1, method:  System.Boolean NativeRealtimeMultiplayerClient.ActiveState.<HandleConnectedSetChanged>c__AnonStorey0::<>m__3(string peer));
        System.Collections.Generic.IEnumerable<TSource> val_46 = System.Linq.Enumerable.Where<UnityEngine.UI.ExtensionsToggle>(source:  0, predicate:  val_39);
        this.PeersDisconnected(participantIds:  System.Linq.Enumerable.ToArray<System.Type>(source:  0));
    }
    internal override void LeaveRoom()
    {
        EnterState(handler:  new NativeRealtimeMultiplayerClient.LeavingRoom(session:  static_value_02131000, room:  X21, leavingCompleteCallback:  new System.Action(object:  this, method:  System.Void NativeRealtimeMultiplayerClient.ActiveState::<LeaveRoom>m__4())), fireStateEnteredEvent:  true);
    }
    private static string <HandleConnectedSetChanged>m__0(GooglePlayGames.Native.PInvoke.MultiplayerParticipant p)
    {
        if(X1 != 0)
        {
                return X1.Id();
        }
        
        return X1.Id();
    }
    private static GooglePlayGames.BasicApi.Multiplayer.Participant <HandleConnectedSetChanged>m__1(GooglePlayGames.Native.PInvoke.MultiplayerParticipant p)
    {
        if(X1 != 0)
        {
                return X1.AsParticipant();
        }
        
        return X1.AsParticipant();
    }
    private static string <HandleConnectedSetChanged>m__2(GooglePlayGames.BasicApi.Multiplayer.Participant p)
    {
        if(X1 != 0)
        {
                return X1.ParticipantId;
        }
        
        return X1.ParticipantId;
    }
    private static string <HandleConnectedSetChanged>m__3(GooglePlayGames.BasicApi.Multiplayer.Participant p)
    {
        if(X1 == 0)
        {
            
        }
    
    }
    private void <LeaveRoom>m__4()
    {
        X19 + 24.LeftRoom();
    }

}
