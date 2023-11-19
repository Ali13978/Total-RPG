using UnityEngine;

namespace TzarGames.Endless
{
    public class MaskTakeMessage : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset messageTemplate;
        [UnityEngine.SerializeField]
        private float showTime;
        
        // Methods
        public MaskTakeMessage()
        {
            this.showTime = 10f;
        }
        public void OnMaskTaken(TzarGames.GameFramework.Item item)
        {
            UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>().AddTempNotification(message:  System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0)), time:  this.showTime);
        }
    
    }

}
