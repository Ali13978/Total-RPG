using UnityEngine;
public class SupportLogger : MonoBehaviour
{
    // Fields
    public bool LogTrafficStats;
    
    // Methods
    public SupportLogger()
    {
        this.LogTrafficStats = true;
    }
    public void Start()
    {
        if(0 != (UnityEngine.GameObject.Find(name:  0)))
        {
                return;
        }
        
        UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  "PunSupportLogger");
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
        this = AddComponent<SupportLogging>();
        val_4.LogTrafficStats = this.LogTrafficStats;
    }

}
