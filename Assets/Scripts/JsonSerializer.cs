using UnityEngine;
public class JsonSerializer : MonoBehaviour
{
    // Fields
    private UnityEngine.WWW www;
    
    // Methods
    public JsonSerializer()
    {
    
    }
    public static string Serialize(object data)
    {
        return MiniJSON.Json.Serialize(obj:  0);
    }
    public static object Deserialize(string json)
    {
        var val_9;
        var val_10;
        System.Collections.Generic.Dictionary<TKey, TValue> val_11;
        var val_12;
        val_9 = 0;
        if((SimpleJSON.JSON.Parse(aJSON:  0)) != null)
        {
                val_9 = 0;
        }
        
        val_10 = 0;
        null = SimpleJSON.JSONNode.op_Equality(a:  0, b:  null);
        if(null == true)
        {
                return (object)val_10;
        }
        
        System.Collections.Generic.Dictionary<System.Object, System.Object> val_4 = null;
        val_10 = val_4;
        val_4 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
        Dictionary.Enumerator<TKey, TValue> val_6 = Dict.GetEnumerator();
        label_9:
        if((0 & 1) == 0)
        {
            goto label_7;
        }
        
        UnityEngine.Playables.PlayableHandle val_7 = 0.GetHandle();
        Add(key:  val_7.m_Handle.InitializationCallback, value:  val_7.m_Handle);
        goto label_9;
        label_7:
        val_11 = 0;
        val_12 = 1;
        0.Dispose();
        if((val_12 & 1) != 0)
        {
                return (object)val_10;
        }
        
        if(val_11 == 0)
        {
                return (object)val_10;
        }
        
        return (object)val_10;
    }
    private void Start()
    {
        var val_6;
        var val_13;
        var val_14;
        set_Item(key:  "Dinar", value:  "Khasanov");
        set_Item(key:  "PI", value:  3.141519f);
        set_Item(key:  "LenaIsEnot", value:  true);
        string val_2 = MiniJSON.Json.Serialize(obj:  0);
        Clear();
        object val_3 = JsonSerializer.Deserialize(json:  new System.Collections.Generic.Dictionary<System.String, System.Object>());
        Dictionary.Enumerator<TKey, TValue> val_4 = 0.GetEnumerator();
        label_35:
        if((0 & 1) == 0)
        {
            goto label_50;
        }
        
        UnityEngine.Playables.PlayableHandle val_7 = val_6.GetHandle();
        val_13 = null;
        val_13 = null;
        typeof(System.Object[]).__il2cppRuntimeField_20 = System.String.Empty;
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_7.m_Handle.InitializationCallback;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " = ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = ;
        typeof(System.Object[]).__il2cppRuntimeField_40 = "  Type: ";
        typeof(System.Object[]).__il2cppRuntimeField_48 = val_7.m_Handle.GetType();
        string val_10 = +0;
        UnityEngine.Debug.Log(message:  0);
        goto label_35;
        label_50:
        val_6.Dispose();
        object val_11 = new System.Object();
        if(null != 0)
        {
                typeof(JsonSerializer.testSer).__il2cppRuntimeField_18 = 1107909673;
            typeof(JsonSerializer.testSer).__il2cppRuntimeField_10 = "DInar";
        }
        else
        {
                mem[16] = "DInar";
            mem[24] = 1107909673;
        }
        
        val_14 = null;
        typeof(JsonSerializer.testSer).__il2cppRuntimeField_20 = val_14;
        if(null == 0)
        {
                val_14 = typeof(JsonSerializer.testSer).__il2cppRuntimeField_20;
        }
        
        typeof(System.String[]).__il2cppRuntimeField_20 = "Enot";
        typeof(System.String[]).__il2cppRuntimeField_28 = "Lena";
        string val_12 = MiniJSON.Json.Serialize(obj:  0);
        this.Invoke(methodName:  "timerFunc", time:  1f);
    }
    private void timerFunc()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.GetData(url:  "http://www.plasmaorb.com/"));
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.IEnumerator GetData(string url)
    {
        if(null != 0)
        {
                typeof(JsonSerializer.<GetData>c__Iterator0).__il2cppRuntimeField_10 = url;
        }
        else
        {
                mem[16] = url;
        }
        
        typeof(JsonSerializer.<GetData>c__Iterator0).__il2cppRuntimeField_18 = this;
        return (System.Collections.IEnumerator)new System.Object();
    }
    private void Update()
    {
    
    }

}
