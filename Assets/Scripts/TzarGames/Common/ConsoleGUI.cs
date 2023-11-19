using UnityEngine;

namespace TzarGames.Common
{
    public class ConsoleGUI : MonoBehaviour
    {
        // Fields
        public float autocompleteWindowHeight;
        private TzarGames.Common.ConsoleGUI.ConsoleDrawMode drawMode;
        private UnityEngine.Rect consoleWindowRect;
        private string inputText;
        private string lastInputText;
        public bool drawConsole;
        private bool autocompleteWindowIsOn;
        private UnityEngine.Vector2 logScrollPos;
        private UnityEngine.Vector2 helpScrollPos;
        private UnityEngine.Vector2 autocompleteScrollPos;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static TzarGames.Common.ConsoleGUI.ConsoleVoidDelegate OnConsoleOpen;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static TzarGames.Common.ConsoleGUI.ConsoleVoidDelegate OnConsoleClose;
        private bool pendingFocusSet;
        private bool tabPressed;
        private bool openConsolePressed;
        private bool pendingTouchRelease;
        private System.Collections.Generic.List<string> lastExecutedCommads;
        private int currentExecutedCommandNum;
        private System.Text.RegularExpressions.Regex regularExpression;
        private char[] newLine;
        private string[] currentAutocompleteResult;
        private UnityEngine.GUIStyle logBackgroundStyle;
        private bool prevCursorState;
        private int lastLogLen;
        
        // Methods
        public ConsoleGUI()
        {
            var val_7;
            this.autocompleteWindowHeight = 300f;
            this.consoleWindowRect = 0;
            val_7 = null;
            val_7 = null;
            this.inputText = System.String.Empty;
            this.lastInputText = System.String.Empty;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            this.logScrollPos = val_1;
            mem[1152921511068223960] = val_1.y;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            this.helpScrollPos = val_2;
            mem[1152921511068223968] = val_2.y;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
            this.autocompleteScrollPos = val_3;
            mem[1152921511068223976] = val_3.y;
            this.lastExecutedCommads = new System.Collections.Generic.List<System.String>();
            this.regularExpression = new System.Text.RegularExpressions.Regex(pattern:  System.String.Empty);
            this.newLine = ToCharArray();
        }
        public static void add_OnConsoleOpen(TzarGames.Common.ConsoleGUI.ConsoleVoidDelegate value)
        {
            var val_3;
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  TzarGames.Common.ConsoleGUI.OnConsoleOpen);
            val_3 = 0;
            if(val_1 == null)
            {
                    return;
            }
            
            val_3 = val_1;
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        public static void remove_OnConsoleOpen(TzarGames.Common.ConsoleGUI.ConsoleVoidDelegate value)
        {
            var val_3;
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  TzarGames.Common.ConsoleGUI.OnConsoleOpen);
            val_3 = 0;
            if(val_1 == null)
            {
                    return;
            }
            
