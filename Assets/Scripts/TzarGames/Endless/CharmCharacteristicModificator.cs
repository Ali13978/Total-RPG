using UnityEngine;

namespace TzarGames.Endless
{
    public class CharmCharacteristicModificator : CharacteristicModificator
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private object <Charm>k__BackingField;
        
        // Properties
        public object Charm { get; set; }
        
        // Methods
        public CharmCharacteristicModificator()
        {
        
        }
        public object get_Charm()
        {
            return (object)this.<Charm>k__BackingField;
        }
        public void set_Charm(object value)
        {
            this.<Charm>k__BackingField = value;
        }
    
    }

}
