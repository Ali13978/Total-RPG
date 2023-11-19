using UnityEngine;

namespace TzarGames.GameFramework
{
    [Serializable]
    internal class PerformedActionEvent : UnityEvent<TzarGames.GameFramework.ActionEventData>
    {
        // Methods
        public PerformedActionEvent()
        {
        
        }
    
    }

}
