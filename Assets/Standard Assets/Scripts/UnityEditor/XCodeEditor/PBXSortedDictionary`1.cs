using UnityEngine;

namespace UnityEditor.XCodeEditor
{
    public class PBXSortedDictionary<T> : SortedDictionary<string, T>
    {
        // Methods
        public PBXSortedDictionary<T>()
        {
            if(this == null)
            {
                
            }
        
        }
        public PBXSortedDictionary<T>(UnityEditor.XCodeEditor.PBXDictionary genericDictionary)
        {
            var val_2;
            var val_20;
            var val_21;
            var val_22;
            Dictionary.Enumerator<TKey, TValue> val_1 = genericDictionary.GetEnumerator();
            label_31:
            if((0 & 1) == 0)
            {
                goto label_39;
            }
            
            UnityEngine.Playables.PlayableHandle val_4 = val_2.GetHandle();
            if(val_4.m_Handle != 0)
            {
                    if(val_4.m_Handle != 0)
            {
                goto label_5;
            }
            
            }
            
            if(val_4.m_Handle == 0)
            {
                goto label_6;
            }
            
            label_5:
            if(val_4.m_Handle != 0)
            {
                goto label_7;
            }
            
            label_6:
            label_7:
            object val_7 = 0.Item["isa"];
            if(val_7 != null)
            {
                    if(val_7 != null)
            {
                goto label_12;
            }
            
            }
            
            if(val_7 == null)
            {
                goto label_13;
            }
            
            label_12:
            val_20 = val_7;
            if(val_20 != null)
            {
                goto label_14;
            }
            
            label_13:
            val_20 = 0;
            label_14:
            if((val_20.CompareTo(strB:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != 0)
            {
                goto label_31;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_20 = val_4.m_Handle.InitializationCallback;
            if(val_4.m_Handle == 0)
            {
                goto label_22;
            }
            
            if(val_4.m_Handle == 0)
            {
                goto label_23;
            }
            
            if(val_4.m_Handle != 0)
            {
                goto label_25;
            }
            
            goto label_25;
            label_23:
            label_25:
            val_21 = ;
            if(val_4.m_Handle != 0)
            {
                goto label_26;
            }
            
            label_22:
            val_21 = 0;
            label_26:
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_21;
            object val_16 = System.Activator.CreateInstance(type:  0, args:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            if(val_16 == null)
            {
                goto label_28;
            }
            
            val_22 = val_16;
            if(val_22 != null)
            {
                goto label_29;
            }
            
            label_28:
            val_22 = 0;
            label_29:
            if(this != null)
            {
                goto label_31;
            }
            
            goto label_31;
        }
        public void Add(T newObject)
        {
            string val_1 = newObject.guid;
            if(this == null)
            {
                
            }
        
        }
        public void Append(UnityEditor.XCodeEditor.PBXDictionary<T> dictionary)
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
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_4 = val_3.m_Handle.InitializationCallback;
            if(this != null)
            {
                goto label_4;
            }
            
            goto label_4;
            label_2:
            val_7 = 0;
            val_8 = 71;
            val_1 = __RuntimeMethodHiddenParam + 24 + 168 + 80;
            val_2 = val_1;
            if((__RuntimeMethodHiddenParam + 24 + 168 + 80 + 258) == 0)
            {
                goto label_6;
            }
            
            var val_6 = __RuntimeMethodHiddenParam + 24 + 168 + 80 + 152;
            var val_7 = 0;
            val_6 = val_6 + 8;
            label_8:
            if(((__RuntimeMethodHiddenParam + 24 + 168 + 80 + 152 + 8) + -8) == null)
            {
                goto label_7;
            }
            
            val_7 = val_7 + 1;
            val_6 = val_6 + 16;
            if(val_7 < (__RuntimeMethodHiddenParam + 24 + 168 + 80 + 258))
            {
                goto label_8;
            }
            
            label_6:
            val_9;
            goto label_9;
            label_7:
            val_9 = ((__RuntimeMethodHiddenParam + 24 + 168 + 80) + (((__RuntimeMethodHiddenParam + 24 + 168 + 80 + 152 + 8)) << 4)) + 272;
            label_9:
            if(71 == 71)
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
