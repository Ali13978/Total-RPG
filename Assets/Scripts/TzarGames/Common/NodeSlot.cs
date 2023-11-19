using UnityEngine;

namespace TzarGames.Common
{
    [Serializable]
    public class NodeSlot : ScriptableObject
    {
        // Fields
        public const float NodeSlotSize = 10;
        private static TzarGames.Common.NodeSlot selection;
        private static bool connecting;
        private UnityEngine.Vector2 position;
        private UnityEngine.Rect nodeRect;
        [UnityEngine.SerializeField]
        private string slotName;
        protected System.Collections.Generic.List<TzarGames.Common.NodeSlot> targets;
        [UnityEngine.SerializeField]
        protected string guid;
        [UnityEngine.SerializeField]
        protected System.Collections.Generic.List<string> targetGuids;
        
        // Properties
        public string Guid { get; }
        public string SlotName { get; set; }
        public static TzarGames.Common.NodeSlot Selection { get; set; }
        public UnityEngine.Vector2 Position { get; set; }
        public UnityEngine.Rect SlotRect { get; }
        public System.Collections.ObjectModel.ReadOnlyCollection<TzarGames.Common.NodeSlot> Targets { get; }
        public System.Collections.ObjectModel.ReadOnlyCollection<string> TargetGuids { get; }
        
        // Methods
        public NodeSlot()
        {
            this.slotName = "Noname slot";
            this.targets = new System.Collections.Generic.List<TzarGames.Common.NodeSlot>();
            this.targetGuids = new System.Collections.Generic.List<System.String>();
            this.slotName = "Empty slot";
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
            this.Position = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        }
        public NodeSlot(string slotname, UnityEngine.Vector2 position)
        {
            this.slotName = "Noname slot";
            this.targets = new System.Collections.Generic.List<TzarGames.Common.NodeSlot>();
            this.targetGuids = new System.Collections.Generic.List<System.String>();
            this.slotName = slotname;
            this.Position = new UnityEngine.Vector2() {x = position.x, y = position.y};
        }
        public string get_Guid()
        {
            return (string)this.guid;
        }
        public virtual TzarGames.Common.NodeSlot MakeCopy()
        {
            Unitycoding.UIWidgets.RadialMenuItem val_1 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
            this.GenerateID();
            if(0 == val_1)
            {
                    return (TzarGames.Common.NodeSlot)val_1;
            }
            
            mem2[0] = new System.Collections.Generic.List<TzarGames.Common.NodeSlot>();
            return (TzarGames.Common.NodeSlot)val_1;
        }
        public void GenerateID()
        {
            System.Guid val_1 = System.Guid.NewGuid();
            this.guid = ;
        }
        public virtual void CopyLinksTo(TzarGames.Common.NodeSlot slot)
        {
            var val_3;
            var val_4;
            List.Enumerator<T> val_1 = this.targets.GetEnumerator();
            label_4:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            slot.ConnectTo(target:  0.InitializationCallback);
            goto label_4;
            label_2:
            val_3 = 0;
            val_4 = 1;
            0.Dispose();
            if((val_4 & 1) != 0)
            {
                    return;
            }
            
            if(val_3 == 0)
            {
                    return;
            }
        
        }
        public string get_SlotName()
        {
            return (string)this.slotName;
        }
        public void set_SlotName(string value)
        {
            this.slotName = value;
        }
        private void OnDestroy()
        {
            goto typeof(TzarGames.Common.NodeSlot).__il2cppRuntimeField_180;
        }
        protected virtual void OnEnable()
        {
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                    return;
            }
            
