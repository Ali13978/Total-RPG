using UnityEngine;

namespace CodeStage.AntiCheat.Detectors
{
    [UnityEngine.AddComponentMenu]
    public class ObscuredCheatingDetector : ActDetectorBase
    {
        // Fields
        internal const string COMPONENT_NAME = "Obscured Cheating Detector";
        internal const string FINAL_LOG_PREFIX = "[ACTk] Obscured Cheating Detector: ";
        private static int instancesInScene;
        [UnityEngine.TooltipAttribute]
        public float floatEpsilon;
        [UnityEngine.TooltipAttribute]
        public float vector2Epsilon;
        [UnityEngine.TooltipAttribute]
        public float vector3Epsilon;
        [UnityEngine.TooltipAttribute]
        public float quaternionEpsilon;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector <Instance>k__BackingField;
        
        // Properties
        public static CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector Instance { get; set; }
        private static CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector GetOrCreateInstance { get; }
        internal static bool IsRunning { get; }
        
        // Methods
        private ObscuredCheatingDetector()
        {
            mem[1152921510032681144] = 257;
            this.floatEpsilon = ;
            this.vector2Epsilon = ;
            this.vector3Epsilon = 0.1f;
            this.quaternionEpsilon = 0.1f;
            mem[1152921510032681146] = 1;
            val_1 = new UnityEngine.MonoBehaviour();
        }
        public static void StartDetection()
        {
            if(0 != (CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField))
            {
                    CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField.StartDetectionInternal(callback:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  0);
        }
        public static void StartDetection(UnityEngine.Events.UnityAction callback)
        {
            CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.GetOrCreateInstance.StartDetectionInternal(callback:  X1);
        }
        public static void StopDetection()
        {
            var val_8;
            CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector val_9;
            val_8 = 1152921504836026368;
            val_9 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField;
            if(0 == val_9)
            {
                    return;
            }
            
            val_9 = ???;
            val_8 = ???;
            goto typeof(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector).__il2cppRuntimeField_1B0;
        }
        public static void Dispose()
        {
            var val_8;
            CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector val_9;
            val_8 = 1152921504836026368;
            val_9 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField;
            if(0 == val_9)
            {
                    return;
            }
            
            val_9 = ???;
            val_8 = ???;
            goto typeof(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector).__il2cppRuntimeField_170;
        }
        public static CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector get_Instance()
        {
            return (CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector)CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField;
        }
        private static void set_Instance(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector value)
        {
            CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField = X1;
        }
        private static CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector get_GetOrCreateInstance()
        {
            CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector val_5 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField;
            if(0 != val_5)
            {
                    return (CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector)CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField;
            }
            
            if(0 == CodeStage.AntiCheat.Detectors.ActDetectorBase.detectorsContainer)
            {
                    CodeStage.AntiCheat.Detectors.ActDetectorBase.detectorsContainer = new UnityEngine.GameObject(name:  "Anti-Cheat Toolkit Detectors");
            }
            
            val_5 = AddComponent<CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector>();
            CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField = val_5;
            return (CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector)CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField;
        }
        internal static bool get_IsRunning()
        {
            var val_2;
            if((CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField) != null)
            {
                    var val_1 = ((CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField + 49) != 0) ? 1 : 0;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        private void Awake()
        {
            int val_3 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.instancesInScene;
            val_3 = val_3 + 1;
            CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.instancesInScene = val_3;
            if((this.Init(instance:  CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField, detectorName:  "Obscured Cheating Detector")) != false)
            {
                    CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField = this;
            }
            
            UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_2 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector::OnLevelWasLoadedNew(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode));
            UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  0);
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            int val_1 = CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.instancesInScene;
            val_1 = val_1 - 1;
            CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.instancesInScene = val_1;
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
            if(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.instancesInScene <= 1)
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
            
                if(0 == (CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField))
            {
                    return;
            }
            
            }
            
            val_8 = ???;
            val_10 = ???;
            goto typeof(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector).__il2cppRuntimeField_170;
        }
        private void StartDetectionInternal(UnityEngine.Events.UnityAction callback)
        {
            UnityEngine.Object val_3;
            object val_4;
            if(true == 0)
            {
                goto label_1;
            }
            
            val_3 = "[ACTk] Obscured Cheating Detector: already running!";
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
            
            UnityEngine.Debug.LogWarning(message:  0, context:  "[ACTk] Obscured Cheating Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?");
            goto label_10;
            label_5:
            val_3 = "[ACTk] Obscured Cheating Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!";
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
            mem[1152921510034186161] = 257;
            mem[1152921510034186152] = callback;
            return;
            label_13:
            UnityEngine.Debug.LogWarning(message:  0, context:  "[ACTk] Obscured Cheating Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.");
            this.enabled = false;
        }
        protected override void StartDetectionAutomatically()
        {
            this.StartDetectionInternal(callback:  0);
        }
        protected override void PauseDetector()
        {
            mem[1152921510034414257] = 0;
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
            
            mem[1152921510034526257] = 1;
        }
        protected override void StopDetectionInternal()
        {
            if(W8 == 0)
            {
                    return;
            }
            
            mem[1152921510034638248] = 0;
            mem[1152921510034638257] = 0;
        }
        protected override void DisposeInternal()
        {
            var val_2 = this;
            this.DisposeInternal();
            if(0 != (CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField))
            {
                    return;
            }
            
            CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector.<Instance>k__BackingField = 0;
        }
    
    }

}
