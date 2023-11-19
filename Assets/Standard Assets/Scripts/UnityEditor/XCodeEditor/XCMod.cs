using UnityEngine;

namespace UnityEditor.XCodeEditor
{
    public class XCMod
    {
        // Fields
        private System.Collections.Hashtable _datastore;
        private System.Collections.ArrayList _libs;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private string <name>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private string <path>k__BackingField;
        
        // Properties
        public string name { get; set; }
        public string path { get; set; }
        public string group { get; }
        public System.Collections.ArrayList patches { get; }
        public System.Collections.ArrayList libs { get; }
        public System.Collections.ArrayList frameworks { get; }
        public System.Collections.ArrayList headerpaths { get; }
        public System.Collections.ArrayList files { get; }
        public System.Collections.ArrayList folders { get; }
        public System.Collections.ArrayList excludes { get; }
        public System.Collections.ArrayList compiler_flags { get; }
        public System.Collections.ArrayList linker_flags { get; }
        public System.Collections.ArrayList embed_binaries { get; }
        public System.Collections.Hashtable plist { get; }
        
        // Methods
        public XCMod(string filename)
        {
            this._datastore = new System.Collections.Hashtable();
            System.IO.FileInfo val_2 = new System.IO.FileInfo(fileName:  filename);
            if((0 & 1) == 0)
            {
                    UnityEngine.Debug.LogWarning(message:  0);
            }
            
            this.<name>k__BackingField = System.IO.Path.GetFileNameWithoutExtension(path:  0);
            this.<path>k__BackingField = System.IO.Path.GetDirectoryName(path:  0);
            System.IO.StreamReader val_5 = OpenText();
            UnityEngine.Debug.Log(message:  0);
            object val_6 = XUPorterJSON.MiniJSON.jsonDecode(json:  null);
            if(val_6 == null)
            {
                goto label_13;
            }
            
            this._datastore = val_6;
            if(val_6 == null)
            {
                goto label_16;
            }
            
            return;
            label_13:
            this._datastore = 0;
            label_16:
            UnityEngine.Debug.Log(message:  0);
            UnityEngine.UnityException val_11 = new UnityEngine.UnityException(message:  0 + "Parse error in file " + System.IO.Path.GetFileName(path:  0)(System.IO.Path.GetFileName(path:  0)));
        }
        public string get_name()
        {
            return (string)this.<name>k__BackingField;
        }
        private void set_name(string value)
        {
            this.<name>k__BackingField = value;
        }
        public string get_path()
        {
            return (string)this.<path>k__BackingField;
        }
        private void set_path(string value)
        {
            this.<path>k__BackingField = value;
        }
        public string get_group()
        {
            System.Collections.Hashtable val_2;
            string val_3;
            var val_4;
            if((this._datastore != null) && ((this._datastore & 1) != 0))
            {
                    val_2 = this._datastore;
                val_3 = val_2;
                if(val_3 != null)
            {
                    if(null == null)
            {
                    return val_3;
            }
            
            }
            
                val_3 = 0;
                return val_3;
            }
            
            val_2 = 1152921504608284672;
            val_4 = null;
            val_4 = null;
            val_3 = System.String.Empty;
            return val_3;
        }
        public System.Collections.ArrayList get_patches()
        {
            this._datastore = 0;
            return (System.Collections.ArrayList)this._datastore;
        }
        public System.Collections.ArrayList get_libs()
        {
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            string val_20;
            var val_21;
            var val_23;
            if(this._libs != null)
            {
                    return (System.Collections.ArrayList)this._libs;
            }
            
            val_16 = this._datastore;
            if(val_16 != null)
            {
                
            }
            
            val_16 = 0;
            this._libs = new System.Collections.ArrayList(capacity:  0);
            val_17 = this._datastore;
            if(val_17 != null)
            {
                
            }
            
            val_17 = 0;
            label_34:
            var val_16 = 1179403647;
            if(mem[282584257676929] == 0)
            {
                goto label_17;
            }
            
            var val_13 = mem[282584257676823];
            var val_14 = 0;
            val_13 = val_13 + 8;
            label_19:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_18;
            }
            
