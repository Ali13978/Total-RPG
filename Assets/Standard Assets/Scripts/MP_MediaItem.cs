using UnityEngine;
public class MP_MediaItem
{
    // Fields
    private string _Id;
    private string _Title;
    private string _Artist;
    private string _AlbumTitle;
    private string _AlbumArtist;
    private string _Genre;
    private string _PlaybackDuration;
    private string _Composer;
    
    // Properties
    public string Id { get; }
    public string Title { get; }
    public string Artist { get; }
    public string AlbumTitle { get; }
    public string AlbumArtist { get; }
    public string PlaybackDuration { get; }
    public string Genre { get; }
    public string Composer { get; }
    
    // Methods
    public MP_MediaItem(string id, string title, string artist, string albumTitle, string albumArtist, string genre, string playbackDuration, string composer)
    {
        val_1 = new System.Object();
        this._Id = id;
        this._Title = val_1;
        this._Artist = artist;
        this._AlbumTitle = albumTitle;
        this._AlbumArtist = albumArtist;
        this._Genre = genre;
        this._PlaybackDuration = playbackDuration;
        this._Composer = composer;
    }
    public string get_Id()
    {
        return (string)this._Id;
    }
    public string get_Title()
    {
        return (string)this._Title;
    }
    public string get_Artist()
    {
        return (string)this._Artist;
    }
    public string get_AlbumTitle()
    {
        return (string)this._AlbumTitle;
    }
    public string get_AlbumArtist()
    {
        return (string)this._AlbumArtist;
    }
    public string get_PlaybackDuration()
    {
        return (string)this._PlaybackDuration;
    }
    public string get_Genre()
    {
        return (string)this._Genre;
    }
    public string get_Composer()
    {
        return (string)this._Composer;
    }

}
