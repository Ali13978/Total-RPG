using UnityEngine;

namespace UnityEditor.XCodeEditor
{
    public class PBXSortedDictionary : SortedDictionary<string, object>
    {
        // Methods
        public PBXSortedDictionary()
        {
        
        }
        public void Append(UnityEditor.XCodeEditor.PBXDictionary dictionary)
        {
            var val_4;
            var val_5;
            Dictionary.Enumerator<TKey, TValue> val_1 = dictionary.GetEnumerator();
            label_3:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            UnityEngine.Playables.PlayableHandle val_2 = 0.GetHandle();
            this.Add(key:  val_2.m_Handle.InitializationCallback, value:  val_2.m_Handle);
            goto label_3;
            label_2:
            val_4 = 0;
            val_5 = 1;
            0.Dispose();
            if((val_5 & 1) != 0)
            {
                    return;
            }
            
            if(val_4 == 0)
            {
                    return;
            }
        
        }
        public void Append<T>(UnityEditor.XCodeEditor.PBXDictionary<T> dictionary)
        {
            var val_1;
            var val_2;
            var val_7;
            var val_8;
            var val_9;
            label_4:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            UnityEngine.Playables.PlayableHandle val_3 = val_1.GetHandle();
            this.Add(key:  val_3.m_Handle.InitializationCallback, value:  val_3.m_Handle);
            goto label_4;
            label_2:
            val_7 = 0;
            val_8 = 76;
            val_1 = __RuntimeMethodHiddenParam + 48 + 48;
            val_2 = val_1;
            if((__RuntimeMethodHiddenParam + 48 + 48 + 258) == 0)
            {
                goto label_6;
            }
            
            var val_6 = __RuntimeMethodHiddenParam + 48 + 48 + 152;
            var val_7 = 0;
            val_6 = val_6 + 8;
            label_8:
            if(((__RuntimeMethodHiddenParam + 48 + 48 + 152 + 8) + -8) == null)
            {
                goto label_7;
            }
            
            val_7 = val_7 + 1;
            val_6 = val_6 + 16;
            if(val_7 < (__RuntimeMethodHiddenParam + 48 + 48 + 258))
            {
                goto label_8;
            }
            
            label_6:
            val_9;
            goto label_9;
            label_7:
            val_9 = ((__RuntimeMethodHiddenParam + 48 + 48) + (((__RuntimeMethodHiddenParam + 48 + 48 + 152 + 8)) << 4)) + 272;
            label_9:
            if(76 == 76)
            {
                    return;
            }
            
            if(val_7 == 0)
            {
                    return;
            }
        
        }
    
    }

}
