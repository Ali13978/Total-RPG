using UnityEngine;

namespace LlockhamIndustries.Decals
{
    [Serializable]
    public struct ProjectionLayer
    {
        // Fields
        public string name;
        public UnityEngine.LayerMask layers;
        
        // Methods
        public ProjectionLayer(string Name)
        {
            mem[1152921511771951920] = Name;
            UnityEngine.LayerMask val_1 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
            mem[1152921511771951928] = val_1.m_Mask;
        }
        public ProjectionLayer(string Name, int Layer)
        {
            mem[1152921511772072112] = Name;
            int val_2 = 1 << (Layer & 31);
            UnityEngine.LayerMask val_3 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
            mem[1152921511772072120] = val_3.m_Mask;
        }
        public ProjectionLayer(string Name, UnityEngine.LayerMask Layers)
        {
            mem[1152921511772192304] = Name;
            mem[1152921511772192312] = Layers.m_Mask;
        }
    
    }

}
