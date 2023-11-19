using UnityEngine;

namespace UnityEngine.AI
{
    [UnityEngine.ExecuteInEditMode]
    [UnityEngine.DefaultExecutionOrder]
    [UnityEngine.AddComponentMenu]
    [UnityEngine.HelpURLAttribute]
    public class NavMeshSurface : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private int m_AgentTypeID;
        [UnityEngine.SerializeField]
        private UnityEngine.AI.CollectObjects m_CollectObjects;
        [UnityEngine.SerializeField]
        private UnityEngine.Vector3 m_Size;
        [UnityEngine.SerializeField]
        private UnityEngine.Vector3 m_Center;
        [UnityEngine.SerializeField]
        private UnityEngine.LayerMask m_LayerMask;
        [UnityEngine.SerializeField]
        private UnityEngine.AI.NavMeshCollectGeometry m_UseGeometry;
        [UnityEngine.SerializeField]
        private int m_DefaultArea;
        [UnityEngine.SerializeField]
        private bool m_IgnoreNavMeshAgent;
        [UnityEngine.SerializeField]
        private bool m_IgnoreNavMeshObstacle;
        [UnityEngine.SerializeField]
        private bool m_OverrideTileSize;
        [UnityEngine.SerializeField]
        private int m_TileSize;
        [UnityEngine.SerializeField]
        private bool m_OverrideVoxelSize;
        [UnityEngine.SerializeField]
        private float m_VoxelSize;
        [UnityEngine.SerializeField]
        private bool m_BuildHeightMesh;
        [UnityEngine.Serialization.FormerlySerializedAsAttribute]
        [UnityEngine.SerializeField]
        private UnityEngine.AI.NavMeshData m_NavMeshData;
        private UnityEngine.AI.NavMeshDataInstance m_NavMeshDataInstance;
        private UnityEngine.Vector3 m_LastPosition;
        private UnityEngine.Quaternion m_LastRotation;
        private static readonly System.Collections.Generic.List<UnityEngine.AI.NavMeshSurface> s_NavMeshSurfaces;
        private static UnityEngine.AI.NavMesh.OnNavMeshPreUpdate <>f__mg$cache0;
        private static UnityEngine.AI.NavMesh.OnNavMeshPreUpdate <>f__mg$cache1;
        private static System.Predicate<UnityEngine.AI.NavMeshModifierVolume> <>f__am$cache0;
        private static System.Predicate<UnityEngine.AI.NavMeshModifier> <>f__am$cache1;
        private static System.Predicate<UnityEngine.AI.NavMeshBuildSource> <>f__am$cache2;
        private static System.Predicate<UnityEngine.AI.NavMeshBuildSource> <>f__am$cache3;
        
        // Properties
        public int agentTypeID { get; set; }
        public UnityEngine.AI.CollectObjects collectObjects { get; set; }
        public UnityEngine.Vector3 size { get; set; }
        public UnityEngine.Vector3 center { get; set; }
        public UnityEngine.LayerMask layerMask { get; set; }
        public UnityEngine.AI.NavMeshCollectGeometry useGeometry { get; set; }
        public int defaultArea { get; set; }
        public bool ignoreNavMeshAgent { get; set; }
        public bool ignoreNavMeshObstacle { get; set; }
        public bool overrideTileSize { get; set; }
        public int tileSize { get; set; }
        public bool overrideVoxelSize { get; set; }
        public float voxelSize { get; set; }
        public bool buildHeightMesh { get; set; }
        public UnityEngine.AI.NavMeshData navMeshData { get; set; }
        public static System.Collections.Generic.List<UnityEngine.AI.NavMeshSurface> activeSurfaces { get; }
        
