using UnityEngine;

namespace Unitycoding
{
    public abstract class CallbackHandler : MonoBehaviour
    {
        // Fields
        [UnityEngine.HideInInspector]
        public System.Collections.Generic.List<Unitycoding.CallbackHandler.Entry> delegates;
        
        // Properties
        public abstract string[] Callbacks { get; }
        
        // Methods
        protected CallbackHandler()
        {
        
        }
        public abstract string[] get_Callbacks(); // 0
        protected void Execute(string eventID, Unitycoding.CallbackEventData eventData)
        {
            if(this.delegates == null)
            {
                    return;
            }
            
            int val_1 = this.delegates.Count;
            if(val_1 < 1)
            {
                    return;
            }
            
            var val_4 = 0;
            do
            {
                Entry val_2 = this.delegates.Item[0];
                if(((System.String.op_Equality(a:  0, b:  val_2.eventID)) != false) && (val_2.callback != null))
            {
                    val_2.callback.Invoke(arg0:  eventData);
            }
            
                val_4 = val_4 + 1;
            }
            while(val_1 != val_4);
        
        }
        public void RegisterListener(string eventID, UnityEngine.Events.UnityAction<Unitycoding.CallbackEventData> call)
        {
            string val_8;
            System.Collections.Generic.List<Entry> val_9;
            var val_10;
            Entry val_11;
            val_8 = eventID;
            val_9 = this.delegates;
            if(val_9 == null)
            {
                goto label_1;
            }
            
            val_10 = 0;
            goto label_3;
            label_1:
            System.Collections.Generic.List<Entry> val_1 = null;
            val_9 = val_1;
            val_1 = new System.Collections.Generic.List<Entry>();
            val_10 = 0;
            this.delegates = val_9;
            goto label_3;
            label_10:
            val_9 = this.delegates;
            val_10 = 1;
            label_3:
            if(val_10 >= val_9.Count)
            {
                goto label_5;
            }
            
            val_11 = this.delegates.Item[1];
            if((System.String.op_Equality(a:  0, b:  val_3.eventID)) == false)
            {
                goto label_10;
            }
            
            if(val_11 != null)
            {
                goto label_11;
            }
            
            label_5:
            object val_6 = null;
            val_11 = val_6;
            val_6 = new System.Object();
            typeof(CallbackHandler.Entry).__il2cppRuntimeField_10 = val_8;
            CallbackHandler.CallbackEvent val_7 = null;
            val_8 = val_7;
            val_7 = new CallbackHandler.CallbackEvent();
            typeof(CallbackHandler.Entry).__il2cppRuntimeField_18 = val_8;
            this.delegates.Add(item:  val_11);
            label_11:
            AddListener(call:  call);
        }
        public void RemoveListener(string eventID, UnityEngine.Events.UnityAction<Unitycoding.CallbackEventData> call)
        {
            System.Collections.Generic.List<Entry> val_4;
            var val_5;
            val_4 = this.delegates;
            if(val_4 == null)
            {
                    return;
            }
            
            val_5 = 0;
            goto label_2;
            label_12:
            val_4 = this.delegates;
            val_5 = 1;
            label_2:
            if(val_5 >= val_4.Count)
            {
                    return;
            }
            
            Entry val_2 = this.delegates.Item[1];
            if((System.String.op_Equality(a:  0, b:  val_2.eventID)) == false)
            {
                goto label_12;
            }
            
            val_2.callback.RemoveListener(call:  call);
            goto label_12;
        }
    
    }

}
