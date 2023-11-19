using UnityEngine;

namespace TMPro.Examples
{
    public class CameraController : MonoBehaviour
    {
        // Fields
        private UnityEngine.Transform cameraTransform;
        private UnityEngine.Transform dummyTarget;
        public UnityEngine.Transform CameraTarget;
        public float FollowDistance;
        public float MaxFollowDistance;
        public float MinFollowDistance;
        public float ElevationAngle;
        public float MaxElevationAngle;
        public float MinElevationAngle;
        public float OrbitalAngle;
        public TMPro.Examples.CameraController.CameraModes CameraMode;
        public bool MovementSmoothing;
        public bool RotationSmoothing;
        private bool previousSmoothing;
        public float MovementSmoothingValue;
        public float RotationSmoothingValue;
        public float MoveSensitivity;
        private UnityEngine.Vector3 currentVelocity;
        private UnityEngine.Vector3 desiredPosition;
        private float mouseX;
        private float mouseY;
        private UnityEngine.Vector3 moveVector;
        private float mouseWheel;
        private const string event_SmoothingValue = "Slider - Smoothing Value";
        private const string event_FollowDistance = "Slider - Camera Zoom";
        
        // Methods
        public CameraController()
        {
            this.FollowDistance = ;
            this.MaxFollowDistance = ;
            this.MinFollowDistance = 2f;
            this.ElevationAngle = 30f;
            this.MaxElevationAngle = 85f;
            this.MovementSmoothing = true;
            this.MovementSmoothingValue = 25f;
            this.RotationSmoothingValue = 5f;
            this.MoveSensitivity = 2f;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.currentVelocity = val_1;
            mem[1152921512511528292] = val_1.y;
            mem[1152921512511528296] = val_1.z;
        }
        private void Awake()
        {
            var val_5;
            if(UnityEngine.QualitySettings.vSyncCount >= 1)
            {
                    val_5 = 0;
            }
            else
            {
                    val_5 = 0;
            }
            
            UnityEngine.Application.targetFrameRate = 0;
            if(UnityEngine.Application.platform != 8)
            {
                    if(UnityEngine.Application.platform != 11)
            {
                goto label_4;
            }
            
            }
            
            UnityEngine.Input.simulateMouseWithTouches = false;
            label_4:
            this.cameraTransform = this.transform;
            this.previousSmoothing = this.MovementSmoothing;
        }
        private void Start()
        {
            if(0 != this.CameraTarget)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = new UnityEngine.GameObject(name:  "Camera Target");
            UnityEngine.Transform val_3 = transform;
            this.dummyTarget = val_3;
            this.CameraTarget = val_3;
        }
        private void LateUpdate()
        {
            UnityEngine.Transform val_21;
            float val_22;
            float val_23;
            float val_24;
            float val_26;
            float val_27;
            float val_28;
            float val_29;
            float val_33;
            float val_34;
            UnityEngine.Vector3 val_38;
            UnityEngine.Vector3 val_39;
            var val_40;
            float val_41;
            val_21 = this;
            this.GetPlayerInput();
            if(0 == this.CameraTarget)
            {
                    return;
            }
            
            if(this.CameraMode == 0)
            {
                goto label_4;
            }
            
            if(this.CameraMode != 1)
            {
                goto label_5;
            }
            
            UnityEngine.Vector3 val_2 = this.CameraTarget.position;
            val_22 = val_2.x;
            val_23 = val_2.y;
            val_24 = val_2.z;
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Euler(x:  this.ElevationAngle, y:  this.OrbitalAngle, z:  0f);
            val_26 = val_3.z;
            val_27 = val_3.x;
            val_28 = val_3.y;
            val_29 = val_26;
            UnityEngine.Vector3 val_4 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_27, y = val_28, z = val_29, w = val_3.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            goto label_9;
            label_4:
            UnityEngine.Vector3 val_5 = this.CameraTarget.position;
            val_22 = val_5.x;
            val_23 = val_5.y;
            val_24 = val_5.z;
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(x:  this.ElevationAngle, y:  this.OrbitalAngle, z:  0f);
            val_26 = val_6.z;
            UnityEngine.Vector3 val_7 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_26, w = val_6.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_27 = val_7.x;
            val_28 = val_7.y;
            val_29 = val_7.z;
            UnityEngine.Vector3 val_8 = this.CameraTarget.TransformDirection(direction:  new UnityEngine.Vector3() {x = val_27, y = val_28, z = val_29});
            label_9:
            val_33 = val_8.y;
            val_34 = val_8.x;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_22, y = val_23, z = val_24}, b:  new UnityEngine.Vector3() {x = val_34, y = val_33, z = val_8.z});
            this.desiredPosition = val_9;
            mem[1152921512511946320] = val_9.y;
            mem[1152921512511946324] = val_9.z;
            label_5:
            if(this.MovementSmoothing == false)
            {
                goto label_16;
            }
            
