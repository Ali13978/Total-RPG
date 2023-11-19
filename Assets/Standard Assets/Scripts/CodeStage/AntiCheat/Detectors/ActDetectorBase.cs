using UnityEngine;

namespace CodeStage.AntiCheat.Detectors
{
    [UnityEngine.AddComponentMenu]
    public abstract class ActDetectorBase : MonoBehaviour
    {
        // Fields
        protected const string CONTAINER_NAME = "Anti-Cheat Toolkit Detectors";
        protected const string MENU_PATH = "Code Stage/Anti-Cheat Toolkit/";
        protected const string GAME_OBJECT_MENU_PATH = "GameObject/Create Other/Code Stage/Anti-Cheat Toolkit/";
        protected static UnityEngine.GameObject detectorsContainer;
        [UnityEngine.TooltipAttribute]
        public bool autoStart;
        [UnityEngine.TooltipAttribute]
        public bool keepAlive;
        [UnityEngine.TooltipAttribute]
        public bool autoDispose;
        [UnityEngine.SerializeField]
        protected UnityEngine.Events.UnityEvent detectionEvent;
        protected UnityEngine.Events.UnityAction detectionAction;
        [UnityEngine.SerializeField]
        protected bool detectionEventHasListener;
        protected bool isRunning;
        protected bool started;
        
        // Methods
        protected ActDetectorBase()
        {
            this.autoStart = true;
            this.keepAlive = true;
            this.autoDispose = true;
        }
        private void Start()
        {
            UnityEngine.GameObject val_6 = CodeStage.AntiCheat.Detectors.ActDetectorBase.detectorsContainer;
            if(0 == val_6)
            {
                    val_6 = this.gameObject.name;
                if((System.String.op_Equality(a:  0, b:  val_6)) != false)
            {
                    val_6 = 0;
                CodeStage.AntiCheat.Detectors.ActDetectorBase.detectorsContainer = this.gameObject;
            }
            
            }
            
            if(this.autoStart == false)
            {
                    return;
            }
            
            if(this.started == false)
            {
                goto typeof(CodeStage.AntiCheat.Detectors.ActDetectorBase).__il2cppRuntimeField_1A0;
            }
        
        }
        private void OnEnable()
        {
            var val_5 = this;
            if(this.started == false)
            {
                    return;
            }
            
            if((this.detectionEventHasListener != true) && (this.detectionAction == null))
            {
                    if((val_5 & 1) == 0)
            {
                    return;
            }
            
            }
            
            val_5 = ???;
            goto typeof(CodeStage.AntiCheat.Detectors.ActDetectorBase).__il2cppRuntimeField_1D0;
        }
        private void OnDisable()
        {
            if(this.started == false)
            {
                    return;
            }
            
            goto typeof(CodeStage.AntiCheat.Detectors.ActDetectorBase).__il2cppRuntimeField_1C0;
        }
        private void OnApplicationQuit()
        {
            goto typeof(CodeStage.AntiCheat.Detectors.ActDetectorBase).__il2cppRuntimeField_170;
        }
        protected virtual void OnDestroy()
        {
            if(this.transform.childCount != 0)
            {
                goto label_2;
            }
            
            T[] val_3 = this.GetComponentsInChildren<UnityEngine.Component>();
            if(val_3.Length <= 2)
            {
                goto label_4;
            }
            
            label_2:
            if((System.String.op_Equality(a:  0, b:  this.name)) == false)
            {
                    return;
            }
            
            T[] val_6 = this.GetComponentsInChildren<CodeStage.AntiCheat.Detectors.ActDetectorBase>();
            if(val_6.Length > 1)
            {
                    return;
            }
            
            label_4:
            UnityEngine.GameObject val_7 = this.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
        }
        protected virtual bool Init(CodeStage.AntiCheat.Detectors.ActDetectorBase instance, string detectorName)
        {
            var val_7;
            var val_8;
            var val_9;
            val_8 = this;
            if(0 != instance)
            {
                    if((0 != instance) && (instance.keepAlive != false))
            {
                    val_7 = this.gameObject;
                UnityEngine.Debug.LogWarning(message:  0, context:  0 + "[ACTk] " + this.name);
                UnityEngine.Object.Destroy(obj:  0);
                val_9 = 0;
                return (bool)val_9;
            }
            
            }
            
            val_8 = this.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
            val_9 = 1;
            return (bool)val_9;
        }
        protected virtual void DisposeInternal()
        {
            UnityEngine.Object.Destroy(obj:  0);
        }
        protected virtual bool DetectorHasAdditionalCallbacks()
        {
            return false;
        }
        internal virtual void OnCheatingDetected()
        {
            var val_1;
            if(this.detectionAction != null)
            {
                    val_1 = 0;
                this.detectionAction.Invoke();
            }
            
            if(this.detectionEventHasListener != false)
            {
                    val_1 = 0;
                this.detectionEvent.Invoke();
            }
            
            if(this.autoDispose != false)
            {
                
            }
        
        }
        protected abstract void StartDetectionAutomatically(); // 0
        protected abstract void StopDetectionInternal(); // 0
        protected abstract void PauseDetector(); // 0
        protected abstract void ResumeDetector(); // 0
    
    }

}
