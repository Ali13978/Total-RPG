using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    public class UIVerticalScroller : MonoBehaviour
    {
        // Fields
        [UnityEngine.TooltipAttribute]
        public UnityEngine.RectTransform _scrollingPanel;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.GameObject[] _arrayOfElements;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.RectTransform _center;
        [UnityEngine.TooltipAttribute]
        public int StartingIndex;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.GameObject ScrollUpButton;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.GameObject ScrollDownButton;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.Events.UnityEvent<int> ButtonClicked;
        private float[] distReposition;
        private float[] distance;
        private int minElementsNum;
        private int elementLength;
        private float deltaY;
        private string result;
        
        // Methods
        public UIVerticalScroller()
        {
            this.StartingIndex = 0;
        }
        public UIVerticalScroller(UnityEngine.RectTransform scrollingPanel, UnityEngine.GameObject[] arrayOfElements, UnityEngine.RectTransform center)
        {
            this.StartingIndex = 0;
            this._scrollingPanel = scrollingPanel;
            this._arrayOfElements = arrayOfElements;
            this._center = center;
        }
        public void Awake()
        {
            UnityEngine.RectTransform val_13;
            UnityEngine.GameObject[] val_14;
            UnityEngine.UI.ScrollRect val_1 = this.GetComponent<UnityEngine.UI.ScrollRect>();
            if((UnityEngine.Object.op_Implicit(exists:  0)) != true)
            {
                    this._scrollingPanel = val_1.content;
            }
            
            val_13 = this._center;
            if((UnityEngine.Object.op_Implicit(exists:  0)) != true)
            {
                    UnityEngine.Debug.LogError(message:  0);
            }
            
            if(this._arrayOfElements != null)
            {
                    if(this._arrayOfElements.Length != 0)
            {
                    return;
            }
            
            }
            
            val_13 = val_1.content.childCount;
            if()
            {
                    return;
            }
            
            val_14 = null;
            val_13 = 0;
            this._arrayOfElements = val_14;
            goto label_15;
            label_23:
            val_14 = this._arrayOfElements;
            val_13 = 1;
            label_15:
            val_14[val_13] = val_1.content.GetChild(index:  1).gameObject;
            if((val_13 - 1) != val_13)
            {
                goto label_23;
            }
        
        }
        public void Start()
        {
            var val_16;
            UnityEngine.GameObject[] val_17;
            int val_18;
            if(this._arrayOfElements.Length <= 0)
            {
                goto label_2;
            }
            
            this.elementLength = this._arrayOfElements.Length;
            this.distance = null;
            this.distReposition = null;
            UnityEngine.Rect val_2 = this._arrayOfElements[0].GetComponent<UnityEngine.RectTransform>().rect;
            val_2.m_XMin = val_2.m_XMin * (float)this.elementLength;
            val_2.m_XMin = val_2.m_XMin / 3f;
            val_2.m_XMin = val_2.m_XMin + val_2.m_XMin;
            this.deltaY = val_2.m_XMin;
            UnityEngine.Vector2 val_3 = this._scrollingPanel.anchoredPosition;
            CinemachineFreeLook.Orbit val_4 = new CinemachineFreeLook.Orbit(h:  val_3.x, r:  -this.deltaY);
            this._scrollingPanel.anchoredPosition = new UnityEngine.Vector2() {x = val_4.m_Height, y = val_4.m_Radius};
            val_16 = 0;
            goto label_10;
            label_15:
            int val_5 = this.elementLength + 276282048;
            this.AddListener(button:  (this.elementLength + 276282048) + 32, index:  0);
            val_16 = 1;
            label_10:
            val_17 = this._arrayOfElements;
            if(val_16 >= this._arrayOfElements.Length)
            {
                goto label_12;
            }
            
            if(val_16 < this._arrayOfElements.Length)
            {
                goto label_15;
            }
            
            goto label_15;
            label_12:
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    UnityEngine.Events.UnityAction val_9 = null;
                val_17 = val_9;
                val_9 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UnityEngine.UI.Extensions.UIVerticalScroller::<Start>m__0());
                this.ScrollUpButton.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(call:  val_17);
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    UnityEngine.Events.UnityAction val_13 = null;
                val_17 = val_13;
                val_13 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UnityEngine.UI.Extensions.UIVerticalScroller::<Start>m__1());
                this.ScrollDownButton.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(call:  val_17);
            }
            
            if((13 & (this.StartingIndex >> 31)) != 0)
            {
                    return;
            }
            
            val_17 = this._arrayOfElements;
            if(this.StartingIndex <= this._arrayOfElements.Length)
            {
                goto label_30;
            }
            
            val_18 = this._arrayOfElements.Length - 1;
            goto label_32;
            label_2:
            UnityEngine.Debug.Log(message:  0);
            return;
            label_30:
            val_18 = this.StartingIndex;
            label_32:
            this.StartingIndex = val_18;
            this.SnapToElement(element:  val_18);
        }
        private void AddListener(UnityEngine.GameObject button, int index)
        {
            if(null != 0)
            {
                    typeof(UIVerticalScroller.<AddListener>c__AnonStorey0).__il2cppRuntimeField_10 = index;
            }
            else
            {
                    mem[16] = index;
            }
            
            typeof(UIVerticalScroller.<AddListener>c__AnonStorey0).__il2cppRuntimeField_18 = this;
            button.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  new System.Object(), method:  System.Void UIVerticalScroller.<AddListener>c__AnonStorey0::<>m__0()));
        }
        private void DoSomething(int index)
        {
            if(this.ButtonClicked == null)
            {
                    return;
            }
            
            this.ButtonClicked.Invoke(arg0:  index);
        }
        public void Update()
        {
            var val_17;
            var val_18;
            System.Single[] val_19;
            UnityEngine.GameObject[] val_20;
            if(this._arrayOfElements.Length < 1)
            {
                    return;
            }
            
            if(this.elementLength > 0)
            {
                    val_17 = 1152921509741435616;
                val_18 = 1152921504719998976;
                var val_23 = 0;
                val_19 = this.distance;
                do
            {
                UnityEngine.Vector3 val_2 = this._center.GetComponent<UnityEngine.RectTransform>().position;
                float val_18 = val_2.y;
                UnityEngine.Vector3 val_4 = this._arrayOfElements[0].GetComponent<UnityEngine.RectTransform>().position;
                val_18 = val_18 - val_4.y;
                this.distReposition[0] = val_18;
                this.distance[0] = System.Math.Abs(this.distReposition[0]);
                var val_5 = mem[this.distance] + 0;
                float val_21 = (mem[this.distance] + 0) + 32;
                val_21 = val_21 / 200f;
                val_21 = val_21 + 1f;
                float val_7 = UnityEngine.Mathf.Max(a:  0.7f, b:  1f / val_21);
                this._arrayOfElements[0].GetComponent<UnityEngine.RectTransform>().transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                val_23 = val_23 + 1;
            }
            while(val_23 < this.elementLength);
            
            }
            else
            {
                    val_19 = this.distance;
            }
            
            val_20 = this._arrayOfElements;
            if(this.elementLength >= 1)
            {
                    val_17 = 1152921509794100528;
                int val_27 = 0;
                do
            {
                val_18 = 0;
                val_20[val_18].GetComponent<UnityEngine.CanvasGroup>().interactable = false;
                var val_12 = mem[this.distance] + 0;
                if((UnityEngine.Mathf.Min(values:  0)) == ((mem[this.distance] + 0) + 32))
            {
                    this.minElementsNum = val_27;
                this._arrayOfElements[val_18].GetComponent<UnityEngine.CanvasGroup>().interactable = true;
                this.result = this._arrayOfElements[val_18].GetComponentInChildren<UnityEngine.UI.Text>();
            }
            
                val_20 = this._arrayOfElements;
                val_27 = val_27 + 1;
            }
            while(val_27 < this.elementLength);
            
            }
            
            UnityEngine.Vector2 val_16 = val_20[this.minElementsNum].GetComponent<UnityEngine.RectTransform>().anchoredPosition;
            this.ScrollingElements(position:  -val_16.y);
        }
        private void ScrollingElements(float position)
        {
            UnityEngine.Vector2 val_1 = this._scrollingPanel.anchoredPosition;
            UnityEngine.Vector2 val_4 = this._scrollingPanel.anchoredPosition;
            CinemachineFreeLook.Orbit val_5 = new CinemachineFreeLook.Orbit(h:  val_4.x, r:  UnityEngine.Mathf.Lerp(a:  val_1.y, b:  position, t:  UnityEngine.Time.deltaTime));
            this._scrollingPanel.anchoredPosition = new UnityEngine.Vector2() {x = val_5.m_Height, y = val_5.m_Radius};
        }
        public string GetResults()
        {
            return (string)this.result;
        }
        public void SnapToElement(int element)
        {
            UnityEngine.Rect val_2 = this._arrayOfElements[0].GetComponent<UnityEngine.RectTransform>().rect;
            UnityEngine.Vector2 val_4 = this._scrollingPanel.anchoredPosition;
            CinemachineFreeLook.Orbit val_5 = new CinemachineFreeLook.Orbit(h:  val_4.x, r:  -((float)element * val_2.m_XMin));
            this._scrollingPanel.anchoredPosition = new UnityEngine.Vector2() {x = val_5.m_Height, y = val_5.m_Radius};
        }
        public void ScrollUp()
        {
            UnityEngine.Rect val_2 = this._arrayOfElements[0].GetComponent<UnityEngine.RectTransform>().rect;
            float val_9 = 1.2f;
            val_9 = val_2.m_XMin / val_9;
            UnityEngine.Vector2 val_3 = this._scrollingPanel.anchoredPosition;
            UnityEngine.Vector2 val_4 = this._scrollingPanel.anchoredPosition;
            val_4.y = val_4.y - val_9;
            CinemachineFreeLook.Orbit val_5 = new CinemachineFreeLook.Orbit(h:  val_3.x, r:  val_4.y);
            UnityEngine.Vector2 val_6 = this._scrollingPanel.anchoredPosition;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.Lerp(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, b:  new UnityEngine.Vector2() {x = val_5.m_Height, y = val_5.m_Radius}, t:  1f);
            this._scrollingPanel.anchoredPosition = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
        }
        public void ScrollDown()
        {
            UnityEngine.Rect val_2 = this._arrayOfElements[0].GetComponent<UnityEngine.RectTransform>().rect;
            float val_7 = 1.2f;
            val_7 = val_2.m_XMin / val_7;
            UnityEngine.Vector2 val_3 = this._scrollingPanel.anchoredPosition;
            UnityEngine.Vector2 val_4 = this._scrollingPanel.anchoredPosition;
            val_4.y = val_7 + val_4.y;
            CinemachineFreeLook.Orbit val_5 = new CinemachineFreeLook.Orbit(h:  val_3.x, r:  val_4.y);
            this._scrollingPanel.anchoredPosition = new UnityEngine.Vector2() {x = val_5.m_Height, y = val_5.m_Radius};
        }
        private void <Start>m__0()
        {
            this.ScrollUp();
        }
        private void <Start>m__1()
        {
            this.ScrollDown();
        }
    
    }

}
