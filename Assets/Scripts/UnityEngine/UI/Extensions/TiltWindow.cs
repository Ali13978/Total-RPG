using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    public class TiltWindow : MonoBehaviour
    {
        // Fields
        public UnityEngine.Vector2 range;
        private UnityEngine.Transform mTrans;
        private UnityEngine.Quaternion mStart;
        private UnityEngine.Vector2 mRot;
        
        // Methods
        public TiltWindow()
        {
            CinemachineFreeLook.Orbit val_1 = new CinemachineFreeLook.Orbit(h:  5f, r:  3f);
            this.range = val_1.m_Height;
            mem[1152921512684118108] = val_1.m_Height >> 32;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
            this.mRot = val_3;
            mem[1152921512684118140] = val_3.y;
        }
        private void Start()
        {
            UnityEngine.Transform val_1 = this.transform;
            this.mTrans = val_1;
            UnityEngine.Quaternion val_2 = val_1.localRotation;
            this.mStart = val_2;
            mem[1152921512684234220] = val_2.y;
            mem[1152921512684234224] = val_2.z;
            mem[1152921512684234228] = val_2.w;
        }
        private void Update()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Input.mousePosition;
            float val_3 = (float)UnityEngine.Screen.width * 0.5f;
            float val_5 = (float)UnityEngine.Screen.height * 0.5f;
            float val_6 = val_1.x - val_3;
            val_6 = val_6 / val_3;
            float val_7 = UnityEngine.Mathf.Clamp(value:  val_6, min:  -1f, max:  1f);
            float val_8 = val_1.y - val_5;
            val_8 = val_8 / val_5;
            CinemachineFreeLook.Orbit val_10 = new CinemachineFreeLook.Orbit(h:  val_7, r:  UnityEngine.Mathf.Clamp(value:  val_8, min:  -1f, max:  1f));
            float val_11 = UnityEngine.Time.deltaTime;
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.Lerp(a:  new UnityEngine.Vector2() {x = this.mRot, y = -1f}, b:  new UnityEngine.Vector2() {x = val_10.m_Height, y = val_10.m_Radius}, t:  val_11 * 5f);
            this.mRot = val_13;
            mem[1152921512684354428] = val_13.y;
            UnityEngine.Quaternion val_16 = UnityEngine.Quaternion.Euler(x:  -(val_13.y * S15), y:  val_13.x * this.range, z:  0f);
            UnityEngine.Quaternion val_17 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = this.mStart, y = -1f, z = val_11, w = val_7}, rhs:  new UnityEngine.Quaternion() {x = val_16.x, y = val_16.y, z = val_16.z, w = val_16.w});
            this.mTrans.localRotation = new UnityEngine.Quaternion() {x = val_17.x, y = val_17.y, z = val_17.z, w = val_17.w};
        }
    
    }

}
