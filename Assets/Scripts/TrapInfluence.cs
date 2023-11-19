using UnityEngine;
private class Trap.TrapInfluence : TimeInfluence
{
    // Fields
    private TzarGames.TzarHero.Influences.WalkingSpeedInfluence walking;
    
    // Methods
    public Trap.TrapInfluence(TzarGames.TzarHero.TH_Character instigator, float effectTime)
    {
        this.walking = new TzarGames.TzarHero.Influences.WalkingSpeedInfluence(instigator:  instigator, modificatorValue:  0f, modificatorOperator:  2);
    }
    public override void OnAddedToCharacter(TzarGames.TzarHero.TH_Character character)
    {
        this.OnAddedToCharacter(character:  character);
        character.AddInfluence(influence:  this.walking);
    }
    public override void OnRemovedFromCharacter(TzarGames.TzarHero.TH_Character character)
    {
        this.OnRemovedFromCharacter(character:  character);
        character.RemoveInfluence(influence:  this.walking);
    }
    public override void Update(float timeDelta)
    {
        this.Update(timeDelta:  timeDelta);
        this.walking.Update(timeDelta:  timeDelta);
    }

}
