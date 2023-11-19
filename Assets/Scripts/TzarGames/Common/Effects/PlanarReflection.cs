using UnityEngine;

namespace TzarGames.Common.Effects
{
    [UnityEngine.ExecuteInEditMode]
    public class PlanarReflection : MonoBehaviour
    {
        // Fields
        public bool disablePixelLights;
        public int textureSize;
        public float clipPlaneOffset;
        public UnityEngine.LayerMask reflectLayers;
        private System.Collections.Generic.Dictionary<UnityEngine.Camera, UnityEngine.Camera> m_ReflectionCameras;
        private UnityEngine.RenderTexture m_ReflectionTexture;
        private int m_OldReflectionTextureSize;
        private static bool s_Inside;
        
        // Methods
        public PlanarReflection()
        {
            this.disablePixelLights = true;
            this.textureSize = 256;
            this.clipPlaneOffset = 3.306083E-41f;
            UnityEngine.LayerMask val_1 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
            this.reflectLayers = val_1;
            this.m_ReflectionCameras = new System.Collections.Generic.Dictionary<UnityEngine.Camera, UnityEngine.Camera>();
        }
        public void OnWillRenderObject()
        {
            float val_26;
            float val_27;
            float val_28;
            float val_29;
            float val_31;
            float val_32;
            float val_33;
            float val_34;
            float val_37;
            float val_38;
            float val_39;
            float val_40;
            float val_44;
            float val_45;
            float val_46;
            float val_47;
            float val_53;
            float val_54;
            float val_55;
            float val_56;
            UnityEngine.Camera val_70;
            UnityEngine.Camera val_11 = 0;
            if(this.enabled == false)
            {
                    return;
            }
            
            UnityEngine.Renderer val_2 = this.GetComponent<UnityEngine.Renderer>();
            val_70 = 1152921504721543168;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            UnityEngine.Material val_5 = this.GetComponent<UnityEngine.Renderer>().sharedMaterial;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            if((this.GetComponent<UnityEngine.Renderer>().enabled) == false)
            {
                    return;
            }
            
            val_70 = UnityEngine.Camera.current;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            if(TzarGames.Common.Effects.PlanarReflection.s_Inside == true)
            {
                    return;
            }
            
            TzarGames.Common.Effects.PlanarReflection.s_Inside = true;
            this.CreateReflectionObjects(currentCamera:  val_70, reflectionCamera: out  val_11);
            UnityEngine.Vector3 val_13 = this.transform.position;
            UnityEngine.Vector3 val_15 = this.transform.up;
            int val_16 = UnityEngine.QualitySettings.pixelLightCount;
            if(this.disablePixelLights != false)
            {
                    UnityEngine.QualitySettings.pixelLightCount = 0;
            }
            
            this.UpdateCameraModes(src:  val_70, dest:  val_11);
            float val_69 = val_13.x;
            val_69 = (-(UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, rhs:  new UnityEngine.Vector3() {x = val_69, y = val_13.y, z = val_13.z}))) - this.clipPlaneOffset;
            UnityEngine.Matrix4x4 val_18 = UnityEngine.Matrix4x4.zero;
            TzarGames.Common.Effects.PlanarReflection.CalculateReflectionMatrix(reflectionMat: ref  new UnityEngine.Matrix4x4(), plane:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            UnityEngine.Vector3 val_24 = val_70.transform.position;
            UnityEngine.Matrix4x4 val_25 = val_70.worldToCameraMatrix;
            UnityEngine.Matrix4x4 val_30 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4(), rhs:  new UnityEngine.Matrix4x4() {m00 = val_28, m10 = val_28, m20 = val_28, m30 = val_28, m01 = val_29, m11 = val_29, m21 = val_29, m31 = val_29, m02 = val_26, m12 = val_26, m22 = val_26, m32 = val_26, m03 = val_27, m13 = val_27, m23 = val_27, m33 = val_27});
            val_11.worldToCameraMatrix = new UnityEngine.Matrix4x4() {m00 = val_33, m10 = val_33, m20 = val_33, m30 = val_33, m01 = val_34, m11 = val_34, m21 = val_34, m31 = val_34, m02 = val_31, m12 = val_31, m22 = val_31, m32 = val_31, m03 = val_32, m13 = val_32, m23 = val_32, m33 = val_32};
            UnityEngine.Vector4 val_35 = this.CameraSpacePlane(cam:  val_11, pos:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, normal:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, sideSign:  1f);
            UnityEngine.Matrix4x4 val_36 = val_70.CalculateObliqueMatrix(clipPlane:  new UnityEngine.Vector4() {x = val_35.x, y = val_35.y, z = val_35.z, w = val_35.w});
            val_11.projectionMatrix = new UnityEngine.Matrix4x4() {m00 = val_39, m10 = val_39, m20 = val_39, m30 = val_39, m01 = val_40, m11 = val_40, m21 = val_40, m31 = val_40, m02 = val_37, m12 = val_37, m22 = val_37, m32 = val_37, m03 = val_38, m13 = val_38, m23 = val_38, m33 = val_38};
            if(val_70 != null)
            {
                    UnityEngine.Matrix4x4 val_41 = val_70.projectionMatrix;
            }
            else
            {
                    UnityEngine.Matrix4x4 val_42 = 0.projectionMatrix;
            }
            
