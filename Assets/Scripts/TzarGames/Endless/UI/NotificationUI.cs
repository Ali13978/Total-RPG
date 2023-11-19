using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class NotificationUI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform container;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.NotificationEntryUI entryPrefab;
        private TzarGames.Common.Pool<TzarGames.Endless.UI.NotificationUI.EntryInfo> pool;
        private System.Collections.Generic.List<TzarGames.Endless.UI.NotificationUI.EntryInfo> tempEntries;
        private System.Collections.Generic.List<TzarGames.Endless.UI.NotificationUI.EntryInfo> constantEntryUis;
        
        // Methods
        public NotificationUI()
        {
            this.tempEntries = new System.Collections.Generic.List<EntryInfo>();
            this.constantEntryUis = new System.Collections.Generic.List<EntryInfo>();
        }
        private TzarGames.Endless.UI.NotificationUI.EntryInfo createObjectCallback()
        {
            var val_4;
            object val_1 = new System.Object();
            TzarGames.Endless.UI.SkillUpgradeUI val_2 = TzarGames.GameFramework.GameManager.MakeInstance<TzarGames.Endless.UI.SkillUpgradeUI>(obj:  0);
            if(null != 0)
            {
                    val_4 = val_1;
                typeof(NotificationUI.EntryInfo).__il2cppRuntimeField_10 = val_2;
            }
            else
            {
                    val_4 = 16;
                mem[16] = val_2;
            }
            
            val_4.gameObject.SetActive(value:  false);
            return (EntryInfo)val_1;
        }
        private void Awake()
        {
            if(this.pool != null)
            {
                    return;
            }
            
            this.initPool();
        }
        private void initPool()
        {
            this.pool = new TzarGames.Common.Pool<EntryInfo>(createObjectCallback:  new Pool.CreateObjectDeleagate<EntryInfo>(object:  this, method:  EntryInfo TzarGames.Endless.UI.NotificationUI::createObjectCallback()), maxCount:  10);
            CreateObjects(count:  10);
        }
        public void AddTempNotification(string message, float time)
        {
            this.AddTempNotificationWithIcon(message:  message, icon:  0, time:  time);
        }
        public void AddTempNotificationWithIcon(string message, UnityEngine.Sprite icon, float time)
        {
            if(this.pool == null)
            {
                    this.initPool();
            }
            
            EntryInfo val_1 = 0.Get();
            val_1.EntryUi.gameObject.SetActive(value:  true);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            val_1.EntryUi.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            float val_5 = UnityEngine.Time.time;
            if(val_1 != null)
            {
                    val_1.StartTime = val_5;
            }
            else
            {
                    mem[24] = val_5;
            }
            
            val_1.EntryUi.text.text = message;
            val_1.EntryUi.Icon = icon;
            val_1.Time = time;
            val_1.IsConstant = false;
            val_1.EntryUi.transform.SetParent(parent:  this.container, worldPositionStays:  false);
            this.tempEntries.Add(item:  val_1);
        }
        public TzarGames.Endless.UI.NotificationEntryUI AddConstantNotification(string message)
        {
            System.Collections.Generic.List<EntryInfo> val_16;
            var val_17;
            var val_18;
            if(this.pool == null)
            {
                    this.initPool();
            }
            
            EntryInfo val_1 = 0.Get();
            val_1.EntryUi.text.text = message;
            val_1.EntryUi.gameObject.SetActive(value:  true);
            if(val_1 != null)
            {
                    val_1.IsConstant = true;
            }
            else
            {
                    mem[32] = true;
            }
            
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            val_1.EntryUi.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            val_1.EntryUi.Icon = 0;
            val_1.EntryUi.transform.SetParent(parent:  this.container, worldPositionStays:  false);
            if(this.constantEntryUis.Count == 0)
            {
                goto label_20;
            }
            
            val_16 = this.constantEntryUis;
            if(val_16 == null)
            {
                goto label_21;
            }
            
            val_17 = val_16.Count;
            goto label_22;
            label_20:
            val_18 = val_1.EntryUi.transform;
            val_18.SetAsFirstSibling();
            goto label_26;
            label_21:
            val_17 = 0.Count;
            val_16 = 0;
            label_22:
            EntryInfo val_11 = val_16.Item[val_17 - 1];
            val_18 = val_1.EntryUi.transform;
            val_18.SetSiblingIndex(index:  val_11.EntryUi.transform.GetSiblingIndex() + 1);
            label_26:
            this.constantEntryUis.Add(item:  val_1);
            if(val_1 != null)
            {
                    return (TzarGames.Endless.UI.NotificationEntryUI)val_1.EntryUi;
            }
            
            return (TzarGames.Endless.UI.NotificationEntryUI)val_1.EntryUi;
        }
        public void RemoveConstantNotification(TzarGames.Endless.UI.NotificationEntryUI entryUi)
        {
            int val_7;
            TzarGames.Endless.UI.NotificationEntryUI val_8;
            val_7 = this.constantEntryUis.Count - 1;
            if((val_7 & 2147483648) != 0)
            {
                    return;
            }
            
            do
            {
                EntryInfo val_2 = this.constantEntryUis.Item[val_7];
                val_8 = val_2.EntryUi;
                bool val_3 = UnityEngine.Object.op_Equality(x:  0, y:  val_8);
                if(val_3 != false)
            {
                    val_3.removeEntry(entryUi:  entryUi);
                bool val_5 = this.constantEntryUis.Remove(item:  val_2);
                val_8 = this.pool;
                bool val_6 = val_8.Set(pooledObject:  val_2);
            }
            
                val_7 = val_7 - 1;
            }
            while((val_7 & 2147483648) == 0);
        
        }
        private void removeEntry(TzarGames.Endless.UI.NotificationEntryUI entryUi)
        {
            UnityEngine.GameObject val_1 = entryUi.gameObject;
            TzarGames.GameFramework.GameManager.DestroyInstance(obj:  0);
        }
        private void Update()
        {
            EntryInfo val_7;
            float val_8;
            int val_7 = this.tempEntries.Count;
            val_7 = val_7 - 1;
            if((val_7 & 2147483648) != 0)
            {
                    return;
            }
            
            do
            {
                val_7 = this.tempEntries.Item[val_7];
                if(val_7 != null)
            {
                    val_8 = val_3.StartTime;
            }
            else
            {
                    val_8 = 1.01654E-38f;
            }
            
                if((UnityEngine.Time.time - val_8) >= val_3.Time)
            {
                    this.tempEntries.RemoveAt(index:  val_7);
                this.tempEntries.removeEntry(entryUi:  val_3.EntryUi);
                if((this.pool.Set(pooledObject:  val_7)) != true)
            {
                    val_7 = val_3.EntryUi.gameObject;
                TzarGames.GameFramework.GameManager.DestroyInstance(obj:  0);
            }
            
            }
            
                val_7 = val_7 - 1;
            }
            while((val_7 & 2147483648) == 0);
        
        }
    
    }

}
