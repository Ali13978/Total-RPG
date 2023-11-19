using UnityEngine;
[UnityEngine.ExecuteInEditMode]
public class ImposterPostEffect : MonoBehaviour
{
    // Fields
    [UnityEngine.SerializeField]
    private int blurIterations;
    [UnityEngine.SerializeField]
    private float blur;
    [UnityEngine.SerializeField]
    private float blurAlphaMultiply;
    [UnityEngine.SerializeField]
    private UnityEngine.MonoBehaviour[] effects;
    [UnityEngine.SerializeField]
    private UnityEngine.Material testMaterial;
    private UnityEngine.Material mat;
    private UnityEngine.RenderTexture resultTexture;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private bool <DepthNormalRender>k__BackingField;
    
    // Properties
    public bool DepthNormalRender { get; set; }
    public float Blur { get; set; }
    public int BlurIterations { get; set; }
    public float BlurAlphaMultiply { get; set; }
    
    // Methods
    public ImposterPostEffect()
    {
        this.blurIterations = 20;
        this.blur = 1f;
        this.blurAlphaMultiply = 3.673364E-41f;
    }
    public bool get_DepthNormalRender()
    {
        return (bool)this.<DepthNormalRender>k__BackingField;
    }
    public void set_DepthNormalRender(bool value)
    {
        this.<DepthNormalRender>k__BackingField = value;
    }
    public float get_Blur()
    {
        return (float)this.blur;
    }
    public void set_Blur(float value)
    {
        this.blur = value;
    }
    public int get_BlurIterations()
    {
        return (int)this.blurIterations;
    }
    public void set_BlurIterations(int value)
    {
        this.blurIterations = value;
    }
    public float get_BlurAlphaMultiply()
    {
        return (float)this.blurAlphaMultiply;
    }
    public void set_BlurAlphaMultiply(float value)
    {
        this.blurAlphaMultiply = value;
    }
    private void OnEnable()
    {
        this.GetComponent<UnityEngine.Camera>().depthTextureMode = 2;
    }
    private void OnDisable()
    {
        UnityEngine.RenderTexture.ReleaseTemporary(temp:  0);
    }
    private UnityEngine.Material createMaterial()
    {
        return (UnityEngine.Material)new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  0));
    }
    private UnityEngine.RenderTexture getTempRenderTextureFrom(UnityEngine.RenderTexture src)
    {
        UnityEngine.RenderTextureFormat val_6;
        UnityEngine.RenderTextureReadWrite val_7;
        if(src != null)
        {
                val_6 = src.depth;
            val_7 = src.format;
        }
        else
        {
                val_6 = 0.depth;
            val_7 = 0.format;
        }
        
        int val_5 = src.antiAliasing;
        return UnityEngine.RenderTexture.GetTemporary(width:  0, height:  src, depthBuffer:  src, format:  val_6, readWrite:  val_7, antiAliasing:  0);
    }
    public void Clear()
    {
        UnityEngine.CameraClearFlags val_4;
        UnityEngine.Camera val_1 = this.GetComponent<UnityEngine.Camera>();
        if(val_1 != null)
        {
                val_4 = val_1.clearFlags;
            val_1.clearFlags = 2;
            val_1.Render();
        }
        else
        {
                val_4 = val_1.clearFlags;
            val_1.clearFlags = 2;
            val_1.Render();
        }
        
        val_1.clearFlags = val_4;
    }
    public void SetPostEffects(bool enable)
    {
        goto label_1;
        label_6:
        enable = enable;
        enabled = enable;
        0 = 1;
        label_1:
        if(0 >= this.effects.Length)
        {
            goto label_3;
        }
        
        if(this.effects[1] != null)
        {
            goto label_6;
        }
        
        goto label_6;
        label_3:
        if(enable != false)
        {
                return;
        }
        
        this.GetComponent<UnityEngine.Camera>().depthTextureMode = 2;
    }
    public void RestoreAlpha(UnityEngine.RenderTexture destination)
    {
        bool val_1 = UnityEngine.Object.op_Inequality(x:  0, y:  this.resultTexture);
        if(val_1 == false)
        {
                return;
        }
        
        this.mat.SetTexture(name:  "_FirstTex", value:  destination);
        this.mat.SetTexture(name:  "_SecondTex", value:  this.resultTexture);
        UnityEngine.Graphics.Blit(source:  0, dest:  destination);
        UnityEngine.Graphics.Blit(source:  0, dest:  val_1.getTempRenderTextureFrom(src:  destination), mat:  destination, pass:  this.mat);
        UnityEngine.RenderTexture.ReleaseTemporary(temp:  0);
    }
    private void OnRenderImage(UnityEngine.RenderTexture src, UnityEngine.RenderTexture dest)
    {
        UnityEngine.Texture val_12;
        UnityEngine.RenderTexture val_13;
        UnityEngine.Material val_14;
        int val_15;
        float val_16;
        bool val_1 = UnityEngine.Object.op_Equality(x:  0, y:  this.mat);
        if(val_1 != false)
        {
                this.mat = val_1.createMaterial();
        }
        
        if(0 != this.testMaterial)
        {
                if(0 == this.testMaterial.mainTexture)
        {
                this.testMaterial.mainTexture = this.resultTexture;
        }
        
        }
        
        if((this.<DepthNormalRender>k__BackingField) != false)
        {
                UnityEngine.GL.sRGBWrite = false;
            val_12 = 0;
            val_13 = src;
            val_14 = dest;
            val_15 = this.mat;
        }
        else
        {
                UnityEngine.GL.sRGBWrite = false;
            val_12 = 0;
            val_13 = src;
            val_14 = dest;
            val_15 = this.mat;
        }
        
        UnityEngine.Graphics.Blit(source:  val_12, dest:  val_13, mat:  val_14, pass:  val_15);
        val_16 = this.blur;
        if(val_16 != 0f)
        {
                this.mat.SetFloat(name:  "_Blur", value:  val_16);
            val_16 = this.blurAlphaMultiply;
            this.mat.SetFloat(name:  "_BlurAlphaMultiply", value:  val_16);
            UnityEngine.RenderTexture val_8 = UnityEngine.RenderTexture.GetTemporary(width:  0, height:  src);
            UnityEngine.Graphics.Blit(source:  0, dest:  dest);
            if(this.blurIterations >= 1)
        {
                var val_12 = 0;
            do
        {
            UnityEngine.Graphics.Blit(source:  0, dest:  dest, mat:  val_8, pass:  this.mat);
            UnityEngine.Graphics.Blit(source:  0, dest:  val_8, mat:  dest, pass:  this.mat);
            val_12 = val_12 + 1;
        }
        while(val_12 < this.blurIterations);
        
        }
        
            UnityEngine.Graphics.Blit(source:  0, dest:  dest);
            this.mat.SetTexture(name:  "_SecondTex", value:  UnityEngine.RenderTexture.GetTemporary(width:  0, height:  src));
            UnityEngine.Graphics.Blit(source:  0, dest:  val_8, mat:  dest, pass:  this.mat);
            UnityEngine.RenderTexture.ReleaseTemporary(temp:  0);
            UnityEngine.RenderTexture.ReleaseTemporary(temp:  0);
        }
        
        if(0 != this.resultTexture)
        {
                UnityEngine.RenderTexture.ReleaseTemporary(temp:  0);
        }
        
        this.resultTexture = this.getTempRenderTextureFrom(src:  src);
        UnityEngine.Graphics.Blit(source:  0, dest:  dest);
        bool val_11 = UnityEngine.GL.sRGBWrite;
        UnityEngine.GL.sRGBWrite = false;
    }

}
