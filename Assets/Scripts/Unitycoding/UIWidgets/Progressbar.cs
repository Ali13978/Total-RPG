using UnityEngine;

namespace Unitycoding.UIWidgets
{
    public class Progressbar : UIWidget
    {
        // Fields
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        protected UnityEngine.UI.Image progressbar;
        [UnityEngine.SerializeField]
        protected UnityEngine.UI.Text progressLabel;
        [UnityEngine.SerializeField]
        protected string format;
        
        // Methods
        public Progressbar()
        {
            this.format = "F0";
        }
        protected override void OnStart()
        {
            this.progressbar.type = 3;
        }
        public virtual void SetProgress(float progress)
        {
            this.progressbar.fillAmount = progress;
            if(0 == this.progressLabel)
            {
                    return;
            }
            
            float val_4 = 100f;
            val_4 = progress * val_4;
            this = 0 + val_4.ToString(format:  this.format)(val_4.ToString(format:  this.format));
        }
        public override void Show()
        {
            this.progressbar.fillAmount = 0f;
            bool val_1 = UnityEngine.Object.op_Inequality(x:  0, y:  this.progressLabel);
            this.Show();
        }
    
    }

}
