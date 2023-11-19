using UnityEngine;

namespace TzarGames.Endless.CloudSaveSystem
{
    internal class DefaultReadResult : ICloudSaveReadResult
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <Success>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private byte[] <Data>k__BackingField;
        
        // Properties
        public bool Success { get; set; }
        public byte[] Data { get; set; }
        
        // Methods
        public DefaultReadResult()
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
        public byte[] get_Data()
        {
            return (System.Byte[])this.<Data>k__BackingField;
        }
        public void set_Data(byte[] value)
        {
            this.<Data>k__BackingField = value;
        }
    
    }

}
