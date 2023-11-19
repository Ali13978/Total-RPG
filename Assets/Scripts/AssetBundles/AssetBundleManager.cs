using UnityEngine;

namespace AssetBundles
{
    public class AssetBundleManager : MonoBehaviour
    {
        // Fields
        private static AssetBundles.AssetBundleManager.LogMode m_LogMode;
        private static string m_BaseDownloadingURL;
        private static string[] m_ActiveVariants;
        private static UnityEngine.AssetBundleManifest m_AssetBundleManifest;
        private static System.Collections.Generic.Dictionary<string, AssetBundles.LoadedAssetBundle> m_LoadedAssetBundles;
        private static System.Collections.Generic.Dictionary<string, string> m_DownloadingErrors;
        private static System.Collections.Generic.List<string> m_DownloadingBundles;
        private static System.Collections.Generic.List<AssetBundles.AssetBundleLoadOperation> m_InProgressOperations;
        private static System.Collections.Generic.Dictionary<string, string[]> m_Dependencies;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static AssetBundles.AssetBundleManager.OverrideBaseDownloadingURLDelegate overrideBaseDownloadingURL;
        
        // Properties
        public static AssetBundles.AssetBundleManager.LogMode logMode { get; set; }
        public static string BaseDownloadingURL { get; set; }
        public static string[] ActiveVariants { get; set; }
        public static UnityEngine.AssetBundleManifest AssetBundleManifestObject { get; set; }
        
        // Methods
        public AssetBundleManager()
        {
        
        }
        public static AssetBundles.AssetBundleManager.LogMode get_logMode()
        {
            null = null;
            return (LogMode)AssetBundles.AssetBundleManager.m_LogMode;
        }
        public static void set_logMode(AssetBundles.AssetBundleManager.LogMode value)
        {
            null = null;
            AssetBundles.AssetBundleManager.m_LogMode = W1;
        }
        public static string get_BaseDownloadingURL()
        {
            null = null;
            return (string)AssetBundles.AssetBundleManager.m_BaseDownloadingURL;
        }
        public static void set_BaseDownloadingURL(string value)
        {
            null = null;
            AssetBundles.AssetBundleManager.m_BaseDownloadingURL = X1;
        }
        public static void add_overrideBaseDownloadingURL(AssetBundles.AssetBundleManager.OverrideBaseDownloadingURLDelegate value)
        {
            var val_3;
            OverrideBaseDownloadingURLDelegate val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = AssetBundles.AssetBundleManager.overrideBaseDownloadingURL;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = AssetBundles.AssetBundleManager.__il2cppRuntimeField_static_fields;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  val_4);
            val_5 = 0;
            if(val_1 != null)
            {
                    val_5 = val_1;
                if(null != null)
            {
                    val_5 = 0;
            }
            
            }
            
            if(1152921504926392392 != val_4)
            {
                goto label_8;
            }
        
        }
        public static void remove_overrideBaseDownloadingURL(AssetBundles.AssetBundleManager.OverrideBaseDownloadingURLDelegate value)
        {
            var val_3;
            OverrideBaseDownloadingURLDelegate val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = AssetBundles.AssetBundleManager.overrideBaseDownloadingURL;
            goto label_3;
            label_8:
            val_3 = null;
            val_4 = AssetBundles.AssetBundleManager.__il2cppRuntimeField_static_fields;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  val_4);
            val_5 = 0;
            if(val_1 != null)
            {
                    val_5 = val_1;
                if(null != null)
            {
                    val_5 = 0;
            }
            
            }
            
