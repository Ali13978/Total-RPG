using UnityEngine;

namespace TzarGames.Common
{
    public class ShowAds : MonoBehaviour
    {
        // Fields
        public TzarGames.Common.Ad Ad;
        [UnityEngine.TooltipAttribute]
        public int DisplayAcrossTimes;
        [UnityEngine.TooltipAttribute]
        public int DisplayAfter;
        public bool OpenOnce;
        public bool ShowOnEnable;
        public bool ShowOnStart;
        public bool ShowOnDisable;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private string guid;
        private const string AD_PREFIX = "AD_INFO_";
        private TzarGames.Common.AdInfo currentAdInfo;
        public UnityEngine.Events.UnityEvent OnAdFinished;
        public UnityEngine.Events.UnityEvent OnAdSkipped;
        public UnityEngine.Events.UnityEvent OnAdFailed;
        
        // Methods
        public ShowAds()
        {
            this.DisplayAcrossTimes = 1;
        }
        private void Reset()
        {
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    System.Guid val_2 = System.Guid.NewGuid();
                this.guid = ;
                string val_3 = 0 + "Unique GUID for ad: "("Unique GUID for ad: ");
                UnityEngine.Debug.Log(message:  0);
            }
            
            this.saveAdInfo(info:  new TzarGames.Common.AdInfo());
        }
        private void Awake()
        {
            string val_8;
            string val_1 = this.getAdKey();
            val_8 = this.guid;
            string val_2 = 0 + "AD_INFO_";
            if((UnityEngine.PlayerPrefs.HasKey(key:  0)) != true)
            {
                    TzarGames.Common.AdInfo val_5 = null;
                val_8 = val_5;
                val_5 = new TzarGames.Common.AdInfo();
                this.saveAdInfo(info:  val_8);
            }
            
            string val_6 = UnityEngine.PlayerPrefs.GetString(key:  0);
            this.currentAdInfo = UnityEngine.JsonUtility.FromJson<EncodedData>(json:  0);
        }
        private void Start()
        {
            if(this.ShowOnStart == false)
            {
                    return;
            }
            
            this.ShowAd();
        }
        private string getAdKey()
        {
            return 0 + "AD_INFO_";
        }
        private void saveAdInfo(TzarGames.Common.AdInfo info)
        {
            string val_1 = UnityEngine.JsonUtility.ToJson(obj:  0);
            string val_2 = 0 + "Saving ad info: "("Saving ad info: ");
            UnityEngine.Debug.Log(message:  0);
            UnityEngine.PlayerPrefs.SetString(key:  0, value:  this.getAdKey());
        }
        private void OnEnable()
        {
            if(this.ShowOnEnable == false)
            {
                    return;
            }
            
            this.ShowAd();
        }
        private void OnDisable()
        {
            if(this.ShowOnDisable == false)
            {
                    return;
            }
            
            this.ShowAd();
        }
        private TzarGames.Common.IAdsService getService()
        {
            return TzarGames.Common.Ads.AdsServiceManager.GetReadyServiceForAd(ad:  0);
        }
        public void RequestAd()
        {
            TzarGames.Common.Ads.AdsServiceManager.RequestAdServicesForAd(ad:  0);
        }
        public bool IsReady()
        {
            var val_3;
            var val_4;
            val_3 = 0;
            TzarGames.Common.IAdsService val_1 = TzarGames.Common.Ads.AdsServiceManager.GetReadyServiceForAd(ad:  0);
            if(val_1 == null)
            {
                    return false;
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = 0;
            val_4 = val_1;
        }
        public void ShowAd()
        {
            int val_10;
            var val_11;
            TzarGames.Common.AdInfo val_12;
            int val_13;
            TzarGames.Common.AdInfo val_14;
            int val_15;
            if((this.OpenOnce != false) && (this.currentAdInfo.showCount >= 1))
            {
                    UnityEngine.Debug.Log(message:  0);
                this.OnShowAdResult(result:  2);
                return;
            }
            
            TzarGames.Common.IAdsService val_1 = TzarGames.Common.Ads.AdsServiceManager.GetReadyServiceForAd(ad:  0);
            if(val_1 == null)
            {
                goto label_6;
            }
            
            if(this.currentAdInfo.attemtCount < this.DisplayAfter)
            {
                goto label_8;
            }
            
            val_10 = this.DisplayAcrossTimes;
            if(val_10 < 2)
            {
                goto label_11;
            }
            
            if(this.currentAdInfo == null)
            {
                    val_10 = this.DisplayAcrossTimes;
            }
            
            val_10 = this.currentAdInfo.showCount - ((this.currentAdInfo.showCount / val_10) * val_10);
            if(val_10 == 0)
            {
                goto label_11;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Skip ad display: DisplayAcrossTimes";
            typeof(System.Object[]).__il2cppRuntimeField_28 = this.DisplayAcrossTimes;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " Show count:";
            typeof(System.Object[]).__il2cppRuntimeField_38 = this.currentAdInfo.showCount;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            string val_3 = +0;
            UnityEngine.Debug.Log(message:  0);
            goto label_30;
            label_6:
            string val_4 = this.Ad.Name;
            string val_5 = 0 + "Advertisement is not ready: "("Advertisement is not ready: ");
            UnityEngine.Debug.LogWarning(message:  0);
            return;
            label_11:
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Display Ad: ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = this.Ad.Name;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " DisplayAcrossTimes";
            typeof(System.Object[]).__il2cppRuntimeField_38 = this.DisplayAcrossTimes;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_40 = " Show count:";
            typeof(System.Object[]).__il2cppRuntimeField_48 = this.currentAdInfo.showCount;
            typeof(System.Object[]).__il2cppRuntimeField_4C = 268435457;
            string val_7 = +0;
            UnityEngine.Debug.Log(message:  0);
            System.Action<TzarGames.Common.ShowResult> val_8 = new System.Action<TzarGames.Common.ShowResult>(object:  this, method:  System.Void TzarGames.Common.ShowAds::OnShowAdResult(TzarGames.Common.ShowResult result));
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_11 = val_1;
            label_30:
            val_12 = this.currentAdInfo;
            if(val_12 != null)
            {
                    val_13 = this.currentAdInfo.showCount;
            }
            else
            {
                    val_12 = 16;
                val_13 = 11993091;
            }
            
            mem[16] = 11993092;
            label_8:
            val_14 = this.currentAdInfo;
            if(val_14 != null)
            {
                    val_15 = this.currentAdInfo.attemtCount;
            }
            else
            {
                    val_14 = 20;
                val_15 = 1;
            }
            
            mem[20] = 2;
            this.saveAdInfo(info:  this.currentAdInfo);
        }
        private void OnShowAdResult(TzarGames.Common.ShowResult result)
        {
            UnityEngine.Events.UnityEvent val_2 = this;
            string val_1 = 0 + "Advert show result: "("Advert show result: ");
            UnityEngine.Debug.Log(message:  0);
            if(result == 0)
            {
                goto label_5;
            }
            
            if(result == 1)
            {
                goto label_6;
            }
            
            if(result != 2)
            {
                    return;
            }
            
            val_2 = this.OnAdFinished;
            if(val_2 != null)
            {
                goto label_12;
            }
            
            goto label_11;
            label_5:
            val_2 = this.OnAdFailed;
            if(val_2 != null)
            {
                goto label_12;
            }
            
            goto label_11;
            label_6:
            val_2 = this.OnAdSkipped;
            if(val_2 != null)
            {
                goto label_12;
            }
            
            label_11:
            label_12:
            val_2.Invoke();
        }
    
    }

}
