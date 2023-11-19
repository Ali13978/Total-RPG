using UnityEngine;

namespace CodeStage.AntiCheat.Detectors
{
    [UnityEngine.AddComponentMenu]
    public class SpeedHackDetector : ActDetectorBase
    {
        // Fields
        internal const string COMPONENT_NAME = "Speed Hack Detector";
        internal const string FINAL_LOG_PREFIX = "[ACTk] Speed Hack Detector: ";
        private const long TICKS_PER_SECOND = 10000000;
        private const int THRESHOLD = 5000000;
        private const float THRESHOLD_FLOAT = 0.5;
        private static int instancesInScene;
        [UnityEngine.TooltipAttribute]
        public float interval;
        [UnityEngine.TooltipAttribute]
        public byte maxFalsePositives;
        [UnityEngine.TooltipAttribute]
        public int coolDown;
        private byte currentFalsePositives;
        private int currentCooldownShots;
        private long ticksOnStart;
        private long vulnerableTicksOnStart;
        private long prevTicks;
        private long prevIntervalTicks;
        private float vulnerableTimeOnStart;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static CodeStage.AntiCheat.Detectors.SpeedHackDetector <Instance>k__BackingField;
        
        // Properties
        public static CodeStage.AntiCheat.Detectors.SpeedHackDetector Instance { get; set; }
        private static CodeStage.AntiCheat.Detectors.SpeedHackDetector GetOrCreateInstance { get; }
        
