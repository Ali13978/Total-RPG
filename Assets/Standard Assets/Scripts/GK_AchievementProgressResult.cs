using UnityEngine;
public class GK_AchievementProgressResult : Result
{
    // Fields
    private GK_AchievementTemplate _tpl;
    
    // Properties
    public GK_AchievementTemplate info { get; }
    public GK_AchievementTemplate Achievement { get; }
    
    // Methods
    public GK_AchievementProgressResult(GK_AchievementTemplate tpl)
    {
        this._tpl = tpl;
    }
    public GK_AchievementTemplate get_info()
    {
        return (GK_AchievementTemplate)this._tpl;
    }
    public GK_AchievementTemplate get_Achievement()
    {
        return (GK_AchievementTemplate)this._tpl;
    }

}
