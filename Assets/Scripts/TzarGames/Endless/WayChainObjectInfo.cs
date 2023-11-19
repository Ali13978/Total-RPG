using UnityEngine;

namespace TzarGames.Endless
{
    public class WayChainObjectInfo
    {
        // Fields
        public UnityEngine.Object ChainObject;
        public TzarGames.Endless.ChainObjectType ObjectType;
        
        // Methods
        public WayChainObjectInfo(UnityEngine.Object obj, TzarGames.Endless.ChainObjectType type)
        {
            this.ObjectType = type;
            this.ChainObject = obj;
        }
    
    }

}
