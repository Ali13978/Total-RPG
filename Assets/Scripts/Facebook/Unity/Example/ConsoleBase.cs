using UnityEngine;

namespace Facebook.Unity.Example
{
    internal class ConsoleBase : MonoBehaviour
    {
        // Fields
        private const int DpiScalingFactor = 160;
        private static System.Collections.Generic.Stack<string> menuStack;
        private string status;
        private string lastResponse;
        private UnityEngine.Vector2 scrollPosition;
        private System.Nullable<float> scaleFactor;
        private UnityEngine.GUIStyle textStyle;
        private UnityEngine.GUIStyle buttonStyle;
        private UnityEngine.GUIStyle textInputStyle;
        private UnityEngine.GUIStyle labelStyle;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Texture2D <LastResponseTexture>k__BackingField;
        
        // Properties
        protected static int ButtonHeight { get; }
        protected static int MainWindowWidth { get; }
        protected static int MainWindowFullWidth { get; }
        protected static int MarginFix { get; }
        protected static System.Collections.Generic.Stack<string> MenuStack { get; set; }
        protected string Status { get; set; }
        protected UnityEngine.Texture2D LastResponseTexture { get; set; }
        protected string LastResponse { get; set; }
        protected UnityEngine.Vector2 ScrollPosition { get; set; }
        protected float ScaleFactor { get; }
        protected int FontSize { get; }
        protected UnityEngine.GUIStyle TextStyle { get; }
        protected UnityEngine.GUIStyle ButtonStyle { get; }
        protected UnityEngine.GUIStyle TextInputStyle { get; }
        protected UnityEngine.GUIStyle LabelStyle { get; }
        
