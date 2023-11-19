using UnityEngine;

namespace LlockhamIndustries.Decals
{
    public abstract class Modifier : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private LlockhamIndustries.Decals.Frequency frequency;
        
        // Properties
        public LlockhamIndustries.Decals.Frequency Frequency { get; set; }
        protected float UpdateRate { get; }
        
        // Methods
        protected Modifier()
        {
        
        }
        public LlockhamIndustries.Decals.Frequency get_Frequency()
        {
            return (LlockhamIndustries.Decals.Frequency)this.frequency;
        }
        public void set_Frequency(LlockhamIndustries.Decals.Frequency value)
        {
            if(this.frequency == value)
            {
                    return;
            }
            
            this.Deregister();
            this.frequency = value;
            this.Register();
        }
        protected float get_UpdateRate()
        {
            if(this.frequency == 1)
            {
                    return 0.1f;
            }
            
            if(this.frequency != 2)
            {
                    return UnityEngine.Time.deltaTime;
            }
            
            return 1f;
        }
        protected virtual void OnEnable()
        {
            this.Register();
        }
        protected virtual void OnDisable()
        {
            this.Deregister();
        }
        private void Register()
        {
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            bool val_3 = this.gameObject.activeInHierarchy;
            if(val_3 == false)
            {
                    return;
            }
            
            LlockhamIndustries.Decals.ModifierManager.Register(p_Modifier:  val_3);
        }
        private void Deregister()
        {
            bool val_1 = UnityEngine.Application.isPlaying;
            if(val_1 == false)
            {
                    return;
            }
            
            LlockhamIndustries.Decals.ModifierManager.Deregister(p_Modifier:  val_1);
        }
        protected abstract void Begin(); // 0
        public abstract void Perform(); // 0
    
    }

}
