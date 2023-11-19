using UnityEngine;

namespace TzarGames.Endless
{
    public class EndlessPlayerSpawnPoint : SpawnPoint
    {
        // Fields
        [UnityEngine.SerializeField]
        private float cameraYaw;
        
        // Properties
        public float CameraYaw { get; }
        
        // Methods
        public EndlessPlayerSpawnPoint()
        {
        
        }
        public float get_CameraYaw()
        {
            return (float)this.cameraYaw;
        }
        private void OnDrawGizmos()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.blue;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.up;
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.AngleAxis(angle:  this.cameraYaw, axis:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_5 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, point:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.up;
            UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.AngleAxis(angle:  this.cameraYaw, axis:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_9 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w}, point:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            UnityEngine.Vector3 val_11 = this.transform.position;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  0.1f);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, d:  0.1f);
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
            UnityEngine.Vector3 val_23 = this.transform.position;
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, to:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, to:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, to:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, to:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
        }
    
    }

}
