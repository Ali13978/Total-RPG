using UnityEngine;

namespace UnityEditor.XCodeEditor
{
    public class PBXProject : PBXObject
    {
        // Fields
        protected string MAINGROUP_KEY;
        protected string KNOWN_REGIONS_KEY;
        protected bool _clearedLoc;
        
        // Properties
        public string mainGroupID { get; }
        public UnityEditor.XCodeEditor.PBXList knownRegions { get; }
        
        // Methods
        public PBXProject()
        {
            this.MAINGROUP_KEY = "mainGroup";
            this.KNOWN_REGIONS_KEY = "knownRegions";
        }
        public PBXProject(string guid, UnityEditor.XCodeEditor.PBXDictionary dictionary)
        {
            this.MAINGROUP_KEY = "mainGroup";
            this.KNOWN_REGIONS_KEY = "knownRegions";
        }
        public string get_mainGroupID()
        {
            var val_3;
            if(Item[this.MAINGROUP_KEY] != null)
            {
                    if(null == null)
            {
                    return (string)val_3;
            }
            
            }
            
            val_3 = 0;
            return (string)val_3;
        }
        public UnityEditor.XCodeEditor.PBXList get_knownRegions()
        {
            var val_4;
            object val_1 = Item[this.KNOWN_REGIONS_KEY];
            val_4 = 0;
            return (UnityEditor.XCodeEditor.PBXList)val_4;
        }
        public void AddRegion(string region)
        {
            if(this._clearedLoc != true)
            {
                    this.knownRegions.Clear();
                this._clearedLoc = true;
            }
            
            int val_3 = this.knownRegions.Add(value:  region);
        }
    
    }

}
