using UnityEngine;

namespace TzarGames.Common
{
    public class Node : ScriptableObject
    {
        // Fields
        private const float kNodeWidth = 150;
        private const float kNodeHeight = 50;
        private static TzarGames.Common.Node selection;
        private bool dragging;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        protected UnityEngine.Vector2 position;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        protected UnityEngine.Rect nodeRect;
        [UnityEngine.SerializeField]
        private string nodeName;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        protected System.Collections.Generic.List<TzarGames.Common.NodeSlot> slots;
        
        // Properties
        public System.Collections.ObjectModel.ReadOnlyCollection<TzarGames.Common.NodeSlot> Slots { get; }
        public static TzarGames.Common.Node Selection { get; set; }
        public string Name { get; set; }
        public UnityEngine.Vector2 Position { get; set; }
        public UnityEngine.Rect NodeRect { get; }
        
        // Methods
        public Node()
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            this.position = val_1;
            mem[1152921511142441696] = val_1.y;
            this.nodeRect = 0;
            this.nodeName = "Default node name";
            this.slots = new System.Collections.Generic.List<TzarGames.Common.NodeSlot>();
        }
        public System.Collections.ObjectModel.ReadOnlyCollection<TzarGames.Common.NodeSlot> get_Slots()
        {
            if(this.slots != null)
            {
                    return this.slots.AsReadOnly();
            }
            
            return this.slots.AsReadOnly();
        }
        public TzarGames.Common.NodeSlot GetSlotByName(string slotName)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            System.Collections.Generic.IEnumerator<T> val_2 = this.Slots.GetEnumerator();
            do
            {
                var val_9 = 0;
                val_9 = val_9 + 1;
                val_9 = val_2;
                if(((val_2 & 1) & 1) == 0)
            {
                goto label_26;
            }
            
                var val_10 = 0;
                val_10 = val_10 + 1;
                val_10 = val_2;
                val_11 = val_2;
            }
            while((System.String.op_Equality(a:  0, b:  X22)) == false);
            
            val_12 = 0;
            val_13 = 79;
            label_26:
            if(val_2 != null)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                val_14 = val_2;
            }
            
            if( != 77)
            {
                    if( == 79)
            {
                    return (TzarGames.Common.NodeSlot)val_11;
            }
            
            }
            
            val_11 = 0;
            return (TzarGames.Common.NodeSlot)val_11;
        }
        private void OnDestroy()
        {
        
        }
        protected virtual void Repaint()
        {
        
        }
        public static TzarGames.Common.Node get_Selection()
        {
            null = null;
            return (TzarGames.Common.Node)TzarGames.Common.Node.selection;
        }
        public static void set_Selection(TzarGames.Common.Node value)
        {
            null = null;
            TzarGames.Common.Node.selection = X1;
        }
        public string get_Name()
        {
            return (string)this.nodeName;
        }
        public void set_Name(string value)
        {
            this.nodeName = value;
        }
        public UnityEngine.Vector2 get_Position()
        {
            return new UnityEngine.Vector2() {x = this.position};
        }
        public void set_Position(UnityEngine.Vector2 value)
        {
            this.position = value;
            mem[1152921511143633376] = value.y;
            this.nodeRect.startFloat = value.x;
            List.Enumerator<T> val_1 = this.slots.GetEnumerator();
            label_7:
            if((0 & 1) == 0)
            {
                goto label_10;
            }
            
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = this.position, y = V12.16B}, b:  new UnityEngine.Vector2() {x = this.position, y = V9.16B});
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = value.y, y = value.x}, b:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            0.InitializationCallback.Position = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            goto label_7;
            label_10:
            0.Dispose();
            if((0 & 1) != 0)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
        
        }
        public UnityEngine.Rect get_NodeRect()
        {
            return new UnityEngine.Rect() {m_XMin = this.nodeRect};
        }
        protected T AddSlot<T>(string slotName, UnityEngine.Vector2 slotPos)
        {
            float val_6;
            string val_7;
            TzarGames.Common.NodeSlot val_8;
            val_6 = slotPos.y;
            val_7 = slotName;
            TzarGames.Common.NodeSlot val_1 = this.GetSlotByName(slotName:  val_7);
            if(0 != val_1)
            {
                    if(val_1 != null)
            {
                    val_8 = val_1;
                if(val_8 != null)
            {
                    return (object)val_8;
            }
            
            }
            
                val_8 = 0;
                return (object)val_8;
            }
            
            val_8 = 0;
            if(val_8 != 0)
            {
                    val_8.GenerateID();
                val_8.SlotName = val_7;
            }
            else
            {
                    val_8.GenerateID();
                val_8.SlotName = val_7;
            }
            
            val_8.Position = new UnityEngine.Vector2() {x = slotPos.x, y = val_6};
            val_7 = this.slots;
            val_7.Add(item:  val_8);
            float val_6 = slotPos.x;
            val_6 = slotPos.x + val_6;
            UnityEngine.Rect val_4 = val_8.SlotRect;
            UnityEngine.Rect val_5 = val_8.SlotRect;
            val_5.m_XMin = val_4.m_XMin + val_5.m_XMin;
            float val_7 = 10f;
            val_6 = val_5.m_XMin + val_7;
            if(val_6 >= 0)
            {
                    return (object)val_8;
            }
            
            val_7 = val_6 - val_6;
            val_5.m_XMin = val_7 + val_5.m_XMin;
            return (object)val_8;
        }
        public void ProcessEvents()
        {
        
        }
        public void Draw()
        {
            if(UnityEngine.Event.current.type != 7)
            {
                    return;
            }
            
            UnityEngine.Color val_3 = UnityEngine.GUI.color;
            if(0 == TzarGames.Common.Node.Selection)
            {
                
            }
            else
            {
                    UnityEngine.Color val_6 = UnityEngine.Color.white;
            }
            
            UnityEngine.GUI.color = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a};
            UnityEngine.GUI.skin.box.Draw(position:  new UnityEngine.Rect() {m_XMin = this.nodeRect, m_YMin = val_6.g, m_Width = val_6.a, m_Height = val_6.b}, content:  new UnityEngine.GUIContent(text:  this.nodeName), isHover:  false, isActive:  false, on:  false, hasKeyboardFocus:  false);
            UnityEngine.GUI.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
        }
        private static Node()
        {
        
        }
    
    }

}
