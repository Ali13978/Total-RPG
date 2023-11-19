using UnityEngine;
public class SceneManagerHelper
{
    // Properties
    public static string ActiveSceneName { get; }
    public static int ActiveSceneBuildIndex { get; }
    
    // Methods
    public SceneManagerHelper()
    {
    
    }
    public static string get_ActiveSceneName()
    {
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        return (string)val_1.m_Handle.name;
    }
    public static int get_ActiveSceneBuildIndex()
    {
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        return (int)val_1.m_Handle.buildIndex;
    }

}
