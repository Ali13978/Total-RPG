using UnityEngine;

namespace TzarGames.Common
{
    internal class ConfigurationEntry
    {
        // Fields
        public string Name;
        public string Value;
        public TzarGames.Common.ParseTypes Type;
        public TzarGames.Common.ConfigurationEntry Parent;
        public System.Collections.Generic.List<TzarGames.Common.ConfigurationEntry> Entries;
        
        // Methods
        public ConfigurationEntry()
        {
            this.Type = 3;
            this.Entries = new System.Collections.Generic.List<TzarGames.Common.ConfigurationEntry>();
        }
    
    }

}
