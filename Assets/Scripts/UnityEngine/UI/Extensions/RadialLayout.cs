using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    public class RadialLayout : LayoutGroup
    {
        // Fields
        public float fDistance;
        [UnityEngine.RangeAttribute]
        public float MinAngle;
        [UnityEngine.RangeAttribute]
        public float MaxAngle;
        [UnityEngine.RangeAttribute]
        public float StartAngle;
        
        // Methods
        public RadialLayout()
        {
        
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
            var val_12;
            var val_18;
            UnityEngine.Object val_19;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            val_18 = this.transform;
            if(val_18.childCount == 0)
            {
                    return;
            }
            
            float val_6 = this.MaxAngle - this.MinAngle;
            float val_18 = this.StartAngle;
            val_18 = 0;
            goto label_4;
            label_20:
            val_18 = 1;
            label_4:
            if(val_18 >= this.transform.childCount)
            {
                    return;
            }
            
            UnityEngine.Transform val_11 = this.transform.GetChild(index:  1);
            val_19 = 0;
            if(val_11 != null)
            {
                    val_19 = val_11;
                if(null != null)
            {
                    val_19 = 0;
            }
            
            }
            
            if(0 == val_19)
            {
                goto label_20;
            }
            
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_6, y = (float)this.transform.childCount});
            float val_15 = val_18 * 0.01745329f;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  this.fDistance);
            val_19.localPosition = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
            val_12 = 0;
            CinemachineFreeLook.Orbit val_17 = new CinemachineFreeLook.Orbit(h:  0.5f, r:  0.5f);
            if(val_19 != 0)
            {
                    val_19.pivot = new UnityEngine.Vector2() {x = val_17.m_Height, y = val_17.m_Radius};
                val_19.anchorMax = new UnityEngine.Vector2() {x = val_17.m_Height, y = val_17.m_Radius};
            }
            else
            {
                    val_19.pivot = new UnityEngine.Vector2() {x = val_17.m_Height, y = val_17.m_Radius};
                val_19.anchorMax = new UnityEngine.Vector2() {x = val_17.m_Height, y = val_17.m_Radius};
            }
            
            val_19.anchorMin = new UnityEngine.Vector2() {x = val_17.m_Height, y = val_17.m_Radius};
            val_18 = (val_6 / (float)this.transform.childCount) + val_18;
            goto label_20;
        }
    
    }

}
