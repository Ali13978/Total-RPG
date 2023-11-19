using UnityEngine;

namespace TzarGames.Endless
{
    public class BlockHitEffectSpawner : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.PlayerCharacter _character;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject effect;
        
        // Methods
        public BlockHitEffectSpawner()
        {
        
        }
        private void Reset()
        {
            this._character = this.GetComponent<TzarGames.Endless.PlayerCharacter>();
        }
        private void OnEnable()
        {
            this._character.add_OnHitBlockedByShield(value:  new System.Action<TzarGames.TzarHero.ICharacterDamageInfo>(object:  this, method:  System.Void TzarGames.Endless.BlockHitEffectSpawner::CharacterOnOnHitBlockedByShield(TzarGames.TzarHero.ICharacterDamageInfo characterDamageInfo)));
        }
        private void CharacterOnOnHitBlockedByShield(TzarGames.TzarHero.ICharacterDamageInfo characterDamageInfo)
        {
            var val_5;
            var val_6;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = characterDamageInfo;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_6 = characterDamageInfo;
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
            TzarGames.GameFramework.TzarBehaviour val_4 = UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
        }
        private void OnDisable()
        {
            if(0 == this._character)
            {
                    return;
            }
            
            this._character.remove_OnHitBlockedByShield(value:  new System.Action<TzarGames.TzarHero.ICharacterDamageInfo>(object:  this, method:  System.Void TzarGames.Endless.BlockHitEffectSpawner::CharacterOnOnHitBlockedByShield(TzarGames.TzarHero.ICharacterDamageInfo characterDamageInfo)));
        }
    
    }

}
