using UnityEngine;

namespace TzarGames.TzarHero.Nodes
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class ActionNodeAddItemToInventory : ActionNode
    {
        // Fields
        private TzarGames.TzarHero.TH_Character character;
        private TzarGames.GameFramework.ItemInstance itemInstance;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot inputGameObjectSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot inputItemInstanceSlot;
        
        // Methods
        public ActionNodeAddItemToInventory()
        {
        
        }
        protected override void Init()
        {
            this.Init();
            this.inputGameObjectSlot = this.AddVariableInputSlot(slotName:  "Character");
            this.inputItemInstanceSlot = this.AddVariableInputSlot(slotName:  "Item instance");
        }
        public override void OnImpulse(TzarGames.Common.NodeSlot slot)
        {
            this.OnImpulse(slot:  slot);
            this.character.TemplateInstance.Inventory.DefaultBag.AddNonconsumableItem(itemInstance:  this.itemInstance);
            this.DefaultImpulse();
        }
        public override void OnVariableImpulse(object var, TzarGames.Common.ScriptViz.SvNodeSlot slot)
        {
            this.OnVariableImpulse(var:  var, slot:  slot);
            if(0 == slot)
            {
                    if(var != null)
            {
                    if(null == null)
            {
                goto label_7;
            }
            
            }
            
                this.character = 0;
                return;
            }
            
            if(0 != slot)
            {
                    return;
            }
            
            if(var == null)
            {
                goto label_12;
            }
            
            this.itemInstance = var;
            return;
            label_7:
            this.character = var.GetComponent<TzarGames.TzarHero.TH_Character>();
            return;
            label_12:
            this.itemInstance = 0;
        }
    
    }

}
