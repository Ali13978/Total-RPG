using UnityEngine;
public class DebugDraw
{
    // Fields
    private static UnityEngine.Material material;
    private static DebugDraw.MeshCreator creator;
    private static UnityEngine.Mesh solidSphere;
    private static UnityEngine.Mesh solidCube;
    
    // Methods
    private static DebugDraw()
    {
        DebugDraw.material = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  0));
        DebugDraw.creator = new System.Object();
        DebugDraw.solidSphere = CreateSphere(subdivisions:  3);
        DebugDraw.solidCube = CreateCube(subdivisions:  0);
    }
    public DebugDraw()
    {
    
    }
    public static void DrawSphere(UnityEngine.Vector3 position, float radius, UnityEngine.Color color)
    {
        UnityEngine.Material val_7;
        var val_10;
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.identity;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
        float val_10 = 0.5f;
        val_10 = radius * val_10;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(d:  val_10, a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        UnityEngine.Matrix4x4 val_4 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, q:  new UnityEngine.Quaternion() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_1.w}, s:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.z});
        UnityEngine.MaterialPropertyBlock val_9 = new UnityEngine.MaterialPropertyBlock();
        SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a});
        val_10 = null;
        val_10 = null;
        UnityEngine.Graphics.DrawMesh(mesh:  0, matrix:  new UnityEngine.Matrix4x4() {m00 = DebugDraw.solidSphere, m10 = DebugDraw.solidSphere, m20 = DebugDraw.solidSphere, m30 = DebugDraw.solidSphere, m01 = DebugDraw.solidSphere, m11 = DebugDraw.solidSphere, m21 = DebugDraw.solidSphere, m31 = DebugDraw.solidSphere, m02 = DebugDraw.solidSphere, m12 = DebugDraw.solidSphere, m22 = DebugDraw.solidSphere, m32 = DebugDraw.solidSphere, m03 = DebugDraw.solidSphere, m13 = DebugDraw.solidSphere, m23 = DebugDraw.solidSphere, m33 = DebugDraw.solidSphere}, material:  val_7, layer:  DebugDraw.material, camera:  0, submeshIndex:  0, properties:  0);
    }
    public static void DrawCube(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, float size, UnityEngine.Color color)
    {
        float val_3;
        float val_4;
        UnityEngine.Material val_8;
        var val_11;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(d:  size, a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        UnityEngine.Matrix4x4 val_5 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, q:  new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w}, s:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.z});
        UnityEngine.MaterialPropertyBlock val_10 = new UnityEngine.MaterialPropertyBlock();
        SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = color.r, g = val_4, b = color.g, a = val_3});
        val_11 = null;
        val_11 = null;
        UnityEngine.Graphics.DrawMesh(mesh:  0, matrix:  new UnityEngine.Matrix4x4() {m00 = DebugDraw.solidCube, m10 = DebugDraw.solidCube, m20 = DebugDraw.solidCube, m30 = DebugDraw.solidCube, m01 = DebugDraw.solidCube, m11 = DebugDraw.solidCube, m21 = DebugDraw.solidCube, m31 = DebugDraw.solidCube, m02 = DebugDraw.solidCube, m12 = DebugDraw.solidCube, m22 = DebugDraw.solidCube, m32 = DebugDraw.solidCube, m03 = DebugDraw.solidCube, m13 = DebugDraw.solidCube, m23 = DebugDraw.solidCube, m33 = DebugDraw.solidCube}, material:  val_8, layer:  DebugDraw.material, camera:  0, submeshIndex:  0, properties:  0);
    }

}
