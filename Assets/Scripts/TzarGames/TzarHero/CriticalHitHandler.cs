using UnityEngine;

namespace TzarGames.TzarHero
{
    public class CriticalHitHandler : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Character character;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject hitEffect;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject enemyHitEffect;
        
        // Methods
        public CriticalHitHandler()
        {
        
        }
        private void Reset()
        {
            if(0 != this.character)
            {
                    return;
            }
            
            this.character = this.GetComponent<TzarGames.TzarHero.TH_Character>();
        }
        private void OnEnable()
        {
            this.character.add_OnHitOtherCharacter(value:  new TH_Character.dlgHitEvent(object:  this, method:  System.Void TzarGames.TzarHero.CriticalHitHandler::CharacterOnOnHitOtherCharacter(TzarGames.TzarHero.ICharacterDamageInfo hitData)));
            if(0 == this.enemyHitEffect)
            {
                    return;
            }
            
            this.character.add_OnCharacterTakeHit(value:  new TH_Character.dlgHitEvent(object:  this, method:  System.Void TzarGames.TzarHero.CriticalHitHandler::Character_OnTakeHit(TzarGames.TzarHero.ICharacterDamageInfo hitData)));
        }
        private void Character_OnTakeHit(TzarGames.TzarHero.ICharacterDamageInfo hitData)
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            if(hitData == null)
            {
                    return;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_13 = hitData;
            if(hitData == null)
            {
                    return;
            }
            
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_14 = hitData;
            if((hitData & 1) == 0)
            {
                    return;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_15 = hitData;
            UnityEngine.Vector3 val_4 = hitData.Position;
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_16 = hitData;
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_17 = hitData;
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_18 = hitData;
            UnityEngine.Quaternion val_9 = hitData.transform.rotation;
            if((TzarGames.GameFramework.Instantiator.IsPoolablePrefab(prefab:  0)) != false)
            {
                    UnityEngine.GameObject val_11 = TzarGames.GameFramework.Instantiator.InstantiateFromPool(originalObject:  0, position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, rotation:  new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w}, parent:  this.enemyHitEffect);
                return;
            }
            
            TzarGames.GameFramework.TzarBehaviour val_12 = UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, rotation:  new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w});
        }
        private void CharacterOnOnHitOtherCharacter(TzarGames.TzarHero.ICharacterDamageInfo hitData)
        {
            var val_16;
            var val_17;
            var val_18;
            TzarGames.TzarHero.TH_Character val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            if(hitData == null)
            {
                    return;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_16 = hitData;
            if(hitData == null)
            {
                    return;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_17 = hitData;
            if((hitData & 1) == 0)
            {
                    return;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_18 = hitData;
            if((hitData & 1) == 0)
            {
                    return;
            }
            
            val_19 = this.character;
            if(val_19 != null)
            {
                    val_20 = null;
                val_19 = this.character;
                if(val_19 != null)
            {
                    val_20 = null;
                val_21 = val_19;
                val_21 = val_19;
                val_21 = val_19;
                if(val_19 == null)
            {
                    val_21 = 0;
                val_20 = null;
            }
            
                var val_4 = (((TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.PlayerCharacter.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_20) ? (val_21) : 0;
            }
            
                0.PlayerCamera.ShakeQuick();
            }
            
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_22 = hitData;
            UnityEngine.Vector3 val_7 = hitData.Position;
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_23 = hitData;
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_24 = hitData;
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_25 = hitData;
            UnityEngine.Quaternion val_12 = hitData.transform.rotation;
            if((TzarGames.GameFramework.Instantiator.IsPoolablePrefab(prefab:  0)) != false)
            {
                    UnityEngine.GameObject val_14 = TzarGames.GameFramework.Instantiator.InstantiateFromPool(originalObject:  0, position:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, rotation:  new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w}, parent:  this.hitEffect);
                return;
            }
            
            TzarGames.GameFramework.TzarBehaviour val_15 = UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, rotation:  new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w});
        }
        private void OnDisable()
        {
            this.character.remove_OnHitOtherCharacter(value:  new TH_Character.dlgHitEvent(object:  this, method:  System.Void TzarGames.TzarHero.CriticalHitHandler::CharacterOnOnHitOtherCharacter(TzarGames.TzarHero.ICharacterDamageInfo hitData)));
            this.character.remove_OnCharacterTakeHit(value:  new TH_Character.dlgHitEvent(object:  this, method:  System.Void TzarGames.TzarHero.CriticalHitHandler::Character_OnTakeHit(TzarGames.TzarHero.ICharacterDamageInfo hitData)));
        }
    
    }

}
