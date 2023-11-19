using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    public class BestFitOutline : Shadow
    {
        // Methods
        protected BestFitOutline()
        {
        
        }
        public override void ModifyMesh(UnityEngine.Mesh mesh)
        {
            var val_51;
            UnityEngine.Mesh val_52;
            System.Collections.Generic.List<UnityEngine.UIVertex> val_53;
            var val_54;
            var val_55;
            float val_56;
            float val_57;
            float val_58;
            var val_59;
            int val_60;
            var val_61;
            int val_62;
            float val_63;
            var val_64;
            var val_65;
            val_52 = mesh;
            if(this.IsActive() == false)
            {
                goto label_37;
            }
            
            System.Collections.Generic.List<UnityEngine.UIVertex> val_2 = null;
            val_53 = val_2;
            val_2 = new System.Collections.Generic.List<UnityEngine.UIVertex>();
            GetUIVertexStream(stream:  val_53);
            val_54 = 0;
            if(null == 0)
            {
                goto label_3;
            }
            
            UnityEngine.UI.VertexHelper val_50 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_4;
            }
            
            var val_48 = mem[null + 152];
            var val_49 = 0;
            val_48 = val_48 + 8;
            label_6:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_49 = val_49 + 1;
            val_48 = val_48 + 16;
            if(val_49 < (mem[null + 258]))
            {
                goto label_6;
            }
            
            label_4:
            val_55 = new UnityEngine.UI.VertexHelper(m:  val_52);
            goto label_7;
            label_5:
            val_50 = val_50 + (((mem[null + 152] + 8)) << 4);
            label_7:
            label_3:
            if(50 == 50)
            {
                
            }
            else
            {
                    val_54 = 0;
            }
            
            UnityEngine.UI.Text val_4 = this.GetComponent<UnityEngine.UI.Text>();
            val_56 = 1f;
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    if(val_4.resizeTextForBestFit != false)
            {
                    val_56 = (float)val_4.cachedTextGenerator.fontSizeUsedForBestFit / ((float)val_4.resizeTextMaxSize - 1);
            }
            
            }
            
            UnityEngine.Color val_12 = this.effectColor;
            UnityEngine.Color32 val_13 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_12.r, g = val_12.g, b = val_12.b, a = val_12.a});
            if(null != 0)
            {
                    UnityEngine.Vector2 val_15 = this.effectDistance;
                UnityEngine.Vector2 val_16 = this.effectDistance;
                val_57 = val_56 * val_15.x;
                val_58 = val_56 * val_16.y;
                this.ApplyShadowZeroAlloc(verts:  val_53, color:  new UnityEngine.Color32() {r = val_13.r & 4294967295, g = val_13.r & 4294967295, b = val_13.r & 4294967295, a = val_13.r & 4294967295}, start:  0, end:  Count, x:  val_57, y:  val_58);
            }
            else
            {
                    UnityEngine.Vector2 val_19 = this.effectDistance;
                UnityEngine.Vector2 val_20 = this.effectDistance;
                val_57 = val_56 * val_19.x;
                val_58 = val_56 * val_20.y;
                this.ApplyShadowZeroAlloc(verts:  val_53, color:  new UnityEngine.Color32() {r = val_13.r & 4294967295, g = val_13.r & 4294967295, b = val_13.r & 4294967295, a = val_13.r & 4294967295}, start:  0, end:  Count, x:  val_57, y:  val_58);
            }
            
            UnityEngine.Color val_23 = this.effectColor;
            UnityEngine.Color32 val_24 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_23.r, g = val_23.g, b = val_23.b, a = val_23.a});
            if(null != 0)
            {
                    val_59 = 0;
            }
            else
            {
                    val_59 = 1;
            }
            
            UnityEngine.Vector2 val_26 = this.effectDistance;
            UnityEngine.Vector2 val_27 = this.effectDistance;
            val_27.y = -(val_56 * val_27.y);
            this.ApplyShadowZeroAlloc(verts:  val_53, color:  new UnityEngine.Color32() {r = val_24.r & 4294967295, g = val_24.r & 4294967295, b = val_24.r & 4294967295, a = val_24.r & 4294967295}, start:  Count, end:  Count, x:  val_56 * val_26.x, y:  val_27.y);
            val_60 = Count;
            UnityEngine.Color val_31 = this.effectColor;
            UnityEngine.Color32 val_32 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_31.r, g = val_31.g, b = val_31.b, a = val_31.a});
            if(null != 0)
            {
                    val_61 = 0;
            }
            else
            {
                    val_61 = 1;
            }
            
            UnityEngine.Vector2 val_34 = this.effectDistance;
            UnityEngine.Vector2 val_35 = this.effectDistance;
            val_35.y = val_56 * val_35.y;
            this.ApplyShadowZeroAlloc(verts:  val_53, color:  new UnityEngine.Color32() {r = val_32.r & 4294967295, g = val_32.r & 4294967295, b = val_32.r & 4294967295, a = val_32.r & 4294967295}, start:  Count, end:  Count, x:  -(val_56 * val_34.x), y:  val_35.y);
            int val_38 = Count;
            UnityEngine.Color val_39 = this.effectColor;
            UnityEngine.Color32 val_40 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_39.r, g = val_39.g, b = val_39.b, a = val_39.a});
            val_62 = Count;
            UnityEngine.Vector2 val_42 = this.effectDistance;
            val_63 = val_42.x;
            UnityEngine.Vector2 val_43 = this.effectDistance;
            val_43.y = -(val_56 * val_43.y);
            this.ApplyShadowZeroAlloc(verts:  val_53, color:  new UnityEngine.Color32() {r = val_40.r & 4294967295, g = val_40.r & 4294967295, b = val_40.r & 4294967295, a = val_40.r & 4294967295}, start:  val_60, end:  val_62, x:  -(val_56 * val_63), y:  val_43.y);
            AddUIVertexTriangleStream(verts:  val_53);
            FillMesh(mesh:  val_52);
            val_52 = val_54;
            val_64 = 442;
            if(null == 0)
            {
                goto label_31;
            }
            
            UnityEngine.UI.VertexHelper val_53 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_32;
            }
            
            var val_51 = mem[null + 152];
            var val_52 = 0;
            val_51 = val_51 + 8;
            label_34:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_33;
            }
            
            val_52 = val_52 + 1;
            val_51 = val_51 + 16;
            if(val_52 < (mem[null + 258]))
            {
                goto label_34;
            }
            
            label_32:
            val_65 = new UnityEngine.UI.VertexHelper();
            goto label_35;
            label_33:
            val_53 = val_53 + (((mem[null + 152] + 8)) << 4);
            label_35:
            label_31:
            if((442 != 442) && (val_52 != 0))
            {
                    val_51 = ???;
                val_52 = ???;
                val_53 = ???;
                val_60 = ???;
                val_62 = ???;
                val_64 = ???;
                val_63 = ???;
            }
            
            label_37:
            var val_47 = val_51 - 96;
        }
    
    }

}
