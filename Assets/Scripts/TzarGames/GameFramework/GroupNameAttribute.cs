using UnityEngine;

namespace TzarGames.GameFramework
{
    [System.AttributeUsageAttribute]
    public class GroupNameAttribute : Attribute
    {
        // Fields
        private static string _name;
        
        // Properties
        public string Name { get; }
        
        // Methods
        public GroupNameAttribute(string name)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            TzarGames.GameFramework.GroupNameAttribute._name = name;
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            TzarGames.GameFramework.GroupNameAttribute._name = "Empty group class name";
        }
        public string get_Name()
        {
            null = null;
            return (string)TzarGames.GameFramework.GroupNameAttribute._name;
        }
        private static GroupNameAttribute()
        {
        
        }
    
    }

}
