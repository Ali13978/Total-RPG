using UnityEngine;

namespace UnityEditor.XCodeEditor
{
    public class XCProject : IDisposable
    {
        // Fields
        private UnityEditor.XCodeEditor.PBXDictionary _datastore;
        public UnityEditor.XCodeEditor.PBXDictionary _objects;
        private UnityEditor.XCodeEditor.PBXGroup _rootGroup;
        private string _rootObjectKey;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private string <projectRootPath>k__BackingField;
        private System.IO.FileInfo projectFileInfo;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private string <filePath>k__BackingField;
        private bool modified;
        private UnityEditor.XCodeEditor.PBXSortedDictionary<UnityEditor.XCodeEditor.PBXBuildFile> _buildFiles;
        private UnityEditor.XCodeEditor.PBXSortedDictionary<UnityEditor.XCodeEditor.PBXGroup> _groups;
        private UnityEditor.XCodeEditor.PBXSortedDictionary<UnityEditor.XCodeEditor.PBXFileReference> _fileReferences;
        private UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXNativeTarget> _nativeTargets;
        private UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXFrameworksBuildPhase> _frameworkBuildPhases;
        private UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXResourcesBuildPhase> _resourcesBuildPhases;
        private UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXShellScriptBuildPhase> _shellScriptBuildPhases;
        private UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXSourcesBuildPhase> _sourcesBuildPhases;
        private UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXCopyFilesBuildPhase> _copyBuildPhases;
        private UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXVariantGroup> _variantGroups;
        private UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.XCBuildConfiguration> _buildConfigurations;
        private UnityEditor.XCodeEditor.PBXSortedDictionary<UnityEditor.XCodeEditor.XCConfigurationList> _configurationLists;
        private UnityEditor.XCodeEditor.PBXProject _project;
        
        // Properties
        public string projectRootPath { get; set; }
        public string filePath { get; set; }
        public UnityEditor.XCodeEditor.PBXProject project { get; }
        public UnityEditor.XCodeEditor.PBXGroup rootGroup { get; }
        public UnityEditor.XCodeEditor.PBXSortedDictionary<UnityEditor.XCodeEditor.PBXBuildFile> buildFiles { get; }
        public UnityEditor.XCodeEditor.PBXSortedDictionary<UnityEditor.XCodeEditor.PBXGroup> groups { get; }
        public UnityEditor.XCodeEditor.PBXSortedDictionary<UnityEditor.XCodeEditor.PBXFileReference> fileReferences { get; }
        public UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXVariantGroup> variantGroups { get; }
        public UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXNativeTarget> nativeTargets { get; }
        public UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.XCBuildConfiguration> buildConfigurations { get; }
        public UnityEditor.XCodeEditor.PBXSortedDictionary<UnityEditor.XCodeEditor.XCConfigurationList> configurationLists { get; }
        public UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXFrameworksBuildPhase> frameworkBuildPhases { get; }
        public UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXResourcesBuildPhase> resourcesBuildPhases { get; }
        public UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXShellScriptBuildPhase> shellScriptBuildPhases { get; }
        public UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXSourcesBuildPhase> sourcesBuildPhases { get; }
        public UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXCopyFilesBuildPhase> copyBuildPhases { get; }
        public System.Collections.Generic.Dictionary<string, object> objects { get; }
        
        // Methods
        public XCProject()
        {
        
        }
        public XCProject(string filePath)
        {
            var val_40;
            string val_41;
            var val_42;
            string val_43;
            UnityEditor.XCodeEditor.PBXGroup val_44;
            UnityEditor.XCodeEditor.PBXDictionary val_45;
            string val_46;
            UnityEditor.XCodeEditor.PBXDictionary val_47;
            UnityEditor.XCodeEditor.PBXDictionary val_48;
            var val_49;
            val_40 = this;
            if((System.IO.Directory.Exists(path:  0)) == false)
            {
                goto label_1;
            }
            
            if((filePath.EndsWith(value:  ".xcodeproj")) == false)
            {
                goto label_3;
            }
            
            string val_4 = 0 + "Opening project ";
            UnityEngine.Debug.Log(message:  0);
            this.<projectRootPath>k__BackingField = System.IO.Path.GetDirectoryName(path:  0);
            this.<filePath>k__BackingField = filePath;
            val_41 = filePath;
            goto label_10;
            label_1:
            string val_6 = 0 + "XCode project path does not exist: "("XCode project path does not exist: ");
            label_61:
            UnityEngine.Debug.LogWarning(message:  0);
            return;
            label_3:
            if(val_7.Length == 0)
            {
                goto label_61;
            }
            
            this.<projectRootPath>k__BackingField = filePath;
            if((System.IO.Path.IsPathRooted(path:  0)) != true)
            {
                    val_42 = null;
                val_42 = null;
                val_43 = System.String.Empty;
                this.<projectRootPath>k__BackingField = 0 + UnityEngine.Application.dataPath.Replace(oldValue:  "Assets", newValue:  val_43)(UnityEngine.Application.dataPath.Replace(oldValue:  "Assets", newValue:  val_43));
            }
            
            val_41 = System.IO.Directory.GetDirectories(path:  0, searchPattern:  filePath)[0];
            this.<filePath>k__BackingField = val_41;
            label_10:
            this.projectFileInfo = new System.IO.FileInfo(fileName:  System.IO.Path.Combine(path1:  0, path2:  val_41));
            UnityEditor.XCodeEditor.PBXParser val_16 = new UnityEditor.XCodeEditor.PBXParser();
            UnityEditor.XCodeEditor.PBXDictionary val_17 = Decode(data:  OpenText());
            this._datastore = val_17;
            if(val_17 == null)
            {
                goto label_30;
            }
            
            val_44 = val_17.ContainsKey(key:  "objects");
            if(val_44 == false)
            {
                goto label_32;
            }
            
            object val_20 = this._datastore.Item["objects"];
            val_43 = 1152921504839168000;
            val_45 = 0;
            this._objects = val_45;
            this.modified = false;
            val_44 = 1152921504608284672;
            val_46 = this._datastore.Item["rootObject"];
            if(val_46 != null)
            {
                    if(null == null)
            {
                goto label_38;
            }
            
            }
            
            val_46 = 0;
            label_38:
            this._rootObjectKey = val_46;
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_41;
            }
            
