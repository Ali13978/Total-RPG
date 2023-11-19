using UnityEngine;

namespace TzarGames.Common
{
    public class TriggerEventHandler : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private bool triggerOnce;
        [UnityEngine.SerializeField]
        private bool callEventsOnUpdate;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onTriggerEnter;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onTriggerExit;
        private bool triggered;
        private UnityEngine.Collider lastTouchedCollider;
        private bool pedningCallEnter;
        private bool pedningCallExit;
        
        // Properties
        public UnityEngine.Events.UnityEvent OnEnterToTrigger { get; }
        public UnityEngine.Events.UnityEvent OnExitFromTrigger { get; }
        
        // Methods
        public TriggerEventHandler()
        {
            this.triggerOnce = true;
            this.callEventsOnUpdate = true;
        }
        public UnityEngine.Events.UnityEvent get_OnEnterToTrigger()
        {
            return (UnityEngine.Events.UnityEvent)this.onTriggerEnter;
        }
        public UnityEngine.Events.UnityEvent get_OnExitFromTrigger()
        {
            return (UnityEngine.Events.UnityEvent)this.onTriggerExit;
        }
        private void Update()
        {
            bool val_2;
            if(this.callEventsOnUpdate == false)
            {
                    return;
            }
            
            if((this.pedningCallEnter & 255) != false)
            {
                    this.pedningCallEnter = false;
                this.onTriggerEnter.Invoke();
                val_2 = this.pedningCallExit;
            }
            else
            {
                    val_2 = this.pedningCallEnter >> 8;
            }
            
            if(val_2 == false)
            {
                    return;
            }
            
            this.pedningCallExit = false;
            this.onTriggerExit.Invoke();
        }
        private void OnTriggerEnter(UnityEngine.Collider other)
        {
            if((this.triggerOnce & 255) != false)
            {
                    if(this.triggered == true)
            {
                    return;
            }
            
                this.triggered = true;
                this.lastTouchedCollider = other;
            }
            
            if(this.triggerOnce < true)
            {
                    this.onTriggerEnter.Invoke();
                return;
            }
            
            this.pedningCallEnter = true;
        }
        private void OnTriggerExit(UnityEngine.Collider other)
        {
            UnityEngine.Collider val_4;
            bool val_5;
            if((this.triggerOnce & 255) != false)
            {
                    val_4 = this.lastTouchedCollider;
                if(0 != val_4)
            {
                    return;
            }
            
                val_5 = this.callEventsOnUpdate;
                this.lastTouchedCollider = 0;
            }
            else
            {
                    val_5 = this.triggerOnce >> 8;
            }
            
            if(val_5 != false)
            {
                    this.pedningCallExit = true;
                return;
            }
            
            this.onTriggerExit.Invoke();
        }
    
    }

}
