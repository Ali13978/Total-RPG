using UnityEngine;

namespace TzarGames.GameFramework.Skills
{
    public class Skill : DatabaseRecord
    {
        // Fields
        [UnityEngine.HideInInspector]
        [UnityEngine.SerializeField]
        private int id;
        [UnityEngine.SerializeField]
        private string skillName;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <IsPerforming>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <Finished>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.GameFramework.Skills.Skill> OnFinished;
        
        // Properties
        public override int Id { get; set; }
        public string Name { get; set; }
        public bool IsPerforming { get; set; }
        public bool Finished { get; set; }
        
        // Methods
        public Skill()
        {
        
        }
        public override int get_Id()
        {
            return (int)this.id;
        }
        public override void set_Id(int value)
        {
            this.id = value;
        }
        public string get_Name()
        {
            return (string)this.skillName;
        }
        public void set_Name(string value)
        {
            this.skillName = value;
        }
        public bool get_IsPerforming()
        {
            return (bool)this.<IsPerforming>k__BackingField;
        }
        private void set_IsPerforming(bool value)
        {
            this.<IsPerforming>k__BackingField = value;
        }
        public bool get_Finished()
        {
            return (bool)this.<Finished>k__BackingField;
        }
        private void set_Finished(bool value)
        {
            this.<Finished>k__BackingField = value;
        }
        public void add_OnFinished(System.Action<TzarGames.GameFramework.Skills.Skill> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnFinished);
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
            while(1152921511436212080 != this.OnFinished);
        
        }
        public void remove_OnFinished(System.Action<TzarGames.GameFramework.Skills.Skill> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnFinished);
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
            while(1152921511436348656 != this.OnFinished);
        
        }
        public virtual void OnInitialize()
        {
        
        }
        public virtual bool Validate()
        {
            return true;
        }
        public virtual void OnValidationFailed()
        {
        
        }
        public void Start()
        {
            if((this.<IsPerforming>k__BackingField) != false)
            {
                    return;
            }
            
            this.<IsPerforming>k__BackingField = true;
            this.<Finished>k__BackingField = false;
            goto typeof(TzarGames.GameFramework.Skills.Skill).__il2cppRuntimeField_1B0;
        }
        public void Stop()
        {
            if((this.<IsPerforming>k__BackingField) == false)
            {
                    return;
            }
            
            this.<IsPerforming>k__BackingField = false;
            goto typeof(TzarGames.GameFramework.Skills.Skill).__il2cppRuntimeField_1C0;
        }
        public virtual void ResetSkill()
        {
            if((this.<IsPerforming>k__BackingField) == false)
            {
                    return;
            }
            
            this.<IsPerforming>k__BackingField = false;
            goto typeof(TzarGames.GameFramework.Skills.Skill).__il2cppRuntimeField_1C0;
        }
        protected virtual void OnStarted()
        {
        
        }
        protected virtual void OnStopped()
        {
        
        }
        protected void Finish()
        {
            this.<Finished>k__BackingField = true;
            if((this.<IsPerforming>k__BackingField) != false)
            {
                    this.<IsPerforming>k__BackingField = false;
            }
            
            if(this.OnFinished == null)
            {
                    return;
            }
            
            this.OnFinished.Invoke(obj:  this);
        }
    
    }

}
