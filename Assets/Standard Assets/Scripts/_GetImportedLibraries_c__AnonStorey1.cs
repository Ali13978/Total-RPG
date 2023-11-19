using UnityEngine;
private sealed class ISD_FrameworkHandler.<GetImportedLibraries>c__AnonStorey1
{
    // Fields
    internal string[] fileExtensions;
    
    // Methods
    public ISD_FrameworkHandler.<GetImportedLibraries>c__AnonStorey1()
    {
    
    }
    internal bool <>m__0(System.IO.FileInfo f)
    {
        string val_2 = f.Extension.ToLower();
        return System.Linq.Enumerable.Contains<System.String>(source:  0, value:  this.fileExtensions);
    }

}
