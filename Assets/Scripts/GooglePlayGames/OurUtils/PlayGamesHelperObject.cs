using UnityEngine;

namespace GooglePlayGames.OurUtils
{
    public class PlayGamesHelperObject : MonoBehaviour
    {
        // Fields
        private static GooglePlayGames.OurUtils.PlayGamesHelperObject instance;
        private static bool sIsDummy;
        private static System.Collections.Generic.List<System.Action> sQueue;
        private System.Collections.Generic.List<System.Action> localQueue;
        private static bool sQueueEmpty;
        private static System.Collections.Generic.List<System.Action<bool>> sPauseCallbackList;
        private static System.Collections.Generic.List<System.Action<bool>> sFocusCallbackList;
        
        // Methods
        public PlayGamesHelperObject()
        {
            this.localQueue = new System.Collections.Generic.List<System.Action>();
        }
        public static void CreateObject()
        {
            var val_7;
            GooglePlayGames.OurUtils.PlayGamesHelperObject val_8;
            var val_9;
            var val_10;
            val_7 = null;
            val_7 = null;
            val_8 = GooglePlayGames.OurUtils.PlayGamesHelperObject.instance;
            if(0 != val_8)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying != false)
            {
                    UnityEngine.GameObject val_4 = new UnityEngine.GameObject(name:  "PlayGames_QueueRunner");
                UnityEngine.Object.DontDestroyOnLoad(target:  0);
                val_9 = null;
                val_8 = AddComponent<GooglePlayGames.OurUtils.PlayGamesHelperObject>();
                val_9 = null;
                GooglePlayGames.OurUtils.PlayGamesHelperObject.instance = val_8;
                return;
            }
            
