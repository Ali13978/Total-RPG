using UnityEngine;
public class FbxExporter : MonoBehaviour
{
    // Fields
    public string sourceFilePath;
    public string exportFileFolder;
    public string exportFilePath;
    private FbxObjectsManager fbxObj;
    private FbxConnectionsManager fbxConn;
    private UnityEngine.Transform[] observeTargets;
    private TransformTracker[] trackers;
    private int objNums;
    public UnityEngine.KeyCode startRecordKey;
    public UnityEngine.KeyCode endRecordKey;
    private bool includePathName;
    private bool recordPos;
    private bool recordRot;
    private bool recordScale;
    private bool isRecording;
    private int nowIdNum;
    
    // Methods
    public FbxExporter()
    {
        this.objNums = 0;
        this.startRecordKey = 113;
        this.endRecordKey = 119;
        this.recordPos = true;
        this.recordRot = true;
        this.recordScale = true;
        this.nowIdNum = 6000001;
    }
    private void Start()
    {
        this.SetupRecordItems();
    }
    private void SetupRecordItems()
    {
        TransformTracker[] val_10;
        this.observeTargets = this.gameObject.GetComponentsInChildren<UnityEngine.Transform>();
        val_10 = null;
        this.trackers = val_10;
        this.objNums = TransformTracker[].__il2cppRuntimeField_namespaze;
        var val_13 = 0;
        do
        {
            string val_3 = this.observeTargets[0].name;
            if(this.includePathName != false)
        {
                UnityEngine.Transform val_11 = this.observeTargets[0];
            string val_5 = AnimationRecorderHelper.GetTransformPathName(rootTransform:  0, targetTransform:  this.transform);
            string val_6 = 0 + "get name: "("get name: ");
            UnityEngine.Debug.Log(message:  0);
        }
        
            TransformTracker val_9 = null;
            val_10 = this.recordPos;
            val_9 = new TransformTracker(targetObj:  this.observeTargets[0], trackPos:  val_10, trackRot:  (this.recordRot != true) ? 1 : 0, trackScale:  (this.recordRot > true) ? 1 : 0);
            this.trackers[0] = val_9;
            val_13 = val_13 + 1;
        }
        while(val_13 < this.objNums);
        
        UnityEngine.Debug.Log(message:  0);
    }
    private void Update()
    {
        if((UnityEngine.Input.GetKeyDown(key:  0)) != false)
        {
                this.StartRecording();
        }
        
        if((UnityEngine.Input.GetKeyDown(key:  0)) == false)
        {
                return;
        }
        
        this.EndRecording();
    }
    private void StartRecording()
    {
        this.isRecording = true;
        UnityEngine.Debug.Log(message:  0);
    }
    private void EndRecording()
    {
        this.isRecording = false;
        UnityEngine.Debug.Log(message:  0);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.ExportToFile());
    }
    private void LateUpdate()
    {
        var val_1;
        if(this.isRecording == false)
        {
                return;
        }
        
        val_1 = 0;
        goto label_1;
        label_7:
        X20.recordFrame();
        val_1 = 1;
        label_1:
        if(val_1 >= this.trackers.Length)
        {
                return;
        }
        
        if(this.trackers[1] != null)
        {
            goto label_7;
        }
        
        goto label_7;
    }
    private void ModifyDefinitions(string targetFilePath)
    {
        string val_19;
        var val_20;
        string val_21;
        var val_22;
        string val_23;
        UnityEngine.Debug.Log(message:  0);
        val_19 = null;
        FbxDataNode[] val_2 = FbxDataNode.FetchNodes(inputData:  val_19, level:  System.IO.File.ReadAllText(path:  0));
        val_20 = 0;
        goto label_5;
        label_12:
        val_20 = 1;
        label_5:
        if(val_20 >= val_2.Length)
        {
            goto label_7;
        }
        
        FbxDataNode val_19 = val_2[1];
        if((System.String.op_Equality(a:  0, b:  val_2[0x1][0].nodeName)) == false)
        {
            goto label_12;
        }
        
        goto label_13;
        label_7:
        val_20 = 0;
        label_13:
        int val_20 = this.observeTargets.Length;
        val_20 = val_20 + (val_20 << 1);
        addSubNode(newNode:  new FbxDataNode(nodeName:  "Count", nodeData:  val_20, level:  2));
        addSubNode(newNode:  new FbxDataNode(nodeName:  "P", nodeData:  "\"d\", \"Compound\", \"\", \"\"", level:  4));
        addSubNode(newNode:  new FbxDataNode(nodeName:  "Properties70", nodeData:  " ", level:  3));
        addSubNode(newNode:  new FbxDataNode(nodeName:  "PropertyTemplate", nodeData:  "\"FbxAnimCurveNode\"", level:  2));
        addSubNode(newNode:  new FbxDataNode(nodeName:  "Count", nodeData:  "10", level:  2));
        FbxDataNode val_21 = val_2[0];
        val_21.addSubNode(newNode:  new FbxDataNode(nodeName:  "ObjectType", nodeData:  "\"AnimationCurveNode\"", level:  1));
        val_2[0x0] + 32.addSubNode(newNode:  new FbxDataNode(nodeName:  "ObjectType", nodeData:  "\"AnimationCurve\"", level:  1));
        UnityEngine.Debug.Log(message:  0);
        System.IO.StreamReader val_12 = null;
        val_21 = targetFilePath;
        val_12 = new System.IO.StreamReader(path:  val_21);
        val_22 = null;
        val_22 = null;
        goto label_29;
        label_36:
        val_21 = System.String.Empty;
        label_29:
        if((val_12 == 1) || ((IndexOf(value:  "Definitions")) != 1))
        {
            goto label_46;
        }
        
        goto label_36;
        label_46:
        val_23 = mem[null + 384 + 8];
        if(val_12 == 1)
        {
            goto label_45;
        }
        
        if((IndexOf(value:  targetFilePath)) != 1)
        {
            goto label_46;
        }
        
        val_23 = "Definitions";
        if((IndexOf(value:  val_23)) == 1)
        {
            goto label_46;
        }
        
        if(1 == 0)
        {
            goto label_45;
        }
        
        goto label_46;
        label_45:
        UnityEngine.Debug.Log(message:  0);
        UnityEngine.Debug.Log(message:  0);
        string val_18 = 0 + 0 + val_21 + val_21(0 + val_21 + val_21) + val_2[0x0] + 32.getResultData()(val_2[0x0] + 32.getResultData());
        System.IO.File.WriteAllText(path:  0, contents:  targetFilePath);
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.IEnumerator ExportToFile()
    {
        typeof(FbxExporter.<ExportToFile>c__Iterator0).__il2cppRuntimeField_D8 = this;
        return (System.Collections.IEnumerator)new System.Object();
    }
    private string getNewId()
    {
        int val_1 = this.nowIdNum;
        val_1 = val_1 + 1;
        this.nowIdNum = val_1;
        return -614737140;
    }

}
