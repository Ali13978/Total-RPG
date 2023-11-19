using UnityEngine;

namespace TzarGames.GameFramework
{
    public interface _IBitStream
    {
        // Properties
        public abstract bool IsWriting { get; }
        
        // Methods
        public abstract void Write(float val); // 0
        public abstract void Write(string val); // 0
        public abstract void Write(UnityEngine.Quaternion val); // 0
        public abstract void Write(UnityEngine.Vector3 val); // 0
        public abstract void Write(int val); // 0
        public abstract void Write(short val); // 0
        public abstract T Read<T>(); // 0
        public abstract bool get_IsWriting(); // 0
    
    }

}
