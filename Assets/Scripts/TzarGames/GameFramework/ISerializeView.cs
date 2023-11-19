using UnityEngine;

namespace TzarGames.GameFramework
{
    public interface ISerializeView
    {
        // Methods
        public abstract void OnSerializeEvent(TzarGames.GameFramework._IBitStream stream, TzarGames.GameFramework.INetworkMessageInfo messageInfo); // 0
    
    }

}
