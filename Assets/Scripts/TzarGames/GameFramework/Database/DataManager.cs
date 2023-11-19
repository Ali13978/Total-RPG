using UnityEngine;

namespace TzarGames.GameFramework.Database
{
    public class DataManager : MonoBehaviour
    {
        // Methods
        public DataManager()
        {
        
        }
        public TzarGames.GameFramework.Database.DatabaseRequest WriteKeyData(string documentName, string key, object value)
        {
            return 0;
        }
        public TzarGames.GameFramework.Database.DatabaseRequest WriteDataWithRandomKey<T>(string documentName, T value)
        {
            return 0;
        }
        public UnityEngine.Coroutine ReadKeyData<T>(string documentName, string key, TzarGames.GameFramework.Database.DataReadCompleteHandler dataReadCompleteHandler)
        {
            if(this != null)
            {
                    return this.StartCoroutine(routine:  this);
            }
            
            return this.StartCoroutine(routine:  this);
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator ReadKeyData_INTERNAL<T>(string documentName, string key, TzarGames.GameFramework.Database.DataReadCompleteHandler dataReadCompleteHandler)
        {
            return (System.Collections.IEnumerator)__RuntimeMethodHiddenParam + 48;
        }
    
    }

}
