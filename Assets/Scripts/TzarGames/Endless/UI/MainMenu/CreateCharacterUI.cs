using UnityEngine;

namespace TzarGames.Endless.UI.MainMenu
{
    public class CreateCharacterUI : UIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.MainMenu.CreateCharacterUI.CharacterClassInfo[] classBehaviours;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.PlayerClassInfo playerClasses;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI currentClassLabel;
        [UnityEngine.SerializeField]
        private UnityEngine.Color selectedClassColor;
        [UnityEngine.SerializeField]
        private UnityEngine.Color unselectedClassColor;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.InputFieldUI input;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Button createButton;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Button cancelButton;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Toggle hardcoreToggle;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase nextMenu;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action OnGoToNextScene;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <AutoSelectCharacter>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private int <LastCreatedCharacterNum>k__BackingField;
        private TzarGames.Endless.PlayerClass currentClass;
        private bool classIsChosen;
        
        // Properties
        public bool AutoSelectCharacter { get; set; }
        public int LastCreatedCharacterNum { get; set; }
        
        // Methods
        public CreateCharacterUI()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.blue;
            this.selectedClassColor = val_1;
            mem[1152921510963208884] = val_1.g;
            mem[1152921510963208888] = val_1.b;
            mem[1152921510963208892] = val_1.a;
            UnityEngine.Color val_2 = UnityEngine.Color.white;
            this.unselectedClassColor = val_2;
            mem[1152921510963208900] = val_2.g;
            mem[1152921510963208904] = val_2.b;
            mem[1152921510963208908] = val_2.a;
        }
        public void add_OnGoToNextScene(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnGoToNextScene);
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
            while(1152921510963333240 != this.OnGoToNextScene);
        
        }
        public void remove_OnGoToNextScene(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnGoToNextScene);
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
            while(1152921510963469816 != this.OnGoToNextScene);
        
        }
        public bool get_AutoSelectCharacter()
        {
            return (bool)this.<AutoSelectCharacter>k__BackingField;
        }
        public void set_AutoSelectCharacter(bool value)
        {
            this.<AutoSelectCharacter>k__BackingField = value;
        }
        public int get_LastCreatedCharacterNum()
        {
            return (int)this.<LastCreatedCharacterNum>k__BackingField;
        }
        private void set_LastCreatedCharacterNum(int value)
        {
            this.<LastCreatedCharacterNum>k__BackingField = value;
        }
        protected override void Start()
        {
            this.Start();
            this.<AutoSelectCharacter>k__BackingField = true;
            this.input.CharacterLimit = TzarGames.Endless.EndlessGameState.Instance.MaxLengthOfCharacterName;
            this.createButton.interactable = (this.classIsChosen == true) ? 1 : 0;
        }
        public void SetPlayerClass(TzarGames.Endless.PlayerClass classType)
        {
            var val_4;
            UnityEngine.Animator val_5;
            this.classIsChosen = true;
            this.currentClass = classType;
            this.createButton.interactable = true;
            string val_1 = this.playerClasses.GetClassLocalizedName(classType:  classType);
            UnityEngine.GameObject val_2 = this.currentClassLabel.gameObject;
            val_2.SetActive(value:  false);
            val_4 = 0;
            goto label_5;
            label_15:
            val_2.Color = new UnityEngine.Color() {r = V8.16B, g = V9.16B, b = V10.16B, a = V11.16B};
            val_4 = 1;
            label_5:
            if(val_4 >= this.classBehaviours.Length)
            {
                    return;
            }
            
            if(this.classBehaviours[1] != null)
            {
                    val_5 = this.classBehaviours[0x1][0].Animator;
            }
            else
            {
                    val_5 = 64;
            }
            
            val_5.SetBool(name:  "Selected", value:  (this.classBehaviours[0x1][0].Class == classType) ? 1 : 0);
            if(this.classBehaviours[0x1][0].Class == classType)
            {
                
            }
            
            if(this.classBehaviours[0x1][0].TextLabel != null)
            {
                goto label_15;
            }
            
            goto label_15;
        }
        public void SetKnightClass()
        {
            this.SetPlayerClass(classType:  0);
        }
        public void SetDualistClass()
        {
            this.SetPlayerClass(classType:  1);
        }
        public void SetNextMenu(TzarGames.Common.UI.UIBase menu)
        {
            this.nextMenu = menu;
        }
        public void SetCancelState(bool enable)
        {
            this.cancelButton.gameObject.SetActive(value:  enable);
        }
        public void Create()
        {
            TzarGames.Endless.PlayerClass val_8;
            if(this.classIsChosen == false)
            {
                    return;
            }
            
            val_8 = this.currentClass;
            int val_5 = TzarGames.Endless.EndlessGameState.Instance.CreateCharacter(name:  this.input.Text, classType:  val_8, hardcore:  this.hardcoreToggle.isOn);
            this.<LastCreatedCharacterNum>k__BackingField = val_5;
            if((val_5 & 2147483648) != 0)
            {
                    return;
            }
            
            if((this.<AutoSelectCharacter>k__BackingField) != false)
            {
                    val_8 = TzarGames.Endless.EndlessGameState.Instance;
                val_8.SelectCharacter(num:  this.<LastCreatedCharacterNum>k__BackingField);
            }
            
            TzarGames.Endless.EndlessGameState.Instance.SaveGame();
            this.GoToNextMenu();
        }
        public void GoToNextMenu()
        {
            var val_2 = 0;
            bool val_1 = UnityEngine.Object.op_Inequality(x:  0, y:  this.nextMenu);
            if(this.OnGoToNextScene == null)
            {
                    return;
            }
            
            this.OnGoToNextScene.Invoke();
        }
        protected override void OnVisible()
        {
            this.OnVisible();
            this.<LastCreatedCharacterNum>k__BackingField = 0;
        }
    
    }

}
