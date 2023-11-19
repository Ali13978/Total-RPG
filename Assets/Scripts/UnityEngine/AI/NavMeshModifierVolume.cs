using UnityEngine;

namespace UnityEngine.AI
{
    [UnityEngine.ExecuteInEditMode]
    [UnityEngine.AddComponentMenu]
    [UnityEngine.HelpURLAttribute]
    public class NavMeshModifierVolume : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Vector3 m_Size;
        [UnityEngine.SerializeField]
        private UnityEngine.Vector3 m_Center;
        [UnityEngine.SerializeField]
        private int m_Area;
        [UnityEngine.SerializeField]
        private System.Collections.Generic.List<int> m_AffectedAgents;
        private static readonly System.Collections.Generic.List<UnityEngine.AI.NavMeshModifierVolume> s_NavMeshModifiers;
        
        // Properties
        public UnityEngine.Vector3 size { get; set; }
        public UnityEngine.Vector3 center { get; set; }
        public int area { get; set; }
        public static System.Collections.Generic.List<UnityEngine.AI.NavMeshModifierVolume> activeModifiers { get; }
        
        // Methods
        public NavMeshModifierVolume()
        {
            this.m_Size = 0;
            mem[1152921512337520924] = 0;
            mem[1152921512337520928] = 0;
            this.m_Center = 0;
            mem[1152921512337520936] = 0;
            mem[1152921512337520940] = 0;
            typeof(System.Int32[]).__il2cppRuntimeField_20 = 0;
            this.m_AffectedAgents = new System.Collections.Generic.List<System.Int32>(collection:  null);
        }
        public UnityEngine.Vector3 get_size()
        {
            return new UnityEngine.Vector3() {x = this.m_Size};
        }
        public void set_size(UnityEngine.Vector3 value)
        {
            this.m_Size = value;
            mem[1152921512337744924] = value.y;
            mem[1152921512337744928] = value.z;
        }
        public UnityEngine.Vector3 get_center()
        {
            return new UnityEngine.Vector3() {x = this.m_Center};
        }
        public void set_center(UnityEngine.Vector3 value)
        {
            this.m_Center = value;
            mem[1152921512337968936] = value.y;
            mem[1152921512337968940] = value.z;
        }
        public int get_area()
        {
            return (int)this.m_Area;
        }
        public void set_area(int value)
        {
            this.m_Area = value;
        }
        public static System.Collections.Generic.List<UnityEngine.AI.NavMeshModifierVolume> get_activeModifiers()
        {
            null = null;
            return (System.Collections.Generic.List<UnityEngine.AI.NavMeshModifierVolume>)UnityEngine.AI.NavMeshModifierVolume.s_NavMeshModifiers;
        }
        private void OnEnable()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((UnityEngine.AI.NavMeshModifierVolume.s_NavMeshModifiers.Contains(item:  this)) != false)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            UnityEngine.AI.NavMeshModifierVolume.s_NavMeshModifiers.Add(item:  this);
        }
        private void OnDisable()
        {
            null = null;
            bool val_1 = UnityEngine.AI.NavMeshModifierVolume.s_NavMeshModifiers.Remove(item:  this);
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
        private static NavMeshModifierVolume()
        {
            UnityEngine.AI.NavMeshModifierVolume.s_NavMeshModifiers = new System.Collections.Generic.List<UnityEngine.AI.NavMeshModifierVolume>();
        }
    
    }

}
