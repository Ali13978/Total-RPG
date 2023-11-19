using UnityEngine;
public class IOSImagePickResult : Result
{
    // Fields
    private UnityEngine.Texture2D _image;
    
    // Properties
    public UnityEngine.Texture2D Image { get; }
    
    // Methods
    public IOSImagePickResult(string ImageData)
    {
        UnityEngine.Texture2D val_10;
        int val_11;
        var val_12;
        var val_13;
        val_11 = this;
        if(ImageData.Length != 0)
        {
                System.Byte[] val_2 = System.Convert.FromBase64String(s:  0);
            UnityEngine.Texture2D val_3 = null;
            val_10 = val_3;
            val_3 = new UnityEngine.Texture2D(width:  1, height:  1);
            this._image = val_10;
            bool val_4 = UnityEngine.ImageConversion.LoadImage(tex:  0, data:  val_10);
            this._image.hideFlags = 52;
            IOSNativeSettings val_5 = IOSNativeSettings.Instance;
            if(val_5.DisablePluginLogs == true)
        {
                return;
        }
        
            val_12 = 4;
            val_12 = mem[null + 48];
            if(("IOSImagePickResult: w") == null)
        {
                val_12 = 0;
        }
        
            val_12 = 0;
            typeof(System.Object[]).__il2cppRuntimeField_20 = "IOSImagePickResult: w";
            int val_6 = this._image.width;
            if(val_6 != 0)
        {
                val_13 = mem[null + 48];
            if(val_6 == 0)
        {
                val_13 = 0;
        }
        
        }
        
            val_13 = 0;
            typeof(System.Object[]).__il2cppRuntimeField_28 = val_6;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            val_13 = mem[null + 48];
            if((" h: ") == null)
        {
                val_13 = 0;
        }
        
            val_10 = " h: ";
            val_13 = 0;
            typeof(System.Object[]).__il2cppRuntimeField_30 = val_10;
            val_11 = this._image.height;
            typeof(System.Object[]).__il2cppRuntimeField_38 = val_11;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            string val_8 = +0;
            ISN_Logger.Log(message:  val_8, logType:  val_8);
            return;
        }
        
        mem[1152921510277788176] = new SA.Common.Models.Error(code:  0, message:  "No Image Data");
    }
    public UnityEngine.Texture2D get_Image()
    {
        return (UnityEngine.Texture2D)this._image;
    }

}
