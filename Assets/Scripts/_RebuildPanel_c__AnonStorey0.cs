using UnityEngine;
private sealed class DropDownList.<RebuildPanel>c__AnonStorey0
{
    // Fields
    internal int ii;
    internal UnityEngine.UI.Extensions.DropDownListItem item;
    internal UnityEngine.UI.Extensions.DropDownList $this;
    
    // Methods
    public DropDownList.<RebuildPanel>c__AnonStorey0()
    {
    
    }
    internal void <>m__0()
    {
        this.$this.OnItemClicked(indx:  this.ii);
        if(this.item.OnSelect == null)
        {
                return;
        }
        
        this.item.OnSelect.Invoke();
    }

}
