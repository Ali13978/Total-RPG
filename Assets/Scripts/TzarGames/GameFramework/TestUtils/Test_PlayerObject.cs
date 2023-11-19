using UnityEngine;

namespace TzarGames.GameFramework.TestUtils
{
    public class Test_PlayerObject : TzarBehaviour, IPlayerComponent
    {
        // Methods
        public Test_PlayerObject()
        {
        
        }
        public object GetPlayerData()
        {
            UnityEngine.Debug.Log(message:  0);
            return 0;
        }
        public byte[] GetPlayerDataAsBytes()
        {
            UnityEngine.Debug.Log(message:  0);
            return 0;
        }
        public void Respawn(UnityEngine.Vector3 spawnPosition, UnityEngine.Quaternion spawnRotation)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Respawn ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = spawnPosition;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " rotation: ";
            typeof(System.Object[]).__il2cppRuntimeField_38 = spawnRotation;
            string val_1 = +0;
            UnityEngine.Debug.Log(message:  0);
        }
        public void SetActive(bool active)
        {
            bool val_1 = active;
            string val_2 = 0 + "SetActive ";
            UnityEngine.Debug.Log(message:  0);
        }
        public void SetPlayerData(object data)
        {
            UnityEngine.Debug.Log(message:  0);
        }
        public void SetPlayerDataFromBytes(byte[] data)
        {
            UnityEngine.Debug.Log(message:  0);
        }
        public void SetupForLocalOrClient(TzarGames.GameFramework.Player owner)
        {
            UnityEngine.Debug.Log(message:  0);
        }
        public void SetupForServer(TzarGames.GameFramework.Player owner)
        {
            UnityEngine.Debug.Log(message:  0);
        }
    
    }

}
