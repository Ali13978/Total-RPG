using UnityEngine;

namespace TzarGames.Endless
{
    [Serializable]
    public class Way
    {
        // Fields
        public string Name;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private System.Collections.Generic.List<TzarGames.Endless.Gate> gates;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.EndlessPlayerSpawnPoint spawnPoint;
        [UnityEngine.SerializeField]
        private TzarGames.Common.TriggerEventHandler finishTrigger;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Collections.Generic.List<TzarGames.Endless.WayChainObjectInfo> <Chain>k__BackingField;
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredBool isWayFinished;
        
        // Properties
        public System.Collections.Generic.List<TzarGames.Endless.WayChainObjectInfo> Chain { get; set; }
        public bool IsWayFinished { get; }
        public TzarGames.Endless.EndlessPlayerSpawnPoint PlayerSpawnPoint { get; }
        public TzarGames.Common.TriggerEventHandler FinishTrigger { get; }
        public System.Collections.Generic.List<TzarGames.Endless.Gate> Gates { get; }
        
        // Methods
        public Way()
        {
            this.Name = "Way";
            CodeStage.AntiCheat.ObscuredTypes.ObscuredBool val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  false);
            this.isWayFinished = val_1;
            mem[1152921511025447232] = val_1.inited;
            mem[1152921511025447233] = val_1.fakeValue;
            mem[1152921511025447234] = val_1.fakeValueActive;
        }
        public System.Collections.Generic.List<TzarGames.Endless.WayChainObjectInfo> get_Chain()
        {
            return (System.Collections.Generic.List<TzarGames.Endless.WayChainObjectInfo>)this.<Chain>k__BackingField;
        }
        private void set_Chain(System.Collections.Generic.List<TzarGames.Endless.WayChainObjectInfo> value)
        {
            this.<Chain>k__BackingField = value;
        }
        public bool get_IsWayFinished()
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {inited = this.isWayFinished, fakeValue = this.isWayFinished, fakeValueActive = this.isWayFinished});
        }
        public TzarGames.Endless.EndlessPlayerSpawnPoint get_PlayerSpawnPoint()
        {
            return (TzarGames.Endless.EndlessPlayerSpawnPoint)this.spawnPoint;
        }
        public TzarGames.Common.TriggerEventHandler get_FinishTrigger()
        {
            return (TzarGames.Common.TriggerEventHandler)this.finishTrigger;
        }
        public System.Collections.Generic.List<TzarGames.Endless.Gate> get_Gates()
        {
            return (System.Collections.Generic.List<TzarGames.Endless.Gate>)this.gates;
        }
        private System.Collections.Generic.Dictionary<TzarGames.Endless.EndlessSpawner, System.Collections.Generic.List<TzarGames.Endless.Gate>> collectRoomsFromGates(System.Collections.Generic.List<TzarGames.Endless.Gate> gates)
        {
            var val_4;
            List.Enumerator<T> val_2 = gates.GetEnumerator();
            label_31:
            if((0 & 1) == 0)
            {
                goto label_34;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_5 = val_4.InitializationCallback;
            if(0 != val_5.FirstRoom)
            {
                    if((ContainsKey(key:  val_5.FirstRoom)) != true)
            {
                    System.Collections.Generic.List<TzarGames.Endless.Gate> val_12 = new System.Collections.Generic.List<TzarGames.Endless.Gate>();
                Add(key:  val_5.FirstRoom, value:  null);
            }
            
                System.Collections.Generic.List<TzarGames.Endless.Gate> val_14 = Item[val_5.FirstRoom];
                if((val_14.Contains(item:  val_5)) != true)
            {
                    val_14.Add(item:  val_5);
            }
            
            }
            
            if(0 == val_5.SecondRoom)
            {
                goto label_31;
            }
            
            if((ContainsKey(key:  val_5.SecondRoom)) != true)
            {
                    System.Collections.Generic.List<TzarGames.Endless.Gate> val_23 = new System.Collections.Generic.List<TzarGames.Endless.Gate>();
                Add(key:  val_5.SecondRoom, value:  null);
            }
            
            System.Collections.Generic.List<TzarGames.Endless.Gate> val_25 = Item[val_5.SecondRoom];
            if((val_25.Contains(item:  val_5)) == true)
            {
                goto label_31;
            }
            
            val_25.Add(item:  val_5);
            goto label_31;
            label_34:
            val_4.Dispose();
            if((0 & 1) != 0)
            {
                    return (System.Collections.Generic.Dictionary<TzarGames.Endless.EndlessSpawner, System.Collections.Generic.List<TzarGames.Endless.Gate>>)new System.Collections.Generic.Dictionary<TzarGames.Endless.EndlessSpawner, System.Collections.Generic.List<TzarGames.Endless.Gate>>();
            }
            
            if(null == null)
            {
                    return (System.Collections.Generic.Dictionary<TzarGames.Endless.EndlessSpawner, System.Collections.Generic.List<TzarGames.Endless.Gate>>)new System.Collections.Generic.Dictionary<TzarGames.Endless.EndlessSpawner, System.Collections.Generic.List<TzarGames.Endless.Gate>>();
            }
            
            return (System.Collections.Generic.Dictionary<TzarGames.Endless.EndlessSpawner, System.Collections.Generic.List<TzarGames.Endless.Gate>>)new System.Collections.Generic.Dictionary<TzarGames.Endless.EndlessSpawner, System.Collections.Generic.List<TzarGames.Endless.Gate>>();
        }
        public void Activate()
        {
            TzarGames.Endless.ChainObjectType val_10;
            var val_92;
            UnityEngine.Object val_93;
            var val_94;
            UnityEngine.Object val_96;
            UnityEngine.Object val_98;
            var val_100;
            string val_1 = 0 + "Activating way: "("Activating way: ");
            UnityEngine.Debug.Log(message:  0);
            this.finishTrigger.gameObject.SetActive(value:  false);
            System.Collections.Generic.List<TzarGames.Endless.WayChainObjectInfo> val_3 = new System.Collections.Generic.List<TzarGames.Endless.WayChainObjectInfo>();
            this.<Chain>k__BackingField = val_3;
            System.Collections.Generic.List<TzarGames.Endless.Gate> val_6 = new System.Collections.Generic.List<TzarGames.Endless.Gate>(collection:  UnityEngine.Object.FindObjectsOfType<UnityEngine.Component>());
            Dictionary.Enumerator<TKey, TValue> val_8 = val_6.collectRoomsFromGates(gates:  val_6).GetEnumerator();
            label_18:
            if((0 & 1) == 0)
            {
                goto label_186;
            }
            
            object val_11 = new System.Object();
            UnityEngine.Playables.PlayableHandle val_12 = val_10.GetHandle();
            if(null != 0)
            {
                    val_92 = null;
                typeof(Way.<Activate>c__AnonStorey0).__il2cppRuntimeField_10 = val_12.m_Handle;
                Way.<Activate>c__AnonStorey0.__il2cppRuntimeField_name.__il2cppRuntimeField_8 = val_12.m_Version;
            }
            else
            {
                    mem[16] = val_12.m_Handle;
                mem[24] = val_12.m_Version;
                val_92 = 16;
            }
            
            if((val_3.collectRoomsFromGates(gates:  this.gates).ContainsKey(key:  mem[16].InitializationCallback)) == true)
            {
                goto label_18;
            }
            
            UnityEngine.Events.UnityAction val_18 = new UnityEngine.Events.UnityAction(object:  null, method:  System.Void Way.<Activate>c__AnonStorey0::<>m__0());
            mem[16].InitializationCallback.OnAllObjectsDestroyed.AddListener(call:  null);
            goto label_18;
            label_186:
            val_10.Dispose();
            val_93 = 0;
            val_94 = 0;
            if(((0 & 1) != 0) || (null == null))
            {
                goto label_21;
            }
            
            val_94 = 0;
            val_93 = 0;
            goto label_21;
            label_144:
            val_94 = 1;
            label_21:
            if(val_94 >= this.gates.Count)
            {
                goto label_23;
            }
            
            object val_20 = new System.Object();
            typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_20 = this;
            typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_10 = 0;
            typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_18 = this.gates.Item[1];
            if(val_94 >= (this.gates.Count - 1))
            {
                goto label_27;
            }
            
            TzarGames.Endless.Gate val_25 = this.gates.Item[val_94 + 1];
            if(null == 0)
            {
                goto label_29;
            }
            
            typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_10 = val_25;
            goto label_30;
            label_27:
            if(0 == (typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_18.FirstRoom))
            {
                    TzarGames.Endless.EndlessSpawner val_28 = typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_18.SecondRoom;
            }
            
            val_96 = typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_18.FirstRoom;
            goto label_39;
            label_29:
            typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_10 = val_25;
            label_30:
            TzarGames.Endless.EndlessSpawner val_31 = typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_10.FirstRoom;
            if(0 == (typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_18.FirstRoom))
            {
                goto label_44;
            }
            
            TzarGames.Endless.EndlessSpawner val_35 = typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_10.SecondRoom;
            if(0 != (typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_18.FirstRoom))
            {
                goto label_50;
            }
            
            label_44:
            if(0 == val_93)
            {
                goto label_53;
            }
            
            TzarGames.Endless.EndlessSpawner val_38 = typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_18.FirstRoom;
            if(0 == val_93)
            {
                goto label_58;
            }
            
            label_53:
            if((this.isRoomAlreadyInChain(room:  typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_18.FirstRoom)) == false)
            {
                goto label_61;
            }
            
            label_58:
            TzarGames.Endless.EndlessSpawner val_43 = typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_18.FirstRoom;
            string val_44 = 0 + "Returning to room: "("Returning to room: ");
            UnityEngine.Debug.Log(message:  0);
            label_93:
            TzarGames.Endless.EndlessSpawner val_45 = typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_18.SecondRoom;
            goto label_70;
            label_50:
            TzarGames.Endless.EndlessSpawner val_47 = typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_10.FirstRoom;
            if(0 == (typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_18.SecondRoom))
            {
                goto label_76;
            }
            
            TzarGames.Endless.EndlessSpawner val_51 = typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_10.SecondRoom;
            if(0 != (typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_18.SecondRoom))
            {
                goto label_190;
            }
            
            label_76:
            if(0 == val_93)
            {
                goto label_85;
            }
            
            TzarGames.Endless.EndlessSpawner val_54 = typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_18.SecondRoom;
            if(0 == val_93)
            {
                goto label_90;
            }
            
            label_85:
            if((this.isRoomAlreadyInChain(room:  typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_18.SecondRoom)) == false)
            {
                goto label_93;
            }
            
            label_90:
            TzarGames.Endless.EndlessSpawner val_59 = typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_18.SecondRoom;
            string val_60 = 0 + "Returning to room: "("Returning to room: ");
            UnityEngine.Debug.Log(message:  0);
            label_61:
            label_70:
            val_96 = typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_18.FirstRoom;
            if(0 == val_93)
            {
                goto label_104;
            }
            
            label_39:
            val_98 = val_93;
            goto label_105;
            label_104:
            TzarGames.Endless.EndlessSpawner val_64 = typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_18.FirstRoom;
            if(0 == val_96)
            {
                    TzarGames.Endless.EndlessSpawner val_66 = typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_18.SecondRoom;
            }
            
            val_98 = typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_18.FirstRoom;
            val_94 = val_94;
            label_105:
            if(0 == val_98)
            {
                goto label_116;
            }
            
            typeof(TzarGames.Endless.WayChainObjectInfo).__il2cppRuntimeField_10 = val_98;
            typeof(TzarGames.Endless.WayChainObjectInfo).__il2cppRuntimeField_18 = 1;
            this.<Chain>k__BackingField.Add(item:  new System.Object());
            typeof(TzarGames.Endless.WayChainObjectInfo).__il2cppRuntimeField_10 = typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_18;
            typeof(TzarGames.Endless.WayChainObjectInfo).__il2cppRuntimeField_18 = 0;
            this.<Chain>k__BackingField.Add(item:  new System.Object());
            if(0 != (((this.isRoomAlreadyInChain(room:  val_96)) != true) ? (val_96) : 0))
            {
                    if(0 != (typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_10))
            {
                    string val_76 = val_98.name;
                string val_77 = 0 + "Gate " + typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_10.name(typeof(Way.<Activate>c__AnonStorey1).__il2cppRuntimeField_10.name) + " will be unblocked by ";
                UnityEngine.Debug.Log(message:  0);
                val_98.OnAllObjectsDestroyed.AddListener(call:  new UnityEngine.Events.UnityAction(object:  val_20, method:  System.Void Way.<Activate>c__AnonStorey1::<>m__0()));
            }
            
            }
            
            val_98.OnAllObjectsDestroyed.AddListener(call:  new UnityEngine.Events.UnityAction(object:  val_20, method:  System.Void Way.<Activate>c__AnonStorey1::<>m__1()));
            if(val_94 != (this.gates.Count - 1))
            {
                goto label_144;
            }
            
            typeof(TzarGames.Endless.WayChainObjectInfo).__il2cppRuntimeField_10 = val_96;
            typeof(TzarGames.Endless.WayChainObjectInfo).__il2cppRuntimeField_18 = 1;
            this.<Chain>k__BackingField.Add(item:  new System.Object());
            typeof(TzarGames.Endless.WayChainObjectInfo).__il2cppRuntimeField_10 = this.finishTrigger;
            typeof(TzarGames.Endless.WayChainObjectInfo).__il2cppRuntimeField_18 = 2;
            this.<Chain>k__BackingField.Add(item:  new System.Object());
            val_96.OnAllObjectsDestroyed.AddListener(call:  new UnityEngine.Events.UnityAction(object:  val_20, method:  System.Void Way.<Activate>c__AnonStorey1::<>m__2()));
            goto label_144;
            label_116:
            label_190:
            string val_88 = 0 + "Current room is null for gate ";
            UnityEngine.Debug.LogError(message:  0);
            label_23:
            UnityEngine.Debug.Log(message:  0);
            val_100 = 0;
            goto label_152;
            label_183:
            UnityEngine.Debug.Log(message:  0);
            val_100 = 1;
            label_152:
            if(val_100 >= (this.<Chain>k__BackingField.Count))
            {
                goto label_154;
            }
            
            TzarGames.Endless.WayChainObjectInfo val_90 = this.<Chain>k__BackingField.Item[1];
            typeof(System.Object[]).__il2cppRuntimeField_20 = ;
            typeof(System.Object[]).__il2cppRuntimeField_28 = " ";
            typeof(System.Object[]).__il2cppRuntimeField_30 = val_90.ChainObject.name;
            typeof(System.Object[]).__il2cppRuntimeField_38 = " (";
            val_10 = val_90.ObjectType;
            typeof(System.Object[]).__il2cppRuntimeField_40 = val_10;
            typeof(System.Object[]).__il2cppRuntimeField_48 = ")";
            string val_92 = +0;
            goto label_183;
            label_154:
            UnityEngine.Debug.Log(message:  0);
        }
        private bool isRoomAlreadyInChain(UnityEngine.Object room)
        {
            var val_5;
            var val_6;
            val_5 = 0;
            goto label_1;
            label_9:
            val_5 = 1;
            label_1:
            if(val_5 >= (this.<Chain>k__BackingField.Count))
            {
                goto label_3;
            }
            
            TzarGames.Endless.WayChainObjectInfo val_2 = this.<Chain>k__BackingField.Item[1];
            if((val_2.ObjectType != 1) || (0 != val_2.ChainObject))
            {
                goto label_9;
            }
            
            val_6 = 1;
            return (bool)val_6;
            label_3:
            val_6 = 0;
            return (bool)val_6;
        }
    
    }

}
