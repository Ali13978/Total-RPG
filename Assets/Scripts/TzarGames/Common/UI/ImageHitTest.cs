using UnityEngine;

namespace TzarGames.Common.UI
{
    public class ImageHitTest : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Image image;
        [UnityEngine.SerializeField]
        private float treshold;
        
        // Methods
        public ImageHitTest()
        {
            this.treshold = 0.5f;
        }
        private void Reset()
        {
            this.image = this.GetComponent<UnityEngine.UI.Image>();
        }
        private void OnEnable()
        {
            if(0 == this.image)
            {
                    UnityEngine.Debug.LogWarning(message:  0);
                return;
            }
            
            this.image.alphaHitTestMinimumThreshold = this.treshold;
        }
    
    }

}
