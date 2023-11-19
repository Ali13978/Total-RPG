using UnityEngine;

namespace UnityEditor.XCodeEditor
{
    public class XCPlist
    {
        // Fields
        private string plistPath;
        private bool plistModified;
        private const string BundleUrlTypes = "CFBundleURLTypes";
        private const string BundleTypeRole = "CFBundleTypeRole";
        private const string BundleUrlName = "CFBundleURLName";
        private const string BundleUrlSchemes = "CFBundleURLSchemes";
        private const string PlistUrlType = "urltype";
        private const string PlistRole = "role";
        private const string PlistEditor = "Editor";
        private const string PlistName = "name";
        private const string PlistSchemes = "schemes";
        
        // Methods
        public XCPlist(string plistPath)
        {
            this.plistPath = plistPath;
        }
        public void Process(System.Collections.Hashtable plist)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_12;
            var val_13;
            var val_14;
            string val_15;
            var val_17;
            object val_1 = PlistCS.Plist.readPlist(path:  0);
            val_12 = 0;
            if(val_1 != null)
            {
                    val_12 = val_1;
                val_12 = 0;
            }
            
            label_23:
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_13 = plist;
            if(((plist & 1) & 1) == 0)
            {
                goto label_36;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_14 = plist;
            val_15 = null.InitializationCallback;
            if(val_15 != null)
            {
                    if(null == null)
            {
                goto label_22;
            }
            
            }
            
            val_15 = 0;
            label_22:
            this.AddPlistItems(key:  val_15, value:  null, dict:  val_12);
            goto label_23;
            label_36:
            if(plist != null)
            {
                    var val_14 = 0;
                val_14 = val_14 + 1;
                val_17 = plist;
            }
            
            if(this.plistModified == false)
            {
                    return;
            }
            
            PlistCS.Plist.writeXml(value:  0, path:  val_12);
        }
        public static System.Collections.Generic.Dictionary<K, V> HashtableToDictionary<K, V>(System.Collections.Hashtable table)
        {
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            label_21:
            var val_10 = __RuntimeMethodHiddenParam;
            if((__RuntimeMethodHiddenParam + 258) == 0)
            {
                goto label_3;
            }
            
            var val_7 = __RuntimeMethodHiddenParam + 152;
            var val_8 = 0;
            val_7 = val_7 + 8;
            label_5:
            if(((__RuntimeMethodHiddenParam + 152 + 8) + -8) == null)
            {
                goto label_4;
            }
            
            val_8 = val_8 + 1;
            val_7 = val_7 + 16;
            if(val_8 < (__RuntimeMethodHiddenParam + 258))
            {
                goto label_5;
            }
            
            label_3:
            val_8 = __RuntimeMethodHiddenParam;
            goto label_6;
            label_4:
            var val_9 = val_7;
            val_9 = val_9 + 1;
            val_10 = val_10 + val_9;
            val_8 = val_10 + 272;
            label_6:
            if(((__RuntimeMethodHiddenParam & 1) & 1) == 0)
            {
                goto label_31;
            }
            
            var val_13 = __RuntimeMethodHiddenParam;
            if((__RuntimeMethodHiddenParam + 258) == 0)
            {
                goto label_9;
            }
            
            var val_11 = __RuntimeMethodHiddenParam + 152;
            var val_12 = 0;
            val_11 = val_11 + 8;
            label_11:
            if(((__RuntimeMethodHiddenParam + 152 + 8) + -8) == null)
            {
                goto label_10;
            }
            
            val_12 = val_12 + 1;
            val_11 = val_11 + 16;
            if(val_12 < (__RuntimeMethodHiddenParam + 258))
            {
                goto label_11;
            }
            
            label_9:
            val_9 = __RuntimeMethodHiddenParam;
            goto label_12;
            label_10:
            val_13 = val_13 + (((__RuntimeMethodHiddenParam + 152 + 8)) << 4);
            val_9 = val_13 + 272;
            label_12:
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_4 = __RuntimeMethodHiddenParam.InitializationCallback;
            if(val_4 == null)
            {
                goto label_17;
            }
            
            val_10 = val_4;
            if(val_10 != null)
            {
                goto label_18;
            }
            
            label_17:
            val_10 = 0;
            label_18:
            if(__RuntimeMethodHiddenParam != 0)
            {
                    val_11 = ;
                if(__RuntimeMethodHiddenParam != 0)
            {
                goto label_21;
            }
            
            }
            
            val_11 = 0;
            goto label_21;
            label_31:
            if(__RuntimeMethodHiddenParam == 0)
            {
                goto label_23;
            }
            
            var val_16 = __RuntimeMethodHiddenParam;
            if((__RuntimeMethodHiddenParam + 258) == 0)
            {
                goto label_24;
            }
            
            var val_14 = __RuntimeMethodHiddenParam + 152;
            var val_15 = 0;
            val_14 = val_14 + 8;
            label_26:
            if(((__RuntimeMethodHiddenParam + 152 + 8) + -8) == null)
            {
                goto label_25;
            }
            
            val_15 = val_15 + 1;
            val_14 = val_14 + 16;
            if(val_15 < (__RuntimeMethodHiddenParam + 258))
            {
                goto label_26;
            }
            
            label_24:
            val_12 = __RuntimeMethodHiddenParam;
            goto label_27;
            label_25:
            val_16 = val_16 + (((__RuntimeMethodHiddenParam + 152 + 8)) << 4);
            val_12 = val_16 + 272;
            label_27:
            label_23:
            if(0 == 96)
            {
                    return (System.Collections.Generic.Dictionary<K, V>)X2 + 48;
            }
            
            if((X2 + 48) == 0)
            {
                    return (System.Collections.Generic.Dictionary<K, V>)X2 + 48;
            }
            
            return (System.Collections.Generic.Dictionary<K, V>)X2 + 48;
        }
        public void AddPlistItems(string key, object value, System.Collections.Generic.Dictionary<string, object> dict)
        {
            var val_8;
            var val_9;
            System.Collections.ArrayList val_10;
            val_8 = value;
            string val_1 = 0 + "AddPlistItems: key="("AddPlistItems: key=");
            UnityEngine.Debug.Log(message:  0);
            if((key.CompareTo(strB:  "urltype")) != 0)
            {
                    val_9 = 0;
                dict.set_Item(key:  key, value:  UnityEditor.XCodeEditor.XCPlist.HashtableToDictionary<System.String, System.Object>(table:  0));
                this.plistModified = true;
                return;
            }
            
            if(val_8 != null)
            {
                
            }
            
            val_10 = 0;
            this.processUrlTypes(urltypes:  val_10, dict:  dict);
        }
        private void processUrlTypes(System.Collections.ArrayList urltypes, System.Collections.Generic.Dictionary<string, object> dict)
        {
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            object val_33;
            var val_36;
            var val_37;
            if((dict.ContainsKey(key:  "CFBundleURLTypes")) != false)
            {
                    object val_2 = dict.Item["CFBundleURLTypes"];
                val_25 = 0;
            }
            else
            {
                    System.Collections.Generic.List<System.Object> val_5 = new System.Collections.Generic.List<System.Object>();
            }
            
            if(urltypes != null)
            {
                goto label_9;
            }
            
            goto label_9;
            label_67:
            mem[1152921510167392696] = 1;
            label_9:
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_26 = urltypes;
            if(((urltypes & 1) & 1) == 0)
            {
                goto label_79;
            }
            
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_27 = urltypes;
            val_28 = 0;
            val_29 = null;
            if(val_28 == 0)
            {
                goto label_24;
            }
            
            if(1179403647 == val_29)
            {
                goto label_25;
            }
            
            val_29 = null;
            label_24:
            val_28 = 0;
            label_25:
            object val_13 = ((System.String.IsNullOrEmpty(value:  0)) != true) ? "Editor" : (val_28);
            if(0 != 0)
            {
                    if(1179403647 == null)
            {
                goto label_30;
            }
            
            }
            
            label_30:
            val_30 = 0;
            val_30 = 0;
            System.Collections.Generic.List<System.Object> val_17 = new System.Collections.Generic.List<System.Object>();
            label_49:
            var val_27 = 1179403647;
            if(mem[282584257676929] == 0)
            {
                goto label_36;
            }
            
            var val_24 = mem[282584257676823];
            var val_25 = 0;
            val_24 = val_24 + 8;
            label_38:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_37;
            }
            
