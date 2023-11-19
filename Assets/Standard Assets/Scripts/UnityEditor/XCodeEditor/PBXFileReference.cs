using UnityEngine;

namespace UnityEditor.XCodeEditor
{
    public class PBXFileReference : PBXObject
    {
        // Fields
        protected const string PATH_KEY = "path";
        protected const string NAME_KEY = "name";
        protected const string SOURCETREE_KEY = "sourceTree";
        protected const string EXPLICIT_FILE_TYPE_KEY = "explicitFileType";
        protected const string LASTKNOWN_FILE_TYPE_KEY = "lastKnownFileType";
        protected const string ENCODING_KEY = "fileEncoding";
        public string compilerFlags;
        public string buildPhase;
        public readonly System.Collections.Generic.Dictionary<UnityEditor.XCodeEditor.TreeEnum, string> trees;
        public static readonly System.Collections.Generic.Dictionary<string, string> typeNames;
        public static readonly System.Collections.Generic.Dictionary<string, string> typePhases;
        
        // Properties
        public string name { get; }
        public string path { get; }
        
        // Methods
        public PBXFileReference(string guid, UnityEditor.XCodeEditor.PBXDictionary dictionary)
        {
            var val_2;
            if(null != 0)
            {
                    val_2 = 1152921510138427568;
                Add(key:  0, value:  "<absolute>");
                Add(key:  1, value:  "<group>");
                Add(key:  2, value:  "BUILT_PRODUCTS_DIR");
                Add(key:  3, value:  "DEVELOPER_DIR");
                Add(key:  4, value:  "SDKROOT");
            }
            else
            {
                    val_2 = 1152921510138427568;
                Add(key:  0, value:  "<absolute>");
                Add(key:  1, value:  "<group>");
                Add(key:  2, value:  "BUILT_PRODUCTS_DIR");
                Add(key:  3, value:  "DEVELOPER_DIR");
                Add(key:  4, value:  "SDKROOT");
            }
            
            Add(key:  5, value:  "SOURCE_ROOT");
            this.trees = new System.Collections.Generic.Dictionary<UnityEditor.XCodeEditor.TreeEnum, System.String>();
        }
        public PBXFileReference(string filePath, UnityEditor.XCodeEditor.TreeEnum tree = 5)
        {
            UnityEditor.XCodeEditor.TreeEnum val_5;
            if(null != 0)
            {
                    Add(key:  0, value:  "<absolute>");
                Add(key:  1, value:  "<group>");
                Add(key:  2, value:  "BUILT_PRODUCTS_DIR");
                Add(key:  3, value:  "DEVELOPER_DIR");
                Add(key:  4, value:  "SDKROOT");
            }
            else
            {
                    Add(key:  0, value:  "<absolute>");
                Add(key:  1, value:  "<group>");
                Add(key:  2, value:  "BUILT_PRODUCTS_DIR");
                Add(key:  3, value:  "DEVELOPER_DIR");
                Add(key:  4, value:  "SDKROOT");
            }
            
            Add(key:  5, value:  "SOURCE_ROOT");
            this.trees = new System.Collections.Generic.Dictionary<UnityEditor.XCodeEditor.TreeEnum, System.String>();
            this.Add(key:  "path", obj:  filePath);
            this.Add(key:  "name", obj:  System.IO.Path.GetFileName(path:  0));
            if((System.IO.Path.IsPathRooted(path:  0)) != false)
            {
                    val_5 = 0;
            }
            else
            {
                    val_5 = tree;
            }
            
            this.Add(key:  "sourceTree", obj:  this.trees.Item[val_5]);
            this.GuessFileType();
        }
        public string get_name()
        {
            var val_4;
            var val_5;
            val_4 = this;
            if((this.ContainsKey(key:  "name")) != false)
            {
                    if(this.Item["name"] != null)
            {
                    if(null == null)
            {
                    return (string)val_5;
            }
            
            }
            
            }
            
            val_5 = 0;
            return (string)val_5;
        }
        public string get_path()
        {
            var val_4;
            var val_5;
            val_4 = this;
            if((this.ContainsKey(key:  "path")) != false)
            {
                    if(this.Item["path"] != null)
            {
                    if(null == null)
            {
                    return (string)val_5;
            }
            
            }
            
            }
            
            val_5 = 0;
            return (string)val_5;
        }
        private void GuessFileType()
        {
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            System.Collections.Generic.Dictionary<System.String, System.String> val_15;
            var val_16;
            val_11 = this;
            bool val_1 = this.Remove(key:  "explicitFileType");
            bool val_2 = this.Remove(key:  "lastKnownFileType");
            val_12 = Item["path"];
            val_13 = 1152921504608284672;
            if(val_12 != null)
            {
                    if(null == null)
            {
                goto label_5;
            }
            
            }
            
            val_12 = 0;
            label_5:
            string val_5 = System.IO.Path.GetExtension(path:  0);
            val_14 = null;
            val_14 = null;
            val_15 = UnityEditor.XCodeEditor.PBXFileReference.typeNames;
            if((val_15.ContainsKey(key:  val_5)) != false)
            {
                    val_16 = null;
                val_16 = null;
                val_13 = 1152921509101878496;
                this.Add(key:  "lastKnownFileType", obj:  UnityEditor.XCodeEditor.PBXFileReference.typeNames.Item[val_5]);
                val_15 = UnityEditor.XCodeEditor.PBXFileReference.typePhases;
                this.buildPhase = val_15.Item[val_5];
                return;
            }
            
            val_11 = 0 + "Unknown file extension: "("Unknown file extension: ") + val_5;
            UnityEngine.Debug.LogWarning(message:  0);
        }
        private void SetFileType(string fileType)
        {
            bool val_1 = this.Remove(key:  "explicitFileType");
            bool val_2 = this.Remove(key:  "lastKnownFileType");
            this.Add(key:  "explicitFileType", obj:  fileType);
        }
        private static PBXFileReference()
        {
            if(null != 0)
            {
                    Add(key:  ".a", value:  "archive.ar");
            }
            else
            {
                    Add(key:  ".a", value:  "archive.ar");
            }
            
            Add(key:  ".app", value:  "wrapper.application");
            if(null != 0)
            {
                    Add(key:  ".s", value:  "sourcecode.asm");
            }
            else
            {
                    Add(key:  ".s", value:  "sourcecode.asm");
            }
            
            Add(key:  ".c", value:  "sourcecode.c.c");
            if(null != 0)
            {
                    Add(key:  ".cpp", value:  "sourcecode.cpp.cpp");
            }
            else
            {
                    Add(key:  ".cpp", value:  "sourcecode.cpp.cpp");
            }
            
            Add(key:  ".framework", value:  "wrapper.framework");
            if(null != 0)
            {
                    Add(key:  ".h", value:  "sourcecode.c.h");
            }
            else
            {
                    Add(key:  ".h", value:  "sourcecode.c.h");
            }
            
            Add(key:  ".pch", value:  "sourcecode.c.h");
            if(null != 0)
            {
                    Add(key:  ".icns", value:  "image.icns");
            }
            else
            {
                    Add(key:  ".icns", value:  "image.icns");
            }
            
            Add(key:  ".m", value:  "sourcecode.c.objc");
            if(null != 0)
            {
                    Add(key:  ".mm", value:  "sourcecode.cpp.objcpp");
            }
            else
            {
                    Add(key:  ".mm", value:  "sourcecode.cpp.objcpp");
            }
            
            Add(key:  ".nib", value:  "wrapper.nib");
            if(null != 0)
            {
                    Add(key:  ".plist", value:  "text.plist.xml");
            }
            else
            {
                    Add(key:  ".plist", value:  "text.plist.xml");
            }
            
            Add(key:  ".png", value:  "image.png");
            if(null != 0)
            {
                    Add(key:  ".rtf", value:  "text.rtf");
            }
            else
            {
                    Add(key:  ".rtf", value:  "text.rtf");
            }
            
            Add(key:  ".tiff", value:  "image.tiff");
            if(null != 0)
            {
                    Add(key:  ".txt", value:  "text");
            }
            else
            {
                    Add(key:  ".txt", value:  "text");
            }
            
            Add(key:  ".xcodeproj", value:  "wrapper.pb-project");
            if(null != 0)
            {
                    Add(key:  ".xib", value:  "file.xib");
            }
            else
            {
                    Add(key:  ".xib", value:  "file.xib");
            }
            
            Add(key:  ".strings", value:  "text.plist.strings");
            if(null != 0)
            {
                    Add(key:  ".bundle", value:  "wrapper.plug-in");
            }
            else
            {
                    Add(key:  ".bundle", value:  "wrapper.plug-in");
            }
            
            Add(key:  ".dylib", value:  "compiled.mach-o.dylib");
            if(null != 0)
            {
                    Add(key:  ".tbd", value:  "sourcecode.text-based-dylib-definition");
            }
            else
            {
                    Add(key:  ".tbd", value:  "sourcecode.text-based-dylib-definition");
            }
            
            Add(key:  ".json", value:  "text.json");
            UnityEditor.XCodeEditor.PBXFileReference.typeNames = new System.Collections.Generic.Dictionary<System.String, System.String>();
            if(null != 0)
            {
                    Add(key:  ".a", value:  "PBXFrameworksBuildPhase");
                Add(key:  ".app", value:  0);
            }
            else
            {
                    Add(key:  ".a", value:  "PBXFrameworksBuildPhase");
                Add(key:  ".app", value:  0);
            }
            
            Add(key:  ".s", value:  "PBXSourcesBuildPhase");
            if(null != 0)
            {
                    Add(key:  ".c", value:  "PBXSourcesBuildPhase");
            }
            else
            {
                    Add(key:  ".c", value:  "PBXSourcesBuildPhase");
            }
            
            Add(key:  ".cpp", value:  "PBXSourcesBuildPhase");
            if(null != 0)
            {
                    Add(key:  ".framework", value:  "PBXFrameworksBuildPhase");
                Add(key:  ".h", value:  0);
                Add(key:  ".pch", value:  0);
            }
            else
            {
                    Add(key:  ".framework", value:  "PBXFrameworksBuildPhase");
                Add(key:  ".h", value:  0);
                Add(key:  ".pch", value:  0);
            }
            
            Add(key:  ".icns", value:  "PBXResourcesBuildPhase");
            if(null != 0)
            {
                    Add(key:  ".m", value:  "PBXSourcesBuildPhase");
            }
            else
            {
                    Add(key:  ".m", value:  "PBXSourcesBuildPhase");
            }
            
            Add(key:  ".mm", value:  "PBXSourcesBuildPhase");
            if(null != 0)
            {
                    Add(key:  ".nib", value:  "PBXResourcesBuildPhase");
            }
            else
            {
                    Add(key:  ".nib", value:  "PBXResourcesBuildPhase");
            }
            
            Add(key:  ".plist", value:  "PBXResourcesBuildPhase");
            if(null != 0)
            {
                    Add(key:  ".png", value:  "PBXResourcesBuildPhase");
            }
            else
            {
                    Add(key:  ".png", value:  "PBXResourcesBuildPhase");
            }
            
            Add(key:  ".rtf", value:  "PBXResourcesBuildPhase");
            if(null != 0)
            {
                    Add(key:  ".tiff", value:  "PBXResourcesBuildPhase");
            }
            else
            {
                    Add(key:  ".tiff", value:  "PBXResourcesBuildPhase");
            }
            
            Add(key:  ".txt", value:  "PBXResourcesBuildPhase");
            if(null != 0)
            {
                    Add(key:  ".json", value:  "PBXResourcesBuildPhase");
                Add(key:  ".xcodeproj", value:  0);
            }
            else
            {
                    Add(key:  ".json", value:  "PBXResourcesBuildPhase");
                Add(key:  ".xcodeproj", value:  0);
            }
            
            Add(key:  ".xib", value:  "PBXResourcesBuildPhase");
            if(null != 0)
            {
                    Add(key:  ".strings", value:  "PBXResourcesBuildPhase");
            }
            else
            {
                    Add(key:  ".strings", value:  "PBXResourcesBuildPhase");
            }
            
            Add(key:  ".bundle", value:  "PBXResourcesBuildPhase");
            if(null != 0)
            {
                    Add(key:  ".dylib", value:  "PBXFrameworksBuildPhase");
            }
            else
            {
                    Add(key:  ".dylib", value:  "PBXFrameworksBuildPhase");
            }
            
            Add(key:  ".tbd", value:  "PBXFrameworksBuildPhase");
            UnityEditor.XCodeEditor.PBXFileReference.typePhases = new System.Collections.Generic.Dictionary<System.String, System.String>();
        }
    
    }

}
