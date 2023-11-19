using UnityEngine;

namespace SA.IOSDeploy
{
    [Serializable]
    public class Variable
    {
        // Fields
        public bool IsOpen;
        public bool IsListOpen;
        public string Name;
        public SA.IOSDeploy.PlistValueTypes Type;
        public string StringValue;
        public int IntegerValue;
        public float FloatValue;
        public bool BooleanValue;
        public System.Collections.Generic.List<string> ChildrensIds;
        
        // Methods
        public Variable()
        {
            var val_2;
            this.IsOpen = true;
            this.IsListOpen = true;
            val_2 = null;
            val_2 = null;
            this.Name = System.String.Empty;
            this.BooleanValue = true;
            this.StringValue = System.String.Empty;
            this.ChildrensIds = new System.Collections.Generic.List<System.String>();
        }
        public void AddChild(SA.IOSDeploy.Variable v)
        {
            var val_27;
            System.Collections.Generic.List<System.String> val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            val_27 = 1152921504838103040;
            val_28 = this.Type.Equals(obj:  5);
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            mem2[0] = null;
            if(val_28 == false)
            {
                goto label_3;
            }
            
            List.Enumerator<T> val_3 = this.ChildrensIds.GetEnumerator();
            val_27 = 1152921509370135312;
            label_10:
            if((0 & 1) == 0)
            {
                goto label_5;
            }
            
            if((val_7.Name.Equals(value:  v.Name)) == false)
            {
                goto label_10;
            }
            
            val_28 = this.ChildrensIds;
            SA.IOSDeploy.ISD_Settings.Instance.RemoveVariable(v:  SA.IOSDeploy.ISD_Settings.Instance.getVariableByKey(uniqueIdKey:  5.InitializationCallback), ListWithThisVariable:  val_28);
            label_5:
            val_29 = 0;
            val_30 = 1;
            goto label_12;
            label_3:
            val_28 = this.Type.Equals(obj:  4);
            val_31 = this.Type;
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y});
            mem2[0] = null;
            if(val_28 == false)
            {
                goto label_33;
            }
            
            val_28 = v.Type.Equals(obj:  0);
            val_31 = v.Type;
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y});
            mem2[0] = null;
            if(val_28 == false)
            {
                goto label_33;
            }
            
            List.Enumerator<T> val_15 = this.ChildrensIds.GetEnumerator();
            label_28:
            if((0 & 1) == 0)
            {
                goto label_21;
            }
            
            UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = val_14.y});
            mem2[0] = null;
            if(((val_18.Type.Equals(obj:  0)) == false) || ((v.StringValue.Equals(value:  val_18.StringValue)) == false))
            {
                goto label_28;
            }
            
            val_28 = this.ChildrensIds;
            SA.IOSDeploy.ISD_Settings.Instance.RemoveVariable(v:  SA.IOSDeploy.ISD_Settings.Instance.getVariableByKey(uniqueIdKey:  0.InitializationCallback), ListWithThisVariable:  val_28);
            label_21:
            val_29 = 0;
            val_30 = 1;
            goto label_30;
            label_12:
            val_32 = public System.Void List.Enumerator<System.String>::Dispose();
            goto label_31;
            label_30:
            val_32 = public System.Void List.Enumerator<System.String>::Dispose();
            label_31:
            0.Dispose();
            if((( & 1) == 0) && ( != 0))
            {
                    val_31 = ;
            }
            
            label_33:
            int val_24 = SA.Common.Util.IdFactory.NextId;
            SA.IOSDeploy.ISD_Settings.Instance.AddVariableToDictionary(uniqueIdKey:  val_24, var:  v);
            this.ChildrensIds.Add(item:  val_24);
        }
    
    }

}
