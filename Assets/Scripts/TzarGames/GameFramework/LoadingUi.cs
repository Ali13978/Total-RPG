using UnityEngine;

namespace TzarGames.GameFramework
{
    public class LoadingUi : MonoBehaviour
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private float <Progress>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <ShowProgress>k__BackingField;
        
        // Properties
        public virtual float Progress { get; set; }
        public virtual bool ShowProgress { get; set; }
        
        // Methods
        public LoadingUi()
        {
        
        }
        public virtual float get_Progress()
        {
            return (float)this.<Progress>k__BackingField;
        }
        public virtual void set_Progress(float value)
        {
            this.<Progress>k__BackingField = value;
        }
        public virtual bool get_ShowProgress()
        {
            return (bool)this.<ShowProgress>k__BackingField;
        }
        public virtual void set_ShowProgress(bool value)
        {
            this.<ShowProgress>k__BackingField = value;
        }
    
    }

}
