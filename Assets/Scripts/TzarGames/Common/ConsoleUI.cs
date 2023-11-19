using UnityEngine;

namespace TzarGames.Common
{
    public class ConsoleUI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private bool showOnStart;
        [UnityEngine.SerializeField]
        private UnityEngine.KeyCode[] toggleKeys;
        [UnityEngine.SerializeField]
        private int touchesToOpen;
        [UnityEngine.SerializeField]
        private bool freezeTimeOnOpen;
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform consoleMainWindow;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject consoleItemPrefab;
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform logContainer;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.InputFieldUI commandInput;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.ScrollRect autocompleteScrollRect;
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform autoCompleteContaner;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject autocompleteItemPrefab;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent OnConsoleOpen;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent OnConsoleClose;
        private bool pendingTouchRelease;
        private float previousTimeScale;
        private System.Collections.Generic.Dictionary<int, UnityEngine.GameObject> logObjectHashTable;
        private string firstAutocompleteItem;
        
        // Properties
        public bool IsConsoleShown { get; }
        
        // Methods
        public ConsoleUI()
        {
            this.touchesToOpen = 4;
            this.previousTimeScale = 1f;
            this.freezeTimeOnOpen = true;
            this.logObjectHashTable = new System.Collections.Generic.Dictionary<System.Int32, UnityEngine.GameObject>();
        }
        public bool get_IsConsoleShown()
        {
            UnityEngine.GameObject val_1 = this.consoleMainWindow.gameObject;
            if(val_1 != null)
            {
                    return val_1.activeInHierarchy;
            }
            
            return val_1.activeInHierarchy;
        }
        private void Awake()
        {
            TzarGames.Common.Console.ForceInit();
            this.ShowConsole(show:  this.showOnStart);
        }
        private void OnDestroy()
        {
            this.ClearLogs();
        }
        private void Update()
        {
            this.processInput();
            if(this.IsConsoleShown == false)
            {
                    return;
            }
            
            this.processLogs();
        }
        private void processLogs()
        {
            var val_4;
            var val_18;
            System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.KeyValuePair<System.String, System.Int32>> val_1 = TzarGames.Common.Console.LogHash;
            System.Collections.Generic.List<System.Int32> val_2 = new System.Collections.Generic.List<System.Int32>();
            Dictionary.Enumerator<TKey, TValue> val_3 = this.logObjectHashTable.GetEnumerator();
            label_10:
            if((0 & 1) == 0)
            {
                goto label_4;
            }
            
            UnityEngine.Playables.PlayableHandle val_6 = val_4.GetHandle();
            if((val_1.ContainsKey(key:  val_6.m_Handle.GetHashCode())) == true)
            {
                goto label_10;
            }
            
            UnityEngine.Object.Destroy(obj:  0);
            Add(item:  val_6.m_Handle.GetHashCode());
            goto label_10;
            label_4:
            val_4.Dispose();
            List.Enumerator<T> val_11 = GetEnumerator();
            label_16:
            if((0 & 1) == 0)
            {
                goto label_14;
            }
            
            bool val_13 = this.logObjectHashTable.Remove(key:  val_4.Status);
            goto label_16;
            label_14:
            val_4.Dispose();
            Dictionary.Enumerator<TKey, TValue> val_14 = val_1.GetEnumerator();
            label_35:
            if((0 & 1) == 0)
            {
                goto label_38;
            }
            
            GooglePlayGames.BasicApi.Nearby.EndpointDetails val_16 = val_4.RemoteEndpoint;
            if((this.logObjectHashTable.TryGetValue(key:  val_18.Status, value: out  0)) != true)
            {
                    Unitycoding.UIWidgets.RadialMenuItem val_23 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
                val_23.GetComponent<UnityEngine.RectTransform>().SetParent(parent:  this.logContainer);
                this.logObjectHashTable.Add(key:  val_18.Status, value:  val_23);
            }
            
            TzarGames.Common.UI.TextUI val_26 = val_23.GetComponent<TzarGames.Common.UI.TextUI>();
            if((-2123470696) <= 1)
            {
                goto label_29;
            }
            
            val_26.text = System.String.Format(format:  0, arg0:  "{0} <color=#ffffaaff>({1})</color>", arg1:  val_18.InitializationCallback);
            goto label_35;
            label_29:
            val_26.text = val_18.InitializationCallback;
            goto label_35;
            label_38:
            val_4.Dispose();
            if((0 & 1) != 0)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
        
        }
        private void processInput()
        {
            UnityEngine.KeyCode[] val_13;
            var val_14;
            val_13 = this.toggleKeys;
            val_14 = 0;
            label_6:
            if(val_14 >= this.toggleKeys.Length)
            {
                goto label_2;
            }
            
            UnityEngine.KeyCode val_13 = val_13[0];
            val_14 = val_14 + 1;
            if((UnityEngine.Input.GetKeyDown(key:  0)) == false)
            {
                goto label_6;
            }
            
            this.ShowConsole(show:  (~this.IsConsoleShown) & 1);
            label_2:
            if(UnityEngine.Input.touchCount >= this.touchesToOpen)
            {
                goto label_9;
            }
            
            if(this.pendingTouchRelease == false)
            {
                goto label_11;
            }
            
            this.ShowConsole(show:  (~this.IsConsoleShown) & 1);
            this.pendingTouchRelease = false;
            goto label_11;
            label_9:
            this.pendingTouchRelease = true;
            label_11:
            if((UnityEngine.Input.GetKeyDown(key:  0)) != false)
            {
                    val_13 = this.firstAutocompleteItem;
                if(val_13 != null)
            {
                    this.commandInput.Text = 0 + val_13;
                val_13 = this.commandInput.Text.Length;
                this.commandInput.CaretPosition = val_13;
            }
            
            }
            
            if((UnityEngine.Input.GetKeyDown(key:  0)) != false)
            {
                    this.commandInput.ActivateInputField();
            }
            
            if((UnityEngine.Input.GetKeyDown(key:  0)) == false)
            {
                    return;
            }
            
            this.OnSubmit();
        }
        private void setFocus()
        {
            this.commandInput.ActivateInputField();
        }
        public void ShowConsole(bool show)
        {
            TzarGames.Common.UI.InputFieldUI val_8;
            object val_9;
            UnityEngine.Events.UnityEvent val_10;
            this.consoleMainWindow.gameObject.SetActive(value:  show);
            this.showAutocompleteWindow(show:  false);
            if(show != false)
            {
                    if(UnityEngine.TouchScreenKeyboard.isSupported != false)
            {
                    UnityEngine.TouchScreenKeyboard val_5 = UnityEngine.TouchScreenKeyboard.Open(text:  0, keyboardType:  this.commandInput.Text, autocorrection:  true, multiline:  false, secure:  false, alert:  false);
            }
            
            }
            
            val_8 = this.commandInput;
            val_8.ActivateInputField();
            if(this.freezeTimeOnOpen != false)
            {
                    if(show != false)
            {
                    this.previousTimeScale = UnityEngine.Time.timeScale;
                UnityEngine.Time.timeScale = 0f;
                val_9 = 0;
            }
            else
            {
                    UnityEngine.Time.timeScale = this.previousTimeScale;
                val_8 = 0 + "Time scale has been reverted to " + this.previousTimeScale;
                val_9 = 0;
            }
            
                UnityEngine.Debug.Log(message:  val_9);
            }
            
            if(show == false)
            {
                goto label_16;
            }
            
            val_10 = this.OnConsoleOpen;
            if(val_10 != null)
            {
                goto label_19;
            }
            
            goto label_18;
            label_16:
            val_10 = this.OnConsoleClose;
            if(val_10 != null)
            {
                goto label_19;
            }
            
            label_18:
            label_19:
            val_10.Invoke();
        }
        private void showAutocompleteWindow(bool show)
        {
            var val_6;
            this.autocompleteScrollRect.gameObject.SetActive(value:  show);
            val_6 = 0;
            goto label_3;
            label_10:
            UnityEngine.Object.Destroy(obj:  0);
            val_6 = 1;
            label_3:
            if(val_6 >= this.autoCompleteContaner.childCount)
            {
                    return;
            }
            
            UnityEngine.GameObject val_5 = this.autoCompleteContaner.GetChild(index:  1).gameObject;
            goto label_10;
        }
        private void onAutocompleteSelect(TzarGames.Common.ConsoleAutocompleteItem autocompleteItem)
        {
            this.commandInput.Text = 0 + autocompleteItem.<MethodName>k__BackingField(autocompleteItem.<MethodName>k__BackingField);
            this.commandInput.ActivateInputField();
        }
        public void OnInputChanged(string inputText)
        {
            var val_8;
            System.Char[] val_16;
            string val_17;
            var val_18;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    this.showAutocompleteWindow(show:  false);
                return;
            }
            
