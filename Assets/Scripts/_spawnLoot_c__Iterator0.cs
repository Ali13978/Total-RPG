using UnityEngine;
private sealed class CharacterLootSpawner.<spawnLoot>c__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal TzarGames.TzarHero.CharacterLootSpawner $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public CharacterLootSpawner.<spawnLoot>c__Iterator0()
    {
    
    }
    public bool MoveNext()
    {
        var val_30;
        int val_37;
        TzarGames.TzarHero.CharacterLootSpawner val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        int val_43;
        var val_44;
        int val_37 = this.$PC;
        this.$PC = 0;
        val_37 = ((val_37 == 1) ? 1 : 0) << 2;
        var val_2 = (val_37 == 0) ? 3 : (val_37);
        if(val_2 == 3)
        {
            goto label_1;
        }
        
        val_37 = 0;
        if(val_2 != 4)
        {
                return (bool)val_37;
        }
        
        val_38 = this.$this;
        goto label_7;
        label_1:
        val_38 = this;
        if(27443.OnClient == true)
        {
            goto label_28;
        }
        
        if(this.$this.spawnDelay > 0f)
        {
                val_37 = 1;
            this.$current = new UnityEngine.WaitForSeconds(seconds:  this.$this.spawnDelay);
            if(this.$disposing == true)
        {
                return (bool)val_37;
        }
        
            this.$PC = val_37;
            return (bool)val_37;
        }
        
        label_7:
        TzarGames.GameFramework.Loot[] val_7 = mem[this.$this] + 96.TemplateInstance.LootList;
        if(val_7.Length < 1)
        {
            goto label_77;
        }
        
        System.Collections.Generic.List<TzarGames.GameFramework.Loot> val_8 = new System.Collections.Generic.List<TzarGames.GameFramework.Loot>();
        val_39 = mem[this.$this] + 96.TemplateInstance.LootList;
        val_40 = 0;
        goto label_19;
        label_26:
        val_40 = 1;
        label_19:
        if(val_40 >= val_10.Length)
        {
            goto label_21;
        }
        
        if((GameUtils.RandomDrop(chanceRate:  0)) == false)
        {
            goto label_26;
        }
        
        Add(item:  val_39[1]);
        goto label_26;
        label_21:
        if(Count == 0)
        {
            goto label_28;
        }
        
        if(((mem[this.$this] + 96.TemplateInstance.MaximumLootSpawnCount) >= 1) && ((mem[this.$this] + 96.TemplateInstance.MaximumLootSpawnCount) < Count))
        {
                val_41 = null;
            if((TzarGames.TzarHero.CharacterLootSpawner.<>f__mg$cache0) == null)
        {
                TzarGames.TzarHero.CharacterLootSpawner.<>f__mg$cache0 = new System.Comparison<TzarGames.GameFramework.Loot>(object:  0, method:  public static System.Int32 TzarGames.GameFramework.Loot::CompareChanceFromMinimal(TzarGames.GameFramework.Loot x, TzarGames.GameFramework.Loot y));
            val_41 = null;
        }
        
            Sort(comparison:  TzarGames.TzarHero.CharacterLootSpawner.<>f__mg$cache0);
            RemoveRange(index:  mem[this.$this] + 96.TemplateInstance.MaximumLootSpawnCount, count:  Count - (mem[this.$this] + 96.TemplateInstance.MaximumLootSpawnCount));
        }
        
        if(0 == (mem[this.$this] + 104))
        {
            goto label_52;
        }
        
        UnityEngine.Vector3 val_26 = mem[this.$this] + 104.position;
        goto label_54;
        label_28:
        val_37 = 0;
        return (bool)val_37;
        label_52:
        UnityEngine.Vector3 val_27 = mem[this.$this] + 96.GroundPivotPosition;
        label_54:
        List.Enumerator<T> val_28 = GetEnumerator();
        label_73:
        if((0 & 1) == 0)
        {
            goto label_80;
        }
        
        System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_31 = val_30.InitializationCallback;
        TzarGames.GameFramework.GameManager val_32 = val_31.MyGameManager;
        UnityEngine.Quaternion val_33 = UnityEngine.Quaternion.identity;
        val_42 = mem[this.$this];
        if(val_42 != 0)
        {
                val_43 = mem[mem[this.$this] + 72];
            val_43 = mem[this.$this] + 72;
        }
        else
        {
                val_43 = mem[mem[this.$this] + 72];
            val_43 = mem[this.$this] + 72;
            if(mem[this.$this] != 0)
        {
                val_42 = mem[this.$this];
        }
        else
        {
                val_42 = 0;
        }
        
        }
        
        if(val_32 != null)
        {
                val_44 = null;
        }
        
        if(val_32 != null)
        {
                val_44 = null;
        }
        
        TzarGames.TzarHero.TH_Dropped val_35 = SpawnLoot(item:  val_31, position:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, rotation:  new UnityEngine.Quaternion() {x = val_33.x, y = val_33.y, z = val_33.z, w = val_33.w}, sessionID:  val_43, dropper:  31514328);
        goto label_73;
        label_80:
        val_40 = 1152921511478216336;
        val_30.Dispose();
        if(Count >= 1)
        {
                mem[this.$this] + 120.Invoke();
        }
        
        label_77:
        val_37 = 0;
        this.$PC = 0;
        return (bool)val_37;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private object System.Collections.Generic.IEnumerator<object>.get_Current()
    {
        return (object)this.$current;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.$current;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public void Dispose()
    {
        this.$disposing = true;
        this.$PC = 0;
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public void Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }

}