        // Methods
        private SpeedHackDetector()
        {
            this.interval = 1f;
            this.maxFalsePositives = 3;
            this.coolDown = 30;
            mem[1152921510034862232] = 257;
            mem[1152921510034862234] = 1;
            val_1 = new UnityEngine.MonoBehaviour();
        }
        public static void StartDetection()
        {
            float val_2;
            byte val_3;
            if(0 == (CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField))
            {
                goto label_4;
            }
            
            if((CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField) == null)
            {
                goto label_6;
            }
            
            val_2 = mem[CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField + 52];
            val_2 = CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField.interval;
            goto label_10;
            label_4:
            UnityEngine.Debug.LogError(message:  0);
            return;
            label_6:
            val_2 = mem[CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField + 52];
            val_2 = CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField.interval;
            label_10:
            if((CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField) != null)
            {
                    val_3 = mem[CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField + 56];
                val_3 = CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField.maxFalsePositives;
            }
            else
            {
                    val_3 = mem[CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField + 56];
                val_3 = CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField.maxFalsePositives;
            }
            
            CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField.StartDetectionInternal(callback:  0, checkInterval:  val_2, falsePositives:  val_3, shotsTillCooldown:  CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField.coolDown);
        }
        public static void StartDetection(UnityEngine.Events.UnityAction callback)
        {
            CodeStage.AntiCheat.Detectors.SpeedHackDetector.StartDetection(callback:  CodeStage.AntiCheat.Detectors.SpeedHackDetector.GetOrCreateInstance, interval:  val_1.interval);
        }
        public static void StartDetection(UnityEngine.Events.UnityAction callback, float interval)
        {
            CodeStage.AntiCheat.Detectors.SpeedHackDetector.StartDetection(callback:  CodeStage.AntiCheat.Detectors.SpeedHackDetector.GetOrCreateInstance, interval:  interval, maxFalsePositives:  X1);
        }
        public static void StartDetection(UnityEngine.Events.UnityAction callback, float interval, byte maxFalsePositives)
        {
            CodeStage.AntiCheat.Detectors.SpeedHackDetector.StartDetection(callback:  CodeStage.AntiCheat.Detectors.SpeedHackDetector.GetOrCreateInstance, interval:  interval, maxFalsePositives:  maxFalsePositives, coolDown:  W2);
        }
        public static void StartDetection(UnityEngine.Events.UnityAction callback, float interval, byte maxFalsePositives, int coolDown)
        {
            CodeStage.AntiCheat.Detectors.SpeedHackDetector.GetOrCreateInstance.StartDetectionInternal(callback:  maxFalsePositives, checkInterval:  interval, falsePositives:  coolDown, shotsTillCooldown:  W3);
        }
        public static void StopDetection()
        {
            var val_8;
            CodeStage.AntiCheat.Detectors.SpeedHackDetector val_9;
            val_8 = 1152921504836079616;
            val_9 = CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField;
            if(0 == val_9)
            {
                    return;
            }
            
            val_9 = ???;
            val_8 = ???;
            goto typeof(CodeStage.AntiCheat.Detectors.SpeedHackDetector).__il2cppRuntimeField_1B0;
        }
        public static void Dispose()
        {
            var val_8;
            CodeStage.AntiCheat.Detectors.SpeedHackDetector val_9;
            val_8 = 1152921504836079616;
            val_9 = CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField;
            if(0 == val_9)
            {
                    return;
            }
            
            val_9 = ???;
            val_8 = ???;
            goto typeof(CodeStage.AntiCheat.Detectors.SpeedHackDetector).__il2cppRuntimeField_170;
        }
        public static CodeStage.AntiCheat.Detectors.SpeedHackDetector get_Instance()
        {
            return (CodeStage.AntiCheat.Detectors.SpeedHackDetector)CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField;
        }
        private static void set_Instance(CodeStage.AntiCheat.Detectors.SpeedHackDetector value)
        {
            CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField = X1;
        }
        private static CodeStage.AntiCheat.Detectors.SpeedHackDetector get_GetOrCreateInstance()
        {
            CodeStage.AntiCheat.Detectors.SpeedHackDetector val_5 = CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField;
            if(0 != val_5)
            {
                    return (CodeStage.AntiCheat.Detectors.SpeedHackDetector)CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField;
            }
            
            if(0 == CodeStage.AntiCheat.Detectors.ActDetectorBase.detectorsContainer)
            {
                    CodeStage.AntiCheat.Detectors.ActDetectorBase.detectorsContainer = new UnityEngine.GameObject(name:  "Anti-Cheat Toolkit Detectors");
            }
            
            val_5 = AddComponent<CodeStage.AntiCheat.Detectors.SpeedHackDetector>();
            CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField = val_5;
            return (CodeStage.AntiCheat.Detectors.SpeedHackDetector)CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField;
        }
        private void Awake()
        {
            int val_3 = CodeStage.AntiCheat.Detectors.SpeedHackDetector.instancesInScene;
            val_3 = val_3 + 1;
            CodeStage.AntiCheat.Detectors.SpeedHackDetector.instancesInScene = val_3;
            if((this.Init(instance:  CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField, detectorName:  "Speed Hack Detector")) != false)
            {
                    CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField = this;
            }
            
            UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_2 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void CodeStage.AntiCheat.Detectors.SpeedHackDetector::OnLevelWasLoadedNew(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode));
            UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  0);
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            int val_1 = CodeStage.AntiCheat.Detectors.SpeedHackDetector.instancesInScene;
            val_1 = val_1 - 1;
            CodeStage.AntiCheat.Detectors.SpeedHackDetector.instancesInScene = val_1;
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
            if(CodeStage.AntiCheat.Detectors.SpeedHackDetector.instancesInScene <= 1)
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
            
