using UnityEngine;
private class CharacterAI.BaseState : StateMachine.State
{
    // Properties
    public TzarGames.TzarHero.CharacterAI AI { get; }
    
    // Methods
    public CharacterAI.BaseState()
    {
    
    }
    public TzarGames.TzarHero.CharacterAI get_AI()
    {
        if(this.Owner == null)
        {
                return (TzarGames.TzarHero.CharacterAI);
        }
        
        0 = 0;
        return (TzarGames.TzarHero.CharacterAI);
    }
    protected static System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> getEnemiesInRadius(TzarGames.TzarHero.TH_Character character, float radius)
    {
        var val_13;
        int val_14;
        System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> val_1 = X1.GetOtherCharactersInRadius(radius:  radius);
        val_13 = 0;
        if(val_1 == null)
        {
                return (System.Collections.Generic.List<TzarGames.TzarHero.TH_Character>)val_13;
        }
        
        val_14 = 1152921510548278032;
        if(val_1.Count == 0)
        {
            goto label_3;
        }
        
        val_14 = val_1.Count - 1;
        if((val_14 & 2147483648) != 0)
        {
            goto label_4;
        }
        
        label_13:
        TzarGames.TzarHero.TH_Character val_4 = val_1.Item[val_14];
        if(val_4.isDead != true)
        {
                if((X1.TemplateInstance.Group.IsFriendly(group:  val_4.TemplateInstance.Group)) == false)
        {
            goto label_12;
        }
        
        }
        
        val_1.RemoveAt(index:  val_14);
        label_12:
        val_14 = val_14 - 1;
        if((val_14 & 2147483648) == 0)
        {
            goto label_13;
        }
        
        label_4:
        val_13 = val_1;
        return (System.Collections.Generic.List<TzarGames.TzarHero.TH_Character>)val_13;
        label_3:
        val_13 = 0;
        return (System.Collections.Generic.List<TzarGames.TzarHero.TH_Character>)val_13;
    }

}
