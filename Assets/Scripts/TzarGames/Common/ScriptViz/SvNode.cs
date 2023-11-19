using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [UnityEngine.HideInInspector]
    public class SvNode : Node
    {
        // Fields
        private const float LabelTopMargin = 25;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private System.Collections.Generic.List<TzarGames.Common.NodeSlot> outputSlots;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private System.Collections.Generic.List<TzarGames.Common.NodeSlot> inputSlots;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private UnityEngine.GameObject owner;
        private static UnityEngine.GUIStyle outSlotLabel;
        private static UnityEngine.GUIStyle inSlotLabel;
        
        // Properties
        public UnityEngine.GameObject Owner { get; set; }
        
        // Methods
        public SvNode()
        {
            this.outputSlots = new System.Collections.Generic.List<TzarGames.Common.NodeSlot>();
            this.inputSlots = new System.Collections.Generic.List<TzarGames.Common.NodeSlot>();
        }
        public virtual bool ShouldUpdateInEditMode()
        {
            return false;
        }
        public virtual TzarGames.Common.ScriptViz.SvNode MakeCopy()
        {
            var val_8;
            var val_34;
            var val_35;
            UnityEngine.Object val_36;
            UnityEngine.Object val_38;
            var val_40;
            var val_41;
            Unitycoding.UIWidgets.RadialMenuItem val_1 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
            if(0 == val_1)
            {
                    return (TzarGames.Common.ScriptViz.SvNode)val_1;
            }
            
            mem2[0] = new System.Collections.Generic.List<TzarGames.Common.NodeSlot>();
            mem2[0] = new System.Collections.Generic.List<TzarGames.Common.NodeSlot>();
            System.Collections.Generic.List<TzarGames.Common.NodeSlot> val_5 = new System.Collections.Generic.List<TzarGames.Common.NodeSlot>();
            if(val_1 != null)
            {
                    val_34 = val_1;
                mem2[0] = val_5;
            }
            else
            {
                    val_34 = 64;
                mem[64] = val_5;
            }
            
            val_1.OnDisable();
            if(this != null)
            {
                    val_35 = this;
                mem2[0] = null;
                mem2[0] = this.owner;
            }
            else
            {
                    val_35 = 56;
                mem2[0] = 4194310;
                mem2[0] = 0;
            }
            
            List.Enumerator<T> val_6 = this.outputSlots.GetEnumerator();
            label_42:
            if((0 & 1) == 0)
            {
                goto label_11;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_9 = val_8.InitializationCallback;
            val_36 = val_1.GetSlotByName(slotName:  this.outputSlots);
            if(0 == val_36)
            {
                    val_36 = val_9.Clone();
            }
            else
            {
                    val_9.GetObjectData(info:  val_36, context:  new System.Runtime.Serialization.StreamingContext() {state = public System.Void System.MulticastDelegate::GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)});
            }
            
            if(0 == val_36)
            {
                goto label_22;
            }
            
            val_10.slotName = val_9;
            if((val_9.Contains(item:  val_36)) != true)
            {
                    val_9.Add(item:  val_36);
            }
            
            if((Contains(item:  val_36)) == true)
            {
                goto label_42;
            }
            
            Add(item:  val_36);
            goto label_42;
            label_22:
            string val_18 = 0 + "Failed to instantiate node slot " + val_36 + " in node ";
            UnityEngine.Debug.LogError(message:  0);
            goto label_42;
            label_94:
            List.Enumerator<T> val_19 = this.inputSlots.GetEnumerator();
            label_78:
            if((0 & 1) == 0)
            {
                goto label_47;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_20 = val_8.InitializationCallback;
            val_38 = val_1.GetSlotByName(slotName:  this.inputSlots);
            if(0 == val_38)
            {
                    val_38 = val_20.Clone();
            }
            else
            {
                    val_20.GetObjectData(info:  val_38, context:  new System.Runtime.Serialization.StreamingContext() {state = public System.Void System.MulticastDelegate::GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)});
            }
            
            if(0 == val_38)
            {
                goto label_58;
            }
            
            val_21.slotName = val_20;
            if((val_20.Contains(item:  val_38)) != true)
            {
                    val_20.Add(item:  val_38);
            }
            
            if((Contains(item:  val_38)) == true)
            {
                goto label_78;
            }
            
            Add(item:  val_38);
            goto label_78;
            label_58:
            string val_29 = 0 + "Failed to instantiate node slot " + val_38 + " in node ";
            UnityEngine.Debug.LogError(message:  0);
            goto label_78;
            label_95:
            List.Enumerator<T> val_30 = GetEnumerator();
            goto label_83;
            label_88:
            mem2[0] = val_1;
            label_83:
            if((0 & 1) == 0)
            {
                goto label_84;
            }
            
            if(0.InitializationCallback == null)
            {
                goto label_88;
            }
            
            goto label_88;
            label_84:
            val_40 = 0;
            val_41 = 1;
            0.Dispose();
            if(( & 1) != 0)
            {
                    return (TzarGames.Common.ScriptViz.SvNode)val_1;
            }
            
            if( == 0)
            {
                    return (TzarGames.Common.ScriptViz.SvNode)val_1;
            }
            
            return (TzarGames.Common.ScriptViz.SvNode)val_1;
            label_11:
            val_8.Dispose();
            goto label_94;
            label_47:
            val_8.Dispose();
            goto label_95;
        }
        protected virtual void Init()
        {
        
        }
        public virtual void OnImpulse(TzarGames.Common.NodeSlot slot)
        {
        
        }
        public virtual void OnVariableImpulse(object var, TzarGames.Common.ScriptViz.SvNodeSlot slot)
        {
        
        }
        public virtual void Update()
        {
        
        }
        protected virtual void OnEnable()
        {
            goto typeof(TzarGames.Common.ScriptViz.SvNode).__il2cppRuntimeField_180;
        }
        protected virtual void OnDisable()
        {
        
        }
        public virtual void OnInpectorGUI()
        {
        
        }
        public UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine)
        {
            UnityEngine.MonoBehaviour val_1 = this.owner.GetComponent<UnityEngine.MonoBehaviour>();
            if(0 == val_1)
            {
                    return 0;
            }
            
            if(val_1 != null)
            {
                    return val_1.StartCoroutine(routine:  routine);
            }
            
            return val_1.StartCoroutine(routine:  routine);
        }
        public void StopCoroutine(System.Collections.IEnumerator routine)
        {
            UnityEngine.MonoBehaviour val_1 = this.owner.GetComponent<UnityEngine.MonoBehaviour>();
            if(0 == val_1)
            {
                    return;
            }
            
            val_1.StopCoroutine(routine:  routine);
        }
        public UnityEngine.GameObject get_Owner()
        {
            return (UnityEngine.GameObject)this.owner;
        }
        public void set_Owner(UnityEngine.GameObject value)
        {
            this.owner = value;
        }
        protected override void Repaint()
        {
            var val_16;
            float val_17;
            float val_18;
            float val_19;
            var val_21;
            val_16 = 0;
            goto label_1;
            label_14:
            UnityEngine.GUIStyle val_1 = TzarGames.Common.ScriptViz.SvNode.getStyle_inSlotLabel();
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = V12.16B, m_YMin = V13.16B, m_Width = V15.16B, m_Height = V14.16B}, text:  0, style:  X22);
            val_17 = V8.16B;
            val_18 = V11.16B;
            UnityEngine.GUI.color = new UnityEngine.Color() {r = val_17, g = V9.16B, b = V10.16B, a = val_18};
            val_16 = 1;
            label_1:
            if(val_16 >= this.inputSlots.Count)
            {
                goto label_3;
            }
            
            TzarGames.Common.NodeSlot val_3 = this.inputSlots.Item[1];
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
            float val_5 = val_4.x + (-10f);
            val_4.x = val_4.x + 25f;
            float val_16 = 1f;
            val_16 = val_16 * 10f;
            val_16 = val_16 + val_16;
            float val_6 = val_16 + val_4.x;
            if(val_3 != null)
            {
                    val_3.Position = new UnityEngine.Vector2() {x = val_5, y = val_6};
                val_19 = val_5 + 5f;
                0.startFloat = val_19;
            }
            else
            {
                    val_3.Position = new UnityEngine.Vector2() {x = val_5, y = val_6};
                val_19 = val_5 + 5f;
                0.startFloat = val_19;
            }
            
            UnityEngine.Rect val_17 = val_3.nodeRect;
            val_17 = val_17 * (-0.5f);
            val_17 = val_5 + val_17;
            val_17 = val_17 + (-5f);
            UnityEngine.Rect val_18 = val_3.nodeRect;
            val_18 = val_18 + val_18;
            UnityEngine.Color val_7 = UnityEngine.GUI.color;
            UnityEngine.Color val_8 = UnityEngine.Color.white;
            UnityEngine.GUI.color = new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a};
            goto label_14;
            label_3:
            val_21 = 0;
            goto label_15;
            label_28:
            UnityEngine.GUIStyle val_9 = TzarGames.Common.ScriptViz.SvNode.getStyle_outSlotLabel();
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = V12.16B, m_YMin = V13.16B, m_Width = V15.16B, m_Height = V14.16B}, text:  0, style:  this.inputSlots);
            val_17 = V8.16B;
            val_18 = V11.16B;
            UnityEngine.GUI.color = new UnityEngine.Color() {r = val_17, g = V9.16B, b = V10.16B, a = val_18};
            val_21 = 1;
            label_15:
            if(val_21 >= this.outputSlots.Count)
            {
                    return;
            }
            
            TzarGames.Common.NodeSlot val_11 = this.outputSlots.Item[1];
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.zero;
            float val_19 = val_12.x;
            val_19 = val_19 + val_12.x;
            val_12.x = val_12.x + 25f;
            float val_20 = 1f;
            val_20 = val_20 * 10f;
            val_20 = val_20 + val_20;
            float val_13 = val_20 + val_12.x;
            if(val_11 != null)
            {
                    val_11.Position = new UnityEngine.Vector2() {x = val_19, y = val_13};
                0.startFloat = val_19;
            }
            else
            {
                    val_11.Position = new UnityEngine.Vector2() {x = val_19, y = val_13};
                0.startFloat = val_19;
            }
            
            UnityEngine.Rect val_21 = val_11.nodeRect;
            val_21 = val_21 * (-0.5f);
            val_21 = val_19 + val_21;
            val_21 = val_21 + (-5f);
            UnityEngine.Rect val_22 = val_11.nodeRect;
            val_22 = val_22 + val_22;
            UnityEngine.Color val_14 = UnityEngine.GUI.color;
            UnityEngine.Color val_15 = UnityEngine.Color.white;
            UnityEngine.GUI.color = new UnityEngine.Color() {r = val_15.r, g = val_15.g, b = val_15.b, a = val_15.a};
            goto label_28;
        }
        private void recalculateNodeHeight()
        {
            var val_5;
            if(this.inputSlots.Count >= 1)
            {
                    val_5 = this.inputSlots.Count;
            }
            else
            {
                    val_5 = 0;
            }
            
            if(this.outputSlots.Count > val_5)
            {
                    val_5 = this.outputSlots.Count;
            }
            
            float val_5 = (float)val_5;
            val_5 = val_5 * 10f;
            val_5 = val_5 + val_5;
            val_5 = val_5 + 25f;
        }
        private TzarGames.Common.ScriptViz.SvNodeSlot addSlotOnRight(string slotName)
        {
            System.Collections.Generic.List<TzarGames.Common.NodeSlot> val_5;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            TzarGames.Common.ScriptViz.SvNodeSlot val_2 = this.AddSlot<TzarGames.Common.ScriptViz.SvNodeSlot>(slotName:  slotName, slotPos:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            val_2.ParentNode = this;
            val_5 = this.outputSlots;
            if((val_5.Contains(item:  val_2)) != true)
            {
                    val_5 = this.outputSlots;
                val_5.Add(item:  val_2);
            }
            
            this.recalculateNodeHeight();
            return val_2;
        }
        private TzarGames.Common.ScriptViz.SvNodeSlot addSlotOnLeft(string slotName)
        {
            System.Collections.Generic.List<TzarGames.Common.NodeSlot> val_5;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            TzarGames.Common.ScriptViz.SvNodeSlot val_2 = this.AddSlot<TzarGames.Common.ScriptViz.SvNodeSlot>(slotName:  slotName, slotPos:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            if(val_2 != null)
            {
                    val_2.type = 1;
            }
            else
            {
                    mem[88] = 1;
            }
            
            val_2.ParentNode = this;
            val_5 = this.inputSlots;
            if((val_5.Contains(item:  val_2)) != true)
            {
                    val_5 = this.inputSlots;
                val_5.Add(item:  val_2);
            }
            
            this.recalculateNodeHeight();
            return val_2;
        }
        protected TzarGames.Common.ScriptViz.SvNodeSlot AddOutputSlot(string slotName)
        {
            val_1.type = 2;
            return (TzarGames.Common.ScriptViz.SvNodeSlot)this.addSlotOnRight(slotName:  slotName);
        }
        protected TzarGames.Common.ScriptViz.SvNodeSlot AddInputSlot(string slotName)
        {
            val_1.type = 1;
            return (TzarGames.Common.ScriptViz.SvNodeSlot)this.addSlotOnLeft(slotName:  slotName);
        }
        protected TzarGames.Common.ScriptViz.SvNodeSlot AddVariableInputSlot(string slotName)
        {
            val_1.type = 3;
            return (TzarGames.Common.ScriptViz.SvNodeSlot)this.addSlotOnLeft(slotName:  slotName);
        }
        protected TzarGames.Common.ScriptViz.SvNodeSlot AddVariableOutputSlot(string slotName)
        {
            val_1.type = 4;
            return (TzarGames.Common.ScriptViz.SvNodeSlot)this.addSlotOnRight(slotName:  slotName);
        }
        private static UnityEngine.GUIStyle getStyle_outSlotLabel()
        {
            var val_4;
            var val_5;
            var val_6;
            val_5 = null;
            val_5 = null;
            if(TzarGames.Common.ScriptViz.SvNode.outSlotLabel == null)
            {
                    val_6 = null;
                val_6 = null;
                TzarGames.Common.ScriptViz.SvNode.outSlotLabel = new UnityEngine.GUIStyle();
                alignment = 5;
                val_4 = normal;
                UnityEngine.Color val_3 = UnityEngine.Color.white;
                val_4.textColor = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
                val_5 = null;
            }
            
            val_5 = null;
            return (UnityEngine.GUIStyle)TzarGames.Common.ScriptViz.SvNode.outSlotLabel;
        }
        private static UnityEngine.GUIStyle getStyle_inSlotLabel()
        {
            var val_4;
            var val_5;
            var val_6;
            val_5 = null;
            val_5 = null;
            if(TzarGames.Common.ScriptViz.SvNode.inSlotLabel == null)
            {
                    val_6 = null;
                val_6 = null;
                TzarGames.Common.ScriptViz.SvNode.inSlotLabel = new UnityEngine.GUIStyle();
                alignment = 3;
                val_4 = normal;
                UnityEngine.Color val_3 = UnityEngine.Color.white;
                val_4.textColor = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
                val_5 = null;
            }
            
            val_5 = null;
            return (UnityEngine.GUIStyle)TzarGames.Common.ScriptViz.SvNode.inSlotLabel;
        }
        private static SvNode()
        {
        
        }
    
    }

}
