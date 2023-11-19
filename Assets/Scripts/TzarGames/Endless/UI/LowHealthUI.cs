using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class LowHealthUI : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.CanvasRenderer[] canvasRenderers;
        [UnityEngine.SerializeField]
        private float activationPercent;
        private int renderCount;
        private TzarGames.TzarHero.TH_Character character;
        
        // Methods
        public LowHealthUI()
        {
            this.activationPercent = 0.3f;
        }
        protected override void OnPlayerOwnerSet(TzarGames.GameFramework.Player owner)
        {
            var val_2;
            this.OnPlayerOwnerSet(owner:  owner);
            val_2 = 0;
            this.character = ;
            this.renderCount = this.canvasRenderers.Length;
        }
        private void OnDisable()
        {
            if(this.renderCount < 1)
            {
                    return;
            }
            
            var val_4 = 0;
            do
            {
                UnityEngine.UI.Graphic val_1 = this.canvasRenderers[0].GetComponent<UnityEngine.UI.Graphic>();
                UnityEngine.Color val_2 = UnityEngine.Color.clear;
                val_4 = val_4 + 1;
            }
            while(val_4 < this.renderCount);
        
        }
        private void OnEnable()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.enableColor());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator enableColor()
        {
            typeof(LowHealthUI.<enableColor>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void Update()
        {
            float val_8;
            var val_9;
            if(0 == this.character)
            {
                    return;
            }
            
            float val_3 = this.character.ActualHealth;
            float val_5 = this.character.BaseHealth * this.activationPercent;
            if(val_5 <= 0f)
            {
                goto label_6;
            }
            
            val_8 = 1f - (val_3 / val_5);
            float val_7 = this.canvasRenderers[0].GetAlpha();
            val_7 = val_7 - val_8;
            if(System.Math.Abs(val_7) < 0)
            {
                    return;
            }
            
            if(val_3 <= val_5)
            {
                goto label_11;
            }
            
            if(this.renderCount <= 0)
            {
                    return;
            }
            
            val_8 = 0f;
            do
            {
                this.canvasRenderers[0].SetAlpha(alpha:  val_8);
                val_9 = 0 + 1;
            }
            while(val_9 < this.renderCount);
            
            return;
            label_6:
            if(this.renderCount < 1)
            {
                    return;
            }
            
            val_8 = 1f;
            do
            {
                this.canvasRenderers[0].SetAlpha(alpha:  val_8);
                val_9 = 0 + 1;
            }
            while(val_9 < this.renderCount);
            
            return;
            label_11:
            if(this.renderCount <= 0)
            {
                    return;
            }
            
            do
            {
                this.canvasRenderers[0].SetAlpha(alpha:  val_8);
                val_9 = 0 + 1;
            }
            while(val_9 < this.renderCount);
        
        }
    
    }

}
