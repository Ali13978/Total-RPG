using UnityEngine;

namespace ExitGames.UtilityScripts
{
    [UnityEngine.RequireComponent]
    public class TextButtonTransition : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IEventSystemHandler
    {
        // Fields
        private UnityEngine.UI.Text _text;
        public UnityEngine.Color NormalColor;
        public UnityEngine.Color HoverColor;
        
        // Methods
        public TextButtonTransition()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.NormalColor = val_1;
            mem[1152921512491100036] = val_1.g;
            mem[1152921512491100040] = val_1.b;
            mem[1152921512491100044] = val_1.a;
            UnityEngine.Color val_2 = UnityEngine.Color.black;
            this.HoverColor = val_2;
            mem[1152921512491100052] = val_2.g;
            mem[1152921512491100056] = val_2.b;
            mem[1152921512491100060] = val_2.a;
        }
        public void Awake()
        {
            this._text = this.GetComponent<UnityEngine.UI.Text>();
        }
        public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this._text.color = new UnityEngine.Color() {r = this.HoverColor, g = V9.16B, b = V10.16B, a = V11.16B};
        }
        public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this._text.color = new UnityEngine.Color() {r = this.NormalColor, g = V9.16B, b = V10.16B, a = V11.16B};
        }
    
    }

}
