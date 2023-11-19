using UnityEngine;

namespace TzarGames.GameFramework
{
    public interface IPlayerComponent
    {
        // Methods
        public abstract void SetupForServer(TzarGames.GameFramework.Player owner); // 0
        public abstract void SetupForLocalOrClient(TzarGames.GameFramework.Player owner); // 0
        public abstract void SetPlayerData(object data); // 0
        public abstract object GetPlayerData(); // 0
        public abstract byte[] GetPlayerDataAsBytes(); // 0
        public abstract void SetPlayerDataFromBytes(byte[] data); // 0
        public abstract void SetActive(bool active); // 0
        public abstract void Respawn(UnityEngine.Vector3 spawnPosition, UnityEngine.Quaternion spawnRotation); // 0
    
    }

}
