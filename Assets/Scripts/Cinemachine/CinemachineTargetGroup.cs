using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [UnityEngine.AddComponentMenu]
    [Cinemachine.SaveDuringPlayAttribute]
    [UnityEngine.ExecuteInEditMode]
    public class CinemachineTargetGroup : MonoBehaviour
    {
        // Fields
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineTargetGroup.PositionMode m_PositionMode;
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineTargetGroup.RotationMode m_RotationMode;
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineTargetGroup.UpdateMethod m_UpdateMethod;
        [Cinemachine.NoSaveDuringPlayAttribute]
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineTargetGroup.Target[] m_Targets;
        private float m_lastRadius;
        
        // Properties
        public UnityEngine.Bounds BoundingBox { get; }
        public bool IsEmpty { get; }
        
        // Methods
        public CinemachineTargetGroup()
        {
            this.m_UpdateMethod = 2;
            this.m_Targets = null;
        }
        public UnityEngine.Bounds get_BoundingBox()
        {
            Target[] val_10;
            float val_11;
            var val_12;
            UnityEngine.Bounds val_0;
            UnityEngine.Vector3 val_2 = this.CalculateAveragePosition(averageWeight: out  float val_1 = -1.113568E-15f);
            float val_11 = this.m_lastRadius;
            val_11 = val_11 + val_11;
            val_11 = 0.0001f;
            if(0f <= val_11)
            {
                goto label_4;
            }
            
            val_11 = 0f + (-0.0001f);
            val_12 = 0;
            goto label_2;
            label_21:
            val_12 = 1;
            label_2:
            val_10 = this.m_Targets;
            if(val_12 >= this.m_Targets.Length)
            {
                goto label_4;
            }
            
            if(0 == this.m_Targets[16])
            {
                goto label_21;
            }
            
            Target val_13 = this.m_Targets[16];
            float val_5 = (val_13 < 0) ? (val_13 / 0f) : 1f;
            Target val_14 = this.m_Targets[16];
            val_14 = val_14 + val_14;
            val_14 = val_5 * val_14;
            UnityEngine.Vector3 val_6 = this.m_Targets[16].position;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, t:  val_5);
            if(((0 & 1) & 1) == 0)
            {
                goto label_21;
            }
            
            goto label_21;
            label_4:
            this.m_lastRadius = UnityEngine.Mathf.Max(a:  val_11, b:  UnityEngine.Mathf.Max(a:  val_2.y, b:  val_2.z));
            val_0.m_Extents.y = 0f;
            val_0.m_Extents.z = 0f;
            val_0.m_Center.x = 0f;
            val_0.m_Center.y = 0f;
            val_0.m_Center.z = 0f;
            val_0.m_Extents.x = 0f;
            return val_0;
        }
        public bool get_IsEmpty()
        {
            var val_2;
            var val_3;
            val_2 = 0;
            goto label_1;
            label_11:
            val_2 = 1;
            label_1:
            if(val_2 >= this.m_Targets.Length)
            {
                goto label_3;
            }
            
            if(0 == this.m_Targets[16])
            {
                goto label_11;
            }
            
            if(this.m_Targets[16] <= 0.0001f)
            {
                goto label_11;
            }
            
            val_3 = 0;
            return (bool)val_3;
            label_3:
            val_3 = 1;
            return (bool)val_3;
        }
        public UnityEngine.Bounds GetViewSpaceBoundingBox(UnityEngine.Matrix4x4 mView)
        {
            var val_4;
            Target[] val_18;
            float val_19;
            var val_20;
            UnityEngine.Bounds val_0;
            val_18 = 1152921511698219616;
            UnityEngine.Vector3 val_6 = this.CalculateAveragePosition(averageWeight: out  float val_5 = -1.201014E-15f);
            float val_19 = this.m_lastRadius;
            val_19 = val_19 + val_19;
            val_19 = 0.0001f;
            if(0f <= val_19)
            {
                goto label_4;
            }
            
            val_19 = 0f + (-0.0001f);
            val_20 = 0;
            goto label_2;
            label_23:
            val_20 = 1;
            label_2:
            val_18 = this.m_Targets;
            if(val_20 >= this.m_Targets.Length)
            {
                goto label_4;
            }
            
            if(0 == this.m_Targets[16])
            {
                goto label_23;
            }
            
            Target val_21 = this.m_Targets[16];
            Target val_22 = this.m_Targets[16];
            UnityEngine.Vector3 val_10 = this.m_Targets[16].position;
            val_22 = val_22 + val_22;
            UnityEngine.Vector4 val_11 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            UnityEngine.Vector3 val_12 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector4() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w});
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, t:  (val_21 < 0) ? (val_21 / 0f) : 1f);
            UnityEngine.Vector4 val_14 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            UnityEngine.Vector3 val_15 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector4() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_14.w});
            val_4 = 0;
            if(((0 & 1) & 1) == 0)
            {
                goto label_23;
            }
            
            goto label_23;
            label_4:
            this.m_lastRadius = UnityEngine.Mathf.Max(a:  val_19, b:  UnityEngine.Mathf.Max(a:  val_6.y, b:  val_6.z));
            val_0.m_Extents.y = 0f;
            val_0.m_Extents.z = 0f;
            val_0.m_Center.x = 0f;
            val_0.m_Center.y = 0f;
            val_0.m_Center.z = 0f;
            val_0.m_Extents.x = 0f;
            return val_0;
        }
        private UnityEngine.Vector3 CalculateAveragePosition(out float averageWeight)
        {
            var val_9;
            float val_13;
            float val_14;
            float val_15;
            var val_16;
            val_9 = 1152921511698753376;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_13 = val_1.x;
            val_14 = val_1.y;
            val_15 = val_1.z;
            val_16 = 0;
            var val_14 = 0;
            goto label_3;
            label_23:
            val_16 = 1;
            label_3:
            if(val_16 >= this.m_Targets.Length)
            {
                goto label_5;
            }
            
            if(0 == this.m_Targets[16])
            {
                goto label_23;
            }
            
            if(this.m_Targets[16] <= 0.0001f)
            {
                goto label_23;
            }
            
            UnityEngine.Vector3 val_3 = this.m_Targets[16].position;
            val_14 = val_14 + 1;
            float val_15 = 0f;
            val_15 = val_15 + this.m_Targets[16];
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  this.m_Targets[16]);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_15}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            goto label_23;
            label_5:
            if(val_15 > 0.0001f)
            {
                    UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_15}, d:  val_15);
                val_13 = val_6.x;
                val_14 = val_6.y;
                val_15 = val_6.z;
            }
            
            if(val_14 != 0)
            {
                    float val_16 = 0f;
                val_16 = val_15 / val_16;
                averageWeight = val_16;
                return new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_15};
            }
            
            averageWeight = 0f;
            val_9 = this.transform;
            UnityEngine.Vector3 val_8 = val_9.position;
            val_13 = val_8.x;
            val_14 = val_8.y;
            val_15 = val_8.z;
            return new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_15};
        }
        private UnityEngine.Quaternion CalculateAverageOrientation()
        {
            var val_5;
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
            val_5 = 0;
            goto label_3;
            label_16:
            val_5 = 1;
            label_3:
            if(val_5 >= this.m_Targets.Length)
            {
                goto label_5;
            }
            
            if(0 == this.m_Targets[16])
            {
                goto label_16;
            }
            
            Target val_6 = this.m_Targets[16];
            UnityEngine.Quaternion val_3 = this.m_Targets[16].rotation;
            val_3.x = val_6 * val_3.x;
            val_3.y = val_6 * val_3.y;
            val_3.z = val_6 * val_3.z;
            val_3.w = val_6 * val_3.w;
            val_3.x = val_1.x + val_3.x;
            val_3.y = val_1.y + val_3.y;
            val_3.z = val_3.z + val_1.z;
            val_3.w = val_3.w + val_1.w;
            goto label_16;
            label_5:
            UnityEngine.Quaternion val_4 = Cinemachine.Utility.UnityQuaternionExtensions.Normalized(q:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w});
            return new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
        }
        private void OnValidate()
        {
            goto label_0;
            label_13:
            0 = 1;
            label_0:
            if(0 >= this.m_Targets.Length)
            {
                    return;
            }
            
            if(this.m_Targets[16] < 0)
            {
                    this.m_Targets[16] = 0;
            }
            
            if(this.m_Targets[16] >= 0)
            {
                goto label_13;
            }
            
            this.m_Targets[16] = 0;
            goto label_13;
        }
        private void FixedUpdate()
        {
            if(this.m_UpdateMethod != 1)
            {
                    return;
            }
            
            this.UpdateTransform();
        }
        private void Update()
        {
            if((UnityEngine.Application.isPlaying != false) && (this.m_UpdateMethod != 0))
            {
                    return;
            }
            
            this.UpdateTransform();
        }
        private void LateUpdate()
        {
            if(this.m_UpdateMethod != 2)
            {
                    return;
            }
            
            this.UpdateTransform();
        }
        private void UpdateTransform()
        {
            var val_10;
            float val_11;
            float val_12;
            if(this.IsEmpty == true)
            {
                    return;
            }
            
            if(this.m_PositionMode == 1)
            {
                goto label_1;
            }
            
            if(this.m_PositionMode != 0)
            {
                goto label_2;
            }
            
            val_10 = this.transform;
            UnityEngine.Bounds val_4 = this.BoundingBox;
            goto label_3;
            label_1:
            val_10 = this.transform;
            UnityEngine.Vector3 val_7 = this.CalculateAveragePosition(averageWeight: out  float val_6 = -1.428428E-15f);
            label_3:
            val_11 = val_7.x;
            val_12 = val_7.z;
            val_10.position = new UnityEngine.Vector3() {x = val_11, y = val_7.y, z = val_12};
            label_2:
            if(this.m_RotationMode != 1)
            {
                    return;
            }
            
            UnityEngine.Quaternion val_9 = this.CalculateAverageOrientation();
            val_11 = val_9.x;
            val_12 = val_9.z;
            this.transform.rotation = new UnityEngine.Quaternion() {x = val_11, y = val_9.y, z = val_12, w = val_9.w};
        }
    
    }

}
