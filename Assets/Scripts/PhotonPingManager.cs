using UnityEngine;
public class PhotonPingManager
{
    // Fields
    public bool UseNative;
    public static int Attempts;
    public static bool IgnoreInitialAttempt;
    public static int MaxMilliseconsPerPing;
    private const string wssProtocolString = "wss://";
    private int PingsRunning;
    
    // Properties
    public Region BestRegion { get; }
    public bool Done { get; }
    
    // Methods
    public PhotonPingManager()
    {
    
    }
    public Region get_BestRegion()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        List.Enumerator<T> val_2 = PhotonNetwork.networkingPeer.AvailableRegions.GetEnumerator();
        val_6 = 0;
        goto label_12;
        label_14:
        System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_3 = 0.InitializationCallback;
        string val_4 = 0 + "BestRegion checks region: "("BestRegion checks region: ");
        UnityEngine.Debug.Log(message:  0);
        label_12:
        if((0 & 1) != 0)
        {
            goto label_14;
        }
        
        val_7 = 0;
        val_8 = 1;
        0.Dispose();
        if(( & 1) != 0)
        {
                return (Region);
        }
        
        if( == 0)
        {
                return (Region);
        }
        
        return (Region);
    }
    public bool get_Done()
    {
        return (bool)(this.PingsRunning == 0) ? 1 : 0;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public System.Collections.IEnumerator PingSocket(Region region)
    {
        if(null != 0)
        {
                typeof(PhotonPingManager.<PingSocket>c__Iterator0).__il2cppRuntimeField_10 = region;
        }
        else
        {
                mem[16] = region;
        }
        
        typeof(PhotonPingManager.<PingSocket>c__Iterator0).__il2cppRuntimeField_50 = this;
        return (System.Collections.IEnumerator)new System.Object();
    }
    public static string ResolveHost(string hostName)
    {
        var val_5;
        string val_6;
        var val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        val_6 = System.String.Empty;
        val_7 = X1;
        System.Net.IPAddress[] val_1 = System.Net.Dns.GetHostAddresses(hostNameOrAddress:  0);
        if(val_1.Length == 1)
        {
                label_29:
            val_6 = val_1[0];
            return (string)val_1;
        }
        
        val_8 = 0;
        goto label_9;
        label_20:
        val_8 = 1;
        label_9:
        if(val_8 >= val_1.Length)
        {
                return (string)val_1;
        }
        
        if(val_8 >= val_1.Length)
        {
                val_7 = 0;
        }
        
        System.Net.IPAddress val_6 = val_1[1];
        if(val_6 == null)
        {
            goto label_20;
        }
        
        if((val_6.Contains(value:  ":")) == true)
        {
            goto label_29;
        }
        
        if(((System.String.IsNullOrEmpty(value:  0)) == false) || (val_1 != null))
        {
            goto label_20;
        }
        
        goto label_20;
    }
    private static PhotonPingManager()
    {
        PhotonPingManager.wssProtocolString = null;
        PhotonPingManager.IgnoreInitialAttempt = true;
        PhotonPingManager.MaxMilliseconsPerPing = 800;
    }

}
