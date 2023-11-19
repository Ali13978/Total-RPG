using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    public class SelectionBox : MonoBehaviour
    {
        // Fields
        public UnityEngine.Color color;
        public UnityEngine.Sprite art;
        private UnityEngine.Vector2 origin;
        public UnityEngine.RectTransform selectionMask;
        private UnityEngine.RectTransform boxRect;
        private UnityEngine.UI.Extensions.IBoxSelectable[] selectables;
        private UnityEngine.MonoBehaviour[] selectableGroup;
        private UnityEngine.UI.Extensions.IBoxSelectable clickedBeforeDrag;
        private UnityEngine.UI.Extensions.IBoxSelectable clickedAfterDrag;
        public UnityEngine.UI.Extensions.SelectionBox.SelectionEvent onSelectionChange;
        
        // Methods
        public SelectionBox()
        {
            this.onSelectionChange = new SelectionBox.SelectionEvent();
        }
        private void ValidateCanvas()
        {
            if((this.gameObject.GetComponent<UnityEngine.Canvas>().renderMode) == 0)
            {
                    UnityEngine.UI.CanvasScaler val_5 = this.gameObject.GetComponent<UnityEngine.UI.CanvasScaler>();
                if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
                if(val_5.enabled == false)
            {
                    return;
            }
            
                if((UnityEngine.Mathf.Approximately(a:  val_5.scaleFactor, b:  1f)) != false)
            {
                    if(val_5.uiScaleMode == 0)
            {
                    return;
            }
            
            }
            
                UnityEngine.Object.Destroy(obj:  0);
                UnityEngine.Debug.LogWarning(message:  0);
                return;
            }
            
            System.Exception val_11 = new System.Exception(message:  "SelectionBox component must be placed on a canvas in Screen Space Overlay mode.");
        }
        private void SetSelectableGroup(System.Collections.Generic.IEnumerable<UnityEngine.MonoBehaviour> behaviourCollection)
        {
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            if(behaviourCollection != null)
            {
                    System.Collections.Generic.List<UnityEngine.MonoBehaviour> val_1 = new System.Collections.Generic.List<UnityEngine.MonoBehaviour>();
                var val_8 = 0;
                val_8 = val_8 + 1;
                val_8 = behaviourCollection;
            }
            else
            {
                    this.selectableGroup = 0;
                return;
            }
            
            do
            {
                label_20:
                var val_9 = 0;
                val_9 = val_9 + 1;
                val_9 = behaviourCollection;
                if(((behaviourCollection & 1) & 1) == 0)
            {
                goto label_29;
            }
            
                var val_10 = 0;
                val_10 = val_10 + 1;
                val_10 = behaviourCollection;
            }
            while(behaviourCollection == null);
            
            Add(item:  behaviourCollection);
            goto label_20;
            label_29:
            if(behaviourCollection != null)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                val_11 = behaviourCollection;
            }
            
            this.selectableGroup = ToArray();
        }
        private void CreateBoxRect()
        {
            var val_8;
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject();
            if(null != 0)
            {
                    name = "Selection Box";
            }
            else
            {
                    0.name = "Selection Box";
            }
            
            transform.parent = this.transform;
            if(null != 0)
            {
                    UnityEngine.UI.Image val_4 = AddComponent<UnityEngine.UI.Image>();
            }
            else
            {
                    UnityEngine.UI.Image val_5 = AddComponent<UnityEngine.UI.Image>();
            }
            
            val_8 = 0;
            this.boxRect = (null == null) ? transform : 0;
        }
        private void ResetBoxRect()
        {
            UnityEngine.UI.Image val_1 = this.boxRect.GetComponent<UnityEngine.UI.Image>();
            val_1.color = new UnityEngine.Color() {r = this.color, g = V9.16B, b = V10.16B, a = V11.16B};
            val_1.sprite = this.art;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            this.origin = val_2;
            mem[1152921512704534436] = val_2.y;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
            this.boxRect.anchoredPosition = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
            this.boxRect.sizeDelta = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
            this.boxRect.anchorMax = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.zero;
            this.boxRect.anchorMin = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.zero;
            this.boxRect.pivot = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
            this.boxRect.gameObject.SetActive(value:  false);
        }
        private void BeginSelection()
        {
            float val_15;
            UnityEngine.MonoBehaviour[] val_16;
            var val_17;
            var val_18;
            var val_19;
            if((UnityEngine.Input.GetMouseButtonDown(button:  0)) == false)
            {
                    return;
            }
            
            this.boxRect.gameObject.SetActive(value:  true);
            UnityEngine.Vector3 val_3 = UnityEngine.Input.mousePosition;
            val_15 = val_3.x;
            UnityEngine.Vector3 val_4 = UnityEngine.Input.mousePosition;
            CinemachineFreeLook.Orbit val_5 = new CinemachineFreeLook.Orbit(h:  val_15, r:  val_4.y);
            float val_13 = val_5.m_Radius;
            this.origin = val_5.m_Height;
            mem[1152921512704818468] = val_13;
            val_13 = this.PointIsValidAgainstSelectionMask(screenPoint:  new UnityEngine.Vector2() {x = val_5.m_Height, y = val_13});
            if(val_13 == false)
            {
                goto label_8;
            }
            
            val_15 = this.origin;
            this.boxRect.anchoredPosition = new UnityEngine.Vector2() {x = val_15, y = V9.16B};
            val_16 = this.selectableGroup;
            if(val_16 == null)
            {
                    val_16 = UnityEngine.Object.FindObjectsOfType<UnityEngine.Component>();
            }
            
            System.Collections.Generic.List<UnityEngine.UI.Extensions.IBoxSelectable> val_8 = new System.Collections.Generic.List<UnityEngine.UI.Extensions.IBoxSelectable>();
            val_17 = 0;
            goto label_13;
            label_26:
            val_17 = 1;
            label_13:
            if(val_17 >= val_7.Length)
            {
                goto label_15;
            }
            
            T val_14 = val_16[1];
            if(val_14 == 0)
            {
                goto label_26;
            }
            
            Add(item:  val_14);
            val_18 = 0;
            if((UnityEngine.Input.GetKey(key:  0)) == true)
            {
                goto label_26;
            }
            
            var val_18 = val_14;
            if((val_7[0x1][0] + 258) == 0)
            {
                goto label_22;
            }
            
            var val_15 = val_7[0x1][0] + 152;
            var val_16 = 0;
            val_15 = val_15 + 8;
            label_24:
            if(((val_7[0x1][0] + 152 + 8) + -8) == null)
            {
                goto label_23;
            }
            
            val_16 = val_16 + 1;
            val_15 = val_15 + 16;
            if(val_16 < (val_7[0x1][0] + 258))
            {
                goto label_24;
            }
            
            label_22:
            val_18 = 1;
            val_19 = val_14;
            goto label_26;
            label_23:
            var val_17 = val_15;
            val_17 = val_17 + 1;
            val_18 = val_18 + val_17;
            val_19 = val_18 + 272;
            goto label_26;
            label_8:
            this.ResetBoxRect();
            return;
            label_15:
            this.selectables = ToArray();
            this.clickedBeforeDrag = this.GetSelectableAtMousePosition();
        }
        private bool PointIsValidAgainstSelectionMask(UnityEngine.Vector2 screenPoint)
        {
            bool val_1 = UnityEngine.Object.op_Implicit(exists:  0);
            if(val_1 == false)
            {
                    return true;
            }
            
            UnityEngine.Camera val_2 = val_1.GetScreenPointCamera(rectTransform:  this.selectionMask);
            return UnityEngine.RectTransformUtility.RectangleContainsScreenPoint(rect:  0, screenPoint:  new UnityEngine.Vector2() {x = screenPoint.x, y = screenPoint.y}, cam:  this.selectionMask);
        }
        private UnityEngine.UI.Extensions.IBoxSelectable GetSelectableAtMousePosition()
        {
            float val_16;
            float val_21;
            float val_22;
            UnityEngine.UI.Extensions.IBoxSelectable val_23;
            var val_24;
            var val_25;
            UnityEngine.RectTransform val_26;
            var val_27;
            UnityEngine.Vector3 val_1 = UnityEngine.Input.mousePosition;
            val_21 = val_1.x;
            val_22 = val_1.z;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_21, y = val_1.y, z = val_22});
            val_23 = 0;
            if((this.PointIsValidAgainstSelectionMask(screenPoint:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y})) == false)
            {
                    return (UnityEngine.UI.Extensions.IBoxSelectable)val_23;
            }
            
            val_24 = 0;
            goto label_6;
            label_39:
            val_24 = 1;
            label_6:
            if(val_24 >= this.selectables.Length)
            {
                goto label_8;
            }
            
            val_23 = this.selectables[1];
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_25 = val_23;
            if(val_23 != null)
            {
                    var val_5 = (null == null) ? (val_23) : 0;
            }
            else
            {
                    val_26 = 0;
            }
            
            bool val_6 = UnityEngine.Object.op_Implicit(exists:  0);
            if(val_6 == false)
            {
                goto label_19;
            }
            
            UnityEngine.Camera val_7 = val_6.GetScreenPointCamera(rectTransform:  val_26);
            UnityEngine.Vector3 val_8 = UnityEngine.Input.mousePosition;
            val_22 = val_8.z;
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_22});
            val_21 = val_9.x;
            if((UnityEngine.RectTransformUtility.RectangleContainsScreenPoint(rect:  0, screenPoint:  new UnityEngine.Vector2() {x = val_21, y = val_9.y}, cam:  val_26)) == false)
            {
                goto label_39;
            }
            
            return (UnityEngine.UI.Extensions.IBoxSelectable)val_23;
            label_19:
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_27 = val_23;
            UnityEngine.Bounds val_14 = val_23.GetComponent<UnityEngine.Renderer>().bounds;
            val_21 = val_16;
            UnityEngine.Vector2 val_17 = val_16.GetScreenPointOfSelectable(selectable:  val_23);
            val_22 = val_17.y;
            UnityEngine.Vector3 val_18 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            if((UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_17.x, y = val_22}, b:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y})) > val_21)
            {
                goto label_39;
            }
            
            return (UnityEngine.UI.Extensions.IBoxSelectable)val_23;
            label_8:
            val_23 = 0;
            return (UnityEngine.UI.Extensions.IBoxSelectable)val_23;
        }
        private void DragSelection()
        {
            UnityEngine.UI.Extensions.IBoxSelectable val_21;
            var val_22;
            var val_23;
            var val_24;
            val_21 = this;
            val_22 = 0;
            if((UnityEngine.Input.GetMouseButton(button:  0)) == false)
            {
                    return;
            }
            
            if(this.boxRect.gameObject.activeSelf == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_4 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector3 val_5 = UnityEngine.Input.mousePosition;
            CinemachineFreeLook.Orbit val_6 = new CinemachineFreeLook.Orbit(h:  val_4.x, r:  val_5.y);
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_6.m_Height, y = val_6.m_Radius}, b:  new UnityEngine.Vector2() {x = this.origin, y = V9.16B});
            this.boxRect.anchoredPosition = new UnityEngine.Vector2() {x = (val_7.x < 0) ? -491307576 : this.origin, y = (val_7.y < 0) ? -491307572 : 1152921512705486180};
            this.boxRect.sizeDelta = new UnityEngine.Vector2() {x = (val_7.x < 0) ? (-val_7.x) : val_7.x, y = (val_7.y < 0) ? (-val_7.y) : val_7.y};
            val_23 = 0;
            goto label_13;
            label_30:
            val_23 = 1;
            label_13:
            if(val_23 >= this.selectables.Length)
            {
                goto label_15;
            }
            
            UnityEngine.Vector2 val_12 = this.boxRect.GetScreenPointOfSelectable(selectable:  this.selectables[1]);
            UnityEngine.Vector3 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            if((UnityEngine.RectTransformUtility.RectangleContainsScreenPoint(rect:  0, screenPoint:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y}, cam:  this.boxRect)) != false)
            {
                    UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
                bool val_18 = this.PointIsValidAgainstSelectionMask(screenPoint:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y});
            }
            
            var val_22 = 0;
            val_22 = val_22 + 1;
            goto label_30;
            label_15:
            val_21 = this.clickedBeforeDrag;
            if(val_21 == null)
            {
                    return;
            }
            
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_22 = 3;
            val_24 = val_21;
        }
        private void ApplySingleClickDeselection()
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            if(this.clickedBeforeDrag == null)
            {
                    return;
            }
            
            if(this.clickedAfterDrag == null)
            {
                    return;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_7 = this.clickedBeforeDrag;
            if((this.clickedBeforeDrag & 1) == 0)
            {
                    return;
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_8 = this.clickedBeforeDrag;
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_9 = this.clickedAfterDrag;
            val_10 = this.clickedAfterDrag;
            if(0 != this.clickedBeforeDrag)
            {
                    return;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_10 = 1;
            val_11 = this.clickedBeforeDrag;
            val_12 = mem[val_4 + 8];
            val_12 = val_4 + 8;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_12 = 3;
            val_13 = this.clickedBeforeDrag;
        }
        private void ApplyPreSelections()
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_4 = 0;
            goto label_1;
            label_21:
            val_4 = 1;
            label_1:
            if(val_4 >= this.selectables.Length)
            {
                    return;
            }
            
            UnityEngine.UI.Extensions.IBoxSelectable val_4 = this.selectables[1];
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = 2;
            val_6 = val_4;
            if((val_4 & 1) == 0)
            {
                goto label_21;
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_5 = 1;
            val_7 = val_4;
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_8 = 3;
            val_9 = val_4;
            goto label_21;
        }
        private UnityEngine.Vector2 GetScreenPointOfSelectable(UnityEngine.UI.Extensions.IBoxSelectable selectable)
        {
            var val_11;
            UnityEngine.RectTransform val_12;
            var val_13;
            var val_14;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_11 = selectable;
            if(selectable != null)
            {
                    var val_2 = (null == null) ? selectable : 0;
            }
            else
            {
                    val_12 = 0;
            }
            
            bool val_3 = UnityEngine.Object.op_Implicit(exists:  0);
            if(val_3 == false)
            {
                goto label_10;
            }
            
            UnityEngine.Camera val_4 = val_3.GetScreenPointCamera(rectTransform:  val_12);
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_13 = selectable;
            goto label_15;
            label_10:
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_14 = selectable;
            goto label_20;
            label_15:
            UnityEngine.Vector3 val_7 = selectable.position;
            return UnityEngine.RectTransformUtility.WorldToScreenPoint(cam:  0, worldPoint:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            label_20:
            UnityEngine.Vector3 val_9 = selectable.position;
            UnityEngine.Vector3 val_10 = UnityEngine.Camera.main.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            return UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        }
        private UnityEngine.Camera GetScreenPointCamera(UnityEngine.RectTransform rectTransform)
        {
            var val_16;
            var val_17;
            do
            {
                val_16 = rectTransform.GetComponent<UnityEngine.Canvas>();
                if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    UnityEngine.Object val_4 = (val_16.isRootCanvas != true) ? (val_16) : 0;
            }
            
                UnityEngine.Transform val_5 = rectTransform.parent;
            }
            while(0 == val_4);
            
            UnityEngine.RenderMode val_9 = val_4.renderMode;
            var val_11 = (val_9 < 3) ? (val_9 + 9) : 0;
            if((val_11 == 0) || (val_11 == 11))
            {
                    return (UnityEngine.Camera)UnityEngine.Camera.main;
            }
            
            val_17 = 0;
            if(val_11 != 10)
            {
                    return (UnityEngine.Camera)UnityEngine.Camera.main;
            }
            
            UnityEngine.Camera val_12 = val_4.worldCamera;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return (UnityEngine.Camera)UnityEngine.Camera.main;
            }
            
            UnityEngine.Camera val_14 = val_4.worldCamera;
            return (UnityEngine.Camera)UnityEngine.Camera.main;
        }
        public UnityEngine.UI.Extensions.IBoxSelectable[] GetAllSelected()
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            if(this.selectables == null)
            {
                goto label_1;
            }
            
            System.Collections.Generic.List<UnityEngine.UI.Extensions.IBoxSelectable> val_1 = null;
            val_4 = val_1;
            val_1 = new System.Collections.Generic.List<UnityEngine.UI.Extensions.IBoxSelectable>();
            val_5 = 0;
            goto label_2;
            label_13:
            val_5 = 1;
            label_2:
            if(val_5 >= this.selectables.Length)
            {
                goto label_4;
            }
            
            UnityEngine.UI.Extensions.IBoxSelectable val_4 = this.selectables[1];
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_6 = val_4;
            if((val_4 & 1) == 0)
            {
                goto label_13;
            }
            
            Add(item:  val_4);
            goto label_13;
            label_4:
            T[] val_3 = ToArray();
            return (UnityEngine.UI.Extensions.IBoxSelectable[])val_7;
            label_1:
            val_4 = null;
            val_7 = val_4;
            return (UnityEngine.UI.Extensions.IBoxSelectable[])val_7;
        }
        private void EndSelection()
        {
            if((UnityEngine.Input.GetMouseButtonUp(button:  0)) == false)
            {
                    return;
            }
            
            if(this.boxRect.gameObject.activeSelf == false)
            {
                    return;
            }
            
            this.clickedAfterDrag = this.GetSelectableAtMousePosition();
            this.ApplySingleClickDeselection();
            this.ApplyPreSelections();
            this.ResetBoxRect();
            this.onSelectionChange.Invoke(arg0:  this.GetAllSelected());
        }
        private void Start()
        {
            this.ValidateCanvas();
            this.CreateBoxRect();
            this.ResetBoxRect();
        }
        private void Update()
        {
            this.BeginSelection();
            this.DragSelection();
            this.EndSelection();
        }
    
    }

}
