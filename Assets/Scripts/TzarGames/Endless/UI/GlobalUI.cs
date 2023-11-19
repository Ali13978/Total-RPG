using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class GlobalUI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.AlertUI alert;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase genuineUI;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static TzarGames.Endless.UI.GlobalUI <Instance>k__BackingField;
        
        // Properties
        public static TzarGames.Endless.UI.GlobalUI Instance { get; set; }
        public TzarGames.Endless.UI.AlertUI Alert { get; }
        
        // Methods
        public GlobalUI()
        {
        
        }
        public static TzarGames.Endless.UI.GlobalUI get_Instance()
        {
            return (TzarGames.Endless.UI.GlobalUI)TzarGames.Endless.UI.GlobalUI.<Instance>k__BackingField;
        }
        private static void set_Instance(TzarGames.Endless.UI.GlobalUI value)
        {
            TzarGames.Endless.UI.GlobalUI.<Instance>k__BackingField = X1;
        }
        public TzarGames.Endless.UI.AlertUI get_Alert()
        {
            return (TzarGames.Endless.UI.AlertUI)this.alert;
        }
        private void Awake()
        {
            TzarGames.Endless.UI.GlobalUI val_13 = this;
            if(0 != (TzarGames.Endless.UI.GlobalUI.<Instance>k__BackingField))
            {
                    UnityEngine.Debug.Log(message:  0);
                UnityEngine.GameObject val_2 = this.gameObject;
                UnityEngine.Object.Destroy(obj:  0);
                return;
            }
            
            TzarGames.Endless.UI.GlobalUI.<Instance>k__BackingField = val_13;
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_3 = TzarGames.Endless.EndlessGameState.GenuineCheckFailed;
            bool val_4 = val_3.inited & 4294967295;
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {inited = val_3.currentCryptoKey, fakeValue = val_3.currentCryptoKey, fakeValueActive = val_3.currentCryptoKey})) != false)
            {
                    val_13 = ???;
            }
            else
            {
                    System.Action val_6 = new System.Action(object:  val_13, method:  System.Void TzarGames.Endless.UI.GlobalUI::EndlessGameState_OnGenuineCheckFailed());
                TzarGames.Endless.EndlessGameState.add_OnGenuineCheckFailed(value:  0);
            }
        
        }
        private void EndlessGameState_OnGenuineCheckFailed()
        {
            if(this.genuineUI == null)
            {
                
            }
        
        }
        private void OnDestroy()
        {
            var val_2 = this;
            if(0 != (TzarGames.Endless.UI.GlobalUI.<Instance>k__BackingField))
            {
                    return;
            }
            
            TzarGames.Endless.UI.GlobalUI.<Instance>k__BackingField = 0;
        }
    
    }

}
