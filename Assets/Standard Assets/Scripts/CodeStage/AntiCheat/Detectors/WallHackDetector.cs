using UnityEngine;

namespace CodeStage.AntiCheat.Detectors
{
    [UnityEngine.AddComponentMenu]
    public class WallHackDetector : ActDetectorBase
    {
        // Fields
        internal const string COMPONENT_NAME = "WallHack Detector";
        internal const string FINAL_LOG_PREFIX = "[ACTk] WallHack Detector: ";
        private const string SERVICE_CONTAINER_NAME = "[WH Detector Service]";
        private const string WIREFRAME_SHADER_NAME = "Hidden/ACTk/WallHackTexture";
        private const int SHADER_TEXTURE_SIZE = 4;
        private const int RENDER_TEXTURE_SIZE = 4;
        private readonly UnityEngine.Vector3 rigidPlayerVelocity;
        private static int instancesInScene;
        private readonly UnityEngine.WaitForEndOfFrame waitForEndOfFrame;
        [UnityEngine.SerializeField]
        [UnityEngine.TooltipAttribute]
        private bool checkRigidbody;
        [UnityEngine.SerializeField]
        [UnityEngine.TooltipAttribute]
        private bool checkController;
        [UnityEngine.SerializeField]
        [UnityEngine.TooltipAttribute]
        private bool checkWireframe;
        [UnityEngine.SerializeField]
        [UnityEngine.TooltipAttribute]
        private bool checkRaycast;
        [UnityEngine.TooltipAttribute]
        [UnityEngine.RangeAttribute]
        public int wireframeDelay;
        [UnityEngine.TooltipAttribute]
        [UnityEngine.RangeAttribute]
        public int raycastDelay;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.Vector3 spawnPosition;
        [UnityEngine.TooltipAttribute]
        public byte maxFalsePositives;
        private UnityEngine.GameObject serviceContainer;
        private UnityEngine.GameObject solidWall;
        private UnityEngine.GameObject thinWall;
        private UnityEngine.Camera wfCamera;
        private UnityEngine.MeshRenderer foregroundRenderer;
        private UnityEngine.MeshRenderer backgroundRenderer;
        private UnityEngine.Color wfColor1;
        private UnityEngine.Color wfColor2;
        private UnityEngine.Shader wfShader;
        private UnityEngine.Material wfMaterial;
        private UnityEngine.Texture2D shaderTexture;
        private UnityEngine.Texture2D targetTexture;
        private UnityEngine.RenderTexture renderTexture;
        private int whLayer;
        private int raycastMask;
        private UnityEngine.Rigidbody rigidPlayer;
        private UnityEngine.CharacterController charControllerPlayer;
        private float charControllerVelocity;
        private byte rigidbodyDetections;
        private byte controllerDetections;
        private byte wireframeDetections;
        private byte raycastDetections;
        private bool wireframeDetected;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static CodeStage.AntiCheat.Detectors.WallHackDetector <Instance>k__BackingField;
        
        // Properties
        public bool CheckRigidbody { get; set; }
        public bool CheckController { get; set; }
        public bool CheckWireframe { get; set; }
        public bool CheckRaycast { get; set; }
        public static CodeStage.AntiCheat.Detectors.WallHackDetector Instance { get; set; }
        private static CodeStage.AntiCheat.Detectors.WallHackDetector GetOrCreateInstance { get; }
        
