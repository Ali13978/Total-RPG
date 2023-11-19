using UnityEngine;

namespace TzarGames.Endless
{
    public class BanHammer : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private System.Collections.Generic.List<string> bannedList;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static TzarGames.Endless.BanHammer <Instance>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static bool <Initialized>k__BackingField;
        
        // Properties
        public static TzarGames.Endless.BanHammer Instance { get; set; }
        public static bool Initialized { get; set; }
        
        // Methods
        public BanHammer()
        {
        
        }
        public static TzarGames.Endless.BanHammer get_Instance()
        {
            return (TzarGames.Endless.BanHammer)TzarGames.Endless.BanHammer.<Instance>k__BackingField;
        }
        private static void set_Instance(TzarGames.Endless.BanHammer value)
        {
            TzarGames.Endless.BanHammer.<Instance>k__BackingField = X1;
        }
        private void Awake()
        {
            if(0 != (TzarGames.Endless.BanHammer.<Instance>k__BackingField))
            {
                    string val_3 = 0 + "Multiple " + this.GetType();
                UnityEngine.Debug.LogError(message:  0);
                UnityEngine.GameObject val_4 = this.gameObject;
                UnityEngine.Object.Destroy(obj:  0);
                return;
            }
            
            TzarGames.Endless.BanHammer.<Instance>k__BackingField = this;
        }
        private void OnDestroy()
        {
            var val_2 = this;
            if(0 != (TzarGames.Endless.BanHammer.<Instance>k__BackingField))
            {
                    return;
            }
            
            TzarGames.Endless.BanHammer.<Instance>k__BackingField = 0;
        }
        public static bool get_Initialized()
        {
            return (bool)TzarGames.Endless.BanHammer.<Initialized>k__BackingField;
        }
        private static void set_Initialized(bool value)
        {
            TzarGames.Endless.BanHammer.<Initialized>k__BackingField = W1 & 1;
        }
        public static bool IsBanned(string userId)
        {
            if(null != 0)
            {
                    return Contains(item:  X1);
            }
            
            return Contains(item:  X1);
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator Start()
        {
            typeof(BanHammer.<Start>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void setInitialized()
        {
            TzarGames.Endless.BanHammer.<Initialized>k__BackingField = true;
            TzarGames.Endless.SocialSystem.Instance.AllowWriteScores = (~(TzarGames.Endless.BanHammer.IsBanned(userId:  TzarGames.Endless.SocialSystem.Instance.GetUserName()))) & 1;
        }
    
    }

}
