using UnityEngine;

namespace TzarGames.TzarHero
{
    public class SimpleRangeCombatSystem : MonoBehaviour, IPoolable
    {
        // Fields
        public bool useAttackNetViewID;
        public TzarGames.GameFramework.IWeaponObject WeaponObject;
        private TzarGames.TzarHero.TH_Projectile currentProjectile;
        private TzarGames.Common.TransformAttachment attachment;
        private TzarGames.TzarHero.TH_Character owner;
        public TzarGames.GameFramework.NetworkViewID AttackNetViewID;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Vector3 <ActualAttackDirection>k__BackingField;
        
        // Properties
        public TzarGames.TzarHero.TH_Character Owner { get; set; }
        public UnityEngine.Vector3 ActualAttackDirection { get; set; }
        public TzarGames.TzarHero.TH_Projectile CurrentProjectile { get; }
        
        // Methods
        public SimpleRangeCombatSystem()
        {
            this.attachment = new TzarGames.Common.TransformAttachment();
        }
        public TzarGames.TzarHero.TH_Character get_Owner()
        {
            return (TzarGames.TzarHero.TH_Character)this.owner;
        }
        public void set_Owner(TzarGames.TzarHero.TH_Character value)
        {
            TzarGames.TzarHero.TH_Character val_5 = this.owner;
            if(0 != val_5)
            {
                    val_5 = this.owner;
                val_5.remove_OnCharacterDead(value:  new TH_Character.dlgDeadEvent(object:  this, method:  System.Void TzarGames.TzarHero.SimpleRangeCombatSystem::onOwnerDeadEventHandler(TzarGames.TzarHero.DeadEventData deadData)));
            }
            
            this.owner = value;
            if(0 == value)
            {
                    return;
            }
            
            value.add_OnCharacterDead(value:  new TH_Character.dlgDeadEvent(object:  this, method:  System.Void TzarGames.TzarHero.SimpleRangeCombatSystem::onOwnerDeadEventHandler(TzarGames.TzarHero.DeadEventData deadData)));
        }
        public UnityEngine.Vector3 get_ActualAttackDirection()
        {
            return new UnityEngine.Vector3() {x = this.<ActualAttackDirection>k__BackingField};
        }
        public void set_ActualAttackDirection(UnityEngine.Vector3 value)
        {
            this.<ActualAttackDirection>k__BackingField = value;
            mem[1152921511510837788] = value.y;
            mem[1152921511510837792] = value.z;
        }
        public TzarGames.TzarHero.TH_Projectile get_CurrentProjectile()
        {
            return (TzarGames.TzarHero.TH_Projectile)this.currentProjectile;
        }
        private void onOwnerDeadEventHandler(TzarGames.TzarHero.DeadEventData deadData)
        {
            this.DestroyCurrentProjectile();
        }
        public void LaunchCurrentProjectile(UnityEngine.Vector3 launchPosition)
        {
            var val_7;
            if(0 == this.currentProjectile)
            {
                    return;
            }
            
            this.currentProjectile = 0;
            val_7 = this.currentProjectile.gameObject;
            if(val_7.activeSelf != true)
            {
                    val_7 = this.currentProjectile.gameObject;
                val_7.SetActive(value:  true);
            }
            
            this.launchProjectile(projectile:  this.currentProjectile, launchPosition:  new UnityEngine.Vector3() {x = launchPosition.x, y = launchPosition.y, z = launchPosition.z});
        }
        public void DestroyCurrentProjectile()
        {
            if(0 == this.currentProjectile)
            {
                    return;
            }
            
            this.attachment.Reset();
            this.attachment.destroyProjectile(projectile:  this.currentProjectile);
        }
        private void destroyProjectile(TzarGames.TzarHero.TH_Projectile projectile)
        {
            UnityEngine.GameObject val_1 = projectile.gameObject;
            if((TzarGames.GameFramework.Instantiator.IsPoolableInstance(instanceObject:  0)) != false)
            {
                    TzarGames.GameFramework.Instantiator.PushToPool(instanceObject:  0);
                return;
            }
            
            UnityEngine.Object.Destroy(obj:  0);
        }
        private void launchProjectile(TzarGames.TzarHero.TH_Projectile projectile, UnityEngine.Vector3 launchPosition)
        {
            TzarGames.TzarHero.TH_Character val_8 = this.owner;
            if(0 == val_8)
            {
                goto label_3;
            }
            
            val_8 = this.owner;
            if(val_8.isDead == false)
            {
                goto label_5;
            }
            
            label_3:
            bool val_4 = UnityEngine.Object.op_Inequality(x:  0, y:  projectile);
            if(val_4 == false)
            {
                    return;
            }
            
            val_4.destroyProjectile(projectile:  projectile);
            return;
            label_5:
            if(0 == projectile)
            {
                    return;
            }
            
            projectile.gameObject.SetActive(value:  true);
            this.attachment.Reset();
            UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = this.<ActualAttackDirection>k__BackingField, y = V12.16B, z = V11.16B});
            if(projectile != null)
            {
                    projectile.EnableMovement = true;
            }
            else
            {
                    mem[144] = 1;
            }
        
        }
        private void OnDestroy()
        {
            this.DestroyCurrentProjectile();
        }
        private void Update()
        {
            this.attachment.Update();
        }
        public UnityEngine.GameObject Use(TzarGames.GameFramework.Weapon weaponTemplate, float speedScale, UnityEngine.Vector3 attackDirection, UnityEngine.Transform projectileFireSource, TzarGames.TzarHero.TH_Character target, bool autoLaunch = True)
        {
            var val_27;
            TzarGames.TzarHero.TH_Projectile val_51;
            UnityEngine.Object val_52;
            float val_53;
            float val_54;
            float val_56;
            float val_57;
            float val_58;
            float val_59;
            float val_61;
            TzarGames.TzarHero.TH_Projectile val_62;
            UnityEngine.Object val_63;
            var val_64;
            float val_65;
            var val_66;
            var val_67;
            val_51 = autoLaunch;
            val_52 = projectileFireSource;
            UnityEngine.Vector3 val_1 = this.owner.Position;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  this.owner.AttackHeightOffset);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_53 = val_5.y;
            val_54 = val_5.z;
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.identity;
            val_56 = val_6.x;
            if((TzarGames.GameFramework.Instantiator.IsPoolablePrefab(prefab:  0)) != false)
            {
                    val_57 = val_53;
                val_58 = val_54;
                val_59 = val_56;
                UnityEngine.GameObject val_8 = TzarGames.GameFramework.Instantiator.InstantiateFromPool(originalObject:  0, position:  new UnityEngine.Vector3() {x = val_5.x, y = val_57, z = val_58}, rotation:  new UnityEngine.Quaternion() {x = val_59, y = val_6.y, z = val_6.z, w = val_6.w}, parent:  weaponTemplate.projectilePrefab);
            }
            else
            {
                    val_57 = val_53;
                val_58 = val_54;
                val_59 = val_56;
                UnityEngine.GameObject val_9 = TzarGames.GameFramework.GameManager.MakeInstance(obj:  0, position:  new UnityEngine.Vector3() {x = val_5.x, y = val_57, z = val_58}, rotation:  new UnityEngine.Quaternion() {x = val_59, y = val_6.y, z = val_6.z, w = val_6.w});
            }
            
            this.<ActualAttackDirection>k__BackingField = attackDirection;
            mem[1152921511512207388] = attackDirection.y;
            val_61 = attackDirection.z;
            mem[1152921511512207392] = val_61;
            if(0 != this.currentProjectile)
            {
                    UnityEngine.Debug.LogWarning(message:  0);
                this.DestroyCurrentProjectile();
            }
            
            val_62 = val_9.GetComponent<TzarGames.TzarHero.TH_Projectile>();
            this.currentProjectile = val_62;
            val_63 = 0;
            if(val_63 != val_62)
            {
                    this.currentProjectile.Target = target;
                this.currentProjectile.Instigator = this.owner;
                mem2[0] = this.owner;
                val_63 = this.currentProjectile;
                val_61 = this.owner.TemplateInstance.Damage;
                val_63.Damage = val_61;
            }
            
            if(val_63.Connected == false)
            {
                goto label_67;
            }
            
            bool val_16 = TzarGames.GameFramework.GameManagerNetSyncBase.IsServer;
            if((val_16 == false) || (weaponTemplate.useUniqueNetworkIDForProjectiles == false))
            {
                goto label_34;
            }
            
            if(0 == (val_9.GetComponent<TzarGames.GameFramework.NetworkViewBase>()))
            {
                goto label_67;
            }
            
            val_62 = TzarGames.GameFramework.GameManager.Instance.Net.AllocateNetworkViewID();
            TzarGames.GameFramework.Player val_23 = TzarGames.GameFramework.GameManager.Instance.LocalPlayer;
            System.Collections.Generic.List<TzarGames.GameFramework.Player> val_24 = this.owner.SessionPlayers;
            if(val_24 == null)
            {
                goto label_67;
            }
            
            List.Enumerator<T> val_25 = val_24.GetEnumerator();
            label_53:
            if((0 & 1) == 0)
            {
                goto label_48;
            }
            
            TzarGames.GameFramework.GameManager.Instance.Net.AddGameObjectRelationship(go:  val_9, player:  val_27.InitializationCallback);
            goto label_53;
            label_34:
            if((val_16.OnClient == false) || (this.useAttackNetViewID == false))
            {
                goto label_67;
            }
            
            this.useAttackNetViewID = false;
            val_62 = this.currentProjectile.GetComponent<TzarGames.GameFramework.NetworkViewBase>();
            TzarGames.GameFramework.Player val_35 = TzarGames.GameFramework.GameManager.Instance.Net.ServerPlayer;
            if(val_62 != null)
            {
                goto label_67;
            }
            
            goto label_67;
            label_48:
            val_64 = 0;
            val_62 = 1;
            val_27.Dispose();
            label_67:
            val_65 = weaponTemplate.rangeAttackThrowTime;
            bool val_36 = UnityEngine.Object.op_Inequality(x:  0, y:  val_52);
            if(val_36 == true)
            {
                goto label_84;
            }
            
            if(this.WeaponObject == null)
            {
                goto label_78;
            }
            
            var val_50 = 0;
            val_50 = val_50 + 1;
            val_66 = this.WeaponObject;
            if(val_36 < true)
            {
                goto label_78;
            }
            
            var val_51 = 0;
            val_51 = val_51 + 1;
            val_67 = this.WeaponObject;
            goto label_83;
            label_78:
            val_52 = 0;
            goto label_84;
            label_83:
            label_84:
            if(val_65 <= 0f)
            {
                    if(val_51 ^ 1 == false)
            {
                goto label_99;
            }
            
            }
            
            if(0 != this.WeaponObject)
            {
                    UnityEngine.Vector3 val_42 = this.WeaponObject.position;
                val_65 = val_42.x;
                val_56 = val_42.z;
                UnityEngine.Quaternion val_43 = this.WeaponObject.rotation;
                val_53 = val_43.y;
                val_54 = val_43.w;
                val_62 = this.currentProjectile.CachedTransform;
                this.attachment.SetAttachment(parent:  this.WeaponObject, child:  val_62);
            }
            
            this.currentProjectile.EnableMovement = false;
            if(weaponTemplate.hideProjectileBeforeLaunch != false)
            {
                    this.currentProjectile.gameObject.SetActive(value:  false);
            }
            
            label_99:
            if(val_51 == false)
            {
                    return val_9;
            }
            
            if(weaponTemplate.rangeAttackThrowTime > 0f)
            {
                    if(weaponTemplate.hideProjectileBeforeLaunch != false)
            {
                    this.currentProjectile.gameObject.SetActive(value:  false);
            }
            
                val_51 = this.currentProjectile;
                float val_52 = weaponTemplate.rangeAttackThrowTime;
                val_52 = val_52 / speedScale;
                UnityEngine.Coroutine val_48 = this.StartCoroutine(routine:  this.projectileThrowDelayTimerFunc(projectile:  val_51, delay:  val_52, muzzleFlashTransform:  this.WeaponObject));
                return val_9;
            }
            
            UnityEngine.Vector3 val_49 = this.WeaponObject.position;
            this.launchProjectile(projectile:  this.currentProjectile, launchPosition:  new UnityEngine.Vector3() {x = val_49.x, y = val_49.y, z = val_49.z});
            this.currentProjectile = 0;
            return val_9;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator projectileThrowDelayTimerFunc(TzarGames.TzarHero.TH_Projectile projectile, float delay, UnityEngine.Transform muzzleFlashTransform)
        {
            if(null != 0)
            {
                    typeof(SimpleRangeCombatSystem.<projectileThrowDelayTimerFunc>c__Iterator0).__il2cppRuntimeField_10 = delay;
                typeof(SimpleRangeCombatSystem.<projectileThrowDelayTimerFunc>c__Iterator0).__il2cppRuntimeField_18 = projectile;
                typeof(SimpleRangeCombatSystem.<projectileThrowDelayTimerFunc>c__Iterator0).__il2cppRuntimeField_20 = muzzleFlashTransform;
            }
            else
            {
                    mem[16] = delay;
                mem[24] = projectile;
                mem[32] = muzzleFlashTransform;
            }
            
            typeof(SimpleRangeCombatSystem.<projectileThrowDelayTimerFunc>c__Iterator0).__il2cppRuntimeField_28 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public void SetViewIdForLastProjectile(TzarGames.GameFramework.NetworkViewID viewID)
        {
            var val_13;
            TzarGames.TzarHero.TH_Projectile val_14;
            val_13 = viewID;
            val_14 = this.currentProjectile;
            if(0 == val_14)
            {
                    return;
            }
            
            if(0 == (this.currentProjectile.GetComponent<TzarGames.GameFramework.NetworkViewBase>()))
            {
                    return;
            }
            
            TzarGames.GameFramework.Player val_6 = TzarGames.GameFramework.GameManager.Instance.Net.ServerPlayer;
            val_13 = ???;
            val_14 = ???;
            goto typeof(TzarGames.GameFramework.NetworkViewBase).__il2cppRuntimeField_1A0;
        }
        public void OnPushedToPool()
        {
            this.enabled = false;
            this.DestroyCurrentProjectile();
            this.useAttackNetViewID = false;
            this.WeaponObject = 0;
            this.attachment.Reset();
            if(0 != this.owner)
            {
                    this.owner.remove_OnCharacterDead(value:  new TH_Character.dlgDeadEvent(object:  this, method:  System.Void TzarGames.TzarHero.SimpleRangeCombatSystem::onOwnerDeadEventHandler(TzarGames.TzarHero.DeadEventData deadData)));
                this.owner = 0;
            }
            
            this.AttackNetViewID = 0;
        }
        public void OnPulledFromPool()
        {
            this.enabled = true;
        }
    
    }

}
