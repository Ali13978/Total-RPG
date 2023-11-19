using UnityEngine;

namespace TzarGames.Endless.Quests
{
    [TzarGames.GameFramework.GroupNameAttribute]
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class CloseNewWorldPortalQuest : EndlessQuest
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Item teleportationItem;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset introMessage;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset introNewWorldMessage;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset completedMessage;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset returnMessage;
        [UnityEngine.SerializeField]
        private string[] newWorldSceneNames;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <QuestCompleted>k__BackingField;
        private const string portal_key = "NEWWORLD_PORTAL_QUEST_COMPLETED";
        private const string scene_key = "NEWWORLD_PORTAL_SCENE_NUMBER";
        
        // Properties
        public TzarGames.GameFramework.Item TeleportationItem { get; }
        public string[] NewWorldSceneNames { get; }
        public string IntroMessage { get; }
        public string IntroNewWorldMessage { get; }
        public string CompletedMessage { get; }
        public string ReturnMessage { get; }
        public bool QuestCompleted { get; set; }
        
        // Methods
        public CloseNewWorldPortalQuest()
        {
            mem[1152921510782041552] = 1000;
            mem[1152921510782041556] = 1056964608;
            mem[1152921510782041560] = 1000;
            val_1 = new TzarGames.Common.CommonAsset();
        }
        public TzarGames.GameFramework.Item get_TeleportationItem()
        {
            return (TzarGames.GameFramework.Item)this.teleportationItem;
        }
        public string[] get_NewWorldSceneNames()
        {
            return (System.String[])this.newWorldSceneNames;
        }
        public string get_IntroMessage()
        {
            return TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
        }
        public string get_IntroNewWorldMessage()
        {
            return TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
        }
        public string get_CompletedMessage()
        {
            return TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
        }
        public string get_ReturnMessage()
        {
            return TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
        }
        public bool get_QuestCompleted()
        {
            return (bool)this.<QuestCompleted>k__BackingField;
        }
        public void set_QuestCompleted(bool value)
        {
            this.<QuestCompleted>k__BackingField = value;
        }
        public override bool CanBeCompleted()
        {
            if(X8 == 0)
            {
                    return false;
            }
            
            return (bool)((this.<QuestCompleted>k__BackingField) == true) ? 1 : 0;
        }
        public static void SetSceneNumber(TzarGames.Common.SerializableData data, int num)
        {
            num.SetInt(id:  "NEWWORLD_PORTAL_SCENE_NUMBER", val:  W2);
        }
        public static int GetSceneNumber(TzarGames.Common.SerializableData data)
        {
            if(X1 != 0)
            {
                    return X1.GetInt(id:  "NEWWORLD_PORTAL_SCENE_NUMBER");
            }
            
            return X1.GetInt(id:  "NEWWORLD_PORTAL_SCENE_NUMBER");
        }
        public override TzarGames.Common.SerializableData SerializeInstance()
        {
            TzarGames.Common.SerializableData val_1 = this.SerializeInstance();
            val_1.SetString(id:  "NEWWORLD_PORTAL_QUEST_COMPLETED", stringValue:  this.<QuestCompleted>k__BackingField);
            return val_1;
        }
        public override void Deserialize(TzarGames.Common.SerializableData data)
        {
            this.Deserialize(data:  data);
            string val_1 = data.GetString(id:  "NEWWORLD_PORTAL_QUEST_COMPLETED");
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            this.<QuestCompleted>k__BackingField = System.Boolean.Parse(value:  0);
        }
        public override bool ConflictsWith(TzarGames.Endless.Quests.EndlessQuest quest)
        {
            return false;
        }
    
    }

}
