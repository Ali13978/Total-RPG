using UnityEngine;

namespace TzarGames.Endless
{
    public class CutsceneWindowActivator : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private Cinemachine.CinemachineBrain brain;
        [UnityEngine.SerializeField]
        private Cinemachine.CinemachineVirtualCameraBase mainVirtualCamera;
        
        // Properties
        public Cinemachine.CinemachineBrain Brain { get; }
        
        // Methods
        public CutsceneWindowActivator()
        {
        
        }
        public Cinemachine.CinemachineBrain get_Brain()
        {
            return (Cinemachine.CinemachineBrain)this.brain;
        }
        private void onVirtualCameraActivated(Cinemachine.ICinemachineCamera camera)
        {
            var val_4;
            var val_5;
            val_4 = 0;
            if(camera != null)
            {
                    val_4 = 0;
            }
            
            if(0 != )
            {
                    val_5 = 1;
            }
            else
            {
                    val_5 = 0;
            }
            
            UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>().ShowCutsceneWindow(show:  false);
        }
        private void Awake()
        {
            this.brain.m_CameraActivatedEvent.AddListener(call:  new UnityEngine.Events.UnityAction<Cinemachine.ICinemachineCamera>(object:  this, method:  System.Void TzarGames.Endless.CutsceneWindowActivator::onVirtualCameraActivated(Cinemachine.ICinemachineCamera camera)));
        }
        private void OnDestroy()
        {
            if(0 == this.brain)
            {
                    return;
            }
            
            this.brain.m_CameraActivatedEvent.RemoveListener(call:  new UnityEngine.Events.UnityAction<Cinemachine.ICinemachineCamera>(object:  this, method:  System.Void TzarGames.Endless.CutsceneWindowActivator::onVirtualCameraActivated(Cinemachine.ICinemachineCamera camera)));
        }
    
    }

}
