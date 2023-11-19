using UnityEngine;

namespace TzarGames.Common
{
    [Serializable]
    internal class SoundGroup
    {
        // Fields
        public string name;
        public UnityEngine.AudioClip[] clips;
        
        // Methods
        public SoundGroup()
        {
            null = null;
            this.name = System.String.Empty;
        }
    
    }

}