            if(1152921504926392392 != val_4)
            {
                goto label_8;
            }
        
        }
        public static string[] get_ActiveVariants()
        {
            null = null;
            return (System.String[])AssetBundles.AssetBundleManager.m_ActiveVariants;
        }
        public static void set_ActiveVariants(string[] value)
        {
            null = null;
            AssetBundles.AssetBundleManager.m_ActiveVariants = X1;
        }
        public static UnityEngine.AssetBundleManifest get_AssetBundleManifestObject()
        {
            null = null;
            return (UnityEngine.AssetBundleManifest)AssetBundles.AssetBundleManager.m_AssetBundleManifest;
        }
        public static void set_AssetBundleManifestObject(UnityEngine.AssetBundleManifest value)
        {
            null = null;
            AssetBundles.AssetBundleManager.m_AssetBundleManifest = X1;
        }
        private static void Log(AssetBundles.AssetBundleManager.LogType logType, string text)
        {
            var val_4;
            LogMode val_5;
            if(text == 2)
            {
                    string val_1 = 0 + "[AssetBundleManager] ";
                UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            val_4 = null;
            val_4 = null;
            val_5 = AssetBundles.AssetBundleManager.m_LogMode;
            if((text == 1) && (val_5 == 0))
            {
                    string val_2 = 0 + "[AssetBundleManager] ";
                UnityEngine.Debug.LogWarning(message:  0);
                return;
            }
            
            val_5 = AssetBundles.AssetBundleManager.m_LogMode;
            if(val_5 != 0)
            {
                    return;
            }
            
            string val_3 = 0 + "[AssetBundleManager] ";
            UnityEngine.Debug.Log(message:  0);
        }
        private static string GetStreamingAssetsPath()
        {
            if(UnityEngine.Application.isMobilePlatform == true)
            {
                    return UnityEngine.Application.streamingAssetsPath;
            }
            
            if(UnityEngine.Application.isConsolePlatform != false)
            {
                    return UnityEngine.Application.streamingAssetsPath;
            }
            
            string val_4 = UnityEngine.Application.streamingAssetsPath;
            return 0 + "file://"("file://");
        }
        public static void SetSourceAssetBundleDirectory(string relativePath)
        {
            AssetBundles.AssetBundleManager.BaseDownloadingURL = 0 + AssetBundles.AssetBundleManager.GetStreamingAssetsPath();
        }
        public static void SetSourceAssetBundleURL(string absolutePath)
        {
            string val_7;
            string val_8;
            val_7 = X1;
            if((val_7.EndsWith(value:  "/")) != true)
            {
                    val_7 = 0 + val_7;
            }
            
            string val_6 = 0 + val_7 + AssetBundles.Utility.GetPlatformForAssetBundles(platform:  UnityEngine.Application.platform)(AssetBundles.Utility.GetPlatformForAssetBundles(platform:  UnityEngine.Application.platform));
            val_8 = null;
            AssetBundles.AssetBundleManager.BaseDownloadingURL = val_8;
        }
        public static void SetDevelopmentAssetBundleServer(string serverUrl)
        {
            var val_8 = X1;
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_3;
            }
            
            val_8 = 0;
            if((UnityEngine.Resources.Load(path:  0)) != null)
            {
                    val_8 = 0;
            }
            
            if(0 == )
            {
                goto label_13;
            }
            
            val_8 = text.Trim();
            label_3:
            if(val_8 != null)
            {
                    if(val_8.Length != 0)
            {
                    AssetBundles.AssetBundleManager.SetSourceAssetBundleURL(absolutePath:  null);
                return;
            }
            
            }
            
            label_13:
            AssetBundles.AssetBundleManager.Log(logType:  null, text:  2);
        }
        public static AssetBundles.LoadedAssetBundle GetLoadedAssetBundle(string assetBundleName, out string error)
        {
            var val_14;
            System.Collections.Generic.Dictionary<System.String, System.String> val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            val_14 = null;
            AssetBundles.LoadedAssetBundle val_13 = 0;
            val_14 = null;
            val_15 = AssetBundles.AssetBundleManager.m_DownloadingErrors;
            if((val_15.TryGetValue(key:  error, value: out  X2)) == true)
            {
                goto label_19;
            }
            
            val_16 = null;
            AssetBundles.LoadedAssetBundle val_4 = 0;
            val_16 = null;
            val_15 = AssetBundles.AssetBundleManager.m_LoadedAssetBundles;
            bool val_5 = val_15.TryGetValue(key:  error, value: out  val_4);
            if(val_4 == 0)
            {
                goto label_19;
            }
            
            val_17 = null;
            System.String[] val_6 = 0;
            val_17 = null;
            val_15 = AssetBundles.AssetBundleManager.m_Dependencies;
            if((val_15.TryGetValue(key:  error, value: out  val_6)) == false)
            {
                goto label_14;
            }
            
            var val_15 = 0;
            label_23:
            if(val_15 >= 7254272)
            {
                goto label_14;
            }
            
            val_18 = null;
            var val_9 = val_6 + 0;
            val_18 = null;
            val_15 = AssetBundles.AssetBundleManager.m_DownloadingErrors;
            if((val_15.TryGetValue(key:  (val_6 + 0) + 32, value: out  X2)) == true)
            {
                goto label_19;
            }
            
            val_19 = null;
            val_19 = null;
            val_15 = AssetBundles.AssetBundleManager.m_LoadedAssetBundles;
            bool val_14 = val_15.TryGetValue(key:  (val_6 + 0) + 32, value: out  val_13);
            val_15 = val_15 + 1;
            if(val_13 != 0)
            {
                goto label_23;
            }
            
            label_19:
            val_20 = 0;
            return (AssetBundles.LoadedAssetBundle)val_20;
            label_14:
            val_20 = val_4;
            return (AssetBundles.LoadedAssetBundle)val_20;
        }
        public static bool IsAssetBundleDownloaded(string assetBundleName)
        {
            null = null;
            if(AssetBundles.AssetBundleManager.m_LoadedAssetBundles != null)
            {
                    return AssetBundles.AssetBundleManager.m_LoadedAssetBundles.ContainsKey(key:  X1);
            }
            
            return AssetBundles.AssetBundleManager.m_LoadedAssetBundles.ContainsKey(key:  X1);
        }
        public static AssetBundles.AssetBundleLoadManifestOperation Initialize(bool loadManifestFromCache)
        {
            var val_3 = W1 & 1;
            return AssetBundles.AssetBundleManager.Initialize(manifestAssetBundleName:  null = null, loadManifestFromCache:  AssetBundles.Utility.GetPlatformForAssetBundles(platform:  UnityEngine.Application.platform));
        }
        public static void Clear()
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            val_4 = null;
            val_4 = null;
            AssetBundles.AssetBundleManager.m_DownloadingErrors.Clear();
            List.Enumerator<T> val_1 = AssetBundles.AssetBundleManager.m_InProgressOperations.GetEnumerator();
            label_7:
            if((0 & 1) == 0)
            {
                goto label_5;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_2 = 0.InitializationCallback;
            if(val_2 == null)
            {
                goto label_7;
            }
            
            System.Delegate val_3 = val_2.CombineImpl(follow:  System.Delegate System.MulticastDelegate::CombineImpl(System.Delegate follow));
            goto label_7;
            label_5:
            val_5 = 0;
            val_6 = 1;
            0.Dispose();
            val_7 = null;
            val_7 = null;
            AssetBundles.AssetBundleManager.m_InProgressOperations.Clear();
            AssetBundles.AssetBundleManager.m_DownloadingBundles.Clear();
        }
        public static AssetBundles.AssetBundleLoadManifestOperation Initialize(string manifestAssetBundleName, bool loadManifestFromCache)
        {
            var val_8;
            if(0 == (UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>()))
            {
                    typeof(System.Type[]).__il2cppRuntimeField_20 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
                UnityEngine.GameObject val_4 = new UnityEngine.GameObject(name:  "AssetBundleManager", components:  null);
                UnityEngine.Object.DontDestroyOnLoad(target:  0);
            }
            
            val_8 = null;
            val_8 = null;
            AssetBundles.AssetBundleManager.m_DownloadingErrors.Clear();
            var val_5 = W2 & 1;
            AssetBundles.AssetBundleManager.LoadAssetBundle(assetBundleName:  AssetBundles.AssetBundleManager.m_DownloadingErrors, isLoadingAssetBundleManifest:  loadManifestFromCache, loadManifestFromCache:  true);
            object val_7 = new System.Object();
            typeof(AssetBundles.AssetBundleLoadManifestOperation).__il2cppRuntimeField_10 = loadManifestFromCache;
            typeof(AssetBundles.AssetBundleLoadManifestOperation).__il2cppRuntimeField_18 = "AssetBundleManifest";
            typeof(AssetBundles.AssetBundleLoadManifestOperation).__il2cppRuntimeField_28 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            AssetBundles.AssetBundleManager.m_InProgressOperations.Add(item:  val_7);
            return (AssetBundles.AssetBundleLoadManifestOperation)val_7;
        }
        protected static void LoadAssetBundle(string assetBundleName)
        {
            AssetBundles.AssetBundleManager.LoadAssetBundle(assetBundleName:  null, isLoadingAssetBundleManifest:  X1, loadManifestFromCache:  false);
        }
        protected static void LoadAssetBundle(string assetBundleName, bool isLoadingAssetBundleManifest, bool loadManifestFromCache)
        {
            LogType val_9;
            var val_10;
            string val_2 = 0 + "Loading Asset Bundle " + (loadManifestFromCache != true) ? "Manifest: " : ": "((loadManifestFromCache != true) ? "Manifest: " : ": ");
            val_9 = null;
            AssetBundles.AssetBundleManager.Log(logType:  val_9, text:  0);
            if(loadManifestFromCache != true)
            {
                    val_10 = null;
                val_10 = null;
                if(0 == AssetBundles.AssetBundleManager.m_AssetBundleManifest)
            {
                    AssetBundles.AssetBundleManager.Log(logType:  null, text:  2);
                return;
            }
            
            }
            
            bool val_5 = loadManifestFromCache;
            var val_6 = W3 & 1;
            if((AssetBundles.AssetBundleManager.LoadAssetBundleInternal(assetBundleName:  null, isLoadingAssetBundleManifest:  isLoadingAssetBundleManifest, loadManifestFromCache:  val_5)) == true)
            {
                    return;
            }
            
            if(val_5 == true)
            {
                    return;
            }
            
            AssetBundles.AssetBundleManager.LoadDependencies(assetBundleName:  null);
        }
        protected static string GetAssetBundleBaseDownloadingURL(string bundleName)
        {
            var val_4;
            OverrideBaseDownloadingURLDelegate val_5;
            var val_6;
            string val_7;
            val_4 = null;
            val_4 = null;
            val_5 = AssetBundles.AssetBundleManager.overrideBaseDownloadingURL;
            if(val_5 == null)
            {
                goto label_3;
            }
            
            val_5 = AssetBundles.AssetBundleManager.overrideBaseDownloadingURL;
            if(val_5 == null)
            {
                goto label_6;
            }
            
            val_6 = 0;
            goto label_11;
            label_16:
            System.Delegate val_4 = val_5.GetInvocationList()[0];
            if(val_4 != null)
            {
                    if(null == null)
            {
                goto label_10;
            }
            
            }
            
            label_14:
            label_13:
            val_6 = 1;
            if((0.Invoke(bundleName:  X1)) == null)
            {
                goto label_11;
            }
            
            return val_7;
            label_10:
            if(val_4 != null)
            {
                goto label_13;
            }
            
            goto label_14;
            label_11:
            if(val_6 < val_1.Length)
            {
                goto label_16;
            }
            
            val_4 = null;
            label_3:
            val_4 = null;
            val_7 = AssetBundles.AssetBundleManager.m_BaseDownloadingURL;
            return val_7;
            label_6:
        }
        protected static bool UsesExternalBundleVariantResolutionMechanism(string baseAssetBundleName)
        {
            return false;
        }
        protected static string RemapVariantName(string assetBundleName)
        {
            var val_12;
            string val_13;
            var val_14;
            var val_15;
            string val_16;
            var val_17;
            int val_18;
            var val_19;
            LogType val_20;
            val_13 = X1;
            val_14 = null;
            val_14 = null;
            if(0 == AssetBundles.AssetBundleManager.m_AssetBundleManifest)
            {
                    UnityEngine.Debug.Log(message:  0);
                return val_13;
            }
            
            val_15 = null;
            val_15 = null;
            System.String[] val_2 = AssetBundles.AssetBundleManager.m_AssetBundleManifest.GetAllAssetBundlesWithVariant();
            typeof(System.Char[]).__il2cppRuntimeField_20 = 46;
            val_16 = val_13.Split(separator:  null)[0];
            val_17 = 0;
            val_12 = 2147483647;
            goto label_17;
            label_32:
            val_17 = 1;
            label_17:
            if(val_17 >= val_2.Length)
            {
                goto label_19;
            }
            
            typeof(System.Char[]).__il2cppRuntimeField_20 = 46;
            System.String[] val_4 = val_2[1].Split(separator:  null);
            val_18 = val_4.Length;
            if(val_18 == 0)
            {
                    val_18 = val_4.Length;
            }
            
            string val_14 = val_4[1];
            if((System.String.op_Inequality(a:  0, b:  val_4[0])) == true)
            {
                goto label_32;
            }
            
            val_19 = null;
            val_19 = null;
            int val_7 = System.Array.IndexOf<UnityEngine.Object>(array:  0, value:  AssetBundles.AssetBundleManager.m_ActiveVariants);
            var val_8 = (val_7 == 1) ? 2147483646 : (val_7);
            var val_9 = (val_8 < val_12) ? (val_17) : 0;
            var val_10 = (val_8 < val_12) ? (val_8) : (val_12);
            goto label_32;
            label_19:
            val_13 = val_13;
            if(val_12 == 2147483646)
            {
                    val_12 = 0;
                string val_15 = val_2[val_12];
                val_16 = 0 + "Ambigious asset bundle variant chosen because there was no matching active variant: "("Ambigious asset bundle variant chosen because there was no matching active variant: ");
                val_20 = null;
                AssetBundles.AssetBundleManager.Log(logType:  val_20, text:  1);
            }
            
            if(0 == 1)
            {
                    return val_13;
            }
            
            val_12 = 0;
            val_13 = val_2[val_12];
            return val_13;
        }
        protected static bool LoadAssetBundleInternal(string assetBundleName, bool isLoadingAssetBundleManifest, bool loadManifestFromCache)
        {
            System.Collections.Generic.List<AssetBundles.AssetBundleLoadOperation> val_21;
            var val_22;
            var val_23;
            var val_24;
            string val_25;
            var val_26;
            string val_27;
            var val_28;
            var val_30;
            UnityEngine.WWW val_31;
            var val_32;
            var val_33;
            val_21 = loadManifestFromCache;
            AssetBundles.LoadedAssetBundle val_1 = 0;
            val_22 = null;
            val_22 = null;
            bool val_2 = AssetBundles.AssetBundleManager.m_LoadedAssetBundles.TryGetValue(key:  isLoadingAssetBundleManifest, value: out  val_1);
            if(val_1 == 0)
            {
                goto label_4;
            }
            
            mem[24] = 7254273;
            goto label_5;
            label_4:
            val_23 = null;
            val_23 = null;
            if((AssetBundles.AssetBundleManager.m_DownloadingBundles.Contains(item:  isLoadingAssetBundleManifest)) == false)
            {
                goto label_9;
            }
            
            label_5:
            val_24 = 1;
            return (bool)val_24;
            label_9:
            val_25 = AssetBundles.AssetBundleManager.GetAssetBundleBaseDownloadingURL(bundleName:  null);
            val_26 = val_25.ToLower();
            if((val_26.StartsWith(value:  "odr://")) == false)
            {
                goto label_15;
            }
            
            val_27 = "Can\'t load bundle ";
            val_28 = " through ODR: this Unity version or build target doesn\'t support it.";
            goto label_18;
            label_15:
            val_26 = val_25.ToLower();
            if((val_26.StartsWith(value:  "res://")) == false)
            {
                goto label_21;
            }
            
            val_27 = "Can\'t load bundle ";
            val_28 = " through asset catalog: this Unity version or build target doesn\'t support it.";
            label_18:
            System.ApplicationException val_11 = new System.ApplicationException(message:  0 + val_27 + isLoadingAssetBundleManifest);
            goto label_24;
            label_21:
            val_26 = "/";
            if((val_25.EndsWith(value:  "/")) != true)
            {
                    val_25 = 0 + val_25;
            }
            
            string val_15 = 0 + val_25;
            if(val_21 == false)
            {
                goto label_31;
            }
            
            if((W3 & 1) == 0)
            {
                goto label_32;
            }
            
            UnityEngine.WWW val_16 = UnityEngine.WWW.LoadFromCacheOrDownload(url:  0, version:  val_15);
            goto label_33;
            label_31:
            val_30 = null;
            val_30 = null;
            UnityEngine.Hash128 val_17 = AssetBundles.AssetBundleManager.m_AssetBundleManifest.GetAssetBundleHash(assetBundleName:  isLoadingAssetBundleManifest);
            label_33:
            val_31 = UnityEngine.WWW.LoadFromCacheOrDownload(url:  0, hash:  new UnityEngine.Hash128() {m_u32_0 = val_15, m_u32_1 = val_15, m_u32_2 = val_17.m_u32_0, m_u32_3 = val_17.m_u32_1}, crc:  val_17.m_u32_2);
            goto label_37;
            label_32:
            UnityEngine.WWW val_19 = null;
            val_31 = val_19;
            val_19 = new UnityEngine.WWW(url:  val_15);
            label_37:
            val_32 = null;
            val_32 = null;
            val_21 = AssetBundles.AssetBundleManager.m_InProgressOperations;
            val_21.Add(item:  new AssetBundles.AssetBundleDownloadFromWebOperation(assetBundleName:  isLoadingAssetBundleManifest, www:  val_31));
            label_24:
            val_33 = null;
            val_33 = null;
            AssetBundles.AssetBundleManager.m_DownloadingBundles.Add(item:  isLoadingAssetBundleManifest);
            val_24 = 0;
            return (bool)val_24;
        }
        public static float GetDownloadProgress(string bundleName)
        {
            var val_4;
            var val_5;
            var val_6;
            val_4 = X1;
            val_5 = null;
            val_5 = null;
            List.Enumerator<T> val_1 = AssetBundles.AssetBundleManager.m_InProgressOperations.GetEnumerator();
            label_10:
            if((0 & 1) == 0)
            {
                goto label_4;
            }
            
            if((0.InitializationCallback == null) || ((System.String.op_Equality(a:  0, b:  X21)) == false))
            {
                goto label_10;
            }
            
            val_6 = V0.16B;
            0.Dispose();
            return (float)val_6;
            label_4:
            0.Dispose();
            val_6 = 0f;
            return (float)val_6;
        }
        protected static void LoadDependencies(string assetBundleName)
        {
            var val_9;
            UnityEngine.Object val_10;
            LogType val_11;
            var val_12;
            var val_13;
            var val_14;
            val_9 = null;
            val_9 = null;
            val_10 = 0;
            val_11 = null;
            if(val_10 == AssetBundles.AssetBundleManager.m_AssetBundleManifest)
            {
                    val_10 = val_11;
                AssetBundles.AssetBundleManager.Log(logType:  val_10, text:  2);
                return;
            }
            
            val_11 = null;
            System.String[] val_4 = AssetBundles.AssetBundleManager.m_AssetBundleManifest.GetAllDependencies(assetBundleName:  X1);
            if(val_4.Length == 0)
            {
                    return;
            }
            
            if(val_4.Length >= 1)
            {
                    do
            {
                string val_10 = val_4[0];
                mem2[0] = AssetBundles.AssetBundleManager.RemapVariantName(assetBundleName:  null);
            }
            while((0 + 1) < val_4.Length);
            
            }
            
            val_12 = null;
            val_12 = null;
            if((AssetBundles.AssetBundleManager.m_Dependencies.ContainsKey(key:  X1)) != true)
            {
                    val_13 = null;
                val_13 = null;
                AssetBundles.AssetBundleManager.m_Dependencies.Add(key:  X1, value:  val_4);
            }
            
            val_14 = 0;
            goto label_28;
            label_34:
            bool val_9 = AssetBundles.AssetBundleManager.LoadAssetBundleInternal(assetBundleName:  AssetBundles.AssetBundleManager.m_Dependencies, isLoadingAssetBundleManifest:  X1, loadManifestFromCache:  false);
            val_14 = 1;
            label_28:
            if(val_14 >= val_4.Length)
            {
                    return;
            }
            
            string val_11 = val_4[1];
            goto label_34;
        }
        public static void UnloadAssetBundle(string assetBundleName)
        {
            string val_1 = AssetBundles.AssetBundleManager.RemapVariantName(assetBundleName:  null);
            AssetBundles.AssetBundleManager.UnloadAssetBundleInternal(assetBundleName:  val_1);
            AssetBundles.AssetBundleManager.UnloadDependencies(assetBundleName:  val_1);
        }
        protected static void UnloadDependencies(string assetBundleName)
        {
            var val_4;
            var val_5;
            var val_6;
            System.String[] val_1 = 0;
            val_4 = null;
            val_4 = null;
            bool val_2 = AssetBundles.AssetBundleManager.m_Dependencies.TryGetValue(key:  X1, value: out  val_1);
            if(val_2 == false)
            {
                    return;
            }
            
            val_5 = 0;
            goto label_5;
            label_11:
            AssetBundles.AssetBundleManager.UnloadAssetBundleInternal(assetBundleName:  val_2);
            val_5 = 1;
            label_5:
            if(val_5 >= 7254272)
            {
                goto label_7;
            }
            
            var val_3 = val_1 + 8;
            goto label_11;
            label_7:
            val_6 = null;
            val_6 = null;
            bool val_4 = AssetBundles.AssetBundleManager.m_Dependencies.Remove(key:  X1);
        }
        protected static void UnloadAssetBundleInternal(string assetBundleName)
        {
            var val_5;
            AssetBundles.LoadedAssetBundle val_2 = AssetBundles.AssetBundleManager.GetLoadedAssetBundle(assetBundleName:  null, error: out  X1);
            if(val_2 == null)
            {
                    return;
            }
            
            int val_5 = val_2.m_ReferencedCount;
            val_5 = val_5 - 1;
            val_2.m_ReferencedCount = val_5;
            if(val_5 != 0)
            {
                    return;
            }
            
            val_2.OnUnload();
            val_5 = null;
            val_5 = null;
            bool val_3 = AssetBundles.AssetBundleManager.m_LoadedAssetBundles.Remove(key:  X1);
            AssetBundles.AssetBundleManager.Log(logType:  0 + X1, text:  0);
        }
        private void Update()
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            val_3 = 0;
            goto label_3;
            label_12:
            val_3 = 1;
            goto label_3;
            label_16:
            X21.RemoveAt(index:  1);
            X21.ProcessFinishedOperation(operation:  static_value_02131000);
            label_3:
            val_4 = null;
            val_4 = null;
            if(val_3 >= AssetBundles.AssetBundleManager.m_InProgressOperations.Count)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            if((AssetBundles.AssetBundleManager.m_InProgressOperations.Item[1] & 1) != 0)
            {
                goto label_12;
            }
            
            val_6 = null;
            val_6 = null;
            if(AssetBundles.AssetBundleManager.m_InProgressOperations != null)
            {
                goto label_16;
            }
            
            goto label_16;
        }
        private void ProcessFinishedOperation(AssetBundles.AssetBundleLoadOperation operation)
        {
            if(operation == null)
            {
                    return;
            }
        
        }
        public static AssetBundles.AssetBundleLoadAssetOperation LoadAssetAsync(string assetBundleName, string assetName, System.Type type)
        {
            LogType val_4;
            typeof(System.String[]).__il2cppRuntimeField_20 = "Loading ";
            typeof(System.String[]).__il2cppRuntimeField_28 = type;
            typeof(System.String[]).__il2cppRuntimeField_30 = " from ";
            typeof(System.String[]).__il2cppRuntimeField_38 = assetName;
            typeof(System.String[]).__il2cppRuntimeField_40 = " bundle";
            string val_1 = +0;
            val_4 = null;
            AssetBundles.AssetBundleManager.Log(logType:  val_4, text:  0);
            string val_2 = AssetBundles.AssetBundleManager.RemapVariantName(assetBundleName:  val_4);
            AssetBundles.AssetBundleManager.LoadAssetBundle(assetBundleName:  val_2);
            object val_3 = new System.Object();
            typeof(AssetBundles.AssetBundleLoadAssetOperationFull).__il2cppRuntimeField_10 = val_2;
            typeof(AssetBundles.AssetBundleLoadAssetOperationFull).__il2cppRuntimeField_18 = type;
            typeof(AssetBundles.AssetBundleLoadAssetOperationFull).__il2cppRuntimeField_28 = X3;
            AssetBundles.AssetBundleManager.m_InProgressOperations.Add(item:  val_3);
            return (AssetBundles.AssetBundleLoadAssetOperation)val_3;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        public static System.Collections.IEnumerator GetAssetDownloadSize(string assetName, System.Action<string> callback)
        {
            if(null != 0)
            {
                    typeof(AssetBundleManager.<GetAssetDownloadSize>c__Iterator0).__il2cppRuntimeField_10 = callback;
            }
            else
            {
                    mem[16] = callback;
            }
            
            typeof(AssetBundleManager.<GetAssetDownloadSize>c__Iterator0).__il2cppRuntimeField_38 = X2;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public static AssetBundles.AssetBundleLoadOperation LoadLevelAsync(string assetBundleName, string levelName, bool isAdditive)
        {
            LogType val_5;
            typeof(System.String[]).__il2cppRuntimeField_20 = "Loading ";
            typeof(System.String[]).__il2cppRuntimeField_28 = isAdditive;
            typeof(System.String[]).__il2cppRuntimeField_30 = " from ";
            typeof(System.String[]).__il2cppRuntimeField_38 = levelName;
            typeof(System.String[]).__il2cppRuntimeField_40 = " bundle";
            string val_1 = +0;
            val_5 = null;
            AssetBundles.AssetBundleManager.Log(logType:  val_5, text:  0);
            string val_2 = AssetBundles.AssetBundleManager.RemapVariantName(assetBundleName:  val_5);
            AssetBundles.AssetBundleManager.LoadAssetBundle(assetBundleName:  val_2);
            object val_3 = new System.Object();
            typeof(AssetBundles.AssetBundleLoadLevelOperation).__il2cppRuntimeField_10 = val_2;
            typeof(AssetBundles.AssetBundleLoadLevelOperation).__il2cppRuntimeField_18 = isAdditive;
            typeof(AssetBundles.AssetBundleLoadLevelOperation).__il2cppRuntimeField_20 = W3 & 1;
            AssetBundles.AssetBundleManager.m_InProgressOperations.Add(item:  val_3);
            return (AssetBundles.AssetBundleLoadOperation)val_3;
        }
        private static AssetBundleManager()
        {
            var val_6;
            AssetBundles.AssetBundleManager.m_LogMode = 0;
            val_6 = null;
            val_6 = null;
            AssetBundles.AssetBundleManager.m_BaseDownloadingURL = System.String.Empty;
            AssetBundles.AssetBundleManager.m_ActiveVariants = null;
            AssetBundles.AssetBundleManager.m_AssetBundleManifest = 0;
            AssetBundles.AssetBundleManager.m_LoadedAssetBundles = new System.Collections.Generic.Dictionary<System.String, AssetBundles.LoadedAssetBundle>();
            AssetBundles.AssetBundleManager.m_DownloadingErrors = new System.Collections.Generic.Dictionary<System.String, System.String>();
            AssetBundles.AssetBundleManager.m_DownloadingBundles = new System.Collections.Generic.List<System.String>();
            AssetBundles.AssetBundleManager.m_InProgressOperations = new System.Collections.Generic.List<AssetBundles.AssetBundleLoadOperation>();
            AssetBundles.AssetBundleManager.m_Dependencies = new System.Collections.Generic.Dictionary<System.String, System.String[]>();
        }
    
    }

}
