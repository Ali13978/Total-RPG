using UnityEngine;

namespace TzarGames.GameFramework
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class ItemComponent : DatabaseRecord
    {
        // Fields
        [UnityEngine.HideInInspector]
        [UnityEngine.SerializeField]
        private int id;
        
        // Properties
        public override int Id { get; set; }
        
        // Methods
        public ItemComponent()
        {
            val_1 = new UnityEngine.ScriptableObject();
        }
        public override int get_Id()
        {
            return (int)this.id;
        }
        public override void set_Id(int value)
        {
            this.id = value;
        }
    
    }

}
