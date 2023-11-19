using UnityEngine;

namespace TzarGames.Endless
{
    public class MaterialFader : MonoBehaviour, IPoolable
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.MaterialFader.MaterialReplacementInfo[] replacements;
        [UnityEngine.SerializeField]
        private float fadeSpeed;
        [UnityEngine.SerializeField]
        private UnityEngine.Renderer[] renderers;
        [UnityEngine.SerializeField]
        private bool fadeOutAtStart;
        private UnityEngine.Coroutine fadingRoutine;
        private System.Collections.Generic.Dictionary<UnityEngine.Renderer, UnityEngine.Material[]> originalMaterials;
        private System.Collections.Generic.List<UnityEngine.Material> newMaterials;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.Endless.MaterialFader> OnComponentDestroy;
        private const string FADING_PARAMETER = "_Fading";
        
        // Methods
        public MaterialFader()
        {
            this.fadeSpeed = 1f;
            this.newMaterials = new System.Collections.Generic.List<UnityEngine.Material>();
        }
        public void add_OnComponentDestroy(System.Action<TzarGames.Endless.MaterialFader> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnComponentDestroy);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511099984064 != this.OnComponentDestroy);
        
        }
        public void remove_OnComponentDestroy(System.Action<TzarGames.Endless.MaterialFader> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnComponentDestroy);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511100120640 != this.OnComponentDestroy);
        
        }
        private UnityEngine.Material getReplacement(UnityEngine.Material original)
        {
            MaterialReplacementInfo[] val_2;
            UnityEngine.Material val_3;
            var val_3 = 0;
            label_8:
            val_2 = this.replacements;
            if(val_3 >= this.replacements.Length)
            {
                goto label_2;
            }
            
            MaterialReplacementInfo val_2 = this.replacements[0];
            val_2 = this.replacements[0x0][0].Original;
            val_3 = val_3 + 1;
            if(0 != val_2)
            {
                goto label_8;
            }
            
            val_3 = this.replacements[0x0][0].Replacement;
            return (UnityEngine.Material)val_3;
            label_2:
            val_3 = 0;
            return (UnityEngine.Material)val_3;
        }
        private void Reset()
        {
            this.setupRenderers();
        }
        private void setupRenderers()
        {
            var val_16;
            MaterialReplacementInfo[] val_17;
            var val_18;
            var val_19;
            UnityEngine.Material val_20;
            System.Collections.Generic.List<UnityEngine.Renderer> val_2 = new System.Collections.Generic.List<UnityEngine.Renderer>(collection:  this.GetComponentsInChildren<UnityEngine.Renderer>());
            System.Collections.Generic.List<UnityEngine.Material> val_3 = new System.Collections.Generic.List<UnityEngine.Material>();
            int val_5 = Count - 1;
            if((val_5 & 2147483648) != 0)
            {
                goto label_2;
            }
            
            val_16 = 1152921511100663984;
            label_19:
            UnityEngine.Renderer val_6 = Item[val_5];
            RemoveAt(index:  val_5);
            goto label_13;
            label_18:
            val_18 = 1;
            if(val_18 >= val_8.Length)
            {
                goto label_13;
            }
            
            UnityEngine.Material val_16 = [1];
            [1] = Contains(item:  val_16);
            if([1] == true)
            {
                goto label_18;
            }
            
            Add(item:  val_16);
            goto label_18;
            label_13:
            val_5 = val_5 - 1;
            if((val_5 & 2147483648) == 0)
            {
                goto label_19;
            }
            
            label_2:
            if(Count < 1)
            {
                goto label_25;
            }
            
            int val_11 = Count;
            val_17 = null;
            this.replacements = val_17;
            val_16 = 1152921504893853696;
            val_19 = 0;
            val_18 = 16;
            goto label_23;
            label_32:
            var val_12 = X24 + 277138240;
            mem2[0] = val_17;
            val_17 = this.replacements;
            val_19 = 1;
            label_23:
            if(val_19 >= this.replacements.Length)
            {
                goto label_25;
            }
            
            object val_13 = new System.Object();
            val_20 = Item[1];
            if(null != 0)
            {
                    typeof(MaterialFader.MaterialReplacementInfo).__il2cppRuntimeField_10 = val_20;
            }
            else
            {
                    mem[16] = val_20;
                val_20 = mem[16];
            }
            
            typeof(MaterialFader.MaterialReplacementInfo).__il2cppRuntimeField_18 = val_20;
            if(val_19 < this.replacements.Length)
            {
                goto label_32;
            }
            
            goto label_32;
            label_25:
            this.renderers = ToArray();
        }
        private void Start()
        {
            var val_3;
            if(this.renderers != null)
            {
                    if(this.renderers.Length != 0)
            {
                goto label_2;
            }
            
            }
            
            this.setupRenderers();
            label_2:
            this.originalMaterials = new System.Collections.Generic.Dictionary<UnityEngine.Renderer, UnityEngine.Material[]>();
            val_3 = 0;
            goto label_3;
            label_12:
            val_3 = 1;
            label_3:
            if(val_3 >= this.renderers.Length)
            {
                goto label_5;
            }
            
            UnityEngine.Renderer val_3 = this.renderers[1];
            if(val_2.Length == 0)
            {
                goto label_12;
            }
            
            this.originalMaterials.Add(key:  val_3, value:  val_3.sharedMaterials);
            goto label_12;
            label_5:
            if(this.fadeOutAtStart == false)
            {
                    return;
            }
            
            this.fadeTo(targetFade:  0f, reverMaterials:  true, timeToFade:  this.fadeSpeed, setCustomStartFade:  true, customStartFade:  1f);
        }
        private void OnDestroy()
        {
            goto label_1;
            label_7:
            UnityEngine.Object.Destroy(obj:  0);
            0 = 1;
            label_1:
            if(0 >= this.newMaterials.Count)
            {
                goto label_3;
            }
            
            UnityEngine.Material val_2 = this.newMaterials.Item[1];
            goto label_7;
            label_3:
            if(this.OnComponentDestroy == null)
            {
                    return;
            }
            
            this.OnComponentDestroy.Invoke(obj:  this);
        }
        [UnityEngine.ContextMenu]
        public void FadeIn()
        {
            this.fadeTo(targetFade:  1f, reverMaterials:  false, timeToFade:  this.fadeSpeed, setCustomStartFade:  false, customStartFade:  0f);
        }
        [UnityEngine.ContextMenu]
        public void FadeOut()
        {
            this.fadeTo(targetFade:  0f, reverMaterials:  true, timeToFade:  this.fadeSpeed, setCustomStartFade:  false, customStartFade:  0f);
        }
        [UnityEngine.ContextMenu]
        public void FadeOutFromZero()
        {
            this.fadeTo(targetFade:  0f, reverMaterials:  true, timeToFade:  this.fadeSpeed, setCustomStartFade:  true, customStartFade:  1f);
        }
        public void FadeOutFromZeroWithTime(float time)
        {
            this.fadeTo(targetFade:  0f, reverMaterials:  true, timeToFade:  time, setCustomStartFade:  true, customStartFade:  1f);
        }
        private void fadeTo(float targetFade, bool reverMaterials, float timeToFade, bool setCustomStartFade = False, float customStartFade = 0)
        {
            if(this.fadingRoutine != null)
            {
                    this.StopCoroutine(routine:  this.fadingRoutine);
                this.fadingRoutine = 0;
            }
            
            this.fadingRoutine = this.StartCoroutine(routine:  this.fade(targetFade:  targetFade, doRevertMaterials:  reverMaterials, timeTofade:  timeToFade, setCustomStartFade:  setCustomStartFade, customStartFade:  customStartFade));
        }
        private void revertMaterials()
        {
            var val_2;
            var val_8;
            var val_9;
            val_8 = this;
            if(this.originalMaterials == null)
            {
                    return;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_1 = this.originalMaterials.GetEnumerator();
            label_15:
            if((0 & 1) == 0)
            {
                goto label_19;
            }
            
            UnityEngine.Playables.PlayableHandle val_4 = val_2.GetHandle();
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_5 = val_4.m_Handle.InitializationCallback;
            val_5.sharedMaterials = val_4.m_Handle;
            val_9 = 0;
            goto label_5;
            label_13:
            val_9 = 1;
            label_5:
            if(val_9 >= val_6.Length)
            {
                goto label_7;
            }
            
            if((this.newMaterials.Contains(item:  val_5.sharedMaterials[1])) == false)
            {
                goto label_13;
            }
            
            UnityEngine.Object.Destroy(obj:  0);
            goto label_13;
            label_7:
            this.newMaterials.Clear();
            goto label_15;
            label_19:
            val_2.Dispose();
            if((0 & 1) != 0)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
        
        }
        public void ResetFading()
        {
            if(this.fadingRoutine != null)
            {
                    this.StopCoroutine(routine:  this.fadingRoutine);
                this.fadingRoutine = 0;
            }
            
            this.revertMaterials();
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator fade(float targetFade, bool doRevertMaterials, float timeTofade, bool setCustomStartFade = False, float customStartFade = 0)
        {
            if(null != 0)
            {
                    typeof(MaterialFader.<fade>c__Iterator0).__il2cppRuntimeField_20 = customStartFade;
                typeof(MaterialFader.<fade>c__Iterator0).__il2cppRuntimeField_28 = timeTofade;
                typeof(MaterialFader.<fade>c__Iterator0).__il2cppRuntimeField_34 = targetFade;
                typeof(MaterialFader.<fade>c__Iterator0).__il2cppRuntimeField_1C = setCustomStartFade;
                typeof(MaterialFader.<fade>c__Iterator0).__il2cppRuntimeField_3C = doRevertMaterials;
            }
            else
            {
                    typeof(MaterialFader.<fade>c__Iterator0).__il2cppRuntimeField_1C = setCustomStartFade;
                mem[32] = customStartFade;
                mem[40] = timeTofade;
                typeof(MaterialFader.<fade>c__Iterator0).__il2cppRuntimeField_34 = targetFade;
                typeof(MaterialFader.<fade>c__Iterator0).__il2cppRuntimeField_3C = doRevertMaterials;
            }
            
            typeof(MaterialFader.<fade>c__Iterator0).__il2cppRuntimeField_40 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public void OnPushedToPool()
        {
            this.ResetFading();
        }
        public void OnPulledFromPool()
        {
        
        }
    
    }

}
