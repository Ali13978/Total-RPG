using UnityEngine;

namespace UnityEngine.UI.Extensions.ColorPicker
{
    public struct HsvColor
    {
        // Fields
        public double H;
        public double S;
        public double V;
        
        // Properties
        public float NormalizedH { get; set; }
        public float NormalizedS { get; set; }
        public float NormalizedV { get; set; }
        
        // Methods
        public HsvColor(double h, double s, double v)
        {
            this.V = h;
            mem[1152921512681962200] = s;
            mem[1152921512681962208] = v;
        }
        public float get_NormalizedH()
        {
            float val_1 = (float)this.V;
            val_1 = val_1 / 360f;
            return (float)val_1;
        }
        public void set_NormalizedH(float value)
        {
            double val_1 = (double)value;
            val_1 = val_1 * 360;
            this.V = val_1;
        }
        public float get_NormalizedS()
        {
            return (float)(float)D0;
        }
        public void set_NormalizedS(float value)
        {
            mem[1152921512682410200] = (double)value;
        }
        public float get_NormalizedV()
        {
            return (float)(float)D0;
        }
        public void set_NormalizedV(float value)
        {
            mem[1152921512682634208] = (double)value;
        }
        public override string ToString()
        {
        
        }
    
    }

}
