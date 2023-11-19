using UnityEngine;

namespace TzarGames.Endless
{
    public class ShieldFeedbackArtifact : SingleActivableItem
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject effect;
        [UnityEngine.SerializeField]
        private float damageForceMultiplier;
        
        // Methods
        public ShieldFeedbackArtifact()
        {
            this.damageForceMultiplier = 2f;
            val_1 = new TzarGames.GameFramework.Item();
        }
        public override void OnActivatedOnCharacter(TzarGames.TzarHero.TH_CharacterTemplate characterTemplate, TzarGames.GameFramework.ItemInstance itemInstance)
        {
            if(characterTemplate.OwnerCharacter != null)
            {
                    0 = 0;
            }
            
            if(0 == )
            {
                    return;
            }
            
            add_OnHitBlockedByShield(value:  new System.Action<TzarGames.TzarHero.ICharacterDamageInfo>(object:  this, method:  System.Void TzarGames.Endless.ShieldFeedbackArtifact::PlayerCharacter_OnHitBlockedByShield(TzarGames.TzarHero.ICharacterDamageInfo info)));
        }
        private void PlayerCharacter_OnHitBlockedByShield(TzarGames.TzarHero.ICharacterDamageInfo info)
        {
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_15 = info;
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_16 = info;
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_17 = info;
            TzarGames.GameFramework.Weapon val_4 = info.ActiveWeaponTemplate;
            TzarGames.TzarHero.CharacterDamageInfo val_5 = TzarGames.TzarHero.SimpleMeleeCombatSystem.AdjustMeleeDamageTo(instigator:  0, victim:  info, weapon:  info, damageForceMultiplier:  this.damageForceMultiplier);
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_18 = info;
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_19 = info;
            if((TzarGames.GameFramework.Instantiator.IsPoolablePrefab(prefab:  0)) != false)
            {
                    UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.identity;
                UnityEngine.GameObject val_10 = TzarGames.GameFramework.Instantiator.InstantiateFromPool(originalObject:  0, position:  new UnityEngine.Vector3() {x = this.damageForceMultiplier, y = V1.16B, z = V2.16B}, rotation:  new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w}, parent:  this.effect);
                return;
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_20 = info;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = this.damageForceMultiplier, y = V1.16B, z = V2.16B});
            UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            TzarGames.GameFramework.TzarBehaviour val_14 = UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = this.damageForceMultiplier, y = V1.16B, z = V2.16B}, rotation:  new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w});
        }
        public override void OnDeactivatedOnCharacter(TzarGames.TzarHero.TH_CharacterTemplate characterTemplate, TzarGames.GameFramework.ItemInstance itemInstance)
        {
            if(characterTemplate.OwnerCharacter != null)
            {
                    0 = 0;
            }
            
            if(0 == )
            {
                    return;
            }
            
            remove_OnHitBlockedByShield(value:  new System.Action<TzarGames.TzarHero.ICharacterDamageInfo>(object:  this, method:  System.Void TzarGames.Endless.ShieldFeedbackArtifact::PlayerCharacter_OnHitBlockedByShield(TzarGames.TzarHero.ICharacterDamageInfo info)));
        }
    
    }

}
