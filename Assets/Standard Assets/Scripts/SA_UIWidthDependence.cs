using UnityEngine;
[UnityEngine.ExecuteInEditMode]
[UnityEngine.RequireComponent]
public class SA_UIWidthDependence : MonoBehaviour
{
    // Fields
    private UnityEngine.RectTransform _rect;
    public bool KeepRatioInEdiotr;
    public bool CaclulcateOnlyOntStart;
    public UnityEngine.Rect InitialRect;
    [UnityEngine.HideInInspector]
    public UnityEngine.Rect InitialScreen;
    
    // Properties
    public UnityEngine.RectTransform rect { get; }
    
    // Methods
    public SA_UIWidthDependence()
    {
        mem[1152921510514629628] = 0;
        this.InitialScreen = 0;
        mem[1152921510514629612] = 0;
        this.InitialRect = 0;
    }
    private void Awake()
    {
        if(UnityEngine.Application.isPlaying == false)
        {
                return;
        }
        
        this.ApplyTransformation();
    }
    private void Update()
    {
        var val_15;
        UnityEngine.HideFlags val_16;
        val_15 = this;
        if(UnityEngine.Application.isPlaying != false)
        {
                if(this.CaclulcateOnlyOntStart == true)
        {
                return;
        }
        
            this.ApplyTransformation();
            return;
        }
        
        if(this.KeepRatioInEdiotr != false)
        {
                this.ApplyTransformation();
            val_15 = this.rect;
            val_16 = 8;
        }
        else
        {
                UnityEngine.Vector2 val_5 = this.rect.anchoredPosition;
            UnityEngine.Vector2 val_7 = this.rect.anchoredPosition;
            UnityEngine.Rect val_9 = this.rect.rect;
            UnityEngine.Rect val_11 = this.rect.rect;
            this.InitialRect = 0;
            int val_12 = UnityEngine.Screen.width;
            int val_13 = UnityEngine.Screen.height;
            this.InitialScreen = 0;
            val_15 = this.rect;
            val_16 = 0;
        }
        
        val_15.hideFlags = val_16;
    }
    public void ApplyTransformation()
    {
        float val_1 = V0.16B / S0;
        float val_12 = (float)UnityEngine.Screen.width;
        float val_4 = val_12 / val_1;
        val_1 = (V0.16B / S0) * val_4;
        val_12 = val_12 / val_12;
        CinemachineFreeLook.Orbit val_9 = new CinemachineFreeLook.Orbit(h:  val_4 * val_12, r:  val_1 * (val_12 / val_12));
        this.rect.anchoredPosition = new UnityEngine.Vector2() {x = val_9.m_Height, y = val_9.m_Radius};
        CinemachineFreeLook.Orbit val_11 = new CinemachineFreeLook.Orbit(h:  val_4, r:  val_1);
        this.rect.sizeDelta = new UnityEngine.Vector2() {x = val_11.m_Height, y = val_11.m_Radius};
    }
    public UnityEngine.RectTransform get_rect()
    {
        UnityEngine.RectTransform val_4;
        if(0 == this._rect)
        {
                this._rect = this.GetComponent<UnityEngine.RectTransform>();
            return val_4;
        }
        
        val_4 = this._rect;
        return val_4;
    }
    private void OnDetroy()
    {
        this.rect.hideFlags = 0;
    }

}
