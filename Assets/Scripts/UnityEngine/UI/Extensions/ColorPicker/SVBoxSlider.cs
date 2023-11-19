using UnityEngine;

namespace UnityEngine.UI.Extensions.ColorPicker
{
    [UnityEngine.RequireComponent]
    [UnityEngine.ExecuteInEditMode]
    public class SVBoxSlider : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Extensions.ColorPicker.ColorPickerControl picker;
        private UnityEngine.UI.Extensions.BoxSlider slider;
        private UnityEngine.UI.RawImage image;
        private float lastH;
        private bool listen;
        
        // Properties
        public UnityEngine.RectTransform RectTransform { get; }
        
        // Methods
        public SVBoxSlider()
        {
            this.lastH = -1f;
            this.listen = true;
        }
        public UnityEngine.RectTransform get_RectTransform()
        {
            var val_3;
            UnityEngine.Transform val_1 = this.transform;
            val_3 = 0;
            if(val_1 == null)
            {
                    return (UnityEngine.RectTransform)(null == null) ? (val_1) : 0;
            }
            
            return (UnityEngine.RectTransform)(null == null) ? (val_1) : 0;
        }
        private void Awake()
        {
            this.slider = this.GetComponent<UnityEngine.UI.Extensions.BoxSlider>();
            this.image = this.GetComponent<UnityEngine.UI.RawImage>();
            this.RegenerateSVTexture();
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
            
            this.slider.OnValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Single, System.Single>(object:  this, method:  System.Void UnityEngine.UI.Extensions.ColorPicker.SVBoxSlider::SliderChanged(float saturation, float value)));
            this.picker.onHSVChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Single, System.Single, System.Single>(object:  this, method:  System.Void UnityEngine.UI.Extensions.ColorPicker.SVBoxSlider::HSVChanged(float h, float s, float v)));
        }
        private void OnDisable()
        {
            if(0 == this.picker)
            {
                    return;
            }
            
            this.slider.OnValueChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.Single, System.Single>(object:  this, method:  System.Void UnityEngine.UI.Extensions.ColorPicker.SVBoxSlider::SliderChanged(float saturation, float value)));
            this.picker.onHSVChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.Single, System.Single, System.Single>(object:  this, method:  System.Void UnityEngine.UI.Extensions.ColorPicker.SVBoxSlider::HSVChanged(float h, float s, float v)));
        }
        private void OnDestroy()
        {
            if(0 == this.image.texture)
            {
                    return;
            }
            
            UnityEngine.Texture val_3 = this.image.texture;
            UnityEngine.Object.DestroyImmediate(obj:  0);
        }
        private void SliderChanged(float saturation, float value)
        {
            if(this.listen != false)
            {
                    this.picker.AssignColor(type:  5, value:  saturation);
                this.picker.AssignColor(type:  6, value:  value);
            }
            
            this.listen = true;
        }
        private void HSVChanged(float h, float s, float v)
        {
            if(this.lastH != h)
            {
                    this.lastH = h;
                this.RegenerateSVTexture();
            }
            
            if(this.slider.NormalizedValueX != s)
            {
                    this.listen = false;
                this.slider.NormalizedValueX = s;
            }
            
            if(this.slider.NormalizedValueY == v)
            {
                    return;
            }
            
            this.listen = false;
            this.slider.NormalizedValueY = v;
        }
        private void RegenerateSVTexture()
        {
            double val_8;
            if(0 != this.picker)
            {
                    float val_8 = this.picker._hue;
                val_8 = val_8 * 360f;
                val_8 = (double)val_8;
            }
            else
            {
                    val_8 = 0;
            }
            
            if(0 != this.image.texture)
            {
                    UnityEngine.Texture val_4 = this.image.texture;
                UnityEngine.Object.DestroyImmediate(obj:  0);
            }
            
            hideFlags = 52;
            var val_12 = 0;
            do
            {
                float val_9 = 0f;
                val_9 = val_9 / 100f;
                var val_11 = 0;
                do
            {
                float val_10 = 0f;
                val_10 = val_10 / 100f;
                UnityEngine.Color val_6 = UnityEngine.UI.Extensions.ColorPicker.HSVUtil.ConvertHsvToRgb(h:  val_8, s:  (double)val_9, v:  (double)val_10, alpha:  1f);
                UnityEngine.Color32 val_7 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a});
                UnityEngine.Color32[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_0 = val_7.r;
                UnityEngine.Color32[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_1 = val_7.g;
                UnityEngine.Color32[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_2 = val_7.b;
                UnityEngine.Color32[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_3 = val_7.a;
                val_11 = val_11 + 1;
            }
            while(val_11 != 100);
            
                SetPixels32(x:  0, y:  0, blockWidth:  1, blockHeight:  100, colors:  null);
                val_12 = val_12 + 1;
            }
            while(val_12 != 100);
            
            Apply();
            this.image.texture = new UnityEngine.Texture2D(width:  100, height:  100);
        }
    
    }

}