            val_25 = val_25 + 1;
            val_24 = val_24 + 16;
            if(val_25 < mem[282584257676929])
            {
                goto label_38;
            }
            
            label_36:
            val_31 = val_30;
            goto label_39;
            label_37:
            var val_26 = val_24;
            val_26 = val_26 + 1;
            val_27 = val_27 + val_26;
            val_31 = val_27 + 272;
            label_39:
            if((0 & 1) == 0)
            {
                goto label_68;
            }
            
            var val_30 = 1179403647;
            if(mem[282584257676929] == 0)
            {
                goto label_42;
            }
            
            var val_28 = mem[282584257676823];
            var val_29 = 0;
            val_28 = val_28 + 8;
            label_44:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_43;
            }
            
            val_29 = val_29 + 1;
            val_28 = val_28 + 16;
            if(val_29 < mem[282584257676929])
            {
                goto label_44;
            }
            
            label_42:
            val_32 = val_30;
            goto label_45;
            label_43:
            val_30 = val_30 + (((mem[282584257676823] + 8)) << 4);
            val_32 = val_30 + 272;
            label_45:
            val_33 = val_30;
            if(val_33 != 0)
            {
                    if(1179403647 == null)
            {
                goto label_47;
            }
            
            }
            
            val_33 = 0;
            label_47:
            Add(item:  val_33);
            goto label_49;
            label_68:
            if(val_30 == 0)
            {
                goto label_51;
            }
            
