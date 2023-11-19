using UnityEngine;

namespace TzarGames.Endless
{
    public class StagePathHelper : MonoBehaviour, IPoolable
    {
        // Fields
        private TzarGames.Endless.Way currentWay;
        private int chainNum;
        private UnityEngine.Transform currentTarget;
        private TzarGames.Endless.WayChainObjectInfo currentChainObject;
        private bool lastTarget;
        private bool initialized;
        
        // Properties
        public UnityEngine.Transform CurrentTarget { get; }
        
        // Methods
        public StagePathHelper()
        {
        
        }
        public UnityEngine.Transform get_CurrentTarget()
        {
            return (UnityEngine.Transform)this.currentTarget;
        }
        private void init()
        {
            if(this.initialized == true)
            {
                    return;
            }
            
            this.initialized = true;
            if(0 != TzarGames.GameFramework.GameManager.Instance)
            {
                    TzarGames.GameFramework.GameManager val_4 = TzarGames.GameFramework.GameManager.Instance;
            }
            
            this.enabled = false;
        }
        private void Start()
        {
            this.init();
        }
        private UnityEngine.Transform getTargetFromChain(TzarGames.Endless.WayChainObjectInfo chainInfo)
        {
            TzarGames.Endless.ChainObjectType val_3 = chainInfo.ObjectType;
            val_3 = (val_3 < 3) ? (val_3 + 3) : 0;
            if(val_3 > 5)
            {
                    return 23900;
            }
            
            var val_4 = 25486556 + (chainInfo.ObjectType < 0x3 ? (chainInfo.ObjectType + 3) : 0) << 2;
            val_4 = val_4 + 25486556;
            goto (25486556 + (chainInfo.ObjectType < 0x3 ? (chainInfo.ObjectType + 3) : 0) << 2 + 25486556);
        }
        private void Update()
        {
            var val_9;
            TzarGames.Endless.WayChainObjectInfo val_10;
            var val_11;
            val_9 = this;
            val_10 = this.currentChainObject;
            if(val_10 == null)
            {
                    return;
            }
            
            if(this.lastTarget == true)
            {
                    return;
            }
            
            TzarGames.Endless.ChainObjectType val_9 = this.currentChainObject.ObjectType;
            val_9 = (val_9 < 3) ? (val_9 + 5) : 0;
            if(val_9 == 5)
            {
                goto label_3;
            }
            
            if(val_9 == 6)
            {
                goto label_4;
            }
            
            if(val_9 != 0)
            {
                    return;
            }
            
            System.ArgumentOutOfRangeException val_2 = null;
            val_9 = val_2;
            val_2 = new System.ArgumentOutOfRangeException();
            val_10 = 1152921510859753808;
            label_3:
            val_11 = public System.Void TeleportSkillAI.<updateFunc>c__Iterator0::Reset();
            val_11 = 0;
            if(val_11.IsBlocked == true)
            {
                    return;
            }
            
            goto label_10;
            label_4:
            if(0.IsSpawning != false)
            {
                    if(0 != this.currentTarget)
            {
                    this.currentTarget = 0;
            }
            
            }
            
            if(0.IsSpawningFinished == false)
            {
                    return;
            }
            
            label_10:
            this.switchToNextChainObject();
        }
        private void switchToNextChainObject()
        {
            int val_1 = this.chainNum + 1;
            this.chainNum = val_1;
            if(val_1 >= (this.currentWay.Chain.Count - 1))
            {
                    this.lastTarget = true;
            }
            
            TzarGames.Endless.WayChainObjectInfo val_6 = this.currentWay.Chain.Item[this.chainNum];
            this.currentChainObject = val_6;
            this.currentTarget = val_6.getTargetFromChain(chainInfo:  val_6);
        }
        public void OnPushedToPool()
        {
            this.enabled = false;
            this.currentWay = 0;
            this.chainNum = 0;
            this.lastTarget = false;
            this.initialized = false;
            this.currentTarget = 0;
            this.currentChainObject = 0;
        }
        public void OnPulledFromPool()
        {
            this.init();
        }
    
    }

}
