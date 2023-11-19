using UnityEngine;

namespace UnityEngine.UI.Extensions.ColorPicker
{
    [UnityEngine.RequireComponent]
    public class ColorLabel : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Extensions.ColorPicker.ColorPickerControl picker;
        public UnityEngine.UI.Extensions.ColorPicker.ColorValues type;
        public string prefix;
        public float minValue;
        public float maxValue;
        public int precision;
        private UnityEngine.UI.Text label;
        
        // Methods
        public ColorLabel()
        {
            this.maxValue = 255f;
            this.prefix = "R: ";
        }
        private void Awake()
        {
            this.label = this.GetComponent<UnityEngine.UI.Text>();
        }
        private void OnEnable()
        {
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            if(0 == this.picker)
            {
                    return;
            }
            
            this.picker.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<UnityEngine.Color>(object:  this, method:  System.Void UnityEngine.UI.Extensions.ColorPicker.ColorLabel::ColorChanged(UnityEngine.Color color)));
            this.picker.onHSVChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Single, System.Single, System.Single>(object:  this, method:  System.Void UnityEngine.UI.Extensions.ColorPicker.ColorLabel::HSVChanged(float hue, float sateration, float value)));
        }
        private void OnDestroy()
        {
            if(0 == this.picker)
            {
                    return;
            }
            
            this.picker.onValueChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<UnityEngine.Color>(object:  this, method:  System.Void UnityEngine.UI.Extensions.ColorPicker.ColorLabel::ColorChanged(UnityEngine.Color color)));
            this.picker.onHSVChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.Single, System.Single, System.Single>(object:  this, method:  System.Void UnityEngine.UI.Extensions.ColorPicker.ColorLabel::HSVChanged(float hue, float sateration, float value)));
        }
        private void ColorChanged(UnityEngine.Color color)
        {
            this.UpdateValue();
        }
        private void HSVChanged(float hue, float sateration, float value)
        {
            this.UpdateValue();
        }
        private void UpdateValue()
        {
            UnityEngine.UI.Text val_5;
            string val_6;
            string val_7;
            if(0 == this.picker)
            {
                    val_5 = this.label;
                val_6 = 0;
                val_7 = this.prefix;
            }
            else
            {
                    float val_2 = this.picker.GetValue(type:  this.type);
                float val_5 = this.minValue;
                val_5 = this.label;
                val_5 = this.maxValue - val_5;
                val_2 = val_2 * val_5;
                val_2 = this.minValue + val_2;
                string val_3 = this.ConvertToDisplayString(value:  val_2);
                val_6 = 0;
                val_7 = this.prefix;
            }
            
            string val_4 = val_6 + val_7;
            if(val_5 == null)
            {
                
            }
        
        }
        private string ConvertToDisplayString(float value)
        {
            if(this.precision >= 1)
            {
                    this = this.precision;
                string val_2 = value.ToString(format:  0 + "f ");
                return -522958728;
            }
            
            int val_3 = UnityEngine.Mathf.FloorToInt(f:  value);
            return -522958728;
        }
    
    }

}
