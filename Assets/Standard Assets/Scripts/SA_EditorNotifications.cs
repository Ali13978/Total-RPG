using UnityEngine;
public class SA_EditorNotifications
{
    // Fields
    private static SA_Notifications_EditorUIController _EditorUI;
    
    // Properties
    private static SA_Notifications_EditorUIController EditorUI { get; }
    
    // Methods
    public SA_EditorNotifications()
    {
    
    }
    public static void ShowNotification(string title, string message, SA_EditorNotificationType type)
    {
        if(SA_EditorTesting.IsInsideEditor == false)
        {
                return;
        }
        
        SA_EditorNotifications.EditorUI.ShowNotification(title:  message, message:  type, type:  W3);
    }
    private static SA_Notifications_EditorUIController get_EditorUI()
    {
        null = null;
        return (SA_Notifications_EditorUIController)SA_EditorNotifications._EditorUI;
    }
    private static SA_EditorNotifications()
    {
    
    }

}
