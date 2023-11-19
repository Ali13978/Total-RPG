using UnityEngine;

namespace TzarGames.Endless.Skills
{
    public class DualistBreakthrough : AnimationBasedSkill, IDamageSkill
    {
        // Fields
        [UnityEngine.SerializeField]
        private string layerName;
        [UnityEngine.SerializeField]
        private float radius;
        [UnityEngine.SerializeField]
        private float attackForceMultiplier;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.CharacteristicModificator damageModificator;
        private int targetLayer;
        private int prevLayer;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject effect;
        private bool ownerControl;
        private UnityEngine.Transform effectInstance;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private float waveTime;
        [UnityEngine.SerializeField]
        private float waveSpeed;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Item waveArtifact;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject waveArtifactEffect;
        private System.Collections.Generic.List<TzarGames.Endless.Skills.DualistBreakthrough.WaveInfo> waves;
        
        // Properties
        public TzarGames.GameFramework.CharacteristicModificator DamageModificator { get; }
        
        // Methods
        public DualistBreakthrough()
        {
            this.radius = 3f;
            this.attackForceMultiplier = 2000f;
            this.waveTime = 0.5f;
            this.waveSpeed = 2.126765E+38f;
            this.waves = new System.Collections.Generic.List<WaveInfo>();
            this = new TzarGames.TzarHero.Skills.CharacterSkill();
        }
        public TzarGames.GameFramework.CharacteristicModificator get_DamageModificator()
        {
            return (TzarGames.GameFramework.CharacteristicModificator)this.damageModificator;
        }
        public override void OnInitialize()
        {
            this.OnInitialize();
            this.targetLayer = UnityEngine.LayerMask.NameToLayer(layerName:  0);
        }
        protected override void OnStarted()
        {
            var val_22;
            UnityEngine.GameObject val_23;
            this.OnStarted();
            this.Character.CharController.enableOverlapRecovery = false;
            UnityEngine.Vector3 val_4 = this.Character.GetDesiredRotationDirection();
            this.prevLayer = this.Character.gameObject.layer;
            this.Character.gameObject.layer = this.targetLayer;
            if(this.Character.PlayerOwner.itsMe != false)
            {
                    if(this.Character.OnClient != false)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_20 = val_4;
                this.SendNetMessage(messageCode:  1, mode:  5, parameters:  null);
            }
            
            }
            
            if(this.isWaveItemActivated() != false)
            {
                    val_22 = null;
                val_23 = this.waveArtifactEffect;
            }
            else
            {
                    val_22 = null;
                val_23 = this.effect;
            }
            
