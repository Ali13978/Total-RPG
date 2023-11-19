using UnityEngine;

namespace UnityEditor.XCodeEditor
{
    public class PBXResolver
    {
        // Fields
        private UnityEditor.XCodeEditor.PBXDictionary objects;
        private string rootObject;
        private UnityEditor.XCodeEditor.PBXResolver.PBXResolverReverseIndex index;
        
        // Methods
        public PBXResolver(UnityEditor.XCodeEditor.PBXDictionary pbxData)
        {
            UnityEditor.XCodeEditor.PBXDictionary val_7;
            string val_8;
            if(pbxData.Item["objects"] != null)
            {
                
            }
            
            val_7 = 0;
            this.objects = val_7;
            this.index = new PBXResolver.PBXResolverReverseIndex();
            if(pbxData.Item["rootObject"] != null)
            {
                    if(null == null)
            {
                goto label_7;
            }
            
            }
            
            val_8 = 0;
            label_7:
            this.rootObject = val_8;
            this.BuildReverseIndex();
        }
        private void BuildReverseIndex()
        {
            var val_3;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            string val_35;
            var val_39;
            var val_41;
            var val_42;
            string val_43;
            var val_44;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.objects.GetEnumerator();
            val_30 = 1152921509319097760;
            val_31 = 0;
            goto label_70;
            label_75:
            UnityEngine.Playables.PlayableHandle val_4 = val_3.GetHandle();
            if(val_4.m_Handle == 0)
            {
                goto label_70;
            }
            
            val_32;
            val_32 = 0;
            System.Collections.IEnumerator val_10 = val_32.children.GetEnumerator();
            label_30:
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_33 = val_10;
            if(((val_10 & 1) & 1) == 0)
            {
                goto label_72;
            }
            
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_34 = val_10;
            val_35 = val_10;
            if(val_35 != null)
            {
                    if(null == null)
            {
                goto label_28;
            }
            
            }
            
            val_35 = 0;
            label_28:
            this.index.set_Item(key:  val_35, value:  val_4.m_Handle.InitializationCallback);
            goto label_30;
            label_72:
            if(val_10 == null)
            {
                goto label_32;
            }
            
            var val_32 = 0;
            val_32 = val_32 + 1;
            val_39 = val_10;
            goto label_36;
            label_58:
            var val_33 = 0;
            val_33 = val_33 + 1;
            val_41 = ;
            if((( & 1) & 1) == 0)
            {
                goto label_71;
            }
            
            var val_34 = 0;
            val_34 = val_34 + 1;
            val_42 = ;
            val_43 = ;
            if(val_43 != null)
            {
                    if(null == null)
            {
                goto label_56;
            }
            
            }
            
            val_43 = 0;
            label_56:
            this.index.set_Item(key:  val_43, value:  val_4.m_Handle.InitializationCallback);
            goto label_58;
            label_71:
            if( != null)
            {
                    var val_35 = 0;
                val_35 = val_35 + 1;
                val_44 = ;
            }
            
            val_31 = 1152921504839753728;
            if( == 139)
            {
                goto label_70;
            }
            
            val_31 = 0;
            if(null == null)
            {
                goto label_70;
            }
            
            val_31 = 0;
            goto label_70;
            label_36:
            label_32:
            val_31 = 1152921504839753728;
            if( != 264)
            {
                    val_31 = 0;
                if(null != null)
            {
                    val_31 = 0;
            }
            
            }
            
            label_70:
            if((0 & 1) != 0)
            {
                goto label_75;
            }
            
            val_3.Dispose();
            if(295 == 295)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        public string ResolveName(string guid)
        {
            string val_50;
            object val_51;
            string val_52;
            string val_53;
            var val_54;
            val_50 = this;
            if((this.objects.ContainsKey(key:  guid)) == false)
            {
                goto label_2;
            }
            
            val_51 = this.objects.Item[guid];
            val_50 = this.rootObject;
            if((System.String.op_Equality(a:  0, b:  guid)) == false)
            {
                goto label_15;
            }
            
            val_52 = "Project object";
            return val_52;
            label_2:
            val_51 = 0 + this + " ResolveName could not resolve ";
            UnityEngine.Debug.LogWarning(message:  0);
            val_52 = System.String.Empty;
            return val_52;
            label_15:
            if(val_51 == null)
            {
                goto label_76;
            }
            
            if((val_51.data.ContainsKey(key:  "name")) == false)
            {
                goto label_41;
            }
            
            typeof(System.String[]).__il2cppRuntimeField_20 = "PBXObject ";
            val_53 = "name";
            val_54 = val_51.data.Item[val_53];
            if(val_54 == null)
            {
                goto label_47;
            }
            
            if(null == null)
            {
                goto label_48;
            }
            
            goto label_86;
            label_76:
            string val_44 = 0 + "UNRESOLVED GUID:"("UNRESOLVED GUID:");
            UnityEngine.Debug.LogWarning(message:  0);
            return val_52;
            label_48:
            label_86:
            val_53 = null;
            if(null == val_53)
            {
                goto label_87;
            }
            
            val_53 = 0;
            label_47:
            val_54 = 0;
            label_87:
            val_53 = 0;
            typeof(System.String[]).__il2cppRuntimeField_28 = val_54;
            val_53 = mem[null + 48];
            if(" " == null)
            {
                    val_53 = 0;
            }
            
            val_53 = 0;
            typeof(System.String[]).__il2cppRuntimeField_30 = " ";
            if(guid != null)
            {
                    val_53 = mem[null + 48];
                if(guid == null)
            {
                    val_53 = 0;
            }
            
            }
            
            val_53 = 0;
            typeof(System.String[]).__il2cppRuntimeField_38 = guid;
            val_53 = mem[null + 48];
            if(" " == null)
            {
                    val_53 = 0;
            }
            
            val_53 = 0;
            typeof(System.String[]).__il2cppRuntimeField_40 = " ";
            typeof(System.String[]).__il2cppRuntimeField_48 = val_51;
            string val_46 = +0;
            UnityEngine.Debug.Log(message:  0);
            label_41:
            if(val_51.data.Item["name"] == null)
            {
                    return val_52;
            }
            
            if(null == null)
            {
                    return val_52;
            }
            
            return val_52;
        }
        public string ResolveBuildPhaseNameForFile(string guid)
        {
            UnityEditor.XCodeEditor.PBXDictionary val_11 = this.objects;
            if((val_11.ContainsKey(key:  guid)) == false)
            {
                    return 0;
            }
            
            val_11 = this.objects;
            object val_2 = val_11.Item[guid];
            if(val_2 == null)
            {
                    return 0;
            }
            
            val_11 = this.index;
            if((val_11.ContainsKey(key:  val_2.guid)) == false)
            {
                    return 0;
            }
            
            string val_6 = this.index.Item[val_2.guid];
            val_11 = this.objects;
            if((val_11.ContainsKey(key:  val_6)) == false)
            {
                    return 0;
            }
            
            val_11 = this.objects;
            object val_8 = val_11.Item[val_6];
            return 0;
        }
    
    }

}
