using UnityEngine;

namespace TzarGames.TzarHero
{
    public class CharacterTargetPointer : MonoBehaviour, IPoolable
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Character character;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject pointerPrefab;
        private UnityEngine.Transform pointerObject;
        
        // Methods
        public CharacterTargetPointer()
        {
        
        }
        public void OnPulledFromPool()
        {
            this.enabled = true;
            if(0 == this.pointerObject)
            {
                    return;
            }
            
            this.pointerObject.SetParent(parent:  0);
        }
        public void OnPushedToPool()
        {
            this.enabled = false;
            if(0 == this.pointerObject)
            {
                    return;
            }
            
            this.pointerObject.gameObject.SetActive(value:  false);
            this.pointerObject.SetParent(parent:  this.transform);
        }
        private void Reset()
        {
            this.character = this.GetComponent<TzarGames.TzarHero.TH_Character>();
        }
        private void Start()
        {
            UnityEngine.Transform val_2 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0).transform;
            this.pointerObject = val_2;
            UnityEngine.GameObject val_3 = val_2.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
            this.pointerObject.gameObject.SetActive(value:  false);
        }
        private void OnDestroy()
        {
            if(0 == this.pointerObject)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = this.pointerObject.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
        }
        private void Update()
        {
            if(true == 0)
            {
                    return;
            }
            
            if(4359 != 0)
            {
                    if(((4359 & 1) & 1) == 0)
            {
                goto label_6;
            }
            
            }
            
            if(0 != this.character.Target)
            {
                    TzarGames.TzarHero.TH_InteractiveObject val_5 = this.character.Target;
            }
            
            this.pointerObject.gameObject.SetActive(value:  false);
            return;
            label_6:
            this.enabled = false;
        }
    
    }

}