            val_14 = val_14 + 1;
            val_13 = val_13 + 16;
            if(val_14 < mem[282584257676929])
            {
                goto label_19;
            }
            
            label_17:
            val_18 = val_17;
            goto label_20;
            label_18:
            var val_15 = val_13;
            val_15 = val_15 + 1;
            val_16 = val_16 + val_15;
            val_18 = val_16 + 272;
            label_20:
            if((0 & 1) == 0)
            {
                goto label_43;
            }
            
            var val_19 = 1179403647;
            if(mem[282584257676929] == 0)
            {
                goto label_23;
            }
            
            var val_17 = mem[282584257676823];
            var val_18 = 0;
            val_17 = val_17 + 8;
            label_25:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_24;
            }
            
            val_18 = val_18 + 1;
            val_17 = val_17 + 16;
            if(val_18 < mem[282584257676929])
            {
                goto label_25;
            }
            
            label_23:
            val_19 = val_17;
            goto label_26;
            label_24:
            val_19 = val_19 + (((mem[282584257676823] + 8)) << 4);
            val_19 = val_19 + 272;
            label_26:
            val_20 = val_17;
            val_21 = null;
            if(val_20 == 0)
            {
                goto label_27;
            }
            
            if(1179403647 == val_21)
            {
                goto label_28;
            }
            
            val_21 = null;
            label_27:
            val_20 = 0;
            label_28:
            string val_11 = 0 + "Adding to Libs: "("Adding to Libs: ");
            UnityEngine.Debug.Log(message:  0);
            UnityEditor.XCodeEditor.XCModFile val_12 = new UnityEditor.XCodeEditor.XCModFile(inputString:  val_20);
            if(this._libs != null)
            {
                goto label_34;
            }
            
            goto label_34;
            label_43:
            if(val_17 == 0)
            {
                goto label_36;
            }
            
            var val_22 = 1179403647;
            if(mem[282584257676929] == 0)
            {
                goto label_37;
            }
            
            var val_20 = mem[282584257676823];
            var val_21 = 0;
            val_20 = val_20 + 8;
            label_39:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_38;
            }
            
            val_21 = val_21 + 1;
            val_20 = val_20 + 16;
            if(val_21 < mem[282584257676929])
            {
                goto label_39;
            }
            
            label_37:
            val_23 = val_17;
            goto label_40;
            label_38:
            val_22 = val_22 + (((mem[282584257676823] + 8)) << 4);
            val_23 = val_22 + 272;
            label_40:
            label_36:
            if(0 == 162)
            {
                    return (System.Collections.ArrayList)this._libs;
            }
            
            if(null == null)
            {
                    return (System.Collections.ArrayList)this._libs;
            }
            
            return (System.Collections.ArrayList)this._libs;
        }
        public System.Collections.ArrayList get_frameworks()
        {
            this._datastore = 0;
            return (System.Collections.ArrayList)this._datastore;
        }
        public System.Collections.ArrayList get_headerpaths()
        {
            this._datastore = 0;
            return (System.Collections.ArrayList)this._datastore;
        }
        public System.Collections.ArrayList get_files()
        {
            this._datastore = 0;
            return (System.Collections.ArrayList)this._datastore;
        }
        public System.Collections.ArrayList get_folders()
        {
            this._datastore = 0;
            return (System.Collections.ArrayList)this._datastore;
        }
        public System.Collections.ArrayList get_excludes()
        {
            this._datastore = 0;
            return (System.Collections.ArrayList)this._datastore;
        }
        public System.Collections.ArrayList get_compiler_flags()
        {
            this._datastore = 0;
            return (System.Collections.ArrayList)this._datastore;
        }
        public System.Collections.ArrayList get_linker_flags()
        {
            this._datastore = 0;
            return (System.Collections.ArrayList)this._datastore;
        }
        public System.Collections.ArrayList get_embed_binaries()
        {
            this._datastore = 0;
            return (System.Collections.ArrayList)this._datastore;
        }
        public System.Collections.Hashtable get_plist()
        {
            this._datastore = 0;
            return (System.Collections.Hashtable)this._datastore;
        }
    
    }

}
