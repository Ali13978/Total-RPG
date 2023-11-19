using UnityEngine;

namespace TzarGames.Endless
{
    public class Trap : MonoBehaviour
    {
        // Fields
        private TzarGames.TzarHero.TH_Character freezedCharacter;
        
        // Methods
        public Trap()
        {
        
        }
        public void ApplyToCharacter(TzarGames.TzarHero.TH_Character character, float freezeTime)
        {
            var val_10;
            if(0 != this.freezedCharacter)
            {
                    return;
            }
            
            this.freezedCharacter = character;
            Trap.TrapInfluence val_3 = new Trap.TrapInfluence(instigator:  0, effectTime:  freezeTime);
            System.Action<TzarGames.TzarHero.Interfaces.IInfluence> val_4 = new System.Action<TzarGames.TzarHero.Interfaces.IInfluence>(object:  this, method:  System.Void TzarGames.Endless.Trap::Character_OnInfluenceRemoved(TzarGames.TzarHero.Interfaces.IInfluence obj));
            if(character != null)
            {
                    character.add_OnInfluenceRemoved(value:  val_4);
                character.AddInfluence(influence:  val_3);
                character.StopMove();
            }
            else
            {
                    0.add_OnInfluenceRemoved(value:  val_4);
                0.AddInfluence(influence:  val_3);
                0.StopMove();
            }
            
            if(character.Movement != null)
            {
                    var val_10 = 0;
                val_10 = val_10 + 1;
                val_10 = character.Movement;
            }
            
            UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  this.delay(freezeTime:  freezeTime));
        }
        private void Character_OnInfluenceRemoved(TzarGames.TzarHero.Interfaces.IInfluence obj)
        {
            if(0 != this.freezedCharacter)
            {
                    this.freezedCharacter.remove_OnInfluenceRemoved(value:  new System.Action<TzarGames.TzarHero.Interfaces.IInfluence>(object:  this, method:  System.Void TzarGames.Endless.Trap::Character_OnInfluenceRemoved(TzarGames.TzarHero.Interfaces.IInfluence obj)));
            }
            
            UnityEngine.GameObject val_3 = this.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator delay(float freezeTime)
        {
            if(null != 0)
            {
                    typeof(Trap.<delay>c__Iterator0).__il2cppRuntimeField_10 = freezeTime;
            }
            else
            {
                    mem[16] = freezeTime;
            }
            
            typeof(Trap.<delay>c__Iterator0).__il2cppRuntimeField_18 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
