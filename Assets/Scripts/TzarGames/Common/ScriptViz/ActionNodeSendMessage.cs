using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class ActionNodeSendMessage : ActionNode
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject receiver;
        [UnityEngine.SerializeField]
        private string methodName;
        [UnityEngine.SerializeField]
        private string data;
        [UnityEngine.SerializeField]
        private UnityEngine.SendMessageOptions options;
        
        // Methods
        public ActionNodeSendMessage()
        {
            this.methodName = "OnStringMessage";
            this.data = "Some Data";
        }
        public override void OnImpulse(TzarGames.Common.NodeSlot slot)
        {
            if(0 != this.receiver)
            {
                    this.receiver.SendMessage(methodName:  this.methodName, value:  this.data, options:  this.options);
            }
            
            this.Impulse();
        }
    
    }

}
