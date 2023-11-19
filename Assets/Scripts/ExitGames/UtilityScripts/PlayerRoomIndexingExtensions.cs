using UnityEngine;

namespace ExitGames.UtilityScripts
{
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static class PlayerRoomIndexingExtensions
    {
        // Methods
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static int GetRoomIndex(PhotonPlayer player)
        {
            if(0 == ExitGames.UtilityScripts.PlayerRoomIndexing.RoomPlayerIndexedProp)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return 0;
            }
            
            if(ExitGames.UtilityScripts.PlayerRoomIndexing.RoomPlayerIndexedProp != null)
            {
                    return ExitGames.UtilityScripts.PlayerRoomIndexing.RoomPlayerIndexedProp.GetRoomIndex(player:  X1);
            }
            
            return ExitGames.UtilityScripts.PlayerRoomIndexing.RoomPlayerIndexedProp.GetRoomIndex(player:  X1);
        }
    
    }

}
