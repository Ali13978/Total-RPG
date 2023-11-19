using UnityEngine;

namespace Unitycoding.UIWidgets
{
    public class UIContainer<T> : UIWidget, IDropHandler, IEventSystemHandler
    {
        // Fields
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        protected bool dynamicContainer;
        [UnityEngine.SerializeField]
        protected UnityEngine.Transform grid;
        [UnityEngine.SerializeField]
        protected UnityEngine.GameObject slotPrefab;
        public bool reference;
        public bool canDragItems;
        public bool canDropItems;
        public bool removeDraggedItems;
        private System.Collections.Generic.List<Unitycoding.UIWidgets.UISlot<T>> slots;
        private System.Collections.Generic.List<T> items;
        public Unitycoding.UIWidgets.UIContainer.ContainerEvent<T> onAdd;
        public Unitycoding.UIWidgets.UIContainer.ContainerEvent<T> onFailedToAdd;
        public Unitycoding.UIWidgets.UIContainer.ContainerEvent<T> onRemove;
        public Unitycoding.UIWidgets.UIContainer.ContainerEvent<T> onDoubleClick;
        public Unitycoding.UIWidgets.UIContainer.ContainerEvent<T> onDrop;
        public Unitycoding.UIWidgets.UIContainer.ContainerEvent<T> onClick;
        public UnityEngine.Events.UnityEvent onChange;
        private bool prevDragState;
        private bool prevDropState;
        private bool prevRemoveState;
        private bool invokeOnChange;
        
        // Properties
        public System.Collections.Generic.List<Unitycoding.UIWidgets.UISlot<T>> Slots { get; }
        public System.Collections.Generic.List<T> Items { get; }
        
        // Methods
        public UIContainer<T>()
        {
            mem[1152921512650005777] = 257;
            mem[1152921512650005779] = 1;
            mem[1152921512650005784] = __RuntimeMethodHiddenParam + 24 + 168;
            mem[1152921512650005792] = __RuntimeMethodHiddenParam + 24 + 168 + 16;
            mem[1152921512650005800] = __RuntimeMethodHiddenParam + 24 + 168 + 32;
            mem[1152921512650005808] = __RuntimeMethodHiddenParam + 24 + 168 + 32;
            mem[1152921512650005816] = __RuntimeMethodHiddenParam + 24 + 168 + 32;
            mem[1152921512650005824] = __RuntimeMethodHiddenParam + 24 + 168 + 32;
            mem[1152921512650005832] = __RuntimeMethodHiddenParam + 24 + 168 + 32;
            mem[1152921512650005840] = __RuntimeMethodHiddenParam + 24 + 168 + 32;
            mem[1152921512650005848] = new UnityEngine.Events.UnityEvent();
            mem[1152921512650005859] = 1;
            if(this != null)
            {
                    return;
            }
        
        }
        public System.Collections.Generic.List<Unitycoding.UIWidgets.UISlot<T>> get_Slots()
        {
            return (System.Collections.Generic.List<Unitycoding.UIWidgets.UISlot<T>>)this;
        }
        public System.Collections.Generic.List<T> get_Items()
        {
            goto label_0;
            label_5:
            label_0:
            if(X21 >= X21)
            {
                    return (System.Collections.Generic.List<T>)X21;
            }
            
            if(X21 != 0)
            {
                goto label_5;
            }
            
            goto label_5;
        }
        protected override void OnAwake()
        {
            if(this != null)
            {
                    this.OnAwake();
            }
            else
            {
                    this.OnAwake();
            }
            
            mem[1152921512650341856] = __RuntimeMethodHiddenParam + 24 + 168 + 80;
            mem[1152921512650341858] = W9 >> 8;
            mem[1152921512650341857] = ???;
            if(X21 == 0)
            {
                
            }
        
        }
        public virtual T Replace(int slotId, T item)
        {
            var val_1;
            if(X23 > slotId)
            {
                    val_1 = this;
                if(this != null)
            {
                    return (object)val_1;
            }
            
                return (object)val_1;
            }
            
            val_1 = item;
            return (object)val_1;
        }
        public virtual bool Add(T item)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            val_9 = __RuntimeMethodHiddenParam;
            val_10 = item;
            val_11 = this;
            val_12 = 0;
            goto label_0;
            label_8:
            val_12 = 1;
            label_0:
            if(val_12 >= X23)
            {
                goto label_2;
            }
            
            if(this != null)
            {
                goto label_8;
            }
            
            val_13 = val_11;
            if((val_13 & 1) == 0)
            {
                goto label_8;
            }
            
