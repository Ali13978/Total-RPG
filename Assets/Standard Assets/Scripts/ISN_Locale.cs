using UnityEngine;
public class ISN_Locale
{
    // Fields
    private string _CountryCode;
    private string _DisplayCountry;
    private string _LanguageCode;
    private string _DisplayLanguage;
    
    // Properties
    public string CountryCode { get; }
    public string DisplayCountry { get; }
    public string LanguageCode { get; }
    public string DisplayLanguage { get; }
    
    // Methods
    public ISN_Locale(string countryCode, string contryName, string languageCode, string languageName)
    {
        val_1 = new System.Object();
        this._CountryCode = countryCode;
        this._DisplayCountry = val_1;
        this._LanguageCode = languageCode;
        this._DisplayLanguage = languageName;
    }
    public string get_CountryCode()
    {
        return (string)this._CountryCode;
    }
    public string get_DisplayCountry()
    {
        return (string)this._DisplayCountry;
    }
    public string get_LanguageCode()
    {
        return (string)this._LanguageCode;
    }
    public string get_DisplayLanguage()
    {
        return (string)this._DisplayLanguage;
    }

}
