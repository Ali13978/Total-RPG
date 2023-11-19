using UnityEngine;

namespace SA.IOSNative.Gestures
{
    public class ForceInfo
    {
        // Fields
        private float _Force;
        private float _MaxForce;
        
        // Properties
        public float Force { get; }
        public float MaxForce { get; }
        
        // Methods
        public ForceInfo(float force, float maxForce)
        {
            this._Force = force;
            this._MaxForce = maxForce;
        }
        public float get_Force()
        {
            return (float)this._Force;
        }
        public float get_MaxForce()
        {
            return (float)this._MaxForce;
        }
    
    }

}
