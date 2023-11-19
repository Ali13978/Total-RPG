using UnityEngine;

namespace TzarGames.Common.Events
{
    [Serializable]
    public class CollisionEvent : UnityEvent<UnityEngine.Collision>
    {
        // Methods
        public CollisionEvent()
        {
        
        }
    
    }

}
