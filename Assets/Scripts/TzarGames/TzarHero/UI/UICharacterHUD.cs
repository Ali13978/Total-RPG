using UnityEngine;

namespace TzarGames.TzarHero.UI
{
    public class UICharacterHUD : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Character character;
        [UnityEngine.SerializeField]
        private float updateInterval;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform targetInfoPanel;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Slider targetHealthSlider;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI targetNameText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset targetFormatString;
        private TzarGames.TzarHero.TH_InteractiveObject lastTarget;
        private float lastUpdateTime;
        private System.Text.StringBuilder targetTextBuilder;
        private System.Text.StringBuilder hpTextBuilder;
        
        // Properties
        public TzarGames.TzarHero.TH_Character Character { get; }
        
        // Methods
        public UICharacterHUD()
        {
            this.updateInterval = 0.1f;
            this.targetTextBuilder = new System.Text.StringBuilder(capacity:  256);
            this.hpTextBuilder = new System.Text.StringBuilder(capacity:  256);
        }
        public TzarGames.TzarHero.TH_Character get_Character()
        {
            return (TzarGames.TzarHero.TH_Character)this.character;
        }
        protected override void OnPlayerOwnerSet(TzarGames.GameFramework.Player player)
        {
            var val_9;
            UnityEngine.GameObject val_10;
            val_9 = this;
            val_10 = player.PlayerObject;
            if(0 == val_10)
            {
                    return;
            }
            
            this.character = player.PlayerObject.GetComponent<TzarGames.TzarHero.TH_Character>();
            val_9 = ???;
            val_10 = ???;
            goto typeof(TzarGames.TzarHero.UI.UICharacterHUD).__il2cppRuntimeField_1A0;
        }
        protected virtual void updateCharacterStats()
        {
            var val_40;
            UnityEngine.Object val_41;
            var val_42;
            string val_43;
            float val_44;
            val_40 = this.character.TemplateInstance;
            if(val_40 != null)
            {
                    float val_2 = val_40.ActualHitPoints;
            }
            else
            {
                    float val_3 = 0.ActualHitPoints;
                val_40 = 0;
            }
            
            float val_4 = val_40.HitPoints;
            if((0 == this.character.Target) || (0 == this.targetInfoPanel))
            {
                goto label_10;
            }
            
            if(this.targetInfoPanel.gameObject.activeSelf != true)
            {
                    this.targetInfoPanel.gameObject.SetActive(value:  true);
            }
            
            val_41 = 0;
            if(this.character.Target == null)
            {
                goto label_19;
            }
            
            val_41 = 0;
            goto label_19;
            label_10:
            if(0 == this.targetInfoPanel)
            {
                    return;
            }
            
            if(this.targetInfoPanel.gameObject.activeSelf == false)
            {
                    return;
            }
            
            this.targetInfoPanel.gameObject.SetActive(value:  false);
            return;
            label_19:
            TzarGames.TzarHero.TH_InteractiveObject val_18 = this.character.Target;
            val_42 = 0.TemplateInstance;
            val_41 = this.character.Target;
            val_43 = 0;
            if(0 != val_41)
            {
                    this.lastTarget = this.character.Target;
                this.targetTextBuilder.Length = 0;
                if(0 != this.targetTextBuilder)
            {
                    System.Text.StringBuilder val_25 = this.targetTextBuilder.Append(value:  val_41.Text);
            }
            
                val_41 = this.targetFormatString.Text;
                System.Text.StringBuilder val_27 = this.targetTextBuilder.Append(value:  val_41);
                System.Text.StringBuilder val_29 = this.targetTextBuilder.Append(value:  0.Level);
                val_43 = this.targetTextBuilder;
            }
            
            if(val_42 != null)
            {
                    val_44 = val_42.ActualHitPoints;
            }
            else
            {
                    val_44 = 0.ActualHitPoints;
                val_42 = 0;
            }
            
            float val_33 = val_42.HitPoints;
            val_44 = val_44 / val_33;
            float val_40 = System.Math.Abs(val_33 - val_44);
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return;
            }
            
            if((System.String.Equals(a:  0, b:  this.targetNameText.text)) != false)
            {
                    return;
            }
            
            this.targetNameText.text = val_43;
        }
        protected virtual void Update()
        {
            if(0 == this.character)
            {
                    if(0 == this.targetInfoPanel)
            {
                    return;
            }
            
                if(this.targetInfoPanel.gameObject.activeSelf == false)
            {
                    return;
            }
            
                this.targetInfoPanel.gameObject.SetActive(value:  false);
                return;
            }
            
            float val_6 = UnityEngine.Time.time;
            val_6 = val_6 - this.lastUpdateTime;
            if(val_6 < this.updateInterval)
            {
                    return;
            }
            
            this.lastUpdateTime = UnityEngine.Time.time;
            goto typeof(TzarGames.TzarHero.UI.UICharacterHUD).__il2cppRuntimeField_1A0;
        }
    
    }

}
