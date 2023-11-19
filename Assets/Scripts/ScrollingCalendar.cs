using UnityEngine;
public class ScrollingCalendar : MonoBehaviour
{
    // Fields
    public UnityEngine.RectTransform monthsScrollingPanel;
    public UnityEngine.RectTransform yearsScrollingPanel;
    public UnityEngine.RectTransform daysScrollingPanel;
    public UnityEngine.GameObject yearsButtonPrefab;
    public UnityEngine.GameObject monthsButtonPrefab;
    public UnityEngine.GameObject daysButtonPrefab;
    private UnityEngine.GameObject[] monthsButtons;
    private UnityEngine.GameObject[] yearsButtons;
    private UnityEngine.GameObject[] daysButtons;
    public UnityEngine.RectTransform monthCenter;
    public UnityEngine.RectTransform yearsCenter;
    public UnityEngine.RectTransform daysCenter;
    private UnityEngine.UI.Extensions.UIVerticalScroller yearsVerticalScroller;
    private UnityEngine.UI.Extensions.UIVerticalScroller monthsVerticalScroller;
    private UnityEngine.UI.Extensions.UIVerticalScroller daysVerticalScroller;
    public UnityEngine.UI.InputField inputFieldDays;
    public UnityEngine.UI.InputField inputFieldMonths;
    public UnityEngine.UI.InputField inputFieldYears;
    public UnityEngine.UI.Text dateText;
    private int daysSet;
    private int monthsSet;
    private int yearsSet;
    
