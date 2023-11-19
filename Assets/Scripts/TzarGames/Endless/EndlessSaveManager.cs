using UnityEngine;

namespace TzarGames.Endless
{
    public class EndlessSaveManager : MonoBehaviour
    {
        // Fields
        private const string cloudSaveKey = "ENDLESS_SAVEMANAGER_CLOUD_SAVE";
        private const string cloudSaveFileName = "cloud_save_";
        private const string PREFIX_INVALID = "invalid";
        private const string PREFIX_BACKUP = "backup";
        private const string PREFIX_DEVICE_ID = "ENDLESSSAVEMANAGER_DEVICE_ID";
        [UnityEngine.SerializeField]
        private CodeStage.AntiCheat.ObscuredTypes.ObscuredString cryptKey;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.PlayerClassInfo playerClassInfo;
        [UnityEngine.SerializeField]
        private bool saveToCloud;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset cloudFileDescriptionFormat;
        private static System.Action<TzarGames.Endless.CloudSaveSystem.ICloudSaveWriteResult> <>f__am$cache0;
        
        // Properties
        public string Key { get; }
        
        // Methods
        public EndlessSaveManager()
        {
            this.saveToCloud = true;
            this.cryptKey = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  0);
        }
        public string get_Key()
        {
            return CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  0);
        }
        public static string GetDeviceID()
        {
            var val_8;
            var val_9;
            if((UnityEngine.PlayerPrefs.HasKey(key:  0)) == true)
            {
                    return (string)UnityEngine.PlayerPrefs.GetString(key:  0);
            }
            
            val_8 = UnityEngine.SystemInfo.deviceUniqueIdentifier;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    System.Guid val_5 = System.Guid.NewGuid();
                val_9;
            }
            else
            {
                    string val_6 = UnityEngine.SystemInfo.deviceUniqueIdentifier;
            }
            
            UnityEngine.PlayerPrefs.SetString(key:  0, value:  "ENDLESSSAVEMANAGER_DEVICE_ID");
            return (string)UnityEngine.PlayerPrefs.GetString(key:  0);
        }
        private void Awake()
        {
            string val_1 = CodeStage.AntiCheat.ObscuredTypes.ObscuredString.op_Implicit(value:  0);
            TzarGames.SaveManager.CryptKey = 0;
        }
        private void Start()
        {
            TzarGames.Endless.CloudSaveSystem.CloudSaveGame.Initialize();
        }
        public TzarGames.Endless.EndlessCharacterData CreateDefaultCharacterData(string name, TzarGames.Endless.PlayerClass classType, bool hardcore)
        {
            TzarGames.Endless.EndlessCharacterData val_3 = null;
            hardcore = hardcore;
            val_3 = new TzarGames.Endless.EndlessCharacterData(characterName:  name, stage:  0, hardcore:  hardcore, heroData:  TzarGames.Endless.EndlessHeroData.CreateDefault(classType:  this.playerClassInfo.GetClassTemplate(classType:  classType), template:  classType));
            return val_3;
        }
        private string getCloudSaveKey()
        {
            var val_6;
            if((UnityEngine.PlayerPrefs.HasKey(key:  0)) == true)
            {
                    return (string)UnityEngine.PlayerPrefs.GetString(key:  0);
            }
            
            System.Guid val_3 = System.Guid.NewGuid();
            val_6 = val_3;
            string val_4 = 0 + "cloud_save_";
            UnityEngine.PlayerPrefs.SetString(key:  0, value:  "ENDLESS_SAVEMANAGER_CLOUD_SAVE");
            return (string)UnityEngine.PlayerPrefs.GetString(key:  0);
        }
        public void SaveData(TzarGames.Endless.EndlessSaveData data)
        {
            System.Byte[] val_19;
            System.Byte[] val_20;
            val_19 = data;
            string val_2 = TzarGames.Endless.EndlessGameState.Instance.Version;
            if(val_19 != null)
            {
                    data.appVersion = val_2;
            }
            else
            {
                    mem[24] = val_2;
            }
            
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    data.deviceID = TzarGames.Endless.EndlessSaveManager.GetDeviceID();
            }
            
            val_20 = UnityEngine.JsonUtility.ToJson(obj:  0);
            TzarGames.SaveManager.SaveDataToLocalStorage(data:  0, bytes: out  val_20);
            if(this.saveToCloud == false)
            {
                    return;
            }
            
            if(TzarGames.Common.Privacy.CanCollectData == false)
            {
                    return;
            }
            
            if(TzarGames.Endless.CloudSaveSystem.CloudSaveGame.IsReady() == false)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            if(mem[24] < 1)
            {
                    return;
            }
            
            System.TimeSpan val_9 = System.TimeSpan.FromSeconds(value:  data._gameTimeInSeconds);
            val_20 = val_9._ticks;
            TzarGames.Endless.EndlessCharacterData val_13 = val_19.SelectedCharacter;
            uint val_14 = val_13.HeroData.GetXP();
            uint val_15 = TzarGames.GameFramework.CharacterTemplate.GetLevelFromXp(xp:  0);
            string val_16 = System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0), arg1:  val_19.SelectedCharacter.Name);
            val_19 = val_16;
            if((TzarGames.Endless.EndlessSaveManager.<>f__am$cache0) == null)
            {
                    System.Action<TzarGames.Endless.CloudSaveSystem.ICloudSaveWriteResult> val_18 = new System.Action<TzarGames.Endless.CloudSaveSystem.ICloudSaveWriteResult>(object:  0, method:  static System.Void TzarGames.Endless.EndlessSaveManager::<SaveData>m__0(TzarGames.Endless.CloudSaveSystem.ICloudSaveWriteResult result));
                TzarGames.Endless.EndlessSaveManager.<>f__am$cache0 = null;
            }
            
            TzarGames.Endless.CloudSaveSystem.CloudSaveGame.Write(file:  0, playedTime:  new System.TimeSpan() {_ticks = val_16.getCloudSaveKey()}, description:  val_20, data:  val_19, callback:  0);
        }
        public void RestoreSaveDataFromCloud(string fileName, System.Action<TzarGames.Endless.EndlessSaveData> callback)
        {
            typeof(EndlessSaveManager.<RestoreSaveDataFromCloud>c__AnonStorey1).__il2cppRuntimeField_10 = callback;
            if(TzarGames.Endless.CloudSaveSystem.CloudSaveGame.IsReady() != false)
            {
                    System.Action<TzarGames.Endless.CloudSaveSystem.ICloudSaveReadResult> val_4 = new System.Action<TzarGames.Endless.CloudSaveSystem.ICloudSaveReadResult>(object:  new System.Object(), method:  System.Void EndlessSaveManager.<RestoreSaveDataFromCloud>c__AnonStorey1::<>m__0(TzarGames.Endless.CloudSaveSystem.ICloudSaveReadResult result));
                TzarGames.Endless.CloudSaveSystem.CloudSaveGame.Read(file:  0, callback:  fileName);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  0);
            typeof(EndlessSaveManager.<RestoreSaveDataFromCloud>c__AnonStorey1).__il2cppRuntimeField_10.Invoke(obj:  0);
        }
        public void LoadSaveData(System.Action<TzarGames.Endless.EndlessSaveData> completeCallback)
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.getSaveDataRoutine(completeCallback:  completeCallback));
        }
        public byte[] GetBinarySaveData()
        {
            return TzarGames.SaveManager.GetBinaryData();
        }
        public void SaveBinarySaveData(byte[] bytes)
        {
            TzarGames.SaveManager.SaveBinaryData(bytes:  0);
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator getSaveDataRoutine(System.Action<TzarGames.Endless.EndlessSaveData> completeCallback)
        {
            if(null != 0)
            {
                    typeof(EndlessSaveManager.<getSaveDataRoutine>c__Iterator0).__il2cppRuntimeField_20 = completeCallback;
            }
            else
            {
                    mem[32] = completeCallback;
            }
            
            typeof(EndlessSaveManager.<getSaveDataRoutine>c__Iterator0).__il2cppRuntimeField_28 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public static byte[] GetInvalidFilesArchive()
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            val_6 = TzarGames.SaveManager.GetAllFilePathsWithPrefix(prefix:  0);
            val_7 = 0;
            if(val_6 == null)
            {
                    return (System.Byte[])val_7;
            }
            
            if(val_1.Length == 0)
            {
                goto label_4;
            }
            
            Ionic.Zip.ZipFile val_2 = null;
            val_5 = val_2;
            val_2 = new Ionic.Zip.ZipFile();
            if(val_1.Length >= 1)
            {
                    do
            {
                Ionic.Zip.ZipEntry val_3 = AddFile(fileName:  val_6[0]);
            }
            while((0 + 1) < val_1.Length);
            
            }
            
            System.IO.MemoryStream val_5 = new System.IO.MemoryStream();
            Save(outputStream:  null);
            val_7 = null;
            val_6 = 0;
            val_8 = 129;
            System.IO.MemoryStream val_9 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_11;
            }
            
            var val_7 = mem[null + 152];
            var val_8 = 0;
            val_7 = val_7 + 8;
            label_13:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_12;
            }
            
            val_8 = val_8 + 1;
            val_7 = val_7 + 16;
            if(val_8 < (mem[null + 258]))
            {
                goto label_13;
            }
            
            label_11:
            val_9 = null;
            goto label_14;
            label_4:
            val_7 = 0;
            return (System.Byte[])val_7;
            label_12:
            val_9 = val_9 + (((mem[null + 152] + 8)) << 4);
            label_14:
            if((val_6 != 0) && (129 != 129))
            {
                    val_6 = 0;
            }
            
            if(null == 0)
            {
                goto label_19;
            }
            
            Ionic.Zip.ZipFile val_11 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_20;
            }
            
            var val_10 = 0;
            label_22:
            if((._TempFileFolder + -8) == null)
            {
                goto label_21;
            }
            
            val_10 = val_10 + 1;
            if(val_10 < (mem[null + 258]))
            {
                goto label_22;
            }
            
            label_20:
            val_10 = val_5;
            goto label_23;
            label_21:
            val_11 = val_11 + ((mem[._TempFileFolder]) << 4);
            label_23:
            label_19:
            if(129 == 129)
            {
                    return (System.Byte[])val_7;
            }
            
            if(val_6 == 0)
            {
                    return (System.Byte[])val_7;
            }
            
            return (System.Byte[])val_7;
        }
        public static void CopyStream(System.IO.Stream input, System.IO.Stream output)
        {
            goto label_1;
            label_6:
            label_1:
            if(output <= 0)
            {
                    return;
            }
            
            if(X2 != 0)
            {
                goto label_6;
            }
            
            goto label_6;
        }
        public static TzarGames.Endless.EndlessSaveData GetSaveDataFromBytes(byte[] bytes)
        {
            var val_5;
            string val_1 = TzarGames.SaveManager.LoadFromMemoryAsString(data:  0);
            val_5 = 0;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return (TzarGames.Endless.EndlessSaveData)UnityEngine.JsonUtility.FromJson<EncodedData>(json:  0);
            }
            
            return (TzarGames.Endless.EndlessSaveData)UnityEngine.JsonUtility.FromJson<EncodedData>(json:  0);
        }
        private TzarGames.Endless.EndlessSaveData createDefaultDataAnsSave()
        {
            TzarGames.SaveManager.SaveDataToLocalStorage(data:  0, bytes: out  UnityEngine.JsonUtility.ToJson(obj:  0));
            return (TzarGames.Endless.EndlessSaveData)new TzarGames.Endless.EndlessSaveData();
        }
        [TzarGames.Common.ConsoleCommand]
        public static void ClearLocalSaveData()
        {
            TzarGames.SaveManager.DeleteUserDataFromLocalStorage();
        }
        [TzarGames.Common.ConsoleCommand]
        public static void BackupSaveData(bool withDate)
        {
            var val_2 = W1 & 1;
            string val_3 = TzarGames.SaveManager.BackupStringDataToLocalStorage(data:  0, filePrefix:  TzarGames.SaveManager.LoadDataFromLocalStorageAsString(), withDate:  true);
        }
        private static void <SaveData>m__0(TzarGames.Endless.CloudSaveSystem.ICloudSaveWriteResult result)
        {
        
        }
    
    }

}
