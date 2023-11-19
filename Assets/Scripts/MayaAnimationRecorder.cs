using UnityEngine;
public class MayaAnimationRecorder : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform[] observeObjs;
    private MayaNodeDataContainer[] objAnims;
    public string saveFolderPath;
    public string saveFileName;
    public string originalMaFilePath;
    public UnityEngine.KeyCode startKey;
    public UnityEngine.KeyCode endKey;
    public bool changeTimeScale;
    public float startGameWithTimeScale;
    public float startRecordWithTimeScale;
    public bool recordPosition;
    public bool recordRotation;
    public bool recordScale;
    public bool includePathName;
    public bool showLogGUI;
    private string logMessage;
    public bool recordLimitFrames;
    public int recordFrames;
    public int processPerFrame;
    public int frameIndexToStartTransform;
    private bool isTransformStart;
    private int objNums;
    public int frameIndex;
    private bool isStart;
    private bool isEnd;
    
    // Methods
    public MayaAnimationRecorder()
    {
        var val_1;
        this.startKey = 113;
        this.endKey = 119;
        this.recordScale = true;
        this.startRecordWithTimeScale = 1f;
        this.recordPosition = true;
        this.recordRotation = true;
        val_1 = null;
        val_1 = null;
        this.frameIndexToStartTransform = 1500;
        this.recordFrames = 1000;
        this.processPerFrame = 20;
        this.logMessage = System.String.Empty;
    }
    private void Start()
    {
        bool val_2 = this.changeTimeScale;
        if((val_2 & 255) != false)
        {
                val_2 = val_2 >> 32;
            UnityEngine.Time.timeScale = val_2;
        }
        
        this.SettingRecordItems();
    }
    private void SettingRecordItems()
    {
        var val_12;
        string val_13;
        this.observeObjs = this.gameObject.GetComponentsInChildren<UnityEngine.Transform>();
        this.objAnims = null;
        val_12 = 0;
        this.objNums = MayaNodeDataContainer[].__il2cppRuntimeField_namespaze;
        goto label_4;
        label_23:
        var val_3 = X28 + ((X19) << 3);
        val_12 = 1;
        mem2[0] = null;
        label_4:
        if(val_12 >= this.observeObjs.Length)
        {
            goto label_6;
        }
        
        val_13 = this.observeObjs[1].name;
        if(this.includePathName != false)
        {
                UnityEngine.Transform val_13 = this.observeObjs[1];
            val_13 = AnimationRecorderHelper.GetTransformPathName(rootTransform:  0, targetTransform:  this.transform);
            string val_7 = 0 + "get name: "("get name: ");
            UnityEngine.Debug.Log(message:  0);
        }
        
        null = new MayaNodeDataContainer(inputObj:  this.observeObjs[1], namePath:  val_13, inputPath:  this.saveFolderPath, recordT:  (this.recordPosition != true) ? 1 : 0, recordR:  (this.recordPosition != true) ? 1 : 0, recordS:  (this.recordPosition != true) ? 1 : 0);
        if(val_12 < this.objAnims.Length)
        {
            goto label_23;
        }
        
        goto label_23;
        label_6:
        this.ShowLog(logStr:  "Setting complete");
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
        
        this.StopRecording();
    }
    private void OnGUI()
    {
        if(this.showLogGUI == false)
        {
                return;
        }
        
        UnityEngine.GUILayout.Label(text:  0, options:  this.logMessage);
    }
    public void StartRecording()
    {
        this.ShowLog(logStr:  "Recording start");
        if(this.changeTimeScale != false)
        {
                UnityEngine.Time.timeScale = this.startRecordWithTimeScale;
        }
        
        this.isStart = true;
    }
    public void StopRecording()
    {
        this.ShowLog(logStr:  "End recording, wait for file process ... ");
        this.isEnd = true;
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "EndRecord");
    }
    private void LateUpdate()
    {
        if((this.isStart & 255) == false)
        {
                return;
        }
        
        if(this.isStart > true)
        {
                return;
        }
        
        if(this.objNums >= 1)
        {
                var val_5 = 0;
            do
        {
            MayaNodeDataContainer val_4 = this.objAnims[0];
            this.objAnims[0x0][0].tracker.recordFrame();
            val_5 = val_5 + 1;
        }
        while(val_5 < this.objNums);
        
        }
        
        int val_6 = this.frameIndex;
        bool val_7 = this.recordLimitFrames;
        val_6 = val_6 + 1;
        this.frameIndex = val_6;
        if((val_7 & 255) == false)
        {
                return;
        }
        
        val_7 = val_7 >> 32;
        if(val_6 <= val_7)
        {
                return;
        }
        
        this.ShowLog(logStr:  "Recording complete, processing ...");
        this.isEnd = true;
        UnityEngine.Coroutine val_3 = this.StartCoroutine(methodName:  "EndRecord");
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.IEnumerator EndRecord()
    {
        typeof(MayaAnimationRecorder.<EndRecord>c__Iterator0).__il2cppRuntimeField_18 = this;
        return (System.Collections.IEnumerator)new System.Object();
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.IEnumerator exportToMayaAnimation()
    {
        typeof(MayaAnimationRecorder.<exportToMayaAnimation>c__Iterator1).__il2cppRuntimeField_38 = this;
        return (System.Collections.IEnumerator)new System.Object();
    }
    private void ShowLog(string logStr)
    {
        if(this.showLogGUI != false)
        {
                this.logMessage = logStr;
            return;
        }
        
        UnityEngine.Debug.Log(message:  0);
    }

}
