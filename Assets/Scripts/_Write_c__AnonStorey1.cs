using UnityEngine;
private sealed class NativeIOSCloudSaveProvider.<Write>c__AnonStorey1
{
    // Fields
    internal string serializedMetadata;
    internal TzarGames.Endless.CloudSaveSystem.NativeIOSCloudSaveProvider.<Write>c__AnonStorey0 <>f__ref$0;
    
    // Methods
    public NativeIOSCloudSaveProvider.<Write>c__AnonStorey1()
    {
    
    }
    internal void <>m__0(iCloudData cloudData)
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_7;
        if(cloudData.IsEmpty != false)
        {
                System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = null;
            val_7 = val_3;
            val_3 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        }
        else
        {
                val_7 = cloudData.DictionaryValue;
        }
        
        if((val_7.ContainsKey(key:  this.<>f__ref$0.file)) != false)
        {
                val_7.set_Item(key:  this.<>f__ref$0.file, value:  this.serializedMetadata);
        }
        else
        {
                val_7.Add(key:  this.<>f__ref$0.file, value:  this.serializedMetadata);
        }
        
        SA.Common.Pattern.Singleton<SA_EditorAd>.Instance.SetStringDictionary(key:  "IOSNATIVE_METADATA", val:  val_7);
    }

}
