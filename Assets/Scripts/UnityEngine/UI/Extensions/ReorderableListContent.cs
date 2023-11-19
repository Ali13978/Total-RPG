using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    public class ReorderableListContent : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.Transform> _cachedChildren;
        private System.Collections.Generic.List<UnityEngine.UI.Extensions.ReorderableListElement> _cachedListElement;
        private UnityEngine.UI.Extensions.ReorderableListElement _ele;
        private UnityEngine.UI.Extensions.ReorderableList _extList;
        private UnityEngine.RectTransform _rect;
        
        // Methods
        public ReorderableListContent()
        {
        
        }
        public void OnTransformChildrenChanged()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.RefreshChildren());
        }
        public void Init(UnityEngine.UI.Extensions.ReorderableList extList)
        {
            this._extList = extList;
            this._rect = this.GetComponent<UnityEngine.RectTransform>();
            this._cachedChildren = new System.Collections.Generic.List<UnityEngine.Transform>();
            this._cachedListElement = new System.Collections.Generic.List<UnityEngine.UI.Extensions.ReorderableListElement>();
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.RefreshChildren());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator RefreshChildren()
        {
            typeof(ReorderableListContent.<RefreshChildren>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
