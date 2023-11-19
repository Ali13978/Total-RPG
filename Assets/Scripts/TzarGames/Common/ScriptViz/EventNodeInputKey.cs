using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class EventNodeInputKey : EventNode
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.KeyCode keyCode;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot keyDownSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot keyUpSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot keySlot;
        
        // Methods
        public EventNodeInputKey()
        {
            this.keyCode = 119;
        }
        protected override void Init()
        {
            val_1.type = 2;
            this.keyDownSlot = this.addSlotOnRight(slotName:  "Key Down");
            val_2.type = 2;
            this.keyUpSlot = this.addSlotOnRight(slotName:  "Key Up");
            val_3.type = 2;
            this.keySlot = this.addSlotOnRight(slotName:  "Key");
        }
        public override void Update()
        {
            TzarGames.Common.ScriptViz.SvNodeSlot val_4;
            if((UnityEngine.Input.GetKeyDown(key:  0)) == false)
            {
                goto label_3;
            }
            
            val_4 = this.keyDownSlot;
            if(val_4 != null)
            {
                goto label_14;
            }
            
            goto label_10;
            label_3:
            if((UnityEngine.Input.GetKeyUp(key:  0)) == false)
            {
                goto label_8;
            }
            
            val_4 = this.keyUpSlot;
            if(val_4 != null)
            {
                goto label_14;
            }
            
            goto label_10;
            label_8:
            if((UnityEngine.Input.GetKey(key:  0)) == false)
            {
                    return;
            }
            
            val_4 = this.keySlot;
            if(val_4 != null)
            {
                goto label_14;
            }
            
            label_10:
            label_14:
            val_4.Impulse();
        }
    
    }

}
