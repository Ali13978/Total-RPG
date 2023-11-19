using UnityEngine;

namespace commanastationwww.multistorydungeons
{
    public class DisableMeshAtRuntime : MonoBehaviour
    {
        // Methods
        public DisableMeshAtRuntime()
        {
        
        }
        private void Start()
        {
            this.GetComponent<UnityEngine.Renderer>().enabled = false;
        }
    
    }

}
