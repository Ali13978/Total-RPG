using UnityEngine;

namespace TzarGames.Common
{
    [UnityEngine.ExecuteInEditMode]
    public class SetCameraDepthTextureMode : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Camera targetCamera;
        [UnityEngine.SerializeField]
        private UnityEngine.DepthTextureMode depthTextureMode;
        
        // Methods
        public SetCameraDepthTextureMode()
        {
        
        }
        private void Update()
        {
            if(this.targetCamera.depthTextureMode == this.depthTextureMode)
            {
                    return;
            }
            
            this.targetCamera.depthTextureMode = this.depthTextureMode;
        }
        private void Reset()
        {
            this.targetCamera = this.GetComponent<UnityEngine.Camera>();
        }
    
    }

}
