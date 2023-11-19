using UnityEngine;

namespace TzarGames.Endless
{
    public static class EndlessInAppManager
    {
        // Fields
        public const int veryBigPackCount = 1200;
        public const int smallPackRubyCount = 10;
        public const int mediumPackRubyCount = 50;
        public const int bigPackRubyCount = 300;
        public const int fullGameRubyBonus = 5;
        public const string veryBigPackId = "ruby_very_big_pack";
        public const string smallPackId = "ruby_small_pack";
        public const string mediumPackId = "ruby_medium_pack";
        public const string bigPackId = "ruby_big_pack";
        public const string bigFullGameId = "full_game";
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action OnGamePurchased;
        private static System.Action<UnityEngine.Purchasing.PurchaseEventArgs> <>f__mg$cache0;
        private static System.Action <>f__mg$cache1;
        private static System.Action <>f__mg$cache2;
        
        // Properties
        public static bool IsInitialized { get; }
        
        // Methods
        private static EndlessInAppManager()
        {
            System.Action<UnityEngine.Purchasing.PurchaseEventArgs> val_4 = TzarGames.Endless.EndlessInAppManager.<>f__mg$cache0;
            if(val_4 == null)
            {
                    TzarGames.Endless.EndlessInAppManager.<>f__mg$cache0 = new System.Action<UnityEngine.Purchasing.PurchaseEventArgs>(object:  0, method:  static System.Void TzarGames.Endless.EndlessInAppManager::UnityInAppManagerOnOnProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e));
                val_4 = TzarGames.Endless.EndlessInAppManager.<>f__mg$cache0;
            }
            
            TzarGames.Common.UnityInAppManager.add_OnProcessPurchase(value:  0);
            if((TzarGames.Endless.EndlessInAppManager.<>f__mg$cache1) == null)
            {
                    val_4 = static System.Void TzarGames.Endless.EndlessInAppManager::checkAndRestoreFullGamePurchase();
                TzarGames.Endless.EndlessInAppManager.<>f__mg$cache1 = new System.Action(object:  0, method:  val_4);
            }
            
            TzarGames.Endless.EndlessGameState.add_OnLobbyLoaded(value:  0);
            if((TzarGames.Endless.EndlessInAppManager.<>f__mg$cache2) == null)
            {
                    val_4 = static System.Void TzarGames.Endless.EndlessInAppManager::checkAndRestoreFullGamePurchase();
                TzarGames.Endless.EndlessInAppManager.<>f__mg$cache2 = new System.Action(object:  0, method:  val_4);
            }
            
            TzarGames.Endless.EndlessGameState.add_OnMainMenuLoaded(value:  0);
        }
        public static void add_OnGamePurchased(System.Action value)
        {
            var val_3;
            System.Action val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = TzarGames.Endless.EndlessInAppManager.OnGamePurchased;
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  null);
            val_5 = 0;
            if(val_1 == null)
            {
                    return;
            }
            
            val_5 = val_1;
            if(null == null)
            {
                    return;
            }
            
