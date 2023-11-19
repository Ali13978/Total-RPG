using UnityEngine;
public class FbxObjectsManager
{
    // Fields
    public FbxDataNode objMainNode;
    private string saveFileFolder;
    
    // Methods
    public FbxObjectsManager(FbxDataNode inputObjNode, string folder)
    {
        val_1 = new System.Object();
        this.objMainNode = inputObjNode;
        this.saveFileFolder = val_1;
    }
    public void EditTargetFile(string targetFilePath)
    {
        int val_14;
        var val_15;
        string val_16;
        var val_17;
        string val_1 = System.IO.File.ReadAllText(path:  0);
        if(val_1 != null)
        {
                val_14 = val_1.IndexOf(value:  "Objects:  {\n");
        }
        else
        {
                val_14 = 0.IndexOf(value:  "Objects:  {\n");
        }
        
        val_15 = "Objects:  {\n";
        if(("Objects:  {\n") == null)
        {
                val_15 = "Objects:  {\n";
        }
        
        int val_5 = Length;
        int val_6 = val_5 + val_14;
        val_16 = val_1;
        null = new System.IO.StringReader(s:  val_16);
        if(val_6 > 0)
        {
                do
        {
            val_16 = mem[null + 400 + 8];
            val_6 = val_6 - 1;
        }
        while(val_6 != 0);
        
        }
        
        var val_14 = 0;
        val_17 = 1;
        goto label_14;
        label_13:
        val_17 = 2;
        label_14:
        val_14 = val_14 + 1;
        if(32768 == 125)
        {
            goto label_11;
        }
        
        if(32768 != 123)
        {
            goto label_14;
        }
        
        goto label_13;
        label_11:
        val_17 = val_17 - 1;
        if(val_17 != 0)
        {
            goto label_14;
        }
        
        string val_8 = this.objMainNode.getResultData();
        string val_12 = val_1.Substring(startIndex:  (val_5 + val_14) + val_14);
        string val_13 = 0 + 0 + val_1.Substring(startIndex:  0, length:  val_14)(val_1.Substring(startIndex:  0, length:  val_14))(0 + val_1.Substring(startIndex:  0, length:  val_14)(val_1.Substring(startIndex:  0, length:  val_14)));
        System.IO.File.WriteAllText(path:  0, contents:  targetFilePath);
    }
    public void AddAnimationCurveNode(string inputId, FbxAnimationCurveNodeType animCurveType, UnityEngine.Vector3 initData)
    {
        var val_10;
        var val_11;
        string val_12;
        val_10 = null;
        val_10 = null;
        if(animCurveType <= 3)
        {
                val_11 = mem[33130912 + (animCurveType) << 3];
            val_11 = 33130912 + (animCurveType) << 3;
        }
        
        FbxDataNode val_3 = new FbxDataNode(nodeName:  "Properties70", nodeData:  System.String.Empty, level:  2);
        addSubNode(newNode:  new FbxDataNode(nodeName:  "P", nodeData:  0 + "\"d|X\", \"Number\", \"\", \"A\","("\"d|X\", \"Number\", \"\", \"A\","), level:  3));
        addSubNode(newNode:  new FbxDataNode(nodeName:  "P", nodeData:  0 + "\"d|Y\", \"Number\", \"\", \"A\","("\"d|Y\", \"Number\", \"\", \"A\","), level:  3));
        addSubNode(newNode:  new FbxDataNode(nodeName:  "P", nodeData:  0 + "\"d|Z\", \"Number\", \"\", \"A\","("\"d|Z\", \"Number\", \"\", \"A\","), level:  3));
        if(null != 0)
        {
                addSubNode(newNode:  val_3);
            val_12 = this.saveFileFolder;
        }
        else
        {
                addSubNode(newNode:  val_3);
            val_12 = this.saveFileFolder;
        }
        
        saveDataOnDisk(saveFolder:  val_12);
        this.objMainNode.addSubNode(newNode:  new FbxDataNode(nodeName:  "AnimationCurveNode", nodeData:  0 + inputId + ", \"AnimCurveNode::"(", \"AnimCurveNode::") + System.String.__il2cppRuntimeField_static_fields, level:  1));
    }
    public void AddAnimationCurve(string inputId, float[] curveData)
    {
        string val_17;
        var val_18;
        string val_19;
        string val_20;
        val_17 = null;
        val_17 = null;
        val_18 = 0;
        val_19 = System.String.Empty;
        goto label_3;
        label_13:
        val_19 = val_17;
        val_18 = 1;
        label_3:
        if(val_18 >= curveData.Length)
        {
            goto label_5;
        }
        
        var val_17 = curveData[1][32];
        if(val_18 == 0)
        {
            goto label_7;
        }
        
        string val_4 = FbxHelper.getFbxSeconds(frameIndex:  0 + val_19 + ",", frameRate:  1);
        string val_5 = 0 + val_19 + ",";
        goto label_13;
        label_7:
        string val_7 = FbxHelper.getFbxSeconds(frameIndex:  0 + val_19, frameRate:  0);
        string val_8 = 0 + val_19;
        goto label_13;
        label_5:
        if(null != 0)
        {
                addSubNode(newNodeName:  "Default", newNodeData:  "0");
        }
        else
        {
                addSubNode(newNodeName:  "Default", newNodeData:  "0");
        }
        
        addSubNode(newNodeName:  "KeyVer", newNodeData:  "4008");
        addSubNode(newNodeName:  "a", newNodeData:  val_19);
        addSubNode(newNode:  new FbxDataNode(nodeName:  "KeyTime", nodeData:  0 + "*"("*"), level:  2));
        FbxDataNode val_14 = new FbxDataNode(nodeName:  "KeyValueFloat", nodeData:  0 + "*"("*"), level:  2);
        addSubNode(newNodeName:  "a", newNodeData:  val_19);
        if(null != 0)
        {
                addSubNode(newNode:  val_14);
        }
        else
        {
                addSubNode(newNode:  val_14);
        }
        
        addSubNode(newNodeName:  ";KeyAttrFlags", newNodeData:  "Cubic|TangeantAuto|GenericTimeIndependent|GenericClampProgressive");
        addSubNode(newNodeName:  "a", newNodeData:  "24840");
        addSubNode(newNode:  new FbxDataNode(nodeName:  "KeyAttrFlags", nodeData:  "*1", level:  2));
        FbxDataNode val_16 = new FbxDataNode(nodeName:  "KeyAttrRefCount", nodeData:  "*1", level:  2);
        addSubNode(newNodeName:  "a", newNodeData:  curveData.Length);
        if(null != 0)
        {
                addSubNode(newNode:  val_16);
            val_20 = this.saveFileFolder;
        }
        else
        {
                addSubNode(newNode:  val_16);
            val_20 = this.saveFileFolder;
        }
        
        saveDataOnDisk(saveFolder:  val_20);
        this.objMainNode.addSubNode(newNode:  new FbxDataNode(nodeName:  "AnimationCurve", nodeData:  0 + inputId, level:  1));
    }

}
