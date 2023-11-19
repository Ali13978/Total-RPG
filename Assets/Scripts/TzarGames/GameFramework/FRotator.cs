using UnityEngine;

namespace TzarGames.GameFramework
{
    public struct FRotator
    {
        // Fields
        private UnityEngine.Transform _transform;
        private UnityEngine.Quaternion _q;
        
        // Properties
        public UnityEngine.Transform transform { get; set; }
        public UnityEngine.Quaternion q { get; set; }
        public static TzarGames.GameFramework.FRotator identity { get; }
        public float Pitch { get; }
        public float Yaw { get; }
        public float Roll { get; }
        
        // Methods
        public FRotator(float p, float y, float r)
        {
        
        }
        public UnityEngine.Transform get_transform()
        {
            return (UnityEngine.Transform)this;
        }
        public void set_transform(UnityEngine.Transform value)
        {
        
        }
        public UnityEngine.Quaternion get_q()
        {
            return new UnityEngine.Quaternion();
        }
        public void set_q(UnityEngine.Quaternion value)
        {
        
        }
        public static TzarGames.GameFramework.FRotator get_identity()
        {
            TzarGames.GameFramework.FRotator val_0;
            val_0._q.x = 0f;
            val_0._q.y = 0f;
            val_0._q.z = 0f;
            val_0._q.w = 0f;
            val_0._transform = 0;
            return val_0;
        }
        public float get_Pitch()
        {
            return (float)S0;
        }
        public float get_Yaw()
        {
            return (float)V1.16B;
        }
        public float get_Roll()
        {
            return (float)V2.16B;
        }
        public TzarGames.GameFramework.FRotator Clamp()
        {
        
        }
        public float ClampAxis(float Angle)
        {
            float val_1 = TzarGames.Common.FMath.Fmod(x:  Angle, y:  360f);
            val_1 = (val_1 < 0) ? (val_1 + 360f) : (val_1);
            return (float)val_1;
        }
        public float NormalizeAxis(float Angle)
        {
            float val_1 = TzarGames.Common.FMath.Fmod(x:  Angle, y:  360f);
            float val_2 = val_1 + 360f;
            val_1 = (val_1 < 0) ? (val_2) : (val_1);
            val_2 = val_1 + (-360f);
            val_1 = (val_1 > 180f) ? (val_2) : (val_1);
            return (float)val_1;
        }
        public TzarGames.GameFramework.FRotator GetNormalized()
        {
            TzarGames.GameFramework.FRotator val_0;
            val_0._q.z = ???;
            val_0._transform = ???;
            return val_0;
        }
        public TzarGames.GameFramework.FRotator GetDenormalized()
        {
        
        }
        public void Normalize()
        {
        
        }
    
    }

}