            val_5 = 0;
        }
        public static void remove_OnGamePurchased(System.Action value)
        {
            var val_3;
            System.Action val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = TzarGames.Endless.EndlessInAppManager.OnGamePurchased;
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  null);
            val_5 = 0;
            if(val_1 == null)
            {
                    return;
            }
            
            val_5 = val_1;
            if(null == null)
            {
                    return;
            }
            
            val_5 = 0;
        }
        private static void UnityInAppManagerOnOnProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e)
        {
            string val_3 = X1.purchasedProduct.definition.id;
            typeof(System.Object[]).__il2cppRuntimeField_20 = val_3;
            UnityEngine.Debug.LogFormat(format:  0, args:  "EndlessInAppManager: ProcessingPurchase {0}");
            if((System.String.op_Equality(a:  0, b:  val_3)) != false)
            {
                    UnityEngine.Debug.Log(message:  0);
                TzarGames.Endless.EndlessGameState.Instance.SetGamePurchased(saveGame:  true);
            }
            
            if(((System.String.op_Equality(a:  0, b:  val_3)) != true) && ((System.String.op_Equality(a:  0, b:  val_3)) != true))
            {
                    if((System.String.op_Equality(a:  0, b:  val_3)) != true)
            {
                    if((System.String.op_Equality(a:  0, b:  val_3)) == false)
            {
                    return;
            }
            
            }
            
            }
            
            string val_13 = 0 + "EndlessInAppManager: Rewarding rubies {0}"("EndlessInAppManager: Rewarding rubies {0}");
            UnityEngine.Debug.Log(message:  0);
            TzarGames.Endless.Rewarder.Instance.RewardRubies(rubyCount:  TzarGames.Endless.EndlessInAppManager.getRubyCountForProductId(productId:  null));
        }
        public static bool get_IsInitialized()
        {
            if(0 == TzarGames.Common.UnityInAppManager.Instance)
            {
                    return false;
            }
            
            TzarGames.Common.UnityInAppManager val_3 = TzarGames.Common.UnityInAppManager.Instance;
            if(val_3 != null)
            {
                    return val_3.IsInitialized;
            }
            
            return val_3.IsInitialized;
        }
        private static void buy(string productId, System.Action<TzarGames.Common.IPurchaseResult> resultCallback)
        {
            typeof(EndlessInAppManager.<buy>c__AnonStorey0).__il2cppRuntimeField_10 = X2;
            if(0 != TzarGames.Common.UnityInAppManager.Instance)
            {
                    TzarGames.Common.UnityInAppManager.Instance.InitiatePurchase(productId:  resultCallback, resultCallback:  new System.Action<TzarGames.Common.IPurchaseResult>(object:  new System.Object(), method:  System.Void EndlessInAppManager.<buy>c__AnonStorey0::<>m__0(TzarGames.Common.IPurchaseResult result)));
                return;
            }
            
            UnityEngine.Debug.LogError(message:  0);
            if((typeof(EndlessInAppManager.<buy>c__AnonStorey0).__il2cppRuntimeField_10) == 0)
            {
                    return;
            }
            
            if(null != 0)
            {
                    Success = false;
            }
            else
            {
                    Success = false;
            }
            
            FailureReason = 7;
            typeof(EndlessInAppManager.<buy>c__AnonStorey0).__il2cppRuntimeField_10.Invoke(obj:  new TzarGames.Common.PurchaseResult());
        }
        private static int getRubyCountForProductId(string productId)
        {
            string val_14;
            var val_15;
            val_14 = X1;
            if(val_14 != 0)
            {
                    if((System.String.op_Equality(a:  0, b:  val_14)) != false)
            {
                    val_14 = TzarGames.Endless.EndlessGameState.Instance;
                if(val_14.IsGamePurchased() != true)
            {
                    val_14 = TzarGames.Endless.EndlessGameState.Instance;
                val_14.SetGamePurchased(saveGame:  false);
            }
            
                val_15 = 300;
                return 1200;
            }
            
                if((System.String.op_Equality(a:  0, b:  val_14)) != false)
            {
                    val_15 = 50;
                return 1200;
            }
            
                if((System.String.op_Equality(a:  0, b:  val_14)) != false)
            {
                    val_15 = 10;
                return 1200;
            }
            
                if((System.String.op_Equality(a:  0, b:  val_14)) != false)
            {
                    val_15 = 1200;
                return 1200;
            }
            
            }
            
            System.ArgumentOutOfRangeException val_13 = new System.ArgumentOutOfRangeException();
        }
        private static void buy_ruby(string productId, System.Action<TzarGames.Common.IPurchaseResult> resultCallback)
        {
            string val_7;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_7 = val_1;
                typeof(EndlessInAppManager.<buy_ruby>c__AnonStorey1).__il2cppRuntimeField_10 = resultCallback;
            }
            else
            {
                    val_7 = 16;
                mem[16] = resultCallback;
            }
            
            typeof(EndlessInAppManager.<buy_ruby>c__AnonStorey1).__il2cppRuntimeField_18 = X2;
            if(0 != TzarGames.Common.UnityInAppManager.Instance)
            {
                    TzarGames.Common.UnityInAppManager.Instance.InitiatePurchase(productId:  val_7, resultCallback:  new System.Action<TzarGames.Common.IPurchaseResult>(object:  val_1, method:  System.Void EndlessInAppManager.<buy_ruby>c__AnonStorey1::<>m__0(TzarGames.Common.IPurchaseResult result)));
                return;
            }
            
            UnityEngine.Debug.LogError(message:  0);
            if((typeof(EndlessInAppManager.<buy_ruby>c__AnonStorey1).__il2cppRuntimeField_18) == 0)
            {
                    return;
            }
            
            if(null != 0)
            {
                    Success = false;
            }
            else
            {
                    Success = false;
            }
            
            FailureReason = 7;
            typeof(EndlessInAppManager.<buy_ruby>c__AnonStorey1).__il2cppRuntimeField_18.Invoke(obj:  new TzarGames.Common.PurchaseResult());
        }
        public static string GetLocalizedPriceForVeryBigPack()
        {
            if(0 == TzarGames.Common.UnityInAppManager.Instance)
            {
                    return 0;
            }
            
            TzarGames.Common.UnityInAppManager val_4 = TzarGames.Common.UnityInAppManager.Instance;
            if(val_4 != null)
            {
                    return val_4.GetLocalizedPriceForProduct(productId:  "ruby_very_big_pack");
            }
            
            return val_4.GetLocalizedPriceForProduct(productId:  "ruby_very_big_pack");
        }
        public static string GetLocalizedPriceForSmallPack()
        {
            if(0 == TzarGames.Common.UnityInAppManager.Instance)
            {
                    return 0;
            }
            
            TzarGames.Common.UnityInAppManager val_4 = TzarGames.Common.UnityInAppManager.Instance;
            if(val_4 != null)
            {
                    return val_4.GetLocalizedPriceForProduct(productId:  "ruby_small_pack");
            }
            
            return val_4.GetLocalizedPriceForProduct(productId:  "ruby_small_pack");
        }
        public static string GetLocalizedPriceForMediumPack()
        {
            if(0 == TzarGames.Common.UnityInAppManager.Instance)
            {
                    return 0;
            }
            
            TzarGames.Common.UnityInAppManager val_4 = TzarGames.Common.UnityInAppManager.Instance;
            if(val_4 != null)
            {
                    return val_4.GetLocalizedPriceForProduct(productId:  "ruby_medium_pack");
            }
            
            return val_4.GetLocalizedPriceForProduct(productId:  "ruby_medium_pack");
        }
        public static string GetLocalizedPriceForBigPack()
        {
            if(0 == TzarGames.Common.UnityInAppManager.Instance)
            {
                    return 0;
            }
            
            TzarGames.Common.UnityInAppManager val_4 = TzarGames.Common.UnityInAppManager.Instance;
            if(val_4 != null)
            {
                    return val_4.GetLocalizedPriceForProduct(productId:  "ruby_big_pack");
            }
            
            return val_4.GetLocalizedPriceForProduct(productId:  "ruby_big_pack");
        }
        public static void BuyVeryBigRubyPack(System.Action<TzarGames.Common.IPurchaseResult> resultCallback)
        {
            TzarGames.Endless.EndlessInAppManager.buy_ruby(productId:  null, resultCallback:  "ruby_very_big_pack");
        }
        public static void BuySmallRubyPack(System.Action<TzarGames.Common.IPurchaseResult> resultCallback)
        {
            TzarGames.Endless.EndlessInAppManager.buy_ruby(productId:  null, resultCallback:  "ruby_small_pack");
        }
        public static void BuyMediumRubyPack(System.Action<TzarGames.Common.IPurchaseResult> resultCallback)
        {
            TzarGames.Endless.EndlessInAppManager.buy_ruby(productId:  null, resultCallback:  "ruby_medium_pack");
        }
        public static void BuyBigRubyPack(System.Action<TzarGames.Common.IPurchaseResult> resultCallback)
        {
            TzarGames.Endless.EndlessInAppManager.buy_ruby(productId:  null, resultCallback:  "ruby_big_pack");
        }
        private static void checkAndRestoreFullGamePurchase()
        {
            var val_7 = TzarGames.Common.UnityInAppManager.Instance;
            if((val_7.IsProductPurchased(productId:  "full_game")) == false)
            {
                    return;
            }
            
            val_7 = TzarGames.Endless.EndlessGameState.Instance;
            if(val_7.IsGamePurchased() != false)
            {
                    return;
            }
            
            TzarGames.Endless.EndlessGameState.Instance.SetGamePurchased(saveGame:  true);
        }
        public static void BuyFullGame(System.Action<TzarGames.Common.IPurchaseResult> resultCallback)
        {
            typeof(EndlessInAppManager.<BuyFullGame>c__AnonStorey2).__il2cppRuntimeField_10 = X1;
            TzarGames.Endless.EndlessInAppManager.checkAndRestoreFullGamePurchase();
            if(TzarGames.Endless.EndlessGameState.Instance.IsGamePurchased() == false)
            {
                goto label_5;
            }
            
            if(null == 0)
            {
                goto label_6;
            }
            
            Success = true;
            goto label_7;
            label_5:
            System.Action<TzarGames.Common.IPurchaseResult> val_5 = new System.Action<TzarGames.Common.IPurchaseResult>(object:  new System.Object(), method:  System.Void EndlessInAppManager.<BuyFullGame>c__AnonStorey2::<>m__0(TzarGames.Common.IPurchaseResult x));
            TzarGames.Endless.EndlessInAppManager.buy(productId:  null, resultCallback:  "full_game");
            return;
            label_6:
            Success = true;
            label_7:
            ProductID = "full_game";
            typeof(EndlessInAppManager.<BuyFullGame>c__AnonStorey2).__il2cppRuntimeField_10.Invoke(obj:  new TzarGames.Common.PurchaseResult());
        }
    
    }

}
