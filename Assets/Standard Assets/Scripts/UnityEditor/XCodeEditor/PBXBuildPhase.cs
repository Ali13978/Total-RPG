using UnityEngine;

namespace UnityEditor.XCodeEditor
{
    public class PBXBuildPhase : PBXObject
    {
        // Fields
        protected const string FILES_KEY = "files";
        
        // Properties
        public UnityEditor.XCodeEditor.PBXList files { get; }
        
        // Methods
        public PBXBuildPhase()
        {
        
        }
        public PBXBuildPhase(string guid, UnityEditor.XCodeEditor.PBXDictionary dictionary)
        {
        
        }
        public bool AddBuildFile(UnityEditor.XCodeEditor.PBXBuildFile file)
        {
            if((this.ContainsKey(key:  "files")) != true)
            {
                    this.Add(key:  "files", obj:  new UnityEditor.XCodeEditor.PBXList());
            }
            
            string val_5 = file.guid;
            if(this.Item["files"] == null)
            {
                    return true;
            }
            
            return true;
            label_9:
            goto label_9;
        }
        public void RemoveBuildFile(string id)
        {
            if((this.ContainsKey(key:  "files")) != false)
            {
                    if(this.Item["files"] == null)
            {
                    return;
            }
            
                return;
            }
            
            this.Add(key:  "files", obj:  new UnityEditor.XCodeEditor.PBXList());
            return;
            label_8:
            goto label_8;
        }
        public bool HasBuildFile(string id)
        {
            object val_10;
            var val_11;
            var val_12;
            val_10 = id;
            val_11 = "files";
            bool val_1 = this.ContainsKey(key:  "files");
            if(val_1 == false)
            {
                goto label_1;
            }
            
            if((UnityEditor.XCodeEditor.PBXObject.IsGuid(aString:  val_1)) == false)
            {
                goto label_2;
            }
            
            object val_4 = this.Item["files"];
            val_11 = 1152921504839434240;
            if(val_4 != null)
            {
                
            }
            
            val_12 = val_4;
            goto label_9;
            label_1:
            UnityEditor.XCodeEditor.PBXList val_8 = null;
            val_10 = val_8;
            val_8 = new UnityEditor.XCodeEditor.PBXList();
            this.Add(key:  "files", obj:  val_10);
            label_2:
            val_12 = 0;
            label_9:
            val_12 = val_12 & 1;
            return (bool)val_12;
            label_10:
            goto label_10;
        }
        public UnityEditor.XCodeEditor.PBXList get_files()
        {
            var val_7;
            if((this.ContainsKey(key:  "files")) != true)
            {
                    this.Add(key:  "files", obj:  new UnityEditor.XCodeEditor.PBXList());
            }
            
            object val_4 = this.Item["files"];
            val_7 = 0;
            return (UnityEditor.XCodeEditor.PBXList)val_7;
        }
    
    }

}
