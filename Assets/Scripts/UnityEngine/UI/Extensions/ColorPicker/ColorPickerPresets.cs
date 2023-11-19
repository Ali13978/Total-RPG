using UnityEngine;

namespace UnityEngine.UI.Extensions.ColorPicker
{
    public class ColorPickerPresets : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Extensions.ColorPicker.ColorPickerControl picker;
        public UnityEngine.GameObject[] presets;
        public UnityEngine.UI.Image createPresetImage;
        
        // Methods
        public ColorPickerPresets()
        {
        
        }
        private void Awake()
        {
            this.picker.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<UnityEngine.Color>(object:  this, method:  System.Void UnityEngine.UI.Extensions.ColorPicker.ColorPickerPresets::ColorChanged(UnityEngine.Color color)));
        }
        public void CreatePresetButton()
        {
            goto label_1;
            label_7:
            0 = 1;
            label_1:
            if(0 >= this.presets.Length)
            {
                    return;
            }
            
            this.presets[1] = this.presets[1].activeSelf;
            if(this.presets[1] == true)
            {
                goto label_7;
            }
            
            this.presets[1].SetActive(value:  true);
            UnityEngine.Color val_3 = this.picker.CurrentColor;
            this.presets[1].GetComponent<UnityEngine.UI.Image>().color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
        }
        public void PresetSelect(UnityEngine.UI.Image sender)
        {
            UnityEngine.Color val_1 = sender.color;
            this.picker.CurrentColor = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
        }
        private void ColorChanged(UnityEngine.Color color)
        {
            this.createPresetImage.color = new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a};
        }
    
    }

}
