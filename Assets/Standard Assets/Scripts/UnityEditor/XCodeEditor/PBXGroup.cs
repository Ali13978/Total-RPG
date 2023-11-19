using UnityEngine;

namespace UnityEditor.XCodeEditor
{
    public class PBXGroup : PBXObject
    {
        // Fields
        protected const string NAME_KEY = "name";
        protected const string CHILDREN_KEY = "children";
        protected const string PATH_KEY = "path";
        protected const string SOURCETREE_KEY = "sourceTree";
        
        // Properties
        public UnityEditor.XCodeEditor.PBXList children { get; }
        public string name { get; }
        public string path { get; }
        public string sourceTree { get; }
        
        // Methods
        public PBXGroup(string name, string path, string tree = "SOURCE_ROOT")
        {
            object val_2;
            string val_3;
            this.Add(key:  "children", obj:  new UnityEditor.XCodeEditor.PBXList());
            this.Add(key:  "name", obj:  name);
            if(path != null)
            {
                    this.Add(key:  "path", obj:  path);
                val_2 = tree;
                val_3 = "sourceTree";
            }
            else
            {
                    val_3 = "sourceTree";
                val_2 = "<group>";
            }
            
            this.Add(key:  val_3, obj:  val_2);
        }
        public PBXGroup(string guid, UnityEditor.XCodeEditor.PBXDictionary dictionary)
        {
        
        }
        public UnityEditor.XCodeEditor.PBXList get_children()
        {
            var val_7;
            if((this.ContainsKey(key:  "children")) != true)
            {
                    this.Add(key:  "children", obj:  new UnityEditor.XCodeEditor.PBXList());
            }
            
            object val_4 = this.Item["children"];
            val_7 = 0;
            return (UnityEditor.XCodeEditor.PBXList)val_7;
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
        public string get_sourceTree()
        {
            var val_3;
            if(this.Item["sourceTree"] != null)
            {
                    if(null == null)
            {
                    return (string)val_3;
            }
            
            }
            
            val_3 = 0;
            return (string)val_3;
        }
        public string AddChild(UnityEditor.XCodeEditor.PBXObject child)
        {
            if(child == null)
            {
                    return 0;
            }
            
            return 0;
        }
        public void RemoveChild(string id)
        {
            if((UnityEditor.XCodeEditor.PBXObject.IsGuid(aString:  this)) == false)
            {
                    return;
            }
            
            this.children.Remove(obj:  id);
        }
        public bool HasChild(string id)
        {
            object val_10;
            var val_11;
            var val_12;
            val_10 = id;
            val_11 = "children";
            bool val_1 = this.ContainsKey(key:  "children");
            if(val_1 == false)
            {
                goto label_1;
            }
            
            if((UnityEditor.XCodeEditor.PBXObject.IsGuid(aString:  val_1)) == false)
            {
                goto label_2;
            }
            
            object val_4 = this.Item["children"];
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
            this.Add(key:  "children", obj:  val_10);
            label_2:
            val_12 = 0;
            label_9:
            val_12 = val_12 & 1;
            return (bool)val_12;
            label_10:
            goto label_10;
        }
        public string GetName()
        {
            var val_3;
            if(this.Item["name"] != null)
            {
                    if(null == null)
            {
                    return (string)val_3;
            }
            
            }
            
            val_3 = 0;
            return (string)val_3;
        }
    
    }

}
