using UnityEngine;

namespace TzarGames.Common
{
    public class SurfaceSoundProvider : MonoBehaviour
    {
        // Fields
        private static TzarGames.Common.SurfaceSoundProvider provider;
        [UnityEngine.SerializeField]
        private System.Collections.Generic.List<TzarGames.Common.SurfaceSoundProvider.SurfacePair> surfaceCollisionInfo;
        
        // Methods
        public SurfaceSoundProvider()
        {
        
        }
        private void Awake()
        {
            TzarGames.Common.SurfaceSoundProvider.provider = this;
        }
        private void OnDestroy()
        {
            TzarGames.Common.SurfaceSoundProvider.provider = 0;
        }
        public static UnityEngine.AudioClip GetCollisionClip(string firstSurfaceName, string secondSurfaceName)
        {
            var val_8;
            string val_10;
            string val_11;
            var val_12;
            int val_21;
            string val_22;
            var val_23;
            val_21 = X2;
            val_22 = 1152921504721543168;
            if(0 == TzarGames.Common.SurfaceSoundProvider.provider)
            {
                    TzarGames.Common.SurfaceSoundProvider.provider = UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>();
                val_23 = 0;
                if(0 == TzarGames.Common.SurfaceSoundProvider.provider)
            {
                    return (UnityEngine.AudioClip)val_23;
            }
            
            }
            
            List.Enumerator<T> val_5 = val_2.surfaceCollisionInfo.GetEnumerator();
            label_21:
            if((0 & 1) == 0)
            {
                goto label_9;
            }
            
            GooglePlayGames.BasicApi.Nearby.EndpointDetails val_9 = val_8.RemoteEndpoint;
            val_22 = val_10;
            if((System.String.op_Equality(a:  0, b:  val_22)) != false)
            {
                    if((System.String.op_Equality(a:  0, b:  val_11)) == true)
            {
                goto label_15;
            }
            
            }
            
            if(((System.String.op_Equality(a:  0, b:  val_22)) == false) || ((System.String.op_Equality(a:  0, b:  val_11)) == false))
            {
                goto label_21;
            }
            
            label_15:
            int val_18 = val_12.Count;
            val_21 = UnityEngine.Random.Range(min:  0, max:  0);
            val_23 = val_12.Item[val_21];
            val_8.Dispose();
            return (UnityEngine.AudioClip)val_23;
            label_9:
            val_8.Dispose();
            val_23 = 0;
            return (UnityEngine.AudioClip)val_23;
        }
        public void AddSurfaceCollisionClip(string firstSurfaceName, string secondSurfaceName, UnityEngine.AudioClip clip)
        {
            string val_3;
            string val_4;
            var val_5;
            System.Collections.Generic.List<SurfacePair> val_12;
            System.Collections.Generic.List<UnityEngine.AudioClip> val_13;
            val_12 = 1152921504608284672;
            val_13 = 0;
            goto label_1;
            label_16:
            val_13 = 1;
            label_1:
            if(val_13 >= this.surfaceCollisionInfo.Count)
            {
                goto label_3;
            }
            
            SurfacePair val_2 = this.surfaceCollisionInfo.Item[1];
            if((System.String.op_Equality(a:  0, b:  val_3)) != false)
            {
                    if((System.String.op_Equality(a:  0, b:  val_4)) == true)
            {
                goto label_10;
            }
            
            }
            
            if(((System.String.op_Equality(a:  0, b:  val_3)) == false) || ((System.String.op_Equality(a:  0, b:  val_4)) == false))
            {
                goto label_16;
            }
            
            label_10:
            val_5.Add(item:  clip);
            return;
            label_3:
            System.Collections.Generic.List<UnityEngine.AudioClip> val_11 = null;
            val_13 = val_11;
            val_11 = new System.Collections.Generic.List<UnityEngine.AudioClip>();
            Add(item:  clip);
            val_12 = this.surfaceCollisionInfo;
            val_12.Add(item:  new SurfacePair() {FirstSurfaceName = firstSurfaceName, SecondSurfaceName = secondSurfaceName, Clips = val_13});
        }
    
    }

}
