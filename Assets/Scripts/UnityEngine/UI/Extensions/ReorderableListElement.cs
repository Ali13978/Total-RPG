using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.RequireComponent]
    public class ReorderableListElement : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IEventSystemHandler
    {
        // Fields
        private readonly System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> _raycastResults;
        private UnityEngine.UI.Extensions.ReorderableList _currentReorderableListRaycasted;
        private UnityEngine.RectTransform _draggingObject;
        private UnityEngine.UI.LayoutElement _draggingObjectLE;
        private UnityEngine.Vector2 _draggingObjectOriginalSize;
        private UnityEngine.RectTransform _fakeElement;
        private UnityEngine.UI.LayoutElement _fakeElementLE;
        private int _fromIndex;
        private bool _isDragging;
        private UnityEngine.RectTransform _rect;
        private UnityEngine.UI.Extensions.ReorderableList _reorderableList;
        
        // Methods
        public ReorderableListElement()
        {
            this._raycastResults = new System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>();
        }
        public void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            UnityEngine.RectTransform val_27;
            UnityEngine.UI.Extensions.ReorderableList val_28;
            var val_29;
            UnityEngine.UI.Extensions.ReorderableList val_32;
            var val_33;
            val_27 = 1152921504721543168;
            if(0 == this._reorderableList)
            {
                    return;
            }
            
            if(this._reorderableList.IsDraggable == false)
            {
                goto label_5;
            }
            
            if(this._reorderableList.CloneDraggedObject == false)
            {
                goto label_7;
            }
            
            UnityEngine.GameObject val_3 = this.gameObject;
            this._draggingObject = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0).GetComponent<UnityEngine.RectTransform>();
            goto label_15;
            label_5:
            this._draggingObject = 0;
            return;
            label_7:
            this._draggingObject = this._rect;
            this._fromIndex = this._rect.GetSiblingIndex();
            if(this._reorderableList.OnElementRemoved == null)
            {
                goto label_15;
            }
            
            val_28 = this._reorderableList;
            if(val_28 == null)
            {
                goto label_18;
            }
            
            goto label_19;
            label_18:
            val_28 = this._reorderableList;
            if(this._reorderableList == null)
            {
                goto label_40;
            }
            
            label_19:
            var val_9 = (this._reorderableList.CloneDraggedObject == true) ? 0 : -497260648;
            if(this._reorderableList.CloneDraggedObject != false)
            {
                    UnityEngine.GameObject val_10 = this.gameObject;
                val_29 = this._reorderableList.OnElementRemoved;
            }
            
            mem2[0] = this._draggingObject.gameObject;
            (this._reorderableList.CloneDraggedObject == true) ? 0 : this._reorderableList.OnElementRemoved.Invoke(arg0:  new ReorderableListEventStruct() {DroppedObject = this._draggingObject.gameObject, FromIndex = this._draggingObject.gameObject, FromList = this._reorderableList, IsAClone = this._reorderableList});
            label_15:
            UnityEngine.Rect val_14 = this.gameObject.GetComponent<UnityEngine.RectTransform>().rect;
            this._draggingObjectOriginalSize = val_14.m_XMin;
            mem[1152921512699533100] = val_14.m_YMin;
            this._draggingObjectLE = this._draggingObject.GetComponent<UnityEngine.UI.LayoutElement>();
            val_27 = this._reorderableList.DraggableArea;
            this._draggingObject.SetParent(parent:  val_27, worldPositionStays:  false);
            this._draggingObject.SetAsLastSibling();
            UnityEngine.GameObject val_16 = new UnityEngine.GameObject(name:  "Fake");
            UnityEngine.RectTransform val_17 = AddComponent<UnityEngine.RectTransform>();
            this._fakeElement = val_17;
            this._fakeElementLE = val_17.gameObject.AddComponent<UnityEngine.UI.LayoutElement>();
            this.RefreshSizes();
            if(this._reorderableList.OnElementGrabbed == null)
            {
                goto label_35;
            }
            
            val_27 = this._reorderableList.OnElementGrabbed;
            val_32 = this._reorderableList;
            if(val_32 == null)
            {
                goto label_38;
            }
            
            goto label_39;
            label_38:
            val_32 = this._reorderableList;
            if(this._reorderableList == null)
            {
                goto label_40;
            }
            
            label_39:
            var val_22 = (this._reorderableList.CloneDraggedObject == true) ? 0 : -497260720;
            if(this._reorderableList.CloneDraggedObject != false)
            {
                    UnityEngine.GameObject val_23 = this.gameObject;
                val_33 = val_27;
            }
            else
            {
                    val_27 = this._draggingObject;
            }
            
            mem2[0] = val_27.gameObject;
            (this._reorderableList.CloneDraggedObject == true) ? 0 : (val_27).Invoke(arg0:  new ReorderableListEventStruct() {DroppedObject = this._draggingObject.gameObject, FromIndex = this._draggingObject.gameObject, FromList = this._reorderableList, IsAClone = this._reorderableList});
            label_35:
            this._isDragging = true;
            return;
            label_40:
        }
        public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            UnityEngine.UI.Extensions.ReorderableList val_33;
            var val_34;
            float val_35;
            float val_36;
            var val_37;
            var val_38;
            val_34 = this;
            if(this._isDragging == false)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_1 = eventData.position;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            val_35 = val_2.x;
            val_36 = val_2.z;
            this._draggingObject.position = new UnityEngine.Vector3() {x = val_35, y = val_2.y, z = val_36};
            UnityEngine.EventSystems.EventSystem.current.RaycastAll(eventData:  eventData, raycastResults:  this._raycastResults);
            val_37 = 1152921504721543168;
            var val_33 = 0;
            label_15:
            if(val_33 >= this._raycastResults.Count)
            {
                goto label_10;
            }
            
            UnityEngine.EventSystems.RaycastResult val_5 = this._raycastResults.Item[0];
            UnityEngine.UI.Extensions.ReorderableList val_7 = InitializationCallback.GetComponent<UnityEngine.UI.Extensions.ReorderableList>();
            this._currentReorderableListRaycasted = val_7;
            val_33 = val_33 + 1;
            if(0 == val_7)
            {
                goto label_15;
            }
            
            label_10:
            val_33 = this._currentReorderableListRaycasted;
            if(0 == val_33)
            {
                goto label_20;
            }
            
            val_33 = this._currentReorderableListRaycasted;
            if(this._currentReorderableListRaycasted.IsDropable == false)
            {
                goto label_20;
            }
            
            val_36 = Infinityf;
            val_35 = 0f;
            if(0 != this._fakeElement.parent)
            {
                    this._fakeElement.SetParent(parent:  this._currentReorderableListRaycasted.Content, worldPositionStays:  false);
            }
            
            val_38 = 0;
            val_33 = 0;
            goto label_27;
            label_61:
            var val_16 = (val_35 < 0) ? (val_35) : (val_36);
            val_38 = 1;
            label_27:
            val_37 = this._currentReorderableListRaycasted.Content;
            if(val_38 >= val_37.childCount)
            {
                goto label_30;
            }
            
            UnityEngine.RectTransform val_21 = this._currentReorderableListRaycasted.Content.GetChild(index:  1).GetComponent<UnityEngine.RectTransform>();
            if(this._currentReorderableListRaycasted.ContentLayout == null)
            {
                goto label_61;
            }
            
            UnityEngine.Vector3 val_22 = val_21.position;
            float val_34 = val_22.x;
            UnityEngine.Vector2 val_23 = eventData.position;
            val_34 = val_34 - val_23.x;
            UnityEngine.Vector3 val_24 = val_21.position;
            float val_37 = val_24.y;
            UnityEngine.Vector2 val_25 = eventData.position;
            val_37 = System.Math.Abs(val_34) + (System.Math.Abs(val_37 - val_25.y));
            goto label_61;
            label_20:
            this.RefreshSizes();
            val_34 = this._fakeElement.transform;
            val_34.SetParent(parent:  this._reorderableList.DraggableArea, worldPositionStays:  false);
            return;
            label_30:
            this.RefreshSizes();
            this._fakeElement.SetSiblingIndex(index:  (val_35 < 0) ? (val_38) : (val_33));
            val_34 = this._fakeElement.gameObject;
            val_34.SetActive(value:  true);
        }
        public void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            var val_17;
            int val_18;
            UnityEngine.UI.Extensions.ReorderableList val_19;
            var val_20;
            val_17 = this;
            this._isDragging = false;
            if(0 == this._draggingObject)
            {
                goto label_28;
            }
            
            if((0 == this._currentReorderableListRaycasted) || (this._currentReorderableListRaycasted.IsDropable == false))
            {
                goto label_8;
            }
            
            this.RefreshSizes();
            this._draggingObject.SetParent(parent:  this._currentReorderableListRaycasted.Content, worldPositionStays:  false);
            val_18 = this._fakeElement.GetSiblingIndex();
            this._draggingObject.SetSiblingIndex(index:  val_18);
            if(this._reorderableList.OnElementDropped == null)
            {
                goto label_28;
            }
            
            val_19 = this._reorderableList;
            if(val_19 == null)
            {
                goto label_17;
            }
            
            goto label_18;
            label_8:
            if(this._reorderableList.CloneDraggedObject == false)
            {
                goto label_20;
            }
            
            UnityEngine.GameObject val_6 = this._draggingObject.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
            goto label_28;
            label_20:
            this.RefreshSizes();
            this._draggingObject.SetParent(parent:  this._reorderableList.Content, worldPositionStays:  false);
            val_18 = this._fromIndex;
            this._draggingObject.SetSiblingIndex(index:  val_18);
            goto label_28;
            label_17:
            val_19 = this._reorderableList;
            if(this._reorderableList == null)
            {
                goto label_29;
            }
            
            label_18:
            var val_9 = (this._reorderableList.CloneDraggedObject == true) ? 0 : -496412968;
            if(this._reorderableList.CloneDraggedObject != false)
            {
                    UnityEngine.GameObject val_10 = this.gameObject;
                val_20 = this._reorderableList.OnElementDropped;
            }
            
            mem2[0] = this._draggingObject.gameObject;
            val_18 = this._fakeElement;
            int val_13 = val_18.GetSiblingIndex() - 1;
            (this._reorderableList.CloneDraggedObject == true) ? 0 : this._reorderableList.OnElementDropped.Invoke(arg0:  new ReorderableListEventStruct() {DroppedObject = this._draggingObject.gameObject, FromIndex = this._draggingObject.gameObject, FromList = this._reorderableList, IsAClone = this._reorderableList, ToList = this._currentReorderableListRaycasted});
            label_28:
            if(0 == this._fakeElement)
            {
                    return;
            }
            
            val_17 = this._fakeElement.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
            return;
            label_29:
        }
        private void RefreshSizes()
        {
            UnityEngine.Vector2 val_9;
            float val_10;
            val_9 = this._draggingObjectOriginalSize;
            if(((0 != this._currentReorderableListRaycasted) && (this._currentReorderableListRaycasted.IsDropable != false)) && (this._currentReorderableListRaycasted.Content.childCount >= 1))
            {
                    UnityEngine.Transform val_5 = this._currentReorderableListRaycasted.Content.GetChild(index:  0);
                if(0 != val_5)
            {
                    UnityEngine.Rect val_8 = val_5.GetComponent<UnityEngine.RectTransform>().rect;
                val_9 = val_8.m_XMin;
                val_10 = val_8.m_YMin;
            }
            
            }
            
            this._draggingObject.sizeDelta = new UnityEngine.Vector2() {x = val_9, y = val_10};
            if(this._fakeElementLE != null)
            {
                    return;
            }
        
        }
        public void Init(UnityEngine.UI.Extensions.ReorderableList reorderableList)
        {
            this._reorderableList = reorderableList;
            this._rect = this.GetComponent<UnityEngine.RectTransform>();
        }
    
    }

}
