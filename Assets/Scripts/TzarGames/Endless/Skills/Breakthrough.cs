using UnityEngine;

namespace TzarGames.Endless.Skills
{
    public class Breakthrough : EndlessCharacterSkill, IDamageSkill
    {
        // Fields
        [UnityEngine.SerializeField]
        private float duration;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.CharacteristicModificator speedModificator;
        private TzarGames.GameFramework.CharacteristicModificator damageModificator;
        [UnityEngine.SerializeField]
        private float maxDistance;
        [UnityEngine.SerializeField]
        private string layerName;
        [UnityEngine.SerializeField]
        private string playerAnimationName;
        [UnityEngine.SerializeField]
        private float pushForce;
        [UnityEngine.SerializeField]
        private float maxAngle;
        private float startTime;
        private UnityEngine.Vector3 startPosition;
        private float sqrDistance;
        private int targetLayer;
        private int prevLayer;
        [UnityEngine.SerializeField]
        private float minSpeed;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject effect;
        private UnityEngine.Transform effectInstance;
        private System.Collections.Generic.List<ulong> touchedObjects;
        private bool ownerControl;
        
        // Properties
        public TzarGames.GameFramework.CharacteristicModificator DamageModificator { get; }
        
        // Methods
        public Breakthrough()
        {
            this.maxDistance = 10f;
            this.duration = 2f;
            this.playerAnimationName = "Breakthrough";
            this.pushForce = 2000f;
            this.maxAngle = 90f;
            this.minSpeed = 10f;
            this.touchedObjects = new System.Collections.Generic.List<System.UInt64>();
            this = new TzarGames.TzarHero.Skills.CharacterSkill();
        }
        public TzarGames.GameFramework.CharacteristicModificator get_DamageModificator()
        {
            return (TzarGames.GameFramework.CharacteristicModificator)this.damageModificator;
        }
        public override void OnInitialize()
        {
            this.OnInitialize();
            float val_3 = this.maxDistance;
            val_3 = val_3 * val_3;
            this.sqrDistance = val_3;
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
        protected override void OnStarted()
        {
            var val_49;
            float val_50;
            float val_51;
            var val_52;
            float val_53;
            this.OnStarted();
            this.Character.CharController.enableOverlapRecovery = false;
            UnityEngine.Vector3 val_4 = this.Character.GetDesiredRotationDirection();
            var val_49 = 0;
            val_49 = val_49 + 1;
            val_49 = this.Character.Movement;
            val_50 = val_4.y;
            val_51 = val_4.z;
            this.startTime = UnityEngine.Time.time;
            UnityEngine.Vector3 val_10 = this.Character.Position;
            this.startPosition = val_10;
            mem[1152921510817287352] = val_10.y;
            mem[1152921510817287356] = val_10.z;
            this.Character.TemplateInstance.DamageCharacteristic.AddModificator(modificator:  this.damageModificator);
            this.Character.TemplateInstance.WalkingSpeedCharacteristic.AddModificator(modificator:  this.speedModificator);
            var val_50 = 0;
            val_50 = val_50 + 1;
            val_52 = this.Character.Movement;
            val_53 = this.Character.TemplateInstance.WalkingSpeed;
            TzarGames.TzarHero.CharacterAnimationBase val_24 = this.Character.Animation;
            this.prevLayer = this.Character.gameObject.layer;
            this.Character.gameObject.layer = this.targetLayer;
            this.touchedObjects.Clear();
            if(this.Character.PlayerOwner.itsMe != false)
            {
                    if(this.Character.OnClient != false)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_20 = val_4;
                this.SendNetMessage(messageCode:  1, mode:  5, parameters:  null);
            }
            
            }
            
            TzarGames.GameFramework.ICharacterMovement val_36 = this.Character.Movement;
            bool val_51 = ~0.UsePrediction;
            val_51 = val_51 & 1;
            this.ownerControl = val_51;
            if(this.Character.PlayerOwner.itsMe != true)
            {
                    if(this.ownerControl == true)
            {
                goto label_48;
            }
            
            }
            
            val_53 = this.maxDistance;
            val_50 = this.duration;
            val_51 = this.minSpeed;
            0.SetMoveTrigger(distance:  val_53, time:  val_50, minSpeed:  val_51, completeCallback:  new System.Action(object:  this, method:  System.Void TzarGames.GameFramework.Skills.Skill::Finish()));
            label_48:
            UnityEngine.Transform val_44 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0).transform;
            this.effectInstance = val_44;
            val_44.SetParent(parent:  this.Character.transform);
            UnityEngine.Vector3 val_47 = UnityEngine.Vector3.zero;
            this.effectInstance.localPosition = new UnityEngine.Vector3() {x = val_47.x, y = val_47.y, z = val_47.z};
            UnityEngine.Quaternion val_48 = UnityEngine.Quaternion.identity;
            this.effectInstance.localRotation = new UnityEngine.Quaternion() {x = val_48.x, y = val_48.y, z = val_48.z, w = val_48.w};
        }
        public override void UpdatePerformingSkill(float deltaTime)
        {
            var val_9;
            this.UpdatePerformingSkill(deltaTime:  deltaTime);
            UnityEngine.Vector3 val_4 = this.Character.ForwardDirection;
            TzarGames.GameFramework.Weapon val_6 = this.Character.GetActiveWeaponTemplate(slot:  0);
            List.Enumerator<T> val_7 = this.Character.GetAllCharactersInAttackRadius(radiusScale:  1f).GetEnumerator();
            label_24:
            do
            {
                label_21:
                if((0 & 1) == 0)
            {
                goto label_32;
            }
            
                System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_10 = val_9.InitializationCallback;
            }
            while((this.Character.isCharacterValidForAttack(character:  val_10)) == false);
            
            if(((this.Character.TemplateInstance.Group.IsFriendly(group:  val_10.TemplateInstance.Group)) == true) || ((this.touchedObjects.Contains(item:  val_10.Id)) == true))
            {
                goto label_21;
            }
            
            UnityEngine.Vector3 val_24 = val_10.Position;
            UnityEngine.Vector3 val_26 = this.Character.Position;
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, b:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
            if((UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, to:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z})) > this.maxAngle)
            {
                goto label_21;
            }
            
            this.touchedObjects.Add(item:  val_10.Id);
            TzarGames.TzarHero.CharacterDamageInfo val_31 = TzarGames.TzarHero.SimpleMeleeCombatSystem.AdjustMeleeDamageTo(instigator:  0, victim:  this.Character, weapon:  val_10, damageForceMultiplier:  this.pushForce);
            goto label_24;
            label_32:
            val_9.Dispose();
            if(0 == 0)
            {
                    return;
            }
            
            this.Character.Target = 0;
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
            var val_26;
            var val_27;
            this.OnStopped();
            this.Character.TemplateInstance.DamageCharacteristic.UnregisterModificator(modificator:  this.damageModificator);
            this.Character.TemplateInstance.WalkingSpeedCharacteristic.UnregisterModificator(modificator:  this.speedModificator);
            this.Character.gameObject.layer = this.prevLayer;
            val_26 = this.Character.Animation;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.zero;
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_27 = this.Character.Movement;
            if(this.Character.OnServer == false)
            {
                goto label_20;
            }
            
            label_28:
            this.SendNetMessage(messageCode:  0, mode:  4, parameters:  null);
            goto label_27;
            label_20:
            if(((this.Character.OnClient == false) || (this.ownerControl == false)) || (this.Character.PlayerOwner.itsMe == false))
            {
                goto label_27;
            }
            
            goto label_28;
            label_27:
            if(this.Finished != true)
            {
                    val_26 = 1152921504721543168;
                if(0 != this.effectInstance)
            {
                    UnityEngine.GameObject val_25 = this.effectInstance.gameObject;
                UnityEngine.Object.Destroy(obj:  0);
            }
            
            }
            
            this.effectInstance = 0;
        }
    
    }

}
