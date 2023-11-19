using UnityEngine;
[UnityEngine.ExecuteInEditMode]
public class MaterialPostprocess : MonoBehaviour
{
    // Fields
    public bool changeDepthTexureMode;
    public UnityEngine.DepthTextureMode depthTextureMode;
    public UnityEngine.Material material;
    
    // Methods
    public MaterialPostprocess()
    {
    
    }
    private void OnEnable()
    {
        if(this.changeDepthTexureMode == false)
        {
                return;
        }
        
        this.GetComponent<UnityEngine.Camera>().depthTextureMode = this.depthTextureMode;
    }
    private void OnRenderImage(UnityEngine.RenderTexture sourceTexture, UnityEngine.RenderTexture destTexture)
    {
        if(0 != this.material)
        {
                UnityEngine.Graphics.Blit(source:  0, dest:  sourceTexture, mat:  destTexture);
            return;
        }
        
        UnityEngine.Graphics.Blit(source:  0, dest:  sourceTexture);
    }

}
