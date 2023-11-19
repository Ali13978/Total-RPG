using UnityEngine;

namespace TzarGames.Common
{
    public class FpsUI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI text;
        [UnityEngine.SerializeField]
        private double interval;
        [UnityEngine.SerializeField]
        private string textFormat;
        [UnityEngine.SerializeField]
        private int minHighFps;
        [UnityEngine.SerializeField]
        private int minAverageFps;
        private int frames;
        private double lastCountTime;
        private double currentFps;
        private bool enableCount;
        
        // Methods
        public FpsUI()
        {
            this.interval = 5.99231044954105E+307;
            this.minHighFps = 45;
            this.minAverageFps = 29;
            this.enableCount = true;
            this.textFormat = "FPS: {0:F1}";
        }
        private void Update()
        {
            double val_7;
            TzarGames.Common.UI.TextUI val_8;
            if(this.enableCount == false)
            {
                    return;
            }
            
            double val_7 = (double)UnityEngine.Time.time;
            val_7 = val_7 - this.lastCountTime;
            if(val_7 >= this.interval)
            {
                    val_7 = 1 / val_7;
                val_7 = val_7 * (double)this.frames;
                this.currentFps = val_7;
                this.text.text = System.String.Format(format:  0, arg0:  this.textFormat);
                this.frames = 0;
                int val_8 = this.minHighFps;
                this.lastCountTime = (double)UnityEngine.Time.time;
                val_7 = (double)val_8;
                if(this.currentFps > val_7)
            {
                    val_8 = this.text;
                UnityEngine.Color val_4 = UnityEngine.Color.green;
            }
            else
            {
                    val_8 = this.text;
                val_8 = val_8 >> 32;
                val_7 = (double)val_8;
                if(this.currentFps > val_7)
            {
                    UnityEngine.Color val_5 = UnityEngine.Color.yellow;
            }
            else
            {
                    UnityEngine.Color val_6 = UnityEngine.Color.red;
            }
            
            }
            
                val_8.Color = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a};
            }
            
            int val_9 = this.frames;
            val_9 = val_9 + 1;
            this.frames = val_9;
        }
        [TzarGames.Common.ConsoleCommand]
        private void fps()
        {
            this.enableCount = this.enableCount ^ 1;
            this.text.enabled = (this.enableCount == false) ? 1 : 0;
            if(this.enableCount == false)
            {
                    return;
            }
            
            this.lastCountTime = (double)UnityEngine.Time.time;
            this.frames = 0;
        }
    
    }

}
