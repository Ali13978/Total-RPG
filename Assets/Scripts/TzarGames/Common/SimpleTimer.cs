using UnityEngine;

namespace TzarGames.Common
{
    public class SimpleTimer
    {
        // Fields
        public int TickCount;
        public float TickInterval;
        private float lastTickTime;
        private int currentTickCount;
        private float pauseTime;
        private bool paused;
        private bool stopped;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.Common.SimpleTimer.TimerTickDelegate OnTimerTick;
        
        // Properties
        public bool IsPaused { get; }
        public bool IsStopped { get; }
        
        // Methods
        public SimpleTimer()
        {
            this.TickCount = 1;
            this.TickInterval = 1f;
        }
        public void add_OnTimerTick(TzarGames.Common.SimpleTimer.TimerTickDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnTimerTick);
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
            while(1152921511207090680 != this.OnTimerTick);
        
        }
        public void remove_OnTimerTick(TzarGames.Common.SimpleTimer.TimerTickDelegate value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnTimerTick);
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
            while(1152921511207227256 != this.OnTimerTick);
        
        }
        public bool get_IsPaused()
        {
            return (bool)this.paused;
        }
        public bool get_IsStopped()
        {
            return (bool)this.stopped;
        }
        public void Start()
        {
            this.paused = false;
            this.stopped = false;
            this.lastTickTime = UnityEngine.Time.time;
            this.currentTickCount = 0;
        }
        public void Pause()
        {
            this.paused = true;
            this.pauseTime = UnityEngine.Time.time;
        }
        public void Resume()
        {
            this.paused = false;
            float val_1 = UnityEngine.Time.time;
            val_1 = val_1 - this.pauseTime;
            val_1 = this.lastTickTime + val_1;
            this.lastTickTime = val_1;
        }
        public void Update()
        {
            if((this.paused & 255) == true)
            {
                    return;
            }
            
            if(this.paused > true)
            {
                    return;
            }
            
            float val_2 = UnityEngine.Time.time;
            val_2 = val_2 - this.lastTickTime;
            if(val_2 < this.TickInterval)
            {
                    return;
            }
            
            int val_4 = this.currentTickCount;
            this.lastTickTime = UnityEngine.Time.time;
            val_4 = val_4 + 1;
            this.currentTickCount = val_4;
            if(val_4 >= this.TickCount)
            {
                    this.stopped = true;
            }
            
            if(this.OnTimerTick == null)
            {
                    return;
            }
            
            this.OnTimerTick.Invoke(timer:  this);
        }
        public void ResetTicks()
        {
            this.currentTickCount = 0;
        }
    
    }

}
