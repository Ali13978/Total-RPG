using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class VariableNodeObject : VariableNode
    {
        // Fields
        [UnityEngine.SerializeField]
        public UnityEngine.Object Object;
        
        // Properties
        protected override object Value { get; set; }
        
        // Methods
        public VariableNodeObject()
        {
        
        }
        protected override object get_Value()
        {
            return (object)this.Object;
        }
        protected override void set_Value(object value)
        {
            var val_2 = 0;
            this.Object = ;
        }
    
    }

}
