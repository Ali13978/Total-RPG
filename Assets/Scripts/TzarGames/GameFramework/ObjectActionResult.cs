using UnityEngine;

namespace TzarGames.GameFramework
{
    internal class ObjectActionResult : IObjectActionResult
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <Success>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private string <Message>k__BackingField;
        
        // Properties
        public bool Success { get; set; }
        public string Message { get; set; }
        
        // Methods
        public ObjectActionResult()
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
        public string get_Message()
        {
            return (string)this.<Message>k__BackingField;
        }
        public void set_Message(string value)
        {
            this.<Message>k__BackingField = value;
        }
    
    }

}