    // Methods
    public ScrollingCalendar()
    {
    
    }
    private void InitializeYears()
    {
        var val_17;
        var val_18;
        var val_19;
        System.DateTime val_1 = System.DateTime.Now;
        string val_2 = val_1.ticks._ticks.ToString(format:  "yyyy");
        int val_4 = (System.Int32.Parse(s:  0)) - 1899;
        this.yearsButtons = null;
        val_17 = 0;
        val_18 = 0;
        goto label_4;
        label_29:
        val_17 = 80;
        (System.Int32[].__il2cppRuntimeField_namespaze + (X27) << 3).__unknownFiledOffset_20 = val_18;
        val_18 = W25 + 1;
        label_4:
        var val_6 = null + (((long)(int)((W25 + 1))) << 2);
        var val_7 = val_18 + 1900;
        mem2[0] = val_7;
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        TzarGames.GameFramework.TzarBehaviour val_9 = UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w});
        val_9.transform.SetParent(parent:  this.yearsScrollingPanel, worldPositionStays:  false);
        val_9.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.UI.Text val_12 = val_9.GetComponentInChildren<UnityEngine.UI.Text>();
        val_19 = null;
        val_19 = null;
        val_7 = val_7 - 1900;
        string val_13 = 0 + System.String.Empty;
        string val_14 = 0 + "Year_";
        if(val_9 != null)
        {
                val_9.name = val_14;
        }
        else
        {
                0.name = val_14;
        }
        
        UnityEngine.CanvasGroup val_15 = val_9.AddComponent<UnityEngine.CanvasGroup>();
        if(val_7 < this.yearsButtons.Length)
        {
            goto label_29;
        }
        
        goto label_29;
    }
    private void InitializeMonths()
    {
        var val_14;
        var val_15;
        var val_16;
        var val_18;
        val_14 = null;
        val_15 = 0;
        val_16 = 0;
        mem[1152921512660849112] = val_14;
        val_18 = null;
        val_18 = null;
        var val_2 = null + (((long)(int)((W23 + 1))) << 2);
        mem2[0] = ;
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_14 = UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
        val_14.transform.SetParent(parent:  mem[1152921512660849064], worldPositionStays:  false);
        val_14.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        if((( < 12) ? ( + 11) : 0) > 22)
        {
                return;
        }
        
        var val_13 = 25804740 + (val_16 < 0xC ? ((W23 + 1) + 11) : 0) << 2;
        val_13 = val_13 + 25804740;
        goto (25804740 + (val_16 < 0xC ? ((W23 + 1) + 11) : 0) << 2 + 25804740);
    }
    private void InitializeDays()
    {
        var val_13;
        var val_14;
        var val_15;
        this.daysButtons = null;
        val_13 = 0;
        val_14 = 0;
        goto label_2;
        label_27:
        val_13 = 80;
        (System.Int32[].__il2cppRuntimeField_namespaze + (X27) << 3).__unknownFiledOffset_20 = val_14;
        val_14 = W25 + 1;
        label_2:
        var val_2 = null + (((long)(int)((W25 + 1))) << 2);
        var val_3 = val_14 + 1;
        mem2[0] = val_3;
        UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        TzarGames.GameFramework.TzarBehaviour val_5 = UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w});
        val_5.transform.SetParent(parent:  this.daysScrollingPanel, worldPositionStays:  false);
        val_5.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.UI.Text val_8 = val_5.GetComponentInChildren<UnityEngine.UI.Text>();
        val_15 = null;
        val_15 = null;
        val_3 = val_3 - 1;
        string val_9 = 0 + System.String.Empty;
        string val_10 = 0 + "Day_";
        if(val_5 != null)
        {
                val_5.name = val_10;
        }
        else
        {
                0.name = val_10;
        }
        
        UnityEngine.CanvasGroup val_11 = val_5.AddComponent<UnityEngine.CanvasGroup>();
        if(val_3 < this.daysButtons.Length)
        {
            goto label_27;
        }
        
        goto label_27;
    }
    public void Awake()
    {
        this.InitializeYears();
        this.InitializeMonths();
        this.InitializeDays();
        this.monthsVerticalScroller = new UnityEngine.UI.Extensions.UIVerticalScroller(scrollingPanel:  this.monthsScrollingPanel, arrayOfElements:  this.monthsButtons, center:  this.monthCenter);
        this.yearsVerticalScroller = new UnityEngine.UI.Extensions.UIVerticalScroller(scrollingPanel:  this.yearsScrollingPanel, arrayOfElements:  this.yearsButtons, center:  this.yearsCenter);
        this.daysVerticalScroller = new UnityEngine.UI.Extensions.UIVerticalScroller(scrollingPanel:  this.daysScrollingPanel, arrayOfElements:  this.daysButtons, center:  this.daysCenter);
        this.monthsVerticalScroller.Start();
        this.yearsVerticalScroller.Start();
        this.daysVerticalScroller.Start();
    }
    public void SetDate()
    {
        string val_1 = this.inputFieldDays.text;
        this.daysSet = (System.Int32.Parse(s:  0)) - 1;
        string val_4 = this.inputFieldMonths.text;
        this.monthsSet = (System.Int32.Parse(s:  0)) - 1;
        string val_7 = this.inputFieldYears.text;
        this.yearsSet = (System.Int32.Parse(s:  0)) - 1900;
        this.daysVerticalScroller.SnapToElement(element:  this.daysSet);
        this.monthsVerticalScroller.SnapToElement(element:  this.monthsSet);
        this.yearsVerticalScroller.SnapToElement(element:  this.yearsSet);
    }
    private void Update()
    {
        var val_12;
        this.monthsVerticalScroller.Update();
        this.yearsVerticalScroller.Update();
        this.daysVerticalScroller.Update();
        string val_1 = this.daysVerticalScroller.GetResults();
        if(((val_1.EndsWith(value:  "1")) != false) && ((System.String.op_Inequality(a:  0, b:  val_1)) != false))
        {
                val_12 = "st";
        }
        else
        {
                if(((val_1.EndsWith(value:  "2")) != false) && ((System.String.op_Inequality(a:  0, b:  val_1)) != false))
        {
                val_12 = "nd";
        }
        else
        {
                if(((val_1.EndsWith(value:  "3")) != false) && ((System.String.op_Inequality(a:  0, b:  val_1)) != false))
        {
                val_12 = "rd";
        }
        else
        {
                val_12 = "th";
        }
        
        }
        
        }
        
        typeof(System.String[]).__il2cppRuntimeField_20 = this.monthsVerticalScroller.GetResults();
        typeof(System.String[]).__il2cppRuntimeField_28 = " ";
        typeof(System.String[]).__il2cppRuntimeField_30 = 0 + val_1;
        typeof(System.String[]).__il2cppRuntimeField_38 = " ";
        typeof(System.String[]).__il2cppRuntimeField_40 = this.yearsVerticalScroller.GetResults();
        string val_11 = +0;
        if(this.dateText == null)
        {
            
        }
    
    }
    public void DaysScrollUp()
    {
        this.daysVerticalScroller.ScrollUp();
    }
    public void DaysScrollDown()
    {
        this.daysVerticalScroller.ScrollDown();
    }
    public void MonthsScrollUp()
    {
        this.monthsVerticalScroller.ScrollUp();
    }
    public void MonthsScrollDown()
    {
        this.monthsVerticalScroller.ScrollDown();
    }
    public void YearsScrollUp()
    {
        this.yearsVerticalScroller.ScrollUp();
    }
    public void YearsScrollDown()
    {
        this.yearsVerticalScroller.ScrollDown();
    }

}
