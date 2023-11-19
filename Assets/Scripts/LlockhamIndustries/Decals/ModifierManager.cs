using UnityEngine;

namespace LlockhamIndustries.Decals
{
    public class ModifierManager : MonoBehaviour
    {
        // Fields
        private static LlockhamIndustries.Decals.ModifierManager singleton;
        private System.Collections.Generic.List<LlockhamIndustries.Decals.Modifier> perFrameModifiers;
        private System.Collections.Generic.List<LlockhamIndustries.Decals.Modifier> tenModifiers;
        private System.Collections.Generic.List<LlockhamIndustries.Decals.Modifier> oneModifiers;
        private UnityEngine.WaitForSeconds tenthOfASecond;
        private UnityEngine.WaitForSeconds second;
        
        // Properties
        public static bool Initialized { get; }
        public static LlockhamIndustries.Decals.ModifierManager Singleton { get; }
        
        // Methods
        public ModifierManager()
        {
            this.tenthOfASecond = new UnityEngine.WaitForSeconds(seconds:  0.1f);
            this.second = new UnityEngine.WaitForSeconds(seconds:  1f);
        }
        public static bool get_Initialized()
        {
            return UnityEngine.Object.op_Inequality(x:  0, y:  LlockhamIndustries.Decals.ModifierManager.singleton);
        }
        public static LlockhamIndustries.Decals.ModifierManager get_Singleton()
        {
            LlockhamIndustries.Decals.ModifierManager val_4 = LlockhamIndustries.Decals.ModifierManager.singleton;
            if(0 != val_4)
            {
                    return (LlockhamIndustries.Decals.ModifierManager)LlockhamIndustries.Decals.ModifierManager.singleton;
            }
            
            UnityEngine.GameObject val_2 = null;
            val_4 = val_2;
            val_2 = new UnityEngine.GameObject(name:  "Dynamic Decals");
            if(null != 0)
            {
                    hideFlags = 23;
            }
            else
            {
                    0.hideFlags = 23;
            }
            
            LlockhamIndustries.Decals.ModifierManager val_3 = AddComponent<LlockhamIndustries.Decals.ModifierManager>();
            return (LlockhamIndustries.Decals.ModifierManager)LlockhamIndustries.Decals.ModifierManager.singleton;
        }
        private void Start()
        {
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = this.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
        }
        private void OnEnable()
        {
            if(0 != LlockhamIndustries.Decals.ModifierManager.singleton)
            {
                goto label_3;
            }
            
            LlockhamIndustries.Decals.ModifierManager.singleton = this;
            goto label_7;
            label_3:
            if(0 == this)
            {
                goto label_7;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                goto label_8;
            }
            
            UnityEngine.Object.Destroy(obj:  0);
            return;
            label_7:
            this.perFrameModifiers = new System.Collections.Generic.List<LlockhamIndustries.Decals.Modifier>();
            this.tenModifiers = new System.Collections.Generic.List<LlockhamIndustries.Decals.Modifier>();
            this.oneModifiers = new System.Collections.Generic.List<LlockhamIndustries.Decals.Modifier>();
            UnityEngine.Coroutine val_11 = this.StartCoroutine(routine:  this.TenTimesPerSecond());
            UnityEngine.Coroutine val_13 = this.StartCoroutine(routine:  this.OncePerSecond());
            return;
            label_8:
            UnityEngine.Object.DestroyImmediate(obj:  0, allowDestroyingAssets:  this.gameObject);
        }
        private void OnDisable()
        {
            this.StopAllCoroutines();
        }
        private static System.Collections.Generic.List<LlockhamIndustries.Decals.Modifier> GetModifiers(LlockhamIndustries.Decals.Frequency p_Frequency)
        {
            System.Collections.Generic.List<LlockhamIndustries.Decals.Modifier> val_4;
            var val_5;
            if(W1 == 2)
            {
                goto label_0;
            }
            
            if(W1 == 1)
            {
                goto label_1;
            }
            
            val_4 = 0;
            if(W1 != 0)
            {
                    return val_4;
            }
            
            val_5 = LlockhamIndustries.Decals.ModifierManager.Singleton;
            val_4 = val_1.perFrameModifiers;
            return val_4;
            label_0:
            val_5 = LlockhamIndustries.Decals.ModifierManager.Singleton;
            val_4 = val_2.oneModifiers;
            return val_4;
            label_1:
            val_5 = LlockhamIndustries.Decals.ModifierManager.Singleton;
            val_4 = val_3.tenModifiers;
            return val_4;
        }
        public static void Register(LlockhamIndustries.Decals.Modifier p_Modifier)
        {
            System.Collections.Generic.List<LlockhamIndustries.Decals.Modifier> val_1 = LlockhamIndustries.Decals.ModifierManager.GetModifiers(p_Frequency:  16610);
            if((val_1.Contains(item:  X1)) != false)
            {
                    return;
            }
            
            val_1.Add(item:  X1);
        }
        public static void Deregister(LlockhamIndustries.Decals.Modifier p_Modifier)
        {
            bool val_2 = LlockhamIndustries.Decals.ModifierManager.GetModifiers(p_Frequency:  16605).Remove(item:  X1);
        }
        private void Update()
        {
            goto label_1;
            label_6:
            0 = 1;
            label_1:
            if(0 >= this.perFrameModifiers.Count)
            {
                    return;
            }
            
            if(this.perFrameModifiers.Item[1] != null)
            {
                goto label_6;
            }
            
            goto label_6;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator TenTimesPerSecond()
        {
            typeof(ModifierManager.<TenTimesPerSecond>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator OncePerSecond()
        {
            typeof(ModifierManager.<OncePerSecond>c__Iterator1).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
