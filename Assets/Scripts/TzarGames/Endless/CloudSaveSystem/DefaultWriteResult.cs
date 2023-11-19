using UnityEngine;

namespace TzarGames.Endless.CloudSaveSystem
{
    internal class DefaultWriteResult : ICloudSaveWriteResult
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <Success>k__BackingField;
        
        // Properties
        public bool Success { get; set; }
        
        // Methods
        public DefaultWriteResult()
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
    
    }

}
