using UnityEngine;
public class UnityCurveContainer
{
    // Fields
    public string propertyName;
    public UnityEngine.AnimationCurve animCurve;
    
    // Methods
    public UnityCurveContainer(string _propertyName)
    {
        null = null;
        this.propertyName = System.String.Empty;
        this.propertyName = _propertyName;
        this.animCurve = new UnityEngine.AnimationCurve();
    }
    public void AddValue(float animTime, float animValue)
    {
        int val_1 = this.animCurve.AddKey(key:  new UnityEngine.Keyframe() {m_Time = 0f, m_Value = 0f, m_InTangent = 0f, m_OutTangent = 0f});
    }

}
