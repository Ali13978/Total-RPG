using UnityEngine;
public class FbxObjectNode
{
    // Fields
    public string nodeName;
    public string nodeValue;
    private string headerString;
    private System.Collections.Generic.List<FbxObjectSubNode> subNodes;
    
    // Methods
    public FbxObjectNode(string nodeType, string nodeId, string nodeName, string subType)
    {
        null = null;
        this.headerString = System.String.Empty;
        val_1 = new System.Object();
        typeof(System.String[]).__il2cppRuntimeField_20 = nodeType;
        typeof(System.String[]).__il2cppRuntimeField_28 = ": ";
        typeof(System.String[]).__il2cppRuntimeField_30 = val_1;
        typeof(System.String[]).__il2cppRuntimeField_38 = ", \"";
        typeof(System.String[]).__il2cppRuntimeField_40 = nodeName;
        typeof(System.String[]).__il2cppRuntimeField_48 = "\", \"";
        typeof(System.String[]).__il2cppRuntimeField_50 = subType;
        typeof(System.String[]).__il2cppRuntimeField_58 = "\" {\n";
        this.headerString = +0;
        this.subNodes = new System.Collections.Generic.List<FbxObjectSubNode>();
    }
    public void AddSubnode(string inputName, string inputValue)
    {
        SetupData(inputName:  inputName, inputValue:  inputValue);
        this.subNodes.Add(item:  new FbxObjectSubNode());
    }
    public void AddSubnode(string inputName, float[] inputFloatData)
    {
        SetupData(inputName:  inputName, inputData:  inputFloatData);
        this.subNodes.Add(item:  new FbxObjectSubNode());
    }
    public void AddSubnode(string inputName, string[] inputStringData)
    {
        SetupData(inputName:  inputName, inputData:  inputStringData);
        this.subNodes.Add(item:  new FbxObjectSubNode());
    }
    public void AddSubnode(string inputName, int[] inputIntData)
    {
        SetupData(inputName:  inputName, inputData:  inputIntData);
        this.subNodes.Add(item:  new FbxObjectSubNode());
    }
    public string GetResultString()
    {
        string val_6;
        var val_7;
        val_6 = 0 + "\t";
        val_7 = 0;
        goto label_3;
        label_10:
        val_6 = 0 + val_6 + "\t\t";
        val_7 = 1;
        label_3:
        if(val_7 >= this.subNodes.Count)
        {
                return 0 + val_6;
        }
        
        string val_5 = this.subNodes.Item[1].GetResultString();
        goto label_10;
    }

}
