using UnityEngine;
private class NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener
{
    // Fields
    private readonly GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener mListener;
    
    // Methods
    internal NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener(GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener)
    {
        this.mListener = GooglePlayGames.OurUtils.Misc.CheckNotNull<GooglePlayGames.BasicApi.IPlayGamesClient>(value:  0);
    }
    public void RoomSetupProgress(float percent)
    {
        if(null != 0)
        {
                typeof(NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener.<RoomSetupProgress>c__AnonStorey0).__il2cppRuntimeField_10 = percent;
        }
        else
        {
                mem[16] = percent;
        }
        
        typeof(NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener.<RoomSetupProgress>c__AnonStorey0).__il2cppRuntimeField_18 = this;
        System.Action val_2 = new System.Action(object:  new System.Object(), method:  System.Void NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener.<RoomSetupProgress>c__AnonStorey0::<>m__0());
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  0);
    }
    public void RoomConnected(bool success)
    {
        if(null != 0)
        {
                typeof(NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener.<RoomConnected>c__AnonStorey1).__il2cppRuntimeField_10 = success;
        }
        else
        {
                mem[16] = success;
        }
        
        typeof(NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener.<RoomConnected>c__AnonStorey1).__il2cppRuntimeField_18 = this;
        System.Action val_4 = new System.Action(object:  new System.Object(), method:  System.Void NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener.<RoomConnected>c__AnonStorey1::<>m__0());
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  0);
    }
    public void LeftRoom()
    {
        System.Action val_1 = new System.Action(object:  this, method:  System.Void NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener::<LeftRoom>m__0());
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  0);
    }
    public void PeersConnected(string[] participantIds)
    {
        if(null != 0)
        {
                typeof(NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener.<PeersConnected>c__AnonStorey2).__il2cppRuntimeField_10 = participantIds;
        }
        else
        {
                mem[16] = participantIds;
        }
        
        typeof(NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener.<PeersConnected>c__AnonStorey2).__il2cppRuntimeField_18 = this;
        System.Action val_2 = new System.Action(object:  new System.Object(), method:  System.Void NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener.<PeersConnected>c__AnonStorey2::<>m__0());
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  0);
    }
    public void PeersDisconnected(string[] participantIds)
    {
        if(null != 0)
        {
                typeof(NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener.<PeersDisconnected>c__AnonStorey3).__il2cppRuntimeField_10 = participantIds;
        }
        else
        {
                mem[16] = participantIds;
        }
        
        typeof(NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener.<PeersDisconnected>c__AnonStorey3).__il2cppRuntimeField_18 = this;
        System.Action val_2 = new System.Action(object:  new System.Object(), method:  System.Void NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener.<PeersDisconnected>c__AnonStorey3::<>m__0());
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  0);
    }
    public void RealTimeMessageReceived(bool isReliable, string senderId, byte[] data)
    {
        if(null != 0)
        {
                typeof(NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener.<RealTimeMessageReceived>c__AnonStorey4).__il2cppRuntimeField_18 = senderId;
            typeof(NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener.<RealTimeMessageReceived>c__AnonStorey4).__il2cppRuntimeField_20 = data;
            typeof(NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener.<RealTimeMessageReceived>c__AnonStorey4).__il2cppRuntimeField_10 = isReliable;
        }
        else
        {
                mem[16] = isReliable;
            mem[24] = senderId;
            mem[32] = data;
        }
        
        typeof(NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener.<RealTimeMessageReceived>c__AnonStorey4).__il2cppRuntimeField_28 = this;
        System.Action val_4 = new System.Action(object:  new System.Object(), method:  System.Void NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener.<RealTimeMessageReceived>c__AnonStorey4::<>m__0());
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  0);
    }
    public void ParticipantLeft(GooglePlayGames.BasicApi.Multiplayer.Participant participant)
    {
        if(null != 0)
        {
                typeof(NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener.<ParticipantLeft>c__AnonStorey5).__il2cppRuntimeField_10 = participant;
        }
        else
        {
                mem[16] = participant;
        }
        
        typeof(NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener.<ParticipantLeft>c__AnonStorey5).__il2cppRuntimeField_18 = this;
        System.Action val_2 = new System.Action(object:  new System.Object(), method:  System.Void NativeRealtimeMultiplayerClient.OnGameThreadForwardingListener.<ParticipantLeft>c__AnonStorey5::<>m__0());
        GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  0);
    }
    private void <LeftRoom>m__0()
    {
        var val_2;
        var val_2 = 0;
        val_2 = val_2 + 1;
        val_2 = this.mListener;
    }

}
