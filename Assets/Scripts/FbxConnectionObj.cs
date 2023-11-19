using UnityEngine;
public class FbxConnectionObj
{
    // Fields
    public string type1;
    public string name1;
    public string id1;
    public string type2;
    public string name2;
    public string id2;
    public string relation;
    public string relationDesc;
    private bool hasRelationDesc;
    public bool isSucceed;
    
    // Methods
    public FbxConnectionObj(string type1, string name1, string id1, string type2, string name2, string id2, string relation, string relationDesc = "")
    {
        var val_3;
        val_1 = new System.Object();
        this.type1 = type1;
        this.name1 = val_1;
        this.id1 = id1;
        this.type2 = type2;
        this.name2 = name2;
        this.id2 = id2;
        this.relation = relation;
        this.relationDesc = relationDesc;
        val_3 = null;
        val_3 = null;
        bool val_3 = ~(System.String.op_Equality(a:  0, b:  relationDesc));
        val_3 = val_3 & 1;
        this.hasRelationDesc = val_3;
    }
    public FbxConnectionObj(string connectionStr)
    {
        string val_23;
        var val_24;
        val_23 = "\\t;([^:]*)::([^,]*),\\s([^:]*)::([^\\n]*)\\n\\tC:\\s\"([^\"]*)\",([0-9]*),([0-9]*)([^\n]*\n)";
        System.Text.RegularExpressions.Match val_1 = System.Text.RegularExpressions.Regex.Match(input:  0, pattern:  connectionStr);
        if(val_1.Success == false)
        {
            goto label_4;
        }
        
        this.type1 = val_1.Item[1].Value;
        this.name1 = val_1.Item[2].Value;
        this.type2 = val_1.Item[3].Value;
        this.name2 = val_1.Item[4].Value;
        this.relation = val_1.Item[5].Value;
        this.id1 = val_1.Item[6].Value;
        this.id2 = val_1.Item[7].Value;
        val_23 = val_1.Item[8].Value;
        System.Text.RegularExpressions.Match val_19 = System.Text.RegularExpressions.Regex.Match(input:  0, pattern:  val_23);
        if(val_19.Success == false)
        {
            goto label_32;
        }
        
        this.hasRelationDesc = true;
        this.relationDesc = val_19.Item[1].Value;
        goto label_36;
        label_4:
        this.isSucceed = false;
        return;
        label_32:
        this.hasRelationDesc = false;
        val_24 = null;
        val_24 = null;
        this.relationDesc = System.String.Empty;
        label_36:
        this.isSucceed = true;
    }
    public string getOutputData()
    {
        var val_1;
        var val_2;
        var val_3;
        if(this.hasRelationDesc != false)
        {
                val_1 = null;
            typeof(System.String[]).__il2cppRuntimeField_20 = "\t;";
            typeof(System.String[]).__il2cppRuntimeField_28 = this.type1;
            typeof(System.String[]).__il2cppRuntimeField_30 = "::";
            typeof(System.String[]).__il2cppRuntimeField_38 = this.name1;
            typeof(System.String[]).__il2cppRuntimeField_40 = ", ";
            typeof(System.String[]).__il2cppRuntimeField_48 = this.type2;
            typeof(System.String[]).__il2cppRuntimeField_50 = "::";
            typeof(System.String[]).__il2cppRuntimeField_58 = this.name2;
            typeof(System.String[]).__il2cppRuntimeField_60 = "\n\tC: \"";
            typeof(System.String[]).__il2cppRuntimeField_68 = this.relation;
            typeof(System.String[]).__il2cppRuntimeField_70 = "\",";
            typeof(System.String[]).__il2cppRuntimeField_78 = this.id1;
            typeof(System.String[]).__il2cppRuntimeField_80 = ",";
            typeof(System.String[]).__il2cppRuntimeField_88 = this.id2;
            val_2 = ", \"";
            typeof(System.String[]).__il2cppRuntimeField_90 = val_2;
            typeof(System.String[]).__il2cppRuntimeField_98 = this.relationDesc;
            val_3 = "\"\n";
            typeof(System.String[]).__il2cppRuntimeField_A0 = val_3;
            return +0;
        }
        
        val_1 = null;
        typeof(System.String[]).__il2cppRuntimeField_20 = "\t;";
        typeof(System.String[]).__il2cppRuntimeField_28 = this.type1;
        typeof(System.String[]).__il2cppRuntimeField_30 = "::";
        typeof(System.String[]).__il2cppRuntimeField_38 = this.name1;
        typeof(System.String[]).__il2cppRuntimeField_40 = ", ";
        typeof(System.String[]).__il2cppRuntimeField_48 = this.type2;
        typeof(System.String[]).__il2cppRuntimeField_50 = "::";
        typeof(System.String[]).__il2cppRuntimeField_58 = this.name2;
        typeof(System.String[]).__il2cppRuntimeField_60 = "\n\tC: \"";
        typeof(System.String[]).__il2cppRuntimeField_68 = this.relation;
        typeof(System.String[]).__il2cppRuntimeField_70 = "\",";
        typeof(System.String[]).__il2cppRuntimeField_78 = this.id1;
        val_2 = ",";
        typeof(System.String[]).__il2cppRuntimeField_80 = val_2;
        typeof(System.String[]).__il2cppRuntimeField_88 = this.id2;
        val_3 = "\n";
        typeof(System.String[]).__il2cppRuntimeField_90 = val_3;
        return +0;
    }
    public void Log()
    {
        typeof(System.String[]).__il2cppRuntimeField_20 = this.type1;
        typeof(System.String[]).__il2cppRuntimeField_28 = " ";
        typeof(System.String[]).__il2cppRuntimeField_30 = this.name1;
        typeof(System.String[]).__il2cppRuntimeField_38 = " ";
        typeof(System.String[]).__il2cppRuntimeField_40 = this.type2;
        typeof(System.String[]).__il2cppRuntimeField_48 = " ";
        typeof(System.String[]).__il2cppRuntimeField_50 = this.name2;
        typeof(System.String[]).__il2cppRuntimeField_58 = " ";
        typeof(System.String[]).__il2cppRuntimeField_60 = this.relation;
        typeof(System.String[]).__il2cppRuntimeField_68 = " ";
        typeof(System.String[]).__il2cppRuntimeField_70 = this.id1;
        typeof(System.String[]).__il2cppRuntimeField_78 = " ";
        typeof(System.String[]).__il2cppRuntimeField_80 = this.id2;
        typeof(System.String[]).__il2cppRuntimeField_88 = " ";
        typeof(System.String[]).__il2cppRuntimeField_90 = this.relationDesc;
        string val_1 = +0;
        UnityEngine.Debug.Log(message:  0);
    }

}
