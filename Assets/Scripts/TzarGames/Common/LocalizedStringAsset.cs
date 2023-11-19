using UnityEngine;

namespace TzarGames.Common
{
    public class LocalizedStringAsset : DatabaseRecord
    {
        // Fields
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private int _id;
        [UnityEngine.MultilineAttribute]
        private string text;
        [UnityEngine.SerializeField]
        private I2.Loc.LanguageSource languageSource;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.Common.LocalizedStringAsset> OnUpdated;
        
        // Properties
        public I2.Loc.LanguageSource LanguageSource { get; set; }
        public string Text { get; set; }
        public string Key { get; set; }
        public override int Id { get; set; }
        
        // Methods
        public LocalizedStringAsset()
        {
        
        }
        public void add_OnUpdated(System.Action<TzarGames.Common.LocalizedStringAsset> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnUpdated);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511128434992 != this.OnUpdated);
        
        }
        public void remove_OnUpdated(System.Action<TzarGames.Common.LocalizedStringAsset> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnUpdated);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511128571568 != this.OnUpdated);
        
        }
        public I2.Loc.LanguageSource get_LanguageSource()
        {
            return (I2.Loc.LanguageSource)this.languageSource;
        }
        public void set_LanguageSource(I2.Loc.LanguageSource value)
        {
            this.languageSource = value;
        }
        public static string op_Implicit(TzarGames.Common.LocalizedStringAsset text)
        {
            var val_3 = 0;
            if(0 == X1)
            {
                    return (string)val_3;
            }
            
            val_3 = mem[X1 + 32];
            val_3 = X1 + 32;
            return (string)val_3;
        }
        public string get_Text()
        {
            return (string)this.text;
        }
        public void set_Text(string value)
        {
            this.text = value;
        }
        public string get_Key()
        {
            return this.name;
        }
        public void set_Key(string value)
        {
            this.name = value;
        }
        public override int get_Id()
        {
            return (int)this._id;
        }
        public override void set_Id(int value)
        {
            this._id = value;
        }
        private void OnEnable()
        {
            this.updateLocalization(fireEvent:  false);
        }
        private void updateLocalization(bool fireEvent)
        {
            I2.Loc.LanguageSource val_4 = this.languageSource;
            if(0 == val_4)
            {
                    return;
            }
            
            val_4 = this.languageSource;
            this.text = val_4.GetTranslation(term:  this.name, overrideLanguage:  0, overrideSpecialization:  0, skipDisabled:  false, allowCategoryMistmatch:  false);
            if(fireEvent == false)
            {
                    return;
            }
            
            if(this.OnUpdated == null)
            {
                    return;
            }
            
            this.OnUpdated.Invoke(obj:  this);
        }
        private void OnDestroy()
        {
            if(0 == this.languageSource)
            {
                    return;
            }
            
            this.languageSource.RemoveTerm(term:  this.name);
            string val_3 = this.name;
            string val_4 = 0 + "Term removed from the language source: "("Term removed from the language source: ");
            UnityEngine.Debug.Log(message:  0);
        }
        [TzarGames.Common.ConsoleCommand]
        public static void SetLanguage(string language)
        {
            var val_2;
            I2.Loc.LocalizationManager.CurrentLanguage = 0;
            val_2 = 0;
            goto label_3;
            label_8:
            updateLocalization(fireEvent:  true);
            val_2 = 1;
            label_3:
            if(val_2 >= val_1.Length)
            {
                    return;
            }
            
            if((UnityEngine.Resources.FindObjectsOfTypeAll<TzarGames.Common.LocalizedStringAsset>()[1]) != 0)
            {
                goto label_8;
            }
            
            goto label_8;
        }
    
    }

}
