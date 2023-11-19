using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class WaveSpawnerUI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Text alertText;
        [UnityEngine.SerializeField]
        [UnityEngine.MultilineAttribute]
        private string waveStartFirstMessage;
        [UnityEngine.SerializeField]
        [UnityEngine.MultilineAttribute]
        private string waveStartMessage;
        [UnityEngine.SerializeField]
        private float alertMessageTime;
        private TzarGames.GameFramework.WaveSpawner spawner;
        
        // Methods
        public WaveSpawnerUI()
        {
            this.alertMessageTime = 5f;
        }
        private void OnEnable()
        {
            UnityEngine.UI.Extensions.BoundTooltipItem val_1 = UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>();
            this.spawner = val_1;
            val_1.OnWaveStarted.AddListener(call:  new UnityEngine.Events.UnityAction<System.UInt32>(object:  this, method:  System.Void TzarGames.Endless.UI.WaveSpawnerUI::onWaveStarted(uint waveNumber)));
            this.alertText.gameObject.SetActive(value:  false);
        }
        private void OnDisable()
        {
            this.spawner.OnWaveStarted.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.UInt32>(object:  this, method:  System.Void TzarGames.Endless.UI.WaveSpawnerUI::onWaveStarted(uint waveNumber)));
        }
        private void onWaveStarted(uint waveNumber)
        {
            string val_5;
            var val_7;
            if(waveNumber != 0)
            {
                    val_5 = this.waveStartMessage;
                val_7 = null;
                uint val_1 = waveNumber + 1;
            }
            else
            {
                    val_5 = this.waveStartFirstMessage;
                val_7 = null;
            }
            
            string val_2 = System.String.Format(format:  0, arg0:  val_5);
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.showAlertRoutine());
        }
        private void showAlert()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.showAlertRoutine());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator showAlertRoutine()
        {
            typeof(WaveSpawnerUI.<showAlertRoutine>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
