using UnityEngine;

namespace SA.IOSDeploy
{
    [Serializable]
    public class Lib
    {
        // Fields
        public bool IsOpen;
        public SA.IOSDeploy.iOSLibrary Type;
        public bool IsOptional;
        
        // Properties
        public string Name { get; }
        
        // Methods
        public Lib(SA.IOSDeploy.iOSLibrary lib)
        {
            this.Type = lib;
        }
        public string get_Name()
        {
            return SA.IOSDeploy.ISD_LibHandler.stringValueOf(value:  this);
        }
    
    }

}
