using UnityEngine;

namespace Unitycoding
{
    public interface INameable
    {
        // Properties
        public abstract string Name { get; set; }
        
        // Methods
        public abstract string get_Name(); // 0
        public abstract void set_Name(string value); // 0
    
    }

}
