using UnityEngine;

namespace TzarGames.GameFramework
{
    public class AnimatedIconItemComponent : ItemComponent
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Sprite[] sprites;
        [UnityEngine.SerializeField]
        private int fps;
        
        // Properties
        public UnityEngine.Sprite[] Sprites { get; }
        public int FPS { get; }
        
        // Methods
        public AnimatedIconItemComponent()
        {
            this.fps = 30;
        }
        public UnityEngine.Sprite[] get_Sprites()
        {
            return (UnityEngine.Sprite[])this.sprites;
        }
        public int get_FPS()
        {
            return (int)this.fps;
        }
    
    }

}
