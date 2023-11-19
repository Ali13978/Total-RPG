using UnityEngine;

namespace TzarGames.GoogleFirebase
{
    public static class GoogleFirebaseApp
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static bool <IsReady>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action OnReady;
        private static System.Action<System.Threading.Tasks.Task<Firebase.DependencyStatus>> <>f__am$cache0;
        
        // Properties
        public static bool IsReady { get; set; }
        
        // Methods
        public static bool get_IsReady()
        {
            return (bool)TzarGames.GoogleFirebase.GoogleFirebaseApp.<IsReady>k__BackingField;
        }
        private static void set_IsReady(bool value)
        {
            TzarGames.GoogleFirebase.GoogleFirebaseApp.<IsReady>k__BackingField = W1 & 1;
        }
        public static void add_OnReady(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  TzarGames.GoogleFirebase.GoogleFirebaseApp.OnReady);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921504889171976 != TzarGames.GoogleFirebase.GoogleFirebaseApp.OnReady);
        
        }
        public static void remove_OnReady(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  TzarGames.GoogleFirebase.GoogleFirebaseApp.OnReady);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921504889171976 != TzarGames.GoogleFirebase.GoogleFirebaseApp.OnReady);
        
        }
        [UnityEngine.RuntimeInitializeOnLoadMethodAttribute]
        private static void init()
        {
            System.Action<System.Threading.Tasks.Task<Firebase.DependencyStatus>> val_4 = TzarGames.GoogleFirebase.GoogleFirebaseApp.<>f__am$cache0;
            if(val_4 == null)
            {
                    TzarGames.GoogleFirebase.GoogleFirebaseApp.<>f__am$cache0 = new System.Action<System.Threading.Tasks.Task<Firebase.DependencyStatus>>(object:  0, method:  static System.Void TzarGames.GoogleFirebase.GoogleFirebaseApp::<init>m__0(System.Threading.Tasks.Task<Firebase.DependencyStatus> task));
                val_4 = TzarGames.GoogleFirebase.GoogleFirebaseApp.<>f__am$cache0;
            }
            
            System.Threading.Tasks.Task val_3 = Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(continuation:  val_4);
        }
        private static void <init>m__0(System.Threading.Tasks.Task<Firebase.DependencyStatus> task)
        {
            var val_3;
            if(X1.Result != 0)
            {
                    val_3 = System.String.Format(format:  0, arg0:  "Could not resolve all Firebase dependencies: {0}");
                UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            TzarGames.GoogleFirebase.GoogleFirebaseApp.<IsReady>k__BackingField = true;
            if(TzarGames.GoogleFirebase.GoogleFirebaseApp.OnReady == null)
            {
                    return;
            }
            
            TzarGames.GoogleFirebase.GoogleFirebaseApp.OnReady.Invoke();
        }
    
    }

}