        // Methods
        private WallHackDetector()
        {
            this.rigidPlayerVelocity = 0;
            mem[1152921510042285896] = 0;
            mem[1152921510042285900] = 0;
            this.waitForEndOfFrame = new UnityEngine.WaitForEndOfFrame();
            this.checkRigidbody = true;
            this.checkController = true;
            this.checkWireframe = true;
            this.checkRaycast = true;
            this.wireframeDelay = 10;
            this.raycastDelay = 10;
            this.maxFalsePositives = 3;
            UnityEngine.Color val_2 = UnityEngine.Color.black;
            this.wfColor1 = val_2;
            mem[1152921510042285996] = val_2.g;
            mem[1152921510042286000] = val_2.b;
            mem[1152921510042286004] = val_2.a;
            UnityEngine.Color val_3 = UnityEngine.Color.black;
            this.wfColor2 = val_3;
            mem[1152921510042286012] = val_3.g;
            mem[1152921510042286016] = val_3.b;
            mem[1152921510042286020] = val_3.a;
            this.whLayer = 0;
            this.raycastMask = 0;
            mem[1152921510042285864] = 257;
            mem[1152921510042285866] = 1;
            this = new UnityEngine.MonoBehaviour();
        }
        public bool get_CheckRigidbody()
        {
            return (bool)this.checkRigidbody;
        }
        public void set_CheckRigidbody(bool value)
        {
            var val_1 = (this.checkRigidbody == true) ? 1 : 0;
            val_1 = val_1 ^ value;
            if(val_1 == false)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            if(this.enabled == false)
            {
                    return;
            }
            
            if(this.gameObject.activeSelf == false)
            {
                    return;
            }
            
            this.checkRigidbody = value;
            if(val_1 == false)
            {
                    return;
            }
            
            this.UpdateServiceContainer();
            if(this.checkRigidbody != false)
            {
                    this.StartRigidModule();
                return;
            }
            
            this.StopRigidModule();
        }
        public bool get_CheckController()
        {
            return (bool)this.checkController;
        }
        public void set_CheckController(bool value)
        {
            var val_1 = (this.checkController == true) ? 1 : 0;
            val_1 = val_1 ^ value;
            if(val_1 == false)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            if(this.enabled == false)
            {
                    return;
            }
            
            if(this.gameObject.activeSelf == false)
            {
                    return;
            }
            
            this.checkController = value;
            if(val_1 == false)
            {
                    return;
            }
            
            this.UpdateServiceContainer();
            if(this.checkController != false)
            {
                    this.StartControllerModule();
                return;
            }
            
            this.StopControllerModule();
        }
        public bool get_CheckWireframe()
        {
            return (bool)this.checkWireframe;
        }
        public void set_CheckWireframe(bool value)
        {
            var val_1 = (this.checkWireframe == true) ? 1 : 0;
            val_1 = val_1 ^ value;
            if(val_1 == false)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            if(this.enabled == false)
            {
                    return;
            }
            
            if(this.gameObject.activeSelf == false)
            {
                    return;
            }
            
            this.checkWireframe = value;
            if(val_1 == false)
            {
                    return;
            }
            
            this.UpdateServiceContainer();
            if(this.checkWireframe != false)
            {
                    this.StartWireframeModule();
                return;
            }
            
            this.StopWireframeModule();
        }
        public bool get_CheckRaycast()
        {
            return (bool)this.checkRaycast;
        }
        public void set_CheckRaycast(bool value)
        {
            var val_1 = (this.checkRaycast == true) ? 1 : 0;
            val_1 = val_1 ^ value;
            if(val_1 == false)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            if(this.enabled == false)
            {
                    return;
            }
            
            if(this.gameObject.activeSelf == false)
            {
                    return;
            }
            
            this.checkRaycast = value;
            if(val_1 == false)
            {
                    return;
            }
            
            this.UpdateServiceContainer();
            if(this.checkRaycast != false)
            {
                    this.StartRaycastModule();
                return;
            }
            
            this.StopRaycastModule();
        }
        public static void StartDetection()
        {
            UnityEngine.Vector3 val_2;
            float val_3;
            float val_4;
            if(0 == (CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField))
            {
                goto label_4;
            }
            
            if((CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField) == null)
            {
                goto label_6;
            }
            
            val_2 = mem[CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField + 84];
            val_2 = CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField.spawnPosition;
            val_3 = mem[CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField + 84 + 4];
            val_3 = CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField + 84 + 4;
            val_4 = mem[CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField + 92];
            val_4 = CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField + 92;
            goto label_10;
            label_4:
            UnityEngine.Debug.LogError(message:  0);
            return;
            label_6:
            val_2 = mem[CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField + 84];
            val_2 = CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField.spawnPosition;
            val_3 = mem[CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField + 84 + 4];
            val_3 = CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField + 84 + 4;
            val_4 = mem[CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField + 92];
            val_4 = CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField + 92;
            label_10:
            CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField.StartDetectionInternal(callback:  0, servicePosition:  new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4}, falsePositivesInRow:  CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField.maxFalsePositives);
        }
        public static void StartDetection(UnityEngine.Events.UnityAction callback)
        {
            CodeStage.AntiCheat.Detectors.WallHackDetector.StartDetection(callback:  CodeStage.AntiCheat.Detectors.WallHackDetector.GetOrCreateInstance, spawnPosition:  new UnityEngine.Vector3() {x = val_1.spawnPosition});
        }
        public static void StartDetection(UnityEngine.Events.UnityAction callback, UnityEngine.Vector3 spawnPosition)
        {
            CodeStage.AntiCheat.Detectors.WallHackDetector.StartDetection(callback:  CodeStage.AntiCheat.Detectors.WallHackDetector.GetOrCreateInstance, spawnPosition:  new UnityEngine.Vector3() {x = spawnPosition.x, y = spawnPosition.y, z = spawnPosition.z}, maxFalsePositives:  X1);
        }
        public static void StartDetection(UnityEngine.Events.UnityAction callback, UnityEngine.Vector3 spawnPosition, byte maxFalsePositives)
        {
            CodeStage.AntiCheat.Detectors.WallHackDetector.GetOrCreateInstance.StartDetectionInternal(callback:  maxFalsePositives, servicePosition:  new UnityEngine.Vector3() {x = spawnPosition.x, y = spawnPosition.y, z = spawnPosition.z}, falsePositivesInRow:  W2);
        }
        public static void StopDetection()
        {
            var val_8;
            CodeStage.AntiCheat.Detectors.WallHackDetector val_9;
            val_8 = 1152921504836186112;
            val_9 = CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField;
            if(0 == val_9)
            {
                    return;
            }
            
            val_9 = ???;
            val_8 = ???;
            goto typeof(CodeStage.AntiCheat.Detectors.WallHackDetector).__il2cppRuntimeField_1B0;
        }
        public static void Dispose()
        {
            var val_8;
            CodeStage.AntiCheat.Detectors.WallHackDetector val_9;
            val_8 = 1152921504836186112;
            val_9 = CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField;
            if(0 == val_9)
            {
                    return;
            }
            
            val_9 = ???;
            val_8 = ???;
            goto typeof(CodeStage.AntiCheat.Detectors.WallHackDetector).__il2cppRuntimeField_170;
        }
        public static CodeStage.AntiCheat.Detectors.WallHackDetector get_Instance()
        {
            return (CodeStage.AntiCheat.Detectors.WallHackDetector)CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField;
        }
        private static void set_Instance(CodeStage.AntiCheat.Detectors.WallHackDetector value)
        {
            CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField = X1;
        }
        private static CodeStage.AntiCheat.Detectors.WallHackDetector get_GetOrCreateInstance()
        {
            CodeStage.AntiCheat.Detectors.WallHackDetector val_5 = CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField;
            if(0 != val_5)
            {
                    return (CodeStage.AntiCheat.Detectors.WallHackDetector)CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField;
            }
            
            if(0 == CodeStage.AntiCheat.Detectors.ActDetectorBase.detectorsContainer)
            {
                    CodeStage.AntiCheat.Detectors.ActDetectorBase.detectorsContainer = new UnityEngine.GameObject(name:  "Anti-Cheat Toolkit Detectors");
            }
            
            val_5 = AddComponent<CodeStage.AntiCheat.Detectors.WallHackDetector>();
            CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField = val_5;
            return (CodeStage.AntiCheat.Detectors.WallHackDetector)CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField;
        }
        private void Awake()
        {
            int val_3 = CodeStage.AntiCheat.Detectors.WallHackDetector.instancesInScene;
            val_3 = val_3 + 1;
            CodeStage.AntiCheat.Detectors.WallHackDetector.instancesInScene = val_3;
            if((this.Init(instance:  CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField, detectorName:  "WallHack Detector")) != false)
            {
                    CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField = this;
            }
            
            UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_2 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void CodeStage.AntiCheat.Detectors.WallHackDetector::OnLevelWasLoadedNew(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode));
            UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  0);
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            this.StopAllCoroutines();
            if(0 != this.serviceContainer)
            {
                    UnityEngine.Object.Destroy(obj:  0);
            }
            
            if(0 != this.wfMaterial)
            {
                    this.wfMaterial.mainTexture = 0;
                this.wfMaterial.shader = 0;
                this.shaderTexture = 0;
                this.targetTexture = 0;
                this.wfShader = 0;
                this.wfMaterial = 0;
                this.renderTexture.DiscardContents();
                this.renderTexture.Release();
                this.renderTexture = 0;
            }
            
            int val_3 = CodeStage.AntiCheat.Detectors.WallHackDetector.instancesInScene;
            val_3 = val_3 - 1;
            CodeStage.AntiCheat.Detectors.WallHackDetector.instancesInScene = val_3;
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
            if(CodeStage.AntiCheat.Detectors.WallHackDetector.instancesInScene <= 1)
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
            
                if(0 == (CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField))
            {
                    return;
            }
            
            }
            
            val_8 = ???;
            val_10 = ???;
            goto typeof(CodeStage.AntiCheat.Detectors.WallHackDetector).__il2cppRuntimeField_170;
        }
        private void FixedUpdate()
        {
            if(true == 0)
            {
                    return;
            }
            
            if(this.checkRigidbody == false)
            {
                    return;
            }
            
            if(0 == this.rigidPlayer)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_4 = this.rigidPlayer.transform.localPosition;
            if(val_4.z <= 1f)
            {
                    return;
            }
            
            byte val_7 = this.rigidbodyDetections;
            val_7 = val_7 + 1;
            this.rigidbodyDetections = val_7;
            if(this.Detect() != false)
            {
                    return;
            }
            
            this.StopRigidModule();
            this.StartRigidModule();
        }
        private void Update()
        {
            if(true == 0)
            {
                    return;
            }
            
            if(this.checkController == false)
            {
                    return;
            }
            
            if(0 == this.charControllerPlayer)
            {
                    return;
            }
            
            if(this.charControllerVelocity <= 0f)
            {
                    return;
            }
            
            float val_3 = UnityEngine.Random.Range(min:  -0.002f, max:  0.002f);
            UnityEngine.CollisionFlags val_4 = this.charControllerPlayer.Move(motion:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_6 = this.charControllerPlayer.transform.localPosition;
            if(val_6.z <= 1f)
            {
                    return;
            }
            
            byte val_9 = this.controllerDetections;
            val_9 = val_9 + 1;
            this.controllerDetections = val_9;
            if(this.Detect() == true)
            {
                    return;
            }
            
            this.StopControllerModule();
            this.StartControllerModule();
        }
        private void StartDetectionInternal(UnityEngine.Events.UnityAction callback, UnityEngine.Vector3 servicePosition, byte falsePositivesInRow)
        {
            UnityEngine.Object val_5;
            object val_6;
            if(true == 0)
            {
                goto label_1;
            }
            
            val_5 = "[ACTk] WallHack Detector: already running!";
            val_6 = 0;
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
            
            UnityEngine.Debug.LogWarning(message:  0, context:  "[ACTk] WallHack Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?");
            goto label_10;
            label_5:
            val_5 = "[ACTk] WallHack Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!";
            val_6 = 0;
            label_4:
            UnityEngine.Debug.LogWarning(message:  val_6, context:  val_5);
            return;
            label_6:
            if(val_2 == false)
            {
                goto label_13;
            }
            
            label_10:
            mem[1152921510045219368] = callback;
            this.spawnPosition = servicePosition;
            mem[1152921510045219416] = servicePosition.y;
            mem[1152921510045219420] = servicePosition.z;
            this.maxFalsePositives = falsePositivesInRow;
            this.rigidbodyDetections = 0;
            this.controllerDetections = 0;
            this.wireframeDetections = 0;
            this.raycastDetections = 0;
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.InitDetector());
            mem[1152921510045219377] = 257;
            return;
            label_13:
            UnityEngine.Debug.LogWarning(message:  0, context:  "[ACTk] WallHack Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.");
            this.enabled = false;
        }
        protected override void StartDetectionAutomatically()
        {
            this.StartDetectionInternal(callback:  0, servicePosition:  new UnityEngine.Vector3() {x = this.spawnPosition}, falsePositivesInRow:  this.maxFalsePositives);
        }
        protected override void PauseDetector()
        {
            if(W8 == 0)
            {
                    return;
            }
            
            mem[1152921510045455665] = 0;
            this.StopRigidModule();
            this.StopControllerModule();
            this.StopWireframeModule();
            this.StopRaycastModule();
        }
        protected override void ResumeDetector()
        {
            bool val_3;
            bool val_4;
            if(X8 == 0)
            {
                    if(W8 == 0)
            {
                    return;
            }
            
            }
            
            mem[1152921510045567665] = 1;
            if((this.checkRigidbody & 255) != false)
            {
                    this.StartRigidModule();
                val_3 = this.checkController;
            }
            else
            {
                    val_3 = this.checkRigidbody >> 8;
            }
            
            if(val_3 != false)
            {
                    this.StartControllerModule();
            }
            
            if((this.checkWireframe & 255) != false)
            {
                    this.StartWireframeModule();
                val_4 = this.checkRaycast;
            }
            else
            {
                    val_4 = this.checkWireframe >> 8;
            }
            
            if(val_4 == false)
            {
                    return;
            }
            
            this.StartRaycastModule();
        }
        protected override void StopDetectionInternal()
        {
            if(W8 == 0)
            {
                    return;
            }
            
            mem[1152921510045679656] = 0;
            mem[1152921510045679665] = 0;
        }
        protected override void DisposeInternal()
        {
            var val_2 = this;
            this.DisposeInternal();
            if(0 != (CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField))
            {
                    return;
            }
            
            CodeStage.AntiCheat.Detectors.WallHackDetector.<Instance>k__BackingField = 0;
        }
        private void UpdateServiceContainer()
        {
            UnityEngine.GameObject val_89;
            int val_90;
            float val_91;
            UnityEngine.Vector3 val_92;
            float val_93;
            float val_94;
            float val_95;
            float val_96;
            UnityEngine.Shader val_100;
            float val_104;
            UnityEngine.Object val_106;
            val_89 = this;
            if((this.enabled == false) || (this.gameObject.activeSelf == false))
            {
                goto label_3;
            }
            
            int val_88 = this.whLayer;
            if(val_88 == 1)
            {
                goto label_4;
            }
            
            val_88 = val_88 >> 32;
            val_90 = this.raycastMask;
            goto label_5;
            label_3:
            val_90 = 1152921504721543168;
            if(0 == this.serviceContainer)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  0);
            return;
            label_4:
            this.whLayer = UnityEngine.LayerMask.NameToLayer(layerName:  0);
            val_90 = val_89;
            label_5:
            if(this.raycastMask == 1)
            {
                    typeof(System.String[]).__il2cppRuntimeField_20 = "Ignore Raycast";
                this.raycastMask = UnityEngine.LayerMask.GetMask(layerNames:  0);
            }
            
            if(0 == this.serviceContainer)
            {
                    val_90 = this.whLayer;
                this.serviceContainer = new UnityEngine.GameObject(name:  "[WH Detector Service]");
                layer = val_90;
                val_92 = this.spawnPosition;
                val_94 = val_92;
                val_95 = V9.16B;
                val_96 = V10.16B;
                this.serviceContainer.transform.position = new UnityEngine.Vector3() {x = val_94, y = val_95, z = val_96};
                UnityEngine.Object.DontDestroyOnLoad(target:  0);
            }
            
            if((this.checkRigidbody & 255) != true)
            {
                    if(this.checkRigidbody < true)
            {
                goto label_25;
            }
            
            }
            
            if(0 == this.solidWall)
            {
                    this.solidWall = new UnityEngine.GameObject(name:  "SolidWall");
                UnityEngine.BoxCollider val_13 = AddComponent<UnityEngine.BoxCollider>();
                this.solidWall.layer = this.whLayer;
                val_90 = this.serviceContainer.transform;
                this.solidWall.transform.parent = val_90;
                this.solidWall.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                UnityEngine.Vector3 val_18 = UnityEngine.Vector3.zero;
                val_92 = val_18.x;
                val_91 = val_18.y;
                val_93 = val_18.z;
                val_94 = val_92;
                val_95 = val_91;
                val_96 = val_93;
                this.solidWall.transform.localPosition = new UnityEngine.Vector3() {x = val_94, y = val_95, z = val_96};
            }
            else
            {
                    if(((this.checkRigidbody & 255) != true) && (this.checkRigidbody <= true))
            {
                    label_25:
                if(0 != this.solidWall)
            {
                    UnityEngine.Object.Destroy(obj:  0);
            }
            
            }
            
            }
            
            if(this.checkWireframe == false)
            {
                goto label_48;
            }
            
            if(0 != this.wfCamera)
            {
                goto label_51;
            }
            
            if(0 != this.wfShader)
            {
                goto label_54;
            }
            
            val_100 = UnityEngine.Shader.Find(name:  0);
            this.wfShader = val_100;
            goto label_55;
            label_51:
            if(this.checkWireframe == true)
            {
                goto label_113;
            }
            
            label_48:
            if(0 == this.wfCamera)
            {
                goto label_113;
            }
            
            UnityEngine.GameObject val_26 = this.foregroundRenderer.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
            UnityEngine.GameObject val_27 = this.backgroundRenderer.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
            this.wfCamera.targetTexture = 0;
            UnityEngine.GameObject val_28 = this.wfCamera.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
            goto label_113;
            label_54:
            val_100 = this.wfShader;
            label_55:
            if(0 != val_100)
            {
                goto label_69;
            }
            
            UnityEngine.Debug.LogError(message:  0, context:  "[ACTk] WallHack Detector: can\'t find \'Hidden/ACTk/WallHackTexture\' shader!\nPlease make sure you have it included at the Editor > Project Settings > Graphics.");
            this.checkWireframe = false;
            goto label_113;
            label_69:
            if(this.wfShader.isSupported == false)
            {
                goto label_74;
            }
            
            UnityEngine.Color val_32 = UnityEngine.Color.black;
            val_104 = V11.16B;
            if((UnityEngine.Color.op_Equality(lhs:  new UnityEngine.Color() {r = this.wfColor1, g = V9.16B, b = V10.16B, a = val_104}, rhs:  new UnityEngine.Color() {r = val_32.r, g = val_32.g, b = val_32.b, a = val_32.a})) != false)
            {
                    UnityEngine.Color32 val_34 = CodeStage.AntiCheat.Detectors.WallHackDetector.GenerateColor();
                byte val_35 = val_34.r & 4294967295;
                UnityEngine.Color val_36 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
                this.wfColor1 = val_36;
                mem[1152921510046356892] = val_36.g;
                mem[1152921510046356896] = val_36.b;
                mem[1152921510046356900] = val_36.a;
                do
            {
                UnityEngine.Color32 val_37 = CodeStage.AntiCheat.Detectors.WallHackDetector.GenerateColor();
                byte val_38 = val_37.r & 4294967295;
                UnityEngine.Color val_39 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
                this.wfColor2 = val_39;
                mem[1152921510046356908] = val_39.g;
                mem[1152921510046356912] = val_39.b;
                mem[1152921510046356916] = val_39.a;
                UnityEngine.Color32 val_40 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = this.wfColor1, g = val_32.r, b = val_32.g, a = val_32.b});
                UnityEngine.Color32 val_41 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = this.wfColor2, g = val_32.r, b = val_32.g, a = val_32.b});
            }
            while((CodeStage.AntiCheat.Detectors.WallHackDetector.ColorsSimilar(c1:  new UnityEngine.Color32() {r = val_41.r, g = val_41.g, b = val_41.b, a = val_41.a}, c2:  new UnityEngine.Color32() {r = val_40.r & 4294967295, g = val_40.r & 4294967295, b = val_40.r & 4294967295, a = val_40.r & 4294967295}, tolerance:  val_41.r & 4294967295)) == true);
            
            }
            
            if(0 == this.shaderTexture)
            {
                    this.shaderTexture = new UnityEngine.Texture2D(width:  4, height:  4, format:  3, mipmap:  false);
                filterMode = 0;
                var val_89 = 0;
                do
            {
                if(val_89 > 7)
            {
                
            }
            
                UnityEngine.Color[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_0 = this.wfColor1;
                val_89 = val_89 + 1;
            }
            while(val_89 != 16);
            
                this.shaderTexture.SetPixels(colors:  null, miplevel:  0);
                this.shaderTexture.Apply();
            }
            
            if(0 == this.renderTexture)
            {
                    this.renderTexture = new UnityEngine.RenderTexture(width:  4, height:  4, depth:  24, format:  0, readWrite:  0);
                autoGenerateMips = false;
                this.renderTexture.filterMode = 0;
                bool val_50 = this.renderTexture.Create();
            }
            
            if(0 == this.targetTexture)
            {
                    this.targetTexture = new UnityEngine.Texture2D(width:  4, height:  4, format:  3, mipmap:  false);
                filterMode = 0;
            }
            
            if(0 == this.wfMaterial)
            {
                    this.wfMaterial = new UnityEngine.Material(shader:  this.wfShader);
                mainTexture = this.shaderTexture;
            }
            
            if(0 != this.foregroundRenderer)
            {
                goto label_104;
            }
            
            UnityEngine.GameObject val_56 = UnityEngine.GameObject.CreatePrimitive(type:  0);
            UnityEngine.BoxCollider val_57 = val_56.GetComponent<UnityEngine.BoxCollider>();
            UnityEngine.Object.Destroy(obj:  0);
            val_56.name = "WireframeFore";
            if(val_56 == null)
            {
                goto label_109;
            }
            
            val_56.layer = this.whLayer;
            goto label_110;
            label_74:
            UnityEngine.Debug.LogWarning(message:  0, context:  "[ACTk] WallHack Detector: can\'t detect wireframe cheats on this platform due to lack of needed shader support!");
            this.checkWireframe = false;
            goto label_113;
            label_109:
            0.layer = this.whLayer;
            label_110:
            val_56.transform.parent = this.serviceContainer.transform;
            val_56.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.MeshRenderer val_61 = val_56.GetComponent<UnityEngine.MeshRenderer>();
            this.foregroundRenderer = val_61;
            val_61.sharedMaterial = this.wfMaterial;
            this.foregroundRenderer.shadowCastingMode = 0;
            this.foregroundRenderer.receiveShadows = false;
            this.foregroundRenderer.enabled = false;
            label_104:
            if(0 == this.backgroundRenderer)
            {
                    UnityEngine.GameObject val_63 = UnityEngine.GameObject.CreatePrimitive(type:  0);
                UnityEngine.MeshCollider val_64 = val_63.GetComponent<UnityEngine.MeshCollider>();
                UnityEngine.Object.Destroy(obj:  0);
                val_63.name = "WireframeBack";
                if(val_63 != null)
            {
                    val_63.layer = this.whLayer;
            }
            else
            {
                    0.layer = this.whLayer;
            }
            
                val_63.transform.parent = this.serviceContainer.transform;
                val_63.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                val_63.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                UnityEngine.MeshRenderer val_69 = val_63.GetComponent<UnityEngine.MeshRenderer>();
                this.backgroundRenderer = val_69;
                val_69.sharedMaterial = this.wfMaterial;
                this.backgroundRenderer.shadowCastingMode = 0;
                this.backgroundRenderer.receiveShadows = false;
                this.backgroundRenderer.enabled = false;
            }
            
            UnityEngine.GameObject val_70 = new UnityEngine.GameObject(name:  "WireframeCamera");
            UnityEngine.Camera val_71 = AddComponent<UnityEngine.Camera>();
            this.wfCamera = val_71;
            val_71.gameObject.layer = this.whLayer;
            this.wfCamera.transform.parent = this.serviceContainer.transform;
            this.wfCamera.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.wfCamera.clearFlags = 2;
            UnityEngine.Color val_76 = UnityEngine.Color.black;
            val_92 = val_76.r;
            val_93 = val_76.b;
            this.wfCamera.backgroundColor = new UnityEngine.Color() {r = val_92, g = val_76.g, b = val_93, a = val_76.a};
            this.wfCamera.orthographic = true;
            this.wfCamera.orthographicSize = 0.5f;
            this.wfCamera.nearClipPlane = 0.01f;
            this.wfCamera.farClipPlane = 2.1f;
            this.wfCamera.depth = 0f;
            this.wfCamera.renderingPath = 1;
            this.wfCamera.useOcclusionCulling = false;
            this.wfCamera.allowHDR = false;
            this.wfCamera.allowMSAA = false;
            val_90 = this.renderTexture;
            this.wfCamera.targetTexture = val_90;
            this.wfCamera.enabled = false;
            label_113:
            if(this.checkRaycast == false)
            {
                goto label_164;
            }
            
            if(0 != this.thinWall)
            {
                goto label_167;
            }
            
            UnityEngine.GameObject val_78 = UnityEngine.GameObject.CreatePrimitive(type:  0);
            this.thinWall = val_78;
            val_78.name = "ThinWall";
            this.thinWall.layer = this.whLayer;
            val_90 = this.serviceContainer.transform;
            this.thinWall.transform.parent = val_90;
            this.thinWall.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Quaternion val_83 = UnityEngine.Quaternion.Euler(x:  270f, y:  0f, z:  0f);
            val_92 = val_83.x;
            val_93 = val_83.z;
            this.thinWall.transform.localRotation = new UnityEngine.Quaternion() {x = val_92, y = val_83.y, z = val_93, w = val_83.w};
            this.thinWall.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Renderer val_85 = this.thinWall.GetComponent<UnityEngine.Renderer>();
            UnityEngine.Object.Destroy(obj:  0);
            val_89 = this.thinWall;
            UnityEngine.MeshFilter val_86 = val_89.GetComponent<UnityEngine.MeshFilter>();
            val_106 = 0;
            goto label_185;
            label_167:
            if(this.checkRaycast == true)
            {
                    return;
            }
            
            label_164:
            if(0 == this.thinWall)
            {
                    return;
            }
            
            val_89 = this.thinWall;
            val_106 = 0;
            label_185:
            UnityEngine.Object.Destroy(obj:  val_106);
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator InitDetector()
        {
            typeof(WallHackDetector.<InitDetector>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void StartRigidModule()
        {
            if(this.checkRigidbody != false)
            {
                    if((UnityEngine.Object.op_Implicit(exists:  0)) != true)
            {
                    this.InitRigidModule();
            }
            
                UnityEngine.Vector3 val_4 = this.rigidPlayer.transform.localPosition;
                if((val_4.z <= 1f) && (this.rigidbodyDetections != 0))
            {
                    this.rigidbodyDetections = 0;
            }
            
                UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.identity;
                this.rigidPlayer.rotation = new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w};
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
                this.rigidPlayer.angularVelocity = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
                this.rigidPlayer.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                this.rigidPlayer.velocity = new UnityEngine.Vector3() {x = this.rigidPlayerVelocity, y = val_6.y, z = val_6.z};
                this.Invoke(methodName:  "StartRigidModule", time:  4f);
                return;
            }
            
            this.StopRigidModule();
            this.UninitRigidModule();
            this.UpdateServiceContainer();
        }
        private void StartControllerModule()
        {
            if(this.checkController != false)
            {
                    if((UnityEngine.Object.op_Implicit(exists:  0)) != true)
            {
                    this.InitControllerModule();
            }
            
                UnityEngine.Vector3 val_4 = this.charControllerPlayer.transform.localPosition;
                if((val_4.z <= 1f) && (this.controllerDetections != 0))
            {
                    this.controllerDetections = 0;
            }
            
                this.charControllerPlayer.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                this.charControllerVelocity = 0.01f;
                this.Invoke(methodName:  "StartControllerModule", time:  4f);
                return;
            }
            
            this.StopControllerModule();
            this.UninitControllerModule();
            this.UpdateServiceContainer();
        }
        private void StartWireframeModule()
        {
            if(this.checkWireframe == false)
            {
                goto label_1;
            }
            
            if(this.wireframeDetected == false)
            {
                goto label_2;
            }
            
            return;
            label_1:
            this.StopWireframeModule();
            this.UpdateServiceContainer();
            return;
            label_2:
            this.Invoke(methodName:  "ShootWireframeModule", time:  (float)this.wireframeDelay);
        }
        private void ShootWireframeModule()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.CaptureFrame());
            this.Invoke(methodName:  "ShootWireframeModule", time:  (float)this.wireframeDelay);
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator CaptureFrame()
        {
            typeof(WallHackDetector.<CaptureFrame>c__Iterator1).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void StartRaycastModule()
        {
            if(this.checkRaycast != false)
            {
                    this.Invoke(methodName:  "ShootRaycastModule", time:  (float)this.raycastDelay);
                return;
            }
            
            this.StopRaycastModule();
            this.UpdateServiceContainer();
        }
        private void ShootRaycastModule()
        {
            UnityEngine.Vector3 val_2 = this.serviceContainer.transform.position;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_5 = this.serviceContainer.transform.TransformDirection(direction:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            byte val_9 = this.raycastDetections;
            if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, direction:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, maxDistance:  1.5f, layerMask:  0)) == false)
            {
                goto label_7;
            }
            
            if(val_9 == 0)
            {
                goto label_10;
            }
            
            this.raycastDetections = 0;
            goto label_10;
            label_7:
            val_9 = val_9 + 1;
            this.raycastDetections = val_9;
            if(this.Detect() != false)
            {
                    return;
            }
            
            label_10:
            this.Invoke(methodName:  "ShootRaycastModule", time:  (float)this.raycastDelay);
        }
        private void StopRigidModule()
        {
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
                this.rigidPlayer.velocity = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            }
            
            this.CancelInvoke(methodName:  "StartRigidModule");
        }
        private void StopControllerModule()
        {
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    this.charControllerVelocity = 0f;
            }
            
            this.CancelInvoke(methodName:  "StartControllerModule");
        }
        private void StopWireframeModule()
        {
            this.CancelInvoke(methodName:  "ShootWireframeModule");
        }
        private void StopRaycastModule()
        {
            this.CancelInvoke(methodName:  "ShootRaycastModule");
        }
        private void InitRigidModule()
        {
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  "RigidPlayer");
            AddComponent<UnityEngine.CapsuleCollider>().height = 2f;
            if(null != 0)
            {
                    layer = this.whLayer;
            }
            else
            {
                    layer = this.whLayer;
            }
            
            transform.parent = this.serviceContainer.transform;
            transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Rigidbody val_6 = AddComponent<UnityEngine.Rigidbody>();
            this.rigidPlayer = val_6;
            val_6.useGravity = false;
        }
        private void InitControllerModule()
        {
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  "ControlledPlayer");
            AddComponent<UnityEngine.CapsuleCollider>().height = 2f;
            if(null != 0)
            {
                    layer = this.whLayer;
            }
            else
            {
                    layer = this.whLayer;
            }
            
            transform.parent = this.serviceContainer.transform;
            transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.charControllerPlayer = AddComponent<UnityEngine.CharacterController>();
        }
        private void UninitRigidModule()
        {
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = this.rigidPlayer.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
            this.rigidPlayer = 0;
        }
        private void UninitControllerModule()
        {
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = this.charControllerPlayer.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
            this.charControllerPlayer = 0;
        }
        private bool Detect()
        {
            var val_2;
            if(this.controllerDetections <= this.maxFalsePositives)
            {
                    byte val_2 = this.rigidbodyDetections;
                if(((val_2 & 255) <= this.maxFalsePositives) && (((uint)(val_2 >> 16) & 255) <= this.maxFalsePositives))
            {
                    val_2 = 0;
                val_2 = val_2 >> 24;
                if(val_2 <= this.maxFalsePositives)
            {
                    return (bool)val_2;
            }
            
            }
            
            }
            
            this.OnCheatingDetected();
            val_2 = 1;
            return (bool)val_2;
        }
        private static UnityEngine.Color32 GenerateColor()
        {
            int val_1 = UnityEngine.Random.Range(min:  0, max:  0);
            int val_2 = UnityEngine.Random.Range(min:  0, max:  0);
            int val_3 = UnityEngine.Random.Range(min:  0, max:  0);
            return new UnityEngine.Color32();
        }
        private static bool ColorsSimilar(UnityEngine.Color32 c1, UnityEngine.Color32 c2, int tolerance)
        {
            byte val_1 = c2.r & 255;
            val_1 = val_1 - tolerance;
            if(((val_1 < 0) ? (-val_1) : (val_1)) >= W3)
            {
                    return false;
            }
            
            int val_3 = tolerance >> 8;
            val_3 = ((uint)(c2.r >> 8) & 255) - val_3;
            if(((val_3 < 0) ? (-val_3) : (val_3)) >= W3)
            {
                    return false;
            }
            
            int val_5 = tolerance >> 16;
            val_5 = ((uint)(c2.r >> 16) & 255) - val_5;
            return (bool)(((val_5 < 0) ? (-val_5) : (val_5)) < W3) ? 1 : 0;
        }
    
    }

}
