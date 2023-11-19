using UnityEngine;

namespace LlockhamIndustries.Decals
{
    internal class CameraData
    {
        // Fields
        public System.Nullable<UnityEngine.DepthTextureMode> originalDTM;
        public System.Nullable<UnityEngine.DepthTextureMode> desiredDTM;
        public LlockhamIndustries.Decals.ShaderReplacement replacement;
        private UnityEngine.RenderTexture depthBuffer;
        private UnityEngine.RenderTexture normalBuffer;
        private UnityEngine.RenderTexture maskBuffer;
        private UnityEngine.RenderTexture depthEye;
        private UnityEngine.RenderTexture normalEye;
        private UnityEngine.RenderTexture maskEye;
        public bool initialized;
        
        // Methods
        public CameraData()
        {
        
        }
        public void Initialize(UnityEngine.Camera Camera, LlockhamIndustries.Decals.DynamicDecals System)
        {
            this.initialized = true;
        }
        public void Terminate(UnityEngine.Camera Camera)
        {
            this.RestoreDepthTextureMode(Camera:  Camera);
            this.ReleaseTextures();
            this.initialized = false;
        }
        public void Update(UnityEngine.Camera Camera, LlockhamIndustries.Decals.DynamicDecals System)
        {
            this.UpdateRenderingMethod(Camera:  Camera, System:  System);
            this.UpdateRenderTextures(Camera:  Camera, System:  System, ForceNewTextures:  false);
            this.UpdateShaderReplacement(Source:  Camera, System:  System);
        }
        public void AssignGlobalProperties(UnityEngine.Camera Camera)
        {
            LlockhamIndustries.Decals.ShaderReplacement val_1 = this.replacement;
            if(val_1 == 0)
            {
                    return;
            }
            
            val_1 = val_1 - 1;
            if(val_1 > 4)
            {
                    return;
            }
            
            var val_2 = 25815584 + ((this.replacement - 1)) << 2;
            val_2 = val_2 - 4;
            if(val_2 > 3)
            {
                    return;
            }
            
            var val_3 = 25815044 + ((25815584 + ((this.replacement - 1)) << 2 - 4)) << 2;
            val_3 = val_3 + 25815044;
            goto (25815044 + ((25815584 + ((this.replacement - 1)) << 2 - 4)) << 2 + 25815044);
        }
        private LlockhamIndustries.Decals.ShaderReplacement Standard(bool VR)
        {
            if(VR != false)
            {
                    return 4;
            }
            
            return (LlockhamIndustries.Decals.ShaderReplacement)(UnityEngine.SystemInfo.supportedRenderTargetCount < 3) ? (2 + 1) : 2;
        }
        private bool VRCamera(UnityEngine.Camera Source)
        {
            var val_6;
            if((Source.cameraType != 2) && (Source.cameraType != 4))
            {
                    if(UnityEngine.XR.XRSettings.enabled != false)
            {
                    var val_5 = (Source.stereoTargetEye != 0) ? 1 : 0;
                return (bool)val_6;
            }
            
            }
            
            val_6 = 0;
            return (bool)val_6;
        }
        private void UpdateRenderingMethod(UnityEngine.Camera Camera, LlockhamIndustries.Decals.DynamicDecals System)
        {
            var val_24;
            var val_25;
            var val_26;
            val_24 = 0;
            if(((Camera.stereoTargetEye != 0) ? 1 : 0) != 0)
            {
                    val_25 = 4;
            }
            else
            {
                    var val_5 = (UnityEngine.SystemInfo.supportedRenderTargetCount < 3) ? (2 + 1) : 2;
            }
            
            LlockhamIndustries.Decals.DynamicDecalSettings val_6 = System.Settings;
            if(val_6.replacement == 2)
            {
                goto label_8;
            }
            
            if(val_6.replacement != 1)
            {
                goto label_9;
            }
            
            val_26 = 1;
            goto label_10;
            label_8:
            val_26 = 5;
            label_10:
            label_9:
            if(0 != this.depthBuffer)
            {
                    string val_9 = this.depthBuffer.format.ToString();
                UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
                LlockhamIndustries.Misc.DebugManager.Log(Title:  0, Log:  "Depth Format");
            }
            
            if(0 != this.normalBuffer)
            {
                    string val_13 = this.normalBuffer.format.ToString();
                UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y});
                LlockhamIndustries.Misc.DebugManager.Log(Title:  0, Log:  "Normal Format");
            }
            
