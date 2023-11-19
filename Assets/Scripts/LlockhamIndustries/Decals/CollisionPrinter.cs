using UnityEngine;

namespace LlockhamIndustries.Decals
{
    [UnityEngine.RequireComponent]
    [UnityEngine.RequireComponent]
    public class CollisionPrinter : Printer
    {
        // Fields
        public LlockhamIndustries.Decals.RotationSource rotationSource;
        public LlockhamIndustries.Decals.CollisionCondition condition;
        public float conditionTime;
        public UnityEngine.LayerMask layers;
        private float timeElapsed;
        private bool delayPrinted;
        
        // Methods
        public CollisionPrinter()
        {
        
        }
        private void OnCollisionEnter(UnityEngine.Collision collision)
        {
            LlockhamIndustries.Decals.CollisionCondition val_1 = this.condition;
            val_1 = val_1 | 2;
            if(val_1 == 2)
            {
                    this.PrintCollision(collision:  collision);
            }
            
            this.delayPrinted = false;
            this.timeElapsed = 0f;
        }
        private void OnCollisionStay(UnityEngine.Collision collision)
        {
            LlockhamIndustries.Decals.CollisionCondition val_2;
            float val_1 = UnityEngine.Time.deltaTime;
            val_2 = this.condition;
            val_1 = this.timeElapsed + val_1;
            this.timeElapsed = val_1;
            if(val_2 == 2)
            {
                    this.PrintCollision(collision:  collision);
                val_2 = this.condition;
            }
            
            if(val_2 != 1)
            {
                    return;
            }
            
            if(this.timeElapsed <= this.conditionTime)
            {
                    return;
            }
            
            if(this.delayPrinted == true)
            {
                    return;
            }
            
            this.PrintCollision(collision:  collision);
            this.delayPrinted = true;
        }
        private void OnCollisionExit(UnityEngine.Collision collision)
        {
            LlockhamIndustries.Decals.CollisionCondition val_1 = this.condition;
            if(val_1 == 3)
            {
                    this.PrintCollision(collision:  collision);
                val_1 = this.condition;
            }
            
            if(val_1 != 1)
            {
                    return;
            }
            
            if(this.delayPrinted != false)
            {
                    return;
            }
            
            this.PrintCollision(collision:  collision);
        }
        public void PrintCollision(UnityEngine.Collision collision)
        {
            float val_30;
            float val_31;
            float val_32;
            var val_33;
            var val_34;
            float val_35;
            float val_36;
            float val_37;
            LlockhamIndustries.Decals.RotationSource val_38;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_30 = val_1.x;
            val_31 = val_1.z;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            val_32 = val_2.y;
            val_33 = collision.contacts;
            val_34 = 0;
            var val_31 = 0;
            goto label_4;
            label_14:
            val_34 = 1;
            label_4:
            if(val_34 >= val_3.Length)
            {
                goto label_6;
            }
            
            var val_4 = val_33 + (1 * 36);
            int val_9 = ((1 * 36) + val_3 + 32.gameObject.layer) & 31;
            val_9 = 1 << val_9;
            val_9 = val_9 | this.layers.value;
            if(this.layers.value != val_9)
            {
                goto label_14;
            }
            
            if(val_31 == 0)
            {
                goto label_11;
            }
            
            val_31 = val_31 + 1;
            goto label_14;
            label_11:
            UnityEngine.Transform val_10 = (1 * 36) + val_3 + 32.transform;
            goto label_14;
            label_6:
            if(val_31 < 1)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_32, z = val_2.z}, d:  0.3f);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_30, y = val_1.y, z = val_31}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            val_30 = val_12.x;
            val_31 = val_12.z;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_32, z = val_2.z});
            val_32 = val_13.y;
            int val_14 = this.layers.value;
            val_35 = val_30;
            val_36 = val_12.y;
            val_37 = val_31;
            if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_35, y = val_36, z = val_37}, direction:  new UnityEngine.Vector3() {x = val_13.x, y = val_32, z = val_13.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3(), m_Normal = new UnityEngine.Vector3(), m_UV = new UnityEngine.Vector2()}, maxDistance:  0.4f, layerMask:  -1376727424)) == false)
            {
                    return;
            }
            
            val_31 = val_37;
            val_38 = this.rotationSource;
            if(val_38 != 0)
            {
                goto label_20;
            }
            
            UnityEngine.Vector3 val_19 = this.GetComponent<UnityEngine.Rigidbody>().velocity;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.zero;
            val_35 = val_19.x;
            val_36 = val_19.y;
            val_37 = val_19.z;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_35, y = val_36, z = val_37}, rhs:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z})) == false)
            {
                goto label_24;
            }
            
            UnityEngine.Vector3 val_23 = this.GetComponent<UnityEngine.Rigidbody>().velocity;
            goto label_28;
            label_24:
            val_38 = this.rotationSource;
            label_20:
            if(val_38 == 1)
            {
                    UnityEngine.Vector3 val_24 = UnityEngine.Random.insideUnitSphere;
            }
            else
            {
                    UnityEngine.Vector3 val_25 = UnityEngine.Vector3.up;
            }
            
            label_28:
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_35, y = val_36, z = val_37});
            UnityEngine.Quaternion val_27 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, upwards:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
            val_30 = val_27.x;
            val_32 = val_27.z;
            val_33 = 0.Payload.gameObject;
            this.Print(Position:  new UnityEngine.Vector3() {x = val_35, y = val_36, z = val_31}, Rotation:  new UnityEngine.Quaternion() {x = val_30, y = val_27.y, z = val_32, w = val_27.w}, Surface:  0.Payload.transform, Layer:  val_33.layer);
        }
    
    }

}
