using UnityEngine;
private sealed class ISD_FrameworkHandler.<GetImportedFrameworks>c__AnonStorey0
{
    // Fields
    internal string[] dirrExtensions;
    
    // Methods
    public ISD_FrameworkHandler.<GetImportedFrameworks>c__AnonStorey0()
    {
    
    }
    internal bool <>m__0(System.IO.FileInfo f)
    {
        string val_2 = f.Extension.ToLower();
        return System.Linq.Enumerable.Contains<System.String>(source:  0, value:  this.dirrExtensions);
    }
    internal bool <>m__1(System.IO.DirectoryInfo f)
    {
        string val_2 = f.Extension.ToLower();
        return System.Linq.Enumerable.Contains<System.String>(source:  0, value:  this.dirrExtensions);
    }

}
