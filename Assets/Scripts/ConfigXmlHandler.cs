using UnityEngine;
private class Configuration.ConfigXmlHandler : SmallXmlParser.IContentHandler
{
    // Fields
    public TzarGames.Common.ConfigurationEntry EntryTree;
    private TzarGames.Common.ConfigurationEntry currentEntry;
    
    // Methods
    public Configuration.ConfigXmlHandler()
    {
        this.EntryTree = new TzarGames.Common.ConfigurationEntry();
    }
    public void OnStartParsing(Mono.Xml.SmallXmlParser parser)
    {
        this.EntryTree.Type = 3;
        this.currentEntry = this.EntryTree;
    }
    public void OnEndParsing(Mono.Xml.SmallXmlParser parser)
    {
    
    }
    public void OnStartElement(string name, Mono.Xml.SmallXmlParser.IAttrList attrs)
    {
        IAttrList val_14;
        TzarGames.Common.ConfigurationEntry val_15;
        TzarGames.Common.ConfigurationEntry val_16;
        TzarGames.Common.ConfigurationEntry val_17;
        val_14 = attrs;
        val_15 = this;
        string val_1 = name.ToLower();
        var val_3 = (this.currentEntry.Type < 4) ? (this.currentEntry.Type + 3) : 0;
        if(val_3 == 3)
        {
            goto label_3;
        }
        
        if(val_3 == 5)
        {
            goto label_4;
        }
        
        if(val_3 != 6)
        {
                return;
        }
        
        if(val_1 == null)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  0, b:  val_1)) == false)
        {
                return;
        }
        
        val_15 = this.currentEntry;
        this.currentEntry.Type = 0;
        return;
        label_3:
        val_14 = val_1.findNameAtribute(attrs:  val_14);
        if(val_1 == null)
        {
                return;
        }
        
        if(val_14 == null)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  0, b:  val_1)) == false)
        {
            goto label_16;
        }
        
        TzarGames.Common.ConfigurationEntry val_8 = null;
        val_16 = val_8;
        val_8 = new TzarGames.Common.ConfigurationEntry();
        if(null == 0)
        {
            goto label_17;
        }
        
        typeof(TzarGames.Common.ConfigurationEntry).__il2cppRuntimeField_10 = val_14;
        goto label_18;
        label_4:
        if((System.String.op_Equality(a:  0, b:  val_1)) == false)
        {
                return;
        }
        
        TzarGames.Common.ConfigurationEntry val_10 = null;
        val_16 = val_10;
        val_10 = new TzarGames.Common.ConfigurationEntry();
        if(null == 0)
        {
            goto label_22;
        }
        
        label_18:
        label_28:
        typeof(TzarGames.Common.ConfigurationEntry).__il2cppRuntimeField_20 = 1;
        val_17 = this.currentEntry;
        goto label_23;
        label_16:
        if((System.String.op_Equality(a:  0, b:  val_1)) == false)
        {
                return;
        }
        
        TzarGames.Common.ConfigurationEntry val_13 = new TzarGames.Common.ConfigurationEntry();
        if(null == 0)
        {
            goto label_27;
        }
        
        typeof(TzarGames.Common.ConfigurationEntry).__il2cppRuntimeField_10 = val_14;
        goto label_28;
        label_17:
        mem[16] = val_14;
        label_22:
        label_31:
        mem[32] = 1;
        val_17 = this.currentEntry;
        label_23:
        typeof(TzarGames.Common.ConfigurationEntry).__il2cppRuntimeField_28 = val_17;
        val_14 = this.currentEntry.Entries;
        val_14.Add(item:  val_16);
        this.currentEntry = val_16;
        return;
        label_27:
        mem[16] = val_14;
        goto label_31;
    }
    private string findNameAtribute(Mono.Xml.SmallXmlParser.IAttrList attrs)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        val_7 = 0;
        goto label_1;
        label_25:
        val_7 = 1;
        label_1:
        var val_7 = 0;
        val_7 = val_7 + 1;
        val_8 = attrs;
        if(val_7 >= attrs)
        {
                return 0;
        }
        
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_9 = attrs;
        IAttrList val_3 = attrs + 8;
        if((System.String.op_Equality(a:  0, b:  attrs)) == false)
        {
            goto label_25;
        }
        
        var val_9 = 0;
        val_9 = val_9 + 1;
        val_10 = attrs;
        IAttrList val_6 = attrs + 8;
        goto label_25;
    }
    public void OnEndElement(string name)
    {
        if(this.currentEntry == null)
        {
                return;
        }
        
        this.currentEntry = this.currentEntry.Parent;
    }
    public void OnProcessingInstruction(string name, string text)
    {
    
    }
    public void OnChars(string text)
    {
        if(this.currentEntry == null)
        {
                return;
        }
        
        if(this.currentEntry.Type != 1)
        {
                return;
        }
        
        this.currentEntry.Value = text;
    }
    public void OnIgnorableWhitespace(string text)
    {
    
    }

}
