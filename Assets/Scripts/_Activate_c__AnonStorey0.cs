using UnityEngine;
private sealed class Way.<Activate>c__AnonStorey0
{
    // Fields
    internal System.Collections.Generic.KeyValuePair<TzarGames.Endless.EndlessSpawner, System.Collections.Generic.List<TzarGames.Endless.Gate>> room;
    
    // Methods
    public Way.<Activate>c__AnonStorey0()
    {
    
    }
    internal void <>m__0()
    {
        List.Enumerator<T> val_1 = this.room.GetEnumerator();
        do
        {
            label_12:
            if((0 & 1) == 0)
        {
            goto label_15;
        }
        
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_2 = 0.InitializationCallback;
            string val_4 = this.room.InitializationCallback.name;
            string val_5 = 0 + "Unexpected gate unblocking in room ";
            UnityEngine.Debug.Log(message:  0);
        }
        while(0 == val_2);
        
        val_2.SetBlocked(blocked:  false);
        goto label_12;
        label_15:
        0.Dispose();
        if((0 & 1) != 0)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
    
    }

}
