using UnityEngine;
public class MP_MediaPickerResult : Result
{
    // Fields
    private System.Collections.Generic.List<MP_MediaItem> _SelectedmediaItems;
    
    // Properties
    public System.Collections.Generic.List<MP_MediaItem> SelectedmediaItems { get; }
    public System.Collections.Generic.List<MP_MediaItem> Items { get; }
    
    // Methods
    public MP_MediaPickerResult(System.Collections.Generic.List<MP_MediaItem> selectedItems)
    {
        this._SelectedmediaItems = selectedItems;
    }
    public MP_MediaPickerResult(string errorData)
    {
        SA.Common.Models.Error val_1 = new SA.Common.Models.Error(errorData:  errorData);
    }
    public System.Collections.Generic.List<MP_MediaItem> get_SelectedmediaItems()
    {
        return (System.Collections.Generic.List<MP_MediaItem>)this._SelectedmediaItems;
    }
    public System.Collections.Generic.List<MP_MediaItem> get_Items()
    {
        return (System.Collections.Generic.List<MP_MediaItem>)this._SelectedmediaItems;
    }

}
