using UnityEngine;

namespace TzarGames.Endless
{
    [Serializable]
    public class AdRewardItem
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Item item;
        [UnityEngine.RangeAttribute]
        [UnityEngine.SerializeField]
        private float chancePercent;
        
        // Properties
        public TzarGames.GameFramework.Item Item { get; }
        public float ChancePercent { get; }
        
        // Methods
        public AdRewardItem()
        {
        
        }
        public TzarGames.GameFramework.Item get_Item()
        {
            return (TzarGames.GameFramework.Item)this.item;
        }
        public float get_ChancePercent()
        {
            return (float)this.chancePercent;
        }
    
    }

}
