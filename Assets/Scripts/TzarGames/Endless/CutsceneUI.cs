using UnityEngine;

namespace TzarGames.Endless
{
    public class CutsceneUI : GameUIBase
    {
        // Methods
        public CutsceneUI()
        {
        
        }
        public void Skip()
        {
            goto label_3;
            label_11:
            0 = 1;
            label_3:
            if(0 >= val_1.Length)
            {
                goto label_5;
            }
            
            T val_8 = UnityEngine.Object.FindObjectsOfType<UnityEngine.Component>()[1];
            if(val_8.state != 1)
            {
                goto label_11;
            }
            
            if(val_8 != 0)
            {
                    val_8.time = val_8.duration;
                val_8.Evaluate();
            }
            else
            {
                    0.time = 0.duration;
                0.Evaluate();
            }
            
            val_8.Stop();
            goto label_11;
            label_5:
            UnityEngine.UI.Extensions.BoundTooltipItem val_5 = UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>();
            UnityEngine.Coroutine val_7 = val_5.StartCoroutine(routine:  TzarGames.Endless.CutsceneUI.cancelBlendCoroutine(brain:  val_5));
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private static System.Collections.IEnumerator cancelBlendCoroutine(Cinemachine.CinemachineBrain brain)
        {
            typeof(CutsceneUI.<cancelBlendCoroutine>c__Iterator0).__il2cppRuntimeField_10 = X1;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
