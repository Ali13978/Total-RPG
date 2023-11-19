using UnityEngine;
public class FbxDataNode
{
    // Fields
    public static int nowDataId;
    public string nodeName;
    public string nodeData;
    private int level;
    public System.Collections.Generic.List<FbxDataNode> subNodes;
    private string dataFilePath;
    private bool isDataInFile;
    public bool hasSubNode;
    
    // Methods
    public FbxDataNode(string nodeName, string nodeData, int level)
    {
        null = null;
        this.dataFilePath = System.String.Empty;
        val_1 = new System.Object();
        this.subNodes = new System.Collections.Generic.List<FbxDataNode>();
        this.nodeName = nodeName;
        this.nodeData = val_1;
        this.level = level;
    }
    public static FbxDataNode[] FetchNodes(string inputData, int level)
    {
        FbxDataNode val_20;
        string val_21;
        FbxDataNode val_22;
        string val_23;
        var val_24;
        string val_25;
        int val_26;
        var val_27;
        int val_28;
        var val_29;
        val_20 = W2;
        System.Collections.Generic.List<FbxDataNode> val_1 = null;
        val_21 = val_1;
        val_1 = new System.Collections.Generic.List<FbxDataNode>();
        System.IO.StringReader val_2 = new System.IO.StringReader(s:  level);
        val_22 = 2;
        var val_3 = val_20 + 1;
        goto label_47;
        label_37:
        val_22 = val_20;
        Add(item:  val_22);
        goto label_47;
        label_54:
        val_20 = val_2;
        if((IndexOf(value:  "{")) == 1)
        {
            goto label_4;
        }
        
        val_23 = val_20;
        System.String[] val_5 = FbxDataNode.GetNodeData(strLine:  X20);
        val_24 = null;
        val_24 = null;
        var val_20 = 1;
        val_25 = System.String.Empty;
        goto label_21;
        label_18:
        val_23 = val_25;
        val_25 = 0 + val_23 + val_21;
        label_21:
        if(val_2 == 1)
        {
            goto label_11;
        }
        
        if((IndexOf(value:  "{")) != 1)
        {
            goto label_13;
        }
        
        if((IndexOf(value:  "}")) != 1)
        {
            goto label_15;
        }
        
        goto label_18;
        label_13:
        string val_9 = 0 + val_25 + val_2;
        val_20 = val_20 + 1;
        goto label_21;
        label_15:
        val_20 = val_20 - 1;
        if(val_20 != 0)
        {
            goto label_18;
        }
        
        label_11:
        val_26 = val_5.Length;
        if(val_26 == 0)
        {
                val_26 = val_5.Length;
        }
        
        string val_21 = val_5[0];
        FbxDataNode val_10 = X20;
        val_10 = new FbxDataNode(nodeName:  val_21, nodeData:  val_5[1], level:  val_20);
        mem2[0] = 1;
        val_27 = 0;
        goto label_30;
        label_35:
        val_10.addSubNode(newNode:  val_21);
        val_27 = 1;
        label_30:
        if(val_27 >= (X20 + 24))
        {
            goto label_32;
        }
        
        var val_11 = X20 + 8;
        if(val_10 != 0)
        {
            goto label_35;
        }
        
        goto label_35;
        label_32:
        if(null != 0)
        {
            goto label_37;
        }
        
        goto label_37;
        label_4:
        val_22 = ":";
        if((IndexOf(value:  val_22)) != 1)
        {
                System.String[] val_13 = FbxDataNode.GetNodeData(strLine:  X20);
            val_28 = val_13.Length;
            if(val_28 == 0)
        {
                val_28 = val_13.Length;
        }
        
            FbxDataNode val_14 = X20;
            val_20 = val_14;
            val_14 = new FbxDataNode(nodeName:  val_13[0], nodeData:  val_13[1], level:  val_20);
            val_21 = val_21;
            val_22 = val_20;
            Add(item:  val_22);
        }
        else
        {
                if(val_20 >= 2)
        {
                if(null != 0)
        {
                val_29 = Count;
        }
        else
        {
                val_29 = Count;
        }
        
            FbxDataNode val_18 = Item[val_29 - 1];
            val_22 = val_18.nodeData;
            val_21 = val_21;
            val_18.nodeData = 0 + val_22;
        }
        
        }
        
        label_47:
        if(val_2 != 1)
        {
            goto label_54;
        }
        
        if(null != 0)
        {
                return ToArray();
        }
        
        return ToArray();
    }
    public static string[] GetNodeData(string strLine)
    {
        string val_17;
        var val_18;
        var val_19;
        var val_21;
        string val_23;
        var val_24;
        string val_26;
        val_17 = X1;
        if((val_17.IndexOf(value:  "{")) != 1)
        {
                val_18 = "([^:]*):\\s([^\\{]*)\\{";
        }
        else
        {
                val_18 = "([^:]*):\\s([^\\n]*)\\n";
            val_17 = 0 + val_17;
        }
        
        System.Text.RegularExpressions.Match val_3 = System.Text.RegularExpressions.Regex.Match(input:  0, pattern:  val_17);
        if(val_3.Success != false)
        {
                val_19 = 0;
            string val_6 = val_3.Item[1].Value;
            if(val_6 != null)
        {
                val_19 = mem[null + 48];
            if(val_6 == null)
        {
                val_19 = 0;
        }
        
        }
        
            val_19 = 0;
            typeof(System.String[]).__il2cppRuntimeField_20 = val_6;
            typeof(System.String[]).__il2cppRuntimeField_28 = val_3.Item[2].Value;
            val_21 = null;
            val_21 = null;
            typeof(System.String[]).__il2cppRuntimeField_20 = typeof(System.String[]).__il2cppRuntimeField_20.Replace(oldValue:  "\t", newValue:  System.String.Empty);
            val_23 = typeof(System.String[]).__il2cppRuntimeField_28;
            val_23 = typeof(System.String[]).__il2cppRuntimeField_28;
            val_24 = val_23.Length;
            if(((typeof(System.String[]).__il2cppRuntimeField_28.Chars[val_24 - 1]) & 65535) != ' ')
        {
                return (System.String[])null;
        }
        
            val_26 = typeof(System.String[]).__il2cppRuntimeField_28;
            val_26 = typeof(System.String[]).__il2cppRuntimeField_28;
            val_24 = val_26.Length;
            typeof(System.String[]).__il2cppRuntimeField_28 = typeof(System.String[]).__il2cppRuntimeField_28.Substring(startIndex:  0, length:  val_24 - 1);
            return (System.String[])null;
        }
        
        UnityEngine.Debug.Log(message:  0);
        return (System.String[])null;
    }
    public static int GetNextDataId()
    {
        null = null;
        FbxDataNode.nowDataId = FbxDataNode.nowDataId + 1;
        return (int)FbxDataNode.nowDataId;
    }
    public void addSubNode(string newNodeName, string newNodeData)
    {
        this.subNodes.Add(item:  new FbxDataNode(nodeName:  newNodeName, nodeData:  newNodeData, level:  this.level + 1));
        this.hasSubNode = true;
    }
    public void addSubNode(FbxDataNode newNode)
    {
        this.subNodes.Add(item:  newNode);
        this.hasSubNode = true;
    }
    public string getResultData()
    {
        var val_11;
        string val_12;
        string val_13;
        var val_14;
        val_11 = null;
        val_11 = null;
        val_12 = System.String.Empty;
        if(this.level < 1)
        {
            goto label_3;
        }
        
        var val_11 = 0;
        goto label_4;
        label_7:
        val_11 = null;
        label_4:
        val_12 = 0 + System.String.Empty;
        val_11 = val_11 + 1;
        if(val_11 < this.level)
        {
            goto label_7;
        }
        
        label_3:
        typeof(System.String[]).__il2cppRuntimeField_20 = System.String.Empty;
        typeof(System.String[]).__il2cppRuntimeField_28 = val_12;
        typeof(System.String[]).__il2cppRuntimeField_30 = this.nodeName;
        typeof(System.String[]).__il2cppRuntimeField_38 = ": ";
        typeof(System.String[]).__il2cppRuntimeField_40 = this.nodeData;
        string val_2 = +0;
        if(this.hasSubNode == false)
        {
                return 0 + val_2;
        }
        
        val_13 = 0 + val_2;
        if(this.isDataInFile != false)
        {
                string val_6 = System.IO.File.ReadAllText(path:  0);
            val_13 = 0 + val_13;
        }
        
        val_14 = 0;
        goto label_32;
        label_40:
        val_13 = 0 + val_13;
        val_14 = 1;
        label_32:
        if(val_14 >= this.subNodes.Count)
        {
                return 0 + val_13 + val_12;
        }
        
        if(this.subNodes.Item[1] != null)
        {
            goto label_40;
        }
        
        goto label_40;
    }
    public void saveDataOnDisk(string saveFolder)
    {
        string val_8;
        var val_9;
        if(this.isDataInFile != false)
        {
                val_8 = this.dataFilePath;
        }
        else
        {
                this.isDataInFile = true;
            int val_1 = FbxDataNode.GetNextDataId();
            val_8 = this;
            this.dataFilePath = 0 + saveFolder + this.nodeName + "-Data-"("-Data-");
            if((System.IO.File.Exists(path:  0)) != false)
        {
                System.IO.File.Delete(path:  0);
        }
        
        }
        
        System.IO.StreamWriter val_4 = new System.IO.StreamWriter(path:  this.dataFilePath, append:  true);
        val_9 = 0;
        goto label_8;
        label_14:
        val_9 = 1;
        label_8:
        if(val_9 >= this.subNodes.Count)
        {
            goto label_11;
        }
        
        string val_7 = this.subNodes.Item[1].getResultData();
        if(null != 0)
        {
            goto label_14;
        }
        
        goto label_14;
        label_11:
        this.subNodes.Clear();
        if(null != 0)
        {
                return;
        }
    
    }
    public void clearSavedData()
    {
        var val_3;
        if(this.isDataInFile != false)
        {
                System.IO.File.Delete(path:  0);
        }
        
        val_3 = 0;
        goto label_2;
        label_8:
        val_3 = 1;
        label_2:
        if(val_3 >= this.subNodes.Count)
        {
                return;
        }
        
        if(this.subNodes.Item[1] != null)
        {
            goto label_8;
        }
        
        goto label_8;
    }
    private static FbxDataNode()
    {
    
    }

}
