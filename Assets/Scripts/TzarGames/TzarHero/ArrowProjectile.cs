using UnityEngine;

namespace TzarGames.TzarHero
{
    public class ArrowProjectile : TH_Projectile
    {
        // Fields
        public float initialForce;
        public float damageMomentumForce;
        [UnityEngine.SerializeField]
        private UnityEngine.LayerMask traceLayers;
        [UnityEngine.SerializeField]
        private bool rotateToTargetOnLaunch;
        [UnityEngine.SerializeField]
        private float targetVerticalOffset;
        [UnityEngine.SerializeField]
        private float rotateToLaunchMinDistance;
        [UnityEngine.SerializeField]
        private UnityEngine.Rigidbody _rigidbody;
        [UnityEngine.SerializeField]
        private UnityEngine.RigidbodyInterpolation interpolationMode;
        [UnityEngine.SerializeField]
        private bool destroyOnHit;
        [UnityEngine.SerializeField]
        private bool ignoreAttachToCharacterController;
        [UnityEngine.SerializeField]
        private string layerNameOnHit;
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Events.HitEvent OnHit;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent OnHitWall;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.TzarHero.CharacterDamageInfo> OnCharacterTakeHit;
        private bool alreadyHit;
        private TzarGames.Common.TransformAttachment attachment;
        private bool boundToTarget;
        private UnityEngine.Vector3 lastVelocity;
        private UnityEngine.Vector3 lastPosition;
        private float instigatorCritChance;
        private float instigatorCritMultiplier;
        private TzarGames.GameFramework.CharacterGroup instigatorGroup;
        private UnityEngine.RaycastHit[] hitBuffer;
        private UnityEngine.Vector3 defaultScale;
        
