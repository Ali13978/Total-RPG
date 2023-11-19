using UnityEngine;

namespace TzarGames.GameFramework
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class ItemAnalyticsEventTracker : CustomAnalyticsEventTracker
    {
        // Fields
        private const string item_name_key = "item_name";
        private const string item_id_key = "item_id";
        
        // Methods
        public ItemAnalyticsEventTracker()
        {
        
        }
        public void SendDefaultEventWithItemInstance(TzarGames.GameFramework.ItemInstance itemInstance)
        {
            if(0 != itemInstance.itemTemplate)
            {
                    itemInstance = itemInstance.itemTemplate.itemName;
                Add(key:  "item_name", value:  itemInstance);
            }
            
            this.SendEvent(customEvent:  this.DefaultEvent, paramaters:  new System.Collections.Generic.Dictionary<System.String, System.Object>());
        }
        public void SendDefaultEventWithItem(TzarGames.GameFramework.Item item)
        {
            Add(key:  "item_name", value:  item.itemName);
            Add(key:  "item_id", value:  item);
            this.SendEvent(customEvent:  this.DefaultEvent, paramaters:  new System.Collections.Generic.Dictionary<System.String, System.Object>());
        }
    
    }

}
