using UnityEngine;
public class UnityObjectAnimation
{
    // Fields
    public UnityCurveContainer[] curves;
    public UnityEngine.Transform observeGameObject;
    public string pathName;
    
    // Methods
    public UnityObjectAnimation(string hierarchyPath, UnityEngine.Transform observeObj)
    {
        null = null;
        this.pathName = System.String.Empty;
        this.observeGameObject = observeObj;
        this.pathName = hierarchyPath;
        this.curves = null;
        typeof(UnityCurveContainer[]).__il2cppRuntimeField_20 = new UnityCurveContainer(_propertyName:  "localPosition.x");
        this.curves[1] = new UnityCurveContainer(_propertyName:  "localPosition.y");
        this.curves[2] = new UnityCurveContainer(_propertyName:  "localPosition.z");
        this.curves[3] = new UnityCurveContainer(_propertyName:  "localRotation.x");
        this.curves[4] = new UnityCurveContainer(_propertyName:  "localRotation.y");
        this.curves[5] = new UnityCurveContainer(_propertyName:  "localRotation.z");
        this.curves[6] = new UnityCurveContainer(_propertyName:  "localRotation.w");
        this.curves[7] = new UnityCurveContainer(_propertyName:  "localScale.x");
        this.curves[8] = new UnityCurveContainer(_propertyName:  "localScale.y");
        this.curves[9] = new UnityCurveContainer(_propertyName:  "localScale.z");
    }
    public void AddFrame(float time)
    {
        UnityEngine.Vector3 val_1 = this.observeGameObject.localPosition;
        this.curves[0].AddValue(animTime:  time, animValue:  val_1.x);
        UnityEngine.Vector3 val_2 = this.observeGameObject.localPosition;
        this.curves[1].AddValue(animTime:  time, animValue:  val_2.y);
        UnityEngine.Vector3 val_3 = this.observeGameObject.localPosition;
        this.curves[2].AddValue(animTime:  time, animValue:  val_3.z);
        UnityEngine.Quaternion val_4 = this.observeGameObject.localRotation;
        this.curves[3].AddValue(animTime:  time, animValue:  val_4.x);
        UnityEngine.Quaternion val_5 = this.observeGameObject.localRotation;
        this.curves[4].AddValue(animTime:  time, animValue:  val_5.y);
        UnityEngine.Quaternion val_6 = this.observeGameObject.localRotation;
        this.curves[5].AddValue(animTime:  time, animValue:  val_6.z);
        UnityEngine.Quaternion val_7 = this.observeGameObject.localRotation;
        this.curves[6].AddValue(animTime:  time, animValue:  val_7.w);
        UnityEngine.Vector3 val_8 = this.observeGameObject.localScale;
        this.curves[7].AddValue(animTime:  time, animValue:  val_8.x);
        UnityEngine.Vector3 val_9 = this.observeGameObject.localScale;
        this.curves[8].AddValue(animTime:  time, animValue:  val_9.y);
        UnityEngine.Vector3 val_10 = this.observeGameObject.localScale;
        this.curves[9].AddValue(animTime:  time, animValue:  val_10.z);
    }

}
