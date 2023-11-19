using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class AlertUI : StateMachine
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI text;
        [UnityEngine.SerializeField]
        private UnityEngine.Animation _animation;
        private System.Collections.Generic.List<string> messages;
        
        // Methods
        public AlertUI()
        {
            this.messages = new System.Collections.Generic.List<System.String>();
        }
        [TzarGames.Common.ConsoleCommand]
        public void Show(string message)
        {
            this.messages.Add(item:  message);
            bool val_1 = this.GotoState<AlertUI.Showing>(stateData:  0);
        }
        public void Disable()
        {
            bool val_1 = this.GotoState<AlertUI.Disabled>(stateData:  0);
        }
        private void Update()
        {
            if(this.CurrentState == null)
            {
                
            }
        
        }
    
    }

}