            UnityEngine.Debug.LogWarning(message:  0);
            this._project = 0;
            this._rootGroup = 0;
            return;
            label_32:
            int val_27 = this._datastore.Count;
            val_40 = 0 + "Errore ";
            UnityEngine.Debug.Log(message:  0);
            return;
            label_41:
            val_47 = this._objects.Item[this._rootObjectKey];
            val_47 = 0;
            UnityEditor.XCodeEditor.PBXProject val_32 = new UnityEditor.XCodeEditor.PBXProject(guid:  this._rootObjectKey, dictionary:  val_47);
            this._project = null;
            val_48 = this._objects.Item[mainGroupID];
            val_44 = null;
            val_48 = 0;
            val_44 = new UnityEditor.XCodeEditor.PBXGroup(guid:  this._rootObjectKey, dictionary:  val_48);
            this._rootGroup = val_44;
            return;
            label_30:
            val_49 = new System.Exception(message:  0 + "Project file not found at file path ");
        }
        public string get_projectRootPath()
        {
            return (string)this.<projectRootPath>k__BackingField;
        }
        private void set_projectRootPath(string value)
        {
            this.<projectRootPath>k__BackingField = value;
        }
        public string get_filePath()
        {
            return (string)this.<filePath>k__BackingField;
        }
        private void set_filePath(string value)
        {
            this.<filePath>k__BackingField = value;
        }
        public UnityEditor.XCodeEditor.PBXProject get_project()
        {
            return (UnityEditor.XCodeEditor.PBXProject)this._project;
        }
        public UnityEditor.XCodeEditor.PBXGroup get_rootGroup()
        {
            return (UnityEditor.XCodeEditor.PBXGroup)this._rootGroup;
        }
        public UnityEditor.XCodeEditor.PBXSortedDictionary<UnityEditor.XCodeEditor.PBXBuildFile> get_buildFiles()
        {
            UnityEditor.XCodeEditor.PBXSortedDictionary<UnityEditor.XCodeEditor.PBXBuildFile> val_2 = this._buildFiles;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            UnityEditor.XCodeEditor.PBXSortedDictionary<UnityEditor.XCodeEditor.PBXBuildFile> val_1 = null;
            val_2 = val_1;
            val_1 = new UnityEditor.XCodeEditor.PBXSortedDictionary<UnityEditor.XCodeEditor.PBXBuildFile>(genericDictionary:  this._objects);
            this._buildFiles = val_2;
            return val_2;
        }
        public UnityEditor.XCodeEditor.PBXSortedDictionary<UnityEditor.XCodeEditor.PBXGroup> get_groups()
        {
            UnityEditor.XCodeEditor.PBXSortedDictionary<UnityEditor.XCodeEditor.PBXGroup> val_2 = this._groups;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            UnityEditor.XCodeEditor.PBXSortedDictionary<UnityEditor.XCodeEditor.PBXGroup> val_1 = null;
            val_2 = val_1;
            val_1 = new UnityEditor.XCodeEditor.PBXSortedDictionary<UnityEditor.XCodeEditor.PBXGroup>(genericDictionary:  this._objects);
            this._groups = val_2;
            return val_2;
        }
        public UnityEditor.XCodeEditor.PBXSortedDictionary<UnityEditor.XCodeEditor.PBXFileReference> get_fileReferences()
        {
            UnityEditor.XCodeEditor.PBXSortedDictionary<UnityEditor.XCodeEditor.PBXFileReference> val_2 = this._fileReferences;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            UnityEditor.XCodeEditor.PBXSortedDictionary<UnityEditor.XCodeEditor.PBXFileReference> val_1 = null;
            val_2 = val_1;
            val_1 = new UnityEditor.XCodeEditor.PBXSortedDictionary<UnityEditor.XCodeEditor.PBXFileReference>(genericDictionary:  this._objects);
            this._fileReferences = val_2;
            return val_2;
        }
        public UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXVariantGroup> get_variantGroups()
        {
            UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXVariantGroup> val_2 = this._variantGroups;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXVariantGroup> val_1 = null;
            val_2 = val_1;
            val_1 = new UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXVariantGroup>(genericDictionary:  this._objects);
            this._variantGroups = val_2;
            return val_2;
        }
        public UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXNativeTarget> get_nativeTargets()
        {
            UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXNativeTarget> val_2 = this._nativeTargets;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXNativeTarget> val_1 = null;
            val_2 = val_1;
            val_1 = new UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXNativeTarget>(genericDictionary:  this._objects);
            this._nativeTargets = val_2;
            return val_2;
        }
        public UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.XCBuildConfiguration> get_buildConfigurations()
        {
            UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.XCBuildConfiguration> val_2 = this._buildConfigurations;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.XCBuildConfiguration> val_1 = null;
            val_2 = val_1;
            val_1 = new UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.XCBuildConfiguration>(genericDictionary:  this._objects);
            this._buildConfigurations = val_2;
            return val_2;
        }
        public UnityEditor.XCodeEditor.PBXSortedDictionary<UnityEditor.XCodeEditor.XCConfigurationList> get_configurationLists()
        {
            UnityEditor.XCodeEditor.PBXSortedDictionary<UnityEditor.XCodeEditor.XCConfigurationList> val_2 = this._configurationLists;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            UnityEditor.XCodeEditor.PBXSortedDictionary<UnityEditor.XCodeEditor.XCConfigurationList> val_1 = null;
            val_2 = val_1;
            val_1 = new UnityEditor.XCodeEditor.PBXSortedDictionary<UnityEditor.XCodeEditor.XCConfigurationList>(genericDictionary:  this._objects);
            this._configurationLists = val_2;
            return val_2;
        }
        public UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXFrameworksBuildPhase> get_frameworkBuildPhases()
        {
            UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXFrameworksBuildPhase> val_2 = this._frameworkBuildPhases;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXFrameworksBuildPhase> val_1 = null;
            val_2 = val_1;
            val_1 = new UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXFrameworksBuildPhase>(genericDictionary:  this._objects);
            this._frameworkBuildPhases = val_2;
            return val_2;
        }
        public UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXResourcesBuildPhase> get_resourcesBuildPhases()
        {
            UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXResourcesBuildPhase> val_2 = this._resourcesBuildPhases;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXResourcesBuildPhase> val_1 = null;
            val_2 = val_1;
            val_1 = new UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXResourcesBuildPhase>(genericDictionary:  this._objects);
            this._resourcesBuildPhases = val_2;
            return val_2;
        }
        public UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXShellScriptBuildPhase> get_shellScriptBuildPhases()
        {
            UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXShellScriptBuildPhase> val_2 = this._shellScriptBuildPhases;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXShellScriptBuildPhase> val_1 = null;
            val_2 = val_1;
            val_1 = new UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXShellScriptBuildPhase>(genericDictionary:  this._objects);
            this._shellScriptBuildPhases = val_2;
            return val_2;
        }
        public UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXSourcesBuildPhase> get_sourcesBuildPhases()
        {
            UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXSourcesBuildPhase> val_2 = this._sourcesBuildPhases;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXSourcesBuildPhase> val_1 = null;
            val_2 = val_1;
            val_1 = new UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXSourcesBuildPhase>(genericDictionary:  this._objects);
            this._sourcesBuildPhases = val_2;
            return val_2;
        }
        public UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXCopyFilesBuildPhase> get_copyBuildPhases()
        {
            UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXCopyFilesBuildPhase> val_2 = this._copyBuildPhases;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXCopyFilesBuildPhase> val_1 = null;
            val_2 = val_1;
            val_1 = new UnityEditor.XCodeEditor.PBXDictionary<UnityEditor.XCodeEditor.PBXCopyFilesBuildPhase>(genericDictionary:  this._objects);
            this._copyBuildPhases = val_2;
            return val_2;
        }
        public bool AddOtherCFlags(string flag)
        {
            return this.AddOtherCFlags(flags:  new UnityEditor.XCodeEditor.PBXList(firstValue:  flag));
        }
        public bool AddOtherCFlags(UnityEditor.XCodeEditor.PBXList flags)
        {
            var val_5;
            var val_6;
            Dictionary.Enumerator<TKey, TValue> val_2 = this.buildConfigurations.GetEnumerator();
            label_4:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            UnityEngine.Playables.PlayableHandle val_3 = 0.GetHandle();
            bool val_4 = val_3.m_Handle.AddOtherCFlags(flags:  flags);
            goto label_4;
            label_2:
            val_5 = 0;
            val_6 = 1;
            0.Dispose();
            this.modified = true;
            return true;
        }
        public bool AddOtherLinkerFlags(string flag)
        {
            return this.AddOtherLinkerFlags(flags:  new UnityEditor.XCodeEditor.PBXList(firstValue:  flag));
        }
        public bool AddOtherLinkerFlags(UnityEditor.XCodeEditor.PBXList flags)
        {
            var val_5;
            var val_6;
            Dictionary.Enumerator<TKey, TValue> val_2 = this.buildConfigurations.GetEnumerator();
            label_4:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            UnityEngine.Playables.PlayableHandle val_3 = 0.GetHandle();
            bool val_4 = val_3.m_Handle.AddOtherLinkerFlags(flags:  flags);
            goto label_4;
            label_2:
            val_5 = 0;
            val_6 = 1;
            0.Dispose();
            this.modified = true;
            return true;
        }
        public bool overwriteBuildSetting(string settingName, string newValue, string buildConfigName = "all")
        {
            var val_4;
            string val_14;
            var val_15;
            typeof(System.String[]).__il2cppRuntimeField_20 = "overwriteBuildSetting ";
            typeof(System.String[]).__il2cppRuntimeField_28 = settingName;
            typeof(System.String[]).__il2cppRuntimeField_30 = " ";
            typeof(System.String[]).__il2cppRuntimeField_38 = newValue;
            typeof(System.String[]).__il2cppRuntimeField_40 = " ";
            typeof(System.String[]).__il2cppRuntimeField_48 = buildConfigName;
            string val_1 = +0;
            UnityEngine.Debug.Log(message:  0);
            Dictionary.Enumerator<TKey, TValue> val_3 = this.buildConfigurations.GetEnumerator();
            goto label_36;
            label_38:
            mem[1152921510170983768] = 1;
            label_36:
            if((0 & 1) == 0)
            {
                goto label_42;
            }
            
            UnityEngine.Playables.PlayableHandle val_6 = val_4.GetHandle();
            val_14 = val_6.m_Handle.data.Item["name"];
            val_15 = null;
            val_15 = null;
            if(val_14 != null)
            {
                    if(null == val_15)
            {
                goto label_32;
            }
            
            }
            
            val_14 = 0;
            label_32:
            if((System.String.op_Equality(a:  0, b:  val_14)) != true)
            {
                    if((System.String.op_Equality(a:  0, b:  buildConfigName)) == false)
            {
                goto label_36;
            }
            
            }
            
            goto label_38;
        }
        public bool AddHeaderSearchPaths(string path)
        {
            return this.AddHeaderSearchPaths(paths:  new UnityEditor.XCodeEditor.PBXList(firstValue:  path));
        }
        public bool AddHeaderSearchPaths(UnityEditor.XCodeEditor.PBXList paths)
        {
            var val_6;
            var val_7;
            string val_1 = 0 + "AddHeaderSearchPaths ";
            UnityEngine.Debug.Log(message:  0);
            Dictionary.Enumerator<TKey, TValue> val_3 = this.buildConfigurations.GetEnumerator();
            label_8:
            if((0 & 1) == 0)
            {
                goto label_6;
            }
            
            UnityEngine.Playables.PlayableHandle val_4 = 0.GetHandle();
            bool val_5 = val_4.m_Handle.AddHeaderSearchPaths(paths:  paths, recursive:  true);
            goto label_8;
            label_6:
            val_6 = 0;
            val_7 = 1;
            0.Dispose();
            this.modified = true;
            return true;
        }
        public bool AddLibrarySearchPaths(string path)
        {
            return this.AddLibrarySearchPaths(paths:  new UnityEditor.XCodeEditor.PBXList(firstValue:  path));
        }
        public bool AddLibrarySearchPaths(UnityEditor.XCodeEditor.PBXList paths)
        {
            var val_6;
            var val_7;
            string val_1 = 0 + "AddLibrarySearchPaths ";
            UnityEngine.Debug.Log(message:  0);
            Dictionary.Enumerator<TKey, TValue> val_3 = this.buildConfigurations.GetEnumerator();
            label_8:
            if((0 & 1) == 0)
            {
                goto label_6;
            }
            
            UnityEngine.Playables.PlayableHandle val_4 = 0.GetHandle();
            bool val_5 = val_4.m_Handle.AddLibrarySearchPaths(paths:  paths, recursive:  true);
            goto label_8;
            label_6:
            val_6 = 0;
            val_7 = 1;
            0.Dispose();
            this.modified = true;
            return true;
        }
        public bool AddFrameworkSearchPaths(string path)
        {
            return this.AddFrameworkSearchPaths(paths:  new UnityEditor.XCodeEditor.PBXList(firstValue:  path));
        }
        public bool AddFrameworkSearchPaths(UnityEditor.XCodeEditor.PBXList paths)
        {
            var val_5;
            var val_6;
            Dictionary.Enumerator<TKey, TValue> val_2 = this.buildConfigurations.GetEnumerator();
            label_4:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            UnityEngine.Playables.PlayableHandle val_3 = 0.GetHandle();
            bool val_4 = val_3.m_Handle.AddFrameworkSearchPaths(paths:  paths, recursive:  true);
            goto label_4;
            label_2:
            val_5 = 0;
            val_6 = 1;
            0.Dispose();
            this.modified = true;
            return true;
        }
        public object GetObject(string guid)
        {
            if(this._objects != null)
            {
                    return this._objects.Item[guid];
            }
            
