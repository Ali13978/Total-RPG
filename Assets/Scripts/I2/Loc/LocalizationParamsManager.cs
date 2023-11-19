using UnityEngine;

namespace I2.Loc
{
    public class LocalizationParamsManager : MonoBehaviour, ILocalizationParamsManager
    {
        // Fields
        [UnityEngine.SerializeField]
        public System.Collections.Generic.List<I2.Loc.LocalizationParamsManager.ParamValue> _Params;
        
        // Methods
        public LocalizationParamsManager()
        {
            this._Params = new System.Collections.Generic.List<ParamValue>();
        }
        public string GetParameterValue(string ParamName)
        {
            var val_5;
            System.Collections.Generic.List<ParamValue> val_6;
            var val_7;
            val_6 = ParamName;
            if(this._Params == null)
            {
                goto label_2;
            }
            
            int val_1 = this._Params.Count;
            if(val_1 < 1)
            {
                goto label_2;
            }
            
            val_5 = 0;
            label_7:
            ParamValue val_2 = this._Params.Item[0];
            if((System.String.op_Equality(a:  0, b:  val_2.Name)) == true)
            {
                goto label_6;
            }
            
            val_5 = val_5 + 1;
            if(val_5 < val_1)
            {
                goto label_7;
            }
            
            label_2:
            val_7 = 0;
            return (string)val_7;
            label_6:
            val_6 = this._Params;
            ParamValue val_4 = val_6.Item[0];
            val_7 = val_4.Value;
            return (string)val_7;
        }
        public void SetParameterValue(string ParamName, string ParamValue, bool localize = True)
        {
            System.Collections.Generic.List<ParamValue> val_5;
            System.Collections.Generic.List<ParamValue> val_6;
            val_5 = this._Params;
            int val_1 = val_5.Count;
            val_6 = this._Params;
            if(val_1 < 1)
            {
                goto label_2;
            }
            
            val_5 = 0;
            label_7:
            ParamValue val_2 = val_6.Item[0];
            val_6 = val_2.Name;
            if((System.String.op_Equality(a:  0, b:  val_6)) == true)
            {
                goto label_6;
            }
            
            val_6 = this._Params;
            val_5 = val_5 + 1;
            if(val_5 < val_1)
            {
                goto label_7;
            }
            
            label_2:
            val_6.Add(item:  new ParamValue() {Name = ParamName, Value = ParamValue});
            goto label_9;
            label_6:
            ParamValue val_4 = this._Params.Item[0];
            this._Params.set_Item(index:  0, value:  new ParamValue() {Name = val_4.Name, Value = ParamValue});
            label_9:
            if(localize == false)
            {
                    return;
            }
            
            this.OnLocalize();
        }
        public void OnLocalize()
        {
            I2.Loc.Localize val_1 = this.GetComponent<I2.Loc.Localize>();
            if(0 == val_1)
            {
                    return;
            }
            
            val_1.OnLocalize(Force:  true);
        }
        public virtual void OnEnable()
        {
            this.DoAutoRegister();
        }
        public void DoAutoRegister()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((I2.Loc.LocalizationManager.ParamManagers.Contains(item:  this)) != false)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            I2.Loc.LocalizationManager.ParamManagers.Add(item:  this);
            I2.Loc.LocalizationManager.LocalizeAll(Force:  I2.Loc.LocalizationManager.ParamManagers);
        }
        public void OnDisable()
        {
            null = null;
            bool val_1 = I2.Loc.LocalizationManager.ParamManagers.Remove(item:  this);
        }
    
    }

}
