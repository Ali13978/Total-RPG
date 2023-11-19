using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class FloatingLabelScreenUI : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private string inactiveContainerName;
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform container;
        [UnityEngine.SerializeField]
        private float showTime;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.FloatingTextLabelUI criticalLabelPrefab;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.FloatingTextLabelUI hitLabelPrefab;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.FloatingTextLabelUI itemTakeLabelPrefab;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.FloatingTextLabelUI blockLabelPrefab;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.FloatingTextLabelUI playerLabelPrefab;
        [UnityEngine.SerializeField]
        private float itemLabelRange;
        [UnityEngine.SerializeField]
        private UnityEngine.Color defaultItemColor;
        private int currentItemPos;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset critMessage;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset blockMessage;
        private TzarGames.Endless.PlayerCharacter _character;
        private UnityEngine.Camera _camera;
        private UnityEngine.Transform inactiveContainer;
        private TzarGames.Common.Pool<TzarGames.Endless.UI.FloatingLabelScreenUI.LabelInfo> labelInfos;
        private TzarGames.Common.Pool<TzarGames.Endless.UI.FloatingTextLabelUI> commonLabelPool;
        private TzarGames.Common.Pool<TzarGames.Endless.UI.FloatingTextLabelUI> criticalLabelPool;
        private TzarGames.Common.Pool<TzarGames.Endless.UI.FloatingTextLabelUI> hitLabelPool;
        private TzarGames.Common.Pool<TzarGames.Endless.UI.FloatingTextLabelUI> itemLabelPool;
        private TzarGames.Common.Pool<TzarGames.Endless.UI.FloatingTextLabelUI> blockLabelPool;
        private TzarGames.Common.Pool<TzarGames.Endless.UI.FloatingTextLabelUI> playerLabelPool;
        private System.Collections.Generic.List<TzarGames.Endless.UI.FloatingLabelScreenUI.LabelInfo> activeLabels;
        private System.Collections.Generic.List<TzarGames.Endless.UI.FloatingLabelScreenUI.PlayerLabelInfo> playerLabels;
        private System.Collections.Generic.Dictionary<TzarGames.Endless.UI.FloatingLabelBaseUI, TzarGames.Common.IPool> labelsAndPools;
        
        // Properties
        public TzarGames.TzarHero.TH_Character Character { get; }
        
        // Methods
        public FloatingLabelScreenUI()
        {
            this.showTime = 2f;
            this.itemLabelRange = 2f;
            this.inactiveContainerName = "___UI Floating Labels";
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.defaultItemColor = val_1;
            mem[1152921510902856992] = val_1.g;
            mem[1152921510902856996] = val_1.b;
            mem[1152921510902857000] = val_1.a;
            this.activeLabels = new System.Collections.Generic.List<LabelInfo>();
            this.playerLabels = new System.Collections.Generic.List<PlayerLabelInfo>();
            this.labelsAndPools = new System.Collections.Generic.Dictionary<TzarGames.Endless.UI.FloatingLabelBaseUI, TzarGames.Common.IPool>();
        }
        public TzarGames.TzarHero.TH_Character get_Character()
        {
            return (TzarGames.TzarHero.TH_Character)this._character;
        }
        protected override void OnPlayerOwnerSet(TzarGames.GameFramework.Player owner)
        {
            TzarGames.Endless.PlayerCharacter val_18;
            var val_19;
            IntPtr val_20;
            var val_21;
            var val_22;
            this.OnPlayerOwnerSet(owner:  owner);
            if(0 != this._character)
            {
                    val_18 = this._character;
                if(val_18.PlayerOwner == owner)
            {
                    return;
            }
            
            }
            
            val_19 = 0;
            this._character = ;
            add_OnHitOtherCharacter(value:  new TH_Character.dlgHitEvent(object:  this, method:  System.Void TzarGames.Endless.UI.FloatingLabelScreenUI::CharacterOnOnHitOtherCharacter(TzarGames.TzarHero.ICharacterDamageInfo hitData)));
            this._character.add_OnItemTaken(value:  new TH_Character.ItemTakeDelegate(object:  this, method:  System.Void TzarGames.Endless.UI.FloatingLabelScreenUI::CharacterOnOnItemTaken(TzarGames.GameFramework.ITakeItemEvent eventData)));
            val_20 = System.Void TzarGames.Endless.UI.FloatingLabelScreenUI::CharacterOnOnHitBlockedByShield(TzarGames.TzarHero.ICharacterDamageInfo characterDamageInfo);
            this._character.add_OnHitBlockedByShield(value:  new System.Action<TzarGames.TzarHero.ICharacterDamageInfo>(object:  this, method:  val_20));
            TzarGames.Endless.ThirdPersonCamera val_7 = this._character.PlayerCamera;
            this._camera = val_7.cachedCamera;
            val_18 = TzarGames.GameFramework.GameManager.Instance;
            if(0 == val_18)
            {
                    return;
            }
            
            List.Enumerator<T> val_10 = owner.NeighbourPlayers.GetEnumerator();
            label_25:
            if((0 & 1) == 0)
            {
                goto label_22;
            }
            
            if(1179403647 == 0)
            {
                goto label_25;
            }
            
            this.addPlayerLabel(player:  0.InitializationCallback);
            goto label_25;
            label_22:
            val_21 = 0;
            val_22 = 1;
            0.Dispose();
            val_20 = 1152921504729530368;
            TzarGames.GameFramework.GameManager.Instance.OnPlayerObjectSpawned.AddListener(call:  new UnityEngine.Events.UnityAction<TzarGames.GameFramework.Player>(object:  this, method:  System.Void TzarGames.Endless.UI.FloatingLabelScreenUI::addPlayerLabel(TzarGames.GameFramework.Player player)));
            UnityEngine.Events.UnityAction<TzarGames.GameFramework.Player> val_17 = null;
            val_18 = val_17;
            val_17 = new UnityEngine.Events.UnityAction<TzarGames.GameFramework.Player>(object:  this, method:  System.Void TzarGames.Endless.UI.FloatingLabelScreenUI::onPlayerExit(TzarGames.GameFramework.Player player));
            TzarGames.GameFramework.GameManager.Instance.OnPlayerExitFromGame.AddListener(call:  val_18);
        }
        private void onPlayerExit(TzarGames.GameFramework.Player player)
        {
            System.Collections.Generic.List<PlayerLabelInfo> val_3 = this.playerLabels;
            val_3 = val_3.Count - 1;
            do
            {
                if((val_3 & 2147483648) != 0)
            {
                    return;
            }
            
                val_3 = val_3 - 1;
            }
            while(val_2.Player != player);
            
            this.removePlayerLabel(info:  this.playerLabels.Item[val_3]);
        }
        private void CharacterOnOnHitBlockedByShield(TzarGames.TzarHero.ICharacterDamageInfo characterDamageInfo)
        {
            var val_3;
            var val_4;
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = characterDamageInfo;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = characterDamageInfo;
            this.addBlockLabel(worldPosition:  new UnityEngine.Vector3());
        }
        private void CharacterOnOnItemTaken(TzarGames.GameFramework.ITakeItemEvent eventData)
        {
            int val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            val_19 = eventData;
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_20 = val_19;
            val_21 = 0;
            if(0 == )
            {
                    return;
            }
            
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_22 = val_19;
            TzarGames.GameFramework.Item val_5 = val_19.GetTemplateInstance();
            if(0 == val_5)
            {
                    var val_20 = 0;
                val_20 = val_20 + 1;
                val_23 = val_19;
                TzarGames.GameFramework.Item val_8 = val_19.GetOriginalTemplate();
            }
            
            UnityEngine.Vector3 val_9 = Position;
            UnityEngine.Vector3 val_12 = PlayerCamera.transform.forward;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_12.x, y = 0f, z = val_12.z}, d:  this.itemLabelRange);
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  (float)this.currentItemPos);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            val_19 = this.currentItemPos + 1;
            this.currentItemPos = val_19;
            this.currentItemPos = UnityEngine.Mathf.Clamp(value:  0, min:  val_19, max:  0);
            UnityEngine.Vector3 val_17 = Position;
            this.addItemLabel(worldPosition:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, item:  val_5);
        }
        private void CharacterOnOnHitOtherCharacter(TzarGames.TzarHero.ICharacterDamageInfo hitData)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_6 = hitData;
            if((hitData & 1) == 0)
            {
                    return;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_7 = hitData;
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_8 = hitData;
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_9 = hitData;
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_10 = hitData;
            if((hitData & 1) != 0)
            {
                    this.addCriticalLabel(worldPosition:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, damage:  V0.16B);
                return;
            }
            
            this.addHitLabel(worldPosition:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, damage:  V0.16B);
        }
        private void addItemLabel(UnityEngine.Vector3 worldPosition, TzarGames.GameFramework.Item item)
        {
            UnityEngine.Color val_5;
            var val_6;
            var val_7;
            var val_8;
            TzarGames.Endless.UI.FloatingTextLabelUI val_1 = this.itemLabelPool.Get();
            val_1._textUi.text = item;
            TzarGames.GameFramework.Items.Attributes.ItemColorAttribute val_2 = item.GetAttributeOfType<TzarGames.GameFramework.Items.Attributes.ItemColorAttribute>();
            if(0 == val_2)
            {
                goto label_8;
            }
            
            UnityEngine.Color val_4 = val_2.Color;
            val_5 = val_4.r;
            val_6 = val_4.g;
            val_7 = val_4.b;
            val_8 = val_4.a;
            if(val_1 != null)
            {
                goto label_12;
            }
            
            goto label_11;
            label_8:
            val_5 = this.defaultItemColor;
            if(val_1 != null)
            {
                goto label_12;
            }
            
            label_11:
            label_12:
            val_1._textUi.Color = new UnityEngine.Color() {r = val_5, g = V12.16B, b = V13.16B, a = V14.16B};
            this.addLabel(worldPosition:  new UnityEngine.Vector3() {x = worldPosition.x, y = worldPosition.y, z = worldPosition.z}, label:  val_1);
        }
        private void addHitLabel(UnityEngine.Vector3 worldPosition, float damage)
        {
            val_1._textUi.text = 0 + "-"("-");
            this.addLabel(worldPosition:  new UnityEngine.Vector3() {x = worldPosition.x, y = worldPosition.y, z = worldPosition.z}, label:  this.hitLabelPool.Get());
        }
        private void addBlockLabel(UnityEngine.Vector3 worldPosition)
        {
            val_1._textUi.text = TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
            this.addLabel(worldPosition:  new UnityEngine.Vector3() {x = worldPosition.x, y = worldPosition.y, z = worldPosition.z}, label:  this.blockLabelPool.Get());
        }
        private void addPlayerLabel(TzarGames.GameFramework.Player player)
        {
            var val_13;
            if(player.itsMe == true)
            {
                    return;
            }
            
            var val_13 = 0;
            label_7:
            if(val_13 >= this.playerLabels.Count)
            {
                goto label_4;
            }
            
            PlayerLabelInfo val_4 = this.playerLabels.Item[0];
            val_13 = val_13 + 1;
            if(val_4.Player != player)
            {
                goto label_7;
            }
            
            return;
            label_4:
            val_13 = 0;
            TzarGames.Endless.UI.FloatingTextLabelUI val_6 = this.playerLabelPool.Get();
            val_6._textUi.text = PlayerOwner.Login;
            if(null != 0)
            {
                    typeof(FloatingLabelScreenUI.PlayerLabelInfo).__il2cppRuntimeField_10 = player;
            }
            else
            {
                    mem[16] = player;
            }
            
            typeof(FloatingLabelScreenUI.PlayerLabelInfo).__il2cppRuntimeField_18 = ;
            player.SetParent(parent:  this.container);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
            player.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            typeof(FloatingLabelScreenUI.PlayerLabelInfo).__il2cppRuntimeField_20 = val_6;
            this.playerLabels.Add(item:  new System.Object());
            UnityEngine.Vector3 val_11 = Position;
            UnityEngine.Vector3 val_12 = this._camera.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            this._camera.position = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
            val_6.Show();
        }
        private void removePlayerLabel(TzarGames.Endless.UI.FloatingLabelScreenUI.PlayerLabelInfo info)
        {
            var val_5;
            TzarGames.Endless.UI.FloatingTextLabelUI val_6;
            if(info != null)
            {
                    val_5 = info;
                val_6 = info.LabelUI;
            }
            else
            {
                    val_5 = 32;
                val_6 = 64;
            }
            
            mem[32] = 0;
            if(0 != val_6)
            {
                    UnityEngine.Color val_2 = 31514328.Color;
                31514328.Color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = 1f};
                0.SetParent(parent:  this.inactiveContainer);
                bool val_3 = this.playerLabelPool.Set(pooledObject:  val_6);
            }
            
            bool val_4 = this.playerLabels.Remove(item:  info);
        }
        private void addLabel(UnityEngine.Vector3 worldPosition, TzarGames.Endless.UI.FloatingLabelBaseUI label)
        {
            TzarGames.Endless.UI.FloatingLabelBaseUI val_20;
            UnityEngine.RectTransform val_21;
            float val_22;
            float val_23;
            float val_24;
            UnityEngine.Transform val_25;
            val_20 = label;
            LabelInfo val_1 = this.labelInfos.Get();
            float val_2 = UnityEngine.Time.time;
            if(val_1 != null)
            {
                    val_1.StartTime = val_2;
                val_1.Time = this.showTime;
            }
            else
            {
                    mem[16] = val_2;
                val_1.Time = this.showTime;
            }
            
            val_1.WorldPosition = worldPosition;
            mem2[0] = worldPosition.y;
            mem2[0] = worldPosition.z;
            val_21 = this.container;
            label.Transform.SetParent(parent:  val_21);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            val_22 = val_3.y;
            label.Transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_22, z = val_3.z};
            val_1.LabelUI = val_20;
            this.activeLabels.Add(item:  val_1);
            UnityEngine.Vector3 val_4 = this._camera.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = worldPosition.x, y = worldPosition.y, z = worldPosition.z});
            val_23 = val_4.x;
            val_24 = val_4.z;
            val_25 = label.Transform;
            val_25.position = new UnityEngine.Vector3() {x = val_23, y = val_4.y, z = val_24};
            if(this._character.Connected == false)
            {
                    return;
            }
            
            val_20 = ???;
            val_25 = ???;
            val_21 = ???;
            val_23 = ???;
            val_24 = ???;
            val_22 = ???;
            goto typeof(TzarGames.Endless.UI.FloatingLabelBaseUI).__il2cppRuntimeField_170;
        }
        private void addCriticalLabel(UnityEngine.Vector3 worldPosition, float damage)
        {
            val_1._textUi.text = System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
            this.addLabel(worldPosition:  new UnityEngine.Vector3() {x = worldPosition.x, y = worldPosition.y, z = worldPosition.z}, label:  this.criticalLabelPool.Get());
        }
        private void OnDestroy()
        {
            if(0 != this._character)
            {
                    this._character.remove_OnHitOtherCharacter(value:  new TH_Character.dlgHitEvent(object:  this, method:  System.Void TzarGames.Endless.UI.FloatingLabelScreenUI::CharacterOnOnHitOtherCharacter(TzarGames.TzarHero.ICharacterDamageInfo hitData)));
                this._character.remove_OnItemTaken(value:  new TH_Character.ItemTakeDelegate(object:  this, method:  System.Void TzarGames.Endless.UI.FloatingLabelScreenUI::CharacterOnOnItemTaken(TzarGames.GameFramework.ITakeItemEvent eventData)));
                this._character.remove_OnHitBlockedByShield(value:  new System.Action<TzarGames.TzarHero.ICharacterDamageInfo>(object:  this, method:  System.Void TzarGames.Endless.UI.FloatingLabelScreenUI::CharacterOnOnHitBlockedByShield(TzarGames.TzarHero.ICharacterDamageInfo characterDamageInfo)));
            }
            
            if(0 != TzarGames.GameFramework.GameManager.Instance)
            {
                    1152921504721543168 = 1152921504729530368;
                TzarGames.GameFramework.GameManager.Instance.OnPlayerEnterToGame.RemoveListener(call:  new UnityEngine.Events.UnityAction<TzarGames.GameFramework.Player>(object:  this, method:  System.Void TzarGames.Endless.UI.FloatingLabelScreenUI::addPlayerLabel(TzarGames.GameFramework.Player player)));
                TzarGames.GameFramework.GameManager.Instance.OnPlayerExitFromGame.RemoveListener(call:  new UnityEngine.Events.UnityAction<TzarGames.GameFramework.Player>(object:  this, method:  System.Void TzarGames.Endless.UI.FloatingLabelScreenUI::onPlayerExit(TzarGames.GameFramework.Player player)));
            }
            
            System.Action<TzarGames.GameFramework.Player> val_14 = new System.Action<TzarGames.GameFramework.Player>(object:  this, method:  System.Void TzarGames.Endless.UI.FloatingLabelScreenUI::Player_OnLoginChanged(TzarGames.GameFramework.Player player));
            TzarGames.GameFramework.Player.remove_OnLoginChanged(value:  0);
        }
        protected override void Awake()
        {
            this.Awake();
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  this.inactiveContainerName);
            if(null != 0)
            {
                    SetActive(value:  false);
            }
            else
            {
                    SetActive(value:  false);
            }
            
            this.inactiveContainer = transform;
            this.labelInfos = new TzarGames.Common.Pool<LabelInfo>(createObjectCallback:  new Pool.CreateObjectDeleagate<LabelInfo>(object:  this, method:  LabelInfo TzarGames.Endless.UI.FloatingLabelScreenUI::createLabelInfo()), maxCount:  2147483647);
            CreateObjects(count:  20);
            this.criticalLabelPool = new TzarGames.Common.Pool<TzarGames.Endless.UI.FloatingTextLabelUI>(createObjectCallback:  new Pool.CreateObjectDeleagate<TzarGames.Endless.UI.FloatingTextLabelUI>(object:  this, method:  TzarGames.Endless.UI.FloatingTextLabelUI TzarGames.Endless.UI.FloatingLabelScreenUI::createCriticalLabel()), maxCount:  2147483647);
            CreateObjects(count:  10);
            this.hitLabelPool = new TzarGames.Common.Pool<TzarGames.Endless.UI.FloatingTextLabelUI>(createObjectCallback:  new Pool.CreateObjectDeleagate<TzarGames.Endless.UI.FloatingTextLabelUI>(object:  this, method:  TzarGames.Endless.UI.FloatingTextLabelUI TzarGames.Endless.UI.FloatingLabelScreenUI::createHitlLabel()), maxCount:  2147483647);
            CreateObjects(count:  20);
            this.itemLabelPool = new TzarGames.Common.Pool<TzarGames.Endless.UI.FloatingTextLabelUI>(createObjectCallback:  new Pool.CreateObjectDeleagate<TzarGames.Endless.UI.FloatingTextLabelUI>(object:  this, method:  TzarGames.Endless.UI.FloatingTextLabelUI TzarGames.Endless.UI.FloatingLabelScreenUI::createItemLabel()), maxCount:  2147483647);
            CreateObjects(count:  10);
            this.blockLabelPool = new TzarGames.Common.Pool<TzarGames.Endless.UI.FloatingTextLabelUI>(createObjectCallback:  new Pool.CreateObjectDeleagate<TzarGames.Endless.UI.FloatingTextLabelUI>(object:  this, method:  TzarGames.Endless.UI.FloatingTextLabelUI TzarGames.Endless.UI.FloatingLabelScreenUI::createBlockLabel()), maxCount:  2147483647);
            CreateObjects(count:  10);
            this.commonLabelPool = new TzarGames.Common.Pool<TzarGames.Endless.UI.FloatingTextLabelUI>(createObjectCallback:  new Pool.CreateObjectDeleagate<TzarGames.Endless.UI.FloatingTextLabelUI>(object:  this, method:  TzarGames.Endless.UI.FloatingTextLabelUI TzarGames.Endless.UI.FloatingLabelScreenUI::createCommonLabel()), maxCount:  2147483647);
            CreateObjects(count:  10);
            this.playerLabelPool = new TzarGames.Common.Pool<TzarGames.Endless.UI.FloatingTextLabelUI>(createObjectCallback:  new Pool.CreateObjectDeleagate<TzarGames.Endless.UI.FloatingTextLabelUI>(object:  this, method:  TzarGames.Endless.UI.FloatingTextLabelUI TzarGames.Endless.UI.FloatingLabelScreenUI::createPlayerLabel()), maxCount:  2147483647);
            CreateObjects(count:  10);
            System.Action<TzarGames.GameFramework.Player> val_17 = new System.Action<TzarGames.GameFramework.Player>(object:  this, method:  System.Void TzarGames.Endless.UI.FloatingLabelScreenUI::Player_OnLoginChanged(TzarGames.GameFramework.Player player));
            TzarGames.GameFramework.Player.add_OnLoginChanged(value:  0);
        }
        private void Player_OnLoginChanged(TzarGames.GameFramework.Player player)
        {
            System.Collections.Generic.List<PlayerLabelInfo> val_4 = this.playerLabels;
            val_4 = val_4.Count - 1;
            do
            {
                if((val_4 & 2147483648) != 0)
            {
                    return;
            }
            
                PlayerLabelInfo val_2 = this.playerLabels.Item[val_4];
                val_4 = val_4 - 1;
            }
            while(val_2.Player != player);
            
            val_2.LabelUI._textUi.text = player.Login;
        }
        private TzarGames.Endless.UI.FloatingLabelScreenUI.LabelInfo createLabelInfo()
        {
            return (LabelInfo)new System.Object();
        }
        private TzarGames.Endless.UI.FloatingTextLabelUI createCriticalLabel()
        {
            TzarGames.Endless.UI.SkillUpgradeUI val_1 = TzarGames.GameFramework.GameManager.MakeInstance<TzarGames.Endless.UI.SkillUpgradeUI>(obj:  0);
            val_1.icon.SetParent(parent:  this.inactiveContainer);
            this.labelsAndPools.Add(key:  val_1, value:  this.criticalLabelPool);
            return (TzarGames.Endless.UI.FloatingTextLabelUI)val_1;
        }
        private TzarGames.Endless.UI.FloatingTextLabelUI createItemLabel()
        {
            TzarGames.Endless.UI.SkillUpgradeUI val_1 = TzarGames.GameFramework.GameManager.MakeInstance<TzarGames.Endless.UI.SkillUpgradeUI>(obj:  0);
            val_1.icon.SetParent(parent:  this.inactiveContainer);
            this.labelsAndPools.Add(key:  val_1, value:  this.itemLabelPool);
            return (TzarGames.Endless.UI.FloatingTextLabelUI)val_1;
        }
        private TzarGames.Endless.UI.FloatingTextLabelUI createBlockLabel()
        {
            TzarGames.Endless.UI.SkillUpgradeUI val_1 = TzarGames.GameFramework.GameManager.MakeInstance<TzarGames.Endless.UI.SkillUpgradeUI>(obj:  0);
            val_1.icon.SetParent(parent:  this.inactiveContainer, worldPositionStays:  false);
            this.labelsAndPools.Add(key:  val_1, value:  this.blockLabelPool);
            return (TzarGames.Endless.UI.FloatingTextLabelUI)val_1;
        }
        private TzarGames.Endless.UI.FloatingTextLabelUI createHitlLabel()
        {
            TzarGames.Endless.UI.SkillUpgradeUI val_1 = TzarGames.GameFramework.GameManager.MakeInstance<TzarGames.Endless.UI.SkillUpgradeUI>(obj:  0);
            val_1.icon.SetParent(parent:  this.inactiveContainer);
            this.labelsAndPools.Add(key:  val_1, value:  this.hitLabelPool);
            return (TzarGames.Endless.UI.FloatingTextLabelUI)val_1;
        }
        private TzarGames.Endless.UI.FloatingTextLabelUI createCommonLabel()
        {
            TzarGames.Endless.UI.SkillUpgradeUI val_1 = TzarGames.GameFramework.GameManager.MakeInstance<TzarGames.Endless.UI.SkillUpgradeUI>(obj:  0);
            val_1.icon.SetParent(parent:  this.inactiveContainer, worldPositionStays:  false);
            this.labelsAndPools.Add(key:  val_1, value:  this.commonLabelPool);
            return (TzarGames.Endless.UI.FloatingTextLabelUI)val_1;
        }
        private TzarGames.Endless.UI.FloatingTextLabelUI createPlayerLabel()
        {
            TzarGames.Endless.UI.SkillUpgradeUI val_1 = TzarGames.GameFramework.GameManager.MakeInstance<TzarGames.Endless.UI.SkillUpgradeUI>(obj:  0);
            val_1.icon.SetParent(parent:  this.inactiveContainer, worldPositionStays:  false);
            this.labelsAndPools.Add(key:  val_1, value:  this.playerLabelPool);
            return (TzarGames.Endless.UI.FloatingTextLabelUI)val_1;
        }
        private void removeLabelInfo(TzarGames.Endless.UI.FloatingLabelScreenUI.LabelInfo info)
        {
            var val_10;
            TzarGames.Endless.UI.FloatingLabelBaseUI val_11;
            TzarGames.Common.Pool<TzarGames.Endless.UI.FloatingTextLabelUI> val_12;
            var val_13;
            var val_14;
            bool val_1 = this.activeLabels.Remove(item:  info);
            if(info != null)
            {
                    val_10 = info;
                val_11 = info.LabelUI;
            }
            else
            {
                    val_10 = 40;
                val_11 = 34460624;
            }
            
            mem[40] = 0;
            bool val_2 = this.labelInfos.Set(pooledObject:  info);
            26687812.SetParent(parent:  this.inactiveContainer);
            TzarGames.Common.IPool val_3 = this.labelsAndPools.Item[val_11];
            val_12 = this.criticalLabelPool;
            if(val_3 == val_12)
            {
                goto label_11;
            }
            
            val_12 = this.hitLabelPool;
            if(val_3 == val_12)
            {
                goto label_11;
            }
            
            val_12 = this.blockLabelPool;
            if(val_3 == val_12)
            {
                goto label_11;
            }
            
            val_12 = this.commonLabelPool;
            if(val_3 == val_12)
            {
                goto label_11;
            }
            
            if(val_3 != this.itemLabelPool)
            {
                    return;
            }
            
            val_13 = 0;
            goto label_16;
            label_11:
            val_14 = 0;
            bool val_5 = val_12.Set(pooledObject:  null);
            return;
            label_16:
            bool val_7 = this.itemLabelPool.Set(pooledObject:  null);
            int val_10 = this.currentItemPos;
            val_10 = val_10 - 1;
            int val_8 = val_10 >> 31;
            val_8 = val_8 & 4294967293;
            this.currentItemPos = (val_8 == 3) ? 0 : (val_10);
        }
        public void AddCommonLabel(string text, UnityEngine.Color color, UnityEngine.Vector3 position)
        {
            val_1._textUi.text = text;
            val_1._textUi.Color = new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a};
            this.addLabel(worldPosition:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, label:  this.commonLabelPool.Get());
        }
        private void LateUpdate()
        {
            float val_20;
            PlayerLabelInfo val_21;
            TzarGames.Common.UI.TextUI val_22;
            float val_23;
            float val_24;
            float val_25;
            val_20 = UnityEngine.Time.deltaTime;
            if(this._character.Connected == false)
            {
                goto label_4;
            }
            
            System.Collections.Generic.List<PlayerLabelInfo> val_20 = this.playerLabels;
            val_20 = val_20.Count - 1;
            if((val_20 & 2147483648) != 0)
            {
                goto label_4;
            }
            
            float val_4 = val_20 + val_20;
            label_32:
            val_21 = this.playerLabels.Item[val_20];
            if(val_21 == null)
            {
                goto label_27;
            }
            
            if((0 == val_5.PlayerCharacter) || (val_5.Player == null))
            {
                goto label_10;
            }
            
            UnityEngine.Vector3 val_9 = val_5.PlayerCharacter.PlayerLabelPosition.position;
            UnityEngine.Vector3 val_10 = this._camera.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            val_5.LabelUI.position = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            val_22 = val_5.LabelUI._textUi;
            UnityEngine.Color val_11 = val_22.Color;
            val_20 = val_11.r;
            val_23 = val_11.b;
            val_24 = val_11.a;
            TzarGames.Endless.PlayerFadeBehaviour val_12 = val_5.PlayerCharacter.Fader;
            if((0 == val_12) || (val_12.IsFading == false))
            {
                goto label_23;
            }
            
            if(val_24 <= 0f)
            {
                goto label_29;
            }
            
            val_24 = val_24 - val_4;
            if(val_24 >= 0)
            {
                goto label_29;
            }
            
            val_24 = 0f;
            goto label_29;
            label_10:
            this.removePlayerLabel(info:  val_21);
            goto label_27;
            label_23:
            if(val_24 < 0)
            {
                    val_24 = val_4 + val_24;
                if(val_24 > 1f)
            {
                    val_24 = 1f;
            }
            
            }
            
            label_29:
            val_21 = val_5.LabelUI._textUi;
            val_21.Color = new UnityEngine.Color() {r = val_20, g = val_11.g, b = val_23, a = val_24};
            label_27:
            val_20 = val_20 - 1;
            if((val_20 & 2147483648) == 0)
            {
                goto label_32;
            }
            
            label_4:
            int val_21 = this.activeLabels.Count;
            if(val_21 == 0)
            {
                    return;
            }
            
            val_20 = UnityEngine.Time.time;
            val_21 = val_21 - 1;
            if((val_21 & 2147483648) != 0)
            {
                    return;
            }
            
            val_22 = 1152921510907103696;
            do
            {
                val_21 = this.activeLabels.Item[val_21];
                if(val_21 != null)
            {
                    val_25 = val_17.StartTime;
            }
            else
            {
                    val_25 = 1.68059E-38f;
            }
            
                if((val_20 - val_25) < val_17.Time)
            {
                    UnityEngine.Vector3 val_19 = this._camera.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_17.WorldPosition, y = val_23, z = val_24});
                val_23 = val_19.y;
                val_21 = val_17.LabelUI.Transform;
                val_21.position = new UnityEngine.Vector3() {x = val_19.x, y = val_23, z = val_19.z};
            }
            else
            {
                    this.removeLabelInfo(info:  val_21);
            }
            
                val_21 = val_21 - 1;
            }
            while((val_21 & 2147483648) == 0);
        
        }
    
    }

}
