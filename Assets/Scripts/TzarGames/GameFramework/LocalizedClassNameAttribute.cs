using UnityEngine;

namespace TzarGames.GameFramework
{
    [System.AttributeUsageAttribute]
    public class LocalizedClassNameAttribute : Attribute
    {
        // Fields
        private static string _name;
        
        // Properties
        public string LocalizedName { get; }
        
        // Methods
        public LocalizedClassNameAttribute(string name)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            TzarGames.GameFramework.LocalizedClassNameAttribute._name = name;
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            TzarGames.GameFramework.LocalizedClassNameAttribute._name = "Empty localized class name";
        }
        public string get_LocalizedName()
        {
            null = null;
            return (string)TzarGames.GameFramework.LocalizedClassNameAttribute._name;
        }
        private static LocalizedClassNameAttribute()
        {
        
        }
    
    }

}
