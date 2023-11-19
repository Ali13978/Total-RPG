using UnityEngine;

namespace TzarGames.GameFramework
{
    public class UPrimitiveComponent : Component
    {
        // Fields
        public TzarGames.GameFramework.EComponentMobilityType Mobility;
        public UnityEngine.Vector3 Componentvelocity;
        
        // Methods
        public UPrimitiveComponent()
        {
            this.Mobility = 2;
        }
        public bool IsSimulatingPhysics()
        {
            return false;
        }
        public UnityEngine.Vector3 GetComponentLocation()
        {
            return UnityEngine.Vector3.zero;
        }
        public void SetWorldLocation(UnityEngine.Vector3 pos, bool unknownParameter)
        {
        
        }
    
    }

}
