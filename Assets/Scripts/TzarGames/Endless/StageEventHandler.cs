using UnityEngine;

namespace TzarGames.Endless
{
    public class StageEventHandler : MonoBehaviour
    {
        // Fields
        private const string prefix = "SEVH_";
        [UnityEngine.SerializeField]
        private TzarGames.Endless.StageEventHandler.TriggerInfo[] triggers;
        
        // Methods
        public StageEventHandler()
        {
        
        }
        private static string getKey(TzarGames.Endless.StageEventInfo info)
        {
            return 0 + "SEVH_";
        }
        private static bool checkChance(TzarGames.Endless.StageEventInfo info)
        {
            return (bool)((UnityEngine.Random.Range(min:  0f, max:  100f)) <= (X1 + 48)) ? 1 : 0;
        }
        [UnityEngine.ContextMenu]
        private void testChance()
        {
            object val_4;
            var val_5;
            val_4 = 23893;
            val_5 = 0;
            goto label_1;
            label_27:
            val_4 = 0;
            UnityEngine.Debug.Log(message:  val_4);
            val_5 = 1;
            label_1:
            if(val_5 >= this.triggers.Length)
            {
                    return;
            }
            
            TriggerInfo val_5 = this.triggers[1];
            var val_6 = 0;
            do
            {
                val_6 = (TzarGames.Endless.StageEventHandler.checkChance(info:  val_4)) + val_6;
            }
            while((10000 - 1) != 0);
            
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Tested chance for ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = this.triggers[0x1][0].Info.key;
            typeof(System.Object[]).__il2cppRuntimeField_30 = ": ";
            float val_7 = (float)val_6;
            val_7 = val_7 / 10000f;
            typeof(System.Object[]).__il2cppRuntimeField_38 = val_7;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            string val_4 = +0;
            goto label_27;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator Start()
        {
            typeof(StageEventHandler.<Start>c__Iterator0).__il2cppRuntimeField_38 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
