using UnityEngine;
private class RootSkill.RootInfluence : TimeInfluence
{
    // Fields
    private TzarGames.TzarHero.Influences.DamageInfluence damage;
    private TzarGames.TzarHero.Influences.WalkingSpeedInfluence walking;
    public UnityEngine.GameObject ObjectToDestroy;
    
    // Methods
    public RootSkill.RootInfluence(float damagePerSecond, float damageInterval, TzarGames.TzarHero.TH_Character instigator, float effectTime)
    {
        this.damage = new TzarGames.TzarHero.Influences.DamageInfluence(damagePerSecond:  damagePerSecond, damageInterval:  damageInterval, instigator:  instigator);
        this.walking = new TzarGames.TzarHero.Influences.WalkingSpeedInfluence(instigator:  instigator, modificatorValue:  0f, modificatorOperator:  2);
    }
    public override void OnAddedToCharacter(TzarGames.TzarHero.TH_Character character)
    {
        this.OnAddedToCharacter(character:  character);
        this.damage.OnAddedToCharacter(character:  character);
        if(this.walking == null)
        {
            
        }
    
    }
    public override void OnRemovedFromCharacter(TzarGames.TzarHero.TH_Character character)
    {
        this.OnRemovedFromCharacter(character:  character);
        this.damage.OnRemovedFromCharacter(character:  character);
        if(0 == this.ObjectToDestroy)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  0);
    }
    public override void Update(float timeDelta)
    {
        this.Update(timeDelta:  timeDelta);
        this.damage.Update(timeDelta:  timeDelta);
        this.walking.Update(timeDelta:  timeDelta);
    }

}
