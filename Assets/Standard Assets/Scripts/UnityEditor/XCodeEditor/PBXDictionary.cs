using UnityEngine;

namespace UnityEditor.XCodeEditor
{
    public class PBXDictionary : Dictionary<string, object>
    {
        // Methods
        public PBXDictionary()
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
        public void Append(UnityEditor.XCodeEditor.PBXSortedDictionary dictionary)
        {
            var val_4;
            var val_5;
            SortedDictionary.Enumerator<TKey, TValue> val_1 = dictionary.GetEnumerator();
            label_3:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            UnityEngine.Hash128 val_2 = 0.hash;
            this.Add(key:  val_2.m_u32_0.InitializationCallback, value:  val_2.m_u32_0);
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
        public void Append<T>(UnityEditor.XCodeEditor.PBXSortedDictionary<T> dictionary)
        {
            var val_1;
            var val_2;
            var val_3;
            var val_8;
            var val_9;
            var val_10;
            label_4:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            UnityEngine.Hash128 val_4 = val_3.hash;
            this.Add(key:  val_4.m_u32_0.InitializationCallback, value:  val_4.m_u32_0);
            goto label_4;
            label_2:
            val_8 = 0;
            val_9 = 76;
            val_3 = __RuntimeMethodHiddenParam + 48 + 48;
            val_1 = val_2;
            val_2 = val_3;
            if((__RuntimeMethodHiddenParam + 48 + 48 + 258) == 0)
            {
                goto label_9;
            }
            
            var val_7 = __RuntimeMethodHiddenParam + 48 + 48 + 152;
            var val_8 = 0;
            val_7 = val_7 + 8;
            label_8:
            if(((__RuntimeMethodHiddenParam + 48 + 48 + 152 + 8) + -8) == null)
            {
                goto label_7;
            }
            
            val_8 = val_8 + 1;
            val_7 = val_7 + 16;
            if(val_8 < (__RuntimeMethodHiddenParam + 48 + 48 + 258))
            {
                goto label_8;
            }
            
            goto label_9;
            label_7:
            val_10 = ((__RuntimeMethodHiddenParam + 48 + 48) + (((__RuntimeMethodHiddenParam + 48 + 48 + 152 + 8)) << 4)) + 272;
            label_9:
            if(76 == 76)
            {
                    return;
            }
            
            if(val_8 == 0)
            {
                    return;
            }
        
        }
        public static bool op_Implicit(UnityEditor.XCodeEditor.PBXDictionary x)
        {
            var val_3;
            if(X1 != 0)
            {
                    var val_2 = (X1.Count == 0) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        public string ToCSV()
        {
            null = null;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.GetEnumerator();
            label_6:
            if((0 & 1) == 0)
            {
                goto label_9;
            }
            
            UnityEngine.Playables.PlayableHandle val_2 = 0.GetHandle();
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_4 = val_2.m_Handle.InitializationCallback;
            string val_7 = 0 + 0 + 0 + 0 + System.String.Empty(0 + System.String.Empty)(0 + 0 + System.String.Empty(0 + System.String.Empty))(0 + 0 + 0 + System.String.Empty(0 + System.String.Empty)(0 + 0 + System.String.Empty(0 + System.String.Empty)));
            string val_8 = 0 + val_7;
            goto label_6;
            label_9:
            0.Dispose();
            if((0 & 1) != 0)
            {
                    return val_7;
            }
            
            if(null == null)
            {
                    return val_7;
            }
            
            return val_7;
        }
        public override string ToString()
        {
            return 0 + "{" + this.ToCSV();
        }
    
    }

}
