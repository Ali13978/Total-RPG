using UnityEngine;
public class FbxObjectSubNode
{
    // Fields
    public string nodeName;
    public string nodeValue;
    
    // Methods
    public FbxObjectSubNode()
    {
        null = null;
        this.nodeName = System.String.Empty;
        this.nodeValue = System.String.Empty;
    }
    public void SetupData(string inputName, string inputValue)
    {
        this.nodeName = 0 + inputName;
        this.nodeValue = inputValue;
    }
    public void SetupData(string inputName, float[] inputData)
    {
        var val_7;
        string val_1 = 0 + inputName + ": *"(": *") + inputData.Length;
        this.nodeName = val_1;
        val_7 = 0;
        this.nodeValue = "{\n\t\t\ta: ";
        goto label_4;
        label_14:
        val_7 = 1;
        this.nodeValue = val_1;
        label_4:
        if(val_7 >= inputData.Length)
        {
            goto label_6;
        }
        
        var val_7 = inputData[1][32];
        if(val_7 == 0)
        {
            goto label_8;
        }
        
        string val_4 = 0 + this.nodeValue + ",";
        goto label_14;
        label_8:
        string val_5 = 0 + this.nodeValue;
        goto label_14;
        label_6:
        this.nodeValue = 0 + this.nodeValue;
    }
    public void SetupData(string inputName, int[] inputData)
    {
        var val_7;
        string val_1 = 0 + inputName + ": *"(": *") + inputData.Length;
        this.nodeName = val_1;
        val_7 = 0;
        this.nodeValue = "{\n\t\t\ta: ";
        goto label_4;
        label_14:
        val_7 = 1;
        this.nodeValue = val_1;
        label_4:
        if(val_7 >= inputData.Length)
        {
            goto label_6;
        }
        
        var val_7 = inputData[1][32];
        if(val_7 == 0)
        {
            goto label_8;
        }
        
        string val_4 = 0 + this.nodeValue + ",";
        goto label_14;
        label_8:
        string val_5 = 0 + this.nodeValue;
        goto label_14;
        label_6:
        this.nodeValue = 0 + this.nodeValue;
    }
    public void SetupData(string inputName, string[] inputData)
    {
        var val_7;
        string val_1 = 0 + inputName + ": *"(": *") + inputData.Length;
        this.nodeName = val_1;
        val_7 = 0;
        this.nodeValue = "{\n\t\t\ta: ";
        goto label_4;
        label_14:
        val_7 = 1;
        this.nodeValue = val_1;
        label_4:
        if(val_7 >= inputData.Length)
        {
            goto label_6;
        }
        
        string val_7 = inputData[1];
        if(val_7 == 0)
        {
            goto label_8;
        }
        
        string val_4 = 0 + this.nodeValue + ",";
        goto label_14;
        label_8:
        string val_5 = 0 + this.nodeValue;
        goto label_14;
        label_6:
        this.nodeValue = 0 + this.nodeValue;
    }
    public string GetResultString()
    {
        return 0 + this.nodeName + this.nodeValue;
    }

}
