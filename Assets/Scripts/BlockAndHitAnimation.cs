using UnityEngine;
public class BlockAndHitAnimation : MonoBehaviour
{
    // Fields
    [UnityEngine.SerializeField]
    private TzarGames.Endless.PlayerCharacter _character;
    [UnityEngine.SerializeField]
    private string blockAnimName;
    [UnityEngine.SerializeField]
    private string frontHitAnimName;
    [UnityEngine.SerializeField]
    private string backHitAnimName;
    [UnityEngine.SerializeField]
    private UnityEngine.Events.UnityEvent onHitBlocked;
    private bool pendingShieldBlock;
    
    // Methods
    public BlockAndHitAnimation()
    {
        this.blockAnimName = "Block";
        this.frontHitAnimName = "Hit front";
        this.backHitAnimName = "Hit back";
    }
    private void Reset()
    {
        this._character = this.GetComponent<TzarGames.Endless.PlayerCharacter>();
    }
    private void Start()
    {
        this._character.add_OnHitBlockedByShield(value:  new System.Action<TzarGames.TzarHero.ICharacterDamageInfo>(object:  this, method:  System.Void BlockAndHitAnimation::CharacterOnOnHitBlockedByShield(TzarGames.TzarHero.ICharacterDamageInfo characterDamageInfo)));
        this._character.add_OnCharacterTakeHit(value:  new TH_Character.dlgHitEvent(object:  this, method:  System.Void BlockAndHitAnimation::CharacterOnOnCharacterTakeHit(TzarGames.TzarHero.ICharacterDamageInfo hitData)));
    }
    private void CharacterOnOnCharacterTakeHit(TzarGames.TzarHero.ICharacterDamageInfo hitData)
    {
        string val_7;
        var val_8;
        val_7 = this;
        if(this.pendingShieldBlock != false)
        {
                this.pendingShieldBlock = false;
            this.playBlockAnimation();
            return;
        }
        
        var val_7 = 0;
        val_7 = val_7 + 1;
        val_8 = hitData;
        UnityEngine.Vector3 val_3 = this._character.transform.forward;
        TzarGames.TzarHero.CharacterAnimationBase val_5 = this._character.ArmorSetPrefabInstance.CharacterAnimation;
        if((UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, rhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z})) > 0f)
        {
                val_7 = this.backHitAnimName;
            if(val_5 != null)
        {
                return;
        }
        
            return;
        }
        
        val_7 = this.frontHitAnimName;
        if(val_5 != null)
        {
                return;
        }
    
    }
    private void CharacterOnOnHitBlockedByShield(TzarGames.TzarHero.ICharacterDamageInfo characterDamageInfo)
    {
        this.pendingShieldBlock = true;
    }
    [UnityEngine.ContextMenu]
    private void playBlockAnimation()
    {
        if(this._character.ArmorSetPrefabInstance.CharacterAnimation == null)
        {
            
        }
    
    }
    private void OnDestroy()
    {
        if(0 == this._character)
        {
                return;
        }
        
        this._character.remove_OnHitBlockedByShield(value:  new System.Action<TzarGames.TzarHero.ICharacterDamageInfo>(object:  this, method:  System.Void BlockAndHitAnimation::CharacterOnOnHitBlockedByShield(TzarGames.TzarHero.ICharacterDamageInfo characterDamageInfo)));
    }

}
