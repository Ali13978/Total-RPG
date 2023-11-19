using UnityEngine;

namespace TzarGames.Common.Curves
{
    [Serializable]
    public class Connection
    {
        // Fields
        public System.Collections.Generic.List<TzarGames.Common.Curves.ConnectedSplineInfo> ConnectedSplines;
        
        // Methods
        public Connection()
        {
        
        }
        public TzarGames.Common.Curves.ConnectedSplineInfo GetSplineInfoById(int id)
        {
            var val_3;
            var val_4;
            val_3 = id;
            List.Enumerator<T> val_1 = this.ConnectedSplines.GetEnumerator();
            label_4:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            val_4 = 0.InitializationCallback;
            if(0 != val_3)
            {
                goto label_4;
            }
            
            0.Dispose();
            return (TzarGames.Common.Curves.ConnectedSplineInfo)val_4;
            label_2:
            0.Dispose();
            val_4 = 0;
            return (TzarGames.Common.Curves.ConnectedSplineInfo)val_4;
        }
        public void RemoveSplineById(int id)
        {
            typeof(Connection.<RemoveSplineById>c__AnonStorey0).__il2cppRuntimeField_10 = id;
            int val_3 = this.ConnectedSplines.RemoveAll(match:  new System.Predicate<TzarGames.Common.Curves.ConnectedSplineInfo>(object:  new System.Object(), method:  System.Boolean Connection.<RemoveSplineById>c__AnonStorey0::<>m__0(TzarGames.Common.Curves.ConnectedSplineInfo x)));
        }
        public bool ContainsSplineId(int id)
        {
            var val_3;
            var val_4;
            val_3 = id;
            List.Enumerator<T> val_1 = this.ConnectedSplines.GetEnumerator();
            label_4:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_2 = 0.InitializationCallback;
            if(0 != val_3)
            {
                goto label_4;
            }
            
            0.Dispose();
            val_4 = 1;
            return (bool)val_4;
            label_2:
            0.Dispose();
            val_4 = 0;
            return (bool)val_4;
        }
    
    }

}
