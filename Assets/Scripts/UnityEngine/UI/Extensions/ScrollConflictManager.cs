using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    public class ScrollConflictManager : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler, IEventSystemHandler
    {
        // Fields
        public UnityEngine.UI.ScrollRect ParentScrollRect;
        private UnityEngine.UI.ScrollRect _myScrollRect;
        private bool scrollOther;
        private bool scrollOtherHorizontally;
        
        // Methods
        public ScrollConflictManager()
        {
        
        }
        private void Awake()
        {
            UnityEngine.UI.ScrollRect val_9;
            var val_10;
            object val_11;
            UnityEngine.UI.ScrollRect val_1 = this.GetComponent<UnityEngine.UI.ScrollRect>();
            this._myScrollRect = val_1;
            bool val_2 = val_1.vertical;
            this.scrollOtherHorizontally = val_2;
            if(val_2 != false)
            {
                    if(this._myScrollRect.horizontal != false)
            {
                    UnityEngine.Debug.Log(message:  0);
            }
            
                val_9 = this.ParentScrollRect;
                if(val_9.horizontal == true)
            {
                    return;
            }
            
                val_10 = "The other scroll rect doesnt support scrolling horizontally";
                val_11 = 0;
            }
            else
            {
                    val_9 = this.ParentScrollRect;
                if(val_9.vertical != false)
            {
                    return;
            }
            
                val_10 = "The other scroll rect doesnt support scrolling vertically";
                val_11 = 0;
            }
            
            UnityEngine.Debug.Log(message:  val_11);
        }
        public void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            var val_16;
            var val_17;
            float val_18;
            float val_19;
            val_17 = eventData;
            if(val_17 != null)
            {
                    UnityEngine.Vector2 val_1 = val_17.position;
                val_18 = val_1.x;
            }
            else
            {
                    UnityEngine.Vector2 val_2 = 0.position;
                val_18 = val_2.x;
            }
            
            UnityEngine.Vector2 val_3 = val_17.pressPosition;
            float val_16 = val_3.x;
            val_16 = val_18 - val_16;
            if(val_17 != null)
            {
                    UnityEngine.Vector2 val_4 = val_17.position;
                val_19 = val_4.y;
            }
            else
            {
                    UnityEngine.Vector2 val_5 = 0.position;
                val_19 = val_5.y;
            }
            
            float val_17 = System.Math.Abs(val_16);
            UnityEngine.Vector2 val_6 = val_17.pressPosition;
            float val_18 = System.Math.Abs(val_19 - val_6.y);
            if(this.scrollOtherHorizontally != false)
            {
                    if(val_17 <= val_18)
            {
                    return;
            }
            
            }
            else
            {
                    if(val_18 <= val_17)
            {
                    return;
            }
            
            }
            
            this.scrollOther = true;
            this._myScrollRect.enabled = false;
            val_17 = ???;
            val_16 = ???;
            val_19 = ???;
            goto typeof(UnityEngine.UI.ScrollRect).__il2cppRuntimeField_3D0;
        }
        public void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.scrollOther == false)
            {
                    return;
            }
            
            this.scrollOther = false;
            this._myScrollRect.enabled = true;
            eventData = ???;
            goto typeof(UnityEngine.UI.ScrollRect).__il2cppRuntimeField_3E0;
        }
        public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this.scrollOther == false)
            {
                    return;
            }
            
            eventData = ???;
            goto typeof(UnityEngine.UI.ScrollRect).__il2cppRuntimeField_3F0;
        }
    
    }

}
