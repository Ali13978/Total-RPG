using UnityEngine;
private sealed class BattleMusicMixer.<playLoop>c__Iterator1 : IEnumerator, IDisposable, IEnumerator<object>
{
    // Fields
    internal int index;
    internal UnityEngine.AudioClip[] clips;
    internal UnityEngine.AudioSource source;
    internal TzarGames.Endless.BattleMusicMixer.Track track;
    internal TzarGames.Endless.BattleMusicMixer $this;
    internal object $current;
    internal bool $disposing;
    internal int $PC;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Diagnostics.DebuggerHiddenAttribute]
    public BattleMusicMixer.<playLoop>c__Iterator1()
    {
    
    }
    public bool MoveNext()
    {
        int val_10;
        BattleMusicMixer.Track val_11;
        int val_12;
        UnityEngine.AudioSource val_13;
        int val_10 = this.$PC;
        this.$PC = 0;
        val_10 = (val_10 < 3) ? (val_10 + 3) : 0;
        if(val_10 == 3)
        {
            goto label_1;
        }
        
        if(val_10 == 4)
        {
            goto label_2;
        }
        
        val_10 = 0;
        if(val_10 != 5)
        {
                return (bool)val_10;
        }
        
        val_11 = this.track;
        goto label_4;
        label_1:
        if(this.index >= this.clips.Length)
        {
            goto label_6;
        }
        
        val_12 = this.index;
        goto label_7;
        label_2:
        val_11 = this;
        if(this.track.Paused == false)
        {
            goto label_9;
        }
        
        this.source.Pause();
        label_4:
        if(this.track.Paused != false)
        {
                this.$current = 0;
            if(this.$disposing != true)
        {
                this.$PC = 2;
        }
        
            val_10 = 1;
            return (bool)val_10;
        }
        
        this.source.UnPause();
        label_9:
        val_13 = this.source;
        if(this.$this == null)
        {
            goto label_16;
        }
        
        val_11 = this.$this.playLoop(source:  val_13, clips:  this.clips, index:  this.index + 1, track:  null);
        goto label_17;
        label_6:
        val_12 = 0;
        this.index = 0;
        label_7:
        val_13 = 0;
        val_11 = this.clips[val_13];
        this.source.clip = val_11;
        this.source.Play();
        val_10 = 1;
        this.$current = new UnityEngine.WaitForSeconds(seconds:  this.source.clip.length);
        if(this.$disposing == true)
        {
                return (bool)val_10;
        }
        
        this.$PC = val_10;
        return (bool)val_10;
        label_16:
        val_11 = 0.playLoop(source:  val_13, clips:  this.clips, index:  this.index + 1, track:  null);
        label_17:
        UnityEngine.Coroutine val_9 = this.$this.StartCoroutine(routine:  val_11);
        val_10 = 0;
        this.$PC = 0;
        return (bool)val_10;
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