                if(0 == (CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField))
            {
                    return;
            }
            
            }
            
            val_8 = ???;
            val_10 = ???;
            goto typeof(CodeStage.AntiCheat.Detectors.SpeedHackDetector).__il2cppRuntimeField_170;
        }
        private void OnApplicationPause(bool pause)
        {
            if(pause != false)
            {
                    return;
            }
            
            this.ResetStartTicks();
        }
        private void Update()
        {
            if(true == 0)
            {
                    return;
            }
            
            System.DateTime val_1 = System.DateTime.UtcNow;
            long val_2 = val_1.ticks._ticks.Ticks;
            long val_10 = this.prevTicks;
            val_10 = val_2 - val_10;
            if(val_10 >= 10000001)
            {
                goto label_4;
            }
            
            float val_11 = this.interval;
            long val_12 = this.prevIntervalTicks;
            this.prevTicks = val_2;
            val_11 = val_11 * (1E+07f);
            val_12 = val_2 - val_12;
            if(val_12 < (long)val_11)
            {
                    return;
            }
            
            long val_3 = val_2 - this.ticksOnStart;
            long val_6 = this.vulnerableTicksOnStart + val_3;
            val_6 = ((long)System.Environment.TickCount * 10000) - val_6;
            float val_7 = UnityEngine.Time.realtimeSinceStartup;
            byte val_16 = this.currentFalsePositives;
            if(System.Math.Abs((float)val_6) > 5000000f)
            {
                goto label_9;
            }
            
            float val_14 = (float)val_3;
            val_14 = val_14 / (1E+07f);
            val_7 = val_7 - this.vulnerableTimeOnStart;
            val_7 = val_14 - val_7;
            if(System.Math.Abs(val_7) > 0.5f)
            {
                goto label_9;
            }
            
            if(((val_16 & 255) == 0) || (this.coolDown < 1))
            {
                goto label_16;
            }
            
            val_16 = val_16 >> 32;
            val_16 = val_16 + 1;
            this.currentCooldownShots = val_16;
            if(val_16 < this.coolDown)
            {
                goto label_16;
            }
            
            this.currentFalsePositives = 0;
            goto label_16;
            label_4:
            this.ResetStartTicks();
            return;
            label_9:
            val_16 = val_16 + 1;
            this.currentFalsePositives = val_16;
            if((val_16 & 255) > this.maxFalsePositives)
            {
                    this.OnCheatingDetected();
            }
            else
            {
                    this.currentCooldownShots = 0;
                this.ResetStartTicks();
            }
            
            label_16:
            this.prevIntervalTicks = val_2;
        }
        private void StartDetectionInternal(UnityEngine.Events.UnityAction callback, float checkInterval, byte falsePositives, int shotsTillCooldown)
        {
            UnityEngine.Object val_3;
            object val_4;
            if(true == 0)
            {
                goto label_1;
            }
            
            val_3 = "[ACTk] Speed Hack Detector: already running!";
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
            
            UnityEngine.Debug.LogWarning(message:  0, context:  "[ACTk] Speed Hack Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?");
            goto label_10;
            label_5:
            val_3 = "[ACTk] Speed Hack Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!";
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
            mem[1152921510036864328] = callback;
            this.interval = checkInterval;
            this.maxFalsePositives = falsePositives;
            this.coolDown = shotsTillCooldown;
            this.ResetStartTicks();
            mem[1152921510036864337] = 257;
            this.currentFalsePositives = 0;
            this.currentCooldownShots = 0;
            return;
            label_13:
            UnityEngine.Debug.LogWarning(message:  0, context:  "[ACTk] Speed Hack Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.");
            this.enabled = false;
        }
        protected override void StartDetectionAutomatically()
        {
            this.StartDetectionInternal(callback:  0, checkInterval:  this.interval, falsePositives:  this.maxFalsePositives, shotsTillCooldown:  this.coolDown);
        }
        protected override void PauseDetector()
        {
            mem[1152921510037092433] = 0;
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
            
            mem[1152921510037204433] = 1;
        }
        protected override void StopDetectionInternal()
        {
            if(W8 == 0)
            {
                    return;
            }
            
            mem[1152921510037316424] = 0;
            mem[1152921510037316433] = 0;
        }
        protected override void DisposeInternal()
        {
            var val_2 = this;
            this.DisposeInternal();
            if(0 != (CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField))
            {
                    return;
            }
            
            CodeStage.AntiCheat.Detectors.SpeedHackDetector.<Instance>k__BackingField = 0;
        }
        private void ResetStartTicks()
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            this.ticksOnStart = val_1.ticks._ticks.Ticks;
            long val_5 = (long)System.Environment.TickCount;
            val_5 = val_5 * 10000;
            this.vulnerableTicksOnStart = val_5;
            this.prevTicks = this.ticksOnStart;
            this.prevIntervalTicks = this.ticksOnStart;
            this.vulnerableTimeOnStart = UnityEngine.Time.realtimeSinceStartup;
        }
    
    }

}
