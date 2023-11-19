using UnityEngine;

namespace UnityEditor.XCodeEditor
{
    public class PBXCopyFilesBuildPhase : PBXBuildPhase
    {
        // Methods
        public PBXCopyFilesBuildPhase(int buildActionMask)
        {
            var val_2;
            this = new UnityEditor.XCodeEditor.PBXObject();
            this.Add(key:  "buildActionMask", obj:  buildActionMask);
            val_2 = null;
            val_2 = null;
            this.Add(key:  "dstPath", obj:  System.String.Empty);
            this.Add(key:  "dstSubfolderSpec", obj:  10);
            this.Add(key:  "name", obj:  "Embed Frameworks");
            this.Add(key:  "runOnlyForDeploymentPostprocessing", obj:  0);
        }
        public PBXCopyFilesBuildPhase(string guid, UnityEditor.XCodeEditor.PBXDictionary dictionary)
        {
            val_1 = new UnityEditor.XCodeEditor.PBXObject(guid:  guid, dictionary:  dictionary);
        }
    
    }

}
