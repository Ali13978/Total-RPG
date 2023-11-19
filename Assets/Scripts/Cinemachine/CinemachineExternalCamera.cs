using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [UnityEngine.RequireComponent]
    [UnityEngine.DisallowMultipleComponent]
    [UnityEngine.ExecuteInEditMode]
    [UnityEngine.AddComponentMenu]
    public class CinemachineExternalCamera : CinemachineVirtualCameraBase
    {
        // Fields
        [UnityEngine.TooltipAttribute]
        [Cinemachine.NoSaveDuringPlayAttribute]
        public UnityEngine.Transform m_LookAt;
        private UnityEngine.Camera m_Camera;
        private Cinemachine.CameraState m_State;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Transform <Follow>k__BackingField;
        
        // Properties
        public override Cinemachine.CameraState State { get; }
        public override UnityEngine.Transform LookAt { get; set; }
        public override UnityEngine.Transform Follow { get; set; }
        
        // Methods
        public CinemachineExternalCamera()
        {
            Cinemachine.CameraState val_1 = Cinemachine.CameraState.Default;
        }
        public override Cinemachine.CameraState get_State()
        {
        
        }
        public override UnityEngine.Transform get_LookAt()
        {
            return (UnityEngine.Transform)this.m_LookAt;
        }
        public override void set_LookAt(UnityEngine.Transform value)
        {
            this.m_LookAt = value;
        }
        public override UnityEngine.Transform get_Follow()
        {
            return (UnityEngine.Transform)this.<Follow>k__BackingField;
        }
        public override void set_Follow(UnityEngine.Transform value)
        {
            this.<Follow>k__BackingField = value;
        }
        public override void UpdateCameraState(UnityEngine.Vector3 worldUp, float deltaTime)
        {
            var val_12;
            var val_13;
            float val_17;
            float val_18;
            float val_19;
            float val_23;
            float val_24;
            float val_25;
            float val_26;
            float val_32;
            float val_33;
            float val_34;
            float val_35;
            UnityEngine.Camera val_36;
            if(0 == this.m_Camera)
            {
                    this.m_Camera = this.GetComponent<UnityEngine.Camera>();
            }
            
            Cinemachine.CameraState val_3 = Cinemachine.CameraState.Default;
            UnityEngine.Vector3 val_5 = this.transform.position;
            mem[1152921511670874796] = val_5.x;
            mem[1152921511670874800] = val_5.y;
            mem[1152921511670874804] = val_5.z;
            UnityEngine.Quaternion val_7 = this.transform.rotation;
            val_32 = val_7.x;
            val_33 = val_7.z;
            mem[1152921511670874808] = val_32;
            mem[1152921511670874812] = val_7.y;
            mem[1152921511670874816] = val_33;
            mem[1152921511670874820] = val_7.w;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.up;
            val_34 = val_8.x;
            val_35 = val_8.z;
            UnityEngine.Vector3 val_9 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_32, y = val_7.y, z = val_33, w = val_7.w}, point:  new UnityEngine.Vector3() {x = val_34, y = val_8.y, z = val_35});
            mem[1152921511670874772] = val_9.x;
            mem[1152921511670874776] = val_9.y;
            mem[1152921511670874780] = val_9.z;
            val_36 = this.m_Camera;
            if(0 != val_36)
            {
                    val_36 = this.m_Camera;
                Cinemachine.LensSettings val_11 = Cinemachine.LensSettings.FromCamera(fromCamera:  0);
                mem2[0] = val_12;
                mem2[0] = val_13;
            }
            
            if(0 == this.m_LookAt)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_16 = this.m_LookAt.transform.position;
            mem[1152921511670874784] = val_16.x;
            mem[1152921511670874788] = val_16.y;
            mem[1152921511670874792] = val_16.z;
            val_34 = val_18;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = val_17, y = val_34, z = val_19});
            val_32 = val_20.x;
            val_33 = val_20.z;
            if((Cinemachine.Utility.UnityVectorExtensions.AlmostZero(v:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z})) == true)
            {
                    return;
            }
            
            val_34 = val_24;
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.forward;
            val_35 = val_27.y;
            UnityEngine.Vector3 val_28 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_23, y = val_34, z = val_25, w = val_26}, point:  new UnityEngine.Vector3() {x = val_27.x, y = val_35, z = val_27.z});
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.Project(vector:  new UnityEngine.Vector3() {x = val_32, y = val_20.y, z = val_33}, onNormal:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
            UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.x, z = val_20.x}, b:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
            mem[1152921511670874784] = val_30.x;
            mem[1152921511670874788] = val_30.y;
            mem[1152921511670874792] = val_30.z;
        }
    
    }

}
