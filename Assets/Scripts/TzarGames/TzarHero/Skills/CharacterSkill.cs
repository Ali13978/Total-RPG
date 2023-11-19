using UnityEngine;

namespace TzarGames.TzarHero.Skills
{
    public class CharacterSkill : Skill
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Sprite icon;
        [UnityEngine.SerializeField]
        private UnityEngine.Sprite disabledIcon;
        [UnityEngine.SerializeField]
        private bool hasCoolDown;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Characteristic _cooldownCharacteristic;
        [UnityEngine.SerializeField]
        private bool rotateToTarget;
        private float lastUsedTime;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.TzarHero.TH_Character <Character>k__BackingField;
        private System.Action pendingAction;
        private float waitTime;
        private float waitStartTime;
        private float currentCooldown;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject[] objectsToSpawnOnStart;
        [UnityEngine.SerializeField]
        private bool destroyObjectsOnFailStop;
        private System.Collections.Generic.List<UnityEngine.GameObject> spawnedObjects;
        
        // Properties
        public TzarGames.TzarHero.TH_Character Character { get; set; }
        public UnityEngine.Sprite Icon { get; }
        public UnityEngine.Sprite DisabledIcon { get; }
        public TzarGames.GameFramework.Characteristic CooldownCharacteristic { get; }
        public bool RotateToTarget { get; }
        public bool IsCoolDowned { get; }
        public float CooldownTimeNormalized { get; }
        public float BaseCooldown { get; }
        
