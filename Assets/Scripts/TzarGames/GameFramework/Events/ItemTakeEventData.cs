using UnityEngine;

namespace TzarGames.GameFramework.Events
{
    public class ItemTakeEventData : ITakeItemEvent
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.GameFramework.IItemReceiver <Receiver>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.GameFramework.IDropperInfo <Dropper>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.GameFramework.ItemInstance <ItemInstance>k__BackingField;
        
        // Properties
        public TzarGames.GameFramework.IItemReceiver Receiver { get; set; }
        public TzarGames.GameFramework.IDropperInfo Dropper { get; set; }
        public TzarGames.GameFramework.ItemInstance ItemInstance { get; set; }
        
        // Methods
        public ItemTakeEventData()
        {
        
        }
        public TzarGames.GameFramework.IItemReceiver get_Receiver()
        {
            return (TzarGames.GameFramework.IItemReceiver)this.<Receiver>k__BackingField;
        }
        public void set_Receiver(TzarGames.GameFramework.IItemReceiver value)
        {
            this.<Receiver>k__BackingField = value;
        }
        public TzarGames.GameFramework.IDropperInfo get_Dropper()
        {
            return (TzarGames.GameFramework.IDropperInfo)this.<Dropper>k__BackingField;
        }
        public void set_Dropper(TzarGames.GameFramework.IDropperInfo value)
        {
            this.<Dropper>k__BackingField = value;
        }
        public TzarGames.GameFramework.ItemInstance get_ItemInstance()
        {
            return (TzarGames.GameFramework.ItemInstance)this.<ItemInstance>k__BackingField;
        }
        public void set_ItemInstance(TzarGames.GameFramework.ItemInstance value)
        {
            this.<ItemInstance>k__BackingField = value;
        }
    
    }

}