            this.showAutocompleteWindow(show:  true);
            val_16 = null;
            typeof(System.Char[]).__il2cppRuntimeField_20 = 32;
            string val_3 = inputText.Split(separator:  val_16)[0].Trim();
            val_17 = null;
            System.String[] val_4 = TzarGames.Common.Console.GetAutocompleteResult(methodName:  val_17);
            if(val_4.Length < 1)
            {
                goto label_14;
            }
            
            val_18 = 0;
            this.firstAutocompleteItem = val_4[0];
            goto label_15;
            label_34:
            val_18 = 1;
            label_15:
            if(val_18 >= val_4.Length)
            {
                goto label_17;
            }
            
            List.Enumerator<T> val_6 = TzarGames.Common.Console.GetCommandParameters(command:  null).GetEnumerator();
            label_31:
            if((0 & 1) == 0)
            {
                goto label_22;
            }
            
            Unitycoding.UIWidgets.RadialMenuItem val_10 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
            val_10.GetComponent<UnityEngine.RectTransform>().SetParent(parent:  this.autoCompleteContaner);
            val_10.GetComponent<TzarGames.Common.ConsoleAutocompleteItem>().SetMethodData(methodName:  val_4[1], parameters:  val_8.InitializationCallback);
            UnityEngine.Events.UnityAction<TzarGames.Common.ConsoleAutocompleteItem> val_13 = new UnityEngine.Events.UnityAction<TzarGames.Common.ConsoleAutocompleteItem>(object:  this, method:  System.Void TzarGames.Common.ConsoleUI::onAutocompleteSelect(TzarGames.Common.ConsoleAutocompleteItem autocompleteItem));
            val_12.OnClickEvent.AddListener(call:  null);
            goto label_31;
            label_22:
            val_8.Dispose();
            goto label_34;
            label_17:
            UnityEngine.Coroutine val_15 = this.StartCoroutine(routine:  this.scrollRoutine());
            return;
            label_14:
            this.firstAutocompleteItem = 0;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator scrollRoutine()
        {
            typeof(ConsoleUI.<scrollRoutine>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public void OnSubmit()
        {
            string val_2;
            var val_3;
            string val_1 = this.commandInput.Text;
            val_2 = null;
            TzarGames.Common.Console.Execute(command:  val_2);
            val_3 = null;
            val_3 = null;
            this.commandInput.Text = System.String.Empty;
            this.commandInput.ActivateInputField();
        }
        public void ClearLogs()
        {
            var val_3;
            var val_4;
            TzarGames.Common.Console.ClearLogs();
            Dictionary.Enumerator<TKey, TValue> val_1 = this.logObjectHashTable.GetEnumerator();
            label_7:
            if((0 & 1) == 0)
            {
                goto label_4;
            }
            
            UnityEngine.Playables.PlayableHandle val_2 = 0.GetHandle();
            UnityEngine.Object.Destroy(obj:  0);
            goto label_7;
            label_4:
            val_3 = 0;
            val_4 = 1;
            0.Dispose();
            this.logObjectHashTable.Clear();
        }
    
    }

}
