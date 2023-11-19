using UnityEngine;

namespace TzarGames.Endless
{
    public class MapBounds : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Renderer boundsRenderer;
        private UnityEngine.Bounds bounds;
        
        // Methods
        public MapBounds()
        {
        
        }
        private void Reset()
        {
            this.boundsRenderer = this.GetComponent<UnityEngine.Renderer>();
        }
        private void Awake()
        {
            var val_3;
            UnityEngine.Bounds val_4;
            if(0 == this.boundsRenderer)
            {
                    return;
            }
            
            UnityEngine.Bounds val_2 = this.boundsRenderer.bounds;
            mem[1152921510725877808] = val_3;
            this.bounds = val_4;
        }
        public void CreateBoundsFromMinMax(UnityEngine.Vector3 min, UnityEngine.Vector3 max)
        {
            mem[1152921510726002064] = 0;
            this.bounds = 0;
        }
        public UnityEngine.Bounds GetBounds()
        {
            UnityEngine.Bounds val_0;
            val_0.m_Extents.y = ;
            val_0.m_Center.x = this.bounds;
            return val_0;
        }
    
    }

}
