using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class ActionNodeInstantiate : ActionNode
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Object Template;
        [UnityEngine.SerializeField]
        private UnityEngine.Transform SpawnPosition;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot valueOutSlot;
        
        // Methods
        public ActionNodeInstantiate()
        {
        
        }
        protected override void Init()
        {
            this.Init();
            val_1.type = 4;
            this.valueOutSlot = this.addSlotOnRight(slotName:  "Instance");
        }
        public override void OnImpulse(TzarGames.Common.NodeSlot slot)
        {
            if(0 != this.SpawnPosition)
            {
                    UnityEngine.Vector3 val_2 = this.SpawnPosition.position;
                UnityEngine.Quaternion val_3 = this.SpawnPosition.rotation;
                UnityEngine.Object val_4 = UnityEngine.Object.Instantiate(original:  0, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
            }
            
            UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  this.waitRoutine(obj:  UnityEngine.Object.Instantiate(original:  0)));
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator waitRoutine(UnityEngine.Object obj)
        {
            if(null != 0)
            {
                    typeof(ActionNodeInstantiate.<waitRoutine>c__Iterator0).__il2cppRuntimeField_10 = obj;
            }
            else
            {
                    mem[16] = obj;
            }
            
            typeof(ActionNodeInstantiate.<waitRoutine>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
