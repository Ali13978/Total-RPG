using UnityEngine;

namespace TzarGames.Endless
{
    public class EndlessLobbyGameManager : EndlessGameManager
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Item hammerItemTemplate;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onStartLobbyMultiplayer;
        
        // Methods
        public EndlessLobbyGameManager()
        {
        
        }
        [TzarGames.Common.ConsoleCommand]
        public void GotoStage(uint stageNumber)
        {
            this.StopPlayerMovement();
            TzarGames.Endless.EndlessGameState.Instance.GotoStage(stage:  stageNumber, toLobby:  false);
        }
        [TzarGames.Common.ConsoleCommand]
        public void GotoLobbyStage(uint stageNumber)
        {
            this.StopPlayerMovement();
            TzarGames.Endless.EndlessGameState.Instance.GotoStage(stage:  stageNumber, toLobby:  true);
        }
        public void GotoMaxStage()
        {
            var val_4;
            TzarGames.Endless.ICharacterInfo val_2 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = val_2;
            this.GotoStage(stageNumber:  val_2);
        }
        public void GotoLowerStage()
        {
            var val_5;
            TzarGames.Endless.ICharacterInfo val_2 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = val_2;
            this.GotoStage(stageNumber:  val_2 - 1);
        }
        protected override void PostSpawnPlayerObject(TzarGames.GameFramework.Player player)
        {
            this.PostSpawnPlayerObject(player:  player);
            0.IgnoreDamage.AddModificator(owner:  this, value:  true, booleanOperator:  1);
            TzarGames.GameFramework.dlgTzarDestroy val_2 = new TzarGames.GameFramework.dlgTzarDestroy(object:  this, method:  System.Void TzarGames.Endless.EndlessLobbyGameManager::PlayerCharacter_OnComponentDestroy(TzarGames.GameFramework.TzarBehaviour behaviour));
            if((1 & 1) != 0)
            {
                    0.add_OnComponentDestroy(value:  val_2);
                0.CanBeAttacked = false;
            }
            else
            {
                    0.add_OnComponentDestroy(value:  val_2);
                0.CanBeAttacked = false;
            }
            
            0.Authoritative = true;
            if(player.itsMe == false)
            {
                    return;
            }
            
            if(TzarGames.Endless.AppSettings.AllowMultiplayerInLobby == false)
            {
                    return;
            }
            
            if(TzarGames.Common.Privacy.CanCollectData == false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  0);
            this.onStartLobbyMultiplayer.Invoke();
        }
        private void PlayerCharacter_OnComponentDestroy(TzarGames.GameFramework.TzarBehaviour behaviour)
        {
            TzarGames.GameFramework.dlgTzarDestroy val_4;
            var val_5;
            TzarGames.GameFramework.dlgTzarDestroy val_1 = null;
            val_4 = val_1;
            val_1 = new TzarGames.GameFramework.dlgTzarDestroy(object:  this, method:  System.Void TzarGames.Endless.EndlessLobbyGameManager::PlayerCharacter_OnComponentDestroy(TzarGames.GameFramework.TzarBehaviour behaviour));
            if(behaviour != null)
            {
                    behaviour.remove_OnComponentDestroy(value:  val_4);
                val_4 = 1152921504871968768;
                val_5 = null;
                val_5 = null;
                var val_2 = (((TzarGames.GameFramework.TzarBehaviour.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.PlayerCharacter.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_5) ? behaviour : 0;
            }
            else
            {
                    behaviour.remove_OnComponentDestroy(value:  val_4);
            }
            
            0.IgnoreDamage.RemoveModificator(owner:  this);
        }
        public TzarGames.Endless.PurchaseStatus CanBuyItem(TzarGames.GameFramework.Item item)
        {
            var val_15;
            float val_16;
            var val_17;
            if(0 == TzarGames.Endless.EndlessGameState.Instance)
            {
                    val_15 = 1;
                return (TzarGames.Endless.PurchaseStatus)((TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter.TemplateInstance.Inventory.DefaultBag.IsThisItemCanBeAdded(item:  item)) != true) ? 0 : 5;
            }
            
            val_16 = item.Cost;
            if(val_16 > (float)(double)TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter.Gold)
            {
                    val_15 = 3;
                return (TzarGames.Endless.PurchaseStatus)((TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter.TemplateInstance.Inventory.DefaultBag.IsThisItemCanBeAdded(item:  item)) != true) ? 0 : 5;
            }
            
            val_16 = item.PremiumCost;
            TzarGames.Endless.ICharacterInfo val_7 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_17 = val_7;
            if(val_16 <= (float)(double)val_7)
            {
                    return (TzarGames.Endless.PurchaseStatus)((TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter.TemplateInstance.Inventory.DefaultBag.IsThisItemCanBeAdded(item:  item)) != true) ? 0 : 5;
            }
            
            val_15 = 2;
            return (TzarGames.Endless.PurchaseStatus)((TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter.TemplateInstance.Inventory.DefaultBag.IsThisItemCanBeAdded(item:  item)) != true) ? 0 : 5;
        }
        public TzarGames.Endless.PurchaseStatus EnchanceItem(TzarGames.GameFramework.ItemInstance item, bool useRubyDiscount)
        {
            bool val_3 = useRubyDiscount;
            TzarGames.Endless.PurchaseStatus val_4 = TzarGames.Endless.ItemEnchancement.EnchanceItemForPlayer(itemInstance:  null = null, playerTemplate:  item, useRuby:  TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter.PlayerTemplateInstance);
            if(val_4 != 0)
            {
                    return val_4;
            }
            
            val_4.saveHeroData();
            return val_4;
        }
        public bool CanSellItemInstance(TzarGames.GameFramework.ItemInstance itemInstance)
        {
            if(0 == TzarGames.Endless.EndlessGameState.Instance)
            {
                    return false;
            }
            
            TzarGames.GameFramework.Items.Attributes.ItemSellableAttribute val_5 = itemInstance.GetTemplateInstance().GetAttributeOfType<TzarGames.GameFramework.Items.Attributes.ItemSellableAttribute>();
            if(0 != val_5)
            {
                    if(val_5.IsSellable == false)
            {
                    return false;
            }
            
            }
            
            TzarGames.GameFramework.InventoryBag val_11 = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter.TemplateInstance.Inventory.DefaultBag;
            if(val_11 != null)
            {
                    return val_11.IsItemInstanceCanBeRemoved(itemInstance:  itemInstance);
            }
            
            return val_11.IsItemInstanceCanBeRemoved(itemInstance:  itemInstance);
        }
        public int GetItemSellCost(TzarGames.GameFramework.Item item)
        {
            float val_2;
            if(item != null)
            {
                    val_2 = item.Cost;
            }
            else
            {
                    val_2 = 0f;
            }
            
            float val_2 = (float)TzarGames.Endless.GoldExchange.GetGoldForOneRuby();
            val_2 = item.PremiumCost * val_2;
            val_2 = val_2 + val_2;
            val_2 = val_2 / 3f;
            return (int)(int)val_2;
        }
        public void SellItemInstance(TzarGames.GameFramework.ItemInstance itemInstance)
        {
            var val_12;
            if((this.CanSellItemInstance(itemInstance:  itemInstance)) == false)
            {
                    return;
            }
            
            TzarGames.TzarHero.TH_CharacterTemplate val_3 = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter.TemplateInstance;
            val_3.Inventory.DefaultBag.RemoveItem(itemInstance:  itemInstance);
            if((val_3.Inventory.IsItemInstanceStoredInAnyBag(instance:  itemInstance)) != false)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            TzarGames.GameFramework.Item val_8 = itemInstance.GetOriginalTemplate();
            string val_10 = System.String.Format(format:  0, arg0:  "Selling item {0} with cost {1}", arg1:  val_8.itemName);
            UnityEngine.Debug.Log(message:  0);
            val_12 = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter;
            val_12.AddGold(goldAdd:  val_8.GetItemSellCost(item:  val_8));
            this.SaveGameWithPlayerData();
        }
        public void SellConsumableItem(TzarGames.GameFramework.Item item, int count)
        {
            int val_12;
            int val_13;
            val_12 = count;
            if(item.ConsumptionType != 0)
            {
                    return;
            }
            
            TzarGames.GameFramework.InventoryBag val_4 = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter.TemplateInstance.Inventory.DefaultBag;
            val_13 = item;
            int val_5 = val_4.GetConsumableItemCount(itemId:  val_13);
            if(val_5 == 0)
            {
                    return;
            }
            
            val_13 = val_5 - val_12;
            if()
            {
                    return;
            }
            
            bool val_6 = val_4.RemoveConsumableItem(item:  item, count:  val_12);
            int val_7 = val_4.GetConsumableItemCount(itemId:  item);
            if(val_7 == val_13)
            {
                    val_12 = val_7.GetItemSellCost(item:  item);
                string val_9 = System.String.Format(format:  0, arg0:  "Selling item {0} with cost {1}", arg1:  item.itemName);
                UnityEngine.Debug.Log(message:  0);
                TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter.AddGold(goldAdd:  val_12);
                this.SaveGameWithPlayerData();
                return;
            }
            
            string val_11 = 0 + "Sell failed, failed to remove item ";
            UnityEngine.Debug.LogError(message:  0);
        }
        public TzarGames.Endless.PurchaseStatus BuyItem(TzarGames.GameFramework.Item item)
        {
            TzarGames.Endless.PlayerCharacter val_17;
            var val_18;
            string val_19;
            float val_20;
            System.Object[] val_21;
            var val_22;
            string val_23;
            var val_24;
            TzarGames.GameFramework.ItemInstance val_3 = 0;
            TzarGames.Endless.PlayerCharacter val_1 = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter;
            val_17 = val_1;
            TzarGames.Endless.PurchaseStatus val_2 = val_1.CanBuyItem(item:  item);
            if(val_2 != 0)
            {
                    return (TzarGames.Endless.PurchaseStatus)val_18;
            }
            
            val_19 = 0;
            if((val_2.addItemToPlayer(item:  item, instanceId:  val_19, player:  val_17, instance: out  val_3)) == false)
            {
                goto label_2;
            }
            
            val_20 = item.Cost;
            if(val_20 > 0f)
            {
                    val_19 = 0;
                val_17.AddGold(goldAdd:  -(int)val_20);
            }
            
            if(item.PremiumCost <= 0f)
            {
                goto label_7;
            }
            
            TzarGames.Endless.ICharacterInfo val_6 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            val_20 = item.PremiumCost;
            val_21 = -(int)val_20;
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_19 = 5;
            val_22 = val_6;
            goto label_13;
            label_2:
            val_18 = 1;
            return (TzarGames.Endless.PurchaseStatus)val_18;
            label_13:
            label_7:
            val_6.saveHeroData();
            if(val_3 != 0)
            {
                    val_23 = val_3.GetInstanceID();
            }
            else
            {
                    val_24 = null;
                val_24 = null;
                val_23 = System.String.Empty;
            }
            
            if(this.OnServer == false)
            {
                goto label_19;
            }
            
            TzarGames.GameFramework.Player val_10 = val_17.PlayerOwner;
            val_21 = 0;
            goto label_22;
            label_41:
            mem2[0] = ???;
            this.RPC(methodDelegate:  X25, target:  X26, parameters:  X27);
            val_21 = 1;
            label_22:
            if(val_21 >= val_10.NeighbourPlayers.Count)
            {
                goto label_42;
            }
            
            TzarGames.GameFramework.Player val_12 = val_10.NeighbourPlayers.Item[1];
            TzarGames.GameFramework.RPCall<System.Int32, System.String, TzarGames.GameFramework.NetworkPlayer> val_13 = new TzarGames.GameFramework.RPCall<System.Int32, System.String, TzarGames.GameFramework.NetworkPlayer>(object:  this, method:  System.Void TzarGames.Endless.EndlessLobbyGameManager::client_buy_item(int itemId, string instanceId, TzarGames.GameFramework.NetworkPlayer netPlayer));
            typeof(System.Object[]).__il2cppRuntimeField_20 = item;
            typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_23;
            TzarGames.GameFramework.Player val_14 = val_17.PlayerOwner;
            if((val_14.NetworkPlayer == null) || (val_14.NetworkPlayer != null))
            {
                goto label_41;
            }
            
            goto label_41;
            label_19:
            if(this.OnClient != false)
            {
                    TzarGames.GameFramework.RPCall<System.Int32, System.String, TzarGames.GameFramework.INetworkMessageInfo> val_16 = null;
                val_17 = val_16;
                val_16 = new TzarGames.GameFramework.RPCall<System.Int32, System.String, TzarGames.GameFramework.INetworkMessageInfo>(object:  this, method:  System.Void TzarGames.Endless.EndlessLobbyGameManager::server_buy_item(int itemId, string instanceId, TzarGames.GameFramework.INetworkMessageInfo messageInfo));
                val_21 = null;
                typeof(System.Object[]).__il2cppRuntimeField_20 = item;
                typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
                typeof(System.Object[]).__il2cppRuntimeField_28 = val_23;
                this.RPC(methodDelegate:  val_17, rpcMode:  5, parameters:  val_21);
            }
            
            label_42:
            val_18 = 0;
            return (TzarGames.Endless.PurchaseStatus)val_18;
        }
        public void AddUniqueItemToLocalPlayer(TzarGames.GameFramework.Item item)
        {
            TzarGames.GameFramework.InventoryBag val_4 = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter.TemplateInstance.Inventory.DefaultBag;
            if((val_4.ContainsNonConsumableWithId(id:  item)) == true)
            {
                    return;
            }
            
            val_4.AddNonconsumableItem(itemInstance:  item.CreateItemInstance());
            if(TzarGames.Endless.EndlessGameState.Instance.IsItSafeStateToSaveGame() == false)
            {
                    return;
            }
            
            this.SaveGameWithPlayerData();
        }
        [TzarRPC]
        protected void server_buy_item(int itemId, string instanceId, TzarGames.GameFramework.INetworkMessageInfo messageInfo)
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            if(messageInfo == null)
            {
                    return;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_11 = messageInfo;
            if(messageInfo == null)
            {
                    return;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_12 = messageInfo;
            val_10 = messageInfo;
            if(((val_10 & 1) & 1) != 0)
            {
                    return;
            }
            
            val_10 = this.Net;
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_13 = messageInfo;
            if((val_10.GetPlayerByNetPlayer(netPlayer:  messageInfo)) == null)
            {
                    return;
            }
            
            val_10 = 0;
            goto label_19;
            label_34:
            mem2[0] = ???;
            this.RPC(methodDelegate:  X25, target:  X26, parameters:  X27);
            val_10 = 1;
            label_19:
            if(val_10 >= val_6.NeighbourPlayers.Count)
            {
                    return;
            }
            
            TzarGames.GameFramework.Player val_8 = val_6.NeighbourPlayers.Item[1];
            TzarGames.GameFramework.RPCall<System.Int32, System.String, TzarGames.GameFramework.NetworkPlayer> val_9 = new TzarGames.GameFramework.RPCall<System.Int32, System.String, TzarGames.GameFramework.NetworkPlayer>(object:  this, method:  System.Void TzarGames.Endless.EndlessLobbyGameManager::client_buy_item(int itemId, string instanceId, TzarGames.GameFramework.NetworkPlayer netPlayer));
            typeof(System.Object[]).__il2cppRuntimeField_20 = itemId;
            typeof(System.Object[]).__il2cppRuntimeField_24 = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_28 = instanceId;
            if((val_6.NetworkPlayer == null) || (val_6.NetworkPlayer != null))
            {
                goto label_34;
            }
            
            goto label_34;
        }
        [TzarRPC]
        protected void client_buy_item(int itemId, string instanceId, TzarGames.GameFramework.NetworkPlayer netPlayer)
        {
            var val_9;
            var val_10;
            var val_11;
            val_10 = this;
            if(netPlayer == null)
            {
                    return;
            }
            
            if(((netPlayer & 1) & 1) != 0)
            {
                    return;
            }
            
            val_9 = this.Net;
            if((val_9.GetPlayerByNetPlayer(netPlayer:  netPlayer)) == null)
            {
                    return;
            }
            
            val_11 = 0;
            val_10 = this.ItemDatabase;
            TzarGames.GameFramework.Item val_6 = val_10.GetItemByID(id:  itemId);
            bool val_8 = val_6.addItemToPlayer(item:  val_6, instanceId:  instanceId, player:  null, instance: out  0);
        }
        private bool addItemToPlayer(TzarGames.GameFramework.Item item, string instanceId, TzarGames.Endless.PlayerCharacter player, out TzarGames.GameFramework.ItemInstance instance)
        {
            var val_10;
            TzarGames.GameFramework.ItemInstance val_11;
            TzarGames.GameFramework.ItemInstance val_12;
            TzarGames.GameFramework.ItemConsumptionType val_13;
            var val_14;
            val_11 = 1152921510638174016;
            val_12 = item;
            if(val_12 == null)
            {
                goto label_1;
            }
            
            val_13 = item.ConsumptionType;
            if(val_13 != 1)
            {
                goto label_2;
            }
            
            goto label_3;
            label_1:
            val_10 = 31514624;
            if(val_10 != 1)
            {
                goto label_4;
            }
            
            label_3:
            instance = val_12.CreateItemInstance();
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    val_12 = instance;
                val_12.SetInstanceID(newId:  instanceId);
            }
            
            val_11 = instance;
            player.TemplateInstance.Inventory.DefaultBag.AddNonconsumableItem(itemInstance:  val_11);
            val_14 = 1;
            return (bool)val_14;
            label_4:
            val_13 = 31514624;
            label_2:
            if(val_13 != 0)
            {
                    UnityEngine.Debug.LogError(message:  0);
                val_14 = 0;
            }
            else
            {
                    val_14 = 1;
                player.TemplateInstance.Inventory.DefaultBag.AddConsumableItem(item:  val_12, count:  1);
            }
            
            instance = 0;
            return (bool)val_14;
        }
        private void saveHeroData()
        {
            TzarGames.Endless.EndlessGameManager.SetHeroDataToGameState();
            TzarGames.Endless.EndlessGameManager.GameState.SaveGame();
        }
    
    }

}
