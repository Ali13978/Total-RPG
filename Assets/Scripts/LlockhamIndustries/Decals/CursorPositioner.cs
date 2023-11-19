using UnityEngine;

namespace LlockhamIndustries.Decals
{
    public class CursorPositioner : Positioner
    {
        // Fields
        public UnityEngine.Camera projectionCamera;
        
        // Methods
        public CursorPositioner()
        {
            UnityEngine.LayerMask val_1 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
            mem[1152921511817780656] = val_1.m_Mask;
            this = new UnityEngine.MonoBehaviour();
        }
        protected override void Start()
        {
            if(0 == this.projectionCamera)
            {
                    this.projectionCamera = UnityEngine.Camera.main;
            }
            
            this.Start();
        }
        private void LateUpdate()
        {
            float val_5;
            float val_6;
            UnityEngine.Vector3 val_1 = UnityEngine.Input.mousePosition;
            UnityEngine.Ray val_2 = this.projectionCamera.ScreenPointToRay(position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_4 = this.projectionCamera.transform.up;
            this.Reproject(Ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_6, y = val_6, z = val_6}, m_Direction = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_5}}, CastLength:  Infinityf, ReferenceUp:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        }
    
    }

}
