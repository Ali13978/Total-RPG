using UnityEngine;

namespace Cinemachine.Utility
{
    internal class PositionPredictor
    {
        // Fields
        private UnityEngine.Vector3 m_Position;
        private const float kSmoothingDefault = 10;
        private float mSmoothing;
        private Cinemachine.Utility.GaussianWindow1D_Vector3 m_Velocity;
        private Cinemachine.Utility.GaussianWindow1D_Vector3 m_Accel;
        
        // Properties
        public float Smoothing { get; set; }
        public bool IsEmpty { get; }
        
        // Methods
        public PositionPredictor()
        {
            this.mSmoothing = 10f;
            this.m_Velocity = new Cinemachine.Utility.GaussianWindow1D_Vector3(sigma:  10f, maxKernelRadius:  10);
            this.m_Accel = new Cinemachine.Utility.GaussianWindow1D_Vector3(sigma:  10f, maxKernelRadius:  10);
        }
        public float get_Smoothing()
        {
            return (float)this.mSmoothing;
        }
        public void set_Smoothing(float value)
        {
            float val_5 = value;
            if(this.mSmoothing == val_5)
            {
                    return;
            }
            
            this.mSmoothing = val_5;
            float val_5 = 1.5f;
            val_5 = val_5 * val_5;
            int val_1 = UnityEngine.Mathf.FloorToInt(f:  val_5);
            int val_2 = UnityEngine.Mathf.Max(a:  0, b:  10);
            this.m_Velocity = new Cinemachine.Utility.GaussianWindow1D_Vector3(sigma:  this.mSmoothing, maxKernelRadius:  val_2);
            Cinemachine.Utility.GaussianWindow1D_Vector3 val_4 = null;
            val_5 = this.mSmoothing;
            val_4 = new Cinemachine.Utility.GaussianWindow1D_Vector3(sigma:  val_5, maxKernelRadius:  val_2);
            this.m_Accel = val_4;
        }
        public bool get_IsEmpty()
        {
            if(this.m_Velocity != null)
            {
                    return this.m_Velocity.IsEmpty();
            }
            
            return this.m_Velocity.IsEmpty();
        }
        public void Reset()
        {
            this.m_Velocity.Reset();
            this.m_Accel.Reset();
        }
        public void AddPosition(UnityEngine.Vector3 pos)
        {
            Cinemachine.Utility.GaussianWindow1D_Vector3 val_8;
            float val_9;
            UnityEngine.Vector3 val_10;
            var val_11;
            var val_12;
            val_8 = this;
            if(this.IsEmpty != false)
            {
                    UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
                val_9 = val_2.y;
                this.m_Velocity.AddValue(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_9, z = val_2.z});
                val_10 = this.m_Position;
                val_11 = 1152921511750069300;
                val_12 = 1152921511750069304;
            }
            else
            {
                    UnityEngine.Vector3 val_3 = this.m_Velocity.Value();
                val_10 = val_8;
                val_11 = 1152921511750069296;
                val_12 = 1152921511750069296;
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z}, b:  new UnityEngine.Vector3() {x = this.m_Position, y = V11.16B, z = V15.16B});
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  UnityEngine.Time.deltaTime);
                this.m_Velocity.AddValue(v:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
                val_8 = this.m_Accel;
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
                val_9 = val_7.y;
                val_8.AddValue(v:  new UnityEngine.Vector3() {x = val_7.x, y = val_9, z = val_7.z});
            }
            
            this.m_Position = pos.x;
            mem[1152921511750069300] = pos.y;
            mem[1152921511750069304] = pos.z;
        }
        public UnityEngine.Vector3 PredictPosition(float lookaheadTime)
        {
            UnityEngine.Vector3 val_16;
            var val_17;
            Cinemachine.Utility.GaussianWindow1D_Vector3 val_18;
            float val_19;
            float val_20;
            float val_24;
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = lookaheadTime / val_1;
            val_16 = this.m_Position;
            val_17 = UnityEngine.Mathf.Min(a:  0, b:  UnityEngine.Mathf.RoundToInt(f:  val_1));
            if(this.m_Velocity.IsEmpty() != false)
            {
                    UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            }
            else
            {
                    UnityEngine.Vector3 val_6 = this.m_Velocity.Value();
            }
            
            val_18 = this.m_Accel;
            val_19 = val_6.x;
            val_20 = val_6.z;
            if(val_18.IsEmpty() != false)
            {
                    UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            }
            else
            {
                    UnityEngine.Vector3 val_9 = this.m_Accel.Value();
            }
            
            val_24 = val_9.z;
            if(val_17 < 1)
            {
                    return new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            }
            
            float val_16 = (float)val_17;
            val_16 = lookaheadTime / val_16;
            val_18 = 1152921504719839232;
            do
            {
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_19, y = val_6.y, z = val_20}, d:  val_16);
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16, y = ???, z = val_1}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_24}, d:  val_16);
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_19, y = val_6.y, z = val_20}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
                val_19 = val_13.x;
                val_16 = val_13.y;
                UnityEngine.Quaternion val_14 = UnityEngine.Quaternion.FromToRotation(fromDirection:  new UnityEngine.Vector3() {x = val_19, y = val_6.y, z = val_20}, toDirection:  new UnityEngine.Vector3() {x = val_19, y = val_16, z = val_13.z});
                UnityEngine.Vector3 val_15 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_14.w}, point:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_24});
                val_20 = val_15.x;
                val_24 = val_15.z;
                val_17 = val_17 - 1;
            }
            while(val_17 != 0);
            
            return new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        }
    
    }

}