        // Methods
        public ConsoleBase()
        {
            var val_2;
            this.status = "Ready";
            val_2 = null;
            val_2 = null;
            this.lastResponse = System.String.Empty;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            this.scrollPosition = val_1;
            mem[1152921511833645212] = val_1.y;
        }
        protected static int get_ButtonHeight()
        {
            return (int)(Facebook.Unity.Constants.IsMobile != true) ? 60 : 24;
        }
        protected static int get_MainWindowWidth()
        {
            var val_3;
            if(Facebook.Unity.Constants.IsMobile != false)
            {
                    val_3 = UnityEngine.Screen.width - 30;
                return 700;
            }
            
            val_3 = 700;
            return 700;
        }
        protected static int get_MainWindowFullWidth()
        {
            if(Facebook.Unity.Constants.IsMobile == false)
            {
                    return 760;
            }
            
            return UnityEngine.Screen.width;
        }
        protected static int get_MarginFix()
        {
            return (int)(Facebook.Unity.Constants.IsMobile != true) ? 0 : 48;
        }
        protected static System.Collections.Generic.Stack<string> get_MenuStack()
        {
            null = null;
            return (System.Collections.Generic.Stack<System.String>)Facebook.Unity.Example.ConsoleBase.menuStack;
        }
        protected static void set_MenuStack(System.Collections.Generic.Stack<string> value)
        {
            null = null;
            Facebook.Unity.Example.ConsoleBase.menuStack = X1;
        }
        protected string get_Status()
        {
            return (string)this.status;
        }
        protected void set_Status(string value)
        {
            this.status = value;
        }
        protected UnityEngine.Texture2D get_LastResponseTexture()
        {
            return (UnityEngine.Texture2D)this.<LastResponseTexture>k__BackingField;
        }
        protected void set_LastResponseTexture(UnityEngine.Texture2D value)
        {
            this.<LastResponseTexture>k__BackingField = value;
        }
        protected string get_LastResponse()
        {
            return (string)this.lastResponse;
        }
        protected void set_LastResponse(string value)
        {
            this.lastResponse = value;
        }
        protected UnityEngine.Vector2 get_ScrollPosition()
        {
            return new UnityEngine.Vector2() {x = this.scrollPosition};
        }
        protected void set_ScrollPosition(UnityEngine.Vector2 value)
        {
            this.scrollPosition = value;
            mem[1152921511835270556] = value.y;
        }
        protected float get_ScaleFactor()
        {
            if(((this.scaleFactor & 1) & 1) != 0)
            {
                    return (float)val_2;
            }
            
            float val_2 = UnityEngine.Screen.dpi;
            val_2 = val_2 / 160f;
            mem2[0] = 0;
            return (float)val_2;
        }
        protected int get_FontSize()
        {
            float val_3;
            float val_6;
            double val_7;
            float val_2 = this.ScaleFactor * 16f;
            if(val_2 >= 0f)
            {
                goto label_0;
            }
            
            if((double)val_2 != (-0.5))
            {
                goto label_1;
            }
            
            val_6 = val_3;
            val_7 = -1;
            goto label_2;
            label_0:
            if((double)val_2 != 0.5)
            {
                    return (int)(int)(double)val_2 + 0.5;
            }
            
            val_6 = val_3;
            val_7 = 1;
            label_2:
            val_7 = val_6 + val_7;
            val_6 = (((long)val_6 & 1) != 0) ? (val_6) : (val_7);
            return (int)(int)(double)val_2 + 0.5;
            label_1:
            double val_4 = (double)val_2 + (-0.5);
            return (int)(int)(double)val_2 + 0.5;
        }
        protected UnityEngine.GUIStyle get_TextStyle()
        {
            UnityEngine.GUIStyle val_6 = this.textStyle;
            if(val_6 != null)
            {
                    return val_6;
            }
            
            this.textStyle = new UnityEngine.GUIStyle(other:  UnityEngine.GUI.skin.textArea);
            alignment = 0;
            this.textStyle.wordWrap = true;
            this.textStyle.padding = new UnityEngine.RectOffset(left:  10, right:  10, top:  10, bottom:  10);
            this.textStyle.stretchHeight = true;
            this.textStyle.stretchWidth = false;
            this.textStyle.fontSize = this.FontSize;
            val_6 = this.textStyle;
            return val_6;
        }
        protected UnityEngine.GUIStyle get_ButtonStyle()
        {
            UnityEngine.GUIStyle val_5 = this.buttonStyle;
            if(val_5 != null)
            {
                    return val_5;
            }
            
            this.buttonStyle = new UnityEngine.GUIStyle(other:  UnityEngine.GUI.skin.button);
            fontSize = this.FontSize;
            val_5 = this.buttonStyle;
            return val_5;
        }
        protected UnityEngine.GUIStyle get_TextInputStyle()
        {
            UnityEngine.GUIStyle val_5 = this.textInputStyle;
            if(val_5 != null)
            {
                    return val_5;
            }
            
            this.textInputStyle = new UnityEngine.GUIStyle(other:  UnityEngine.GUI.skin.textField);
            fontSize = this.FontSize;
            val_5 = this.textInputStyle;
            return val_5;
        }
        protected UnityEngine.GUIStyle get_LabelStyle()
        {
            UnityEngine.GUIStyle val_5 = this.labelStyle;
            if(val_5 != null)
            {
                    return val_5;
            }
            
            this.labelStyle = new UnityEngine.GUIStyle(other:  UnityEngine.GUI.skin.label);
            fontSize = this.FontSize;
            val_5 = this.labelStyle;
            return val_5;
        }
        protected virtual void Awake()
        {
            UnityEngine.Application.targetFrameRate = 0;
        }
        protected bool Button(string label)
        {
            var val_8;
            float val_3 = this.ScaleFactor;
            val_3 = ((Facebook.Unity.Constants.IsMobile != true) ? 60f : 24f) * val_3;
            UnityEngine.GUILayoutOption val_5 = UnityEngine.GUILayout.MinHeight(minHeight:  val_3);
            if(val_5 != null)
            {
                    val_8 = val_5;
            }
            
            typeof(UnityEngine.GUILayoutOption[]).__il2cppRuntimeField_20 = val_5;
            typeof(UnityEngine.GUILayoutOption[]).__il2cppRuntimeField_28 = UnityEngine.GUILayout.MaxWidth(maxWidth:  (float)Facebook.Unity.Example.ConsoleBase.MainWindowWidth);
            return UnityEngine.GUILayout.Button(text:  0, style:  label, options:  this.ButtonStyle);
        }
        protected void LabelAndTextField(string label, ref string text)
        {
            var val_9;
            UnityEngine.GUILayout.BeginHorizontal(options:  0);
            float val_2 = this.ScaleFactor;
            val_2 = val_2 * 200f;
            typeof(UnityEngine.GUILayoutOption[]).__il2cppRuntimeField_20 = UnityEngine.GUILayout.MaxWidth(maxWidth:  val_2);
            UnityEngine.GUILayout.Label(text:  0, style:  label, options:  this.LabelStyle);
            val_9 = null;
            val_9 = null;
            typeof(UnityEngine.GUILayoutOption[]).__il2cppRuntimeField_20 = UnityEngine.GUILayout.MaxWidth(maxWidth:  (float)Facebook.Unity.Example.ConsoleBase.MainWindowWidth - 150);
            text = UnityEngine.GUILayout.TextField(text:  0, style:  text, options:  this.TextInputStyle);
            UnityEngine.GUILayout.EndHorizontal();
        }
        protected bool IsHorizontalLayout()
        {
            return (bool)(UnityEngine.Screen.orientation == 3) ? 1 : 0;
        }
        protected void SwitchMenu(System.Type menuClass)
        {
            null = null;
            Facebook.Unity.Example.ConsoleBase.menuStack.Push(t:  this.GetType());
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  0);
        }
        protected void GoBack()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((System.Linq.Enumerable.Any<System.String>(source:  0)) == false)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            string val_2 = Facebook.Unity.Example.ConsoleBase.menuStack.Pop();
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  0);
        }
        private static ConsoleBase()
        {
            Facebook.Unity.Example.ConsoleBase.menuStack = new System.Collections.Generic.Stack<System.String>();
        }
    
    }

}
