using UnityEngine;
[System.Runtime.CompilerServices.ExtensionAttribute]
public static class WindowsRuntimeExtension
{
    // Methods
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static System.Type GetBaseType(System.Type type)
    {
        if(X1 == 0)
        {
            
        }
    
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static System.Reflection.Assembly GetAssembly(System.Type type)
    {
        if(X1 == 0)
        {
            
        }
    
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static bool IsValueType(System.Type type)
    {
        if(X1 != 0)
        {
                return X1.IsValueType;
        }
        
        return X1.IsValueType;
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static bool IsGenericType(System.Type type)
    {
        if(X1 == 0)
        {
            
        }
    
    }
    private static bool ParametersMatch(System.Reflection.ParameterInfo[] parameters, System.Type[] args)
    {
        var val_2 = 0;
        if(args.Length != (X2 + 24))
        {
                return (bool)val_2;
        }
        
        var val_3 = 0;
        label_9:
        if(val_3 >= args.Length)
        {
            goto label_4;
        }
        
        var val_1 = X2 + 0;
        val_3 = val_3 + 1;
        if(args[0] == ((X2 + 0) + 32))
        {
            goto label_9;
        }
        
        val_2 = 0;
        return (bool)val_2;
        label_4:
        val_2 = 1;
        return (bool)val_2;
    }
    public static bool MatchBindingFlags(bool isPublic, bool isPrivate, bool isStatic, System.Reflection.BindingFlags bindingAttr, bool baseClass)
    {
        var val_2;
        if(isPrivate == false)
        {
            goto label_0;
        }
        
        if((baseClass & 16) != 0)
        {
            goto label_1;
        }
        
        return false;
        label_0:
        if((baseClass & 32) == 0)
        {
                return false;
        }
        
        label_1:
        if((bindingAttr & 1) == 0)
        {
            goto label_4;
        }
        
        if((baseClass & 8) == 0)
        {
                return false;
        }
        
        if((W5 & 1) == 0)
        {
            goto label_10;
        }
        
        val_2 = 0;
        if((baseClass & 64) == 0)
        {
                return (bool)val_2;
        }
        
        if(isStatic == false)
        {
            goto label_10;
        }
        
        return (bool)val_2;
        label_4:
        if((baseClass & 4) == 0)
        {
                return false;
        }
        
        label_10:
        val_2 = 1;
        return (bool)val_2;
    }

}
