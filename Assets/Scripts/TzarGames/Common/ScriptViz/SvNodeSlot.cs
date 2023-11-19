using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    public class SvNodeSlot : NodeSlot
    {
        // Fields
        public static bool DebugImpulse;
        public static System.Collections.Generic.Dictionary<TzarGames.Common.ScriptViz.SvNodeSlot, int> ImpulseCount;
        public static System.Collections.Generic.List<TzarGames.Common.ScriptViz.SvNodeSlot> ImpulseHistory;
        [UnityEngine.SerializeField]
        public TzarGames.Common.ScriptViz.SvNode ParentNode;
        [UnityEngine.SerializeField]
        private TzarGames.Common.ScriptViz.SlotType type;
        private System.Collections.Generic.List<TzarGames.Common.ScriptViz.SvNodeSlot> inputs;
        private System.Collections.Generic.List<TzarGames.Common.ScriptViz.SvNodeSlot> outputs;
        private System.Collections.Generic.List<TzarGames.Common.ScriptViz.SvNodeSlot> varInputs;
        private System.Collections.Generic.List<TzarGames.Common.ScriptViz.SvNodeSlot> varOutputs;
        private object lastVariableValue;
        
        // Properties
        public object LastVariableValue { get; }
        public TzarGames.Common.ScriptViz.SlotType Type { get; set; }
        public System.Collections.ObjectModel.ReadOnlyCollection<TzarGames.Common.ScriptViz.SvNodeSlot> Inputs { get; }
        public System.Collections.ObjectModel.ReadOnlyCollection<TzarGames.Common.ScriptViz.SvNodeSlot> VariableInputs { get; }
        
        // Methods
        public SvNodeSlot()
        {
            this.type = 2;
            this.inputs = new System.Collections.Generic.List<TzarGames.Common.ScriptViz.SvNodeSlot>();
            this.outputs = new System.Collections.Generic.List<TzarGames.Common.ScriptViz.SvNodeSlot>();
            this.varInputs = new System.Collections.Generic.List<TzarGames.Common.ScriptViz.SvNodeSlot>();
            this.varOutputs = new System.Collections.Generic.List<TzarGames.Common.ScriptViz.SvNodeSlot>();
        }
        public object get_LastVariableValue()
        {
            return (object)this.lastVariableValue;
        }
        public TzarGames.Common.ScriptViz.SlotType get_Type()
        {
            return (TzarGames.Common.ScriptViz.SlotType)this.type;
        }
        public void set_Type(TzarGames.Common.ScriptViz.SlotType value)
        {
            this.type = value;
        }
        public override TzarGames.Common.NodeSlot MakeCopy()
        {
            var val_9;
            TzarGames.Common.NodeSlot val_1 = this.MakeCopy();
            val_9 = 0;
            if(0 == )
            {
                    return (TzarGames.Common.NodeSlot);
            }
            
            mem2[0] = new System.Collections.Generic.List<TzarGames.Common.ScriptViz.SvNodeSlot>();
            mem2[0] = new System.Collections.Generic.List<TzarGames.Common.ScriptViz.SvNodeSlot>();
            mem2[0] = new System.Collections.Generic.List<TzarGames.Common.ScriptViz.SvNodeSlot>();
            mem2[0] = new System.Collections.Generic.List<TzarGames.Common.ScriptViz.SvNodeSlot>();
            return (TzarGames.Common.NodeSlot);
        }
        public override void CopyLinksTo(TzarGames.Common.NodeSlot slot)
        {
            var val_3;
            System.Collections.Generic.List<TzarGames.Common.ScriptViz.SvNodeSlot> val_11;
            TzarGames.Common.NodeSlot val_12;
            var val_13;
            val_12 = slot;
            val_12.CopyLinksTo(slot:  val_12);
            if(val_12 == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_1 = this.inputs.GetEnumerator();
            label_7:
            if((0 & 1) == 0)
            {
                goto label_5;
            }
            
            val_3.InitializationCallback.ConnectTo(target:  val_12);
            goto label_7;
            label_5:
            val_3.Dispose();
            List.Enumerator<T> val_5 = this.outputs.GetEnumerator();
            label_12:
            if((0 & 1) == 0)
            {
                goto label_11;
            }
            
            val_12.ConnectTo(target:  val_3.InitializationCallback);
            goto label_12;
            label_11:
            val_3.Dispose();
            val_11 = this.varInputs;
            List.Enumerator<T> val_7 = val_11.GetEnumerator();
            label_18:
            if((0 & 1) == 0)
            {
                goto label_16;
            }
            
            0.InitializationCallback.ConnectTo(target:  val_12);
            goto label_18;
            label_16:
            0.Dispose();
            List.Enumerator<T> val_9 = this.varOutputs.GetEnumerator();
            label_23:
            if((0 & 1) == 0)
            {
                goto label_22;
            }
            
            val_12.ConnectTo(target:  0.InitializationCallback);
            goto label_23;
            label_22:
            val_12 = 0;
            val_13 = 1;
            0.Dispose();
            if((val_13 & 1) != 0)
            {
                    return;
            }
            
            if(val_12 == 0)
            {
                    return;
            }
        
        }
        public System.Collections.ObjectModel.ReadOnlyCollection<TzarGames.Common.ScriptViz.SvNodeSlot> get_Inputs()
        {
            if(this.inputs != null)
            {
                    return this.inputs.AsReadOnly();
            }
            
            return this.inputs.AsReadOnly();
        }
        public System.Collections.ObjectModel.ReadOnlyCollection<TzarGames.Common.ScriptViz.SvNodeSlot> get_VariableInputs()
        {
            if(this.varInputs != null)
            {
                    return this.varInputs.AsReadOnly();
            }
            
            return this.varInputs.AsReadOnly();
        }
        public void VariableImpulse(object variable)
        {
            TzarGames.Common.ScriptViz.SvNode val_3;
            object val_4;
            var val_5;
            val_4 = variable;
            if(this.type != 4)
            {
                    if(this.type != 3)
            {
                    return;
            }
            
                val_3 = this.ParentNode;
                this.lastVariableValue = val_4;
                if(val_3 != null)
            {
                    return;
            }
            
                return;
            }
            
            List.Enumerator<T> val_1 = this.varOutputs.GetEnumerator();
            val_3 = 1152921511180948400;
            label_9:
            if((0 & 1) == 0)
            {
                goto label_6;
            }
            
            if(0.InitializationCallback != null)
            {
                goto label_9;
            }
            
            goto label_9;
            label_6:
            val_4 = 0;
            val_5 = 1;
            0.Dispose();
            if((val_5 & 1) != 0)
            {
                    return;
            }
            
            if(val_4 == 0)
            {
                    return;
            }
        
        }
        public void Impulse()
        {
            var val_3;
            if(this.type == 1)
            {
                goto label_1;
            }
            
            if(this.type != 2)
            {
                    return;
            }
            
            val_3 = 0;
            goto label_3;
            label_9:
            val_3 = 1;
            label_3:
            if(val_3 >= this.outputs.Count)
            {
                    return;
            }
            
            if(this.outputs.Item[1] != null)
            {
                goto label_9;
            }
            
            goto label_9;
            label_1:
            if(this.ParentNode == null)
            {
                
            }
        
        }
        public void RandomOutImpulse()
        {
            int val_1 = this.outputs.Count;
            this.outputs.Item[UnityEngine.Random.Range(min:  0, max:  0)].Impulse();
        }
        protected override void Repaint()
        {
            UnityEngine.Color val_1 = UnityEngine.GUI.color;
            TzarGames.Common.ScriptViz.SlotType val_19 = this.type;
            val_19 = (val_19 < 5) ? (val_19 + 5) : 0;
            if(val_19 > 9)
            {
                    return;
            }
            
            var val_20 = 25807528 + (this.type < 0x5 ? (this.type + 5) : 0) << 2;
            val_20 = val_20 + 25807528;
            goto (25807528 + (this.type < 0x5 ? (this.type + 5) : 0) << 2 + 25807528);
        }
        protected override void OnConnectedWith(TzarGames.Common.NodeSlot target)
        {
            target = 0;
            var val_14 = 0;
            val_14 = (val_14 < 5) ? (val_14 + 3) : 0;
            if(val_14 > 7)
            {
                    return;
            }
            
            var val_15 = 25807568 + (0 < 0x5 ? (0 + 3) : 0) << 2;
            val_15 = val_15 + 25807568;
            goto (25807568 + (0 < 0x5 ? (0 + 3) : 0) << 2 + 25807568);
        }
        public override void BreakAllLinks()
        {
            var val_3;
            var val_23;
            var val_24;
            this.BreakAllLinks();
            List.Enumerator<T> val_1 = this.inputs.GetEnumerator();
            label_11:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_4 = val_3.InitializationCallback;
            bool val_5 = UnityEngine.Object.op_Inequality(x:  0, y:  val_4);
            if((val_5 == false) || (val_5 == false))
            {
                goto label_11;
            }
            
            bool val_6 = val_5.Remove(item:  this);
            bool val_7 = X21.Remove(item:  this);
            bool val_8 = val_4.Remove(item:  X21);
            goto label_11;
            label_2:
            val_3.Dispose();
            this.inputs.Clear();
            List.Enumerator<T> val_9 = this.outputs.GetEnumerator();
            label_22:
            if((0 & 1) == 0)
            {
                goto label_16;
            }
            
            bool val_11 = UnityEngine.Object.op_Inequality(x:  0, y:  val_3.InitializationCallback);
            if((val_11 == false) || (val_11 == false))
            {
                goto label_22;
            }
            
            bool val_12 = val_11.Remove(item:  this);
            goto label_22;
            label_16:
            val_3.Dispose();
            this.outputs.Clear();
            List.Enumerator<T> val_13 = this.varInputs.GetEnumerator();
            label_36:
            if((0 & 1) == 0)
            {
                goto label_27;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_14 = val_3.InitializationCallback;
            bool val_15 = UnityEngine.Object.op_Inequality(x:  0, y:  val_14);
            if((val_15 == false) || (val_15 == false))
            {
                goto label_36;
            }
            
            bool val_16 = val_15.Remove(item:  this);
            bool val_17 = X21.Remove(item:  this);
            bool val_18 = val_14.Remove(item:  X21);
            goto label_36;
            label_27:
            val_3.Dispose();
            this.varInputs.Clear();
            List.Enumerator<T> val_19 = this.varOutputs.GetEnumerator();
            label_47:
            if((0 & 1) == 0)
            {
                goto label_41;
            }
            
            bool val_21 = UnityEngine.Object.op_Inequality(x:  0, y:  0.InitializationCallback);
            if((val_21 == false) || (val_21 == false))
            {
                goto label_47;
            }
            
            bool val_22 = val_21.Remove(item:  this);
            goto label_47;
            label_41:
            val_23 = 0;
            val_24 = 1;
            0.Dispose();
            this.varOutputs.Clear();
        }
        protected override bool AllowInput()
        {
            return (bool)(this.type != 2) ? 1 : 0;
        }
        protected override bool AllowOutput()
        {
            return (bool)(this.type != 1) ? 1 : 0;
        }
        public override bool CanConnectWith(TzarGames.Common.NodeSlot target)
        {
            return false;
        }
        private static SvNodeSlot()
        {
            TzarGames.Common.ScriptViz.SvNodeSlot.DebugImpulse = false;
            TzarGames.Common.ScriptViz.SvNodeSlot.ImpulseCount = new System.Collections.Generic.Dictionary<TzarGames.Common.ScriptViz.SvNodeSlot, System.Int32>();
            TzarGames.Common.ScriptViz.SvNodeSlot.ImpulseHistory = new System.Collections.Generic.List<TzarGames.Common.ScriptViz.SvNodeSlot>();
        }
    
    }

}
