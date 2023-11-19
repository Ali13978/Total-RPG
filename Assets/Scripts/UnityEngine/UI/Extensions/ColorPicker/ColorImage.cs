using UnityEngine;

namespace UnityEngine.UI.Extensions.ColorPicker
{
    [UnityEngine.RequireComponent]
    public class ColorImage : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Extensions.ColorPicker.ColorPickerControl picker;
        private UnityEngine.UI.Image image;
        
        // Methods
        public ColorImage()
        {
        
        }
        private void Awake()
        {
            this.image = this.GetComponent<UnityEngine.UI.Image>();
            this.picker.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<UnityEngine.Color>(object:  this, method:  System.Void UnityEngine.UI.Extensions.ColorPicker.ColorImage::ColorChanged(UnityEngine.Color newColor)));
        }
        private void OnDestroy()
        {
            this.picker.onValueChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<UnityEngine.Color>(object:  this, method:  System.Void UnityEngine.UI.Extensions.ColorPicker.ColorImage::ColorChanged(UnityEngine.Color newColor)));
        }
        private void ColorChanged(UnityEngine.Color newColor)
        {
            this.image.color = new UnityEngine.Color() {r = newColor.r, g = newColor.g, b = newColor.b, a = newColor.a};
        }
    
    }

}
