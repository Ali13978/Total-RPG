using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    public class CurvedText : BaseMeshEffect
    {
        // Fields
        public UnityEngine.AnimationCurve curveForText;
        public float curveMultiplier;
        private UnityEngine.RectTransform rectTrans;
        
        // Methods
        public CurvedText()
        {
            this.curveMultiplier = 1f;
            this.curveForText = UnityEngine.AnimationCurve.Linear(timeStart:  0f, valueStart:  0f, timeEnd:  1f, valueEnd:  10f);
        }
        protected override void Awake()
        {
            this.Awake();
            this.rectTrans = this.GetComponent<UnityEngine.RectTransform>();
            goto typeof(UnityEngine.UI.Extensions.CurvedText).__il2cppRuntimeField_1B0;
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this.rectTrans = this.GetComponent<UnityEngine.RectTransform>();
            goto typeof(UnityEngine.UI.Extensions.CurvedText).__il2cppRuntimeField_1B0;
        }
        public override void ModifyMesh(UnityEngine.UI.VertexHelper vh)
        {
            float val_6;
            float val_9;
            var val_11 = vh.currentVertCount;
            if(val_11 == 0)
            {
                    return;
            }
            
            if(this.IsActive() ^ 1 == true)
            {
                    return;
            }
            
            val_11 = 0;
            goto label_3;
            label_11:
            vh.SetUIVertex(vertex:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2(), tangent = new UnityEngine.Vector4()}, i:  0);
            val_11 = 1;
            label_3:
            if(val_11 >= vh.currentVertCount)
            {
                    return;
            }
            
            vh.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2(), tangent = new UnityEngine.Vector4()}, i:  1);
            UnityEngine.Rect val_7 = this.rectTrans.rect;
            UnityEngine.Vector2 val_8 = this.rectTrans.pivot;
            val_8.x = val_7.m_XMin * val_8.x;
            val_8.x = val_9 + val_8.x;
            float val_10 = this.curveForText.Evaluate(time:  val_8.x);
            val_10 = val_10 * this.curveMultiplier;
            val_10 = val_6 + val_10;
            val_6 = val_10;
            if(vh != null)
            {
                goto label_11;
            }
            
            goto label_11;
        }
        protected override void OnRectTransformDimensionsChange()
        {
            var val_9;
            if(this.curveForText != null)
            {
                    val_9 = this.curveForText.length;
            }
            else
            {
                    val_9 = 0.length;
            }
            
            UnityEngine.Keyframe val_4 = this.curveForText.Item[val_9 - 1];
            UnityEngine.Rect val_5 = this.rectTrans.rect;
            val_4.m_Time.startFloat = val_5.m_XMin;
            int val_8 = this.curveForText.MoveKey(index:  this.curveForText.length - 1, key:  new UnityEngine.Keyframe() {m_Time = val_4.m_Time, m_Value = val_4.m_Value, m_InTangent = val_4.m_InTangent, m_OutTangent = val_4.m_OutTangent});
        }
    
    }

}
