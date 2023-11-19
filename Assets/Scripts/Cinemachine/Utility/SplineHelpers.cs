using UnityEngine;

namespace Cinemachine.Utility
{
    internal static class SplineHelpers
    {
        // Methods
        public static UnityEngine.Vector3 Bezier3(float t, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3)
        {
            float val_1;
            float val_2;
            float val_3 = UnityEngine.Mathf.Clamp01(value:  t);
            float val_14 = 1f;
            float val_4 = val_14 - val_3;
            val_14 = val_4 * val_4;
            val_14 = val_4 * val_14;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(d:  val_14, a:  new UnityEngine.Vector3() {x = p0.x, y = p0.y, z = p0.z});
            float val_15 = 3f;
            float val_6 = val_4 * val_15;
            val_15 = val_4 * val_6;
            val_15 = val_3 * val_15;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(d:  val_15, a:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z});
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            float val_9 = val_3 * val_6;
            val_9 = val_3 * val_9;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(d:  val_9, a:  new UnityEngine.Vector3() {x = p2.x, y = val_2, z = p2.y});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            float val_12 = val_3 * val_3;
            val_12 = val_3 * val_12;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(d:  val_12, a:  new UnityEngine.Vector3() {x = p2.z, y = val_1, z = p3.x});
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        }
        public static UnityEngine.Vector3 BezierTangent3(float t, UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3)
        {
            float val_1;
            float val_2;
            float val_3 = UnityEngine.Mathf.Clamp01(value:  t);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(d:  -3f, a:  new UnityEngine.Vector3() {x = p0.x, y = p0.y, z = p0.z});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(d:  9f, a:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z});
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(d:  9f, a:  new UnityEngine.Vector3() {x = p2.x, y = val_2, z = p2.y});
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = p2.z, y = val_1, z = p3.x});
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  val_3);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  val_3);
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(d:  6f, a:  new UnityEngine.Vector3() {x = p0.x, y = p0.y, z = p0.z});
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(d:  12f, a:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z});
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(d:  6f, a:  new UnityEngine.Vector3() {x = p2.x, y = val_2, z = p2.y});
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, d:  val_3);
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = p0.x, y = p0.y, z = p0.z});
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z});
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
        }
        public static float Bezier1(float t, float p0, float p1, float p2, float p3)
        {
            float val_1 = UnityEngine.Mathf.Clamp01(value:  t);
            float val_5 = 1f;
            float val_6 = 3f;
            val_5 = val_5 - val_1;
            float val_2 = val_5 * val_5;
            val_6 = val_5 * val_6;
            val_2 = val_5 * val_2;
            val_5 = val_5 * val_6;
            float val_3 = val_1 * val_1;
            val_6 = val_1 * val_6;
            val_5 = val_1 * val_5;
            val_2 = val_2 * p0;
            val_3 = val_1 * val_3;
            val_1 = val_1 * val_6;
            val_5 = val_5 * p1;
            val_1 = val_1 * p2;
            val_5 = val_2 + val_5;
            val_1 = val_1 + val_5;
            val_1 = (val_3 * p3) + val_1;
            return (float)val_1;
        }
        public static float BezierTangent1(float t, float p0, float p1, float p2, float p3)
        {
            float val_1 = UnityEngine.Mathf.Clamp01(value:  t);
            float val_9 = 6f;
            float val_7 = -12f;
            val_7 = p1 * val_7;
            float val_10 = 3f;
            val_7 = (p0 * val_9) + val_7;
            float val_8 = 9f;
            float val_3 = p0 * val_10;
            val_8 = p1 * val_8;
            val_8 = val_8 - val_3;
            val_9 = p2 * val_9;
            val_8 = val_8 - (p2 * val_8);
            val_9 = val_7 + val_9;
            float val_6 = val_8 + (p3 * val_10);
            val_6 = val_6 * val_1;
            val_9 = val_9 * val_1;
            val_1 = val_1 * val_6;
            val_10 = p1 * val_10;
            val_1 = val_9 + val_1;
            val_1 = val_1 - val_3;
            val_1 = val_10 + val_1;
            return (float)val_1;
        }
        public static void ComputeSmoothControlPoints(ref UnityEngine.Vector4[] knot, ref UnityEngine.Vector4[] ctrl1, ref UnityEngine.Vector4[] ctrl2)
        {
            int val_41;
            var val_42;
            float val_43;
            var val_44;
            float val_46;
            var val_48;
            float val_49;
            float val_50;
            var val_51;
            UnityEngine.Vector4[] val_52;
            val_41 = mem[ctrl1 + 24];
            val_41 = ctrl1.Length;
            int val_1 = val_41 - 2;
            if()
            {
                goto label_2;
            }
            
            val_42 = null;
            int val_5 = val_41 - 3;
            var val_7 = (null + (val_1 << 2)) + 32;
            float val_8 = 1152921505848467328 + (val_1 << 2);
            var val_9 = 1152921505848467328 + (val_1 << 2);
            float val_10 = 1152921505848467328 + (val_1 << 2);
            var val_11 = 1152921505848467328 + (val_5 << 2);
            var val_12 = 1152921505848467328 + (val_5 << 2);
            var val_13 = 1152921505848467328 + (val_5 << 2);
            val_43 = 4f;
            val_13 = val_13 + 32;
            label_87:
            typeof(System.Single[]).__il2cppRuntimeField_20 = 0;
            typeof(System.Single[]).__il2cppRuntimeField_20 = 1073741824;
            typeof(System.Single[]).__il2cppRuntimeField_20 = 1065353216;
            float val_46 = V0.16B;
            float val_14 = V0.16B + V0.16B;
            val_46 = val_46 + val_14;
            typeof(System.Single[]).__il2cppRuntimeField_20 = val_46;
            val_44 = 1;
            goto label_15;
            label_29:
            var val_15 = null + (((ctrl1.Length - 2)) << 2);
            mem2[0] = val_46;
            label_15:
            if(val_44 >= (long)val_1)
            {
                goto label_17;
            }
            
            mem[1152921505848467332] = 1065353216;
            mem[1152921505848467332] = 1082130432;
            mem[1152921505848467332] = 1f;
            int val_16 = ctrl1.Length + 32;
            float val_47 = val_14;
            UnityEngine.Vector4[] val_18 = ctrl1 + (((long)(int)((val_44 + 1))) << 4);
            val_14 = val_47 * val_43;
            val_47 = val_14 + (val_14 + val_14);
            var val_20 = ((long)val_44 + 1) - 1;
            goto label_29;
            label_17:
            mem2[0] = 1073741824;
            mem2[0] = 1088421888;
            mem2[0] = 0;
            UnityEngine.Vector4[] val_21 = ctrl1 + (((long)(int)((ctrl1.Length - 2))) << 4);
            float val_48 = val_14;
            UnityEngine.Vector4[] val_22 = ctrl1 + (((long)(int)((ctrl1.Length - 1))) << 4);
            val_14 = val_48 * 8f;
            val_48 = val_14 + val_14;
            mem2[0] = val_48;
            if(((long)val_41 - 1) >= 2)
            {
                    var val_53 = 0;
                do
            {
                var val_49 = 1;
                float val_50 = mem[1152921505848467332];
                var val_23 = val_49 - 1;
                float val_51 = typeof(System.Single[]).__il2cppRuntimeField_20;
                val_23 = val_23 + 1;
                val_49 = val_23 - 1;
                val_50 = val_50 / val_51;
                val_46 = typeof(System.Single[]).__il2cppRuntimeField_20;
                val_51 = mem[1152921505848467332] - (val_50 * val_46);
                val_49 = val_49 + 1;
                mem[1152921505848467332] = val_51;
                val_23 = val_49 - 1;
                float val_52 = typeof(System.Single[]).__il2cppRuntimeField_20;
                val_23 = val_23 + 1;
                val_52 = val_50 * val_52;
                val_50 = mem[1152921505848467332] - val_52;
                mem[1152921505848467332] = val_50;
                val_53 = val_53 + 1;
            }
            while((val_23 + 1) != ((long)val_41 - 1));
            
            }
            
            val_48 = 0;
            var val_27 = (ctrl2 + (((long)(int)((ctrl1.Length - 2))) << 4)) + 32;
            val_49 = val_10 / val_8;
            var val_56 = val_13;
            var val_55 = 0;
            if(((val_41 - 3) & 2147483648) != 0)
            {
                goto label_61;
            }
            
            do
            {
                var val_28 = (long)val_5 + val_55;
                int val_54 = val_41 - 2;
                val_54 = val_54 + val_55;
                var val_30 = (ctrl2 + (((long)(int)(((ctrl1.Length - 2) + 0))) << 4)) + 32;
                val_46 = mem[(1152921505848467328 + ((ctrl1.Length - 3)) << 2) + 0];
                val_46 = (1152921505848467328 + ((ctrl1.Length - 3)) << 2) + 0;
                val_49 = ((1152921505848467328 + ((ctrl1.Length - 3)) << 2) + 0) * val_49;
                val_49 = ((1152921505848467328 + ((ctrl1.Length - 3)) << 2) + 0) - val_49;
                var val_31 = ctrl2 + val_56;
                val_48 = val_48;
                val_49 = val_49 / val_46;
                int val_57 = val_5;
                val_42 = null;
                val_41 = 0;
                val_55 = val_55 - 1;
                val_56 = val_56 - 16;
                val_57 = val_57 + val_55;
            }
            while((val_57 & 2147483648) == 0);
            
            goto label_74;
            label_61:
            val_41 = 0;
            goto label_74;
            label_82:
            var val_33 = 0 + 32;
            val_49 = (val_10 + val_10) - val_8;
            val_41 = val_23 + 1;
            label_74:
            if(val_41 >= ((long)val_41 - 1))
            {
                goto label_77;
            }
            
            UnityEngine.Vector4[] val_35 = ctrl1 + (((long)(int)(((((((((1 - 1) + 1) - 1) + 1) - 1) + 1) + 1) + 1))) << 4);
            var val_37 = (ctrl2 + (((long)(int)(((((((((1 - 1) + 1) - 1) + 1) - 1) + 1) + 1) + 1))) << 4)) + 32;
            if((((long)val_41 + 1) - 1) < (??? + 24))
            {
                goto label_82;
            }
            
            goto label_82;
            label_77:
            UnityEngine.Vector4[] val_39 = ctrl1 + (((long)(int)((ctrl1.Length - 1))) << 4);
            var val_58 = val_48;
            val_50 = val_49;
            val_51 = mem[ctrl2];
            val_51 = ctrl2;
            var val_41 = (val_51 + (((long)(int)((ctrl1.Length - 2))) << 4)) + 32;
            val_49 = val_50 + val_49;
            var val_43 = ((???) + (((long)(int)((ctrl1.Length - 2))) << 4)) + 32;
            val_49 = val_49 * 0.5f;
            val_58 = val_58 + 1;
            if(val_58 != 4)
            {
                goto label_87;
            }
            
            return;
            label_2:
            if(val_41 != 1)
            {
                    val_51 = 1152921511752097440;
                if(val_41 != 2)
            {
                    return;
            }
            
                val_52 = ctrl1;
                if(ctrl1 == null)
            {
                    val_52 = ctrl1;
                if(val_52 == null)
            {
                    val_52 = 0;
            }
            
            }
            
                UnityEngine.Vector4 val_44 = UnityEngine.Vector4.Lerp(a:  new UnityEngine.Vector4() {x = mem[ctrl1 + 32], y = mem[ctrl1 + 32 + 4], z = mem[ctrl1 + 40], w = mem[ctrl1 + 40 + 4]}, b:  new UnityEngine.Vector4() {x = 0f, y = 5.142877E-39f, z = 5.87748E-39f, w = 2.295924E-39f}, t:  0.33333f);
                mem2[0] = val_44.x;
                mem2[0] = val_44.y;
                mem2[0] = val_44.z;
                mem2[0] = val_44.w;
                val_41 = ctrl1;
                if(ctrl1 == null)
            {
                    val_41 = ctrl1;
                if(val_41 == null)
            {
                    val_41 = 0;
            }
            
            }
            
                UnityEngine.Vector4 val_45 = UnityEngine.Vector4.Lerp(a:  new UnityEngine.Vector4() {x = mem[ctrl1 + 32], y = mem[ctrl1 + 32 + 4], z = mem[ctrl1 + 40], w = mem[ctrl1 + 40 + 4]}, b:  new UnityEngine.Vector4() {x = 0f, y = 5.142877E-39f, z = 5.87748E-39f, w = 2.295924E-39f}, t:  0.66666f);
                val_50 = val_45.x;
                val_43 = val_45.w;
                mem2[0] = val_50;
                mem2[0] = val_45.y;
                mem2[0] = val_45.z;
                mem2[0] = val_43;
                return;
            }
            
            val_41 = mem[???];
            val_41 = ???;
            mem2[0] = mem[ctrl1 + 32];
            mem2[0] = mem[ctrl1 + 32];
        }
        public static void ComputeSmoothControlPointsLooped(ref UnityEngine.Vector4[] knot, ref UnityEngine.Vector4[] ctrl1, ref UnityEngine.Vector4[] ctrl2)
        {
            var val_20;
            UnityEngine.Vector4[] val_21;
            UnityEngine.Vector4[] val_22;
            var val_23;
            int val_24;
            val_20 = 1152921511752233632;
            int val_1 = ctrl1.Length - 1;
            if()
            {
                goto label_2;
            }
            
            int val_2 = UnityEngine.Mathf.Min(a:  0, b:  4);
            val_21 = 1152921505938976448;
            int val_3 = ctrl1.Length + (val_2 << 1);
            val_22 = null;
            UnityEngine.Vector4[] val_14 = val_22;
            UnityEngine.Vector4[] val_15 = null;
            UnityEngine.Vector4[] val_13 = null;
            if(val_2 >= 1)
            {
                    int val_18 = val_2;
                var val_19 = 0;
                var val_20 = 32;
                val_21 = val_18;
                do
            {
                val_18 = (ctrl1.Length - val_18) + val_19;
                UnityEngine.Vector4[] val_6 = ctrl1 + (((long)(int)(((ctrl1.Length - val_2) + 0))) << 4);
                typeof(UnityEngine.Vector4[]).__il2cppRuntimeField_20 = mem[(ctrl1 + ((long)(int)(((ctrl1.Length - val_2) + 0))) << 4) + 32];
                int val_7 = (val_18 + ctrl1.Length) + val_19;
                var val_9 = (val_22 + (((long)(int)(((val_2 + ctrl1.Length) + 0))) << 4)) + 32;
                val_19 = val_19 + 1;
                val_20 = val_20 + 16;
                mem2[0] = mem[ctrl1 + 32];
            }
            while(val_21 != val_19);
            
            }
            
            val_24 = ctrl1.Length;
            if(val_24 <= 0)
            {
                goto label_15;
            }
            
            var val_21 = 32;
            do
            {
                int val_10 = val_2 + 0;
                var val_12 = (val_22 + (((long)(int)((val_2 + 0))) << 4)) + 32;
                val_21 = 0 + 1;
                val_21 = val_21 + 16;
                mem2[0] = mem[ctrl1 + 32];
                val_24 = val_24;
            }
            while(val_24 != val_21);
            
            Cinemachine.Utility.SplineHelpers.ComputeSmoothControlPoints(knot: ref  val_13, ctrl1: ref  val_14, ctrl2: ref  val_15);
            val_23 = null;
            if(val_24 < 1)
            {
                    return;
            }
            
            do
            {
                val_22 = val_2 + 0;
                var val_16 = val_23 + (((long)(int)((val_2 + 0))) << 4);
                mem2[0] = (val_23 + ((long)(int)((val_2 + 0))) << 4) + 32;
                var val_17 = val_13 + (((long)(int)((val_2 + 0))) << 4);
                val_21 = 0 + 1;
                mem2[0] = (val_13 + ((long)(int)((val_2 + 0))) << 4) + 32;
                val_20 = 32 + 16;
            }
            while(val_24 != val_21);
            
            return;
            label_2:
            if()
            {
                    return;
            }
            
            val_21 = ctrl2;
            mem2[0] = mem[ctrl1 + 32];
            mem2[0] = mem[ctrl1 + 32];
            return;
            label_15:
            Cinemachine.Utility.SplineHelpers.ComputeSmoothControlPoints(knot: ref  val_13, ctrl1: ref  val_14, ctrl2: ref  val_15);
        }
    
    }

}
