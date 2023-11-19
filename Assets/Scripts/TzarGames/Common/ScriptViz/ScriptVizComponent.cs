using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [UnityEngine.ExecuteInEditMode]
    public class ScriptVizComponent : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.ScriptViz.ScriptVizData _data;
        [UnityEngine.SerializeField]
        private string vizGuid;
        
        // Properties
        public TzarGames.Common.ScriptViz.ScriptVizData Data { get; set; }
        
        // Methods
        public ScriptVizComponent()
        {
        
        }
        public TzarGames.Common.ScriptViz.ScriptVizData get_Data()
        {
            return (TzarGames.Common.ScriptViz.ScriptVizData)this._data;
        }
        public void set_Data(TzarGames.Common.ScriptViz.ScriptVizData value)
        {
            this._data = value;
        }
        private void OnEnable()
        {
            var val_7;
            var val_30;
            TzarGames.Common.ScriptViz.ScriptVizComponent val_31;
            var val_32;
            var val_33;
            var val_35;
            var val_36;
            TzarGames.Common.ScriptViz.ScriptVizData val_37;
            var val_38;
            val_31 = this;
            if(0 == this._data)
            {
                    return;
            }
            
            System.Collections.Generic.List<TzarGames.Common.NodeSlot> val_3 = new System.Collections.Generic.List<TzarGames.Common.NodeSlot>();
            System.Collections.Generic.Dictionary<System.String, TzarGames.Common.NodeSlot> val_4 = new System.Collections.Generic.Dictionary<System.String, TzarGames.Common.NodeSlot>();
            List.Enumerator<T> val_5 = this._data._nodes.GetEnumerator();
            goto label_32;
            label_34:
            System.Collections.Generic.IEnumerator<T> val_10 = val_7.InitializationCallback.Slots.GetEnumerator();
            label_23:
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_32 = val_10;
            if(((val_10 & 1) & 1) == 0)
            {
                goto label_33;
            }
            
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_33 = val_10;
            Add(item:  val_10);
            Add(key:  X25, value:  val_10);
            goto label_23;
            label_33:
            if(val_10 != null)
            {
                    var val_32 = 0;
                val_32 = val_32 + 1;
                val_35 = val_10;
            }
            
            label_32:
            if((0 & 1) != 0)
            {
                goto label_34;
            }
            
            val_7.Dispose();
            List.Enumerator<T> val_15 = GetEnumerator();
            label_44:
            if((0 & 1) == 0)
            {
                goto label_41;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_16 = val_7.InitializationCallback;
            System.Collections.ObjectModel.ReadOnlyCollection<System.String> val_17 = val_16.TargetGuids;
            int val_19 = val_17.Count - 1;
            label_48:
            if((val_19 & 2147483648) != 0)
            {
                goto label_44;
            }
            
            val_19 = val_19 - 1;
            val_16.ConnectTo(target:  Item[val_17.Item[val_19]]);
            goto label_48;
            label_83:
            val_37 = this._data;
            if(0 == val_37)
            {
                goto label_70;
            }
            
            val_37 = this._data._nodes;
            List.Enumerator<T> val_23 = val_37.GetEnumerator();
            goto label_59;
            label_65:
            mem2[0] = val_16;
            label_59:
            if((0 & 1) == 0)
            {
                goto label_60;
            }
            
            val_38 = val_7.InitializationCallback;
            val_38 = 0;
            UnityEngine.GameObject val_27 = this.gameObject;
            if(val_38 != 0)
            {
                goto label_65;
            }
            
            goto label_65;
            label_60:
            val_7.Dispose();
            label_70:
            List.Enumerator<T> val_28 = this._data._nodes.GetEnumerator();
            val_30 = 1152921504899231744;
            label_78:
            if((0 & 1) == 0)
            {
                goto label_74;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_29 = 0.InitializationCallback;
            if(val_29 == null)
            {
                goto label_78;
            }
            
            val_29.ImpulseDefaultValue();
            goto label_78;
            label_74:
            0.Dispose();
            if(476 == 476)
            {
                    return;
            }
            
            if(val_36 == 0)
            {
                    return;
            }
            
            return;
            label_41:
            val_7.Dispose();
            goto label_83;
        }
        private void OnDestroy()
        {
        
        }
        private void Reset()
        {
            string val_1 = this.name;
            string val_2 = 0 + "Reset svd ";
            UnityEngine.Debug.Log(message:  0);
        }
        private void Start()
        {
            this.TriggerEvent<TzarGames.Common.ScriptViz.EventNodeStart>(slotName:  0);
        }
        private void Update()
        {
            var val_5;
            var val_6;
            val_5 = 0;
            goto label_2;
            label_16:
            val_5 = 1;
            label_2:
            if(val_5 >= this._data._nodes.Count)
            {
                    return;
            }
            
            TzarGames.Common.Node val_2 = this._data._nodes.Item[1];
            val_6 = 0;
            if(0 != )
            {
                goto label_16;
            }
            
            UnityEngine.Debug.Log(message:  0);
            goto label_16;
        }
        public void OnStringMessage(string message)
        {
            this.TriggerEvent<TzarGames.Common.ScriptViz.EventNodeStringMessage>(slotName:  message);
        }
        private void OnTriggerEnter(UnityEngine.Collider other)
        {
            this.TriggerEvent<TzarGames.Common.ScriptViz.EventNodeTrigger>(slotName:  "OnTriggerEnter");
        }
        private void OnTriggerExit(UnityEngine.Collider other)
        {
            this.TriggerEvent<TzarGames.Common.ScriptViz.EventNodeTrigger>(slotName:  "OnTriggerExit");
        }
        private void TriggerEvent<T>(string slotName)
        {
            var val_5;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            val_9 = __RuntimeMethodHiddenParam;
            val_10 = this;
            if(this._data.Nodes == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_3 = this._data.Nodes.GetEnumerator();
            do
            {
                label_10:
                if((0 & 1) == 0)
            {
                goto label_18;
            }
            
                System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_6 = val_5.InitializationCallback;
            }
            while(val_6 == null);
            
            if(val_6 == null)
            {
                goto label_7;
            }
            
            val_11 = val_6;
            if(val_11 == null)
            {
                goto label_8;
            }
            
            val_12 = val_11;
            goto label_10;
            label_8:
            label_7:
            val_12 = 0;
            val_11 = 0;
            goto label_10;
            label_18:
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_13;
            if(0 == 115)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
    
    }

}
