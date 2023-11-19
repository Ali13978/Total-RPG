using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.RequireComponent]
    public class UIScrollToSelectionXY : MonoBehaviour
    {
        // Fields
        public float scrollSpeed;
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform layoutListGroup;
        private UnityEngine.RectTransform targetScrollObject;
        private bool scrollToSelection;
        private UnityEngine.RectTransform scrollWindow;
        private UnityEngine.RectTransform currentCanvas;
        private UnityEngine.UI.ScrollRect targetScrollRect;
        
        // Methods
        public UIScrollToSelectionXY()
        {
            this.scrollSpeed = 10f;
            this.scrollToSelection = true;
        }
        private void Start()
        {
            UnityEngine.UI.ScrollRect val_1 = this.GetComponent<UnityEngine.UI.ScrollRect>();
            this.targetScrollRect = val_1;
            this.scrollWindow = val_1.GetComponent<UnityEngine.RectTransform>();
        }
        private void Update()
        {
            this.ScrollRectToLevelSelection();
        }
        private void ScrollRectToLevelSelection()
        {
            var val_38;
            UnityEngine.RectTransform val_39;
            UnityEngine.Object val_40;
            float val_41;
            float val_42;
            float val_43;
            val_38 = 1152921504721543168;
            val_39 = UnityEngine.EventSystems.EventSystem.current;
            if(0 == this.targetScrollRect)
            {
                    return;
            }
            
            if(0 == this.layoutListGroup)
            {
                    return;
            }
            
            if(0 == this.scrollWindow)
            {
                    return;
            }
            
            val_40 = 0;
            if(0 != val_39.currentSelectedGameObject)
            {
                    val_40 = val_39.currentSelectedGameObject.GetComponent<UnityEngine.RectTransform>();
            }
            
            val_39 = this.targetScrollObject;
            if(0 != val_40)
            {
                    this.scrollToSelection = true;
            }
            
            if(0 == val_40)
            {
                    return;
            }
            
            if(this.scrollToSelection != true)
            {
                    return;
            }
            
            val_39 = val_40.transform.parent;
            UnityEngine.Transform val_17 = this.layoutListGroup.transform;
            if(0 != val_39)
            {
                    return;
            }
            
            if(this.targetScrollRect.vertical != false)
            {
                    UnityEngine.Vector2 val_21 = val_40.anchoredPosition;
                UnityEngine.Vector2 val_22 = this.layoutListGroup.anchoredPosition;
                float val_24 = val_21.y + val_22.y;
                UnityEngine.Vector2 val_25 = this.layoutListGroup.sizeDelta;
                val_41 = val_25.y;
                val_42 = this.scrollSpeed;
                val_43 = UnityEngine.Time.deltaTime;
                float val_27 = val_24 / val_41;
                val_27 = val_43 * val_27;
                val_27 = val_42 * val_27;
                val_27 = this.targetScrollRect.verticalNormalizedPosition + val_27;
                this.targetScrollRect.verticalNormalizedPosition = val_27;
                var val_28 = (System.Math.Abs(val_24) >= 0) ? 1 : 0;
            }
            else
            {
                    val_38 = 1;
            }
            
            val_39 = this.targetScrollRect;
            if(val_39.horizontal != false)
            {
                    UnityEngine.Vector2 val_30 = val_40.anchoredPosition;
                UnityEngine.Vector2 val_31 = this.layoutListGroup.anchoredPosition;
                val_39 = this.targetScrollRect;
                float val_33 = val_30.x + val_31.x;
                UnityEngine.Vector2 val_34 = this.layoutListGroup.sizeDelta;
                val_41 = val_34.x;
                val_42 = this.scrollSpeed;
                val_43 = UnityEngine.Time.deltaTime;
                float val_36 = val_33 / val_41;
                val_36 = val_43 * val_36;
                val_36 = val_42 * val_36;
                val_36 = val_39.horizontalNormalizedPosition + val_36;
                val_39.horizontalNormalizedPosition = val_36;
                var val_37 = (System.Math.Abs(val_33) >= 0) ? 1 : 0;
                val_37 = val_38 | val_37;
                if((val_37 & 1) == 0)
            {
                    this.scrollToSelection = false;
            }
            
            }
            
            this.targetScrollObject = val_40;
        }
    
    }

}
