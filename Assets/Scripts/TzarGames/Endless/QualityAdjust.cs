using UnityEngine;

namespace TzarGames.Endless
{
    public class QualityAdjust : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private bool adjustTargetFramerate;
        [UnityEngine.SerializeField]
        private int targetFramerate;
        [UnityEngine.SerializeField]
        private System.Collections.Generic.List<TzarGames.Endless.MemoryInfo> memoryLevels;
        [UnityEngine.SerializeField]
        private bool dontDestroyOnLoad;
        private static System.Comparison<TzarGames.Endless.MemoryInfo> <>f__am$cache0;
        
        // Methods
        public QualityAdjust()
        {
            this.targetFramerate = 60;
        }
        [TzarGames.Common.ConsoleCommand]
        public void EnableCloth(bool enable)
        {
            goto label_3;
            label_8:
            X21.enabled = enable;
            0 = 1;
            label_3:
            if(0 >= val_1.Length)
            {
                    return;
            }
            
            if((UnityEngine.Object.FindObjectsOfType<UnityEngine.Component>()[1]) != 0)
            {
                goto label_8;
            }
            
            goto label_8;
        }
        private void Start()
        {
            var val_14;
            string val_15;
            var val_16;
            var val_17;
            if(this.dontDestroyOnLoad != false)
            {
                    UnityEngine.GameObject val_1 = this.gameObject;
                UnityEngine.Object.DontDestroyOnLoad(target:  0);
            }
            
            AppSettings.GraphicsSettings.Adjust();
            if((this.adjustTargetFramerate & 255) != false)
            {
                    bool val_3 = this.adjustTargetFramerate >> 32;
                UnityEngine.Application.targetFrameRate = 0;
            }
            
            int val_4 = UnityEngine.SystemInfo.systemMemorySize;
            string val_5 = 0 + "System memory size: "("System memory size: ");
            UnityEngine.Debug.Log(message:  0);
            val_14 = null;
            if((TzarGames.Endless.QualityAdjust.<>f__am$cache0) == null)
            {
                    TzarGames.Endless.QualityAdjust.<>f__am$cache0 = new System.Comparison<TzarGames.Endless.MemoryInfo>(object:  0, method:  static System.Int32 TzarGames.Endless.QualityAdjust::<Start>m__0(TzarGames.Endless.MemoryInfo x, TzarGames.Endless.MemoryInfo y));
                val_14 = null;
            }
            
            this.memoryLevels.Sort(comparison:  TzarGames.Endless.QualityAdjust.<>f__am$cache0);
            List.Enumerator<T> val_7 = this.memoryLevels.GetEnumerator();
            val_15 = 1152921510775153168;
            label_14:
            if((0 & 1) == 0)
            {
                goto label_39;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_9 = val_4.InitializationCallback;
            if(UnityEngine.SystemInfo.systemMemorySize > 0)
            {
                goto label_14;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Applying quality level for low memory device ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = System.Object[].__il2cppRuntimeField_namespaze;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " ";
            val_15 = UnityEngine.QualitySettings.names[1152921510775154192];
            typeof(System.Object[]).__il2cppRuntimeField_38 = val_15;
            UnityEngine.Debug.Log(message:  0);
            UnityEngine.QualitySettings.SetQualityLevel(index:  0, applyExpensiveChanges:  +0);
            string val_13 = 0 + "Applying target framerate: "("Applying target framerate: ");
            UnityEngine.Debug.Log(message:  0);
            UnityEngine.Application.targetFrameRate = 0;
            label_39:
            val_16 = 0;
            val_17 = 1;
            val_4.Dispose();
            if(( & 1) != 0)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        private static int <Start>m__0(TzarGames.Endless.MemoryInfo x, TzarGames.Endless.MemoryInfo y)
        {
            var val_2;
            if(y.Amount <= (X2 + 16))
            {
                    return (int)(y.Amount < (X2 + 16)) ? -1 : 0;
            }
            
            val_2 = 1;
            return (int)(y.Amount < (X2 + 16)) ? -1 : 0;
        }
    
    }

}
