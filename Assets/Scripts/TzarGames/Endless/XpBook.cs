using UnityEngine;

namespace TzarGames.Endless
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class XpBook : TH_Item, IUsableByCharacter
    {
        // Fields
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private bool isGold;
        [UnityEngine.SerializeField]
        private float duration;
        [UnityEngine.SerializeField]
        private float multiplier;
        
        // Methods
        public XpBook()
        {
            this.duration = 60f;
            this.multiplier = 2f;
        }
        public override string GetDescription()
        {
            float val_5 = 60f;
            val_5 = this.duration / val_5;
            int val_1 = UnityEngine.Mathf.CeilToInt(f:  val_5);
            float val_6 = this.multiplier;
            val_6 = val_6 + (-1f);
            val_6 = val_6 * 100f;
            return (string)System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0), arg1:  UnityEngine.Mathf.CeilToInt(f:  val_6));
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