            UnityEngine.Transform val_17 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0).transform;
            this.effectInstance = val_17;
            val_17.SetParent(parent:  this.Character.transform);
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.zero;
            this.effectInstance.localPosition = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
            UnityEngine.Quaternion val_21 = UnityEngine.Quaternion.identity;
            this.effectInstance.localRotation = new UnityEngine.Quaternion() {x = val_21.x, y = val_21.y, z = val_21.z, w = val_21.w};
        }
        public override void OnNetMessage(byte messageCode, object[] parameters)
        {
            this.OnNetMessage(messageCode:  messageCode, parameters:  parameters);
            if((messageCode & 255) != 0)
            {
                    return;
            }
            
            if(this.IsPerforming == false)
            {
                    return;
            }
            
            this.Finish();
        }
        protected override void OnStopped()
        {
            var val_14;
            this.OnStopped();
            val_14 = this.Character.gameObject;
            val_14.layer = this.prevLayer;
            if(this.Finished != true)
            {
                    val_14 = 1152921504721543168;
                if(0 != this.effectInstance)
            {
                    UnityEngine.GameObject val_6 = this.effectInstance.gameObject;
                UnityEngine.Object.Destroy(obj:  0);
            }
            
            }
            
            if(this.Character.OnServer == false)
            {
                goto label_11;
            }
            
            label_18:
            this.SendNetMessage(messageCode:  0, mode:  4, parameters:  null);
            return;
            label_11:
            if(this.Character.OnClient == false)
            {
                    return;
            }
            
            if(this.ownerControl == false)
            {
                    return;
            }
            
            if(this.Character.PlayerOwner.itsMe == false)
            {
                    return;
            }
            
            goto label_18;
        }
        private bool isWaveItemActivated()
        {
            int val_12;
            var val_13;
            TzarGames.TzarHero.TH_Character val_1 = this.Character;
            val_12 = this.waveArtifact;
            System.Collections.Generic.List<TzarGames.GameFramework.ItemInstance> val_5 = val_1.TemplateInstance.Inventory.DefaultBag.GetAllItemInstancesById(id:  val_12);
            if(val_5 == null)
            {
                goto label_8;
            }
            
            val_13 = 0;
            if(val_5.Count <= 0)
            {
                    return (bool)val_13;
            }
            
            val_12 = 0;
            label_11:
            if(val_12 >= val_5.Count)
            {
                goto label_8;
            }
            
            val_12 = val_12 + 1;
            if((val_1.TemplateInstance.IsItemActivated(item:  val_5.Item[0])) == false)
            {
                goto label_11;
            }
            
            val_13 = 1;
            return (bool)val_13;
            label_8:
            val_13 = 0;
            return (bool)val_13;
        }
        protected override void action(TzarGames.Common.StringID animationEvent)
        {
            float val_25;
            var val_26;
            System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> val_27;
            var val_28;
            var val_29;
            TzarGames.TzarHero.TH_Character val_1 = this.Character;
            if(val_1 != null)
            {
                    val_25 = this.radius;
                val_26 = val_1.GetOtherCharactersInRadius(radius:  val_25);
            }
            else
            {
                    val_25 = this.radius;
                val_26 = 0.GetOtherCharactersInRadius(radius:  val_25);
            }
            
            UnityEngine.Vector3 val_4 = val_1.GroundPivotPosition;
            UnityEngine.Vector3 val_5 = val_1.ForwardDirection;
            bool val_6 = this.isWaveItemActivated();
            val_27 = 0;
            if(val_6 != false)
            {
                    System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> val_7 = null;
                val_27 = val_7;
                val_7 = new System.Collections.Generic.List<TzarGames.TzarHero.TH_Character>();
                this.waves.Add(item:  new WaveInfo() {StartTime = UnityEngine.Time.time, InitialRadius = this.radius, WeaponTemplate = val_1.ActiveWeaponTemplate, IgnoreList = val_27});
            }
            
            val_28 = 1152921510548295440;
            val_29 = 0;
            goto label_7;
            label_25:
            val_29 = 1;
            label_7:
            if(val_29 >= val_26.Count)
            {
                goto label_9;
            }
            
            TzarGames.TzarHero.TH_Character val_11 = val_26.Item[1];
            if(((val_1.isCharacterValidForAttack(character:  val_11)) == false) || ((val_1.TemplateInstance.Group.IsFriendly(group:  val_11.TemplateInstance.Group)) == true))
            {
                goto label_25;
            }
            
            UnityEngine.Vector3 val_19 = val_11.GroundPivotPosition;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            TzarGames.GameFramework.Weapon val_21 = val_1.ActiveWeaponTemplate;
            TzarGames.TzarHero.CharacterDamageInfo val_22 = TzarGames.TzarHero.SimpleMeleeCombatSystem.AdjustMeleeDamageTo(instigator:  0, victim:  val_1, weapon:  val_11, damageForceMultiplier:  mem[1152921510820302372]);
            if(val_6 == false)
            {
                goto label_25;
            }
            
            Add(item:  val_11);
            goto label_25;
            label_9:
            if(0 == 0)
            {
                    return;
            }
            
            val_28 = this.Character;
            val_28.Target = 0;
        }
        public override void UpdateSkill(float deltaTime)
        {
            float val_5;
            float val_6;
            var val_8;
            var val_29;
            int val_30;
            var val_31;
            var val_32;
            var val_33;
            this.UpdateSkill(deltaTime:  deltaTime);
            TzarGames.TzarHero.TH_Character val_2 = this.Character;
            val_30 = this.waves.Count - 1;
            if((val_30 & 2147483648) != 0)
            {
                    return;
            }
            
            val_29 = 1152921510548278032;
            label_30:
            WaveInfo val_4 = this.waves.Item[val_30];
            float val_29 = val_5;
            val_29 = UnityEngine.Time.time - val_29;
            if(val_29 >= this.waveTime)
            {
                goto label_4;
            }
            
            val_29 = val_29 * this.waveSpeed;
            System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> val_10 = val_2.GetOtherCharactersInRadius(radius:  val_6 + val_29);
            val_31 = 0;
            val_32 = 1152921510548295440;
            val_33 = 1152921510682981472;
            goto label_6;
            label_28:
            val_31 = 1;
            label_6:
            if(val_31 >= val_10.Count)
            {
                goto label_8;
            }
            
            TzarGames.TzarHero.TH_Character val_12 = val_10.Item[1];
            if((val_8.Contains(item:  val_12)) == true)
            {
                goto label_28;
            }
            
            val_8.Add(item:  val_12);
            if(((0 == val_12.TemplateInstance) || (0 == val_12.TemplateInstance.Group)) || ((val_12.TemplateInstance.Group.IsFriendly(group:  val_2.TemplateInstance.Group)) == true))
            {
                goto label_28;
            }
            
            TzarGames.TzarHero.CharacterDamageInfo val_28 = TzarGames.TzarHero.SimpleMeleeCombatSystem.AdjustMeleeDamageTo(instigator:  0, victim:  val_2, weapon:  val_12, damageForceMultiplier:  this.attackForceMultiplier);
            goto label_28;
            label_4:
            this.waves.RemoveAt(index:  val_30);
            val_32 = 1152921510548295440;
            val_33 = 1152921510682981472;
            label_8:
            val_30 = val_30 - 1;
            if((val_30 & 2147483648) == 0)
            {
                goto label_30;
            }
        
        }
        public override bool Validate()
        {
            if(this.Character != null)
            {
                    0 = 0;
            }
            
            if(0 == )
            {
                    return false;
            }
            
            if(0 != SecondWeapon)
            {
                    return this.Validate();
            }
            
            return false;
        }
    
    }

}
