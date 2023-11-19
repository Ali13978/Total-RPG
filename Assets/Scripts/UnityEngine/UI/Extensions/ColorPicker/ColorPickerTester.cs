using UnityEngine;

namespace UnityEngine.UI.Extensions.ColorPicker
{
    public class ColorPickerTester : MonoBehaviour
    {
        // Fields
        public UnityEngine.Renderer pickerRenderer;
        public UnityEngine.UI.Extensions.ColorPicker.ColorPickerControl picker;
        
        // Methods
        public ColorPickerTester()
        {
        
        }
        private void Awake()
        {
            this.pickerRenderer = this.GetComponent<UnityEngine.Renderer>();
        }
        private void Start()
        {
            this.picker.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<UnityEngine.Color>(object:  this, method:  System.Void UnityEngine.UI.Extensions.ColorPicker.ColorPickerTester::<Start>m__0(UnityEngine.Color color)));
        }
        private void <Start>m__0(UnityEngine.Color color)
        {
            this.pickerRenderer.material.color = new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a};
        }
    
    }

}
