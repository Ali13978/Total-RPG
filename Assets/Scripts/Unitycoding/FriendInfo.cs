using UnityEngine;

namespace Unitycoding
{
    public class FriendInfo
    {
        // Fields
        protected string m_Name;
        protected bool m_Online;
        
        // Properties
        public string Name { get; }
        public bool Online { get; set; }
        
        // Methods
        public FriendInfo(string name)
        {
            this.m_Name = name;
        }
        public string get_Name()
        {
            return (string)this.m_Name;
        }
        public bool get_Online()
        {
            return (bool)this.m_Online;
        }
        public void set_Online(bool value)
        {
            this.m_Online = value;
        }
    
    }

}
