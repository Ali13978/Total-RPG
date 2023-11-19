using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    public class CurvedLayout : LayoutGroup
    {
        // Fields
        public UnityEngine.Vector3 CurveOffset;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.Vector3 itemAxis;
        [UnityEngine.TooltipAttribute]
        public float itemSize;
        public float centerpoint;
        
        // Methods
        public CurvedLayout()
        {
            this.centerpoint = 0.5f;
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this.CalculateRadial();
        }
        public override void SetLayoutHorizontal()
        {
        
        }
        public override void SetLayoutVertical()
        {
        
        }
        public override void CalculateLayoutInputVertical()
        {
            this.CalculateRadial();
        }
        public override void CalculateLayoutInputHorizontal()
        {
            this.CalculateRadial();
        }
        private void CalculateRadial()
        {
            var val_22;
            var val_29;
            UnityEngine.Object val_30;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            val_29 = this.transform;
            if(val_29.childCount == 0)
            {
                    return;
            }
            
            UnityEngine.TextAnchor val_4 = this.childAlignment;
            var val_29 = (long)val_4;
            val_29 = val_29 * 1431655766;
            var val_6 = (long)this.childAlignment * 1431655766;
            val_29 = val_29 >> 32;
            val_29 = val_29 + (val_29 >> 63);
            val_6 = val_6 >> 32;
            val_29 = val_29 + (val_29 << 1);
            val_6 = val_6 + (val_6 >> 63);
            val_29 = val_4 - val_29;
            float val_31 = 0.5f;
            float val_30 = (float)val_29;
            val_30 = val_30 * val_31;
            val_31 = (float)val_6 * val_31;
            CinemachineFreeLook.Orbit val_9 = new CinemachineFreeLook.Orbit(h:  val_30, r:  val_31);
            float val_33 = 0f;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.GetStartOffset(axis:  0, requiredSpaceWithoutPadding:  this.GetTotalPreferredSize(axis:  0)), y = this.GetStartOffset(axis:  1, requiredSpaceWithoutPadding:  this.GetTotalPreferredSize(axis:  1)), z = val_33}, d:  this.itemSize);
            val_29 = 0;
            goto label_6;
            label_21:
            val_29 = 1;
            label_6:
            if(val_29 >= this.transform.childCount)
            {
                    return;
            }
            
            UnityEngine.Transform val_21 = this.transform.GetChild(index:  1);
            val_30 = 0;
            if(val_21 != null)
            {
                    val_30 = val_21;
                if(null != null)
            {
                    val_30 = 0;
            }
            
            }
            
            if(0 == val_30)
            {
                goto label_21;
            }
            
            UnityEngine.Vector2 val_24 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            float val_32 = this.centerpoint;
            val_32 = val_33 - val_32;
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Multiply(d:  val_32, a:  new UnityEngine.Vector3() {x = this.CurveOffset, y = val_17.y, z = val_17.x});
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, b:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
            val_30.localPosition = new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z};
            val_30.pivot = new UnityEngine.Vector2() {x = val_9.m_Height, y = val_9.m_Radius};
            val_22 = 0;
            CinemachineFreeLook.Orbit val_28 = new CinemachineFreeLook.Orbit(h:  0.5f, r:  0.5f);
            if(val_30 != 0)
            {
                    val_30.anchorMax = new UnityEngine.Vector2() {x = val_28.m_Height, y = val_28.m_Radius};
            }
            else
            {
                    val_30.anchorMax = new UnityEngine.Vector2() {x = val_28.m_Height, y = val_28.m_Radius};
            }
            
            val_30.anchorMin = new UnityEngine.Vector2() {x = val_28.m_Height, y = val_28.m_Radius};
            val_33 = (1f / (float)this.transform.childCount) + val_33;
            goto label_21;
        }
    
    }

}
