using UnityEngine;

namespace TzarGames.Endless.Skills
{
    public class Swirlwind : EndlessCharacterSkill, ICommonSkillUpgrade
    {
        // Fields
        [UnityEngine.SerializeField]
        private float duration;
        [UnityEngine.SerializeField]
        private float rotationSpeed;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.CharacteristicModificator speedModificator;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.CharacteristicModificator rotationSpeedModificator;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.CharacteristicModificator damageModificator;
        [UnityEngine.SerializeField]
        private float maxDistance;
        [UnityEngine.SerializeField]
        private float attackRangeMultiplier;
        [UnityEngine.SerializeField]
        private float attackForceMultiplier;
        [UnityEngine.SerializeField]
        private string layerName;
        [UnityEngine.SerializeField]
        private string animationName;
        private int targetLayer;
        private int prevLayer;
        [UnityEngine.SerializeField]
        private float minSpeed;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject effect;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.TrailFxInfo trailSettings;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset speedUpgradeLabel;
        private UnityEngine.Transform effectInstance;
        private UnityEngine.Vector3 direction;
        private System.Collections.Generic.List<ulong> firstHandTouchedObjects;
        private System.Collections.Generic.List<ulong> secondHandTouchedObjects;
        private bool prevBodyRotationState;
        private float currentAngle;
        private bool ownerControl;
        
        // Properties
        public TzarGames.GameFramework.CharacteristicModificator Modificator { get; }
        
        // Methods
        public Swirlwind()
        {
            this.duration = 2f;
            this.rotationSpeed = 1080f;
            this.rotationSpeedModificator = new TzarGames.GameFramework.CharacteristicModificator(value:  1f);
            this.attackForceMultiplier = 2000f;
            this.maxDistance = 0f;
            this.attackRangeMultiplier = 1f;
            this.animationName = "Swirlwind";
            this.minSpeed = 10f;
            this.firstHandTouchedObjects = new System.Collections.Generic.List<System.UInt64>();
            this.secondHandTouchedObjects = new System.Collections.Generic.List<System.UInt64>();
        }
        public TzarGames.GameFramework.CharacteristicModificator get_Modificator()
        {
            return (TzarGames.GameFramework.CharacteristicModificator)this.rotationSpeedModificator;
        }
        public override void OnInitialize()
        {
            this.OnInitialize();
            this.targetLayer = UnityEngine.LayerMask.NameToLayer(layerName:  0);
            if(this.damageModificator != null)
            {
                    return;
            }
            
            this.damageModificator = new TzarGames.GameFramework.CharacteristicModificator();
            typeof(TzarGames.GameFramework.CharacteristicModificator).__il2cppRuntimeField_18 = 2;
            this.damageModificator.ModificationMode = 0;
            this.damageModificator.Value = 1f;
        }
        protected override void OnCharacterAssigned()
        {
            this.OnCharacterAssigned();
            if(0 == this.Character.AnimBasedCombatSystem)
            {
                    return;
            }
            
            this.Character.AnimBasedCombatSystem.add_OnAttackFinished(value:  new System.Action<TzarGames.TzarHero.AnimationBasedCombatSystem>(object:  this, method:  System.Void TzarGames.Endless.Skills.Swirlwind::AnimBasedCombatSystemOnOnAttackFinished(TzarGames.TzarHero.AnimationBasedCombatSystem combatSystem)));
        }
        protected override void OnCharacterRemoved(TzarGames.TzarHero.TH_Character character)
        {
            this.OnCharacterRemoved(character:  character);
            if(0 == this.Character.AnimBasedCombatSystem)
            {
                    return;
            }
            
            this.Character.AnimBasedCombatSystem.remove_OnAttackFinished(value:  new System.Action<TzarGames.TzarHero.AnimationBasedCombatSystem>(object:  this, method:  System.Void TzarGames.Endless.Skills.Swirlwind::AnimBasedCombatSystemOnOnAttackFinished(TzarGames.TzarHero.AnimationBasedCombatSystem combatSystem)));
        }
        private void AnimBasedCombatSystemOnOnAttackFinished(TzarGames.TzarHero.AnimationBasedCombatSystem combatSystem)
        {
            if(this.IsPerforming == false)
            {
                    return;
            }
            
            this.Finish();
        }
        public override void UpdatePerformingSkill(float deltaTime)
        {
            var val_67;
            float val_68;
            var val_69;
            float val_70;
            var val_74;
            var val_75;
            val_67 = this;
            this.UpdatePerformingSkill(deltaTime:  deltaTime);
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_3 = this.Character.GroundPivotPosition;
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.AngleAxis(angle:  this.currentAngle, axis:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            val_68 = val_4.w;
            float val_5 = this.rotationSpeedModificator.Value;
            float val_67 = deltaTime;
            val_67 = this.rotationSpeed * val_67;
            val_5 = val_67 * val_5;
            val_5 = this.currentAngle + val_5;
            this.currentAngle = val_5;
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.AngleAxis(angle:  val_5, axis:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_8 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_68}, point:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_10 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w}, point:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  this.Character.AttackHeightOffset);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            float val_68 = this.currentAngle;
            if(val_68 >= 360f)
            {
                    val_68 = val_68 + (-360f);
                this.currentAngle = val_68;
                this.firstHandTouchedObjects.Clear();
                this.secondHandTouchedObjects.Clear();
            }
            
