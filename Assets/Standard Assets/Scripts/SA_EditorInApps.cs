using UnityEngine;
public class SA_EditorInApps
{
    // Fields
    private static SA_InApps_EditorUIController _EditorUI;
    
    // Properties
    private static SA_InApps_EditorUIController EditorUI { get; }
    
    // Methods
    public SA_EditorInApps()
    {
    
    }
    public static void ShowInAppPopup(string title, string describtion, string price, System.Action<bool> OnComplete)
    {
        SA_EditorInApps.EditorUI.ShowInAppPopup(title:  describtion, describtion:  price, price:  OnComplete, OnComplete:  X4);
    }
    private static SA_InApps_EditorUIController get_EditorUI()
    {
        null = null;
        return (SA_InApps_EditorUIController)SA_EditorInApps._EditorUI;
    }
    private static SA_EditorInApps()
    {
    
    }

}
