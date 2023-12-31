using UnityEngine;
private sealed class MiniJSON.Parser : IDisposable
{
    // Fields
    private const string WORD_BREAK = "{}[],:\"";
    private System.IO.StringReader json;
    
    // Properties
    private char PeekChar { get; }
    private char NextChar { get; }
    private string NextWord { get; }
    private Unitycoding.MiniJSON.Parser.TOKEN NextToken { get; }
    
    // Methods
    private MiniJSON.Parser(string jsonString)
    {
        this.json = new System.IO.StringReader(s:  jsonString);
    }
    public static bool IsWordBreak(char c)
    {
        var val_5;
        var val_6;
        if((System.Char.IsWhiteSpace(c:  ' ')) != false)
        {
                val_5 = 1;
            return (bool)((IndexOf(value:  W1)) != 1) ? 1 : 0;
        }
        
        val_6 = "{}[],:\"";
        if(("{}[],:\"") != null)
        {
                return (bool)((IndexOf(value:  W1)) != 1) ? 1 : 0;
        }
        
        val_6 = "{}[],:\"";
        return (bool)((IndexOf(value:  W1)) != 1) ? 1 : 0;
    }
    public static object Parse(string jsonString)
    {
        var val_4;
        if(null == 0)
        {
            goto label_2;
        }
        
        MiniJSON.Parser val_6 = null;
        if((mem[null + 258]) == 0)
        {
            goto label_3;
        }
        
        var val_4 = mem[null + 152];
        var val_5 = 0;
        val_4 = val_4 + 8;
        label_5:
        if(((mem[null + 152] + 8) + -8) == null)
        {
            goto label_4;
        }
        
        val_5 = val_5 + 1;
        val_4 = val_4 + 16;
        if(val_5 < (mem[null + 258]))
        {
            goto label_5;
        }
        
        label_3:
        val_4 = new MiniJSON.Parser(jsonString:  X1);
        goto label_6;
        label_4:
        val_6 = val_6 + (((mem[null + 152] + 8)) << 4);
        label_6:
        label_2:
        if(32 == 32)
        {
                return (object)ParseByToken(token:  NextToken);
        }
        
        if(0 == 0)
        {
                return (object)ParseByToken(token:  NextToken);
        }
        
        return (object)ParseByToken(token:  NextToken);
    }
    public void Dispose()
    {
        this.json.Dispose();
        this.json = 0;
    }
    private System.Collections.Generic.Dictionary<string, object> ParseObject()
    {
        var val_9;
        System.IO.StringReader val_10;
        string val_11;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = null;
        val_9 = val_1;
        val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_10 = this.json;
        if(val_10 != null)
        {
            goto label_5;
        }
        
        goto label_5;
        label_10:
        val_11 = val_10;
        set_Item(key:  val_11, value:  X22);
        do
        {
            label_5:
            TOKEN val_2 = this.NextToken;
            var val_4 = (val_2 < 3) ? (val_2 + 4) : 0;
            if(val_4 != 0)
        {
                if(val_4 != 5)
        {
            goto label_4;
        }
        
        }
        
        }
        while(val_2 == 6);
        
        val_10 = this.ParseString();
        if((val_10 == null) || (this.NextToken != 5))
        {
            goto label_7;
        }
        
        object val_8 = this.ParseByToken(token:  this.NextToken);
        if(null != 0)
        {
            goto label_10;
        }
        
        goto label_10;
        label_4:
        if(val_4 == 6)
        {
                return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_9;
        }
        
        label_7:
        val_9 = 0;
        return (System.Collections.Generic.Dictionary<System.String, System.Object>)val_9;
    }
    private System.Collections.Generic.List<object> ParseArray()
    {
        var val_6;
        System.Collections.Generic.List<System.Object> val_1 = null;
        val_6 = val_1;
        val_1 = new System.Collections.Generic.List<System.Object>();
        if(this.json != null)
        {
            goto label_3;
        }
        
        goto label_3;
        label_8:
        Add(item:  this.json);
        do
        {
            label_3:
            TOKEN val_2 = this.NextToken;
            var val_4 = ((val_2 - 4) >= 3) ? 0 : (val_2 + 1);
        }
        while(val_4 == 7);
        
        if(val_4 != 6)
        {
                if(val_4 != 0)
        {
                return (System.Collections.Generic.List<System.Object>)val_6;
        }
        
        }
        
        if(val_2 == 0)
        {
            goto label_6;
        }
        
        object val_5 = this.ParseByToken(token:  val_2);
        if(null != 0)
        {
            goto label_8;
        }
        
        goto label_8;
        label_6:
        val_6 = 0;
        return (System.Collections.Generic.List<System.Object>)val_6;
    }
    private object ParseValue()
    {
        return this.ParseByToken(token:  this.NextToken);
    }
    private object ParseByToken(Unitycoding.MiniJSON.Parser.TOKEN token)
    {
        string val_16 = 0;
        if((((token - 7) < 5) ? (token - 4) : 0) > 6)
        {
                return (object);
        }
        
