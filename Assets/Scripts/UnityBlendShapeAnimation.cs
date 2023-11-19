using UnityEngine;
public class UnityBlendShapeAnimation
{
    // Fields
    public UnityCurveContainer[] curves;
    public UnityEngine.SkinnedMeshRenderer skinMeshObj;
    private string[] blendShapeNames;
    private int blendShapeCount;
    public string pathName;
    
    // Methods
    public UnityBlendShapeAnimation(string hierarchyPath, UnityEngine.SkinnedMeshRenderer observeSkinnedMeshRenderer)
    {
        var val_6;
        UnityCurveContainer[] val_7;
        val_6 = null;
        val_6 = null;
        this.pathName = System.String.Empty;
        this.pathName = hierarchyPath;
        this.skinMeshObj = observeSkinnedMeshRenderer;
        UnityEngine.Mesh val_1 = observeSkinnedMeshRenderer.sharedMesh;
        this.blendShapeCount = val_1.blendShapeCount;
        this.blendShapeNames = null;
        val_7 = null;
        this.curves = val_7;
        if(this.blendShapeCount < 1)
        {
                return;
        }
        
        do
        {
            this.blendShapeNames[0] = val_1.GetBlendShapeName(shapeIndex:  0);
            string val_6 = this.blendShapeNames[0];
            this.curves[0] = new UnityCurveContainer(_propertyName:  0 + "blendShape.");
            val_7 = 0 + 1;
        }
        while(val_7 < this.blendShapeCount);
    
    }
    public void AddFrame(float time)
    {
        if(this.blendShapeCount < 1)
        {
                return;
        }
        
        var val_3 = 0;
        do
        {
            this.curves[0].AddValue(animTime:  time, animValue:  this.skinMeshObj.GetBlendShapeWeight(index:  0));
            val_3 = val_3 + 1;
        }
        while(val_3 < this.blendShapeCount);
    
    }

}
