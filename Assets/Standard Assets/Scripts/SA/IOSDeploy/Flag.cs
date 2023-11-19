using UnityEngine;

namespace SA.IOSDeploy
{
    [Serializable]
    public class Flag
    {
        // Fields
        public bool IsOpen;
        public string Name;
        public SA.IOSDeploy.FlagType Type;
        
        // Methods
        public Flag()
        {
            this.IsOpen = true;
        }
    
    }

}
