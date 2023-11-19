using UnityEngine;

namespace TzarGames.Endless.CloudSaveSystem
{
    internal class DefaultSaveFile : ICloudSaveGameFile
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private string <Filename>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private string <Description>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.DateTime <Timestamp>k__BackingField;
        
        // Properties
        public string Filename { get; set; }
        public string Description { get; set; }
        public System.DateTime Timestamp { get; set; }
        
        // Methods
        public DefaultSaveFile()
        {
        
        }
        public string get_Filename()
        {
            return (string)this.<Filename>k__BackingField;
        }
        public void set_Filename(string value)
        {
            this.<Filename>k__BackingField = value;
        }
        public string get_Description()
        {
            return (string)this.<Description>k__BackingField;
        }
        public void set_Description(string value)
        {
            this.<Description>k__BackingField = value;
        }
        public System.DateTime get_Timestamp()
        {
            return new System.DateTime() {ticks = new System.TimeSpan() {_ticks = this.<Timestamp>k__BackingField}};
        }
        public void set_Timestamp(System.DateTime value)
        {
            this.<Timestamp>k__BackingField = value;
            mem[1152921510579540616] = value.kind;
        }
    
    }

}
