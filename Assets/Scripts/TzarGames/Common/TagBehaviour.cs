using UnityEngine;

namespace TzarGames.Common
{
    public class TagBehaviour : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.StringID[] tags;
        
        // Methods
        public TagBehaviour()
        {
        
        }
        public bool HasTag(string tag)
        {
            TzarGames.Common.StringID[] val_4;
            var val_5;
            var val_5 = 0;
            label_8:
            val_4 = this.tags;
            if(val_5 >= this.tags.Length)
            {
                goto label_2;
            }
            
            val_4 = this.tags[0].Name;
            val_5 = val_5 + 1;
            if((System.String.op_Equality(a:  0, b:  val_4)) == false)
            {
                goto label_8;
            }
            
            val_5 = 1;
            return (bool)val_5;
            label_2:
            val_5 = 0;
            return (bool)val_5;
        }
    
    }

}
