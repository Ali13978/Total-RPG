using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class VariableNodeRuntimeObject : VariableNode
    {
        // Fields
        public object Object;
        
        // Properties
        protected override object Value { get; set; }
        
        // Methods
        public VariableNodeRuntimeObject()
        {
        
        }
        protected override object get_Value()
        {
            return (object)this.Object;
        }
        protected override void set_Value(object value)
        {
            this.Object = value;
        }
    
    }

}
