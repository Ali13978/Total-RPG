using UnityEngine;

namespace TzarGames.Common
{
    public class LookAtCamera : MonoBehaviour
    {
        // Fields
        private UnityEngine.Camera lastCamera;
        private UnityEngine.Transform lastCameraTransform;
        private UnityEngine.Transform cachedTransform;
        
        // Methods
        public LookAtCamera()
        {
        
        }
        private void Awake()
        {
            this.cachedTransform = this.transform;
        }
        private void Update()
        {
            UnityEngine.Transform val_11;
            if(0 != this.lastCamera)
            {
                goto label_3;
            }
            
            UnityEngine.Camera val_2 = UnityEngine.Camera.main;
            this.lastCamera = val_2;
            if(0 == val_2)
            {
                    return;
            }
            
            goto label_13;
            label_3:
            UnityEngine.Camera val_5 = UnityEngine.Camera.main;
            if(0 == this.lastCamera)
            {
                goto label_10;
            }
            
            UnityEngine.Camera val_8 = UnityEngine.Camera.main;
            this.lastCamera = val_8;
            if(0 == val_8)
            {
                    this.lastCameraTransform = 0;
                return;
            }
            
            label_13:
            val_11 = this.lastCamera.transform;
            this.lastCameraTransform = val_11;
            goto label_15;
            label_10:
            val_11 = this.lastCameraTransform;
            label_15:
            this.cachedTransform.LookAt(target:  val_11);
        }
    
    }

}
