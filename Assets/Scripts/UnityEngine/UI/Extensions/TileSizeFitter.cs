using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.ExecuteInEditMode]
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    public class TileSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Vector2 m_Border;
        [UnityEngine.SerializeField]
        private UnityEngine.Vector2 m_TileSize;
        private UnityEngine.RectTransform m_Rect;
        private UnityEngine.DrivenRectTransformTracker m_Tracker;
        
        // Properties
        public UnityEngine.Vector2 Border { get; set; }
        public UnityEngine.Vector2 TileSize { get; set; }
        private UnityEngine.RectTransform rectTransform { get; }
        
        // Methods
        public TileSizeFitter()
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            this.m_Border = val_1;
            mem[1152921512749977708] = val_1.y;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            this.m_TileSize = val_2;
            mem[1152921512749977716] = val_2.y;
        }
        public UnityEngine.Vector2 get_Border()
        {
            return new UnityEngine.Vector2() {x = this.m_Border};
        }
        public void set_Border(UnityEngine.Vector2 value)
        {
            if((UnityEngine.UI.Extensions.SetPropertyUtility.SetStruct<UnityEngine.Vector2>(currentValue: ref  new UnityEngine.Vector2(), newValue:  new UnityEngine.Vector2() {x = value.x, y = value.y})) == false)
            {
                    return;
            }
            
            if(this.IsActive() == false)
            {
                    return;
            }
            
            this.UpdateRect();
        }
        public UnityEngine.Vector2 get_TileSize()
        {
            return new UnityEngine.Vector2() {x = this.m_TileSize};
        }
        public void set_TileSize(UnityEngine.Vector2 value)
        {
            if((UnityEngine.UI.Extensions.SetPropertyUtility.SetStruct<UnityEngine.Vector2>(currentValue: ref  new UnityEngine.Vector2(), newValue:  new UnityEngine.Vector2() {x = value.x, y = value.y})) == false)
            {
                    return;
            }
            
            if(this.IsActive() == false)
            {
                    return;
            }
            
            this.UpdateRect();
        }
        private UnityEngine.RectTransform get_rectTransform()
        {
            UnityEngine.RectTransform val_4;
            if(0 == this.m_Rect)
            {
                    this.m_Rect = this.GetComponent<UnityEngine.RectTransform>();
                return val_4;
            }
            
            val_4 = this.m_Rect;
            return val_4;
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            if(this.IsActive() == false)
            {
                    return;
            }
            
            this.UpdateRect();
        }
        protected override void OnDisable()
        {
            this.m_Tracker.Clear();
            UnityEngine.RectTransform val_1 = this.rectTransform;
            UnityEngine.UI.LayoutRebuilder.MarkLayoutForRebuild(rect:  0);
            this.OnDisable();
        }
        protected override void OnRectTransformDimensionsChange()
        {
            this.UpdateRect();
        }
        private void UpdateRect()
        {
            float val_18;
            float val_19;
            UnityEngine.Vector2 val_20;
            float val_21;
            if(this.IsActive() == false)
            {
                    return;
            }
            
            this.m_Tracker.Clear();
            UnityEngine.RectTransform val_2 = this.rectTransform;
            this.m_Tracker.Clear();
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
            this.rectTransform.anchorMin = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.one;
            this.rectTransform.anchorMax = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.zero;
            this.rectTransform.anchoredPosition = new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
            UnityEngine.RectTransform val_9 = this.rectTransform;
            this.m_Tracker.Clear();
            UnityEngine.Vector2 val_10 = this.GetParentSize();
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, b:  new UnityEngine.Vector2() {x = this.m_Border});
            val_18 = 0f;
            val_19 = val_18;
            if(this.m_TileSize > 0.001f)
            {
                    val_20 = this.m_TileSize;
                val_20 = this.m_TileSize;
                val_20 = this.m_TileSize;
                val_20 = (val_11.x / this.m_TileSize) * val_20;
                val_19 = val_11.x - val_20;
            }
            
            if(val_11.x > 0.001f)
            {
                    val_21 = val_11.x;
                val_21 = val_11.x;
                val_21 = (val_11.y / val_11.x) * val_21;
                val_18 = val_11.y - val_21;
            }
            
            UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_UnaryNegation(a:  new UnityEngine.Vector2() {x = val_19, y = val_18});
            this.rectTransform.sizeDelta = new UnityEngine.Vector2() {x = val_15.x, y = val_15.y};
        }
        private UnityEngine.Vector2 GetParentSize()
        {
            var val_8 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    UnityEngine.Rect val_6 = (null == null) ? this.rectTransform.parent : 0.rect;
                return new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
            }
            
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.zero;
            return new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
        }
        public virtual void SetLayoutHorizontal()
        {
        
        }
        public virtual void SetLayoutVertical()
        {
        
        }
        protected void SetDirty()
        {
            if(this.IsActive() == false)
            {
                    return;
            }
            
            this.UpdateRect();
        }
    
    }

}
