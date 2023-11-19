using UnityEngine;

namespace TzarGames.TzarHero
{
    public class KillCharacterOnTriggerEnter : MonoBehaviour
    {
        // Methods
        public KillCharacterOnTriggerEnter()
        {
        
        }
        public void OnCharacterEnterToTrigger(TzarGames.TzarHero.TH_Character other)
        {
            if(this.enabled == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_2 = other.Position;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.down;
            TzarGames.TzarHero.TH_DamageType val_8 = new TzarGames.TzarHero.TH_DamageType(surfaceType:  TzarGames.GameFramework.SurfaceTypeBase.Default);
            var val_11 = ~val_8.OnClient;
            val_11 = val_11 & 1;
            typeof(TzarGames.TzarHero.CharacterDamageInfo).__il2cppRuntimeField_38 = 0;
            typeof(TzarGames.TzarHero.CharacterDamageInfo).__il2cppRuntimeField_40 = other;
            typeof(TzarGames.TzarHero.CharacterDamageInfo).__il2cppRuntimeField_36 = val_11;
            typeof(TzarGames.TzarHero.CharacterDamageInfo).__il2cppRuntimeField_35 = 1;
            other.TakeDamage(damageInfo:  new TzarGames.GameFramework.DamageInfoBase(damage:  3.402823E+38f, force:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, damageType:  val_8, hitInfo:  new TzarGames.GameFramework.Hit(point:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, normal:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, collider:  0, rigidbody:  0, surfaceType:  TzarGames.GameFramework.SurfaceTypeBase.Default)));
        }
    
    }

}
