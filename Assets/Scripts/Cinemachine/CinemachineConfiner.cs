using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [UnityEngine.ExecuteInEditMode]
    [UnityEngine.AddComponentMenu]
    [Cinemachine.SaveDuringPlayAttribute]
    public class CinemachineConfiner : CinemachineExtension
    {
        // Fields
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineConfiner.Mode m_ConfineMode;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.Collider m_BoundingVolume;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.Collider2D m_BoundingShape2D;
        [UnityEngine.TooltipAttribute]
        public bool m_ConfineScreenEdges;
        [UnityEngine.TooltipAttribute]
        [UnityEngine.RangeAttribute]
        public float m_Damping;
        private System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>> m_pathCache;
        
        // Properties
        public bool IsValid { get; }
        
        // Methods
        public CinemachineConfiner()
        {
            this.m_ConfineScreenEdges = true;
            val_1 = new UnityEngine.MonoBehaviour();
        }
        public bool CameraWasDisplaced(Cinemachine.CinemachineVirtualCameraBase vcam)
        {
            CinemachineConfiner.VcamExtraState val_1 = this.GetExtraState<CinemachineConfiner.VcamExtraState>(vcam:  vcam);
            return (bool)(val_1.confinerDisplacement > 0f) ? 1 : 0;
        }
        private void OnValidate()
        {
            this.m_Damping = UnityEngine.Mathf.Max(a:  0f, b:  this.m_Damping);
        }
        public bool get_IsValid()
        {
            Mode val_3;
            var val_4;
            val_3 = this.m_ConfineMode;
            if(val_3 == 1)
            {
                    if(0 != this.m_BoundingVolume)
            {
                    val_4 = 1;
                return (bool)val_4;
            }
            
                val_3 = this.m_ConfineMode;
            }
            
            if(val_3 == 0)
            {
                    return UnityEngine.Object.op_Inequality(x:  0, y:  this.m_BoundingShape2D);
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        protected override void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, ref Cinemachine.CameraState state, float deltaTime)
        {
            float val_10;
            var val_11;
            float val_15;
            float val_16;
            float val_17;
            val_10 = deltaTime;
            val_11 = 1152921511668456944;
            if(stage != 0)
            {
                    return;
            }
            
            if(this.IsValid == false)
            {
                    return;
            }
            
            if(this.m_ConfineScreenEdges == false)
            {
                goto label_4;
            }
            
            if(((state.<Lens>k__BackingField.FieldOfView.Size) & 1) == 0)
            {
                goto label_4;
            }
            
            UnityEngine.Vector3 val_3 = this.ConfineScreenEdges(vcam:  0, state: ref  new Cinemachine.CameraState() {<Lens>k__BackingField = new Cinemachine.LensSettings() {FieldOfView = state.<Lens>k__BackingField.FieldOfView, OrthographicSize = state.<Lens>k__BackingField.OrthographicSize, NearClipPlane = state.<Lens>k__BackingField.NearClipPlane, FarClipPlane = state.<Lens>k__BackingField.FarClipPlane, Dutch = state.<Lens>k__BackingField.Dutch, <Orthographic>k__BackingField = state.<Lens>k__BackingField.<Orthographic>k__BackingField, <Aspect>k__BackingField = state.<Lens>k__BackingField.<Aspect>k__BackingField}, <ReferenceUp>k__BackingField = new UnityEngine.Vector3() {x = state.<ReferenceUp>k__BackingField.x, y = state.<ReferenceUp>k__BackingField.y, z = state.<ReferenceUp>k__BackingField.z}, <ReferenceLookAt>k__BackingField = new UnityEngine.Vector3() {x = state.<ReferenceLookAt>k__BackingField.x, y = state.<ReferenceLookAt>k__BackingField.y, z = state.<ReferenceLookAt>k__BackingField.z}, <RawPosition>k__BackingField = new UnityEngine.Vector3() {x = state.<RawPosition>k__BackingField.x, y = state.<RawPosition>k__BackingField.y, z = state.<RawPosition>k__BackingField.z}});
            goto label_5;
            label_4:
            UnityEngine.Vector3 val_4 = this.ConfinePoint(camPos:  new UnityEngine.Vector3() {x = deltaTime});
            label_5:
            val_15 = val_4.x;
            val_16 = val_4.y;
            val_17 = val_4.z;
            CinemachineConfiner.VcamExtraState val_5 = this.GetExtraState<CinemachineConfiner.VcamExtraState>(vcam:  vcam);
            if((val_10 >= 0f) && (this.m_Damping > 0f))
            {
                    UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_15, y = val_16, z = val_17}, b:  new UnityEngine.Vector3() {x = val_5.m_previousDisplacement, y = V13.16B, z = V12.16B});
                UnityEngine.Vector3 val_7 = Cinemachine.Utility.Damper.Damp(initial:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, dampTime:  this.m_Damping, deltaTime:  val_10);
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.m_previousDisplacement, y = val_7.y, z = V12.16B}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
                val_15 = val_8.x;
                val_16 = val_8.y;
                val_17 = val_8.z;
            }
            
            val_5.m_previousDisplacement = val_4;
            mem2[0] = val_16;
            mem2[0] = val_17;
            val_10 = val_17;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = state.<PositionCorrection>k__BackingField.x, y = state.<PositionCorrection>k__BackingField.y, z = state.<PositionCorrection>k__BackingField.z}, b:  new UnityEngine.Vector3() {x = val_15, y = val_16, z = val_10});
            state.<PositionCorrection>k__BackingField.x = val_9.x;
            state.<PositionCorrection>k__BackingField.y = val_9.y;
            state.<PositionCorrection>k__BackingField.z = val_9.z;
            val_5.confinerDisplacement = val_9.x;
        }
        public void InvalidatePathCache()
        {
            this.m_pathCache = 0;
        }
        private bool ValidatePathCache()
        {
            var val_21;
            UnityEngine.Vector2[] val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            int val_27;
            var val_28;
            val_21 = 0;
            if(0 != this.m_BoundingShape2D)
            {
                    val_21 = this.m_BoundingShape2D.GetType();
            }
            
            if(val_21 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_7;
            }
            
            val_22 = null;
            if(val_21 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_10;
            }
            
            val_23 = 0;
            this.m_pathCache = 0;
            return (bool)val_23;
            label_7:
            if(this.m_BoundingShape2D == null)
            {
                goto label_12;
            }
            
            var val_6 = (null == null) ? this.m_BoundingShape2D : 0;
            goto label_13;
            label_10:
            if(this.m_BoundingShape2D == null)
            {
                goto label_14;
            }
            
            var val_7 = (null == null) ? this.m_BoundingShape2D : 0;
            goto label_15;
            label_12:
            val_24 = 0;
            label_13:
            if(this.m_pathCache == null)
            {
                goto label_16;
            }
            
            val_22 = this.m_pathCache.Count;
            if(val_22 == val_24.pathCount)
            {
                goto label_37;
            }
            
            label_16:
            System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>> val_10 = new System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>>();
            this.m_pathCache = val_10;
            val_22 = 0;
            goto label_19;
            label_30:
            X23.Add(item:  val_10);
            val_22 = 1;
            label_19:
            if(val_22 >= val_24.pathCount)
            {
                goto label_37;
            }
            
            System.Collections.Generic.List<UnityEngine.Vector2> val_13 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            val_26 = 0;
            goto label_23;
            label_28:
            Add(item:  new UnityEngine.Vector2() {});
            val_26 = 1;
            label_23:
            val_27 = val_12.Length;
            if(val_26 >= val_27)
            {
                goto label_25;
            }
            
            if(null == 0)
            {
                    val_27 = val_12.Length;
            }
            
            if(val_26 < val_27)
            {
                goto label_28;
            }
            
            goto label_28;
            label_25:
            if(this.m_pathCache != null)
            {
                goto label_30;
            }
            
            goto label_30;
            label_14:
            val_25 = 0;
            label_15:
            if(this.m_pathCache == null)
            {
                goto label_31;
            }
            
            val_22 = this.m_pathCache.Count;
            if(val_22 == val_25.pathCount)
            {
                goto label_37;
            }
            
            label_31:
            this.m_pathCache = new System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector2>>();
            int val_17 = val_25.pointCount;
            val_22 = null;
            val_28 = 0;
            goto label_35;
            label_45:
            X24.Add(item:  X23);
            val_28 = 1;
            label_35:
            if(val_28 >= val_25.pathCount)
            {
                goto label_37;
            }
            
            int val_19 = val_25.GetPath(index:  1, points:  val_22);
            System.Collections.Generic.List<UnityEngine.Vector2> val_20 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            if(val_19 >= 1)
            {
                    var val_23 = 0;
                do
            {
                Add(item:  new UnityEngine.Vector2() {x = UnityEngine.Vector2[].__il2cppRuntimeField_byval_arg, y = typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_24});
                val_23 = val_23 + 1;
            }
            while(val_19 != val_23);
            
            }
            
            if(this.m_pathCache != null)
            {
                goto label_45;
            }
            
            goto label_45;
            label_37:
            val_23 = 1;
            return (bool)val_23;
        }
        private UnityEngine.Vector3 ConfinePoint(UnityEngine.Vector3 camPos)
        {
            float val_34;
            UnityEngine.Collider val_35;
            float val_36;
            var val_40;
            val_34 = camPos.x;
            val_35 = this;
            if(this.m_ConfineMode == 1)
            {
                    val_35 = this.m_BoundingVolume;
                UnityEngine.Vector3 val_1 = val_35.ClosestPoint(position:  new UnityEngine.Vector3() {x = val_34, y = camPos.y, z = camPos.z});
                val_36 = val_1.y;
                UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_36, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_34, y = camPos.y, z = camPos.z});
                return new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z};
            }
            
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_34, y = camPos.y, z = camPos.z});
            val_36 = val_3.y;
            if(((this.m_BoundingShape2D.OverlapPoint(point:  new UnityEngine.Vector2() {x = val_3.x, y = val_36})) == true) || (this.ValidatePathCache() == false))
            {
                goto label_10;
            }
            
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_34, y = camPos.y, z = camPos.z});
            val_40 = 0;
            val_34 = val_7.y;
            goto label_13;
            label_33:
            val_40 = 1;
            label_13:
            int val_8 = this.m_pathCache.Count;
            if(val_40 >= val_8)
            {
                goto label_15;
            }
            
            int val_10 = this.m_pathCache.Item[1].Count;
            if(val_40 < val_8)
            {
                goto label_33;
            }
            
            UnityEngine.Vector2 val_14 = this.m_pathCache.Item[1].Item[val_10 - 1];
            UnityEngine.Vector3 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
            UnityEngine.Vector3 val_16 = this.m_BoundingShape2D.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
            if(val_10 < 1)
            {
                goto label_33;
            }
            
            var val_34 = 0;
            do
            {
                UnityEngine.Vector2 val_20 = this.m_pathCache.Item[1].Item[0];
                UnityEngine.Vector3 val_21 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y});
                UnityEngine.Vector3 val_22 = this.m_BoundingShape2D.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
                UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
                UnityEngine.Vector2 val_25 = UnityEngine.Vector2.Lerp(a:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y}, b:  new UnityEngine.Vector2() {x = val_23.x, y = val_23.y}, t:  Cinemachine.Utility.UnityVectorExtensions.ClosestPointOnSegment(p:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, s0:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y}, s1:  new UnityEngine.Vector2() {x = val_23.x, y = val_23.y}));
                UnityEngine.Vector2 val_26 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, b:  new UnityEngine.Vector2() {x = val_25.x, y = val_25.y});
                float val_27 = UnityEngine.Vector2.SqrMagnitude(a:  new UnityEngine.Vector2() {x = val_26.x, y = val_26.y});
                val_34 = val_34 + 1;
                var val_28 = (val_27 < 0) ? (val_27) : 3.402823E+38f;
                var val_29 = (val_27 < 0) ? val_25.x : val_7.x;
                var val_30 = (val_27 < 0) ? val_25.y : (val_34);
            }
            while(val_10 != val_34);
            
            goto label_33;
            label_10:
            UnityEngine.Vector3 val_31 = UnityEngine.Vector3.zero;
            return new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z};
            label_15:
            UnityEngine.Vector2 val_32 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_7.x, y = val_34}, b:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
            UnityEngine.Vector3 val_33 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_32.x, y = val_32.y});
            return new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z};
        }
        private UnityEngine.Vector3 ConfineScreenEdges(Cinemachine.CinemachineVirtualCameraBase vcam, ref Cinemachine.CameraState state)
        {
            float val_30;
            float val_31;
            float val_32;
            float val_33;
            float val_37;
            float val_38;
            float val_39;
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = V0.16B, y = V1.16B, z = V2.16B, w = V3.16B});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_5 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w}, point:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  (state.<Lens>k__BackingField.OrthographicSize) * (state.<Lens>k__BackingField.FieldOfView.GetDuration()));
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_8 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w}, point:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  state.<Lens>k__BackingField.OrthographicSize);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            val_30 = val_10.y;
            val_31 = val_10.z;
            val_32 = val_10.y;
            var val_30 = 0;
            do
            {
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_32, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
                val_33 = val_6.x;
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_33, y = val_6.y, z = val_6.z});
                UnityEngine.Vector3 val_13 = this.ConfinePoint(camPos:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
                val_37 = val_13.x;
                val_38 = val_13.y;
                val_39 = val_13.z;
                if((Cinemachine.Utility.UnityVectorExtensions.AlmostZero(v:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z})) != false)
            {
                    UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_32, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
                val_33 = val_6.x;
                UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_33, y = val_6.y, z = val_6.z});
                UnityEngine.Vector3 val_17 = this.ConfinePoint(camPos:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
                val_37 = val_17.x;
                val_38 = val_17.y;
                val_39 = val_17.z;
            }
            
                if((Cinemachine.Utility.UnityVectorExtensions.AlmostZero(v:  new UnityEngine.Vector3() {x = val_37, y = val_38, z = val_39})) != false)
            {
                    UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_32, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
                val_33 = val_6.x;
                UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, b:  new UnityEngine.Vector3() {x = val_33, y = val_6.y, z = val_6.z});
                UnityEngine.Vector3 val_21 = this.ConfinePoint(camPos:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
                val_37 = val_21.x;
                val_38 = val_21.y;
                val_39 = val_21.z;
            }
            
                if((Cinemachine.Utility.UnityVectorExtensions.AlmostZero(v:  new UnityEngine.Vector3() {x = val_37, y = val_38, z = val_39})) != false)
            {
                    UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_32, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
                UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
                UnityEngine.Vector3 val_25 = this.ConfinePoint(camPos:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
                val_37 = val_25.x;
                val_38 = val_25.y;
                val_39 = val_25.z;
            }
            
                if((Cinemachine.Utility.UnityVectorExtensions.AlmostZero(v:  new UnityEngine.Vector3() {x = val_37, y = val_38, z = val_39})) == true)
            {
                    return new UnityEngine.Vector3() {x = val_28.x, y = val_30, z = val_31};
            }
            
                UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_30, z = val_31}, b:  new UnityEngine.Vector3() {x = val_37, y = val_38, z = val_39});
                val_30 = val_28.y;
                val_31 = val_28.z;
                UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_32, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_37, y = val_38, z = val_39});
                val_32 = val_29.y;
                val_30 = val_30 + 1;
            }
            while(val_30 < 11);
            
            return new UnityEngine.Vector3() {x = val_28.x, y = val_30, z = val_31};
        }
    
    }

}
