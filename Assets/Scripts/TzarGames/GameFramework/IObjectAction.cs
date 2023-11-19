using UnityEngine;

namespace TzarGames.GameFramework
{
    public interface IObjectAction
    {
        // Properties
        public abstract UnityEngine.Sprite Icon { get; }
        public abstract TzarGames.GameFramework.ActionObjectBehaviour Behaviour { get; }
        public abstract bool UseOnce { get; }
        
        // Methods
        public abstract UnityEngine.Sprite get_Icon(); // 0
        public abstract TzarGames.GameFramework.ActionObjectBehaviour get_Behaviour(); // 0
        public abstract bool get_UseOnce(); // 0
    
    }

}
