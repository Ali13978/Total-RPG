using UnityEngine;

namespace TzarGames.GameFramework
{
    public abstract class DatabaseRecord : ScriptableObject
    {
        // Properties
        public abstract int Id { get; set; }
        
        // Methods
        protected DatabaseRecord()
        {
        
        }
        public abstract int get_Id(); // 0
        public abstract void set_Id(int value); // 0
    
    }

}
