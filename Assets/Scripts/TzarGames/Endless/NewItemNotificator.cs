using UnityEngine;

namespace TzarGames.Endless
{
    public class NewItemNotificator : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.ItemDatabaseData itemDatabase;
        private const string saveKey = "NetItemNotificator.Save";
        
        // Methods
        public NewItemNotificator()
        {
        
        }
        public void CheckForNewItems()
        {
            var val_33;
            UnityEngine.Object val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            val_33 = 1152921504721543168;
            val_34 = TzarGames.Endless.EndlessGameState.Instance;
            if(0 == val_34)
            {
                    return;
            }
            
            if(val_34.SelectedCharacter == null)
            {
                    return;
            }
            
            TzarGames.Endless.PlayerCharacter val_5 = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter;
            if(0 == val_5)
            {
                    return;
            }
            
            TzarGames.Endless.ICharacterInfo val_8 = val_34.SelectedCharacter;
            var val_33 = 0;
            val_33 = val_33 + 1;
            val_35 = val_8;
            val_36 = 0;
            if((val_8.HasString(id:  "NetItemNotificator.Save")) != false)
            {
                    string val_11 = val_8.GetString(id:  "NetItemNotificator.Save");
                val_36 = UnityEngine.JsonUtility.FromJson<EncodedData>(json:  0);
            }
            
            System.Collections.Generic.List<TzarGames.GameFramework.Item> val_13 = new System.Collections.Generic.List<TzarGames.GameFramework.Item>();
            val_34 = 1152921510747402064;
            val_37 = 0;
            goto label_19;
            label_36:
            val_37 = 1;
            label_19:
            if(val_37 >= Count)
            {
                goto label_21;
            }
            
            TzarGames.GameFramework.Item val_15 = Item[1];
            if(val_36 != null)
            {
                    if((val_12.Data.Contains(item:  val_15)) == true)
            {
                goto label_36;
            }
            
            }
            
            if((((val_5.PlayerTemplateInstance.CanWearItemType(t:  val_15.GetType())) == false) || (val_15.MinimumLevel == 0)) || (val_5.Level != val_15.MinimumLevel))
            {
                goto label_36;
            }
            
            Add(item:  val_15);
            goto label_36;
            label_21:
            if(Count < 1)
            {
                    return;
            }
            
            if(val_36 == null)
            {
                    object val_24 = null;
                val_38 = val_24;
                val_24 = new System.Object();
                typeof(NewItemNotificator.NotificatorSaveInfo).__il2cppRuntimeField_10 = new System.Collections.Generic.List<System.Int32>();
            }
            
            val_39 = 0;
            goto label_41;
            label_52:
            val_39 = 1;
            label_41:
            if(val_39 >= Count)
            {
                goto label_43;
            }
            
            TzarGames.GameFramework.Item val_27 = Item[1];
            if((Contains(item:  val_27)) == true)
            {
                goto label_52;
            }
            
            Add(item:  val_27);
            goto label_52;
            label_43:
            val_8.SetString(id:  "NetItemNotificator.Save", stringValue:  UnityEngine.JsonUtility.ToJson(obj:  0));
            typeof(NewItemNotificator.<CheckForNewItems>c__AnonStorey0).__il2cppRuntimeField_10 = ToArray();
            Event.EventFunction<TzarGames.Endless.IItemNotificatorHandler> val_32 = new Event.EventFunction<TzarGames.Endless.IItemNotificatorHandler>(object:  new System.Object(), method:  System.Void NewItemNotificator.<CheckForNewItems>c__AnonStorey0::<>m__0(TzarGames.Endless.IItemNotificatorHandler handler));
            TzarGames.Common.EventSystem.Event<TzarGames.TzarHero.ICharacterEvents>.Execute(functor:  0);
        }
    
    }

}
