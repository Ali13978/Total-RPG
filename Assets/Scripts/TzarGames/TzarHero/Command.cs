using UnityEngine;

namespace TzarGames.TzarHero
{
    public abstract class Command
    {
        // Fields
        private bool completed;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.TzarHero.Command.dlgOnCompleted OnComplete;
        
        // Methods
        protected Command()
        {
        
        }
        public abstract void Start(); // 0
        public abstract void Stop(); // 0
        public void add_OnComplete(TzarGames.TzarHero.Command.dlgOnCompleted value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnComplete);
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
            while(1152921511482078424 != this.OnComplete);
        
        }
        public void remove_OnComplete(TzarGames.TzarHero.Command.dlgOnCompleted value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnComplete);
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
            while(1152921511482215000 != this.OnComplete);
        
        }
        public void MarkAsCompleted()
        {
            this.completed = true;
            if(this.OnComplete == null)
            {
                    return;
            }
            
            this.OnComplete.Invoke(completedCommand:  this);
        }
        public bool IsCompleted()
        {
            return (bool)this.completed;
        }
        public void Reset()
        {
            this.completed = false;
        }
    
    }

}
