using UnityEngine;
public class GK_UserPhotoLoadResult : Result
{
    // Fields
    private UnityEngine.Texture2D _Photo;
    private GK_PhotoSize _Size;
    
    // Properties
    public UnityEngine.Texture2D Photo { get; }
    public GK_PhotoSize Size { get; }
    
    // Methods
    public GK_UserPhotoLoadResult(GK_PhotoSize size, UnityEngine.Texture2D photo)
    {
        this._Photo = photo;
        this._Size = size;
    }
    public GK_UserPhotoLoadResult(GK_PhotoSize size, SA.Common.Models.Error error)
    {
        this._Size = size;
    }
    public UnityEngine.Texture2D get_Photo()
    {
        return (UnityEngine.Texture2D)this._Photo;
    }
    public GK_PhotoSize get_Size()
    {
        return (GK_PhotoSize)this._Size;
    }

}
