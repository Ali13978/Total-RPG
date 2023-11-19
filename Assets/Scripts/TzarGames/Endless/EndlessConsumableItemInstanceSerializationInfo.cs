using UnityEngine;

namespace TzarGames.Endless
{
    [Serializable]
    public class EndlessConsumableItemInstanceSerializationInfo : ConsumableItemInstanceSerializationInfo
    {
        // Methods
        public EndlessConsumableItemInstanceSerializationInfo()
        {
        
        }
        public EndlessConsumableItemInstanceSerializationInfo(int itemID, int count)
        {
            mem[1152921510660467952] = itemID;
            mem[1152921510660467956] = count;
        }
    
    }

}
