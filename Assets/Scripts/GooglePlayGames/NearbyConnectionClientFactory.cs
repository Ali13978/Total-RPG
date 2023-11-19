using UnityEngine;

namespace GooglePlayGames
{
    public static class NearbyConnectionClientFactory
    {
        // Methods
        public static void Create(System.Action<GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient> callback)
        {
            if(UnityEngine.Application.isEditor != false)
            {
                    GooglePlayGames.OurUtils.Logger.d(msg:  null);
                X1.Invoke(obj:  new GooglePlayGames.BasicApi.Nearby.DummyNearbyConnectionClient());
            }
            
            GooglePlayGames.OurUtils.Logger.d(msg:  null);
            GooglePlayGames.Native.NativeNearbyConnectionClientFactory.Create(callback:  0);
        }
        private static GooglePlayGames.BasicApi.Nearby.InitializationStatus ToStatus(GooglePlayGames.Native.Cwrapper.NearbyConnectionsStatus.InitializationStatus status)
        {
            var val_3;
            var val_4;
            string val_5;
            val_3 = W1;
            if((val_3 + 4) > 5)
            {
                goto label_1;
            }
            
            if((25812576 + ((W1 + 4)) << 2) == 3)
            {
                    return (GooglePlayGames.BasicApi.Nearby.InitializationStatus)val_4;
            }
            
            val_4 = 0;
            if((25812576 + ((W1 + 4)) << 2) == 6)
            {
                    return (GooglePlayGames.BasicApi.Nearby.InitializationStatus)val_4;
            }
            
            if((25812576 + ((W1 + 4)) << 2) == 5)
            {
                goto label_4;
            }
            
            label_1:
            val_3 = 0 + "Unknown initialization status: "("Unknown initialization status: ");
            val_5 = null;
            GooglePlayGames.OurUtils.Logger.w(msg:  val_5);
            label_4:
            val_4 = 2;
            return (GooglePlayGames.BasicApi.Nearby.InitializationStatus)val_4;
        }
    
    }

}
