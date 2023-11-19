using UnityEngine;

namespace TzarGames.GameFramework.TestUtils
{
    public class Test_NetworkGameManager : GameManager
    {
        // Methods
        public Test_NetworkGameManager()
        {
        
        }
        public override void GetPlayerData(TzarGames.GameFramework.Player player, System.Action<byte[]> getDataMethod)
        {
            UnityEngine.Debug.Log(message:  0);
            object val_1 = new System.Object();
            typeof(TzarGames.GameFramework.TestUtils.PlayerData).__il2cppRuntimeField_10 = 0 + "Message from player ";
            string val_3 = UnityEngine.JsonUtility.ToJson(obj:  0);
            getDataMethod.Invoke(obj:  TzarGames.Common.Utils.GetBytesFromString(str:  0));
        }
        public override void SetPlayerData(TzarGames.GameFramework.Player player, byte[] data, System.Action completeCallback)
        {
            UnityEngine.Debug.Log(message:  0);
            completeCallback.Invoke();
        }
    
    }

}
