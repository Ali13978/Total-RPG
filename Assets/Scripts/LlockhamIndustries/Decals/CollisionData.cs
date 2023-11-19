using UnityEngine;

namespace LlockhamIndustries.Decals
{
    internal struct CollisionData
    {
        // Fields
        public UnityEngine.Vector3 position;
        public UnityEngine.Quaternion rotation;
        public UnityEngine.Transform surface;
        public int layer;
        
        // Methods
        public CollisionData(UnityEngine.Vector3 Position, UnityEngine.Quaternion Rotation, UnityEngine.Transform Surface, int Layer)
        {
            mem[1152921511824177616] = Position.x;
            mem[1152921511824177620] = Position.y;
            mem[1152921511824177624] = Position.z;
            mem[1152921511824177628] = Rotation.x;
            this.surface = Rotation.y;
            mem[1152921511824177636] = Rotation.z;
            this.layer = Rotation.w;
            mem[1152921511824177648] = Surface;
            mem[1152921511824177656] = Layer;
        }
    
    }

}
