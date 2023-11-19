using UnityEngine;

namespace TzarGames.Common
{
    public class CustomAnalyticsEventTracker : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.CustomAnalyticsEvent defaultEvent;
        [UnityEngine.SerializeField]
        private string defaultParamater;
        [UnityEngine.SerializeField]
        private bool sendOnce;
        private bool eventSent;
        
        // Properties
        public TzarGames.Common.CustomAnalyticsEvent DefaultEvent { get; }
        
        // Methods
        public CustomAnalyticsEventTracker()
        {
        
        }
        public TzarGames.Common.CustomAnalyticsEvent get_DefaultEvent()
        {
            return (TzarGames.Common.CustomAnalyticsEvent)this.defaultEvent;
        }
        public void SendEvent(TzarGames.Common.CustomAnalyticsEvent customEvent, System.Collections.Generic.IDictionary<string, object> paramaters)
        {
            System.Collections.Generic.Dictionary<TKey, TValue> val_18;
            UnityEngine.Object val_19;
            TzarGames.Common.CustomAnalyticsEvent val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            val_19 = customEvent;
            if(0 == val_19)
            {
                    string val_2 = this.name;
                val_19 = 0 + "Null event: "("Null event: ");
                UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            if((this.sendOnce & 255) != false)
            {
                    if(this.sendOnce > true)
            {
                    return;
            }
            
                this.eventSent = true;
            }
            
            val_20 = val_19;
            if(paramaters == null)
            {
                goto label_12;
            }
            
            if(val_20 == null)
            {
                goto label_13;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_21 = paramaters;
            goto label_17;
            label_12:
            val_22 = 0;
            label_45:
            val_23 = 0;
            goto label_44;
            label_13:
            val_23 = 0;
            val_22 = 0;
            val_20 = paramaters;
            goto label_19;
            label_17:
            val_24 = 1152921504608178176;
            label_35:
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_25 = paramaters;
            if(((paramaters & 1) & 1) == 0)
            {
                goto label_25;
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_26 = paramaters;
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_27 = val_20;
            goto label_35;
            label_25:
            val_23 = 0;
            val_29 = 138;
            if(paramaters != null)
            {
                    var val_22 = 0;
                val_22 = val_22 + 1;
                val_30 = paramaters;
            }
            
            if(138 != 138)
            {
                goto label_43;
            }
            
            val_22 = 0;
            goto label_44;
            label_43:
            if(val_23 == 0)
            {
                goto label_45;
            }
            
            val_31 = 0;
            label_44:
            if(val_20 == null)
            {
                goto label_46;
            }
            
            label_19:
            System.Collections.Generic.Dictionary<System.String, System.String> val_11 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_32 = val_20;
            goto label_50;
            label_46:
            TzarGames.Common.Analytics.AnalyticsManager.SendEvent(customEvent:  null, paramaters:  val_19);
            return;
            label_50:
            val_24 = 1152921509319100832;
            label_67:
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_33 = val_20;
            if(((val_20 & 1) & 1) == 0)
            {
                goto label_59;
            }
            
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_34 = val_20;
            Add(key:  val_20.InitializationCallback, value:  val_20);
            goto label_67;
            label_59:
            val_18 = val_31;
            val_35 = 236;
            if(val_20 != null)
            {
                    var val_26 = 0;
                val_26 = val_26 + 1;
                val_36 = val_20;
            }
            
            TzarGames.Common.Analytics.AnalyticsManager.SendEvent(customEvent:  null, paramaters:  val_19);
        }
        public void SendEvent(TzarGames.Common.CustomAnalyticsEvent customEvent)
        {
            this.SendEvent(customEvent:  customEvent, paramaters:  0);
        }
        public void SendDefaultEventWithParameterValue(string parameterValue)
        {
            var val_7;
            TzarGames.Common.CustomAnalyticsEvent val_8;
            object val_9;
            val_7 = this;
            val_8 = this.defaultEvent;
            if(0 != val_8)
            {
                goto label_3;
            }
            
            val_9 = 0;
            goto label_6;
            label_3:
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_9;
            }
            
            val_8 = this.defaultParamater;
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_12;
            }
            
            label_9:
            val_7 = 0 + "Parameter is null ";
            val_9 = 0;
            label_6:
            UnityEngine.Debug.LogError(message:  val_9);
            return;
            label_12:
            Add(key:  this.defaultParamater, value:  parameterValue);
            this.SendEvent(customEvent:  this.defaultEvent, paramaters:  new System.Collections.Generic.Dictionary<System.String, System.Object>());
        }
    
    }

}
