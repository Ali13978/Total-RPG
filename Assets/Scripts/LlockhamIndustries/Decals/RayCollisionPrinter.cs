using UnityEngine;

namespace LlockhamIndustries.Decals
{
    public class RayCollisionPrinter : Printer
    {
        // Fields
        public LlockhamIndustries.Decals.CollisionCondition condition;
        public float conditionTime;
        public UnityEngine.LayerMask layers;
        public LlockhamIndustries.Decals.CastMethod method;
        public UnityEngine.Transform castCenter;
        public UnityEngine.Vector2 castDimensions;
        public UnityEngine.Vector3 positionOffset;
        public UnityEngine.Vector3 rotationOffset;
        public float castLength;
        public UnityEngine.QueryTriggerInteraction hitTriggers;
        private float timeElapsed;
        private bool delayPrinted;
        private LlockhamIndustries.Decals.CollisionData collision;
        
        // Methods
        public RayCollisionPrinter()
        {
            this.conditionTime = 1f;
            this.castLength = 1f;
        }
        private void FixedUpdate()
        {
            this.CastCollision(deltaTime:  UnityEngine.Time.fixedDeltaTime);
        }
        private void CastCollision(float deltaTime)
        {
            UnityEngine.Transform val_25;
            var val_26;
            float val_27;
            float val_28;
            float val_29;
            float val_30;
            float val_31;
            float val_32;
            float val_33;
            float val_34;
            float val_35;
            float val_36;
            float val_37;
            float val_38;
            float val_39;
            if(0 != this.castCenter)
            {
                    val_25 = this.castCenter;
            }
            else
            {
                    val_25 = this.transform;
            }
            
            UnityEngine.Quaternion val_3 = val_25.rotation;
            val_26 = 1152921504719839232;
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.rotationOffset, y = V13.16B, z = V12.16B});
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, rhs:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w});
            val_27 = val_5.w;
            UnityEngine.Vector3 val_6 = val_25.position;
            UnityEngine.Vector3 val_7 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_27}, point:  new UnityEngine.Vector3() {x = this.positionOffset, y = val_4.y, z = val_4.z});
            val_28 = val_6.x;
            val_29 = val_6.y;
            val_30 = val_6.z;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_28, y = val_29, z = val_30}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            val_31 = val_8.x;
            val_32 = val_8.y;
            val_33 = val_8.z;
            if(this.method == 1)
            {
                    UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
                UnityEngine.Vector3 val_12 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_27}, point:  new UnityEngine.Vector3() {x = UnityEngine.Random.Range(min:  -this.castDimensions, max:  this.castDimensions), y = UnityEngine.Random.Range(min:  -this.castDimensions, max:  this.castDimensions), z = val_9.z});
                val_28 = val_31;
                val_29 = val_32;
                val_30 = val_33;
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_28, y = val_29, z = val_30}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
                val_31 = val_13.x;
                val_32 = val_13.y;
                val_33 = val_13.z;
            }
            
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.forward;
            val_34 = val_14.z;
            UnityEngine.Vector3 val_15 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_27}, point:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_34});
            val_35 = val_32;
            val_36 = this.castLength;
            if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3(), m_Direction = new UnityEngine.Vector3()}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  val_36, layerMask:  -1373083168, queryTriggerInteraction:  this.layers.value)) == false)
            {
                goto label_20;
            }
            
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_36, y = val_35, z = val_33});
            val_32 = val_18.z;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_20 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_27}, point:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
            val_37 = val_20.x;
            val_38 = val_20.z;
            UnityEngine.Quaternion val_21 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_32}, upwards:  new UnityEngine.Vector3() {x = val_37, y = val_20.y, z = val_38});
            val_34 = val_21.y;
            val_27 = val_21.w;
            val_26 = 0.Payload.gameObject;
            int val_24 = val_26.layer;
            this.collision = val_36;
            mem[1152921511823710748] = val_35;
            mem[1152921511823710752] = val_33;
            mem[1152921511823710756] = val_21.x;
            mem[1152921511823710760] = val_34;
            mem[1152921511823710764] = val_21.z;
            mem[1152921511823710768] = val_27;
            mem[1152921511823710772] = 0;
            mem[1152921511823710776] = ;
            mem[1152921511823710784] = val_24;
            mem[1152921511823710788] = 0;
            if(this.condition == 2)
            {
                    val_37 = val_21.x;
                val_38 = val_21.z;
                this.Print(Position:  new UnityEngine.Vector3() {x = val_36, y = val_35, z = val_33}, Rotation:  new UnityEngine.Quaternion() {x = val_37, y = val_34, z = val_38, w = val_27}, Surface:  0, Layer:  val_24);
            }
            
            val_39 = this.timeElapsed;
            if(val_39 != 0f)
            {
                goto label_28;
            }
            
            val_36 = deltaTime;
            if(this.condition != 0)
            {
                goto label_30;
            }
            
            this.Print(Position:  new UnityEngine.Vector3() {x = this.collision, y = val_35, z = val_33}, Rotation:  new UnityEngine.Quaternion() {x = val_37, y = val_34, z = val_38, w = val_27}, Surface:  0, Layer:  val_24);
            val_39 = this.timeElapsed;
            goto label_30;
            label_20:
            if(this.timeElapsed <= 0f)
            {
                goto label_34;
            }
            
            LlockhamIndustries.Decals.CollisionCondition val_25 = this.condition;
            if(val_25 == 3)
            {
                goto label_32;
            }
            
            if(val_25 != 1)
            {
                goto label_34;
            }
            
            val_25 = val_25 >> 32;
            val_35 = val_25;
            if(this.timeElapsed >= 0)
            {
                goto label_34;
            }
            
            label_32:
            this.Print(Position:  new UnityEngine.Vector3() {x = this.collision, y = val_35, z = val_33}, Rotation:  new UnityEngine.Quaternion() {x = val_15.x, y = val_15.y, z = val_15.z, w = val_34}, Surface:  0, Layer:  -1373083168);
            label_34:
            this.timeElapsed = 0f;
            this.delayPrinted = false;
            return;
            label_28:
            val_36 = deltaTime;
            label_30:
            LlockhamIndustries.Decals.CollisionCondition val_26 = this.condition;
            val_39 = val_39 + val_36;
            this.timeElapsed = val_39;
            if(val_26 != 1)
            {
                    return;
            }
            
            val_26 = val_26 >> 32;
            if(val_39 < val_26)
            {
                    return;
            }
            
            if(this.delayPrinted == true)
            {
                    return;
            }
            
            this.Print(Position:  new UnityEngine.Vector3() {x = this.collision, y = val_26, z = val_33}, Rotation:  new UnityEngine.Quaternion() {x = val_37, y = val_34, z = val_38, w = val_27}, Surface:  0, Layer:  val_24);
            this.delayPrinted = true;
        }
        private void PrintCollision(LlockhamIndustries.Decals.CollisionData collision)
        {
            this.Print(Position:  new UnityEngine.Vector3() {x = collision.position.x, y = collision.position.y, z = collision.position.z}, Rotation:  new UnityEngine.Quaternion() {x = collision.rotation.x, y = collision.rotation.y, z = collision.rotation.z, w = collision.rotation.w}, Surface:  collision.surface, Layer:  collision.layer);
        }
        private void OnDrawGizmosSelected()
        {
            UnityEngine.Transform val_33;
            float val_34;
            float val_35;
            float val_36;
            float val_37;
            if(0 != this.castCenter)
            {
                    val_33 = this.castCenter;
            }
            else
            {
                    val_33 = this.transform;
            }
            
            UnityEngine.Quaternion val_3 = val_33.rotation;
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.rotationOffset, y = V13.16B, z = V12.16B});
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w}, rhs:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w});
            val_34 = val_5.y;
            UnityEngine.Vector3 val_6 = val_33.position;
            UnityEngine.Vector3 val_7 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_34, z = val_5.z, w = val_5.w}, point:  new UnityEngine.Vector3() {x = this.positionOffset, y = val_4.y, z = val_4.z});
            val_35 = val_7.y;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_35, z = val_7.z});
            val_36 = val_8.x;
            val_37 = val_8.y;
            UnityEngine.Color val_9 = UnityEngine.Color.white;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.a};
            if(this.method != 1)
            {
                    if(this.method != 0)
            {
                    return;
            }
            
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.forward;
                UnityEngine.Vector3 val_11 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_34, z = val_5.z, w = val_5.w}, point:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  this.castLength);
                UnityEngine.Gizmos.DrawRay(from:  new UnityEngine.Vector3() {x = val_36, y = val_37, z = val_8.z}, direction:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
                return;
            }
            
            UnityEngine.Vector3 val_13 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_34, z = val_5.z, w = val_5.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_36, y = val_37, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_16 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_34, z = val_5.z, w = val_5.w}, point:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, d:  this.castLength);
            UnityEngine.Gizmos.DrawRay(from:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, direction:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            UnityEngine.Vector3 val_18 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_34, z = val_5.z, w = val_5.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_36, y = val_37, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.forward;
            val_37 = val_5.z;
            UnityEngine.Vector3 val_21 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_34, z = val_5.z, w = val_5.w}, point:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, d:  this.castLength);
            UnityEngine.Gizmos.DrawRay(from:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, direction:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
            val_34 = val_34;
            UnityEngine.Vector3 val_23 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_34, z = val_37, w = val_5.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_36, y = val_37, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_26 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_34, z = val_37, w = val_5.w}, point:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, d:  this.castLength);
            UnityEngine.Gizmos.DrawRay(from:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, direction:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
            UnityEngine.Vector3 val_28 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_34, z = val_37, w = val_5.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_36, y = val_37, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
            val_35 = val_29.x;
            val_36 = val_29.z;
            UnityEngine.Vector3 val_30 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_31 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_34, z = val_37, w = val_5.w}, point:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z});
            UnityEngine.Vector3 val_32 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, d:  this.castLength);
            UnityEngine.Gizmos.DrawRay(from:  new UnityEngine.Vector3() {x = val_35, y = val_29.y, z = val_36}, direction:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z});
        }
    
    }

}
