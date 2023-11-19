using UnityEngine;

namespace TzarGames.Endless
{
    public class PlayerCharacter : PlayerCharacterBase, IActionPerformer
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.CharacterCinematic forceGainCinematic;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.ThirdPersonCamera cameraPrefab;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject mapCamera;
        [UnityEngine.SerializeField]
        private UnityEngine.Transform playerLabelPosition;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.PlayerFadeBehaviour fader;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.ActionObjectDetector actionDetector;
        private TzarGames.Endless.XpBoostTimer _xpBoost;
        private TzarGames.Endless.AttackSpeedBoostTimer _attackSpeedBoost;
        private TzarGames.Endless.DefenceBoostTimer _defenceBoostTimer;
        private TzarGames.Endless.SpeedBoostTimer _speedBoostTimer;
        private TzarGames.Endless.DamageBoostTimer _damageBoostTimer;
        private System.Collections.Generic.List<TzarGames.Endless.CharacteristicBoostTimer> boostTimers;
        private float lastHealingPotionUseTime;
        private float healingPotionInterval;
        private int lastActivatedWeaponSlot;
        private TzarGames.Common.SerializableData characterData;
        private TzarGames.Common.RootMovementHandler rootMovementHandler;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.GameFramework.Item, TzarGames.GameFramework.ItemInstance> OnItemUsed;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.TzarHero.ICharacterDamageInfo> OnHitBlockedByShield;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.Endless.ThirdPersonCamera <PlayerCamera>k__BackingField;
        private System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> allies;
        
        // Properties
        public TzarGames.TzarHero.CharacterCinematic ForceGainCinematic { get; }
        public TzarGames.GameFramework.ActionObjectDetector ActionDetector { get; }
        public UnityEngine.Transform PlayerLabelPosition { get; }
        public TzarGames.Endless.XpBoostTimer XpBoostTimer { get; }
        public TzarGames.Endless.AttackSpeedBoostTimer AttackSpeedBoost { get; }
        public TzarGames.Endless.DefenceBoostTimer DefenceeBoost { get; }
        public TzarGames.Endless.SpeedBoostTimer SpeedBoost { get; }
        public TzarGames.Endless.DamageBoostTimer DamageBoost { get; }
        public ulong Gold { get; set; }
        public TzarGames.Endless.PlayerFadeBehaviour Fader { get; }
        public TzarGames.Endless.ThirdPersonCamera PlayerCamera { get; set; }
        public System.Collections.Generic.IEnumerable<TzarGames.TzarHero.TH_Character> Allies { get; }
        public float HealingPotionCooldownTime { get; }
        