        var val_16 = 25805448 + (val_1 < 0x5 ? (token - 4) : 0) << 2;
        val_16 = val_16 + 25805448;
        goto (25805448 + (val_1 < 0x5 ? (token - 4) : 0) << 2 + 25805448);
    }
    private string ParseString()
    {
        char val_26;
        System.IO.StringReader val_27;
        if(this.json != null)
        {
            goto label_29;
        }
        
        goto label_29;
        label_8:
        val_26 = this.json;
        System.Text.StringBuilder val_2 = Append(value:  val_26);
        label_29:
        val_27 = this.json;
        if(val_27 == 1)
        {
            goto label_10;
        }
        
        val_27 = this.NextChar;
        char val_4 = val_27 & 65535;
        if(val_4 == '\')
        {
            goto label_5;
        }
        
        if(val_4 == '"')
        {
            goto label_10;
        }
        
        label_26:
        if(null != 0)
        {
            goto label_8;
        }
        
        goto label_8;
        label_5:
        val_27 = this.json;
        if(val_27 == 1)
        {
            goto label_10;
        }
        
        char val_5 = this.NextChar;
        char val_6 = val_5 & 65535;
        char val_7 = val_6 - 114;
        val_6 = val_6 - 103;
        var val_8 = (val_7 < '') ? (val_6) : 0;
        val_7 = val_8 - 11;
        if(val_7 > 3)
        {
            goto label_11;
        }
        
        var val_26 = 25805432 + ((val_7 < '' ? ((val_5 & 65535) - 103) : 0 - 11)) << 2;
        val_26 = val_26 + 25805432;
        goto (25805432 + ((val_7 < '' ? ((val_5 & 65535) - 103) : 0 - 11)) << 2 + 25805432);
        label_11:
        if(val_8 != 0)
        {
                return (string)new System.Text.StringBuilder();
        }
        
        char val_9 = val_5 & 65535;
        if(val_9 > 'a')
        {
            goto label_15;
        }
        
        val_9 = val_9 - 34;
        if(val_9 > (':'))
        {
            goto label_29;
        }
        
        val_9 = 1 << val_9;
        val_9 = val_9 & 288230376151719937;
        if(val_9 != 0)
        {
            goto label_26;
        }
        
        goto label_29;
        label_35:
        System.Text.StringBuilder val_10 = Append(value:  '	');
        goto label_29;
        label_15:
        if(val_9 == 'b')
        {
            goto label_27;
        }
        
        if(val_9 == 'f')
        {
            goto label_28;
        }
        
        if(val_9 != 'n')
        {
            goto label_29;
        }
        
        if(null != 0)
        {
            goto label_35;
        }
        
        goto label_35;
        label_27:
        if(null != 0)
        {
            goto label_35;
        }
        
        goto label_35;
        label_28:
        if(null != 0)
        {
            goto label_35;
        }
        
        goto label_35;
        label_10:
        if(null == 0)
        {
            
        }
    
    }
    private object ParseNumber()
    {
        var val_12;
        var val_13;
        string val_1 = this.NextWord;
        if((val_1.IndexOf(value:  '.')) != 1)
        {
                bool val_7 = System.Double.TryParse(s:  0, style:  val_1, provider:  511, result: out  System.Globalization.CultureInfo.InvariantCulture);
            val_12 = 0;
            val_13 = 1152921504608497664;
            return (object)0;
        }
        
        bool val_11 = System.Int64.TryParse(s:  0, style:  val_1, provider:  511, result: out  System.Globalization.CultureInfo.InvariantCulture);
        val_12 = 0;
        val_13 = 1152921504607592448;
        return (object)0;
    }
    private UnityEngine.Vector3 ToVector3(string vector)
    {
        typeof(System.Char[]).__il2cppRuntimeField_20 = 40;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 41;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 44;
        System.String[] val_3 = vector.Split(separator:  null)[1].Split(separator:  null)[0].Split(separator:  null);
        string val_9 = val_3[0];
        float val_4 = System.Convert.ToSingle(value:  0);
        string val_10 = val_3[1];
        float val_5 = System.Convert.ToSingle(value:  0);
        string val_11 = val_3[2];
        float val_6 = System.Convert.ToSingle(value:  0);
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private UnityEngine.Vector2 ToVector2(string vector)
    {
        typeof(System.Char[]).__il2cppRuntimeField_20 = 40;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 41;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 44;
        System.String[] val_3 = vector.Split(separator:  null)[1].Split(separator:  null)[0].Split(separator:  null);
        string val_9 = val_3[0];
        string val_10 = val_3[1];
        CinemachineFreeLook.Orbit val_6 = new CinemachineFreeLook.Orbit(h:  System.Convert.ToSingle(value:  0), r:  System.Convert.ToSingle(value:  0));
        return new UnityEngine.Vector2() {x = val_6.m_Height, y = val_6.m_Radius};
    }
    private UnityEngine.Color ToColor(string color)
    {
        typeof(System.Char[]).__il2cppRuntimeField_20 = 40;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 41;
        typeof(System.Char[]).__il2cppRuntimeField_20 = 44;
        System.String[] val_3 = color.Split(separator:  null)[1].Split(separator:  null)[0].Split(separator:  null);
        string val_10 = val_3[0];
        float val_4 = System.Convert.ToSingle(value:  0);
        string val_11 = val_3[1];
        float val_5 = System.Convert.ToSingle(value:  0);
        string val_12 = val_3[2];
        float val_6 = System.Convert.ToSingle(value:  0);
        string val_13 = val_3[3];
        float val_7 = System.Convert.ToSingle(value:  0);
        return new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
    }
    private void EatWhitespace()
    {
        do
        {
            char val_1 = this.PeekChar;
            if((System.Char.IsWhiteSpace(c:  ' ')) == false)
        {
                return;
        }
        
        }
        while(this.json != 1);
    
    }
    private char get_PeekChar()
    {
        return System.Convert.ToChar(value:  0);
    }
    private char get_NextChar()
    {
        return System.Convert.ToChar(value:  0);
    }
    private string get_NextWord()
    {
        var val_6;
        System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
        label_4:
        char val_2 = this.PeekChar;
        val_6 = val_2;
        if((MiniJSON.Parser.IsWordBreak(c:  val_2)) == true)
        {
            goto label_1;
        }
        
        System.Text.StringBuilder val_5 = Append(value:  this.NextChar);
        if(this.json != 1)
        {
            goto label_4;
        }
        
        label_1:
        if(null == 0)
        {
            
        }
    
    }
    private Unitycoding.MiniJSON.Parser.TOKEN get_NextToken()
    {
        System.IO.StringReader val_17;
        var val_18;
        val_17 = this;
        this.EatWhitespace();
        if(this.json == 1)
        {
            goto label_33;
        }
        
        char val_2 = this.PeekChar & 65535;
        if((val_2 - 44) > '')
        {
            goto label_3;
        }
        
        val_18 = 5;
        if((25805872 + (((val_1 & 65535) - 44)) << 2) > 6)
        {
                return (TOKEN)val_18;
        }
        
        var val_17 = 25805404 + (25805872 + (((val_1 & 65535) - 44)) << 2) << 2;
        val_17 = val_17 + 25805404;
        goto (25805404 + (25805872 + (((val_1 & 65535) - 44)) << 2) << 2 + 25805404);
        label_3:
        var val_6 = ((val_2 - 91) < '') ? (val_2 - 82) : 0;
        if(val_6 == 0)
        {
            goto label_5;
        }
        
        if(val_6 == 11)
        {
            goto label_6;
        }
        
        if(val_6 != 10)
        {
            goto label_7;
        }
        
        label_5:
        var val_9 = ((val_2 - 123) < '') ? (val_2 - 110) : 0;
        if(val_9 == 0)
        {
            goto label_8;
        }
        
        if(val_9 == 15)
        {
            goto label_9;
        }
        
        if(val_9 != 14)
        {
            goto label_10;
        }
        
        label_8:
        if(val_2 != '"')
        {
            goto label_11;
        }
        
        val_18 = 7;
        return (TOKEN)val_18;
        label_6:
        val_17 = this.json;
        val_18 = 4;
        return (TOKEN)val_18;
        label_7:
        val_18 = 3;
        return (TOKEN)val_18;
        label_9:
        val_17 = this.json;
        val_18 = 2;
        return (TOKEN)val_18;
        label_10:
        val_18 = 1;
        return (TOKEN)val_18;
        label_11:
        val_17 = this.NextWord;
        if(val_17 != null)
        {
                if((System.String.op_Equality(a:  0, b:  val_17)) != false)
        {
                val_18 = 10;
            return (TOKEN)val_18;
        }
        
            if((System.String.op_Equality(a:  0, b:  val_17)) != false)
        {
                val_18 = 9;
            return (TOKEN)val_18;
        }
        
            if((System.String.op_Equality(a:  0, b:  val_17)) != false)
        {
                val_18 = 11;
            return (TOKEN)val_18;
        }
        
        }
        
        label_33:
        val_18 = 0;
        return (TOKEN)val_18;
    }

}
