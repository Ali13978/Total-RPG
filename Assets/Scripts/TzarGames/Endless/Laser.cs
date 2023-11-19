using UnityEngine;

namespace TzarGames.Endless
{
    public class Laser : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private float traceDistance;
        [UnityEngine.SerializeField]
        private UnityEngine.LayerMask tracelayers;
        private TzarGames.TzarHero.TH_Character touchingCharacter;
        private UnityEngine.Transform cachedTransform;
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.DamageInfluenceBehaviour damageInfluence;
        
        // Properties
        public float TraceDistance { get; set; }
        
        // Methods
        public Laser()
        {
            this.traceDistance = 20f;
        }
        public float get_TraceDistance()
        {
            return (float)this.traceDistance;
        }
        public void set_TraceDistance(float value)
        {
            this.traceDistance = value;
        }
        private void Start()
        {
            this.cachedTransform = this.transform;
        }
        private void Update()
        {
            TzarGames.TzarHero.TH_Character val_13;
            UnityEngine.Object val_14;
            UnityEngine.Object val_15;
            UnityEngine.Vector3 val_1 = this.cachedTransform.position;
            UnityEngine.Vector3 val_2 = this.cachedTransform.forward;
            int val_3 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask());
            if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, direction:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3(), m_Normal = new UnityEngine.Vector3(), m_UV = new UnityEngine.Vector2()}, maxDistance:  this.traceDistance, layerMask:  1814812800)) == false)
            {
                goto label_3;
            }
            
            TzarGames.TzarHero.TH_Character val_6 = 0.Payload.GetComponent<TzarGames.TzarHero.TH_Character>();
            val_13 = this.touchingCharacter;
            if(0 != val_6)
            {
                goto label_7;
            }
            
            val_14 = 0;
            val_15 = val_13;
            goto label_10;
            label_3:
            val_14 = 0;
            val_15 = this.touchingCharacter;
            label_10:
            if(val_14 == val_15)
            {
                    return;
            }
            
            val_13 = this.touchingCharacter;
            this.damageInfluence.RemoveFromCharacter(character:  val_13);
            this.touchingCharacter = 0;
            return;
            label_7:
            if(0 != val_13)
            {
                    if(0 != this.touchingCharacter)
            {
                    this.damageInfluence.RemoveFromCharacter(character:  this.touchingCharacter);
            }
            
            }
            
            val_13 = this.damageInfluence;
            this.touchingCharacter = val_6;
            val_13.ApplyToCharacter(character:  val_6);
        }
        private void OnDestroy()
        {
            if(0 == this.touchingCharacter)
            {
                    return;
            }
            
            this.damageInfluence.RemoveFromCharacter(character:  this.touchingCharacter);
        }
        private void OnDrawGizmos()
        {
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Vector3 val_2 = val_1.position;
            UnityEngine.Vector3 val_3 = val_1.position;
            UnityEngine.Vector3 val_4 = val_1.forward;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  this.traceDistance);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Color val_7 = UnityEngine.Color.blue;
            UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, end:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, color:  new UnityEngine.Color() {r = val_7.r, g = val_7.b, a = val_2.y});
        }
    
    }

}
