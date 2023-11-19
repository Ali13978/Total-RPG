using UnityEngine;

namespace TzarGames.Endless
{
    public class ThirdPersonCamera : MonoBehaviour
    {
        // Fields
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private UnityEngine.Vector3 offset;
        [UnityEngine.SerializeField]
        private float cameraPitch;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private float <CameraYaw>k__BackingField;
        [UnityEngine.SerializeField]
        private float cameraOffset;
        private float initialCameraOffset;
        private UnityEngine.Coroutine cameraOffsetCoroutine;
        private UnityEngine.Coroutine yawChangeCoroutine;
        private UnityEngine.Coroutine pitchChangeCoroutine;
        [UnityEngine.SerializeField]
        private float lerpSpeed;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private float checkRadius;
        [UnityEngine.SerializeField]
        private UnityEngine.LayerMask traceLayers;
        private bool shaking;
        private float shakeStartTime;
        private float shakeDuration;
        private float shakeSpeed;
        private float shakeMagnitude;
        private float shakeRandomStart;
        private UnityEngine.Transform target;
        private UnityEngine.Quaternion updatedRotation;
        private bool pendingForceUpdate;
        private UnityEngine.Collider[] tempColliders;
        private UnityEngine.Transform cachedTransform;
        private UnityEngine.Camera cachedCamera;
        
        // Properties
        public float CameraYaw { get; set; }
        public UnityEngine.Transform Target { get; set; }
        public UnityEngine.Camera Camera { get; }
        
