using UnityEngine;

namespace TzarGames.GameFramework
{
    public interface IDropperInfo
    {
        // Properties
        public abstract uint ID { get; }
        public abstract uint Level { get; }
        
        // Methods
        public abstract uint get_ID(); // 0
        public abstract uint get_Level(); // 0
    
    }

}
