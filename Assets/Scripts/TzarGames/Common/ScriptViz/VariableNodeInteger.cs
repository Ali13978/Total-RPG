using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class VariableNodeInteger : VariableNode
    {
        // Fields
        [UnityEngine.SerializeField]
        private int intValue;
        
        // Properties
        protected override object Value { get; set; }
        
        // Methods
        public VariableNodeInteger()
        {
        
        }
        protected override object get_Value()
        {
            return (object)this.intValue;
        }
        protected override void set_Value(object value)
        {
            this.intValue = System.Convert.ToInt32(value:  0);
        }
    
    }

}
