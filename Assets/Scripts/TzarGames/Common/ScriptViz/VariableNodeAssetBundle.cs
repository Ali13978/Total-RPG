using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class VariableNodeAssetBundle : VariableNode
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.ScriptViz.SvNodeSlot UnloadSlot;
        [UnityEngine.SerializeField]
        private bool unloadAllLoadedObjects;
        private UnityEngine.AssetBundle assetBundle;
        
        // Properties
        protected override object Value { get; set; }
        
        // Methods
        public VariableNodeAssetBundle()
        {
            this.unloadAllLoadedObjects = true;
        }
        protected override void Init()
        {
            this.Init();
            val_1.type = 1;
            this.UnloadSlot = this.addSlotOnLeft(slotName:  "Unload");
        }
        public override void OnImpulse(TzarGames.Common.NodeSlot slot)
        {
            if(0 != slot)
            {
                    return;
            }
            
            this.assetBundle.Unload(unloadAllLoadedObjects:  (this.unloadAllLoadedObjects == true) ? 1 : 0);
        }
        public override void OnVariableImpulse(object var, TzarGames.Common.ScriptViz.SvNodeSlot slot)
        {
            UnityEngine.AssetBundle val_2;
            this.ImpulseOut(variable:  this);
            if(var != null)
            {
                    var val_1 = (null == null) ? var : 0;
            }
            else
            {
                    val_2 = 0;
            }
            
            this.assetBundle = val_2;
            this.ImpulseOut(variable:  val_2);
        }
        protected override object get_Value()
        {
            return (object)this.assetBundle;
        }
        protected override void set_Value(object value)
        {
            UnityEngine.AssetBundle val_2;
            if(value != null)
            {
                    var val_1 = (null == null) ? value : 0;
            }
            else
            {
                    val_2 = 0;
            }
            
            this.assetBundle = val_2;
        }
    
    }

}
