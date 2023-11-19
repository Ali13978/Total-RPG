using UnityEngine;
public class FbxConnectionsManager
{
    // Fields
    private string fbxStrData;
    private string originalConnectionData;
    private System.Collections.Generic.List<FbxConnectionObj> connObjs;
    
    // Methods
    public FbxConnectionsManager(string inputData)
    {
        null = null;
        this.fbxStrData = System.String.Empty;
        this.originalConnectionData = System.String.Empty;
        this.fbxStrData = inputData;
        this.LoadObjectsData();
    }
    public void EditTargetFile(string targetFilePath)
    {
        string val_12;
        var val_13;
        val_12 = "Connections:  {\n";
        val_13 = 0;
        goto label_1;
        label_8:
        string val_1 = X23.getOutputData();
        val_12 = 0 + val_12;
        val_13 = 1;
        label_1:
        if(val_13 >= this.connObjs.Count)
        {
            goto label_3;
        }
        
        string val_6 = 0 + val_12;
        if(this.connObjs.Item[1] != null)
        {
            goto label_8;
        }
        
        goto label_8;
        label_3:
        string val_9 = 0 + val_12;
        string val_11 = System.Text.RegularExpressions.Regex.Replace(input:  0, pattern:  System.IO.File.ReadAllText(path:  0), replacement:  "Connections:\\s\\s\\{[^\\}]*\\}\\n");
        System.IO.File.WriteAllText(path:  0, contents:  targetFilePath);
    }
    private void LoadObjectsData()
    {
        var val_13;
        var val_14;
        System.Text.RegularExpressions.Match val_1 = System.Text.RegularExpressions.Regex.Match(input:  0, pattern:  this.fbxStrData);
        string val_3 = val_1.Item[0].Value;
        UnityEngine.Debug.Log(message:  0);
        UnityEngine.Debug.Log(message:  0);
        this.connObjs = new System.Collections.Generic.List<FbxConnectionObj>();
        typeof(System.String[]).__il2cppRuntimeField_20 = "\t\n";
        val_13 = 0;
        goto label_16;
        label_23:
        val_13 = 1;
        label_16:
        if(val_13 >= val_7.Length)
        {
            goto label_18;
        }
        
        this.connObjs.Add(item:  new FbxConnectionObj(connectionStr:  val_1.Item[1].Value.Split(separator:  null, options:  1)[1]));
        goto label_23;
        label_18:
        int val_9 = this.connObjs.Count;
        string val_10 = 0 + "found attributes: "("found attributes: ");
        UnityEngine.Debug.Log(message:  0);
        val_14 = 0;
        goto label_29;
        label_34:
        Log();
        val_14 = 1;
        label_29:
        if(val_14 >= this.connObjs.Count)
        {
                return;
        }
        
        if(this.connObjs.Item[1] != null)
        {
            goto label_34;
        }
        
        goto label_34;
    }
    public void AddConnectionItem(string type1, string name1, string id1, string type2, string name2, string id2, string relation, string relationDesc = "")
    {
        this.connObjs.Add(item:  new FbxConnectionObj(type1:  type1, name1:  name1, id1:  id1, type2:  type2, name2:  name2, id2:  id2, relation:  relation, relationDesc:  relationDesc));
    }
    public string searchObjectId(string objectName)
    {
        var val_5;
        var val_6;
        string val_7;
        var val_8;
        val_5 = objectName;
        val_6 = 0;
        goto label_1;
        label_8:
        val_6 = 1;
        label_1:
        if(val_6 >= this.connObjs.Count)
        {
            goto label_3;
        }
        
        FbxConnectionObj val_2 = this.connObjs.Item[1];
        if((System.String.op_Equality(a:  0, b:  val_2.name2)) == false)
        {
            goto label_8;
        }
        
        val_5 = this.connObjs.Item[1];
        val_7 = val_4.id2;
        return (string)System.String.__il2cppRuntimeField_static_fields;
        label_3:
        val_8 = null;
        val_8 = null;
        return (string)System.String.__il2cppRuntimeField_static_fields;
    }
    public string getAnimBaseLayerId()
    {
        var val_7;
        System.Collections.Generic.List<FbxConnectionObj> val_8;
        string val_9;
        var val_10;
        val_7 = 0;
        goto label_1;
        label_13:
        val_7 = 1;
        label_1:
        val_8 = this.connObjs;
        if(val_7 >= val_8.Count)
        {
            goto label_3;
        }
        
        FbxConnectionObj val_2 = this.connObjs.Item[1];
        if((System.String.op_Equality(a:  0, b:  val_2.type1)) == false)
        {
            goto label_13;
        }
        
        FbxConnectionObj val_4 = this.connObjs.Item[1];
        val_8 = val_4.name1;
        if((System.String.op_Equality(a:  0, b:  val_8)) == false)
        {
            goto label_13;
        }
        
        val_7 = this.connObjs.Item[1];
        val_9 = val_6.id1;
        return (string)System.String.__il2cppRuntimeField_static_fields;
        label_3:
        val_10 = null;
        val_10 = null;
        return (string)System.String.__il2cppRuntimeField_static_fields;
    }

}
