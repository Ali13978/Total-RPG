using UnityEngine;

namespace CodeStage.AntiCheat.Detectors
{
    [UnityEngine.AddComponentMenu]
    public class TimeCheatingDetector : ActDetectorBase
    {
        // Fields
        internal const string COMPONENT_NAME = "Time Cheating Detector";
        private const string FINAL_LOG_PREFIX = "[ACTk] Time Cheating Detector: ";
        private const string TIME_SERVER = "pool.ntp.org";
        private const int NTP_DATA_BUFFER_LENGTH = 48;
        private static int instancesInScene;
        private readonly System.DateTime date1900;
        [UnityEngine.TooltipAttribute]
        [UnityEngine.RangeAttribute]
        public int interval;
        [UnityEngine.TooltipAttribute]
        public int threshold;
        private System.Net.Sockets.Socket asyncSocket;
        private System.Action<double> getOnlineTimeCallback;
        private string targetHost;
        private byte[] targetIP;
        private System.Net.IPEndPoint targetEndpoint;
        private byte[] ntpData;
        private System.Net.Sockets.SocketAsyncEventArgs connectArgs;
        private System.Net.Sockets.SocketAsyncEventArgs sendArgs;
        private System.Net.Sockets.SocketAsyncEventArgs receiveArgs;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static CodeStage.AntiCheat.Detectors.TimeCheatingDetector <Instance>k__BackingField;
        
        // Properties
        public static CodeStage.AntiCheat.Detectors.TimeCheatingDetector Instance { get; set; }
        private static CodeStage.AntiCheat.Detectors.TimeCheatingDetector GetOrCreateInstance { get; }
        