            this.GenerateID();
        }
        public virtual void BreakAllLinks()
        {
            this.targets.Clear();
            this.targetGuids.Clear();
        }
        public static TzarGames.Common.NodeSlot get_Selection()
        {
            null = null;
            return (TzarGames.Common.NodeSlot)TzarGames.Common.NodeSlot.selection;
        }
        public static void set_Selection(TzarGames.Common.NodeSlot value)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            TzarGames.Common.NodeSlot.selection = X1;
            if(0 != TzarGames.Common.NodeSlot.selection)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            TzarGames.Common.NodeSlot.connecting = false;
        }
        public UnityEngine.Vector2 get_Position()
        {
            return new UnityEngine.Vector2() {x = this.position};
        }
        public void set_Position(UnityEngine.Vector2 value)
        {
            this.position = value;
            mem[1152921511146056860] = value.y;
            this.nodeRect = 0;
        }
        public UnityEngine.Rect get_SlotRect()
        {
            return new UnityEngine.Rect() {m_XMin = this.nodeRect};
        }
        public System.Collections.ObjectModel.ReadOnlyCollection<TzarGames.Common.NodeSlot> get_Targets()
        {
            if(this.targets != null)
            {
                    return this.targets.AsReadOnly();
            }
            
            return this.targets.AsReadOnly();
        }
        public System.Collections.ObjectModel.ReadOnlyCollection<string> get_TargetGuids()
        {
            if(this.targetGuids != null)
            {
                    return this.targetGuids.AsReadOnly();
            }
            
            return this.targetGuids.AsReadOnly();
        }
        public virtual bool CanConnectWith(TzarGames.Common.NodeSlot target)
        {
            return true;
        }
        public void ConnectTo(TzarGames.Common.NodeSlot target)
        {
            System.Collections.Generic.List<TzarGames.Common.NodeSlot> val_5;
            System.Collections.Generic.List<System.String> val_6;
            var val_7;
            if((this & 1) == 0)
            {
                    return;
            }
            
            val_5 = this.targets;
            if((val_5.Contains(item:  target)) != false)
            {
                    return;
            }
            
            this.targets.Add(item:  target);
            val_6 = this.targetGuids;
            val_7 = public System.Boolean System.Collections.Generic.List<System.String>::Contains(System.String item);
            if((val_6.Contains(item:  target.guid)) != true)
            {
                    val_6 = this.targetGuids;
                val_7 = public System.Void System.Collections.Generic.List<System.String>::Add(System.String item);
                val_6.Add(item:  target.guid);
            }
        
        }
        public void DisconnectFrom(string targetGuid)
        {
            System.Collections.Generic.List<System.String> val_7 = this.targetGuids;
            if((val_7.Contains(item:  targetGuid)) == false)
            {
                    return;
            }
            
            bool val_2 = this.targetGuids.Remove(item:  targetGuid);
            val_7 = this.targets.Count - 1;
            if((val_7 & 2147483648) != 0)
            {
                    return;
            }
            
            do
            {
                TzarGames.Common.NodeSlot val_4 = this.targets.Item[val_7];
                if((System.String.op_Equality(a:  0, b:  val_4.guid)) != false)
            {
                    this.targets.RemoveAt(index:  val_7);
            }
            
                val_7 = val_7 - 1;
            }
            while((val_7 & 2147483648) == 0);
        
        }
        public void DisconnectFrom(TzarGames.Common.NodeSlot target)
        {
            if((this.targetGuids.Contains(item:  target.guid)) != false)
            {
                    bool val_2 = this.targetGuids.Remove(item:  target.guid);
            }
            
            if((this.targets.Contains(item:  target)) == false)
            {
                    return;
            }
            
            bool val_4 = this.targets.Remove(item:  target);
        }
        protected virtual void OnConnectedWith(TzarGames.Common.NodeSlot target)
        {
        
        }
        protected virtual bool AllowInput()
        {
            return true;
        }
        protected virtual bool AllowOutput()
        {
            return true;
        }
        protected virtual void Repaint()
        {
            UnityEngine.GUIContent val_1 = new UnityEngine.GUIContent(text:  this.slotName);
            UnityEngine.GUI.Box(position:  new UnityEngine.Rect() {m_XMin = this.nodeRect, m_YMin = V9.16B, m_Width = V10.16B, m_Height = V11.16B}, content:  0);
        }
        public void OnGUI()
        {
        
        }
        public static void DrawConnection(UnityEngine.Vector2 from, UnityEngine.Vector2 to)
        {
        
        }
        public static void DrawConnection(UnityEngine.Vector2 from, UnityEngine.Vector2 to, bool left, float tangentSize)
        {
        
        }
        private static NodeSlot()
        {
        
        }
    
    }

}
