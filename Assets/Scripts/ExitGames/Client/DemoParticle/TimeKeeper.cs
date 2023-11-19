using UnityEngine;

namespace ExitGames.Client.DemoParticle
{
    public class TimeKeeper
    {
        // Fields
        private int lastExecutionTime;
        private bool shouldExecute;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private int <Interval>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <IsEnabled>k__BackingField;
        
        // Properties
        public int Interval { get; set; }
        public bool IsEnabled { get; set; }
        public bool ShouldExecute { get; set; }
        
        // Methods
        public TimeKeeper(int interval)
        {
            this.lastExecutionTime = System.Environment.TickCount;
            this.<Interval>k__BackingField = interval;
            this.<IsEnabled>k__BackingField = true;
        }
        public int get_Interval()
        {
            return (int)this.<Interval>k__BackingField;
        }
        public void set_Interval(int value)
        {
            this.<Interval>k__BackingField = value;
        }
        public bool get_IsEnabled()
        {
            return (bool)this.<IsEnabled>k__BackingField;
        }
        public void set_IsEnabled(bool value)
        {
            this.<IsEnabled>k__BackingField = value;
        }
        public bool get_ShouldExecute()
        {
            var val_3;
            if((this.<IsEnabled>k__BackingField) == false)
            {
                goto label_0;
            }
            
            if(this.shouldExecute == false)
            {
                goto label_1;
            }
            
            val_3 = 1;
            return (bool)(val_3 > (this.<Interval>k__BackingField)) ? 1 : 0;
            label_0:
            val_3 = 0;
            return (bool)(val_3 > (this.<Interval>k__BackingField)) ? 1 : 0;
            label_1:
            int val_3 = this.lastExecutionTime;
            val_3 = System.Environment.TickCount - val_3;
            return (bool)(val_3 > (this.<Interval>k__BackingField)) ? 1 : 0;
        }
        public void set_ShouldExecute(bool value)
        {
            this.shouldExecute = value;
        }
        public void Reset()
        {
            this.shouldExecute = false;
            this.lastExecutionTime = System.Environment.TickCount;
        }
    
    }

}
