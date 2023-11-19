using UnityEngine;

namespace UnityEngine.UI.Extensions.ColorPicker
{
    public class ColorPickerControl : MonoBehaviour
    {
        // Fields
        private float _hue;
        private float _saturation;
        private float _brightness;
        private float _red;
        private float _green;
        private float _blue;
        private float _alpha;
        public ColorChangedEvent onValueChanged;
        public HSVChangedEvent onHSVChanged;
        
        // Properties
        public UnityEngine.Color CurrentColor { get; set; }
        public float H { get; set; }
        public float S { get; set; }
        public float V { get; set; }
        public float R { get; set; }
        public float G { get; set; }
        public float B { get; set; }
        private float A { get; set; }
        
        // Methods
        public ColorPickerControl()
        {
            this._alpha = 1f;
            this.onValueChanged = new ColorChangedEvent();
            this.onHSVChanged = new HSVChangedEvent();
        }
        public UnityEngine.Color get_CurrentColor()
        {
            return new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        public void set_CurrentColor(UnityEngine.Color value)
        {
            UnityEngine.Color val_1 = this.CurrentColor;
            if((UnityEngine.Color.op_Equality(lhs:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a}, rhs:  new UnityEngine.Color() {r = value.r, g = value.g, b = value.b, a = value.a})) != false)
            {
                    return;
            }
            
            this._red = value.r;
            this._green = value.g;
            this._blue = value.b;
            this._alpha = value.a;
            this.RGBChanged();
            this.SendChangedEvent();
        }
        private void Start()
        {
            this.SendChangedEvent();
        }
        public float get_H()
        {
            return (float)this._hue;
        }
        public void set_H(float value)
        {
            if(this._hue == value)
            {
                    return;
            }
            
            this._hue = value;
            this.HSVChanged();
            this.SendChangedEvent();
        }
        public float get_S()
        {
            return (float)this._saturation;
        }
        public void set_S(float value)
        {
            if(this._saturation == value)
            {
                    return;
            }
            
            this._saturation = value;
            this.HSVChanged();
            this.SendChangedEvent();
        }
        public float get_V()
        {
            return (float)this._brightness;
        }
        public void set_V(float value)
        {
            if(this._brightness == value)
            {
                    return;
            }
            
            this._brightness = value;
            this.HSVChanged();
            this.SendChangedEvent();
        }
        public float get_R()
        {
            return (float)this._red;
        }
        public void set_R(float value)
        {
            if(this._red == value)
            {
                    return;
            }
            
            this._red = value;
            this.RGBChanged();
            this.SendChangedEvent();
        }
        public float get_G()
        {
            return (float)this._green;
        }
        public void set_G(float value)
        {
            if(this._green == value)
            {
                    return;
            }
            
            this._green = value;
            this.RGBChanged();
            this.SendChangedEvent();
        }
        public float get_B()
        {
            return (float)this._blue;
        }
        public void set_B(float value)
        {
            if(this._blue == value)
            {
                    return;
            }
            
            this._blue = value;
            this.RGBChanged();
            this.SendChangedEvent();
        }
        private float get_A()
        {
            return (float)this._alpha;
        }
        private void set_A(float value)
        {
            if(this._alpha == value)
            {
                    return;
            }
            
            this._alpha = value;
            this.SendChangedEvent();
        }
        private void RGBChanged()
        {
            UnityEngine.Color val_1 = this.CurrentColor;
            val_1.r = val_1.r * 255f;
            val_1.g = val_1.g * 255f;
            val_1.b = val_1.b * 255f;
            UnityEngine.UI.Extensions.ColorPicker.HsvColor val_2 = UnityEngine.UI.Extensions.ColorPicker.HSVUtil.ConvertRgbToHsv(r:  (double)(int)val_1.r, b:  (double)(int)val_1.g, g:  (double)(int)val_1.b);
            float val_3 = (float)(double)(int)val_1.r;
            val_3 = val_3 / 360f;
            this._hue = val_3;
            this._saturation = (float)(double)(int)val_1.g;
            this._brightness = (float)(double)(int)val_1.b;
        }
        private void HSVChanged()
        {
            float val_2 = this._hue;
            val_2 = val_2 * 360f;
            UnityEngine.Color val_1 = UnityEngine.UI.Extensions.ColorPicker.HSVUtil.ConvertHsvToRgb(h:  (double)val_2, s:  (double)this._saturation, v:  (double)this._brightness, alpha:  this._alpha);
            this._red = val_1.r;
            this._green = val_1.g;
            this._blue = val_1.b;
        }
        private void SendChangedEvent()
        {
            UnityEngine.Color val_1 = this.CurrentColor;
            this.onValueChanged.Invoke(arg0:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
            this.onHSVChanged.Invoke(arg0:  this._hue, arg1:  this._saturation, arg2:  this._brightness);
        }
        public void AssignColor(UnityEngine.UI.Extensions.ColorPicker.ColorValues type, float value)
        {
            var val_2 = (type < 7) ? (type + 3) : 0;
            val_2 = val_2 - 3;
            if(val_2 > 6)
            {
                    return;
            }
            
            var val_3 = 25811008 + ((type < 0x7 ? (type + 3) : 0 - 3)) << 2;
            val_3 = val_3 + 25811008;
            goto (25811008 + ((type < 0x7 ? (type + 3) : 0 - 3)) << 2 + 25811008);
        }
        public float GetValue(UnityEngine.UI.Extensions.ColorPicker.ColorValues type)
        {
            var val_5;
            var val_2 = (type < 7) ? (type + 3) : 0;
            val_2 = val_2 - 3;
            if(val_2 <= 6)
            {
                    var val_4 = 25811036 + ((type < 0x7 ? (type + 3) : 0 - 3)) << 2;
                val_4 = val_4 + 25811036;
            }
            else
            {
                    val_5 = null;
                val_5 = null;
                System.NotImplementedException val_3 = new System.NotImplementedException(message:  System.String.Empty);
            }
        
        }
    
    }

}
