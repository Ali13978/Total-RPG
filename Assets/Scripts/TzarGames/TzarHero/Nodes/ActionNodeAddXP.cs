using UnityEngine;

namespace TzarGames.TzarHero.Nodes
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class ActionNodeAddXP : ActionNode
    {
        // Fields
        [UnityEngine.SerializeField]
        private int xpAmount;
        private TzarGames.TzarHero.TH_Character character;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot inputGameObjectSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot inputXpAmountSlot;
        
        // Methods
        public ActionNodeAddXP()
        {
        
        }
        protected override void Init()
        {
            this.Init();
            this.inputGameObjectSlot = this.AddVariableInputSlot(slotName:  "Character");
            this.inputXpAmountSlot = this.AddVariableInputSlot(slotName:  "XP amount");
        }
        public override void OnImpulse(TzarGames.Common.NodeSlot slot)
        {
            this.OnImpulse(slot:  slot);
            this.character.ChangeXPBy(amount:  this.xpAmount);
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
            
            if(var == null)
            {
                    return;
            }
            
            if(((UnityEngine.Object.op_Equality(x:  0, y:  slot)) ^ 1) == true)
            {
                    return;
            }
            
            if(null != null)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            this.xpAmount = null;
            return;
            label_7:
            this.character = var.GetComponent<TzarGames.TzarHero.TH_Character>();
        }
    
    }

}