            val_3 = val_1;
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        public static void add_OnConsoleClose(TzarGames.Common.ConsoleGUI.ConsoleVoidDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  TzarGames.Common.ConsoleGUI.OnConsoleClose);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921504891940872 != TzarGames.Common.ConsoleGUI.OnConsoleClose);
        
        }
        public static void remove_OnConsoleClose(TzarGames.Common.ConsoleGUI.ConsoleVoidDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  TzarGames.Common.ConsoleGUI.OnConsoleClose);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921504891940872 != TzarGames.Common.ConsoleGUI.OnConsoleClose);
        
        }
        private void Start()
        {
            float val_2 = (float)UnityEngine.Screen.width - S0;
            val_2 = val_2 * 0.5f;
            this.consoleWindowRect.startFloat = val_2;
            val_2 = (float)UnityEngine.Screen.height - val_2;
            val_2 = val_2 * 0.5f;
            this.prevCursorState = UnityEngine.Cursor.visible;
            TzarGames.Common.Console.ForceInit();
        }
        private void Update()
        {
            if(UnityEngine.Input.touchCount >= 4)
            {
                    this.pendingTouchRelease = true;
                return;
            }
            
            if(this.pendingTouchRelease == false)
            {
                    return;
            }
            
            bool val_2 = this.drawConsole;
            val_2 = val_2 ^ 1;
            this.drawConsole = val_2;
        }
        private void OnGUI()
        {
            this.initStyles();
            this.processEvents();
            if(this.drawConsole == false)
            {
                    return;
            }
            
            UnityEngine.Rect val_2 = UnityEngine.GUI.Window(id:  0, clientRect:  new UnityEngine.Rect() {m_XMin = this.consoleWindowRect, m_YMin = V9.16B, m_Width = V10.16B, m_Height = V11.16B}, func:  0, text:  new GUI.WindowFunction(object:  this, method:  System.Void TzarGames.Common.ConsoleGUI::consoleWindowFunc(int windowID)));
            this.consoleWindowRect = val_2;
            mem[1152921511069111444] = val_2.m_YMin;
            mem[1152921511069111448] = val_2.m_Width;
            mem[1152921511069111452] = val_2.m_Height;
        }
        private void executeCommand(string command)
        {
            System.Collections.Generic.List<System.String> val_3;
            var val_4;
            val_3 = this.lastExecutedCommads;
            if((val_3.Contains(item:  command)) != true)
            {
                    val_3 = this.lastExecutedCommads;
                val_3.Add(item:  command);
            }
            
            TzarGames.Common.Console.Execute(command:  null);
            val_4 = null;
            val_4 = null;
            this.inputText = System.String.Empty;
        }
        private void processEvents()
        {
            var val_18;
            var val_19;
            int val_20;
            string val_21;
            System.Collections.Generic.List<System.String> val_22;
            if(UnityEngine.Event.current == null)
            {
                    return;
            }
            
            UnityEngine.Event val_2 = UnityEngine.Event.current;
            if(val_2.isKey == false)
            {
                    return;
            }
            
            val_18 = val_2.type;
            if(val_18 == 4)
            {
                    if((val_2.character & 65535) == '
            ')
            {
                    this.executeCommand(command:  this.inputText);
            }
            
            }
            
            UnityEngine.KeyCode val_7 = val_2.keyCode;
            if(val_7 <= 26)
            {
                goto label_9;
            }
            
            if(val_7 == 27)
            {
                goto label_10;
            }
            
            if(val_7 == 273)
            {
                goto label_11;
            }
            
            if(val_7 != 274)
            {
                    return;
            }
            
            if(this.lastExecutedCommads == null)
            {
                    return;
            }
            
            val_19 = 1152921509084995904;
            if(this.lastExecutedCommads.Count < 1)
            {
                    return;
            }
            
            int val_9 = this.currentExecutedCommandNum + 1;
            this.currentExecutedCommandNum = val_9;
            if(val_9 >= this.lastExecutedCommads.Count)
            {
                goto label_16;
            }
            
            val_20 = this.currentExecutedCommandNum;
            goto label_28;
            label_9:
            if(val_7 == 9)
            {
                goto label_18;
            }
            
            if(val_7 != 19)
            {
                    return;
            }
            
            if(this.openConsolePressed == false)
            {
                goto label_20;
            }
            
            if(val_18 == 4)
            {
                    return;
            }
            
            this.openConsolePressed = false;
            return;
            label_10:
            bool val_17 = this.drawConsole;
            val_17 = val_17 ^ 1;
            this.drawConsole = val_17;
            return;
            label_11:
            if(this.lastExecutedCommads == null)
            {
                    return;
            }
            
            val_19 = 1152921509084995904;
            if(this.lastExecutedCommads.Count < 1)
            {
                    return;
            }
            
            val_20 = this.currentExecutedCommandNum - 1;
            this.currentExecutedCommandNum = val_20;
            if((val_20 & 2147483648) == 0)
            {
                goto label_28;
            }
            
            val_20 = this.lastExecutedCommads.Count - 1;
            this.currentExecutedCommandNum = val_20;
            goto label_28;
            label_18:
            if(val_18 != 4)
            {
                goto label_29;
            }
            
            if(this.tabPressed == true)
            {
                    return;
            }
            
            this.tabPressed = true;
            if(this.currentAutocompleteResult == null)
            {
                    return;
            }
            
            if(this.currentAutocompleteResult.Length < 1)
            {
                    return;
            }
            
            val_21 = this.currentAutocompleteResult[0];
            this.inputText = val_21;
            goto label_33;
            label_29:
            this.tabPressed = false;
            return;
            label_20:
            if(val_18 == 4)
            {
                    this.openConsolePressed = true;
            }
            
            this.drawConsole = this.drawConsole ^ 1;
            if(this.drawConsole == false)
            {
                goto label_35;
            }
            
            UnityEngine.Cursor.visible = false;
            this.pendingFocusSet = false;
            if(TzarGames.Common.ConsoleGUI.OnConsoleClose != null)
            {
                goto label_36;
            }
            
            return;
            label_16:
            val_20 = 0;
            this.currentExecutedCommandNum = 0;
            label_28:
            val_22 = this.lastExecutedCommads;
            string val_14 = val_22.Item[0];
            this.inputText = val_14;
            val_21 = val_14;
            label_33:
            val_14.moveCursorToEnd(text:  val_21);
            return;
            label_35:
            this.prevCursorState = UnityEngine.Cursor.visible;
            UnityEngine.Cursor.visible = false;
            this.pendingFocusSet = true;
            if(TzarGames.Common.ConsoleGUI.OnConsoleOpen == null)
            {
                    return;
            }
            
            label_36:
            TzarGames.Common.ConsoleGUI.OnConsoleOpen.Invoke();
        }
        private void moveCursorToEnd(string text)
        {
            var val_8;
            int val_2 = UnityEngine.GUIUtility.keyboardControl;
            object val_3 = UnityEngine.GUIUtility.GetStateObject(t:  0, controlID:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_8 = 0;
            if(val_3 != null)
            {
                    val_8 = val_3;
                val_8 = 0;
            }
            
            val_8.cursorIndex = text.Length;
            val_8.selectIndex = text.Length;
        }
        private bool drawAutoCompleteWindow(UnityEngine.Rect rect)
        {
            float val_14;
            string val_19;
            System.String[] val_20;
            var val_21;
            float val_22;
            float val_23;
            float val_24;
            float val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            string val_32;
            var val_33;
            var val_34;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_16;
            }
            
            val_19 = this.lastInputText;
            if((System.String.op_Inequality(a:  0, b:  val_19)) != false)
            {
                    val_19 = null;
                typeof(System.Char[]).__il2cppRuntimeField_20 = 32;
                string val_19 = this.inputText.Split(separator:  val_19)[0];
                this.currentAutocompleteResult = TzarGames.Common.Console.GetAutocompleteResult(methodName:  null);
            }
            else
            {
                    val_20 = this.currentAutocompleteResult;
            }
            
            if((val_20 == null) || (this.currentAutocompleteResult.Length == 0))
            {
                goto label_16;
            }
            
            var val_21 = 1152921504742842368;
            do
            {
                val_21 = null;
                val_21 = null;
                UnityEngine.GUI.Box(position:  new UnityEngine.Rect() {m_XMin = rect.m_XMin, m_YMin = rect.m_YMin, m_Width = rect.m_Width, m_Height = rect.m_Height}, text:  0);
                val_19 = 6 - 1;
            }
            while(val_19 != 0);
            
            val_22 = rect.m_Width;
            val_23 = rect.m_Height;
            UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = rect.m_XMin, m_YMin = rect.m_YMin, m_Width = val_22, m_Height = val_23});
            val_24 = this.autocompleteScrollPos;
            val_25 = rect.m_YMin;
            UnityEngine.Vector2 val_7 = UnityEngine.GUILayout.BeginScrollView(scrollPosition:  new UnityEngine.Vector2() {x = val_24, y = val_25}, options:  0);
            this.autocompleteScrollPos = val_7;
            mem[1152921511069977288] = val_7.y;
            val_26 = 0;
            val_27 = 0;
            goto label_22;
            label_84:
            val_24 = this.autocompleteScrollPos;
            val_25 = rect.m_YMin;
            val_22 = rect.m_Height;
            val_23 = rect.m_Width;
            UnityEngine.GUI.color = new UnityEngine.Color() {r = val_24, g = val_25, b = val_22, a = val_23};
            UnityEngine.GUILayout.EndHorizontal();
            val_27 = 1;
            label_22:
            if(val_27 >= this.currentAutocompleteResult.Length)
            {
                goto label_24;
            }
            
            UnityEngine.GUILayout.BeginHorizontal(options:  0);
            val_24 = val_24 * 0.45f;
            typeof(UnityEngine.GUILayoutOption[]).__il2cppRuntimeField_20 = UnityEngine.GUILayout.Width(width:  val_24);
            UnityEngine.GUILayout.Label(text:  0, options:  this.currentAutocompleteResult[1]);
            UnityEngine.Color val_10 = UnityEngine.GUI.color;
            UnityEngine.Color val_11 = UnityEngine.Color.yellow;
            UnityEngine.GUI.color = new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a};
            List.Enumerator<T> val_12 = TzarGames.Common.Console.GetCommandParameters(command:  null).GetEnumerator();
            float val_22 = val_14;
            if((0 & 1) == 0)
            {
                goto label_37;
            }
            
            val_28 = null;
            val_28 = null;
            val_29 = 0;
            goto label_41;
            label_73:
            val_29 = 1;
            val_26 = val_21;
            label_41:
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_16 = val_22.InitializationCallback + 8;
            val_30 = 5;
            if(System.String.Empty != null)
            {
                    val_30 = mem[null + 48];
                if(System.String.Empty == null)
            {
                    val_30 = 0;
            }
            
            }
            
            val_30 = 0;
            typeof(System.String[]).__il2cppRuntimeField_20 = System.String.Empty;
            val_31 = mem[null + 400 + 8];
            if(null != null)
            {
                    val_31 = mem[null + 48];
                if(null == null)
            {
                    val_31 = 0;
            }
            
            }
            
            val_31 = 0;
            typeof(System.String[]).__il2cppRuntimeField_28 = null;
            val_31 = mem[null + 48];
            if(" " == null)
            {
                    val_31 = 0;
            }
            
            val_31 = 0;
            typeof(System.String[]).__il2cppRuntimeField_30 = " ";
            val_21 = (1152921504608288767 < 1) ? (null) : (val_26);
            typeof(System.String[]).__il2cppRuntimeField_38 = null;
            if(1152921504608288767 >= 1)
            {
                    val_32 = ", ";
            }
            else
            {
                    val_33 = null;
                val_33 = null;
                val_32 = System.String.Empty;
                if(val_21 == 0)
            {
                goto label_74;
            }
            
            }
            
            label_74:
            typeof(System.String[]).__il2cppRuntimeField_40 = val_32;
            string val_17 = +0;
            goto label_73;
            label_37:
            val_22.Dispose();
            goto label_84;
            label_16:
            val_34 = 0;
            return (bool)val_34;
            label_24:
            UnityEngine.GUILayout.EndScrollView();
            UnityEngine.GUILayout.EndArea();
            val_34 = 1;
            return (bool)val_34;
        }
        private void drawLog(UnityEngine.Rect rect)
        {
            var val_6;
            var val_9;
            float val_16;
            var val_17;
            var val_20;
            var val_21;
            var val_22;
            val_16 = rect.m_Height;
            val_17 = null;
            val_17 = null;
            UnityEngine.GUI.Box(position:  new UnityEngine.Rect() {m_XMin = rect.m_XMin, m_YMin = rect.m_YMin, m_Width = rect.m_Width, m_Height = val_16}, text:  0);
            UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = rect.m_XMin, m_YMin = rect.m_YMin, m_Width = rect.m_Width, m_Height = val_16});
            if(this.autocompleteWindowIsOn != true)
            {
                    val_16 = this.logScrollPos;
                UnityEngine.Vector2 val_1 = UnityEngine.GUILayout.BeginScrollView(scrollPosition:  new UnityEngine.Vector2() {x = val_16, y = rect.m_Width}, options:  0);
                this.logScrollPos = val_1;
                mem[1152921511070320632] = val_1.y;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_3 = TzarGames.Common.Console.LogHash.GetEnumerator();
            label_15:
            if((0 & 1) == 0)
            {
                goto label_9;
            }
            
            GooglePlayGames.BasicApi.Nearby.EndpointDetails val_7 = val_6.RemoteEndpoint;
            UnityEngine.GUILayout.Label(text:  0, options:  val_9.InitializationCallback);
            goto label_15;
            label_9:
            val_20 = 1152921504891777024;
            val_21 = 0;
            val_22 = 1;
            val_6.Dispose();
            if(this.autocompleteWindowIsOn != true)
            {
                    UnityEngine.GUILayout.EndScrollView();
            }
            
            UnityEngine.GUILayout.EndArea();
            if(this.lastLogLen == TzarGames.Common.Console.LogHash.Count)
            {
                    return;
            }
            
            int val_14 = TzarGames.Common.Console.LogHash.Count;
            this.lastLogLen = val_14;
            mem[1152921511070320632] = (float)val_14 * 50;
        }
        private void drawHelp(UnityEngine.Rect rect)
        {
            null = null;
            UnityEngine.GUI.Box(position:  new UnityEngine.Rect() {m_XMin = rect.m_XMin, m_YMin = rect.m_YMin, m_Width = rect.m_Width, m_Height = rect.m_Height}, text:  0);
            UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = rect.m_XMin, m_YMin = rect.m_YMin, m_Width = rect.m_Width, m_Height = rect.m_Height});
            UnityEngine.Vector2 val_1 = UnityEngine.GUILayout.BeginScrollView(scrollPosition:  new UnityEngine.Vector2() {x = this.helpScrollPos, y = rect.m_Width}, options:  0);
            this.helpScrollPos = val_1;
            mem[1152921511070466224] = val_1.y;
            UnityEngine.GUILayout.Label(text:  0, options:  "Help");
            UnityEngine.GUILayout.Space(pixels:  50f);
            UnityEngine.GUILayout.Label(text:  0, options:  "Control keys:");
            UnityEngine.GUILayout.Space(pixels:  20f);
            UnityEngine.GUILayout.Label(text:  0, options:  "Pause - open/close console");
            UnityEngine.GUILayout.Label(text:  0, options:  "Enter - execute command");
            UnityEngine.GUILayout.Label(text:  0, options:  "Tab - autocomplete command");
            UnityEngine.GUILayout.Label(text:  0, options:  "Esc - erase command text field or close the console");
            UnityEngine.GUILayout.Label(text:  0, options:  "Up/Down arrows - select next command");
            UnityEngine.GUILayout.EndScrollView();
            UnityEngine.GUILayout.EndArea();
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator changeAutocompleteWindowStateFlag(bool on)
        {
            if(null != 0)
            {
                    typeof(ConsoleGUI.<changeAutocompleteWindowStateFlag>c__Iterator0).__il2cppRuntimeField_10 = on;
            }
            else
            {
                    mem[16] = on;
            }
            
            typeof(ConsoleGUI.<changeAutocompleteWindowStateFlag>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void consoleWindowFunc(int windowID)
        {
            var val_23;
            float val_24;
            float val_25;
            float val_26;
            var val_27;
            0.startFloat = 0f;
            float val_24 = 0f;
            val_23 = null;
            val_23 = null;
            float val_23 = val_24;
            val_24 = 0f;
            UnityEngine.GUI.Box(position:  new UnityEngine.Rect() {m_XMin = val_24, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  System.String.Empty);
            val_23 = val_23 + (-10f);
            float val_1 = val_23 + (-100f);
            val_24 = val_23 + (-50f);
            0.startFloat = 5f;
            float val_2 = UnityEngine.Mathf.Max(a:  0f, b:  val_1);
            val_25 = 0f;
            val_26 = val_24;
            float val_3 = UnityEngine.Mathf.Max(a:  val_25, b:  val_26);
            if(this.drawMode == 1)
            {
                goto label_7;
            }
            
            if(this.drawMode != 0)
            {
                goto label_9;
            }
            
            val_25 = 0f;
            val_26 = 0f;
            val_24 = 0f;
            this.drawLog(rect:  new UnityEngine.Rect() {m_XMin = val_25, m_YMin = val_26, m_Width = 0f, m_Height = val_24});
            goto label_9;
            label_7:
            val_25 = 0f;
            val_26 = 0f;
            val_24 = 0f;
            this.drawHelp(rect:  new UnityEngine.Rect() {m_XMin = val_25, m_YMin = val_26, m_Width = 0f, m_Height = val_24});
            label_9:
            val_25 = val_25 + val_25;
            float val_27 = 25f;
            if((this.currentAutocompleteResult != null) && (this.currentAutocompleteResult.Length >= 1))
            {
                    if((this.currentAutocompleteResult[0].ToLower().StartsWith(value:  this.inputText.ToLower())) != false)
            {
                    string val_8 = this.currentAutocompleteResult[0].Remove(startIndex:  0, count:  this.inputText.Length);
                string val_9 = 0 + this.inputText;
                val_27 = val_27 + 3f;
                0.startFloat = val_27;
                float val_28 = 0f;
                val_24 = 0f;
                UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0);
                val_26 = -3f;
                val_28 = val_28 + val_26;
                0.startFloat = val_28;
            }
            
            }
            
            UnityEngine.GUI.SetNextControlName(name:  0);
            string val_10 = UnityEngine.GUI.TextField(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0);
            if(this.pendingFocusSet != false)
            {
                    this.pendingFocusSet = false;
                UnityEngine.GUI.FocusControl(name:  0);
            }
            
            if((this.regularExpression.IsMatch(input:  val_10)) == false)
            {
                goto label_30;
            }
            
            if((val_10.IndexOfAny(anyOf:  this.newLine)) == 1)
            {
                goto label_32;
            }
            
            this.executeCommand(command:  this.inputText);
            goto label_36;
            label_30:
            UnityEngine.Debug.Log(message:  0);
            goto label_36;
            label_32:
            this.inputText = val_10;
            label_36:
            float val_29 = this.autocompleteWindowHeight;
            val_29 = val_29 - val_29;
            bool val_13 = this.drawAutoCompleteWindow(rect:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
            var val_14 = (this.autocompleteWindowIsOn == true) ? 1 : 0;
            val_14 = val_13 ^ val_14;
            if(val_14 != false)
            {
                    this.StopCoroutine(methodName:  "changeAutocompleteWindowStateFlag");
                UnityEngine.Coroutine val_17 = this.StartCoroutine(routine:  this.changeAutocompleteWindowStateFlag(on:  val_13));
            }
            
            val_1 = val_1 + 5f;
            0.startFloat = val_1;
            val_27 = null;
            val_27 = null;
            UnityEngine.GUI.Box(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0);
            UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
            typeof(System.String[]).__il2cppRuntimeField_20 = "Log";
            typeof(System.String[]).__il2cppRuntimeField_28 = "Help";
            this.drawMode = UnityEngine.GUILayout.SelectionGrid(selected:  0, texts:  this.drawMode, xCount:  412370080, options:  1);
            UnityEngine.GUILayout.EndArea();
            0.startFloat = val_1;
            float val_19 = val_24 + 20f;
            if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
            {
                    this.executeCommand(command:  this.inputText);
            }
            
            UnityEngine.GUI.DragWindow(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
            if((System.String.op_Inequality(a:  0, b:  this.lastInputText)) == false)
            {
                    return;
            }
            
            this.lastInputText = this.inputText;
            UnityEngine.Vector2 val_22 = UnityEngine.Vector2.zero;
            this.autocompleteScrollPos = val_22;
            mem[1152921511070891416] = val_22.y;
        }
        private void initStyles()
        {
            if(this.logBackgroundStyle != null)
            {
                    return;
            }
            
            this.logBackgroundStyle = new UnityEngine.GUIStyle(other:  UnityEngine.GUI.skin.box);
            this = normal;
            this.background = 0.MakeTex(width:  16, height:  16, col:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
        }
        private UnityEngine.Texture2D MakeTex(int width, int height, UnityEngine.Color col)
        {
            var val_4;
            int val_1 = height * width;
            val_4 = 0;
            goto label_1;
            label_5:
            var val_2 = null + ((X23) << 4);
            val_4 = 1;
            mem2[0] = col.r;
            mem2[0] = col.g;
            mem2[0] = col.b;
            mem2[0] = col.a;
            label_1:
            if(null != null)
            {
                goto label_5;
            }
            
            goto label_5;
        }
    
    }

}