        // Methods
        private TimeCheatingDetector()
        {
            mem[1152921510037652448] = 0;
            this.interval = 1;
            this.threshold = 65;
            this.date1900 = 0;
            this.ntpData = null;
            mem[1152921510037652408] = 257;
            mem[1152921510037652410] = 1;
            this = new UnityEngine.MonoBehaviour();
        }
        public static void StartDetection()
        {
            int val_2;
            if(0 == (CodeStage.AntiCheat.Detectors.TimeCheatingDetector.<Instance>k__BackingField))
            {
                goto label_4;
            }
            
            if((CodeStage.AntiCheat.Detectors.TimeCheatingDetector.<Instance>k__BackingField) == null)
            {
                goto label_6;
            }
            
            val_2 = mem[CodeStage.AntiCheat.Detectors.TimeCheatingDetector.<Instance>k__BackingField + 72];
            val_2 = CodeStage.AntiCheat.Detectors.TimeCheatingDetector.<Instance>k__BackingField.interval;
            goto label_7;
            label_4:
            UnityEngine.Debug.LogError(message:  0);
            return;
            label_6:
            val_2 = mem[CodeStage.AntiCheat.Detectors.TimeCheatingDetector.<Instance>k__BackingField + 72];
            val_2 = CodeStage.AntiCheat.Detectors.TimeCheatingDetector.<Instance>k__BackingField.interval;
            label_7:
            CodeStage.AntiCheat.Detectors.TimeCheatingDetector.<Instance>k__BackingField.StartDetectionInternal(callback:  0, checkInterval:  val_2);
        }
        public static void StartDetection(UnityEngine.Events.UnityAction callback)
        {
            CodeStage.AntiCheat.Detectors.TimeCheatingDetector.StartDetection(callback:  CodeStage.AntiCheat.Detectors.TimeCheatingDetector.GetOrCreateInstance, interval:  X1);
        }
        public static void StartDetection(UnityEngine.Events.UnityAction callback, int interval)
        {
            CodeStage.AntiCheat.Detectors.TimeCheatingDetector.GetOrCreateInstance.StartDetectionInternal(callback:  interval, checkInterval:  W2);
        }
        public static void StopDetection()
        {
            var val_8;
            CodeStage.AntiCheat.Detectors.TimeCheatingDetector val_9;
            val_8 = 1152921504836132864;
            val_9 = CodeStage.AntiCheat.Detectors.TimeCheatingDetector.<Instance>k__BackingField;
            if(0 == val_9)
            {
                    return;
            }
            
            val_9 = ???;
            val_8 = ???;
            goto typeof(CodeStage.AntiCheat.Detectors.TimeCheatingDetector).__il2cppRuntimeField_1B0;
        }
        public static void Dispose()
        {
            var val_8;
            CodeStage.AntiCheat.Detectors.TimeCheatingDetector val_9;
            val_8 = 1152921504836132864;
            val_9 = CodeStage.AntiCheat.Detectors.TimeCheatingDetector.<Instance>k__BackingField;
            if(0 == val_9)
            {
                    return;
            }
            
            val_9 = ???;
            val_8 = ???;
            goto typeof(CodeStage.AntiCheat.Detectors.TimeCheatingDetector).__il2cppRuntimeField_170;
        }
        public static CodeStage.AntiCheat.Detectors.TimeCheatingDetector get_Instance()
        {
            return (CodeStage.AntiCheat.Detectors.TimeCheatingDetector)CodeStage.AntiCheat.Detectors.TimeCheatingDetector.<Instance>k__BackingField;
        }
        private static void set_Instance(CodeStage.AntiCheat.Detectors.TimeCheatingDetector value)
        {
            CodeStage.AntiCheat.Detectors.TimeCheatingDetector.<Instance>k__BackingField = X1;
        }
        private static CodeStage.AntiCheat.Detectors.TimeCheatingDetector get_GetOrCreateInstance()
        {
            CodeStage.AntiCheat.Detectors.TimeCheatingDetector val_5 = CodeStage.AntiCheat.Detectors.TimeCheatingDetector.<Instance>k__BackingField;
            if(0 != val_5)
            {
                    return (CodeStage.AntiCheat.Detectors.TimeCheatingDetector)CodeStage.AntiCheat.Detectors.TimeCheatingDetector.<Instance>k__BackingField;
            }
            
            if(0 == CodeStage.AntiCheat.Detectors.ActDetectorBase.detectorsContainer)
            {
                    CodeStage.AntiCheat.Detectors.ActDetectorBase.detectorsContainer = new UnityEngine.GameObject(name:  "Anti-Cheat Toolkit Detectors");
            }
            
            val_5 = AddComponent<CodeStage.AntiCheat.Detectors.TimeCheatingDetector>();
            CodeStage.AntiCheat.Detectors.TimeCheatingDetector.<Instance>k__BackingField = val_5;
            return (CodeStage.AntiCheat.Detectors.TimeCheatingDetector)CodeStage.AntiCheat.Detectors.TimeCheatingDetector.<Instance>k__BackingField;
        }
        private void Awake()
        {
            int val_3 = CodeStage.AntiCheat.Detectors.TimeCheatingDetector.instancesInScene;
            val_3 = val_3 + 1;
            CodeStage.AntiCheat.Detectors.TimeCheatingDetector.instancesInScene = val_3;
            if((this.Init(instance:  CodeStage.AntiCheat.Detectors.TimeCheatingDetector.<Instance>k__BackingField, detectorName:  "Time Cheating Detector")) != false)
            {
                    CodeStage.AntiCheat.Detectors.TimeCheatingDetector.<Instance>k__BackingField = this;
            }
            
            UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_2 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void CodeStage.AntiCheat.Detectors.TimeCheatingDetector::OnLevelWasLoadedNew(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode));
            UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  0);
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            int val_1 = CodeStage.AntiCheat.Detectors.TimeCheatingDetector.instancesInScene;
            val_1 = val_1 - 1;
            CodeStage.AntiCheat.Detectors.TimeCheatingDetector.instancesInScene = val_1;
        }
        private void OnLevelWasLoadedNew(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
        {
            this.OnLevelLoadedCallback();
        }
        private void OnLevelLoadedCallback()
        {
            var val_8;
            var val_10;
            val_8 = this;
            if(CodeStage.AntiCheat.Detectors.TimeCheatingDetector.instancesInScene <= 1)
            {
                    if(W9 != 0)
            {
                    return;
            }
            
            }
            else
            {
                    if(W9 != 0)
            {
                    return;
            }
            
                if(0 == (CodeStage.AntiCheat.Detectors.TimeCheatingDetector.<Instance>k__BackingField))
            {
                    return;
            }
            
            }
            
            val_8 = ???;
            val_10 = ???;
            goto typeof(CodeStage.AntiCheat.Detectors.TimeCheatingDetector).__il2cppRuntimeField_170;
        }
        private void StartDetectionInternal(UnityEngine.Events.UnityAction callback, int checkInterval)
        {
            UnityEngine.Object val_3;
            object val_4;
            if(true == 0)
            {
                goto label_1;
            }
            
            val_3 = "[ACTk] Time Cheating Detector: already running!";
            val_4 = 0;
            goto label_4;
            label_1:
            bool val_2 = this.enabled;
            if(val_2 == false)
            {
                goto label_5;
            }
            
            if(callback == null)
            {
                goto label_6;
            }
            
            if(val_2 == false)
            {
                goto label_10;
            }
            
            UnityEngine.Debug.LogWarning(message:  0, context:  "[ACTk] Time Cheating Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?");
            goto label_10;
            label_5:
            val_3 = "[ACTk] Time Cheating Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!";
            val_4 = 0;
            label_4:
            UnityEngine.Debug.LogWarning(message:  val_4, context:  val_3);
            return;
            label_6:
            if(val_2 == false)
            {
                goto label_13;
            }
            
            label_10:
            this.interval = checkInterval;
            mem[1152921510039173848] = callback;
            var val_3 = 60;
            val_3 = checkInterval * val_3;
            this.InvokeRepeating(methodName:  "CheckForCheat", time:  0f, repeatRate:  (float)val_3);
            mem[1152921510039173857] = 257;
            return;
            label_13:
            UnityEngine.Debug.LogWarning(message:  0, context:  "[ACTk] Time Cheating Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.");
            this.enabled = false;
        }
        protected override void StartDetectionAutomatically()
        {
            this.StartDetectionInternal(callback:  0, checkInterval:  this.interval);
        }
        protected override void PauseDetector()
        {
            mem[1152921510039401953] = 0;
        }
        protected override void ResumeDetector()
        {
            if(X8 == 0)
            {
                    if(W8 == 0)
            {
                    return;
            }
            
            }
            
            mem[1152921510039513953] = 1;
        }
        protected override void StopDetectionInternal()
        {
            if(true == 0)
            {
                    return;
            }
            
            this.CancelInvoke(methodName:  "CheckForCheat");
            mem[1152921510039625944] = 0;
            mem[1152921510039625953] = 0;
        }
        protected override void DisposeInternal()
        {
            this.DisposeInternal();
            if(0 == (CodeStage.AntiCheat.Detectors.TimeCheatingDetector.<Instance>k__BackingField))
            {
                    CodeStage.AntiCheat.Detectors.TimeCheatingDetector.<Instance>k__BackingField = 0;
            }
            
            if(this.asyncSocket.Connected == false)
            {
                    return;
            }
            
            this.asyncSocket.Close();
        }
        private void CheckForCheat()
        {
            if(true == 0)
            {
                    return;
            }
            
            this.GetOnlineTimeAsync(server:  "pool.ntp.org", callback:  new System.Action<System.Double>(object:  this, method:  System.Void CodeStage.AntiCheat.Detectors.TimeCheatingDetector::OnTimeGot(double onlineTime)));
        }
        private void OnTimeGot(double onlineTime)
        {
            double val_6 = onlineTime;
            if(val_6 > 0f)
            {
                    double val_1 = this.GetLocalTime();
                UnityEngine.Timeline.DiscreteTime val_3 = new UnityEngine.Timeline.DiscreteTime(time:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = (long)val_6 * 10000});
                UnityEngine.Timeline.DiscreteTime val_5 = new UnityEngine.Timeline.DiscreteTime(time:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = (long)val_1 * 10000});
                val_6 = val_1;
                val_1 = val_6 - val_1;
                if(System.Math.Abs(val_1) <= (double)this.threshold)
            {
                    return;
            }
            
                this.OnCheatingDetected();
                return;
            }
            
            UnityEngine.Debug.LogWarning(message:  0);
        }
        public static double GetOnlineTime(string server)
        {
            typeof(System.Byte[]).__il2cppRuntimeField_20 = 27;
            System.Net.Sockets.Socket val_3 = new System.Net.Sockets.Socket(family:  2, type:  2, proto:  17);
            System.Net.IPEndPoint val_4 = new System.Net.IPEndPoint(address:  System.Net.Dns.GetHostEntry(hostNameOrAddress:  0).AddressList[0], port:  123);
            Connect(remoteEP:  null);
            ReceiveTimeout = 184;
            int val_5 = Send(buf:  null);
            int val_6 = Receive(buffer:  null);
            Close();
            Il2CppClass* val_7 = System.Byte[].__il2cppRuntimeField_parent << 24;
            var val_8 = typeof(System.Byte[]).__il2cppRuntimeField_4C << 24;
            double val_12 = 1000;
            double val_11 = (double)((System.Byte[].__il2cppRuntimeField_parent << 24) | typeof(System.Byte[]).__il2cppRuntimeField_4B);
            val_11 = val_11 * val_12;
            val_12 = ((double)((typeof(System.Byte[]).__il2cppRuntimeField_4C << 24) | typeof(System.Byte[]).__il2cppRuntimeField_4F)) * val_12;
            val_12 = val_12 * (2.3283064365387E-10);
            val_12 = val_11 + val_12;
            return (double)val_12;
        }
        public void GetOnlineTimeAsync(string server, System.Action<double> callback)
        {
            object val_10;
            System.Net.IPEndPoint val_11;
            val_10 = this;
            if(val_2.Length == 0)
            {
                goto label_5;
            }
            
            if(this.asyncSocket == null)
            {
                    System.Net.Sockets.Socket val_3 = new System.Net.Sockets.Socket(family:  2, type:  2, proto:  17);
                this.asyncSocket = null;
            }
            
            this.targetHost = server;
            System.Net.IPAddress val_10 = System.Net.Dns.GetHostEntry(hostNameOrAddress:  0).AddressList[0];
            System.Byte[] val_4 = val_10.GetAddressBytes();
            if(val_4 != this.targetIP)
            {
                    System.Net.IPEndPoint val_5 = new System.Net.IPEndPoint(address:  val_10, port:  123);
                this.targetIP = val_4;
                this.targetEndpoint = null;
            }
            
            if(this.connectArgs == null)
            {
                goto label_10;
            }
            
            val_11 = this.targetEndpoint;
            goto label_19;
            label_5:
            val_10 = 0 + "[ACTk] Time Cheating Detector: Could not resolve IP from the host "("[ACTk] Time Cheating Detector: Could not resolve IP from the host ") + server;
            UnityEngine.Debug.Log(message:  0);
            callback.Invoke(obj:  -1);
            return;
            label_10:
            System.Net.Sockets.SocketAsyncEventArgs val_7 = new System.Net.Sockets.SocketAsyncEventArgs();
            this.connectArgs = null;
            System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs> val_8 = new System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs>(object:  this, method:  System.Void CodeStage.AntiCheat.Detectors.TimeCheatingDetector::OnSockedConnected(object sender, System.Net.Sockets.SocketAsyncEventArgs e));
            add_Completed(value:  null);
            val_11 = this.targetEndpoint;
            label_19:
            0.RemoteEndPoint = val_11;
            this.asyncSocket.ReceiveTimeout = 184;
            this.getOnlineTimeCallback = callback;
            bool val_9 = this.asyncSocket.ConnectAsync(e:  this.connectArgs);
        }
        private void OnSockedConnected(object sender, System.Net.Sockets.SocketAsyncEventArgs e)
        {
            var val_7;
            System.Net.IPEndPoint val_8;
            System.Byte[] val_9;
            if(e.SocketError != 0)
            {
                    val_7 = null;
                typeof(System.Object[]).__il2cppRuntimeField_20 = "[ACTk] Time Cheating Detector: Could not get NTP time from ";
                typeof(System.Object[]).__il2cppRuntimeField_28 = this.targetHost;
                typeof(System.Object[]).__il2cppRuntimeField_30 = " =/\n";
                typeof(System.Object[]).__il2cppRuntimeField_38 = e;
                string val_2 = +0;
                UnityEngine.Debug.Log(message:  0);
                if(this.getOnlineTimeCallback == null)
            {
                    return;
            }
            
                this.getOnlineTimeCallback.Invoke(obj:  -1);
                return;
            }
            
            if(true == 0)
            {
                    return;
            }
            
            this.ntpData[0] = 27;
            if(this.sendArgs != null)
            {
                    val_8 = this.targetEndpoint;
            }
            else
            {
                    this.sendArgs = new System.Net.Sockets.SocketAsyncEventArgs();
                add_Completed(value:  new System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs>(object:  this, method:  System.Void CodeStage.AntiCheat.Detectors.TimeCheatingDetector::OnSocketSend(object sender, System.Net.Sockets.SocketAsyncEventArgs e)));
                this.sendArgs.UserToken = this.asyncSocket;
                val_9 = this.ntpData;
                this.sendArgs.SetBuffer(buffer:  val_9, offset:  0, count:  48);
                val_8 = this.targetEndpoint;
            }
            
            0.RemoteEndPoint = val_8;
            bool val_5 = this.asyncSocket.SendAsync(e:  this.sendArgs);
        }
        private void OnSocketSend(object sender, System.Net.Sockets.SocketAsyncEventArgs e)
        {
            var val_8;
            System.Net.IPEndPoint val_9;
            System.Byte[] val_10;
            if(true == 0)
            {
                    return;
            }
            
            if(e.SocketError != 0)
            {
                    val_8 = null;
                typeof(System.Object[]).__il2cppRuntimeField_20 = "[ACTk] Time Cheating Detector: Could not get NTP time from ";
                typeof(System.Object[]).__il2cppRuntimeField_28 = this.targetHost;
                typeof(System.Object[]).__il2cppRuntimeField_30 = " =/\n";
                typeof(System.Object[]).__il2cppRuntimeField_38 = e;
                string val_2 = +0;
                UnityEngine.Debug.Log(message:  0);
                if(this.getOnlineTimeCallback == null)
            {
                    return;
            }
            
                this.getOnlineTimeCallback.Invoke(obj:  -1);
                return;
            }
            
            if(e.LastOperation != 7)
            {
                    return;
            }
            
            if(this.receiveArgs != null)
            {
                    val_9 = this.targetEndpoint;
            }
            else
            {
                    this.receiveArgs = new System.Net.Sockets.SocketAsyncEventArgs();
                add_Completed(value:  new System.EventHandler<System.Net.Sockets.SocketAsyncEventArgs>(object:  this, method:  System.Void CodeStage.AntiCheat.Detectors.TimeCheatingDetector::OnSocketReceive(object sender, System.Net.Sockets.SocketAsyncEventArgs e)));
                this.receiveArgs.UserToken = this.asyncSocket;
                val_10 = this.ntpData;
                this.receiveArgs.SetBuffer(buffer:  val_10, offset:  0, count:  48);
                val_9 = this.targetEndpoint;
            }
            
            0.RemoteEndPoint = val_9;
            bool val_6 = this.asyncSocket.ReceiveAsync(e:  this.receiveArgs);
        }
        private void OnSocketReceive(object sender, System.Net.Sockets.SocketAsyncEventArgs e)
        {
            byte val_5;
            if(true == 0)
            {
                    return;
            }
            
            System.Byte[] val_1 = e.Buffer;
            this.ntpData = val_1;
            val_5 = this.ntpData[41];
            byte val_6 = this.ntpData[42];
            byte val_9 = this.ntpData[45];
            byte val_10 = this.ntpData[46];
            if(this.getOnlineTimeCallback == null)
            {
                    return;
            }
            
            byte val_2 = val_1[40] << 24;
            double val_13 = 1000;
            val_2 = val_2 | this.ntpData[43];
            double val_12 = (double)val_2;
            val_12 = val_12 * val_13;
            val_13 = ((double)(this.ntpData[44] << 24) | this.ntpData[47]) * val_13;
            val_13 = val_13 * (2.3283064365387E-10);
            val_13 = val_12 + val_13;
            this.getOnlineTimeCallback.Invoke(obj:  val_13);
        }
        private double GetLocalTime()
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            return (double)D0;
        }
    
    }

}
