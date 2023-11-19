using UnityEngine;

namespace LlockhamIndustries.Decals
{
    public class RayPrinter : Printer
    {
        // Fields
        public UnityEngine.LayerMask layers;
        
        // Methods
        public RayPrinter()
        {
        
        }
        public void PrintOnRay(UnityEngine.Ray Ray, float RayLength, UnityEngine.Vector3 DecalUp)
        {
            float val_11;
            float val_12;
            float val_13;
            var val_14;
            val_11 = DecalUp.z;
            val_12 = DecalUp.y;
            val_13 = DecalUp.x;
            val_14 = 1152921504719785984;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_13, y = val_12, z = val_11}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) != false)
            {
                    UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
                val_13 = val_3.x;
                val_12 = val_3.y;
                val_11 = val_3.z;
            }
            
            int val_4 = this.layers.value;
            if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3(), m_Direction = new UnityEngine.Vector3()}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = Ray.m_Origin.x}, m_Normal = new UnityEngine.Vector3() {y = Ray.m_Direction.y}, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  RayLength, layerMask:  -1372342976)) == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = RayLength, y = val_3.y, z = val_3.z});
            UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, upwards:  new UnityEngine.Vector3() {x = val_13, y = val_12, z = val_11});
            val_11 = val_7.x;
            val_13 = val_7.z;
            val_14 = 0.Payload.gameObject;
            this.Print(Position:  new UnityEngine.Vector3() {x = RayLength, y = val_3.y, z = val_3.z}, Rotation:  new UnityEngine.Quaternion() {x = val_11, y = val_7.y, z = val_13, w = val_7.w}, Surface:  0, Layer:  val_14.layer);
        }
    
    }

}
