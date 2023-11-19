using UnityEngine;

namespace TzarGames.Endless.Skills
{
    public class PowerAttack : AnimBasedAttackSkill
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject effect;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.TrailFxInfo trailSettings;
        
        // Methods
        public PowerAttack()
        {
        
        }
        protected override void onHit(TzarGames.TzarHero.CharacterDamageInfo hit)
        {
            var val_5;
            this.onHit(hit:  hit);
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = hit.Hit;
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
            TzarGames.GameFramework.TzarBehaviour val_4 = UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
        }
        protected override void OnStarted()
        {
            TzarGames.Endless.TrailFxInfo val_5;
            var val_6;
            val_5 = this;
            this.OnStarted();
            if(0 == this.trailSettings)
            {
                    return;
            }
            
            TzarGames.TzarHero.TH_Character val_2 = this.Character;
            if(val_2 != null)
            {
                    val_6 = null;
                val_6 = null;
                val_2 = (((TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.PlayerCharacterBase.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_6) ? (val_2) : 0;
            }
            
            if(0 == 0.TrailController)
            {
                    return;
            }
            
            val_5 = this.trailSettings;
            val_3.trailSettings = val_5;
        }
        protected override void OnStopped()
        {
            var val_4;
            this.OnStopped();
            TzarGames.TzarHero.TH_Character val_1 = this.Character;
            if(val_1 != null)
            {
                    val_4 = null;
                val_4 = null;
                val_1 = (((TzarGames.TzarHero.TH_Character.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.PlayerCharacterBase.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_4) ? (val_1) : 0;
            }
            
            TzarGames.Endless.TrailFxController val_2 = 0.TrailController;
            if(0 == val_2)
            {
                    return;
            }
            
            if(val_2 != null)
            {
                    val_2.trailSettings = 0;
            }
            else
            {
                    mem[32] = 0;
            }
            
            val_2.ResetTrails();
        }
    
    }

}