        // Methods
        public ArrowProjectile()
        {
            this.initialForce = 6000f;
            this.damageMomentumForce = 1000f;
            this.targetVerticalOffset = 1f;
            this.rotateToLaunchMinDistance = 2f;
            this.interpolationMode = 1;
            this.ignoreAttachToCharacterController = 1;
            this.layerNameOnHit = "Default";
            this.attachment = new TzarGames.Common.TransformAttachment();
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.lastVelocity = val_2;
            mem[1152921511465054688] = val_2.y;
            mem[1152921511465054692] = val_2.z;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            mem[1152921511465054704] = val_3.z;
            this.lastPosition = val_3;
            mem[1152921511465054700] = val_3.y;
            this.hitBuffer = null;
        }
        public void add_OnCharacterTakeHit(System.Action<TzarGames.TzarHero.CharacterDamageInfo> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnCharacterTakeHit);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511465178944 != this.OnCharacterTakeHit);
        
        }
        public void remove_OnCharacterTakeHit(System.Action<TzarGames.TzarHero.CharacterDamageInfo> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnCharacterTakeHit);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921511465315520 != this.OnCharacterTakeHit);
        
        }
        protected override void Awake()
        {
            this.Awake();
            UnityEngine.Vector3 val_2 = this.CachedTransform.localScale;
            this.defaultScale = val_2;
            mem[1152921511465464468] = val_2.y;
            mem[1152921511465464472] = val_2.z;
            this._rigidbody.isKinematic = true;
            this._rigidbody.useGravity = false;
            this._rigidbody.detectCollisions = false;
            this._rigidbody.interpolation = 0;
            UnityEngine.Vector3 val_4 = this.CachedTransform.position;
            mem[1152921511465464432] = val_4.z;
            this.lastPosition = val_4;
            mem[1152921511465464428] = val_4.y;
        }
        public override void NotifyLaunched()
        {
            float val_20;
            float val_21;
            float val_22;
            this.NotifyLaunched();
            if((this.rotateToTargetOnLaunch != false) && (0 != this.Target))
            {
                    UnityEngine.Vector3 val_4 = this.Target.Position;
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  this.targetVerticalOffset);
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
                UnityEngine.Vector3 val_9 = this.CachedTransform.position;
                val_20 = val_7.x;
                val_21 = val_7.z;
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_20, y = val_7.y, z = val_21}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
                val_22 = this.rotateToLaunchMinDistance * this.rotateToLaunchMinDistance;
                if(val_10.x >= val_22)
            {
                    val_20 = val_7.x;
                val_22 = val_7.y;
                val_21 = val_7.z;
                this.CachedTransform.LookAt(worldPosition:  new UnityEngine.Vector3() {x = val_20, y = val_22, z = val_21});
            }
            
            }
            
            UnityEngine.Vector3 val_13 = this.CachedTransform.forward;
            this.lastVelocity = val_13;
            mem[1152921511465650144] = val_13.y;
            mem[1152921511465650148] = val_13.z;
            UnityEngine.Vector3 val_15 = this.CachedTransform.position;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = this.lastVelocity, y = V11.16B, z = val_7.z});
            this.lastPosition = val_16;
            mem[1152921511465650156] = val_16.y;
            mem[1152921511465650160] = val_16.z;
            this._rigidbody.useGravity = true;
            this._rigidbody.isKinematic = false;
            this._rigidbody.interpolation = this.interpolationMode;
            UnityEngine.Vector3 val_18 = this.CachedTransform.forward;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, d:  this.initialForce);
            this._rigidbody.AddForce(force:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, mode:  1);
            this.setLifeTimer();
        }
        protected override void OnInstigatorChanged()
        {
            var val_9;
            this.OnInstigatorChanged();
            TzarGames.TzarHero.TH_Character val_1 = this.Instigator;
            if(0 == val_1)
            {
                    return;
            }
            
            val_9 = val_1.TemplateInstance;
            if(val_9 != null)
            {
                    this.instigatorCritChance = val_9.CritChance;
                this.instigatorCritMultiplier = val_9.CritMultiplier;
            }
            else
            {
                    this.instigatorCritChance = 0.CritChance;
                this.instigatorCritMultiplier = 0.CritMultiplier;
                val_9 = 0;
            }
            
            this.instigatorGroup = val_9.Group;
        }
        private void Update()
        {
            TzarGames.Common.TransformAttachment val_36;
            float val_37;
            float val_38;
            float val_39;
            float val_40;
            float val_41;
            float val_42;
            var val_43;
            TzarGames.GameFramework.ISurfaceType val_44;
            UnityEngine.Collider val_45;
            float val_46;
            float val_47;
            float val_48;
            TzarGames.GameFramework.IHit val_49;
            var val_50;
            var val_51;
            float val_52;
            float val_53;
            float val_54;
            val_36 = this;
            if(this.alreadyHit == false)
            {
                goto label_1;
            }
            
            if(this.boundToTarget == false)
            {
                    return;
            }
            
            if(0 != this.attachment.Parent)
            {
                goto label_6;
            }
            
            this.boundToTarget = false;
            this.destroy();
            return;
            label_1:
            if(this._rigidbody.isKinematic == true)
            {
                goto label_13;
            }
            
            UnityEngine.Vector3 val_6 = this.CachedTransform.position;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = this.lastPosition, y = V11.16B, z = V10.16B});
            val_37 = val_7.x;
            val_38 = val_7.z;
            val_40 = this.lastPosition;
            val_41 = this.lastPosition;
            val_42 = val_6.z;
            int val_9 = UnityEngine.Physics.RaycastNonAlloc(origin:  new UnityEngine.Vector3() {x = val_40, y = val_41, z = val_42}, direction:  new UnityEngine.Vector3() {x = val_37, y = val_7.y, z = val_38}, results:  0, maxDistance:  val_7.x, layermask:  this.hitBuffer, queryTriggerInteraction:  UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask()));
            if(val_9 < 1)
            {
                goto label_13;
            }
            
            var val_40 = 0;
            label_46:
            var val_10 = this.hitBuffer + (val_40 * 48);
            TzarGames.GameFramework.IDamageReceiver val_12 = (0 * 48) + this.hitBuffer + 32.Payload.GetComponent<TzarGames.GameFramework.IDamageReceiver>();
            if(val_12 == null)
            {
                goto label_17;
            }
            
            if(val_12.OnClient == true)
            {
                goto label_34;
            }
            
            var val_37 = 0;
            val_37 = val_37 + 1;
            val_43 = val_12;
            goto label_24;
            label_17:
            TzarGames.GameFramework.SurfaceTypeBase val_16 = TzarGames.GameFramework.SurfaceTypeBase.Default;
            goto label_27;
            label_24:
            TzarGames.GameFramework.Hit val_27 = null;
            val_46 = (0 * 48) + this.hitBuffer + 32;
            val_47 = val_41;
            val_48 = val_42;
            val_27 = new TzarGames.GameFramework.Hit(point:  new UnityEngine.Vector3() {x = val_46, y = val_47, z = val_48}, normal:  new UnityEngine.Vector3() {x = (0 * 48) + this.hitBuffer + 32, y = val_41, z = val_42}, collider:  (0 * 48) + this.hitBuffer + 32.Payload, rigidbody:  (0 * 48) + this.hitBuffer + 32, surfaceType:  val_12);
            val_49 = val_27;
            TzarGames.TzarHero.CharacterDamageInfo val_28 = this.calculateDamageAndCreateDamageInfo(victim:  0, hit:  val_49);
            var val_38 = 0;
            val_38 = val_38 + 1;
            val_49 = 0;
            val_50 = val_12;
            var val_39 = 0;
            val_39 = val_39 + 1;
            val_51 = val_12;
            val_44 = val_12;
            label_27:
            val_37 = val_46;
            val_38 = val_48;
            UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_46, y = val_47, z = val_48});
            val_39 = val_31.y;
            val_45 = (0 * 48) + this.hitBuffer + 32.Payload;
            TzarGames.GameFramework.Hit val_33 = null;
            val_52 = val_37;
            val_53 = val_47;
            val_54 = val_38;
            val_33 = new TzarGames.GameFramework.Hit(point:  new UnityEngine.Vector3() {x = val_52, y = val_53, z = val_54}, normal:  new UnityEngine.Vector3() {x = val_31.x, y = val_39, z = val_31.z}, collider:  val_45, rigidbody:  (0 * 48) + this.hitBuffer + 32, surfaceType:  val_44);
            this.performHit(character:  val_12, hitInfo:  val_33);
            label_34:
            val_40 = val_40 + 1;
            if(val_40 != val_9)
            {
                goto label_46;
            }
            
            label_13:
            if(this.alreadyHit == true)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_35 = this.CachedTransform.position;
            this.lastPosition = val_35;
            mem[1152921511466227436] = val_35.y;
            mem[1152921511466227440] = val_35.z;
            UnityEngine.Vector3 val_36 = this._rigidbody.velocity;
            this.lastVelocity = val_36;
            mem[1152921511466227424] = val_36.y;
            mem[1152921511466227428] = val_36.z;
            return;
            label_6:
            val_36 = this.attachment;
            val_36.Update();
        }
        private void performHit(TzarGames.GameFramework.IDamageReceiver character, TzarGames.GameFramework.IHit hitInfo)
        {
            UnityEngine.Object val_53;
            TzarGames.GameFramework.IDamageReceiver val_54;
            var val_55;
            var val_56;
            TzarGames.Common.TransformAttachment val_57;
            var val_58;
            var val_59;
            var val_60;
            UnityEngine.Object val_61;
            float val_62;
            var val_63;
            float val_67;
            float val_68;
            var val_69;
            float val_70;
            float val_71;
            var val_72;
            var val_73;
            var val_74;
            var val_75;
            float val_76;
            float val_77;
            float val_78;
            var val_79;
            var val_80;
            var val_81;
            val_53 = hitInfo;
            val_54 = character;
            if(this.alreadyHit == true)
            {
                    return;
            }
            
            this.alreadyHit = true;
            bool val_1 = 2914.OnClient;
            if(val_1 != true)
            {
                    if(val_1.Connected == true)
            {
                goto label_68;
            }
            
            }
            
            if((TzarGames.GameFramework.ApplicationManager.IsBatchMode == true) || (this.destroyOnHit == true))
            {
                goto label_68;
            }
            
            val_55 = 1152921504910041088;
            var val_48 = 0;
            val_48 = val_48 + 1;
            val_56 = val_53;
            if(0 != val_53)
            {
                goto label_15;
            }
            
            System.Collections.Generic.List<UnityEngine.Collider> val_9 = null;
            val_57 = val_9;
            val_9 = new System.Collections.Generic.List<UnityEngine.Collider>();
            var val_49 = 0;
            val_49 = val_49 + 1;
            val_58 = val_53;
            goto label_20;
            label_15:
            var val_50 = 0;
            val_50 = val_50 + 1;
            val_59 = val_53;
            goto label_25;
            label_20:
            TzarGames.Common.Utils.GetComponentsInChildrenAll<UnityEngine.Collider>(target:  0, result:  val_53.transform);
            UnityEngine.Vector3 val_13 = this.CachedTransform.position;
            var val_51 = 0;
            val_51 = val_51 + 1;
            val_60 = val_53;
            goto label_32;
            label_25:
            val_61 = val_53;
            goto label_33;
            label_32:
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  5f);
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
            val_62 = val_17.z;
            var val_52 = 0;
            val_52 = val_52 + 1;
            val_63 = val_53;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            val_67 = val_17.y;
            val_68 = val_62;
            val_69 = 0;
            val_61 = 0;
            val_70 = 10f;
            goto label_41;
            label_65:
            val_69 = 1;
            label_41:
            if(val_69 >= Count)
            {
                goto label_43;
            }
            
            UnityEngine.Collider val_21 = Item[1];
            if(val_21 == null)
            {
                goto label_45;
            }
            
            if(null != null)
            {
                goto label_48;
            }
            
            if(this.ignoreAttachToCharacterController == true)
            {
                goto label_65;
            }
            
            goto label_48;
            label_45:
            label_48:
            if(val_21.enabled == false)
            {
                goto label_49;
            }
            
            val_71 = val_70;
            if((val_21.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  val_71)) == true)
            {
                goto label_51;
            }
            
            goto label_65;
            label_49:
            UnityEngine.Vector3 val_25 = val_21.ClosestPointOnBounds(position:  new UnityEngine.Vector3() {x = val_17.x, y = val_67, z = val_68});
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, b:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
            if((UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, rhs:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z})) < 0.95f)
            {
                goto label_65;
            }
            
            val_71 = val_25.x;
            val_67 = val_25.y;
            val_68 = val_25.z;
            label_51:
            if(0 == val_61)
            {
                goto label_65;
            }
            
            UnityEngine.Vector3 val_30 = this.CachedTransform.position;
            float val_31 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_71, y = val_67, z = val_68}, b:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z});
            UnityEngine.Vector3 val_33 = this.CachedTransform.position;
            float val_34 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_31, y = val_67, z = val_68}, b:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z});
            if(val_31 >= 0)
            {
                goto label_65;
            }
            
            goto label_65;
            label_43:
            val_55 = 1152921504910041088;
            val_53 = val_53;
            val_54 = val_54;
            label_33:
            val_72 = 0;
            if(0 == val_61)
            {
                goto label_68;
            }
            
            var val_56 = val_53;
            if((hitInfo + 258) == 0)
            {
                goto label_70;
            }
            
            var val_53 = hitInfo + 152;
            var val_54 = 0;
            val_53 = val_53 + 8;
            label_72:
            if(((hitInfo + 152 + 8) + -8) == val_55)
            {
                goto label_71;
            }
            
            val_54 = val_54 + 1;
            val_53 = val_53 + 16;
            if(val_54 < (hitInfo + 258))
            {
                goto label_72;
            }
            
            label_70:
            val_73 = val_53;
            goto label_73;
            label_71:
            var val_55 = val_53;
            val_55 = val_55 + 2;
            val_56 = val_56 + val_55;
            val_73 = val_56 + 272;
            label_73:
            UnityEngine.Transform val_37 = this.CachedTransform;
            if(0 != val_61)
            {
                goto label_76;
            }
            
            var val_59 = val_53;
            if((hitInfo + 258) == 0)
            {
                goto label_78;
            }
            
            var val_57 = hitInfo + 152;
            var val_58 = 0;
            val_57 = val_57 + 8;
            label_80:
            if(((hitInfo + 152 + 8) + -8) == null)
            {
                goto label_79;
            }
            
            val_58 = val_58 + 1;
            val_57 = val_57 + 16;
            if(val_58 < (hitInfo + 258))
            {
                goto label_80;
            }
            
            label_78:
            val_74 = val_53;
            goto label_81;
            label_76:
            val_37.position = new UnityEngine.Vector3() {x = val_17.x, y = val_67, z = val_68};
            val_75 = this.CachedTransform;
            val_76 = this.lastVelocity;
            val_77 = val_67;
            val_78 = val_17.x;
            goto label_85;
            label_79:
            val_59 = val_59 + (((hitInfo + 152 + 8)) << 4);
            val_74 = val_59 + 272;
            label_81:
            val_37.position = new UnityEngine.Vector3() {x = val_17.x, y = val_67, z = val_68};
            val_75 = this.CachedTransform;
            var val_63 = val_53;
            if((hitInfo + 258) == 0)
            {
                goto label_88;
            }
            
            var val_60 = hitInfo + 152;
            var val_61 = 0;
            val_60 = val_60 + 8;
            label_90:
            if(((hitInfo + 152 + 8) + -8) == null)
            {
                goto label_89;
            }
            
            val_61 = val_61 + 1;
            val_60 = val_60 + 16;
            if(val_61 < (hitInfo + 258))
            {
                goto label_90;
            }
            
            label_88:
            val_79 = val_53;
            goto label_91;
            label_89:
            var val_62 = val_60;
            val_62 = val_62 + 1;
            val_63 = val_63 + val_62;
            val_79 = val_63 + 272;
            label_91:
            UnityEngine.Vector3 val_40 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_67, z = val_68});
            val_76 = val_40.x;
            val_77 = val_40.y;
            val_78 = val_40.z;
            label_85:
            UnityEngine.Quaternion val_41 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_76, y = val_77, z = val_78});
            val_75.rotation = new UnityEngine.Quaternion() {x = val_41.x, y = val_41.y, z = val_41.z, w = val_41.w};
            val_57 = this.attachment;
            this.boundToTarget = true;
            val_57.SetAttachment(parent:  val_61.transform, child:  this.CachedTransform);
            UnityEngine.Vector3 val_44 = UnityEngine.Vector3.zero;
            this._rigidbody.angularVelocity = new UnityEngine.Vector3() {x = val_44.x, y = val_44.y, z = val_44.z};
            UnityEngine.Vector3 val_45 = UnityEngine.Vector3.zero;
            val_70 = val_45.x;
            val_62 = val_45.z;
            this._rigidbody.velocity = new UnityEngine.Vector3() {x = val_70, y = val_45.y, z = val_62};
            this._rigidbody.isKinematic = true;
            this._rigidbody.useGravity = false;
            val_72 = 0;
            this._rigidbody.interpolation = 0;
            label_68:
            var val_67 = val_53;
            if((hitInfo + 258) == 0)
            {
                goto label_107;
            }
            
            var val_64 = hitInfo + 152;
            var val_65 = 0;
            val_64 = val_64 + 8;
            label_109:
            if(((hitInfo + 152 + 8) + -8) == null)
            {
                goto label_108;
            }
            
            val_65 = val_65 + 1;
            val_64 = val_64 + 16;
            if(val_65 < (hitInfo + 258))
            {
                goto label_109;
            }
            
            label_107:
            val_72 = 2;
            val_80 = val_53;
            goto label_110;
            label_108:
            var val_66 = val_64;
            val_66 = val_66 + 2;
            val_67 = val_67 + val_66;
            val_80 = val_67 + 272;
            label_110:
            TzarGames.GameFramework.IHittable val_46 = val_53.GetComponent<TzarGames.GameFramework.IHittable>();
            if(val_46 != null)
            {
                    var val_68 = 0;
                val_68 = val_68 + 1;
                val_72 = 0;
                val_81 = val_46;
            }
            
            this.OnHit.Invoke(arg0:  val_53);
            if(val_54 == 0)
            {
                    this.OnHitWall.Invoke();
            }
            
            if(this.destroyOnHit == false)
            {
                    return;
            }
            
            this.destroy();
        }
        private TzarGames.TzarHero.CharacterDamageInfo calculateDamageAndCreateDamageInfo(TzarGames.TzarHero.TH_Character victim, TzarGames.GameFramework.IHit hit)
        {
            TzarGames.TzarHero.TH_Character val_14;
            float val_15;
            float val_16;
            float val_17;
            val_14 = victim;
            val_15 = 0f;
            val_16 = this.Damage;
            val_17 = val_15;
            float val_2 = UnityEngine.Random.Range(min:  val_17, max:  100f);
            if(val_2 <= this.instigatorCritChance)
            {
                    val_17 = val_16 * this.instigatorCritMultiplier;
                val_15 = val_17 - val_16;
                val_16 = val_16 + val_15;
            }
            
            UnityEngine.Vector3 val_4 = this.CachedTransform.forward;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  this.damageMomentumForce);
            TzarGames.TzarHero.TH_Character val_8 = this.Instigator;
            var val_13 = ~val_8.OnClient;
            val_13 = val_13 & 1;
            typeof(TzarGames.TzarHero.CharacterDamageInfo).__il2cppRuntimeField_38 = val_8;
            typeof(TzarGames.TzarHero.CharacterDamageInfo).__il2cppRuntimeField_40 = val_14;
            typeof(TzarGames.TzarHero.CharacterDamageInfo).__il2cppRuntimeField_36 = val_13;
            if(null != 0)
            {
                    typeof(TzarGames.TzarHero.CharacterDamageInfo).__il2cppRuntimeField_34 = (val_2 <= this.instigatorCritChance) ? 1 : 0;
            }
            else
            {
                    typeof(TzarGames.TzarHero.CharacterDamageInfo).__il2cppRuntimeField_34 = (val_2 <= this.instigatorCritChance) ? 1 : 0;
            }
            
            typeof(TzarGames.TzarHero.CharacterDamageInfo).__il2cppRuntimeField_30 = val_15;
            return (TzarGames.TzarHero.CharacterDamageInfo)new TzarGames.GameFramework.DamageInfoBase(damage:  val_16, force:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, damageType:  new TzarGames.TzarHero.TH_DamageType_Default(surfaceType:  TzarGames.GameFramework.SurfaceTypeBase.GetOrCreate(surfaceName:  null)), hitInfo:  hit);
        }
        private void adjustDamageToCharacter(TzarGames.TzarHero.TH_Character character, TzarGames.GameFramework.IHit hit)
        {
            TzarGames.GameFramework.IHit val_10 = hit;
            if(2908.OnClient == true)
            {
                    return;
            }
            
            if(0 == character)
            {
                    return;
            }
            
            val_10 = this.calculateDamageAndCreateDamageInfo(victim:  character, hit:  val_10 = hit);
            if(character != null)
            {
                    character.TakeDamage(damageInfo:  val_10);
            }
            else
            {
                    0.TakeDamage(damageInfo:  val_10);
            }
            
            if((System.Object.ReferenceEquals(objA:  0, objB:  character.TemplateInstance)) != true)
            {
                    mem[34803928].ApplyToTemplate(template:  character.TemplateInstance);
            }
            
            if(this.OnCharacterTakeHit == null)
            {
                    return;
            }
            
            this.OnCharacterTakeHit.Invoke(obj:  val_10);
        }
        public override void OnPushedToPool()
        {
            this.OnPushedToPool();
            this.instigatorGroup = 0;
            this.attachment.Reset();
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this._rigidbody.velocity = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this._rigidbody.angularVelocity = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            this._rigidbody.isKinematic = true;
            this._rigidbody.useGravity = false;
            this._rigidbody.interpolation = 0;
            this.enabled = false;
        }
        public override void OnPulledFromPool()
        {
            this.OnPulledFromPool();
            this.boundToTarget = false;
            this.alreadyHit = false;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.lastVelocity = val_1;
            mem[1152921511467387488] = val_1.y;
            mem[1152921511467387492] = val_1.z;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.lastPosition = val_2;
            mem[1152921511467387500] = val_2.y;
            mem[1152921511467387504] = val_2.z;
            this.instigatorCritChance = 0f;
            UnityEngine.Vector3 val_4 = this.CachedTransform.position;
            this.lastPosition = val_4;
            mem[1152921511467387500] = val_4.y;
            mem[1152921511467387504] = val_4.z;
            this._rigidbody.interpolation = 0;
            this.enabled = true;
        }
    
    }

}
