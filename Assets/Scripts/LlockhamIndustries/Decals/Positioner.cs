using UnityEngine;

namespace LlockhamIndustries.Decals
{
    public abstract class Positioner : MonoBehaviour
    {
        // Fields
        public LlockhamIndustries.Decals.ProjectionRenderer projection;
        public UnityEngine.LayerMask layers;
        public bool alwaysVisible;
        private LlockhamIndustries.Decals.ProjectionRenderer proj;
        
        // Properties
        public LlockhamIndustries.Decals.ProjectionRenderer Active { get; }
        
        // Methods
        protected Positioner()
        {
            UnityEngine.LayerMask val_1 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
            this.layers = val_1;
        }
        public LlockhamIndustries.Decals.ProjectionRenderer get_Active()
        {
            return (LlockhamIndustries.Decals.ProjectionRenderer)this.proj;
        }
        private void OnDisable()
        {
            if(0 == this.proj)
            {
                    return;
            }
            
            this.proj.gameObject.SetActive(value:  false);
        }
        protected virtual void Start()
        {
            if(0 != this.projection)
            {
                    UnityEngine.Transform val_5 = LlockhamIndustries.Decals.DynamicDecals.System.DefaultPool.Parent;
                LlockhamIndustries.Decals.ProjectionRenderer val_7 = UnityEngine.Object.Instantiate<TzarGames.Endless.UI.RewardItemUI>(original:  0, parent:  this.projection.gameObject).GetComponent<LlockhamIndustries.Decals.ProjectionRenderer>();
                this.proj = val_7;
                val_7.name = "Positioned Projection";
                return;
            }
            
            UnityEngine.Debug.LogWarning(message:  0);
        }
        protected void Reproject(UnityEngine.Ray Ray, float CastLength, UnityEngine.Vector3 ReferenceUp)
        {
            float val_10;
            float val_11;
            var val_12;
            val_10 = ReferenceUp.z;
            val_11 = ReferenceUp.x;
            val_12 = this;
            if(0 == this.proj)
            {
                    return;
            }
            
            int val_2 = this.layers.value;
            if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3(), m_Direction = new UnityEngine.Vector3()}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = Ray.m_Origin.x}, m_Normal = new UnityEngine.Vector3() {y = Ray.m_Direction.y}, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  CastLength, layerMask:  -1378038416)) != false)
            {
                    this.proj.gameObject.SetActive(value:  true);
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = CastLength, y = ReferenceUp.x, z = ReferenceUp.y});
                UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, upwards:  new UnityEngine.Vector3() {x = val_11, y = ReferenceUp.y, z = val_10});
                this.proj.transform.rotation = new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w};
                val_12 = this.proj.transform;
                val_10 = val_7.x;
                val_11 = val_7.z;
                val_12.position = new UnityEngine.Vector3() {x = val_10, y = val_7.y, z = val_11};
                return;
            }
            
            if(this.alwaysVisible == true)
            {
                    return;
            }
            
            val_12 = this.proj.gameObject;
            val_12.SetActive(value:  false);
        }
        private UnityEngine.Vector3 Divide(UnityEngine.Vector3 A, UnityEngine.Vector3 B)
        {
            A.x = A.x / B.x;
            A.y = A.y / B.y;
            A.z = A.z / B.z;
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
    
    }

}
