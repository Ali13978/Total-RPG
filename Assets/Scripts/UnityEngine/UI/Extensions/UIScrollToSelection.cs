using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    public class UIScrollToSelection : MonoBehaviour
    {
        // Fields
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Extensions.UIScrollToSelection.ScrollType scrollDirection;
        [UnityEngine.SerializeField]
        private float scrollSpeed;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private bool cancelScrollOnInput;
        [UnityEngine.SerializeField]
        private System.Collections.Generic.List<UnityEngine.KeyCode> cancelScrollKeycodes;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.RectTransform <ScrollWindow>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.UI.ScrollRect <TargetScrollRect>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.GameObject <LastCheckedGameObject>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.RectTransform <CurrentTargetRectTransform>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <IsManualScrollingAvailable>k__BackingField;
        
        // Properties
        protected UnityEngine.RectTransform LayoutListGroup { get; }
        protected UnityEngine.UI.Extensions.UIScrollToSelection.ScrollType ScrollDirection { get; }
        protected float ScrollSpeed { get; }
        protected bool CancelScrollOnInput { get; }
        protected System.Collections.Generic.List<UnityEngine.KeyCode> CancelScrollKeycodes { get; }
        protected UnityEngine.RectTransform ScrollWindow { get; set; }
        protected UnityEngine.UI.ScrollRect TargetScrollRect { get; set; }
        protected UnityEngine.EventSystems.EventSystem CurrentEventSystem { get; }
        protected UnityEngine.GameObject LastCheckedGameObject { get; set; }
        protected UnityEngine.GameObject CurrentSelectedGameObject { get; }
        protected UnityEngine.RectTransform CurrentTargetRectTransform { get; set; }
        protected bool IsManualScrollingAvailable { get; set; }
        
        // Methods
        public UIScrollToSelection()
        {
            this.scrollSpeed = 10f;
            this.cancelScrollKeycodes = new System.Collections.Generic.List<UnityEngine.KeyCode>();
        }
        protected UnityEngine.RectTransform get_LayoutListGroup()
        {
            if(0 == (this.<TargetScrollRect>k__BackingField))
            {
                    return 0;
            }
            
            if((this.<TargetScrollRect>k__BackingField) != null)
            {
                    return this.<TargetScrollRect>k__BackingField.content;
            }
            
            return this.<TargetScrollRect>k__BackingField.content;
        }
        protected UnityEngine.UI.Extensions.UIScrollToSelection.ScrollType get_ScrollDirection()
        {
            return (ScrollType)this.scrollDirection;
        }
        protected float get_ScrollSpeed()
        {
            return (float)this.scrollSpeed;
        }
        protected bool get_CancelScrollOnInput()
        {
            return (bool)this.cancelScrollOnInput;
        }
        protected System.Collections.Generic.List<UnityEngine.KeyCode> get_CancelScrollKeycodes()
        {
            return (System.Collections.Generic.List<UnityEngine.KeyCode>)this.cancelScrollKeycodes;
        }
        protected UnityEngine.RectTransform get_ScrollWindow()
        {
            return (UnityEngine.RectTransform)this.<ScrollWindow>k__BackingField;
        }
        protected void set_ScrollWindow(UnityEngine.RectTransform value)
        {
            this.<ScrollWindow>k__BackingField = value;
        }
        protected UnityEngine.UI.ScrollRect get_TargetScrollRect()
        {
            return (UnityEngine.UI.ScrollRect)this.<TargetScrollRect>k__BackingField;
        }
        protected void set_TargetScrollRect(UnityEngine.UI.ScrollRect value)
        {
            this.<TargetScrollRect>k__BackingField = value;
        }
        protected UnityEngine.EventSystems.EventSystem get_CurrentEventSystem()
        {
            return UnityEngine.EventSystems.EventSystem.current;
        }
        protected UnityEngine.GameObject get_LastCheckedGameObject()
        {
            return (UnityEngine.GameObject)this.<LastCheckedGameObject>k__BackingField;
        }
        protected void set_LastCheckedGameObject(UnityEngine.GameObject value)
        {
            this.<LastCheckedGameObject>k__BackingField = value;
        }
        protected UnityEngine.GameObject get_CurrentSelectedGameObject()
        {
            UnityEngine.EventSystems.EventSystem val_1 = UnityEngine.EventSystems.EventSystem.current;
            if(val_1 != null)
            {
                    return val_1.currentSelectedGameObject;
            }
            
            return val_1.currentSelectedGameObject;
        }
        protected UnityEngine.RectTransform get_CurrentTargetRectTransform()
        {
            return (UnityEngine.RectTransform)this.<CurrentTargetRectTransform>k__BackingField;
        }
        protected void set_CurrentTargetRectTransform(UnityEngine.RectTransform value)
        {
            this.<CurrentTargetRectTransform>k__BackingField = value;
        }
        protected bool get_IsManualScrollingAvailable()
        {
            return (bool)this.<IsManualScrollingAvailable>k__BackingField;
        }
        protected void set_IsManualScrollingAvailable(bool value)
        {
            this.<IsManualScrollingAvailable>k__BackingField = value;
        }
        protected virtual void Awake()
        {
            UnityEngine.UI.ScrollRect val_1 = this.GetComponent<UnityEngine.UI.ScrollRect>();
            this.<TargetScrollRect>k__BackingField = val_1;
            this.<ScrollWindow>k__BackingField = val_1.GetComponent<UnityEngine.RectTransform>();
        }
        protected virtual void Start()
        {
        
        }
        protected virtual void Update()
        {
            this.UpdateReferences();
            this.CheckIfScrollingShouldBeLocked();
            this.ScrollRectToLevelSelection();
        }
        private void UpdateReferences()
        {
            UnityEngine.Object val_16;
            UnityEngine.RectTransform val_17;
            val_16 = this.CurrentSelectedGameObject;
            bool val_2 = UnityEngine.Object.op_Inequality(x:  0, y:  val_16);
            if(val_2 != false)
            {
                    bool val_4 = UnityEngine.Object.op_Inequality(x:  0, y:  val_2.CurrentSelectedGameObject);
                val_17 = 0;
                if(val_4 != false)
            {
                    UnityEngine.RectTransform val_6 = val_4.CurrentSelectedGameObject.GetComponent<UnityEngine.RectTransform>();
                val_17 = val_6;
            }
            
                this.<CurrentTargetRectTransform>k__BackingField = val_17;
                bool val_8 = UnityEngine.Object.op_Inequality(x:  0, y:  val_6.CurrentSelectedGameObject);
                if(val_8 != false)
            {
                    val_16 = this.LayoutListGroup.transform;
                bool val_14 = UnityEngine.Object.op_Equality(x:  0, y:  val_8.CurrentSelectedGameObject.transform.parent);
                if(val_14 != false)
            {
                    this.<IsManualScrollingAvailable>k__BackingField = false;
            }
            
            }
            
            }
            
            this.<LastCheckedGameObject>k__BackingField = val_14.CurrentSelectedGameObject;
        }
        private void CheckIfScrollingShouldBeLocked()
        {
            System.Collections.Generic.List<UnityEngine.KeyCode> val_4;
            if(this.cancelScrollOnInput == false)
            {
                    return;
            }
            
            if((this.<IsManualScrollingAvailable>k__BackingField) == true)
            {
                    return;
            }
            
            var val_4 = 0;
            do
            {
                val_4 = this.cancelScrollKeycodes;
                if(val_4 >= val_4.Count)
            {
                    return;
            }
            
                val_4 = this.cancelScrollKeycodes.Item[0];
                val_4 = val_4 + 1;
            }
            while((UnityEngine.Input.GetKeyDown(key:  0)) == false);
            
            this.<IsManualScrollingAvailable>k__BackingField = true;
        }
        private void ScrollRectToLevelSelection()
        {
            if(0 == (this.<TargetScrollRect>k__BackingField))
            {
                    return;
            }
            
            if(0 == this.LayoutListGroup)
            {
                    return;
            }
            
            if(0 == (this.<ScrollWindow>k__BackingField))
            {
                    return;
            }
            
            if((this.<IsManualScrollingAvailable>k__BackingField) == true)
            {
                    return;
            }
            
            if(0 == (this.<CurrentTargetRectTransform>k__BackingField))
            {
                    return;
            }
            
            UnityEngine.Transform val_13 = this.LayoutListGroup.transform;
            if(0 != (this.<CurrentTargetRectTransform>k__BackingField.transform.parent))
            {
                    return;
            }
            
            if(this.scrollDirection == 2)
            {
                goto label_20;
            }
            
            if(this.scrollDirection == 1)
            {
                goto label_21;
            }
            
            if(this.scrollDirection != 0)
            {
                    return;
            }
            
            this.UpdateVerticalScrollPosition(selection:  this.<CurrentTargetRectTransform>k__BackingField);
            return;
            label_20:
            this.UpdateVerticalScrollPosition(selection:  this.<CurrentTargetRectTransform>k__BackingField);
            label_21:
            this.UpdateHorizontalScrollPosition(selection:  this.<CurrentTargetRectTransform>k__BackingField);
        }
        private void UpdateVerticalScrollPosition(UnityEngine.RectTransform selection)
        {
            float val_16;
            var val_17;
            if(selection != null)
            {
                    UnityEngine.Vector2 val_1 = selection.anchoredPosition;
                val_16 = val_1.y;
            }
            else
            {
                    UnityEngine.Vector2 val_2 = 0.anchoredPosition;
                val_16 = val_2.y;
            }
            
            UnityEngine.Rect val_3 = selection.rect;
            UnityEngine.Rect val_4 = this.<ScrollWindow>k__BackingField.rect;
            UnityEngine.Vector2 val_6 = this.LayoutListGroup.anchoredPosition;
            if(val_6.y > (-val_16))
            {
                    val_17 = val_16 + val_6.y;
            }
            else
            {
                    float val_7 = val_3.m_XMin - val_16;
                val_6.y = val_4.m_XMin + val_6.y;
            }
            
            UnityEngine.Rect val_12 = this.LayoutListGroup.rect;
            float val_14 = ((val_7 > val_6.y) ? (val_6.y - val_7) : 0f) / val_12.m_XMin;
            val_14 = val_14 * UnityEngine.Time.deltaTime;
            val_14 = val_14 * this.scrollSpeed;
            val_14 = (this.<TargetScrollRect>k__BackingField.verticalNormalizedPosition) + val_14;
            this.<TargetScrollRect>k__BackingField.verticalNormalizedPosition = val_14;
        }
        private void UpdateHorizontalScrollPosition(UnityEngine.RectTransform selection)
        {
            float val_15;
            float val_16;
            var val_17;
            if(selection != null)
            {
                    UnityEngine.Vector2 val_1 = selection.anchoredPosition;
                val_15 = val_1.x;
            }
            else
            {
                    UnityEngine.Vector2 val_2 = 0.anchoredPosition;
                val_15 = val_2.x;
            }
            
            UnityEngine.Rect val_3 = selection.rect;
            float val_13 = val_3.m_XMin;
            UnityEngine.Rect val_4 = this.<ScrollWindow>k__BackingField.rect;
            UnityEngine.Vector2 val_6 = this.LayoutListGroup.anchoredPosition;
            val_16 = -val_6.x;
            if(val_15 < 0)
            {
                    val_17 = val_16 - val_15;
            }
            else
            {
                    val_16 = val_15 + val_13;
                val_6.x = val_4.m_XMin - val_6.x;
                val_13 = (val_16 > val_6.x) ? (val_6.x - val_16) : 0f;
            }
            
            UnityEngine.Rect val_10 = this.LayoutListGroup.rect;
            float val_12 = (-val_13) / val_10.m_XMin;
            val_12 = val_12 * UnityEngine.Time.deltaTime;
            val_12 = val_12 * this.scrollSpeed;
            val_12 = (this.<TargetScrollRect>k__BackingField.horizontalNormalizedPosition) + val_12;
            this.<TargetScrollRect>k__BackingField.horizontalNormalizedPosition = val_12;
        }
        private float GetScrollOffset(float position, float listAnchorPosition, float targetLength, float maskLength)
        {
            if(position < 0)
            {
                    position = listAnchorPosition - position;
                return (float)position;
            }
            
            position = position + targetLength;
            listAnchorPosition = listAnchorPosition + maskLength;
            targetLength = listAnchorPosition - position;
            return (float)(position > listAnchorPosition) ? (targetLength) : 0f;
        }
    
    }

}
