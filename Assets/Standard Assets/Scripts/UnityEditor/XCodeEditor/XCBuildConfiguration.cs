using UnityEngine;

namespace UnityEditor.XCodeEditor
{
    public class XCBuildConfiguration : PBXObject
    {
        // Fields
        protected const string BUILDSETTINGS_KEY = "buildSettings";
        protected const string HEADER_SEARCH_PATHS_KEY = "HEADER_SEARCH_PATHS";
        protected const string LIBRARY_SEARCH_PATHS_KEY = "LIBRARY_SEARCH_PATHS";
        protected const string FRAMEWORK_SEARCH_PATHS_KEY = "FRAMEWORK_SEARCH_PATHS";
        protected const string OTHER_C_FLAGS_KEY = "OTHER_CFLAGS";
        protected const string OTHER_LDFLAGS_KEY = "OTHER_LDFLAGS";
        
        // Properties
        public UnityEditor.XCodeEditor.PBXSortedDictionary buildSettings { get; }
        
        // Methods
        public XCBuildConfiguration(string guid, UnityEditor.XCodeEditor.PBXDictionary dictionary)
        {
        
        }
        public UnityEditor.XCodeEditor.PBXSortedDictionary get_buildSettings()
        {
            var val_12;
            UnityEditor.XCodeEditor.PBXDictionary val_13;
            val_12 = 0;
            if((this.ContainsKey(key:  "buildSettings")) == false)
            {
                    return (UnityEditor.XCodeEditor.PBXSortedDictionary)val_12;
            }
            
            System.Type val_3 = val_12.Item["buildSettings"].GetType();
            if(val_3 != (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                    val_12 = val_3.Item["buildSettings"];
                if(val_12 != null)
            {
                
            }
            
                val_12 = 0;
                return (UnityEditor.XCodeEditor.PBXSortedDictionary)val_12;
            }
            
            UnityEditor.XCodeEditor.PBXSortedDictionary val_8 = null;
            val_12 = val_8;
            val_8 = new UnityEditor.XCodeEditor.PBXSortedDictionary();
            val_13 = this.Item["buildSettings"];
            val_13 = 0;
            Append(dictionary:  val_13);
            return (UnityEditor.XCodeEditor.PBXSortedDictionary)val_12;
        }
        protected bool AddSearchPaths(string path, string key, bool recursive = True)
        {
            int val_2 = Add(value:  path);
            return this.AddSearchPaths(paths:  new UnityEditor.XCodeEditor.PBXList(), key:  key, recursive:  false, quoted:  false);
        }
        protected bool AddSearchPaths(UnityEditor.XCodeEditor.PBXList paths, string key, bool recursive = True, bool quoted = False)
        {
            var val_71;
            var val_72;
            string val_73;
            var val_74;
            var val_75;
            var val_76;
            var val_77;
            var val_78;
            var val_79;
            var val_80;
            var val_81;
            var val_82;
            var val_85;
            var val_86;
            var val_87;
            var val_89;
            bool val_74 = quoted;
            if((this.ContainsKey(key:  "buildSettings")) != true)
            {
                    this.Add(key:  "buildSettings", obj:  new UnityEditor.XCodeEditor.PBXSortedDictionary());
            }
            
            System.Collections.IEnumerator val_4 = paths.GetEnumerator();
            label_93:
            label_79:
            var val_72 = 0;
            val_72 = val_72 + 1;
            val_71 = val_4;
            if(((val_4 & 1) & 1) == 0)
            {
                goto label_8;
            }
            
            var val_73 = 0;
            val_73 = val_73 + 1;
            val_72 = val_4;
            val_73 = val_4;
            if(val_73 != null)
            {
                    if(null == null)
            {
                goto label_15;
            }
            
            }
            
            val_73 = 0;
            label_15:
            val_74 = X24.Item["buildSettings"];
            val_74 = 0;
            if((val_74.ContainsKey(key:  key)) == false)
            {
                goto label_23;
            }
            
            val_75 = val_74.Item["buildSettings"];
            val_75 = 0;
            if((val_75.Item[key] == null) || (null != null))
            {
                goto label_48;
            }
            
            UnityEditor.XCodeEditor.PBXList val_22 = new UnityEditor.XCodeEditor.PBXList();
            val_76 = 0.Item["buildSettings"];
            val_76 = 0;
            object val_28 = val_76.Item[key];
            int val_29 = Add(value:  val_28);
            val_77 = val_28.Item["buildSettings"];
            val_77 = 0;
            val_77.set_Item(key:  key, value:  null);
            goto label_48;
            label_23:
            val_78 = val_74.Item["buildSettings"];
            UnityEditor.XCodeEditor.PBXList val_36 = new UnityEditor.XCodeEditor.PBXList();
            val_78 = 0;
            val_78.Add(key:  key, value:  null);
            label_48:
            val_74 = val_74 | (val_73.Contains(value:  " "));
            if(val_74 != false)
            {
                    if((val_73.EndsWith(value:  "/**")) != false)
            {
                    string val_43 = val_73.Replace(oldValue:  "/**", newValue:  "\\\"/**");
                val_73 = 0 + "\\\"";
            }
            else
            {
                    val_73 = 0 + "\\\"" + val_73;
            }
            
            }
            
            val_79 = Item["buildSettings"];
            val_79 = 0;
            val_80 = val_79.Item[key];
            val_80 = 0;
            if((0 & 1) != 0)
            {
                goto label_79;
            }
            
            val_81 = val_80.Item["buildSettings"];
            val_81 = 0;
            val_82 = val_81.Item[key];
            val_82 = 0;
            goto label_93;
            label_8:
            val_85 = 0;
            val_86 = 0;
            val_87 = 450;
            if(val_4 == null)
            {
                    return (bool) & 1;
            }
            
            var val_75 = 0;
            val_75 = val_75 + 1;
            val_89 = val_4;
            return (bool) & 1;
        }
        public bool AddHeaderSearchPaths(UnityEditor.XCodeEditor.PBXList paths, bool recursive = True)
        {
            return this.AddSearchPaths(paths:  paths, key:  "HEADER_SEARCH_PATHS", recursive:  false, quoted:  false);
        }
        public bool AddLibrarySearchPaths(UnityEditor.XCodeEditor.PBXList paths, bool recursive = True)
        {
            string val_1 = 0 + "AddLibrarySearchPaths ";
            UnityEngine.Debug.Log(message:  0);
            return this.AddSearchPaths(paths:  paths, key:  "LIBRARY_SEARCH_PATHS", recursive:  false, quoted:  false);
        }
        public bool AddFrameworkSearchPaths(UnityEditor.XCodeEditor.PBXList paths, bool recursive = True)
        {
            return this.AddSearchPaths(paths:  paths, key:  "FRAMEWORK_SEARCH_PATHS", recursive:  false, quoted:  false);
        }
        public bool AddOtherCFlags(string flag)
        {
            int val_2 = Add(value:  flag);
            return this.AddOtherCFlags(flags:  new UnityEditor.XCodeEditor.PBXList());
        }
        public bool AddOtherCFlags(UnityEditor.XCodeEditor.PBXList flags)
        {
            var val_72;
            var val_73;
            var val_74;
            var val_75;
            var val_76;
            var val_77;
            var val_78;
            var val_79;
            var val_80;
            var val_81;
            var val_82;
            var val_83;
            var val_84;
            var val_85;
            var val_86;
            var val_89;
            var val_90;
            var val_91;
            var val_93;
            if((this.ContainsKey(key:  "buildSettings")) != true)
            {
                    this.Add(key:  "buildSettings", obj:  new UnityEditor.XCodeEditor.PBXSortedDictionary());
            }
            
            System.Collections.IEnumerator val_4 = flags.GetEnumerator();
            label_97:
            label_83:
            var val_73 = 0;
            val_73 = val_73 + 1;
            val_72 = val_4;
            if(((val_4 & 1) & 1) == 0)
            {
                goto label_8;
            }
            
            var val_74 = 0;
            val_74 = val_74 + 1;
            val_73 = val_4;
            val_74 = val_4;
            if(val_74 != null)
            {
                    if(null == null)
            {
                goto label_15;
            }
            
            }
            
            val_74 = 0;
            label_15:
            val_75 = X22.Item["buildSettings"];
            val_75 = 0;
            if((val_75.ContainsKey(key:  "OTHER_CFLAGS")) == false)
            {
                goto label_23;
            }
            
            val_76 = val_75.Item["buildSettings"];
            val_76 = 0;
            if((val_76.Item["OTHER_CFLAGS"] == null) || (null != null))
            {
                goto label_62;
            }
            
            val_77 = val_76.Item["buildSettings"];
            val_77 = 0;
            val_78 = val_77.Item["OTHER_CFLAGS"];
            if(val_78 != null)
            {
                    if(null == null)
            {
                goto label_41;
            }
            
            }
            
            val_78 = 0;
            label_41:
            val_79 = 0.Item["buildSettings"];
            UnityEditor.XCodeEditor.PBXList val_30 = new UnityEditor.XCodeEditor.PBXList();
            val_79 = 0;
            val_79.set_Item(key:  "OTHER_CFLAGS", value:  null);
            val_80 = Item["buildSettings"];
            val_80 = 0;
            val_81 = val_80.Item["OTHER_CFLAGS"];
            val_81 = 0;
            goto label_62;
            label_23:
            val_82 = val_75.Item["buildSettings"];
            UnityEditor.XCodeEditor.PBXList val_46 = new UnityEditor.XCodeEditor.PBXList();
            val_82 = 0;
            val_82.Add(key:  "OTHER_CFLAGS", value:  null);
            label_62:
            val_83 = Item["buildSettings"];
            val_83 = 0;
            val_84 = val_83.Item["OTHER_CFLAGS"];
            val_84 = 0;
            if((0 & 1) != 0)
            {
                goto label_83;
            }
            
            val_85 = val_84.Item["buildSettings"];
            val_85 = 0;
            val_86 = val_85.Item["OTHER_CFLAGS"];
            val_86 = 0;
            goto label_97;
            label_8:
            val_89 = 0;
            val_90 = 0;
            val_91 = 422;
            if(val_4 == null)
            {
                    return (bool) & 1;
            }
            
            var val_75 = 0;
            val_75 = val_75 + 1;
            val_93 = val_4;
            return (bool) & 1;
        }
        public bool AddOtherLinkerFlags(string flag)
        {
            int val_2 = Add(value:  flag);
            return this.AddOtherLinkerFlags(flags:  new UnityEditor.XCodeEditor.PBXList());
        }
        public bool AddOtherLinkerFlags(UnityEditor.XCodeEditor.PBXList flags)
        {
            var val_74;
            var val_75;
            var val_76;
            var val_77;
            var val_78;
            var val_79;
            var val_80;
            var val_81;
            var val_82;
            var val_83;
            var val_84;
            var val_85;
            var val_86;
            var val_87;
            var val_88;
            var val_91;
            var val_92;
            var val_93;
            var val_95;
            if((this.ContainsKey(key:  "buildSettings")) != true)
            {
                    this.Add(key:  "buildSettings", obj:  new UnityEditor.XCodeEditor.PBXSortedDictionary());
            }
            
            System.Collections.IEnumerator val_4 = flags.GetEnumerator();
            label_100:
            label_86:
            var val_75 = 0;
            val_75 = val_75 + 1;
            val_74 = val_4;
            if(((val_4 & 1) & 1) == 0)
            {
                goto label_8;
            }
            
            var val_76 = 0;
            val_76 = val_76 + 1;
            val_75 = val_4;
            val_76 = val_4;
            if(val_76 != null)
            {
                    if(null == null)
            {
                goto label_15;
            }
            
            }
            
            val_76 = 0;
            label_15:
            val_77 = X22.Item["buildSettings"];
            val_77 = 0;
            if((val_77.ContainsKey(key:  "OTHER_LDFLAGS")) == false)
            {
                goto label_23;
            }
            
            val_78 = val_77.Item["buildSettings"];
            val_78 = 0;
            if((val_78.Item["OTHER_LDFLAGS"] == null) || (null != null))
            {
                goto label_65;
            }
            
            val_79 = val_78.Item["buildSettings"];
            val_79 = 0;
            val_80 = val_79.Item["OTHER_LDFLAGS"];
            if(val_80 != null)
            {
                    if(null == null)
            {
                goto label_41;
            }
            
            }
            
            val_80 = 0;
            label_41:
            val_81 = 0.Item["buildSettings"];
            UnityEditor.XCodeEditor.PBXList val_30 = new UnityEditor.XCodeEditor.PBXList();
            val_81 = 0;
            val_81.set_Item(key:  "OTHER_LDFLAGS", value:  null);
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_65;
            }
            
            val_82 = Item["buildSettings"];
            val_82 = 0;
            val_83 = val_82.Item["OTHER_LDFLAGS"];
            val_83 = 0;
            goto label_65;
            label_23:
            val_84 = val_77.Item["buildSettings"];
            UnityEditor.XCodeEditor.PBXList val_48 = new UnityEditor.XCodeEditor.PBXList();
            val_84 = 0;
            val_84.Add(key:  "OTHER_LDFLAGS", value:  null);
            label_65:
            val_85 = Item["buildSettings"];
            val_85 = 0;
            val_86 = val_85.Item["OTHER_LDFLAGS"];
            val_86 = 0;
            if((0 & 1) != 0)
            {
                goto label_86;
            }
            
            val_87 = val_86.Item["buildSettings"];
            val_87 = 0;
            val_88 = val_87.Item["OTHER_LDFLAGS"];
            val_88 = 0;
            goto label_100;
            label_8:
            val_91 = 0;
            val_92 = 0;
            val_93 = 433;
            if(val_4 == null)
            {
                    return (bool) & 1;
            }
            
            var val_77 = 0;
            val_77 = val_77 + 1;
            val_95 = val_4;
            return (bool) & 1;
        }
        public bool overwriteBuildSetting(string settingName, string settingValue)
        {
            var val_52;
            var val_53;
            var val_54;
            var val_55;
            var val_56;
            var val_57;
            var val_58;
            var val_59;
            val_52 = this;
            string val_1 = 0 + "overwriteBuildSetting " + settingName + " ";
            UnityEngine.Debug.Log(message:  0);
            if((this.ContainsKey(key:  "buildSettings")) != true)
            {
                    UnityEngine.Debug.Log(message:  0);
                this.Add(key:  "buildSettings", obj:  new UnityEditor.XCodeEditor.PBXSortedDictionary());
            }
            
            val_53 = Item["buildSettings"];
            if(val_53 != null)
            {
                
            }
            
            val_53 = 0;
            if((val_53.ContainsKey(key:  settingName)) == false)
            {
                goto label_15;
            }
            
            val_54 = val_53.Item["buildSettings"];
            if(val_54 == null)
            {
                goto label_17;
            }
            
            goto label_22;
            label_15:
            UnityEngine.Debug.Log(message:  0);
            val_55 = 0 + "adding key ".Item["buildSettings"];
            if(val_55 == null)
            {
                goto label_28;
            }
            
            goto label_33;
            label_17:
            label_22:
            val_54 = 0;
            if((val_54.Item[settingName] == null) || (null != null))
            {
                goto label_43;
            }
            
            val_56 = val_54.Item["buildSettings"];
            if(val_56 == null)
            {
                goto label_37;
            }
            
            goto label_42;
            label_28:
            label_33:
            val_55 = 0;
            val_55.Add(key:  settingName, value:  new UnityEditor.XCodeEditor.PBXList());
            goto label_43;
            label_37:
            label_42:
            val_56 = 0;
            val_56.set_Item(key:  settingName, value:  new UnityEditor.XCodeEditor.PBXList());
            label_43:
            val_57 = Item["buildSettings"];
            if(val_57 != null)
            {
                
            }
            
            val_57 = 0;
            val_58 = val_57.Item[settingName];
            if(val_58 != null)
            {
                
            }
            
            val_58 = 0;
            if((0 & 1) != 0)
            {
                    val_59 = 0;
                return (bool)val_59;
            }
            
            string val_41 = 0 + "setting " + settingName + " to ";
            UnityEngine.Debug.Log(message:  0);
            val_52 = this.Item["buildSettings"];
            if(val_52 != null)
            {
                
            }
            
            val_52 = 0;
            object val_47 = val_52.Item[settingName];
            val_59 = 1;
            return (bool)val_59;
            label_89:
            goto label_89;
        }
    
    }

}
