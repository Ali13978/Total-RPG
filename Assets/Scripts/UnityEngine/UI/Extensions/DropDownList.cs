using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    public class DropDownList : MonoBehaviour
    {
        // Fields
        public UnityEngine.Color disabledTextColor;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.UI.Extensions.DropDownListItem <SelectedItem>k__BackingField;
        public System.Collections.Generic.List<UnityEngine.UI.Extensions.DropDownListItem> Items;
        public System.Action<int> OnSelectionChanged;
        public bool OverrideHighlighted;
        private bool _isPanelActive;
        private bool _hasDrawnOnce;
        private UnityEngine.UI.Extensions.DropDownListButton _mainButton;
        private UnityEngine.RectTransform _rectTransform;
        private UnityEngine.RectTransform _overlayRT;
        private UnityEngine.RectTransform _scrollPanelRT;
        private UnityEngine.RectTransform _scrollBarRT;
        private UnityEngine.RectTransform _slidingAreaRT;
        private UnityEngine.RectTransform _itemsPanelRT;
        private UnityEngine.Canvas _canvas;
        private UnityEngine.RectTransform _canvasRT;
        private UnityEngine.UI.ScrollRect _scrollRect;
        private System.Collections.Generic.List<UnityEngine.UI.Extensions.DropDownListButton> _panelItems;
        private UnityEngine.GameObject _itemTemplate;
        [UnityEngine.SerializeField]
        private float _scrollBarWidth;
        private int _selectedIndex;
        [UnityEngine.SerializeField]
        private int _itemsToDisplay;
        
        // Properties
        public UnityEngine.UI.Extensions.DropDownListItem SelectedItem { get; set; }
        public float ScrollBarWidth { get; set; }
        public int ItemsToDisplay { get; set; }
        
        // Methods
        public DropDownList()
        {
            this.OverrideHighlighted = true;
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
        public void Start()
        {
            bool val_1 = this.Initialize();
        }
        private bool Initialize()
        {
            UnityEngine.RectTransform val_1 = this.GetComponent<UnityEngine.RectTransform>();
            this._rectTransform = val_1;
            UnityEngine.UI.Extensions.DropDownListButton val_4 = new UnityEngine.UI.Extensions.DropDownListButton(btnObj:  val_1.Find(name:  "MainButton").gameObject);
            this._mainButton = null;
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
            float val_23 = 0.5f;
            val_23 = val_19.y * val_23;
            val_18.scrollSensitivity = val_23;
            this._scrollRect.movementType = 2;
            this._scrollRect.content = this._itemsPanelRT;
            UnityEngine.GameObject val_21 = this._rectTransform.Find(name:  "ItemTemplate").gameObject;
            this._itemTemplate = val_21;
            val_21.SetActive(value:  false);
            this._panelItems = new System.Collections.Generic.List<UnityEngine.UI.Extensions.DropDownListButton>();
            this.RebuildPanel();
            this.RedrawPanel();
            return true;
        }
        private void RebuildPanel()
        {
            int val_31;
            var val_32;
            UnityEngine.UI.Image val_33;
            float val_34;
            float val_35;
            float val_36;
            float val_37;
            if(this.Items.Count == 0)
            {
                    return;
            }
            
            val_31 = this._panelItems.Count;
            goto label_4;
            label_16:
            X22.Add(item:  X23);
            val_31 = val_31 + 1;
            label_4:
            int val_3 = this._panelItems.Count;
            if(val_3 >= this.Items.Count)
            {
                goto label_7;
            }
            
            Unitycoding.UIWidgets.RadialMenuItem val_5 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
            string val_6 = 0 + "Item ";
            if(val_5 != null)
            {
                    val_5.name = val_6;
            }
            else
            {
                    0.name = val_6;
            }
            
            val_5.transform.SetParent(parent:  this._itemsPanelRT, worldPositionStays:  false);
            UnityEngine.UI.Extensions.DropDownListButton val_8 = new UnityEngine.UI.Extensions.DropDownListButton(btnObj:  val_5);
            if(this._panelItems != null)
            {
                goto label_16;
            }
            
            goto label_16;
            label_7:
            val_32 = 0;
            goto label_17;
            label_74:
            val_3.SetActive(value:  (val_32 < this.Items) ? 1 : 0);
            val_32 = 1;
            label_17:
            if(val_32 >= this._panelItems.Count)
            {
                    return;
            }
            
            if(val_32 < this.Items.Count)
            {
                    typeof(DropDownList.<RebuildPanel>c__AnonStorey0).__il2cppRuntimeField_20 = this;
                typeof(DropDownList.<RebuildPanel>c__AnonStorey0).__il2cppRuntimeField_18 = this.Items.Item[1];
                UnityEngine.UI.Extensions.DropDownListButton val_14 = this._panelItems.Item[1];
                if((val_13 + 32) != 0)
            {
                    UnityEngine.UI.Extensions.DropDownListButton val_15 = this._panelItems.Item[1];
                val_15.txt.color = new UnityEngine.Color() {r = this.disabledTextColor, g = V12.16B, b = V13.16B, a = V14.16B};
            }
            
                UnityEngine.UI.Extensions.DropDownListButton val_16 = this._panelItems.Item[1];
                if(0 != val_16.btnImg)
            {
                    UnityEngine.UI.Extensions.DropDownListButton val_18 = this._panelItems.Item[1];
                val_18.btnImg.sprite = 0;
            }
            
                UnityEngine.UI.Extensions.DropDownListButton val_19 = this._panelItems.Item[1];
                val_19.img.sprite = val_13 + 24;
                UnityEngine.UI.Extensions.DropDownListButton val_20 = this._panelItems.Item[1];
                val_33 = val_20.img;
                bool val_21 = UnityEngine.Object.op_Equality(x:  0, y:  val_13 + 24);
                if(val_21 != false)
            {
                    val_34 = 0f;
                val_35 = 0f;
                val_36 = 0f;
                val_37 = 0f;
            }
            else
            {
                    if((val_13 + 32) != 0)
            {
                    val_34 = 0f;
                val_35 = 0f;
                val_36 = 0f;
                val_37 = 0f;
            }
            else
            {
                    UnityEngine.Color val_23 = UnityEngine.Color.white;
                val_34 = val_23.r;
                val_35 = val_23.g;
                val_36 = val_23.b;
                val_37 = val_23.a;
            }
            
                val_33 = (val_21 != true) ? 0 : (val_33);
            }
            
                typeof(DropDownList.<RebuildPanel>c__AnonStorey0).__il2cppRuntimeField_10 = val_32;
                UnityEngine.UI.Extensions.DropDownListButton val_24 = this._panelItems.Item[1];
                val_24.btn.onClick.RemoveAllListeners();
                UnityEngine.UI.Extensions.DropDownListButton val_26 = this._panelItems.Item[1];
                val_26.btn.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  new System.Object(), method:  System.Void DropDownList.<RebuildPanel>c__AnonStorey0::<>m__0()));
            }
            
            UnityEngine.UI.Extensions.DropDownListButton val_29 = this._panelItems.Item[1];
            int val_30 = this.Items.Count;
            if(val_29.gameobject != null)
            {
                goto label_74;
            }
            
            goto label_74;
        }
        private void OnItemClicked(int indx)
        {
            string val_1 = 0 + "item " + indx;
            UnityEngine.Debug.Log(message:  0);
            if((this._selectedIndex != indx) && (this.OnSelectionChanged != null))
            {
                    this.OnSelectionChanged.Invoke(obj:  indx);
            }
            
            this._selectedIndex = indx;
            this.ToggleDropdownPanel(directClick:  true);
            this.UpdateSelected();
        }
        private void UpdateSelected()
        {
            int val_9;
            UnityEngine.UI.Extensions.DropDownListItem val_10;
            float val_11;
            float val_12;
            float val_13;
            float val_14;
            float val_15;
            var val_16;
            val_9 = this._selectedIndex;
            if((val_9 & 2147483648) != 0)
            {
                goto label_1;
            }
            
            if(val_9 >= this.Items.Count)
            {
                goto label_3;
            }
            
            val_9 = this._selectedIndex;
            val_10 = this.Items.Item[val_9];
            goto label_5;
            label_1:
            this.<SelectedItem>k__BackingField = 0;
            return;
            label_3:
            val_10 = 0;
            label_5:
            this.<SelectedItem>k__BackingField = val_10;
            if(val_10 == 0)
            {
                    return;
            }
            
            if(0 != 7254272)
            {
                    this._mainButton.img.sprite = this.<SelectedItem>k__BackingField._image;
                UnityEngine.Color val_4 = UnityEngine.Color.white;
                val_11 = val_4.r;
                val_12 = val_11;
                val_13 = val_4.g;
                val_14 = val_4.b;
                val_15 = val_4.a;
                this._mainButton.img.color = new UnityEngine.Color() {r = val_12, g = val_13, b = val_14, a = val_15};
            }
            else
            {
                    this._mainButton.img.sprite = 0;
            }
            
            val_9 = this.<SelectedItem>k__BackingField._caption;
            if(this.OverrideHighlighted == false)
            {
                    return;
            }
            
            val_16 = 0;
            val_11 = 0f;
            goto label_23;
            label_33:
            val_12 = V9.16B;
            val_13 = V10.16B;
            val_14 = V11.16B;
            val_15 = V12.16B;
            val_16 = 1;
            label_23:
            val_9 = this._itemsPanelRT;
            if(val_16 >= val_9.childCount)
            {
                    return;
            }
            
            UnityEngine.UI.Extensions.DropDownListButton val_6 = this._panelItems.Item[1];
            if(val_16 == this._selectedIndex)
            {
                    UnityEngine.UI.ColorBlock val_7 = this._mainButton.btn.colors;
                UnityEngine.Color val_8 = normalColor;
            }
            else
            {
                
            }
            
            if(val_6.btnImg != null)
            {
                goto label_33;
            }
            
            goto label_33;
        }
        private void RedrawPanel()
        {
            UnityEngine.RectTransform val_24;
            float val_25;
            UnityEngine.UI.Extensions.DropDownListButton val_26;
            float val_27;
            float val_28;
            UnityEngine.RectTransform val_29;
            val_24 = this;
            if(this.Items.Count > this._itemsToDisplay)
            {
                    val_25 = this._scrollBarWidth;
            }
            else
            {
                    val_25 = 0f;
            }
            
            if(this._hasDrawnOnce == false)
            {
                goto label_4;
            }
            
            UnityEngine.Vector2 val_2 = this._rectTransform.sizeDelta;
            val_26 = val_24;
            val_27 = val_2.y;
            UnityEngine.Vector2 val_3 = this._mainButton.rectTransform.sizeDelta;
            val_28 = val_27;
            if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = val_2.x, y = val_28}, rhs:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y})) == false)
            {
                goto label_10;
            }
            
            goto label_11;
            label_4:
            val_26 = this._mainButton;
            label_11:
            this._hasDrawnOnce = true;
            UnityEngine.Vector2 val_5 = this._rectTransform.sizeDelta;
            this._mainButton.rectTransform.SetSizeWithCurrentAnchors(axis:  0, size:  val_5.x);
            UnityEngine.Vector2 val_6 = this._rectTransform.sizeDelta;
            mem[this._mainButton] + 16.SetSizeWithCurrentAnchors(axis:  1, size:  val_6.y);
            CinemachineFreeLook.Orbit val_8 = new CinemachineFreeLook.Orbit(h:  4f, r:  0f);
            mem[this._mainButton] + 32.rectTransform.offsetMax = new UnityEngine.Vector2() {x = val_8.m_Height, y = val_8.m_Radius};
            this._scrollPanelRT.SetParent(parent:  this.transform, worldPositionStays:  true);
            UnityEngine.Vector2 val_10 = this._rectTransform.sizeDelta;
            CinemachineFreeLook.Orbit val_11 = new CinemachineFreeLook.Orbit(h:  0f, r:  -val_10.y);
            val_28 = val_11.m_Radius;
            this._scrollPanelRT.anchoredPosition = new UnityEngine.Vector2() {x = val_11.m_Height, y = val_28};
            this._overlayRT.SetParent(parent:  this._canvas.transform, worldPositionStays:  false);
            UnityEngine.Vector2 val_13 = this._canvasRT.sizeDelta;
            this._overlayRT.SetSizeWithCurrentAnchors(axis:  0, size:  val_13.x);
            UnityEngine.Vector2 val_14 = this._canvasRT.sizeDelta;
            this._overlayRT.SetSizeWithCurrentAnchors(axis:  1, size:  val_14.y);
            this._overlayRT.SetParent(parent:  this.transform, worldPositionStays:  true);
            val_29 = this._scrollPanelRT;
            val_29.SetParent(parent:  this._overlayRT, worldPositionStays:  true);
            label_10:
            if(this.Items.Count < 1)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_17 = this._rectTransform.sizeDelta;
            float val_24 = val_17.y;
            int val_18 = this.Items.Count;
            val_24 = val_24 * ((float)UnityEngine.Mathf.Min(a:  0, b:  this._itemsToDisplay));
            this._scrollPanelRT.SetSizeWithCurrentAnchors(axis:  1, size:  val_24);
            UnityEngine.Vector2 val_20 = this._rectTransform.sizeDelta;
            this._scrollPanelRT.SetSizeWithCurrentAnchors(axis:  0, size:  val_20.x);
            val_29 = this._scrollPanelRT;
            UnityEngine.Vector2 val_21 = val_29.sizeDelta;
            val_27 = val_21.x;
            val_21.x = val_27 - val_25;
            val_21.x = val_21.x + (-5f);
            this._itemsPanelRT.SetSizeWithCurrentAnchors(axis:  0, size:  val_21.x);
            CinemachineFreeLook.Orbit val_22 = new CinemachineFreeLook.Orbit(h:  5f, r:  0f);
            this._itemsPanelRT.anchoredPosition = new UnityEngine.Vector2() {x = val_22.m_Height, y = val_22.m_Radius};
            this._scrollBarRT.SetSizeWithCurrentAnchors(axis:  0, size:  val_25);
            this._scrollBarRT.SetSizeWithCurrentAnchors(axis:  1, size:  val_24);
            this._slidingAreaRT.SetSizeWithCurrentAnchors(axis:  0, size:  0f);
            val_24 = this._slidingAreaRT;
            UnityEngine.Vector2 val_23 = this._scrollBarRT.sizeDelta;
            val_25 = val_23.x;
            val_23.x = val_24 - val_25;
            val_24.SetSizeWithCurrentAnchors(axis:  1, size:  val_23.x);
        }
        public void ToggleDropdownPanel(bool directClick)
        {
            this._overlayRT.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this._scrollBarRT.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            bool val_6 = this._isPanelActive;
            val_6 = val_6 ^ 1;
            this._isPanelActive = val_6;
            this._overlayRT.gameObject.SetActive(value:  (this._isPanelActive == true) ? 1 : 0);
            if(this._isPanelActive == false)
            {
                    return;
            }
            
            this = this.transform;
            this.SetAsLastSibling();
        }
    
    }

}
