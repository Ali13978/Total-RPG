using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class ActionNodeDownloadAssetBundle : ActionNode
    {
        // Fields
        [UnityEngine.SerializeField]
        public string url;
        [UnityEngine.SerializeField]
        private int version;
        [UnityEngine.SerializeField]
        private float progressUpdateInterval;
        [UnityEngine.SerializeField]
        private bool loadAllWhenDonloadComplete;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot finishSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot progressSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot assetBundleSlot;
        private float currentProgress;
        
        // Methods
        public ActionNodeDownloadAssetBundle()
        {
            this.progressUpdateInterval = 0.5f;
        }
        protected override void Init()
        {
            this.Init();
            val_1.type = 2;
            this.finishSlot = this.addSlotOnRight(slotName:  "Finish");
            val_2.type = 4;
            this.progressSlot = this.addSlotOnRight(slotName:  "Progress");
            val_3.type = 4;
            this.assetBundleSlot = this.addSlotOnRight(slotName:  "Asset bundle");
        }
        public override void OnImpulse(TzarGames.Common.NodeSlot slot)
        {
            TzarGames.Common.ScriptViz.ScriptVizComponent val_13 = GetComponent<TzarGames.Common.ScriptViz.ScriptVizComponent>();
            if(0 != val_13)
            {
                    if((UnityEngine.Object.op_Implicit(exists:  0)) == true)
            {
                goto label_7;
            }
            
            }
            
            val_13 = val_13.GetComponent<UnityEngine.MonoBehaviour>();
            label_7:
            if(0 != val_13)
            {
                    if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    UnityEngine.Coroutine val_12 = val_13.StartCoroutine(routine:  this.download(assetUrl:  this.url, assetVersion:  this.version));
                this.Impulse();
                return;
            }
            
            }
            
            UnityEngine.Debug.Log(message:  0);
        }
        private void impulseProgress(float progress)
        {
            this.currentProgress = progress;
            this.progressSlot.VariableImpulse(variable:  progress);
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator download(string assetUrl, int assetVersion)
        {
            if(null != 0)
            {
                    typeof(ActionNodeDownloadAssetBundle.<download>c__Iterator0).__il2cppRuntimeField_10 = assetUrl;
                typeof(ActionNodeDownloadAssetBundle.<download>c__Iterator0).__il2cppRuntimeField_18 = assetVersion;
            }
            else
            {
                    mem[16] = assetUrl;
                mem[24] = assetVersion;
            }
            
            typeof(ActionNodeDownloadAssetBundle.<download>c__Iterator0).__il2cppRuntimeField_28 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
