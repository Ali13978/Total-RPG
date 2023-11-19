using UnityEngine;

namespace TzarGames.GameFramework
{
    public class ApplicationManager : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private bool editor_simulateBatchMode;
        private static bool s_editor_simulateBatchMode;
        [UnityEngine.SerializeField]
        private string editor_debugCommandLine;
        private static TzarGames.GameFramework.ApplicationManager _globalAM;
        private static bool batchMode;
        private static bool cmdLineArgsProcessed;
        private static string cmdlevelName;
        private static int cmdPort;
        private static string cmdIP;
        
        // Properties
        public static TzarGames.GameFramework.ApplicationManager Get { get; }
        public static bool IsBatchMode { get; }
        public int CommandLineNetPort { get; }
        public string CommandLineIpAddress { get; }
        
        // Methods
        public ApplicationManager()
        {
            null = null;
            this.editor_debugCommandLine = System.String.Empty;
        }
        public static TzarGames.GameFramework.ApplicationManager get_Get()
        {
            null = null;
            return (TzarGames.GameFramework.ApplicationManager)TzarGames.GameFramework.ApplicationManager._globalAM;
        }
        public static bool get_IsBatchMode()
        {
            var val_2;
            System.String[] val_1 = System.Environment.GetCommandLineArgs();
            val_2 = null;
            val_2 = null;
            return (bool)TzarGames.GameFramework.ApplicationManager.batchMode;
        }
        public void localProcessCmdArgs()
        {
        
        }
        public int get_CommandLineNetPort()
        {
            var val_1;
            this.localProcessCmdArgs();
            val_1 = null;
            val_1 = null;
            return (int)TzarGames.GameFramework.ApplicationManager.cmdPort;
        }
        public string get_CommandLineIpAddress()
        {
            null = null;
            return (string)TzarGames.GameFramework.ApplicationManager.cmdIP;
        }
        private void Destroy()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if(0 != TzarGames.GameFramework.ApplicationManager._globalAM)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            TzarGames.GameFramework.ApplicationManager._globalAM = 0;
        }
        private void OnDestroy()
        {
            this.Destroy();
        }
        private void OnApplicationQuit()
        {
            var val_3;
            TzarGames.GameFramework.ApplicationManager val_4;
            var val_5;
            var val_6;
            val_3 = null;
            val_3 = null;
            val_4 = TzarGames.GameFramework.ApplicationManager._globalAM;
            if(0 != val_4)
            {
                    val_5 = null;
                val_5 = null;
                val_4 = TzarGames.GameFramework.ApplicationManager._globalAM.gameObject;
                UnityEngine.Object.Destroy(obj:  0);
            }
            
            val_6 = null;
            val_6 = null;
            TzarGames.GameFramework.ApplicationManager._globalAM = 0;
        }
        private void Awake()
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = null;
            val_5 = null;
            if(0 == TzarGames.GameFramework.ApplicationManager._globalAM)
            {
                goto label_5;
            }
            
            val_6 = null;
            val_6 = null;
            if(0 == TzarGames.GameFramework.ApplicationManager._globalAM)
            {
                goto label_15;
            }
            
            UnityEngine.Debug.LogWarning(message:  0);
            UnityEngine.GameObject val_3 = this.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
            goto label_15;
            label_5:
            UnityEngine.Debug.Log(message:  0);
            val_7 = null;
            val_7 = null;
            TzarGames.GameFramework.ApplicationManager._globalAM = this;
            label_15:
            UnityEngine.Coroutine val_4 = this.StartCoroutine(methodName:  "ApplicationInit");
        }
        private static void initBatchMode()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            if(TzarGames.GameFramework.ApplicationManager.batchMode != false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  0);
            val_2 = null;
            val_2 = null;
            TzarGames.GameFramework.ApplicationManager.batchMode = true;
            UnityEngine.Application.targetFrameRate = 0;
        }
        public static bool IsCommandlineArgumentExist(string argument)
        {
            return false;
        }
        public static string GetCommandLineArgumentValue(string argument)
        {
            return 0;
        }
        private static void processCommandLineArguments(string[] args)
        {
        
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator ApplicationInit()
        {
            typeof(ApplicationManager.<ApplicationInit>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void logCallback(string condition, string stackTrace, UnityEngine.LogType type)
        {
            UnityEngine.Debug.Log(message:  0);
        }
        private static ApplicationManager()
        {
            var val_1;
            TzarGames.GameFramework.ApplicationManager.cmdPort = 0;
            val_1 = null;
            val_1 = null;
            TzarGames.GameFramework.ApplicationManager.cmdIP = System.String.Empty;
        }
    
    }

}