            if(0 != this.maskBuffer)
            {
                    string val_17 = this.maskBuffer.format.ToString();
                UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y});
                LlockhamIndustries.Misc.DebugManager.Log(Title:  0, Log:  "Mask Format");
            }
            
            string val_19 = 5.ToString();
            UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y});
            LlockhamIndustries.Misc.DebugManager.Log(Title:  0, Log:  "Shader Replacement");
            string val_22 = UnityEngine.SystemInfo.graphicsDeviceType.ToString();
            UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y});
            LlockhamIndustries.Misc.DebugManager.Log(Title:  0, Log:  "API");
            if(this.replacement == null)
            {
                    return;
            }
            
            this.replacement = null;
            this.SwitchRenderingMethod(Camera:  Camera);
            this.UpdateRenderTextures(Camera:  Camera, System:  System, ForceNewTextures:  true);
        }
        private void SwitchRenderingMethod(UnityEngine.Camera Camera)
        {
            LlockhamIndustries.Decals.ShaderReplacement val_2 = this.replacement;
            val_2 = val_2 - 1;
            if(val_2 > 4)
            {
                    return;
            }
            
            if((25815616 + ((this.replacement - 1)) << 2) == 3)
            {
                goto label_2;
            }
            
            if((25815616 + ((this.replacement - 1)) << 2) == 4)
            {
                goto label_3;
            }
            
            if((25815616 + ((this.replacement - 1)) << 2) != 5)
            {
                    return;
            }
            
            goto label_5;
            label_3:
            if(Camera.actualRenderingPath != 3)
            {
                goto label_7;
            }
            
            label_2:
            this.RestoreDepthTextureMode(Camera:  Camera);
            return;
            label_7:
            label_5:
            this.desiredDTM = 0;
            this.SetDepthTextureMode(Camera:  Camera);
        }
        private void SetDepthTextureMode(UnityEngine.Camera Camera)
        {
            if((this.desiredDTM & 1) == 0)
            {
                goto label_1;
            }
            
            if(Camera.depthTextureMode == (-1431099656))
            {
                    if((0 & 1) != 0)
            {
                    return;
            }
            
            }
            
            if(((this.originalDTM & 1) & 1) == 0)
            {
                goto label_5;
            }
            
            Camera.depthTextureMode = this.originalDTM;
            goto label_7;
            label_1:
            this.RestoreDepthTextureMode(Camera:  Camera);
            return;
            label_5:
            UnityEngine.DepthTextureMode val_3 = Camera.depthTextureMode;
            mem2[0] = 0;
            label_7:
            this = Camera.depthTextureMode;
            Camera.depthTextureMode = this.desiredDTM | this;
        }
        public void RestoreDepthTextureMode(UnityEngine.Camera Camera)
        {
            if((this.originalDTM & 1) == 0)
            {
                    return;
            }
            
            if(0 == Camera)
            {
                    return;
            }
            
            Camera.depthTextureMode = this.originalDTM;
        }
        private void UpdateRenderTextures(UnityEngine.Camera Camera, LlockhamIndustries.Decals.DynamicDecals System, bool ForceNewTextures = False)
        {
            int val_10;
            int val_11;
            UnityEngine.RenderTexture val_12;
            if(Camera != null)
            {
                    val_10 = Camera.pixelWidth;
            }
            else
            {
                    val_10 = 0.pixelWidth;
            }
            
            int val_3 = Camera.pixelHeight;
            val_11 = val_3;
            if((val_3.VRCamera(Source:  Camera)) != false)
            {
                    LlockhamIndustries.Decals.DynamicDecalSettings val_5 = System.Settings;
                val_10 = UnityEngine.XR.XRSettings.eyeTextureWidth << val_5.singlepassVR;
                val_11 = UnityEngine.XR.XRSettings.eyeTextureHeight;
            }
            
            val_12 = this.maskBuffer;
            if(0 != val_12)
            {
                    val_12 = this.maskBuffer;
                if(val_12 == val_10)
            {
                    val_12 = this.maskBuffer;
                if((val_12 == val_11) && (ForceNewTextures != true))
            {
                    return;
            }
            
            }
            
            }
            
            this.ReleaseTextures();
            this.GetTextures(Camera:  Camera, System:  System, Width:  val_10, Height:  val_11);
        }
        private void GetTextures(UnityEngine.Camera Camera, LlockhamIndustries.Decals.DynamicDecals System, int Width, int Height)
        {
            LlockhamIndustries.Decals.ShaderReplacement val_34 = this.replacement;
            val_34 = val_34 + 2;
            var val_2 = ((val_34 - 1) < 5) ? (val_34) : 0;
            val_2 = val_2 - 3;
            if(val_2 > 4)
            {
                    return;
            }
            
            var val_35 = 25815060 + ((val_1 < 0x5 ? (this.replacement + 2) : 0 - 3)) << 2;
            val_35 = val_35 + 25815060;
            goto (25815060 + ((val_1 < 0x5 ? (this.replacement + 2) : 0 - 3)) << 2 + 25815060);
        }
        private void ReleaseTextures()
        {
            if((0 != this.depthBuffer) && (this.depthBuffer.IsCreated() != false))
            {
                    UnityEngine.RenderTexture.ReleaseTemporary(temp:  0);
                this.depthBuffer = 0;
                if(0 != this.depthEye)
            {
                    if(this.depthEye.IsCreated() != false)
            {
                    UnityEngine.RenderTexture.ReleaseTemporary(temp:  0);
                this.depthEye = 0;
            }
            
            }
            
            }
            
            if((0 != this.normalBuffer) && (this.normalBuffer.IsCreated() != false))
            {
                    UnityEngine.RenderTexture.ReleaseTemporary(temp:  0);
                this.normalBuffer = 0;
                if(0 != this.normalEye)
            {
                    if(this.normalEye.IsCreated() != false)
            {
                    UnityEngine.RenderTexture.ReleaseTemporary(temp:  0);
                this.normalEye = 0;
            }
            
            }
            
            }
            
            if(0 == this.maskBuffer)
            {
                    return;
            }
            
            if(this.maskBuffer.IsCreated() == false)
            {
                    return;
            }
            
            UnityEngine.RenderTexture.ReleaseTemporary(temp:  0);
            this.maskBuffer = 0;
            if(0 == this.maskEye)
            {
                    return;
            }
            
            if(this.maskEye.IsCreated() == false)
            {
                    return;
            }
            
            UnityEngine.RenderTexture.ReleaseTemporary(temp:  0);
            this.maskEye = 0;
        }
        private void UpdateShaderReplacement(UnityEngine.Camera Source, LlockhamIndustries.Decals.DynamicDecals System)
        {
            float val_22;
            float val_23;
            float val_24;
            float val_25;
            float val_27;
            float val_28;
            float val_29;
            float val_30;
            float val_42;
            float val_43;
            var val_60;
            float val_64;
            float val_65;
            float val_66;
            float val_67;
            float val_68;
            float val_69;
            float val_70;
            float val_71;
            if(System.ShaderReplacement == false)
            {
                    return;
            }
            
            UnityEngine.Camera val_2 = System.CustomCamera;
            val_2.SetupReplacementCamera(Source:  Source, Target:  val_2);
            if((val_2.VRCamera(Source:  Source)) == false)
            {
                goto label_7;
            }
            
            val_60 = System.Settings;
            if(val_4.singlepassVR == false)
            {
                goto label_7;
            }
            
            if(Source.stereoTargetEye != 3)
            {
                    if(Source.stereoTargetEye != 1)
            {
                goto label_11;
            }
            
            }
            
            if(0 == Source.transform.parent)
            {
                goto label_17;
            }
            
            UnityEngine.Vector3 val_13 = UnityEngine.XR.InputTracking.GetLocalPosition(node:  0);
            UnityEngine.Vector3 val_14 = Source.transform.parent.TransformPoint(position:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            goto label_23;
            label_7:
            this.RenderToTextures(Source:  Source, Renderer:  val_2, System:  System, depth:  this.depthBuffer, normal:  this.normalBuffer, mask:  this.maskBuffer);
            return;
            label_17:
            UnityEngine.Vector3 val_15 = UnityEngine.XR.InputTracking.GetLocalPosition(node:  0);
            label_23:
            val_2.transform.position = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
            val_60 = val_2.transform;
            UnityEngine.Quaternion val_18 = Source.transform.rotation;
            UnityEngine.Quaternion val_19 = UnityEngine.XR.InputTracking.GetLocalRotation(node:  0);
            val_64 = val_19.x;
            val_65 = val_19.w;
            UnityEngine.Quaternion val_20 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_18.x, y = val_18.y, z = val_18.z, w = val_18.w}, rhs:  new UnityEngine.Quaternion() {x = val_64, y = val_19.y, z = val_19.z, w = val_65});
            val_66 = val_20.x;
            val_67 = val_20.z;
            val_60.rotation = new UnityEngine.Quaternion() {x = val_66, y = val_20.y, z = val_67, w = val_20.w};
            UnityEngine.Matrix4x4 val_21 = Source.GetStereoProjectionMatrix(eye:  0);
            val_2.projectionMatrix = new UnityEngine.Matrix4x4() {m00 = val_24, m10 = val_24, m20 = val_24, m30 = val_24, m01 = val_25, m11 = val_25, m21 = val_25, m31 = val_25, m02 = val_22, m12 = val_22, m22 = val_22, m32 = val_22, m03 = val_23, m13 = val_23, m23 = val_23, m33 = val_23};
            UnityEngine.Matrix4x4 val_26 = Source.worldToCameraMatrix;
            val_2.worldToCameraMatrix = new UnityEngine.Matrix4x4() {m00 = val_29, m10 = val_29, m20 = val_29, m30 = val_29, m01 = val_30, m11 = val_30, m21 = val_30, m31 = val_30, m02 = val_27, m12 = val_27, m22 = val_27, m32 = val_27, m03 = val_28, m13 = val_28, m23 = val_28, m33 = val_28};
            this.RenderToTextures(Source:  Source, Renderer:  val_2, System:  System, depth:  this.depthEye, normal:  this.normalEye, mask:  this.maskEye);
            this.StereoBlit(Source:  Source, System:  System, Left:  true);
            label_11:
            if(Source.stereoTargetEye != 3)
            {
                    if(Source.stereoTargetEye != 2)
            {
                    return;
            }
            
            }
            
            UnityEngine.Transform val_36 = val_2.transform;
            if(0 == Source.transform.parent)
            {
                goto label_49;
            }
            
            UnityEngine.Vector3 val_39 = UnityEngine.XR.InputTracking.GetLocalPosition(node:  0);
            UnityEngine.Vector3 val_40 = Source.transform.parent.TransformPoint(position:  new UnityEngine.Vector3() {x = val_39.x, y = val_39.y, z = val_39.z});
            val_68 = val_40.y;
            val_69 = val_40.z;
            val_36.position = new UnityEngine.Vector3() {x = val_40.x, y = val_68, z = val_69};
            UnityEngine.Matrix4x4 val_41 = Source.worldToCameraMatrix;
            if(Source == null)
            {
                goto label_57;
            }
            
            val_70 = Source.stereoSeparation;
            goto label_58;
            label_49:
            UnityEngine.Vector3 val_45 = UnityEngine.XR.InputTracking.GetLocalPosition(node:  0);
            val_71 = val_45.x;
            val_68 = val_45.y;
            val_69 = val_45.z;
            val_36.position = new UnityEngine.Vector3() {x = val_71, y = val_68, z = val_69};
            UnityEngine.Matrix4x4 val_46 = Source.worldToCameraMatrix;
            float val_58 = val_23;
            val_58 = val_58 - Source.stereoSeparation;
            val_30 = val_25;
            val_27 = val_22;
            val_29 = val_24;
            if(val_2 != null)
            {
                goto label_65;
            }
            
            goto label_65;
            label_57:
            val_70 = 0.stereoSeparation;
            label_58:
            UnityEngine.Vector3 val_51 = Source.transform.parent.localScale;
            val_71 = val_70 * val_51.x;
            val_70 = val_23 - val_71;
            val_30 = val_25;
            val_27 = val_22;
            val_29 = val_24;
            label_65:
            val_2.worldToCameraMatrix = new UnityEngine.Matrix4x4() {m00 = val_29, m10 = val_29, m20 = val_29, m30 = val_29, m01 = val_30, m11 = val_30, m21 = val_30, m31 = val_30, m02 = val_27, m12 = val_27, m22 = val_27, m32 = val_27, m03 = val_70, m13 = val_43, m23 = val_43, m33 = val_42};
            val_60 = val_2.transform;
            UnityEngine.Quaternion val_54 = Source.transform.rotation;
            UnityEngine.Quaternion val_55 = UnityEngine.XR.InputTracking.GetLocalRotation(node:  0);
            val_64 = val_55.x;
            val_65 = val_55.w;
            UnityEngine.Quaternion val_56 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_54.x, y = val_54.y, z = val_54.z, w = val_54.w}, rhs:  new UnityEngine.Quaternion() {x = val_64, y = val_55.y, z = val_55.z, w = val_65});
            val_66 = val_56.x;
            val_67 = val_56.z;
            val_60.rotation = new UnityEngine.Quaternion() {x = val_66, y = val_56.y, z = val_67, w = val_56.w};
            UnityEngine.Matrix4x4 val_57 = Source.GetStereoProjectionMatrix(eye:  1);
            val_2.projectionMatrix = new UnityEngine.Matrix4x4() {m00 = val_24, m10 = val_24, m20 = val_24, m30 = val_24, m01 = val_25, m11 = val_25, m21 = val_25, m31 = val_25, m02 = val_22, m12 = val_22, m22 = val_22, m32 = val_22, m03 = val_23, m13 = val_23, m23 = val_23, m33 = val_23};
            this.RenderToTextures(Source:  Source, Renderer:  val_2, System:  System, depth:  this.depthEye, normal:  this.normalEye, mask:  this.maskEye);
            this.StereoBlit(Source:  Source, System:  System, Left:  false);
        }
        private void RenderToTextures(UnityEngine.Camera Source, UnityEngine.Camera Renderer, LlockhamIndustries.Decals.DynamicDecals System, UnityEngine.RenderTexture depth, UnityEngine.RenderTexture normal, UnityEngine.RenderTexture mask)
        {
            IntPtr val_32;
            UnityEngine.RenderBuffer[] val_33;
            val_32 = mask;
            val_33 = this;
            LlockhamIndustries.Decals.ShaderReplacement val_32 = this.replacement;
            val_32 = val_32 + 2;
            if((((val_32 - 1) < 5) ? (val_32) : 0) > 7)
            {
                    return;
            }
            
            var val_33 = 25815080 + (val_1 < 0x5 ? (this.replacement + 2) : 0) << 2;
            val_33 = val_33 + 25815080;
            goto (25815080 + (val_1 < 0x5 ? (this.replacement + 2) : 0) << 2 + 25815080);
        }
        private void DrawRegualarPass(UnityEngine.Camera Renderer, UnityEngine.Shader ReplacementShader)
        {
            Renderer.clearFlags = 2;
            UnityEngine.Color val_1 = UnityEngine.Color.clear;
            if(Renderer != null)
            {
                    Renderer.backgroundColor = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
            }
            else
            {
                    0.backgroundColor = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
            }
            
            Renderer.RenderWithShader(shader:  ReplacementShader, replacementTag:  "RenderType");
        }
        private void DrawSplitPass(UnityEngine.Camera Source, UnityEngine.Camera Renderer, LlockhamIndustries.Decals.DynamicDecals System, UnityEngine.Shader ReplacementShader, bool RenderInvalid = True)
        {
            var val_15;
            LlockhamIndustries.Decals.DynamicDecalSettings val_1 = System.Settings;
            Renderer.clearFlags = 2;
            UnityEngine.Color val_2 = UnityEngine.Color.clear;
            Renderer.backgroundColor = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
            LlockhamIndustries.Decals.DynamicDecalSettings val_3 = System.Settings;
            LlockhamIndustries.Decals.DecalMaskMethod val_15 = val_3.maskMethod;
            val_15 = val_15 | 2;
            if(val_15 != 2)
            {
                goto label_7;
            }
            
            val_15 = 0;
            goto label_8;
            label_25:
            val_15 = 1;
            label_8:
            if(val_15 >= val_1.passes.Count)
            {
                    return;
            }
            
            LlockhamIndustries.Decals.ReplacementPass val_5 = val_1.passes.Item[1];
            UnityEngine.Vector4 val_6 = UnityEngine.Vector4.zero;
            if((UnityEngine.Vector4.op_Inequality(lhs:  new UnityEngine.Vector4() {x = val_5.vector, y = val_2.b, z = val_2.g, w = val_2.r}, rhs:  new UnityEngine.Vector4() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w})) != true)
            {
                    if(RenderInvalid == false)
            {
                goto label_25;
            }
            
            }
            
            LlockhamIndustries.Decals.ReplacementPass val_9 = val_1.passes.Item[1];
            Renderer.cullingMask = Source.cullingMask & (UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask()));
            LlockhamIndustries.Decals.ReplacementPass val_13 = val_1.passes.Item[1];
            UnityEngine.Shader.SetGlobalVector(name:  0, value:  new UnityEngine.Vector4() {x = val_13.vector, y = val_2.b, z = val_2.g, w = val_2.r});
            if(Renderer != null)
            {
                    Renderer.RenderWithShader(shader:  ReplacementShader, replacementTag:  "RenderType");
            }
            else
            {
                    0.RenderWithShader(shader:  ReplacementShader, replacementTag:  "RenderType");
            }
            
            Renderer.clearFlags = 4;
            goto label_25;
            label_7:
            if(RenderInvalid == false)
            {
                    return;
            }
            
            Renderer.cullingMask = 0;
            UnityEngine.Vector4 val_14 = UnityEngine.Vector4.zero;
            UnityEngine.Shader.SetGlobalVector(name:  0, value:  new UnityEngine.Vector4() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_14.w});
            if(Renderer != null)
            {
                    Renderer.RenderWithShader(shader:  ReplacementShader, replacementTag:  "RenderType");
            }
            else
            {
                    0.RenderWithShader(shader:  ReplacementShader, replacementTag:  "RenderType");
            }
            
            Renderer.clearFlags = 4;
        }
        private void StereoBlit(UnityEngine.Camera Source, LlockhamIndustries.Decals.DynamicDecals System, bool Left)
        {
            UnityEngine.RenderTexture val_10;
            UnityEngine.RenderTexture val_11;
            UnityEngine.RenderTexture val_12;
            var val_15;
            var val_16;
            if(this.replacement == 4)
            {
                goto label_1;
            }
            
            if(this.replacement != 1)
            {
                    return;
            }
            
            val_11 = this.depthEye;
            val_12 = this.depthBuffer;
            if(Left == false)
            {
                goto label_4;
            }
            
            UnityEngine.Material val_1 = System.StereoBlitLeft;
            goto label_5;
            label_1:
            if(Source.actualRenderingPath != 3)
            {
                goto label_7;
            }
            
            if(Left == false)
            {
                goto label_9;
            }
            
            UnityEngine.Material val_3 = System.StereoDepthBlitLeft;
            goto label_10;
            label_4:
            label_5:
            val_15 = System.StereoBlitRight;
            val_16 = null;
            goto label_11;
            label_9:
            label_10:
            System.StereoDepthBlitRight.SetTexture(name:  "_DepthTex", value:  this.depthEye);
            UnityEngine.Graphics.Blit(source:  0, dest:  this.depthEye, mat:  this.depthBuffer);
            label_7:
            val_10 = this.normalBuffer;
            if(Left != false)
            {
                    UnityEngine.Material val_6 = System.StereoBlitLeft;
            }
            else
            {
                    UnityEngine.Material val_7 = System.StereoBlitRight;
            }
            
            UnityEngine.Graphics.Blit(source:  0, dest:  this.normalEye, mat:  val_10);
            val_11 = this.maskEye;
            val_12 = this.maskBuffer;
            if(Left != false)
            {
                    UnityEngine.Material val_8 = System.StereoBlitLeft;
            }
            
            val_15 = System.StereoBlitRight;
            val_16 = null;
            label_11:
            UnityEngine.Graphics.Blit(source:  0, dest:  val_11, mat:  val_12);
        }
        private void SetupReplacementCamera(UnityEngine.Camera Source, UnityEngine.Camera Target)
        {
            if(Target != null)
            {
                    Target.CopyFrom(other:  Source);
                Target.renderingPath = 1;
                Target.depthTextureMode = 0;
                Target.useOcclusionCulling = false;
                Target.allowMSAA = false;
            }
            else
            {
                    0.CopyFrom(other:  Source);
                0.renderingPath = 1;
                0.depthTextureMode = 0;
                0.useOcclusionCulling = false;
                0.allowMSAA = false;
            }
            
            Target.allowHDR = false;
            Target.rect = new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
        }
        private void SetupReplacementCameraExperimental(UnityEngine.Camera Source, UnityEngine.Camera Target)
        {
            float val_15;
            UnityEngine.Vector3 val_3 = Source.transform.position;
            Target.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Quaternion val_6 = Source.transform.rotation;
            val_15 = val_6.x;
            Target.transform.rotation = new UnityEngine.Quaternion() {x = val_15, y = val_6.y, z = val_6.z, w = val_6.w};
            if(UnityEngine.XR.XRSettings.enabled != true)
            {
                    val_15 = Source.fieldOfView;
                Target.fieldOfView = val_15;
            }
            
            Target.nearClipPlane = Source.nearClipPlane;
            Target.farClipPlane = Source.farClipPlane;
            Target.rect = new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
            Target.orthographic = Source.orthographic;
            float val_14 = Source.orthographicSize;
            if(Target != null)
            {
                    Target.orthographicSize = val_14;
                Target.ResetProjectionMatrix();
                Target.ResetWorldToCameraMatrix();
                Target.renderingPath = 1;
                Target.depthTextureMode = 0;
                Target.useOcclusionCulling = false;
                Target.allowMSAA = false;
                Target.allowHDR = false;
            }
            else
            {
                    0.orthographicSize = val_14;
                0.ResetProjectionMatrix();
                0.ResetWorldToCameraMatrix();
                0.renderingPath = 1;
                0.depthTextureMode = 0;
                0.useOcclusionCulling = false;
                0.allowMSAA = false;
                0.allowHDR = false;
            }
            
            Target.eventMask = 0;
        }
    
    }

}