        // Methods
        public NavMeshSurface()
        {
            this.m_Size = 0;
            mem[1152921512338893604] = 0;
            mem[1152921512338893608] = 0;
            this.m_Center = 0;
            mem[1152921512338893616] = 0;
            mem[1152921512338893620] = 0;
            UnityEngine.LayerMask val_1 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
            this.m_LayerMask = val_1;
            this.m_IgnoreNavMeshAgent = true;
            this.m_IgnoreNavMeshObstacle = true;
            this.m_TileSize = 256;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.m_LastPosition = val_2;
            mem[1152921512338893672] = val_2.y;
            mem[1152921512338893676] = val_2.z;
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
            this.m_LastRotation = val_3;
            mem[1152921512338893684] = val_3.y;
            mem[1152921512338893688] = val_3.z;
            mem[1152921512338893692] = val_3.w;
        }
        public int get_agentTypeID()
        {
            return (int)this.m_AgentTypeID;
        }
        public void set_agentTypeID(int value)
        {
            this.m_AgentTypeID = value;
        }
        public UnityEngine.AI.CollectObjects get_collectObjects()
        {
            return (UnityEngine.AI.CollectObjects)this.m_CollectObjects;
        }
        public void set_collectObjects(UnityEngine.AI.CollectObjects value)
        {
            this.m_CollectObjects = value;
        }
        public UnityEngine.Vector3 get_size()
        {
            return new UnityEngine.Vector3() {x = this.m_Size};
        }
        public void set_size(UnityEngine.Vector3 value)
        {
            this.m_Size = value;
            mem[1152921512339581988] = value.y;
            mem[1152921512339581992] = value.z;
        }
        public UnityEngine.Vector3 get_center()
        {
            return new UnityEngine.Vector3() {x = this.m_Center};
        }
        public void set_center(UnityEngine.Vector3 value)
        {
            this.m_Center = value;
            mem[1152921512339806000] = value.y;
            mem[1152921512339806004] = value.z;
        }
        public UnityEngine.LayerMask get_layerMask()
        {
            return (UnityEngine.LayerMask)this.m_LayerMask;
        }
        public void set_layerMask(UnityEngine.LayerMask value)
        {
            this.m_LayerMask = value;
        }
        public UnityEngine.AI.NavMeshCollectGeometry get_useGeometry()
        {
            return (UnityEngine.AI.NavMeshCollectGeometry)this.m_UseGeometry;
        }
        public void set_useGeometry(UnityEngine.AI.NavMeshCollectGeometry value)
        {
            this.m_UseGeometry = value;
        }
        public int get_defaultArea()
        {
            return (int)this.m_DefaultArea;
        }
        public void set_defaultArea(int value)
        {
            this.m_DefaultArea = value;
        }
        public bool get_ignoreNavMeshAgent()
        {
            return (bool)this.m_IgnoreNavMeshAgent;
        }
        public void set_ignoreNavMeshAgent(bool value)
        {
            this.m_IgnoreNavMeshAgent = value;
        }
        public bool get_ignoreNavMeshObstacle()
        {
            return (bool)this.m_IgnoreNavMeshObstacle;
        }
        public void set_ignoreNavMeshObstacle(bool value)
        {
            this.m_IgnoreNavMeshObstacle = value;
        }
        public bool get_overrideTileSize()
        {
            return (bool)this.m_OverrideTileSize;
        }
        public void set_overrideTileSize(bool value)
        {
            this.m_OverrideTileSize = value;
        }
        public int get_tileSize()
        {
            return (int)this.m_TileSize;
        }
        public void set_tileSize(int value)
        {
            this.m_TileSize = value;
        }
        public bool get_overrideVoxelSize()
        {
            return (bool)this.m_OverrideVoxelSize;
        }
        public void set_overrideVoxelSize(bool value)
        {
            this.m_OverrideVoxelSize = value;
        }
        public float get_voxelSize()
        {
            return (float)this.m_VoxelSize;
        }
        public void set_voxelSize(float value)
        {
            this.m_VoxelSize = value;
        }
        public bool get_buildHeightMesh()
        {
            return (bool)this.m_BuildHeightMesh;
        }
        public void set_buildHeightMesh(bool value)
        {
            this.m_BuildHeightMesh = value;
        }
        public UnityEngine.AI.NavMeshData get_navMeshData()
        {
            return (UnityEngine.AI.NavMeshData)this.m_NavMeshData;
        }
        public void set_navMeshData(UnityEngine.AI.NavMeshData value)
        {
            this.m_NavMeshData = value;
        }
        public static System.Collections.Generic.List<UnityEngine.AI.NavMeshSurface> get_activeSurfaces()
        {
            null = null;
            return (System.Collections.Generic.List<UnityEngine.AI.NavMeshSurface>)UnityEngine.AI.NavMeshSurface.s_NavMeshSurfaces;
        }
        private void OnEnable()
        {
            UnityEngine.AI.NavMeshSurface.Register(surface:  null);
            this.AddData();
        }
        private void OnDisable()
        {
            this.m_NavMeshDataInstance = 0;
            UnityEngine.AI.NavMeshSurface.Unregister(surface:  null);
        }
        public void AddData()
        {
            UnityEngine.AI.NavMeshData val_13;
            if(((this.m_NavMeshDataInstance & 1) & 1) != 0)
            {
                    return;
            }
            
            val_13 = this.m_NavMeshData;
            if(0 != val_13)
            {
                    val_13 = this.m_NavMeshData;
                UnityEngine.Vector3 val_5 = this.transform.position;
                UnityEngine.Quaternion val_7 = this.transform.rotation;
                UnityEngine.AI.NavMeshDataInstance val_8 = UnityEngine.AI.NavMesh.AddNavMeshData(navMeshData:  0, position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, rotation:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w});
                this.m_NavMeshDataInstance = val_8;
            }
            
