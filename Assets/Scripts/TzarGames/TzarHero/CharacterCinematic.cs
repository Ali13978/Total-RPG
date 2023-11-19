using UnityEngine;

namespace TzarGames.TzarHero
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class CharacterCinematic : CommonAsset
    {
        // Fields
        [UnityEngine.SerializeField]
        private string animationName;
        
        // Properties
        public string AnimationName { get; }
        
        // Methods
        public CharacterCinematic()
        {
        
        }
        public string get_AnimationName()
        {
            return (string)this.animationName;
        }
    
    }

}
