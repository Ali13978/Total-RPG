using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class ActionNodeWait : ActionNode
    {
        // Fields
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot timeSlot;
        [UnityEngine.SerializeField]
        private float waitTime;
        private System.Collections.Generic.List<TzarGames.Common.ScriptViz.ActionNodeWait.WaitImpulseData> waitImpulses;
        
        // Methods
        public ActionNodeWait()
        {
            this.waitTime = 5f;
            this.waitImpulses = new System.Collections.Generic.List<WaitImpulseData>();
        }
        protected override void Init()
        {
            this.Init();
            val_1.type = 3;
            this.timeSlot = this.addSlotOnLeft(slotName:  "Time");
        }
        protected override void OnEnable()
        {
            goto typeof(TzarGames.Common.ScriptViz.ActionNodeWait).__il2cppRuntimeField_180;
        }
        public override void OnImpulse(TzarGames.Common.NodeSlot slot)
        {
            typeof(ActionNodeWait.WaitImpulseData).__il2cppRuntimeField_10 = UnityEngine.Time.time;
            typeof(ActionNodeWait.WaitImpulseData).__il2cppRuntimeField_14 = this.waitTime;
            this.waitImpulses.Add(item:  new System.Object());
        }
        public override void OnVariableImpulse(object var, TzarGames.Common.ScriptViz.SvNodeSlot slot)
        {
            if(0 != slot)
            {
                    return;
            }
            
            this.waitTime = System.Convert.ToSingle(value:  0);
        }
        public override void Update()
        {
            var val_5;
            float val_6;
            System.Collections.Generic.List<WaitImpulseData> val_5 = this.waitImpulses;
            val_5 = val_5.Count - 1;
            if((val_5 & 2147483648) != 0)
            {
                    return;
            }
            
            do
            {
                val_5 = this.waitImpulses.Item[val_5];
                if(val_5 != null)
            {
                    val_6 = val_2.ActualTime;
            }
            else
            {
                    val_6 = 1.68059E-38f;
            }
            
                if((UnityEngine.Time.time - val_6) >= val_2.WaitTime)
            {
                    this.waitImpulses.RemoveAt(index:  val_5);
                this.waitImpulses.Impulse();
            }
            
                val_5 = val_5 - 1;
            }
            while((val_5 & 2147483648) == 0);
        
        }
        public override bool ShouldUpdateInEditMode()
        {
            return true;
        }
    
    }

}
