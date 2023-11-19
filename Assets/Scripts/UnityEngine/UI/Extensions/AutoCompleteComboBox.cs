using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    public class AutoCompleteComboBox : MonoBehaviour
    {
        // Fields
        public UnityEngine.Color disabledTextColor;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.UI.Extensions.DropDownListItem <SelectedItem>k__BackingField;
        public System.Collections.Generic.List<string> AvailableOptions;
        public System.Action<int> OnSelectionChanged;
        private bool _isPanelActive;
        private bool _hasDrawnOnce;
        private UnityEngine.UI.InputField _mainInput;
        private UnityEngine.RectTransform _inputRT;
        private UnityEngine.RectTransform _rectTransform;
        private UnityEngine.RectTransform _overlayRT;
        private UnityEngine.RectTransform _scrollPanelRT;
        private UnityEngine.RectTransform _scrollBarRT;
        private UnityEngine.RectTransform _slidingAreaRT;
        private UnityEngine.RectTransform _itemsPanelRT;
        private UnityEngine.Canvas _canvas;
        private UnityEngine.RectTransform _canvasRT;
        private UnityEngine.UI.ScrollRect _scrollRect;
        private System.Collections.Generic.List<string> _panelItems;
        private System.Collections.Generic.List<string> _prunedPanelItems;
        private System.Collections.Generic.Dictionary<string, UnityEngine.GameObject> panelObjects;
        private UnityEngine.GameObject itemTemplate;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private string <Text>k__BackingField;
        [UnityEngine.SerializeField]
        private float _scrollBarWidth;
        [UnityEngine.SerializeField]
        private int _itemsToDisplay;
        
        // Properties
        public UnityEngine.UI.Extensions.DropDownListItem SelectedItem { get; set; }
        public string Text { get; set; }
        public float ScrollBarWidth { get; set; }
        public int ItemsToDisplay { get; set; }
        
        // Methods
        public AutoCompleteComboBox()
        {
            this._scrollBarWidth = 20f;
        }
        public UnityEngine.UI.Extensions.DropDownListItem get_SelectedItem()
        {
            return (UnityEngine.UI.Extensions.DropDownListItem)this.<SelectedItem>k__BackingField;
        }
        private void set_SelectedItem(UnityEngine.UI.Extensions.DropDownListItem value)
        {
            this.<SelectedItem>k__BackingField = value;
        }
        public string get_Text()
        {
            return (string)this.<Text>k__BackingField;
        }
        private void set_Text(string value)
        {
            this.<Text>k__BackingField = value;
        }
        public float get_ScrollBarWidth()
        {
            return (float)this._scrollBarWidth;
        }
        public void set_ScrollBarWidth(float value)
        {
            this._scrollBarWidth = value;
            this.RedrawPanel();
        }
        public int get_ItemsToDisplay()
        {
            return (int)this._itemsToDisplay;
        }
        public void set_ItemsToDisplay(int value)
        {
            this._itemsToDisplay = value;
            this.RedrawPanel();
        }
        public void Awake()
        {
            bool val_1 = this.Initialize();
        }
        private bool Initialize()
        {
            UnityEngine.RectTransform val_1 = this.GetComponent<UnityEngine.RectTransform>();
            this._rectTransform = val_1;
            UnityEngine.RectTransform val_3 = val_1.Find(name:  "InputField").GetComponent<UnityEngine.RectTransform>();
            this._inputRT = val_3;
            this._mainInput = val_3.GetComponent<UnityEngine.UI.InputField>();
            UnityEngine.RectTransform val_6 = this._rectTransform.Find(name:  "Overlay").GetComponent<UnityEngine.RectTransform>();
            this._overlayRT = val_6;
            val_6.gameObject.SetActive(value:  false);
            UnityEngine.RectTransform val_9 = this._overlayRT.Find(name:  "ScrollPanel").GetComponent<UnityEngine.RectTransform>();
            this._scrollPanelRT = val_9;
            UnityEngine.RectTransform val_11 = val_9.Find(name:  "Scrollbar").GetComponent<UnityEngine.RectTransform>();
            this._scrollBarRT = val_11;
            this._slidingAreaRT = val_11.Find(name:  "SlidingArea").GetComponent<UnityEngine.RectTransform>();
            this._itemsPanelRT = this._scrollPanelRT.Find(name:  "Items").GetComponent<UnityEngine.RectTransform>();
            UnityEngine.Canvas val_16 = this.GetComponentInParent<UnityEngine.Canvas>();
            this._canvas = val_16;
            this._canvasRT = val_16.GetComponent<UnityEngine.RectTransform>();
            UnityEngine.UI.ScrollRect val_18 = this._scrollPanelRT.GetComponent<UnityEngine.UI.ScrollRect>();
            this._scrollRect = val_18;
            UnityEngine.Vector2 val_19 = this._rectTransform.sizeDelta;
            float val_25 = 0.5f;
            val_25 = val_19.y * val_25;
            val_18.scrollSensitivity = val_25;
            this._scrollRect.movementType = 2;
            this._scrollRect.content = this._itemsPanelRT;
            UnityEngine.GameObject val_21 = this._rectTransform.Find(name:  "ItemTemplate").gameObject;
            this.itemTemplate = val_21;
            val_21.SetActive(value:  false);
            this.panelObjects = new System.Collections.Generic.Dictionary<System.String, UnityEngine.GameObject>();
            this._prunedPanelItems = new System.Collections.Generic.List<System.String>();
            this._panelItems = System.Linq.Enumerable.ToList<UnityEngine.Component>(source:  0);
            this.RebuildPanel();
            return true;
        }
        private void RebuildPanel()
        {
            int val_3;
            var val_35;
            var val_36;
            var val_37;
            int val_38;
            this._panelItems.Clear();
            List.Enumerator<T> val_1 = this.AvailableOptions.GetEnumerator();
            label_6:
            if((0 & 1) == 0)
            {
                goto label_3;
            }
            
            this._panelItems.Add(item:  val_3.InitializationCallback.ToLower());
            goto label_6;
            label_3:
            val_35 = 0;
            val_36 = 1;
            val_3.Dispose();
            this._panelItems.Sort();
            this._prunedPanelItems.Clear();
            System.Collections.Generic.List<UnityEngine.GameObject> val_7 = new System.Collections.Generic.List<UnityEngine.GameObject>(collection:  this.panelObjects.Values);
            this.panelObjects.Clear();
            val_37 = 0;
            goto label_14;
            label_26:
            Add(item:  this.panelObjects);
            val_37 = 1;
            label_14:
            if(Count >= this.AvailableOptions.Count)
            {
                goto label_17;
            }
            
            Unitycoding.UIWidgets.RadialMenuItem val_10 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
            val_3 = val_37;
            string val_11 = 0 + "Item ";
            if(val_10 != null)
            {
                    val_10.name = val_11;
            }
            else
            {
                    0.name = val_11;
            }
            
            val_10.transform.SetParent(parent:  this._itemsPanelRT, worldPositionStays:  false);
            if(null != 0)
            {
                goto label_26;
            }
            
            goto label_26;
            label_17:
            val_38 = 0;
            goto label_27;
            label_71:
            val_38 = 1;
            label_27:
            if(val_38 >= Count)
            {
                    return;
            }
            
            Item[1].SetActive(value:  (val_38 <= this.AvailableOptions.Count) ? 1 : 0);
            if(val_38 >= this.AvailableOptions.Count)
            {
                goto label_71;
            }
            
            typeof(AutoCompleteComboBox.<RebuildPanel>c__AnonStorey0).__il2cppRuntimeField_18 = this;
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Item ";
            val_3 = val_38;
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_3;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " ";
            typeof(System.Object[]).__il2cppRuntimeField_38 = this._panelItems.Item[1];
            Item[1].name = +0;
            UnityEngine.UI.Text val_25 = Item[1].transform.Find(name:  "Text").GetComponent<UnityEngine.UI.Text>();
            string val_26 = this._panelItems.Item[1];
            UnityEngine.UI.Button val_28 = Item[1].GetComponent<UnityEngine.UI.Button>();
            val_28.onClick.RemoveAllListeners();
            typeof(AutoCompleteComboBox.<RebuildPanel>c__AnonStorey0).__il2cppRuntimeField_10 = this._panelItems.Item[1];
            val_28.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  new System.Object(), method:  System.Void AutoCompleteComboBox.<RebuildPanel>c__AnonStorey0::<>m__0()));
            this.panelObjects.set_Item(key:  this._panelItems.Item[1], value:  Item[1]);
            goto label_71;
        }
        private void OnItemClicked(string item)
        {
            this.<Text>k__BackingField = item;
            this._mainInput.text = item;
            this.ToggleDropdownPanel(directClick:  true);
        }
        private void RedrawPanel()
        {
            UnityEngine.RectTransform val_25;
            float val_26;
            UnityEngine.RectTransform val_27;
            UnityEngine.RectTransform val_28;
            UnityEngine.RectTransform val_29;
            float val_30;
            float val_31;
            val_25 = this;
            if(this._panelItems.Count > this._itemsToDisplay)
            {
                    val_26 = this._scrollBarWidth;
            }
            else
            {
                    val_26 = 0f;
            }
            
            val_27 = this._panelItems.Count;
            this._scrollBarRT.gameObject.SetActive(value:  (val_27 > this._itemsToDisplay) ? 1 : 0);
            if(this._hasDrawnOnce == false)
            {
                goto label_7;
            }
            
            val_28 = val_25;
            UnityEngine.Vector2 val_5 = this._rectTransform.sizeDelta;
            val_29 = val_25;
            val_30 = val_5.y;
            UnityEngine.Vector2 val_6 = this._inputRT.sizeDelta;
            val_31 = val_30;
            if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = val_5.x, y = val_31}, rhs:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y})) == false)
            {
                goto label_12;
            }
            
            goto label_13;
            label_7:
            val_29 = this._inputRT;
            val_28 = this._rectTransform;
            label_13:
            this._hasDrawnOnce = true;
            UnityEngine.Vector2 val_8 = this._rectTransform.sizeDelta;
            this._inputRT.SetSizeWithCurrentAnchors(axis:  0, size:  val_8.x);
            UnityEngine.Vector2 val_9 = mem[this._rectTransform].sizeDelta;
            mem[this._inputRT].SetSizeWithCurrentAnchors(axis:  1, size:  val_9.y);
            this._scrollPanelRT.SetParent(parent:  this.transform, worldPositionStays:  true);
            UnityEngine.Vector2 val_11 = this._rectTransform.sizeDelta;
            CinemachineFreeLook.Orbit val_12 = new CinemachineFreeLook.Orbit(h:  0f, r:  -val_11.y);
            val_31 = val_12.m_Radius;
            this._scrollPanelRT.anchoredPosition = new UnityEngine.Vector2() {x = val_12.m_Height, y = val_31};
            this._overlayRT.SetParent(parent:  this._canvas.transform, worldPositionStays:  false);
            UnityEngine.Vector2 val_14 = this._canvasRT.sizeDelta;
            this._overlayRT.SetSizeWithCurrentAnchors(axis:  0, size:  val_14.x);
            UnityEngine.Vector2 val_15 = this._canvasRT.sizeDelta;
            this._overlayRT.SetSizeWithCurrentAnchors(axis:  1, size:  val_15.y);
            this._overlayRT.SetParent(parent:  this.transform, worldPositionStays:  true);
            val_27 = this._scrollPanelRT;
            val_27.SetParent(parent:  this._overlayRT, worldPositionStays:  true);
            label_12:
            if(this._panelItems.Count < 1)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_18 = this._rectTransform.sizeDelta;
            float val_25 = val_18.y;
            int val_19 = this._panelItems.Count;
            val_25 = val_25 * ((float)UnityEngine.Mathf.Min(a:  0, b:  this._itemsToDisplay));
            this._scrollPanelRT.SetSizeWithCurrentAnchors(axis:  1, size:  val_25);
            UnityEngine.Vector2 val_21 = this._rectTransform.sizeDelta;
            this._scrollPanelRT.SetSizeWithCurrentAnchors(axis:  0, size:  val_21.x);
            val_27 = this._scrollPanelRT;
            UnityEngine.Vector2 val_22 = val_27.sizeDelta;
            val_30 = val_22.x;
            val_22.x = val_30 - val_26;
            val_22.x = val_22.x + (-5f);
            this._itemsPanelRT.SetSizeWithCurrentAnchors(axis:  0, size:  val_22.x);
            CinemachineFreeLook.Orbit val_23 = new CinemachineFreeLook.Orbit(h:  5f, r:  0f);
            this._itemsPanelRT.anchoredPosition = new UnityEngine.Vector2() {x = val_23.m_Height, y = val_23.m_Radius};
            this._scrollBarRT.SetSizeWithCurrentAnchors(axis:  0, size:  val_26);
            this._scrollBarRT.SetSizeWithCurrentAnchors(axis:  1, size:  val_25);
            this._slidingAreaRT.SetSizeWithCurrentAnchors(axis:  0, size:  0f);
            val_25 = this._slidingAreaRT;
            UnityEngine.Vector2 val_24 = this._scrollBarRT.sizeDelta;
            val_26 = val_24.x;
            val_24.x = val_25 - val_26;
            val_25.SetSizeWithCurrentAnchors(axis:  1, size:  val_24.x);
        }
        public void OnValueChanged(string currText)
        {
            var val_2;
            this.<Text>k__BackingField = currText;
            this.PruneItems(currText:  currText);
            this.RedrawPanel();
            if(this._panelItems.Count == 0)
            {
                goto label_2;
            }
            
            if(this._isPanelActive == false)
            {
                goto label_3;
            }
            
            return;
            label_2:
            this._isPanelActive = true;
            val_2 = 0;
            goto label_4;
            label_3:
            val_2 = 0;
            label_4:
            this.ToggleDropdownPanel(directClick:  false);
        }
        public void ToggleDropdownPanel(bool directClick)
        {
            bool val_4 = this._isPanelActive;
            val_4 = val_4 ^ 1;
            this._isPanelActive = val_4;
            this._overlayRT.gameObject.SetActive(value:  (this._isPanelActive == true) ? 1 : 0);
            if(this._isPanelActive == false)
            {
                    return;
            }
            
            this.transform.SetAsLastSibling();
        }
        private void PruneItems(string currText)
        {
            var val_9;
            object val_1 = new System.Object();
            typeof(AutoCompleteComboBox.<PruneItems>c__AnonStorey1).__il2cppRuntimeField_10 = currText;
            System.Func<System.String, System.Boolean> val_2 = new System.Func<System.String, System.Boolean>(object:  val_1, method:  System.Boolean AutoCompleteComboBox.<PruneItems>c__AnonStorey1::<>m__0(string x));
            System.Collections.Generic.IEnumerable<TSource> val_3 = System.Linq.Enumerable.Where<UnityEngine.UI.ExtensionsToggle>(source:  0, predicate:  this._panelItems);
            System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<UnityEngine.Component>(source:  0);
            System.Collections.Generic.IEnumerable<TSource> val_5 = System.Linq.Enumerable.Except<System.String>(first:  0, second:  this._panelItems);
            List.Enumerator<T> val_7 = System.Linq.Enumerable.ToList<UnityEngine.Component>(source:  0).GetEnumerator();
            label_8:
            if((0 & 1) == 0)
            {
                goto label_3;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_10 = val_9.InitializationCallback;
            this.panelObjects.Item[val_10].SetActive(value:  false);
            bool val_12 = this._panelItems.Remove(item:  val_10);
            this._prunedPanelItems.Add(item:  val_10);
            goto label_8;
            label_3:
            val_9.Dispose();
            System.Func<System.String, System.Boolean> val_13 = new System.Func<System.String, System.Boolean>(object:  val_1, method:  System.Boolean AutoCompleteComboBox.<PruneItems>c__AnonStorey1::<>m__1(string x));
            System.Collections.Generic.IEnumerable<TSource> val_14 = System.Linq.Enumerable.Where<UnityEngine.UI.ExtensionsToggle>(source:  0, predicate:  this._prunedPanelItems);
            List.Enumerator<T> val_16 = System.Linq.Enumerable.ToList<UnityEngine.Component>(source:  0).GetEnumerator();
            label_17:
            if((0 & 1) == 0)
            {
                goto label_20;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_17 = 0.InitializationCallback;
            this.panelObjects.Item[val_17].SetActive(value:  true);
            this._panelItems.Add(item:  val_17);
            goto label_17;
            label_20:
            0.Dispose();
            if((0 & 1) != 0)
            {
                    return;
            }
            
            if((this._prunedPanelItems.Remove(item:  val_17)) == false)
            {
                    return;
            }
        
        }
    
    }

}
