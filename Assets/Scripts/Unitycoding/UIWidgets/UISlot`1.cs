using UnityEngine;

namespace Unitycoding.UIWidgets
{
    public class UISlot<T> : MonoBehaviour, IDropHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerUpHandler, IPointerDownHandler, IEventSystemHandler
    {
        // Fields
        [UnityEngine.HideInInspector]
        public int id;
        public Unitycoding.UIWidgets.UIContainer<T> container;
        public static T draggedItem;
        public static bool draggedReference;
        protected UnityEngine.UI.ScrollRect scrollRect;
        protected bool placingItem;
        
        // Properties
        public T observedItem { get; }
        
        // Methods
        public UISlot<T>()
        {
            mem[1152921512652769944] = 0;
            if(this != null)
            {
                    return;
            }
        
        }
        public T get_observedItem()
        {
            var val_8;
            var val_9;
            val_8 = __RuntimeMethodHiddenParam;
            if(0 == 34820096)
            {
                    return 0;
            }
            
            val_8 = ???;
            val_9 = ???;
            goto __RuntimeMethodHiddenParam + 24 + 168;
        }
        protected virtual void Start()
        {
            mem[1152921512652998048] = this;
            mem[1152921512652998040] = this;
            mem[1152921512652998056] = this.GetComponentInParent<UnityEngine.UI.ScrollRect>();
        }
        public virtual T Replace(T item)
        {
            var val_8;
            var val_9;
            val_8 = item;
            if(0 == 34820096)
            {
                    return (object)val_8;
            }
            
            val_8 = ???;
            val_9 = ???;
            goto mem[34820096] + 448;
        }
        public virtual void UpdateSlot(T item)
        {
        
        }
        public virtual void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            var val_8;
            Unitycoding.UIWidgets.UISlot<T> val_9;
            var val_10;
            val_8 = eventData;
            if((this != null) && (mem[34820369] != false))
            {
                    if(mem[34820371] != false)
            {
                    val_9 = this;
            }
            else
            {
                    val_9 = this;
            }
            
                mem2[0] = val_9;
            }
            
            if(0 == (__RuntimeMethodHiddenParam + 24 + 168 + 56))
            {
                    return;
            }
            
            val_8 = ???;
            val_10 = ???;
            goto typeof(Unitycoding.UIWidgets.UISlot<T>).__il2cppRuntimeField_3D0;
        }
        public virtual void OnDrag(UnityEngine.EventSystems.PointerEventData data)
        {
            var val_8;
            var val_9;
            val_8 = data;
            if(0 == 34820096)
            {
                    return;
            }
            
            val_8 = ???;
            val_9 = ???;
            goto typeof(Unitycoding.UIWidgets.UISlot<T>).__il2cppRuntimeField_3F0;
        }
        public virtual void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            var val_8;
            var val_9;
            val_8 = eventData;
            if(((this & 1) != 0) && ((__RuntimeMethodHiddenParam + 24 + 168 + 56 + 160 + 274) != 0))
            {
                    mem2[0] = this;
            }
            
            if(0 == (__RuntimeMethodHiddenParam + 24 + 168 + 56))
            {
                    return;
            }
            
            val_8 = ???;
            val_9 = ???;
            goto typeof(Unitycoding.UIWidgets.UISlot<T>).__il2cppRuntimeField_3E0;
        }
        public virtual void OnDrop(UnityEngine.EventSystems.PointerEventData data)
        {
            if(((this & 1) != 0) && ((__RuntimeMethodHiddenParam + 24 + 168 + 56 + 160 + 274) != 0))
            {
                    mem2[0] = this;
            }
            
            if(this == null)
            {
                
            }
        
        }
        public virtual void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
        {
            mem[1152921512653839408] = ((__RuntimeMethodHiddenParam + 24 + 168 + 56 + 160) != 0) ? 1 : 0;
        }
        public virtual void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
        {
            var val_2;
            var val_3;
            val_2 = __RuntimeMethodHiddenParam;
            mem[1152921512653959600] = ((__RuntimeMethodHiddenParam + 24 + 168 + 56 + 160) != 0) ? 1 : 0;
            val_3 = mem[__RuntimeMethodHiddenParam + 24 + 168 + 56 + 160];
            val_3 = __RuntimeMethodHiddenParam + 24 + 168 + 56 + 160;
            if((this & 1) == 0)
            {
                    return;
            }
            
            if((__RuntimeMethodHiddenParam + 24 + 168 + 56 + 160 + 274) == 0)
            {
                    return;
            }
            
            val_3 = mem[__RuntimeMethodHiddenParam + 24 + 168 + 56 + 160];
            val_3 = __RuntimeMethodHiddenParam + 24 + 168 + 56 + 160;
            val_2 = mem[__RuntimeMethodHiddenParam + 24 + 168 + 56];
            val_2 = __RuntimeMethodHiddenParam + 24 + 168 + 56;
            mem2[0] = this;
        }
        public virtual bool Validate(T item)
        {
            var val_11;
            System.Type val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            if(item == null)
            {
                goto label_1;
            }
            
            UnityEngine.Component[] val_2 = this.GetComponents(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_11 = System.Linq.Enumerable.ToList<UnityEngine.Component>(source:  0);
            if(0 != X23)
            {
                    val_12 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
                val_11.AddRange(collection:  this.GetComponents(type:  val_12));
            }
            
            val_13 = 0;
            goto label_12;
            label_16:
            val_13 = 1;
            label_12:
            if(val_13 >= val_11.Count)
            {
                goto label_14;
            }
            
            if(val_11.Item[1] == null)
            {
                goto label_16;
            }
            
            val_14 = public UnityEngine.Component System.Collections.Generic.List<UnityEngine.Component>::get_Item(int index);
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_14 = 0;
            val_15 = val_11.Item[1];
            goto __RuntimeMethodHiddenParam + 24 + 168 + 96;
            label_1:
            val_16 = 0;
            return (bool)val_16;
            label_14:
            val_16 = 1;
            return (bool)val_16;
        }
        public virtual void MoveTo(string container)
        {
            if(0 == 0)
            {
                    return;
            }
            
            if((0 & 1) != 0)
            {
                    return;
            }
            
            if(this == null)
            {
                
            }
        
        }
    
    }

}