        // Methods
        public ThirdPersonCamera()
        {
            this.cameraPitch = 60f;
            this.cameraOffset = 5f;
            this.lerpSpeed = 3f;
            this.checkRadius = 2f;
            this.shakeDuration = 0.5f;
            this.shakeSpeed = 4f;
            this.shakeMagnitude = 7.346868E-41f;
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
            this.updatedRotation = val_1;
            mem[1152921510862106980] = val_1.y;
            mem[1152921510862106984] = val_1.z;
            mem[1152921510862106988] = val_1.w;
            this.pendingForceUpdate = true;
            this.tempColliders = null;
        }
        public float get_CameraYaw()
        {
            return (float)this.<CameraYaw>k__BackingField;
        }
        public void set_CameraYaw(float value)
        {
            this.<CameraYaw>k__BackingField = value;
        }
        public UnityEngine.Transform get_Target()
        {
            return (UnityEngine.Transform)this.target;
        }
        public void set_Target(UnityEngine.Transform value)
        {
            this.target = value;
            this.updateCamera();
        }
        public UnityEngine.Camera get_Camera()
        {
            return (UnityEngine.Camera)this.cachedCamera;
        }
        private void Awake()
        {
            this.cachedTransform = this.transform;
            this.cachedCamera = this.GetComponent<UnityEngine.Camera>();
            this.initialCameraOffset = this.cameraOffset;
        }
        private void OnDestroy()
        {
            this.tempColliders = 0;
        }
        private void LateUpdate()
        {
            this.updateCamera();
        }
        public void ForceUpdatePosition()
        {
            this.pendingForceUpdate = true;
        }
        private void updateCamera()
        {
            float val_44;
            float val_48;
            float val_49;
            float val_50;
            float val_51;
            float val_52;
            float val_53;
            float val_54;
            float val_55;
            float val_59;
            float val_60;
            var val_61;
            float val_62;
            UnityEngine.Transform val_66;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.AngleAxis(angle:  this.<CameraYaw>k__BackingField, axis:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.right;
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.AngleAxis(angle:  this.cameraPitch, axis:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, rhs:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w});
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_7 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w}, point:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            UnityEngine.Vector3 val_8 = this.target.position;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = this.offset, y = val_6.x, z = val_6.y});
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(d:  this.cameraOffset, a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            val_44 = val_11.z;
            UnityEngine.Vector3 val_12 = this.target.position;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = this.offset, y = val_10.y, z = val_10.z});
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            val_48 = val_14.x;
            if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, direction:  new UnityEngine.Vector3() {x = val_48, y = val_14.y, z = val_14.z}, maxDistance:  this.cameraOffset, layerMask:  0, queryTriggerInteraction:  UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask()))) != false)
            {
                    val_49 = val_5.y;
                val_50 = val_5.z;
                UnityEngine.Vector3 val_17 = UnityEngine.Vector3.up;
                val_51 = val_17.y;
                UnityEngine.Quaternion val_18 = UnityEngine.Quaternion.AngleAxis(angle:  this.<CameraYaw>k__BackingField, axis:  new UnityEngine.Vector3() {x = val_17.x, y = val_51, z = val_17.z});
                val_48 = val_18.y;
                this.updatedRotation = val_18;
                mem[1152921510863359076] = val_48;
                mem[1152921510863359080] = val_18.z;
                mem[1152921510863359084] = val_18.w;
                UnityEngine.Vector3 val_19 = UnityEngine.Vector3.down;
                UnityEngine.Quaternion val_20 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
                val_52 = val_18.x;
                val_53 = val_48;
                val_54 = val_18.z;
                val_55 = val_18.w;
                UnityEngine.Quaternion val_21 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_52, y = val_53, z = val_54, w = val_55}, rhs:  new UnityEngine.Quaternion() {x = val_20.x, y = val_20.y, z = val_20.z, w = val_20.w});
                this.updatedRotation = val_21;
                mem[1152921510863359076] = val_21.y;
                mem[1152921510863359080] = val_21.z;
                mem[1152921510863359084] = val_21.w;
                val_60 = val_5.w;
                val_59 = val_5.x;
                val_61 = 1;
            }
            else
            {
                    int val_22 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask());
                val_51 = val_11.x;
                val_53 = val_11.y;
                val_52 = val_51;
                val_54 = val_44;
                val_55 = this.checkRadius;
                int val_23 = UnityEngine.Physics.OverlapSphereNonAlloc(position:  new UnityEngine.Vector3() {x = val_52, y = val_53, z = val_54}, radius:  val_55, results:  0, layerMask:  this.tempColliders);
                val_49 = val_5.y;
                val_50 = val_5.z;
                val_60 = val_5.w;
                val_59 = val_5.x;
                if(val_23 >= 1)
            {
                    int val_24 = UnityEngine.Mathf.Min(a:  0, b:  val_23);
                val_62 = 3.402823E+38f;
                if(val_24 >= 1)
            {
                    var val_44 = 0;
                do
            {
                UnityEngine.Vector3 val_25 = this.tempColliders[val_44].ClosestPointOnBounds(position:  new UnityEngine.Vector3() {x = val_51, y = val_11.y, z = val_44});
                float val_45 = val_44;
                float val_26 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_51, y = val_11.y, z = val_45}, b:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
                val_44 = val_44 + 1;
            }
            while(val_24 != val_44);
            
            }
            
                val_45 = ((val_26 <= val_62) ? (val_26) : (val_62)) / this.checkRadius;
                UnityEngine.Vector3 val_29 = UnityEngine.Vector3.up;
                UnityEngine.Quaternion val_30 = UnityEngine.Quaternion.AngleAxis(angle:  this.<CameraYaw>k__BackingField, axis:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
                val_48 = val_30.x;
                val_51 = val_30.w;
                this.updatedRotation = val_30;
                mem[1152921510863359076] = val_30.y;
                mem[1152921510863359080] = val_30.z;
                mem[1152921510863359084] = val_51;
                UnityEngine.Vector3 val_31 = UnityEngine.Vector3.right;
                UnityEngine.Quaternion val_32 = UnityEngine.Quaternion.AngleAxis(angle:  UnityEngine.Mathf.Lerp(a:  90f, b:  this.cameraPitch, t:  val_45), axis:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
                val_52 = val_48;
                val_53 = val_30.y;
                val_54 = val_30.z;
                val_55 = val_51;
                UnityEngine.Quaternion val_33 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_52, y = val_53, z = val_54, w = val_55}, rhs:  new UnityEngine.Quaternion() {x = val_32.x, y = val_32.y, z = val_32.z, w = val_32.w});
                this.updatedRotation = val_33;
                mem[1152921510863359076] = val_33.y;
                mem[1152921510863359080] = val_33.z;
                mem[1152921510863359084] = val_33.w;
                val_60 = val_5.w;
                val_59 = val_5.x;
                val_50 = val_5.z;
                val_61 = 1;
            }
            else
            {
                    val_61 = 0;
            }
            
            }
            
            if(this.pendingForceUpdate == false)
            {
                goto label_30;
            }
            
            this.pendingForceUpdate = false;
            val_66 = this;
            if(val_61 == 0)
            {
                goto label_31;
            }
            
            val_52 = this.updatedRotation;
            val_53 = val_48;
            val_54 = val_59;
            val_55 = val_44;
            this.cachedTransform.rotation = new UnityEngine.Quaternion() {x = val_52, y = val_53, z = val_54, w = val_55};
            goto label_39;
            label_30:
            val_66 = this.cachedTransform;
            if((val_61 & 1) != 0)
            {
                goto label_39;
            }
            
            UnityEngine.Quaternion val_34 = mem[this.cachedTransform].rotation;
            val_51 = val_34.w;
            val_52 = val_59;
            val_53 = val_49;
            val_54 = val_50;
            val_55 = val_60;
            if((UnityEngine.Quaternion.op_Inequality(lhs:  new UnityEngine.Quaternion() {x = val_52, y = val_53, z = val_54, w = val_55}, rhs:  new UnityEngine.Quaternion() {x = val_34.x, y = val_34.y, z = val_34.z, w = val_51})) == false)
            {
                goto label_49;
            }
            
            this.updatedRotation = val_5;
            mem[1152921510863359076] = val_49;
            mem[1152921510863359080] = val_50;
            mem[1152921510863359084] = val_60;
            goto label_39;
            label_31:
            val_52 = val_59;
            val_53 = val_49;
            val_54 = val_50;
            val_55 = val_60;
            this.cachedTransform.rotation = new UnityEngine.Quaternion() {x = val_52, y = val_53, z = val_54, w = val_55};
            label_39:
            float val_36 = UnityEngine.Time.deltaTime;
            val_36 = val_36 * this.lerpSpeed;
            UnityEngine.Quaternion val_37 = this.cachedTransform.rotation;
            UnityEngine.Quaternion val_38 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_37.x, y = val_37.y, z = val_37.z, w = val_37.w}, b:  new UnityEngine.Quaternion() {x = this.updatedRotation, y = val_51, z = val_60, w = val_44}, t:  val_36);
            UnityEngine.Vector3 val_39 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_40 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_38.x, y = val_38.y, z = val_38.z, w = val_38.w}, point:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z});
            UnityEngine.Vector3 val_41 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z}, d:  this.cameraOffset);
            UnityEngine.Vector3 val_42 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_41.x, y = val_41.y, z = val_41.z});
            label_49:
            this.cachedTransform.rotation = new UnityEngine.Quaternion() {x = val_38.x, y = val_38.y, z = val_38.z, w = val_38.w};
            this.cachedTransform.position = new UnityEngine.Vector3() {x = val_42.x, y = val_42.y, z = val_42.z};
            if(this.shaking == false)
            {
                    return;
            }
            
            this.updateShake();
        }
        private void OnDrawGizmos()
        {
            UnityEngine.Vector3 val_1 = this.target.position;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = this.offset, y = V11.16B, z = V10.16B});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_4 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = this.updatedRotation, y = this.offset, z = val_1.z, w = V14.16B}, point:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  this.cameraOffset);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, to:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        }
        public void ShakeQuick()
        {
            this.shaking = true;
            this.shakeStartTime = UnityEngine.Time.time;
            float val_4 = UnityEngine.Mathf.Sign(f:  (float)UnityEngine.Random.Range(min:  0, max:  0));
            val_4 = (UnityEngine.Random.Range(min:  750f, max:  1000f)) * val_4;
            this.shakeDuration = 0.5f;
            this.shakeSpeed = 0f;
            this.shakeRandomStart = val_4;
            this.shakeMagnitude = 0.1f;
        }
        public void Shake(float duration, float speed, float magnitude)
        {
            this.shaking = true;
            this.shakeStartTime = UnityEngine.Time.time;
            float val_4 = UnityEngine.Mathf.Sign(f:  (float)UnityEngine.Random.Range(min:  0, max:  0));
            val_4 = (UnityEngine.Random.Range(min:  750f, max:  1000f)) * val_4;
            this.shakeDuration = duration;
            this.shakeSpeed = speed;
            this.shakeMagnitude = magnitude;
            this.shakeRandomStart = val_4;
        }
        private void updateShake()
        {
            UnityEngine.Transform val_18;
            float val_19;
            val_18 = this;
            val_19 = UnityEngine.Time.time - this.shakeStartTime;
            if(val_19 < 0)
            {
                    UnityEngine.Vector3 val_2 = this.cachedTransform.position;
                float val_17 = this.shakeDuration;
                float val_3 = val_19 / val_17;
                val_17 = val_3 + val_3;
                val_17 = val_17 + (-1f);
                float val_7 = this.shakeRandomStart + (val_3 * this.shakeSpeed);
                float val_9 = UnityEngine.Mathf.PerlinNoise(x:  0f, y:  val_7);
                float val_18 = this.shakeMagnitude;
                float val_10 = (UnityEngine.Mathf.PerlinNoise(x:  val_7, y:  0f)) + (UnityEngine.Mathf.PerlinNoise(x:  val_7, y:  0f));
                val_9 = val_9 + val_9;
                val_10 = val_10 + (-1f);
                val_18 = (1f - (UnityEngine.Mathf.Clamp(value:  val_17, min:  0f, max:  1f))) * val_18;
                float val_12 = val_10 * val_18;
                float val_13 = (val_9 + (-1f)) * val_18;
                UnityEngine.Quaternion val_14 = this.cachedTransform.rotation;
                UnityEngine.Vector3 val_15 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_14.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_18 = this.cachedTransform;
                UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
                val_19 = val_16.x;
                val_18.position = new UnityEngine.Vector3() {x = val_19, y = val_16.y, z = val_16.z};
                return;
            }
            
            this.shaking = false;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator offsetChangeRoutine(float targetOffset, float time)
        {
            if(null != 0)
            {
                    typeof(ThirdPersonCamera.<offsetChangeRoutine>c__Iterator0).__il2cppRuntimeField_10 = time;
                typeof(ThirdPersonCamera.<offsetChangeRoutine>c__Iterator0).__il2cppRuntimeField_20 = targetOffset;
            }
            else
            {
                    mem[16] = time;
                mem[32] = targetOffset;
            }
            
            typeof(ThirdPersonCamera.<offsetChangeRoutine>c__Iterator0).__il2cppRuntimeField_28 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        [TzarGames.Common.ConsoleCommand]
        public void SetOffset(float targetOffset, float time)
        {
            if(this.cameraOffsetCoroutine != null)
            {
                    this.StopCoroutine(routine:  this.cameraOffsetCoroutine);
                this.cameraOffsetCoroutine = 0;
            }
            
            if(System.Math.Abs(time) < 0)
            {
                    this.cameraOffset = targetOffset;
                return;
            }
            
            this.cameraOffsetCoroutine = this.StartCoroutine(routine:  this.offsetChangeRoutine(targetOffset:  targetOffset, time:  time));
        }
        [TzarGames.Common.ConsoleCommand]
        public void ResetOffset(float time)
        {
            this.SetOffset(targetOffset:  this.initialCameraOffset, time:  time);
        }
        public void ChangeCameraYaw(float yaw, float time)
        {
            if(this.yawChangeCoroutine != null)
            {
                    this.StopCoroutine(routine:  this.yawChangeCoroutine);
                this.yawChangeCoroutine = 0;
            }
            
            if(time > 0f)
            {
                    this.yawChangeCoroutine = this.StartCoroutine(routine:  this.smoothYawChangeRoutine(yaw:  yaw, time:  time));
                return;
            }
            
            this.<CameraYaw>k__BackingField = yaw;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator smoothYawChangeRoutine(float yaw, float time)
        {
            if(null != 0)
            {
                    typeof(ThirdPersonCamera.<smoothYawChangeRoutine>c__Iterator1).__il2cppRuntimeField_18 = yaw;
                typeof(ThirdPersonCamera.<smoothYawChangeRoutine>c__Iterator1).__il2cppRuntimeField_1C = time;
            }
            else
            {
                    mem[24] = yaw;
                typeof(ThirdPersonCamera.<smoothYawChangeRoutine>c__Iterator1).__il2cppRuntimeField_1C = time;
            }
            
            typeof(ThirdPersonCamera.<smoothYawChangeRoutine>c__Iterator1).__il2cppRuntimeField_28 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public void ChangeCameraPitch(float pitch, float time)
        {
            if(this.pitchChangeCoroutine != null)
            {
                    this.StopCoroutine(routine:  this.pitchChangeCoroutine);
                this.pitchChangeCoroutine = 0;
            }
            
            if(time > 0f)
            {
                    this.pitchChangeCoroutine = this.StartCoroutine(routine:  this.smoothPitchChangeRoutine(pitch:  pitch, time:  time));
                return;
            }
            
            this.cameraPitch = pitch;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator smoothPitchChangeRoutine(float pitch, float time)
        {
            if(null != 0)
            {
                    typeof(ThirdPersonCamera.<smoothPitchChangeRoutine>c__Iterator2).__il2cppRuntimeField_18 = pitch;
                typeof(ThirdPersonCamera.<smoothPitchChangeRoutine>c__Iterator2).__il2cppRuntimeField_1C = time;
            }
            else
            {
                    mem[24] = pitch;
                typeof(ThirdPersonCamera.<smoothPitchChangeRoutine>c__Iterator2).__il2cppRuntimeField_1C = time;
            }
            
            typeof(ThirdPersonCamera.<smoothPitchChangeRoutine>c__Iterator2).__il2cppRuntimeField_28 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
