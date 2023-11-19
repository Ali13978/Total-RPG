using UnityEngine;
[System.Runtime.CompilerServices.ExtensionAttribute]
public static class SA_UnityExtensions
{
    // Fields
    private static readonly System.Text.RegularExpressions.Regex _regex;
    
    // Methods
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static void MoveTo(UnityEngine.GameObject go, UnityEngine.Vector3 position, float time, SA.Common.Animation.EaseType easeType = 21, System.Action OnCompleteAction)
    {
        SA.Common.Animation.ValuesTween val_1 = easeType.AddComponent<SA.Common.Animation.ValuesTween>();
        val_1.DestoryGameObjectOnComplete = false;
        UnityEngine.Vector3 val_3 = easeType.transform.position;
        if(val_1 != null)
        {
                val_1.VectorTo(from:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, to:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, time:  time, easeType:  OnCompleteAction);
        }
        else
        {
                val_1.VectorTo(from:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, to:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, time:  time, easeType:  OnCompleteAction);
        }
        
        val_1.add_OnComplete(value:  X3);
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static void ScaleTo(UnityEngine.GameObject go, UnityEngine.Vector3 scale, float time, SA.Common.Animation.EaseType easeType = 21, System.Action OnCompleteAction)
    {
        SA.Common.Animation.ValuesTween val_1 = easeType.AddComponent<SA.Common.Animation.ValuesTween>();
        val_1.DestoryGameObjectOnComplete = false;
        UnityEngine.Vector3 val_3 = easeType.transform.localScale;
        if(val_1 != null)
        {
                val_1.ScaleTo(from:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, to:  new UnityEngine.Vector3() {x = scale.x, y = scale.y, z = scale.z}, time:  time, easeType:  OnCompleteAction);
        }
        else
        {
                val_1.ScaleTo(from:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, to:  new UnityEngine.Vector3() {x = scale.x, y = scale.y, z = scale.z}, time:  time, easeType:  OnCompleteAction);
        }
        
        val_1.add_OnComplete(value:  X3);
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static UnityEngine.Bounds GetRealBounds(UnityEngine.GameObject go)
    {
        float val_8;
        var val_12;
        var val_13;
        UnityEngine.Bounds val_0;
        if(X1 != 0)
        {
                val_12 = X1.GetComponentsInChildren<UnityEngine.Renderer>(includeInactive:  false);
        }
        else
        {
                val_12 = 0.GetComponentsInChildren<UnityEngine.Renderer>(includeInactive:  false);
        }
        
        UnityEngine.Vector3 val_4 = X1.transform.position;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        val_13 = 0;
        goto label_6;
        label_15:
        val_13 = 1;
        label_6:
        if(val_13 >= val_2.Length)
        {
            goto label_8;
        }
        
        T val_12 = val_12[1];
        UnityEngine.Bounds val_6 = val_12.bounds;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_8, y = val_4.y, z = val_4.z}, rhs:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z})) == false)
        {
            goto label_15;
        }
        
        UnityEngine.Bounds val_11 = val_12.bounds;
        goto label_15;
        label_8:
        val_0.m_Extents.y = 0f;
        val_0.m_Extents.z = 0f;
        val_0.m_Center.x = 0f;
        val_0.m_Center.y = 0f;
        val_0.m_Center.z = 0f;
        val_0.m_Extents.x = 0f;
        return val_0;
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static UnityEngine.Bounds GetRealBounds(UnityEngine.Component go)
    {
        float val_8;
        var val_12;
        var val_13;
        UnityEngine.Bounds val_0;
        if(X1 != 0)
        {
                val_12 = X1.GetComponentsInChildren<UnityEngine.Renderer>(includeInactive:  false);
        }
        else
        {
                val_12 = 0.GetComponentsInChildren<UnityEngine.Renderer>(includeInactive:  false);
        }
        
        UnityEngine.Vector3 val_4 = X1.transform.position;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        val_13 = 0;
        goto label_6;
        label_15:
        val_13 = 1;
        label_6:
        if(val_13 >= val_2.Length)
        {
            goto label_8;
        }
        
        T val_12 = val_12[1];
        UnityEngine.Bounds val_6 = val_12.bounds;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_8, y = val_4.y, z = val_4.z}, rhs:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z})) == false)
        {
            goto label_15;
        }
        
        UnityEngine.Bounds val_11 = val_12.bounds;
        goto label_15;
        label_8:
        val_0.m_Extents.y = 0f;
        val_0.m_Extents.z = 0f;
        val_0.m_Center.x = 0f;
        val_0.m_Center.y = 0f;
        val_0.m_Center.z = 0f;
        val_0.m_Extents.x = 0f;
        return val_0;
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static UnityEngine.Bounds GetRendererBounds(UnityEngine.GameObject go)
    {
        return SA_UnityExtensions.CalculateBounds(obj:  null);
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static UnityEngine.Vector3 GetVertex(UnityEngine.GameObject go, VertexX x, VertexY y, VertexZ z)
    {
        UnityEngine.Bounds val_1 = SA_UnityExtensions.GetRendererBounds(go:  null);
        UnityEngine.Vector3 val_2 = SA_UnityExtensions.GetVertex(bounds:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3(), m_Extents = new UnityEngine.Vector3()}, x:  0, y:  y, z:  z);
        return new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static void Reset(UnityEngine.GameObject go)
    {
        UnityEngine.Transform val_2;
        UnityEngine.Transform val_1 = X1.transform;
        val_2 = null;
        SA_UnityExtensions.Reset(t:  val_2);
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static bool IsVisibleFrom(UnityEngine.Renderer renderer, UnityEngine.Camera camera)
    {
        UnityEngine.Plane[] val_1 = UnityEngine.GeometryUtility.CalculateFrustumPlanes(camera:  0);
        UnityEngine.Bounds val_2 = camera.bounds;
        return (bool)UnityEngine.GeometryUtility.TestPlanesAABB(planes:  0, bounds:  new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = val_1, y = val_1, z = val_1}, m_Extents = new UnityEngine.Vector3() {x = val_1, y = val_1, z = val_1}});
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static void Reset(UnityEngine.Transform t)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
        X1.localScale = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        X1.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
        X1.localRotation = new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w};
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static UnityEngine.Bounds GetRendererBounds(UnityEngine.Transform t)
    {
        UnityEngine.GameObject val_2;
        UnityEngine.GameObject val_1 = X1.gameObject;
        val_2 = null;
        return SA_UnityExtensions.GetRendererBounds(go:  val_2);
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static UnityEngine.Vector3 GetVertex(UnityEngine.Transform t, VertexX x, VertexY y, VertexZ z)
    {
        return SA_UnityExtensions.GetVertex(go:  null = null, x:  x.gameObject, y:  y, z:  z);
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static UnityEngine.Transform Clear(UnityEngine.Transform transform)
    {
        var val_6;
        if(X1.childCount == 0)
        {
                return (UnityEngine.Transform)X1;
        }
        
        val_6 = 0;
        goto label_4;
        label_17:
        val_6 = 1;
        label_4:
        if(val_6 >= val_2.Length)
        {
                return (UnityEngine.Transform)X1;
        }
        
        T val_6 = X1.GetComponentsInChildren<UnityEngine.Transform>()[1];
        if((0 == val_6) || (0 == val_6))
        {
            goto label_17;
        }
        
        UnityEngine.GameObject val_5 = val_6.gameObject;
        UnityEngine.Object.DestroyImmediate(obj:  0);
        goto label_17;
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static UnityEngine.Vector3 GetVertex(UnityEngine.Bounds bounds, VertexX x, VertexY y, VertexZ z)
    {
        float val_1;
        float val_2;
        float val_3;
        val_1 = V0.16B;
        val_2 = V1.16B;
        val_3 = V2.16B;
        if(y == 0)
        {
            goto label_0;
        }
        
        if(y != 1)
        {
            goto label_2;
        }
        
        val_1 = val_1 - S0;
        goto label_2;
        label_0:
        val_1 = val_1 + S0;
        label_2:
        if(z == 0)
        {
            goto label_3;
        }
        
        if(z != 1)
        {
            goto label_5;
        }
        
        val_2 = val_2 - S1;
        goto label_5;
        label_3:
        val_2 = val_2 + S1;
        label_5:
        if(W4 != 0)
        {
                if(W4 != 1)
        {
                return new UnityEngine.Vector3() {x = val_1, y = val_2, z = val_3};
        }
        
            val_3 = val_3 - S2;
            return new UnityEngine.Vector3() {x = val_1, y = val_2, z = val_3};
        }
        
        val_3 = val_3 + S2;
        return new UnityEngine.Vector3() {x = val_1, y = val_2, z = val_3};
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static void SetAlpha(UnityEngine.Material material, float value)
    {
        if((X1.HasProperty(propertyName:  "_Color")) == false)
        {
                return;
        }
        
        UnityEngine.Color val_2 = X1.color;
        X1.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = value};
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static UnityEngine.Sprite ToSprite(UnityEngine.Texture2D texture)
    {
        CinemachineFreeLook.Orbit val_1 = new CinemachineFreeLook.Orbit(h:  0.5f, r:  0.5f);
        return (UnityEngine.Sprite)UnityEngine.Sprite.Create(texture:  0, rect:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, pivot:  new UnityEngine.Vector2() {x = val_1.m_Height, y = val_1.m_Radius});
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static UnityEngine.Texture2D Rotate(UnityEngine.Texture2D texture, float angle)
    {
        return SA.Common.Util.IconManager.Rotate(tex:  null, angle:  angle);
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static UnityEngine.Vector3 Reset(UnityEngine.Vector3 vec)
    {
        return UnityEngine.Vector3.zero;
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static UnityEngine.Vector3 ResetXCoord(UnityEngine.Vector3 vec)
    {
        return new UnityEngine.Vector3() {x = 0f, y = vec.y, z = vec.z};
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static UnityEngine.Vector3 ResetYCoord(UnityEngine.Vector3 vec)
    {
        return new UnityEngine.Vector3() {x = vec.x, y = 0f, z = vec.z};
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static UnityEngine.Vector3 ResetZCoord(UnityEngine.Vector3 vec)
    {
        return new UnityEngine.Vector3() {x = vec.x, y = vec.y, z = 0f};
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static UnityEngine.Vector3 Average(UnityEngine.Vector3[] f)
    {
        var val_6;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        val_6 = 0;
        var val_8 = 0;
        goto label_3;
        label_13:
        val_6 = 1;
        label_3:
        var val_6 = X1 + 24;
        val_6 = val_6 - 1;
        if(val_6 >= val_6)
        {
            goto label_5;
        }
        
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        long val_7 = 1;
        val_7 = X1 + (val_7 * 12);
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = (1 * 12) + X1 + 32, y = (1 * 12) + X1 + 32 + 4, z = (1 * 12) + X1 + 32 + 8}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z})) == false)
        {
            goto label_13;
        }
        
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = (1 * 12) + X1 + 32, y = (1 * 12) + X1 + 32 + 4, z = (1 * 12) + X1 + 32 + 8});
        val_8 = val_8 + 1;
        goto label_13;
        label_5:
        float val_9 = (float)(val_8 < 1) ? 1 : (val_8);
        val_1.x = val_1.x / val_9;
        val_1.y = val_1.y / val_9;
        val_9 = val_1.z / val_9;
        return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_9};
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static string GetLast(string source, int count)
    {
        var val_5;
        if(count.Length <= W2)
        {
                return (string)count;
        }
        
        if(count != 0)
        {
                val_5 = count.Length;
            return count.Substring(startIndex:  val_5 - W2);
        }
        
        val_5 = 0.Length;
        return count.Substring(startIndex:  val_5 - W2);
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static string GetFirst(string source, int count)
    {
        if(count.Length <= W2)
        {
                return (string)count;
        }
        
        if(count != 0)
        {
                return count.Substring(startIndex:  0, length:  W2);
        }
        
        return count.Substring(startIndex:  0, length:  W2);
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static void CopyToClipboard(string source)
    {
        UnityEngine.TextEditor val_1 = new UnityEngine.TextEditor();
        if(null != 0)
        {
                text = X1;
            SelectAll();
        }
        else
        {
                text = X1;
            SelectAll();
        }
        
        Copy();
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static System.Uri CovertToURI(string source)
    {
        return (System.Uri)new System.Uri(uriString:  X1);
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static System.Collections.Generic.Dictionary<string, string> ParseQueryString(System.Uri uri)
    {
        var val_11;
        var val_12;
        val_11 = null;
        val_11 = null;
        val_12 = SA_UnityExtensions._regex.Match(input:  X1.PathAndQuery);
        goto label_5;
        label_16:
        val_12 = val_12.NextMatch();
        label_5:
        if(val_12.Success == false)
        {
                return (System.Collections.Generic.Dictionary<System.String, System.String>)new System.Collections.Generic.Dictionary<System.String, System.String>();
        }
        
        Add(key:  val_12.Item[1].Value, value:  val_12.Item[2].Value);
        if(val_12 != null)
        {
            goto label_16;
        }
        
        goto label_16;
    }
    public static UnityEngine.Bounds CalculateBounds(UnityEngine.GameObject obj)
    {
        float val_8;
        float val_9;
        var val_13;
        var val_14;
        var val_15;
        UnityEngine.Bounds val_0;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        if(X1 != 0)
        {
                val_13 = X1.GetComponentsInChildren<UnityEngine.Renderer>();
        }
        else
        {
                val_13 = 0.GetComponentsInChildren<UnityEngine.Renderer>();
        }
        
        UnityEngine.Renderer val_5 = X1.GetComponent<UnityEngine.Renderer>();
        if(0 != val_5)
        {
                UnityEngine.Bounds val_7 = val_5.bounds;
            val_14 = 1;
        }
        else
        {
                val_14 = 0;
        }
        
        val_15 = 0;
        goto label_10;
        label_17:
        val_15 = 1;
        val_14 = 1;
        label_10:
        if(val_15 >= val_4.Length)
        {
            goto label_12;
        }
        
        T val_13 = val_13[1];
        if(((val_14 & 1) & 1) == 0)
        {
            goto label_15;
        }
        
        UnityEngine.Bounds val_11 = val_13.bounds;
        goto label_17;
        label_15:
        UnityEngine.Bounds val_12 = val_13.bounds;
        goto label_17;
        label_12:
        val_0.m_Extents.y = val_8;
        val_0.m_Center.x = val_9;
        return val_0;
    }
    private static SA_UnityExtensions()
    {
        SA_UnityExtensions._regex = new System.Text.RegularExpressions.Regex(pattern:  "[?|&]([\\w\\.]+)=([^?|^&]+)");
    }

}
