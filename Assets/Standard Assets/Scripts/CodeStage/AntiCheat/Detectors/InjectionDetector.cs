using UnityEngine;

namespace CodeStage.AntiCheat.Detectors
{
    [UnityEngine.AddComponentMenu]
    public class InjectionDetector : ActDetectorBase
    {
        // Fields
        internal const string COMPONENT_NAME = "Injection Detector";
        internal const string FINAL_LOG_PREFIX = "[ACTk] Injection Detector: ";
        protected UnityEngine.Events.UnityAction<string> detectionActionWithArgument;
        private static int instancesInScene;
        private bool signaturesAreNotGenuine;
        private CodeStage.AntiCheat.Detectors.InjectionDetector.AllowedAssembly[] allowedAssemblies;
        private string[] hexTable;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static CodeStage.AntiCheat.Detectors.InjectionDetector <Instance>k__BackingField;
        
        // Properties
        public static CodeStage.AntiCheat.Detectors.InjectionDetector Instance { get; set; }
        private static CodeStage.AntiCheat.Detectors.InjectionDetector GetOrCreateInstance { get; }
        
        // Methods
        private InjectionDetector()
        {
            mem[1152921510028441640] = 257;
            mem[1152921510028441642] = 1;
            val_1 = new UnityEngine.MonoBehaviour();
        }
        public static void StartDetection()
        {
            if(0 != (CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField))
            {
                    CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField.StartDetectionInternal(callback:  0, callbackWithArgument:  0);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  0);
        }
        public static void StartDetection(UnityEngine.Events.UnityAction callback)
        {
            CodeStage.AntiCheat.Detectors.InjectionDetector.GetOrCreateInstance.StartDetectionInternal(callback:  X1, callbackWithArgument:  0);
        }
        public static void StartDetection(UnityEngine.Events.UnityAction<string> callback)
        {
            CodeStage.AntiCheat.Detectors.InjectionDetector.GetOrCreateInstance.StartDetectionInternal(callback:  0, callbackWithArgument:  X1);
        }
        public static void StopDetection()
        {
            var val_8;
            CodeStage.AntiCheat.Detectors.InjectionDetector val_9;
            val_8 = 1152921504835919872;
            val_9 = CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField;
            if(0 == val_9)
            {
                    return;
            }
            
            val_9 = ???;
            val_8 = ???;
            goto typeof(CodeStage.AntiCheat.Detectors.InjectionDetector).__il2cppRuntimeField_1B0;
        }
        public static void Dispose()
        {
            var val_8;
            CodeStage.AntiCheat.Detectors.InjectionDetector val_9;
            val_8 = 1152921504835919872;
            val_9 = CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField;
            if(0 == val_9)
            {
                    return;
            }
            
            val_9 = ???;
            val_8 = ???;
            goto typeof(CodeStage.AntiCheat.Detectors.InjectionDetector).__il2cppRuntimeField_170;
        }
        public static CodeStage.AntiCheat.Detectors.InjectionDetector get_Instance()
        {
            return (CodeStage.AntiCheat.Detectors.InjectionDetector)CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField;
        }
        private static void set_Instance(CodeStage.AntiCheat.Detectors.InjectionDetector value)
        {
            CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField = X1;
        }
        private static CodeStage.AntiCheat.Detectors.InjectionDetector get_GetOrCreateInstance()
        {
            CodeStage.AntiCheat.Detectors.InjectionDetector val_5 = CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField;
            if(0 != val_5)
            {
                    return (CodeStage.AntiCheat.Detectors.InjectionDetector)CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField;
            }
            
            if(0 == CodeStage.AntiCheat.Detectors.ActDetectorBase.detectorsContainer)
            {
                    CodeStage.AntiCheat.Detectors.ActDetectorBase.detectorsContainer = new UnityEngine.GameObject(name:  "Anti-Cheat Toolkit Detectors");
            }
            
            val_5 = AddComponent<CodeStage.AntiCheat.Detectors.InjectionDetector>();
            CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField = val_5;
            return (CodeStage.AntiCheat.Detectors.InjectionDetector)CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField;
        }
        private void Awake()
        {
            int val_3 = CodeStage.AntiCheat.Detectors.InjectionDetector.instancesInScene;
            val_3 = val_3 + 1;
            CodeStage.AntiCheat.Detectors.InjectionDetector.instancesInScene = val_3;
            if((this.Init(instance:  CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField, detectorName:  "Injection Detector")) != false)
            {
                    CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField = this;
            }
            
            UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_2 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void CodeStage.AntiCheat.Detectors.InjectionDetector::OnLevelWasLoadedNew(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode));
            UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  0);
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            int val_1 = CodeStage.AntiCheat.Detectors.InjectionDetector.instancesInScene;
            val_1 = val_1 - 1;
            CodeStage.AntiCheat.Detectors.InjectionDetector.instancesInScene = val_1;
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
            if(CodeStage.AntiCheat.Detectors.InjectionDetector.instancesInScene <= 1)
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
            
