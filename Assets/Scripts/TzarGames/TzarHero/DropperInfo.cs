using UnityEngine;

namespace TzarGames.TzarHero
{
    internal class DropperInfo : IDropperInfo
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private uint <ID>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private uint <Level>k__BackingField;
        
        // Properties
        public uint ID { get; set; }
        public uint Level { get; set; }
        
        // Methods
        public DropperInfo()
        {
        
        }
        public uint get_ID()
        {
            return (uint)this.<ID>k__BackingField;
        }
        public void set_ID(uint value)
        {
            this.<ID>k__BackingField = value;
        }
        public uint get_Level()
        {
            return (uint)this.<Level>k__BackingField;
        }
        public void set_Level(uint value)
        {
            this.<Level>k__BackingField = value;
        }
    
    }

}
