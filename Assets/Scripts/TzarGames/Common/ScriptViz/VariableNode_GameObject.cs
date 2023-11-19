using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class VariableNode_GameObject : VariableNode
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject gameObject;
        
        // Properties
        protected override object Value { get; set; }
        
        // Methods
        public VariableNode_GameObject()
        {
        
        }
        protected override void Init()
        {
            this.Init();
        }
        protected override object get_Value()
        {
            return (object)this.gameObject;
        }
        protected override void set_Value(object value)
        {
            UnityEngine.GameObject val_2;
            if(value != null)
            {
                    var val_1 = (null == null) ? value : 0;
            }
            else
            {
                    val_2 = 0;
            }
            
            this.gameObject = val_2;
        }
    
    }

}
