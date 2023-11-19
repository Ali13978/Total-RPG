using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    public class FlowLayoutGroup : LayoutGroup
    {
        // Fields
        public float SpacingX;
        public float SpacingY;
        public bool ExpandHorizontalSpacing;
        public bool ChildForceExpandWidth;
        public bool ChildForceExpandHeight;
        private float _layoutHeight;
        private readonly System.Collections.Generic.IList<UnityEngine.RectTransform> _rowList;
        
        // Properties
        protected bool IsCenterAlign { get; }
        protected bool IsRightAlign { get; }
        protected bool IsMiddleAlign { get; }
        protected bool IsLowerAlign { get; }
        
        // Methods
        public FlowLayoutGroup()
        {
            this._rowList = new System.Collections.Generic.List<UnityEngine.RectTransform>();
        }
        public override void CalculateLayoutInputHorizontal()
        {
            this.CalculateLayoutInputHorizontal();
            float val_6 = (float)this.padding.left;
            val_6 = this.GetGreatestMinimumChildWidth() + val_6;
            val_6 = val_6 + (float)this.padding.right;
            this.SetLayoutInputForAxis(totalMin:  val_6, totalPreferred:  -1f, totalFlexible:  -1f, axis:  0);
        }
        public override void SetLayoutHorizontal()
        {
            UnityEngine.Rect val_2 = this.rectTransform.rect;
            float val_3 = this.SetLayout(width:  val_2.m_XMin, axis:  0, layoutInput:  false);
        }
        public override void SetLayoutVertical()
        {
            UnityEngine.Rect val_2 = this.rectTransform.rect;
            float val_3 = this.SetLayout(width:  val_2.m_XMin, axis:  1, layoutInput:  false);
        }
        public override void CalculateLayoutInputVertical()
        {
            UnityEngine.Rect val_2 = this.rectTransform.rect;
            this._layoutHeight = this.SetLayout(width:  val_2.m_XMin, axis:  1, layoutInput:  true);
        }
        protected bool get_IsCenterAlign()
        {
            var val_5;
            if(this.childAlignment != 7)
            {
                    if(this.childAlignment != 4)
            {
                    return (bool)(this.childAlignment == 1) ? 1 : 0;
            }
            
            }
            
            val_5 = 1;
            return (bool)(this.childAlignment == 1) ? 1 : 0;
        }
        protected bool get_IsRightAlign()
        {
            var val_5;
            if(this.childAlignment != 8)
            {
                    if(this.childAlignment != 5)
            {
                    return (bool)(this.childAlignment == 2) ? 1 : 0;
            }
            
            }
            
            val_5 = 1;
            return (bool)(this.childAlignment == 2) ? 1 : 0;
        }
        protected bool get_IsMiddleAlign()
        {
            var val_5;
            if(this.childAlignment != 3)
            {
                    if(this.childAlignment != 5)
            {
                    return (bool)(this.childAlignment == 4) ? 1 : 0;
            }
            
            }
            
            val_5 = 1;
            return (bool)(this.childAlignment == 4) ? 1 : 0;
        }
        protected bool get_IsLowerAlign()
        {
            var val_5;
            if(this.childAlignment != 6)
            {
                    if(this.childAlignment != 8)
            {
                    return (bool)(this.childAlignment == 7) ? 1 : 0;
            }
            
            }
            
            val_5 = 1;
            return (bool)(this.childAlignment == 7) ? 1 : 0;
        }
        public float SetLayout(float width, int axis, bool layoutInput)
        {
            float val_47;
            var val_48;
            float val_49;
            float val_50;
            int val_51;
            int val_52;
            var val_53;
            var val_54;
            var val_55;
            float val_56;
            var val_57;
            UnityEngine.Rect val_2 = this.rectTransform.rect;
            UnityEngine.Rect val_4 = this.rectTransform.rect;
            float val_46 = val_4.m_XMin;
            UnityEngine.RectOffset val_10 = this.padding;
            val_46 = val_46 - (float)this.padding.left;
            if(this.IsLowerAlign != false)
            {
                    int val_11 = val_10.bottom;
            }
            
            val_47 = 0f;
            val_48 = 0;
            float val_13 = val_46 - (float)this.padding.right;
            float val_48 = (float)val_10.top;
            val_49 = val_47;
            val_50 = val_47;
            goto label_8;
            label_31:
            val_48 = 1;
            label_8:
            if(val_48 >= this.rectChildren.Count)
            {
                goto label_10;
            }
            
            val_51 = val_48;
            if(this.IsLowerAlign != false)
            {
                    val_51 = this.rectChildren.Count + val_48;
            }
            
            UnityEngine.RectTransform val_20 = this.rectChildren.Item[val_51];
            val_52 = 1;
            float val_22 = UnityEngine.UI.LayoutUtility.GetPreferredSize(rect:  0, axis:  val_20);
            float val_23 = UnityEngine.Mathf.Min(a:  UnityEngine.UI.LayoutUtility.GetPreferredSize(rect:  0, axis:  val_20), b:  val_13);
            val_23 = val_50 + val_23;
            if(val_23 > val_13)
            {
                    if(layoutInput != true)
            {
                    val_50 = val_50 - this.SpacingX;
                val_52 = axis;
                this.LayoutRow(contents:  0, rowWidth:  val_50, rowHeight:  val_49, maxWidth:  val_13, xOffset:  (float)this.padding.left, yOffset:  this.CalculateRowVerticalOffset(groupHeight:  val_2.m_XMin, yOffset:  val_48, currentRowHeight:  val_49), axis:  val_52);
            }
            
                var val_47 = 0;
                val_47 = val_47 + 1;
                val_52 = 3;
                val_53 = this._rowList;
                val_49 = val_47;
                val_50 = val_47;
                val_48 = (val_49 + val_48) + this.SpacingY;
            }
            
            var val_49 = 0;
            val_49 = val_49 + 1;
            val_52 = 2;
            val_54 = this._rowList;
            var val_31 = (val_22 > val_49) ? (val_22) : (val_49);
            val_50 = val_23 + val_50;
            if(val_48 >= (this.rectChildren.Count - 1))
            {
                goto label_31;
            }
            
            val_50 = val_50 + this.SpacingX;
            goto label_31;
            label_10:
            if(layoutInput != true)
            {
                    float val_51 = this.SpacingX;
                val_47 = this.CalculateRowVerticalOffset(groupHeight:  val_2.m_XMin, yOffset:  val_48, currentRowHeight:  val_49);
                var val_50 = 0;
                val_50 = val_50 + 1;
                val_55 = this._rowList;
                if(this._rowList < 2)
            {
                    val_56 = 0f;
            }
            else
            {
                    val_56 = this.SpacingX;
            }
            
                val_51 = val_50 - val_51;
                this.LayoutRow(contents:  0, rowWidth:  val_51, rowHeight:  val_49, maxWidth:  val_13 - val_56, xOffset:  (float)this.padding.left, yOffset:  val_47, axis:  axis);
            }
            
            var val_52 = 0;
            val_52 = val_52 + 1;
            val_57 = this._rowList;
            UnityEngine.RectOffset val_43 = this.padding;
            val_48 = val_49 + val_48;
            if(this.IsLowerAlign != false)
            {
                    int val_44 = val_43.top;
            }
            
            val_48 = val_48 + (float)val_43.bottom;
            if(axis != 1)
            {
                    return val_48;
            }
            
            if(layoutInput == false)
            {
                    return val_48;
            }
            
            this.SetLayoutInputForAxis(totalMin:  val_48, totalPreferred:  val_48, totalFlexible:  -1f, axis:  1);
            return val_48;
        }
        private float CalculateRowVerticalOffset(float groupHeight, float yOffset, float currentRowHeight)
        {
            float val_4 = yOffset;
            if(this.IsLowerAlign != false)
            {
                    groupHeight = groupHeight - val_4;
                val_4 = groupHeight - currentRowHeight;
                return (float)val_4;
            }
            
            if(this.IsMiddleAlign == false)
            {
                    return (float)val_4;
            }
            
            float val_4 = this._layoutHeight;
            val_4 = val_4 * 0.5f;
            val_4 = (groupHeight * 0.5f) - val_4;
            val_4 = val_4 + val_4;
            return (float)val_4;
        }
        protected void LayoutRow(System.Collections.Generic.IList<UnityEngine.RectTransform> contents, float rowWidth, float rowHeight, float maxWidth, float xOffset, float yOffset, int axis)
        {
            float val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            float val_39;
            var val_40;
            UnityEngine.RectTransform val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            val_30 = xOffset;
            float val_34 = rowWidth;
            if(this.ChildForceExpandWidth == true)
            {
                goto label_3;
            }
            
            if(this.IsCenterAlign == false)
            {
                goto label_2;
            }
            
            rowWidth = maxWidth - val_34;
            rowWidth = rowWidth * 0.5f;
            label_49:
            val_30 = rowWidth + val_30;
            label_48:
            if(this.ChildForceExpandWidth == true)
            {
                goto label_3;
            }
            
            if(this.ExpandHorizontalSpacing == false)
            {
                goto label_70;
            }
            
            var val_29 = 0;
            val_29 = val_29 + 1;
            val_31 = this._rowList;
            goto label_9;
            label_2:
            if(this.ChildForceExpandWidth == false)
            {
                goto label_10;
            }
            
            label_3:
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_32 = 0;
            val_33 = this._rowList;
            rowWidth = maxWidth - val_34;
            label_70:
            val_34 = 0;
            goto label_16;
            label_47:
            val_34 = 1;
            label_16:
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_32 = 0;
            val_35 = this._rowList;
            if(val_34 >= this._rowList)
            {
                    return;
            }
            
            val_36 = val_34;
            if(this.IsLowerAlign != false)
            {
                    var val_32 = 0;
                val_32 = val_32 + 1;
                val_32 = 0;
                val_37 = this._rowList;
                val_36 = this._rowList + val_34;
            }
            
            var val_33 = 0;
            val_33 = val_33 + 1;
            val_32 = 3;
            val_38 = this._rowList;
            val_34 = (rowWidth / (float)this._rowList) + (UnityEngine.UI.LayoutUtility.GetPreferredSize(rect:  0, axis:  this._rowList));
            float val_10 = (this.ChildForceExpandHeight == true) ? rowHeight : UnityEngine.UI.LayoutUtility.GetPreferredSize(rect:  0, axis:  this._rowList);
            float val_11 = UnityEngine.Mathf.Min(a:  val_34, b:  maxWidth);
            if(this.IsMiddleAlign == false)
            {
                goto label_36;
            }
            
            val_39 = (rowHeight - val_10) * 0.5f;
            goto label_37;
            label_36:
            if(this.IsLowerAlign == false)
            {
                goto label_38;
            }
            
            val_39 = rowHeight - val_10;
            label_37:
            val_39 = val_39 + yOffset;
            label_38:
            val_30 = (this.ExpandHorizontalSpacing < false) ? (val_30) : (0f + val_30);
            if(axis != 0)
            {
                    val_40 = 1;
                val_41 = this._rowList;
            }
            else
            {
                    val_40 = 0;
                val_41 = this._rowList;
            }
            
            this.SetChildAlongAxis(rect:  val_41, axis:  0, pos:  val_30, size:  val_11);
            var val_35 = 0;
            val_35 = val_35 + 1;
            val_42 = this._rowList;
            if(val_34 >= (this._rowList - 1))
            {
                goto label_47;
            }
            
            float val_36 = this.SpacingX;
            val_36 = val_11 + val_36;
            val_30 = val_30 + val_36;
            goto label_47;
            label_10:
            if(this.IsRightAlign == false)
            {
                goto label_48;
            }
            
            rowWidth = maxWidth - val_34;
            goto label_49;
            label_9:
            val_34 = maxWidth - val_34;
            var val_37 = 0;
            val_37 = val_37 + 1;
            val_43 = this._rowList;
            float val_22 = val_34 / ((float)this._rowList - 1);
            if(this._rowList < 2)
            {
                goto label_70;
            }
            
            if(this.IsCenterAlign == false)
            {
                goto label_57;
            }
            
            var val_38 = 0;
            val_38 = val_38 + 1;
            val_44 = this._rowList;
            goto label_62;
            label_57:
            if(this.IsRightAlign == false)
            {
                goto label_70;
            }
            
            var val_39 = 0;
            val_39 = val_39 + 1;
            val_45 = this._rowList;
            goto label_68;
            label_62:
            float val_40 = -0.5f;
            val_40 = val_22 * val_40;
            val_40 = val_40 * ((float)this._rowList - 1);
            val_30 = val_30 + val_40;
            goto label_70;
            label_68:
            float val_41 = (float)this._rowList - 1;
            val_41 = val_22 * val_41;
            val_30 = val_30 - val_41;
            goto label_70;
        }
        public float GetGreatestMinimumChildWidth()
        {
            var val_7;
            float val_8;
            val_7 = 0;
            val_8 = 0f;
            goto label_1;
            label_7:
            val_8 = UnityEngine.Mathf.Max(a:  V9.16B, b:  val_8);
            val_7 = 1;
            label_1:
            if(val_7 >= this.rectChildren.Count)
            {
                    return (float)val_8;
            }
            
            UnityEngine.RectTransform val_5 = this.rectChildren.Item[1];
            float val_6 = UnityEngine.UI.LayoutUtility.GetMinWidth(rect:  0);
            goto label_7;
        }
    
    }

}
