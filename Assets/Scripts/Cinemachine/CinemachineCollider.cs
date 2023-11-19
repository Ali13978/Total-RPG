using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [UnityEngine.ExecuteInEditMode]
    [UnityEngine.AddComponentMenu]
    [Cinemachine.SaveDuringPlayAttribute]
    public class CinemachineCollider : CinemachineExtension
    {
        // Fields
        [UnityEngine.HeaderAttribute]
        [UnityEngine.TooltipAttribute]
        public UnityEngine.LayerMask m_CollideAgainst;
        [Cinemachine.TagFieldAttribute]
        [UnityEngine.TooltipAttribute]
        public string m_IgnoreTag;
        [UnityEngine.TooltipAttribute]
        public float m_MinimumDistanceFromTarget;
        [UnityEngine.SpaceAttribute]
        [UnityEngine.TooltipAttribute]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute]
        public bool m_AvoidObstacles;
        [UnityEngine.TooltipAttribute]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute]
        public float m_DistanceLimit;
        [UnityEngine.TooltipAttribute]
        public float m_CameraRadius;
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineCollider.ResolutionStrategy m_Strategy;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        public int m_MaximumEffort;
        [UnityEngine.RangeAttribute]
        [UnityEngine.TooltipAttribute]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute]
        public float m_Damping;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.TooltipAttribute]
        public float m_OptimalTargetDistance;
        private const float PrecisionSlush = 0.001;
        private UnityEngine.RaycastHit[] m_CornerBuffer;
        private const float AngleThreshold = 0.1;
        private UnityEngine.Collider[] mColliderBuffer;
        private UnityEngine.SphereCollider mCameraCollider;
        private UnityEngine.GameObject mCameraColliderGameObject;
        
        // Properties
        public System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>> DebugPaths { get; }
        
        // Methods
        public CinemachineCollider()
        {
            var val_3;
            UnityEngine.LayerMask val_1 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
            this.m_CollideAgainst = val_1;
            val_3 = null;
            val_3 = null;
            this.m_IgnoreTag = System.String.Empty;
            this.m_MinimumDistanceFromTarget = 0.1f;
            this.m_AvoidObstacles = true;
            this.m_CameraRadius = 0.1f;
            this.m_Strategy = 5;
            this.m_CornerBuffer = null;
            this.mColliderBuffer = null;
            this = new UnityEngine.MonoBehaviour();
        }
        public bool IsTargetObscured(Cinemachine.ICinemachineCamera vcam)
        {
            if((this.GetExtraState<VcamExtraState>(vcam:  vcam)) != null)
            {
                    return (bool)val_1.targetObscured;
            }
            
            return (bool)val_1.targetObscured;
        }
        public bool CameraWasDisplaced(Cinemachine.CinemachineVirtualCameraBase vcam)
        {
            VcamExtraState val_1 = this.GetExtraState<VcamExtraState>(vcam:  vcam);
            return (bool)(val_1.colliderDisplacement > 0f) ? 1 : 0;
        }
        private void OnValidate()
        {
            this.m_DistanceLimit = UnityEngine.Mathf.Max(a:  0f, b:  this.m_DistanceLimit);
            this.m_CameraRadius = UnityEngine.Mathf.Max(a:  0f, b:  this.m_CameraRadius);
            this.m_MinimumDistanceFromTarget = UnityEngine.Mathf.Max(a:  0.01f, b:  this.m_MinimumDistanceFromTarget);
            this.m_OptimalTargetDistance = UnityEngine.Mathf.Max(a:  0f, b:  this.m_OptimalTargetDistance);
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            this.CleanupCameraCollider();
        }
        public System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>> get_DebugPaths()
        {
            System.Collections.Generic.List<T> val_5;
            var val_6;
            List.Enumerator<T> val_3 = this.GetAllExtraStates<VcamExtraState>().GetEnumerator();
            label_6:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_4 = 0.InitializationCallback;
            if(val_4 == null)
            {
                goto label_6;
            }
            
            Add(item:  val_4);
            goto label_6;
            label_2:
            val_5 = 0;
            val_6 = 1;
            0.Dispose();
            if((val_6 & 1) != 0)
            {
                    return (System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>>)new System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>>();
            }
            
            if(val_5 == 0)
            {
                    return (System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>>)new System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>>();
            }
            
            return (System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>>)new System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>>();
        }
        protected override void PostPipelineStageCallback(Cinemachine.CinemachineVirtualCameraBase vcam, Cinemachine.CinemachineCore.Stage stage, ref Cinemachine.CameraState state, float deltaTime)
        {
            float val_13;
            VcamExtraState val_14;
            Cinemachine.ICinemachineCamera val_15;
            float val_19;
            float val_20;
            float val_21;
            float val_22;
            float val_23;
            float val_24;
            float val_25;
            float val_26;
            val_13 = deltaTime;
            val_14 = 1152921511664861360;
            val_15 = vcam;
            if(stage == 1)
            {
                goto label_1;
            }
            
            if(stage != 0)
            {
                    return;
            }
            
            VcamExtraState val_2 = this.GetExtraState<VcamExtraState>(vcam:  val_15);
            val_1.targetObscured = false;
            mem2[0] = 0;
            val_15 = val_2;
            mem2[0] = 0;
            if(this.m_AvoidObstacles == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_3 = this.PreserveLignOfSight(state: ref  new Cinemachine.CameraState() {<Lens>k__BackingField = new Cinemachine.LensSettings() {FieldOfView = state.<Lens>k__BackingField.FieldOfView, OrthographicSize = state.<Lens>k__BackingField.OrthographicSize, NearClipPlane = state.<Lens>k__BackingField.NearClipPlane, FarClipPlane = state.<Lens>k__BackingField.FarClipPlane, Dutch = state.<Lens>k__BackingField.Dutch, <Orthographic>k__BackingField = state.<Lens>k__BackingField.<Orthographic>k__BackingField, <Aspect>k__BackingField = state.<Lens>k__BackingField.<Aspect>k__BackingField}, <ReferenceUp>k__BackingField = new UnityEngine.Vector3() {x = state.<ReferenceUp>k__BackingField.x, y = state.<ReferenceUp>k__BackingField.y, z = state.<ReferenceUp>k__BackingField.z}, <ReferenceLookAt>k__BackingField = new UnityEngine.Vector3() {x = state.<ReferenceLookAt>k__BackingField.x, y = state.<ReferenceLookAt>k__BackingField.y, z = state.<ReferenceLookAt>k__BackingField.z}, <RawPosition>k__BackingField = new UnityEngine.Vector3() {x = state.<RawPosition>k__BackingField.x, y = state.<RawPosition>k__BackingField.y, z = state.<RawPosition>k__BackingField.z}}, extra: ref  val_2);
            val_19 = val_3.x;
            val_20 = val_3.y;
            val_21 = val_3.z;
            if((val_13 >= 0f) && (this.m_Damping > 0f))
            {
                    val_15 = val_2;
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_19, y = val_20, z = val_21}, b:  new UnityEngine.Vector3() {x = val_1 + 16, y = val_1 + 16 + 4, z = val_1 + 24});
                UnityEngine.Vector3 val_5 = Cinemachine.Utility.Damper.Damp(initial:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, dampTime:  this.m_Damping, deltaTime:  val_13);
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1 + 16, y = val_1 + 16 + 4, z = val_1 + 24}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
                val_19 = val_6.x;
                val_20 = val_6.y;
                val_21 = val_6.z;
            }
            
            mem2[0] = val_19;
            mem2[0] = val_20;
            mem2[0] = val_21;
            val_22 = state.<PositionCorrection>k__BackingField.y;
            val_23 = state.<PositionCorrection>k__BackingField.z;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = state.<PositionCorrection>k__BackingField.x, y = val_22, z = val_23}, b:  new UnityEngine.Vector3() {x = val_19, y = val_20, z = val_21});
            state.<PositionCorrection>k__BackingField.x = val_7.x;
            state.<PositionCorrection>k__BackingField.y = val_7.y;
            state.<PositionCorrection>k__BackingField.z = val_7.z;
            val_14 = val_2;
            if(val_14 == 0)
            {
                goto label_16;
            }
            
            val_24 = mem[val_1 + 28];
            val_24 = val_1 + 28;
            val_13 = val_7.x;
            goto label_17;
            label_1:
            val_8.targetObscured = this.CheckForTargetObstructions(state:  new Cinemachine.CameraState() {<Lens>k__BackingField = new Cinemachine.LensSettings() {<Orthographic>k__BackingField = false}, <ReferenceUp>k__BackingField = new UnityEngine.Vector3(), <ReferenceLookAt>k__BackingField = new UnityEngine.Vector3(), <RawPosition>k__BackingField = new UnityEngine.Vector3(), <RawOrientation>k__BackingField = new UnityEngine.Quaternion(), <PositionDampingBypass>k__BackingField = new UnityEngine.Vector3(), <PositionCorrection>k__BackingField = new UnityEngine.Vector3(), <OrientationCorrection>k__BackingField = new UnityEngine.Quaternion(), mCustom0 = new CustomBlendable(), mCustom1 = new CustomBlendable(), mCustom2 = new CustomBlendable(), mCustom3 = new CustomBlendable()});
            if((val_8 + 32) != 0)
            {
                    float val_13 = state.<ShotQuality>k__BackingField;
                val_25 = 0.2f;
                val_13 = val_13 * val_25;
                state.<ShotQuality>k__BackingField = val_13;
            }
            
            val_15 = this.GetExtraState<VcamExtraState>(vcam:  val_15);
            if((val_8 + 28) > 0f)
            {
                    float val_14 = state.<ShotQuality>k__BackingField;
                val_25 = 0.8f;
                val_14 = val_14 * val_25;
                state.<ShotQuality>k__BackingField = val_14;
            }
            
            if(this.m_OptimalTargetDistance <= 0f)
            {
                    return;
            }
            
            if((val_14 & 1) == 0)
            {
                    return;
            }
            
            val_13 = state.<ReferenceLookAt>k__BackingField.x;
            val_23 = state.<ReferenceLookAt>k__BackingField.z;
            val_22 = val_25;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_13, y = state.<ReferenceLookAt>k__BackingField.y, z = val_23}, b:  new UnityEngine.Vector3() {x = this.m_OptimalTargetDistance, y = val_22, z = V2.16B});
            float val_12 = UnityEngine.Vector3.Magnitude(vector:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            float val_15 = this.m_OptimalTargetDistance;
            if(val_12 <= val_15)
            {
                goto label_27;
            }
            
            val_12 = val_12 - val_15;
            val_15 = val_15 * 3f;
            if(val_12 >= 0)
            {
                goto label_28;
            }
            
            val_12 = val_12 / val_15;
            val_12 = 1f - val_12;
            val_26 = val_12 * 0.2f;
            goto label_32;
            label_16:
            val_14 = 28;
            val_24 = 0f;
            val_13 = val_7.x;
            label_17:
            val_7.x = val_13 + val_24;
            mem[28] = val_7.x;
            return;
            label_27:
            float val_16 = 0.5f;
            val_16 = val_15 * val_16;
            if(val_12 >= val_16)
            {
                goto label_31;
            }
            
            label_28:
            val_26 = 0f;
            goto label_32;
            label_31:
            val_12 = val_12 - val_16;
            val_15 = val_15 - val_16;
            val_12 = val_12 * 0.2f;
            val_26 = val_12 / val_15;
            label_32:
            val_26 = val_26 + 1f;
            val_26 = (state.<ShotQuality>k__BackingField) * val_26;
            state.<ShotQuality>k__BackingField = val_26;
        }
        private UnityEngine.Vector3 PreserveLignOfSight(ref Cinemachine.CameraState state, ref Cinemachine.CinemachineCollider.VcamExtraState extra)
        {
            float val_21;
            float val_22;
            float val_23;
            float val_24;
            float val_27;
            float val_29;
            float val_31;
            float val_32;
            float val_33;
            float val_35;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_21 = val_1.x;
            val_22 = val_1.y;
            val_23 = val_1.z;
            if((1152921511665043776 & 1) == 0)
            {
                    return new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_23};
            }
            
            val_24 = val_1.y;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_24, z = val_1.z}, b:  new UnityEngine.Vector3() {x = state.<ReferenceLookAt>k__BackingField.x, y = state.<ReferenceLookAt>k__BackingField.y, z = state.<ReferenceLookAt>k__BackingField.z});
            val_27 = 0.0001f;
            float val_3 = UnityEngine.Mathf.Max(a:  this.m_MinimumDistanceFromTarget, b:  val_27);
            if(val_2.x <= val_3)
            {
                goto label_8;
            }
            
            val_29 = val_2.x - val_3;
            if(this.m_DistanceLimit <= val_27)
            {
                goto label_9;
            }
            
            val_29 = UnityEngine.Mathf.Min(a:  this.m_DistanceLimit, b:  val_29);
            goto label_12;
            label_8:
            val_31 = val_1.z;
            val_32 = val_1.x;
            val_33 = val_24;
            goto label_22;
            label_9:
            label_12:
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(d:  val_29, a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            val_31 = val_1.z;
            val_24 = val_24;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_24, z = val_31}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            float val_17 = 0.001f;
            val_17 = val_29 + val_17;
            if(val_17 <= val_27)
            {
                goto label_16;
            }
            
            val_32 = val_1.x;
            val_33 = val_24;
            if((this.RaycastIgnoreTag(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, rayLength:  val_17)) == false)
            {
                goto label_22;
            }
            
            float val_9 = 0.targetValue + (-0.001f);
            val_32 = UnityEngine.Mathf.Max(a:  0f, b:  val_9);
            val_33 = val_9;
            val_31 = val_6.z;
            if(this.m_Strategy == 0)
            {
                goto label_22;
            }
            
            UnityEngine.Vector3 val_12 = this.PushCameraBack(currentPos:  new UnityEngine.Vector3() {x = val_32, y = val_33, z = val_31}, pushDir:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, obstacle:  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, lookAtPos:  new UnityEngine.Vector3() {x = state.<ReferenceLookAt>k__BackingField.x, y = state.<ReferenceLookAt>k__BackingField.z, z = 0f}, startPlane:  new UnityEngine.Plane() {m_Normal = new UnityEngine.Vector3() {x = this.m_MaximumEffort, y = this.m_MaximumEffort, z = -7.802571E-17f}, m_Distance = 2.524355E-29f}, targetDistance:  0f, iterations:  0, extra: ref  Cinemachine.CinemachineCollider.VcamExtraState val_11 = null);
            val_32 = val_12.x;
            val_33 = val_12.y;
            val_31 = val_12.z;
            goto label_22;
            label_16:
            val_32 = val_1.x;
            val_33 = val_24;
            label_22:
            if(this.m_CameraRadius > val_27)
            {
                    UnityEngine.Vector3 val_13 = this.RespectCameraRadius(cameraPos:  new UnityEngine.Vector3() {x = val_32, y = val_33, z = val_31}, lookAtPos:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
                val_27 = val_13.x;
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_32, y = val_33, z = val_31}, b:  new UnityEngine.Vector3() {x = val_27, y = val_13.y, z = val_13.z});
                val_35 = val_1.z;
                val_32 = val_14.x;
                val_33 = val_14.y;
                val_31 = val_14.z;
            }
            else
            {
                    val_35 = val_1.z;
                if(0 != this.mCameraColliderGameObject)
            {
                    this.CleanupCameraCollider();
            }
            
            }
            
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_32, y = val_33, z = val_31}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_24, z = val_35});
            val_21 = val_16.x;
            val_22 = val_16.y;
            val_23 = val_16.z;
            return new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_23};
        }
        private bool RaycastIgnoreTag(UnityEngine.Ray ray, out UnityEngine.RaycastHit hitInfo, float rayLength)
        {
            float val_13;
            string val_14;
            var val_15;
            val_13 = rayLength;
            if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3(), m_Direction = new UnityEngine.Vector3()}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = ray.m_Origin.x}, m_Normal = new UnityEngine.Vector3() {y = ray.m_Direction.y}, m_UV = new UnityEngine.Vector2()}, maxDistance:  val_13, layerMask:  -1531489920, queryTriggerInteraction:  this.m_CollideAgainst.value)) == false)
            {
                goto label_10;
            }
            
            label_11:
            val_14 = this.m_IgnoreTag;
            if(val_14.Length == 0)
            {
                goto label_5;
            }
            
            val_14 = this.m_IgnoreTag;
            if((hitInfo.m_Point.x.Payload.CompareTag(tag:  val_14)) == false)
            {
                goto label_5;
            }
            
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_13, y = V1.16B, z = V2.16B});
            val_14 = hitInfo.m_Point.x.Payload;
            if((val_14.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = hitInfo.m_Point.x, y = hitInfo.m_Point.y, z = hitInfo.m_Point.z}, m_Normal = new UnityEngine.Vector3() {x = hitInfo.m_Normal.x, y = hitInfo.m_Normal.y, z = hitInfo.m_Normal.z}, m_FaceID = hitInfo.m_FaceID, m_Distance = hitInfo.m_Distance, m_UV = new UnityEngine.Vector2() {x = hitInfo.m_UV.x, y = hitInfo.m_UV.y}, m_Collider = hitInfo.m_Collider}, maxDistance:  val_13)) == false)
            {
                goto label_10;
            }
            
            val_13 = hitInfo.m_Point.x.targetValue + (-0.001f);
            if(val_13 < 0)
            {
                goto label_10;
            }
            
            float val_12 = ray.m_Direction.y;
            val_12 = UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3(), m_Direction = new UnityEngine.Vector3()}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = ray.m_Origin.x}, m_Normal = new UnityEngine.Vector3() {y = val_12}, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  val_13, layerMask:  -1531489920, queryTriggerInteraction:  this.m_CollideAgainst.value);
            if(val_12 == true)
            {
                goto label_11;
            }
            
            label_10:
            val_15 = 0;
            return (bool)val_15;
            label_5:
            val_15 = 1;
            return (bool)val_15;
        }
        private UnityEngine.Vector3 PushCameraBack(UnityEngine.Vector3 currentPos, UnityEngine.Vector3 pushDir, UnityEngine.RaycastHit obstacle, UnityEngine.Vector3 lookAtPos, UnityEngine.Plane startPlane, float targetDistance, int iterations, ref Cinemachine.CinemachineCollider.VcamExtraState extra)
        {
            float val_3;
            var val_4;
            float val_5;
            float val_10;
            float val_11;
            float val_27;
            float val_28;
            float val_29;
            float val_30;
            float val_34;
            val_27 = pushDir.y;
            val_28 = currentPos.z;
            val_29 = currentPos.y;
            val_30 = currentPos.x;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            if((this.GetWalkingDirection(pos:  new UnityEngine.Vector3() {x = val_30, y = val_29, z = val_28}, pushDir:  new UnityEngine.Vector3() {x = pushDir.x, y = val_27, z = pushDir.z}, obstacle:  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = obstacle.m_Point.x}, m_Normal = new UnityEngine.Vector3() {y = obstacle.m_Normal.y}, m_UV = new UnityEngine.Vector2() {x = obstacle.m_UV.x}}, outDir: ref  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) == false)
            {
                    return new UnityEngine.Vector3() {x = val_30, y = val_29, z = val_28};
            }
            
            val_27 = val_4;
            val_34 = lookAtPos.x;
            float val_7 = this.GetPushBackDistance(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, startPlane:  new UnityEngine.Plane() {m_Normal = new UnityEngine.Vector3() {x = -8.090118E-17f, y = 2.524355E-29f, z = startPlane.m_Normal.z}, m_Distance = startPlane.m_Distance}, targetDistance:  lookAtPos.z, lookAtPos:  new UnityEngine.Vector3() {x = val_3, y = targetDistance, z = val_5});
            if(val_7 <= 0.0001f)
            {
                goto label_4;
            }
            
            val_27 = val_34;
            System.Byte[] val_8 = obstacle.m_Point.x.Payload;
            UnityEngine.Bounds val_9 = val_8.bounds;
            float val_26 = val_11;
            val_34 = val_8.ClampRayToBounds(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, distance:  val_7, bounds:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = val_26, y = val_26, z = val_26}, m_Extents = new UnityEngine.Vector3() {x = val_26, y = val_10, z = val_10}});
            val_30 = val_30;
            val_28 = val_28;
            val_26 = val_34 + 0.001f;
            float val_13 = UnityEngine.Mathf.Min(a:  val_7, b:  val_26);
            val_29 = val_29;
            if((this.RaycastIgnoreTag(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, rayLength:  val_13)) == false)
            {
                goto label_8;
            }
            
            float val_15 = 0.targetValue;
            val_15 = val_15 + (-0.001f);
            val_30 = val_15;
            val_29 = -0.001f;
            val_28 = targetDistance;
            if(startPlane.m_Normal.x < (2.802597E-45f))
            {
                    return new UnityEngine.Vector3() {x = val_30, y = val_29, z = val_28};
            }
            
            float val_16 = startPlane.m_Normal.x - 1;
            label_23:
            val_30 = val_30;
            val_29 = val_29;
            val_28 = val_28;
            return new UnityEngine.Vector3() {x = val_30, y = val_29, z = val_28};
            label_4:
            val_30 = val_30;
            val_28 = val_28;
            val_29 = val_29;
            return new UnityEngine.Vector3() {x = val_30, y = val_29, z = val_28};
            label_8:
            val_34 = val_27;
            val_27 = val_27;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_13, y = 0f, z = targetDistance}, b:  new UnityEngine.Vector3() {x = val_34, y = val_27, z = lookAtPos.y});
            if(val_17.x < 0)
            {
                    return new UnityEngine.Vector3() {x = val_30, y = val_29, z = val_28};
            }
            
            if((this.RaycastIgnoreTag(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, rayLength:  val_17.x + (-0.001f))) == true)
            {
                    return new UnityEngine.Vector3() {x = val_30, y = val_29, z = val_28};
            }
            
            float val_21 = this.GetPushBackDistance(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, startPlane:  new UnityEngine.Plane() {m_Normal = new UnityEngine.Vector3() {x = -8.090038E-17f, y = 2.524355E-29f, z = startPlane.m_Normal.z}, m_Distance = startPlane.m_Distance}, targetDistance:  lookAtPos.z, lookAtPos:  new UnityEngine.Vector3() {x = val_3, y = targetDistance, z = val_5});
            val_30 = val_13;
            val_28 = targetDistance;
            val_29 = 0f;
            if(val_21 <= 0.0001f)
            {
                    return new UnityEngine.Vector3() {x = val_30, y = val_29, z = val_28};
            }
            
            if((this.RaycastIgnoreTag(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, rayLength:  val_21)) == false)
            {
                goto label_20;
            }
            
            float val_24 = 0.targetValue;
            val_24 = val_24 + (-0.001f);
            val_30 = val_24;
            val_29 = -0.001f;
            val_28 = targetDistance;
            if(startPlane.m_Normal.x < (2.802597E-45f))
            {
                    return new UnityEngine.Vector3() {x = val_30, y = val_29, z = val_28};
            }
            
            float val_25 = startPlane.m_Normal.x - 1;
            goto label_23;
            label_20:
            val_30 = val_21;
            val_29 = val_3;
            val_28 = targetDistance;
            if(startPlane.m_Normal.z != 0)
            {
                    return new UnityEngine.Vector3() {x = val_30, y = val_29, z = val_28};
            }
            
            return new UnityEngine.Vector3() {x = val_30, y = val_29, z = val_28};
        }
        private bool GetWalkingDirection(UnityEngine.Vector3 pos, UnityEngine.Vector3 pushDir, UnityEngine.RaycastHit obstacle, ref UnityEngine.Vector3 outDir)
        {
            var val_28;
            var val_29;
            float val_30;
            float val_31;
            float val_32;
            float val_33;
            float val_34;
            float val_37;
            float val_38;
            float val_39;
            float val_40;
            float val_41;
            float val_42;
            float val_44;
            var val_45;
            val_28 = 1152921511666200432;
            val_29 = 1152921511666192160;
            val_30 = pos.x;
            val_31 = pos.y;
            val_32 = pos.x;
            val_33 = pos.y;
            val_34 = pos.z;
            int val_2 = UnityEngine.Physics.SphereCastNonAlloc(origin:  new UnityEngine.Vector3() {x = val_32, y = val_33, z = val_34}, radius:  0.005f, direction:  new UnityEngine.Vector3() {x = pos.x, y = val_31, z = pos.z}, results:  0, maxDistance:  0f, layerMask:  this.m_CornerBuffer, queryTriggerInteraction:  this.m_CollideAgainst.value);
            if(val_2 < 2)
            {
                goto label_1;
            }
            
            var val_27 = 0;
            var val_28 = 32;
            label_32:
            if(this.m_IgnoreTag.Length < 1)
            {
                goto label_3;
            }
            
            if((this.m_CornerBuffer[val_28].Payload.CompareTag(tag:  this.m_IgnoreTag)) == true)
            {
                goto label_25;
            }
            
            label_3:
            System.Type val_8 = this.m_CornerBuffer[val_28].Payload.GetType();
            if(val_8 != (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                    if(val_8 != (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                    if(val_8 != (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_25;
            }
            
            }
            
            }
            
            UnityEngine.Vector3 val_13 = this.m_CornerBuffer[val_28].Payload.ClosestPoint(position:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z});
            val_31 = val_13.z;
            val_32 = val_13.x;
            val_33 = val_13.y;
            val_34 = val_31;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_32, y = val_33, z = val_34}, b:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z});
            if(val_14.x <= (1E-05f))
            {
                goto label_25;
            }
            
            val_33 = pos.y;
            val_34 = pos.z;
            val_32 = 0.005f;
            if((this.m_CornerBuffer[val_28].Payload.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = this.m_CornerBuffer[val_28], y = this.m_CornerBuffer[val_28], z = this.m_CornerBuffer[val_28]}, m_Normal = new UnityEngine.Vector3() {x = this.m_CornerBuffer[val_28], y = this.m_CornerBuffer[val_28], z = this.m_CornerBuffer[val_28]}, m_FaceID = this.m_CornerBuffer[val_28], m_Distance = this.m_CornerBuffer[val_28], m_UV = new UnityEngine.Vector2() {x = this.m_CornerBuffer[val_28], y = this.m_CornerBuffer[val_28]}, m_Collider = this.m_CornerBuffer[val_28]}, maxDistance:  0.005f)) == true)
            {
                goto label_31;
            }
            
            label_25:
            val_27 = val_27 + 1;
            val_28 = val_28 + 48;
            if(val_27 < (long)val_2)
            {
                goto label_32;
            }
            
            val_29 = val_29;
            val_28 = val_28;
            val_30 = val_30;
            label_1:
            label_56:
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = 0.005f, y = val_33, z = val_34}, rhs:  new UnityEngine.Vector3() {x = val_30, y = pos.y, z = pos.z});
            val_37 = val_17.y;
            val_38 = pushDir.x;
            val_39 = pushDir.z;
            if((Cinemachine.Utility.UnityVectorExtensions.AlmostZero(v:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z})) == false)
            {
                goto label_35;
            }
            
            val_37 = val_17.y;
            val_40 = val_38;
            val_41 = pushDir.y;
            val_42 = val_39;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.ProjectOnPlane(vector:  new UnityEngine.Vector3() {x = val_40, y = val_41, z = val_42}, planeNormal:  new UnityEngine.Vector3() {x = val_17.x, y = val_37, z = val_17.z});
            goto label_38;
            label_35:
            float val_20 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_17.x, y = val_37, z = val_17.z}, rhs:  new UnityEngine.Vector3() {x = val_38, y = pushDir.y, z = val_39});
            if(System.Math.Abs(val_20) < 0)
            {
                goto label_43;
            }
            
            val_39 = val_17.x;
            val_44 = val_37;
            val_38 = val_17.z;
            if(val_20 >= 0)
            {
                goto label_44;
            }
            
            val_40 = val_39;
            val_41 = val_44;
            val_42 = val_38;
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_40, y = val_41, z = val_42});
            label_38:
            val_39 = val_21.x;
            val_44 = val_21.y;
            val_38 = val_21.z;
            label_44:
            if((Cinemachine.Utility.UnityVectorExtensions.AlmostZero(v:  new UnityEngine.Vector3() {x = val_39, y = val_44, z = val_38})) == false)
            {
                goto label_47;
            }
            
            label_43:
            val_45 = 0;
            return (bool)val_45;
            label_47:
            val_45 = 1;
            outDir.x = val_39;
            outDir.y = val_44;
            outDir.z = val_38;
            return (bool)val_45;
            label_31:
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 0.005f, y = val_33, z = val_34}, b:  new UnityEngine.Vector3() {x = 0.005f, y = val_33, z = val_34});
            if((Cinemachine.Utility.UnityVectorExtensions.AlmostZero(v:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z})) == true)
            {
                goto label_56;
            }
            
            goto label_56;
        }
        private float GetPushBackDistance(UnityEngine.Ray ray, UnityEngine.Plane startPlane, float targetDistance, UnityEngine.Vector3 lookAtPos)
        {
            float val_6;
            var val_7;
            float val_8;
            float val_10;
            val_6 = V6.16B;
            val_7 = 1152921511666791776;
            val_8 = targetDistance;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_8, y = lookAtPos.x, z = lookAtPos.y}, b:  new UnityEngine.Vector3() {x = V5.16B, y = val_6, z = V7.16B});
            float val_2 = V4.16B - val_1.x;
            val_10 = 0f;
            if(val_2 < 0)
            {
                    return val_10;
            }
            
            if(this.m_Strategy == 2)
            {
                    val_10 = val_2;
                return val_10;
            }
            
            if(((-1530033920) & 1) != 0)
            {
                    val_6 = 0f;
            }
            else
            {
                    val_6 = 0f;
            }
            
            float val_3 = UnityEngine.Mathf.Min(a:  val_2, b:  val_6);
            if(val_3 < 0)
            {
                    return val_10;
            }
            
            val_8 = val_6;
            float val_8 = val_1.z;
            float val_6 = -90f;
            val_6 = 0.1f;
            val_10 = val_3;
            val_6 = (UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_3, y = val_6, z = val_8}, to:  new UnityEngine.Vector3() {x = val_3, y = val_8, z = val_1.z})) + val_6;
            float val_7 = System.Math.Abs(val_6);
            if(val_7 >= 0)
            {
                    return val_10;
            }
            
            val_8 = val_7 / val_6;
            val_10 = UnityEngine.Mathf.Lerp(a:  0f, b:  val_10, t:  val_8);
            return val_10;
        }
        private float ClampRayToBounds(UnityEngine.Ray ray, float distance, UnityEngine.Bounds bounds)
        {
            float val_22;
            var val_23;
            float val_26;
            float val_27;
            float val_28;
            float val_32;
            float val_33;
            float val_34;
            float val_38;
            val_22 = distance;
            val_23 = 1152921511666920256;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
            float val_2 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = distance, y = V1.16B, z = V2.16B}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            if(val_2 <= 0f)
            {
                goto label_3;
            }
            
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.down;
            val_26 = val_3.x;
            val_27 = val_3.y;
            val_28 = val_3.z;
            goto label_6;
            label_3:
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.down;
            val_26 = val_2;
            val_27 = V1.16B;
            val_28 = V2.16B;
            if((UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_26, y = val_27, z = val_28}, rhs:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z})) <= 0f)
            {
                goto label_13;
            }
            
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.up;
            val_26 = val_6.x;
            val_27 = val_6.y;
            val_28 = val_6.z;
            label_6:
            if(((-1529905432) & 1) != 0)
            {
                    val_26 = 0.0001f;
                if(0f > val_26)
            {
                    val_26 = val_22;
                val_27 = 0f;
                float val_7 = UnityEngine.Mathf.Min(a:  val_26, b:  val_27);
                val_22 = val_7;
            }
            
            }
            
            label_13:
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.right;
            float val_9 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_7, y = val_27, z = val_28}, rhs:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            if(val_9 <= 0f)
            {
                goto label_18;
            }
            
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.left;
            val_32 = val_10.x;
            val_33 = val_10.y;
            val_34 = val_10.z;
            goto label_21;
            label_18:
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.left;
            val_32 = val_9;
            val_33 = val_27;
            val_34 = val_28;
            if((UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_32, y = val_33, z = val_34}, rhs:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z})) <= 0f)
            {
                goto label_28;
            }
            
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.right;
            val_32 = val_13.x;
            val_33 = val_13.y;
            val_34 = val_13.z;
            label_21:
            if(((-1529905464) & 1) != 0)
            {
                    val_32 = 0.0001f;
                if(0f > val_32)
            {
                    val_32 = val_22;
                val_33 = 0f;
                float val_14 = UnityEngine.Mathf.Min(a:  val_32, b:  val_33);
                val_22 = val_14;
            }
            
            }
            
            label_28:
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.forward;
            float val_16 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_14, y = val_33, z = val_34}, rhs:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            if(val_16 > 0f)
            {
                    UnityEngine.Vector3 val_17 = UnityEngine.Vector3.back;
                val_38 = val_17.y;
            }
            else
            {
                    val_38 = val_33;
                UnityEngine.Vector3 val_18 = UnityEngine.Vector3.back;
                if((UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_16, y = val_38, z = val_34}, rhs:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z})) <= 0f)
            {
                    return (float)val_22;
            }
            
                UnityEngine.Vector3 val_20 = UnityEngine.Vector3.forward;
                val_38 = val_20.y;
            }
            
            if(((-1529905496) & 1) == 0)
            {
                    return (float)val_22;
            }
            
            if(0f <= 0.0001f)
            {
                    return (float)val_22;
            }
            
            val_22 = UnityEngine.Mathf.Min(a:  val_22, b:  0f);
            return (float)val_22;
        }
        private UnityEngine.Vector3 RespectCameraRadius(UnityEngine.Vector3 cameraPos, UnityEngine.Vector3 lookAtPos)
        {
            float val_23;
            float val_24;
            float val_25;
            float val_26;
            UnityEngine.SphereCollider val_27;
            var val_28;
            string val_29;
            float val_30;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_23 = this.m_CameraRadius;
            val_24 = val_1.z;
            val_25 = cameraPos.y;
            val_26 = cameraPos.z;
            int val_3 = UnityEngine.Physics.OverlapSphereNonAlloc(position:  new UnityEngine.Vector3() {x = cameraPos.x, y = val_25, z = val_26}, radius:  val_23, results:  0, layerMask:  this.mColliderBuffer, queryTriggerInteraction:  UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask()));
            if(val_3 < 1)
            {
                    return new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_24};
            }
            
            if(0 == this.mCameraColliderGameObject)
            {
                    this.mCameraColliderGameObject = new UnityEngine.GameObject(name:  "Cinemachine Collider Collider");
                hideFlags = 61;
                val_25 = 0f;
                val_26 = 0f;
                this.mCameraColliderGameObject.transform.position = new UnityEngine.Vector3() {x = 0f, y = val_25, z = val_26};
                this.mCameraColliderGameObject.SetActive(value:  true);
                val_27 = this.mCameraColliderGameObject.AddComponent<UnityEngine.SphereCollider>();
                val_28 = this;
                this.mCameraCollider = val_27;
            }
            else
            {
                    val_28 = this;
                val_27 = this.mCameraCollider;
            }
            
            val_23 = this.m_CameraRadius;
            val_27.radius = val_23;
            var val_21 = 0;
            label_29:
            UnityEngine.Collider val_20 = this.mColliderBuffer[val_21];
            if(this.m_IgnoreTag.Length < 1)
            {
                goto label_17;
            }
            
            val_29 = this.m_IgnoreTag;
            this.mColliderBuffer[val_21] = val_20.CompareTag(tag:  val_29);
            if(this.mColliderBuffer[val_21] == true)
            {
                goto label_26;
            }
            
            label_17:
            val_29 = this.mCameraCollider;
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.identity;
            val_23 = val_11.z;
            UnityEngine.Vector3 val_13 = val_20.transform.position;
            val_30 = val_13.x;
            UnityEngine.Quaternion val_15 = val_20.transform.rotation;
            val_25 = cameraPos.y;
            if((UnityEngine.Physics.ComputePenetration(colliderA:  0, positionA:  new UnityEngine.Vector3() {x = cameraPos.x, y = val_25, z = cameraPos.z}, rotationA:  new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_23, w = val_11.w}, colliderB:  val_29, positionB:  new UnityEngine.Vector3() {x = val_30, y = val_13.z, z = val_15.x}, rotationB:  new UnityEngine.Quaternion() {x = val_15.z, w = val_1.y}, direction: out  new UnityEngine.Vector3() {x = val_20, y = val_20, z = val_20}, distance: out  float val_16 = -9.160312E-17f)) != false)
            {
                    val_23 = 0f;
                val_30 = 0f;
                UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_23, y = 0f, z = val_30}, d:  0f);
                val_25 = val_1.y;
                UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_25, z = val_24}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
                val_24 = val_19.z;
            }
            
            label_26:
            val_21 = val_21 + 1;
            if(val_3 != val_21)
            {
                goto label_29;
            }
            
            return new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_24};
        }
        private void CleanupCameraCollider()
        {
            if(0 != this.mCameraColliderGameObject)
            {
                    UnityEngine.Object.DestroyImmediate(obj:  0);
            }
            
            this.mCameraCollider = 0;
            this.mCameraColliderGameObject = 0;
        }
        private bool CheckForTargetObstructions(Cinemachine.CameraState state)
        {
            var val_5;
            if((1152921511667552624 & 1) == 0)
            {
                goto label_7;
            }
            
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = state.<ReferenceLookAt>k__BackingField.x, y = state.<ReferenceLookAt>k__BackingField.y, z = state.<ReferenceLookAt>k__BackingField.z}, b:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
            float val_2 = UnityEngine.Mathf.Max(a:  this.m_MinimumDistanceFromTarget, b:  0.0001f);
            if(val_1.x < 0)
            {
                goto label_6;
            }
            
            float val_5 = this.m_MinimumDistanceFromTarget;
            val_5 = val_1.x - val_5;
            if((this.RaycastIgnoreTag(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, rayLength:  val_5)) == false)
            {
                goto label_7;
            }
            
            label_6:
            val_5 = 1;
            return (bool)val_5;
            label_7:
            val_5 = 0;
            return (bool)val_5;
        }
    
    }

}
