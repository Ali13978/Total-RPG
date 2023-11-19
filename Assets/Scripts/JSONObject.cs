using UnityEngine;
public class JSONObject
{
    // Fields
    private const int MAX_DEPTH = 1000;
    private const string INFINITY = "\"INFINITY\"";
    private const string NEGINFINITY = "\"NEGINFINITY\"";
    private const string NaN = "\"NaN\"";
    public static char[] WHITESPACE;
    public JSONObject parent;
    public JSONObject.Type type;
    public System.Collections.Generic.List<JSONObject> list;
    public System.Collections.Generic.List<string> keys;
    public string str;
    public float n;
    public bool b;
    
    // Properties
    public bool isContainer { get; }
    public int Count { get; }
    public float f { get; }
    public static JSONObject nullJO { get; }
    public static JSONObject obj { get; }
    public static JSONObject arr { get; }
    public bool IsNumber { get; }
    public bool IsNull { get; }
    public bool IsString { get; }
    public bool IsBool { get; }
    public bool IsArray { get; }
    public bool IsObject { get; }
    public JSONObject Item { get; set; }
    public JSONObject Item { get; set; }
    
    // Methods
    public JSONObject(JSONObject.Type t)
    {
        this.type = t;
        if(t != 3)
        {
                if(t != 4)
        {
                return;
        }
        
            this.list = new System.Collections.Generic.List<JSONObject>();
            return;
        }
        
        this.list = new System.Collections.Generic.List<JSONObject>();
        this.keys = new System.Collections.Generic.List<System.String>();
    }
    public JSONObject(bool b)
    {
        this.b = b;
        this.type = 5;
    }
    public JSONObject(float f)
    {
        this.n = f;
        this.type = 2;
    }
    public JSONObject(System.Collections.Generic.Dictionary<string, string> dic)
    {
        this.type = 3;
        this.keys = new System.Collections.Generic.List<System.String>();
        this.list = new System.Collections.Generic.List<JSONObject>();
        Dictionary.Enumerator<TKey, TValue> val_3 = dic.GetEnumerator();
        label_6:
        if((0 & 1) == 0)
        {
            goto label_9;
        }
        
        UnityEngine.Playables.PlayableHandle val_4 = 0.GetHandle();
        this.keys.Add(item:  val_4.m_Handle.InitializationCallback);
        object val_6 = new System.Object();
        typeof(JSONObject).__il2cppRuntimeField_18 = 1;
        typeof(JSONObject).__il2cppRuntimeField_30 = val_4.m_Handle;
        this.list.Add(item:  null);
        goto label_6;
        label_9:
        0.Dispose();
        if((0 & 1) != 0)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
    
    }
    public JSONObject(System.Collections.Generic.Dictionary<string, JSONObject> dic)
    {
        this.type = 3;
        this.keys = new System.Collections.Generic.List<System.String>();
        this.list = new System.Collections.Generic.List<JSONObject>();
        Dictionary.Enumerator<TKey, TValue> val_3 = dic.GetEnumerator();
        label_5:
        if((0 & 1) == 0)
        {
            goto label_8;
        }
        
        UnityEngine.Playables.PlayableHandle val_4 = 0.GetHandle();
        this.keys.Add(item:  val_4.m_Handle.InitializationCallback);
        this.list.Add(item:  val_4.m_Handle);
        goto label_5;
        label_8:
        0.Dispose();
        if((0 & 1) != 0)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
    
    }
    public JSONObject(JSONObject.AddJSONConents content)
    {
        content.Invoke(self:  this);
    }
    public JSONObject(JSONObject[] objs)
    {
        this.type = 4;
        this.list = new System.Collections.Generic.List<JSONObject>(collection:  objs);
    }
    public JSONObject()
    {
    
    }
    public JSONObject(string str, bool strict = False)
    {
        bool val_55;
        var val_56;
        Type val_57;
        float val_58;
        var val_59;
        var val_62;
        var val_63;
        var val_64;
        val_55 = strict;
        if(str == null)
        {
            goto label_19;
        }
        
        val_56 = null;
        val_56 = null;
        string val_1 = str.Trim(trimChars:  JSONObject.WHITESPACE);
        if(val_55 != false)
        {
                if((val_1.Chars[0] & 65535) != '[')
        {
                if((val_1.Chars[0] & 65535) != '{')
        {
            goto label_8;
        }
        
        }
        
        }
        
        if(val_1.Length < 1)
        {
            goto label_19;
        }
        
        val_55 = true;
        if((System.String.Compare(strA:  0, strB:  val_1, ignoreCase:  true)) == 0)
        {
            goto label_13;
        }
        
        if((System.String.Compare(strA:  0, strB:  val_1, ignoreCase:  true)) == 0)
        {
            goto label_16;
        }
        
        if((System.String.Compare(strA:  0, strB:  val_1, ignoreCase:  true)) == 0)
        {
            goto label_19;
        }
        
        if((System.String.op_Equality(a:  0, b:  val_1)) == false)
        {
            goto label_22;
        }
        
        val_57 = 2;
        val_58 = 2139095040;
        goto label_32;
        label_19:
        this.type = 0;
        return;
        label_13:
        this.type = 5;
        this.b = val_55;
        return;
        label_16:
        this.type = 5;
        this.b = false;
        return;
        label_8:
        this.type = 0;
        UnityEngine.Debug.LogWarning(message:  0);
        return;
        label_22:
        if((System.String.op_Equality(a:  0, b:  val_1)) == false)
        {
            goto label_31;
        }
        
        val_57 = 2;
        val_58 = -8388608;
        goto label_32;
        label_31:
        if((System.String.op_Equality(a:  0, b:  val_1)) == false)
        {
            goto label_35;
        }
        
        val_57 = 2;
        val_58 = 0f;
        label_32:
        this.type = val_57;
        this.n = val_58;
        return;
        label_35:
        if((val_1.Chars[0] & 65535) != '"')
        {
            goto label_37;
        }
        
        this.type = 1;
        if(val_1 == null)
        {
            goto label_38;
        }
        
        val_59 = val_1.Length;
        goto label_39;
        label_37:
        this.n = System.Convert.ToSingle(value:  0);
        this.type = 2;
        return;
        label_38:
        val_59 = 0.Length;
        label_39:
        this.str = val_1.Substring(startIndex:  1, length:  val_59 - 2);
        return;
        label_104:
        var val_56 = 0;
        goto label_93;
        label_71:
        var val_26 = (null == 3) ? () : ( + 1);
        goto label_93;
        label_65:
        val_62 = null;
        val_62 = null;
        char val_27 = val_1.Chars[null];
        if(((System.Array.IndexOf<System.Char>(array:  0, value:  JSONObject.WHITESPACE)) & 2147483648) != 0)
        {
            goto label_63;
        }
        
        label_93:
         =  + 1;
        if( < val_1.Length)
        {
            goto label_65;
        }
        
        return;
        label_63:
        if((val_1.Chars[null] & 65535) != '"')
        {
            goto label_68;
        }
        
        if((1 & 1) != 0)
        {
            goto label_69;
        }
        
        if(0 != 0)
        {
            goto label_93;
        }
        
        goto label_71;
        label_68:
        if((1 & 1) != 0)
        {
            goto label_93;
        }
        
        goto label_75;
        label_69:
        if((0 == 0) && ((1 & 1) != 0))
        {
                val_63 = 0;
        }
        
        label_75:
        if((val_63 == 0) && ((~val_26) == 3))
        {
                char val_36 = val_1.Chars[null] & 65535;
            val_56 = val_56 | ((val_36 == (':')) ? 1 : 0);
            int val_38 = (val_36 != (':')) ? (val_26) : ( + 1);
        }
        
        if((val_1.Chars[null] & 65535) != '[')
        {
                if((val_1.Chars[null] & 65535) != '{')
        {
            goto label_84;
        }
        
        }
        
        val_63 = val_63 + 1;
        goto label_89;
        label_84:
        if((val_1.Chars[null] & 65535) != ']')
        {
                if((val_1.Chars[null] & 65535) != '}')
        {
            goto label_89;
        }
        
        }
        
        val_63 = val_63 - 1;
        label_89:
        var val_49 = ((val_1.Chars[null] & 65535) != ',') ? 1 : 0;
        if((val_63 & 2147483648) != 0)
        {
            goto label_92;
        }
        
        val_49 = ((val_63 != 0) ? 1 : 0) | val_49;
        if((val_49 & 1) == 0)
        {
            goto label_92;
        }
        
        goto label_93;
        label_92:
        val_64 = null;
        val_64 = null;
        if((val_1.Substring(startIndex:  val_38, length:   - val_38).Trim(trimChars:  JSONObject.WHITESPACE).Length) < 1)
        {
            goto label_104;
        }
        
        JSONObject.WHITESPACE.Add(item:  val_1.Substring(startIndex:  val_26 + 1, length:  (~val_26) +));
        1.Add(item:  null);
        goto label_104;
    }
    public bool get_isContainer()
    {
        Type val_2 = this.type;
        val_2 = val_2 - 3;
        return (bool)(val_2 < 2) ? 1 : 0;
    }
    public int get_Count()
    {
        if(this.list == null)
        {
                return 0;
        }
        
        return this.list.Count;
    }
    public float get_f()
    {
        return (float)this.n;
    }
    public static JSONObject get_nullJO()
    {
        return (JSONObject)new JSONObject(t:  0);
    }
    public static JSONObject get_obj()
    {
        return (JSONObject)new JSONObject(t:  3);
    }
    public static JSONObject get_arr()
    {
        return (JSONObject)new JSONObject(t:  4);
    }
    public static JSONObject StringObject(string val)
    {
        if(null != 0)
        {
                typeof(JSONObject).__il2cppRuntimeField_18 = 1;
        }
        else
        {
                mem[24] = 1;
        }
        
        typeof(JSONObject).__il2cppRuntimeField_30 = X1;
        return (JSONObject)new System.Object();
    }
    public void Absorb(JSONObject obj)
    {
        this.list.AddRange(collection:  obj.list);
        this.keys.AddRange(collection:  obj.keys);
        this.str = obj.str;
        this.n = obj.n;
        this.b = obj.b;
        this.type = obj.type;
    }
    public bool get_IsNumber()
    {
        return (bool)(this.type == 2) ? 1 : 0;
    }
    public bool get_IsNull()
    {
        return (bool)(this.type == 0) ? 1 : 0;
    }
    public bool get_IsString()
    {
        return (bool)(this.type == 1) ? 1 : 0;
    }
    public bool get_IsBool()
    {
        return (bool)(this.type == 5) ? 1 : 0;
    }
    public bool get_IsArray()
    {
        return (bool)(this.type == 4) ? 1 : 0;
    }
    public bool get_IsObject()
    {
        return (bool)(this.type == 3) ? 1 : 0;
    }
    public void Add(bool val)
    {
        typeof(JSONObject).__il2cppRuntimeField_3C = val;
        typeof(JSONObject).__il2cppRuntimeField_18 = 5;
        this.Add(obj:  new System.Object());
    }
    public void Add(float val)
    {
        typeof(JSONObject).__il2cppRuntimeField_38 = val;
        typeof(JSONObject).__il2cppRuntimeField_18 = 2;
        this.Add(obj:  new System.Object());
    }
    public void Add(int val)
    {
        typeof(JSONObject).__il2cppRuntimeField_38 = (float)val;
        typeof(JSONObject).__il2cppRuntimeField_18 = 2;
        this.Add(obj:  new System.Object());
    }
    public void Add(string str)
    {
        this.Add(obj:  JSONObject.StringObject(val:  null));
    }
    public void Add(JSONObject.AddJSONConents content)
    {
        this.Add(obj:  new JSONObject(content:  content));
    }
    public void Add(JSONObject obj)
    {
        System.Collections.Generic.List<JSONObject> val_2;
        System.Collections.Generic.List<JSONObject> val_3;
        System.Collections.Generic.List<JSONObject> val_4;
        if(obj == null)
        {
                return;
        }
        
        if(this.type != 4)
        {
            goto label_4;
        }
        
        val_2 = this.list;
        goto label_5;
        label_4:
        val_3 = this.list;
        this.type = 4;
        if(val_3 != null)
        {
            goto label_7;
        }
        
        System.Collections.Generic.List<JSONObject> val_1 = null;
        val_4 = val_1;
        val_1 = new System.Collections.Generic.List<JSONObject>();
        this.list = val_4;
        label_5:
        if(null == 0)
        {
                val_3 = 0;
        }
        
        label_7:
        val_3.Add(item:  obj);
    }
    public void AddField(string name, bool val)
    {
        typeof(JSONObject).__il2cppRuntimeField_3C = val;
        typeof(JSONObject).__il2cppRuntimeField_18 = 5;
        this.AddField(name:  name, obj:  new System.Object());
    }
    public void AddField(string name, float val)
    {
        typeof(JSONObject).__il2cppRuntimeField_38 = val;
        typeof(JSONObject).__il2cppRuntimeField_18 = 2;
        this.AddField(name:  name, obj:  new System.Object());
    }
    public void AddField(string name, int val)
    {
        typeof(JSONObject).__il2cppRuntimeField_38 = (float)val;
        typeof(JSONObject).__il2cppRuntimeField_18 = 2;
        this.AddField(name:  name, obj:  new System.Object());
    }
    public void AddField(string name, JSONObject.AddJSONConents content)
    {
        this.AddField(name:  name, obj:  new JSONObject(content:  content));
    }
    public void AddField(string name, string val)
    {
        this.AddField(name:  name, obj:  JSONObject.StringObject(val:  null));
    }
    public void AddField(string name, JSONObject obj)
    {
        var val_5;
        string val_6;
        System.Collections.Generic.List<System.String> val_7;
        object val_8;
        var val_9;
        val_6 = name;
        if(obj == null)
        {
                return;
        }
        
        if(this.type != 3)
        {
            goto label_4;
        }
        
        val_7 = this.keys;
        goto label_5;
        label_4:
        val_7 = this;
        this.keys = new System.Collections.Generic.List<System.String>();
        if(this.type != 4)
        {
            goto label_6;
        }
        
        val_5 = 1152921509076290944;
        val_8 = 0;
        goto label_7;
        label_13:
        Add(item:  val_6);
        val_8 = 1;
        label_7:
        if(val_8 >= this.list.Count)
        {
            goto label_14;
        }
        
        val_9 = null;
        val_9 = null;
        string val_3 = 0 + val_8;
        if(null != 0)
        {
            goto label_13;
        }
        
        goto label_13;
        label_6:
        if(this.list == null)
        {
                this.list = new System.Collections.Generic.List<JSONObject>();
        }
        
        label_14:
        val_6 = val_6;
        this.type = 3;
        label_5:
        Add(item:  val_6);
        this.list.Add(item:  obj);
    }
    public void SetField(string name, bool val)
    {
        typeof(JSONObject).__il2cppRuntimeField_3C = val;
        typeof(JSONObject).__il2cppRuntimeField_18 = 5;
        this.SetField(name:  name, obj:  new System.Object());
    }
    public void SetField(string name, float val)
    {
        typeof(JSONObject).__il2cppRuntimeField_38 = val;
        typeof(JSONObject).__il2cppRuntimeField_18 = 2;
        this.SetField(name:  name, obj:  new System.Object());
    }
    public void SetField(string name, int val)
    {
        typeof(JSONObject).__il2cppRuntimeField_38 = (float)val;
        typeof(JSONObject).__il2cppRuntimeField_18 = 2;
        this.SetField(name:  name, obj:  new System.Object());
    }
    public void SetField(string name, JSONObject obj)
    {
        if((this.HasField(name:  name)) != false)
        {
                bool val_3 = this.list.Remove(item:  this.GetField(name:  name));
            bool val_4 = this.keys.Remove(item:  name);
        }
        
        this.AddField(name:  name, obj:  obj);
    }
    public void RemoveField(string name)
    {
        if(((this.keys.IndexOf(item:  name)) & 2147483648) != 0)
        {
                return;
        }
        
        this.list.RemoveAt(index:  this.keys.IndexOf(item:  name));
        bool val_3 = this.keys.Remove(item:  name);
    }
    public void GetField(ref bool field, string name, JSONObject.FieldNotFound fail)
    {
        int val_3;
        if(this.type == 3)
        {
                val_3 = this.keys.IndexOf(item:  name);
            if((val_3 & 2147483648) == 0)
        {
                JSONObject val_2 = this.list.Item[val_3];
            field = val_2.b;
            return;
        }
        
        }
        
        if(fail == null)
        {
                return;
        }
        
        fail.Invoke(name:  name);
    }
    public void GetField(ref float field, string name, JSONObject.FieldNotFound fail)
    {
        int val_3;
        if(this.type == 3)
        {
                val_3 = this.keys.IndexOf(item:  name);
            if((val_3 & 2147483648) == 0)
        {
                JSONObject val_2 = this.list.Item[val_3];
            field = val_2.n;
            return;
        }
        
        }
        
        if(fail == null)
        {
                return;
        }
        
        fail.Invoke(name:  name);
    }
    public void GetField(ref int field, string name, JSONObject.FieldNotFound fail)
    {
        int val_3;
        if(this.type == 3)
        {
                val_3 = this.keys.IndexOf(item:  name);
            if((val_3 & 2147483648) == 0)
        {
                JSONObject val_2 = this.list.Item[val_3];
            field = (int)val_2.n;
            return;
        }
        
        }
        
        if(fail == null)
        {
                return;
        }
        
        fail.Invoke(name:  name);
    }
    public void GetField(ref uint field, string name, JSONObject.FieldNotFound fail)
    {
        int val_3;
        if(this.type == 3)
        {
                val_3 = this.keys.IndexOf(item:  name);
            if((val_3 & 2147483648) == 0)
        {
                JSONObject val_2 = this.list.Item[val_3];
            field = 1152921511118115488;
            return;
        }
        
        }
        
        if(fail == null)
        {
                return;
        }
        
        fail.Invoke(name:  name);
    }
    public void GetField(ref string field, string name, JSONObject.FieldNotFound fail)
    {
        int val_3;
        if(this.type == 3)
        {
                val_3 = this.keys.IndexOf(item:  name);
            if((val_3 & 2147483648) == 0)
        {
                JSONObject val_2 = this.list.Item[val_3];
            field = val_2.str;
            return;
        }
        
        }
        
        if(fail == null)
        {
                return;
        }
        
        fail.Invoke(name:  name);
    }
    public void GetField(string name, JSONObject.GetFieldResponse response, JSONObject.FieldNotFound fail)
    {
        int val_3;
        if((response != null) && (this.type == 3))
        {
                val_3 = this.keys.IndexOf(item:  name);
            if((val_3 & 2147483648) == 0)
        {
                response.Invoke(obj:  this.list.Item[val_3]);
            return;
        }
        
        }
        
        if(fail == null)
        {
                return;
        }
        
        fail.Invoke(name:  name);
    }
    public JSONObject GetField(string name)
    {
        var val_5;
        System.Collections.Generic.List<JSONObject> val_6;
        var val_7;
        val_6 = name;
        if(this.type != 3)
        {
            goto label_4;
        }
        
        val_5 = 0;
        goto label_2;
        label_8:
        val_5 = 1;
        label_2:
        if(val_5 >= this.keys.Count)
        {
            goto label_4;
        }
        
        if((System.String.op_Equality(a:  0, b:  this.keys.Item[1])) == false)
        {
            goto label_8;
        }
        
        val_6 = this.list;
        JSONObject val_4 = val_6.Item[1];
        return (JSONObject)val_7;
        label_4:
        val_7 = 0;
        return (JSONObject)val_7;
    }
    public bool HasFields(string[] names)
    {
        string val_2;
        var val_3;
        var val_4;
        val_3 = 0;
        label_5:
        if(val_3 >= names.Length)
        {
            goto label_2;
        }
        
        val_2 = names[0];
        val_3 = val_3 + 1;
        if((this.keys.Contains(item:  val_2)) == true)
        {
            goto label_5;
        }
        
        val_4 = 0;
        return (bool)val_4;
        label_2:
        val_4 = 1;
        return (bool)val_4;
    }
    public bool HasField(string name)
    {
        var val_5;
        var val_6;
        if(this.type != 3)
        {
            goto label_3;
        }
        
        val_5 = 0;
        label_7:
        if(val_5 >= this.keys.Count)
        {
            goto label_3;
        }
        
        val_5 = val_5 + 1;
        if((System.String.op_Equality(a:  0, b:  this.keys.Item[0])) == false)
        {
            goto label_7;
        }
        
        val_6 = 1;
        return (bool)val_6;
        label_3:
        val_6 = 0;
        return (bool)val_6;
    }
    public void Clear()
    {
        var val_1;
        this.type = 0;
        if(this.list != null)
        {
                this.list.Clear();
        }
        
        if(this.keys != null)
        {
                this.keys.Clear();
        }
        
        val_1 = null;
        val_1 = null;
        this.b = false;
        this.n = 0f;
        this.str = System.String.Empty;
    }
    public JSONObject Copy()
    {
        return (JSONObject)new JSONObject(str:  this.print(depth:  0, pretty:  false), strict:  false);
    }
    public void Merge(JSONObject obj)
    {
        JSONObject.MergeRecur(left:  null, right:  this);
    }
    private static void MergeRecur(JSONObject left, JSONObject right)
    {
        var val_19;
        Type val_20;
        var val_21;
        var val_22;
        var val_23;
        string val_24;
        JSONObject val_25;
        if(right == null)
        {
            goto label_1;
        }
        
        val_19 = right;
        val_20 = right.type;
        if(val_20 != 0)
        {
            goto label_2;
        }
        
        goto label_4;
        label_1:
        val_21 = 7254272;
        if(val_21 == 0)
        {
            goto label_4;
        }
        
        val_22 = 24;
        val_20 = 7254272;
        label_2:
        if((val_20 != 3) || ((X2 + 24) != 3))
        {
            goto label_7;
        }
        
        val_23 = 1152921511114312160;
        val_22 = 0;
        goto label_8;
        label_31:
        val_22 = 1;
        label_8:
        if(val_22 >= (X2 + 32.Count))
        {
                return;
        }
        
        string val_2 = X2 + 40.Item[1];
        JSONObject val_3 = X2.Item[1];
        bool val_5 = right.HasField(name:  val_2);
        if((val_3.type - 3) > 1)
        {
            goto label_16;
        }
        
        if(val_5 == false)
        {
            goto label_17;
        }
        
        JSONObject val_6 = right.GetField(name:  val_2);
        JSONObject val_7 = X2.Item[1];
        goto label_31;
        label_16:
        JSONObject val_8 = X2.Item[1];
        if(val_5 == false)
        {
            goto label_26;
        }
        
        right.SetField(name:  val_2, obj:  val_8);
        goto label_31;
        label_17:
        val_24 = val_2;
        val_25 = X2.Item[1];
        goto label_30;
        label_26:
        val_24 = val_2;
        val_25 = val_8;
        label_30:
        right.AddField(name:  val_24, obj:  val_25);
        goto label_31;
        label_7:
        if(val_22 != 4)
        {
                return;
        }
        
        if((X2 + 24) != 4)
        {
                return;
        }
        
        if(X2.Count <= right.Count)
        {
            goto label_37;
        }
        
        UnityEngine.Debug.LogError(message:  0);
        return;
        label_4:
        right.Absorb(obj:  X2);
        return;
        label_37:
        val_23 = 1152921504895184896;
        val_22 = 0;
        goto label_40;
        label_60:
        val_22 = 1;
        label_40:
        if(val_22 >= (X2 + 32.Count))
        {
                return;
        }
        
        JSONObject val_13 = right.Item[1];
        JSONObject val_14 = X2.Item[1];
        if(val_13.type != val_14.type)
        {
            goto label_60;
        }
        
        JSONObject val_15 = right.Item[1];
        Type val_19 = val_15.type;
        val_19 = val_19 - 3;
        if(val_19 > 1)
        {
            goto label_51;
        }
        
        JSONObject val_16 = right.Item[1];
        JSONObject val_17 = X2.Item[1];
        goto label_60;
        label_51:
        right.set_Item(index:  1, value:  X2.Item[1]);
        goto label_60;
    }
    public string print(bool pretty = False)
    {
        return this.print(depth:  0, pretty:  pretty);
    }
    public string print(int depth, bool pretty = False)
    {
        float val_23;
        var val_58;
        string val_59;
        string val_60;
        var val_61;
        string val_62;
        var val_64;
        var val_67;
        string val_68;
        string val_70;
        string val_71;
        string val_72;
        var val_73;
        var val_74;
        var val_75;
        var val_76;
        var val_77;
        string val_78;
        var val_79;
        var val_80;
        val_59 = pretty;
        val_60 = depth;
        if(val_60 >= 1001)
        {
            goto label_1;
        }
        
        val_61 = null;
        val_61 = null;
        val_62 = System.String.Empty;
        var val_2 = (this.type < 6) ? (this.type + 10) : 0;
        val_2 = val_2 - 10;
        if(val_2 > 5)
        {
                return (string)val_62;
        }
        
        var val_57 = 25814980 + ((this.type < 0x6 ? (this.type + 10) : 0 - 10)) << 2;
        val_58 = val_60 + 1;
        val_57 = val_57 + 25814980;
        goto (25814980 + ((this.type < 0x6 ? (this.type + 10) : 0 - 10)) << 2 + 25814980);
        label_1:
        UnityEngine.Debug.Log(message:  0);
        val_60 = 1152921504608284672;
        val_64 = null;
        val_64 = null;
        return (string)val_62;
        label_39:
        val_67 = 1;
        if(val_67 >= this.list.Count)
        {
            goto label_23;
        }
        
        string val_12 = this.keys.Item[1];
        JSONObject val_13 = this.list.Item[1];
        if(val_13 == null)
        {
            goto label_39;
        }
        
        string val_58 =  + 1;
        if( != true)
        {
                do
        {
            val_68 = 0 + ;
            val_58 = val_58 - 1;
        }
        while(val_58 != 0);
        
        }
        
        bool val_16 = val_59;
        if(val_59 == false)
        {
            goto label_39;
        }
        
        string val_18 = 0 + 0 + 0 + val_68 + "\"" + val_12(0 + val_68 + "\"" + val_12) + val_13(0 + 0 + val_68 + "\"" + val_12(0 + val_68 + "\"" + val_12) + val_13);
        goto label_39;
        label_61:
        label_49:
        if((0 & 1) == 0)
        {
            goto label_46;
        }
        
        val_71 = public JSONObject List.Enumerator<JSONObject>::get_Current();
        System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_26 = val_23.InitializationCallback;
        if(val_26 == null)
        {
            goto label_49;
        }
        
        if(( & 1) != 0)
        {
                val_72 = ;
        }
        else
        {
                var val_59 = 0;
            do
        {
            val_71 = ;
            val_72 = 0 + val_71;
            val_59 = val_59 + 1;
        }
        while(val_59 < );
        
        }
        
        string val_28 = val_12 & 1;
        if((val_12 & 1) == 0)
        {
            goto label_61;
        }
        
        string val_30 = 0 + 0 + val_72 + val_26(0 + val_72 + val_26);
        goto label_61;
        label_23:
        val_59 = val_59;
        if(val_59 == false)
        {
            goto label_65;
        }
        
        if( == null)
        {
            goto label_66;
        }
        
        val_73 = Length;
        goto label_67;
        label_46:
        val_59 = val_12;
        val_74 = 0;
        val_58 = 1;
        val_23.Dispose();
        if((val_59 & 1) == 0)
        {
            goto label_76;
        }
        
        if( == null)
        {
            goto label_77;
        }
        
        val_75 = Length;
        goto label_78;
        label_66:
        val_73 = 0.Length;
        label_67:
        val_76 = Substring(startIndex:  0, length:  val_73 - 1);
        label_65:
        if(val_76 != null)
        {
                val_77 = val_76.Length;
        }
        else
        {
                val_77 = 0.Length;
        }
        
        val_78 = val_76.Substring(startIndex:  0, length:  val_77 - 1);
        if((val_59 != false) && (this.list.Count >= 1))
        {
                val_78 = 0 + val_78;
            if( >= 1)
        {
                do
        {
            val_78 = 0 + val_78;
            val_60 =  - 1;
        }
        while(val_60 != null);
        
        }
        
        }
        
        val_79 = "}";
        goto label_95;
        label_77:
        val_75 = 0.Length;
        label_78:
        val_70 = Substring(startIndex:  0, length:  val_75 - 1);
        label_76:
        if(val_70 != null)
        {
                val_80 = val_70.Length;
        }
        else
        {
                val_80 = 0.Length;
        }
        
        val_78 = val_70.Substring(startIndex:  0, length:  val_80 - 1);
        if(((val_59 & 1) != 0) && (this.list.Count >= 1))
        {
                val_78 = 0 + val_78;
            if( >= 1)
        {
                do
        {
            val_78 = 0 + val_78;
            val_60 =  - 1;
        }
        while(val_60 != null);
        
        }
        
        }
        
        val_79 = "]";
        label_95:
        val_62 = 0 + val_78;
        return (string)val_62;
    }
    public static UnityEngine.WWWForm op_Implicit(JSONObject obj)
    {
        object val_8;
        var val_9;
        var val_10;
        val_8 = 0;
        goto label_1;
        label_21:
        AddField(fieldName:  X22, value:  X23);
        val_8 = 1;
        label_1:
        if(val_8 >= (X1 + 32.Count))
        {
                return (UnityEngine.WWWForm)new UnityEngine.WWWForm();
        }
        
        val_9 = null;
        val_9 = null;
        string val_3 = 0 + val_8;
        if((X1 + 24) == 3)
        {
                string val_4 = X1 + 40.Item[1];
        }
        
        JSONObject val_6 = X1 + 32.Item[1];
        if(val_6.type == 1)
        {
                val_10 = null;
            val_10 = null;
            string val_7 = X1 + 32.Item[1].Replace(oldValue:  "\"", newValue:  System.String.Empty);
        }
        
        if(null != 0)
        {
            goto label_21;
        }
        
        goto label_21;
    }
    public JSONObject get_Item(int index)
    {
        var val_3;
        if(this.list.Count > index)
        {
                JSONObject val_2 = this.list.Item[index];
            return (JSONObject)val_3;
        }
        
        val_3 = 0;
        return (JSONObject)val_3;
    }
    public void set_Item(int index, JSONObject value)
    {
        if(this.list.Count <= index)
        {
                return;
        }
        
        this.list.set_Item(index:  index, value:  value);
    }
    public JSONObject get_Item(string index)
    {
        return this.GetField(name:  index);
    }
    public void set_Item(string index, JSONObject value)
    {
        this.SetField(name:  index, obj:  value);
    }
    public override string ToString()
    {
        return this.print(depth:  0, pretty:  false);
    }
    public string ToString(bool pretty)
    {
        return this.print(depth:  0, pretty:  pretty);
    }
    public System.Collections.Generic.Dictionary<string, string> ToDictionary()
    {
        var val_10;
        var val_11;
        if(this.type != 3)
        {
            goto label_1;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.String> val_1 = null;
        val_10 = val_1;
        val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        val_11 = 0;
        goto label_2;
        label_24:
        val_11 = 1;
        label_2:
        if(val_11 >= this.list.Count)
        {
                return (System.Collections.Generic.Dictionary<System.String, System.String>)val_10;
        }
        
        JSONObject val_3 = this.list.Item[1];
        Type val_10 = val_3.type;
        val_10 = val_10 - 1;
        if(val_10 > 4)
        {
            goto label_7;
        }
        
        if((25815552 + ((val_3.type - 1)) << 2) > 9)
        {
                return (System.Collections.Generic.Dictionary<System.String, System.String>)val_10;
        }
        
        var val_11 = 25815004 + (25815552 + ((val_3.type - 1)) << 2) << 2;
        val_11 = val_11 + 25815004;
        goto (25815004 + (25815552 + ((val_3.type - 1)) << 2) << 2 + 25815004);
        label_7:
        string val_5 = 0 + "Omitting object: "("Omitting object: ") + this.keys.Item[1];
        UnityEngine.Debug.LogWarning(message:  0);
        goto label_24;
        label_1:
        UnityEngine.Debug.LogWarning(message:  0);
        val_10 = 0;
        return (System.Collections.Generic.Dictionary<System.String, System.String>)val_10;
    }
    public static bool op_Implicit(JSONObject o)
    {
        return (bool)(X1 != 0) ? 1 : 0;
    }
    private static JSONObject()
    {
        JSONObject.WHITESPACE = null;
    }

}
