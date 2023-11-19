using UnityEngine;

namespace TzarGames.Endless
{
    public class ChangeCharacterLevel : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Character character;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.ChangeCharacterLevel.ChangeMode changeMode;
        [UnityEngine.SerializeField]
        private uint levelAddition;
        [UnityEngine.SerializeField]
        private float stageMultiplier;
        
        // Methods
        public ChangeCharacterLevel()
        {
            this.stageMultiplier = 1f;
        }
        private void Reset()
        {
            this.character = this.GetComponent<TzarGames.TzarHero.TH_Character>();
        }
        private void Start()
        {
            if(0 == TzarGames.Endless.EndlessGameState._instance)
            {
                    return;
            }
            
            this.ChangeOnCharacter(targetCharacter:  this.character);
        }
        public void ChangeOnCharacter(TzarGames.TzarHero.TH_Character targetCharacter)
        {
            TzarGames.Endless.EndlessGameState val_7;
            var val_8;
            var val_9;
            var val_11;
            val_7 = TzarGames.Endless.EndlessGameState._instance;
            if(0 == val_7)
            {
                goto label_4;
            }
            
            if(this.changeMode == 1)
            {
                goto label_5;
            }
            
            if(this.changeMode != 0)
            {
                goto label_6;
            }
            
            if(null == 0)
            {
                goto label_8;
            }
            
            val_7 = SelectedCharacter;
            if(val_7 != null)
            {
                goto label_9;
            }
            
            goto label_10;
            label_4:
            val_9 = 0;
            goto label_11;
            label_5:
            if(null == 0)
            {
                goto label_13;
            }
            
            val_7 = SelectedCharacter;
            if(val_7 != null)
            {
                goto label_14;
            }
            
            goto label_15;
            label_13:
            val_7 = 0;
            label_15:
            val_8 = 0;
            label_14:
            if(mem[282584257676929] == 0)
            {
                goto label_23;
            }
            
            var val_6 = mem[282584257676823];
            var val_7 = 0;
            val_6 = val_6 + 8;
            label_18:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_17;
            }
            
            val_7 = val_7 + 1;
            val_6 = val_6 + 16;
            if(val_7 < mem[282584257676929])
            {
                goto label_18;
            }
            
            goto label_23;
            label_8:
            val_7 = 0;
            label_10:
            val_8 = 0;
            label_9:
            if(mem[282584257676929] == 0)
            {
                goto label_23;
            }
            
            var val_8 = mem[282584257676823];
            var val_9 = 0;
            val_8 = val_8 + 8;
            label_22:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_21;
            }
            
            val_9 = val_9 + 1;
            val_8 = val_8 + 16;
            if(val_9 < mem[282584257676929])
            {
                goto label_22;
            }
            
            goto label_23;
            label_17:
            val_11 = val_6 + 3;
            goto label_24;
            label_21:
            val_11 = val_8 + 1;
            label_24:
            val_8 = val_8 + val_11;
            val_8 = val_8 + 272;
            label_23:
            val_9 = val_7;
            label_11:
            float val_10 = this.stageMultiplier;
            val_10 = val_10 * (float)0;
            targetCharacter.Level = val_11 + this.levelAddition;
            return;
            label_6:
            System.Exception val_5 = new System.Exception(message:  "Unknown mode");
        }
        public void ChangeOnGameObject(UnityEngine.GameObject targetCharacter)
        {
            TzarGames.TzarHero.TH_Character val_1 = targetCharacter.GetComponent<TzarGames.TzarHero.TH_Character>();
            if(0 == val_1)
            {
                    return;
            }
            
            this.ChangeOnCharacter(targetCharacter:  val_1);
        }
    
    }

}