            var val_33 = 1179403647;
            if(mem[282584257676929] == 0)
            {
                goto label_52;
            }
            
            var val_31 = mem[282584257676823];
            var val_32 = 0;
            val_31 = val_31 + 8;
            label_54:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_53;
            }
            
            val_32 = val_32 + 1;
            val_31 = val_31 + 16;
            if(val_32 < mem[282584257676929])
            {
                goto label_54;
            }
            
            label_52:
            val_36 = val_30;
            goto label_55;
            label_53:
            val_33 = val_33 + (((mem[282584257676823] + 8)) << 4);
            val_36 = val_33 + 272;
            label_55:
            label_51:
            if(0 == 222)
            {
                
            }
            else
            {
                    if(null != 0)
            {
                
            }
            
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_19 = this.findUrlTypeByName(bundleUrlTypes:  val_5, name:  0);
            if(val_19 == null)
            {
                goto label_61;
            }
            
            val_19.set_Item(key:  "CFBundleTypeRole", value:  val_13);
            val_19.set_Item(key:  "CFBundleURLSchemes", value:  null);
            goto label_67;
            label_61:
            System.Collections.Generic.Dictionary<System.String, System.Object> val_20 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            set_Item(key:  "CFBundleTypeRole", value:  val_13);
            set_Item(key:  "CFBundleURLName", value:  0);
            set_Item(key:  "CFBundleURLSchemes", value:  null);
            Add(item:  null);
            goto label_67;
            label_79:
            if(urltypes != null)
            {
                    var val_34 = 0;
                val_34 = val_34 + 1;
                val_37 = urltypes;
            }
            
            dict.set_Item(key:  "CFBundleURLTypes", value:  val_5);
        }
        private System.Collections.Generic.Dictionary<string, object> findUrlTypeByName(System.Collections.Generic.List<object> bundleUrlTypes, string name)
        {
            var val_4;
            var val_11;
            string val_12;
            var val_13;
            var val_14;
            val_11 = name;
            val_12 = bundleUrlTypes;
            val_13 = 0;
            if(val_12 == null)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_13;
            }
            
            if(val_12.Count == 0)
            {
                goto label_15;
            }
            
            List.Enumerator<T> val_2 = val_12.GetEnumerator();
            label_11:
            if((0 & 1) == 0)
            {
                goto label_3;
            }
            
            val_13 = val_4.InitializationCallback;
            val_13 = 0;
            val_12 = val_13.Item["CFBundleURLName"];
            val_14 = null;
            if(val_12 == null)
            {
                goto label_7;
            }
            
            if(null == val_14)
            {
                goto label_8;
            }
            
            val_14 = null;
            label_7:
            val_12 = 0;
            label_8:
            if((System.String.Compare(strA:  0, strB:  val_12)) != 0)
            {
                goto label_11;
            }
            
            val_4.Dispose();
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_13;
            label_3:
            val_4.Dispose();
            label_15:
            val_13 = 0;
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_13;
        }
    
    }

}
