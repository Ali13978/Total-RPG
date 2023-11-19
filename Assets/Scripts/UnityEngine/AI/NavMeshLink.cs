using UnityEngine;

namespace UnityEngine.AI
{
    [UnityEngine.ExecuteInEditMode]
    [UnityEngine.DefaultExecutionOrder]
    [UnityEngine.AddComponentMenu]
    [UnityEngine.HelpURLAttribute]
    public class NavMeshLink : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private int m_AgentTypeID;
        [UnityEngine.SerializeField]
        private UnityEngine.Vector3 m_StartPoint;
        [UnityEngine.SerializeField]
        private UnityEngine.Vector3 m_EndPoint;
        [UnityEngine.SerializeField]
        private float m_Width;
        [UnityEngine.SerializeField]
        private int m_CostModifier;
        [UnityEngine.SerializeField]
        private bool m_Bidirectional;
        [UnityEngine.SerializeField]
        private bool m_AutoUpdatePosition;
        [UnityEngine.SerializeField]
        private int m_Area;
        private UnityEngine.AI.NavMeshLinkInstance m_LinkInstance;
        private UnityEngine.Vector3 m_LastPosition;
        private UnityEngine.Quaternion m_LastRotation;
        private static readonly System.Collections.Generic.List<UnityEngine.AI.NavMeshLink> s_Tracked;
        private static UnityEngine.AI.NavMesh.OnNavMeshPreUpdate <>f__mg$cache0;
        private static UnityEngine.AI.NavMesh.OnNavMeshPreUpdate <>f__mg$cache1;
        
        // Properties
        public int agentTypeID { get; set; }
        public UnityEngine.Vector3 startPoint { get; set; }
        public UnityEngine.Vector3 endPoint { get; set; }
        public float width { get; set; }
        public int costModifier { get; set; }
        public bool bidirectional { get; set; }
        public bool autoUpdate { get; set; }
        public int area { get; set; }
        
