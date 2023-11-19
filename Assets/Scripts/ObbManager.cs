using UnityEngine;
public class ObbManager : MonoBehaviour
{
    // Fields
    [UnityEngine.SerializeField]
    private TzarGames.Common.UI.TextUI statusText;
    [UnityEngine.SerializeField]
    private string nextSceneName;
    [UnityEngine.SerializeField]
    private string privacySceneName;
    private bool pendingDownload;
    private string expPath;
    private string mainPath;
    [UnityEngine.SerializeField]
    private TzarGames.Common.LocalizedStringAsset initText;
    [UnityEngine.SerializeField]
    private TzarGames.Common.LocalizedStringAsset externalNotAvailable;
    [UnityEngine.SerializeField]
    private TzarGames.Common.LocalizedStringAsset loadingExtensionFile;
    [UnityEngine.SerializeField]
    private TzarGames.Common.LocalizedStringAsset preparingResources;
    private IGooglePlayObbDownloader downloader;
    
    // Methods
    public ObbManager()
    {
    
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.IEnumerator Start()
    {
        typeof(ObbManager.<Start>c__Iterator0).__il2cppRuntimeField_10 = this;
        return (System.Collections.IEnumerator)new System.Object();
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private System.Collections.IEnumerator loadNextScene()
    {
        typeof(ObbManager.<loadNextScene>c__Iterator1).__il2cppRuntimeField_10 = this;
        return (System.Collections.IEnumerator)new System.Object();
    }
    private void Update()
    {
        var val_4;
        if(this.pendingDownload == false)
        {
                return;
        }
        
        var val_4 = 0;
        val_4 = val_4 + 1;
        val_4 = this.downloader;
        this.mainPath = this.downloader;
        if(this.downloader == null)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  0);
        this.pendingDownload = false;
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.loadNextScene());
    }

}
