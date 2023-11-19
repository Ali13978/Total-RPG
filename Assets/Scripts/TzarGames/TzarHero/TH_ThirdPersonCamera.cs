using UnityEngine;

namespace TzarGames.TzarHero
{
    public class TH_ThirdPersonCamera : TG_ThirdPersonCamera
    {
        // Fields
        public float MaxCameraOffset;
        public float MinCameraOffset;
        public float MinCameraPitch;
        public float MaxCameraPitch;
        public float cameraUpdateSpeed;
        public float distanceForMaxOffset;
        public float distanceForMinOffset;
        private float desiredOffset;
        private float desiredPitch;
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.CameraModes cameraMode;
        private bool shake;
        private float shakeStartTime;
        private float shakeTime;
        private float shakeMaxRange;
        
        // Properties
        public TzarGames.TzarHero.CameraModes CameraMode { get; set; }
        
        // Methods
        public TH_ThirdPersonCamera()
        {
            this.cameraUpdateSpeed = 1f;
            this.distanceForMaxOffset = 0f;
            this.distanceForMinOffset = 3f;
            this.MaxCameraOffset = ;
            this.MinCameraOffset = ;
            this.MinCameraPitch = 50f;
            this.MaxCameraPitch = 60f;
            this.shakeTime = 1f;
            this.shakeMaxRange = 7.346868E-41f;
        }
        public TzarGames.TzarHero.CameraModes get_CameraMode()
        {
            return (TzarGames.TzarHero.CameraModes)this.cameraMode;
        }
        public void set_CameraMode(TzarGames.TzarHero.CameraModes value)
        {
            float val_1;
            float val_2;
            this.cameraMode = value;
            if(value != 2)
            {
                    if(value != 1)
            {
                    return;
            }
            
                val_1 = this.MaxCameraOffset;
                val_2 = this.MaxCameraPitch;
            }
            else
            {
                    val_1 = this.MinCameraOffset;
                val_2 = this.MinCameraPitch;
            }
            
            this.desiredOffset = val_1;
            this.desiredPitch = val_2;
        }
        private void ckeckCharacters()
        {
            var val_6;
            float val_20;
            if(this.cameraMode != 0)
            {
                    return;
            }
            
            float val_3 = this.distanceForMaxOffset * this.distanceForMaxOffset;
            List.Enumerator<T> val_4 = TzarGames.TzarHero.TH_Character.AllCharacters.GetEnumerator();
            val_20 = val_3;
            label_27:
            do
            {
                label_26:
                if((0 & 1) == 0)
            {
                goto label_30;
            }
            
                System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_7 = val_6.InitializationCallback;
            }
            while(0 == val_7);
            
            if(0 == val_7)
            {
                goto label_11;
            }
            
            UnityEngine.Vector3 val_11 = X21.position;
            UnityEngine.Vector3 val_12 = X21.position;
            val_20 = val_11.x;
            bool val_14 = UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_20, y = val_11.y, z = val_11.z}, rhs:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            if(val_14 == true)
            {
                goto label_26;
            }
            
            if(val_14 == false)
            {
                goto label_21;
            }
            
            goto label_26;
            label_11:
            label_21:
            UnityEngine.Vector3 val_15 = val_7.position;
            UnityEngine.Vector3 val_16 = val_7.position;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
            if(val_17.x > val_20)
            {
                goto label_26;
            }
            
            goto label_27;
            label_30:
            val_6.Dispose();
            float val_20 = this.MaxCameraOffset;
            float val_18 = (val_20 < 0) ? (this.distanceForMinOffset * this.distanceForMinOffset) : (val_20);
            val_18 = val_18 / val_3;
            val_20 = val_20 - this.MinCameraOffset;
            val_20 = val_18 * val_20;
            val_20 = this.MinCameraOffset + val_20;
            val_18 = val_18 * (this.MaxCameraPitch - this.MinCameraPitch);
            val_18 = this.MinCameraPitch + val_18;
            this.desiredOffset = val_20;
            this.desiredPitch = val_18;
        }
        private void Awake()
        {
            mem[1152921511616051880] = this.MaxCameraOffset;
            mem[1152921511616051872] = this.MaxCameraPitch;
            this.desiredOffset = this.MaxCameraOffset;
            this.desiredPitch = this.MaxCameraPitch;
        }
        private void Start()
        {
            this.InvokeRepeating(methodName:  "ckeckCharacters", time:  0f, repeatRate:  0.5f);
        }
        public void Shake(float timeOfShake, float shakeRange)
        {
            this.shakeTime = timeOfShake;
            this.shakeMaxRange = shakeRange;
            this.shake = true;
            this.shakeStartTime = UnityEngine.Time.time;
        }
        public void ShakeSlightly()
        {
            this.shake = true;
            this.shakeTime = 0.5f;
            this.shakeMaxRange = 7.346868E-41f;
            this.shakeStartTime = UnityEngine.Time.time;
        }
        private void updateShake()
        {
            if(this.shake == false)
            {
                    return;
            }
            
            mem[1152921511616500020] = UnityEngine.Random.Range(min:  -this.shakeMaxRange, max:  this.shakeMaxRange);
            mem[1152921511616500024] = UnityEngine.Random.Range(min:  -this.shakeMaxRange, max:  this.shakeMaxRange);
            mem[1152921511616500028] = UnityEngine.Random.Range(min:  -this.shakeMaxRange, max:  this.shakeMaxRange);
            float val_4 = UnityEngine.Time.time;
            val_4 = val_4 - this.shakeStartTime;
            if(val_4 < this.shakeTime)
            {
                    return;
            }
            
            this.shake = false;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            mem[1152921511616500020] = val_5.x;
            mem[1152921511616500024] = val_5.y;
            mem[1152921511616500028] = val_5.z;
        }
        public override void UpdateCamera()
        {
            mem[1152921511616611992] = UnityEngine.Mathf.Lerp(a:  V8.16B, b:  this.desiredOffset, t:  UnityEngine.Time.deltaTime * this.cameraUpdateSpeed);
            mem[1152921511616611984] = UnityEngine.Mathf.Lerp(a:  V8.16B, b:  this.desiredPitch, t:  UnityEngine.Time.deltaTime * this.cameraUpdateSpeed);
            this.updateShake();
            this.UpdateCamera();
        }
    
    }

}
