using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    public class ScrollRectEx : ScrollRect
    {
        // Fields
        private bool routeToParent;
        
        // Methods
        public ScrollRectEx()
        {
        
        }
        private void DoForParents<T>(System.Action<T> action)
        {
            UnityEngine.Object val_9;
            var val_10;
            var val_11;
            val_9 = this.transform.parent;
            goto label_3;
            label_20:
            val_9 = val_9.parent;
            label_3:
            if(0 == val_9)
            {
                    return;
            }
            
            val_10 = 0;
            goto label_8;
            label_18:
            val_10 = 1;
            label_8:
            if(val_10 >= val_6.Length)
            {
                goto label_10;
            }
            
            T val_9 = val_9.GetComponents<UnityEngine.Component>()[1];
            if(val_9 == 0)
            {
                goto label_18;
            }
            
            if(val_9 == 0)
            {
                goto label_14;
            }
            
            val_11 = val_9;
            if(val_11 != 0)
            {
                goto label_15;
            }
            
            label_14:
            val_11 = 0;
            label_15:
            if((val_11 == 0) || (val_11 != 0))
            {
                goto label_18;
            }
            
            goto label_18;
            label_10:
            if(val_9 != null)
            {
                goto label_20;
            }
            
            goto label_20;
        }
        public override void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            typeof(ScrollRectEx.<OnInitializePotentialDrag>c__AnonStorey0).__il2cppRuntimeField_10 = eventData;
            this.DoForParents<UnityEngine.EventSystems.IInitializePotentialDragHandler>(action:  new System.Action<UnityEngine.EventSystems.IInitializePotentialDragHandler>(object:  new System.Object(), method:  System.Void ScrollRectEx.<OnInitializePotentialDrag>c__AnonStorey0::<>m__0(UnityEngine.EventSystems.IInitializePotentialDragHandler parent)));
            this.OnInitializePotentialDrag(eventData:  typeof(ScrollRectEx.<OnInitializePotentialDrag>c__AnonStorey0).__il2cppRuntimeField_10);
        }
        public override void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            typeof(ScrollRectEx.<OnDrag>c__AnonStorey1).__il2cppRuntimeField_10 = eventData;
            if(this.routeToParent != false)
            {
                    this.DoForParents<UnityEngine.EventSystems.IDragHandler>(action:  new System.Action<UnityEngine.EventSystems.IDragHandler>(object:  new System.Object(), method:  System.Void ScrollRectEx.<OnDrag>c__AnonStorey1::<>m__0(UnityEngine.EventSystems.IDragHandler parent)));
                return;
            }
            
            this.OnDrag(eventData:  eventData);
        }
        public override void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            UnityEngine.EventSystems.PointerEventData val_11;
            float val_12;
            val_11 = eventData;
            typeof(ScrollRectEx.<OnBeginDrag>c__AnonStorey2).__il2cppRuntimeField_10 = val_11;
            if(this.horizontal == true)
            {
                goto label_2;
            }
            
            UnityEngine.Vector2 val_4 = typeof(ScrollRectEx.<OnBeginDrag>c__AnonStorey2).__il2cppRuntimeField_10.delta;
            val_11 = typeof(ScrollRectEx.<OnBeginDrag>c__AnonStorey2).__il2cppRuntimeField_10;
            val_12 = System.Math.Abs(val_4.x);
            UnityEngine.Vector2 val_5 = val_11.delta;
            if(val_12 > System.Math.Abs(val_5.y))
            {
                goto label_5;
            }
            
            label_2:
            if(this.vertical == true)
            {
                goto label_10;
            }
            
            UnityEngine.Vector2 val_8 = typeof(ScrollRectEx.<OnBeginDrag>c__AnonStorey2).__il2cppRuntimeField_10.delta;
            val_11 = typeof(ScrollRectEx.<OnBeginDrag>c__AnonStorey2).__il2cppRuntimeField_10;
            val_12 = System.Math.Abs(val_8.x);
            UnityEngine.Vector2 val_9 = val_11.delta;
            float val_12 = System.Math.Abs(val_9.y);
            if(val_12 >= 0)
            {
                goto label_10;
            }
            
            label_5:
            this.routeToParent = true;
            this.DoForParents<UnityEngine.EventSystems.IBeginDragHandler>(action:  new System.Action<UnityEngine.EventSystems.IBeginDragHandler>(object:  new System.Object(), method:  System.Void ScrollRectEx.<OnBeginDrag>c__AnonStorey2::<>m__0(UnityEngine.EventSystems.IBeginDragHandler parent)));
            return;
            label_10:
            this.routeToParent = false;
            this.OnBeginDrag(eventData:  typeof(ScrollRectEx.<OnBeginDrag>c__AnonStorey2).__il2cppRuntimeField_10);
        }
        public override void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            typeof(ScrollRectEx.<OnEndDrag>c__AnonStorey3).__il2cppRuntimeField_10 = eventData;
            if(this.routeToParent != false)
            {
                    this.DoForParents<UnityEngine.EventSystems.IEndDragHandler>(action:  new System.Action<UnityEngine.EventSystems.IEndDragHandler>(object:  new System.Object(), method:  System.Void ScrollRectEx.<OnEndDrag>c__AnonStorey3::<>m__0(UnityEngine.EventSystems.IEndDragHandler parent)));
            }
            else
            {
                    this.OnEndDrag(eventData:  eventData);
            }
            
            this.routeToParent = false;
        }
        public override void OnScroll(UnityEngine.EventSystems.PointerEventData eventData)
        {
            UnityEngine.EventSystems.PointerEventData val_11;
            float val_12;
            val_11 = eventData;
            typeof(ScrollRectEx.<OnScroll>c__AnonStorey4).__il2cppRuntimeField_10 = val_11;
            if(this.horizontal == true)
            {
                goto label_2;
            }
            
            UnityEngine.Vector2 val_4 = typeof(ScrollRectEx.<OnScroll>c__AnonStorey4).__il2cppRuntimeField_10.scrollDelta;
            val_11 = typeof(ScrollRectEx.<OnScroll>c__AnonStorey4).__il2cppRuntimeField_10;
            val_12 = System.Math.Abs(val_4.x);
            UnityEngine.Vector2 val_5 = val_11.scrollDelta;
            if(val_12 > System.Math.Abs(val_5.y))
            {
                goto label_5;
            }
            
            label_2:
            if(this.vertical == true)
            {
                goto label_10;
            }
            
            UnityEngine.Vector2 val_8 = typeof(ScrollRectEx.<OnScroll>c__AnonStorey4).__il2cppRuntimeField_10.scrollDelta;
            val_11 = typeof(ScrollRectEx.<OnScroll>c__AnonStorey4).__il2cppRuntimeField_10;
            val_12 = System.Math.Abs(val_8.x);
            UnityEngine.Vector2 val_9 = val_11.scrollDelta;
            float val_12 = System.Math.Abs(val_9.y);
            if(val_12 >= 0)
            {
                goto label_10;
            }
            
            label_5:
            this.routeToParent = true;
            this.DoForParents<UnityEngine.EventSystems.IScrollHandler>(action:  new System.Action<UnityEngine.EventSystems.IScrollHandler>(object:  new System.Object(), method:  System.Void ScrollRectEx.<OnScroll>c__AnonStorey4::<>m__0(UnityEngine.EventSystems.IScrollHandler parent)));
            return;
            label_10:
            this.routeToParent = false;
            this.OnScroll(data:  typeof(ScrollRectEx.<OnScroll>c__AnonStorey4).__il2cppRuntimeField_10);
        }
    
    }

}
