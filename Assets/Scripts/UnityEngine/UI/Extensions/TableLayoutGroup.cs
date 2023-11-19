using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    public class TableLayoutGroup : LayoutGroup
    {
        // Fields
        [UnityEngine.SerializeField]
        protected UnityEngine.UI.Extensions.TableLayoutGroup.Corner startCorner;
        [UnityEngine.SerializeField]
        protected float[] columnWidths;
        [UnityEngine.SerializeField]
        protected float minimumRowHeight;
        [UnityEngine.SerializeField]
        protected bool flexibleRowHeight;
        [UnityEngine.SerializeField]
        protected float columnSpacing;
        [UnityEngine.SerializeField]
        protected float rowSpacing;
        private float[] preferredRowHeights;
        
        // Properties
        public UnityEngine.UI.Extensions.TableLayoutGroup.Corner StartCorner { get; set; }
        public float[] ColumnWidths { get; set; }
        public float MinimumRowHeight { get; set; }
        public bool FlexibleRowHeight { get; set; }
        public float ColumnSpacing { get; set; }
        public float RowSpacing { get; set; }
        
        // Methods
        public TableLayoutGroup()
        {
            typeof(System.Single[]).__il2cppRuntimeField_20 = 1119879168;
            this.flexibleRowHeight = true;
            this.columnWidths = null;
            this.minimumRowHeight = 32f;
        }
        public UnityEngine.UI.Extensions.TableLayoutGroup.Corner get_StartCorner()
        {
            return (Corner)this.startCorner;
        }
        public void set_StartCorner(UnityEngine.UI.Extensions.TableLayoutGroup.Corner value)
        {
            this.SetProperty<Corner>(currentValue: ref  this.startCorner, newValue:  value);
        }
        public float[] get_ColumnWidths()
        {
            return (System.Single[])this.columnWidths;
        }
        public void set_ColumnWidths(float[] value)
        {
            this.SetProperty<System.Single[]>(currentValue: ref  this.columnWidths, newValue:  value);
        }
        public float get_MinimumRowHeight()
        {
            return (float)this.minimumRowHeight;
        }
        public void set_MinimumRowHeight(float value)
        {
            this.SetProperty<System.Single>(currentValue: ref  this.minimumRowHeight, newValue:  value);
        }
        public bool get_FlexibleRowHeight()
        {
            return (bool)this.flexibleRowHeight;
        }
        public void set_FlexibleRowHeight(bool value)
        {
            this.SetProperty<System.Boolean>(currentValue: ref  this.flexibleRowHeight, newValue:  value);
        }
        public float get_ColumnSpacing()
        {
            return (float)this.columnSpacing;
        }
        public void set_ColumnSpacing(float value)
        {
            this.SetProperty<System.Single>(currentValue: ref  this.columnSpacing, newValue:  value);
        }
        public float get_RowSpacing()
        {
            return (float)this.rowSpacing;
        }
        public void set_RowSpacing(float value)
        {
            this.SetProperty<System.Single>(currentValue: ref  this.rowSpacing, newValue:  value);
        }
        public override void CalculateLayoutInputHorizontal()
        {
            int val_6;
            float val_7;
            float val_8;
            this.CalculateLayoutInputHorizontal();
            val_6 = this.rectChildren.Count;
            val_7 = (float)this.padding.horizontal;
            int val_5 = UnityEngine.Mathf.Min(a:  0, b:  val_6);
            if(val_5 >= 1)
            {
                    var val_7 = 0;
                val_6 = val_5;
                do
            {
                float val_6 = this.columnWidths[val_7];
                val_8 = this.columnSpacing;
                val_7 = val_7 + 1;
                val_6 = val_7 + val_6;
                val_7 = val_6 + val_8;
            }
            while(val_6 != val_7);
            
            }
            else
            {
                    val_8 = this.columnSpacing;
            }
            
            val_8 = val_7 - val_8;
            this.SetLayoutInputForAxis(totalMin:  val_8, totalPreferred:  val_8, totalFlexible:  0f, axis:  0);
        }
        public override void CalculateLayoutInputVertical()
        {
            float val_21;
            var val_22;
            float val_23;
            float val_24;
            float val_25;
            float val_26;
            val_21 = (float)this.rectChildren.Count / (float)this.columnWidths.Length;
            int val_3 = UnityEngine.Mathf.CeilToInt(f:  val_21);
            this.preferredRowHeights = null;
            val_22 = this.padding.vertical;
            val_23 = (float)val_22;
            val_24 = (float)this.padding.vertical;
            if(val_3 >= 2)
            {
                    val_21 = ((float)val_3 - 1) * this.rowSpacing;
                val_23 = val_23 + val_21;
                val_24 = val_24 + val_21;
            }
            
            if(this.flexibleRowHeight == false)
            {
                goto label_8;
            }
            
            if(val_3 < 1)
            {
                goto label_22;
            }
            
            var val_22 = 0;
            var val_21 = 0;
            label_21:
            val_25 = this.minimumRowHeight;
            if(this.columnWidths.Length < 1)
            {
                goto label_10;
            }
            
            var val_20 = 0;
            val_22 = val_22;
            val_26 = val_25;
            label_17:
            if(val_22 == this.rectChildren.Count)
            {
                goto label_18;
            }
            
            UnityEngine.RectTransform val_12 = this.rectChildren.Item[0];
            val_26 = UnityEngine.Mathf.Max(a:  UnityEngine.UI.LayoutUtility.GetPreferredHeight(rect:  0), b:  val_26);
            UnityEngine.RectTransform val_16 = this.rectChildren.Item[0];
            val_25 = UnityEngine.Mathf.Max(a:  UnityEngine.UI.LayoutUtility.GetMinHeight(rect:  0), b:  val_25);
            val_20 = val_20 + 1;
            val_22 = val_22 + 1;
            if(val_20 < this.columnWidths.Length)
            {
                goto label_17;
            }
            
            goto label_18;
            label_10:
            val_26 = val_25;
            label_18:
            this.preferredRowHeights[val_21] = val_26;
            val_23 = val_23 + val_25;
            val_24 = val_24 + val_26;
            val_21 = val_21 + 1;
            val_22 = val_22 + this.columnWidths.Length;
            if(val_21 != val_3)
            {
                goto label_21;
            }
            
            goto label_22;
            label_8:
            if(val_3 >= 1)
            {
                    var val_23 = 0;
                val_22 = val_3;
                do
            {
                val_23 = val_23 + 1;
                this.preferredRowHeights[val_23] = this.minimumRowHeight;
            }
            while(val_22 != val_23);
            
            }
            
            float val_24 = this.minimumRowHeight;
            val_24 = (float)val_3 * val_24;
            val_24 = val_23 + val_24;
            val_23 = val_24;
            label_22:
            this.SetLayoutInputForAxis(totalMin:  val_23, totalPreferred:  UnityEngine.Mathf.Max(a:  val_23, b:  val_24), totalFlexible:  1f, axis:  1);
        }
        public override void SetLayoutHorizontal()
        {
            System.Single[] val_15;
            float val_16;
            float val_17;
            var val_18;
            float val_19;
            if(this.columnWidths.Length != 0)
            {
                    val_15 = this.columnWidths;
            }
            else
            {
                    val_15 = null;
                this.columnWidths = val_15;
            }
            
            var val_1 = (this.startCorner < 0) ? (this.startCorner + 1) : this.startCorner;
            val_1 = val_1 & 4294967294;
            val_1 = this.startCorner - val_1;
            int val_4 = UnityEngine.Mathf.Min(a:  0, b:  this.rectChildren.Count);
            if(val_4 >= 1)
            {
                    var val_16 = 0;
                do
            {
                float val_15 = this.columnWidths[val_16];
                val_16 = this.columnSpacing;
                val_16 = val_16 + 1;
                val_15 = 0f + val_15;
                val_17 = val_15 + val_16;
            }
            while(val_4 != val_16);
            
            }
            else
            {
                    val_16 = this.columnSpacing;
                val_17 = 0f;
            }
            
            val_17 = val_17 - val_16;
            float val_5 = this.GetStartOffset(axis:  0, requiredSpaceWithoutPadding:  val_17);
            val_18 = 0;
            goto label_14;
            label_27:
            val_18 = 1;
            label_14:
            if(val_18 >= this.rectChildren.Count)
            {
                    return;
            }
            
            if(val_1 == 1)
            {
                    val_19 = (((val_18 - ((val_18 / System.Single[].__il2cppRuntimeField_namespaze) * System.Single[].__il2cppRuntimeField_namespaze)) == 0) ? ((val_1 == 1) ? (val_5 + val_17) : (val_5)) : ((val_1 == 1) ? (val_5 + val_17) : (val_5))) - (this.columnWidths[(long)(long)(int)(val_18 - ((val_18 / System.Single[].__il2cppRuntimeField_namespaze) * System.Single[].__il2cppRuntimeField_namespaze))]);
            }
            
            this.SetChildAlongAxis(rect:  this.rectChildren.Item[1], axis:  0, pos:  val_19, size:  this.columnWidths[(long)(long)(int)(val_18 - ((val_18 / System.Single[].__il2cppRuntimeField_namespaze) * System.Single[].__il2cppRuntimeField_namespaze))]);
            if(val_1 != 1)
            {
                goto label_23;
            }
            
            val_19 = val_19 - this.columnSpacing;
            goto label_27;
            label_23:
            float val_19 = this.columnWidths[(long)(long)(int)(val_18 - ((val_18 / System.Single[].__il2cppRuntimeField_namespaze) * System.Single[].__il2cppRuntimeField_namespaze))];
            val_19 = val_19 + this.columnSpacing;
            val_19 = val_19 + val_19;
            goto label_27;
        }
        public override void SetLayoutVertical()
        {
            float val_8;
            System.Single[] val_9;
            int val_10;
            float val_11;
            val_8 = 0f;
            if(this.preferredRowHeights.Length >= 1)
            {
                    do
            {
                val_9 = this.preferredRowHeights;
                val_10 = 0 + 1;
                val_8 = val_8 + val_9[0];
            }
            while(this.preferredRowHeights.Length != val_10);
            
                if(this.preferredRowHeights.Length > val_10)
            {
                    float val_9 = this.rowSpacing;
                float val_10 = (float)this.preferredRowHeights.Length - 1;
                val_9 = val_10 * val_9;
                val_8 = val_8 + val_9;
            }
            
            }
            
            float val_2 = this.GetStartOffset(axis:  1, requiredSpaceWithoutPadding:  val_8);
            if(this.preferredRowHeights.Length < 1)
            {
                goto label_8;
            }
            
            Corner val_3 = this.startCorner & 4294967294;
            var val_17 = 0;
            var val_16 = 0;
            val_10 = val_8 + val_2;
            val_8 = (val_3 == 2) ? (val_10) : (val_2);
            label_23:
            if(val_3 == 2)
            {
                    val_11 = val_8 - this.preferredRowHeights[val_16];
            }
            
            if(this.columnWidths.Length < 1)
            {
                goto label_14;
            }
            
            var val_13 = 0;
            var val_14 = val_17;
            label_18:
            if(val_14 == this.rectChildren.Count)
            {
                goto label_14;
            }
            
            this.SetChildAlongAxis(rect:  this.rectChildren.Item[0], axis:  1, pos:  val_11, size:  this.preferredRowHeights[val_16]);
            val_13 = val_13 + 1;
            val_14 = val_14 + 1;
            if(val_13 < this.columnWidths.Length)
            {
                goto label_18;
            }
            
            label_14:
            val_9 = val_3;
            if(val_9 == 2)
            {
                    val_10 = this.preferredRowHeights.Length;
                val_8 = val_11 - this.rowSpacing;
            }
            else
            {
                    val_10 = this.preferredRowHeights.Length;
                float val_15 = this.preferredRowHeights[val_16];
                val_15 = val_15 + this.rowSpacing;
                val_8 = val_11 + val_15;
            }
            
            val_16 = val_16 + 1;
            val_17 = val_17 + this.columnWidths.Length;
            if(val_16 != val_10)
            {
                goto label_23;
            }
            
            label_8:
            this.preferredRowHeights = 0;
        }
    
    }

}
