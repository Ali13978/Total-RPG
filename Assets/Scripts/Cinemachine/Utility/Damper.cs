using UnityEngine;

namespace Cinemachine.Utility
{
    public static class Damper
    {
        // Fields
        private const float Epsilon = 0.0001;
        public const float kNegligibleResidual = 0.01;
        
        // Methods
        private static float DecayConstant(float time, float residual)
        {
            float val_1 = 1f;
            val_1 = val_1 / residual;
            val_1 = val_1 / time;
            return (float)val_1;
        }
        private static float Decay(float initial, float decayConstant, float deltaTime)
        {
            float val_1 = decayConstant * deltaTime;
            val_1 = initial / val_1;
            return (float)val_1;
        }
        public static float Damp(float initial, float dampTime, float deltaTime)
        {
            float val_3 = initial;
            if(dampTime < 0)
            {
                    return (float)val_3;
            }
            
            if((System.Math.Abs(val_3 = initial)) < 0)
            {
                    return (float)val_3;
            }
            
            if(deltaTime < 0)
            {
                    val_3 = 0f;
                return (float)val_3;
            }
            
            val_3 = val_3 - (Cinemachine.Utility.Damper.Decay(initial:  val_3, decayConstant:  Cinemachine.Utility.Damper.DecayConstant(time:  dampTime, residual:  0.01f), deltaTime:  deltaTime));
            return (float)val_3;
        }
        public static UnityEngine.Vector3 Damp(UnityEngine.Vector3 initial, UnityEngine.Vector3 dampTime, float deltaTime)
        {
            var val_2 = 0;
            do
            {
                float val_1 = Cinemachine.Utility.Damper.Damp(initial:  initial.x, dampTime:  initial.x, deltaTime:  deltaTime);
                val_2 = val_2 + 1;
            }
            while(val_2 != 3);
            
            return new UnityEngine.Vector3() {x = initial.x, y = initial.y, z = initial.z};
        }
        public static UnityEngine.Vector3 Damp(UnityEngine.Vector3 initial, float dampTime, float deltaTime)
        {
            var val_2 = 0;
            do
            {
                float val_1 = Cinemachine.Utility.Damper.Damp(initial:  initial.x, dampTime:  dampTime, deltaTime:  deltaTime);
                val_2 = val_2 + 1;
            }
            while(val_2 != 3);
            
            return new UnityEngine.Vector3() {x = initial.x, y = initial.y, z = initial.z};
        }
    
    }

}
