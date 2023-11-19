using UnityEngine;
[Serializable]
public class GK_AchievementTemplate
{
    // Fields
    public bool IsOpen;
    public string Id;
    public string Title;
    public string Description;
    public float _progress;
    public UnityEngine.Texture2D Texture;
    
    // Properties
    public float Progress { get; set; }
    
    // Methods
    public GK_AchievementTemplate()
    {
        var val_1;
        this.IsOpen = true;
        val_1 = null;
        val_1 = null;
        this.Id = System.String.Empty;
        this.Title = "New Achievement";
        this.Description = System.String.Empty;
    }
    public float get_Progress()
    {
        IOSNativeSettings val_1 = IOSNativeSettings.Instance;
        if(val_1.UsePPForAchievements == false)
        {
                return (float)this._progress;
        }
        
        return GameCenterManager.GetAchievementProgress(id:  null);
    }
    public void set_Progress(float value)
    {
        this._progress = value;
    }

}
