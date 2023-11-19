using UnityEngine;

namespace TzarGames.Common.Attributes
{
    public class Attribute : DatabaseRecord
    {
        // Fields
        [UnityEngine.SerializeField]
        private string _name;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private int id;
        
        // Properties
        public string Name { get; set; }
        public override int Id { get; set; }
        
        // Methods
        public Attribute()
        {
        
        }
        public string get_Name()
        {
            return (string)this._name;
        }
        public void set_Name(string value)
        {
            this._name = value;
        }
        public override int get_Id()
        {
            return (int)this.id;
        }
        public override void set_Id(int value)
        {
            this.id = value;
        }
        public override string ToString()
        {
            return (string)this._name;
        }
    
    }

}
