using UnityEngine;

namespace TzarGames.Endless
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class DefencePotion : TH_Item, IUsableByCharacter
    {
        // Fields
        [UnityEngine.SerializeField]
        private float duration;
        [UnityEngine.SerializeField]
        private float multiplier;
        
        // Methods
        public DefencePotion()
        {
            this.duration = 60f;
            this.multiplier = 5.510186E-41f;
        }
        public override string GetDescription()
        {
            float val_5 = 60f;
            val_5 = this.duration / val_5;
            int val_1 = UnityEngine.Mathf.FloorToInt(f:  val_5);
            float val_6 = this.multiplier;
            val_6 = val_6 + (-1f);
            val_6 = val_6 * 100f;
            return (string)System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0), arg1:  UnityEngine.Mathf.FloorToInt(f:  val_6));
        }
        public bool ApplyToCharacter(TzarGames.TzarHero.TH_Character character)
        {
            return false;
        }
        public bool MustBeDestroyedAfterUse()
        {
            return true;
        }
    
    }

}
