using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.RequireComponent]
    public class DropDownListButton
    {
        // Fields
        public UnityEngine.RectTransform rectTransform;
        public UnityEngine.UI.Button btn;
        public UnityEngine.UI.Text txt;
        public UnityEngine.UI.Image btnImg;
        public UnityEngine.UI.Image img;
        public UnityEngine.GameObject gameobject;
        
        // Methods
        public DropDownListButton(UnityEngine.GameObject btnObj)
        {
            this.gameobject = btnObj;
            this.rectTransform = btnObj.GetComponent<UnityEngine.RectTransform>();
            if(btnObj != null)
            {
                    this.btnImg = btnObj.GetComponent<UnityEngine.UI.Image>();
            }
            else
            {
                    this.btnImg = 0.GetComponent<UnityEngine.UI.Image>();
            }
            
            this.btn = btnObj.GetComponent<UnityEngine.UI.Button>();
            this.txt = this.rectTransform.Find(name:  "Text").GetComponent<UnityEngine.UI.Text>();
            this.img = this.rectTransform.Find(name:  "Image").GetComponent<UnityEngine.UI.Image>();
        }
    
    }

}
