using UnityEngine;

namespace TzarGames.Common.Events
{
    [Serializable]
    public class TriggerEvent : UnityEvent<UnityEngine.Collider>
    {
        // Methods
        public TriggerEvent()
        {
        
        }
    
    }

}
