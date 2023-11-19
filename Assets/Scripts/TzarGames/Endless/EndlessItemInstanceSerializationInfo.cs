using UnityEngine;

namespace TzarGames.Endless
{
    [Serializable]
    public class EndlessItemInstanceSerializationInfo : NonConsumableItemInstanceSerializationInfo
    {
        // Methods
        public EndlessItemInstanceSerializationInfo()
        {
        
        }
        public EndlessItemInstanceSerializationInfo(int itemID, string instanceID)
        {
            mem[1152921510660239864] = instanceID;
            mem[1152921510660239856] = itemID;
        }
    
    }

}