        // Methods
        public CharacterSkill()
        {
            this.hasCoolDown = true;
            this.destroyObjectsOnFailStop = true;
            this.spawnedObjects = new System.Collections.Generic.List<UnityEngine.GameObject>();
            this = new TzarGames.GameFramework.DatabaseRecord();
        }
        public TzarGames.TzarHero.TH_Character get_Character()
        {
            return (TzarGames.TzarHero.TH_Character)this.<Character>k__BackingField;
        }
        private void set_Character(TzarGames.TzarHero.TH_Character value)
        {
            this.<Character>k__BackingField = value;
        }
        public UnityEngine.Sprite get_Icon()
        {
            return (UnityEngine.Sprite)this.icon;
        }
        public UnityEngine.Sprite get_DisabledIcon()
        {
            return (UnityEngine.Sprite)this.disabledIcon;
        }
        public TzarGames.GameFramework.Characteristic get_CooldownCharacteristic()
        {
            return (TzarGames.GameFramework.Characteristic)this._cooldownCharacteristic;
        }
        public bool get_RotateToTarget()
        {
            return (bool)this.rotateToTarget;
        }
        public override void OnInitialize()
        {
            this._cooldownCharacteristic.Init();
            this._cooldownCharacteristic.minValue = 0f;
            this._cooldownCharacteristic.clampMinimum = true;
            this._cooldownCharacteristic.applyModificatorsWhenBaseIsLessOrEqualZero = true;
        }
        public void SetCharacter(TzarGames.TzarHero.TH_Character character)
        {
            var val_10;
            TzarGames.TzarHero.TH_Character val_11;
            var val_12;
            val_10 = this;
            if(0 == (this.<Character>k__BackingField))
            {
                    return;
            }
            
            val_11 = this.<Character>k__BackingField;
            this.<Character>k__BackingField = character;
            val_12 = 0;
            if(0 != character)
            {
                    val_10 = ???;
                val_11 = ???;
            }
        
        }
        protected virtual void OnCharacterAssigned()
        {
        
        }
        protected virtual void OnCharacterRemoved(TzarGames.TzarHero.TH_Character character)
        {
        
        }
        public virtual bool OverrideTakenDamage(TzarGames.TzarHero.ICharacterDamageInfo damageInfo, out float newDamage)
        {
            newDamage = 0f;
            return false;
        }
        public bool get_IsCoolDowned()
        {
            return (bool)(System.Math.Abs(this.currentCooldown) < 0) ? 1 : 0;
        }
        public float get_CooldownTimeNormalized()
        {
            float val_1 = this._cooldownCharacteristic.Value;
            val_1 = this.currentCooldown / val_1;
            return UnityEngine.Mathf.Clamp01(value:  val_1);
        }
        public float get_BaseCooldown()
        {
            if(this._cooldownCharacteristic != null)
            {
                    return this._cooldownCharacteristic.Value;
            }
            
            return this._cooldownCharacteristic.Value;
        }
        public override bool Validate()
        {
            if(this.hasCoolDown == false)
            {
                    return true;
            }
            
            if(this.IsCoolDowned == false)
            {
                    return false;
            }
            
            return true;
        }
        protected override void OnStarted()
        {
            var val_7;
            var val_8;
            val_7 = this;
            this.lastUsedTime = UnityEngine.Time.time;
            this.currentCooldown = this._cooldownCharacteristic.Value;
            val_8 = 0;
            goto label_2;
            label_13:
            val_8 = 1;
            label_2:
            if(val_8 >= this.objectsToSpawnOnStart.Length)
            {
                    return;
            }
            
            UnityEngine.GameObject val_7 = this.objectsToSpawnOnStart[1];
            UnityEngine.Vector3 val_3 = this.<Character>k__BackingField.Position;
            UnityEngine.Quaternion val_5 = this.<Character>k__BackingField.transform.rotation;
            this.spawnedObjects.Add(item:  UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w}));
            goto label_13;
        }
        protected override void OnStopped()
        {
            var val_5;
            if((true != 0) || (this.destroyObjectsOnFailStop == false))
            {
                goto label_5;
            }
            
            val_5 = 0;
            goto label_3;
            label_12:
            val_5 = 1;
            label_3:
            if(val_5 >= this.spawnedObjects.Count)
            {
                goto label_5;
            }
            
            if(0 == this.spawnedObjects.Item[1])
            {
                goto label_12;
            }
            
            UnityEngine.Object.Destroy(obj:  0);
            goto label_12;
            label_5:
            this.spawnedObjects.Clear();
        }
        public void WaitAndDoAction(float timeToWait, System.Action action)
        {
            this.pendingAction = action;
            this.waitTime = timeToWait;
            this.waitStartTime = UnityEngine.Time.time;
        }
        public virtual void UpdateSkill(float deltaTime)
        {
            this._cooldownCharacteristic.Update();
            float val_1 = this._cooldownCharacteristic.Value;
            if(this.hasCoolDown == false)
            {
                    return;
            }
            
            if(this.currentCooldown <= 0f)
            {
                    return;
            }
            
            float val_2 = UnityEngine.Time.time;
            val_2 = val_2 - this.lastUsedTime;
            val_2 = val_1 - val_2;
            this.currentCooldown = UnityEngine.Mathf.Clamp(value:  val_2, min:  0f, max:  val_1);
        }
        protected void ResetCooldownTime()
        {
            this.lastUsedTime = UnityEngine.Time.time;
        }
        public virtual void UpdatePerformingSkill(float deltaTime)
        {
            if(this.pendingAction == null)
            {
                    return;
            }
            
            float val_1 = UnityEngine.Time.time;
            val_1 = val_1 - this.waitStartTime;
            if(val_1 < this.waitTime)
            {
                    return;
            }
            
            this.pendingAction.Invoke();
            this.pendingAction = 0;
        }
        protected void SendNetMessage(byte messageCode, TzarGames.GameFramework.TzarRPCModes mode, object[] parameters)
        {
            this.<Character>k__BackingField.SendSkillNetMessage(skillId:  this.Id, messageCode:  messageCode, mode:  mode, parameters:  parameters);
        }
        public virtual void OnNetMessage(byte messageCode, object[] parameters)
        {
        
        }
        public override void ResetSkill()
        {
            if(W8 != 0)
            {
                    mem[1152921511520485048] = 0;
            }
            
            this.lastUsedTime = 0f;
            this.currentCooldown = 0f;
            this.pendingAction = 0;
            this.waitTime = 0f;
            this.waitStartTime = 0f;
        }
    
    }

}
