using UnityEngine;

namespace TzarGames.Common
{
    [Serializable]
    public class LocalizedString
    {
        // Fields
        [UnityEngine.MultilineAttribute]
        [UnityEngine.SerializeField]
        private string text;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset _stringAsset;
        
        // Properties
        public string Text { get; }
        
        // Methods
        public LocalizedString(string text)
        {
            this.text = text;
        }
        public string get_Text()
        {
            return (string)this.text;
        }
        public static TzarGames.Common.LocalizedString op_Implicit(string text)
        {
            typeof(TzarGames.Common.LocalizedString).__il2cppRuntimeField_10 = X1;
            return (TzarGames.Common.LocalizedString)new System.Object();
        }
        public static string op_Implicit(TzarGames.Common.LocalizedString text)
        {
            if(X1 != 0)
            {
                    return (string)X1 + 16;
            }
            
            return (string)X1 + 16;
        }
    
    }

}