            System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> val_17 = this.Character.GetAllCharactersInAttackRadius(radiusScale:  this.attackRangeMultiplier);
            TzarGames.GameFramework.Weapon val_19 = this.Character.GetActiveWeaponTemplate(slot:  1);
            TzarGames.GameFramework.Weapon val_21 = this.Character.GetActiveWeaponTemplate(slot:  0);
            float val_23 = this.Character.GetAttackRadius();
            val_23 = val_23 * this.attackRangeMultiplier;
            val_69 = 0;
            goto label_15;
            label_60:
            val_69 = 1;
            label_15:
            if(val_69 >= val_17.Count)
            {
                goto label_17;
            }
            
            TzarGames.TzarHero.TH_Character val_25 = val_17.Item[1];
            if(((this.Character.isCharacterValidForAttack(character:  val_25)) == false) || ((this.Character.TemplateInstance.Group.IsFriendly(group:  val_25.TemplateInstance.Group)) == true))
            {
                goto label_60;
            }
            
            UnityEngine.Vector3 val_35 = val_25.GroundPivotPosition;
            UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Vector3 val_37 = UnityEngine.Vector3.right;
            val_70 = val_6.x;
            UnityEngine.Vector3 val_38 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_70, y = val_6.y, z = val_6.z, w = val_6.w}, point:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z});
            bool val_40 = this.firstHandTouchedObjects.Contains(item:  val_25.Id);
            if(val_40 != true)
            {
                    val_70 = val_36.x;
                if((val_40.checkAttackDirection(targetDir:  new UnityEngine.Vector3() {x = val_70, y = val_36.y, z = val_36.z}, rightEdgeVector:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, leftEdgeVector:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.z})) != false)
            {
                    this.firstHandTouchedObjects.Add(item:  val_25.Id);
                TzarGames.TzarHero.TH_Character val_44 = this.Character;
                if(val_44 != null)
            {
                    val_74 = null;
                val_74 = null;
                val_44 = (((TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.PlayerCharacter.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_74) ? (val_44) : 0;
            }
            
                TzarGames.GameFramework.Weapon val_45 = 0.ActivateWeaponModificators(slot:  1);
                UnityEngine.Vector3 val_47 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z}, d:  val_23);
                UnityEngine.Vector3 val_48 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z});
                val_68 = val_48.z;
                UnityEngine.Vector3 val_49 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z});
                val_70 = this.attackForceMultiplier;
                TzarGames.TzarHero.CharacterDamageInfo val_50 = TzarGames.TzarHero.SimpleMeleeCombatSystem.AdjustMeleeDamageTo(instigator:  0, victim:  this.Character, weapon:  val_25, damageForceMultiplier:  val_70, hitPosition:  new UnityEngine.Vector3() {x = val_48.x, y = val_48.y, z = val_68}, hitNormal:  new UnityEngine.Vector3() {x = val_49.x, y = val_49.y, z = val_49.z}, hitDirection:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.z});
            }
            
            }
            
            if((this.secondHandTouchedObjects.Contains(item:  val_25.Id)) == true)
            {
                goto label_60;
            }
            
            UnityEngine.Vector3 val_54 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            UnityEngine.Vector3 val_55 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            if((this.checkAttackDirection(targetDir:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z}, rightEdgeVector:  new UnityEngine.Vector3() {x = val_54.x, y = val_54.y, z = val_54.z}, leftEdgeVector:  new UnityEngine.Vector3() {x = val_55.x, y = val_55.z})) == false)
            {
                goto label_60;
            }
            
            this.secondHandTouchedObjects.Add(item:  val_25.Id);
            TzarGames.TzarHero.TH_Character val_58 = this.Character;
            if(val_58 != null)
            {
                    val_75 = null;
                val_75 = null;
                val_58 = (((TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.PlayerCharacter.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_75) ? (val_58) : 0;
            }
            
            TzarGames.GameFramework.Weapon val_59 = 0.ActivateWeaponModificators(slot:  0);
            UnityEngine.Vector3 val_61 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z}, d:  val_23);
            UnityEngine.Vector3 val_62 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_61.x, y = val_61.y, z = val_61.z});
            UnityEngine.Vector3 val_63 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z});
            TzarGames.TzarHero.CharacterDamageInfo val_64 = TzarGames.TzarHero.SimpleMeleeCombatSystem.AdjustMeleeDamageTo(instigator:  0, victim:  this.Character, weapon:  val_25, damageForceMultiplier:  this.attackForceMultiplier, hitPosition:  new UnityEngine.Vector3() {x = val_62.x, y = val_62.y, z = val_62.z}, hitNormal:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z}, hitDirection:  new UnityEngine.Vector3() {x = val_63.x, y = val_63.z});
            goto label_60;
            label_17:
            this.setRotation(rot:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w});
            if(0 == 0)
            {
                    return;
            }
            
            val_67 = this.Character;
            val_67.Target = 0;
        }
        private bool checkAttackDirection(UnityEngine.Vector3 targetDir, UnityEngine.Vector3 rightEdgeVector, UnityEngine.Vector3 leftEdgeVector)
        {
            float val_3;
            var val_6;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
            if(((TzarGames.Endless.Skills.Swirlwind.angleDir(fwd:  new UnityEngine.Vector3() {x = rightEdgeVector.x, y = rightEdgeVector.y, z = rightEdgeVector.z}, targetDir:  new UnityEngine.Vector3() {x = targetDir.x, y = targetDir.y, z = targetDir.z}, up:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.z, z = ???})) & 2147483648) == 0)
            {
                    var val_5 = ((TzarGames.Endless.Skills.Swirlwind.angleDir(fwd:  new UnityEngine.Vector3() {x = leftEdgeVector.x, y = val_3, z = leftEdgeVector.y}, targetDir:  new UnityEngine.Vector3() {x = targetDir.x, y = targetDir.y, z = targetDir.z}, up:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.z, z = ???})) < 1) ? 1 : 0;
                return (bool)val_6;
            }
            
            val_6 = 0;
            return (bool)val_6;
        }
        private static int angleDir(UnityEngine.Vector3 fwd, UnityEngine.Vector3 targetDir, UnityEngine.Vector3 up)
        {
            float val_1;
            var val_5;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = fwd.x, y = fwd.y, z = fwd.z}, rhs:  new UnityEngine.Vector3() {x = targetDir.x, y = targetDir.y, z = targetDir.z});
            float val_3 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = up.x, y = val_1, z = up.y});
            if(val_3 <= 0f)
            {
                    var val_4 = (val_3 < 0) ? 0 : 0;
                return (int)val_5;
            }
            
            val_5 = 1;
            return (int)val_5;
        }
        protected override void OnStarted()
        {
            object val_37;
            float val_38;
            IntPtr val_39;
            var val_40;
            float val_41;
            float val_42;
            var val_43;
            float val_44;
            var val_45;
            float val_46;
            UnityEngine.GameObject val_47;
            var val_48;
            val_37 = this;
            this.OnStarted();
            TzarGames.TzarHero.TH_Character val_1 = this.Character;
            val_1.CharController.enableOverlapRecovery = false;
            UnityEngine.Vector3 val_3 = val_1.GetDesiredRotationDirection();
            this.direction = val_3;
            mem[1152921510838335276] = val_3.y;
            mem[1152921510838335280] = val_3.z;
            if(val_1 != null)
            {
                    this.prevBodyRotationState = val_1.enableBodyRotation;
                val_1.enableBodyRotation = false;
            }
            else
            {
                    this.prevBodyRotationState = true;
                mem[456] = 0;
            }
            
            val_39 = 1152921504909455360;
            var val_37 = 0;
            val_37 = val_37 + 1;
            val_40 = val_1.Movement;
            val_41 = V9.16B;
            val_42 = V10.16B;
            val_1.TemplateInstance.DamageCharacteristic.AddModificator(modificator:  this.damageModificator);
            val_1.TemplateInstance.WalkingSpeedCharacteristic.AddModificator(modificator:  this.speedModificator);
            if(val_1 != null)
            {
                    val_43 = val_1.Movement;
            }
            else
            {
                    val_43 = 0.Movement;
            }
            
            val_44 = val_1.TemplateInstance.WalkingSpeed;
            var val_38 = 0;
            val_38 = val_38 + 1;
            val_45 = val_43;
            val_46 = val_44;
            TzarGames.TzarHero.CharacterAnimationBase val_15 = val_1.Animation;
            this.prevLayer = val_1.gameObject.layer;
            val_1.gameObject.layer = this.targetLayer;
            this.currentAngle = 0f;
            if(val_1.PlayerOwner.itsMe != false)
            {
                    if(val_1.OnClient != false)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_20 = this.direction;
                this.SendNetMessage(messageCode:  1, mode:  5, parameters:  null);
            }
            
            }
            
            TzarGames.GameFramework.ICharacterMovement val_22 = val_1.Movement;
            bool val_39 = ~0.UsePrediction;
            val_39 = val_39 & 1;
            this.ownerControl = val_39;
            if(val_1.PlayerOwner.itsMe != true)
            {
                    if(this.ownerControl == true)
            {
                goto label_47;
            }
            
            }
            
            val_44 = this.maxDistance;
            val_38 = this.minSpeed;
            val_39 = System.Void TzarGames.Endless.Skills.Swirlwind::OnMoveFinished();
            val_46 = val_44;
            val_41 = this.duration;
            val_42 = val_38;
            0.SetMoveTrigger(distance:  val_46, time:  val_41, minSpeed:  val_42, completeCallback:  new System.Action(object:  this, method:  val_39));
            label_47:
            val_47 = this.effect;
            if(0 != val_47)
            {
                    val_47 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0).transform;
                this.effectInstance = val_47;
                val_47.SetParent(parent:  val_1.transform);
                UnityEngine.Vector3 val_32 = UnityEngine.Vector3.zero;
                this.effectInstance.localPosition = new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z};
                UnityEngine.Quaternion val_33 = UnityEngine.Quaternion.identity;
                val_44 = val_33.x;
                val_38 = val_33.z;
                this.effectInstance.localRotation = new UnityEngine.Quaternion() {x = val_44, y = val_33.y, z = val_38, w = val_33.w};
            }
            
            TzarGames.TzarHero.TH_Character val_34 = this.Character;
            if(val_34 != null)
            {
                    val_47 = 1152921504872022016;
                val_48 = null;
                val_48 = null;
                val_34 = (((TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.PlayerCharacterBase.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_48) ? (val_34) : 0;
            }
            
            TzarGames.Endless.TrailFxController val_35 = 0.TrailController;
            if(0 == val_35)
            {
                    return;
            }
            
            val_37 = this.trailSettings;
            if(val_35 != null)
            {
                    val_35.trailSettings = val_37;
            }
            else
            {
                    mem[32] = val_37;
            }
            
            val_35.ActivateTrails(info:  0);
        }
        private void OnMoveFinished()
        {
            if(this.IsPerforming == false)
            {
                    return;
            }
            
            this.Finish();
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
        private void setRotation(UnityEngine.Quaternion rot)
        {
            this.Character.transform.rotation = new UnityEngine.Quaternion() {x = rot.x, y = rot.y, z = rot.z, w = rot.w};
        }
        protected override void OnStopped()
        {
            var val_31;
            var val_32;
            this.OnStopped();
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = this.direction, y = V9.16B, z = V8.16B});
            this.setRotation(rot:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w});
            TzarGames.TzarHero.TH_Character val_2 = this.Character;
            val_2.enableBodyRotation = this.prevBodyRotationState;
            this.Character.TemplateInstance.DamageCharacteristic.UnregisterModificator(modificator:  this.damageModificator);
            this.Character.TemplateInstance.WalkingSpeedCharacteristic.UnregisterModificator(modificator:  this.speedModificator);
            this.Character.gameObject.layer = this.prevLayer;
            TzarGames.TzarHero.CharacterAnimationBase val_12 = this.Character.Animation;
            this.Character.AnimBasedCombatSystem.StopAttack();
            this.firstHandTouchedObjects.Clear();
            this.secondHandTouchedObjects.Clear();
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.zero;
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_31 = this.Character.Movement;
            if(this.Character.OnServer == false)
            {
                goto label_27;
            }
            
            label_35:
            this.SendNetMessage(messageCode:  0, mode:  4, parameters:  null);
            goto label_34;
            label_27:
            if(((this.Character.OnClient == false) || (this.ownerControl == false)) || (this.Character.PlayerOwner.itsMe == false))
            {
                goto label_34;
            }
            
            goto label_35;
            label_34:
            if(0 != this.effectInstance)
            {
                    UnityEngine.GameObject val_27 = this.effectInstance.gameObject;
                UnityEngine.Object.Destroy(obj:  0);
            }
            
            TzarGames.TzarHero.TH_Character val_28 = this.Character;
            if(val_28 != null)
            {
                    val_32 = null;
                val_32 = null;
                val_28 = (((TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.PlayerCharacterBase.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_32) ? (val_28) : 0;
            }
            
            TzarGames.Endless.TrailFxController val_29 = 0.TrailController;
            if(0 == val_29)
            {
                    return;
            }
            
            if(val_29 != null)
            {
                    val_29.trailSettings = 0;
            }
            else
            {
                    mem[32] = 0;
            }
            
            val_29.deactivateTrails(reset:  true, smoothly:  false);
        }
        public string GetUpgradeLabelWithBonus(float bonus)
        {
            var val_5;
            var val_6;
            if((TzarGames.Endless.EndlessUtils.FloatToPercent(val:  bonus)) > 0)
            {
                    val_5 = "+";
            }
            else
            {
                    val_6 = null;
                val_6 = null;
            }
            
            string val_2 = 0 + System.String.__il2cppRuntimeField_static_fields;
            return (string)System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
        }
        public override bool Validate()
        {
            if(0 == (this.Character.GetActiveWeaponTemplate(slot:  0)))
            {
                    return false;
            }
            
            if(0 != (this.Character.GetActiveWeaponTemplate(slot:  1)))
            {
                    return this.Validate();
            }
            
            return false;
        }
    
    }

}
