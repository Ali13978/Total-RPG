using UnityEngine;

namespace TzarGames.Endless
{
    public class DynamicLinkHandler : MonoBehaviour
    {
        // Fields
        private static bool isSubscribed;
        private static System.Action <>f__mg$cache0;
        private static System.EventHandler<Firebase.DynamicLinks.ReceivedDynamicLinkEventArgs> <>f__mg$cache1;
        private static System.EventHandler<Firebase.DynamicLinks.ReceivedDynamicLinkEventArgs> <>f__mg$cache2;
        
        // Methods
        public DynamicLinkHandler()
        {
        
        }
        [UnityEngine.RuntimeInitializeOnLoadMethodAttribute]
        private static void init()
        {
            System.Action val_2;
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((TzarGames.Endless.DynamicLinkHandler.<>f__mg$cache0) == null)
            {
                    System.Action val_1 = null;
                val_2 = val_1;
                val_1 = new System.Action(object:  0, method:  static System.Void TzarGames.Endless.DynamicLinkHandler::GoogleFirebaseApp_OnReady());
                val_4 = null;
                val_4 = null;
                TzarGames.Endless.DynamicLinkHandler.<>f__mg$cache0 = val_2;
                val_3 = null;
            }
            
            val_3 = null;
            TzarGames.GoogleFirebase.GoogleFirebaseApp.add_OnReady(value:  0);
        }
        private static void GoogleFirebaseApp_OnReady()
        {
            TzarGames.Endless.DynamicLinkHandler.subscribe();
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator Start()
        {
            return (System.Collections.IEnumerator)new System.Object();
        }
        private static void subscribe()
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = null;
            val_2 = null;
            if(TzarGames.Endless.DynamicLinkHandler.isSubscribed != false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  0);
            val_3 = null;
            val_3 = null;
            TzarGames.Endless.DynamicLinkHandler.isSubscribed = true;
            val_4 = null;
            if((TzarGames.Endless.DynamicLinkHandler.<>f__mg$cache1) == null)
            {
                    val_5 = null;
                val_5 = null;
                TzarGames.Endless.DynamicLinkHandler.<>f__mg$cache1 = new System.EventHandler<Firebase.DynamicLinks.ReceivedDynamicLinkEventArgs>(object:  0, method:  static System.Void TzarGames.Endless.DynamicLinkHandler::DynamicLinks_DynamicLinkReceived(object sender, Firebase.DynamicLinks.ReceivedDynamicLinkEventArgs e));
                val_4 = null;
            }
            
            val_4 = null;
            Firebase.DynamicLinks.DynamicLinks.add_DynamicLinkReceived(value:  0);
        }
        private static void unsubscribe()
        {
            System.EventHandler<Firebase.DynamicLinks.ReceivedDynamicLinkEventArgs> val_2;
            var val_3;
            var val_5;
            val_3 = null;
            val_3 = null;
            if(TzarGames.Endless.DynamicLinkHandler.isSubscribed == false)
            {
                    return;
            }
            
            val_3 = null;
            if((TzarGames.Endless.DynamicLinkHandler.<>f__mg$cache2) == null)
            {
                    val_5 = null;
                val_5 = null;
                TzarGames.Endless.DynamicLinkHandler.<>f__mg$cache2 = new System.EventHandler<Firebase.DynamicLinks.ReceivedDynamicLinkEventArgs>(object:  0, method:  static System.Void TzarGames.Endless.DynamicLinkHandler::DynamicLinks_DynamicLinkReceived(object sender, Firebase.DynamicLinks.ReceivedDynamicLinkEventArgs e));
                val_3 = null;
            }
            
            val_3 = null;
            val_2 = TzarGames.Endless.DynamicLinkHandler.<>f__mg$cache2;
            Firebase.DynamicLinks.DynamicLinks.remove_DynamicLinkReceived(value:  0);
            TzarGames.Endless.DynamicLinkHandler.isSubscribed = false;
        }
        private static void DynamicLinks_DynamicLinkReceived(object sender, Firebase.DynamicLinks.ReceivedDynamicLinkEventArgs e)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = X2.ReceivedDynamicLink.Url.OriginalString;
            typeof(System.Object[]).__il2cppRuntimeField_28 = X2.ReceivedDynamicLink.MatchStrength;
            UnityEngine.Debug.LogFormat(format:  0, args:  "Dynamic link received: URL: {0}, match strenght: {1}");
        }
        private void OnDestroy()
        {
            TzarGames.Endless.DynamicLinkHandler.unsubscribe();
        }
        private static DynamicLinkHandler()
        {
        
        }
    
    }

}
