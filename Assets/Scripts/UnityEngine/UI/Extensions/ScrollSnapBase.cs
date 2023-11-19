using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    public class ScrollSnapBase : MonoBehaviour, IBeginDragHandler, IDragHandler, IEventSystemHandler
    {
        // Fields
        internal UnityEngine.RectTransform _screensContainer;
        internal bool _isVertical;
        internal int _screens;
        internal float _scrollStartPosition;
        internal float _childSize;
        private float _childPos;
        private float _maskSize;
        internal UnityEngine.Vector2 _childAnchorPoint;
        internal UnityEngine.UI.ScrollRect _scroll_rect;
        internal UnityEngine.Vector3 _lerp_target;
        internal bool _lerp;
        internal bool _pointerDown;
        internal bool _settled;
        internal UnityEngine.Vector3 _startPosition;
        [UnityEngine.TooltipAttribute]
        internal int _currentPage;
        internal int _previousPage;
        internal int _halfNoVisibleItems;
        private int _bottomItem;
        private int _topItem;
        [UnityEngine.TooltipAttribute]
        [UnityEngine.SerializeField]
        public int StartingScreen;
        [UnityEngine.TooltipAttribute]
        [UnityEngine.SerializeField]
        [UnityEngine.RangeAttribute]
        public float PageStep;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.GameObject Pagination;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.GameObject NextButton;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.GameObject PrevButton;
        [UnityEngine.TooltipAttribute]
        public float transitionSpeed;
        [UnityEngine.TooltipAttribute]
        public bool UseFastSwipe;
        [UnityEngine.TooltipAttribute]
        public int FastSwipeThreshold;
        [UnityEngine.TooltipAttribute]
        public int SwipeVelocityThreshold;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.RectTransform MaskArea;
        [UnityEngine.TooltipAttribute]
        public float MaskBuffer;
        [UnityEngine.TooltipAttribute]
        public bool UseParentTransform;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.GameObject[] ChildObjects;
        [UnityEngine.SerializeField]
        [UnityEngine.TooltipAttribute]
        private UnityEngine.UI.Extensions.ScrollSnapBase.SelectionChangeStartEvent m_OnSelectionChangeStartEvent;
        [UnityEngine.SerializeField]
        [UnityEngine.TooltipAttribute]
        private UnityEngine.UI.Extensions.ScrollSnapBase.SelectionPageChangedEvent m_OnSelectionPageChangedEvent;
        [UnityEngine.SerializeField]
        [UnityEngine.TooltipAttribute]
        private UnityEngine.UI.Extensions.ScrollSnapBase.SelectionChangeEndEvent m_OnSelectionChangeEndEvent;
        
        // Properties
        public int CurrentPage { get; set; }
        public UnityEngine.UI.Extensions.ScrollSnapBase.SelectionChangeStartEvent OnSelectionChangeStartEvent { get; set; }
        public UnityEngine.UI.Extensions.ScrollSnapBase.SelectionPageChangedEvent OnSelectionPageChangedEvent { get; set; }
        public UnityEngine.UI.Extensions.ScrollSnapBase.SelectionChangeEndEvent OnSelectionChangeEndEvent { get; set; }
        
        // Methods
        public ScrollSnapBase()
        {
            this._startPosition = 0;
            mem[1152921512741172300] = 0;
            this.transitionSpeed = 7.5f;
            this.FastSwipeThreshold = 100;
            this._screens = 1;
            this._settled = 1;
            this.UseParentTransform = 1;
            mem[1152921512741172304] = 0;
            this.PageStep = 1f;
            this.SwipeVelocityThreshold = 200;
            this.MaskBuffer = 1f;
            this.m_OnSelectionChangeStartEvent = new UnityEngine.Events.UnityEvent();
            this.m_OnSelectionPageChangedEvent = new ScrollSnapBase.SelectionPageChangedEvent();
            this.m_OnSelectionChangeEndEvent = new ScrollSnapBase.SelectionChangeEndEvent();
        }
        public int get_CurrentPage()
        {
            return (int)this._currentPage;
        }
        internal void set_CurrentPage(int value)
        {
            UnityEngine.RectTransform val_4;
            if(((value & 2147483648) != 0) || (this._currentPage == value))
            {
                goto label_2;
            }
            
            val_4 = this._screensContainer;
            if(val_4.childCount > value)
            {
                goto label_7;
            }
            
            label_2:
            if(value != 0)
            {
                    return;
            }
            
            val_4 = this._screensContainer;
            if(val_4.childCount != 0)
            {
                    return;
            }
            
            label_7:
            this._currentPage = value;
            this._previousPage = this._currentPage;
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    this.UpdateVisible();
            }
            
            if(this._lerp != true)
            {
                    this.ScreenChange();
            }
            
            this.ChangeBulletsInfo(targetScreen:  this._currentPage);
        }
        public UnityEngine.UI.Extensions.ScrollSnapBase.SelectionChangeStartEvent get_OnSelectionChangeStartEvent()
        {
            return (SelectionChangeStartEvent)this.m_OnSelectionChangeStartEvent;
        }
        public void set_OnSelectionChangeStartEvent(UnityEngine.UI.Extensions.ScrollSnapBase.SelectionChangeStartEvent value)
        {
            this.m_OnSelectionChangeStartEvent = value;
        }
        public UnityEngine.UI.Extensions.ScrollSnapBase.SelectionPageChangedEvent get_OnSelectionPageChangedEvent()
        {
            return (SelectionPageChangedEvent)this.m_OnSelectionPageChangedEvent;
        }
        public void set_OnSelectionPageChangedEvent(UnityEngine.UI.Extensions.ScrollSnapBase.SelectionPageChangedEvent value)
        {
            this.m_OnSelectionPageChangedEvent = value;
        }
        public UnityEngine.UI.Extensions.ScrollSnapBase.SelectionChangeEndEvent get_OnSelectionChangeEndEvent()
        {
            return (SelectionChangeEndEvent)this.m_OnSelectionChangeEndEvent;
        }
        public void set_OnSelectionChangeEndEvent(UnityEngine.UI.Extensions.ScrollSnapBase.SelectionChangeEndEvent value)
        {
            this.m_OnSelectionChangeEndEvent = value;
        }
        private void Awake()
        {
            UnityEngine.UI.ScrollRect val_2 = this.gameObject.GetComponent<UnityEngine.UI.ScrollRect>();
            this._scroll_rect = val_2;
            UnityEngine.UI.Scrollbar val_3 = val_2.horizontalScrollbar;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == true)
            {
                goto label_5;
            }
            
            UnityEngine.UI.Scrollbar val_6 = this._scroll_rect.verticalScrollbar;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                goto label_9;
            }
            
            label_5:
            UnityEngine.Debug.LogWarning(message:  0);
            label_9:
            if((this.StartingScreen & 2147483648) != 0)
            {
                    this.StartingScreen = 0;
            }
            
            UnityEngine.RectTransform val_8 = this._scroll_rect.content;
            this._screensContainer = val_8;
            if((this.ChildObjects == null) || (this.ChildObjects.Length < 1))
            {
                goto label_15;
            }
            
            if(val_8.transform.childCount < 1)
            {
                goto label_18;
            }
            
            UnityEngine.Debug.LogError(message:  0);
            return;
            label_15:
            this.InitialiseChildObjectsFromScene();
            goto label_21;
            label_18:
            this.InitialiseChildObjectsFromArray();
            label_21:
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    this.NextButton.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UnityEngine.UI.Extensions.ScrollSnapBase::<Awake>m__0()));
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            this.PrevButton.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UnityEngine.UI.Extensions.ScrollSnapBase::<Awake>m__1()));
        }
        internal void InitialiseChildObjectsFromScene()
        {
            UnityEngine.GameObject[] val_8;
            var val_9;
            UnityEngine.GameObject[] val_10;
            UnityEngine.RectTransform val_11;
            val_8 = null;
            this.ChildObjects = val_8;
            if()
            {
                    return;
            }
            
            val_9 = 0;
            goto label_3;
            label_21:
            val_10 = this.ChildObjects;
            val_9 = 1;
            label_3:
            val_10[val_9] = this._screensContainer.transform.GetChild(index:  1).gameObject;
            val_11 = this.MaskArea;
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    val_11 = this.ChildObjects[val_9];
                if(val_11.activeSelf != false)
            {
                    val_11 = this.ChildObjects[val_9];
                val_11.SetActive(value:  false);
            }
            
            }
            
            if((this._screensContainer.childCount - 1) != val_9)
            {
                goto label_21;
            }
        
        }
        internal void InitialiseChildObjectsFromArray()
        {
            if(this.ChildObjects.Length < 1)
            {
                    return;
            }
            
            var val_13 = 0;
            do
            {
                UnityEngine.GameObject val_10 = this.ChildObjects[val_13];
                Unitycoding.UIWidgets.RadialMenuItem val_1 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
                if(this.UseParentTransform != false)
            {
                    UnityEngine.RectTransform val_2 = val_1.GetComponent<UnityEngine.RectTransform>();
                UnityEngine.Quaternion val_3 = this._screensContainer.rotation;
                val_2.rotation = new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w};
                UnityEngine.Vector3 val_4 = this._screensContainer.localScale;
                val_2.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
                UnityEngine.Vector3 val_5 = this._screensContainer.position;
                val_2.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            }
            
                val_1.transform.SetParent(parent:  this._screensContainer.transform);
                this.ChildObjects[val_13] = val_1;
                if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    if(this.ChildObjects[val_13].activeSelf != false)
            {
                    this.ChildObjects[val_13].SetActive(value:  false);
            }
            
            }
            
                val_13 = val_13 + 1;
            }
            while(this.ChildObjects.Length != val_13);
        
        }
        internal void UpdateVisible()
        {
            UnityEngine.GameObject val_22;
            int val_23;
            int val_24;
            var val_25;
            int val_26;
            var val_27;
            val_22 = this;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            if(this.ChildObjects == null)
            {
                    return;
            }
            
            if(this.ChildObjects.Length < 1)
            {
                    return;
            }
            
            if(this._screensContainer.childCount < 1)
            {
                    return;
            }
            
            UnityEngine.Rect val_3 = this.MaskArea.rect;
            if(this._isVertical != false)
            {
                
            }
            
            float val_20 = this._childSize;
            val_20 = val_20 * this.MaskBuffer;
            val_20 = val_3.m_XMin / val_20;
            this._maskSize = val_3.m_XMin;
            this._bottomItem = 0;
            this._topItem = 0;
            var val_5 = (((int)System.Math.Round(value:  (double)val_20, mode:  0)) < 0) ? (((int)System.Math.Round(value:  (double)val_20, mode:  0)) + 1) : ((int)System.Math.Round(value:  (double)val_20, mode:  0));
            val_23 = val_5 >> 1;
            this._halfNoVisibleItems = val_23;
            if(((int)System.Math.Round(value:  (double)val_20, mode:  0)) >= (4.94065645841247E-324))
            {
                goto label_12;
            }
            
            val_24 = 0;
            goto label_13;
            label_12:
            int val_21 = this._currentPage;
            var val_6 = val_23 + 1;
            val_21 = val_21 - 1;
            val_5 = val_21 - val_23;
            label_15:
            int val_7 = (val_5 >= 0) ? (val_6) : 0;
            if(val_7 >= 1)
            {
                goto label_14;
            }
            
            var val_8 = val_6 - 1;
            val_5 = val_5 + 1;
            if(val_6 > 1)
            {
                goto label_15;
            }
            
            label_14:
            val_23 = this._halfNoVisibleItems;
            this._bottomItem = val_7;
            label_13:
            if((val_23 + 1) <= 0)
            {
                goto label_16;
            }
            
            var val_23 = ~val_23;
            label_19:
            val_25 = val_23 + 1;
            int val_22 = this._currentPage;
            val_22 = this._screensContainer.childCount - val_22;
            val_22 = val_23 + val_22;
            int val_11 = (val_22 >= 0) ? (val_25) : 0;
            this._topItem = val_11;
            if(val_11 > 0)
            {
                goto label_18;
            }
            
            int val_12 = val_23 - 1;
            val_23 = val_23 + 1;
            if(val_23 > 0)
            {
                goto label_19;
            }
            
            label_18:
            val_24 = this._bottomItem;
            label_16:
            val_26 = this._currentPage;
            int val_13 = val_26 - val_24;
            if(val_13 < (this._topItem + val_26))
            {
                    val_25 = 1152921504607113216;
                do
            {
                this.ChildObjects[(long)val_13].SetActive(value:  true);
                val_26 = this._currentPage;
                int val_25 = this._topItem;
                val_13 = val_13 + 1;
                val_25 = val_25 + val_26;
            }
            while(val_13 < val_25);
            
            }
            
            if(val_26 > this._halfNoVisibleItems)
            {
                    this.ChildObjects[(long)val_26 - this._bottomItem].SetActive(value:  false);
            }
            
            if((this._screensContainer.childCount - this._currentPage) <= this._topItem)
            {
                    return;
            }
            
            val_22 = this.ChildObjects[(long)this._topItem + this._currentPage];
            val_22.SetActive(value:  false);
            return;
            label_42:
            val_27 = val_22;
            mem[8] = null;
            goto label_42;
        }
        public void NextScreen()
        {
            int val_4;
            int val_4 = this._screens;
            val_4 = this._currentPage;
            val_4 = val_4 - 1;
            if(val_4 >= val_4)
            {
                    return;
            }
            
            if(this._lerp != true)
            {
                    this.m_OnSelectionChangeStartEvent.Invoke();
                val_4 = this._currentPage;
            }
            
            this._lerp = true;
            this.CurrentPage = val_4 + 1;
            float val_5 = (float)this._currentPage;
            val_5 = -(val_5 * this._childSize);
            this._childPos = val_5;
            float val_3 = this._scrollStartPosition - (val_5 * this._childSize);
            if(this._isVertical != false)
            {
                    mem[1152921512744044284] = val_3;
            }
            else
            {
                    this._lerp_target = val_3;
            }
            
            this.ScreenChange();
        }
        public void PreviousScreen()
        {
            int val_4 = this._currentPage;
            if(val_4 < 1)
            {
                    return;
            }
            
            if(this._lerp != true)
            {
                    this.m_OnSelectionChangeStartEvent.Invoke();
                val_4 = this._currentPage;
            }
            
            this._lerp = true;
            this.CurrentPage = val_4 - 1;
            float val_4 = (float)this._currentPage;
            val_4 = -(val_4 * this._childSize);
            this._childPos = val_4;
            float val_3 = this._scrollStartPosition - (val_4 * this._childSize);
            if(this._isVertical != false)
            {
                    mem[1152921512744164476] = val_3;
            }
            else
            {
                    this._lerp_target = val_3;
            }
            
            this.ScreenChange();
        }
        public void GoToScreen(int screenIndex)
        {
            if((screenIndex & 2147483648) != 0)
            {
                    return;
            }
            
            int val_3 = this._screens;
            val_3 = val_3 - 1;
            if(val_3 < screenIndex)
            {
                    return;
            }
            
            if(this._lerp != true)
            {
                    this.m_OnSelectionChangeStartEvent.Invoke();
            }
            
            this._lerp = true;
            this.CurrentPage = screenIndex;
            float val_4 = (float)this._currentPage;
            val_4 = -(val_4 * this._childSize);
            this._childPos = val_4;
            float val_2 = this._scrollStartPosition - (val_4 * this._childSize);
            if(this._isVertical != false)
            {
                    mem[1152921512744284668] = val_2;
            }
            else
            {
                    this._lerp_target = val_2;
            }
            
            this.ScreenChange();
        }
        internal int GetPageforPosition(UnityEngine.Vector3 pos)
        {
            float val_2;
            float val_6;
            float val_7;
            double val_8;
            if(this._isVertical != false)
            {
                    val_6 = pos.y - this._scrollStartPosition;
            }
            else
            {
                    val_6 = pos.x - this._scrollStartPosition;
            }
            
            float val_1 = val_6 / this._childSize;
            if(val_1 >= 0f)
            {
                goto label_2;
            }
            
            if((double)val_1 != (-0.5))
            {
                goto label_3;
            }
            
            val_7 = val_2;
            val_8 = -1;
            goto label_4;
            label_2:
            if((double)val_1 != 0.5)
            {
                    return (int)-((int)(double)val_1 + 0.5);
            }
            
            val_7 = val_2;
            val_8 = 1;
            label_4:
            val_8 = val_7 + val_8;
            val_7 = (((long)val_7 & 1) != 0) ? (val_7) : (val_8);
            return (int)-((int)(double)val_1 + 0.5);
            label_3:
            double val_3 = (double)val_1 + (-0.5);
            return (int)-((int)(double)val_1 + 0.5);
        }
        internal bool IsRectSettledOnaPage(UnityEngine.Vector3 pos)
        {
            float val_2;
            float val_7;
            float val_8;
            double val_9;
            if(this._isVertical != false)
            {
                    val_7 = pos.y - this._scrollStartPosition;
            }
            else
            {
                    val_7 = pos.x - this._scrollStartPosition;
            }
            
            float val_1 = val_7 / this._childSize;
            if(val_1 >= 0f)
            {
                goto label_2;
            }
            
            if((double)val_1 != (-0.5))
            {
                goto label_3;
            }
            
            val_8 = val_2;
            val_9 = -1;
            goto label_4;
            label_2:
            if((double)val_1 != 0.5)
            {
                    return (bool)(((float)-((int)(double)val_1 + 0.5)) == (-val_1)) ? 1 : 0;
            }
            
            val_8 = val_2;
            val_9 = 1;
            label_4:
            val_9 = val_8 + val_9;
            val_8 = (((long)val_8 & 1) != 0) ? (val_8) : (val_9);
            return (bool)(((float)-((int)(double)val_1 + 0.5)) == (-val_1)) ? 1 : 0;
            label_3:
            double val_3 = (double)val_1 + (-0.5);
            return (bool)(((float)-((int)(double)val_1 + 0.5)) == (-val_1)) ? 1 : 0;
        }
        internal void GetPositionforPage(int page, ref UnityEngine.Vector3 target)
        {
            float val_3 = this._childSize;
            val_3 = -((float)page * val_3);
            this._childPos = val_3;
            float val_2 = this._scrollStartPosition - ((float)page * val_3);
            if(this._isVertical != false)
            {
                    target.y = val_2;
                return;
            }
            
            target.x = val_2;
        }
        internal void ScrollToClosestElement()
        {
            this._lerp = true;
            UnityEngine.Vector3 val_1 = this._screensContainer.localPosition;
            this.CurrentPage = this.GetPageforPosition(pos:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            float val_5 = this._childSize;
            val_5 = -((float)this._currentPage * val_5);
            this._childPos = val_5;
            float val_4 = this._scrollStartPosition - ((float)this._currentPage * val_5);
            if(this._isVertical != false)
            {
                    mem[1152921512744748956] = val_4;
            }
            else
            {
                    this._lerp_target = val_4;
            }
            
            this.ChangeBulletsInfo(targetScreen:  this._currentPage);
        }
        internal void ChangeBulletsInfo(int targetScreen)
        {
            UnityEngine.GameObject val_9 = this.Pagination;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            val_9 = 0;
            goto label_4;
            label_12:
            X22.isOn = (targetScreen == val_9) ? 1 : 0;
            val_9 = 1;
            label_4:
            if(val_9 >= this.Pagination.transform.childCount)
            {
                    return;
            }
            
            if((this.Pagination.transform.GetChild(index:  1).GetComponent<UnityEngine.UI.Toggle>()) != null)
            {
                goto label_12;
            }
            
            goto label_12;
        }
        private void OnValidate()
        {
            var val_7;
            int val_8;
            val_7 = this.gameObject.GetComponent<UnityEngine.UI.ScrollRect>().content;
            int val_4 = val_7.childCount;
            if(val_4 == 0)
            {
                goto label_4;
            }
            
            if(this.ChildObjects != null)
            {
                goto label_5;
            }
            
            goto label_6;
            label_4:
            if(this.ChildObjects == null)
            {
                goto label_9;
            }
            
            label_5:
            label_6:
            val_8 = this.StartingScreen;
            int val_6 = ((this.ChildObjects.Length == 0) ? (val_4) : this.ChildObjects.Length) - 1;
            if(val_8 > val_6)
            {
                    val_8 = val_6;
                this.StartingScreen = val_6;
            }
            
            if((val_8 & 2147483648) != 0)
            {
                    this.StartingScreen = 0;
            }
            
            label_9:
            if(this.MaskBuffer <= 0f)
            {
                    this.MaskBuffer = 1f;
            }
            
            if(this.PageStep < 0)
            {
                    this.PageStep = 0f;
                return;
            }
            
            if(this.PageStep <= 8f)
            {
                    return;
            }
            
            this.PageStep = 9f;
        }
        internal void StartScreenChange()
        {
            this.m_OnSelectionChangeStartEvent.Invoke();
        }
        internal void ScreenChange()
        {
            this.m_OnSelectionPageChangedEvent.Invoke(arg0:  this._currentPage);
        }
        internal void EndScreenChange()
        {
            this.m_OnSelectionChangeEndEvent.Invoke(arg0:  this._currentPage);
            this._settled = true;
        }
        public void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this._pointerDown = true;
            this._settled = false;
            this.m_OnSelectionChangeStartEvent.Invoke();
            UnityEngine.Vector3 val_1 = this._screensContainer.localPosition;
            this._startPosition = val_1;
            mem[1152921512745618604] = val_1.y;
            mem[1152921512745618608] = val_1.z;
        }
        public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this._lerp = false;
        }
        private void <Awake>m__0()
        {
            this.NextScreen();
        }
        private void <Awake>m__1()
        {
            this.PreviousScreen();
        }
    
    }

}
