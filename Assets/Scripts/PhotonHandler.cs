using UnityEngine;
internal class PhotonHandler : MonoBehaviour
{
    // Fields
    public static PhotonHandler SP;
    public int updateInterval;
    public int updateIntervalOnSerialize;
    private int nextSendTickCount;
    private int nextSendTickCountOnSerialize;
    private static bool sendThreadShouldRun;
    private static System.Diagnostics.Stopwatch timerToStopConnectionInBackground;
    protected internal static bool AppQuits;
    protected internal static System.Type PingImplementation;
    private const string PlayerPrefsKey = "PUNCloudBestRegion";
    private static UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> <>f__am$cache0;
    private static System.Func<bool> <>f__mg$cache0;
    
    // Properties
    internal static CloudRegionCode BestRegionCodeInPreferences { get; set; }
    
    // Methods
    public PhotonHandler()
    {
    
    }
    protected void Awake()
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        val_11 = null;
        val_11 = null;
        if(0 != PhotonHandler.PlayerPrefsKey)
        {
                val_12 = null;
            val_12 = null;
            if(0 != PhotonHandler.PlayerPrefsKey)
        {
                val_13 = null;
            val_13 = null;
            if(0 != PhotonHandler.PlayerPrefsKey.gameObject)
        {
                val_14 = null;
            val_14 = null;
            UnityEngine.GameObject val_5 = PhotonHandler.PlayerPrefsKey.gameObject;
            UnityEngine.Object.DestroyImmediate(obj:  0);
        }
        
        }
        
        }
        
