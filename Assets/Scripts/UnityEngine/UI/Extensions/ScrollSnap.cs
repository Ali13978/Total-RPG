using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.ExecuteInEditMode]
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    public class ScrollSnap : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler, IEventSystemHandler
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.UI.Extensions.ScrollSnap.PageSnapChange onPageChange;
        public UnityEngine.UI.Extensions.ScrollSnap.ScrollDirection direction;
        protected UnityEngine.UI.ScrollRect scrollRect;
        protected UnityEngine.RectTransform scrollRectTransform;
        protected UnityEngine.Transform listContainerTransform;
        protected UnityEngine.RectTransform rectTransform;
        private int pages;
        protected int startingPage;
        protected UnityEngine.Vector3[] pageAnchorPositions;
        protected UnityEngine.Vector3 lerpTarget;
        protected bool lerp;
        protected float listContainerMinPosition;
        protected float listContainerMaxPosition;
        protected float listContainerSize;
        protected UnityEngine.RectTransform listContainerRectTransform;
        protected UnityEngine.Vector2 listContainerCachedSize;
        protected float itemSize;
        protected int itemsCount;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.UI.Button nextButton;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.UI.Button prevButton;
        [UnityEngine.TooltipAttribute]
        [UnityEngine.RangeAttribute]
        public int itemsVisibleAtOnce;
        [UnityEngine.TooltipAttribute]
        public bool autoLayoutItems;
        [UnityEngine.TooltipAttribute]
        public bool linkScrolbarSteps;
        [UnityEngine.TooltipAttribute]
        public bool linkScrolrectScrollSensitivity;
        public bool useFastSwipe;
        public int fastSwipeThreshold;
        protected bool startDrag;
        protected UnityEngine.Vector3 positionOnDragStart;
        protected int pageOnDragStart;
        protected bool fastSwipeTimer;
        protected int fastSwipeCounter;
        protected int fastSwipeTarget;
        private bool fastSwipe;
        
        // Methods
        public ScrollSnap()
        {
            this.positionOnDragStart = 0;
            mem[1152921512737044900] = 0;
            this.fastSwipeThreshold = 100;
            mem[1152921512737044904] = 0;
            this.itemsVisibleAtOnce = 1;
            this.autoLayoutItems = 1;
            this.useFastSwipe = 1;
            this.startDrag = 1;
            this.fastSwipeTarget = 10;
        }
        public void add_onPageChange(UnityEngine.UI.Extensions.ScrollSnap.PageSnapChange value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.onPageChange);
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
            while(1152921512737169032 != this.onPageChange);
        
        }
        public void remove_onPageChange(UnityEngine.UI.Extensions.ScrollSnap.PageSnapChange value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.onPageChange);
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
            while(1152921512737305608 != this.onPageChange);
        
        }
        private void Awake()
        {
            UnityEngine.Events.UnityAction val_18;
            this.lerp = false;
            this.scrollRect = this.gameObject.GetComponent<UnityEngine.UI.ScrollRect>();
            val_18 = 1152921509741008480;
            this.scrollRectTransform = this.gameObject.GetComponent<UnityEngine.RectTransform>();
            UnityEngine.RectTransform val_5 = this.scrollRect.content;
            this.listContainerTransform = val_5;
            this.listContainerRectTransform = val_5.GetComponent<UnityEngine.RectTransform>();
            this.rectTransform = this.listContainerTransform.gameObject.GetComponent<UnityEngine.RectTransform>();
            this.UpdateListItemsSize();
            this.UpdateListItemPositions();
            this.PageChanged(currentPage:  this.CurrentPage());
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    UnityEngine.Events.UnityAction val_13 = null;
                val_18 = val_13;
                val_13 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UnityEngine.UI.Extensions.ScrollSnap::<Awake>m__0());
                this.nextButton.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(call:  val_18);
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            this.prevButton.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void UnityEngine.UI.Extensions.ScrollSnap::<Awake>m__1()));
        }
        private void Start()
        {
            this.Awake();
        }
        public void UpdateListItemsSize()
        {
            var val_34;
            ScrollDirection val_35;
            float val_36;
            var val_38;
            var val_39;
            var val_40;
            UnityEngine.Object val_41;
            var val_43;
            val_34 = this;
            val_35 = this.direction;
            UnityEngine.Rect val_1 = this.scrollRectTransform.rect;
            if(val_35 != 0)
            {
                    val_36 = val_1.m_XMin / (float)this.itemsVisibleAtOnce;
                UnityEngine.Rect val_2 = this.listContainerRectTransform.rect;
            }
            else
            {
                    val_36 = val_1.m_XMin / (float)this.itemsVisibleAtOnce;
                UnityEngine.Rect val_3 = this.listContainerRectTransform.rect;
            }
            
            this.itemSize = val_36;
            if(this.linkScrolrectScrollSensitivity != false)
            {
                    this.scrollRect.scrollSensitivity = val_36;
            }
            
            if((val_3.m_XMin / (float)this.itemsCount) == val_36)
            {
                    return;
            }
            
            if(this.autoLayoutItems == false)
            {
                    return;
            }
            
            if(this.itemsCount < 1)
            {
                    return;
            }
            
            System.Collections.IEnumerator val_5 = this.listContainerTransform.GetEnumerator();
            if(this.direction == 0)
            {
                goto label_70;
            }
            
            do
            {
                label_38:
                var val_34 = 0;
                val_34 = val_34 + 1;
                val_38 = val_5;
                if(((val_5 & 1) & 1) == 0)
            {
                goto label_81;
            }
            
                var val_35 = 0;
                val_35 = val_35 + 1;
                val_39 = val_5;
                val_40 = val_5;
                val_40 = 0;
                UnityEngine.GameObject val_13 = val_40.gameObject;
            }
            while(val_13.activeInHierarchy == false);
            
            val_41 = val_13.GetComponent<UnityEngine.UI.LayoutElement>();
            if(0 == val_41)
            {
                    val_41 = val_13.AddComponent<UnityEngine.UI.LayoutElement>();
            }
            
            if(val_41 != null)
            {
                goto label_38;
            }
            
            goto label_38;
            label_81:
            if(val_5 != null)
            {
                    var val_36 = 0;
                val_36 = val_36 + 1;
                val_43 = val_5;
            }
            
            if( == 497)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
        
        }
        public void UpdateListItemPositions()
        {
            UnityEngine.RectTransform val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            UnityEngine.Transform val_36;
            float val_37;
            var val_38;
            float val_39;
            float val_40;
            val_30 = this;
            UnityEngine.Rect val_1 = this.listContainerRectTransform.rect;
            if((0 & 1) != 0)
            {
                    return;
            }
            
            System.Collections.IEnumerator val_2 = this.listContainerTransform.GetEnumerator();
            goto label_4;
            label_23:
            System.Collections.IEnumerator val_3 = val_2 & 1;
            label_4:
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_31 = val_2;
            if(((val_2 & 1) & 1) == 0)
            {
                goto label_61;
            }
            
            var val_32 = 0;
            val_32 = val_32 + 1;
            val_32 = val_2;
            val_33 = val_2;
            val_33 = 0;
            bool val_12 = val_33.gameObject.activeInHierarchy;
            goto label_23;
            label_61:
            if(val_2 != null)
            {
                    var val_33 = 0;
                val_33 = val_33 + 1;
                val_35 = val_2;
            }
            
            this.itemsCount = 0;
            System.Array.Resize<UnityEngine.Vector3>(array: ref  0, newSize:  this.pageAnchorPositions);
            if(null < 1)
            {
                goto label_32;
            }
            
            val_34 = 1152921504719998976;
            this.pages = UnityEngine.Mathf.Max(a:  0, b:  (UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished - this.itemsVisibleAtOnce)>>0&0xFFFFFFFF);
            if(this.direction == 0)
            {
                goto label_36;
            }
            
            this.scrollRect.verticalNormalizedPosition = 1f;
            UnityEngine.Vector3 val_17 = this.listContainerTransform.localPosition;
            this.listContainerMinPosition = val_17.y;
            this.scrollRect.verticalNormalizedPosition = 0f;
            val_36 = this.listContainerTransform;
            UnityEngine.Vector3 val_18 = val_36.localPosition;
            val_37 = val_18.y - this.listContainerMinPosition;
            this.listContainerMaxPosition = val_18.y;
            this.listContainerSize = val_37;
            if(this.pages < 1)
            {
                goto label_50;
            }
            
            var val_35 = 0;
            val_38 = 12;
            do
            {
                UnityEngine.Vector3 val_19 = this.listContainerTransform.localPosition;
                val_39 = this.itemSize;
                UnityEngine.Vector3 val_20 = this.listContainerTransform.localPosition;
                float val_34 = 0f;
                val_34 = val_34 * val_39;
                val_40 = this.listContainerMinPosition + val_34;
                val_37 = val_19.x;
                val_36 = 0;
                var val_21 = mem[this.pageAnchorPositions] + (val_36 * val_38);
                val_35 = val_35 + 1;
                mem2[0] = 0;
                mem2[0] = 0;
            }
            while(val_35 < this.pages);
            
            goto label_50;
            label_36:
            this.scrollRect.horizontalNormalizedPosition = 0f;
            UnityEngine.Vector3 val_22 = this.listContainerTransform.localPosition;
            this.listContainerMaxPosition = val_22.x;
            this.scrollRect.horizontalNormalizedPosition = 1f;
            val_36 = this.listContainerTransform;
            UnityEngine.Vector3 val_23 = val_36.localPosition;
            val_40 = this.listContainerMaxPosition;
            this.listContainerMinPosition = val_23.x;
            val_37 = val_40 - val_23.x;
            this.listContainerSize = val_37;
            if(this.pages >= 1)
            {
                    var val_37 = 0;
                val_38 = 12;
                do
            {
                val_39 = this.itemSize;
                UnityEngine.Vector3 val_24 = this.listContainerTransform.localPosition;
                UnityEngine.Vector3 val_25 = this.listContainerTransform.localPosition;
                float val_36 = 0f;
                val_36 = val_36 * val_39;
                val_37 = this.listContainerMaxPosition - val_36;
                val_40 = val_24.y;
                val_36 = 0;
                var val_26 = mem[this.pageAnchorPositions] + (val_36 * val_38);
                val_37 = val_37 + 1;
                mem2[0] = 0;
                mem2[0] = 0;
            }
            while(val_37 < this.pages);
            
            }
            
            label_50:
            this.UpdateScrollbar(linkSteps:  this.linkScrolbarSteps);
            this.startingPage = UnityEngine.Mathf.Min(a:  0, b:  this.startingPage);
            this.ResetPage();
            label_32:
            if(this.itemsCount != null)
            {
                    this.PageChanged(currentPage:  this.CurrentPage());
            }
            
            this.itemsCount = null;
            UnityEngine.Rect val_29 = this.listContainerRectTransform.rect;
            val_30 = this.listContainerRectTransform;
            UnityEngine.Rect val_30 = val_30.rect;
            this.listContainerCachedSize.Set(newX:  val_29.m_XMin, newY:  val_30.m_YMin);
        }
        public void ResetPage()
        {
            float val_3;
            float val_4;
            int val_1 = this.pages;
            int val_2 = this.startingPage;
            if(this.direction == 0)
            {
                goto label_0;
            }
            
            if(val_1 >= 2)
            {
                goto label_1;
            }
            
            val_3 = 0f;
            goto label_2;
            label_0:
            if(val_1 >= 2)
            {
                goto label_3;
            }
            
            val_4 = 0f;
            goto label_4;
            label_1:
            val_1 = val_1 - 1;
            val_2 = val_1 - val_2;
            val_3 = (float)val_2 / (float)val_1;
            label_2:
            this.scrollRect.verticalNormalizedPosition = val_3;
            return;
            label_3:
            val_1 = val_1 - 1;
            val_4 = (float)val_2 / (float)val_1;
            label_4:
            this.scrollRect.horizontalNormalizedPosition = val_4;
        }
        protected void UpdateScrollbar(bool linkSteps)
        {
            int val_15;
            var val_16;
            if(linkSteps == false)
            {
                goto label_2;
            }
            
            if(this.direction == 0)
            {
                goto label_3;
            }
            
            if(0 == this.scrollRect.verticalScrollbar)
            {
                    return;
            }
            
            UnityEngine.UI.Scrollbar val_3 = this.scrollRect.verticalScrollbar;
            goto label_8;
            label_2:
            if(this.direction == 0)
            {
                goto label_9;
            }
            
            if(0 == this.scrollRect.verticalScrollbar)
            {
                    return;
            }
            
            UnityEngine.UI.Scrollbar val_6 = this.scrollRect.verticalScrollbar;
            goto label_14;
            label_3:
            if(0 == this.scrollRect.horizontalScrollbar)
            {
                    return;
            }
            
            UnityEngine.UI.Scrollbar val_9 = this.scrollRect.horizontalScrollbar;
            label_8:
            val_15 = this.pages;
            val_16 = val_15;
            goto label_20;
            label_9:
            if(0 == this.scrollRect.horizontalScrollbar)
            {
                    return;
            }
            
            label_14:
            val_15 = this.scrollRect.horizontalScrollbar;
            val_16 = 0;
            label_20:
            val_15.numberOfSteps = 0;
        }
        private void LateUpdate()
        {
            float val_11;
            float val_12;
            float val_13;
            this.UpdateListItemsSize();
            this.UpdateListItemPositions();
            if(this.lerp != false)
            {
                    this.UpdateScrollbar(linkSteps:  false);
                UnityEngine.Vector3 val_1 = this.listContainerTransform.localPosition;
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = this.lerpTarget, y = V11.16B, z = V12.16B}, t:  UnityEngine.Time.deltaTime * 7.5f);
                val_11 = val_4.x;
                val_12 = val_4.z;
                this.listContainerTransform.localPosition = new UnityEngine.Vector3() {x = val_11, y = val_4.y, z = val_12};
                UnityEngine.Vector3 val_5 = this.listContainerTransform.localPosition;
                val_13 = 0.001f;
                if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = this.lerpTarget, y = V11.16B, z = V12.16B})) < 0)
            {
                    val_11 = this.lerpTarget;
                val_13 = val_4.y;
                val_12 = val_4.z;
                this.listContainerTransform.localPosition = new UnityEngine.Vector3() {x = val_11, y = val_13, z = val_12};
                this.lerp = false;
                this.UpdateScrollbar(linkSteps:  this.linkScrolbarSteps);
            }
            
                UnityEngine.Vector3 val_7 = this.listContainerTransform.localPosition;
                if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = this.lerpTarget, y = V11.16B, z = val_4.z})) < 0)
            {
                    this.PageChanged(currentPage:  this.CurrentPage());
            }
            
            }
            
            bool val_11 = this.fastSwipeTimer;
            if((val_11 & 255) == false)
            {
                    return;
            }
            
            val_11 = val_11 >> 32;
            val_11 = val_11 + 1;
            this.fastSwipeCounter = val_11;
        }
        public void NextScreen()
        {
            this.UpdateListItemPositions();
            int val_6 = this.pages;
            val_6 = val_6 - 1;
            if(this.CurrentPage() >= val_6)
            {
                    return;
            }
            
            this.lerp = true;
            var val_7 = 12;
            val_7 = this.pageAnchorPositions + (((long)this.CurrentPage() + 1) * val_7);
            this.lerpTarget = ((long)(int)((val_2 + 1)) * 12) + this.pageAnchorPositions + 32;
            mem[1152921512738835532] = ((long)(int)((val_2 + 1)) * 12) + this.pageAnchorPositions + 32 + 4;
            mem[1152921512738835536] = ((long)(int)((val_2 + 1)) * 12) + this.pageAnchorPositions + 40;
            this.PageChanged(currentPage:  this.CurrentPage() + 1);
        }
        public void PreviousScreen()
        {
            this.UpdateListItemPositions();
            if(this.CurrentPage() < 1)
            {
                    return;
            }
            
            this.lerp = true;
            var val_6 = 12;
            val_6 = this.pageAnchorPositions + (((long)this.CurrentPage() - 1) * val_6);
            this.lerpTarget = ((long)(int)((val_2 - 1)) * 12) + this.pageAnchorPositions + 32;
            mem[1152921512739021260] = ((long)(int)((val_2 - 1)) * 12) + this.pageAnchorPositions + 32 + 4;
            mem[1152921512739021264] = ((long)(int)((val_2 - 1)) * 12) + this.pageAnchorPositions + 40;
            this.PageChanged(currentPage:  this.CurrentPage() - 1);
        }
        private void NextScreenCommand()
        {
            int val_1 = this.pages - 1;
            if(this.pageOnDragStart >= val_1)
            {
                    return;
            }
            
            int val_2 = this.itemsVisibleAtOnce + this.pageOnDragStart;
            int val_3 = UnityEngine.Mathf.Min(a:  0, b:  val_1);
            this.lerp = true;
            var val_4 = 12;
            val_4 = this.pageAnchorPositions + ((long)val_3 * val_4);
            this.lerpTarget = ((long)(int)(val_3) * 12) + this.pageAnchorPositions + 32;
            mem[1152921512739206988] = ((long)(int)(val_3) * 12) + this.pageAnchorPositions + 32 + 4;
            mem[1152921512739206992] = ((long)(int)(val_3) * 12) + this.pageAnchorPositions + 40;
            this.PageChanged(currentPage:  val_3);
        }
        private void PrevScreenCommand()
        {
            if(this.pageOnDragStart < 1)
            {
                    return;
            }
            
            int val_1 = this.pageOnDragStart - this.itemsVisibleAtOnce;
            int val_2 = UnityEngine.Mathf.Max(a:  0, b:  0);
            this.lerp = true;
            var val_3 = 12;
            val_3 = this.pageAnchorPositions + ((long)val_2 * val_3);
            this.lerpTarget = ((long)(int)(val_2) * 12) + this.pageAnchorPositions + 32;
            mem[1152921512739392716] = ((long)(int)(val_2) * 12) + this.pageAnchorPositions + 32 + 4;
            mem[1152921512739392720] = ((long)(int)(val_2) * 12) + this.pageAnchorPositions + 40;
            this.PageChanged(currentPage:  val_2);
        }
        public int CurrentPage()
        {
            float val_9;
            var val_10;
            float val_11;
            if(this.direction != 0)
            {
                    UnityEngine.Vector3 val_1 = this.listContainerTransform.localPosition;
                val_9 = this.listContainerSize;
                val_10 = null;
                val_11 = val_1.y - this.listContainerMinPosition;
            }
            else
            {
                    UnityEngine.Vector3 val_2 = this.listContainerTransform.localPosition;
                val_9 = this.listContainerSize;
                val_11 = this.listContainerMaxPosition - val_2.x;
                val_10 = null;
            }
            
            val_9 = (UnityEngine.Mathf.Clamp(value:  val_11, min:  0f, max:  val_9)) / this.itemSize;
            return UnityEngine.Mathf.Clamp(value:  0, min:  UnityEngine.Mathf.RoundToInt(f:  val_9), max:  0);
        }
        public void ChangePage(int page)
        {
            if((page & 2147483648) != 0)
            {
                    return;
            }
            
            if(this.pages <= page)
            {
                    return;
            }
            
            this.lerp = true;
            var val_1 = 12;
            val_1 = this.pageAnchorPositions + ((long)page * val_1);
            this.lerpTarget = ((long)(int)(page) * 12) + this.pageAnchorPositions + 32;
            mem[1152921512739715020] = ((long)(int)(page) * 12) + this.pageAnchorPositions + 32 + 4;
            mem[1152921512739715024] = ((long)(int)(page) * 12) + this.pageAnchorPositions + 40;
            this.PageChanged(currentPage:  page);
        }
        private void PageChanged(int currentPage)
        {
            UnityEngine.UI.Button val_6;
            this.startingPage = currentPage;
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    this.nextButton.interactable = ((this.pages - 1) > currentPage) ? 1 : 0;
            }
            
            val_6 = this.prevButton;
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    val_6 = this.prevButton;
                val_6.interactable = (currentPage > 0) ? 1 : 0;
            }
            
            if(this.onPageChange == null)
            {
                    return;
            }
            
            this.onPageChange.Invoke(page:  currentPage);
        }
        public void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.UpdateScrollbar(linkSteps:  false);
            this.fastSwipeCounter = 0;
            this.fastSwipeTimer = true;
            UnityEngine.Vector2 val_1 = eventData.position;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            this.positionOnDragStart = val_2;
            mem[1152921512740021028] = val_2.y;
            mem[1152921512740021032] = val_2.z;
            this.pageOnDragStart = this.CurrentPage();
        }
        public void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            UnityEngine.Vector3 val_5;
            float val_6;
            this.startDrag = true;
            if(this.direction != 0)
            {
                    UnityEngine.Vector2 val_1 = eventData.position;
                val_6 = val_1.y - S8;
            }
            else
            {
                    val_5 = this.positionOnDragStart;
                UnityEngine.Vector2 val_2 = eventData.position;
                val_6 = val_5 - val_2.x;
            }
            
            if(this.useFastSwipe == false)
            {
                goto label_8;
            }
            
            this.fastSwipe = false;
            int val_5 = this.fastSwipeTarget;
            this.fastSwipeTimer = false;
            if((this.fastSwipeCounter > val_5) || (System.Math.Abs(val_6) <= (float)this.fastSwipeThreshold))
            {
                goto label_6;
            }
            
            this.fastSwipe = true;
            goto label_7;
            label_6:
            val_5 = val_5 & 1095216660480;
            if(val_5 == 0)
            {
                goto label_8;
            }
            
            label_7:
            if(val_6 <= 0f)
            {
                goto label_9;
            }
            
            this.NextScreenCommand();
            return;
            label_8:
            this.lerp = true;
            var val_6 = 12;
            val_6 = this.pageAnchorPositions + ((long)this.CurrentPage() * val_6);
            this.lerpTarget = ((long)(int)(val_3) * 12) + this.pageAnchorPositions + 32;
            mem[1152921512740182092] = ((long)(int)(val_3) * 12) + this.pageAnchorPositions + 36;
            mem[1152921512740182096] = ((long)(int)(val_3) * 12) + this.pageAnchorPositions + 40;
            return;
            label_9:
            this.PrevScreenCommand();
        }
        public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.lerp = false;
            if(this.startDrag == false)
            {
                    return;
            }
            
            this.OnBeginDrag(eventData:  eventData);
            this.startDrag = false;
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
