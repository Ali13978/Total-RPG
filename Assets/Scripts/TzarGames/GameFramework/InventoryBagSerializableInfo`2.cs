using UnityEngine;

namespace TzarGames.GameFramework
{
    [Serializable]
    public class InventoryBagSerializableInfo<T, K>
    {
        // Fields
        public string BagName;
        public System.Collections.Generic.List<T> NonConsumables;
        public System.Collections.Generic.List<K> Consumables;
        
        // Methods
        public InventoryBagSerializableInfo<T, K>()
        {
            mem[1152921511345647608] = __RuntimeMethodHiddenParam + 24 + 168;
            mem[1152921511345647616] = __RuntimeMethodHiddenParam + 24 + 168 + 16;
            if(this != null)
            {
                    return;
            }
        
        }
    
    }

}
