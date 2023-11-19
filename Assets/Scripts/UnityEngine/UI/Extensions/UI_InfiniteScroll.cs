using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    public class UI_InfiniteScroll : MonoBehaviour
    {
        // Fields
        [UnityEngine.TooltipAttribute]
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
        private bool _hasDisabledGridComponents;
        private System.Collections.Generic.List<UnityEngine.RectTransform> items;
        private UnityEngine.Vector2 _newAnchoredPosition;
        private float _treshold;
        private int _itemCount;
        private float _recordOffsetX;
        private float _recordOffsetY;
        
        // Methods
        public UI_InfiniteScroll()
        {
            this.items = new System.Collections.Generic.List<UnityEngine.RectTransform>();
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            this._newAnchoredPosition = val_2;
            mem[1152921512801117748] = val_2.y;
            this._treshold = 100f;
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
            var val_39;
            if(0 == (this.GetComponent<UnityEngine.UI.ScrollRect>()))
            {
                goto label_3;
            }
            
            UnityEngine.UI.ScrollRect val_3 = this.GetComponent<UnityEngine.UI.ScrollRect>();
            this._scrollRect = val_3;
            val_3.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<UnityEngine.Vector2>(object:  this, method:  public System.Void UnityEngine.UI.Extensions.UI_InfiniteScroll::OnScroll(UnityEngine.Vector2 pos)));
            this._scrollRect.movementType = 0;
            val_39 = 0;
            goto label_7;
            label_15:
            Add(item:  public System.Void UnityEngine.UI.Extensions.UI_InfiniteScroll::OnScroll(UnityEngine.Vector2 pos));
            val_39 = 1;
            label_7:
            if(val_39 >= this._scrollRect.content.childCount)
            {
                goto label_10;
            }
            
            UnityEngine.RectTransform val_10 = this._scrollRect.content.GetChild(index:  1).GetComponent<UnityEngine.RectTransform>();
            if(this.items != null)
            {
                goto label_15;
            }
            
            goto label_15;
            label_3:
            UnityEngine.Debug.LogError(message:  0);
            return;
            label_10:
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
            
            if(0 != (this._scrollRect.content.GetComponent<UnityEngine.UI.ContentSizeFitter>()))
            {
                    this._contentSizeFitter = this._scrollRect.content.GetComponent<UnityEngine.UI.ContentSizeFitter>();
            }
            
            this._isHorizontal = this._scrollRect.horizontal;
            bool val_33 = this._scrollRect.vertical;
            this._isVertical = val_33;
            if(this._isHorizontal != false)
            {
                    if(val_33 ^ 1 != true)
            {
                    UnityEngine.Debug.LogError(message:  0);
            }
            
            }
            
            this._itemCount = this._scrollRect.content.childCount;
        }
        private void DisableGridComponents()
        {
            bool val_18;
            if((this._isVertical & 255) != false)
            {
                    UnityEngine.Vector2 val_4 = this.items.Item[0].GetComponent<UnityEngine.RectTransform>().anchoredPosition;
                UnityEngine.Vector2 val_7 = this.items.Item[1].GetComponent<UnityEngine.RectTransform>().anchoredPosition;
                val_18 = this._isHorizontal;
                val_7.y = val_4.y - val_7.y;
                this._recordOffsetY = val_7.y;
                float val_18 = (float)this._itemCount;
                val_18 = val_7.y * val_18;
                val_18 = val_18 * 0.5f;
                this._disableMarginY = val_18;
            }
            else
            {
                    val_18 = this._isVertical >> 8;
            }
            
            if(val_18 != false)
            {
                    UnityEngine.Vector2 val_10 = this.items.Item[1].GetComponent<UnityEngine.RectTransform>().anchoredPosition;
                UnityEngine.Vector2 val_13 = this.items.Item[0].GetComponent<UnityEngine.RectTransform>().anchoredPosition;
                val_13.x = val_10.x - val_13.x;
                this._recordOffsetX = val_13.x;
                val_13.x = val_13.x * (float)this._itemCount;
                val_13.x = val_13.x * 0.5f;
                this._disableMarginX = val_13.x;
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
            
            this._hasDisabledGridComponents = true;
        }
        public void OnScroll(UnityEngine.Vector2 pos)
        {
            var val_52;
            float val_53;
            float val_54;
            float val_55;
            if(this._hasDisabledGridComponents != true)
            {
                    this.DisableGridComponents();
            }
            
            val_52 = 0;
            goto label_2;
            label_69:
            val_52 = 1;
            label_2:
            if(val_52 >= this.items.Count)
            {
                    return;
            }
            
            if(this._isHorizontal != false)
            {
                    UnityEngine.Vector3 val_6 = this.items.Item[1].gameObject.transform.position;
                UnityEngine.Vector3 val_7 = this._scrollRect.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
                float val_52 = this._disableMarginX;
                val_52 = val_52 + this._treshold;
                if(val_7.x > val_52)
            {
                    UnityEngine.Vector2 val_9 = this.items.Item[1].anchoredPosition;
                mem[1152921512802289172] = val_9.y;
                val_53 = this._recordOffsetX;
                float val_53 = (float)this._itemCount;
                val_53 = val_53 * val_53;
                val_9.x = val_9.x - val_53;
                this._newAnchoredPosition = val_9.x;
                val_54 = this._newAnchoredPosition;
                val_55 = val_6.y;
                this.items.Item[1].anchoredPosition = new UnityEngine.Vector2() {x = val_54, y = val_55};
                this._scrollRect.content.GetChild(index:  this._itemCount - 1).transform.SetAsFirstSibling();
            }
            else
            {
                    UnityEngine.Vector3 val_19 = this.items.Item[1].gameObject.transform.position;
                val_54 = val_19.x;
                val_53 = val_19.z;
                UnityEngine.Vector3 val_20 = this._scrollRect.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_54, y = val_19.y, z = val_53});
                val_55 = -this._disableMarginX;
                if(val_20.x < 0)
            {
                    UnityEngine.Vector2 val_22 = this.items.Item[1].anchoredPosition;
                mem[1152921512802289172] = val_22.y;
                val_53 = this._recordOffsetX;
                float val_54 = (float)this._itemCount;
                val_54 = val_54 * val_53;
                val_22.x = val_22.x + val_54;
                this._newAnchoredPosition = val_22.x;
                val_54 = this._newAnchoredPosition;
                val_55 = val_19.y;
                this.items.Item[1].anchoredPosition = new UnityEngine.Vector2() {x = val_54, y = val_55};
                this._scrollRect.content.GetChild(index:  0).transform.SetAsLastSibling();
            }
            
            }
            
            }
            
            if(this._isVertical == false)
            {
                goto label_69;
            }
            
            UnityEngine.Vector3 val_31 = this.items.Item[1].gameObject.transform.position;
            UnityEngine.Vector3 val_32 = this._scrollRect.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
            float val_55 = this._disableMarginY;
            val_55 = val_55 + this._treshold;
            if(val_32.y <= val_55)
            {
                goto label_44;
            }
            
            UnityEngine.Vector2 val_34 = this.items.Item[1].anchoredPosition;
            this._newAnchoredPosition = val_34;
            float val_56 = (float)this._itemCount;
            val_56 = val_56 * this._recordOffsetY;
            val_56 = val_34.y - val_56;
            mem[1152921512802289172] = val_56;
            this.items.Item[1].anchoredPosition = new UnityEngine.Vector2() {x = this._newAnchoredPosition, y = val_31.y};
            this._scrollRect.content.GetChild(index:  this._itemCount - 1).transform.SetAsFirstSibling();
            goto label_69;
            label_44:
            UnityEngine.Vector3 val_44 = this.items.Item[1].gameObject.transform.position;
            UnityEngine.Vector3 val_45 = this._scrollRect.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_44.x, y = val_44.y, z = val_44.z});
            if(val_45.y >= 0)
            {
                goto label_69;
            }
            
            UnityEngine.Vector2 val_47 = this.items.Item[1].anchoredPosition;
            this._newAnchoredPosition = val_47;
            float val_57 = (float)this._itemCount;
            val_57 = val_57 * this._recordOffsetY;
            val_57 = val_47.y + val_57;
            mem[1152921512802289172] = val_57;
            this.items.Item[1].anchoredPosition = new UnityEngine.Vector2() {x = this._newAnchoredPosition, y = val_44.y};
            this._scrollRect.content.GetChild(index:  0).transform.SetAsLastSibling();
            goto label_69;
        }
    
    }

}
