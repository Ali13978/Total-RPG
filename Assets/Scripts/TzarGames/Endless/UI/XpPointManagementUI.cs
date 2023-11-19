using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class XpPointManagementUI : GameUIBase
    {
        // Fields
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase characteristicsWindow;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Button characteristicsButton;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Button confirmButton;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI currentPoints;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.CharacteristicUpgradeUI damageUpgradePointsUI;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.CharacteristicUpgradeUI defenceUpgradePointsUI;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.CharacteristicUpgradeUI speedUpgradePointsUI;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.CharacteristicUpgradeUI attackSpeedUpgradePointsUI;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.CharacteristicUpgradeUI hpUpgradePointsUI;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.CharacteristicUpgradeUI hpRegenUpgradePointsUI;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.CharacteristicUpgradeUI critChanceUpgradePointsUI;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.CharacteristicUpgradeUI critMultiplierUpgradePointsUI;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.CharacteristicUpgradeUI blockChanceUpgradePointsUI;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset currentPointsFormat;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase skillWindow;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Button skillsButton;
        [UnityEngine.SerializeField]
        private UnityEngine.Transform skillContainer;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.SkillUpgradeUI skillUpgradePrefab;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset damageSkillUpgradeLabel;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset cooldownUpgradeLabel;
        private TzarGames.Common.Pool<TzarGames.Endless.UI.SkillUpgradeUI> skillUpgradeUiPool;
        private System.Collections.Generic.List<TzarGames.Endless.UI.SkillUpgradeUI> activeSkillUiList;
        private System.Collections.Generic.List<TzarGames.Endless.UI.SkillUpgradeUI> createdSkillUiList;
        private bool isInitialized;
        private System.Collections.Generic.List<TzarGames.Endless.UI.XpPointManagementUI.CharacteristicUpgradeInfo> upgrades;
        private System.Collections.Generic.List<TzarGames.Endless.UI.XpPointManagementUI.SkillUpgradeInfo> skillUpgrades;
        
        // Properties
        private TzarGames.Endless.EndlessPlayerCharacterTemplate playerCharacter { get; }
        
        // Methods
        public XpPointManagementUI()
        {
            this.activeSkillUiList = new System.Collections.Generic.List<TzarGames.Endless.UI.SkillUpgradeUI>();
            this.createdSkillUiList = new System.Collections.Generic.List<TzarGames.Endless.UI.SkillUpgradeUI>();
            this.upgrades = new System.Collections.Generic.List<CharacteristicUpgradeInfo>();
            this.skillUpgrades = new System.Collections.Generic.List<SkillUpgradeInfo>();
        }
        private TzarGames.Endless.UI.SkillUpgradeUI createSkillUpgradeUI()
        {
            TzarGames.Endless.UI.SkillUpgradeUI val_1 = TzarGames.GameFramework.GameManager.MakeInstance<TzarGames.Endless.UI.SkillUpgradeUI>(obj:  0);
            val_1.transform.SetParent(parent:  TzarGames.Endless.UI.XpPointManagementUI.getSkillUiContainer().transform);
            val_1.CooldownCounter.add_OnValueChanged(value:  new System.Action<System.String>(object:  this, method:  System.Void TzarGames.Endless.UI.XpPointManagementUI::onCounterChanged(string val)));
            val_1.CommonCounter.add_OnValueChanged(value:  new System.Action<System.String>(object:  this, method:  System.Void TzarGames.Endless.UI.XpPointManagementUI::onCounterChanged(string val)));
            this.createdSkillUiList.Add(item:  val_1);
            return val_1;
        }
        private void OnDestroy()
        {
            goto label_1;
            label_13:
            0 = 1;
            label_1:
            if(0 >= this.createdSkillUiList.Count)
            {
                goto label_4;
            }
            
            TzarGames.Endless.UI.SkillUpgradeUI val_2 = this.createdSkillUiList.Item[1];
            if(0 == val_2)
            {
                goto label_13;
            }
            
            val_2.CooldownCounter.remove_OnValueChanged(value:  new System.Action<System.String>(object:  this, method:  System.Void TzarGames.Endless.UI.XpPointManagementUI::onCounterChanged(string val)));
            val_2.CommonCounter.remove_OnValueChanged(value:  new System.Action<System.String>(object:  this, method:  System.Void TzarGames.Endless.UI.XpPointManagementUI::onCounterChanged(string val)));
            UnityEngine.GameObject val_7 = val_2.gameObject;
            TzarGames.GameFramework.GameManager.DestroyInstance(obj:  0);
            goto label_13;
            label_4:
            this.createdSkillUiList.Clear();
        }
        private void onCounterChanged(string val)
        {
            this.UpdateUI();
        }
        private static UnityEngine.Transform getSkillUiContainer()
        {
            UnityEngine.GameObject val_4 = UnityEngine.GameObject.Find(name:  0);
            if(0 == val_4)
            {
                    UnityEngine.GameObject val_3 = null;
                val_4 = val_3;
                val_3 = new UnityEngine.GameObject(name:  "SkillUpgradeUI_Container");
            }
            
            if(null != 0)
            {
                    return transform;
            }
            
            return transform;
        }
        private TzarGames.Endless.EndlessPlayerCharacterTemplate get_playerCharacter()
        {
            var val_4;
            if(this.PlayerOwner == null)
            {
                    return 0;
            }
            
            TzarGames.GameFramework.Player val_2 = this.PlayerOwner;
            if(val_2.PlayerComponent == null)
            {
                    return 0.PlayerTemplateInstance;
            }
            
            val_4 = null;
            val_4 = null;
            var val_3 = (((TzarGames.GameFramework.IPlayerComponent.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.PlayerCharacter.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_4) ? val_2.PlayerComponent : 0;
            return 0.PlayerTemplateInstance;
        }
        private void registerUpgrade(TzarGames.Endless.UI.CharacteristicUpgradeUI ui, TzarGames.Endless.EndlessPlayerCharacterTemplate.ICharacteristicUpgrade upgrade)
        {
            ui.Counter.MinValue = 0;
            ui.Counter.MaxValue = 10;
            typeof(XpPointManagementUI.CharacteristicUpgradeInfo).__il2cppRuntimeField_10 = ui;
            typeof(XpPointManagementUI.CharacteristicUpgradeInfo).__il2cppRuntimeField_18 = ui.Counter;
            typeof(XpPointManagementUI.CharacteristicUpgradeInfo).__il2cppRuntimeField_20 = upgrade;
            this.upgrades.Add(item:  new System.Object());
        }
        private int getRequiredPoints()
        {
            var val_8;
            var val_9;
            var val_10;
            List.Enumerator<T> val_1 = this.upgrades.GetEnumerator();
            val_8 = 0;
            goto label_2;
            label_7:
            val_8 = val_1.current + val_8;
            label_2:
            if((0 & 1) == 0)
            {
                goto label_3;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_2 = 0.InitializationCallback;
            int val_3 = X22.CurrentValue;
            int val_4 = val_3.calculateRequiredPoints(currentValue:  val_3, upgrade:  null);
            goto label_7;
            label_3:
            0.Dispose();
            List.Enumerator<T> val_5 = this.skillUpgrades.GetEnumerator();
            goto label_11;
            label_13:
            val_8 = val_5.current + val_8;
            label_11:
            if((0 & 1) == 0)
            {
                goto label_12;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_6 = 0.InitializationCallback;
            int val_7 = val_6.calculateRequiredPointsForSkill(skillInfo:  val_6);
            goto label_13;
            label_12:
            val_9 = 0;
            val_10 = 1;
            0.Dispose();
            if((val_10 & 1) != 0)
            {
                    return (int)val_8;
            }
            
            if(val_9 == 0)
            {
                    return (int)val_8;
            }
            
            return (int)val_8;
        }
        private int calculateRequiredPointsForSkill(TzarGames.Endless.UI.XpPointManagementUI.SkillUpgradeInfo skillInfo)
        {
            EndlessPlayerCharacterTemplate.ISkillUpgrade val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            if(skillInfo != null)
            {
                    val_7 = skillInfo.Upgrade;
            }
            else
            {
                    val_7 = 7254272;
            }
            
            var val_16 = skillInfo.SkillUI.CommonCounter.CurrentValue;
            var val_7 = skillInfo.SkillUI.CooldownCounter.CurrentValue;
            var val_6 = -1342125470;
            if((mem[-484915127754110108]) == 0)
            {
                goto label_9;
            }
            
            var val_3 = mem[-484915127754110214];
            var val_4 = 0;
            val_3 = val_3 + 8;
            label_11:
            if(((mem[-484915127754110214] + 8) + -8) == null)
            {
                goto label_10;
            }
            
            val_4 = val_4 + 1;
            val_3 = val_3 + 16;
            if(val_4 < (mem[-484915127754110108]))
            {
                goto label_11;
            }
            
            label_9:
            val_8 = 1;
            val_9 = val_7;
            goto label_12;
            label_10:
            var val_5 = val_3;
            val_5 = val_5 + 1;
            val_6 = val_6 + val_5;
            val_9 = val_6 + 272;
            label_12:
            val_7 = val_7 - val_7;
            var val_11 = -1342125470;
            if((mem[-484915127754110108]) == 0)
            {
                goto label_14;
            }
            
            var val_8 = mem[-484915127754110214];
            var val_9 = 0;
            val_8 = val_8 + 8;
            label_16:
            if(((mem[-484915127754110214] + 8) + -8) == null)
            {
                goto label_15;
            }
            
            val_9 = val_9 + 1;
            val_8 = val_8 + 16;
            if(val_9 < (mem[-484915127754110108]))
            {
                goto label_16;
            }
            
            label_14:
            val_8 = 8;
            val_10 = val_7;
            goto label_17;
            label_15:
            var val_10 = val_8;
            val_10 = val_10 + 8;
            val_11 = val_11 + val_10;
            val_10 = val_11 + 272;
            label_17:
            val_11 = mem[((-1342125470 + ((mem[-484915127754110214] + 8) + 8)) + 272) + 8];
            val_11 = ((-1342125470 + ((mem[-484915127754110214] + 8) + 8)) + 272) + 8;
            var val_15 = -1342125470;
            if((mem[-484915127754110108]) == 0)
            {
                goto label_19;
            }
            
            var val_12 = mem[-484915127754110214];
            var val_13 = 0;
            val_12 = val_12 + 8;
            label_21:
            if(((mem[-484915127754110214] + 8) + -8) == null)
            {
                goto label_20;
            }
            
            val_13 = val_13 + 1;
            val_12 = val_12 + 16;
            if(val_13 < (mem[-484915127754110108]))
            {
                goto label_21;
            }
            
            label_19:
            val_11 = 2;
            val_12 = val_7;
            goto label_22;
            label_20:
            var val_14 = val_12;
            val_14 = val_14 + 2;
            val_15 = val_15 + val_14;
            val_12 = val_15 + 272;
            label_22:
            val_16 = val_16 - val_7;
            var val_20 = -1342125470;
            if((mem[-484915127754110108]) == 0)
            {
                goto label_24;
            }
            
            var val_17 = mem[-484915127754110214];
            var val_18 = 0;
            val_17 = val_17 + 8;
            label_26:
            if(((mem[-484915127754110214] + 8) + -8) == null)
            {
                goto label_25;
            }
            
            val_18 = val_18 + 1;
            val_17 = val_17 + 16;
            if(val_18 < (mem[-484915127754110108]))
            {
                goto label_26;
            }
            
            label_24:
            val_11 = 7;
            val_13 = val_7;
            goto label_27;
            label_25:
            var val_19 = val_17;
            val_19 = val_19 + 7;
            val_20 = val_20 + val_19;
            val_13 = val_20 + 272;
            label_27:
            var val_21 = val_7;
            val_21 = val_21 + val_7;
            return (int)val_21;
        }
        private int calculateRequiredPoints(int currentValue, TzarGames.Endless.EndlessPlayerCharacterTemplate.ICharacteristicUpgrade upgrade)
        {
            var val_3;
            var val_4;
            var val_5;
            int val_4 = currentValue;
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = 3;
            val_4 = upgrade;
            val_4 = val_4 - upgrade;
            if(val_4 < 1)
            {
                    return 0;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_3 = 1;
            val_5 = upgrade;
        }
        public void Confirm()
        {
            var val_6;
            var val_44;
            var val_45;
            var val_46;
            var val_47;
            var val_48;
            var val_49;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            var val_54;
            var val_55;
            var val_56;
            var val_57;
            var val_58;
            var val_59;
            var val_60;
            var val_61;
            var val_62;
            var val_63;
            var val_64;
            var val_65;
            var val_66;
            var val_67;
            var val_68;
            var val_69;
            var val_70;
            var val_71;
            var val_72;
            val_44 = this.playerCharacter;
            if((long)this.getRequiredPoints() > val_44.AvailableUpgradePoints)
            {
                    UnityEngine.Debug.Log(message:  0);
                return;
            }
            
            List.Enumerator<T> val_4 = this.upgrades.GetEnumerator();
            label_23:
            if((0 & 1) == 0)
            {
                goto label_7;
            }
            
            var val_36 = X22;
            if((X22 + 258) == 0)
            {
                goto label_12;
            }
            
            var val_33 = X22 + 152;
            var val_34 = 0;
            val_33 = val_33 + 8;
            label_14:
            if(((X22 + 152 + 8) + -8) == null)
            {
                goto label_13;
            }
            
            val_34 = val_34 + 1;
            val_33 = val_33 + 16;
            if(val_34 < (X22 + 258))
            {
                goto label_14;
            }
            
            label_12:
            val_45 = 3;
            val_46 = X22;
            goto label_15;
            label_13:
            var val_35 = val_33;
            val_35 = val_35 + 3;
            val_36 = val_36 + val_35;
            val_46 = val_36 + 272;
            label_15:
            val_44 = val_44.CurrentValue - X22;
            if(val_44 < 1)
            {
                goto label_23;
            }
            
            var val_39 = X22;
            if((X22 + 258) == 0)
            {
                goto label_19;
            }
            
            var val_37 = X22 + 152;
            var val_38 = 0;
            val_37 = val_37 + 8;
            label_21:
            if(((X22 + 152 + 8) + -8) == null)
            {
                goto label_20;
            }
            
            val_38 = val_38 + 1;
            val_37 = val_37 + 16;
            if(val_38 < (X22 + 258))
            {
                goto label_21;
            }
            
            label_19:
            val_45 = 0;
            val_47 = X22;
            goto label_22;
            label_20:
            val_39 = val_39 + (((X22 + 152 + 8)) << 4);
            val_47 = val_39 + 272;
            label_22:
            if(((X22 & 1) & 1) != 0)
            {
                goto label_23;
            }
            
            string val_10 = val_6.InitializationCallback.name;
            string val_11 = 0 + "Failed to upgrade ";
            UnityEngine.Debug.Log(message:  0);
            val_6.Dispose();
            return;
            label_7:
            val_6.Dispose();
            List.Enumerator<T> val_12 = this.skillUpgrades.GetEnumerator();
            label_68:
            if((0 & 1) == 0)
            {
                goto label_34;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_13 = val_6.InitializationCallback;
            var val_44 = val_44.CurrentValue;
            var val_43 = X22;
            if((X22 + 258) == 0)
            {
                goto label_40;
            }
            
            var val_40 = X22 + 152;
            var val_41 = 0;
            val_40 = val_40 + 8;
            label_42:
            if(((X22 + 152 + 8) + -8) == null)
            {
                goto label_41;
            }
            
            val_41 = val_41 + 1;
            val_40 = val_40 + 16;
            if(val_41 < (X22 + 258))
            {
                goto label_42;
            }
            
            label_40:
            val_48 = 2;
            val_49 = X22;
            goto label_43;
            label_41:
            var val_42 = val_40;
            val_42 = val_42 + 2;
            val_43 = val_43 + val_42;
            val_49 = val_43 + 272;
            label_43:
            val_44 = val_44 - X22;
            if(val_44 < 1)
            {
                goto label_44;
            }
            
            var val_48 = X22;
            if((X22 + 258) == 0)
            {
                goto label_47;
            }
            
            var val_45 = X22 + 152;
            var val_46 = 0;
            val_45 = val_45 + 8;
            label_49:
            if(((X22 + 152 + 8) + -8) == null)
            {
                goto label_48;
            }
            
            val_46 = val_46 + 1;
            val_45 = val_45 + 16;
            if(val_46 < (X22 + 258))
            {
                goto label_49;
            }
            
            label_47:
            val_50 = 5;
            val_51 = X22;
            goto label_50;
            label_48:
            var val_47 = val_45;
            val_47 = val_47 + 5;
            val_48 = val_48 + val_47;
            val_51 = val_48 + 272;
            label_50:
            val_52 = mem[((X22 + ((X22 + 152 + 8) + 5)) + 272) + 8];
            val_52 = ((X22 + ((X22 + 152 + 8) + 5)) + 272) + 8;
            if(((X22 & 1) & 1) == 0)
            {
                goto label_51;
            }
            
            label_44:
            var val_53 = (val_14 - X22) + 56.CurrentValue;
            var val_52 = X22;
            if((X22 + 258) == 0)
            {
                goto label_57;
            }
            
            var val_49 = X22 + 152;
            var val_50 = 0;
            val_49 = val_49 + 8;
            label_59:
            if(((X22 + 152 + 8) + -8) == null)
            {
                goto label_58;
            }
            
            val_50 = val_50 + 1;
            val_49 = val_49 + 16;
            if(val_50 < (X22 + 258))
            {
                goto label_59;
            }
            
            label_57:
            val_52 = 1;
            val_53 = X22;
            goto label_60;
            label_58:
            var val_51 = val_49;
            val_51 = val_51 + 1;
            val_52 = val_52 + val_51;
            val_53 = val_52 + 272;
            label_60:
            val_53 = val_53 - X22;
            if(val_53 < 1)
            {
                goto label_68;
            }
            
            var val_57 = X22;
            if((X22 + 258) == 0)
            {
                goto label_64;
            }
            
            var val_54 = X22 + 152;
            var val_55 = 0;
            val_54 = val_54 + 8;
            label_66:
            if(((X22 + 152 + 8) + -8) == null)
            {
                goto label_65;
            }
            
            val_55 = val_55 + 1;
            val_54 = val_54 + 16;
            if(val_55 < (X22 + 258))
            {
                goto label_66;
            }
            
            label_64:
            val_52 = 6;
            val_54 = X22;
            goto label_67;
            label_65:
            var val_56 = val_54;
            val_56 = val_56 + 6;
            val_57 = val_57 + val_56;
            val_54 = val_57 + 272;
            label_67:
            if(((X22 & 1) & 1) != 0)
            {
                goto label_68;
            }
            
            var val_58 = 0;
            val_58 = val_58 + 1;
            val_55 = val_13;
            goto label_74;
            label_78:
            List.Enumerator<T> val_18 = this.upgrades.GetEnumerator();
            val_56 = 0;
            goto label_88;
            label_34:
            val_6.Dispose();
            goto label_78;
            label_95:
            val_56 = 1;
            goto label_88;
            label_101:
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_19 = val_6.InitializationCallback;
            var val_63 = CurrentValue;
            var val_62 = X22;
            if((X22 + 258) == 0)
            {
                goto label_84;
            }
            
            var val_59 = X22 + 152;
            var val_60 = 0;
            val_59 = val_59 + 8;
            label_86:
            if(((X22 + 152 + 8) + -8) == null)
            {
                goto label_85;
            }
            
            val_60 = val_60 + 1;
            val_59 = val_59 + 16;
            if(val_60 < (X22 + 258))
            {
                goto label_86;
            }
            
            label_84:
            val_57 = 3;
            val_58 = X22;
            goto label_87;
            label_85:
            var val_61 = val_59;
            val_61 = val_61 + 3;
            val_62 = val_62 + val_61;
            val_58 = val_62 + 272;
            label_87:
            val_63 = val_63 - X22;
            if(val_63 < 1)
            {
                goto label_88;
            }
            
            var val_67 = X22;
            if((X22 + 258) == 0)
            {
                goto label_91;
            }
            
            var val_64 = X22 + 152;
            var val_65 = 0;
            val_64 = val_64 + 8;
            label_93:
            if(((X22 + 152 + 8) + -8) == null)
            {
                goto label_92;
            }
            
            val_65 = val_65 + 1;
            val_64 = val_64 + 16;
            if(val_65 < (X22 + 258))
            {
                goto label_93;
            }
            
            label_91:
            val_59 = 2;
            val_60 = X22;
            goto label_94;
            label_92:
            var val_66 = val_64;
            val_66 = val_66 + 2;
            val_67 = val_67 + val_66;
            val_60 = val_67 + 272;
            label_94:
            if(((X22 & 1) & 1) != 0)
            {
                goto label_95;
            }
            
            string val_22 = 0 + "Failed to upgrade ";
            val_61 = 0;
            UnityEngine.Debug.LogError(message:  0);
            label_88:
            if((0 & 1) != 0)
            {
                goto label_101;
            }
            
            val_6.Dispose();
            val_62 = 1152921511021797408;
            val_63 = 1152921511021798432;
            List.Enumerator<T> val_23 = this.skillUpgrades.GetEnumerator();
            label_139:
            if((0 & 1) == 0)
            {
                goto label_150;
            }
            
            var val_72 = (val_20 - X22) + 48.CurrentValue;
            var val_71 = X22;
            if((X22 + 258) == 0)
            {
                goto label_111;
            }
            
            var val_68 = X22 + 152;
            var val_69 = 0;
            val_68 = val_68 + 8;
            label_113:
            if(((X22 + 152 + 8) + -8) == null)
            {
                goto label_112;
            }
            
            val_69 = val_69 + 1;
            val_68 = val_68 + 16;
            if(val_69 < (X22 + 258))
            {
                goto label_113;
            }
            
            label_111:
            val_61 = 2;
            val_64 = X22;
            goto label_114;
            label_112:
            var val_70 = val_68;
            val_70 = val_70 + 2;
            val_71 = val_71 + val_70;
            val_64 = val_71 + 272;
            label_114:
            val_72 = val_72 - X22;
            if(val_72 < 1)
            {
                goto label_115;
            }
            
            var val_76 = X22;
            if((X22 + 258) == 0)
            {
                goto label_118;
            }
            
            var val_73 = X22 + 152;
            var val_74 = 0;
            val_73 = val_73 + 8;
            label_120:
            if(((X22 + 152 + 8) + -8) == null)
            {
                goto label_119;
            }
            
            val_74 = val_74 + 1;
            val_73 = val_73 + 16;
            if(val_74 < (X22 + 258))
            {
                goto label_120;
            }
            
            label_118:
            val_65 = 4;
            val_66 = X22;
            goto label_121;
            label_115:
            val_67 = val_56;
            goto label_122;
            label_119:
            var val_75 = val_73;
            val_75 = val_75 + 4;
            val_76 = val_76 + val_75;
            val_66 = val_76 + 272;
            label_121:
            val_68 = mem[((X22 + ((X22 + 152 + 8) + 4)) + 272) + 8];
            val_68 = ((X22 + ((X22 + 152 + 8) + 4)) + 272) + 8;
            val_67 = 1;
            label_122:
            var val_81 = (val_25 - X22) + 56.CurrentValue;
            var val_80 = X22;
            if((X22 + 258) == 0)
            {
                goto label_128;
            }
            
            var val_77 = X22 + 152;
            var val_78 = 0;
            val_77 = val_77 + 8;
            label_130:
            if(((X22 + 152 + 8) + -8) == null)
            {
                goto label_129;
            }
            
            val_78 = val_78 + 1;
            val_77 = val_77 + 16;
            if(val_78 < (X22 + 258))
            {
                goto label_130;
            }
            
            label_128:
            val_68 = 1;
            val_69 = X22;
            goto label_131;
            label_129:
            var val_79 = val_77;
            val_79 = val_79 + 1;
            val_80 = val_80 + val_79;
            val_69 = val_80 + 272;
            label_131:
            val_81 = val_81 - X22;
            if(val_81 < 1)
            {
                goto label_139;
            }
            
            var val_82 = 0;
            val_82 = val_82 + 1;
            val_68 = 3;
            val_70 = val_6.InitializationCallback;
            goto label_139;
            label_150:
            val_6.Dispose();
            if((val_67 & 1) == 0)
            {
                    return;
            }
            
            TzarGames.GameFramework.GameManager val_28 = TzarGames.GameFramework.GameManager.Instance;
            if(val_28 != null)
            {
                    val_44 = 1152921504862969856;
                val_71 = null;
                val_71 = null;
                val_28 = (((TzarGames.GameFramework.GameManager.__il2cppRuntimeField_typeHierarchy + (TzarGames.Endless.EndlessLobbyGameManager.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_71) ? (val_28) : 0;
            }
            
            0.SaveGameWithPlayerData();
            this.UpdateUI();
            return;
            label_51:
            var val_83 = 0;
            val_83 = val_83 + 1;
            val_72 = val_13;
            string val_30 = 0 + "Failed to upgrade common for skill ";
            UnityEngine.Debug.LogError(message:  0);
            goto label_161;
            label_74:
            string val_32 = 0 + "Failed to upgrade cooldown for skill ";
            UnityEngine.Debug.LogError(message:  0);
            label_161:
            val_6.Dispose();
        }
        protected override void OnPlayerOwnerSet(TzarGames.GameFramework.Player owner)
        {
            this.OnPlayerOwnerSet(owner:  owner);
            this.UpdateUI();
        }
        protected override void Awake()
        {
            this.Awake();
            this.skillUpgradeUiPool = new TzarGames.Common.Pool<TzarGames.Endless.UI.SkillUpgradeUI>(createObjectCallback:  new Pool.CreateObjectDeleagate<TzarGames.Endless.UI.SkillUpgradeUI>(object:  this, method:  TzarGames.Endless.UI.SkillUpgradeUI TzarGames.Endless.UI.XpPointManagementUI::createSkillUpgradeUI()), maxCount:  2147483647);
            CreateObjects(count:  10);
        }
        public override void NotifyShown()
        {
            var val_21;
            var val_57;
            var val_58;
            var val_59;
            int val_60;
            var val_61;
            var val_62;
            this.NotifyShown();
            if(this.isInitialized != true)
            {
                    this.registerUpgrade(ui:  this.damageUpgradePointsUI, upgrade:  this.playerCharacter.DamageUpgrade);
                this.registerUpgrade(ui:  this.defenceUpgradePointsUI, upgrade:  this.playerCharacter.DefenceUpgrade);
                this.registerUpgrade(ui:  this.speedUpgradePointsUI, upgrade:  this.playerCharacter.SpeedUpgrade);
                this.registerUpgrade(ui:  this.attackSpeedUpgradePointsUI, upgrade:  this.playerCharacter.AttackSpeedUpgrade);
                this.registerUpgrade(ui:  this.hpUpgradePointsUI, upgrade:  this.playerCharacter.HitPointsUpgrade);
                this.registerUpgrade(ui:  this.hpRegenUpgradePointsUI, upgrade:  this.playerCharacter.HitPointsRegenUpgrade);
                this.registerUpgrade(ui:  this.critChanceUpgradePointsUI, upgrade:  this.playerCharacter.CritChanceUpgrade);
                this.registerUpgrade(ui:  this.critMultiplierUpgradePointsUI, upgrade:  this.playerCharacter.CritMultiplierUpgrade);
                this.registerUpgrade(ui:  this.blockChanceUpgradePointsUI, upgrade:  this.playerCharacter.BlockChanceUpgrade);
                this.isInitialized = true;
            }
            
            List.Enumerator<T> val_19 = this.upgrades.GetEnumerator();
            label_21:
            if((0 & 1) == 0)
            {
                goto label_12;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_22 = val_21.InitializationCallback;
            if(val_22 != null)
            {
                
            }
            else
            {
                    val_57 = 7254272;
            }
            
            var val_57 = 0;
            val_57 = val_57 + 1;
            val_58 = val_22;
            val_57.CurrentValue = val_22;
            goto label_21;
            label_12:
            val_21.Dispose();
            this.ShowCharacteristics();
            List.Enumerator<T> val_25 = this.activeSkillUiList.GetEnumerator();
            label_29:
            if((0 & 1) == 0)
            {
                goto label_89;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_26 = val_21.InitializationCallback;
            val_26.transform.SetParent(parent:  TzarGames.Endless.UI.XpPointManagementUI.getSkillUiContainer());
            bool val_28 = this.skillUpgradeUiPool.Set(pooledObject:  val_26);
            goto label_29;
            label_89:
            val_21.Dispose();
            this.activeSkillUiList.Clear();
            if(0 != this.playerCharacter)
            {
                    this.skillUpgrades.Clear();
                int val_32 = this.playerCharacter.SkillInstanceCount;
                if(val_32 >= 1)
            {
                    do
            {
                TzarGames.TzarHero.Skills.CharacterSkill val_34 = this.playerCharacter.GetSkillInstanceAtIndex(index:  0);
                TzarGames.Endless.UI.SkillUpgradeUI val_35 = this.skillUpgradeUiPool.Get();
                if(val_35.gameObject.activeSelf != true)
            {
                    val_35.gameObject.SetActive(value:  true);
            }
            
                this.activeSkillUiList.Add(item:  val_35);
                val_35.icon.sprite = val_34.Icon;
                val_60 = this.playerCharacter.GetSkillUpgradeBySkillId(skillId:  val_34.Id);
                if(val_60 == null)
            {
                    val_60 = this.playerCharacter.CreateSkillUpgrade(skillId:  val_34.Id);
            }
            
                val_35.CommonCounter.MinValue = 0;
                val_35.CommonCounter.MaxValue = 10;
                var val_58 = 0;
                val_58 = val_58 + 1;
                val_61 = val_60;
                val_35.CommonCounter.CurrentValue = val_60;
                val_35.CooldownCounter.MinValue = 0;
                val_35.CooldownCounter.MaxValue = 10;
                var val_59 = 0;
                val_59 = val_59 + 1;
                val_62 = val_60;
                val_35.CooldownCounter.CurrentValue = val_60;
                if(null != 0)
            {
                    typeof(XpPointManagementUI.SkillUpgradeInfo).__il2cppRuntimeField_10 = val_35;
            }
            else
            {
                    mem[16] = val_35;
            }
            
                typeof(XpPointManagementUI.SkillUpgradeInfo).__il2cppRuntimeField_18 = val_60;
                this.skillUpgrades.Add(item:  new System.Object());
                val_35.transform.SetParent(parent:  this.skillContainer, worldPositionStays:  false);
                UnityEngine.Vector3 val_52 = UnityEngine.Vector3.one;
                val_35.transform.localScale = new UnityEngine.Vector3() {x = val_52.x, y = val_52.y, z = val_52.z};
                UnityEngine.Vector3 val_54 = UnityEngine.Vector3.one;
                val_35.transform.localPosition = new UnityEngine.Vector3() {x = val_54.x, y = val_54.y, z = val_54.z};
                UnityEngine.Quaternion val_56 = UnityEngine.Quaternion.identity;
                val_35.transform.localRotation = new UnityEngine.Quaternion() {x = val_56.x, y = val_56.y, z = val_56.z, w = val_56.w};
                val_59 = 0 + 1;
            }
            while(val_59 != val_32);
            
            }
            
            }
            
            this.UpdateUI();
        }
        public override void NotifyHidden()
        {
            var val_6;
            this.NotifyHidden();
            val_6 = 0;
            goto label_1;
            label_10:
            val_6 = 1;
            label_1:
            if(val_6 >= this.createdSkillUiList.Count)
            {
                    return;
            }
            
            TzarGames.Endless.UI.SkillUpgradeUI val_2 = this.createdSkillUiList.Item[1];
            if(val_2.gameObject.activeSelf == false)
            {
                goto label_10;
            }
            
            val_2.gameObject.SetActive(value:  false);
            goto label_10;
        }
        public void ShowCharacteristics()
        {
            this.skillsButton.interactable = true;
            this.characteristicsButton.interactable = false;
            this.blockChanceUpgradePointsUI.gameObject.SetActive(value:  this.playerCharacter.HasBlockChanceCharacteristic());
        }
        public void ShowSkills()
        {
            this.skillsButton.interactable = false;
            this.characteristicsButton.interactable = true;
        }
        public void UpdateUI()
        {
            float val_12;
            UnityEngine.UI.Button val_47;
            var val_49;
            var val_50;
            var val_52;
            var val_53;
            var val_54;
            var val_56;
            var val_57;
            var val_58;
            var val_59;
            var val_60;
            var val_62;
            var val_63;
            var val_64;
            var val_65;
            var val_66;
            var val_67;
            var val_69;
            var val_70;
            var val_71;
            val_47 = this;
            if(0 == this.playerCharacter)
            {
                    return;
            }
            
            int val_4 = this.getRequiredPoints();
            long val_6 = this.playerCharacter.AvailableUpgradePoints;
            long val_8 = val_6 - (val_4 << );
            string val_9 = System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
            this.currentPoints.text = val_9;
            List.Enumerator<T> val_10 = this.upgrades.GetEnumerator();
            label_38:
            if((0 & 1) == 0)
            {
                goto label_9;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_13 = val_12.InitializationCallback;
            val_9.EnableIncrement(enable:  (val_6 > (long)val_4) ? 1 : 0);
            if(val_13 != null)
            {
                
            }
            
            var val_46 = 0;
            val_46 = val_46 + 1;
            val_49 = val_8;
            val_50 = 0;
            val_9.MinValue = 2122191072;
            if(val_13 != null)
            {
                
            }
            
            int val_17 = val_8.Counter.CurrentValue;
            var val_47 = 0;
            val_47 = val_47 + 1;
            val_50 = 4;
            val_52 = val_9;
            val_53 = "+";
            if(val_12 <= 0f)
            {
                    val_54 = null;
                val_54 = null;
            }
            
            string val_19 = 0 + System.String.__il2cppRuntimeField_static_fields;
            if(val_13 != null)
            {
                    val_56 = val_13;
            }
            
            System.String.__il2cppRuntimeField_static_fields.Label = System.String.Format(format:  0, arg0:  val_13.TemplateText);
            goto label_38;
            label_116:
            List.Enumerator<T> val_22 = this.skillUpgrades.GetEnumerator();
            label_112:
            if((0 & 1) == 0)
            {
                goto label_117;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_23 = val_12.InitializationCallback;
            EnableIncrement(enable:  (val_6 > (long)val_4) ? 1 : 0);
            EnableIncrement(enable:  (val_6 > (long)val_4) ? 1 : 0);
            var val_48 = 0;
            val_48 = val_48 + 1;
            val_57 = val_19;
            TzarGames.Endless.UI.SkillUpgradeUI val_27 = val_19.createSkillUpgradeUI();
            MinValue = val_27;
            var val_49 = 0;
            val_49 = val_49 + 1;
            val_58 = val_27;
            val_27.Dispose();
            MinValue = val_27;
            var val_50 = 0;
            val_50 = val_50 + 1;
            val_59 = val_27;
            val_60 = 0;
            TzarGames.TzarHero.Skills.CharacterSkill val_31 = this.playerCharacter.GetSkillInstanceById(id:  val_27);
            if(val_23 != null)
            {
                
            }
            
            int val_32 = CurrentValue;
            var val_51 = 0;
            val_51 = val_51 + 1;
            val_60 = 9;
            val_62 = val_27;
            val_63 = mem[val_32 + 8];
            val_63 = val_32 + 8;
            if(val_31 != null)
            {
                    val_64 = "+";
                if((TzarGames.Endless.EndlessUtils.FloatToPercent(val:  val_12)) <= 0)
            {
                    val_65 = null;
                val_65 = null;
            }
            
                string val_35 = 0 + System.String.__il2cppRuntimeField_static_fields;
                val_63 = 0;
                text = System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
            }
            else
            {
                    if(val_31 != null)
            {
                    val_66 = null;
                var val_52 = 0;
                val_52 = val_52 + 1;
                val_67 = val_31;
                val_66 = null;
                val_63 = 0;
                text = val_31;
            }
            
            }
            
            if(val_23 != null)
            {
                
            }
            
            int val_39 = CurrentValue;
            var val_53 = 0;
            val_53 = val_53 + 1;
            val_63 = 10;
            val_69 = val_31;
            val_70 = "+";
            if((TzarGames.Endless.EndlessUtils.FloatToPercent(val:  val_12)) <= 0)
            {
                    val_71 = null;
                val_71 = null;
            }
            
            string val_42 = 0 + System.String.__il2cppRuntimeField_static_fields;
            text = System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
            goto label_112;
            label_117:
            val_12.Dispose();
            val_47 = this.confirmButton;
            val_47.interactable = (val_4 > 0) ? 1 : 0;
            return;
            label_9:
            val_12.Dispose();
            goto label_116;
        }
    
    }

}