            GooglePlayGames.OurUtils.PlayGamesHelperObject val_6 = null;
            val_8 = val_6;
            val_6 = new GooglePlayGames.OurUtils.PlayGamesHelperObject();
            val_10 = null;
            val_10 = null;
            GooglePlayGames.OurUtils.PlayGamesHelperObject.instance = val_8;
            GooglePlayGames.OurUtils.PlayGamesHelperObject.sIsDummy = true;
        }
        public void Awake()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
        }
        public void OnDisable()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if(0 != GooglePlayGames.OurUtils.PlayGamesHelperObject.instance)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            GooglePlayGames.OurUtils.PlayGamesHelperObject.instance = 0;
        }
        public static void RunCoroutine(System.Collections.IEnumerator action)
        {
            var val_4;
            typeof(PlayGamesHelperObject.<RunCoroutine>c__AnonStorey0).__il2cppRuntimeField_10 = X1;
            val_4 = null;
            val_4 = null;
            if(0 == GooglePlayGames.OurUtils.PlayGamesHelperObject.instance)
            {
                    return;
            }
            
            System.Action val_3 = new System.Action(object:  new System.Object(), method:  System.Void PlayGamesHelperObject.<RunCoroutine>c__AnonStorey0::<>m__0());
            GooglePlayGames.OurUtils.PlayGamesHelperObject.RunOnGameThread(action:  null);
        }
        public static void RunOnGameThread(System.Action action)
        {
            System.Action val_8;
            var val_9;
            var val_11;
            val_8 = X1;
            if(val_8 != 0)
            {
                    val_9 = null;
                val_9 = null;
                if(GooglePlayGames.OurUtils.PlayGamesHelperObject.sIsDummy == true)
            {
                    return;
            }
            
                System.Threading.Monitor.Enter(obj:  0);
                val_11 = null;
                val_11 = null;
                GooglePlayGames.OurUtils.PlayGamesHelperObject.sQueue.Add(item:  val_8);
                GooglePlayGames.OurUtils.PlayGamesHelperObject.sQueueEmpty = false;
                System.Threading.Monitor.Exit(obj:  0);
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "action");
            val_8 = null;
            System.Threading.Monitor.Exit(obj:  0);
            if(val_8 == 0)
            {
                    return;
            }
            
            val_8 = ???;
        }
        public void Update()
        {
            var val_3;
            var val_5;
            var val_6;
            var val_7;
            val_3 = null;
            val_3 = null;
            if(GooglePlayGames.OurUtils.PlayGamesHelperObject.sIsDummy == true)
            {
                    return;
            }
            
            if(GooglePlayGames.OurUtils.PlayGamesHelperObject.sQueueEmpty == true)
            {
                    return;
            }
            
            this.localQueue.Clear();
            val_5 = null;
            val_5 = null;
            System.Threading.Monitor.Enter(obj:  0);
            val_6 = null;
            val_6 = null;
            this.localQueue.AddRange(collection:  GooglePlayGames.OurUtils.PlayGamesHelperObject.sQueue);
            GooglePlayGames.OurUtils.PlayGamesHelperObject.sQueue.Clear();
            GooglePlayGames.OurUtils.PlayGamesHelperObject.sQueueEmpty = true;
            System.Threading.Monitor.Exit(obj:  0);
            val_7 = 0;
            goto label_14;
            label_19:
            GooglePlayGames.OurUtils.PlayGamesHelperObject.sQueue.Invoke();
            val_7 = 1;
            label_14:
            if(val_7 >= this.localQueue.Count)
            {
                    return;
            }
            
            if(this.localQueue.Item[1] != null)
            {
                goto label_19;
            }
            
            goto label_19;
        }
        public void OnApplicationFocus(bool focused)
        {
            var val_3;
            var val_9 = null;
            List.Enumerator<T> val_1 = GooglePlayGames.OurUtils.PlayGamesHelperObject.sFocusCallbackList.GetEnumerator();
            label_14:
            if((0 & 1) == 0)
            {
                goto label_18;
            }
            
            val_3.InitializationCallback.Invoke(obj:  focused);
            goto label_14;
            label_19:
            if( != 1)
            {
                goto label_20;
            }
            
            label_18:
            val_3.Dispose();
            if((0 & 1) != 0)
            {
                    return;
            }
            
            if(1179403647 == 0)
            {
                    return;
            }
            
            return;
            label_20:
            goto label_19;
        }
        public void OnApplicationPause(bool paused)
        {
            var val_3;
            var val_9 = null;
            List.Enumerator<T> val_1 = GooglePlayGames.OurUtils.PlayGamesHelperObject.sPauseCallbackList.GetEnumerator();
            label_14:
            if((0 & 1) == 0)
            {
                goto label_18;
            }
            
            val_3.InitializationCallback.Invoke(obj:  paused);
            goto label_14;
            label_19:
            if( != 1)
            {
                goto label_20;
            }
            
            label_18:
            val_3.Dispose();
            if((0 & 1) != 0)
            {
                    return;
            }
            
            if(1179403647 == 0)
            {
                    return;
            }
            
            return;
            label_20:
            goto label_19;
        }
        public static void AddFocusCallback(System.Action<bool> callback)
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((GooglePlayGames.OurUtils.PlayGamesHelperObject.sFocusCallbackList.Contains(item:  X1)) != false)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            GooglePlayGames.OurUtils.PlayGamesHelperObject.sFocusCallbackList.Add(item:  X1);
        }
        public static bool RemoveFocusCallback(System.Action<bool> callback)
        {
            null = null;
            if(GooglePlayGames.OurUtils.PlayGamesHelperObject.sFocusCallbackList != null)
            {
                    return GooglePlayGames.OurUtils.PlayGamesHelperObject.sFocusCallbackList.Remove(item:  X1);
            }
            
            return GooglePlayGames.OurUtils.PlayGamesHelperObject.sFocusCallbackList.Remove(item:  X1);
        }
        public static void AddPauseCallback(System.Action<bool> callback)
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((GooglePlayGames.OurUtils.PlayGamesHelperObject.sPauseCallbackList.Contains(item:  X1)) != false)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            GooglePlayGames.OurUtils.PlayGamesHelperObject.sPauseCallbackList.Add(item:  X1);
        }
        public static bool RemovePauseCallback(System.Action<bool> callback)
        {
            null = null;
            if(GooglePlayGames.OurUtils.PlayGamesHelperObject.sPauseCallbackList != null)
            {
                    return GooglePlayGames.OurUtils.PlayGamesHelperObject.sPauseCallbackList.Remove(item:  X1);
            }
            
            return GooglePlayGames.OurUtils.PlayGamesHelperObject.sPauseCallbackList.Remove(item:  X1);
        }
        private static PlayGamesHelperObject()
        {
            GooglePlayGames.OurUtils.PlayGamesHelperObject.instance = 0;
            GooglePlayGames.OurUtils.PlayGamesHelperObject.sIsDummy = false;
            GooglePlayGames.OurUtils.PlayGamesHelperObject.sQueue = new System.Collections.Generic.List<System.Action>();
            GooglePlayGames.OurUtils.PlayGamesHelperObject.sQueueEmpty = true;
            GooglePlayGames.OurUtils.PlayGamesHelperObject.sPauseCallbackList = new System.Collections.Generic.List<System.Action<System.Boolean>>();
            GooglePlayGames.OurUtils.PlayGamesHelperObject.sFocusCallbackList = new System.Collections.Generic.List<System.Action<System.Boolean>>();
        }
    
    }

}
