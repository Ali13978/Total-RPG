using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class MaskGroupUI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.MaskItemUI[] maskIcons;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Button getRewardButton;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.Endless.UI.MaskGroupUI> OnGetRewardClicked;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.Endless.UI.MaskItemUI> OnMaskClicked;
        
        // Properties
        public TzarGames.Endless.UI.MaskItemUI[] MaskIcons { get; }
        public bool CanGetReward { get; set; }
        
        // Methods
        public MaskGroupUI()
        {
        
        }
        public void add_OnGetRewardClicked(System.Action<TzarGames.Endless.UI.MaskGroupUI> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnGetRewardClicked);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921510984112584 != this.OnGetRewardClicked);
        
        }
        public void remove_OnGetRewardClicked(System.Action<TzarGames.Endless.UI.MaskGroupUI> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnGetRewardClicked);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921510984249160 != this.OnGetRewardClicked);
        
        }
        public void add_OnMaskClicked(System.Action<TzarGames.Endless.UI.MaskItemUI> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnMaskClicked);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921510984385744 != this.OnMaskClicked);
        
        }
        public void remove_OnMaskClicked(System.Action<TzarGames.Endless.UI.MaskItemUI> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnMaskClicked);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921510984522320 != this.OnMaskClicked);
        
        }
        private void Awake()
        {
            var val_5;
            var val_6;
            val_5 = 0;
            goto label_1;
            label_10:
            X21.AddListener(call:  X22);
            val_5 = 1;
            label_1:
            if(val_5 >= this.maskIcons.Length)
            {
                    return;
            }
            
            object val_1 = new System.Object();
            TzarGames.Endless.UI.MaskItemUI val_5 = this.maskIcons[1];
            if(null != 0)
            {
                    val_6 = val_1;
                typeof(MaskGroupUI.<Awake>c__AnonStorey0).__il2cppRuntimeField_10 = val_5;
                MaskGroupUI.<Awake>c__AnonStorey0.__il2cppRuntimeField_name.__il2cppRuntimeField_8 = this;
            }
            else
            {
                    mem[16] = val_5;
                mem[24] = this;
                val_6 = 16;
            }
            
            UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  val_1, method:  System.Void MaskGroupUI.<Awake>c__AnonStorey0::<>m__0());
            if((val_6.GetComponentInChildren<UnityEngine.UI.Button>().onClick) != null)
            {
                goto label_10;
            }
            
            goto label_10;
        }
        public TzarGames.Endless.UI.MaskItemUI[] get_MaskIcons()
        {
            return (TzarGames.Endless.UI.MaskItemUI[])this.maskIcons;
        }
        public bool get_CanGetReward()
        {
            if(this.getRewardButton != null)
            {
                    return this.getRewardButton.interactable;
            }
            
            return this.getRewardButton.interactable;
        }
        public void set_CanGetReward(bool value)
        {
            value = value;
            this.getRewardButton.interactable = value;
        }
        public void NotifyGetRewardClicked()
        {
            if(this.OnGetRewardClicked == null)
            {
                    return;
            }
            
            this.OnGetRewardClicked.Invoke(obj:  this);
        }
        private void notifyMaskClicked(TzarGames.Endless.UI.MaskItemUI maskUI)
        {
            if(this.OnMaskClicked == null)
            {
                    return;
            }
            
            this.OnMaskClicked.Invoke(obj:  maskUI);
        }
    
    }

}