            UnityEngine.Matrix4x4 val_43 = val_70.worldToCameraMatrix;
            UnityEngine.Matrix4x4 val_52 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4(), rhs:  new UnityEngine.Matrix4x4() {m00 = val_46, m10 = val_46, m20 = val_46, m30 = val_46, m01 = val_47, m11 = val_47, m21 = val_47, m31 = val_47, m02 = val_44, m12 = val_44, m22 = val_44, m32 = val_44, m03 = val_45, m13 = val_45, m23 = val_45, m33 = val_45});
            val_11.cullingMatrix = new UnityEngine.Matrix4x4() {m00 = val_55, m10 = val_55, m20 = val_55, m30 = val_55, m01 = val_56, m11 = val_56, m21 = val_56, m31 = val_56, m02 = val_53, m12 = val_53, m22 = val_53, m32 = val_53, m03 = val_54, m13 = val_54, m23 = val_54, m33 = val_54};
            val_11.cullingMask = this.reflectLayers.value & 4294967279;
            val_11.targetTexture = this.m_ReflectionTexture;
            bool val_59 = UnityEngine.GL.invertCulling;
            var val_60 = (~val_59) & 1;
            UnityEngine.GL.invertCulling = false;
            val_11.transform.position = new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z};
            UnityEngine.Vector3 val_63 = val_70.transform.eulerAngles;
            val_11.transform.eulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_11.Render();
            val_11.transform.position = new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z};
            bool val_66 = val_59;
            UnityEngine.GL.invertCulling = false;
            val_70 = this.m_ReflectionTexture;
            this.GetComponent<UnityEngine.Renderer>().sharedMaterial.SetTexture(name:  "_ReflectionTex", value:  val_70);
            if(this.disablePixelLights != false)
            {
                    UnityEngine.QualitySettings.pixelLightCount = 0;
            }
            
            TzarGames.Common.Effects.PlanarReflection.s_Inside = false;
        }
        private void OnDisable()
        {
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    UnityEngine.Object.DestroyImmediate(obj:  0);
                this.m_ReflectionTexture = 0;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_2 = this.m_ReflectionCameras.GetEnumerator();
            label_11:
            if((0 & 1) == 0)
            {
                goto label_15;
            }
            
            UnityEngine.Playables.PlayableHandle val_3 = 0.GetHandle();
            UnityEngine.GameObject val_4 = val_3.m_Handle.gameObject;
            UnityEngine.Object.DestroyImmediate(obj:  0);
            goto label_11;
            label_15:
            0.Dispose();
            this.m_ReflectionCameras.Clear();
        }
        private void UpdateCameraModes(UnityEngine.Camera src, UnityEngine.Camera dest)
        {
            if(0 == dest)
            {
                    return;
            }
            
            dest.clearFlags = src.clearFlags;
            UnityEngine.Color val_4 = src.backgroundColor;
            dest.backgroundColor = new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a};
            if(src.clearFlags != 1)
            {
                goto label_22;
            }
            
            UnityEngine.Skybox val_6 = src.GetComponent<UnityEngine.Skybox>();
            UnityEngine.Skybox val_7 = dest.GetComponent<UnityEngine.Skybox>();
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                goto label_18;
            }
            
            1152921504721543168 = val_6.material;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                goto label_18;
            }
            
            val_7.enabled = true;
            val_7.material = val_6.material;
            goto label_22;
            label_18:
            val_7.enabled = false;
            label_22:
            dest.farClipPlane = src.farClipPlane;
            dest.nearClipPlane = src.nearClipPlane;
            dest.orthographic = src.orthographic;
            dest.fieldOfView = src.fieldOfView;
            dest.aspect = src.aspect;
            dest.orthographicSize = src.orthographicSize;
        }
        private void CreateReflectionObjects(UnityEngine.Camera currentCamera, out UnityEngine.Camera reflectionCamera)
        {
            System.Collections.Generic.Dictionary<UnityEngine.Camera, UnityEngine.Camera> val_25;
            string val_26;
            val_25 = this;
            reflectionCamera = 0;
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    if(this.m_OldReflectionTextureSize == this.textureSize)
            {
                goto label_4;
            }
            
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    UnityEngine.Object.DestroyImmediate(obj:  0);
            }
            
            this.m_ReflectionTexture = new UnityEngine.RenderTexture(width:  this.textureSize, height:  this.textureSize, depth:  16, format:  2);
            int val_4 = this.GetInstanceID();
            val_26 = 0 + "__PlanarReflection";
            name = val_26;
            this.m_ReflectionTexture.isPowerOfTwo = true;
            this.m_ReflectionTexture.hideFlags = 52;
            this.m_OldReflectionTextureSize = this.textureSize;
            label_4:
            bool val_7 = this.m_ReflectionCameras.TryGetValue(key:  currentCamera, value: out  UnityEngine.Camera val_6 = reflectionCamera);
            if((UnityEngine.Object.op_Implicit(exists:  0)) == true)
            {
                    return;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Refl Camera id";
            typeof(System.Object[]).__il2cppRuntimeField_28 = this.GetInstanceID();
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " for ";
            typeof(System.Object[]).__il2cppRuntimeField_38 = currentCamera.GetInstanceID();
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            typeof(System.Type[]).__il2cppRuntimeField_20 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            typeof(System.Type[]).__il2cppRuntimeField_28 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            UnityEngine.GameObject val_15 = new UnityEngine.GameObject(name:  +0, components:  null);
            UnityEngine.Camera val_16 = GetComponent<UnityEngine.Camera>();
            reflectionCamera = val_16;
            val_16.enabled = false;
            UnityEngine.Vector3 val_19 = this.transform.position;
            reflectionCamera.transform.position = new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z};
            UnityEngine.Quaternion val_22 = this.transform.rotation;
            reflectionCamera.transform.rotation = new UnityEngine.Quaternion() {x = val_22.x, y = val_22.y, z = val_22.z, w = val_22.w};
            val_26 = reflectionCamera.gameObject;
            UnityEngine.FlareLayer val_24 = val_26.AddComponent<UnityEngine.FlareLayer>();
            hideFlags = 61;
            reflectionCamera.allowHDR = true;
            val_25 = this.m_ReflectionCameras;
            val_25.set_Item(key:  currentCamera, value:  reflectionCamera);
        }
        private UnityEngine.Vector4 CameraSpacePlane(UnityEngine.Camera cam, UnityEngine.Vector3 pos, UnityEngine.Vector3 normal, float sideSign)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z}, d:  this.clipPlaneOffset);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Matrix4x4 val_3 = cam.worldToCameraMatrix;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z}, d:  sideSign);
            float val_9 = UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rhs:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            return new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f};
        }
        private static void CalculateReflectionMatrix(ref UnityEngine.Matrix4x4 reflectionMat, UnityEngine.Vector4 plane)
        {
            float val_1 = plane.x * (-2f);
            plane.x = val_1 * plane.x;
            plane.x = plane.x + 1f;
            mem2[0] = plane.x;
            val_1 = plane.x * (-2f);
            plane.x = val_1 * plane.x;
            mem2[0] = plane.x;
            val_1 = plane.x * (-2f);
            plane.x = val_1 * plane.x;
            mem2[0] = plane.x;
            val_1 = plane.x * (-2f);
            plane.x = val_1 * plane.x;
            mem2[0] = plane.x;
            val_1 = plane.x * (-2f);
            plane.x = val_1 * plane.x;
            mem2[0] = plane.x;
            val_1 = plane.x + plane.x;
            plane.x = val_1 * plane.x;
            plane.x = 1f - plane.x;
            mem2[0] = plane.x;
            val_1 = plane.x * (-2f);
            plane.x = val_1 * plane.x;
            mem2[0] = plane.x;
            val_1 = plane.x * (-2f);
            plane.x = val_1 * plane.x;
            mem2[0] = plane.x;
            val_1 = plane.x * (-2f);
            plane.x = val_1 * plane.x;
            mem2[0] = plane.x;
            val_1 = plane.x * (-2f);
            plane.x = val_1 * plane.x;
            mem2[0] = plane.x;
            val_1 = plane.x + plane.x;
            plane.x = val_1 * plane.x;
            plane.x = 1f - plane.x;
            mem2[0] = plane.x;
            val_1 = plane.x * (-2f);
            plane.x = val_1 * plane.x;
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = plane.x;
            mem2[0] = 1065353216;
        }
    
    }

}