                if(0 == (CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField))
            {
                    return;
            }
            
            }
            
            val_8 = ???;
            val_10 = ???;
            goto typeof(CodeStage.AntiCheat.Detectors.InjectionDetector).__il2cppRuntimeField_170;
        }
        private void StartDetectionInternal(UnityEngine.Events.UnityAction callback, UnityEngine.Events.UnityAction<string> callbackWithArgument)
        {
            UnityEngine.Object val_8;
            string val_9;
            string val_3 = 0;
            if(true == 0)
            {
                goto label_1;
            }
            
            val_8 = "[ACTk] Injection Detector: already running!";
            goto label_4;
            label_1:
            bool val_2 = this.enabled;
            if(val_2 == false)
            {
                goto label_5;
            }
            
            if((callback != null) || (callbackWithArgument != null))
            {
                goto label_7;
            }
            
            if(val_2 == true)
            {
                goto label_14;
            }
            
            UnityEngine.Debug.LogWarning(message:  0, context:  "[ACTk] Injection Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.");
            this.enabled = false;
            return;
            label_5:
            val_8 = "[ACTk] Injection Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!";
            label_4:
            UnityEngine.Debug.LogWarning(message:  0, context:  val_8);
            return;
            label_7:
            if(val_2 != false)
            {
                    UnityEngine.Debug.LogWarning(message:  0, context:  "[ACTk] Injection Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?");
            }
            
            label_14:
            mem[1152921510030009112] = callback;
            this.detectionActionWithArgument = callbackWithArgument;
            mem[1152921510030009121] = 257;
            if(this.allowedAssemblies == null)
            {
                    this.LoadAndParseAllowedAssemblies();
            }
            
            if(this.signaturesAreNotGenuine == false)
            {
                goto label_18;
            }
            
            val_9 = "signatures";
            goto label_19;
            label_18:
            if((this.FindInjectionInCurrentAssemblies(cause: out  val_3)) == false)
            {
                goto label_20;
            }
            
            val_9 = val_3;
            label_19:
            this.OnCheatingDetected(cause:  val_9);
            return;
            label_20:
            System.AppDomain.CurrentDomain.add_AssemblyLoad(value:  new System.AssemblyLoadEventHandler(object:  this, method:  System.Void CodeStage.AntiCheat.Detectors.InjectionDetector::OnNewAssemblyLoaded(object sender, System.AssemblyLoadEventArgs args)));
        }
        protected override void StartDetectionAutomatically()
        {
            this.StartDetectionInternal(callback:  0, callbackWithArgument:  0);
        }
        protected override void PauseDetector()
        {
            mem[1152921510030286369] = 0;
            System.AppDomain.CurrentDomain.remove_AssemblyLoad(value:  new System.AssemblyLoadEventHandler(object:  this, method:  System.Void CodeStage.AntiCheat.Detectors.InjectionDetector::OnNewAssemblyLoaded(object sender, System.AssemblyLoadEventArgs args)));
        }
        protected override void ResumeDetector()
        {
            if((true == 0) && (this.detectionActionWithArgument == null))
            {
                    if(this.detectionActionWithArgument == null)
            {
                    return;
            }
            
            }
            
            mem[1152921510030410657] = 1;
            System.AppDomain.CurrentDomain.add_AssemblyLoad(value:  new System.AssemblyLoadEventHandler(object:  this, method:  System.Void CodeStage.AntiCheat.Detectors.InjectionDetector::OnNewAssemblyLoaded(object sender, System.AssemblyLoadEventArgs args)));
        }
        protected override void StopDetectionInternal()
        {
            if(true == 0)
            {
                    return;
            }
            
            System.AppDomain.CurrentDomain.remove_AssemblyLoad(value:  new System.AssemblyLoadEventHandler(object:  this, method:  System.Void CodeStage.AntiCheat.Detectors.InjectionDetector::OnNewAssemblyLoaded(object sender, System.AssemblyLoadEventArgs args)));
            mem[1152921510030534936] = 0;
            this.detectionActionWithArgument = 0;
            mem[1152921510030534945] = 0;
        }
        protected override void DisposeInternal()
        {
            var val_2 = this;
            this.DisposeInternal();
            if(0 != (CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField))
            {
                    return;
            }
            
            CodeStage.AntiCheat.Detectors.InjectionDetector.<Instance>k__BackingField = 0;
        }
        private void OnCheatingDetected(string cause)
        {
            if(this.detectionActionWithArgument != null)
            {
                    this.detectionActionWithArgument.Invoke(arg0:  cause);
            }
            
            this.OnCheatingDetected();
        }
        private void OnNewAssemblyLoaded(object sender, System.AssemblyLoadEventArgs args)
        {
            if((this.AssemblyAllowed(ass:  args.LoadedAssembly)) != false)
            {
                    return;
            }
            
            this.OnCheatingDetected(cause:  args.LoadedAssembly);
        }
        private bool FindInjectionInCurrentAssemblies(out string cause)
        {
            var val_4;
            cause = 0;
            if(val_2.Length == 0)
            {
                goto label_3;
            }
            
            val_4 = 0;
            if(val_2.Length <= 0)
            {
                    return (bool)val_4;
            }
            
            label_7:
            System.Reflection.Assembly val_5 = System.AppDomain.CurrentDomain.GetAssemblies()[0];
            System.AppDomain.CurrentDomain.GetAssemblies()[0] = this.AssemblyAllowed(ass:  val_5);
            if(System.AppDomain.CurrentDomain.GetAssemblies()[0] == false)
            {
                goto label_6;
            }
            
            if((0 + 1) < val_2.Length)
            {
                goto label_7;
            }
            
            val_4 = 0;
            return (bool)val_4;
            label_3:
            val_4 = 1;
            cause = "no assemblies";
            return (bool)val_4;
            label_6:
            cause = val_5;
            val_4 = 1;
            return (bool)val_4;
        }
        private bool AssemblyAllowed(System.Reflection.Assembly ass)
        {
            var val_5;
            var val_6;
            string val_1 = ass.Name;
            int val_2 = this.GetAssemblyHash(ass:  ass);
            val_5 = 0;
            goto label_3;
            label_13:
            val_5 = 1;
            label_3:
            if(val_5 >= this.allowedAssemblies.Length)
            {
                goto label_5;
            }
            
            AllowedAssembly val_5 = this.allowedAssemblies[1];
            if(((System.String.op_Equality(a:  0, b:  this.allowedAssemblies[0x1][0].name)) == false) || ((System.Array.IndexOf<System.Int32>(array:  0, value:  this.allowedAssemblies[0x1][0].hashes)) == 1))
            {
                goto label_13;
            }
            
            val_6 = 1;
            return (bool)val_6;
            label_5:
            val_6 = 0;
            return (bool)val_6;
        }
        private void LoadAndParseAllowedAssemblies()
        {
            var val_15;
            UnityEngine.Object val_16;
            System.String[] val_17;
            System.Byte[] val_18;
            string val_19;
            AllowedAssembly[] val_20;
            var val_21;
            string val_22;
            System.String[] val_23;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            UnityEngine.Object val_2 = UnityEngine.Resources.Load(path:  0, systemTypeInstance:  "fndid");
            val_16 = 0;
            if(val_2 != null)
            {
                    val_16 = val_2;
                val_16 = 0;
            }
            
            if(0 == val_16)
            {
                    this.signaturesAreNotGenuine = true;
                return;
            }
            
            val_17 = null;
            typeof(System.String[]).__il2cppRuntimeField_20 = ":";
            val_18 = val_16.bytes;
            System.IO.MemoryStream val_7 = new System.IO.MemoryStream(buffer:  val_18);
            System.IO.BinaryReader val_8 = null;
            val_19 = val_8;
            val_8 = new System.IO.BinaryReader(input:  val_7);
            val_20 = null;
            val_21 = 0;
            this.allowedAssemblies = val_20;
            goto label_16;
            label_33:
            val_19 = val_19;
            mem2[-8070450532116140000] = val_20;
            val_21 = 1;
            label_16:
            if(val_21 >= val_19)
            {
                goto label_18;
            }
            
            val_22 = val_19;
            val_22 = null;
            val_20 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.EncryptDecrypt(value:  val_22, key:  val_22).Split(separator:  val_17, options:  1);
            if(val_10.Length < 2)
            {
                goto label_23;
            }
            
            int val_11 = val_10.Length - 1;
            var val_18 = 0;
            do
            {
                var val_17 = 1;
                val_17 = val_17 - 1;
                val_18 = val_18 + 1;
                typeof(System.Int32[]).__il2cppRuntimeField_20 = System.Int32.Parse(s:  0);
            }
            while((val_17 + 2) != val_10.Length);
            
            object val_14 = new System.Object();
            typeof(InjectionDetector.AllowedAssembly).__il2cppRuntimeField_10 = val_20[0];
            typeof(InjectionDetector.AllowedAssembly).__il2cppRuntimeField_18 = null;
            if((null == 0) || (null != 0))
            {
                goto label_33;
            }
            
            goto label_33;
            label_18:
            UnityEngine.Resources.UnloadAsset(assetToUnload:  0);
            val_23 = null;
            this.hexTable = val_23;
            goto label_35;
            label_40:
            val_23 = this.hexTable;
            label_35:
            val_17 = 0.ToString(format:  "x2");
            val_18 = 0;
            val_23[val_18] = val_17;
            val_15 = 1;
            if(val_15 <= 255)
            {
                goto label_40;
            }
            
            return;
            label_23:
            mem[1152921510031749856] = 1;
            val_15 = val_7;
        }
        private int GetAssemblyHash(System.Reflection.Assembly ass)
        {
            System.Byte[] val_8;
            string val_9;
            var val_10;
            val_8 = ass.GetPublicKeyToken();
            val_9 = ass.Name;
            if(val_1.Length >= 8)
            {
                    string val_3 = this.PublicKeyTokenToString(bytes:  val_8);
                val_9 = 0 + val_9;
            }
            
            int val_5 = val_9.Length;
            val_10 = 0;
            if(val_5 < 1)
            {
                    return 0;
            }
            
            do
            {
                char val_7 = val_10 + val_9.Chars[0];
                val_7 = val_7 + (val_7 << 10);
                val_8 = val_10 + 1;
            }
            while(val_5 != val_8);
            
            val_10 = 0;
            return 0;
        }
        private string PublicKeyTokenToString(byte[] bytes)
        {
            null = null;
            var val_3 = 0;
            do
            {
                string val_2 = this.hexTable[null];
                val_3 = val_3 + 1;
            }
            while(val_3 != 8);
            
            return (string)0 + System.String.Empty;
        }
    
    }

}
