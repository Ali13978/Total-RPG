using UnityEngine;

namespace TzarGames.Common
{
    public abstract class CommonAsset : DatabaseRecord
    {
        // Fields
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private int id;
        [UnityEngine.SerializeField]
        private string _name;
        
        // Properties
        public override int Id { get; set; }
        public string Name { get; }
        
        // Methods
        protected CommonAsset()
        {
            this._name = "Unknown asset";
        }
        public override int get_Id()
        {
            return (int)this.id;
        }
        public override void set_Id(int value)
        {
            this.id = value;
        }
        public string get_Name()
        {
            return (string)this._name;
        }
    
    }

}
