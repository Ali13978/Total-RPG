using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class QuestRewardUI : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset questSuccessText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI successText;
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform goldContainer;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI gold;
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform rubyContainer;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI ruby;
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform xpContainer;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI xp;
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform itemContainer;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.RewardItemUI itemPrefab;
        [UnityEngine.SerializeField]
        private TzarGames.Common.Events.StringEvent onRewardShown;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.Endless.Quests.IEndlessQuestReward <Reward>k__BackingField;
        
        // Properties
        public TzarGames.Endless.Quests.IEndlessQuestReward Reward { get; set; }
        
        // Methods
        public QuestRewardUI()
        {
        
        }
        public TzarGames.Endless.Quests.IEndlessQuestReward get_Reward()
        {
            return (TzarGames.Endless.Quests.IEndlessQuestReward)this.<Reward>k__BackingField;
        }
        public void set_Reward(TzarGames.Endless.Quests.IEndlessQuestReward value)
        {
            this.<Reward>k__BackingField = value;
        }
        public override void NotifyShown()
        {
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            var val_47;
            var val_48;
            var val_49;
            this.NotifyShown();
            var val_32 = 0;
            val_32 = val_32 + 1;
            val_32 = this.<Reward>k__BackingField;
            string val_3 = this.<Reward>k__BackingField.GetLocalizedName();
            this.successText.text = System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
            var val_33 = 0;
            val_33 = val_33 + 1;
            val_33 = this.<Reward>k__BackingField;
            if((this.<Reward>k__BackingField) < 1)
            {
                goto label_15;
            }
            
            var val_34 = 0;
            val_34 = val_34 + 1;
            val_34 = this.<Reward>k__BackingField;
            goto label_20;
            label_15:
            val_35 = this.goldContainer.gameObject;
            val_36 = 0;
            goto label_23;
            label_20:
            this.gold.text = this.<Reward>k__BackingField;
            val_35 = this.goldContainer.gameObject;
            val_36 = 1;
            label_23:
            val_35.SetActive(value:  true);
            var val_35 = 0;
            val_35 = val_35 + 1;
            val_37 = this.<Reward>k__BackingField;
            if((this.<Reward>k__BackingField) < 1)
            {
                goto label_32;
            }
            
            var val_36 = 0;
            val_36 = val_36 + 1;
            val_38 = this.<Reward>k__BackingField;
            goto label_37;
            label_32:
            val_39 = this.rubyContainer.gameObject;
            val_40 = 0;
            goto label_40;
            label_37:
            this.ruby.text = this.<Reward>k__BackingField;
            val_39 = this.rubyContainer.gameObject;
            val_40 = 1;
            label_40:
            val_39.SetActive(value:  true);
            var val_37 = 0;
            val_37 = val_37 + 1;
            val_41 = this.<Reward>k__BackingField;
            if((this.<Reward>k__BackingField) < 1)
            {
                goto label_49;
            }
            
            var val_38 = 0;
            val_38 = val_38 + 1;
            val_42 = this.<Reward>k__BackingField;
            goto label_54;
            label_49:
            val_43 = this;
            val_44 = this.xpContainer.gameObject;
            val_45 = 0;
            goto label_57;
            label_54:
            this.xp.text = this.<Reward>k__BackingField;
            val_43 = this;
            val_44 = this.xpContainer.gameObject;
            val_45 = 1;
            label_57:
            val_44.SetActive(value:  true);
            val_46 = 0;
            goto label_61;
            label_77:
            val_46 = 1;
            label_61:
            if(val_46 >= this.itemContainer.childCount)
            {
                goto label_63;
            }
            
            UnityEngine.Transform val_18 = this.itemContainer.GetChild(index:  1);
            if(((0 == val_18) || (0 == val_18)) || (0 == val_18))
            {
                goto label_77;
            }
            
            UnityEngine.GameObject val_25 = val_18.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
            goto label_77;
            label_63:
            var val_39 = 0;
            val_39 = val_39 + 1;
            val_47 = this.<Reward>k__BackingField;
            if((this.<Reward>k__BackingField) == null)
            {
                    if(7254272 < 1)
            {
                goto label_87;
            }
            
            }
            
            val_48 = 0;
            goto label_85;
            label_98:
            val_3.SetParent(parent:  this.itemContainer, worldPositionStays:  false);
            val_48 = 1;
            label_85:
            if(val_48 >= 7254272)
            {
                goto label_87;
            }
            
            TzarGames.Endless.Quests.IEndlessQuestReward val_27 = (this.<Reward>k__BackingField) + 8;
            X24.text = val_3;
            val_3.sprite = val_3;
            if((UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0).transform) != null)
            {
                goto label_98;
            }
            
            goto label_98;
            label_87:
            var val_40 = 0;
            val_40 = val_40 + 1;
            val_49 = this.<Reward>k__BackingField;
            this.onRewardShown.Invoke(arg0:  this.<Reward>k__BackingField.Name);
        }
    
    }

}
