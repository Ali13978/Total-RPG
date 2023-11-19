using UnityEngine;

namespace LlockhamIndustries.Misc
{
    public class DebugManager : MonoBehaviour
    {
        // Fields
        private static LlockhamIndustries.Misc.DebugManager singleton;
        public UnityEngine.Font font;
        public UnityEngine.RectTransform logRect;
        public float logHeight;
        private System.Collections.Generic.List<LlockhamIndustries.Misc.DebugEntry> Entries;
        
        // Methods
        public DebugManager()
        {
            this.logHeight = 40f;
            this.Entries = new System.Collections.Generic.List<LlockhamIndustries.Misc.DebugEntry>();
        }
        private void Awake()
        {
            if(0 == LlockhamIndustries.Misc.DebugManager.singleton)
            {
                    LlockhamIndustries.Misc.DebugManager.singleton = this;
                return;
            }
            
            if(0 == this)
            {
                    return;
            }
            
            UnityEngine.GameObject val_3 = this.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
        }
        private void Start()
        {
            this.CreateEntries();
        }
        private void OnEnable()
        {
            Application.LogCallback val_1 = new Application.LogCallback(object:  this, method:  System.Void LlockhamIndustries.Misc.DebugManager::OnLog(string logString, string stackTrace, UnityEngine.LogType type));
            UnityEngine.Application.add_logMessageReceived(value:  0);
        }
        private void OnDisable()
        {
            Application.LogCallback val_1 = new Application.LogCallback(object:  this, method:  System.Void LlockhamIndustries.Misc.DebugManager::OnLog(string logString, string stackTrace, UnityEngine.LogType type));
            UnityEngine.Application.remove_logMessageReceived(value:  0);
        }
        public static void Log(string Title, string Log)
        {
            var val_4;
            LlockhamIndustries.Misc.DebugManager val_14;
            int val_15;
            int val_16;
            val_14 = LlockhamIndustries.Misc.DebugManager.singleton;
            if(0 == val_14)
            {
                    return;
            }
            
            val_14 = mem[LlockhamIndustries.Misc.DebugManager.singleton + 48];
            val_14 = LlockhamIndustries.Misc.DebugManager.singleton.Entries;
            List.Enumerator<T> val_2 = GetEnumerator();
            label_10:
            if((0 & 1) == 0)
            {
                goto label_6;
            }
            
            if((System.String.op_Equality(a:  0, b:  X23)) == false)
            {
                goto label_10;
            }
            
            val_4.InitializationCallback.Update(Title:  Log, Log:  X2);
            val_4.Dispose();
            return;
            label_6:
            val_4.Dispose();
            val_16 = Count - 2;
            goto label_16;
            label_24:
            X23.Update(Title:  1152921511802542688, Log:  1152921511802543712);
            val_16 = val_16 - 1;
            label_16:
            val_15 = val_16 + 1;
            if(val_15 <= 0)
            {
                goto label_18;
            }
            
            LlockhamIndustries.Misc.DebugEntry val_9 = Item[val_16];
            LlockhamIndustries.Misc.DebugEntry val_10 = Item[val_16];
            if(Item[val_15] != null)
            {
                goto label_24;
            }
            
            goto label_24;
            label_18:
            val_14 = Item[0];
            val_14.Update(Title:  Log, Log:  X2);
        }
        private void OnLog(string logString, string stackTrace, UnityEngine.LogType type)
        {
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            LlockhamIndustries.Misc.DebugManager.Log(Title:  type, Log:  type.ToString());
        }
        private void CreateEntries()
        {
            float val_4;
            UnityEngine.Rect val_1 = this.logRect.rect;
            val_4 = val_1.m_XMin;
            val_1.m_XMin = val_4 / this.logHeight;
            int val_2 = UnityEngine.Mathf.FloorToInt(f:  val_1.m_XMin);
            if(val_2 < 1)
            {
                    return;
            }
            
            var val_4 = 0;
            do
            {
                LlockhamIndustries.Misc.DebugEntry val_3 = null;
                val_4 = this.logHeight;
                val_3 = new LlockhamIndustries.Misc.DebugEntry(Font:  this.font, LogRect:  this.logRect, LogHeight:  val_4, Index:  0);
                this.Entries.Add(item:  val_3);
                val_4 = val_4 + 1;
            }
            while(val_2 != val_4);
        
        }
    
    }

}