            UnityEngine.Vector3 val_10 = this.cameraTransform.position;
            val_38 = this.currentVelocity;
            val_26 = UnityEngine.Time.fixedDeltaTime;
            val_34 = this.desiredPosition;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.SmoothDamp(current:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, target:  new UnityEngine.Vector3() {x = val_34, y = val_8.x, z = val_33}, currentVelocity: ref  new UnityEngine.Vector3(), smoothTime:  this.MovementSmoothingValue * val_26);
            val_39 = val_13.x;
            val_40 = val_13.y;
            val_41 = val_13.z;
            if(this.cameraTransform != null)
            {
                goto label_22;
            }
            
            goto label_21;
            label_16:
            val_39 = this.desiredPosition;
            if(this.cameraTransform != null)
            {
                goto label_22;
            }
            
            label_21:
            label_22:
            this.cameraTransform.position = new UnityEngine.Vector3() {x = val_39, y = val_23, z = val_24};
            if(this.RotationSmoothing != false)
            {
                    UnityEngine.Quaternion val_14 = this.cameraTransform.rotation;
                UnityEngine.Vector3 val_15 = this.CameraTarget.position;
                val_38 = this.cameraTransform;
                UnityEngine.Vector3 val_16 = val_38.position;
                UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
                UnityEngine.Quaternion val_18 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
                val_26 = this.RotationSmoothingValue;
                val_33 = val_18.z;
                float val_19 = UnityEngine.Time.deltaTime;
                val_19 = val_26 * val_19;
                UnityEngine.Quaternion val_20 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_14.w}, b:  new UnityEngine.Quaternion() {x = val_18.x, y = val_18.y, z = val_33, w = val_18.w}, t:  val_19);
                val_39 = val_20.x;
                val_41 = val_20.z;
                this.cameraTransform.rotation = new UnityEngine.Quaternion() {x = val_39, y = val_20.y, z = val_41, w = val_20.w};
                return;
            }
            
            val_21 = this.CameraTarget;
            this.cameraTransform.LookAt(target:  val_21);
        }
        private void GetPlayerInput()
        {
            float val_22;
            float val_23;
            float val_52;
            float val_53;
            float val_54;
            float val_55;
            float val_56;
            float val_57;
            UnityEngine.Transform val_58;
            UnityEngine.Transform val_59;
            UnityEngine.Transform val_60;
            float val_63;
            float val_66;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.moveVector = val_1;
            mem[1152921512512210164] = val_1.y;
            mem[1152921512512210168] = val_1.z;
            this.mouseWheel = UnityEngine.Input.GetAxis(axisName:  0);
            int val_3 = UnityEngine.Input.touchCount;
            if((UnityEngine.Input.GetKey(key:  0)) != true)
            {
                    if(val_3 <= 0)
            {
                    if((UnityEngine.Input.GetKey(key:  0)) == false)
            {
                goto label_57;
            }
            
            }
            
            }
            
            val_52 = 10f;
            val_53 = this.mouseWheel * val_52;
            this.mouseWheel = val_53;
            if((UnityEngine.Input.GetKeyDown(key:  0)) != false)
            {
                    this.CameraMode = 1;
            }
            
            if((UnityEngine.Input.GetKeyDown(key:  0)) != false)
            {
                    this.CameraMode = 0;
            }
            
            if((UnityEngine.Input.GetKeyDown(key:  0)) != false)
            {
                    bool val_47 = this.MovementSmoothing;
                val_47 = val_47 ^ 1;
                this.MovementSmoothing = val_47;
            }
            
            if((UnityEngine.Input.GetMouseButton(button:  0)) == false)
            {
                goto label_30;
            }
            
            this.mouseY = UnityEngine.Input.GetAxis(axisName:  0);
            val_52 = UnityEngine.Input.GetAxis(axisName:  0);
            float val_48 = this.mouseY;
            this.mouseX = val_52;
            if(val_48 > 0.01f)
            {
                goto label_24;
            }
            
            val_54 = -0.01f;
            if(val_48 >= 0)
            {
                goto label_25;
            }
            
            label_24:
            val_55 = this.MaxElevationAngle;
            val_48 = val_48 * this.MoveSensitivity;
            val_56 = this.ElevationAngle - val_48;
            this.ElevationAngle = val_56;
            val_54 = val_55;
            val_52 = this.mouseX;
            this.ElevationAngle = UnityEngine.Mathf.Clamp(value:  val_56, min:  this.MinElevationAngle, max:  val_54);
            label_25:
            if(val_52 > 0.01f)
            {
                goto label_28;
            }
            
            val_53 = -0.01f;
            if(val_52 >= 0)
            {
                goto label_30;
            }
            
            label_28:
            val_57 = this.MoveSensitivity;
            val_53 = 360f;
            val_52 = val_52 * val_57;
            val_52 = this.OrbitalAngle + val_52;
            val_54 = val_52 + (-360f);
            val_52 = (val_52 > val_53) ? (val_54) : (val_52);
            this.OrbitalAngle = val_52;
            if(val_52 < 0)
            {
                    val_53 = val_52 + val_53;
                this.OrbitalAngle = val_53;
            }
            
            label_30:
            if(val_3 != 1)
            {
                goto label_43;
            }
            
            UnityEngine.Touch val_14 = UnityEngine.Input.GetTouch(index:  0);
            if((-684583736) != 1)
            {
                goto label_43;
            }
            
            UnityEngine.Touch val_15 = UnityEngine.Input.GetTouch(index:  0);
            val_55 = val_53;
            if(val_52 <= 0.01f)
            {
                    if(val_52 >= 0)
            {
                goto label_38;
            }
            
            }
            
            val_52 = val_52 * (-0.1f);
            float val_16 = this.ElevationAngle + val_52;
            this.ElevationAngle = val_16;
            val_56 = this.MinElevationAngle;
            val_52 = val_56;
            val_54 = this.MaxElevationAngle;
            this.ElevationAngle = UnityEngine.Mathf.Clamp(value:  val_16, min:  val_52, max:  val_54);
            label_38:
            if(val_55 > 0.01f)
            {
                goto label_41;
            }
            
            val_53 = -0.01f;
            if(val_55 >= 0)
            {
                goto label_43;
            }
            
            label_41:
            float val_49 = 0.1f;
            float val_50 = this.OrbitalAngle;
            val_57 = -360f;
            val_53 = 360f;
            val_49 = val_55 * val_49;
            val_50 = val_49 + val_50;
            val_54 = val_50 + val_57;
            val_50 = (val_50 > val_53) ? (val_54) : (val_50);
            this.OrbitalAngle = val_50;
            if(val_50 < 0)
            {
                    val_53 = val_50 + val_53;
                this.OrbitalAngle = val_53;
            }
            
            label_43:
            if((UnityEngine.Input.GetMouseButton(button:  0)) != false)
            {
                    val_58 = UnityEngine.Camera.main;
                UnityEngine.Vector3 val_20 = UnityEngine.Input.mousePosition;
                val_55 = val_20.x;
                val_56 = val_20.z;
                val_52 = val_20.y;
                val_54 = val_56;
                UnityEngine.Ray val_21 = val_58.ScreenPointToRay(position:  new UnityEngine.Vector3() {x = val_55, y = val_52, z = val_54});
                val_53 = 300f;
                if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3(), m_Direction = new UnityEngine.Vector3()}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = val_23, y = val_23, z = val_23}, m_Normal = new UnityEngine.Vector3() {x = val_23, y = val_22, z = val_22}, m_UV = new UnityEngine.Vector2()}, maxDistance:  val_53, layerMask:  -684583856)) != false)
            {
                    val_58 = this.CameraTarget;
                if(0 == 0)
            {
                    this.OrbitalAngle = 0f;
            }
            else
            {
                    this.CameraTarget = 0;
                this.OrbitalAngle = 0f;
                this.MovementSmoothing = this.previousSmoothing;
            }
            
            }
            
            }
            
            if((UnityEngine.Input.GetMouseButton(button:  0)) == false)
            {
                goto label_57;
            }
            
            if(0 != this.dummyTarget)
            {
                goto label_60;
            }
            
            UnityEngine.GameObject val_28 = new UnityEngine.GameObject(name:  "Camera Target");
            val_59 = this.CameraTarget;
            val_60 = transform;
            this.dummyTarget = val_60;
            if(val_59 != null)
            {
                goto label_67;
            }
            
            goto label_63;
            label_60:
            if(0 == this.dummyTarget)
            {
                goto label_66;
            }
            
            val_60 = this.dummyTarget;
            val_59 = this.CameraTarget;
            if(val_59 != null)
            {
                goto label_67;
            }
            
            label_63:
            label_67:
            UnityEngine.Vector3 val_31 = val_59.position;
            val_60.position = new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z};
            UnityEngine.Quaternion val_32 = this.CameraTarget.rotation;
            val_63 = val_32.x;
            this.dummyTarget.rotation = new UnityEngine.Quaternion() {x = val_63, y = val_32.y, z = val_32.z, w = val_32.w};
            this.CameraTarget = this.dummyTarget;
            this.previousSmoothing = this.MovementSmoothing;
            this.MovementSmoothing = false;
            label_66:
            this.mouseY = UnityEngine.Input.GetAxis(axisName:  0);
            float val_34 = UnityEngine.Input.GetAxis(axisName:  0);
            this.mouseX = val_34;
            UnityEngine.Vector3 val_35 = this.cameraTransform.TransformDirection(x:  val_34, y:  this.mouseY, z:  0f);
            this.moveVector = val_35;
            mem[1152921512512210164] = val_35.y;
            mem[1152921512512210168] = val_35.z;
            val_58 = this.dummyTarget;
            UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z});
            val_55 = val_36.x;
            val_56 = val_36.z;
            val_66 = val_55;
            val_52 = val_36.y;
            val_58.Translate(translation:  new UnityEngine.Vector3() {x = val_66, y = val_52, z = val_56}, relativeTo:  0);
            label_57:
            if(val_3 == 2)
            {
                    UnityEngine.Touch val_37 = UnityEngine.Input.GetTouch(index:  0);
                UnityEngine.Touch val_38 = UnityEngine.Input.GetTouch(index:  0);
                UnityEngine.Vector2 val_39 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_66, y = val_52}, b:  new UnityEngine.Vector2() {x = val_66, y = val_52});
                UnityEngine.Vector2 val_40 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_39.x, y = val_39.y}, b:  new UnityEngine.Vector2() {x = val_39.x, y = val_39.y});
                UnityEngine.Vector2 val_41 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_39.x, y = val_39.y}, b:  new UnityEngine.Vector2() {x = val_40.x, y = val_40.y});
                val_55 = val_41.x;
                val_56 = val_41.y;
                UnityEngine.Vector2 val_42 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_41.x, y = val_56}, b:  new UnityEngine.Vector2() {x = val_41.x, y = val_41.y});
                val_42.x = val_55 - val_42.x;
                if(val_42.x <= 0.01f)
            {
                    if(val_42.x >= 0)
            {
                goto label_83;
            }
            
            }
            
                val_55 = this.MaxFollowDistance;
                val_42.x = val_42.x * 0.25f;
                float val_43 = val_42.x + this.FollowDistance;
                this.FollowDistance = val_43;
                val_56 = this.MinFollowDistance;
                this.FollowDistance = UnityEngine.Mathf.Clamp(value:  val_43, min:  val_56, max:  val_55);
            }
            
            label_83:
            float val_51 = this.mouseWheel;
            if(val_51 >= 0)
            {
                    if(val_51 <= 0.01f)
            {
                    return;
            }
            
            }
            
            val_55 = this.MaxFollowDistance;
            val_51 = val_51 * (-5f);
            float val_45 = this.FollowDistance + val_51;
            this.FollowDistance = val_45;
            val_56 = this.MinFollowDistance;
            this.FollowDistance = UnityEngine.Mathf.Clamp(value:  val_45, min:  val_56, max:  val_55);
        }
    
    }

}