        // Methods
        public NavMeshLink()
        {
            this.m_StartPoint = 0;
            mem[1152921512332910880] = 0;
            mem[1152921512332910884] = 0;
            this.m_LinkInstance = 0;
            this.m_CostModifier = 0;
            this.m_Bidirectional = true;
            this.m_EndPoint = 0;
            mem[1152921512332910892] = 0;
            mem[1152921512332910896] = 0;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.m_LastPosition = val_1;
            mem[1152921512332910924] = val_1.y;
            mem[1152921512332910928] = val_1.z;
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
            this.m_LastRotation = val_2;
            mem[1152921512332910936] = val_2.y;
            mem[1152921512332910940] = val_2.z;
            mem[1152921512332910944] = val_2.w;
        }
        public int get_agentTypeID()
        {
            return (int)this.m_AgentTypeID;
        }
        public void set_agentTypeID(int value)
        {
            this.m_AgentTypeID = value;
            this.AddLink();
        }
        public UnityEngine.Vector3 get_startPoint()
        {
            return new UnityEngine.Vector3() {x = this.m_StartPoint};
        }
        public void set_startPoint(UnityEngine.Vector3 value)
        {
            this.m_StartPoint = value;
            mem[1152921512333358880] = value.y;
            mem[1152921512333358884] = value.z;
            this.AddLink();
        }
        public UnityEngine.Vector3 get_endPoint()
        {
            return new UnityEngine.Vector3() {x = this.m_EndPoint};
        }
        public void set_endPoint(UnityEngine.Vector3 value)
        {
            this.m_EndPoint = value;
            mem[1152921512333582892] = value.y;
            mem[1152921512333582896] = value.z;
            this.AddLink();
        }
        public float get_width()
        {
            return (float)this.m_Width;
        }
        public void set_width(float value)
        {
            this.m_Width = value;
            this.AddLink();
        }
        public int get_costModifier()
        {
            return (int)this.m_CostModifier;
        }
        public void set_costModifier(int value)
        {
            this.m_CostModifier = value;
            this.AddLink();
        }
        public bool get_bidirectional()
        {
            return (bool)this.m_Bidirectional;
        }
        public void set_bidirectional(bool value)
        {
            this.m_Bidirectional = value;
            this.AddLink();
        }
        public bool get_autoUpdate()
        {
            return (bool)this.m_AutoUpdatePosition;
        }
        public void set_autoUpdate(bool value)
        {
            this.SetAutoUpdate(value:  value);
        }
        public int get_area()
        {
            return (int)this.m_Area;
        }
        public void set_area(int value)
        {
            this.m_Area = value;
            this.AddLink();
        }
        private void OnEnable()
        {
            this.AddLink();
            if(this.m_AutoUpdatePosition == false)
            {
                    return;
            }
            
            if((this.m_LinkInstance & 1) == 0)
            {
                    return;
            }
            
            UnityEngine.AI.NavMeshLink.AddTracking(link:  null);
        }
        private void OnDisable()
        {
            UnityEngine.AI.NavMeshLink.RemoveTracking(link:  null);
        }
        public void UpdateLink()
        {
            this.AddLink();
        }
        private static void AddTracking(UnityEngine.AI.NavMeshLink link)
        {
            var val_5;
            var val_6;
            var val_7;
            OnNavMeshPreUpdate val_8;
            var val_9;
            val_5 = null;
            val_5 = null;
            if(UnityEngine.AI.NavMeshLink.s_Tracked.Count == 0)
            {
                    val_6 = null;
                val_6 = null;
                if((UnityEngine.AI.NavMeshLink.<>f__mg$cache0) == null)
            {
                    val_7 = null;
                val_7 = null;
                UnityEngine.AI.NavMeshLink.<>f__mg$cache0 = new NavMesh.OnNavMeshPreUpdate(object:  0, method:  static System.Void UnityEngine.AI.NavMeshLink::UpdateTrackedInstances());
                val_6 = null;
            }
            
                val_6 = null;
                System.Delegate val_3 = System.Delegate.Combine(a:  0, b:  UnityEngine.AI.NavMesh.onPreUpdate);
                val_8 = 0;
                if(val_3 != null)
            {
                    val_8 = val_3;
                if(null != null)
            {
                    val_8 = 0;
            }
            
            }
            
                UnityEngine.AI.NavMesh.onPreUpdate = val_8;
            }
            
            val_9 = null;
            val_9 = null;
            UnityEngine.AI.NavMeshLink.s_Tracked.Add(item:  X1);
        }
        private static void RemoveTracking(UnityEngine.AI.NavMeshLink link)
        {
            var val_6;
            System.Collections.Generic.List<UnityEngine.AI.NavMeshLink> val_7;
            var val_8;
            var val_9;
            OnNavMeshPreUpdate val_10;
            val_6 = null;
            val_6 = null;
            bool val_1 = UnityEngine.AI.NavMeshLink.s_Tracked.Remove(item:  X1);
            val_7 = UnityEngine.AI.NavMeshLink.s_Tracked;
            if(val_7.Count != 0)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            if((UnityEngine.AI.NavMeshLink.<>f__mg$cache1) == null)
            {
                    val_9 = null;
                val_9 = null;
                UnityEngine.AI.NavMeshLink.<>f__mg$cache1 = new NavMesh.OnNavMeshPreUpdate(object:  0, method:  static System.Void UnityEngine.AI.NavMeshLink::UpdateTrackedInstances());
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
        private void SetAutoUpdate(bool value)
        {
            var val_1 = (this.m_AutoUpdatePosition == true) ? 1 : 0;
            val_1 = val_1 ^ value;
            if(val_1 == false)
            {
                    return;
            }
            
            this.m_AutoUpdatePosition = value;
            if(value != false)
            {
                    UnityEngine.AI.NavMeshLink.AddTracking(link:  null);
                return;
            }
            
            UnityEngine.AI.NavMeshLink.RemoveTracking(link:  null);
        }
        private void AddLink()
        {
            0.startValue = (float)this.m_CostModifier;
            0.colorFormat = this.m_Area;
            UnityEngine.Vector3 val_2 = this.transform.position;
            UnityEngine.Quaternion val_4 = this.transform.rotation;
            UnityEngine.AI.NavMeshLinkInstance val_5 = UnityEngine.AI.NavMesh.AddLink(link:  new UnityEngine.AI.NavMeshLinkData() {m_StartPosition = new UnityEngine.Vector3(), m_EndPosition = new UnityEngine.Vector3()}, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w});
            this.m_LinkInstance = val_5;
            UnityEngine.Vector3 val_7 = this.transform.position;
            this.m_LastPosition = val_7;
            mem[1152921512335540172] = val_7.y;
            mem[1152921512335540176] = val_7.z;
            UnityEngine.Quaternion val_9 = this.transform.rotation;
            this.m_LastRotation = val_9;
            mem[1152921512335540184] = val_9.y;
            mem[1152921512335540188] = val_9.z;
            mem[1152921512335540192] = val_9.w;
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
        private void OnDidApplyAnimationProperties()
        {
            this.AddLink();
        }
        private static void UpdateTrackedInstances()
        {
            var val_6;
            var val_7;
            var val_8;
            val_6 = null;
            val_6 = null;
            List.Enumerator<T> val_1 = UnityEngine.AI.NavMeshLink.s_Tracked.GetEnumerator();
            label_8:
            if((0 & 1) == 0)
            {
                goto label_4;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_2 = 0.InitializationCallback;
            if(val_2.HasTransformChanged() == false)
            {
                goto label_8;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_5 = val_2 + 68;
            val_2.AddLink();
            goto label_8;
            label_4:
            val_7 = 0;
            val_8 = 1;
            0.Dispose();
            if((val_8 & 1) != 0)
            {
                    return;
            }
            
            if(val_7 == 0)
            {
                    return;
            }
        
        }
        private static NavMeshLink()
        {
            UnityEngine.AI.NavMeshLink.s_Tracked = new System.Collections.Generic.List<UnityEngine.AI.NavMeshLink>();
        }
    
    }

}
