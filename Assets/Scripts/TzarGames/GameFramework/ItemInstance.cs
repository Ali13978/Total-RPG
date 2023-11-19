using UnityEngine;

namespace TzarGames.GameFramework
{
    [Serializable]
    public class ItemInstance
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Item itemTemplate;
        private TzarGames.GameFramework.Item instancedItem;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private string InstanceID;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private bool idGenerated;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private object <Appearance>k__BackingField;
        private object owner;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.GameFramework.ItemInstance.dlgItemInstanceUse OnItemUse;
        public static System.Collections.Generic.List<TzarGames.GameFramework.Item> InstancesToRemove;
        public static object locker;
        public bool Activated;
        public TzarGames.Common.SerializableData Data;
        
        // Properties
        public object Appearance { get; set; }
        public object Owner { get; set; }
        
        // Methods
        public ItemInstance(string instanceID)
        {
            this.Data = new TzarGames.Common.SerializableData();
            this.InstanceID = instanceID;
            this.idGenerated = true;
        }
        public ItemInstance()
        {
            this.Data = new TzarGames.Common.SerializableData();
        }
        public object get_Appearance()
        {
            return (object)this.<Appearance>k__BackingField;
        }
        public void set_Appearance(object value)
        {
            this.<Appearance>k__BackingField = value;
        }
        public void add_OnItemUse(TzarGames.GameFramework.ItemInstance.dlgItemInstanceUse value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnItemUse);
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
            while(1152921511351974016 != this.OnItemUse);
        
        }
        public void remove_OnItemUse(TzarGames.GameFramework.ItemInstance.dlgItemInstanceUse value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnItemUse);
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
            while(1152921511352110592 != this.OnItemUse);
        
        }
        public object get_Owner()
        {
            return (object)this.owner;
        }
        public void set_Owner(object value)
        {
            this.owner = value;
        }
        public TzarGames.GameFramework.Item GetOriginalTemplate()
        {
            return (TzarGames.GameFramework.Item)this.itemTemplate;
        }
        public TzarGames.GameFramework.Item GetTemplateInstance()
        {
            return (TzarGames.GameFramework.Item)this.instancedItem;
        }
        public void CreateTemplateInstance(TzarGames.GameFramework.Item item)
        {
            if(0 == this.itemTemplate)
            {
                    return;
            }
            
            TzarGames.GameFramework.ItemInstanceManager.Initialize();
            if(0 != this.instancedItem)
            {
                    this.RemoveTemplateInstance();
            }
            
            this.itemTemplate = item;
            this.generateItemInstance();
        }
        public void RemoveTemplateInstance()
        {
            TzarGames.GameFramework.ItemInstanceManager.Initialize();
            TzarGames.GameFramework.ItemInstanceManager.RemoveInstance(item:  null);
            this.instancedItem = 0;
        }
        private void generateItemInstance()
        {
            if(0 == this.itemTemplate)
            {
                    return;
            }
            
            this.instancedItem = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
        }
        public string GetInstanceID()
        {
            this.GenerateID();
            return (string)this.InstanceID;
        }
        public void SetInstanceID(string newId)
        {
            this.idGenerated = true;
            this.InstanceID = newId;
        }
        public void GenerateID()
        {
            var val_8;
            var val_9;
            System.Guid val_10;
            byte val_11;
            var val_12;
            if(this.idGenerated == true)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            val_9 = 0;
            val_10 = System.Guid.Empty;
            goto label_4;
            label_11:
            System.Guid val_1 = System.Guid.NewGuid();
            val_10 = val_1._a;
            val_8 = null;
            val_11 = val_1._d;
            val_9 = 1;
            label_4:
            val_8 = null;
            val_12 = null;
            if((val_9 > 10) || (((System.Guid.op_Equality(a:  new System.Guid() {_d = val_10, _e = val_10, _f = val_10, _g = val_10, _h = val_1._b, _i = val_10, _j = val_1._c, _k = val_10}, b:  new System.Guid() {_a = val_11, _b = val_1._h, _c = val_1._j, _d = System.Guid.Empty, _e = System.Guid.Empty, _f = System.Guid.Empty, _g = System.Guid.Empty, _h = System.Guid.Empty, _i = System.Guid.Empty, _j = System.Guid.Empty, _k = System.Guid.Empty})) ^ 1) == true))
            {
                goto label_8;
            }
            
            goto label_11;
            label_8:
            val_12 = null;
            if((System.Guid.op_Equality(a:  new System.Guid() {_d = val_10, _e = val_10, _f = val_10, _g = val_10, _h = val_1._b, _i = val_10, _j = val_1._c, _k = val_10}, b:  new System.Guid() {_a = val_11, _b = val_1._h, _c = val_1._j, _d = System.Guid.Empty, _e = System.Guid.Empty, _f = System.Guid.Empty, _g = System.Guid.Empty, _h = System.Guid.Empty, _i = System.Guid.Empty, _j = System.Guid.Empty, _k = System.Guid.Empty})) != false)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            this.InstanceID = ;
            this.idGenerated = true;
        }
        protected override void Finalize()
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_7 = this;
            val_8 = null;
            val_8 = null;
            System.Threading.Monitor.Enter(obj:  0);
            val_9 = null;
            val_9 = null;
            TzarGames.GameFramework.ItemInstance.InstancesToRemove.Add(item:  this.instancedItem);
            val_10 = 0;
            System.Threading.Monitor.Exit(obj:  0);
            val_11 = 52;
            if((40 != 40) && (val_10 != 0))
            {
                    val_10 = 0;
                val_11 = 52;
            }
            
            this.Finalize();
            if(52 == 52)
            {
                    return;
            }
            
            if(val_10 == 0)
            {
                    return;
            }
            
            val_7 = ???;
            val_10 = ???;
        }
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                    return false;
            }
            
            return false;
        }
        public override int GetHashCode()
        {
            if(this.InstanceID == null)
            {
                
            }
        
        }
        public override string ToString()
        {
            this.GenerateID();
            return System.String.Format(format:  0, arg0:  "[ItemInstance: Template={0}, ID={1}]", arg1:  (0 == this.itemTemplate) ? this.itemTemplate : 0);
        }
        private static ItemInstance()
        {
            TzarGames.GameFramework.ItemInstance.InstancesToRemove = new System.Collections.Generic.List<TzarGames.GameFramework.Item>();
            TzarGames.GameFramework.ItemInstance.locker = new System.Object();
        }
    
    }

}
