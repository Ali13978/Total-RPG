using UnityEngine;

namespace TzarGames.Endless.UI.Chat
{
    public class ChatMessageUI : MonoBehaviour, IPoolable
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI messageText;
        private const string messageFormat = "<color=#{0}>{1}:</color> {2}";
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private string <PlayerName>k__BackingField;
        
        // Properties
        public string PlayerName { get; set; }
        
        // Methods
        public ChatMessageUI()
        {
        
        }
        public string get_PlayerName()
        {
            return (string)this.<PlayerName>k__BackingField;
        }
        private void set_PlayerName(string value)
        {
            this.<PlayerName>k__BackingField = value;
        }
        public void Build(string playerName, ref UnityEngine.Color playerNameColor, string message)
        {
            this.<PlayerName>k__BackingField = playerName;
            this.messageText.text = System.String.Format(format:  0, arg0:  "<color=#{0}>{1}:</color> {2}", arg1:  UnityEngine.ColorUtility.ToHtmlStringRGBA(color:  new UnityEngine.Color() {r = playerNameColor.r, g = playerNameColor.g, b = playerNameColor.b, a = playerNameColor.a}), arg2:  playerName);
        }
        public void OnPushedToPool()
        {
            this.<PlayerName>k__BackingField = 0;
            this.messageText.enabled = false;
        }
        public void OnPulledFromPool()
        {
            this.messageText.enabled = true;
        }
    
    }

}
