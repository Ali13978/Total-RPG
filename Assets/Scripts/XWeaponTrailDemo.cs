using UnityEngine;
public class XWeaponTrailDemo : MonoBehaviour
{
    // Fields
    public UnityEngine.Animation SwordAnimation;
    public XftWeapon.XWeaponTrail ProTrailDistort;
    public XftWeapon.XWeaponTrail ProTrailShort;
    public XftWeapon.XWeaponTrail ProTraillong;
    public XftWeapon.XWeaponTrail SimpleTrail;
    
    // Methods
    public XWeaponTrailDemo()
    {
    
    }
    public void Start()
    {
        this.ProTrailDistort.Init();
        this.ProTrailShort.Init();
        this.ProTraillong.Init();
        this.SimpleTrail.Init();
    }
    private void OnGUI()
    {
        XftWeapon.XWeaponTrail val_9;
        XftWeapon.XWeaponTrail val_10;
        val_9 = this;
        val_10 = 1152921504742842368;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.ProTrailDistort.Deactivate();
            this.ProTrailShort.Deactivate();
            this.ProTraillong.Deactivate();
            bool val_2 = this.SwordAnimation.Play();
            this.SimpleTrail.Activate();
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.SimpleTrail.Deactivate();
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.SimpleTrail.mIsFading = true;
            this.SimpleTrail.mFadeTime = 0.3f;
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.SimpleTrail.Deactivate();
            bool val_6 = this.SwordAnimation.Play();
            this.ProTrailDistort.Activate();
            this.ProTrailShort.Activate();
            this.ProTraillong.Activate();
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) != false)
        {
                this.ProTrailDistort.Deactivate();
            this.ProTrailShort.Deactivate();
            this.ProTraillong.Deactivate();
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0)) == false)
        {
                return;
        }
        
        this.ProTrailDistort.mFadeTime = 0.3f;
        this.ProTrailDistort.mIsFading = true;
        val_10 = this.ProTrailShort;
        this.ProTrailShort.mFadeTime = 0.3f;
        this.ProTrailShort.mIsFading = true;
        val_9 = this.ProTraillong;
        this.ProTraillong.mIsFading = true;
        this.ProTraillong.mFadeTime = 0.3f;
    }

}