            return this._objects.Item[guid];
        }
        public UnityEditor.XCodeEditor.PBXDictionary AddFile(string filePath, UnityEditor.XCodeEditor.PBXGroup parent, string tree = "SOURCE_ROOT", bool createBuildFiles = True, bool weak = False)
        {
            bool val_74;
            UnityEditor.XCodeEditor.PBXGroup val_75;
            string val_76;
            var val_77;
            var val_78;
            var val_79;
            string val_80;
            string val_81;
            var val_82;
            var val_83;
            var val_84;
            var val_85;
            var val_86;
            val_74 = createBuildFiles;
            val_75 = parent;
            val_76 = filePath;
            UnityEditor.XCodeEditor.PBXDictionary val_1 = null;
            val_77 = val_1;
            val_1 = new UnityEditor.XCodeEditor.PBXDictionary();
            if(val_76 != null)
            {
                    val_78 = null;
            }
            else
            {
                    UnityEngine.Debug.LogError(message:  0);
                return (UnityEditor.XCodeEditor.PBXDictionary)val_77;
            }
            
            val_79 = 1152921504622874624;
            val_80 = System.String.Empty;
            if((System.IO.Path.IsPathRooted(path:  0)) != false)
            {
                    UnityEngine.Debug.Log(message:  0);
                val_80 = val_76;
            }
            else
            {
                    if((tree.CompareTo(strB:  "SDKROOT")) != 0)
            {
                    val_74 = UnityEngine.Application.dataPath;
                val_80 = System.IO.Path.Combine(path1:  0, path2:  val_74);
            }
            
            }
            
            if(((System.IO.File.Exists(path:  0)) != true) && ((System.IO.Directory.Exists(path:  0)) != true))
            {
                    if((tree.CompareTo(strB:  "SDKROOT")) != 0)
            {
                    string val_11 = 0 + "Missing file: "("Missing file: ");
                UnityEngine.Debug.Log(message:  0);
                return (UnityEditor.XCodeEditor.PBXDictionary)val_77;
            }
            
            }
            
            if((tree.CompareTo(strB:  "SOURCE_ROOT")) == 0)
            {
                goto label_28;
            }
            
            if((tree.CompareTo(strB:  "GROUP")) != 0)
            {
                goto label_30;
            }
            
            UnityEngine.Debug.Log(message:  0);
            string val_14 = System.IO.Path.GetFileName(path:  0);
            goto label_35;
            label_28:
            UnityEngine.Debug.Log(message:  0);
            System.Uri val_17 = new System.Uri(uriString:  0 + this.<projectRootPath>k__BackingField(this.<projectRootPath>k__BackingField));
            val_79 = 1152921504622874624;
            val_74 = MakeRelativeUri(uri:  new System.Uri(uriString:  val_80));
            val_81 = val_74;
            label_35:
            val_76 = val_81;
            label_30:
            if(val_75 == null)
            {
                    val_75 = this._rootGroup;
            }
            
            if((this.GetFile(name:  System.IO.Path.GetFileName(path:  0))) == null)
            {
                goto label_45;
            }
            
            string val_21 = 0 + "File already exists: "("File already exists: ");
            UnityEngine.Debug.Log(message:  0);
            label_130:
            val_77 = 0;
            return (UnityEditor.XCodeEditor.PBXDictionary)val_77;
            label_45:
            object val_23 = System.Enum.Parse(enumType:  0, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            UnityEngine.Vector2 val_24 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            UnityEditor.XCodeEditor.PBXFileReference val_25 = new UnityEditor.XCodeEditor.PBXFileReference(filePath:  val_76, tree:  null);
            string val_26 = val_75.AddChild(child:  null);
            this.fileReferences.Add(newObject:  null);
            Add(key:  guid, value:  null);
            if(val_74 == false)
            {
                    return (UnityEditor.XCodeEditor.PBXDictionary)val_77;
            }
            
            if(((System.String.IsNullOrEmpty(value:  0)) ^ 1) == false)
            {
                    return (UnityEditor.XCodeEditor.PBXDictionary)val_77;
            }
            
            if((System.String.op_Equality(a:  0, b:  UnityEditor.XCodeEditor.PBXFileReference.__il2cppRuntimeField_this_arg)) == false)
            {
                goto label_69;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_36 = this.frameworkBuildPhases.GetEnumerator();
            label_72:
            if((0 & 1) == 0)
            {
                goto label_71;
            }
            
            UnityEngine.Playables.PlayableHandle val_37 = 0.GetHandle();
            bool val_38 = weak;
            this.BuildAddFile(fileReference:  null, currentObject:  new System.Collections.Generic.KeyValuePair<System.String, UnityEditor.XCodeEditor.PBXFrameworksBuildPhase>() {Value = val_37.m_Handle}, weak:  val_37.m_Version);
            goto label_72;
            label_69:
            if((System.String.op_Equality(a:  0, b:  UnityEditor.XCodeEditor.PBXFileReference.__il2cppRuntimeField_this_arg)) == false)
            {
                goto label_81;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_43 = this.resourcesBuildPhases.GetEnumerator();
            label_86:
            if((0 & 1) == 0)
            {
                goto label_83;
            }
            
            UnityEngine.Playables.PlayableHandle val_44 = 0.GetHandle();
            UnityEngine.Debug.Log(message:  0);
            bool val_45 = weak;
            this.BuildAddFile(fileReference:  null, currentObject:  new System.Collections.Generic.KeyValuePair<System.String, UnityEditor.XCodeEditor.PBXResourcesBuildPhase>() {Value = val_44.m_Handle}, weak:  val_44.m_Version);
            goto label_86;
            label_81:
            if((System.String.op_Equality(a:  0, b:  UnityEditor.XCodeEditor.PBXFileReference.__il2cppRuntimeField_this_arg)) == false)
            {
                goto label_90;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_49 = this.shellScriptBuildPhases.GetEnumerator();
            label_95:
            if((0 & 1) == 0)
            {
                goto label_92;
            }
            
            UnityEngine.Playables.PlayableHandle val_50 = 0.GetHandle();
            UnityEngine.Debug.Log(message:  0);
            bool val_51 = weak;
            this.BuildAddFile(fileReference:  null, currentObject:  new System.Collections.Generic.KeyValuePair<System.String, UnityEditor.XCodeEditor.PBXShellScriptBuildPhase>() {Value = val_50.m_Handle}, weak:  val_50.m_Version);
            goto label_95;
            label_71:
            val_82 = 0;
            val_83 = 1;
            0.Dispose();
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return (UnityEditor.XCodeEditor.PBXDictionary)val_77;
            }
            
            if((tree.CompareTo(strB:  "SOURCE_ROOT")) != 0)
            {
                    return (UnityEditor.XCodeEditor.PBXDictionary)val_77;
            }
            
            string val_55 = System.IO.Path.GetDirectoryName(path:  0);
            UnityEditor.XCodeEditor.PBXList val_58 = new UnityEditor.XCodeEditor.PBXList(firstValue:  System.IO.Path.Combine(path1:  0, path2:  "$(SRCROOT)"));
            if((System.IO.File.Exists(path:  0)) == false)
            {
                goto label_106;
            }
            
            bool val_59 = this.AddLibrarySearchPaths(paths:  val_58);
            return (UnityEditor.XCodeEditor.PBXDictionary)val_77;
            label_90:
            if((System.String.op_Equality(a:  0, b:  UnityEditor.XCodeEditor.PBXFileReference.__il2cppRuntimeField_this_arg)) == false)
            {
                goto label_110;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_63 = this.sourcesBuildPhases.GetEnumerator();
            label_115:
            if((0 & 1) == 0)
            {
                goto label_112;
            }
            
            UnityEngine.Playables.PlayableHandle val_64 = 0.GetHandle();
            UnityEngine.Debug.Log(message:  0);
            bool val_65 = weak;
            this.BuildAddFile(fileReference:  null, currentObject:  new System.Collections.Generic.KeyValuePair<System.String, UnityEditor.XCodeEditor.PBXSourcesBuildPhase>() {Value = val_64.m_Handle}, weak:  val_64.m_Version);
            goto label_115;
            label_110:
            if((System.String.op_Equality(a:  0, b:  UnityEditor.XCodeEditor.PBXFileReference.__il2cppRuntimeField_this_arg)) == false)
            {
                goto label_119;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_69 = this.copyBuildPhases.GetEnumerator();
            label_124:
            if((0 & 1) == 0)
            {
                goto label_121;
            }
            
            UnityEngine.Playables.PlayableHandle val_70 = 0.GetHandle();
            UnityEngine.Debug.Log(message:  0);
            bool val_71 = weak;
            this.BuildAddFile(fileReference:  null, currentObject:  new System.Collections.Generic.KeyValuePair<System.String, UnityEditor.XCodeEditor.PBXCopyFilesBuildPhase>() {Value = val_70.m_Handle}, weak:  val_70.m_Version);
            goto label_124;
            label_83:
            val_84 = 0;
            val_85 = 1;
            val_86 = public System.Void Dictionary.Enumerator<System.String, UnityEditor.XCodeEditor.PBXResourcesBuildPhase>::Dispose();
            goto label_132;
            label_106:
            bool val_72 = this.AddFrameworkSearchPaths(paths:  val_58);
            return (UnityEditor.XCodeEditor.PBXDictionary)val_77;
            label_119:
            UnityEngine.Debug.LogWarning(message:  0);
            goto label_130;
            label_92:
            val_84 = 0;
            val_85 = 1;
            val_86 = public System.Void Dictionary.Enumerator<System.String, UnityEditor.XCodeEditor.PBXShellScriptBuildPhase>::Dispose();
            goto label_132;
            label_112:
            val_84 = 0;
            val_85 = 1;
            val_86 = public System.Void Dictionary.Enumerator<System.String, UnityEditor.XCodeEditor.PBXSourcesBuildPhase>::Dispose();
            goto label_132;
            label_121:
            val_84 = 0;
            val_85 = 1;
            val_86 = public System.Void Dictionary.Enumerator<System.String, UnityEditor.XCodeEditor.PBXCopyFilesBuildPhase>::Dispose();
            label_132:
            0.Dispose();
            if((val_85 & 1) != 0)
            {
                    return (UnityEditor.XCodeEditor.PBXDictionary)val_77;
            }
            
            if(val_84 == 0)
            {
                    return (UnityEditor.XCodeEditor.PBXDictionary)val_77;
            }
            
            return (UnityEditor.XCodeEditor.PBXDictionary)val_77;
        }
        public UnityEditor.XCodeEditor.PBXNativeTarget GetNativeTarget(string name)
        {
            var val_3;
            string val_11;
            var val_12;
            var val_13;
            IntPtr val_14;
            var val_15;
            Dictionary.Enumerator<TKey, TValue> val_2 = this.nativeTargets.GetEnumerator();
            label_9:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            UnityEngine.Playables.PlayableHandle val_5 = val_3.GetHandle();
            val_11 = val_5.m_Handle.data.Item["name"];
            val_12 = null;
            if(val_11 == null)
            {
                goto label_5;
            }
            
            if(null == val_12)
            {
                goto label_6;
            }
            
            val_12 = null;
            label_5:
            val_11 = 0;
            label_6:
            if((System.String.op_Equality(a:  0, b:  val_11)) == false)
            {
                goto label_9;
            }
            
            val_13;
            val_14 = 0;
            goto label_10;
            label_2:
            val_14 = 0;
            val_13 = 0;
            label_10:
            val_15 = 1;
            val_3.Dispose();
            if((val_15 & 1) != 0)
            {
                    return (UnityEditor.XCodeEditor.PBXNativeTarget)val_13;
            }
            
            if(val_14 == 0)
            {
                    return (UnityEditor.XCodeEditor.PBXNativeTarget)val_13;
            }
            
            return (UnityEditor.XCodeEditor.PBXNativeTarget)val_13;
        }
        public int GetBuildActionMask()
        {
            var val_8;
            var val_9;
            Dictionary.Enumerator<TKey, TValue> val_2 = this.copyBuildPhases.GetEnumerator();
            if((0 & 1) != 0)
            {
                    UnityEngine.Playables.PlayableHandle val_3 = 0.GetHandle();
                object val_5 = val_3.m_Handle.data.Item["buildActionMask"];
                UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
                val_9 = 0;
            }
            else
            {
                    val_9 = 0;
                val_8 = 0;
            }
            
            0.Dispose();
            if((1 & 1) != 0)
            {
                    return (int)val_8;
            }
            
            if(val_9 == 0)
            {
                    return (int)val_8;
            }
            
            return (int)val_8;
        }
        public UnityEditor.XCodeEditor.PBXCopyFilesBuildPhase AddEmbedFrameworkBuildPhase()
        {
            var val_5;
            var val_22;
            string val_23;
            var val_24;
            UnityEditor.XCodeEditor.PBXCopyFilesBuildPhase val_25;
            var val_27;
            val_22 = this;
            UnityEditor.XCodeEditor.PBXNativeTarget val_1 = this.GetNativeTarget(name:  "Unity-iPhone");
            if(val_1 == null)
            {
                goto label_1;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_3 = this.copyBuildPhases.GetEnumerator();
            label_11:
            if((0 & 1) == 0)
            {
                goto label_3;
            }
            
            UnityEngine.Playables.PlayableHandle val_6 = val_5.GetHandle();
            object val_8 = 0;
            if((val_6.m_Handle.data.TryGetValue(key:  "name", value: out  val_8)) == false)
            {
                goto label_11;
            }
            
            val_23 = val_8;
            val_24 = null;
            if(val_23 == 0)
            {
                goto label_7;
            }
            
            if(1179403647 == val_24)
            {
                goto label_8;
            }
            
            val_24 = null;
            label_7:
            val_23 = 0;
            label_8:
            if((System.String.op_Equality(a:  0, b:  val_23)) == false)
            {
                goto label_11;
            }
            
            val_25;
            val_5.Dispose();
            return val_25;
            label_1:
            UnityEngine.Debug.Log(message:  0);
            val_25 = 0;
            return val_25;
            label_3:
            val_5.Dispose();
            UnityEditor.XCodeEditor.PBXCopyFilesBuildPhase val_14 = null;
            val_25 = val_14;
            val_14 = new UnityEditor.XCodeEditor.PBXCopyFilesBuildPhase(buildActionMask:  this.GetBuildActionMask());
            val_27 = val_1.data.Item["buildPhases"];
            val_27 = 0;
            string val_19 = guid;
            val_22 = this.copyBuildPhases;
            val_22.Add(newObject:  val_25);
            return val_25;
        }
        public void AddEmbedFramework(string fileName)
        {
            var val_10;
            object val_11;
            val_10 = this;
            string val_1 = 0 + "Add Embed Framework: "("Add Embed Framework: ");
            UnityEngine.Debug.Log(message:  0);
            UnityEditor.XCodeEditor.PBXFileReference val_3 = this.GetFile(name:  System.IO.Path.GetFileName(path:  0));
            if(val_3 == null)
            {
                goto label_7;
            }
            
            UnityEditor.XCodeEditor.PBXCopyFilesBuildPhase val_4 = this.AddEmbedFrameworkBuildPhase();
            if(val_4 == null)
            {
                goto label_8;
            }
            
            UnityEditor.XCodeEditor.PBXBuildFile val_5 = new UnityEditor.XCodeEditor.PBXBuildFile(fileRef:  val_3, weak:  false);
            bool val_6 = AddCodeSignOnCopy();
            this.buildFiles.Add(newObject:  val_5);
            bool val_8 = val_4.AddBuildFile(file:  val_5);
            return;
            label_7:
            val_10 = 0 + "Embed Framework must added already: "("Embed Framework must added already: ");
            val_11 = 0;
            goto label_15;
            label_8:
            val_11 = 0;
            label_15:
            UnityEngine.Debug.Log(message:  val_11);
        }
        private void BuildAddFile(UnityEditor.XCodeEditor.PBXFileReference fileReference, System.Collections.Generic.KeyValuePair<string, UnityEditor.XCodeEditor.PBXFrameworksBuildPhase> currentObject, bool weak)
        {
            UnityEditor.XCodeEditor.PBXBuildFile val_2 = new UnityEditor.XCodeEditor.PBXBuildFile(fileRef:  fileReference, weak:  W4 & 1);
            this.buildFiles.Add(newObject:  val_2);
            bool val_4 = currentObject.Value.AddBuildFile(file:  val_2);
        }
        private void BuildAddFile(UnityEditor.XCodeEditor.PBXFileReference fileReference, System.Collections.Generic.KeyValuePair<string, UnityEditor.XCodeEditor.PBXResourcesBuildPhase> currentObject, bool weak)
        {
            UnityEditor.XCodeEditor.PBXBuildFile val_2 = new UnityEditor.XCodeEditor.PBXBuildFile(fileRef:  fileReference, weak:  W4 & 1);
            this.buildFiles.Add(newObject:  val_2);
            bool val_4 = currentObject.Value.AddBuildFile(file:  val_2);
        }
        private void BuildAddFile(UnityEditor.XCodeEditor.PBXFileReference fileReference, System.Collections.Generic.KeyValuePair<string, UnityEditor.XCodeEditor.PBXShellScriptBuildPhase> currentObject, bool weak)
        {
            UnityEditor.XCodeEditor.PBXBuildFile val_2 = new UnityEditor.XCodeEditor.PBXBuildFile(fileRef:  fileReference, weak:  W4 & 1);
            this.buildFiles.Add(newObject:  val_2);
            bool val_4 = currentObject.Value.AddBuildFile(file:  val_2);
        }
        private void BuildAddFile(UnityEditor.XCodeEditor.PBXFileReference fileReference, System.Collections.Generic.KeyValuePair<string, UnityEditor.XCodeEditor.PBXSourcesBuildPhase> currentObject, bool weak)
        {
            UnityEditor.XCodeEditor.PBXBuildFile val_2 = new UnityEditor.XCodeEditor.PBXBuildFile(fileRef:  fileReference, weak:  W4 & 1);
            this.buildFiles.Add(newObject:  val_2);
            bool val_4 = currentObject.Value.AddBuildFile(file:  val_2);
        }
        private void BuildAddFile(UnityEditor.XCodeEditor.PBXFileReference fileReference, System.Collections.Generic.KeyValuePair<string, UnityEditor.XCodeEditor.PBXCopyFilesBuildPhase> currentObject, bool weak)
        {
            UnityEditor.XCodeEditor.PBXBuildFile val_2 = new UnityEditor.XCodeEditor.PBXBuildFile(fileRef:  fileReference, weak:  W4 & 1);
            this.buildFiles.Add(newObject:  val_2);
            bool val_4 = currentObject.Value.AddBuildFile(file:  val_2);
        }
        public bool AddFolder(string folderPath, UnityEditor.XCodeEditor.PBXGroup parent, string[] exclude, bool recursive = True, bool createBuildFile = True)
        {
            var val_21;
            UnityEditor.XCodeEditor.PBXGroup val_22;
            var val_23;
            bool val_24;
            var val_25;
            var val_26;
            val_22 = parent;
            val_23 = 0 + "Folder PATH: "("Folder PATH: ");
            UnityEngine.Debug.Log(message:  0);
            if((System.IO.Directory.Exists(path:  0)) == false)
            {
                goto label_5;
            }
            
            if((folderPath.EndsWith(value:  ".lproj")) == false)
            {
                goto label_7;
            }
            
            UnityEngine.Debug.Log(message:  0);
            return this.AddLocFolder(folderPath:  folderPath, parent:  val_22, exclude:  exclude, createBuildFile:  createBuildFile);
            label_5:
            UnityEngine.Debug.Log(message:  0);
            val_24 = 0;
            return val_24;
            label_7:
            if(exclude == 0)
            {
                    UnityEngine.Debug.Log(message:  0);
                val_25 = 0;
            }
            
            if(val_22 == null)
            {
                    val_25 = "Parent was null";
                UnityEngine.Debug.Log(message:  0);
                val_22 = this._rootGroup;
            }
            
            UnityEditor.XCodeEditor.PBXGroup val_7 = this.GetGroup(name:  new System.IO.DirectoryInfo(path:  folderPath), path:  0, parent:  val_22);
            UnityEngine.Debug.Log(message:  0);
            val_26 = 0;
            goto label_22;
            label_41:
            val_26 = 1;
            label_22:
            if(val_26 >= val_8.Length)
            {
                goto label_24;
            }
            
            string val_21 = System.IO.Directory.GetDirectories(path:  0)[1];
            string val_9 = 0 + "DIR: "("DIR: ");
            UnityEngine.Debug.Log(message:  0);
            if((val_21.EndsWith(value:  ".bundle")) == false)
            {
                goto label_31;
            }
            
            string val_11 = 0 + "This is a special folder: "("This is a special folder: ");
            UnityEngine.Debug.LogWarning(message:  0);
            UnityEditor.XCodeEditor.PBXDictionary val_13 = this.AddFile(filePath:  val_21, parent:  val_7, tree:  "SOURCE_ROOT", createBuildFiles:  createBuildFile, weak:  false);
            goto label_41;
            label_31:
            if(recursive == false)
            {
                goto label_41;
            }
            
            UnityEngine.Debug.Log(message:  0);
            createBuildFile = createBuildFile;
            goto label_41;
            label_24:
            string val_14 = System.String.Join(separator:  0, value:  "|");
            string val_15 = System.String.Format(format:  0, arg0:  "{0}");
            val_21 = System.IO.Directory.GetFiles(path:  0);
            val_23 = 0;
            goto label_44;
            label_53:
            val_23 = 1;
            label_44:
            if(val_23 >= val_16.Length)
            {
                goto label_46;
            }
            
            string val_22 = val_21[1];
            if((System.Text.RegularExpressions.Regex.IsMatch(input:  0, pattern:  val_22)) == true)
            {
                goto label_53;
            }
            
            UnityEngine.Debug.Log(message:  0);
            UnityEditor.XCodeEditor.PBXDictionary val_20 = this.AddFile(filePath:  val_22, parent:  val_7, tree:  "SOURCE_ROOT", createBuildFiles:  createBuildFile, weak:  false);
            goto label_53;
            label_46:
            val_24 = true;
            this.modified = val_24;
            return val_24;
        }
        public bool AddLocFolder(string folderPath, UnityEditor.XCodeEditor.PBXGroup parent, string[] exclude, bool createBuildFile = True)
        {
            var val_22;
            UnityEditor.XCodeEditor.PBXGroup val_23;
            var val_24;
            var val_25;
            val_22 = exclude;
            val_23 = parent;
            if(val_22 == null)
            {
                    val_22 = null;
            }
            
            if(val_23 == null)
            {
                    val_23 = mem[1152921510174215504];
            }
            
            System.Uri val_3 = new System.Uri(uriString:  mem[1152921510174215528].DirectoryName);
            val_24 = ".lproj";
            if(".lproj" == null)
            {
                    val_24 = ".lproj";
            }
            
            mem[1152921510174215648].AddRegion(region:  Substring(startIndex:  0, length:  Length - Length));
            string val_11 = System.String.Join(separator:  0, value:  "|");
            string val_12 = System.String.Format(format:  0, arg0:  "{0}");
            val_25 = 0;
            goto label_14;
            label_25:
            val_25 = 1;
            label_14:
            if(val_25 >= val_13.Length)
            {
                goto label_16;
            }
            
            string val_22 = System.IO.Directory.GetFiles(path:  0)[1];
            if((System.Text.RegularExpressions.Regex.IsMatch(input:  0, pattern:  val_22)) == true)
            {
                goto label_25;
            }
            
            UnityEditor.XCodeEditor.PBXGroup val_18 = new UnityEditor.XCodeEditor.PBXGroup(name:  System.IO.Path.GetFileName(path:  0), path:  0, tree:  "GROUP");
            this.variantGroups.Add(newObject:  val_18);
            string val_20 = this.GetGroup(name:  new System.IO.DirectoryInfo(path:  folderPath), path:  MakeRelativeUri(uri:  new System.Uri(uriString:  folderPath)), parent:  val_23).AddChild(child:  val_18);
            UnityEditor.XCodeEditor.PBXDictionary val_21 = this.AddFile(filePath:  val_22, parent:  val_18, tree:  "GROUP", createBuildFiles:  createBuildFile, weak:  false);
            goto label_25;
            label_16:
            mem[1152921510174215544] = 1;
            return true;
        }
        public UnityEditor.XCodeEditor.PBXFileReference GetFile(string name)
        {
            string val_11;
            var val_12;
            val_11 = name;
            val_12 = 0;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return (UnityEditor.XCodeEditor.PBXFileReference)val_12;
            }
            
            SortedDictionary.Enumerator<TKey, TValue> val_4 = this.fileReferences.GetEnumerator();
            label_12:
            if((0 & 1) == 0)
            {
                goto label_5;
            }
            
            UnityEngine.Hash128 val_5 = 0.hash;
            string val_6 = val_5.m_u32_0.name;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_12;
            }
            
            if((val_5.m_u32_0.name.CompareTo(strB:  val_11)) != 0)
            {
                goto label_12;
            }
            
            val_12;
            0.Dispose();
            return (UnityEditor.XCodeEditor.PBXFileReference)val_12;
            label_5:
            0.Dispose();
            val_12 = 0;
            return (UnityEditor.XCodeEditor.PBXFileReference)val_12;
        }
        public UnityEditor.XCodeEditor.PBXGroup GetGroup(string name, string path, UnityEditor.XCodeEditor.PBXGroup parent)
        {
            var val_7;
            UnityEditor.XCodeEditor.PBXGroup val_22;
            string val_23;
            UnityEditor.XCodeEditor.PBXGroup val_24;
            val_22 = parent;
            val_23 = path;
            val_24 = 0;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return val_24;
            }
            
            if(val_22 == null)
            {
                    val_22 = this._rootGroup;
            }
            
            SortedDictionary.Enumerator<TKey, TValue> val_4 = this.groups.GetEnumerator();
            label_21:
            if((0 & 1) == 0)
            {
                goto label_6;
            }
            
            UnityEngine.Hash128 val_8 = val_7.hash;
            string val_9 = val_8.m_u32_0.name;
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_10;
            }
            
            if(((val_8.m_u32_0.path.CompareTo(strB:  name)) != 0) || ((val_22.HasChild(id:  val_8.m_u32_0.InitializationCallback)) == false))
            {
                goto label_21;
            }
            
            goto label_16;
            label_10:
            if(((val_8.m_u32_0.name.CompareTo(strB:  name)) != 0) || ((val_22.HasChild(id:  val_8.m_u32_0.InitializationCallback)) == false))
            {
                goto label_21;
            }
            
            goto label_22;
            label_26:
            UnityEditor.XCodeEditor.PBXGroup val_19 = null;
            val_24 = val_19;
            val_19 = new UnityEditor.XCodeEditor.PBXGroup(name:  name, path:  val_23, tree:  "SOURCE_ROOT");
            val_23 = this.groups;
            val_23.Add(newObject:  val_24);
            string val_21 = val_22.AddChild(child:  val_24);
            this.modified = true;
            return val_24;
            label_6:
            val_7.Dispose();
            goto label_26;
            label_16:
            label_22:
            val_7.Dispose();
            return val_24;
        }
        public void ApplyMod(string pbxmod)
        {
            var val_8;
            var val_9;
            var val_10;
            System.Collections.ArrayList val_2 = libs;
            label_18:
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_8 = val_2;
            if(((val_2 & 1) & 1) == 0)
            {
                goto label_26;
            }
            
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_9 = val_2;
            string val_6 = 0 + "Library: "("Library: ");
            UnityEngine.Debug.Log(message:  0);
            goto label_18;
            label_26:
            if(val_2 != null)
            {
                    var val_10 = 0;
                val_10 = val_10 + 1;
                val_10 = val_2;
            }
            
            this.ApplyMod(mod:  new UnityEditor.XCodeEditor.XCMod(filename:  pbxmod));
        }
        public void ApplyMod(UnityEditor.XCodeEditor.XCMod mod)
        {
            var val_84;
            var val_85;
            var val_86;
            var val_87;
            var val_89;
            var val_90;
            var val_91;
            var val_92;
            int val_93;
            var val_94;
            var val_95;
            var val_96;
            var val_97;
            var val_98;
            var val_99;
            var val_100;
            var val_101;
            var val_102;
            var val_103;
            var val_104;
            var val_105;
            var val_106;
            var val_107;
            System.String[] val_108;
            var val_109;
            var val_110;
            var val_111;
            string val_112;
            var val_113;
            var val_114;
            var val_115;
            string val_116;
            var val_117;
            var val_118;
            var val_119;
            string val_120;
            var val_121;
            UnityEditor.XCodeEditor.PBXGroup val_2 = this.GetGroup(name:  mod.group, path:  0, parent:  0);
            UnityEngine.Debug.Log(message:  0);
            System.Collections.ArrayList val_3 = mod.libs;
            if(val_3 != null)
            {
                goto label_22;
            }
            
            goto label_22;
            label_29:
            var val_84 = 0;
            val_84 = val_84 + 1;
            val_84 = val_3;
            string val_8 = 0 + "Adding library ";
            UnityEngine.Debug.Log(message:  0);
            UnityEditor.XCodeEditor.PBXDictionary val_9 = this.AddFile(filePath:  System.IO.Path.Combine(path1:  0, path2:  "usr/lib"), parent:  val_2, tree:  "SDKROOT", createBuildFiles:  true, weak:  false);
            label_22:
            var val_85 = 0;
            val_85 = val_85 + 1;
            val_85 = val_3;
            if(((val_3 & 1) & 1) != 0)
            {
                goto label_29;
            }
            
            val_86 = 0;
            val_87 = 146;
            if(val_3 != null)
            {
                    var val_86 = 0;
                val_86 = val_86 + 1;
                val_89 = val_3;
            }
            
            if( == 146)
            {
                
            }
            
            UnityEngine.Debug.Log(message:  0);
            System.Collections.ArrayList val_14 = mod.frameworks;
            label_65:
            var val_87 = 0;
            val_87 = val_87 + 1;
            val_90 = val_14;
            if(((val_14 & 1) & 1) == 0)
            {
                goto label_278;
            }
            
            var val_88 = 0;
            val_88 = val_88 + 1;
            val_91 = val_14;
            val_92 = val_14;
            if(val_92 != null)
            {
                    if(null == null)
            {
                goto label_56;
            }
            
            }
            
            val_92 = 0;
            label_56:
            typeof(System.Char[]).__il2cppRuntimeField_20 = 58;
            System.String[] val_19 = val_92.Split(separator:  null);
            if(val_19 != null)
            {
                    val_93 = val_19.Length;
                val_94 = val_93;
            }
            else
            {
                    val_94 = 7254272;
                val_93 = 7254272;
            }
            
            string val_89 = val_19[0];
            UnityEditor.XCodeEditor.PBXDictionary val_22 = this.AddFile(filePath:  System.IO.Path.Combine(path1:  0, path2:  "System/Library/Frameworks"), parent:  this.GetGroup(name:  "Frameworks", path:  0, parent:  0), tree:  "SDKROOT", createBuildFiles:  true, weak:  (val_94 > 1) ? 1 : 0);
            goto label_65;
            label_278:
            if(val_14 != null)
            {
                    var val_90 = 0;
                val_90 = val_90 + 1;
                val_95 = val_14;
            }
            
            if( == 317)
            {
                
            }
            
            UnityEngine.Debug.Log(message:  0);
            System.Collections.ArrayList val_24 = mod.files;
            label_95:
            var val_91 = 0;
            val_91 = val_91 + 1;
            val_96 = val_24;
            if(((val_24 & 1) & 1) == 0)
            {
                goto label_273;
            }
            
            var val_92 = 0;
            val_92 = val_92 + 1;
            val_97 = val_24;
            val_98 = val_24;
            if(val_98 != null)
            {
                    if(null == null)
            {
                goto label_91;
            }
            
            }
            
            val_98 = 0;
            label_91:
            UnityEditor.XCodeEditor.PBXDictionary val_30 = this.AddFile(filePath:  System.IO.Path.Combine(path1:  0, path2:  mod.<path>k__BackingField), parent:  val_2, tree:  "SOURCE_ROOT", createBuildFiles:  true, weak:  false);
            goto label_95;
            label_273:
            if(val_24 != null)
            {
                    var val_93 = 0;
                val_93 = val_93 + 1;
                val_99 = val_24;
            }
            
            if( == 431)
            {
                    val_100 = 0;
            }
            
            UnityEngine.Debug.Log(message:  0);
            if(mod.embed_binaries == null)
            {
                goto label_135;
            }
            
            bool val_33 = this.overwriteBuildSetting(settingName:  "LD_RUNPATH_SEARCH_PATHS", newValue:  "$(inherited) @executable_path/Frameworks", buildConfigName:  "Release");
            bool val_34 = this.overwriteBuildSetting(settingName:  "LD_RUNPATH_SEARCH_PATHS", newValue:  "$(inherited) @executable_path/Frameworks", buildConfigName:  "Debug");
            System.Collections.ArrayList val_35 = mod.embed_binaries;
            label_127:
            var val_94 = 0;
            val_94 = val_94 + 1;
            val_101 = val_35;
            if(((val_35 & 1) & 1) == 0)
            {
                goto label_280;
            }
            
            var val_95 = 0;
            val_95 = val_95 + 1;
            val_102 = val_35;
            val_103 = val_35;
            if(val_103 != null)
            {
                    if(null == null)
            {
                goto label_123;
            }
            
            }
            
            val_103 = 0;
            label_123:
            this.AddEmbedFramework(fileName:  System.IO.Path.Combine(path1:  0, path2:  mod.<path>k__BackingField));
            goto label_127;
            label_280:
            if(val_35 != null)
            {
                    var val_96 = 0;
                val_96 = val_96 + 1;
                val_104 = val_35;
            }
            
            if( == 591)
            {
                    val_100 = 0;
            }
            
            label_135:
            UnityEngine.Debug.Log(message:  0);
            System.Collections.ArrayList val_42 = mod.folders;
            label_166:
            var val_97 = 0;
            val_97 = val_97 + 1;
            val_105 = val_42;
            if(((val_42 & 1) & 1) == 0)
            {
                goto label_281;
            }
            
            var val_98 = 0;
            val_98 = val_98 + 1;
            val_106 = val_42;
            val_107 = val_42;
            if(val_107 != null)
            {
                    if(null == null)
            {
                goto label_153;
            }
            
            }
            
            val_107 = 0;
            label_153:
            string val_49 = 0 + "Adding folder ";
            UnityEngine.Debug.Log(message:  0);
            System.Collections.ArrayList val_50 = mod.excludes;
            System.Type val_51 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if(val_50 == null)
            {
                goto label_164;
            }
            
            val_108 = val_50;
            if(val_108 != null)
            {
                goto label_165;
            }
            
            label_164:
            val_108 = 0;
            label_165:
            bool val_53 = this.AddFolder(folderPath:  System.IO.Path.Combine(path1:  0, path2:  UnityEngine.Application.dataPath), parent:  val_2, exclude:  val_108, recursive:  true, createBuildFile:  true);
            goto label_166;
            label_281:
            if(val_42 != null)
            {
                    var val_99 = 0;
                val_99 = val_99 + 1;
                val_109 = val_42;
            }
            
            if( == 742)
            {
                
            }
            
            UnityEngine.Debug.Log(message:  0);
            System.Collections.ArrayList val_55 = mod.headerpaths;
            label_202:
            var val_100 = 0;
            val_100 = val_100 + 1;
            val_110 = val_55;
            if(((val_55 & 1) & 1) == 0)
            {
                goto label_274;
            }
            
            var val_101 = 0;
            val_101 = val_101 + 1;
            val_111 = val_55;
            val_112 = val_55;
            if(val_112 != null)
            {
                    if(null == null)
            {
                goto label_192;
            }
            
            }
            
            val_112 = 0;
            label_192:
            if((val_112.Contains(value:  "$(inherited)")) == false)
            {
                goto label_193;
            }
            
            string val_62 = 0 + "not prepending a path to ";
            UnityEngine.Debug.Log(message:  0);
            bool val_63 = this.AddHeaderSearchPaths(path:  val_112);
            goto label_202;
            label_193:
            bool val_65 = this.AddHeaderSearchPaths(path:  System.IO.Path.Combine(path1:  0, path2:  mod.<path>k__BackingField));
            goto label_202;
            label_274:
            if(val_55 != null)
            {
                    var val_102 = 0;
                val_102 = val_102 + 1;
                val_113 = val_55;
            }
            
            if( == 896)
            {
                
            }
            
            UnityEngine.Debug.Log(message:  0);
            System.Collections.ArrayList val_67 = mod.compiler_flags;
            label_229:
            var val_103 = 0;
            val_103 = val_103 + 1;
            val_114 = val_67;
            if(((val_67 & 1) & 1) == 0)
            {
                goto label_271;
            }
            
            var val_104 = 0;
            val_104 = val_104 + 1;
            val_115 = val_67;
            val_116 = val_67;
            if(val_116 != null)
            {
                    if(null == null)
            {
                goto label_228;
            }
            
            }
            
            val_116 = 0;
            label_228:
            bool val_72 = this.AddOtherCFlags(flag:  val_116);
            goto label_229;
            label_271:
            if(val_67 != null)
            {
                    var val_105 = 0;
                val_105 = val_105 + 1;
                val_117 = val_67;
            }
            
            if( == 987)
            {
                
            }
            
            UnityEngine.Debug.Log(message:  0);
            System.Collections.ArrayList val_74 = mod.linker_flags;
            label_256:
            var val_106 = 0;
            val_106 = val_106 + 1;
            val_118 = val_74;
            if(((val_74 & 1) & 1) == 0)
            {
                goto label_272;
            }
            
            var val_107 = 0;
            val_107 = val_107 + 1;
            val_119 = val_74;
            val_120 = val_74;
            if(val_120 != null)
            {
                    if(null == null)
            {
                goto label_255;
            }
            
            }
            
            val_120 = 0;
            label_255:
            bool val_79 = this.AddOtherLinkerFlags(flag:  val_120);
            goto label_256;
            label_272:
            if(val_74 != null)
            {
                    var val_108 = 0;
                val_108 = val_108 + 1;
                val_121 = val_74;
            }
            
            UnityEngine.Debug.Log(message:  0);
            object val_82 = new System.Object();
            typeof(UnityEditor.XCodeEditor.XCPlist).__il2cppRuntimeField_10 = 0 + this.<projectRootPath>k__BackingField(this.<projectRootPath>k__BackingField);
            Process(plist:  mod.plist);
            this.Consolidate();
        }
        public void Consolidate()
        {
            Append<UnityEditor.XCodeEditor.PBXBuildFile>(dictionary:  this.buildFiles);
            Append<UnityEditor.XCodeEditor.PBXCopyFilesBuildPhase>(dictionary:  this.copyBuildPhases);
            Append<UnityEditor.XCodeEditor.PBXFileReference>(dictionary:  this.fileReferences);
            Append<UnityEditor.XCodeEditor.PBXFrameworksBuildPhase>(dictionary:  this.frameworkBuildPhases);
            Append<UnityEditor.XCodeEditor.PBXGroup>(dictionary:  this.groups);
            Append<UnityEditor.XCodeEditor.PBXNativeTarget>(dictionary:  this.nativeTargets);
            Add(key:  this._project.guid, value:  this._project.data);
            Append<UnityEditor.XCodeEditor.PBXResourcesBuildPhase>(dictionary:  this.resourcesBuildPhases);
            Append<UnityEditor.XCodeEditor.PBXShellScriptBuildPhase>(dictionary:  this.shellScriptBuildPhases);
            Append<UnityEditor.XCodeEditor.PBXSourcesBuildPhase>(dictionary:  this.sourcesBuildPhases);
            Append<UnityEditor.XCodeEditor.PBXVariantGroup>(dictionary:  this.variantGroups);
            Append<UnityEditor.XCodeEditor.XCBuildConfiguration>(dictionary:  this.buildConfigurations);
            Append<UnityEditor.XCodeEditor.XCConfigurationList>(dictionary:  this.configurationLists);
            this._objects = new UnityEditor.XCodeEditor.PBXDictionary();
        }
        public void Backup()
        {
            string val_1 = System.IO.Path.Combine(path1:  0, path2:  this.<filePath>k__BackingField);
            if((System.IO.File.Exists(path:  0)) != false)
            {
                    System.IO.File.Delete(path:  0);
            }
            
            System.IO.File.Copy(sourceFileName:  0, destFileName:  System.IO.Path.Combine(path1:  0, path2:  this.<filePath>k__BackingField));
        }
        private void DeleteExisting(string path)
        {
            if((System.IO.File.Exists(path:  0)) == false)
            {
                    return;
            }
            
            System.IO.File.Delete(path:  0);
        }
        private void CreateNewProject(UnityEditor.XCodeEditor.PBXDictionary result, string path)
        {
            UnityEditor.XCodeEditor.PBXParser val_1 = new UnityEditor.XCodeEditor.PBXParser();
            string val_3 = Encode(pbxData:  result, readable:  true);
            if((System.IO.File.CreateText(path:  0)) == null)
            {
                
            }
        
        }
        public void Save()
        {
            Add(key:  "archiveVersion", value:  1);
            Add(key:  "classes", value:  new UnityEditor.XCodeEditor.PBXDictionary());
            Add(key:  "objectVersion", value:  46);
            this.Consolidate();
            Add(key:  "objects", value:  this._objects);
            Add(key:  "rootObject", value:  this._rootObjectKey);
            string val_3 = System.IO.Path.Combine(path1:  0, path2:  this.<filePath>k__BackingField);
            val_3.DeleteExisting(path:  val_3);
            val_3.CreateNewProject(result:  new UnityEditor.XCodeEditor.PBXDictionary(), path:  val_3);
        }
        public System.Collections.Generic.Dictionary<string, object> get_objects()
        {
            return 0;
        }
        public void Dispose()
        {
        
        }
    
    }

}
