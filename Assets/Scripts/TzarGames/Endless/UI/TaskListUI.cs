using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class TaskListUI : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.TaskItemUI itemPrefab;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject startButton;
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform container;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI description;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI noTasksText;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.Endless.Quests.QuestProviderBase <QuestProvider>k__BackingField;
        private TzarGames.Endless.UI.TaskItemUI activeTask;
        private System.Collections.Generic.Dictionary<TzarGames.Endless.UI.TaskItemUI, TzarGames.Endless.Quests.EndlessQuest> taskMap;
        [UnityEngine.SerializeField]
        private TzarGames.Common.Events.StringEvent onTaskStarted;
        
        // Properties
        public TzarGames.Endless.Quests.QuestProviderBase QuestProvider { get; set; }
        
        // Methods
        public TaskListUI()
        {
            this.taskMap = new System.Collections.Generic.Dictionary<TzarGames.Endless.UI.TaskItemUI, TzarGames.Endless.Quests.EndlessQuest>();
        }
        public TzarGames.Endless.Quests.QuestProviderBase get_QuestProvider()
        {
            return (TzarGames.Endless.Quests.QuestProviderBase)this.<QuestProvider>k__BackingField;
        }
        public void set_QuestProvider(TzarGames.Endless.Quests.QuestProviderBase value)
        {
            this.<QuestProvider>k__BackingField = value;
        }
        public override void NotifyShown()
        {
            var val_17;
            string val_18;
            var val_19;
            var val_20;
            this.NotifyShown();
            if(0 == TzarGames.Endless.EndlessGameState.Instance)
            {
                    return;
            }
            
            if(0 == (this.<QuestProvider>k__BackingField))
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            TzarGames.Common.Utils.DestroyAllChilds(transform:  0);
            this.taskMap.Clear();
            this.activeTask = 0;
            val_17 = 0;
            goto label_11;
            label_28:
            val_17 = 1;
            label_11:
            if(val_17 >= val_5.Length)
            {
                goto label_13;
            }
            
            TzarGames.Endless.Quests.EndlessQuest val_17 = this.<QuestProvider>k__BackingField.AvailableQuests[1];
            Unitycoding.UIWidgets.RadialMenuItem val_6 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
            X24.text = val_17.GetLocalizedName();
            val_6.transform.SetParent(parent:  this.container);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
            val_6.transform.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            System.Action<TzarGames.Endless.UI.TaskItemUI> val_11 = new System.Action<TzarGames.Endless.UI.TaskItemUI>(object:  this, method:  System.Void TzarGames.Endless.UI.TaskListUI::NewItemOnOnClicked(TzarGames.Endless.UI.TaskItemUI taskItemUi));
            if(val_6 != null)
            {
                    val_6.add_OnClicked(value:  val_11);
            }
            else
            {
                    val_6.add_OnClicked(value:  val_11);
            }
            
            val_6.Activated = false;
            this.taskMap.Add(key:  val_6, value:  val_17);
            if(0 != this.activeTask)
            {
                goto label_28;
            }
            
            this.activeTask = val_6;
            goto label_28;
            label_13:
            if(0 != this.activeTask)
            {
                    this.activeTask.Activated = true;
                val_18 = this.taskMap.Item[this.activeTask];
                this.description.text = val_18;
                this.startButton.SetActive(value:  true);
            }
            else
            {
                    this.startButton.SetActive(value:  false);
                val_19 = null;
                val_19 = null;
                val_18 = System.String.Empty;
                this.description.text = val_18;
            }
            
            if(this.taskMap.Count >= 1)
            {
                    val_20 = 0;
            }
            else
            {
                    val_20 = 1;
            }
            
            this.noTasksText.gameObject.SetActive(value:  true);
        }
        private void NewItemOnOnClicked(TzarGames.Endless.UI.TaskItemUI taskItemUi)
        {
            var val_2;
            string val_11;
            this.activeTask = taskItemUi;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.taskMap.GetEnumerator();
            label_9:
            if((0 & 1) == 0)
            {
                goto label_19;
            }
            
            UnityEngine.Playables.PlayableHandle val_4 = val_2.GetHandle();
            if(0 != val_4.m_Handle.InitializationCallback)
            {
                goto label_5;
            }
            
            val_4.m_Handle.InitializationCallback.Activated = true;
            goto label_9;
            label_5:
            val_4.m_Handle.InitializationCallback.Activated = false;
            goto label_9;
            label_19:
            val_2.Dispose();
            if(0 == this.activeTask)
            {
                    return;
            }
            
            val_11 = this.taskMap.Item[this.activeTask];
            this.description.text = val_11;
            this.startButton.SetActive(value:  true);
        }
        public void OnStartTaskClicked()
        {
            if(0 == this.activeTask)
            {
                    return;
            }
            
            UnityEngine.UI.Extensions.BoundTooltipItem val_3 = UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>();
            if(0 == val_3)
            {
                    return;
            }
            
            TzarGames.Endless.Quests.EndlessQuest val_5 = this.taskMap.Item[this.activeTask];
            val_3.StartQuest(quest:  val_5);
            this.onTaskStarted.Invoke(arg0:  val_5.Name);
        }
    
    }

}
