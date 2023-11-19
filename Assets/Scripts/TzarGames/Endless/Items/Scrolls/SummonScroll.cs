using UnityEngine;

namespace TzarGames.Endless.Items.Scrolls
{
    public class SummonScroll : Item, IUsableByCharacter
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Character summoningCharacter;
        [UnityEngine.SerializeField]
        private float radius;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset cantBeUsedMessage;
        [UnityEngine.SerializeField]
        private float messageShowTime;
        private static TzarGames.TzarHero.TH_Character spawned;
        private static float lastMessageTime;
        
        // Methods
        public SummonScroll()
        {
            this.radius = 5f;
            this.messageShowTime = 4f;
        }
        public bool ApplyToCharacter(TzarGames.TzarHero.TH_Character character)
        {
            TzarGames.TzarHero.TH_Character val_34;
            var val_35;
            var val_36;
            TzarGames.TzarHero.TH_Character val_37;
            IntPtr val_38;
            var val_39;
            float val_40;
            float val_41;
            float val_42;
            float val_43;
            var val_44;
            var val_45;
            var val_46;
            var val_48;
            var val_51;
            var val_52;
            var val_53;
            var val_54;
            val_34 = character;
            val_35 = null;
            val_35 = null;
            if(0 == TzarGames.Endless.Items.Scrolls.SummonScroll.spawned)
            {
                goto label_5;
            }
            
            val_36 = null;
            val_36 = null;
            val_37 = TzarGames.Endless.Items.Scrolls.SummonScroll.spawned;
            if(val_37.isDead == false)
            {
                goto label_70;
            }
            
            label_5:
            if(0 == TzarGames.Endless.EndlessGameState.Instance)
            {
                goto label_12;
            }
            
            val_37 = TzarGames.Endless.EndlessGameState.Instance;
            if(val_37.IsInGameState() == false)
            {
                goto label_14;
            }
            
            label_12:
            val_38 = 1152921504719785984;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            val_39 = 0;
            label_23:
            UnityEngine.Vector3 val_9 = UnityEngine.Random.onUnitSphere;
            if(val_34 != null)
            {
                    val_37 = val_34.Pathfinder;
            }
            else
            {
                    val_37 = 0.Pathfinder;
            }
            
            UnityEngine.Vector3 val_12 = val_34.GroundPivotPosition;
            val_40 = 0f;
            val_41 = this.radius;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_40, z = val_9.z}, d:  val_41);
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            val_42 = val_14.x;
            val_43 = val_14.z;
            if(((val_37 & 1) & 1) != 0)
            {
                goto label_22;
            }
            
            val_39 = val_39 + 1;
            if(val_39 <= 6)
            {
                goto label_23;
            }
            
            goto label_70;
            label_22:
            val_44 = null;
            val_44 = null;
            if(0 != TzarGames.Endless.Items.Scrolls.SummonScroll.spawned)
            {
                    val_45 = null;
                val_45 = null;
                UnityEngine.GameObject val_17 = TzarGames.Endless.Items.Scrolls.SummonScroll.spawned.gameObject;
                UnityEngine.Object.Destroy(obj:  0);
            }
            
            UnityEngine.Vector3 val_18 = this.summoningCharacter.GetGroundPivotDisplacement();
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            val_42 = val_19.x;
            val_43 = val_19.z;
            UnityEngine.Quaternion val_20 = UnityEngine.Quaternion.identity;
            val_41 = val_20.y;
            val_40 = val_20.z;
            val_46 = null;
            val_46 = null;
            TzarGames.Endless.Items.Scrolls.SummonScroll.spawned = UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_42, y = val_19.y, z = val_43}, rotation:  new UnityEngine.Quaternion() {x = val_20.x, y = val_41, z = val_40, w = val_20.w});
            TzarGames.Endless.Items.Scrolls.SummonScroll.spawned.Level = val_34.Level;
            val_37 = TzarGames.Endless.Items.Scrolls.SummonScroll.spawned;
            val_38 = System.Void TzarGames.Endless.Items.Scrolls.SummonScroll::Spawned_OnComponentDestroy(TzarGames.GameFramework.TzarBehaviour behaviour);
            val_37.add_OnComponentDestroy(value:  new TzarGames.GameFramework.dlgTzarDestroy(object:  this, method:  val_38));
            TzarGames.TzarHero.CharacterAI val_24 = TzarGames.Endless.Items.Scrolls.SummonScroll.spawned.GetComponent<TzarGames.TzarHero.CharacterAI>();
            if(0 != val_24)
            {
                    val_24.Target = val_34;
            }
            
            if(val_34 == null)
            {
                goto label_52;
            }
            
            val_37 = 1152921504871968768;
            val_48 = null;
            val_51 = null;
            val_48 = null;
            val_51 = null;
            val_48 = null;
            goto label_58;
            label_14:
            val_52 = null;
            val_42 = UnityEngine.Time.time;
            val_52 = null;
            float val_34 = TzarGames.Endless.Items.Scrolls.SummonScroll.lastMessageTime;
            val_34 = val_42 - val_34;
            if(val_34 >= this.messageShowTime)
            {
                    val_34 = this.cantBeUsedMessage;
                if(0 != val_34)
            {
                    val_34 = UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>();
                if(0 == val_34)
            {
                    UnityEngine.Debug.LogError(message:  0);
            }
            else
            {
                    val_53 = null;
                val_42 = UnityEngine.Time.time;
                val_53 = null;
                TzarGames.Endless.Items.Scrolls.SummonScroll.lastMessageTime = val_42;
                val_34 = val_34.Alert;
                val_34.Show(message:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
            }
            
            }
            
            }
            
            label_70:
            val_54 = 0;
            return (bool)val_54;
            label_58:
            AddAlly(character:  TzarGames.Endless.Items.Scrolls.SummonScroll.spawned);
            label_52:
            val_54 = 1;
            return (bool)val_54;
        }
        private void Spawned_OnComponentDestroy(TzarGames.GameFramework.TzarBehaviour behaviour)
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if(0 != behaviour)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            TzarGames.Endless.Items.Scrolls.SummonScroll.spawned = 0;
        }
        public bool MustBeDestroyedAfterUse()
        {
            return true;
        }
        private static SummonScroll()
        {
            TzarGames.Endless.Items.Scrolls.SummonScroll.lastMessageTime = -4f;
        }
    
    }

}
