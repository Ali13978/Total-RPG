using UnityEngine;
private sealed class GoogleTranslation.<Translate>c__AnonStorey1
{
    // Fields
    internal System.Action<string, string> OnTranslationReady;
    internal string text;
    internal System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> queries;
    internal string LanguageCodeTo;
    
    // Methods
    public GoogleTranslation.<Translate>c__AnonStorey1()
    {
    
    }
    internal void <>m__0(System.Collections.Generic.Dictionary<string, I2.Loc.TranslationQuery> results, string error)
    {
        System.Collections.Generic.Dictionary<System.String, I2.Loc.TranslationQuery> val_4;
        System.Action<System.String, System.String> val_5;
        string val_6;
        string val_7;
        var val_8;
        val_4 = results;
        if(((System.String.IsNullOrEmpty(value:  0)) != false) && (val_4.Count != 0))
        {
                val_4 = this.queries;
            val_5 = I2.Loc.GoogleTranslation.RebuildTranslation(text:  0, dict:  this.text, LanguageCodeTo:  val_4);
            val_6 = 0;
            val_7 = val_5;
            val_8 = public System.Void System.Action<System.String, System.String>::Invoke(System.String arg1, System.String arg2);
        }
        else
        {
                val_5 = this.OnTranslationReady;
            val_7 = 0;
            val_6 = error;
            val_8 = public System.Void System.Action<System.String, System.String>::Invoke(System.String arg1, System.String arg2);
        }
        
        val_5.Invoke(arg1:  val_7, arg2:  val_6);
    }

}