            val_14 = 1;
            return (bool)val_14;
            label_2:
            if((__RuntimeMethodHiddenParam + 24 + 168 + 72) != 0)
            {
                    val_11 = ???;
                val_10 = ???;
                val_9 = ???;
                val_13 = ???;
            }
            else
            {
                    val_14 = 0;
                return (bool)val_14;
            }
        
        }
        public UnityEngine.GameObject CreateSlot()
        {
            UnityEngine.Object val_5 = 0;
            if(0 == 34820096)
            {
                    return (UnityEngine.GameObject)val_5;
            }
            
            val_5 = 0;
            if(0 == val_5)
            {
                    return (UnityEngine.GameObject)val_5;
            }
            
            val_5 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
            if(val_5 != null)
            {
                    val_5.SetActive(value:  true);
            }
            else
            {
                    val_5.SetActive(value:  true);
            }
            
            val_5.transform.SetParent(parent:  1152921504721543168, worldPositionStays:  false);
            return (UnityEngine.GameObject)val_5;
        }
        public void RefreshSlots()
        {
            var val_8;
            var val_9;
            var val_10;
            val_9 = __RuntimeMethodHiddenParam;
            val_10 = this;
            if(true == 0)
            {
                goto label_8;
            }
            
            if(0 == 34820096)
            {
                goto label_4;
            }
            
            mem[1152921512650822552] = 0;
            val_10 = ???;
            val_9 = ???;
            val_8 = ???;
            goto __RuntimeMethodHiddenParam + 24 + 168 + 232;
            label_4:
            label_8:
            mem2[0] = 0;
        }
        public virtual void Clear()
        {
            var val_10;
            var val_11;
            var val_12;
            val_10 = __RuntimeMethodHiddenParam;
            val_11 = 0;
            goto label_1;
            label_5:
            val_11 = 1;
            label_1:
            if(val_11 >= X22)
            {
                goto label_3;
            }
            
            if(this != null)
            {
                goto label_5;
            }
            
            goto label_5;
            label_3:
            if((__RuntimeMethodHiddenParam + 24 + 168 + 72) == 0)
            {
                    return;
            }
            
            val_12 = 0;
            goto label_7;
            label_14:
            UnityEngine.Object.DestroyImmediate(obj:  0);
            val_12 = 1;
            label_7:
            if(val_12 >= X22)
            {
                goto label_9;
            }
            
            UnityEngine.GameObject val_1 = X22.gameObject;
            goto label_14;
            label_9:
            val_10 = ???;
            val_11 = ???;
            goto __RuntimeMethodHiddenParam + 24 + 168 + 80;
        }
        public T GetItem(int slotId)
        {
            var val_7;
            var val_8;
            var val_9;
            val_7 = __RuntimeMethodHiddenParam;
            val_8 = slotId;
            val_9 = this;
            if(val_9 <= val_8)
            {
                    return 0;
            }
            
            val_7 = ???;
            val_8 = ???;
            val_9 = ???;
            goto __RuntimeMethodHiddenParam + 24 + 168 + 136;
        }
        public void MoveTo(string container)
        {
            var val_2;
            if(0 == 0)
            {
                    return;
            }
            
            val_2 = 0;
            mem[1152921512651170915] = 0;
            goto label_6;
            label_15:
            val_2 = 1;
            label_6:
            if(val_2 >= this)
            {
                goto label_9;
            }
            
            if(((this == null) || ((0 & 1) != 0)) || (this != null))
            {
                goto label_15;
            }
            
            goto label_15;
            label_9:
            mem[1152921512651170915] = 1;
            if(this == null)
            {
                    return;
            }
            
            this.Invoke();
        }
        public void OnDrop(UnityEngine.EventSystems.PointerEventData eventData)
        {
            var val_7;
            var val_8;
            val_7 = __RuntimeMethodHiddenParam;
            val_8 = mem[__RuntimeMethodHiddenParam + 24 + 168 + 248];
            val_8 = __RuntimeMethodHiddenParam + 24 + 168 + 248;
            if((__RuntimeMethodHiddenParam + 24 + 168 + 248 + 160) == 0)
            {
                    return;
            }
            
            if(this == null)
            {
                    return;
            }
            
            val_7 = ???;
            val_8 = ???;
            goto __RuntimeMethodHiddenParam + 24 + 168 + 144;
        }
        public virtual void Lock(bool state)
        {
            var val_3;
            var val_4;
            bool val_5;
            bool val_1 = state;
            if(val_1 != false)
            {
                    val_3 = 0;
                val_4 = 0;
                val_5 = 0;
            }
            else
            {
                    val_4 = (uint)(val_1 >> 8) & 255;
                val_5 = val_1 >> 16;
            }
            
            mem[1152921512651407121] = val_1;
            mem[1152921512651407122] = val_4;
            mem[1152921512651407123] = val_5;
        }
        private void <OnAwake>m__0(T arg)
        {
            if(this == null)
            {
                    return;
            }
            
            if(this == null)
            {
                    return;
            }
            
            this.Invoke();
        }
        private void <OnAwake>m__1(T arg)
        {
            if(this == null)
            {
                    return;
            }
            
            if(this == null)
            {
                    return;
            }
            
            this.Invoke();
        }
    
    }

}
