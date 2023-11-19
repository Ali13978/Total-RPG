using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    [UnityEngine.ExecuteInEditMode]
    public class CinemachineDollyCart : MonoBehaviour
    {
        // Fields
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachinePathBase m_Path;
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachineDollyCart.UpdateMethod m_UpdateMethod;
        [UnityEngine.TooltipAttribute]
        public Cinemachine.CinemachinePathBase.PositionUnits m_PositionUnits;
        [UnityEngine.TooltipAttribute]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute]
        public float m_Speed;
        [UnityEngine.TooltipAttribute]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute]
        public float m_Position;
        
        // Methods
        public CinemachineDollyCart()
        {
            this.m_PositionUnits = 1;
        }
        private void FixedUpdate()
        {
            if(this.m_UpdateMethod != 1)
            {
                    return;
            }
            
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.m_Speed * val_1;
            val_1 = this.m_Position + val_1;
            this.m_Position = val_1;
            this.SetCartPosition(distanceAlongPath:  val_1);
        }
        private void Update()
        {
            if(UnityEngine.Application.isPlaying != false)
            {
                    if(this.m_UpdateMethod != 0)
            {
                    return;
            }
            
                float val_3 = UnityEngine.Time.deltaTime;
                val_3 = this.m_Speed * val_3;
                val_3 = this.m_Position + val_3;
                this.m_Position = val_3;
            }
            
            this.SetCartPosition(distanceAlongPath:  val_3);
        }
        private void SetCartPosition(float distanceAlongPath)
        {
            float val_6;
            float val_8;
            if(0 == this.m_Path)
            {
                    return;
            }
            
            this.m_Position = distanceAlongPath;
            val_6 = this.m_Position;
            if(this.m_PositionUnits == 1)
            {
                    val_6 = this.m_Path.GetPathPositionFromDistance(distance:  val_6);
            }
            
            this.transform.position = new UnityEngine.Vector3() {x = val_6, y = V1.16B, z = V2.16B};
            val_8 = this.m_Position;
            if(this.m_PositionUnits == 1)
            {
                    val_8 = this.m_Path.GetPathPositionFromDistance(distance:  val_8);
            }
            
            this.transform.rotation = new UnityEngine.Quaternion() {x = val_8, y = V1.16B, z = V2.16B, w = V3.16B};
        }
    
    }

}
