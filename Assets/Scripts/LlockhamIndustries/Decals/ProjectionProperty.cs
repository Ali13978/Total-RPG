using UnityEngine;

namespace LlockhamIndustries.Decals
{
    [Serializable]
    public struct ProjectionProperty
    {
        // Fields
        public string name;
        public int nameID;
        public LlockhamIndustries.Decals.PropertyType type;
        public UnityEngine.Color color;
        public float value;
        public bool enabled;
        
        // Methods
        public ProjectionProperty(string Name, int ID, UnityEngine.Color Color)
        {
            this.color = Name;
            mem[1152921511833288632] = ID;
            mem[1152921511833288636] = 0;
            this.value = Color.r;
            this.enabled = Color.g;
            mem[1152921511833288648] = Color.b;
            mem[1152921511833288652] = Color.a;
            mem[1152921511833288656] = 0;
            mem[1152921511833288660] = 0;
        }
        public ProjectionProperty(string Name, int ID, float Value)
        {
            this.color = Name;
            mem[1152921511833408824] = ID;
            mem[1152921511833408828] = 1;
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.value = val_1.r;
            this.enabled = val_1.g;
            mem[1152921511833408840] = val_1.b;
            mem[1152921511833408844] = val_1.a;
            mem[1152921511833408852] = 0;
            mem[1152921511833408848] = Value;
        }
        public ProjectionProperty(string Name, int ID, UnityEngine.Color Color, float Value)
        {
            this.color = Name;
            this.value = Color.r;
            this.enabled = Color.g;
            mem[1152921511833529032] = Color.b;
            mem[1152921511833529036] = Color.a;
            mem[1152921511833529040] = Value;
            mem[1152921511833529016] = ID;
            mem[1152921511833529020] = 2;
            mem[1152921511833529044] = 0;
        }
    
    }

}
