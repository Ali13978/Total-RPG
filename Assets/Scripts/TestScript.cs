using UnityEngine;
public class TestScript : MonoBehaviour
{
    // Fields
    public string testString;
    public UnityEngine.GameObject someGameObject;
    public string someGameObject_id;
    public TestClass testClass;
    public TestClass[] testClassArray;
    [UnityEngine.UI.Extensions.DontSaveField]
    public UnityEngine.Transform TransformThatWontBeSaved;
    
    // Methods
    public TestScript()
    {
        this.testString = "Hello";
        this.testClass = new TestClass();
        this.testClassArray = null;
    }
    public void OnSerialize()
    {
        UnityEngine.GameObject val_9 = this;
        if(0 == this.someGameObject)
        {
            goto label_7;
        }
        
        UnityEngine.UI.Extensions.ObjectIdentifier val_2 = this.someGameObject.GetComponent<UnityEngine.UI.Extensions.ObjectIdentifier>();
        if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
        {
            goto label_7;
        }
        
        UnityEngine.UI.Extensions.ObjectIdentifier val_4 = this.someGameObject.GetComponent<UnityEngine.UI.Extensions.ObjectIdentifier>();
        this.someGameObject_id = val_4.id;
        goto label_10;
        label_7:
        this.someGameObject_id = 0;
        label_10:
        if(this.testClassArray == null)
        {
                return;
        }
        
        if(this.testClassArray.Length < 1)
        {
                return;
        }
        
        label_29:
        TestClass val_10 = this.testClassArray[0];
        val_9 = this.testClassArray[0x0][0].go;
        if(0 == val_9)
        {
            goto label_22;
        }
        
        val_9 = this.testClassArray[0x0][0].go.GetComponent<UnityEngine.UI.Extensions.ObjectIdentifier>();
        if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
        {
            goto label_22;
        }
        
        UnityEngine.UI.Extensions.ObjectIdentifier val_8 = this.testClassArray[0x0][0].go.GetComponent<UnityEngine.UI.Extensions.ObjectIdentifier>();
        val_9 = val_8.id;
        this.testClassArray[0x0][0].go_id = val_9;
        goto label_27;
        label_22:
        this.testClassArray[0x0][0].go_id = 0;
        label_27:
        if((0 + 1) < this.testClassArray.Length)
        {
            goto label_29;
        }
    
    }
    public void OnDeserialize()
    {
        string val_15;
        var val_16;
        var val_17;
        System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object[] val_2 = UnityEngine.Object.FindObjectsOfType(type:  0);
        val_15 = this.someGameObject_id;
        if((System.String.IsNullOrEmpty(value:  0)) == true)
        {
            goto label_10;
        }
        
        val_16 = 0;
        goto label_8;
        label_19:
        val_16 = 1;
        label_8:
        if(val_16 >= val_2.Length)
        {
            goto label_10;
        }
        
        val_15 = val_2[1];
        if(((System.String.IsNullOrEmpty(value:  0)) == true) || ((System.String.op_Equality(a:  0, b:  X23)) == false))
        {
            goto label_19;
        }
        
        this.someGameObject = val_15.gameObject;
        label_10:
        if(this.testClassArray == null)
        {
                return;
        }
        
        if(this.testClassArray.Length < 1)
        {
                return;
        }
        
        label_43:
        val_16 = 0;
        TestClass val_16 = this.testClassArray[val_16];
        if((System.String.IsNullOrEmpty(value:  0)) == true)
        {
            goto label_30;
        }
        
        val_17 = 0;
        goto label_28;
        label_40:
        val_17 = 1;
        label_28:
        if(val_17 >= val_2.Length)
        {
            goto label_30;
        }
        
        if(((System.String.IsNullOrEmpty(value:  0)) == true) || ((System.String.op_Equality(a:  0, b:  val_15)) == false))
        {
            goto label_40;
        }
        
        this.testClassArray[0x0][0].go = val_2[1].gameObject;
        label_30:
        if((val_16 + 1) < this.testClassArray.Length)
        {
            goto label_43;
        }
    
    }

}
