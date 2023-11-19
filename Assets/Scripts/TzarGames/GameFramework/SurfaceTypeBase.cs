using UnityEngine;

namespace TzarGames.GameFramework
{
    public class SurfaceTypeBase : ISurfaceType
    {
        // Fields
        private static System.Collections.Generic.Dictionary<string, TzarGames.GameFramework.SurfaceTypeBase> surfaceTypes;
        private const string DefaultSurfaceName = "Default";
        private static TzarGames.GameFramework.SurfaceTypeBase _default;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private string <SurfaceName>k__BackingField;
        
        // Properties
        public static TzarGames.GameFramework.SurfaceTypeBase Default { get; }
        public string SurfaceName { get; set; }
        
        // Methods
        private SurfaceTypeBase(string surfaceName)
        {
            this.<SurfaceName>k__BackingField = surfaceName;
        }
        public static TzarGames.GameFramework.SurfaceTypeBase GetOrCreate(string surfaceName)
        {
            string val_5;
            var val_6;
            TzarGames.GameFramework.SurfaceTypeBase val_7;
            var val_8;
            val_5 = 1152921504915472384;
            val_6 = null;
            val_6 = null;
            if((TzarGames.GameFramework.SurfaceTypeBase.DefaultSurfaceName.TryGetValue(key:  X1, value: out  0)) == true)
            {
                    return val_7;
            }
            
            object val_4 = null;
            val_7 = val_4;
            val_4 = new System.Object();
            typeof(TzarGames.GameFramework.SurfaceTypeBase).__il2cppRuntimeField_10 = X1;
            val_8 = null;
            val_8 = null;
            val_7 = val_7;
            val_5 = TzarGames.GameFramework.SurfaceTypeBase.DefaultSurfaceName;
            val_5.Add(key:  X1, value:  val_7);
            return val_7;
        }
        public static TzarGames.GameFramework.SurfaceTypeBase get_Default()
        {
            null = null;
            return (TzarGames.GameFramework.SurfaceTypeBase)TzarGames.GameFramework.SurfaceTypeBase._default;
        }
        public string get_SurfaceName()
        {
            return (string)this.<SurfaceName>k__BackingField;
        }
        public void set_SurfaceName(string value)
        {
            this.<SurfaceName>k__BackingField = value;
        }
        private static SurfaceTypeBase()
        {
            TzarGames.GameFramework.SurfaceTypeBase.DefaultSurfaceName = new System.Collections.Generic.Dictionary<System.String, TzarGames.GameFramework.SurfaceTypeBase>();
            typeof(TzarGames.GameFramework.SurfaceTypeBase).__il2cppRuntimeField_10 = "Default";
            TzarGames.GameFramework.SurfaceTypeBase._default = new System.Object();
        }
    
    }

}
