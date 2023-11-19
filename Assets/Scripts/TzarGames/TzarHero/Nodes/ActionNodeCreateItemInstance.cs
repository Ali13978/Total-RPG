using UnityEngine;

namespace TzarGames.TzarHero.Nodes
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class ActionNodeCreateItemInstance : ActionNode
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Item item;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot valueOutSlot;
        
        // Methods
        public ActionNodeCreateItemInstance()
        {
        
        }
        protected override void Init()
        {
            this.Init();
            this.valueOutSlot = this.AddVariableOutputSlot(slotName:  "Created item");
        }
        public override void OnImpulse(TzarGames.Common.NodeSlot slot)
        {
            TzarGames.GameFramework.Item val_2;
            if(null != 0)
            {
                    GenerateID();
                val_2 = this.item;
            }
            else
            {
                    GenerateID();
                val_2 = this.item;
            }
            
            CreateTemplateInstance(item:  val_2);
            this.valueOutSlot.VariableImpulse(variable:  new TzarGames.GameFramework.ItemInstance());
            this.DefaultImpulse();
        }
    
    }

}
