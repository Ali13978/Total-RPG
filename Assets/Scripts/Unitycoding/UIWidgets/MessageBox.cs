using UnityEngine;

namespace Unitycoding.UIWidgets
{
    public class MessageBox : UIWidget
    {
        // Fields
        public bool autoClose;
        [UnityEngine.HeaderAttribute]
        public UnityEngine.UI.Text title;
        public UnityEngine.UI.Text text;
        public UnityEngine.UI.Image icon;
        public UnityEngine.UI.Button button;
        private System.Collections.Generic.List<UnityEngine.UI.Button> buttonCache;
        private static System.Predicate<UnityEngine.UI.Button> <>f__am$cache0;
        
        // Methods
        public MessageBox()
        {
            this.autoClose = true;
            this.buttonCache = new System.Collections.Generic.List<UnityEngine.UI.Button>();
        }
        public virtual void Show(Unitycoding.UIWidgets.MessageOptions settings, UnityEngine.Events.UnityAction<string> result, string[] buttons)
        {
            string val_2;
            string val_3;
            if(settings != null)
            {
                    val_3 = settings.title;
                val_2 = settings.text;
            }
            else
            {
                    val_3 = 11993091;
                val_2 = 7254272;
            }
            
            string val_1 = Unitycoding.UIWidgets.UIUtility.ColorString(value:  null, color:  new UnityEngine.Color() {r = settings.color, g = V10.16B, b = V9.16B, a = V8.16B});
            goto typeof(Unitycoding.UIWidgets.MessageBox).__il2cppRuntimeField_1E0;
        }
        public virtual void Show(string title, string text, string[] buttons)
        {
            goto typeof(Unitycoding.UIWidgets.MessageBox).__il2cppRuntimeField_1E0;
        }
        public virtual void Show(string title, string text, UnityEngine.Events.UnityAction<string> result, string[] buttons)
        {
            goto typeof(Unitycoding.UIWidgets.MessageBox).__il2cppRuntimeField_1E0;
        }
        public virtual void Show(string title, string text, UnityEngine.Sprite icon, UnityEngine.Events.UnityAction<string> result, string[] buttons)
        {
            var val_26;
            UnityEngine.UI.Text val_27;
            var val_28;
            var val_29;
            UnityEngine.UI.Image val_30;
            var val_31;
            var val_32;
            var val_33;
            if(null != 0)
            {
                    typeof(MessageBox.<Show>c__AnonStorey0).__il2cppRuntimeField_10 = result;
            }
            else
            {
                    mem[16] = result;
            }
            
            typeof(MessageBox.<Show>c__AnonStorey0).__il2cppRuntimeField_18 = this;
            val_26 = 0;
            goto label_3;
            label_12:
            X26.SetActive(value:  false);
            val_26 = 1;
            label_3:
            if(val_26 >= this.buttonCache.Count)
            {
                goto label_5;
            }
            
            this.buttonCache.Item[1].onClick.RemoveAllListeners();
            if(this.buttonCache.Item[1].gameObject != null)
            {
                goto label_12;
            }
            
            goto label_12;
            label_5:
            val_27 = this.title;
            if(0 != val_27)
            {
                    val_27 = this.title;
                if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    val_28 = val_27.gameObject;
                val_29 = 0;
            }
            else
            {
                    val_28 = this.title.gameObject;
                val_29 = 1;
            }
            
                val_28.SetActive(value:  true);
            }
            
            bool val_12 = UnityEngine.Object.op_Inequality(x:  0, y:  this.text);
            val_30 = this.icon;
            if(0 != val_30)
            {
                    bool val_14 = UnityEngine.Object.op_Inequality(x:  0, y:  icon);
                val_30 = this.icon;
                if(val_14 != false)
            {
                    val_30.sprite = icon;
                val_31 = this.icon.transform.parent.gameObject;
                val_32 = 1;
            }
            else
            {
                    val_31 = val_30.transform.parent.gameObject;
                val_32 = 0;
            }
            
                val_31.SetActive(value:  false);
            }
            
            this.Show();
            this.button.gameObject.SetActive(value:  false);
            val_33 = 0;
            goto label_45;
            label_52:
            val_30.AddListener(call:  val_14);
            val_33 = 1;
            label_45:
            if(val_33 >= buttons.Length)
            {
                    return;
            }
            
            typeof(MessageBox.<Show>c__AnonStorey1).__il2cppRuntimeField_18 = new System.Object();
            string val_26 = buttons[1];
            typeof(MessageBox.<Show>c__AnonStorey1).__il2cppRuntimeField_10 = val_26;
            UnityEngine.Events.UnityAction val_25 = new UnityEngine.Events.UnityAction(object:  new System.Object(), method:  System.Void MessageBox.<Show>c__AnonStorey1::<>m__0());
            if((this.AddButton(text:  val_26).onClick) != null)
            {
                goto label_52;
            }
            
            goto label_52;
        }
        private UnityEngine.UI.Button AddButton(string text)
        {
            var val_11;
            UnityEngine.Object val_12;
            val_11 = null;
            if((Unitycoding.UIWidgets.MessageBox.<>f__am$cache0) == null)
            {
                    Unitycoding.UIWidgets.MessageBox.<>f__am$cache0 = new System.Predicate<UnityEngine.UI.Button>(object:  0, method:  static System.Boolean Unitycoding.UIWidgets.MessageBox::<AddButton>m__0(UnityEngine.UI.Button x));
                val_11 = null;
            }
            
            val_12 = this.buttonCache.Find(match:  Unitycoding.UIWidgets.MessageBox.<>f__am$cache0);
            if(0 == val_12)
            {
                    val_12 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
                this.buttonCache.Add(item:  val_12);
            }
            
            val_12.gameObject.SetActive(value:  true);
            val_12.onClick.RemoveAllListeners();
            val_12.transform.SetParent(parent:  this.button.transform.parent, worldPositionStays:  false);
            if(val_10.Length < 1)
            {
                    return val_12;
            }
            
            T val_11 = val_12.GetComponentsInChildren<UnityEngine.UI.Text>(includeInactive:  true)[0];
            return val_12;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private void <Close>__BaseCallProxy0()
        {
            this.Close();
        }
        private static bool <AddButton>m__0(UnityEngine.UI.Button x)
        {
            bool val_1 = X1.isActiveAndEnabled;
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
    
    }

}
