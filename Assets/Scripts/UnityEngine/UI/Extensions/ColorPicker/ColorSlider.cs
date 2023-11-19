using UnityEngine;

namespace UnityEngine.UI.Extensions.ColorPicker
{
    [UnityEngine.RequireComponent]
    public class ColorSlider : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Extensions.ColorPicker.ColorPickerControl ColorPicker;
        public UnityEngine.UI.Extensions.ColorPicker.ColorValues type;
        private UnityEngine.UI.Slider slider;
        private bool listen;
        
        // Methods
        public ColorSlider()
        {
            this.listen = true;
        }
        private void Awake()
        {
            this.slider = this.GetComponent<UnityEngine.UI.Slider>();
            this.ColorPicker.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<UnityEngine.Color>(object:  this, method:  System.Void UnityEngine.UI.Extensions.ColorPicker.ColorSlider::ColorChanged(UnityEngine.Color newColor)));
            this.ColorPicker.onHSVChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Single, System.Single, System.Single>(object:  this, method:  System.Void UnityEngine.UI.Extensions.ColorPicker.ColorSlider::HSVChanged(float hue, float saturation, float value)));
            this.slider.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Single>(object:  this, method:  System.Void UnityEngine.UI.Extensions.ColorPicker.ColorSlider::SliderChanged(float newValue)));
        }
        private void OnDestroy()
        {
            this.ColorPicker.onValueChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<UnityEngine.Color>(object:  this, method:  System.Void UnityEngine.UI.Extensions.ColorPicker.ColorSlider::ColorChanged(UnityEngine.Color newColor)));
            this.ColorPicker.onHSVChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.Single, System.Single, System.Single>(object:  this, method:  System.Void UnityEngine.UI.Extensions.ColorPicker.ColorSlider::HSVChanged(float hue, float saturation, float value)));
            this.slider.onValueChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.Single>(object:  this, method:  System.Void UnityEngine.UI.Extensions.ColorPicker.ColorSlider::SliderChanged(float newValue)));
        }
        private void ColorChanged(UnityEngine.Color newColor)
        {
            UnityEngine.UI.Extensions.ColorPicker.ColorValues val_10 = this.type;
            this.listen = false;
            val_10 = (val_10 < 4) ? (val_10 + 3) : 0;
            val_10 = val_10 - 3;
            if(val_10 > 3)
            {
                    return;
            }
            
            var val_11 = 25811064 + ((this.type < 0x4 ? (this.type + 3) : 0 - 3)) << 2;
            val_11 = val_11 + 25811064;
            goto (25811064 + ((this.type < 0x4 ? (this.type + 3) : 0 - 3)) << 2 + 25811064);
        }
        private void HSVChanged(float hue, float saturation, float value)
        {
            UnityEngine.UI.Slider val_3;
            UnityEngine.UI.Extensions.ColorPicker.ColorValues val_3 = this.type;
            this.listen = false;
            val_3 = val_3 - 1;
            var val_2 = ((val_3 - 4) < 3) ? (val_3) : 0;
            if(val_2 == 5)
            {
                goto label_0;
            }
            
            if(val_2 == 4)
            {
                goto label_1;
            }
            
            if(val_2 != 3)
            {
                    return;
            }
            
            val_3 = this.slider;
            if(val_3 != null)
            {
                goto label_6;
            }
            
            goto label_6;
            label_0:
            val_3 = this.slider;
            if(val_3 != null)
            {
                goto label_6;
            }
            
            goto label_6;
            label_1:
            val_3 = this.slider;
            label_6:
            val_3.normalizedValue = saturation;
        }
        private void SliderChanged(float newValue)
        {
            if(this.listen != false)
            {
                    this.ColorPicker.AssignColor(type:  this.type, value:  this.slider.normalizedValue);
            }
            
            this.listen = true;
        }
    
    }

}
