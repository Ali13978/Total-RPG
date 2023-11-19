using UnityEngine;

namespace I2.Loc
{
    [Serializable]
    public class TermData
    {
        // Fields
        public string Term;
        public I2.Loc.eTermType TermType;
        public string Description;
        public string[] Languages;
        public byte[] Flags;
        [UnityEngine.SerializeField]
        private string[] Languages_Touch;
        
        // Methods
        public TermData()
        {
            null = null;
            this.Term = System.String.Empty;
            this.Languages = null;
            this.Flags = null;
        }
        public string GetTranslation(int idx, string specialization, bool editMode = False)
        {
            var val_4;
            var val_5;
            string val_4 = this.Languages[(long)idx];
            if(val_4 != null)
            {
                    val_4 = I2.Loc.SpecializationManager.GetSpecializedText(text:  null, specialization:  val_4);
                if(editMode == true)
            {
                    return (string)val_4;
            }
            
                val_5 = null;
                val_5 = null;
                string val_3 = val_4.Replace(oldValue:  "[i2nt]", newValue:  System.String.Empty);
                if(val_3 != null)
            {
                    return val_3.Replace(oldValue:  "[/i2nt]", newValue:  System.String.Empty);
            }
            
                return val_3.Replace(oldValue:  "[/i2nt]", newValue:  System.String.Empty);
            }
            
            val_4 = 0;
            return (string)val_4;
        }
        public void SetTranslation(int idx, string translation, string specialization)
        {
            mem2[0] = I2.Loc.SpecializationManager.SetSpecializedText(text:  null, newText:  this.Languages[(long)idx], specialization:  translation);
        }
        public void RemoveSpecialization(string specialization)
        {
            goto label_0;
            label_2:
            this.RemoveSpecialization(idx:  0, specialization:  specialization);
            0 = 1;
            label_0:
            if(0 < this.Languages.Length)
            {
                goto label_2;
            }
        
        }
        public void RemoveSpecialization(int idx, string specialization)
        {
            System.String[] val_8;
            string val_9;
            val_8 = this;
            val_9 = 1152921504608284672;
            string val_8 = this.Languages[(long)idx];
            if((System.String.op_Equality(a:  0, b:  specialization)) == true)
            {
                    return;
            }
            
            val_9 = 0 + "[i2s_" + specialization;
            if((val_8.Contains(value:  val_9)) == false)
            {
                    return;
            }
            
            val_8 = this.Languages;
            val_8[(long)idx] = I2.Loc.SpecializationManager.SetSpecializedText(specializations:  I2.Loc.SpecializationManager.GetSpecializations(text:  null, buffer:  val_8).Remove(key:  specialization));
        }
        public bool IsAutoTranslated(int idx, bool IsTouch)
        {
            return (bool)(uint)(this.Flags[(long)idx] >> 1) & 1;
        }
        public void Validate()
        {
            System.String[] val_8;
            var val_9;
            int val_1 = UnityEngine.Mathf.Max(a:  0, b:  this.Languages.Length);
            if(this.Languages.Length != val_1)
            {
                    System.Array.Resize<System.String>(array: ref  0, newSize:  -881134024);
            }
            
            if(this.Flags.Length != val_1)
            {
                    System.Array.Resize<System.Byte>(array: ref  0, newSize:  -881134016);
            }
            
            val_8 = this.Languages_Touch;
            if(val_8 == null)
            {
                    return;
            }
            
            val_9 = 0;
            goto label_10;
            label_33:
            val_8 = this.Languages_Touch;
            val_9 = 1;
            label_10:
            if(val_9 >= (UnityEngine.Mathf.Min(a:  0, b:  this.Languages_Touch.Length)))
            {
                goto label_14;
            }
            
            string val_8 = this.Languages[1];
            if((System.String.IsNullOrEmpty(value:  0)) == false)
            {
                goto label_33;
            }
            
            string val_9 = this.Languages_Touch[1];
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_33;
            }
            
            this.Languages[1] = this.Languages_Touch[1];
            this.Languages_Touch[1] = 0;
            goto label_33;
            label_14:
            this.Languages_Touch = 0;
        }
        public bool IsTerm(string name, bool allowCategoryMistmatch)
        {
            string val_3 = this.Term;
            if(allowCategoryMistmatch != false)
            {
                    val_3 = I2.Loc.LanguageSource.GetKeyFromFullTerm(FullTerm:  0, OnlyMainCategory:  val_3 = this.Term);
                return System.String.op_Equality(a:  0, b:  name);
            }
            
            return System.String.op_Equality(a:  0, b:  name);
        }
        public bool HasSpecializations()
        {
            var val_4;
            var val_5;
            val_4 = 0;
            goto label_1;
            label_12:
            val_4 = 1;
            label_1:
            if(val_4 >= this.Languages.Length)
            {
                goto label_3;
            }
            
            string val_4 = this.Languages[1];
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_12;
            }
            
            this.Languages[1] = this.Languages[1].Contains(value:  "[i2s_");
            if(this.Languages[1] == false)
            {
                goto label_12;
            }
            
            val_5 = 1;
            return (bool)val_5;
            label_3:
            val_5 = 0;
            return (bool)val_5;
        }
        public System.Collections.Generic.List<string> GetAllSpecializations()
        {
            var val_2;
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            val_2 = 0;
            goto label_1;
            label_8:
            I2.Loc.SpecializationManager.AppendSpecializations(text:  val_1 = new System.Collections.Generic.List<System.String>(), list:  X21);
            val_2 = 1;
            label_1:
            if(val_2 >= this.Languages.Length)
            {
                    return val_1;
            }
            
            string val_2 = this.Languages[1];
            goto label_8;
        }
    
    }

}
