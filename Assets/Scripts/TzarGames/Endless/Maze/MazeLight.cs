using UnityEngine;

namespace TzarGames.Endless.Maze
{
    public class MazeLight : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Light _light;
        [UnityEngine.SerializeField]
        private float intensity;
        public UnityEngine.Transform CachedTransform;
        private float intensityScale;
        
        // Properties
        public float IntensityScale { get; set; }
        
        // Methods
        public MazeLight()
        {
            this.intensity = 1f;
        }
        public float get_IntensityScale()
        {
            return (float)this.intensityScale;
        }
        public void set_IntensityScale(float value)
        {
            UnityEngine.Light val_5;
            var val_6;
            float val_1 = UnityEngine.Mathf.Clamp01(value:  value);
            this.intensityScale = val_1;
            val_1 = val_1 * this.intensity;
            this._light.intensity = val_1;
            bool val_3 = this._light.enabled;
            if(this._light.intensity < 0)
            {
                    if(val_3 == false)
            {
                    return;
            }
            
                this._light.intensity = 0f;
                val_5 = this._light;
                val_6 = 0;
            }
            else
            {
                    if(val_3 != false)
            {
                    return;
            }
            
                this._light.intensity = 0.0001f;
                val_5 = this._light;
                val_6 = 1;
            }
            
            val_5.enabled = true;
        }
        private void Reset()
        {
            this._light = this.GetComponent<UnityEngine.Light>();
            this.IntensityScale = 0f;
            this.CachedTransform = this.transform;
        }
    
    }

}
