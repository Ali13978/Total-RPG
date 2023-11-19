using UnityEngine;

namespace TzarGames.GameFramework
{
    public class Hit : IHit
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Vector3 <Point>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Vector3 <Normal>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.GameFramework.ISurfaceType <SurfaceType>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Collider <Collider>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Rigidbody <Rigidbody>k__BackingField;
        
        // Properties
        public UnityEngine.Vector3 Point { get; set; }
        public UnityEngine.Vector3 Normal { get; set; }
        public TzarGames.GameFramework.ISurfaceType SurfaceType { get; set; }
        public UnityEngine.Collider Collider { get; set; }
        public UnityEngine.Rigidbody Rigidbody { get; set; }
        
        // Methods
        public Hit(UnityEngine.Vector3 point, UnityEngine.Vector3 normal, UnityEngine.Collider collider, UnityEngine.Rigidbody rigidbody, TzarGames.GameFramework.ISurfaceType surfaceType)
        {
            this.<Point>k__BackingField = point;
            mem[1152921511335864324] = point.y;
            mem[1152921511335864328] = point.z;
            this.<Normal>k__BackingField = normal;
            mem[1152921511335864336] = normal.y;
            mem[1152921511335864340] = normal.z;
            this.<SurfaceType>k__BackingField = surfaceType;
            this.<Collider>k__BackingField = collider;
            this.<Rigidbody>k__BackingField = rigidbody;
        }
        public UnityEngine.Vector3 get_Point()
        {
            return new UnityEngine.Vector3() {x = this.<Point>k__BackingField};
        }
        public void set_Point(UnityEngine.Vector3 value)
        {
            this.<Point>k__BackingField = value;
            mem[1152921511336100612] = value.y;
            mem[1152921511336100616] = value.z;
        }
        public UnityEngine.Vector3 get_Normal()
        {
            return new UnityEngine.Vector3() {x = this.<Normal>k__BackingField};
        }
        public void set_Normal(UnityEngine.Vector3 value)
        {
            this.<Normal>k__BackingField = value;
            mem[1152921511336324624] = value.y;
            mem[1152921511336324628] = value.z;
        }
        public TzarGames.GameFramework.ISurfaceType get_SurfaceType()
        {
            return (TzarGames.GameFramework.ISurfaceType)this.<SurfaceType>k__BackingField;
        }
        public void set_SurfaceType(TzarGames.GameFramework.ISurfaceType value)
        {
            this.<SurfaceType>k__BackingField = value;
        }
        public UnityEngine.Collider get_Collider()
        {
            return (UnityEngine.Collider)this.<Collider>k__BackingField;
        }
        public void set_Collider(UnityEngine.Collider value)
        {
            this.<Collider>k__BackingField = value;
        }
        public UnityEngine.Rigidbody get_Rigidbody()
        {
            return (UnityEngine.Rigidbody)this.<Rigidbody>k__BackingField;
        }
        public void set_Rigidbody(UnityEngine.Rigidbody value)
        {
            this.<Rigidbody>k__BackingField = value;
        }
    
    }

}
