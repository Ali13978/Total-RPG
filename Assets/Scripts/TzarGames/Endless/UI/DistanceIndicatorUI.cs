using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class DistanceIndicatorUI : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform container;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Image indicatorImage;
        [UnityEngine.SerializeField]
        private UnityEngine.Color farColor;
        [UnityEngine.SerializeField]
        private UnityEngine.Color nearColor;
        [UnityEngine.SerializeField]
        private UnityEngine.Animation _animation;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.LayoutElement layoutElement;
        private TzarGames.Endless.ObjectDistanceIndicator indicator;
        private float lastValue;
        
        // Methods
        public DistanceIndicatorUI()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.farColor = val_1;
            mem[1152921510899293100] = val_1.g;
            mem[1152921510899293104] = val_1.b;
            mem[1152921510899293108] = val_1.a;
            UnityEngine.Color val_2 = UnityEngine.Color.red;
            this.nearColor = val_2;
            mem[1152921510899293116] = val_2.g;
            mem[1152921510899293120] = val_2.b;
            mem[1152921510899293124] = val_2.a;
            this.lastValue = -1f;
        }
        protected override void Awake()
        {
            this.Awake();
            this.Show(show:  false);
        }
        protected override void OnPlayerOwnerSet(TzarGames.GameFramework.Player owner)
        {
            this.OnPlayerOwnerSet(owner:  owner);
            TzarGames.Endless.ObjectDistanceIndicator val_1 = owner.PlayerObject.GetComponentInChildren<TzarGames.Endless.ObjectDistanceIndicator>();
            this.indicator = val_1;
            val_1.add_OnObservedCountChanged(value:  new System.Action<TzarGames.Endless.ObjectDistanceIndicator>(object:  this, method:  System.Void TzarGames.Endless.UI.DistanceIndicatorUI::IndicatorOnOnObservedCountChanged(TzarGames.Endless.ObjectDistanceIndicator objectDistanceIndicator)));
        }
        private void OnDestroy()
        {
            if(0 == this.indicator)
            {
                    return;
            }
            
            this.indicator.remove_OnObservedCountChanged(value:  new System.Action<TzarGames.Endless.ObjectDistanceIndicator>(object:  this, method:  System.Void TzarGames.Endless.UI.DistanceIndicatorUI::IndicatorOnOnObservedCountChanged(TzarGames.Endless.ObjectDistanceIndicator objectDistanceIndicator)));
        }
        private void IndicatorOnOnObservedCountChanged(TzarGames.Endless.ObjectDistanceIndicator objectDistanceIndicator)
        {
            var val_2;
            if(objectDistanceIndicator.ObservedObjectsCount >= 1)
            {
                    val_2 = 1;
            }
            else
            {
                    val_2 = 0;
            }
            
            this.Show(show:  false);
        }
        private void Update()
        {
            UnityEngine.Sprite val_13;
            UnityEngine.Animation val_14;
            var val_15;
            if(0 == this.indicator)
            {
                    return;
            }
            
            if(this.container.gameObject.activeSelf == false)
            {
                    return;
            }
            
            val_13 = this.indicatorImage.sprite;
            if(0 != this.indicator.Icon)
            {
                    val_13 = this.indicator.Icon;
                this.indicatorImage.sprite = val_13;
            }
            
            float val_9 = this.indicator.NormalizedDistance;
            bool val_10 = this._animation.enabled;
            if(val_9 >= 1f)
            {
                goto label_16;
            }
            
            if(val_10 == true)
            {
                goto label_20;
            }
            
            val_14 = this._animation;
            val_15 = 1;
            goto label_19;
            label_16:
            if(val_10 == false)
            {
                goto label_20;
            }
            
            val_14 = this._animation;
            val_15 = 0;
            label_19:
            val_14.enabled = false;
            label_20:
            float val_13 = this.lastValue;
            val_13 = val_9 - val_13;
            if(System.Math.Abs(val_13) <= 0.0001f)
            {
                    return;
            }
            
            this.lastValue = val_9;
            UnityEngine.Color val_12 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = this.nearColor, g = 0.0001f}, b:  new UnityEngine.Color() {r = this.farColor}, t:  val_9);
            this.indicatorImage.color = new UnityEngine.Color() {r = val_12.r, g = val_12.g, b = val_12.b, a = val_12.a};
        }
        public void Show(bool show)
        {
            this.container.gameObject.SetActive(value:  show);
            var val_3 = (~show) & 1;
            goto typeof(UnityEngine.UI.LayoutElement).__il2cppRuntimeField_2D0;
        }
    
    }

}