        val_15 = null;
        val_15 = null;
        PhotonHandler.PlayerPrefsKey = this;
        UnityEngine.GameObject val_6 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
        this.updateInterval = 1000 / PhotonNetwork.sendRate;
        this.updateIntervalOnSerialize = 1000 / PhotonNetwork.sendRateOnSerialize;
        PhotonHandler.StartFallbackSendAckThread();
    }
    protected void Start()
    {
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_2;
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if((PhotonHandler.<>f__am$cache0) == null)
        {
                UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_1 = null;
            val_2 = val_1;
            val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  0, method:  static System.Void PhotonHandler::<Start>m__0(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode loadingMode));
            val_4 = null;
            val_4 = null;
            PhotonHandler.<>f__am$cache0 = val_2;
            val_3 = null;
        }
        
        val_3 = null;
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  0);
    }
    protected void OnApplicationQuit()
    {
        null = null;
        PhotonHandler.AppQuits = true;
        PhotonHandler.StopFallbackSendAckThread();
        PhotonNetwork.Disconnect();
    }
    protected void OnApplicationPause(bool pause)
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        val_4 = null;
        val_4 = null;
        if(PhotonNetwork.BackgroundTimeout <= 0.1f)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        if(PhotonHandler.timerToStopConnectionInBackground == null)
        {
                val_6 = null;
            val_6 = null;
            PhotonHandler.timerToStopConnectionInBackground = new System.Diagnostics.Stopwatch();
            val_5 = null;
        }
        
        val_5 = null;
        Reset();
        val_7 = null;
        if(pause != false)
        {
                val_8 = null;
            Start();
            return;
        }
        
        val_9 = null;
        Stop();
    }
    protected void OnDestroy()
    {
        PhotonHandler.StopFallbackSendAckThread();
    }
    protected void Update()
    {
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        val_16 = null;
        val_16 = null;
        if(PhotonNetwork.networkingPeer == null)
        {
            goto label_3;
        }
        
        if(PhotonNetwork.connectionStateDetailed == 1)
        {
                return;
        }
        
        if(PhotonNetwork.connectionStateDetailed == 15)
        {
                return;
        }
        
        if(PhotonNetwork.offlineMode == true)
        {
                return;
        }
        
        if(PhotonNetwork.isMessageQueueRunning == false)
        {
                return;
        }
        
        val_17 = 1;
        goto label_16;
        label_23:
        val_17 = val_17;
        label_16:
        if((val_17 & PhotonNetwork.isMessageQueueRunning) == false)
        {
            goto label_19;
        }
        
        val_18 = null;
        val_18 = null;
        if(PhotonNetwork.networkingPeer != null)
        {
            goto label_23;
        }
        
        goto label_23;
        label_3:
        UnityEngine.Debug.LogError(message:  0);
        return;
        label_19:
        float val_10 = UnityEngine.Time.realtimeSinceStartup;
        if(PhotonNetwork.isMessageQueueRunning != false)
        {
                val_10 = val_10 * 1000f;
            if((int)val_10 > this.nextSendTickCountOnSerialize)
        {
                val_19 = null;
            val_19 = null;
            PhotonNetwork.networkingPeer.RunViewUpdate();
            int val_16 = this.updateIntervalOnSerialize;
            val_16 = val_16 + (int)val_10;
            this.nextSendTickCount = 0;
            this.nextSendTickCountOnSerialize = val_16;
        }
        
        }
        
        float val_12 = UnityEngine.Time.realtimeSinceStartup;
        val_12 = val_12 * 1000f;
        if((int)val_12 <= this.nextSendTickCount)
        {
                return;
        }
        
        val_20 = 1;
        goto label_34;
        label_41:
        val_20 = val_20;
        label_34:
        if((val_20 & PhotonNetwork.isMessageQueueRunning) == false)
        {
            goto label_37;
        }
        
        val_21 = null;
        val_21 = null;
        if(PhotonNetwork.networkingPeer != null)
        {
            goto label_41;
        }
        
        goto label_41;
        label_37:
        int val_17 = this.updateInterval;
        val_17 = val_17 + (int)val_12;
        this.nextSendTickCount = val_17;
    }
    protected void OnJoinedRoom()
    {
        null = null;
        PhotonNetwork.networkingPeer.LoadLevelIfSynced();
    }
    protected void OnCreatedRoom()
    {
        null = null;
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        PhotonNetwork.networkingPeer.SetLevelInPropsIfSynced(levelId:  val_1.m_Handle.name, asyncLoading:  false);
    }
    public static void StartFallbackSendAckThread()
    {
        var val_3;
        var val_5;
        var val_6;
        var val_7;
        val_3 = null;
        val_3 = null;
        if(PhotonHandler.sendThreadShouldRun != false)
        {
                return;
        }
        
        PhotonHandler.sendThreadShouldRun = true;
        val_5 = null;
        if((PhotonHandler.<>f__mg$cache0) == null)
        {
                val_6 = null;
            val_6 = null;
            PhotonHandler.<>f__mg$cache0 = new System.Func<System.Boolean>(object:  0, method:  public static System.Boolean PhotonHandler::FallbackSendAckThread());
            val_5 = null;
        }
        
        val_5 = null;
        val_7 = null;
        val_7 = null;
        byte val_2 = ExitGames.Client.Photon.SupportClass.StartBackgroundCalls(myThread:  0, millisecondsInterval:  107347968, taskName:  100);
    }
    public static void StopFallbackSendAckThread()
    {
        null = null;
        PhotonHandler.sendThreadShouldRun = false;
    }
    public static bool FallbackSendAckThread()
    {
        System.Diagnostics.Stopwatch val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        val_11 = null;
        val_11 = null;
        if(PhotonHandler.sendThreadShouldRun == false)
        {
                return (bool)PhotonHandler.sendThreadShouldRun;
        }
        
        if(PhotonNetwork.offlineMode == true)
        {
                return (bool)PhotonHandler.sendThreadShouldRun;
        }
        
        val_12 = null;
        val_12 = null;
        if(PhotonNetwork.networkingPeer == null)
        {
                return (bool)PhotonHandler.sendThreadShouldRun;
        }
        
        val_13 = null;
        val_13 = null;
        val_14 = null;
        if(PhotonHandler.timerToStopConnectionInBackground != null)
        {
                val_13 = val_14;
            val_14 = null;
            if(PhotonNetwork.BackgroundTimeout > 0.1f)
        {
                val_15 = null;
            val_15 = null;
            val_16 = 0;
            val_14 = null;
            val_17 = val_14;
            val_14 = null;
            float val_10 = PhotonNetwork.BackgroundTimeout;
            val_10 = val_10 * 1000f;
            if((float)PhotonHandler.timerToStopConnectionInBackground.ElapsedMilliseconds > val_10)
        {
                val_18 = val_14;
            if(PhotonNetwork.connected != false)
        {
                PhotonNetwork.Disconnect();
        }
        
            val_19 = null;
            val_19 = null;
            PhotonHandler.timerToStopConnectionInBackground.Stop();
            val_10 = PhotonHandler.timerToStopConnectionInBackground;
            val_10.Reset();
            return (bool)PhotonHandler.sendThreadShouldRun;
        }
        
        }
        
        }
        
        val_13 = val_14;
        if(PhotonNetwork.isMessageQueueRunning != false)
        {
                val_20 = null;
            val_20 = null;
            val_10 = PhotonNetwork.networkingPeer.ConnectionTime;
            val_16 = 0;
            if((val_10 - PhotonNetwork.networkingPeer.LastSendOutgoingTime) < 201)
        {
                return (bool)PhotonHandler.sendThreadShouldRun;
        }
        
        }
        
        val_21 = null;
        val_21 = null;
        val_10 = PhotonNetwork.networkingPeer;
        bool val_9 = val_10.SendAcksOnly();
        return (bool)PhotonHandler.sendThreadShouldRun;
    }
    internal static CloudRegionCode get_BestRegionCodeInPreferences()
    {
        null = null;
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  0, defaultValue:  "PUNCloudBestRegion");
        bool val_2 = System.String.IsNullOrEmpty(value:  0);
        if(val_2 == false)
        {
                return Region.Parse(codeAsString:  val_2);
        }
        
        return 4;
    }
    internal static void set_BestRegionCodeInPreferences(CloudRegionCode value)
    {
        if(W1 == 4)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  0);
            return;
        }
        
        string val_1 = W1.ToString();
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        UnityEngine.PlayerPrefs.SetString(key:  0, value:  "PUNCloudBestRegion");
    }
    protected internal static void PingAvailableRegionsAndConnectToBest()
    {
        var val_4;
        System.Collections.IEnumerator val_5;
        val_4 = null;
        val_4 = null;
        if(PhotonHandler.PlayerPrefsKey != null)
        {
                val_5 = PingAvailableRegionsCoroutine(connectToBest:  true);
        }
        else
        {
                val_5 = PingAvailableRegionsCoroutine(connectToBest:  true);
        }
        
        UnityEngine.Coroutine val_3 = PhotonHandler.PlayerPrefsKey.StartCoroutine(routine:  val_5);
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    internal System.Collections.IEnumerator PingAvailableRegionsCoroutine(bool connectToBest)
    {
        typeof(PhotonHandler.<PingAvailableRegionsCoroutine>c__Iterator0).__il2cppRuntimeField_38 = connectToBest;
        return (System.Collections.IEnumerator)new System.Object();
    }
    private static PhotonHandler()
    {
    
    }
    private static void <Start>m__0(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode loadingMode)
    {
        null = null;
        PhotonNetwork.networkingPeer.NewSceneLoaded();
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        PhotonNetwork.networkingPeer.SetLevelInPropsIfSynced(levelId:  val_1.m_Handle.name, asyncLoading:  false);
    }

}
