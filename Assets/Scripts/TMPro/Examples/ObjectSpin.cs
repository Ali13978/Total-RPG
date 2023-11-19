using UnityEngine;

namespace TMPro.Examples
{
    public class ObjectSpin : MonoBehaviour
    {
        // Fields
        public float SpinSpeed;
        public int RotationRange;
        private UnityEngine.Transform m_transform;
        private float m_time;
        private UnityEngine.Vector3 m_prevPOS;
        private UnityEngine.Vector3 m_initial_Rotation;
        private UnityEngine.Vector3 m_initial_Position;
        private UnityEngine.Color32 m_lightColor;
        private int frames;
        public TMPro.Examples.ObjectSpin.MotionType Motion;
        
        // Methods
        public ObjectSpin()
        {
            this.SpinSpeed = 5f;
            this.RotationRange = 15;
        }
        private void Awake()
        {
            UnityEngine.Transform val_1 = this.transform;
            this.m_transform = val_1;
            UnityEngine.Quaternion val_2 = val_1.rotation;
            this.m_initial_Rotation = val_2.x;
            mem[1152921512514195676] = val_2.y;
            mem[1152921512514195680] = val_2.z;
            UnityEngine.Vector3 val_3 = this.m_transform.position;
            this.m_initial_Position = val_3;
            mem[1152921512514195688] = val_3.y;
            mem[1152921512514195692] = val_3.z;
            UnityEngine.Light val_4 = this.GetComponent<UnityEngine.Light>();
            if(0 != val_4)
            {
                    UnityEngine.Color val_6 = val_4.color;
            }
            else
            {
                    UnityEngine.Color val_7 = UnityEngine.Color.black;
            }
            
            UnityEngine.Color32 val_8 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a});
            this.m_lightColor = val_8;
        }
        private void Update()
        {
            if(this.Motion == 0)
            {
                goto label_1;
            }
            
            float val_8 = this.SpinSpeed;
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = val_8 * val_1;
            val_8 = this.m_time + val_1;
            this.m_time = val_8;
            if(this.Motion != 1)
            {
                goto label_2;
            }
            
            float val_9 = (float)this.RotationRange;
            val_9 = val_8 * val_9;
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Euler(x:  this.m_initial_Rotation, y:  S11 + val_9, z:  val_8);
            this.m_transform.rotation = new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w};
            return;
            label_1:
            this.m_transform.Rotate(xAngle:  0f, yAngle:  this.SpinSpeed * UnityEngine.Time.deltaTime, zAngle:  0f);
            return;
            label_2:
            float val_10 = 0.95f;
            val_10 = val_8 * val_10;
            val_10 = val_10 * 15f;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.m_initial_Position, y = val_8, z = V10.16B}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this.m_transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Vector3 val_7 = this.m_transform.position;
            int val_11 = this.frames;
            this.m_prevPOS = val_7;
            mem[1152921512514340432] = val_7.y;
            mem[1152921512514340436] = val_7.z;
            val_11 = val_11 + 1;
            this.frames = val_11;
        }
    
    }

}
