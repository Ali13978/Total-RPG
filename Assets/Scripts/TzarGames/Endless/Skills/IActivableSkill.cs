using UnityEngine;

namespace TzarGames.Endless.Skills
{
    public interface IActivableSkill
    {
        // Properties
        public abstract bool IsActive { get; }
        public abstract UnityEngine.Sprite ActivatedIcon { get; }
        
        // Methods
        public abstract bool get_IsActive(); // 0
        public abstract UnityEngine.Sprite get_ActivatedIcon(); // 0
    
    }

}
