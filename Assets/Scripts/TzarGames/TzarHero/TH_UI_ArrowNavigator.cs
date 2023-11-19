using UnityEngine;

namespace TzarGames.TzarHero
{
    public class TH_UI_ArrowNavigator : MonoBehaviour
    {
        // Fields
        private const int initPoolCount = 10;
        private System.Collections.Generic.List<TzarGames.TzarHero.Arrow> arrows;
        private int currentPoolPointer;
        public float ArrowWidth;
        public float ArrowHeight;
        public TzarGames.GameFramework.CharacterGroup[] Groups;
        public bool drawDebugGui;
        public bool drawArrowsOnGUI;
        public UnityEngine.Texture2D guiArrowTexture;
        private UnityEngine.Rect guiRect;
        
        // Methods
        public TH_UI_ArrowNavigator()
        {
            this.ArrowWidth = 64f;
            this.ArrowHeight = 64f;
            this.arrows = new System.Collections.Generic.List<TzarGames.TzarHero.Arrow>();
            this.guiRect = 0;
        }
        private void addArrow(TzarGames.TzarHero.TH_Character character)
        {
            TzarGames.TzarHero.Arrow val_10;
            label_7:
            if(0 >= this.arrows.Count)
            {
                goto label_2;
            }
            
            TzarGames.TzarHero.Arrow val_2 = this.arrows.Item[0];
            val_10 = 0 + 1;
            if(0 != val_2.character)
            {
                goto label_7;
            }
            
            return;
            label_2:
            character.add_OnCharacterDead(value:  new TH_Character.dlgDeadEvent(object:  this, method:  System.Void TzarGames.TzarHero.TH_UI_ArrowNavigator::onCharacterDead(TzarGames.TzarHero.DeadEventData deadData)));
            character.add_OnObjectDestroy(value:  new TH_InteractiveObject.InteractiveObjectDelegate(object:  this, method:  System.Void TzarGames.TzarHero.TH_UI_ArrowNavigator::onInterObjectDestroy(TzarGames.TzarHero.TH_InteractiveObject obj)));
            if(this.currentPoolPointer < this.arrows.Count)
            {
                    val_10 = this.arrows.Item[this.currentPoolPointer];
                val_8.character = character;
            }
            else
            {
                    TzarGames.TzarHero.Arrow val_9 = null;
                val_10 = val_9;
                val_9 = new TzarGames.TzarHero.Arrow();
                typeof(TzarGames.TzarHero.Arrow).__il2cppRuntimeField_10 = character;
                this.arrows.Add(item:  val_10);
            }
            
            int val_10 = this.currentPoolPointer;
            val_10 = val_10 + 1;
            this.currentPoolPointer = val_10;
        }
        private void removeArrow(TzarGames.TzarHero.TH_Character character)
        {
            TzarGames.TzarHero.TH_Character val_5;
            int val_6;
            int val_7;
            TzarGames.TzarHero.Arrow val_8;
            if(this.currentPoolPointer < 1)
            {
                goto label_1;
            }
            
            var val_5 = 0;
            label_7:
            TzarGames.TzarHero.Arrow val_1 = this.arrows.Item[0];
            val_5 = val_1.character;
            if(0 == val_5)
            {
                goto label_6;
            }
            
            val_5 = val_5 + 1;
            if(val_5 < this.currentPoolPointer)
            {
                goto label_7;
            }
            
            label_1:
            UnityEngine.Debug.LogWarning(message:  0);
            return;
            label_6:
            val_6 = this.currentPoolPointer - 1;
            if(val_5 < val_6)
            {
                    do
            {
                val_5 = this.arrows;
                if(val_5 != null)
            {
                    val_7 = val_5 + 1;
                val_8 = val_5.Item[val_7];
            }
            else
            {
                    val_7 = val_5 + 1;
                val_8 = 0.Item[val_7];
                val_5 = 0;
            }
            
                val_5.set_Item(index:  0, value:  val_8);
                val_6 = this.currentPoolPointer - 1;
            }
            while(val_7 < val_6);
            
            }
            
            this.currentPoolPointer = val_6;
            if(val_1 != null)
            {
                    val_1.draw = false;
            }
            else
            {
                    val_1.draw = false;
            }
            
            val_1.character = 0;
            this.arrows.set_Item(index:  this.currentPoolPointer, value:  val_1);
        }
        private void logArrowsInfo(string prefix)
        {
            string val_5;
            var val_6;
            var val_7;
            var val_8;
            val_5 = prefix;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    val_6 = null;
                val_6 = null;
                val_5 = System.String.Empty;
            }
            
