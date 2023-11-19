using UnityEngine;
public class MayaNodeDataContainer
{
    // Fields
    private TransformTracker tracker;
    public UnityEngine.Transform observeObj;
    private string objNodeName;
    private string saveFileName;
    private string fileFolderPath;
    private bool recordTranslation;
    private bool recordRotation;
    private bool recordScale;
    private string objFinalFilePath;
    
    // Methods
    public MayaNodeDataContainer(UnityEngine.Transform inputObj, string namePath, string inputPath, bool recordT, bool recordR, bool recordS)
    {
        null = null;
        this.objFinalFilePath = System.String.Empty;
        val_1 = new System.Object();
        this.objNodeName = val_1;
        bool val_3 = recordS;
        this.saveFileName = val_1.Replace(oldChar:  '/', newChar:  '-');
        this.fileFolderPath = inputPath;
        bool val_4 = recordT;
        bool val_5 = recordR;
        this.recordScale = val_3;
        this.observeObj = inputObj;
        this.recordTranslation = val_4;
        this.recordRotation = val_5;
        this.tracker = new TransformTracker(targetObj:  inputObj, trackPos:  val_4, trackRot:  val_5, trackScale:  val_3);
    }
    public void recordFrame(int frameIndex)
    {
        this.tracker.recordFrame();
    }
    public void WriteIntoFile()
    {
        var val_59;
        string val_60;
        var val_61;
        int val_62;
        bool val_63;
        var val_64;
        int val_65;
        System.Collections.Generic.List<UnityEngine.Quaternion> val_66;
        var val_67;
        int val_68;
        val_59 = 1152921504623407104;
        System.IO.StreamWriter val_4 = new System.IO.StreamWriter(path:  0 + this.fileFolderPath + this.saveFileName);
        System.IO.StreamWriter val_5 = new System.IO.StreamWriter(path:  0 + this.fileFolderPath + this.saveFileName);
        val_60 = 0 + this.fileFolderPath + this.saveFileName;
        null = new System.IO.StreamWriter(path:  val_60);
        if((this.recordTranslation & 255) == false)
        {
            goto label_3;
        }
        
        string val_9 = this.getMayaCurveHeadContent(curveName:  "animCurveTL", propertyName:  "translateX", animCount:  this.tracker.posDataList.Count);
        string val_11 = this.getMayaCurveHeadContent(curveName:  "animCurveTL", propertyName:  "translateY", animCount:  this.tracker.posDataList.Count);
        string val_13 = this.getMayaCurveHeadContent(curveName:  "animCurveTL", propertyName:  "translateZ", animCount:  this.tracker.posDataList.Count);
        val_61 = mem[null + 480 + 8];
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.zero;
        val_62 = 0;
        goto label_15;
        label_65:
        val_61 = mem[null + 480 + 8];
        val_62 = 1;
        label_15:
        if(val_62 >= this.tracker.posDataList.Count)
        {
            goto label_18;
        }
        
        UnityEngine.Vector3 val_16 = this.tracker.posDataList.Item[1];
        UnityEngine.Vector3 val_17 = ExportHelper.UnityToMayaPosition(t:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
        typeof(System.Object[]).__il2cppRuntimeField_20 = " ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_62;
        typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = val_17.x;
        typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
        string val_18 = +0;
        typeof(System.Object[]).__il2cppRuntimeField_20 = " ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_62;
        typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = val_17.y;
        typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
        string val_19 = +0;
        typeof(System.Object[]).__il2cppRuntimeField_20 = " ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_62;
        typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = val_17.z;
        typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
        string val_20 = +0;
        if(null != 0)
        {
            goto label_65;
        }
        
        goto label_65;
        label_18:
        string val_21 = this.getMayaCurveFootContent(propertyName:  "translateX", footPropertyName:  "tx");
        string val_22 = this.getMayaCurveFootContent(propertyName:  "translateY", footPropertyName:  "ty");
        string val_23 = this.getMayaCurveFootContent(propertyName:  "translateZ", footPropertyName:  "tz");
        val_63 = this.recordRotation;
        goto label_72;
        label_3:
        val_63 = this.recordTranslation >> 8;
        label_72:
        if(val_63 == false)
        {
            goto label_73;
        }
        
        string val_25 = this.getMayaCurveHeadContent(curveName:  "animCurveTA", propertyName:  "rotateX", animCount:  this.tracker.rotDataList.Count);
        string val_27 = this.getMayaCurveHeadContent(curveName:  "animCurveTA", propertyName:  "rotateY", animCount:  this.tracker.rotDataList.Count);
        string val_29 = this.getMayaCurveHeadContent(curveName:  "animCurveTA", propertyName:  "rotateZ", animCount:  this.tracker.rotDataList.Count);
        val_64 = mem[null + 480 + 8];
        UnityEngine.Vector3 val_30 = UnityEngine.Vector3.zero;
        val_65 = 0;
        goto label_85;
        label_135:
        val_64 = mem[null + 480 + 8];
        val_65 = 1;
        label_85:
        val_66 = this.tracker.rotDataList;
        if(val_65 >= val_66.Count)
        {
            goto label_88;
        }
        
        UnityEngine.Quaternion val_32 = this.tracker.rotDataList.Item[1];
        UnityEngine.Vector3 val_33 = ExportHelper.UnityToMayaRotation(q:  new UnityEngine.Quaternion() {x = val_32.x, y = val_32.y, z = val_32.z, w = val_32.w});
        typeof(System.Object[]).__il2cppRuntimeField_20 = " ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_65;
        typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = val_33.x;
        typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
        string val_34 = +0;
        typeof(System.Object[]).__il2cppRuntimeField_20 = " ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_65;
        typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = val_33.y;
        typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
        string val_35 = +0;
        typeof(System.Object[]).__il2cppRuntimeField_20 = " ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_65;
        typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = val_33.z;
        typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
        string val_36 = +0;
        if(null != 0)
        {
            goto label_135;
        }
        
        goto label_135;
        label_88:
        val_59 = ";\n";
        string val_37 = this.getMayaCurveFootContent(propertyName:  "rotateX", footPropertyName:  "rx");
        string val_38 = this.getMayaCurveFootContent(propertyName:  "rotateY", footPropertyName:  "ry");
        val_60 = this.getMayaCurveFootContent(propertyName:  "rotateZ", footPropertyName:  "rz");
        label_73:
        if(this.recordScale == false)
        {
            goto label_142;
        }
        
        string val_41 = this.getMayaCurveHeadContent(curveName:  "animCurveTU", propertyName:  "scaleX", animCount:  this.tracker.scaleDataList.Count);
        string val_43 = this.getMayaCurveHeadContent(curveName:  "animCurveTU", propertyName:  "scaleY", animCount:  this.tracker.scaleDataList.Count);
        string val_45 = this.getMayaCurveHeadContent(curveName:  "animCurveTU", propertyName:  "scaleZ", animCount:  this.tracker.scaleDataList.Count);
        val_67 = mem[null + 480 + 8];
        UnityEngine.Vector3 val_46 = UnityEngine.Vector3.zero;
        val_68 = 0;
        goto label_154;
        label_204:
        val_67 = mem[null + 480 + 8];
        val_68 = 1;
        label_154:
        val_66 = this.tracker.rotDataList;
        if(val_68 >= val_66.Count)
        {
            goto label_157;
        }
        
        UnityEngine.Vector3 val_48 = this.tracker.scaleDataList.Item[1];
        typeof(System.Object[]).__il2cppRuntimeField_20 = " ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_68;
        typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = val_48.x;
        typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
        string val_49 = +0;
        typeof(System.Object[]).__il2cppRuntimeField_20 = " ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_68;
        typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = val_48.y;
        typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
        string val_50 = +0;
        typeof(System.Object[]).__il2cppRuntimeField_20 = " ";
        typeof(System.Object[]).__il2cppRuntimeField_28 = val_68;
        typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
        typeof(System.Object[]).__il2cppRuntimeField_30 = " ";
        typeof(System.Object[]).__il2cppRuntimeField_38 = val_48.z;
        typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
        string val_51 = +0;
        if(null != 0)
        {
            goto label_204;
        }
        
        goto label_204;
        label_157:
        val_59 = ";\n";
        string val_52 = this.getMayaCurveFootContent(propertyName:  "scaleX", footPropertyName:  "sx");
        string val_53 = this.getMayaCurveFootContent(propertyName:  "scaleY", footPropertyName:  "sy");
        val_60 = this.getMayaCurveFootContent(propertyName:  "scaleZ", footPropertyName:  "sz");
        label_142:
        string val_55 = 0 + this.fileFolderPath + this.saveFileName;
        this.objFinalFilePath = val_55;
        string val_56 = System.IO.File.ReadAllText(path:  0);
        System.IO.File.AppendAllText(path:  0, contents:  val_55);
        string val_57 = System.IO.File.ReadAllText(path:  0);
        System.IO.File.AppendAllText(path:  0, contents:  this.objFinalFilePath);
        string val_58 = System.IO.File.ReadAllText(path:  0);
        System.IO.File.AppendAllText(path:  0, contents:  this.objFinalFilePath);
        System.IO.File.Delete(path:  0);
        System.IO.File.Delete(path:  0);
        System.IO.File.Delete(path:  0);
    }
    public string getFinalFilePath()
    {
        var val_3;
        string val_4;
        val_3 = null;
        val_3 = null;
        val_4 = 0;
        if((System.String.op_Equality(a:  0, b:  this.objFinalFilePath)) == true)
        {
                return val_4;
        }
        
        val_4 = this.objFinalFilePath;
        return val_4;
    }
    public bool cleanFile()
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        if((System.String.op_Equality(a:  0, b:  this.objFinalFilePath)) != false)
        {
                val_4 = 0;
            return (bool)val_4;
        }
        
        System.IO.File.Delete(path:  0);
        val_5 = null;
        val_5 = null;
        val_4 = 1;
        this.objFinalFilePath = System.String.Empty;
        return (bool)val_4;
    }
    private string getMayaCurveHeadContent(string curveName, string propertyName, int animCount)
    {
        null = null;
        typeof(System.String[]).__il2cppRuntimeField_20 = System.String.Empty;
        typeof(System.String[]).__il2cppRuntimeField_28 = "createNode ";
        typeof(System.String[]).__il2cppRuntimeField_30 = curveName;
        typeof(System.String[]).__il2cppRuntimeField_38 = " -n \"";
        typeof(System.String[]).__il2cppRuntimeField_40 = this.objNodeName;
        typeof(System.String[]).__il2cppRuntimeField_48 = "_";
        typeof(System.String[]).__il2cppRuntimeField_50 = propertyName;
        typeof(System.String[]).__il2cppRuntimeField_58 = "\";\n";
        typeof(System.String[]).__il2cppRuntimeField_20 = 0 + 0 + +0(+0)(0 + +0(+0));
        typeof(System.String[]).__il2cppRuntimeField_28 = "\tsetAttr -s ";
        typeof(System.String[]).__il2cppRuntimeField_30 = ;
        typeof(System.String[]).__il2cppRuntimeField_38 = " \".ktv[0:";
        int val_5 = animCount;
        val_5 = val_5 - 1;
        typeof(System.String[]).__il2cppRuntimeField_40 = ;
        typeof(System.String[]).__il2cppRuntimeField_48 = "]\" ";
        return (string)+0;
    }
    private string getMayaCurveFootContent(string propertyName, string footPropertyName)
    {
        null = null;
        typeof(System.String[]).__il2cppRuntimeField_20 = System.String.Empty;
        typeof(System.String[]).__il2cppRuntimeField_28 = "connectAttr \"";
        typeof(System.String[]).__il2cppRuntimeField_30 = this.objNodeName;
        typeof(System.String[]).__il2cppRuntimeField_38 = "_";
        typeof(System.String[]).__il2cppRuntimeField_40 = propertyName;
        typeof(System.String[]).__il2cppRuntimeField_48 = ".o\" \"";
        typeof(System.String[]).__il2cppRuntimeField_50 = this.objNodeName;
        typeof(System.String[]).__il2cppRuntimeField_58 = ".";
        typeof(System.String[]).__il2cppRuntimeField_60 = footPropertyName;
        typeof(System.String[]).__il2cppRuntimeField_68 = "\";\n";
        return +0;
    }

}
