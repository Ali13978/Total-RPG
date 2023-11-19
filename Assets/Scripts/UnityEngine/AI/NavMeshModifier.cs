using UnityEngine;

namespace UnityEngine.AI
{
    [UnityEngine.ExecuteInEditMode]
    [UnityEngine.AddComponentMenu]
    [UnityEngine.HelpURLAttribute]
    public class NavMeshModifier : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private bool m_OverrideArea;
        [UnityEngine.SerializeField]
        private int m_Area;
        [UnityEngine.SerializeField]
        private bool m_IgnoreFromBuild;
        [UnityEngine.SerializeField]
        private System.Collections.Generic.List<int> m_AffectedAgents;
        private static readonly System.Collections.Generic.List<UnityEngine.AI.NavMeshModifier> s_NavMeshModifiers;
        
        // Properties
        public bool overrideArea { get; set; }
        public int area { get; set; }
        public bool ignoreFromBuild { get; set; }
        public static System.Collections.Generic.List<UnityEngine.AI.NavMeshModifier> activeModifiers { get; }
        
        // Methods
        public NavMeshModifier()
        {
            typeof(System.Int32[]).__il2cppRuntimeField_20 = 0;
            this.m_AffectedAgents = new System.Collections.Generic.List<System.Int32>(collection:  null);
        }
        public bool get_overrideArea()
        {
            return (bool)this.m_OverrideArea;
        }
        public void set_overrideArea(bool value)
        {
            this.m_OverrideArea = value;
        }
        public int get_area()
        {
            return (int)this.m_Area;
        }
        public void set_area(int value)
        {
            this.m_Area = value;
        }
        public bool get_ignoreFromBuild()
        {
            return (bool)this.m_IgnoreFromBuild;
        }
        public void set_ignoreFromBuild(bool value)
        {
            this.m_IgnoreFromBuild = value;
        }
        public static System.Collections.Generic.List<UnityEngine.AI.NavMeshModifier> get_activeModifiers()
        {
            null = null;
            return (System.Collections.Generic.List<UnityEngine.AI.NavMeshModifier>)UnityEngine.AI.NavMeshModifier.s_NavMeshModifiers;
        }
        private void OnEnable()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((UnityEngine.AI.NavMeshModifier.s_NavMeshModifiers.Contains(item:  this)) != false)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            UnityEngine.AI.NavMeshModifier.s_NavMeshModifiers.Add(item:  this);
        }
        private void OnDisable()
        {
            null = null;
            bool val_1 = UnityEngine.AI.NavMeshModifier.s_NavMeshModifiers.Remove(item:  this);
        }
        public bool AffectsAgentType(int agentTypeID)
        {
            System.Collections.Generic.List<System.Int32> val_5;
            var val_6;
            val_5 = this.m_AffectedAgents;
            if(val_5.Count == 0)
            {
                goto label_2;
            }
            
            val_5 = this.m_AffectedAgents;
            if(val_5.Item[0] == 1)
            {
                goto label_4;
            }
            
            var val_4 = ((this.m_AffectedAgents.IndexOf(item:  agentTypeID)) != 1) ? 1 : 0;
            return (bool)val_6;
            label_2:
            val_6 = 0;
            return (bool)val_6;
            label_4:
            val_6 = 1;
            return (bool)val_6;
        }
        private static NavMeshModifier()
        {
            UnityEngine.AI.NavMeshModifier.s_NavMeshModifiers = new System.Collections.Generic.List<UnityEngine.AI.NavMeshModifier>();
        }
    
    }

}
