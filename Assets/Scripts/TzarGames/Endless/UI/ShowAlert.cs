using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class ShowAlert : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private string _message;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset localizedMessage;
        [UnityEngine.SerializeField]
        private bool useGlobalUI;
        
        // Methods
        public ShowAlert()
        {
        
        }
        public void ShowLocalizedMessage(TzarGames.Common.LocalizedStringAsset message)
        {
            this.Show(message:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
        }
        public void Show(string message)
        {
            if(this.useGlobalUI != false)
            {
                    TzarGames.Endless.UI.GlobalUI val_1 = TzarGames.Endless.UI.GlobalUI.Instance;
                if(0 == val_1)
            {
                    return;
            }
            
                val_1.Alert.Show(message:  message);
                return;
            }
            
            UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>().ShowAlert(message:  message);
        }
        public void Show()
        {
            string val_3;
            if(0 == this.localizedMessage)
            {
                    val_3 = this._message;
            }
            else
            {
                    val_3 = TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
            }
            
            this.Show(message:  val_3);
        }
    
    }

}
