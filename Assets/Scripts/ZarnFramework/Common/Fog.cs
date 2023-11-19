using UnityEngine;

namespace ZarnFramework.Common
{
    [UnityEngine.ExecuteInEditMode]
    [UnityEngine.ImageEffectAllowedInSceneView]
    public class Fog : MonoBehaviour
    {
        // Fields
        public ZarnFramework.Common.FogSettings[] Settings;
        public UnityEngine.Shader FogShader;
        public UnityEngine.Transform sun;
        public float SunShaftsExposure;
        public float SunShaftsWeight;
        public float SunShaftDensity;
        public float SunShaftDecay;
        public bool GaussianBlur;
        public float SunShaftsBlur;
        [UnityEngine.RangeAttribute]
        public int SunShaftDepthTextureDivider;
        private UnityEngine.Camera _camera;
        private UnityEngine.Material fogMaterial;
        private UnityEngine.Transform cameraTransform;
        
        // Methods
        public Fog()
        {
            this.GaussianBlur = true;
            this.SunShaftsExposure = ;
            this.SunShaftsWeight = ;
            this.SunShaftDensity = 1f;
            this.SunShaftDecay = 1f;
            this.SunShaftsBlur = 0.25f;
            this.SunShaftDepthTextureDivider = 2;
        }
        private void OnEnable()
        {
            UnityEngine.Camera val_1 = this.GetComponent<UnityEngine.Camera>();
            this._camera = val_1;
            val_1.depthTextureMode = 1;
            this.cameraTransform = this._camera.transform;
        }
        private UnityEngine.Matrix4x4 calculateFrustrumCornersArray(float clipPlane)
        {
            float val_7;
            float val_8;
            float val_9;
            float val_10;
            UnityEngine.Matrix4x4 val_0;
            this._camera.CalculateFrustumCorners(viewport:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, z:  clipPlane, eye:  this._camera.stereoActiveEye, outCorners:  null);
            UnityEngine.Vector3 val_2 = this.cameraTransform.TransformVector(vector:  new UnityEngine.Vector3() {x = UnityEngine.Vector3[].__il2cppRuntimeField_byval_arg, y = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24, z = UnityEngine.Vector3[].__il2cppRuntimeField_this_arg});
            UnityEngine.Vector3 val_3 = this.cameraTransform.TransformVector(vector:  new UnityEngine.Vector3() {x = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_2C, y = UnityEngine.Vector3[].__il2cppRuntimeField_element_class, z = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_34});
            UnityEngine.Vector3 val_4 = this.cameraTransform.TransformVector(vector:  new UnityEngine.Vector3() {x = UnityEngine.Vector3[].__il2cppRuntimeField_castClass, y = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_3C, z = UnityEngine.Vector3[].__il2cppRuntimeField_declaringType});
            UnityEngine.Vector3 val_5 = this.cameraTransform.TransformVector(vector:  new UnityEngine.Vector3() {x = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_44, y = UnityEngine.Vector3[].__il2cppRuntimeField_parent, z = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_4C});
            UnityEngine.Matrix4x4 val_6 = UnityEngine.Matrix4x4.identity;
            UnityEngine.Vector4 val_11 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector4 val_12 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector4 val_13 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Vector4 val_14 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_0.m02 = val_7;
            val_0.m03 = val_8;
            val_0.m00 = val_9;
            val_0.m01 = val_10;
            return val_0;
        }
        private void OnRenderImage(UnityEngine.RenderTexture source, UnityEngine.RenderTexture destination)
        {
            UnityEngine.RenderTexture val_35;
            var val_36;
            UnityEngine.Shader val_37;
            UnityEngine.Material val_38;
            float val_39;
            float val_40;
            float val_41;
            var val_42;
            var val_43;
            float val_47;
            string val_48;
            var val_49;
            val_36 = 1152921504721543168;
            if(0 == this.fogMaterial)
            {
                    if(0 != this.FogShader)
            {
                    val_37 = this.FogShader;
                UnityEngine.Material val_4 = null;
                val_38 = val_4;
                val_4 = new UnityEngine.Material(shader:  val_37);
                this.fogMaterial = val_38;
            }
            else
            {
                    val_38 = this.fogMaterial;
            }
            
                if(0 == val_38)
            {
                    UnityEngine.Graphics.Blit(source:  0, dest:  source);
                return;
            }
            
            }
            
            this._camera = this.GetComponent<UnityEngine.Camera>();
            this._camera.CalculateFrustumCorners(viewport:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, z:  this._camera.farClipPlane, eye:  this._camera.stereoActiveEye, outCorners:  null);
            UnityEngine.Matrix4x4 val_10 = this.calculateFrustrumCornersArray(clipPlane:  this._camera.farClipPlane);
            this.fogMaterial.SetMatrix(name:  "_FrustumCornersWS", value:  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f});
            UnityEngine.Matrix4x4 val_12 = this.calculateFrustrumCornersArray(clipPlane:  this._camera.nearClipPlane);
            this.fogMaterial.SetMatrix(name:  "_FrustumCornersWS_Near", value:  new UnityEngine.Matrix4x4() {m00 = 0f, m10 = 0f, m20 = 0f, m30 = 0f, m01 = 0f, m11 = 0f, m21 = 0f, m31 = 0f, m02 = 0f, m12 = 0f, m22 = 0f, m32 = 0f, m03 = 0f, m13 = 0f, m23 = 0f, m33 = 0f});
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  100000f);
            val_39 = val_14.x;
            val_40 = val_14.y;
            val_41 = val_14.z;
            if(0 == this.sun)
            {
                goto label_25;
            }
            
