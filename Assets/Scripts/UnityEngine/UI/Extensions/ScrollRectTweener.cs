using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    public class ScrollRectTweener : MonoBehaviour, IDragHandler, IEventSystemHandler
    {
        // Fields
        private UnityEngine.UI.ScrollRect scrollRect;
        private UnityEngine.Vector2 startPos;
        private UnityEngine.Vector2 targetPos;
        private bool wasHorizontal;
        private bool wasVertical;
        public float moveSpeed;
        public bool disableDragWhileTweening;
        
        // Methods
        public ScrollRectTweener()
        {
            this.moveSpeed = 5000f;
        }
        private void Awake()
        {
            UnityEngine.UI.ScrollRect val_1 = this.GetComponent<UnityEngine.UI.ScrollRect>();
            this.scrollRect = val_1;
            this.wasHorizontal = val_1.horizontal;
            this.wasVertical = this.scrollRect.vertical;
        }
        public void ScrollHorizontal(float normalizedX)
        {
            CinemachineFreeLook.Orbit val_2 = new CinemachineFreeLook.Orbit(h:  normalizedX, r:  this.scrollRect.verticalNormalizedPosition);
            this.Scroll(normalizedPos:  new UnityEngine.Vector2() {x = val_2.m_Height, y = val_2.m_Radius}, duration:  this.GetScrollDuration(normalizedPos:  new UnityEngine.Vector2() {x = val_2.m_Height, y = val_2.m_Radius}));
        }
        public void ScrollHorizontal(float normalizedX, float duration)
        {
            CinemachineFreeLook.Orbit val_2 = new CinemachineFreeLook.Orbit(h:  normalizedX, r:  this.scrollRect.verticalNormalizedPosition);
            this.Scroll(normalizedPos:  new UnityEngine.Vector2() {x = val_2.m_Height, y = val_2.m_Radius}, duration:  duration);
        }
        public void ScrollVertical(float normalizedY)
        {
            CinemachineFreeLook.Orbit val_2 = new CinemachineFreeLook.Orbit(h:  this.scrollRect.horizontalNormalizedPosition, r:  normalizedY);
            this.Scroll(normalizedPos:  new UnityEngine.Vector2() {x = val_2.m_Height, y = val_2.m_Radius}, duration:  this.GetScrollDuration(normalizedPos:  new UnityEngine.Vector2() {x = val_2.m_Height, y = val_2.m_Radius}));
        }
        public void ScrollVertical(float normalizedY, float duration)
        {
            CinemachineFreeLook.Orbit val_2 = new CinemachineFreeLook.Orbit(h:  this.scrollRect.horizontalNormalizedPosition, r:  normalizedY);
            this.Scroll(normalizedPos:  new UnityEngine.Vector2() {x = val_2.m_Height, y = val_2.m_Radius}, duration:  duration);
        }
        public void Scroll(UnityEngine.Vector2 normalizedPos)
        {
            this.Scroll(normalizedPos:  new UnityEngine.Vector2() {x = normalizedPos.x, y = normalizedPos.y}, duration:  this.GetScrollDuration(normalizedPos:  new UnityEngine.Vector2() {x = normalizedPos.x, y = normalizedPos.y}));
        }
        private float GetScrollDuration(UnityEngine.Vector2 normalizedPos)
        {
            UnityEngine.Vector2 val_1 = this.GetCurrentPos();
            UnityEngine.Vector2 val_2 = this.DeNormalize(normalizedPos:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            UnityEngine.Vector2 val_3 = this.DeNormalize(normalizedPos:  new UnityEngine.Vector2() {x = normalizedPos.x, y = normalizedPos.y});
            float val_4 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, b:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            val_4 = val_4 / this.moveSpeed;
            return (float)val_4;
        }
        private UnityEngine.Vector2 DeNormalize(UnityEngine.Vector2 normalizedPos)
        {
            UnityEngine.Rect val_2 = this.scrollRect.content.rect;
            UnityEngine.Rect val_4 = this.scrollRect.content.rect;
            CinemachineFreeLook.Orbit val_7 = new CinemachineFreeLook.Orbit(h:  normalizedPos.x * val_2.m_XMin, r:  normalizedPos.y * val_4.m_XMin);
            return new UnityEngine.Vector2() {x = val_7.m_Height, y = val_7.m_Radius};
        }
        private UnityEngine.Vector2 GetCurrentPos()
        {
            CinemachineFreeLook.Orbit val_3 = new CinemachineFreeLook.Orbit(h:  this.scrollRect.horizontalNormalizedPosition, r:  this.scrollRect.verticalNormalizedPosition);
            return new UnityEngine.Vector2() {x = val_3.m_Height, y = val_3.m_Radius};
        }
        public void Scroll(UnityEngine.Vector2 normalizedPos, float duration)
        {
            UnityEngine.Vector2 val_1 = this.GetCurrentPos();
            this.startPos = val_1;
            mem[1152921512789874500] = val_1.y;
            this.targetPos = normalizedPos;
            mem[1152921512789874508] = normalizedPos.y;
            if(this.disableDragWhileTweening != false)
            {
                    this.LockScrollability();
            }
            
            this.StopAllCoroutines();
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.DoMove(duration:  duration));
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator DoMove(float duration)
        {
            if(null != 0)
            {
                    typeof(ScrollRectTweener.<DoMove>c__Iterator0).__il2cppRuntimeField_10 = duration;
            }
            else
            {
                    mem[16] = duration;
            }
            
            typeof(ScrollRectTweener.<DoMove>c__Iterator0).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public UnityEngine.Vector2 EaseVector(float currentTime, UnityEngine.Vector2 startValue, UnityEngine.Vector2 changeInValue, float duration)
        {
            float val_6 = duration;
            float val_1 = currentTime / val_6;
            val_6 = val_1 * 1.570796f;
            val_1 = changeInValue.x * val_6;
            CinemachineFreeLook.Orbit val_5 = new CinemachineFreeLook.Orbit(h:  startValue.x + val_1, r:  startValue.y + (changeInValue.y * val_6));
            return new UnityEngine.Vector2() {x = val_5.m_Height, y = val_5.m_Radius};
        }
        public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.disableDragWhileTweening != false)
            {
                    return;
            }
            
            this.StopScroll();
        }
        private void StopScroll()
        {
            this.StopAllCoroutines();
            if(this.disableDragWhileTweening == false)
            {
                    return;
            }
            
            this.RestoreScrollability();
        }
        private void LockScrollability()
        {
            this.scrollRect.horizontal = false;
            this.scrollRect.vertical = false;
        }
        private void RestoreScrollability()
        {
            this.scrollRect.horizontal = (this.wasHorizontal == true) ? 1 : 0;
            this.scrollRect.vertical = (this.wasVertical == true) ? 1 : 0;
        }
    
    }

}
