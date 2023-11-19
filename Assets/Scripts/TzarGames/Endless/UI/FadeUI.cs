using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class FadeUI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Image image;
        [UnityEngine.SerializeField]
        private float fadeTime;
        private UnityEngine.Coroutine coroutine;
        
        // Methods
        public FadeUI()
        {
            this.fadeTime = 1f;
        }
        private void Awake()
        {
            this.image.canvasRenderer.SetAlpha(alpha:  0f);
            this.image.enabled = true;
        }
        public void FadeInHalf(System.Action completeCallback)
        {
            this.image.CrossFadeAlpha(alpha:  0.5f, duration:  this.fadeTime, ignoreTimeScale:  true);
            this.startFadingTimer(completeCallback:  completeCallback);
        }
        public void FadeInFull(System.Action completeCallback)
        {
            this.image.CrossFadeAlpha(alpha:  1f, duration:  this.fadeTime, ignoreTimeScale:  true);
            this.startFadingTimer(completeCallback:  completeCallback);
        }
        public void FadeOut(System.Action completeCallback)
        {
            this.image.CrossFadeAlpha(alpha:  0f, duration:  this.fadeTime, ignoreTimeScale:  true);
            this.startFadingTimer(completeCallback:  completeCallback);
        }
        private void startFadingTimer(System.Action completeCallback)
        {
            if(this.coroutine != null)
            {
                    this.StopCoroutine(routine:  this.coroutine);
            }
            
            this.coroutine = this.StartCoroutine(routine:  this.fadeCompleteRoutine(callback:  completeCallback));
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator fadeCompleteRoutine(System.Action callback)
        {
            if(null != 0)
            {
                    typeof(FadeUI.<fadeCompleteRoutine>c__Iterator0).__il2cppRuntimeField_10 = callback;
            }
            else
            {
                    mem[16] = callback;
            }
            
            typeof(FadeUI.<fadeCompleteRoutine>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