            UnityEngine.Transform val_16 = this.sun.transform;
            if(val_16 == null)
            {
                goto label_27;
            }
            
            UnityEngine.Vector3 val_17 = val_16.forward;
            val_42 = val_17.x;
            UnityEngine.Vector3 val_18 = val_16.forward;
            val_43 = val_18.y;
            goto label_28;
            label_25:
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.down;
            val_47 = 0f;
            val_48 = "_SunDir";
            this.fogMaterial.SetVector(name:  val_48, value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = val_47});
            goto label_32;
            label_27:
            UnityEngine.Vector3 val_22 = 0.forward;
            val_42 = val_22.x;
            UnityEngine.Vector3 val_23 = 0.forward;
            val_43 = val_23.y;
            label_28:
            UnityEngine.Vector3 val_24 = val_16.forward;
            this.fogMaterial.SetVector(name:  "_SunDir", value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            UnityEngine.Vector3 val_25 = val_16.forward;
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
            val_48 = 0;
            val_47 = 100000f;
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, d:  100000f);
            val_39 = val_27.x;
            val_40 = val_27.y;
            val_41 = val_27.z;
            label_32:
            UnityEngine.RenderTexture val_28 = source / this.SunShaftDepthTextureDivider;
            UnityEngine.RenderTexture val_29 = source / this.SunShaftDepthTextureDivider;
            UnityEngine.RenderTexture val_30 = UnityEngine.RenderTexture.GetTemporary(width:  0, height:  val_28);
            this.fogMaterial.SetFloat(name:  "_Exposure", value:  this.SunShaftsExposure);
            this.fogMaterial.SetFloat(name:  "_SunShaftsWeight", value:  this.SunShaftsWeight);
            this.fogMaterial.SetFloat(name:  "_SunShaftDensity", value:  this.SunShaftDensity);
            this.fogMaterial.SetFloat(name:  "_SunShaftDecay", value:  this.SunShaftDecay);
            UnityEngine.Vector3 val_31 = this._camera.WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = val_39, y = val_40, z = val_41});
            this.fogMaterial.SetVector(name:  "_SunPosition", value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
            UnityEngine.Graphics.Blit(source:  0, dest:  source, mat:  val_30, pass:  this.fogMaterial);
            if(this.GaussianBlur != false)
            {
                    UnityEngine.RenderTexture val_32 = UnityEngine.RenderTexture.GetTemporary(width:  0, height:  val_28);
                val_39 = this.SunShaftsBlur;
                this.fogMaterial.SetFloat(name:  "_SunShaftsBlur", value:  val_39);
                UnityEngine.Graphics.Blit(source:  0, dest:  val_30, mat:  val_32, pass:  this.fogMaterial);
                UnityEngine.Graphics.Blit(source:  0, dest:  val_32, mat:  val_30, pass:  this.fogMaterial);
                UnityEngine.RenderTexture.ReleaseTemporary(temp:  0);
            }
            
            val_37 = this.fogMaterial;
            val_35 = source;
            val_37.SetTexture(name:  "_SunShaftsTex", value:  val_30);
            val_36 = "_WindSpeed";
            val_49 = 0;
            goto label_52;
            label_74:
            val_49 = 1;
            label_52:
            if(val_49 >= this.Settings.Length)
            {
                goto label_54;
            }
            
            ZarnFramework.Common.FogSettings val_34 = this.Settings[1];
            if(this.Settings[0x1][0].Enabled == false)
            {
                goto label_74;
            }
            
            this.fogMaterial.SetColor(name:  "_FogColor", value:  new UnityEngine.Color() {r = this.Settings[0x1][0].FogColor, g = val_40, b = val_41, a = this.SunShaftDecay});
            this.fogMaterial.SetFloat(name:  "_FogDensity", value:  this.Settings[0x1][0].FogDensity);
            this.fogMaterial.SetFloat(name:  "_SunAmount", value:  this.Settings[0x1][0].SunAmount * 8f);
            this.fogMaterial.SetColor(name:  "_SunColor", value:  new UnityEngine.Color() {r = this.Settings[0x1][0].SunColor, g = val_40, b = val_41, a = this.SunShaftDecay});
            this.fogMaterial.SetFloat(name:  "_HeightFalloff", value:  this.Settings[0x1][0].HeightFalloff);
            this.fogMaterial.SetFloat(name:  "_Y", value:  this.Settings[0x1][0].Height);
            this.fogMaterial.SetFloat(name:  "_WindSpeed", value:  this.Settings[0x1][0].WindSpeed);
            this.fogMaterial.SetFloat(name:  "_WindWaveHeight", value:  this.Settings[0x1][0].WindWaveHeight);
            this.fogMaterial.SetFloat(name:  "_WindWaveLenght", value:  this.Settings[0x1][0].WindWaveLenght);
            UnityEngine.Graphics.Blit(source:  0, dest:  val_35, mat:  destination, pass:  this.fogMaterial);
            int val_35 = this.Settings.Length;
            val_35 = val_35 - 1;
            if(val_35 <= val_49)
            {
                goto label_74;
            }
            
            UnityEngine.Graphics.Blit(source:  0, dest:  destination);
            goto label_74;
            label_54:
            UnityEngine.RenderTexture.ReleaseTemporary(temp:  0);
        }
    
    }

}
