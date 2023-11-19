using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class BattleHealingFloatingLabelUI : MonoBehaviour, IBattleHealingEventHandler
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.FloatingLabelScreenUI labelScreen;
        [UnityEngine.SerializeField]
        private UnityEngine.Color color;
        
        // Methods
        public BattleHealingFloatingLabelUI()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.green;
            this.color = val_1;
            mem[1152921510878285156] = val_1.g;
            mem[1152921510878285160] = val_1.b;
            mem[1152921510878285164] = val_1.a;
        }
        public void OnCharacterHealed(TzarGames.TzarHero.TH_Character character, float healValue)
        {
            UnityEngine.Color val_8;
            TzarGames.Endless.PlayerCharacter val_9;
            val_8 = healValue;
            val_9 = this.labelScreen._character;
            if(0 != character)
            {
                    return;
            }
            
            if(this.enabled == false)
            {
                    return;
            }
            
            val_9 = this.labelScreen;
            val_8 = this.color;
            UnityEngine.Vector3 val_5 = character.Position;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            val_9.AddCommonLabel(text:  System.String.Format(format:  0, arg0:  "+{0} HP"), color:  new UnityEngine.Color() {r = val_8, g = V9.16B, b = V10.16B, a = V11.16B}, position:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        }
        private void Awake()
        {
            TzarGames.Common.EventSystem.Event<TzarGames.TzarHero.ICharacterEvents>.AddHandler(obj:  0);
        }
        private void OnDestroy()
        {
            TzarGames.Common.EventSystem.Event<TzarGames.TzarHero.ICharacterEvents>.RemoveHandler(obj:  0);
        }
    
    }

}
