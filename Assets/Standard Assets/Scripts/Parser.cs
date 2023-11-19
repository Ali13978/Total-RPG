using UnityEngine;
private sealed class Json.Parser : IDisposable
{
    // Fields
    private const string WHITE_SPACE = " \t\n\r";
    private const string WORD_BREAK = " \t\n\r{}[],:\"";
    private System.IO.StringReader json;
    
    // Properties
    private char PeekChar { get; }
    private char NextChar { get; }
    private string NextWord { get; }
    private SA.Common.Data.Json.Parser.TOKEN NextToken { get; }
    
    // Methods
    private Json.Parser(string jsonString)
    {
        this.json = new System.IO.StringReader(s:  jsonString);
    }
    public static object Parse(string jsonString)
    {
        var val_4;
        if(null == 0)
        {
            goto label_2;
        }
        
        Json.Parser val_6 = null;
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
        val_4 = new Json.Parser(jsonString:  X1);
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
    private object ParseByToken(SA.Common.Data.Json.Parser.TOKEN token)
    {
        var val_10;
        var val_3 = ((token - 7) < 5) ? (token - 4) : 0;
        val_3 = val_3 - 3;
        if(val_3 <= 4)
        {
                var val_10 = 25976108 + ((val_1 < 0x5 ? (token - 4) : 0 - 3)) << 2;
            val_10 = val_10 + 25976108;
        }
        else
        {
                var val_7 = ((token - 1) < 3) ? (token + 8) : 0;
            if(val_7 != 9)
        {
                val_10 = 0;
            if(val_7 != 11)
        {
                return (object)this.ParseObject();
        }
        
            System.Collections.Generic.List<System.Object> val_8 = this.ParseArray();
            return (object)this.ParseObject();
        }
        
            return (object)this.ParseObject();
        }
    
    }
    private string ParseString()
    {
        char val_27;
        System.IO.StringReader val_28;
        if(this.json != null)
        {
            goto label_29;
        }
        
        goto label_29;
        label_8:
        val_27 = this.json;
        System.Text.StringBuilder val_2 = Append(value:  val_27);
        label_29:
        val_28 = this.json;
        if(val_28 == 1)
        {
            goto label_10;
        }
        
        val_28 = this.NextChar;
        char val_4 = val_28 & 65535;
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
        val_28 = this.json;
        if(val_28 == 1)
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
        
        var val_27 = 25976092 + ((val_7 < '' ? ((val_5 & 65535) - 103) : 0 - 11)) << 2;
        val_27 = val_27 + 25976092;
        goto (25976092 + ((val_7 < '' ? ((val_5 & 65535) - 103) : 0 - 11)) << 2 + 25976092);
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
        var val_7;
        var val_8;
        string val_1 = this.NextWord;
        if((val_1.IndexOf(value:  '.')) != 1)
        {
                bool val_4 = System.Double.TryParse(s:  0, result: out  val_1);
            val_7 = 0;
            val_8 = 1152921504608497664;
            return (object)0;
        }
        
        bool val_6 = System.Int64.TryParse(s:  0, result: out  val_1);
        val_7 = 0;
        val_8 = 1152921504607592448;
        return (object)0;
    }
    private void EatWhitespace()
    {
        var val_3;
        do
        {
            val_3 = " \t\n\r";
            if(" \t\n\r" == null)
        {
                val_3 = " \t\n\r";
        }
        
            if((IndexOf(value:  this.PeekChar)) == 1)
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
        char val_7;
        char val_8;
        System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
        label_5:
        val_6 = " \t\n\r{}[],:\"";
        val_7 = this.PeekChar;
        if((" \t\n\r{}[],:\"") == null)
        {
                val_6 = " \t\n\r{}[],:\"";
        }
        
        val_8 = val_7;
        if((IndexOf(value:  val_8)) != 1)
        {
            goto label_2;
        }
        
        System.Text.StringBuilder val_5 = Append(value:  this.NextChar);
        val_7 = this.json;
        if(val_7 != 1)
        {
            goto label_5;
        }
        
        label_2:
        if(null == 0)
        {
            
        }
    
    }
    private SA.Common.Data.Json.Parser.TOKEN get_NextToken()
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
        if((25976240 + (((val_1 & 65535) - 44)) << 2) > 6)
        {
                return (TOKEN)val_18;
        }
        
        var val_17 = 25976064 + (25976240 + (((val_1 & 65535) - 44)) << 2) << 2;
        val_17 = val_17 + 25976064;
        goto (25976064 + (25976240 + (((val_1 & 65535) - 44)) << 2) << 2 + 25976064);
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
