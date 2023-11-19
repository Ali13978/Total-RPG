using UnityEngine;
private class AddInsectSpikeInfluence.InsectSpikeInfluence : TimeInfluence
{
    // Fields
    private TzarGames.TzarHero.Influences.WalkingSpeedInfluence walkingSpeedInfluence;
    
    // Methods
    public AddInsectSpikeInfluence.InsectSpikeInfluence(float speedMultiplier, TzarGames.TzarHero.TH_Character instigator, float effectTime)
    {
        this.walkingSpeedInfluence = new TzarGames.TzarHero.Influences.WalkingSpeedInfluence(instigator:  instigator, modificatorValue:  speedMultiplier, modificatorOperator:  2);
    }
    public override void OnAddedToCharacter(TzarGames.TzarHero.TH_Character character)
    {
        this.OnAddedToCharacter(character:  character);
        if(this.walkingSpeedInfluence == null)
        {
            
        }
    
    }
    public override void OnRemovedFromCharacter(TzarGames.TzarHero.TH_Character character)
    {
        this.OnRemovedFromCharacter(character:  character);
        if(this.walkingSpeedInfluence == null)
        {
            
        }
    
    }
    public override void Update(float timeDelta)
    {
        this.Update(timeDelta:  timeDelta);
        this.walkingSpeedInfluence.Update(timeDelta:  timeDelta);
    }

}