            List.Enumerator<T> val_2 = this.arrows.GetEnumerator();
            label_13:
            if((0 & 1) == 0)
            {
                goto label_7;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_3 = 0.InitializationCallback;
            string val_4 = 0 + val_5;
            UnityEngine.Debug.Log(message:  0);
            goto label_13;
            label_7:
            val_7 = 0;
            val_8 = 1;
            0.Dispose();
            if((val_8 & 1) != 0)
            {
                    return;
            }
            
            if(val_7 == 0)
            {
                    return;
            }
        
        }
        private void Start()
        {
            bool val_1 = TzarGames.GameFramework.ApplicationManager.IsBatchMode;
            this.enabled = false;
        }
        private void OnCharacterAlive(TzarGames.TzarHero.TH_Character character)
        {
            this.tryAddCharacter(character:  character);
        }
        private void onCharacterSpawn(TzarGames.TzarHero.TH_Character character)
        {
            this.tryAddCharacter(character:  character);
        }
        private void tryAddCharacter(TzarGames.TzarHero.TH_Character character)
        {
            goto label_0;
            label_10:
            0 = 1;
            label_0:
            if(0 >= this.Groups.Length)
            {
                    return;
            }
            
            if(((character.TemplateInstance.Group.IsFriendly(group:  this.Groups[1])) == false) || (character.enabled == false))
            {
                goto label_10;
            }
            
            this.addArrow(character:  character);
            goto label_10;
        }
        private void onCharacterDead(TzarGames.TzarHero.DeadEventData deadData)
        {
            deadData.Victim.remove_OnCharacterDead(value:  new TH_Character.dlgDeadEvent(object:  this, method:  System.Void TzarGames.TzarHero.TH_UI_ArrowNavigator::onCharacterDead(TzarGames.TzarHero.DeadEventData deadData)));
            this.removeArrow(character:  deadData.Victim);
        }
        private void OnDestroy()
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        private void onInterObjectDestroy(TzarGames.TzarHero.TH_InteractiveObject obj)
        {
            TH_InteractiveObject.InteractiveObjectDelegate val_1 = new TH_InteractiveObject.InteractiveObjectDelegate(object:  this, method:  System.Void TzarGames.TzarHero.TH_UI_ArrowNavigator::onInterObjectDestroy(TzarGames.TzarHero.TH_InteractiveObject obj));
            if(obj != null)
            {
                    obj.remove_OnObjectDestroy(value:  val_1);
                return;
            }
            
            obj.remove_OnObjectDestroy(value:  val_1);
        }
        private void Update()
        {
            if(this.currentPoolPointer < 1)
            {
                    return;
            }
            
            var val_15 = 0;
            label_21:
            UnityEngine.Vector3 val_3 = val_1.character.Position;
            UnityEngine.Vector3 val_4 = this.GetComponent<UnityEngine.Camera>().WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            float val_13 = val_4.x;
            float val_14 = val_4.y;
            val_13 = val_13 * (UnityEngine.Mathf.Sign(f:  val_4.z));
            val_14 = val_14 * (UnityEngine.Mathf.Sign(f:  val_4.z));
            UnityEngine.Vector3 val_8 = this.GetComponent<UnityEngine.Camera>().ViewportToScreenPoint(position:  new UnityEngine.Vector3() {x = val_13, y = val_14, z = 0f});
            if((val_8.x >= 0) && (val_8.y >= 0))
            {
                    if(val_8.x <= (float)UnityEngine.Screen.width)
            {
                    if(val_8.y <= (float)UnityEngine.Screen.height)
            {
                goto label_16;
            }
            
            }
            
            }
            
            if(val_1.character.gameObject.activeInHierarchy == false)
            {
                goto label_16;
            }
            
            if(this.arrows.Item[0] == null)
            {
                goto label_17;
            }
            
            val_1.draw = true;
            goto label_18;
            label_16:
            val_1.draw = false;
            goto label_20;
            label_17:
            val_1.draw = true;
            label_18:
            val_1.position = val_8;
            mem2[0] = val_8.y;
            mem2[0] = val_8.z;
            label_20:
            val_15 = val_15 + 1;
            if(val_15 < this.currentPoolPointer)
            {
                goto label_21;
            }
        
        }
        private void OnGUI()
        {
            float val_4;
            var val_26;
            UnityEngine.Rect val_27;
            if(this.drawDebugGui == false)
            {
                goto label_26;
            }
            
            UnityEngine.GUILayout.Label(text:  0, options:  0 + "Current pointer: "("Current pointer: "));
            List.Enumerator<T> val_2 = this.arrows.GetEnumerator();
            label_24:
            if((0 & 1) == 0)
            {
                goto label_51;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_5 = val_4.InitializationCallback;
            val_26 = null;
            val_26 = null;
            typeof(System.Object[]).__il2cppRuntimeField_20 = System.String.Empty;
            typeof(System.Object[]).__il2cppRuntimeField_28 = System.String.Empty;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " draw: ";
            typeof(System.Object[]).__il2cppRuntimeField_38 = System.Object[].__il2cppRuntimeField_namespaze;
            typeof(System.Object[]).__il2cppRuntimeField_39 = 27394915;
            UnityEngine.GUILayout.Label(text:  0, options:  +0);
            goto label_24;
            label_51:
            val_4.Dispose();
            label_26:
            if(this.currentPoolPointer < 1)
            {
                    return;
            }
            
            var val_26 = 0;
            val_27 = this.guiRect;
            goto label_50;
            label_43:
            if(val_4 != ((float)UnityEngine.Screen.height - 64))
            {
                goto label_29;
            }
            
            goto label_32;
            label_29:
            if(((float)UnityEngine.Screen.height - 64) != 0f)
            {
                goto label_42;
            }
            
            goto label_32;
            label_50:
            TzarGames.TzarHero.Arrow val_9 = this.arrows.Item[0];
            if(val_9.draw == false)
            {
                goto label_36;
            }
            
            UnityEngine.Matrix4x4 val_10 = UnityEngine.GUI.matrix;
            val_27.startFloat = UnityEngine.Mathf.Clamp(value:  val_9.position, min:  32f, max:  (float)UnityEngine.Screen.width - 32);
            float val_18 = UnityEngine.Mathf.Clamp(value:  val_9.position, min:  32f, max:  (float)UnityEngine.Screen.height - 32);
            val_18 = (float)UnityEngine.Screen.height - val_18;
            val_18 = val_18 + (-32f);
            val_27.startFloat = val_18;
            val_18 = val_18 + (-32f);
            if(val_18 != ((float)UnityEngine.Screen.width - 64))
            {
                goto label_41;
            }
            
            goto label_42;
            label_41:
            if(((float)UnityEngine.Screen.width - 64) != 0f)
            {
                goto label_43;
            }
            
            label_42:
            label_32:
            UnityEngine.Quaternion val_22 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_4 = 0;
            CinemachineFreeLook.Orbit val_25 = new CinemachineFreeLook.Orbit(h:  val_22.x + 32f, r:  val_22.x + 32f);
            UnityEngine.GUIUtility.RotateAroundPivot(angle:  val_22.y, pivotPoint:  new UnityEngine.Vector2() {x = val_25.m_Height, y = val_25.m_Radius});
            UnityEngine.GUI.DrawTexture(position:  new UnityEngine.Rect() {m_XMin = this.guiRect, m_YMin = val_22.x, m_Width = V15.16B, m_Height = 0f}, image:  0);
            UnityEngine.GUI.matrix = new UnityEngine.Matrix4x4();
            label_36:
            val_26 = val_26 + 1;
            if(val_26 < this.currentPoolPointer)
            {
                goto label_50;
            }
        
        }
    
    }

}
