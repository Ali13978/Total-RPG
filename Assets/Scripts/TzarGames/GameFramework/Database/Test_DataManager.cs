using UnityEngine;

namespace TzarGames.GameFramework.Database
{
    public class Test_DataManager : MonoBehaviour
    {
        // Fields
        private TzarGames.GameFramework.Database.DataManager manager;
        private string docName;
        private string key;
        private string val;
        
        // Methods
        public Test_DataManager()
        {
            this.docName = "DocumentName";
            this.key = "Key";
            this.val = "Value";
        }
        private void Start()
        {
            this.manager = this.GetComponent<TzarGames.GameFramework.Database.DataManager>();
        }
        private void OnGUI()
        {
            UnityEngine.GUILayout.BeginHorizontal(options:  0);
            UnityEngine.GUILayout.Label(text:  0, options:  "Document name");
            this.docName = UnityEngine.GUILayout.TextField(text:  0, options:  this.docName);
            UnityEngine.GUILayout.EndHorizontal();
            UnityEngine.GUILayout.BeginHorizontal(options:  0);
            UnityEngine.GUILayout.Label(text:  0, options:  "Key");
            this.key = UnityEngine.GUILayout.TextField(text:  0, options:  this.key);
            UnityEngine.GUILayout.EndHorizontal();
            UnityEngine.GUILayout.BeginHorizontal(options:  0);
            UnityEngine.GUILayout.Label(text:  0, options:  "Value");
            this.val = UnityEngine.GUILayout.TextField(text:  0, options:  this.val);
            UnityEngine.GUILayout.EndHorizontal();
            bool val_4 = UnityEngine.GUILayout.Button(text:  0, options:  "Write Key Data");
            if((UnityEngine.GUILayout.Button(text:  0, options:  "Read Key Data")) == false)
            {
                    return;
            }
            
            typeof(TzarGames.GameFramework.Database.DataReadCompleteHandler).__il2cppRuntimeField_20 = this;
            typeof(TzarGames.GameFramework.Database.DataReadCompleteHandler).__il2cppRuntimeField_28 = System.Void TzarGames.GameFramework.Database.Test_DataManager::OnReadKeyComplete(object val);
            typeof(TzarGames.GameFramework.Database.DataReadCompleteHandler).__il2cppRuntimeField_10 = System.Void TzarGames.GameFramework.Database.Test_DataManager::OnReadKeyComplete(object val);
            UnityEngine.Coroutine val_6 = this.manager.ReadKeyData<System.String>(documentName:  this.docName, key:  this.key, dataReadCompleteHandler:  null);
        }
        private void OnReadKeyComplete(object val)
        {
            string val_1 = 0 + "Readkey complete: "("Readkey complete: ");
            UnityEngine.Debug.Log(message:  0);
        }
    
    }

}
