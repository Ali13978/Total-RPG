using UnityEngine;
[UnityEngine.RequireComponent]
public class NetworkCullingHandler : MonoBehaviour, IPunObservable
{
    // Fields
    private int orderIndex;
    private CullArea cullArea;
    private System.Collections.Generic.List<byte> previousActiveCells;
    private System.Collections.Generic.List<byte> activeCells;
    private PhotonView pView;
    private UnityEngine.Vector3 lastPosition;
    private UnityEngine.Vector3 currentPosition;
    
    // Methods
    public NetworkCullingHandler()
    {
    
    }
    private void OnEnable()
    {
        if(0 == this.pView)
        {
                PhotonView val_2 = this.GetComponent<PhotonView>();
            this.pView = val_2;
            if(val_2.isMine == false)
        {
                return;
        }
        
        }
        
        if(0 == this.cullArea)
        {
                this.cullArea = UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>();
        }
        
        1152921504721543168 = 1152921504617496576;
        this.previousActiveCells = new System.Collections.Generic.List<System.Byte>(capacity:  0);
        this.activeCells = new System.Collections.Generic.List<System.Byte>(capacity:  0);
        UnityEngine.Vector3 val_9 = this.transform.position;
        this.lastPosition = val_9;
        mem[1152921512470637252] = val_9.y;
        mem[1152921512470637256] = val_9.z;
        this.currentPosition = val_9;
        mem[1152921512470637264] = val_9.y;
        mem[1152921512470637268] = val_9.z;
    }
    private void Start()
    {
        if(this.pView.isMine == false)
        {
                return;
        }
        
        if(PhotonNetwork.inRoom == false)
        {
                return;
        }
        
        if(this.cullArea.NumberOfSubdivisions != 0)
        {
                this.pView.ObservedComponents.Add(item:  this);
            return;
        }
        
        this.pView.group = this.cullArea.FIRST_GROUP_ID;
        PhotonNetwork.SetInterestGroups(group:  0, enabled:  this.cullArea.FIRST_GROUP_ID);
    }
    private void Update()
    {
        if(this.pView.isMine == false)
        {
                return;
        }
        
        this.lastPosition = this.currentPosition;
        mem[1152921512470939076] = ???;
        mem[1152921512470939080] = ???;
        UnityEngine.Vector3 val_3 = this.transform.position;
        this.currentPosition = val_3;
        mem[1152921512470939088] = val_3.y;
        mem[1152921512470939092] = val_3.z;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, rhs:  new UnityEngine.Vector3() {x = this.lastPosition, y = V12.16B, z = V11.16B})) == false)
        {
                return;
        }
        
        if(this.HaveActiveCellsChanged() == false)
        {
                return;
        }
        
        this.UpdateInterestGroups();
    }
    private void OnGUI()
    {
        var val_16;
        PhotonView val_17;
        object val_18;
        var val_19;
        val_16 = this;
        val_17 = this.pView;
        if(val_17.isMine == false)
        {
                return;
        }
        
        val_18 = "Subscribed cells:\n";
        val_19 = 0;
        goto label_3;
        label_14:
        val_18 = 0 + val_18 + X23;
        val_19 = 1;
        label_3:
        if(val_19 >= this.activeCells.Count)
        {
            goto label_5;
        }
        
        if(val_19 <= this.cullArea.NumberOfSubdivisions)
        {
                string val_5 = 0 + "Inside cells:\n"("Inside cells:\n") + this.activeCells.Item[1];
        }
        
        byte val_6 = this.activeCells.Item[1];
        goto label_14;
        label_5:
        float val_16 = (float)UnityEngine.Screen.height;
        val_16 = val_16 + (-120f);
        UnityEngine.GUIStyle val_9 = new UnityEngine.GUIStyle();
        if(null != 0)
        {
                alignment = 0;
        }
        else
        {
                alignment = 0;
        }
        
        fontSize = 16;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  0 + "<color=white>PhotonView Group: "("<color=white>PhotonView Group: ") + this.pView.group);
        float val_17 = (float)UnityEngine.Screen.height;
        val_17 = val_17 + (-100f);
        UnityEngine.GUIStyle val_12 = null;
        val_16 = val_12;
        val_12 = new UnityEngine.GUIStyle();
        if(null != 0)
        {
                alignment = 0;
        }
        else
        {
                alignment = 0;
        }
        
        fontSize = 16;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  0 + "<color=white>"("<color=white>") + "Inside cells:\n"("Inside cells:\n"));
        float val_18 = (float)UnityEngine.Screen.height;
        val_18 = val_18 + (-60f);
        val_17 = 0 + "<color=white>"("<color=white>") + val_18;
        UnityEngine.GUIStyle val_15 = new UnityEngine.GUIStyle();
        if(null != 0)
        {
                alignment = 0;
        }
        else
        {
                alignment = 0;
        }
        
        fontSize = 16;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  0, style:  val_17);
    }
    private bool HaveActiveCellsChanged()
    {
        var val_12;
        System.Collections.Generic.List<System.Byte> val_13;
        System.Collections.Generic.List<System.Byte> val_14;
        var val_15;
        val_12 = this;
        if(this.cullArea.NumberOfSubdivisions == 0)
        {
            goto label_2;
        }
        
        this.previousActiveCells = new System.Collections.Generic.List<System.Byte>(collection:  this.activeCells);
        UnityEngine.Transform val_2 = this.transform;
        UnityEngine.Vector3 val_3 = val_2.position;
        val_13 = this.cullArea.GetActiveCells(position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        this.activeCells = val_13;
        goto label_5;
        label_11:
        val_13.Add(item:  val_2);
        val_13 = this.activeCells;
        label_5:
        if(val_13.Count > this.cullArea.NumberOfSubdivisions)
        {
            goto label_8;
        }
        
        if(this.activeCells != null)
        {
            goto label_11;
        }
        
        goto label_11;
        label_8:
        val_14 = this.previousActiveCells;
        if(this.activeCells.Count != val_14.Count)
        {
            goto label_14;
        }
        
        val_12 = this.activeCells.Item[this.cullArea.NumberOfSubdivisions];
        val_14 = this.cullArea.NumberOfSubdivisions;
        var val_11 = ((val_12 & 255) != this.previousActiveCells.Item[val_14]) ? 1 : 0;
        return (bool)val_15;
        label_2:
        val_15 = 0;
        return (bool)val_15;
        label_14:
        val_15 = 1;
        return (bool)val_15;
    }
    private void UpdateInterestGroups()
    {
        var val_4;
        System.Collections.Generic.List<T> val_10;
        var val_11;
        System.Collections.Generic.List<System.Byte> val_1 = new System.Collections.Generic.List<System.Byte>(capacity:  0);
        List.Enumerator<T> val_2 = this.previousActiveCells.GetEnumerator();
        label_6:
        if((0 & 1) == 0)
        {
            goto label_2;
        }
        
        bool val_5 = val_4.EnableSavedGames;
        if((this.activeCells.Contains(item:  val_5)) == true)
        {
            goto label_6;
        }
        
        Add(item:  val_5);
        goto label_6;
        label_2:
        val_10 = 0;
        val_11 = 1;
        val_4.Dispose();
        T[] val_9 = this.activeCells.ToArray();
        PhotonNetwork.SetInterestGroups(disableGroups:  0, enableGroups:  ToArray());
    }
    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        byte val_9;
        CullArea val_10;
        System.Collections.Generic.List<System.Byte> val_11;
        int val_12;
        System.Int32[] val_13;
        val_9 = this;
        goto label_1;
        label_7:
        Add(item:  W21);
        label_1:
        val_10 = this.cullArea;
        if(this.activeCells.Count > this.cullArea.NumberOfSubdivisions)
        {
            goto label_4;
        }
        
        if(this.activeCells != null)
        {
            goto label_7;
        }
        
        goto label_7;
        label_4:
        if(this.cullArea.NumberOfSubdivisions != 1)
        {
            goto label_9;
        }
        
        int val_2 = this.orderIndex + 1;
        this.orderIndex = val_2;
        val_11 = this.activeCells;
        val_10 = this.pView;
        val_12 = val_2 - ((val_2 / this.cullArea.SUBDIVISION_FIRST_LEVEL_ORDER.Length) * this.cullArea.SUBDIVISION_FIRST_LEVEL_ORDER.Length);
        this.orderIndex = val_12;
        if(this.cullArea == null)
        {
                val_12 = this.orderIndex;
        }
        
        val_13 = this.cullArea.SUBDIVISION_FIRST_LEVEL_ORDER;
        if(val_13 != null)
        {
            goto label_27;
        }
        
        goto label_21;
        label_9:
        if(this.cullArea.NumberOfSubdivisions != 2)
        {
            goto label_16;
        }
        
        int val_4 = this.orderIndex + 1;
        this.orderIndex = val_4;
        val_11 = this.activeCells;
        val_10 = this.pView;
        val_12 = val_4 - ((val_4 / this.cullArea.SUBDIVISION_SECOND_LEVEL_ORDER.Length) * this.cullArea.SUBDIVISION_SECOND_LEVEL_ORDER.Length);
        this.orderIndex = val_12;
        if(this.cullArea == null)
        {
                val_12 = this.orderIndex;
        }
        
        val_13 = this.cullArea.SUBDIVISION_SECOND_LEVEL_ORDER;
        if(val_13 != null)
        {
            goto label_27;
        }
        
        goto label_21;
        label_16:
        if(this.cullArea.NumberOfSubdivisions != 3)
        {
                return;
        }
        
        int val_6 = this.orderIndex + 1;
        this.orderIndex = val_6;
        val_11 = this.activeCells;
        val_10 = this.pView;
        val_12 = val_6 - ((val_6 / this.cullArea.SUBDIVISION_THIRD_LEVEL_ORDER.Length) * this.cullArea.SUBDIVISION_THIRD_LEVEL_ORDER.Length);
        this.orderIndex = val_12;
        if(this.cullArea == null)
        {
                val_12 = this.orderIndex;
        }
        
        val_13 = this.cullArea.SUBDIVISION_THIRD_LEVEL_ORDER;
        if(val_13 != null)
        {
            goto label_27;
        }
        
        label_21:
        label_27:
        val_9 = val_11.Item[val_13[(long)val_12]];
        this.pView.group = val_9;
    }

}