            UnityEngine.Vector3 val_10 = this.transform.position;
            this.m_LastPosition = val_10;
            mem[1152921512342775400] = val_10.y;
            mem[1152921512342775404] = val_10.z;
            UnityEngine.Quaternion val_12 = this.transform.rotation;
            this.m_LastRotation = val_12;
            mem[1152921512342775412] = val_12.y;
            mem[1152921512342775416] = val_12.z;
            mem[1152921512342775420] = val_12.w;
        }
        public void RemoveData()
        {
            this.m_NavMeshDataInstance = 0;
        }
        public UnityEngine.AI.NavMeshBuildSettings GetBuildSettings()
        {
            int val_2;
            int val_3;
            float val_4;
            int val_5;
            UnityEngine.Object val_8;
            UnityEngine.AI.NavMeshBuildSettings val_0;
            UnityEngine.AI.NavMeshBuildSettings val_1 = UnityEngine.AI.NavMesh.GetSettingsByID(agentTypeID:  0);
            if(val_5.Status == 1)
            {
                    val_5 = this.m_AgentTypeID;
                val_8 = 0 + "No build settings for agent type ID ";
                UnityEngine.Debug.LogWarning(message:  0, context:  val_8);
                val_5.nodeType = this.m_AgentTypeID;
            }
            
            if(this.m_OverrideTileSize != false)
            {
                    val_5.dimension = this.m_TileSize;
            }
            
            if(this.m_OverrideVoxelSize != false)
            {
                    val_5.startValue = this.m_VoxelSize;
            }
            
            val_0.m_AccuratePlacement = val_2;
            val_0.m_AgentClimb = val_4;
            val_0.m_OverrideVoxelSize = val_3;
            val_0.m_AgentTypeID = val_5;
            return val_0;
        }
        public void BuildNavMesh()
        {
            System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> val_5;
            string val_19;
            System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> val_1 = this.CollectSources();
            UnityEngine.Vector3 val_2 = UnityEngine.AI.NavMeshSurface.Abs(v:  new UnityEngine.Vector3() {x = this.m_Size, y = V12.16B, z = V11.16B});
            UnityEngine.AI.CollectObjects val_18 = this.m_CollectObjects;
            val_18 = val_18 | 2;
            if(val_18 == 2)
            {
                    UnityEngine.Bounds val_3 = this.CalculateWorldBounds(sources:  val_1);
            }
            
            UnityEngine.AI.NavMeshBuildSettings val_6 = this.GetBuildSettings();
            UnityEngine.Vector3 val_8 = this.transform.position;
            val_19 = this.transform;
            UnityEngine.Quaternion val_10 = val_19.rotation;
            UnityEngine.AI.NavMeshData val_13 = UnityEngine.AI.NavMeshBuilder.BuildNavMeshData(buildSettings:  new UnityEngine.AI.NavMeshBuildSettings() {m_Debug = new UnityEngine.AI.NavMeshBuildDebugSettings()}, sources:  val_5, localBounds:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = val_1, y = val_1, z = val_1}, m_Extents = new UnityEngine.Vector3() {x = val_1, y = val_1, z = val_1}}, position:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, rotation:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w});
            if(0 == val_13)
            {
                    return;
            }
            
            val_19 = this.gameObject.name;
            val_13.name = val_19;
            this.m_NavMeshDataInstance = 0;
            this.m_NavMeshData = val_13;
            if(this.isActiveAndEnabled == false)
            {
                    return;
            }
            
            this.AddData();
        }
        public UnityEngine.AsyncOperation UpdateNavMesh(UnityEngine.AI.NavMeshData data)
        {
            System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> val_1 = this.CollectSources();
            UnityEngine.Vector3 val_2 = UnityEngine.AI.NavMeshSurface.Abs(v:  new UnityEngine.Vector3() {x = this.m_Size, y = V12.16B, z = V11.16B});
            UnityEngine.AI.CollectObjects val_8 = this.m_CollectObjects;
            val_8 = val_8 | 2;
            if(val_8 == 2)
            {
                    UnityEngine.Bounds val_3 = this.CalculateWorldBounds(sources:  val_1);
            }
            
            UnityEngine.AI.NavMeshBuildSettings val_6 = this.GetBuildSettings();
            return (UnityEngine.AsyncOperation)UnityEngine.AI.NavMeshBuilder.UpdateNavMeshDataAsync(data:  0, buildSettings:  new UnityEngine.AI.NavMeshBuildSettings() {m_AgentTypeID = data, m_AgentRadius = data, m_AgentHeight = data, m_AgentSlope = data, m_AgentClimb = data, m_LedgeDropHeight = data, m_MaxJumpAcrossDistance = data, m_MinRegionArea = data, m_OverrideVoxelSize = data, m_VoxelSize = data, m_OverrideTileSize = data, m_TileSize = data, m_AccuratePlacement = data, m_Debug = new UnityEngine.AI.NavMeshBuildDebugSettings() {m_Flags = data}}, sources:  -853406624, localBounds:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = val_1, y = val_1, z = val_1}, m_Extents = new UnityEngine.Vector3() {x = val_1, y = val_1, z = val_1}});
        }
        private static void Register(UnityEngine.AI.NavMeshSurface surface)
        {
            var val_7;
            var val_8;
            var val_9;
            OnNavMeshPreUpdate val_10;
            var val_11;
            var val_12;
            val_7 = null;
            val_7 = null;
            if(UnityEngine.AI.NavMeshSurface.s_NavMeshSurfaces.Count == 0)
            {
                    val_8 = null;
                val_8 = null;
                if((UnityEngine.AI.NavMeshSurface.<>f__mg$cache0) == null)
            {
                    val_9 = null;
                val_9 = null;
                UnityEngine.AI.NavMeshSurface.<>f__mg$cache0 = new NavMesh.OnNavMeshPreUpdate(object:  0, method:  static System.Void UnityEngine.AI.NavMeshSurface::UpdateActive());
                val_8 = null;
            }
            
                val_8 = null;
                System.Delegate val_3 = System.Delegate.Combine(a:  0, b:  UnityEngine.AI.NavMesh.onPreUpdate);
                val_10 = 0;
                if(val_3 != null)
            {
                    val_10 = val_3;
                if(null != null)
            {
                    val_10 = 0;
            }
            
            }
            
                UnityEngine.AI.NavMesh.onPreUpdate = val_10;
            }
            
            val_11 = null;
            val_11 = null;
            if((UnityEngine.AI.NavMeshSurface.s_NavMeshSurfaces.Contains(item:  X1)) == true)
            {
                    return;
            }
            
            val_12 = null;
            val_12 = null;
            UnityEngine.AI.NavMeshSurface.s_NavMeshSurfaces.Add(item:  X1);
        }
        private static void Unregister(UnityEngine.AI.NavMeshSurface surface)
        {
            var val_6;
            System.Collections.Generic.List<UnityEngine.AI.NavMeshSurface> val_7;
            var val_8;
            var val_9;
            OnNavMeshPreUpdate val_10;
            val_6 = null;
            val_6 = null;
            bool val_1 = UnityEngine.AI.NavMeshSurface.s_NavMeshSurfaces.Remove(item:  X1);
            val_7 = UnityEngine.AI.NavMeshSurface.s_NavMeshSurfaces;
            if(val_7.Count != 0)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            if((UnityEngine.AI.NavMeshSurface.<>f__mg$cache1) == null)
            {
                    val_9 = null;
                val_9 = null;
                UnityEngine.AI.NavMeshSurface.<>f__mg$cache1 = new NavMesh.OnNavMeshPreUpdate(object:  0, method:  static System.Void UnityEngine.AI.NavMeshSurface::UpdateActive());
                val_8 = null;
            }
            
            val_8 = null;
            System.Delegate val_4 = System.Delegate.Remove(source:  0, value:  UnityEngine.AI.NavMesh.onPreUpdate);
            val_10 = 0;
            if(val_4 != null)
            {
                    val_10 = val_4;
                if(null != null)
            {
                    val_10 = 0;
            }
            
            }
            
            UnityEngine.AI.NavMesh.onPreUpdate = val_10;
        }
        private static void UpdateActive()
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = 0;
            goto label_2;
            label_11:
            UpdateDataIfTransformChanged();
            val_3 = 1;
            label_2:
            val_4 = null;
            val_4 = null;
            if(val_3 >= UnityEngine.AI.NavMeshSurface.s_NavMeshSurfaces.Count)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            if(UnityEngine.AI.NavMeshSurface.s_NavMeshSurfaces.Item[1] != null)
            {
                goto label_11;
            }
            
            goto label_11;
        }
        private void AppendModifierVolumes(ref System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> sources)
        {
            var val_8;
            var val_27;
            var val_28;
            var val_29;
            if(this.m_CollectObjects == 2)
            {
                    System.Collections.Generic.List<UnityEngine.AI.NavMeshModifierVolume> val_2 = null;
                val_27 = val_2;
                val_2 = new System.Collections.Generic.List<UnityEngine.AI.NavMeshModifierVolume>(collection:  this.GetComponentsInChildren<UnityEngine.AI.NavMeshModifierVolume>());
                val_28 = null;
                val_28 = null;
                if((UnityEngine.AI.NavMeshSurface.<>f__am$cache0) == null)
            {
                    val_29 = null;
                val_29 = null;
                UnityEngine.AI.NavMeshSurface.<>f__am$cache0 = new System.Predicate<UnityEngine.AI.NavMeshModifierVolume>(object:  0, method:  static System.Boolean UnityEngine.AI.NavMeshSurface::<AppendModifierVolumes>m__0(UnityEngine.AI.NavMeshModifierVolume x));
                val_28 = null;
            }
            
                val_28 = null;
                int val_4 = RemoveAll(match:  UnityEngine.AI.NavMeshSurface.<>f__am$cache0);
            }
            else
            {
                    val_27 = UnityEngine.AI.NavMeshModifierVolume.activeModifiers;
            }
            
            List.Enumerator<T> val_6 = val_27.GetEnumerator();
            do
            {
                label_35:
                if((0 & 1) == 0)
            {
                goto label_38;
            }
            
                System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_9 = val_8.InitializationCallback;
                int val_13 = val_9.gameObject.layer & 31;
                val_13 = 1 << val_13;
                val_13 = val_13 & (UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask()));
            }
            while(val_13 == 0);
            
            if((val_9.AffectsAgentType(agentTypeID:  this.m_AgentTypeID)) == false)
            {
                goto label_35;
            }
            
            UnityEngine.Vector3 val_16 = val_9.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B});
            UnityEngine.Vector3 val_18 = val_9.transform.lossyScale;
            float val_27 = System.Math.Abs(val_18.x);
            val_27 = S12 * val_27;
            val_18.y = val_18.y * System.Math.Abs(val_18.y);
            val_18.z = val_18.z * System.Math.Abs(val_18.z);
            UnityEngine.Quaternion val_20 = val_9.transform.rotation;
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.one;
            UnityEngine.Matrix4x4 val_22 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, q:  new UnityEngine.Quaternion() {x = val_20.x, y = val_20.y, z = val_20.z, w = val_20.w}, s:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.z});
            sources.Add(item:  new UnityEngine.AI.NavMeshBuildSource() {m_Transform = new UnityEngine.Matrix4x4(), m_Size = new UnityEngine.Vector3()});
            goto label_35;
            label_38:
            val_8.Dispose();
            if((0 & 1) != 0)
            {
                    return;
            }
            
            if(sources._version == 0)
            {
                    return;
            }
        
        }
        private System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> CollectSources()
        {
            float val_9;
            float val_10;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            UnityEngine.AI.NavMeshCollectGeometry val_43;
            int val_44;
            UnityEngine.AI.NavMeshCollectGeometry val_45;
            UnityEngine.Transform val_46;
            int val_47;
            var val_48;
            var val_49;
            bool val_50;
            var val_51;
            var val_52;
            System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> val_1 = new System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource>();
            System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup> val_2 = new System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildMarkup>();
            if(this.m_CollectObjects == 2)
            {
                    System.Collections.Generic.List<UnityEngine.AI.NavMeshModifier> val_4 = null;
                val_39 = val_4;
                val_4 = new System.Collections.Generic.List<UnityEngine.AI.NavMeshModifier>(collection:  this.GetComponentsInChildren<UnityEngine.AI.NavMeshModifier>());
                val_40 = null;
                val_40 = null;
                if((UnityEngine.AI.NavMeshSurface.<>f__am$cache1) == null)
            {
                    val_41 = null;
                val_41 = null;
                UnityEngine.AI.NavMeshSurface.<>f__am$cache1 = new System.Predicate<UnityEngine.AI.NavMeshModifier>(object:  0, method:  static System.Boolean UnityEngine.AI.NavMeshSurface::<CollectSources>m__1(UnityEngine.AI.NavMeshModifier x));
                val_40 = null;
            }
            
                val_40 = null;
                int val_6 = RemoveAll(match:  UnityEngine.AI.NavMeshSurface.<>f__am$cache1);
            }
            else
            {
                    val_39 = UnityEngine.AI.NavMeshModifier.activeModifiers;
            }
            
            List.Enumerator<T> val_8 = val_39.GetEnumerator();
            do
            {
                label_23:
                if((0 & 1) == 0)
            {
                goto label_58;
            }
            
                System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_11 = val_10.InitializationCallback;
                int val_15 = val_11.gameObject.layer & 31;
                val_15 = 1 << val_15;
                val_15 = val_15 & (UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask()));
            }
            while(val_15 == 0);
            
            if((val_11.AffectsAgentType(agentTypeID:  this.m_AgentTypeID)) == false)
            {
                goto label_23;
            }
            
            UnityEngine.Transform val_17 = val_11.transform;
            Add(item:  new UnityEngine.AI.NavMeshBuildMarkup());
            goto label_23;
            label_58:
            val_10.Dispose();
            if(this.m_CollectObjects == 2)
            {
                goto label_26;
            }
            
            if(this.m_CollectObjects == 1)
            {
                goto label_27;
            }
            
            if(this.m_CollectObjects != 0)
            {
                goto label_30;
            }
            
            val_43 = this.m_UseGeometry;
            val_44 = this.m_DefaultArea;
            val_45 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask());
            val_46 = 0;
            val_47 = 0;
            goto label_29;
            label_26:
            val_43 = this.m_UseGeometry;
            val_44 = this.m_DefaultArea;
            val_45 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask());
            val_46 = 0;
            val_47 = this.transform;
            label_29:
            UnityEngine.AI.NavMeshBuilder.CollectSources(root:  val_46, includedLayerMask:  val_47, geometry:  val_45, defaultArea:  val_43, markups:  val_44, results:  val_2);
            goto label_30;
            label_27:
            UnityEngine.Vector3 val_22 = this.transform.position;
            UnityEngine.Quaternion val_24 = this.transform.rotation;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.one;
            UnityEngine.Matrix4x4 val_26 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, q:  new UnityEngine.Quaternion() {x = val_24.x, y = val_24.y, z = val_24.z, w = val_24.w}, s:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.z});
            UnityEngine.Bounds val_29 = UnityEngine.AI.NavMeshSurface.GetWorldBounds(mat:  new UnityEngine.Matrix4x4(), bounds:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = val_10, y = val_10, z = val_10}, m_Extents = new UnityEngine.Vector3() {x = val_10, y = val_9, z = val_9}});
            UnityEngine.AI.NavMeshBuilder.CollectSources(includedWorldBounds:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3(), m_Extents = new UnityEngine.Vector3()}, includedLayerMask:  -852507040, geometry:  UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask()), defaultArea:  this.m_UseGeometry, markups:  this.m_DefaultArea, results:  val_2);
            label_30:
            if((this.m_IgnoreNavMeshAgent & 255) != false)
            {
                    val_48 = null;
                val_48 = null;
                if((UnityEngine.AI.NavMeshSurface.<>f__am$cache2) == null)
            {
                    val_49 = null;
                val_49 = null;
                UnityEngine.AI.NavMeshSurface.<>f__am$cache2 = new System.Predicate<UnityEngine.AI.NavMeshBuildSource>(object:  0, method:  static System.Boolean UnityEngine.AI.NavMeshSurface::<CollectSources>m__2(UnityEngine.AI.NavMeshBuildSource x));
                val_48 = null;
            }
            
                val_48 = null;
                int val_35 = RemoveAll(match:  UnityEngine.AI.NavMeshSurface.<>f__am$cache2);
                val_50 = this.m_IgnoreNavMeshObstacle;
            }
            else
            {
                    val_50 = this.m_IgnoreNavMeshAgent >> 8;
            }
            
            if(val_50 != false)
            {
                    val_42 = 1152921504970371072;
                val_51 = null;
                val_51 = null;
                if((UnityEngine.AI.NavMeshSurface.<>f__am$cache3) == null)
            {
                    val_52 = null;
                val_52 = null;
                UnityEngine.AI.NavMeshSurface.<>f__am$cache3 = new System.Predicate<UnityEngine.AI.NavMeshBuildSource>(object:  0, method:  static System.Boolean UnityEngine.AI.NavMeshSurface::<CollectSources>m__3(UnityEngine.AI.NavMeshBuildSource x));
                val_51 = null;
            }
            
                val_51 = null;
                int val_37 = RemoveAll(match:  UnityEngine.AI.NavMeshSurface.<>f__am$cache3);
            }
            
            this.AppendModifierVolumes(sources: ref  val_1);
            return val_1;
        }
        private static UnityEngine.Vector3 Abs(UnityEngine.Vector3 v)
        {
            float val_1 = System.Math.Abs(v.x);
            float val_2 = System.Math.Abs(v.y);
            float val_3 = System.Math.Abs(v.z);
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        private static UnityEngine.Bounds GetWorldBounds(UnityEngine.Matrix4x4 mat, UnityEngine.Bounds bounds)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_2 = UnityEngine.AI.NavMeshSurface.Abs(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_4 = UnityEngine.AI.NavMeshSurface.Abs(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_6 = UnityEngine.AI.NavMeshSurface.Abs(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  val_6.x);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  val_7.y);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  val_9.z);
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            val_0.m_Center.z = 0f;
            val_0.m_Extents.x = 0f;
            val_0.m_Extents.y = 0f;
            val_0.m_Extents.z = 0f;
            val_0.m_Center.x = 0f;
            val_0.m_Center.y = 0f;
        }
        private UnityEngine.Bounds CalculateWorldBounds(System.Collections.Generic.List<UnityEngine.AI.NavMeshBuildSource> sources)
        {
            float val_11;
            float val_12;
            float val_13;
            float val_14;
            var val_16;
            float val_26;
            float val_27;
            float val_40;
            float val_41;
            float val_57;
            float val_58;
            var val_63;
            var val_64;
            var val_65;
            var val_66;
            var val_67;
            UnityEngine.Bounds val_0;
            UnityEngine.Vector3 val_2 = this.transform.position;
            UnityEngine.Quaternion val_4 = this.transform.rotation;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            UnityEngine.Matrix4x4 val_6 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, q:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, s:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.z});
            List.Enumerator<T> val_15 = sources.GetEnumerator();
            label_41:
            if((0 & 1) == 0)
            {
                goto label_8;
            }
            
            if((-851998632) >= 6)
            {
                goto label_41;
            }
            
            val_63 = mem[912778704];
            if(val_63 > 9)
            {
                goto label_10;
            }
            
            if(val_63 == 0)
            {
                goto label_41;
            }
            
            return val_0;
            label_10:
            if(val_63 == 12)
            {
                goto label_13;
            }
            
            if(val_63 == 11)
            {
                goto label_14;
            }
            
            if(val_63 != 10)
            {
                    return val_0;
            }
            
            if(==0)
            {
                goto label_16;
            }
            
            var val_17 = (val_16 == null) ? -851998632 : 0;
            goto label_17;
            label_13:
            UnityEngine.Matrix4x4 val_22 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4(), rhs:  new UnityEngine.Matrix4x4() {m00 = val_14, m10 = val_14, m20 = val_14, m30 = val_14, m01 = val_13, m11 = val_13, m21 = val_13, m31 = val_13, m02 = val_12, m12 = val_12, m22 = val_12, m32 = val_12, m03 = val_11, m13 = val_11, m23 = val_11, m33 = val_11});
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.zero;
            UnityEngine.Bounds val_28 = UnityEngine.AI.NavMeshSurface.GetWorldBounds(mat:  new UnityEngine.Matrix4x4(), bounds:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = val_26, y = val_26, z = val_26}, m_Extents = new UnityEngine.Vector3() {x = val_26, y = val_27, z = val_27}});
            goto label_41;
            label_14:
            if(==0)
            {
                goto label_25;
            }
            
            var val_31 = (val_16 == null) ? -851998632 : 0;
            goto label_26;
            label_16:
            val_64 = 0;
            label_17:
            UnityEngine.Matrix4x4 val_36 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4(), rhs:  new UnityEngine.Matrix4x4() {m00 = val_14, m10 = val_14, m20 = val_14, m30 = val_14, m01 = val_13, m11 = val_13, m21 = val_13, m31 = val_13, m02 = val_12, m12 = val_12, m22 = val_12, m32 = val_12, m03 = val_11, m13 = val_11, m23 = val_11, m33 = val_11});
            UnityEngine.Bounds val_37 = val_64.bounds;
            UnityEngine.Bounds val_44 = UnityEngine.AI.NavMeshSurface.GetWorldBounds(mat:  new UnityEngine.Matrix4x4(), bounds:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = val_41, y = val_41, z = val_41}, m_Extents = new UnityEngine.Vector3() {x = val_41, y = val_40, z = val_40}});
            goto label_41;
            label_25:
            val_65 = 0;
            label_26:
            UnityEngine.Matrix4x4 val_51 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4(), rhs:  new UnityEngine.Matrix4x4() {m00 = val_14, m10 = val_14, m20 = val_14, m30 = val_14, m01 = val_13, m11 = val_13, m21 = val_13, m31 = val_13, m02 = val_12, m12 = val_12, m22 = val_12, m32 = val_12, m03 = val_11, m13 = val_11, m23 = val_11, m33 = val_11});
            UnityEngine.Vector3 val_52 = val_65.size;
            UnityEngine.Vector3 val_53 = UnityEngine.Vector3.op_Multiply(d:  0.5f, a:  new UnityEngine.Vector3() {x = val_52.x, y = val_52.y, z = val_52.z});
            UnityEngine.Vector3 val_54 = val_65.size;
            UnityEngine.Bounds val_59 = UnityEngine.AI.NavMeshSurface.GetWorldBounds(mat:  new UnityEngine.Matrix4x4(), bounds:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = val_57, y = val_57, z = val_57}, m_Extents = new UnityEngine.Vector3() {x = val_57, y = val_58, z = val_58}});
            goto label_41;
            label_8:
            val_66 = 0;
            val_67 = 1;
            Dispose();
            val_63 = 0;
            val_0.m_Extents.y = 0f;
            val_0.m_Extents.z = 0f;
            val_0.m_Center.x = 0f;
            val_0.m_Center.y = 0f;
            val_0.m_Center.z = 0f;
            val_0.m_Extents.x = 0f;
            return val_0;
        }
        private bool HasTransformChanged()
        {
            UnityEngine.Vector3 val_2 = this.transform.position;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = this.m_LastPosition, y = V9.16B, z = V10.16B}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z})) != false)
            {
                    return true;
            }
            
            UnityEngine.Quaternion val_6 = this.transform.rotation;
            return UnityEngine.Quaternion.op_Inequality(lhs:  new UnityEngine.Quaternion() {x = this.m_LastRotation, y = V9.16B, z = V10.16B, w = val_2.x}, rhs:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w});
        }
        private void UpdateDataIfTransformChanged()
        {
            if(this.HasTransformChanged() == false)
            {
                    return;
            }
            
            this.m_NavMeshDataInstance = 0;
            this.AddData();
        }
        private static NavMeshSurface()
        {
            UnityEngine.AI.NavMeshSurface.s_NavMeshSurfaces = new System.Collections.Generic.List<UnityEngine.AI.NavMeshSurface>();
        }
        private static bool <AppendModifierVolumes>m__0(UnityEngine.AI.NavMeshModifierVolume x)
        {
            bool val_1 = X1.isActiveAndEnabled;
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        private static bool <CollectSources>m__1(UnityEngine.AI.NavMeshModifier x)
        {
            bool val_1 = X1.isActiveAndEnabled;
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        private static bool <CollectSources>m__2(UnityEngine.AI.NavMeshBuildSource x)
        {
            if(0 == X1)
            {
                    return false;
            }
            
            return UnityEngine.Object.op_Inequality(x:  0, y:  X1.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>());
        }
        private static bool <CollectSources>m__3(UnityEngine.AI.NavMeshBuildSource x)
        {
            if(0 == X1)
            {
                    return false;
            }
            
            return UnityEngine.Object.op_Inequality(x:  0, y:  X1.gameObject.GetComponent<UnityEngine.AI.NavMeshObstacle>());
        }
    
    }

}
