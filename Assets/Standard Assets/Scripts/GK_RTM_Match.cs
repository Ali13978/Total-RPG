using UnityEngine;
public class GK_RTM_Match
{
    // Fields
    private int _ExpectedPlayerCount;
    private System.Collections.Generic.List<GK_Player> _Players;
    
    // Properties
    public int ExpectedPlayerCount { get; }
    public System.Collections.Generic.List<GK_Player> Players { get; }
    
    // Methods
    public GK_RTM_Match(string matchData)
    {
        var val_6;
        this._Players = new System.Collections.Generic.List<GK_Player>();
        typeof(System.String[]).__il2cppRuntimeField_20 = "|%|";
        System.String[] val_2 = matchData.Split(separator:  null, options:  0);
        this._ExpectedPlayerCount = System.Convert.ToInt32(value:  0);
        val_6 = 0;
        goto label_11;
        label_18:
        Add(item:  val_2[0]);
        val_6 = 1;
        label_11:
        if(val_6 >= val_4.Length)
        {
                return;
        }
        
        string val_8 = SA.Common.Data.Converter.ParseArray(arrayData:  0, splitter:  val_2[1])[1];
        GK_Player val_5 = GameCenterManager.GetPlayerById(playerID:  null);
        if(this._Players != null)
        {
            goto label_18;
        }
        
        goto label_18;
    }
    public int get_ExpectedPlayerCount()
    {
        return (int)this._ExpectedPlayerCount;
    }
    public System.Collections.Generic.List<GK_Player> get_Players()
    {
        return (System.Collections.Generic.List<GK_Player>)this._Players;
    }

}
