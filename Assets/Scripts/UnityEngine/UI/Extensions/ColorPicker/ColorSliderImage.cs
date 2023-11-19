using UnityEngine;

namespace UnityEngine.UI.Extensions.ColorPicker
{
    [UnityEngine.RequireComponent]
    [UnityEngine.ExecuteInEditMode]
    public class ColorSliderImage : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Extensions.ColorPicker.ColorPickerControl picker;
        public UnityEngine.UI.Extensions.ColorPicker.ColorValues type;
        public UnityEngine.UI.Slider.Direction direction;
        private UnityEngine.UI.RawImage image;
        
        // Properties
        private UnityEngine.RectTransform RectTransform { get; }
        
        // Methods
        public ColorSliderImage()
        {
        
        }
        private UnityEngine.RectTransform get_RectTransform()
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
            this.image = this.GetComponent<UnityEngine.UI.RawImage>();
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    this.RegenerateTexture();
                return;
            }
            
            string val_4 = 0 + "Missing RawImage on object [" + this.name;
            UnityEngine.Debug.LogWarning(message:  0);
        }
        private void OnEnable()
        {
            if(0 == this.picker)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            this.picker.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<UnityEngine.Color>(object:  this, method:  System.Void UnityEngine.UI.Extensions.ColorPicker.ColorSliderImage::ColorChanged(UnityEngine.Color newColor)));
            this.picker.onHSVChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Single, System.Single, System.Single>(object:  this, method:  System.Void UnityEngine.UI.Extensions.ColorPicker.ColorSliderImage::ColorChanged(float hue, float saturation, float value)));
        }
        private void OnDisable()
        {
            if(0 == this.picker)
            {
                    return;
            }
            
            this.picker.onValueChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<UnityEngine.Color>(object:  this, method:  System.Void UnityEngine.UI.Extensions.ColorPicker.ColorSliderImage::ColorChanged(UnityEngine.Color newColor)));
            this.picker.onHSVChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.Single, System.Single, System.Single>(object:  this, method:  System.Void UnityEngine.UI.Extensions.ColorPicker.ColorSliderImage::ColorChanged(float hue, float saturation, float value)));
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
        private void ColorChanged(UnityEngine.Color newColor)
        {
            UnityEngine.UI.Extensions.ColorPicker.ColorValues val_1 = this.type;
            if(val_1 > 6)
            {
                    return;
            }
            
            val_1 = val_1 - 3;
            if(val_1 < 2)
            {
                    return;
            }
            
            this.RegenerateTexture();
        }
        private void ColorChanged(float hue, float saturation, float value)
        {
            UnityEngine.UI.Extensions.ColorPicker.ColorValues val_1 = this.type;
            if(val_1 > 6)
            {
                    return;
            }
            
            val_1 = val_1 - 3;
            if(val_1 < 2)
            {
                    return;
            }
            
            this.RegenerateTexture();
        }
        private void RegenerateTexture()
        {
            string val_44;
            var val_45;
            UnityEngine.Texture val_50;
            double val_51;
            double val_52;
            Slider.Direction val_53;
            UnityEngine.Color32[] val_54;
            var val_55;
            var val_56;
            var val_57;
            var val_58;
            var val_59;
            var val_60;
            var val_61;
            var val_62;
            val_44 = this;
            val_45 = 1152921504721543168;
            if((UnityEngine.Object.op_Implicit(exists:  0)) != true)
            {
                    string val_4 = 0 + "Missing Picker on object [" + this.name;
                UnityEngine.Debug.LogWarning(message:  0);
            }
            
            if(0 != this.picker)
            {
                    UnityEngine.Color val_6 = this.picker.CurrentColor;
            }
            else
            {
                    UnityEngine.Color val_7 = UnityEngine.Color.black;
            }
            
            UnityEngine.Color32 val_8 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a});
            val_50 = val_8.r;
            if(0 != this.picker)
            {
                    float val_49 = this.picker._hue;
                val_49 = val_49 * 360f;
                val_51 = (double)val_49;
            }
            else
            {
                    val_51 = 0;
            }
            
            if(0 != this.picker)
            {
                    if(this.picker != null)
            {
                goto label_22;
            }
            
            }
            
            label_22:
            if(0 != this.picker)
            {
                    val_52 = (double)this.picker._brightness;
            }
            else
            {
                    val_52 = 0;
            }
            
            val_53 = this.direction;
            if(val_53 != 2)
            {
                goto label_28;
            }
            
            val_54 = 0;
            val_53 = 2;
            goto label_30;
            label_28:
            var val_12 = (val_53 != 3) ? 1 : 0;
            if(val_53 != 3)
            {
                goto label_30;
            }
            
            val_55 = 1;
            goto label_31;
            label_30:
            label_31:
            if(this.type > 6)
            {
                goto label_48;
            }
            
            if((25811360 + (this.type) << 2) <= 30)
            {
                goto label_33;
            }
            
            if((25811360 + (this.type) << 2) == 32)
            {
                goto label_34;
            }
            
            if((25811360 + (this.type) << 2) != 31)
            {
                    return;
            }
            
            val_56 = 360;
            goto label_38;
            label_33:
            if((25811360 + (this.type) << 2) != 30)
            {
                goto label_37;
            }
            
            val_56 = 255;
            goto label_38;
            label_34:
            val_56 = 100;
            label_38:
            if((val_54 & 1) != 0)
            {
                    val_57 = 1;
                val_58 = 100;
            }
            else
            {
                    val_58 = 1;
                val_57 = 100;
            }
            
            null = new UnityEngine.Texture2D(width:  1, height:  100);
            hideFlags = 52;
            UnityEngine.UI.Extensions.ColorPicker.ColorValues val_50 = this.type;
            val_54 = null;
            var val_16 = (val_50 < 7) ? (val_50 + 42) : 0;
            val_50 = val_16 - 42;
            if(val_50 > 6)
            {
                goto label_42;
            }
            
            var val_51 = 25811080 + ((this.type < 0x7 ? (this.type + 42) : 0 - 42)) << 2;
            val_51 = val_51 + 25811080;
            goto (25811080 + ((this.type < 0x7 ? (this.type + 42) : 0 - 42)) << 2 + 25811080);
            label_37:
            if((25811360 + (this.type) << 2) != 0)
            {
                    return;
            }
            
            goto label_48;
            label_42:
            if(val_16 != 0)
            {
                    return;
            }
            
            label_48:
            val_60 = null;
            val_60 = null;
            val_44 = System.String.Empty;
            System.NotImplementedException val_22 = new System.NotImplementedException(message:  val_44);
            var val_53 = 0;
            byte val_24 = val_50 >> 16;
            do
            {
                var val_26 = (((val_53 == 1) ? 1 : 0) == 0) ? (val_53) : ((100 - 1) - val_53);
                var val_27 = val_54 + (((long)(int)(val_13 == 0x0 ? 0 : ((100 - 1) - 0))) << 2);
                val_59 = val_53 + 1;
                val_53 = val_59 & 255;
                mem2[0] = 0;
            }
            while(val_53 < 100);
            
            val_50 = null;
            if(null != 0)
            {
                    SetPixels32(colors:  val_54);
            }
            else
            {
                    SetPixels32(colors:  val_54);
            }
            
            Apply();
            if(0 != (System.String.Empty + 40.texture))
            {
                    UnityEngine.Texture val_48 = System.String.Empty + 40.texture;
                UnityEngine.Object.DestroyImmediate(obj:  0);
            }
            
            val_61 = mem[System.String.Empty + 40];
            val_61 = System.String.Empty + 40;
            val_61.texture = val_50;
            if((System.String.Empty + 36) > 3)
            {
                    return;
            }
            
            if((25811388 + (System.String.Empty + 36) << 2) != 89)
            {
                    if((25811388 + (System.String.Empty + 36) << 2) != 90)
            {
                    return;
            }
            
                val_44 = mem[System.String.Empty + 40];
                val_44 = System.String.Empty + 40;
                val_62 = 0f;
            }
            else
            {
                    val_44 = mem[System.String.Empty + 40];
                val_44 = System.String.Empty + 40;
                val_62 = 0f;
            }
            
            val_44.uvRect = new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
        }
    
    }

}
