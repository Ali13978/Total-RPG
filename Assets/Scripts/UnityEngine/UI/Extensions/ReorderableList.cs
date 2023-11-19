using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.RequireComponent]
    [UnityEngine.DisallowMultipleComponent]
    [UnityEngine.AddComponentMenu]
    public class ReorderableList : MonoBehaviour
    {
        // Fields
        [UnityEngine.TooltipAttribute]
        public UnityEngine.UI.LayoutGroup ContentLayout;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.RectTransform DraggableArea;
        [UnityEngine.TooltipAttribute]
        public bool IsDraggable;
        [UnityEngine.TooltipAttribute]
        public bool CloneDraggedObject;
        [UnityEngine.TooltipAttribute]
        public bool IsDropable;
        [UnityEngine.HeaderAttribute]
        public UnityEngine.UI.Extensions.ReorderableList.ReorderableListHandler OnElementDropped;
        public UnityEngine.UI.Extensions.ReorderableList.ReorderableListHandler OnElementGrabbed;
        public UnityEngine.UI.Extensions.ReorderableList.ReorderableListHandler OnElementRemoved;
        private UnityEngine.RectTransform _content;
        private UnityEngine.UI.Extensions.ReorderableListContent _listContent;
        
        // Properties
        public UnityEngine.RectTransform Content { get; }
        
        // Methods
        public ReorderableList()
        {
            this.IsDropable = true;
            this.IsDraggable = true;
            this.OnElementDropped = new ReorderableList.ReorderableListHandler();
            this.OnElementGrabbed = new ReorderableList.ReorderableListHandler();
            this.OnElementRemoved = new ReorderableList.ReorderableListHandler();
        }
        public UnityEngine.RectTransform get_Content()
        {
            UnityEngine.RectTransform val_4;
            if(0 == this._content)
            {
                    this._content = this.ContentLayout.GetComponent<UnityEngine.RectTransform>();
                return val_4;
            }
            
            val_4 = this._content;
            return val_4;
        }
        private UnityEngine.Canvas GetCanvas()
        {
            var val_8;
            UnityEngine.Transform val_1 = this.transform;
            val_8 = 0;
            goto label_1;
            label_12:
            val_8 = 1;
            label_1:
            if(val_8 > 99)
            {
                    return (UnityEngine.Canvas)0;
            }
            
            if(((UnityEngine.Object.op_Equality(x:  0, y:  0)) ^ 1) == true)
            {
                    return (UnityEngine.Canvas)0;
            }
            
            if(0 != (val_1.gameObject.GetComponent<UnityEngine.Canvas>()))
            {
                goto label_12;
            }
            
            UnityEngine.Transform val_7 = val_1.parent;
            goto label_12;
        }
        private void Awake()
        {
            if(0 != this.ContentLayout)
            {
                goto label_3;
            }
            
            string val_2 = this.name;
            string val_3 = 0 + "You need to have a child LayoutGroup content set for the list: "("You need to have a child LayoutGroup content set for the list: ");
            goto label_6;
            label_3:
            if(0 == this.DraggableArea)
            {
                    this.DraggableArea = this.transform.root.GetComponentInChildren<UnityEngine.Canvas>().GetComponent<UnityEngine.RectTransform>();
            }
            
            if(this.IsDropable == false)
            {
                goto label_13;
            }
            
            UnityEngine.UI.Graphic val_9 = this.GetComponent<UnityEngine.UI.Graphic>();
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                goto label_16;
            }
            
            label_13:
            if(this.GetCanvas().renderMode != 0)
            {
                    UnityEngine.Debug.LogError(message:  0);
            }
            
            UnityEngine.UI.Extensions.ReorderableListContent val_15 = this.ContentLayout.gameObject.AddComponent<UnityEngine.UI.Extensions.ReorderableListContent>();
            this._listContent = val_15;
            val_15.Init(extList:  this);
            return;
            label_16:
            label_6:
            UnityEngine.GameObject val_18 = this.gameObject;
            UnityEngine.Debug.LogError(message:  0, context:  0 + "You need to have a Graphic control (such as an Image) for the list [" + this.name);
        }
        public void TestReOrderableListTarget(UnityEngine.UI.Extensions.ReorderableList.ReorderableListEventStruct item)
        {
            UnityEngine.Debug.Log(message:  0);
            string val_1 = 0 + "Hello World, is my item a clone? ["("Hello World, is my item a clone? [") + item.IsAClone;
            UnityEngine.Debug.Log(message:  0);
        }
    
    }

}
