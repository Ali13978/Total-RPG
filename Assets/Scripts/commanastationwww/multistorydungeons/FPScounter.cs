using UnityEngine;

namespace commanastationwww.multistorydungeons
{
    public class FPScounter : MonoBehaviour
    {
        // Fields
        public float updateInterval;
        private float accum;
        private int frames;
        private float timeleft;
        private UnityEngine.UI.Text textFpsCounter;
        
        // Methods
        public FPScounter()
        {
            this.updateInterval = 0.5f;
        }
        private void Start()
        {
            this.textFpsCounter = this.GetComponent<UnityEngine.UI.Text>();
        }
        private void Update()
        {
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.timeleft - val_1;
            this.timeleft = val_1;
            float val_3 = UnityEngine.Time.deltaTime;
            int val_5 = this.frames;
            val_3 = UnityEngine.Time.timeScale / val_3;
            val_3 = this.accum + val_3;
            val_5 = val_5 + 1;
            this.accum = val_3;
            this.frames = val_5;
            if(this.timeleft > 0f)
            {
                    return;
            }
            
            val_3 = val_3 / (float)val_5;
            string val_4 = System.String.Format(format:  0, arg0:  "{0:F2} FPS");
            this.accum = 0f;
            this.frames = 0;
            this.timeleft = this.updateInterval;
        }
    
    }

}
