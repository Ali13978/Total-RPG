using UnityEngine;

namespace TzarGames.TzarHero.Nodes
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class ActionNodeActivateItem : ActionNode
    {
        // Fields
        private TzarGames.TzarHero.TH_Character character;
        private TzarGames.GameFramework.ItemInstance itemInstance;
        [UnityEngine.SerializeField]
        private bool active;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot inputGameObjectSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot inputItemInstanceSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot inputActiveStateSlot;
        
        // Methods
        public ActionNodeActivateItem()
        {
            this.active = true;
        }
        protected override void Init()
        {
            this.Init();
            this.inputGameObjectSlot = this.AddVariableInputSlot(slotName:  "Character");
            this.inputItemInstanceSlot = this.AddVariableInputSlot(slotName:  "Item instance");
            this.inputActiveStateSlot = this.AddVariableInputSlot(slotName:  "Active");
        }
        public override void OnImpulse(TzarGames.Common.NodeSlot slot)
        {
            this.OnImpulse(slot:  slot);
            if(this.character.TemplateInstance != null)
            {
                    TzarGames.TzarHero.TH_CharacterTemplate val_2 = this.character.TemplateInstance;
                var val_3 = (this.active == true) ? 1 : 0;
            }
            
            this.DefaultImpulse();
        }
        public override void OnVariableImpulse(object var, TzarGames.Common.ScriptViz.SvNodeSlot slot)
        {
            TzarGames.Common.ScriptViz.SvNodeSlot val_8 = slot;
            this.OnVariableImpulse(var:  var, slot:  val_8 = slot);
            if(0 == val_8)
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
            
            if(0 != val_8)
            {
                goto label_11;
            }
            
            if(var == null)
            {
                goto label_12;
            }
            
            this.itemInstance = var;
            return;
            label_11:
            if(0 != val_8)
            {
                    return;
            }
            
            val_8 = null;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            this.active = null;
            return;
            label_7:
            this.character = var.GetComponent<TzarGames.TzarHero.TH_Character>();
            return;
            label_12:
            this.itemInstance = 0;
        }
    
    }

}
