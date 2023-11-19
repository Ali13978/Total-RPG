using UnityEngine;

namespace TzarGames.Endless
{
    public class ItemTakeVusialEffect : MonoBehaviour, IPoolable
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.PlayerCharacter character;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject attackSpeedEffect;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject damageEffect;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject speedEffect;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject defenceEffect;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject healthEffect;
        private UnityEngine.ParticleSystem attackSpeedEffectInstance;
        private UnityEngine.ParticleSystem damageEffectInstance1;
        private UnityEngine.ParticleSystem damageEffectInstance2;
        private UnityEngine.ParticleSystem speedEffectInstance;
        private UnityEngine.ParticleSystem defenceEffectInstance;
        private UnityEngine.ParticleSystem healthEffectInstance;
        private System.Collections.Generic.Dictionary<UnityEngine.ParticleSystem, float> rateMultipliers;
        private System.Collections.Generic.Dictionary<TzarGames.GameFramework.CharacteristicModificator, UnityEngine.ParticleSystem> modificatorToEffects;
        
        // Methods
        public ItemTakeVusialEffect()
        {
            this.rateMultipliers = new System.Collections.Generic.Dictionary<UnityEngine.ParticleSystem, System.Single>();
            this.modificatorToEffects = new System.Collections.Generic.Dictionary<TzarGames.GameFramework.CharacteristicModificator, UnityEngine.ParticleSystem>();
        }
        private void Start()
        {
            this.attackSpeedEffectInstance = this.createEffectInstance(prefab:  this.attackSpeedEffect);
            this.damageEffectInstance1 = this.createEffectInstance(prefab:  this.damageEffect);
            this.damageEffectInstance2 = this.createEffectInstance(prefab:  this.damageEffect);
            this.speedEffectInstance = this.createEffectInstance(prefab:  this.speedEffect);
            UnityEngine.ParticleSystem val_5 = this.createEffectInstance(prefab:  this.defenceEffect);
            this.defenceEffectInstance = val_5;
            ShapeModule val_6 = val_5.shape;
            this.healthEffectInstance = this.createEffectInstance(prefab:  this.healthEffect);
            TzarGames.TzarHero.TH_CharacterTemplate val_8 = this.character.TemplateInstance;
            this.initCharacteristic<TzarGames.TzarHero.AttackSpeedModificator>(characteristic:  val_8.AttackSpeedCharacteristic);
            if(val_8 != null)
            {
                    this.initCharacteristic<TzarGames.TzarHero.SpeedModificator>(characteristic:  val_8.WalkingSpeedCharacteristic);
            }
            else
            {
                    this.initCharacteristic<TzarGames.TzarHero.SpeedModificator>(characteristic:  val_8.WalkingSpeedCharacteristic);
            }
            
            this.initCharacteristic<TzarGames.TzarHero.DefenceModificator>(characteristic:  val_8.DefenceCharacteristic);
            this.initCharacteristic<TzarGames.TzarHero.DamageModificator>(characteristic:  val_8.DamageCharacteristic);
            this.character.add_OnItemUsed(value:  new System.Action<TzarGames.GameFramework.Item, TzarGames.GameFramework.ItemInstance>(object:  this, method:  System.Void TzarGames.Endless.ItemTakeVusialEffect::CharacterOnOnItemUsed(TzarGames.GameFramework.Item item1, TzarGames.GameFramework.ItemInstance itemInstance)));
            this.character.add_OnArmorSetChanged(value:  new PlayerCharacterBase.ArmorSetChangedDelegate(object:  this, method:  System.Void TzarGames.Endless.ItemTakeVusialEffect::Character_OnArmorSetChanged(TzarGames.Endless.Items.ArmorSetPrefab oldSet, TzarGames.Endless.Items.ArmorSetPrefab newSet)));
        }
        private void Character_OnArmorSetChanged(TzarGames.Endless.Items.ArmorSetPrefab oldSet, TzarGames.Endless.Items.ArmorSetPrefab newSet)
        {
            UnityEngine.Transform val_10;
            UnityEngine.Debug.Log(message:  0);
            if(0 != newSet)
            {
                    val_10 = newSet.transform;
                this.attackSpeedEffectInstance.transform.SetParent(parent:  val_10, worldPositionStays:  false);
                this.damageEffectInstance1.transform.SetParent(parent:  newSet.rightHandWeaponSocket, worldPositionStays:  false);
                this.damageEffectInstance2.transform.SetParent(parent:  newSet.leftHandWeaponSocket, worldPositionStays:  false);
                this.speedEffectInstance.transform.SetParent(parent:  val_10, worldPositionStays:  false);
                this.defenceEffectInstance.transform.SetParent(parent:  val_10, worldPositionStays:  false);
                ShapeModule val_8 = this.defenceEffectInstance.shape;
                this = this.healthEffectInstance.transform;
                this.SetParent(parent:  val_10, worldPositionStays:  false);
                return;
            }
            
            this.stopAllEffects();
        }
        private void CharacterOnOnItemUsed(TzarGames.GameFramework.Item item1, TzarGames.GameFramework.ItemInstance itemInstance)
        {
            if(item1 == null)
            {
                    return;
            }
        
        }
        private void initCharacteristic<T>(TzarGames.GameFramework.Characteristic characteristic)
        {
            var val_19;
            IntPtr val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            val_19 = __RuntimeMethodHiddenParam;
            characteristic.add_OnModificatorAdded(value:  new Characteristic.ModificatorDelegate(object:  this, method:  System.Void TzarGames.Endless.ItemTakeVusialEffect::onModificatorAdded(TzarGames.GameFramework.Characteristic characteristic, TzarGames.GameFramework.CharacteristicModificator modificator)));
            Characteristic.ModificatorDelegate val_2 = null;
            val_20 = System.Void TzarGames.Endless.ItemTakeVusialEffect::onModificatorRemoved(TzarGames.GameFramework.Characteristic characteristic, TzarGames.GameFramework.CharacteristicModificator modificator);
            val_2 = new Characteristic.ModificatorDelegate(object:  this, method:  val_20);
            if(characteristic != null)
            {
                    characteristic.add_OnModificatorRemoved(value:  val_2);
            }
            else
            {
                    0.add_OnModificatorRemoved(value:  val_2);
            }
            
            System.Collections.Generic.IEnumerable<TzarGames.GameFramework.CharacteristicModificator> val_3 = characteristic.Modificators;
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_21 = val_3;
            val_22 = 1152921504608018432;
            label_20:
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_23 = val_3;
            if(((val_3 & 1) & 1) == 0)
            {
                goto label_14;
            }
            
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_24 = val_3;
            val_20 = val_3;
            if(val_20 == null)
            {
                goto label_20;
            }
            
            this.onModificatorAdded(characteristic:  characteristic, modificator:  val_20);
            label_14:
            val_25 = 0;
            val_26 = 115;
            if(val_3 != null)
            {
                    var val_22 = 0;
                val_22 = val_22 + 1;
                val_27 = val_3;
            }
            
            if( == 115)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_25 = ???;
            val_19 = ???;
            val_20 = ???;
            val_22 = ???;
        }
        private void OnDestroy()
        {
            this.stopAllEffects();
            if(0 != this.character)
            {
                    this.character.remove_OnItemUsed(value:  new System.Action<TzarGames.GameFramework.Item, TzarGames.GameFramework.ItemInstance>(object:  this, method:  System.Void TzarGames.Endless.ItemTakeVusialEffect::CharacterOnOnItemUsed(TzarGames.GameFramework.Item item1, TzarGames.GameFramework.ItemInstance itemInstance)));
                this.character.remove_OnArmorSetChanged(value:  new PlayerCharacterBase.ArmorSetChangedDelegate(object:  this, method:  System.Void TzarGames.Endless.ItemTakeVusialEffect::Character_OnArmorSetChanged(TzarGames.Endless.Items.ArmorSetPrefab oldSet, TzarGames.Endless.Items.ArmorSetPrefab newSet)));
            }
            
            if(0 == this.character)
            {
                    return;
            }
            
            if(0 == this.character.TemplateInstance)
            {
                    return;
            }
            
            TzarGames.TzarHero.TH_CharacterTemplate val_7 = this.character.TemplateInstance;
            val_7.AttackSpeedCharacteristic.remove_OnModificatorAdded(value:  new Characteristic.ModificatorDelegate(object:  this, method:  System.Void TzarGames.Endless.ItemTakeVusialEffect::onModificatorAdded(TzarGames.GameFramework.Characteristic characteristic, TzarGames.GameFramework.CharacteristicModificator modificator)));
            val_7.AttackSpeedCharacteristic.remove_OnModificatorRemoved(value:  new Characteristic.ModificatorDelegate(object:  this, method:  System.Void TzarGames.Endless.ItemTakeVusialEffect::onModificatorRemoved(TzarGames.GameFramework.Characteristic characteristic, TzarGames.GameFramework.CharacteristicModificator modificator)));
            val_7.DamageCharacteristic.remove_OnModificatorAdded(value:  new Characteristic.ModificatorDelegate(object:  this, method:  System.Void TzarGames.Endless.ItemTakeVusialEffect::onModificatorAdded(TzarGames.GameFramework.Characteristic characteristic, TzarGames.GameFramework.CharacteristicModificator modificator)));
            val_7.DamageCharacteristic.remove_OnModificatorRemoved(value:  new Characteristic.ModificatorDelegate(object:  this, method:  System.Void TzarGames.Endless.ItemTakeVusialEffect::onModificatorRemoved(TzarGames.GameFramework.Characteristic characteristic, TzarGames.GameFramework.CharacteristicModificator modificator)));
            val_7.WalkingSpeedCharacteristic.remove_OnModificatorAdded(value:  new Characteristic.ModificatorDelegate(object:  this, method:  System.Void TzarGames.Endless.ItemTakeVusialEffect::onModificatorAdded(TzarGames.GameFramework.Characteristic characteristic, TzarGames.GameFramework.CharacteristicModificator modificator)));
            val_7.WalkingSpeedCharacteristic.remove_OnModificatorRemoved(value:  new Characteristic.ModificatorDelegate(object:  this, method:  System.Void TzarGames.Endless.ItemTakeVusialEffect::onModificatorRemoved(TzarGames.GameFramework.Characteristic characteristic, TzarGames.GameFramework.CharacteristicModificator modificator)));
            val_7.DefenceCharacteristic.remove_OnModificatorAdded(value:  new Characteristic.ModificatorDelegate(object:  this, method:  System.Void TzarGames.Endless.ItemTakeVusialEffect::onModificatorAdded(TzarGames.GameFramework.Characteristic characteristic, TzarGames.GameFramework.CharacteristicModificator modificator)));
            val_7.DefenceCharacteristic.remove_OnModificatorRemoved(value:  new Characteristic.ModificatorDelegate(object:  this, method:  System.Void TzarGames.Endless.ItemTakeVusialEffect::onModificatorRemoved(TzarGames.GameFramework.Characteristic characteristic, TzarGames.GameFramework.CharacteristicModificator modificator)));
            val_7.HitPointsCharacteristic.remove_OnModificatorAdded(value:  new Characteristic.ModificatorDelegate(object:  this, method:  System.Void TzarGames.Endless.ItemTakeVusialEffect::onModificatorAdded(TzarGames.GameFramework.Characteristic characteristic, TzarGames.GameFramework.CharacteristicModificator modificator)));
            val_7.HitPointsCharacteristic.remove_OnModificatorRemoved(value:  new Characteristic.ModificatorDelegate(object:  this, method:  System.Void TzarGames.Endless.ItemTakeVusialEffect::onModificatorRemoved(TzarGames.GameFramework.Characteristic characteristic, TzarGames.GameFramework.CharacteristicModificator modificator)));
        }
        private UnityEngine.ParticleSystem createEffectInstance(UnityEngine.GameObject prefab)
        {
            Unitycoding.UIWidgets.RadialMenuItem val_1 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
            if(val_1 != null)
            {
                    val_1.SetActive(value:  false);
            }
            else
            {
                    val_1.SetActive(value:  false);
            }
            
            val_1.transform.SetParent(parent:  this.transform, worldPositionStays:  false);
            UnityEngine.ParticleSystem val_4 = val_1.GetComponentInChildren<UnityEngine.ParticleSystem>();
            EmissionModule val_5 = val_4.emission;
            this.rateMultipliers.Add(key:  val_4, value:  V0.16B);
            return val_4;
        }
        private void activateEffect(UnityEngine.ParticleSystem effect, UnityEngine.Transform parent)
        {
            effect.transform.SetParent(parent:  parent, worldPositionStays:  false);
            effect.gameObject.SetActive(value:  true);
            EmissionModule val_3 = effect.emission;
            float val_4 = this.rateMultipliers.Item[effect];
        }
        private void stopTimeEffect(UnityEngine.ParticleSystem particle)
        {
            bool val_1 = UnityEngine.Object.op_Equality(x:  0, y:  particle);
            if(particle != null)
            {
                    EmissionModule val_2 = particle.emission;
            }
            else
            {
                    EmissionModule val_3 = 0.emission;
            }
            
            particle.transform.SetParent(parent:  this.damageEffectInstance1.transform, worldPositionStays:  false);
            particle.gameObject.SetActive(value:  false);
        }
        private void onModificatorAdded(TzarGames.GameFramework.Characteristic characteristic, TzarGames.GameFramework.CharacteristicModificator modificator)
        {
            UnityEngine.ParticleSystem val_9;
            if(modificator == null)
            {
                    return;
            }
            
            TzarGames.Endless.Items.ArmorSetPrefab val_1 = this.character.ArmorSetPrefabInstance;
            val_9 = 0;
            if((this.modificatorToEffects.ContainsKey(key:  modificator)) != false)
            {
                    return;
            }
            
            this.modificatorToEffects.Add(key:  modificator, value:  null);
        }
        private void setDefenceEffectState(bool active, TzarGames.Endless.Items.ArmorSetPrefab armorSet)
        {
            TzarGames.Endless.Items.ArmorSetPrefab val_4 = armorSet;
            if(active != false)
            {
                    this.activateEffect(effect:  this.defenceEffectInstance, parent:  val_4.transform);
                ShapeModule val_2 = this.defenceEffectInstance.shape;
                if(val_4 != null)
            {
                    return;
            }
            
                return;
            }
            
            this.stopTimeEffect(particle:  this.defenceEffectInstance);
            val_4 = this.defenceEffectInstance;
            ShapeModule val_3 = val_4.shape;
        }
        private void onModificatorRemoved(TzarGames.GameFramework.Characteristic characteristic, TzarGames.GameFramework.CharacteristicModificator modificator)
        {
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            val_11 = characteristic;
            if((this.modificatorToEffects.ContainsKey(key:  modificator)) == false)
            {
                    return;
            }
            
            System.Collections.Generic.IEnumerable<TzarGames.GameFramework.CharacteristicModificator> val_2 = val_11.Modificators;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_12 = val_2;
            val_11 = val_2;
            label_22:
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_13 = val_11;
            if(((val_11 & 1) & 1) == 0)
            {
                goto label_14;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_14 = val_11;
            if(val_11.GetType() != modificator.GetType())
            {
                goto label_22;
            }
            
            val_15 = 0;
            val_16 = 2;
            goto label_23;
            label_14:
            val_15 = 0;
            val_16 = 0;
            label_23:
            val_17 = 98;
            if(val_11 != null)
            {
                    var val_14 = 0;
                val_14 = val_14 + 1;
                val_18 = val_11;
            }
            
            if(val_16 != 0)
            {
                    return;
            }
            
            this.stopTimeEffect(particle:  this.modificatorToEffects.Item[modificator]);
        }
        private void stopAllEffects()
        {
            if(0 != this.attackSpeedEffectInstance)
            {
                    this.stopTimeEffect(particle:  this.attackSpeedEffectInstance);
            }
            
            if(0 != this.damageEffectInstance1)
            {
                    this.stopTimeEffect(particle:  this.damageEffectInstance1);
            }
            
            if(0 != this.damageEffectInstance2)
            {
                    this.stopTimeEffect(particle:  this.damageEffectInstance2);
            }
            
            if(0 != this.speedEffectInstance)
            {
                    this.stopTimeEffect(particle:  this.speedEffectInstance);
            }
            
            if(0 != this.defenceEffectInstance)
            {
                    this.setDefenceEffectState(active:  false, armorSet:  0);
            }
            
            if(0 == this.healthEffectInstance)
            {
                    return;
            }
            
            this.stopTimeEffect(particle:  this.healthEffectInstance);
        }
        public void OnPushedToPool()
        {
            this.enabled = false;
            this.stopAllEffects();
            this.modificatorToEffects.Clear();
        }
        public void OnPulledFromPool()
        {
            this.enabled = true;
        }
    
    }

}
