using UnityEngine;
private abstract class NativeRealtimeMultiplayerClient.MessagingEnabledState : NativeRealtimeMultiplayerClient.State
{
    // Fields
    protected readonly GooglePlayGames.Native.NativeRealtimeMultiplayerClient.RoomSession mSession;
    protected GooglePlayGames.Native.PInvoke.NativeRealTimeRoom mRoom;
    protected System.Collections.Generic.Dictionary<string, GooglePlayGames.Native.PInvoke.MultiplayerParticipant> mNativeParticipants;
    protected System.Collections.Generic.Dictionary<string, GooglePlayGames.BasicApi.Multiplayer.Participant> mParticipants;
    private static System.Func<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, string> <>f__am$cache0;
    private static System.Func<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, GooglePlayGames.BasicApi.Multiplayer.Participant> <>f__am$cache1;
    private static System.Func<GooglePlayGames.BasicApi.Multiplayer.Participant, string> <>f__am$cache2;
    private static System.Func<GooglePlayGames.BasicApi.Multiplayer.Participant, bool> <>f__am$cache3;
    
    // Methods
    internal NativeRealtimeMultiplayerClient.MessagingEnabledState(GooglePlayGames.Native.NativeRealtimeMultiplayerClient.RoomSession session, GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room)
    {
        val_1 = new System.Object();
        this.mSession = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
        this.UpdateCurrentRoom(room:  GooglePlayGames.Native.PInvoke.NativeRealTimeRoom val_1 = room);
    }
    internal void UpdateCurrentRoom(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room)
    {
        GooglePlayGames.Native.PInvoke.NativeRealTimeRoom val_10;
        var val_11;
        val_10 = this.mRoom;
        if(val_10 != null)
        {
                val_10.Dispose(fromFinalizer:  false);
            System.GC.SuppressFinalize(obj:  0);
        }
        
        GooglePlayGames.BasicApi.IPlayGamesClient val_1 = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
        this.mRoom = val_1;
        val_11 = null;
        if((NativeRealtimeMultiplayerClient.MessagingEnabledState.<>f__am$cache0) == null)
        {
                val_10 = static System.String NativeRealtimeMultiplayerClient.MessagingEnabledState::<UpdateCurrentRoom>m__0(GooglePlayGames.Native.PInvoke.MultiplayerParticipant p);
            NativeRealtimeMultiplayerClient.MessagingEnabledState.<>f__am$cache0 = new System.Func<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, System.String>(object:  0, method:  val_10);
            val_11 = null;
        }
        
        System.Collections.Generic.Dictionary<TKey, TSource> val_4 = System.Linq.Enumerable.ToDictionary<UnityEngine.Object, System.String>(source:  0, keySelector:  val_1.Participants());
        this.mNativeParticipants = val_4;
        if((NativeRealtimeMultiplayerClient.MessagingEnabledState.<>f__am$cache1) == null)
        {
                val_10 = static GooglePlayGames.BasicApi.Multiplayer.Participant NativeRealtimeMultiplayerClient.MessagingEnabledState::<UpdateCurrentRoom>m__1(GooglePlayGames.Native.PInvoke.MultiplayerParticipant p);
            NativeRealtimeMultiplayerClient.MessagingEnabledState.<>f__am$cache1 = new System.Func<GooglePlayGames.Native.PInvoke.MultiplayerParticipant, GooglePlayGames.BasicApi.Multiplayer.Participant>(object:  0, method:  val_10);
        }
        
        if((NativeRealtimeMultiplayerClient.MessagingEnabledState.<>f__am$cache2) == null)
        {
                val_10 = static System.String NativeRealtimeMultiplayerClient.MessagingEnabledState::<UpdateCurrentRoom>m__2(GooglePlayGames.BasicApi.Multiplayer.Participant p);
            NativeRealtimeMultiplayerClient.MessagingEnabledState.<>f__am$cache2 = new System.Func<GooglePlayGames.BasicApi.Multiplayer.Participant, System.String>(object:  0, method:  val_10);
        }
        
        this.mParticipants = System.Linq.Enumerable.ToDictionary<UnityEngine.Object, System.String>(source:  0, keySelector:  System.Linq.Enumerable.Select<System.Type, System.String>(source:  0, selector:  val_4.Values));
    }
    internal sealed override void OnRoomStatusChanged(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room)
    {
        this.UpdateCurrentRoom(room:  room);
    }
    internal virtual void HandleRoomStatusChanged(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room)
    {
    
    }
    internal sealed override void OnConnectedSetChanged(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room)
    {
        this.UpdateCurrentRoom(room:  room);
    }
    internal virtual void HandleConnectedSetChanged(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room)
    {
    
    }
    internal sealed override void OnParticipantStatusChanged(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant)
    {
        this.UpdateCurrentRoom(room:  room);
    }
    internal virtual void HandleParticipantStatusChanged(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant participant)
    {
    
    }
    internal sealed override System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant> GetConnectedParticipants()
    {
        if((NativeRealtimeMultiplayerClient.MessagingEnabledState.<>f__am$cache3) == null)
        {
                NativeRealtimeMultiplayerClient.MessagingEnabledState.<>f__am$cache3 = new System.Func<GooglePlayGames.BasicApi.Multiplayer.Participant, System.Boolean>(object:  0, method:  static System.Boolean NativeRealtimeMultiplayerClient.MessagingEnabledState::<GetConnectedParticipants>m__3(GooglePlayGames.BasicApi.Multiplayer.Participant p));
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_3 = System.Linq.Enumerable.Where<UnityEngine.UI.ExtensionsToggle>(source:  0, predicate:  this.mParticipants.Values);
        System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<UnityEngine.Component>(source:  0);
        val_4.Sort();
        return (System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant>)val_4;
    }
    internal override void SendToSpecificRecipient(string recipientId, byte[] data, int offset, int length, bool isReliable)
    {
        if((this.mNativeParticipants.ContainsKey(key:  recipientId)) == false)
        {
            goto label_2;
        }
        
        if(isReliable == false)
        {
            goto label_4;
        }
        
        this.mSession.mManager.SendReliableMessage(room:  this.mRoom, participant:  this.mNativeParticipants.Item[recipientId], data:  GooglePlayGames.OurUtils.Misc.GetSubsetBytes(array:  0, offset:  data, length:  offset), callback:  0);
        return;
        label_2:
        string val_5 = 0 + "Attempted to send message to unknown participant ";
        GooglePlayGames.OurUtils.Logger.e(msg:  0);
        return;
        label_4:
        Add(item:  this.mNativeParticipants.Item[recipientId]);
        this.mSession.mManager.SendUnreliableMessageToSpecificParticipants(room:  this.mRoom, recipients:  new System.Collections.Generic.List<GooglePlayGames.Native.PInvoke.MultiplayerParticipant>(), data:  GooglePlayGames.OurUtils.Misc.GetSubsetBytes(array:  0, offset:  data, length:  offset));
    }
    internal override void SendToAll(byte[] data, int offset, int length, bool isReliable)
    {
        int val_4;
        GooglePlayGames.Native.PInvoke.RealtimeManager val_5;
        GooglePlayGames.Native.PInvoke.NativeRealTimeRoom val_6;
        var val_7;
        val_4 = data;
        System.Byte[] val_1 = GooglePlayGames.OurUtils.Misc.GetSubsetBytes(array:  0, offset:  val_4, length:  offset);
        if(isReliable == false)
        {
            goto label_1;
        }
        
        val_5 = this.mNativeParticipants.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = val_5.GetEnumerator();
        val_4 = 1152921512084557840;
        label_6:
        if((0 & 1) == 0)
        {
            goto label_4;
        }
        
        if(val_1 != null)
        {
            goto label_6;
        }
        
        goto label_6;
        label_1:
        val_5 = this.mSession.mManager;
        val_6 = this.mRoom;
        val_5.SendUnreliableMessageToAll(room:  val_6, data:  val_1);
        return;
        label_4:
        val_6 = 0;
        val_7 = 1;
        if((val_7 & 1) != 0)
        {
                return;
        }
        
        if(val_6 == 0)
        {
                return;
        }
    
    }
    internal override void OnDataReceived(GooglePlayGames.Native.PInvoke.NativeRealTimeRoom room, GooglePlayGames.Native.PInvoke.MultiplayerParticipant sender, byte[] data, bool isReliable)
    {
        this.mSession.mListener.RealTimeMessageReceived(isReliable:  isReliable, senderId:  sender.Id(), data:  data);
    }
    private static string <UpdateCurrentRoom>m__0(GooglePlayGames.Native.PInvoke.MultiplayerParticipant p)
    {
        if(X1 != 0)
        {
                return X1.Id();
        }
        
        return X1.Id();
    }
    private static GooglePlayGames.BasicApi.Multiplayer.Participant <UpdateCurrentRoom>m__1(GooglePlayGames.Native.PInvoke.MultiplayerParticipant p)
    {
        if(X1 != 0)
        {
                return X1.AsParticipant();
        }
        
        return X1.AsParticipant();
    }
    private static string <UpdateCurrentRoom>m__2(GooglePlayGames.BasicApi.Multiplayer.Participant p)
    {
        if(X1 != 0)
        {
                return X1.ParticipantId;
        }
        
        return X1.ParticipantId;
    }
    private static bool <GetConnectedParticipants>m__3(GooglePlayGames.BasicApi.Multiplayer.Participant p)
    {
        if(X1 != 0)
        {
                return X1.IsConnectedToRoom;
        }
        
        return X1.IsConnectedToRoom;
    }

}
