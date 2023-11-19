using UnityEngine;

namespace SA.IOSDeploy
{
    [Serializable]
    public class Framework
    {
        // Fields
        public bool IsOpen;
        public SA.IOSDeploy.iOSFramework Type;
        public bool IsOptional;
        public bool IsEmbeded;
        
        // Properties
        public string Name { get; }
        public string TypeString { get; }
        
        // Methods
        public Framework(SA.IOSDeploy.iOSFramework type, bool Embaded = False)
        {
            this.IsEmbeded = Embaded;
            this.Type = type;
        }
        public Framework(string frameworkName)
        {
            null = null;
            string val_1 = frameworkName.Replace(oldValue:  ".framework", newValue:  System.String.Empty);
            this.Type = SA.Common.Util.General.ParseEnum<SA.IOSDeploy.iOSFramework>(value:  0);
        }
        public string get_Name()
        {
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            mem2[0] = null;
            return 0 + this.Type.ToString();
        }
        public int[] BaseIndexes()
        {
            var val_3;
            System.String[] val_1 = SA.IOSDeploy.ISD_FrameworkHandler.BaseFrameworksArray();
            System.Collections.Generic.List<System.Int32> val_2 = new System.Collections.Generic.List<System.Int32>(capacity:  val_1.Length);
            val_3 = 0;
            goto label_4;
            label_7:
            Add(item:  0);
            val_3 = 1;
            label_4:
            if(val_3 < val_1.Length)
            {
                goto label_7;
            }
            
            return ToArray();
        }
        public string get_TypeString()
        {
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            mem2[0] = null;
            return (string)this.Type.ToString();
        }
    
    }

}
