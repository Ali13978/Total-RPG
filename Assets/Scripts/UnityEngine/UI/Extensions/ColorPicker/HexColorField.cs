using UnityEngine;

namespace UnityEngine.UI.Extensions.ColorPicker
{
    [UnityEngine.RequireComponent]
    public class HexColorField : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Extensions.ColorPicker.ColorPickerControl ColorPicker;
        public bool displayAlpha;
        private UnityEngine.UI.InputField hexInputField;
        private const string hexRegex = "^#?(?:[0-9a-fA-F]{3,4}){1,2}$";
        
        // Methods
        public HexColorField()
        {
        
        }
        private void Awake()
        {
            UnityEngine.UI.InputField val_1 = this.GetComponent<UnityEngine.UI.InputField>();
            this.hexInputField = val_1;
            val_1.onEndEdit.AddListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void UnityEngine.UI.Extensions.ColorPicker.HexColorField::UpdateColor(string newHex)));
            this.ColorPicker.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<UnityEngine.Color>(object:  this, method:  System.Void UnityEngine.UI.Extensions.ColorPicker.HexColorField::UpdateHex(UnityEngine.Color newColor)));
        }
        private void OnDestroy()
        {
            this.hexInputField.onValueChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void UnityEngine.UI.Extensions.ColorPicker.HexColorField::UpdateColor(string newHex)));
            this.ColorPicker.onValueChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<UnityEngine.Color>(object:  this, method:  System.Void UnityEngine.UI.Extensions.ColorPicker.HexColorField::UpdateHex(UnityEngine.Color newColor)));
        }
        private void UpdateHex(UnityEngine.Color newColor)
        {
            UnityEngine.Color32 val_1 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = newColor.r, g = newColor.g, b = newColor.b, a = newColor.a});
            this.hexInputField.text = this.ColorToHex(color:  new UnityEngine.Color32() {r = val_1.r & 4294967295, g = val_1.r & 4294967295, b = val_1.r & 4294967295, a = val_1.r & 4294967295});
        }
        private void UpdateColor(string newHex)
        {
            if((UnityEngine.UI.Extensions.ColorPicker.HexColorField.HexToColor(hex:  11834, color: out  new UnityEngine.Color32() {r = newHex, g = newHex, b = newHex, a = newHex})) != false)
            {
                    this = this.ColorPicker;
                UnityEngine.Color val_2 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
                this.CurrentColor = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
                return;
            }
            
            UnityEngine.Debug.Log(message:  0);
        }
        private string ColorToHex(UnityEngine.Color32 color)
        {
            object val_8;
            byte val_9;
            if(this.displayAlpha != false)
            {
                    val_8 = null;
                typeof(System.Object[]).__il2cppRuntimeField_20 = color.r;
                typeof(System.Object[]).__il2cppRuntimeField_21 = 31540189;
                typeof(System.Object[]).__il2cppRuntimeField_28 = color.r >> 8;
                typeof(System.Object[]).__il2cppRuntimeField_29 = 31540205;
                val_9 = color.r >> 16;
                typeof(System.Object[]).__il2cppRuntimeField_30 = val_9;
                typeof(System.Object[]).__il2cppRuntimeField_31 = 31540221;
                typeof(System.Object[]).__il2cppRuntimeField_38 = color.r >> 24;
                typeof(System.Object[]).__il2cppRuntimeField_39 = 31540237;
                string val_4 = System.String.Format(format:  0, args:  "#{0:X2}{1:X2}{2:X2}{3:X2}");
                return (string)System.String.Format(format:  0, arg0:  "#{0:X2}{1:X2}{2:X2}", arg1:  color.r, arg2:  color.r >> 8);
            }
            
            val_8 = color.r;
            val_9 = color.r >> 16;
            return (string)System.String.Format(format:  0, arg0:  "#{0:X2}{1:X2}{2:X2}", arg1:  color.r, arg2:  color.r >> 8);
        }
        public static bool HexToColor(string hex, out UnityEngine.Color32 color)
        {
            int val_67;
            var val_68;
            var val_69;
            var val_70;
            var val_71;
            var val_73;
            var val_75;
            var val_76;
            string val_77;
            var val_78;
            if((System.Text.RegularExpressions.Regex.IsMatch(input:  0, pattern:  color.r)) == false)
            {
                goto label_3;
            }
            
            if(color.r == 0)
            {
                goto label_4;
            }
            
            bool val_2 = color.r.StartsWith(value:  "#");
            val_67 = val_2;
            if(color.r.Length == ((val_2 != true) ? (8 + 1) : 8))
            {
                goto label_5;
            }
            
            if(color.r.Length == ((val_67 == true) ? (6 + 1) : 6))
            {
                goto label_6;
            }
            
            goto label_14;
            label_3:
            val_68 = 0;
            mem2[0] = 0;
            return (bool)val_68;
            label_4:
            bool val_7 = 0.StartsWith(value:  "#");
            val_67 = val_7;
            if(0.Length != ((val_7 != true) ? (8 + 1) : 8))
            {
                goto label_9;
            }
            
            label_5:
            val_69 = System.Byte.Parse(s:  0, style:  color.r.Substring(startIndex:  val_67, length:  2));
            val_70 = System.Byte.Parse(s:  0, style:  color.r.Substring(startIndex:  val_67 | 2, length:  2));
            val_71 = System.Byte.Parse(s:  0, style:  color.r.Substring(startIndex:  val_67 | 4, length:  2));
            string val_19 = color.r.Substring(startIndex:  val_67 | 6, length:  2);
            goto label_13;
            label_9:
            if(0.Length != ((val_67 == true) ? (6 + 1) : 6))
            {
                goto label_14;
            }
            
            label_6:
            val_73 = System.Byte.Parse(s:  0, style:  color.r.Substring(startIndex:  val_67, length:  2));
            val_70 = System.Byte.Parse(s:  0, style:  color.r.Substring(startIndex:  val_67 | 2, length:  2));
            string val_28 = color.r.Substring(startIndex:  val_67 | 4, length:  2);
            goto label_17;
            label_14:
            val_75 = null;
            if(color.r.Length != (val_67 | 4))
            {
                goto label_18;
            }
            
            val_76 = null;
            char val_34 = color.r.Chars[val_67];
            val_69 = System.Byte.Parse(s:  0, style:  0 + System.String.Empty + color.r.Chars[val_67]);
            bool val_37 = val_67 + 1;
            char val_39 = color.r.Chars[val_37];
            val_70 = System.Byte.Parse(s:  0, style:  0 + System.String.Empty + color.r.Chars[val_37]);
            bool val_42 = val_67 | 2;
            char val_44 = color.r.Chars[val_42];
            val_71 = System.Byte.Parse(s:  0, style:  0 + System.String.Empty + color.r.Chars[val_42]);
            val_77 = System.String.Empty;
            val_67 = val_67 + 3;
            char val_48 = color.r.Chars[val_67];
            label_13:
            byte val_50 = System.Byte.Parse(s:  0, style:  0 + val_77 + color.r.Chars[val_67]);
            goto label_29;
            label_18:
            val_78 = null;
            char val_53 = color.r.Chars[val_67];
            val_73 = System.Byte.Parse(s:  0, style:  0 + System.String.Empty + color.r.Chars[val_67]);
            bool val_56 = val_67 + 1;
            char val_58 = color.r.Chars[val_56];
            val_70 = System.Byte.Parse(s:  0, style:  0 + System.String.Empty + color.r.Chars[val_56]);
            val_67 = val_67 | 2;
            char val_61 = color.r.Chars[val_67];
            val_77 = val_61;
            char val_62 = color.r.Chars[val_67];
            label_17:
            byte val_64 = System.Byte.Parse(s:  0, style:  0 + System.String.Empty + val_61);
            label_29:
            val_68 = 1;
            return (bool)val_68;
        }
    
    }

}
