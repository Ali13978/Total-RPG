using UnityEngine;

namespace TzarGames.GameFramework
{
    internal class NavMeshPathResult : IPathResult
    {
        // Fields
        public UnityEngine.Vector3[] PathPoints;
        public int AllocatedCornerCount;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <Success>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.GameFramework.PathResultType <ResultType>k__BackingField;
        
        // Properties
        public bool Success { get; set; }
        public int CornerCount { get; }
        public TzarGames.GameFramework.PathResultType ResultType { get; set; }
        
        // Methods
        public NavMeshPathResult()
        {
            this.PathPoints = null;
        }
        public bool get_Success()
        {
            return (bool)this.<Success>k__BackingField;
        }
        public void set_Success(bool value)
        {
            this.<Success>k__BackingField = value;
        }
        public int get_CornerCount()
        {
            return (int)this.AllocatedCornerCount;
        }
        public TzarGames.GameFramework.PathResultType get_ResultType()
        {
            return (TzarGames.GameFramework.PathResultType)this.<ResultType>k__BackingField;
        }
        public void set_ResultType(TzarGames.GameFramework.PathResultType value)
        {
            this.<ResultType>k__BackingField = value;
        }
        public UnityEngine.Vector3 GetCornerAtIndex(int index)
        {
            var val_1 = 12;
            val_1 = this.PathPoints + ((long)index * val_1);
            return new UnityEngine.Vector3() {x = ((long)(int)(index) * 12) + this.PathPoints + 32, y = ((long)(int)(index) * 12) + this.PathPoints + 32 + 4, z = ((long)(int)(index) * 12) + this.PathPoints + 40};
        }
    
    }

}
