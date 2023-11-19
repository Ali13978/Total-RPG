using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    public class UI_ScrollRectOcclusion : MonoBehaviour
    {
        // Fields
        public bool InitByUser;
        private UnityEngine.UI.ScrollRect _scrollRect;
        private UnityEngine.UI.ContentSizeFitter _contentSizeFitter;
        private UnityEngine.UI.VerticalLayoutGroup _verticalLayoutGroup;
        private UnityEngine.UI.HorizontalLayoutGroup _horizontalLayoutGroup;
        private UnityEngine.UI.GridLayoutGroup _gridLayoutGroup;
        private bool _isVertical;
        private bool _isHorizontal;
        private float _disableMarginX;
        private float _disableMarginY;
        private bool hasDisabledGridComponents;
        private System.Collections.Generic.List<UnityEngine.RectTransform> items;
        
        // Methods
        public UI_ScrollRectOcclusion()
        {
            this.items = new System.Collections.Generic.List<UnityEngine.RectTransform>();
        }
        private void Awake()
        {
            if(this.InitByUser != false)
            {
                    return;
            }
            
            this.Init();
        }
        public void Init()
        {
            var val_35;
            if(0 == (this.GetComponent<UnityEngine.UI.ScrollRect>()))
            {
                goto label_3;
            }
            
            UnityEngine.UI.ScrollRect val_3 = this.GetComponent<UnityEngine.UI.ScrollRect>();
            this._scrollRect = val_3;
            val_3.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<UnityEngine.Vector2>(object:  this, method:  public System.Void UnityEngine.UI.Extensions.UI_ScrollRectOcclusion::OnScroll(UnityEngine.Vector2 pos)));
            this._isHorizontal = this._scrollRect.horizontal;
            this._isVertical = this._scrollRect.vertical;
            val_35 = 0;
            goto label_8;
            label_16:
            Add(item:  public System.Void UnityEngine.UI.Extensions.UI_ScrollRectOcclusion::OnScroll(UnityEngine.Vector2 pos));
            val_35 = 1;
            label_8:
            if(val_35 >= this._scrollRect.content.childCount)
            {
                goto label_11;
            }
            
            UnityEngine.RectTransform val_14 = this._scrollRect.content.GetChild(index:  1).GetComponent<UnityEngine.RectTransform>();
            if(this.items != null)
            {
                goto label_16;
            }
            
            goto label_16;
            label_3:
            UnityEngine.Debug.LogError(message:  0);
            return;
            label_11:
            if(0 != (this._scrollRect.content.GetComponent<UnityEngine.UI.VerticalLayoutGroup>()))
            {
                    this._verticalLayoutGroup = this._scrollRect.content.GetComponent<UnityEngine.UI.VerticalLayoutGroup>();
            }
            
            if(0 != (this._scrollRect.content.GetComponent<UnityEngine.UI.HorizontalLayoutGroup>()))
            {
                    this._horizontalLayoutGroup = this._scrollRect.content.GetComponent<UnityEngine.UI.HorizontalLayoutGroup>();
            }
            
            if(0 != (this._scrollRect.content.GetComponent<UnityEngine.UI.GridLayoutGroup>()))
            {
                    this._gridLayoutGroup = this._scrollRect.content.GetComponent<UnityEngine.UI.GridLayoutGroup>();
            }
            
            if(0 == (this._scrollRect.content.GetComponent<UnityEngine.UI.ContentSizeFitter>()))
            {
                    return;
            }
            
            this._contentSizeFitter = this._scrollRect.content.GetComponent<UnityEngine.UI.ContentSizeFitter>();
        }
        private void DisableGridComponents()
        {
            bool val_14;
            if((this._isVertical & 255) != false)
            {
                    UnityEngine.Rect val_3 = this._scrollRect.GetComponent<UnityEngine.RectTransform>().rect;
                UnityEngine.Vector2 val_5 = this.items.Item[0].sizeDelta;
                val_14 = this._isHorizontal;
                float val_14 = 0.5f;
                val_14 = val_3.m_XMin * val_14;
                val_14 = val_14 + val_5.y;
                this._disableMarginY = val_14;
            }
            else
            {
                    val_14 = this._isVertical >> 8;
            }
            
            if(val_14 != false)
            {
                    UnityEngine.Rect val_7 = this._scrollRect.GetComponent<UnityEngine.RectTransform>().rect;
                UnityEngine.Vector2 val_9 = this.items.Item[0].sizeDelta;
                float val_15 = 0.5f;
                val_15 = val_7.m_XMin * val_15;
                val_9.x = val_15 + val_9.x;
                this._disableMarginX = val_9.x;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    this._verticalLayoutGroup.enabled = false;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    this._horizontalLayoutGroup.enabled = false;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    this._contentSizeFitter.enabled = false;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    this._gridLayoutGroup.enabled = false;
            }
            
            this.hasDisabledGridComponents = true;
        }
        public void OnScroll(UnityEngine.Vector2 pos)
        {
            var val_35;
            float val_36;
            float val_37;
            float val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            if(this.hasDisabledGridComponents != true)
            {
                    this.DisableGridComponents();
            }
            
            val_35 = 0;
            goto label_2;
            label_53:
            val_35 = 1;
            label_2:
            if(val_35 >= this.items.Count)
            {
                    return;
            }
            
            if((this._isVertical & 255) == false)
            {
                goto label_5;
            }
            
            if(this._isVertical >= true)
            {
                goto label_6;
            }
            
            UnityEngine.Vector3 val_5 = this.items.Item[1].position;
            val_36 = val_5.y;
            val_37 = val_5.z;
            UnityEngine.Vector3 val_6 = this._scrollRect.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_5.x, y = val_36, z = val_37});
            val_38 = -this._disableMarginY;
            if(val_6.y < 0)
            {
                goto label_11;
            }
            
            UnityEngine.Vector3 val_9 = this.items.Item[1].position;
            val_36 = val_9.y;
            val_37 = val_9.z;
            UnityEngine.Vector3 val_10 = this._scrollRect.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_9.x, y = val_36, z = val_37});
            val_38 = this._disableMarginY;
            if(val_10.y <= val_38)
            {
                goto label_16;
            }
            
            label_11:
            val_39 = this.items.Item[1].gameObject;
            val_40 = 0;
            goto label_20;
            label_6:
            UnityEngine.Vector3 val_15 = this.items.Item[1].position;
            UnityEngine.Vector3 val_16 = this._scrollRect.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            if(val_16.y < 0)
            {
                goto label_40;
            }
            
            UnityEngine.Vector3 val_19 = this.items.Item[1].position;
            val_36 = val_19.y;
            val_37 = val_19.z;
            UnityEngine.Vector3 val_20 = this._scrollRect.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_19.x, y = val_36, z = val_37});
            val_38 = this._disableMarginY;
            if(val_20.y > val_38)
            {
                goto label_40;
            }
            
            goto label_31;
            label_16:
            val_39 = this.items.Item[1].gameObject;
            val_40 = 1;
            label_20:
            val_39.SetActive(value:  true);
            label_5:
            if(this._isHorizontal == false)
            {
                goto label_53;
            }
            
            label_31:
            UnityEngine.Vector3 val_25 = this.items.Item[1].position;
            UnityEngine.Vector3 val_26 = this._scrollRect.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
            if(val_26.x < 0)
            {
                goto label_40;
            }
            
            UnityEngine.Vector3 val_29 = this.items.Item[1].position;
            UnityEngine.Vector3 val_30 = this._scrollRect.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
            if(val_30.x <= this._disableMarginX)
            {
                goto label_45;
            }
            
            label_40:
            val_41 = this.items.Item[1].gameObject;
            val_42 = 0;
            goto label_49;
            label_45:
            val_41 = this.items.Item[1].gameObject;
            val_42 = 1;
            label_49:
            val_41.SetActive(value:  true);
            goto label_53;
        }
    
    }

}
