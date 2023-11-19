using UnityEngine;

namespace TzarGames.Endless.CloudSaveSystem
{
    internal class DefaultSaveGameListResult : ICloudGetSaveGameListResult
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <Success>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.Endless.CloudSaveSystem.ICloudSaveGameFile[] <Files>k__BackingField;
        
        // Properties
        public bool Success { get; set; }
        public TzarGames.Endless.CloudSaveSystem.ICloudSaveGameFile[] Files { get; set; }
        
        // Methods
        public DefaultSaveGameListResult()
        {
        
        }
        public bool get_Success()
        {
            return (bool)this.<Success>k__BackingField;
        }
        public void set_Success(bool value)
        {
            this.<Success>k__BackingField = value;
        }
        public TzarGames.Endless.CloudSaveSystem.ICloudSaveGameFile[] get_Files()
        {
            return (TzarGames.Endless.CloudSaveSystem.ICloudSaveGameFile[])this.<Files>k__BackingField;
        }
        public void set_Files(TzarGames.Endless.CloudSaveSystem.ICloudSaveGameFile[] value)
        {
            this.<Files>k__BackingField = value;
        }
    
    }

}
