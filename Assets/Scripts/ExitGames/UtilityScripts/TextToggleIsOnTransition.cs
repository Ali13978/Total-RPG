using UnityEngine;

namespace ExitGames.UtilityScripts
{
    [UnityEngine.RequireComponent]
    public class TextToggleIsOnTransition : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IEventSystemHandler
    {
        // Fields
        public UnityEngine.UI.Toggle toggle;
        private UnityEngine.UI.Text _text;
        public UnityEngine.Color NormalOnColor;
        public UnityEngine.Color NormalOffColor;
        public UnityEngine.Color HoverOnColor;
        public UnityEngine.Color HoverOffColor;
        private bool isHover;
        
        // Methods
        public TextToggleIsOnTransition()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.NormalOnColor = val_1;
            mem[1152921512491589004] = val_1.g;
            mem[1152921512491589008] = val_1.b;
            mem[1152921512491589012] = val_1.a;
            UnityEngine.Color val_2 = UnityEngine.Color.black;
            this.NormalOffColor = val_2;
            mem[1152921512491589020] = val_2.g;
            mem[1152921512491589024] = val_2.b;
            mem[1152921512491589028] = val_2.a;
            UnityEngine.Color val_3 = UnityEngine.Color.black;
            this.HoverOnColor = val_3;
            mem[1152921512491589036] = val_3.g;
            mem[1152921512491589040] = val_3.b;
            mem[1152921512491589044] = val_3.a;
            UnityEngine.Color val_4 = UnityEngine.Color.black;
            this.HoverOffColor = val_4;
            mem[1152921512491589052] = val_4.g;
            mem[1152921512491589056] = val_4.b;
            mem[1152921512491589060] = val_4.a;
        }
        public void OnEnable()
        {
            this._text = this.GetComponent<UnityEngine.UI.Text>();
            this.toggle.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  public System.Void ExitGames.UtilityScripts.TextToggleIsOnTransition::OnValueChanged(bool isOn)));
        }
        public void OnDisable()
        {
            this.toggle.onValueChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  public System.Void ExitGames.UtilityScripts.TextToggleIsOnTransition::OnValueChanged(bool isOn)));
        }
        public void OnValueChanged(bool isOn)
        {
            UnityEngine.Color val_1;
            if(isOn == false)
            {
                goto label_0;
            }
            
            if(this.isHover == false)
            {
                goto label_1;
            }
            
            val_1 = this.HoverOnColor;
            goto label_5;
            label_0:
            if(this.isHover == false)
            {
                goto label_3;
            }
            
            val_1 = this.NormalOnColor;
            goto label_5;
            label_1:
            val_1 = this.HoverOffColor;
            goto label_5;
            label_3:
            val_1 = this.NormalOffColor;
            label_5:
            this._text.color = new UnityEngine.Color() {r = val_1, g = V9.16B, b = V10.16B, a = V11.16B};
        }
        public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
        {
            UnityEngine.Color val_2;
            this.isHover = true;
            if(this.toggle.isOn != false)
            {
                    val_2 = this.HoverOnColor;
            }
            else
            {
                    val_2 = this.HoverOffColor;
            }
            
            this._text.color = new UnityEngine.Color() {r = val_2, g = V9.16B, b = V10.16B, a = V11.16B};
        }
        public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
        {
            UnityEngine.Color val_2;
            this.isHover = false;
            if(this.toggle.isOn != false)
            {
                    val_2 = this.NormalOnColor;
            }
            else
            {
                    val_2 = this.NormalOffColor;
            }
            
            this._text.color = new UnityEngine.Color() {r = val_2, g = V9.16B, b = V10.16B, a = V11.16B};
        }
    
    }

}
