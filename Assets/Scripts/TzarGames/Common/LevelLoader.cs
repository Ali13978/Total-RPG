using UnityEngine;

namespace TzarGames.Common
{
    [Serializable]
    public class LevelLoader
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.SceneUrl[] sceneUrls;
        private System.Collections.Generic.Dictionary<string, UnityEngine.WWW> levelLoadRequests;
        [UnityEngine.SerializeField]
        private bool avoidLevelDownloadInEditor;
        
        // Methods
        public LevelLoader()
        {
            this.levelLoadRequests = new System.Collections.Generic.Dictionary<System.String, UnityEngine.WWW>();
        }
        public float GetLevelDownLoadProgress(string levelName)
        {
            string val_5 = levelName;
            UnityEngine.WWW val_1 = 0;
            if((this.levelLoadRequests.TryGetValue(key:  val_5 = levelName, value: out  val_1)) == false)
            {
                    return (float)UnityEngine.Application.GetStreamProgressForLevel(levelName:  0);
            }
            
            val_5 = val_1;
            float val_3 = val_5.progress;
            return (float)UnityEngine.Application.GetStreamProgressForLevel(levelName:  0);
        }
        public bool IsLevelDownloadRequired(string levelName)
        {
            var val_3;
            var val_4 = 0;
            label_7:
            if(val_4 >= this.sceneUrls.Length)
            {
                goto label_2;
            }
            
            TzarGames.Common.SceneUrl val_3 = this.sceneUrls[0];
            val_4 = val_4 + 1;
            if((System.String.op_Equality(a:  0, b:  this.sceneUrls[0x0][0].SceneName)) == false)
            {
                goto label_7;
            }
            
            val_3 = 1;
            return (bool)val_3;
            label_2:
            val_3 = 0;
            return (bool)val_3;
        }
        public string GetLevelDownloadLink(string levelName)
        {
            string val_2;
            var val_3 = 0;
            label_7:
            if(val_3 >= this.sceneUrls.Length)
            {
                goto label_2;
            }
            
            TzarGames.Common.SceneUrl val_2 = this.sceneUrls[0];
            val_3 = val_3 + 1;
            if((System.String.op_Equality(a:  0, b:  this.sceneUrls[0x0][0].SceneName)) == false)
            {
                goto label_7;
            }
            
            val_2 = this.sceneUrls[0x0][0].Url;
            return (string)val_2;
            label_2:
            val_2 = 0;
            return (string)val_2;
        }
        public UnityEngine.WWW DownloadLevel(string levelName)
        {
            int val_9;
            UnityEngine.WWW val_10;
            UnityEngine.WWW val_1 = 0;
            if((this.levelLoadRequests.TryGetValue(key:  levelName, value: out  val_1)) == false)
            {
                goto label_2;
            }
            
            val_9 = val_1;
            if(val_9.isDone == false)
            {
                goto label_4;
            }
            
            bool val_4 = this.levelLoadRequests.Remove(key:  levelName);
            label_2:
            val_9 = this.GetLevelDownloadLink(levelName:  levelName);
            val_10 = 0;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return (UnityEngine.WWW)val_10;
            }
            
            UnityEngine.Debug.Log(message:  0);
            val_10 = UnityEngine.WWW.LoadFromCacheOrDownload(url:  0, version:  val_9);
            this.levelLoadRequests.Add(key:  levelName, value:  val_10);
            return (UnityEngine.WWW)val_10;
            label_4:
            val_10 = val_1;
            return (UnityEngine.WWW)val_10;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        public System.Collections.IEnumerator LoadLevel(string levelName)
        {
            if(null != 0)
            {
                    typeof(LevelLoader.<LoadLevel>c__Iterator0).__il2cppRuntimeField_10 = levelName;
            }
            else
            {
                    mem[16] = levelName;
            }
            
            typeof(LevelLoader.<LoadLevel>c__Iterator0).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