        // Methods
        public PlayerCharacter()
        {
            this.healingPotionInterval = 1f;
            this.boostTimers = new System.Collections.Generic.List<TzarGames.Endless.CharacteristicBoostTimer>();
            this.characterData = new TzarGames.Common.SerializableData();
            this.allies = new System.Collections.Generic.List<TzarGames.TzarHero.TH_Character>();
        }
        public TzarGames.TzarHero.CharacterCinematic get_ForceGainCinematic()
        {
            return (TzarGames.TzarHero.CharacterCinematic)this.forceGainCinematic;
        }
        public TzarGames.GameFramework.ActionObjectDetector get_ActionDetector()
        {
            return (TzarGames.GameFramework.ActionObjectDetector)this.actionDetector;
        }
        public UnityEngine.Transform get_PlayerLabelPosition()
        {
            return (UnityEngine.Transform)this.playerLabelPosition;
        }
        public void add_OnItemUsed(System.Action<TzarGames.GameFramework.Item, TzarGames.GameFramework.ItemInstance> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnItemUsed);
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
            while(this.OnItemUsed != this.OnItemUsed);
        
        }
        public void remove_OnItemUsed(System.Action<TzarGames.GameFramework.Item, TzarGames.GameFramework.ItemInstance> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnItemUsed);
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
            while(this.OnItemUsed != this.OnItemUsed);
        
        }
        public void add_OnHitBlockedByShield(System.Action<TzarGames.TzarHero.ICharacterDamageInfo> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnHitBlockedByShield);
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
            while(this.OnHitBlockedByShield != this.OnHitBlockedByShield);
        
        }
        public void remove_OnHitBlockedByShield(System.Action<TzarGames.TzarHero.ICharacterDamageInfo> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnHitBlockedByShield);
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
            while(this.OnHitBlockedByShield != this.OnHitBlockedByShield);
        
        }
        public TzarGames.Endless.XpBoostTimer get_XpBoostTimer()
        {
            return (TzarGames.Endless.XpBoostTimer)this._xpBoost;
        }
        public TzarGames.Endless.AttackSpeedBoostTimer get_AttackSpeedBoost()
        {
            return (TzarGames.Endless.AttackSpeedBoostTimer)this._attackSpeedBoost;
        }
        public TzarGames.Endless.DefenceBoostTimer get_DefenceeBoost()
        {
            return (TzarGames.Endless.DefenceBoostTimer)this._defenceBoostTimer;
        }
        public TzarGames.Endless.SpeedBoostTimer get_SpeedBoost()
        {
            return (TzarGames.Endless.SpeedBoostTimer)this._speedBoostTimer;
        }
        public TzarGames.Endless.DamageBoostTimer get_DamageBoost()
        {
            return (TzarGames.Endless.DamageBoostTimer)this._damageBoostTimer;
        }
        public ulong get_Gold()
        {
            TzarGames.Endless.EndlessPlayerCharacterTemplate val_1 = this.PlayerTemplateInstance;
            if(val_1 != null)
            {
                    return val_1.Gold;
            }
            
            return val_1.Gold;
        }
        public void set_Gold(ulong value)
        {
            this.PlayerTemplateInstance.Gold = value;
        }
        public TzarGames.Endless.PlayerFadeBehaviour get_Fader()
        {
            return (TzarGames.Endless.PlayerFadeBehaviour)this.fader;
        }
        public TzarGames.Endless.ThirdPersonCamera get_PlayerCamera()
        {
            return (TzarGames.Endless.ThirdPersonCamera)this.<PlayerCamera>k__BackingField;
        }
        private void set_PlayerCamera(TzarGames.Endless.ThirdPersonCamera value)
        {
            this.<PlayerCamera>k__BackingField = value;
        }
        public System.Collections.Generic.IEnumerable<TzarGames.TzarHero.TH_Character> get_Allies()
        {
            return (System.Collections.Generic.IEnumerable<TzarGames.TzarHero.TH_Character>)this.allies;
        }
        public void AddGold(int goldAdd)
        {
            this.PlayerTemplateInstance.AddGold(goldAdd:  goldAdd);
        }
        public void AddAlly(TzarGames.TzarHero.TH_Character character)
        {
            if((this.allies.Contains(item:  character)) != false)
            {
                    return;
            }
            
            this.allies.Add(item:  character);
            character.add_OnComponentDestroy(value:  new TzarGames.GameFramework.dlgTzarDestroy(object:  this, method:  System.Void TzarGames.Endless.PlayerCharacter::onAllyDestroy(TzarGames.GameFramework.TzarBehaviour tzarBehaviour)));
        }
        public void RemoveAlly(TzarGames.TzarHero.TH_Character character)
        {
            if((this.allies.Contains(item:  character)) == false)
            {
                    return;
            }
            
            bool val_2 = this.allies.Remove(item:  character);
            character.remove_OnComponentDestroy(value:  new TzarGames.GameFramework.dlgTzarDestroy(object:  this, method:  System.Void TzarGames.Endless.PlayerCharacter::onAllyDestroy(TzarGames.GameFramework.TzarBehaviour tzarBehaviour)));
        }
        private void onAllyDestroy(TzarGames.GameFramework.TzarBehaviour tzarBehaviour)
        {
            var val_3 = 0;
            bool val_1 = this.allies.Remove(item:  null);
            tzarBehaviour.remove_OnComponentDestroy(value:  new TzarGames.GameFramework.dlgTzarDestroy(object:  this, method:  System.Void TzarGames.Endless.PlayerCharacter::onAllyDestroy(TzarGames.GameFramework.TzarBehaviour tzarBehaviour)));
        }
        public override void SetPlayerData(object data)
        {
            System.Collections.Generic.List<TzarGames.Endless.CharacteristicBoostTimer> val_29;
            float val_30;
            float val_31;
            this.SetPlayerData(data:  data);
            mem[1152921510754928480] = (1 == 1) ? 1 : 0;
            if(this.PlayerOwner != null)
            {
                    this.characterData = 150;
                float val_3 = UnityEngine.Time.time;
                if(this._xpBoost != null)
            {
                    this._xpBoost.RemoveFromCharacter();
                bool val_4 = this.boostTimers.Remove(item:  this._xpBoost);
            }
            
                this._xpBoost = new TzarGames.Endless.XpBoostTimer(character:  this, data:  this.characterData);
                Continue(gameTime:  val_3);
                this.boostTimers.Add(item:  this._xpBoost);
                if(this._attackSpeedBoost != null)
            {
                    this._attackSpeedBoost.RemoveFromCharacter();
                bool val_6 = this.boostTimers.Remove(item:  this._attackSpeedBoost);
            }
            
                this._attackSpeedBoost = new TzarGames.Endless.AttackSpeedBoostTimer(character:  this, data:  this.characterData);
                Continue(gameTime:  val_3);
                this.boostTimers.Add(item:  this._attackSpeedBoost);
                if(this._defenceBoostTimer != null)
            {
                    this._defenceBoostTimer.RemoveFromCharacter();
                bool val_8 = this.boostTimers.Remove(item:  this._defenceBoostTimer);
            }
            
                this._defenceBoostTimer = new TzarGames.Endless.DefenceBoostTimer(character:  this, data:  this.characterData);
                Continue(gameTime:  val_3);
                this.boostTimers.Add(item:  this._defenceBoostTimer);
                if(this._damageBoostTimer != null)
            {
                    this._damageBoostTimer.RemoveFromCharacter();
                bool val_10 = this.boostTimers.Remove(item:  this._damageBoostTimer);
            }
            
                this._damageBoostTimer = new TzarGames.Endless.DamageBoostTimer(character:  this, data:  this.characterData);
                Continue(gameTime:  val_3);
                this.boostTimers.Add(item:  this._damageBoostTimer);
                if(this._speedBoostTimer != null)
            {
                    this._speedBoostTimer.RemoveFromCharacter();
                bool val_12 = this.boostTimers.Remove(item:  this._speedBoostTimer);
            }
            
                this._speedBoostTimer = new TzarGames.Endless.SpeedBoostTimer(character:  this, data:  this.characterData);
                val_30 = val_3;
                Continue(gameTime:  val_30);
                val_29 = this.boostTimers;
                val_29.Add(item:  this._speedBoostTimer);
            }
            
            if(this.Connected == false)
            {
                    return;
            }
            
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {inited = true, fakeValue = false, fakeValueActive = false})) != false)
            {
                    UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
                bool val_20 = this.GotoState<Dead>(stateData:  new TzarGames.TzarHero.DeadEventData(killer:  0, victim:  this, force:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, damageType:  new TzarGames.TzarHero.TH_DamageType_Default(surfaceType:  TzarGames.GameFramework.SurfaceTypeBase.Default)));
                val_30 = 0f;
                this.PlayerTemplateInstance.ActualHitPoints = val_30;
            }
            
            string val_22 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  0);
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    TzarGames.GameFramework.Player val_25 = this.PlayerOwner;
                string val_26 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  0);
                TzarGames.GameFramework.Player.ChangeLogin(player:  0, newLogin:  val_25);
            }
            
            UnityEngine.Vector3 val_27 = val_25.eulerAngles;
            if((1 & 1) != 0)
            {
                    val_31 = 9.416726E-43f;
            }
            else
            {
                    val_31 = 9.416726E-43f;
            }
            
            UnityEngine.Quaternion val_28 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_27.x, y = val_31, z = val_27.z});
            this.SetPositionAndRotation(position:  new UnityEngine.Vector3() {x = 4.991428E+22f, y = 0f, z = 7.300765E-43f}, rotation:  new UnityEngine.Quaternion() {x = val_28.x, y = val_28.y, z = val_28.z, w = val_28.w});
        }
        public override object GetPlayerData()
        {
            var val_6;
            var val_7;
            List.Enumerator<T> val_1 = this.boostTimers.GetEnumerator();
            label_4:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            0.InitializationCallback.SerializeElapsedTime();
            goto label_4;
            label_2:
            val_6 = 0;
            val_7 = 1;
            0.Dispose();
            object val_3 = this.GetPlayerData();
            if(val_3 != null)
            {
                    mem2[0] = this.characterData;
                return val_3;
            }
        
        }
        public override void FillNetData(TzarGames.Endless.EndlessHeroData data)
        {
            this.FillNetData(data:  data);
            if((0 != TzarGames.Endless.SocialSystem.Instance) && (TzarGames.Endless.SocialSystem.Instance.IsAuthenticated != false))
            {
                    string val_6 = TzarGames.Endless.SocialSystem.Instance.GetUserName();
            }
            else
            {
                    string val_8 = this.PlayerOwner.Login;
            }
            
            data.Net_PlayerName = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  0);
            UnityEngine.Vector3 val_10 = this.Position;
            mem2[0] = val_10.z;
            data.Net_Position = val_10;
            mem2[0] = val_10.y;
            UnityEngine.Vector3 val_11 = this.eulerAngles;
            data.Net_Yaw = val_11.y;
        }
        protected override void PlayAttackEffects()
        {
            TzarGames.TzarHero.CharacterAnimationBase val_1 = this.Animation;
            int val_2 = UnityEngine.Random.Range(min:  0, max:  0);
            float val_5 = 1f;
            val_5 = val_5 / this.TemplateInstance.AttackSpeed;
            goto typeof(TzarGames.TzarHero.CharacterAnimationBase).__il2cppRuntimeField_1E0;
        }
        protected override void HandleItemUsedEvent(TzarGames.GameFramework.Item item, TzarGames.GameFramework.ItemInstance instance)
        {
            this.HandleItemUsedEvent(item:  item, instance:  instance);
            if((item != null) && ((item & 1) != 0))
            {
                    this.lastHealingPotionUseTime = UnityEngine.Time.time;
            }
            
            if(this.OnItemUsed == null)
            {
                    return;
            }
            
            this.OnItemUsed.Invoke(arg1:  item, arg2:  instance);
        }
        public override void SetPlayerOwner(TzarGames.GameFramework.Player owner)
        {
            UnityEngine.Transform val_8;
            this.SetPlayerOwner(owner:  owner);
            if((owner != null) && (owner.itsMe != false))
            {
                    val_8 = 1152921504721543168;
                if(0 == (this.<PlayerCamera>k__BackingField))
            {
                    Unitycoding.UIWidgets.RadialMenuItem val_3 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
                this.<PlayerCamera>k__BackingField = val_3;
                val_8 = this.transform;
                val_3.Target = val_8;
            }
            
                this.mapCamera.gameObject.SetActive(value:  true);
                this.mapCamera.transform.SetParent(parent:  0);
                return;
            }
            
            this.mapCamera.gameObject.SetActive(value:  false);
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            if(0 != (this.<PlayerCamera>k__BackingField))
            {
                    UnityEngine.GameObject val_2 = this.<PlayerCamera>k__BackingField.gameObject;
                UnityEngine.Object.Destroy(obj:  0);
            }
            
            if(0 == this.mapCamera)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  0);
        }
        public float get_HealingPotionCooldownTime()
        {
            float val_1 = UnityEngine.Time.time;
            val_1 = val_1 - this.lastHealingPotionUseTime;
            float val_3 = UnityEngine.Mathf.Clamp01(value:  val_1 / this.healingPotionInterval);
            val_3 = 1f - val_3;
            return (float)val_3;
        }
        public override bool CanUseItem(TzarGames.GameFramework.Item item)
        {
            var val_7;
            var val_8;
            val_7 = this;
            if((this.CanUseItem(item:  item)) == false)
            {
                goto label_7;
            }
            
            if((item == null) || ((item & 1) == 0))
            {
                goto label_5;
            }
            
            val_7 = this.PlayerTemplateInstance;
            float val_5 = val_7.HealingPotionUsageInterval;
            if((UnityEngine.Time.time - this.lastHealingPotionUseTime) < 0)
            {
                goto label_7;
            }
            
            label_5:
            val_8 = 1;
            return (bool)val_8;
            label_7:
            val_8 = 0;
            return (bool)val_8;
        }
        public override void ModifyDamageInfo(TzarGames.TzarHero.CharacterDamageInfo damageInfo)
        {
            float val_16;
            float val_17;
            float val_18;
            TzarGames.Endless.EndlessPlayerCharacterTemplate val_1 = this.PlayerTemplateInstance;
            if(0 != val_1)
            {
                    UnityEngine.Vector3 val_3 = damageInfo.Force;
                val_16 = val_3.x;
                val_17 = val_3.z;
                if(val_1.ShieldInstance != null)
            {
                    UnityEngine.Vector3 val_5 = this.ForwardDirection;
                val_18 = val_16;
                if((UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_18, y = val_3.y, z = val_17}, rhs:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z})) < 0)
            {
                    val_16 = val_1.BlockChance;
                val_18 = 0f;
                if((UnityEngine.Random.Range(min:  val_18, max:  100f)) < 0)
            {
                    if(this.OnHitBlockedByShield != null)
            {
                    this.OnHitBlockedByShield.Invoke(obj:  damageInfo);
            }
            
                damageInfo.Damage = 0f;
                return;
            }
            
            }
            
            }
            
                if(damageInfo.IsCritical != false)
            {
                    float val_11 = val_1.CritResistance;
                val_11 = val_11 * (-0.01f);
                val_11 = val_11 + 1f;
                val_16 = damageInfo.CriticalDamage * val_11;
                if(damageInfo != null)
            {
                    float val_13 = damageInfo.CriticalDamage;
                val_13 = val_13 - val_16;
                val_13 = damageInfo.Damage - val_13;
                damageInfo.Damage = val_13;
            }
            else
            {
                    float val_15 = 0.CriticalDamage;
                val_17 = val_15;
                val_15 = val_17 - val_16;
                val_15 = damageInfo.Damage - val_15;
                damageInfo.Damage = val_15;
            }
            
                damageInfo.CriticalDamage = val_16;
            }
            
            }
            
            this.ModifyDamageInfo(damageInfo:  damageInfo);
        }
        protected override void OnTemplateInstanceCreated()
        {
            this.OnTemplateInstanceCreated();
            this.healingPotionInterval = this.PlayerTemplateInstance.HealingPotionUsageInterval;
        }
        public TzarGames.GameFramework.Weapon ActivateWeaponModificators(int slot)
        {
            UnityEngine.Object val_13;
            var val_15;
            if(slot != 0)
            {
                    TzarGames.GameFramework.Weapon val_1 = this.SecondWeapon;
            }
            else
            {
                    TzarGames.GameFramework.Weapon val_2 = this.ActiveWeaponTemplate;
            }
            
            TzarGames.GameFramework.Weapon val_3 = this.SecondWeapon;
            if(0 != val_2)
            {
                goto label_5;
            }
            
            val_13 = this.TemplateInstance;
            TzarGames.GameFramework.Weapon val_6 = this.ActiveWeaponTemplate;
            goto label_6;
            label_5:
            val_13 = this.SecondWeapon;
            val_15 = 0;
            if(0 == val_13)
            {
                goto label_9;
            }
            
            val_13 = this.TemplateInstance;
            TzarGames.GameFramework.Weapon val_10 = this.SecondWeapon;
            label_6:
            label_9:
            if(this.TemplateInstance != null)
            {
                    return val_2;
            }
            
            return val_2;
        }
        protected override void StartAnimBasedAttack()
        {
            TzarGames.TzarHero.TH_Character val_13;
            if((this.PlayerTemplateInstance.Class != 1) || (0 == this.SecondWeapon))
            {
                goto label_5;
            }
            
            val_13 = this.Target;
            val_13 = 0;
            this.AnimBasedCombatSystem.StartAttack(speedScale:  this.TemplateInstance.AttackSpeed, target:  val_13, weapon:  this.ActivateWeaponModificators(slot:  this.lastActivatedWeaponSlot), attackRangeMultiplier:  1f, attackAnimName:  (this.lastActivatedWeaponSlot == 0) ? "Dualist attack 1" : "Dualist attack 2");
            if(this.lastActivatedWeaponSlot == 0)
            {
                goto label_11;
            }
            
            this.lastActivatedWeaponSlot = 0;
            return;
            label_5:
            this.StartAnimBasedAttack();
            return;
            label_11:
            this.lastActivatedWeaponSlot = 1;
        }
        protected override void Update()
        {
            var val_4;
            this.Update();
            val_4 = 0;
            goto label_1;
            label_6:
            X21.Update(gameTime:  UnityEngine.Time.time);
            val_4 = 1;
            label_1:
            if(val_4 >= this.boostTimers.Count)
            {
                    return;
            }
            
            if(this.boostTimers.Item[1] != null)
            {
                goto label_6;
            }
            
            goto label_6;
        }
        protected override void OnItemActivated(TzarGames.GameFramework.ItemInstance itemInstance, TzarGames.TzarHero.ItemActivationInfo info)
        {
            TzarGames.GameFramework.ItemInstance val_12;
            object val_13;
            TzarGames.Common.RootMovementHandler val_14;
            System.Action<UnityEngine.Vector3, UnityEngine.Quaternion> val_15;
            val_12 = itemInstance;
            val_13 = this;
            this.OnItemActivated(itemInstance:  val_12, info:  info);
            if(val_12.GetOriginalTemplate() == null)
            {
                    return;
            }
            
            if(info.IsActive == false)
            {
                    return;
            }
            
            val_14 = 1152921504721543168;
            if(0 == this.rootMovementHandler)
            {
                goto label_9;
            }
            
            val_12 = System.Void TzarGames.Endless.PlayerCharacter::OnAnimatorMoveHandler(UnityEngine.Vector3 deltaPosition, UnityEngine.Quaternion deltaRotation);
            System.Action<UnityEngine.Vector3, UnityEngine.Quaternion> val_4 = new System.Action<UnityEngine.Vector3, UnityEngine.Quaternion>(object:  this, method:  val_12);
            val_15 = System.Delegate.Remove(source:  0, value:  this.rootMovementHandler.OnAnimatorMoveEvent);
            if(val_15 != null)
            {
                    if(null == null)
            {
                goto label_13;
            }
            
            }
            
            val_15 = 0;
            label_13:
            this.rootMovementHandler.OnAnimatorMoveEvent = val_15;
            label_9:
            if(!=0)
            {
                    if((???) != 0)
            {
                goto label_15;
            }
            
            }
            
            label_15:
            TzarGames.Common.RootMovementHandler val_7 = 0.GetComponent<TzarGames.Common.RootMovementHandler>();
            this.rootMovementHandler = val_7;
            if(0 == val_7)
            {
                    return;
            }
            
            val_14 = this.rootMovementHandler;
            val_12 = System.Void TzarGames.Endless.PlayerCharacter::OnAnimatorMoveHandler(UnityEngine.Vector3 deltaPosition, UnityEngine.Quaternion deltaRotation);
            System.Action<UnityEngine.Vector3, UnityEngine.Quaternion> val_9 = new System.Action<UnityEngine.Vector3, UnityEngine.Quaternion>(object:  this, method:  val_12);
            val_13 = System.Delegate.Combine(a:  0, b:  this.rootMovementHandler.OnAnimatorMoveEvent);
            if(val_13 == null)
            {
                goto label_21;
            }
            
            if(null == null)
            {
                goto label_22;
            }
            
            label_21:
            val_13 = 0;
            label_22:
            this.rootMovementHandler.OnAnimatorMoveEvent = val_13;
        }
        private void OnAnimatorMoveHandler(UnityEngine.Vector3 deltaPosition, UnityEngine.Quaternion deltaRotation)
        {
            var val_3;
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = this.Movement;
        }
        public override void OnPushedToPool()
        {
            IntPtr val_10;
            System.Action<UnityEngine.Vector3, UnityEngine.Quaternion> val_11;
            this.OnPushedToPool();
            if(this.allies != null)
            {
                    this.allies.Clear();
            }
            
            if(0 != (this.<PlayerCamera>k__BackingField))
            {
                    UnityEngine.GameObject val_2 = this.<PlayerCamera>k__BackingField.gameObject;
                UnityEngine.Object.Destroy(obj:  0);
            }
            
            if(0 != this.mapCamera)
            {
                    this.mapCamera.gameObject.SetActive(value:  false);
                val_10 = this.mapCamera.transform;
                val_10.SetParent(parent:  this.mapCamera);
            }
            
            this._damageBoostTimer = 0;
            this._speedBoostTimer = 0;
            this._defenceBoostTimer = 0;
            this._attackSpeedBoost = 0;
            this._xpBoost = 0;
            if(this.boostTimers != null)
            {
                    this.boostTimers.Clear();
            }
            
            this.lastHealingPotionUseTime = 0f;
            if(0 == this.rootMovementHandler)
            {
                    return;
            }
            
            val_10 = System.Void TzarGames.Endless.PlayerCharacter::OnAnimatorMoveHandler(UnityEngine.Vector3 deltaPosition, UnityEngine.Quaternion deltaRotation);
            System.Action<UnityEngine.Vector3, UnityEngine.Quaternion> val_7 = new System.Action<UnityEngine.Vector3, UnityEngine.Quaternion>(object:  this, method:  val_10);
            val_11 = System.Delegate.Remove(source:  0, value:  this.rootMovementHandler.OnAnimatorMoveEvent);
            if(val_11 != null)
            {
                    if(null == null)
            {
                goto label_22;
            }
            
            }
            
            val_11 = 0;
            label_22:
            this.rootMovementHandler.OnAnimatorMoveEvent = val_11;
            this.rootMovementHandler = 0;
        }
    
    }

}
