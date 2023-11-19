using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    public abstract class CinemachineExtension : MonoBehaviour
    {
        // Fields
        protected const float Epsilon = 0.0001;
        private Cinemachine.CinemachineVirtualCameraBase m_vcamOwner;
        private System.Collections.Generic.Dictionary<Cinemachine.ICinemachineCamera, object> mExtraState;
        
        // Properties
        public Cinemachine.CinemachineVirtualCameraBase VirtualCamera { get; }
        
        // Methods
        protected CinemachineExtension()
        {
        
        }
        public Cinemachine.CinemachineVirtualCameraBase get_VirtualCamera()
        {
            Cinemachine.CinemachineVirtualCameraBase val_4;
            if(0 == this.m_vcamOwner)
            {
                    this.m_vcamOwner = this.GetComponent<Cinemachine.CinemachineVirtualCameraBase>();
                return val_4;
            }
            
            val_4 = this.m_vcamOwner;
            return val_4;
        }
        protected virtual void Awake()
        {
            this.ConnectToVcam();
        }
        protected virtual void OnDestroy()
        {
            if(0 == this.VirtualCamera)
            {
                    return;
            }
            
            Cinemachine.CinemachineVirtualCameraBase val_3 = this.VirtualCamera;
            CinemachineVirtualCameraBase.OnPostPipelineStageDelegate val_4 = new CinemachineVirtualCameraBase.OnPostPipelineStageDelegate(object:  this, method:  typeof(Cinemachine.CinemachineExtension).__il2cppRuntimeField_178);
            this = ???;
            goto typeof(Cinemachine.CinemachineVirtualCameraBase).__il2cppRuntimeField_250;
        }
        private void ConnectToVcam()
        {
            if(0 == this.VirtualCamera)
            {
                    UnityEngine.Debug.LogError(message:  0);
            }
            else
            {
                    Cinemachine.CinemachineVirtualCameraBase val_3 = this.VirtualCamera;
                CinemachineVirtualCameraBase.OnPostPipelineStageDelegate val_4 = new CinemachineVirtualCameraBase.OnPostPipelineStageDelegate(object:  this, method:  typeof(Cinemachine.CinemachineExtension).__il2cppRuntimeField_178);
            }
            
            this.mExtraState = 0;
        }
        protected abstract void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, ref Cinemachine.CameraState state, float deltaTime); // 0
        protected T GetExtraState<T>(Cinemachine.ICinemachineCamera vcam)
        {
            var val_5;
            System.Collections.Generic.Dictionary<Cinemachine.ICinemachineCamera, System.Object> val_6;
            object val_7;
            var val_8;
            val_5 = __RuntimeMethodHiddenParam;
            val_6 = this.mExtraState;
            if(val_6 != null)
            {
                
            }
            else
            {
                    System.Collections.Generic.Dictionary<Cinemachine.ICinemachineCamera, System.Object> val_1 = null;
                val_6 = val_1;
                val_1 = new System.Collections.Generic.Dictionary<Cinemachine.ICinemachineCamera, System.Object>();
                this.mExtraState = val_6;
                object val_2 = 0;
                if(null == 0)
            {
                    val_6 = 0;
            }
            
            }
            
            if((val_6.TryGetValue(key:  vcam, value: out  val_2)) != false)
            {
                    val_7 = val_2;
                val_5 = val_5 + 48;
            }
            else
            {
                    val_7 = 0;
                this.mExtraState.set_Item(key:  vcam, value:  val_7);
            }
            
            if(val_7 != 0)
            {
                    val_8 = val_7;
                if(val_8 != 0)
            {
                    return (object)val_8;
            }
            
            }
            
            val_8 = 0;
            return (object)val_8;
        }
        protected System.Collections.Generic.List<T> GetAllExtraStates<T>()
        {
            var val_2;
            var val_7;
            var val_8;
            var val_9;
            val_7 = this;
            if(this.mExtraState == null)
            {
                    return (System.Collections.Generic.List<T>)__RuntimeMethodHiddenParam + 48;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_1 = this.mExtraState.GetEnumerator();
            label_6:
            if((0 & 1) == 0)
            {
                goto label_14;
            }
            
            UnityEngine.Playables.PlayableHandle val_4 = val_2.GetHandle();
            if(val_4.m_Handle != 0)
            {
                    val_8 = ;
                if(val_4.m_Handle != 0)
            {
                goto label_6;
            }
            
            }
            
            val_8 = 0;
            goto label_6;
            label_14:
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_9;
            if( == 96)
            {
                    return (System.Collections.Generic.List<T>)__RuntimeMethodHiddenParam + 48;
            }
            
            if((__RuntimeMethodHiddenParam + 48) == 0)
            {
                    return (System.Collections.Generic.List<T>)__RuntimeMethodHiddenParam + 48;
            }
            
            return (System.Collections.Generic.List<T>)__RuntimeMethodHiddenParam + 48;
        }
    
    }

}
