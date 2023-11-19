using UnityEngine;
public class GK_Player
{
    // Fields
    private string _PlayerId;
    private string _DisplayName;
    private string _Alias;
    private UnityEngine.Texture2D _SmallPhoto;
    private UnityEngine.Texture2D _BigPhoto;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private System.Action<GK_UserPhotoLoadResult> OnPlayerPhotoLoaded;
    private static System.Collections.Generic.Dictionary<string, UnityEngine.Texture2D> LocalPhotosCache;
    private static System.Action<GK_UserPhotoLoadResult> <>f__am$cache0;
    
    // Properties
    public string Id { get; }
    public string Alias { get; }
    public string DisplayName { get; }
    public UnityEngine.Texture2D SmallPhoto { get; }
    public UnityEngine.Texture2D BigPhoto { get; }
    private string SmallPhotoCacheKey { get; }
    private string BigPhotoCacheKey { get; }
    
    // Methods
    public GK_Player(string pId, string pName, string pAlias)
    {
        var val_8;
        var val_9;
        val_8 = null;
        val_8 = null;
        if((GK_Player.<>f__am$cache0) == null)
        {
                val_9 = null;
            val_9 = null;
            GK_Player.<>f__am$cache0 = new System.Action<GK_UserPhotoLoadResult>(object:  0, method:  static System.Void GK_Player::<OnPlayerPhotoLoaded>m__0(GK_UserPhotoLoadResult ));
            val_8 = null;
        }
        
        val_8 = null;
        this.OnPlayerPhotoLoaded = GK_Player.<>f__am$cache0;
        this._PlayerId = pId;
        this._DisplayName = pName;
        this._Alias = pAlias;
        this._SmallPhoto = GK_Player.GetLocalCachedPhotoByKey(key:  this.SmallPhotoCacheKey);
        this._BigPhoto = GK_Player.GetLocalCachedPhotoByKey(key:  this.BigPhotoCacheKey);
        IOSNativeSettings val_6 = IOSNativeSettings.Instance;
        if(val_6.AutoLoadUsersBigImages != false)
        {
                this.LoadPhoto(size:  1);
        }
        
        IOSNativeSettings val_7 = IOSNativeSettings.Instance;
        if(val_7.AutoLoadUsersSmallImages == false)
        {
                return;
        }
        
        this.LoadPhoto(size:  0);
    }
    public void add_OnPlayerPhotoLoaded(System.Action<GK_UserPhotoLoadResult> value)
    {
        var val_3;
        do
        {
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnPlayerPhotoLoaded);
            val_3 = 0;
            if(val_1 != null)
        {
                val_3 = val_1;
            if(null != null)
        {
                val_3 = 0;
        }
        
        }
        
        }
        while(1152921510241318136 != this.OnPlayerPhotoLoaded);
    
    }
    public void remove_OnPlayerPhotoLoaded(System.Action<GK_UserPhotoLoadResult> value)
    {
        var val_3;
        do
        {
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnPlayerPhotoLoaded);
            val_3 = 0;
            if(val_1 != null)
        {
                val_3 = val_1;
            if(null != null)
        {
                val_3 = 0;
        }
        
        }
        
        }
        while(1152921510241454712 != this.OnPlayerPhotoLoaded);
    
    }
    public void LoadPhoto(GK_PhotoSize size)
    {
        UnityEngine.Texture2D val_5;
        UnityEngine.Texture2D val_6;
        System.Action<GK_UserPhotoLoadResult> val_7;
        GK_UserPhotoLoadResult val_8;
        var val_9;
        if(size != 0)
        {
                val_5 = this._BigPhoto;
            if(0 == val_5)
        {
                return;
        }
        
            SA.Common.Models.Result val_2 = null;
            val_6 = val_2;
            val_2 = new SA.Common.Models.Result();
            typeof(GK_UserPhotoLoadResult).__il2cppRuntimeField_18 = this._BigPhoto;
            typeof(GK_UserPhotoLoadResult).__il2cppRuntimeField_20 = size;
            val_7 = this.OnPlayerPhotoLoaded;
            val_8 = val_6;
            val_9 = public System.Void System.Action<GK_UserPhotoLoadResult>::Invoke(GK_UserPhotoLoadResult obj);
        }
        else
        {
                if(0 == this._SmallPhoto)
        {
                return;
        }
        
            val_6 = this._SmallPhoto;
            typeof(GK_UserPhotoLoadResult).__il2cppRuntimeField_18 = val_6;
            typeof(GK_UserPhotoLoadResult).__il2cppRuntimeField_20 = 0;
            val_7 = this.OnPlayerPhotoLoaded;
            val_8 = new SA.Common.Models.Result();
            val_9 = public System.Void System.Action<GK_UserPhotoLoadResult>::Invoke(GK_UserPhotoLoadResult obj);
        }
        
        val_7.Invoke(obj:  val_8);
    }
    public void SetPhotoData(GK_PhotoSize size, string base64String)
    {
        string val_8;
        UnityEngine.Texture2D val_9;
        string val_10;
        if(base64String.Length == 0)
        {
                return;
        }
        
        System.Byte[] val_2 = System.Convert.FromBase64String(s:  0);
        UnityEngine.Texture2D val_3 = new UnityEngine.Texture2D(width:  1, height:  1);
        bool val_4 = UnityEngine.ImageConversion.LoadImage(tex:  0, data:  val_3);
        if(size != 0)
        {
                this._BigPhoto = val_3;
            string val_5 = this.BigPhotoCacheKey;
            val_9 = this._BigPhoto;
            val_10 = null;
        }
        else
        {
                this._SmallPhoto = val_3;
            val_9 = this._SmallPhoto;
            val_10 = null;
        }
        
        val_8 = val_10;
        GK_Player.UpdatePhotosCache(key:  val_8, photo:  this.SmallPhotoCacheKey);
        typeof(GK_UserPhotoLoadResult).__il2cppRuntimeField_18 = val_3;
        typeof(GK_UserPhotoLoadResult).__il2cppRuntimeField_20 = size;
        this.OnPlayerPhotoLoaded.Invoke(obj:  new SA.Common.Models.Result());
    }
    public void SetPhotoLoadFailedEventData(GK_PhotoSize size, string errorData)
    {
        typeof(GK_UserPhotoLoadResult).__il2cppRuntimeField_20 = size;
        this.OnPlayerPhotoLoaded.Invoke(obj:  new SA.Common.Models.Result(error:  new SA.Common.Models.Error(errorData:  errorData)));
    }
    public string get_Id()
    {
        return (string)this._PlayerId;
    }
    public string get_Alias()
    {
        return (string)this._Alias;
    }
    public string get_DisplayName()
    {
        return (string)this._DisplayName;
    }
    public UnityEngine.Texture2D get_SmallPhoto()
    {
        return (UnityEngine.Texture2D)this._SmallPhoto;
    }
    public UnityEngine.Texture2D get_BigPhoto()
    {
        return (UnityEngine.Texture2D)this._BigPhoto;
    }
    private string get_SmallPhotoCacheKey()
    {
        string val_1 = 0.ToString();
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        return (string)0 + this._PlayerId;
    }
    private string get_BigPhotoCacheKey()
    {
        string val_1 = 1.ToString();
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        return (string)0 + this._PlayerId;
    }
    public static void UpdatePhotosCache(string key, UnityEngine.Texture2D photo)
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        val_5 = null;
        if((GK_Player.LocalPhotosCache.ContainsKey(key:  photo)) != false)
        {
                val_6 = null;
            GK_Player.LocalPhotosCache.set_Item(key:  photo, value:  X2);
            return;
        }
        
        val_7 = null;
        GK_Player.LocalPhotosCache.Add(key:  photo, value:  X2);
    }
    public static UnityEngine.Texture2D GetLocalCachedPhotoByKey(string key)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        if((GK_Player.LocalPhotosCache.ContainsKey(key:  X1)) != false)
        {
                val_4 = null;
            val_4 = null;
            UnityEngine.Texture2D val_2 = GK_Player.LocalPhotosCache.Item[X1];
            return (UnityEngine.Texture2D)val_5;
        }
        
        val_5 = 0;
        return (UnityEngine.Texture2D)val_5;
    }
    private static GK_Player()
    {
        GK_Player.LocalPhotosCache = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Texture2D>();
    }
    private static void <OnPlayerPhotoLoaded>m__0(GK_UserPhotoLoadResult )
    {
    
    }

}
