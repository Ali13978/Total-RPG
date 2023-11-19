using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class TopPlayerWidgetUI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset mostExperiencedLabel;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset topLevelLabel;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset topStageLabel;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset friendsLabel;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.TopPlayerElementUI elementPrefab;
        [UnityEngine.SerializeField]
        private int elementPoolCapacity;
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform elementContainer;
        [UnityEngine.SerializeField]
        private float changeInterval;
        [UnityEngine.SerializeField]
        private float startDelay;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject backgroundImage;
        private float lastChangeTime;
        private int currentIndex;
        private System.Collections.Generic.List<TzarGames.Endless.UI.TopPlayerElementUI> elementPool;
        private System.Collections.Generic.List<TzarGames.Endless.UI.TopPlayerElementUI> elements;
        private System.Collections.Generic.Dictionary<TzarGames.Endless.UI.TopPlayerElementUI, TzarGames.Endless.UI.TopPlayerWidgetUI.labelDelegate> elementUpdateMethods;
        private UnityEngine.Coroutine updateRoutine;
        
        // Methods
        public TopPlayerWidgetUI()
        {
            this.changeInterval = 5f;
            this.startDelay = 2f;
            this.elementPoolCapacity = 3;
            this.elementPool = new System.Collections.Generic.List<TzarGames.Endless.UI.TopPlayerElementUI>();
            this.elements = new System.Collections.Generic.List<TzarGames.Endless.UI.TopPlayerElementUI>();
            this.elementUpdateMethods = new System.Collections.Generic.Dictionary<TzarGames.Endless.UI.TopPlayerElementUI, labelDelegate>();
        }
        public void ResetMessages()
        {
            TzarGames.Common.UI.UIBase val_5;
            var val_6;
            var val_7;
            val_5 = this;
            List.Enumerator<T> val_1 = this.elements.GetEnumerator();
            label_5:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            0.InitializationCallback.GetObjectData(info:  0, context:  new System.Runtime.Serialization.StreamingContext() {state = public System.Void System.MulticastDelegate::GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)});
            goto label_5;
            label_2:
            val_6 = 0;
            val_7 = 1;
            0.Dispose();
            if(this.elements.Count <= this.currentIndex)
            {
                    return;
            }
            
            TzarGames.Endless.UI.TopPlayerElementUI val_4 = this.elements.Item[this.currentIndex];
            val_5 = val_4.ui;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator Start()
        {
            typeof(TopPlayerWidgetUI.<Start>c__Iterator0).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void OnDestroy()
        {
            if(0 == this.topStageLabel)
            {
                    return;
            }
            
            this.topStageLabel.remove_OnUpdated(value:  new System.Action<TzarGames.Common.LocalizedStringAsset>(object:  this, method:  System.Void TzarGames.Endless.UI.TopPlayerWidgetUI::onLabelUpdated(TzarGames.Common.LocalizedStringAsset obj)));
        }
        private void onLabelUpdated(TzarGames.Common.LocalizedStringAsset obj)
        {
            if(this.updateRoutine != null)
            {
                    this.StopCoroutine(routine:  this.updateRoutine);
                this.updateRoutine = 0;
            }
            
            this.updateRoutine = this.StartCoroutine(routine:  this.localizationUpdate());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator localizationUpdate()
        {
            typeof(TopPlayerWidgetUI.<localizationUpdate>c__Iterator1).__il2cppRuntimeField_28 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private string getMostExperiencedFriendsLabel()
        {
            string val_2 = TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
            return 0 + TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0)(TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
        }
        private string getTopLevelFriendsLabel()
        {
            string val_2 = TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
            return 0 + TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0)(TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
        }
        private string getTopStageFriendsLabel()
        {
            string val_2 = TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
            return 0 + TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0)(TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
        }
        private string getMostExperiencedLabel()
        {
            return TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
        }
        private string getTopLevelLabel()
        {
            return TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
        }
        private string getTopStageLabel()
        {
            return TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
        }
        private TzarGames.Endless.UI.TopPlayerElementUI getOrCreateElement()
        {
            if(this.elementPool.Count < 1)
            {
                    return UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
            }
            
            TzarGames.Endless.UI.TopPlayerElementUI val_2 = this.elementPool.Item[0];
            this.elementPool.RemoveAt(index:  0);
            val_2.gameObject.SetActive(value:  true);
            return val_2;
        }
        private TzarGames.Endless.UI.TopPlayerElementUI createElement(TzarGames.Endless.UI.TopPlayerWidgetUI.labelDelegate labelCreateMethod, UnityEngine.SocialPlatforms.IUserProfile profile)
        {
            var val_9;
            var val_10;
            var val_11;
            TzarGames.Endless.UI.TopPlayerElementUI val_1 = this.getOrCreateElement();
            val_1.transform.SetParent(parent:  this.elementContainer, worldPositionStays:  false);
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_9 = profile;
            if(0 != profile)
            {
                    var val_10 = 0;
                val_10 = val_10 + 1;
                val_10 = profile;
                val_1.icon.texture = profile;
            }
            
            val_1.label.text = labelCreateMethod.Invoke();
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_11 = profile;
            val_1.playerName.text = profile;
            if(this.elements.Count != 0)
            {
                
            }
            
            this.elements.Add(item:  val_1);
            this.elementUpdateMethods.Add(key:  val_1, value:  labelCreateMethod);
            return val_1;
        }
        public void ShowDefaultLeaderboardUI()
        {
            if(0 == TzarGames.Endless.SocialSystem.Instance)
            {
                    return;
            }
            
            TzarGames.Endless.SocialSystem.Instance.ShowDefaultLeaderboardUI();
        }
        private void Update()
        {
            var val_13;
            UnityEngine.GameObject val_14;
            UnityEngine.GameObject val_15;
            var val_16;
            int val_17;
            var val_18;
            val_13 = this;
            val_14 = this.backgroundImage;
            bool val_2 = val_14.activeSelf;
            if(this.elements.Count < 1)
            {
                goto label_3;
            }
            
            if(val_2 == true)
            {
                goto label_7;
            }
            
            val_15 = this.backgroundImage;
            val_16 = 1;
            goto label_6;
            label_3:
            if(val_2 == false)
            {
                goto label_7;
            }
            
            val_15 = this.backgroundImage;
            val_16 = 0;
            label_6:
            val_15.SetActive(value:  false);
            label_7:
            if(this.elements.Count < 2)
            {
                    return;
            }
            
            float val_5 = UnityEngine.Time.time;
            val_5 = val_5 - this.lastChangeTime;
            if(val_5 < this.changeInterval)
            {
                    return;
            }
            
            this.lastChangeTime = UnityEngine.Time.time;
            int val_7 = this.currentIndex + 1;
            this.currentIndex = val_7;
            if(val_7 < this.elements.Count)
            {
                    val_17 = this.currentIndex;
            }
            else
            {
                    val_17 = 0;
                this.currentIndex = 0;
            }
            
            TzarGames.Endless.UI.TopPlayerElementUI val_9 = this.elements.Item[0];
            List.Enumerator<T> val_10 = this.elements.GetEnumerator();
            val_14 = 1152921511014151072;
            label_26:
            if((0 & 1) == 0)
            {
                goto label_17;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_11 = 0.InitializationCallback;
            if(0 != val_11)
            {
                goto label_20;
            }
            
            val_11.GetObjectData(info:  1, context:  new System.Runtime.Serialization.StreamingContext() {state = public System.Void System.MulticastDelegate::GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)});
            goto label_26;
            label_20:
            val_11.GetObjectData(info:  0, context:  new System.Runtime.Serialization.StreamingContext() {state = public System.Void System.MulticastDelegate::GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)});
            goto label_26;
            label_17:
            val_13 = 0;
            val_18 = 1;
            0.Dispose();
            if((val_18 & 1) != 0)
            {
                    return;
            }
            
            if(val_13 == 0)
            {
                    return;
            }
        
        }
    
    }

}
