using UnityEngine;

namespace TzarGames.Endless.UI
{
    [Serializable]
    internal class StatisticsUiElement
    {
        // Fields
        public TzarGames.Common.LocalizedStringAsset StringFormat;
        public TzarGames.Common.UI.TextUI Text;
        
        // Methods
        public StatisticsUiElement()
        {
        
        }
        public void Update(int value)
        {
            this.Text.text = System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
        }
    
    }

}
