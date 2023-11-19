using UnityEngine;

namespace TzarGames.Endless
{
    [Serializable]
    public class EndlessBagSerializationInfo : InventoryBagSerializableInfo<TzarGames.Endless.EndlessItemInstanceSerializationInfo, TzarGames.Endless.EndlessConsumableItemInstanceSerializationInfo>
    {
        // Methods
        public EndlessBagSerializationInfo(string bagName)
        {
            mem[1152921510660585072] = bagName;
        }
    
    }

}
