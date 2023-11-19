using UnityEngine;

namespace ScottGarland
{
    public class BigInteger
    {
        // Fields
        private ScottGarland.DigitsArray m_digits;
        
        // Properties
        public bool IsNegative { get; }
        public bool IsZero { get; }
        
        // Methods
        public BigInteger()
        {
            this.m_digits = new ScottGarland.DigitsArray(size:  1, used:  1);
        }
        public BigInteger(long number)
        {
            var val_13;
            ScottGarland.DigitsArray val_14;
            ScottGarland.DigitsArray val_15;
            var val_16;
            var val_17;
            ScottGarland.DigitsArray val_18;
            val_13 = number;
            ScottGarland.DigitsArray val_3 = null;
            var val_13 = 8;
            val_13 = val_13 / ScottGarland.DigitsArray.DataSizeOf;
            val_14 = val_3;
            val_3 = new ScottGarland.DigitsArray(size:  val_13 + 1, used:  0);
            this.m_digits = val_14;
            if(val_13 != 0)
            {
                goto label_3;
            }
            
            goto label_4;
            label_14:
            val_15 = this.m_digits;
            label_3:
            if(val_15.DataUsed >= this.m_digits.Count)
            {
                goto label_7;
            }
            
            val_16 = null;
            val_16 = null;
            this.m_digits.set_Item(index:  this.m_digits.DataUsed, value:  ScottGarland.DigitsArray.AllBits & val_13);
            val_13 = val_13 >> (ScottGarland.DigitsArray.DataSizeBits & 63);
            if(this.m_digits != null)
            {
                    val_17 = this.m_digits.DataUsed;
            }
            else
            {
                    val_17 = 0.DataUsed;
            }
            
            this.m_digits.DataUsed = val_17 + 1;
            if(val_13 != 0)
            {
                goto label_14;
            }
            
            label_7:
            val_18 = this.m_digits;
            label_4:
            val_18.ResetDataUsed();
        }
        public BigInteger(ulong number)
        {
            var val_13;
            ScottGarland.DigitsArray val_14;
            ScottGarland.DigitsArray val_15;
            var val_16;
            var val_17;
            ScottGarland.DigitsArray val_18;
            val_13 = number;
            ScottGarland.DigitsArray val_3 = null;
            var val_13 = 8;
            val_13 = val_13 / ScottGarland.DigitsArray.DataSizeOf;
            val_14 = val_3;
            val_3 = new ScottGarland.DigitsArray(size:  val_13 + 1, used:  0);
            this.m_digits = val_14;
            if(val_13 != 0)
            {
                goto label_3;
            }
            
            goto label_4;
            label_14:
            val_15 = this.m_digits;
            label_3:
            if(val_15.DataUsed >= this.m_digits.Count)
            {
                goto label_7;
            }
            
            val_16 = null;
            val_16 = null;
            this.m_digits.set_Item(index:  this.m_digits.DataUsed, value:  ScottGarland.DigitsArray.AllBits & val_13);
            val_13 = val_13 >> (ScottGarland.DigitsArray.DataSizeBits & 63);
            if(this.m_digits != null)
            {
                    val_17 = this.m_digits.DataUsed;
            }
            else
            {
                    val_17 = 0.DataUsed;
            }
            
            this.m_digits.DataUsed = val_17 + 1;
            if(val_13 != 0)
            {
                goto label_14;
            }
            
            label_7:
            val_18 = this.m_digits;
            label_4:
            val_18.ResetDataUsed();
        }
        public BigInteger(byte[] array)
        {
            this.ConstructFrom(array:  array, offset:  0, length:  array.Length);
        }
        public BigInteger(byte[] array, int length)
        {
            this.ConstructFrom(array:  array, offset:  0, length:  length);
        }
        public BigInteger(byte[] array, int offset, int length)
        {
            this.ConstructFrom(array:  array, offset:  offset, length:  length);
        }
        public BigInteger(string digits)
        {
            this.Construct(digits:  digits, radix:  10);
        }
        public BigInteger(string digits, int radix)
        {
            this.Construct(digits:  digits, radix:  radix);
        }
        private BigInteger(ScottGarland.DigitsArray digits)
        {
            digits.ResetDataUsed();
            this.m_digits = digits;
        }
        private void ConstructFrom(byte[] array, int offset, int length)
        {
            ScottGarland.BigInteger val_28;
            ScottGarland.DigitsArray val_29;
            var val_30;
            int val_31;
            var val_32;
            var val_33;
            int val_34;
            var val_35;
            System.ArgumentOutOfRangeException val_36;
            string val_37;
            int val_33 = offset;
            val_28 = this;
            if(array == null)
            {
                goto label_1;
            }
            
            if((array.Length < val_33) || (array.Length < length))
            {
                goto label_3;
            }
            
            int val_1 = length + val_33;
            if(val_1 > array.Length)
            {
                goto label_4;
            }
            
            ScottGarland.DigitsArray val_8 = null;
            var val_4 = ((length < 0) ? (length + 3) : length) >> 2;
            val_29 = val_8;
            val_8 = new ScottGarland.DigitsArray(size:  ((length != 3) ? (val_4 + 1) : (val_4)) + 1, used:  0);
            int val_9 = val_1 - 1;
            val_9 = val_9 - val_33;
            this.m_digits = val_29;
            if(val_9 < 3)
            {
                goto label_5;
            }
            
            int val_25 = length;
            var val_30 = 0;
            int val_10 = val_25 - 4;
            val_25 = val_25 + val_33;
            val_10 = val_10 >> 2;
            val_30 = val_25 - 4;
            val_10 = val_10 + 1;
            goto label_6;
            label_14:
            val_29 = mem[((length + offset) - 4) + 16];
            val_29 = ((length + offset) - 4) + 16;
            val_30 = W28 - 4;
            label_6:
            val_31 = array.Length;
            if(val_30 >= val_31)
            {
                    val_31 = array.Length;
            }
            
            var val_11 = (long)val_30 + 1;
            if(val_11 >= val_31)
            {
                    val_31 = array.Length;
            }
            
            byte val_27 = array[(long)val_11];
            var val_13 = (long)val_30 + 2;
            if(val_13 >= val_31)
            {
                    val_31 = array.Length;
            }
            
            byte val_28 = array[(long)val_13];
            val_29.set_Item(index:  0, value:  (array[(long)val_30] << 24) | (array[(long)val_30 + 3]));
            val_28 = val_28;
            if(null != 0)
            {
                    val_32 = DataUsed;
            }
            else
            {
                    val_32 = 0.DataUsed;
            }
            
            DataUsed = val_32 + 1;
            val_30 = val_30 + 1;
            if(val_10 != val_30)
            {
                goto label_14;
            }
            
            label_5:
            if((length & 3) != 0)
            {
                    int val_31 = length;
                val_31 = val_31 & 3;
                int val_19 = val_31 + 1;
                val_31 = val_31 << 3;
                int val_20 = val_31 - 8;
                do
            {
                val_32 = (long)val_33;
                byte val_32 = array[val_32];
                val_19 = val_19 - 1;
                val_33 = val_32 + 1;
                val_32 = val_32 << (val_20 & 24);
                val_20 = val_20 - 8;
                val_33 = val_32 | 0;
            }
            while(val_19 > 1);
            
            }
            else
            {
                    val_33 = 0;
            }
            
            if(null != 0)
            {
                    val_34 = DataUsed;
            }
            else
            {
                    val_34 = 0.DataUsed;
            }
            
            set_Item(index:  val_34, value:  0);
            ResetDataUsed();
            return;
            label_1:
            System.ArgumentNullException val_24 = null;
            val_35 = val_24;
            val_24 = new System.ArgumentNullException(paramName:  "array");
            goto label_22;
            label_3:
            val_36 = null;
            val_37 = "offset";
            goto label_23;
            label_4:
            val_36 = null;
            val_37 = "length";
            label_23:
            val_35 = val_36;
            val_36 = new System.ArgumentOutOfRangeException(paramName:  val_37);
            label_22:
        }
        private void Construct(string digits, int radix)
        {
            var val_28;
            ScottGarland.BigInteger val_29;
            int val_31;
            var val_32;
            val_28 = this;
            if(digits == null)
            {
                goto label_1;
            }
            
            ScottGarland.BigInteger val_1 = new ScottGarland.BigInteger(number:  1);
            ScottGarland.BigInteger val_2 = null;
            val_29 = val_2;
            val_2 = new ScottGarland.BigInteger();
            string val_5 = digits.ToUpper(culture:  System.Globalization.CultureInfo.CurrentCulture).Trim();
            if(val_5 != null)
            {
                    var val_8 = ((val_5.Chars[0] & 65535) == ('-')) ? 1 : 0;
            }
            
            int val_12 = val_5.Length;
            val_31 = val_12 - 1;
            goto label_7;
            label_13:
            ScottGarland.BigInteger val_15 = ScottGarland.BigInteger.op_Addition(leftSide:  ScottGarland.BigInteger.op_Multiply(leftSide:  ScottGarland.BigInteger.op_Implicit(value:  val_12), rightSide:  val_1), rightSide:  val_29);
            val_29 = val_15;
            ScottGarland.BigInteger val_17 = ScottGarland.BigInteger.op_Multiply(leftSide:  ScottGarland.BigInteger.op_Implicit(value:  val_15), rightSide:  val_1);
            val_31 = val_31 - 1;
            label_7:
            if(val_31 < (((0.Chars[0] & 65535) == ('-')) ? 1 : 0))
            {
                goto label_9;
            }
            
            char val_18 = val_5.Chars[val_31];
            char val_19 = val_18 - 48;
            char val_20 = val_18 & 65535;
            val_19 = val_19 & 65535;
            if(val_19 <= '	')
            {
                goto label_10;
            }
            
            if((val_20 - 65) > '')
            {
                goto label_11;
            }
            
            val_32 = val_20 - 55;
            goto label_12;
            label_10:
            val_32 = val_20 - 48;
            label_12:
            if(val_32 < radix)
            {
                goto label_13;
            }
            
            label_11:
            System.ArgumentOutOfRangeException val_22 = null;
            val_28 = val_22;
            val_22 = new System.ArgumentOutOfRangeException(paramName:  "digits");
            label_16:
            label_9:
            char val_23 = val_5.Chars[0];
            if((val_23 & 65535) == ('-'))
            {
                    val_29 = ScottGarland.BigInteger.op_UnaryNegation(leftSide:  val_23);
            }
            
            typeof(System.ArgumentOutOfRangeException).__il2cppRuntimeField_10 = val_25.m_digits;
            return;
            label_1:
            System.ArgumentNullException val_26 = new System.ArgumentNullException(paramName:  "digits");
            goto label_16;
        }
        public bool get_IsNegative()
        {
            if(this.m_digits != null)
            {
                    return this.m_digits.IsNegative;
            }
            
            return this.m_digits.IsNegative;
        }
        public bool get_IsZero()
        {
            if(this.m_digits != null)
            {
                    return this.m_digits.IsZero;
            }
            
            return this.m_digits.IsZero;
        }
        public static ScottGarland.BigInteger op_Implicit(long value)
        {
            return (ScottGarland.BigInteger)new ScottGarland.BigInteger(number:  X1);
        }
        public static ScottGarland.BigInteger op_Implicit(ulong value)
        {
            return (ScottGarland.BigInteger)new ScottGarland.BigInteger(number:  X1);
        }
        public static ScottGarland.BigInteger op_Implicit(int value)
        {
            return (ScottGarland.BigInteger)new ScottGarland.BigInteger(number:  (long)W1);
        }
        public static ScottGarland.BigInteger op_Implicit(uint value)
        {
            return (ScottGarland.BigInteger)new ScottGarland.BigInteger(number:  W1);
        }
        public static ScottGarland.BigInteger op_Addition(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide)
        {
            var val_13;
            int val_2 = X2 + 16.DataUsed;
            int val_13 = rightSide.m_digits.DataUsed;
            ScottGarland.DigitsArray val_4 = null;
            val_13 = (System.Math.Max(val1:  0, val2:  val_13)) + 1;
            val_4 = new ScottGarland.DigitsArray(size:  val_13);
            val_13 = 0;
            var val_15 = 0;
            goto label_5;
            label_15:
            set_Item(index:  0, value:  W24 & W23);
            val_13 = 1;
            label_5:
            if(val_13 >= Count)
            {
                    return (ScottGarland.BigInteger)new ScottGarland.BigInteger(digits:  val_4);
            }
            
            var val_14 = rightSide.m_digits.Item[1];
            val_14 = (val_15 + val_14) + (X2 + 16.Item[1]);
            val_15 = val_14 >> (ScottGarland.DigitsArray.DataSizeBits & 63);
            if(null != 0)
            {
                goto label_15;
            }
            
            goto label_15;
        }
        public static ScottGarland.BigInteger Add(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide)
        {
            return ScottGarland.BigInteger.op_Subtraction(leftSide:  leftSide, rightSide:  rightSide);
        }
        public static ScottGarland.BigInteger op_Increment(ScottGarland.BigInteger leftSide)
        {
            return ScottGarland.BigInteger.op_Addition(leftSide:  ScottGarland.BigInteger.op_Implicit(value:  leftSide), rightSide:  X1);
        }
        public static ScottGarland.BigInteger Increment(ScottGarland.BigInteger leftSide)
        {
            return ScottGarland.BigInteger.op_Addition(leftSide:  ScottGarland.BigInteger.op_Implicit(value:  leftSide), rightSide:  X1);
        }
        public static ScottGarland.BigInteger op_Subtraction(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide)
        {
            var val_16;
            var val_17;
            var val_18;
            int val_2 = X2 + 16.DataUsed;
            val_16 = 0;
            val_17 = 0;
            goto label_5;
            label_16:
            DataUsed = W23 + 1;
            val_17 = X24 >> 63;
            val_16 = 1;
            label_5:
            if(val_16 >= Count)
            {
                    return (ScottGarland.BigInteger)new ScottGarland.BigInteger(digits:  new ScottGarland.DigitsArray(size:  (System.Math.Max(val1:  0, val2:  rightSide.m_digits.DataUsed)) + 1));
            }
            
            var val_16 = X2 + 16;
            val_18 = null;
            var val_15 = rightSide.m_digits.Item[1];
            val_15 = val_15 - val_16.Item[1];
            val_16 = val_15 - val_17;
            val_18 = null;
            if(null == 0)
            {
                goto label_14;
            }
            
            set_Item(index:  1, value:  ScottGarland.DigitsArray.AllBits & val_16);
            int val_11 = DataUsed;
            goto label_16;
            label_14:
            set_Item(index:  1, value:  ScottGarland.DigitsArray.AllBits & val_16);
            int val_13 = DataUsed;
            goto label_16;
        }
        public static ScottGarland.BigInteger Subtract(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide)
        {
            return ScottGarland.BigInteger.op_Subtraction(leftSide:  leftSide, rightSide:  rightSide);
        }
        public static ScottGarland.BigInteger op_Decrement(ScottGarland.BigInteger leftSide)
        {
            return ScottGarland.BigInteger.op_Subtraction(leftSide:  ScottGarland.BigInteger.op_Implicit(value:  leftSide), rightSide:  X1);
        }
        public static ScottGarland.BigInteger Decrement(ScottGarland.BigInteger leftSide)
        {
            return ScottGarland.BigInteger.op_Subtraction(leftSide:  ScottGarland.BigInteger.op_Implicit(value:  leftSide), rightSide:  X1);
        }
        public static ScottGarland.BigInteger op_UnaryNegation(ScottGarland.BigInteger leftSide)
        {
            ScottGarland.DigitsArray val_19;
            var val_20;
            var val_21;
            var val_22;
            if((System.Object.ReferenceEquals(objA:  0, objB:  X1)) == true)
            {
                goto label_1;
            }
            
            val_19 = mem[X1 + 16];
            val_19 = X1 + 16;
            if(val_19.IsZero != false)
            {
                    ScottGarland.BigInteger val_3 = null;
                val_20 = val_3;
                val_3 = new ScottGarland.BigInteger(number:  0);
                return (ScottGarland.BigInteger)val_20;
            }
            
            int val_5 = X1 + 16.DataUsed;
            ScottGarland.DigitsArray val_8 = null;
            val_19 = val_8;
            val_8 = new ScottGarland.DigitsArray(size:  (X1 + 16.DataUsed) + 1, used:  val_5 + 1);
            val_21 = 0;
            goto label_9;
            label_15:
            set_Item(index:  0, value:  ~val_5);
            val_21 = 1;
            label_9:
            if(val_21 >= Count)
            {
                goto label_11;
            }
            
            uint val_10 = X1 + 16.Item[1];
            if(null != 0)
            {
                goto label_15;
            }
            
            goto label_15;
            label_11:
            var val_18 = 0;
            label_22:
            if(val_18 >= Count)
            {
                goto label_17;
            }
            
            val_22 = null;
            val_21 = Item[0] + 1;
            val_22 = null;
            set_Item(index:  0, value:  ScottGarland.DigitsArray.AllBits & val_21);
            int val_15 = ScottGarland.DigitsArray.DataSizeBits & 63;
            val_15 = val_21 >> val_15;
            val_18 = val_18 + 1;
            if(val_15 >= 1)
            {
                goto label_22;
            }
            
            label_17:
            ScottGarland.BigInteger val_16 = null;
            val_20 = val_16;
            val_16 = new ScottGarland.BigInteger(digits:  val_19);
            return (ScottGarland.BigInteger)val_20;
            label_1:
            System.ArgumentNullException val_17 = new System.ArgumentNullException(paramName:  "leftSide");
        }
        public ScottGarland.BigInteger Negate()
        {
            return ScottGarland.BigInteger.op_UnaryNegation(leftSide:  this);
        }
        public static ScottGarland.BigInteger Abs(ScottGarland.BigInteger leftSide)
        {
            if((System.Object.ReferenceEquals(objA:  0, objB:  X1)) != true)
            {
                    bool val_2 = X1 + 16.IsNegative;
                if(val_2 == false)
            {
                    return (ScottGarland.BigInteger)X1;
            }
            
                return ScottGarland.BigInteger.op_UnaryNegation(leftSide:  val_2);
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "leftSide");
        }
        public static ScottGarland.BigInteger op_Multiply(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide)
        {
            int val_27;
            var val_28;
            var val_29;
            uint val_30;
            var val_31;
            System.ArgumentNullException val_32;
            string val_33;
            if((System.Object.ReferenceEquals(objA:  0, objB:  rightSide)) == true)
            {
                goto label_1;
            }
            
            if((System.Object.ReferenceEquals(objA:  0, objB:  X2)) == true)
            {
                goto label_2;
            }
            
            bool val_4 = X2 + 16.IsNegative;
            ScottGarland.BigInteger val_6 = ScottGarland.BigInteger.Abs(leftSide:  ScottGarland.BigInteger.Abs(leftSide:  val_4));
            if(null != 0)
            {
                    val_27 = Count;
            }
            else
            {
                    val_27 = Count;
            }
            
            DataUsed = val_27;
            val_28 = 0;
            goto label_13;
            label_34:
            val_28 = 1;
            label_13:
            if(val_28 >= val_5.m_digits.DataUsed)
            {
                goto label_16;
            }
            
            val_29 = 0;
            val_30 = 0;
            goto label_17;
            label_29:
            set_Item(index:  W27, value:  val_30 & val_5.m_digits);
            val_30 = val_5.m_digits >> (ScottGarland.DigitsArray.DataSizeBits & 63);
            val_29 = 1;
            label_17:
            if(val_29 >= val_6.m_digits.DataUsed)
            {
                goto label_20;
            }
            
            var val_26 = val_6.m_digits.Item[1];
            val_31 = null;
            val_26 = (val_30 + (val_26 ?? val_5.m_digits.Item[1])) + (Item[val_28 + val_29]);
            val_31 = null;
            if(null != 0)
            {
                goto label_29;
            }
            
            goto label_29;
            label_20:
            if(val_30 == null)
            {
                goto label_34;
            }
            
            set_Item(index:  val_6.m_digits.DataUsed + val_28, value:  val_30);
            goto label_34;
            label_16:
            ScottGarland.BigInteger val_25 = new ScottGarland.BigInteger(digits:  new ScottGarland.DigitsArray(size:  val_6.m_digits.DataUsed + val_5.m_digits.DataUsed));
            bool val_27 = rightSide.m_digits.IsNegative;
            val_27 = val_27 ^ val_4;
            if(val_27 == false)
            {
                    return val_25;
            }
            
            return ScottGarland.BigInteger.op_UnaryNegation(leftSide:  val_25 = new ScottGarland.BigInteger(digits:  new ScottGarland.DigitsArray(size:  val_6.m_digits.DataUsed + val_5.m_digits.DataUsed)));
            label_1:
            val_32 = null;
            val_33 = "leftSide";
            goto label_36;
            label_2:
            val_32 = null;
            val_33 = "rightSide";
            label_36:
            val_32 = new System.ArgumentNullException(paramName:  val_33);
        }
        public static ScottGarland.BigInteger Multiply(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide)
        {
            return ScottGarland.BigInteger.op_Multiply(leftSide:  leftSide, rightSide:  rightSide);
        }
        public static ScottGarland.BigInteger op_Division(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide)
        {
            var val_16;
            System.ArgumentNullException val_17;
            string val_18;
            var val_19;
            ScottGarland.BigInteger val_11 = 0;
            bool val_1 = ScottGarland.BigInteger.op_Equality(leftSide:  3555, rightSide:  rightSide);
            if(val_1 == true)
            {
                goto label_1;
            }
            
            if((ScottGarland.BigInteger.op_Equality(leftSide:  val_1, rightSide:  X2)) == true)
            {
                goto label_2;
            }
            
            if((X2 + 16.IsZero) == true)
            {
                goto label_5;
            }
            
            bool val_5 = rightSide.m_digits.IsNegative;
            ScottGarland.BigInteger val_6 = ScottGarland.BigInteger.Abs(leftSide:  val_5);
            ScottGarland.BigInteger val_7 = ScottGarland.BigInteger.Abs(leftSide:  val_6);
            bool val_8 = ScottGarland.BigInteger.op_LessThan(leftSide:  val_7, rightSide:  val_6);
            if(val_8 != false)
            {
                    ScottGarland.BigInteger val_9 = null;
                val_16 = val_9;
                val_9 = new ScottGarland.BigInteger(number:  0);
                return (ScottGarland.BigInteger)val_16;
            }
            
            ScottGarland.BigInteger.Divide(leftSide:  val_8, rightSide:  val_6, quotient: out  val_7, remainder: out  val_11);
            val_16 = val_11;
            if(((X2 + 16.IsNegative) ^ val_5) == false)
            {
                    return (ScottGarland.BigInteger)val_16;
            }
            
            val_16 = ScottGarland.BigInteger.op_UnaryNegation(leftSide:  val_8);
            return (ScottGarland.BigInteger)val_16;
            label_1:
            val_17 = null;
            val_18 = "leftSide";
            goto label_13;
            label_2:
            val_17 = null;
            val_18 = "rightSide";
            label_13:
            val_19 = val_17;
            val_17 = new System.ArgumentNullException(paramName:  val_18);
            goto label_14;
            label_5:
            System.DivideByZeroException val_14 = null;
            val_19 = val_14;
            val_14 = new System.DivideByZeroException();
            label_14:
        }
        public static ScottGarland.BigInteger Divide(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide)
        {
            return ScottGarland.BigInteger.op_Division(leftSide:  leftSide, rightSide:  rightSide);
        }
        public static void Divide(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide, out ScottGarland.BigInteger quotient, out ScottGarland.BigInteger remainder)
        {
            if(rightSide.m_digits.IsZero != false)
            {
                    remainder = new ScottGarland.BigInteger();
                mem2[0] = new ScottGarland.BigInteger();
                return;
            }
            
            int val_5 = mem[1152921512571205344].DataUsed;
            if(val_5 == 1)
            {
                    ScottGarland.BigInteger.SingleDivide(leftSide:  val_5, rightSide:  rightSide, quotient: out  ScottGarland.BigInteger val_6 = quotient, remainder: out  ScottGarland.BigInteger val_7 = remainder);
                return;
            }
            
            ScottGarland.BigInteger.MultiDivide(leftSide:  val_5, rightSide:  rightSide, quotient: out  val_6, remainder: out  val_7);
        }
        private static void MultiDivide(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide, out ScottGarland.BigInteger quotient, out ScottGarland.BigInteger remainder)
        {
            var val_64;
            var val_65;
            var val_66;
            var val_67;
            int val_68;
            int val_69;
            ScottGarland.DigitsArray val_70;
            var val_71;
            var val_72;
            var val_73;
            System.UInt32[] val_74;
            int val_75;
            ScottGarland.BigInteger val_77;
            int val_78;
            int val_79;
            if(mem[1152921512571395936].IsZero == true)
            {
                goto label_3;
            }
            
            if(quotient != null)
            {
                    val_64 = mem[1152921512571395936];
                val_65 = val_64;
            }
            else
            {
                    val_65 = mem[1152921512571395936];
                val_64 = mem[1152921512571395936];
            }
            
            uint val_4 = val_65.Item[val_64.DataUsed - 1];
            val_66 = null;
            val_66 = null;
            val_67 = 0;
            if((ScottGarland.DigitsArray.HiBitSet != 0) && ((ScottGarland.DigitsArray.HiBitSet & val_4) == 0))
            {
                    label_13:
                val_67 = 1;
                if((ScottGarland.DigitsArray.HiBitSet >> 1) != 0)
            {
                    if((val_4 & (ScottGarland.DigitsArray.HiBitSet >> 1)) == 0)
            {
                goto label_13;
            }
            
            }
            
            }
            
            ScottGarland.DigitsArray val_64 = rightSide.m_digits;
            val_68 = val_64.DataUsed;
            val_64 = val_68 + 1;
            if(rightSide.m_digits != null)
            {
                    val_69 = rightSide.m_digits.DataUsed;
            }
            else
            {
                    val_69 = rightSide.m_digits.DataUsed;
            }
            
            rightSide.m_digits.CopyTo(array:  null, offset:  0, length:  val_69);
            ScottGarland.BigInteger val_12 = ScottGarland.BigInteger.op_LeftShift(leftSide:  ScottGarland.DigitsArray.ShiftLeft(buffer:  0, shiftCount:  471214096), shiftCount:  -625385648);
            if(val_12 != null)
            {
                    val_70 = val_12.m_digits;
                val_71 = val_70;
            }
            else
            {
                    val_71 = 11993091;
                val_70 = 11993091;
            }
            
            uint val_15 = val_71.Item[val_70.DataUsed - 1];
            if(11993091.DataUsed >= 2)
            {
                    if(val_12 != null)
            {
                    val_72 = 11993091;
                val_73 = val_72;
            }
            else
            {
                    val_73 = 11993091;
                val_72 = 11993091;
            }
            
            }
            
            int val_20 = 11993091.DataUsed;
            int val_21 = val_20 + 1;
            int val_24 = rightSide.m_digits.Count + 1;
            val_74 = null;
            int val_28 = val_64 - 11993091.DataUsed;
            if(val_28 < 1)
            {
                goto label_39;
            }
            
            int val_29 = 1 << (ScottGarland.DigitsArray.DataSizeBits & 63);
            label_70:
            var val_30 = null + (((long)(int)(val_8)) << 2);
            var val_65 = 1152921505078061104 + ((long)(int)((val_8 - 1))) << 2;
            int val_33 = ScottGarland.DigitsArray.DataSizeBits & 63;
            val_33 = ((null + ((long)(int)(val_8)) << 2) + 32) << val_33;
            val_65 = val_65 + val_33;
            val_75 = val_65 / val_15;
            int val_36 = val_65 - (val_75 * val_15);
            label_52:
            if(val_68 <= 1)
            {
                goto label_51;
            }
            
            if(val_75 == val_29)
            {
                goto label_46;
            }
            
            var val_66 = 1152921505078061104 + ((val_68 - 2) << 2);
            uint val_67 = val_73.Item[val_72.DataUsed - 2];
            int val_38 = ScottGarland.DigitsArray.DataSizeBits & 63;
            val_38 = val_36 << val_38;
            val_66 = val_66 + val_38;
            val_67 = val_75 * val_67;
            if(val_67 <= val_66)
            {
                goto label_51;
            }
            
            label_46:
            val_75 = val_75 - 1;
            val_36 = val_36 + val_15;
            if(val_36 < val_29)
            {
                goto label_52;
            }
            
            label_51:
            if(val_21 >= 1)
            {
                    var val_68 = 0;
                do
            {
                int val_39 = val_68 + val_68;
                var val_40 = null + (((long)(int)((val_8 + 0))) << 2);
                set_Item(index:  val_20 + val_68, value:  (null + ((long)(int)((val_8 + 0))) << 2) + 32);
                val_68 = val_68 - 1;
            }
            while((val_20 + val_68) != 1);
            
            }
            
            ScottGarland.BigInteger val_43 = new ScottGarland.BigInteger(digits:  new ScottGarland.DigitsArray(size:  val_21, used:  val_21));
            ScottGarland.BigInteger val_45 = ScottGarland.BigInteger.op_Multiply(leftSide:  ScottGarland.BigInteger.op_Implicit(value:  val_43 = new ScottGarland.BigInteger(digits:  new ScottGarland.DigitsArray(size:  val_21, used:  val_21))), rightSide:  val_12);
            val_77 = val_45;
            bool val_46 = ScottGarland.BigInteger.op_GreaterThan(leftSide:  val_45, rightSide:  val_77);
            if(val_46 != false)
            {
                    do
            {
                val_75 = val_75 - 1;
                ScottGarland.BigInteger val_47 = ScottGarland.BigInteger.op_Subtraction(leftSide:  val_46, rightSide:  val_77);
                val_77 = val_47;
                bool val_48 = ScottGarland.BigInteger.op_GreaterThan(leftSide:  val_47, rightSide:  val_77);
            }
            while(val_48 == true);
            
            }
            
            ScottGarland.BigInteger val_50 = ScottGarland.BigInteger.op_Subtraction(leftSide:  val_48, rightSide:  val_43);
            if(val_21 >= 1)
            {
                    var val_69 = 0;
                do
            {
                int val_54 = val_68 + val_69;
                var val_55 = null + (((long)(int)((val_8 + 0))) << 2);
                mem2[0] = val_50.m_digits.Item[11993091.DataUsed + val_69];
                val_69 = val_69 - 1;
            }
            while((~val_20) != val_69);
            
            }
            
            val_74 = val_74;
            var val_70 = 0;
            val_78 = val_28;
            val_68 = val_68 - 1;
            val_70 = val_70 + 1;
            typeof(System.UInt32[]).__il2cppRuntimeField_20 = val_75;
            if(val_70 != val_78)
            {
                goto label_70;
            }
            
            goto label_71;
            label_39:
            val_78 = 0;
            label_71:
            System.Array.Reverse(array:  0, index:  471214096, length:  0);
            remainder = new ScottGarland.BigInteger(digits:  new ScottGarland.DigitsArray(copyFrom:  val_74));
            int val_58 = ScottGarland.DigitsArray.ShiftRight(buffer:  0, shiftCount:  471214096);
            if(null != 0)
            {
                    val_79 = DataUsed;
            }
            else
            {
                    val_79 = DataUsed;
            }
            
            CopyFrom(source:  null, sourceOffset:  0, offset:  0, length:  val_79);
            mem2[0] = new ScottGarland.BigInteger(digits:  new ScottGarland.DigitsArray(size:  val_58, used:  val_58));
            return;
            label_3:
            System.DivideByZeroException val_63 = new System.DivideByZeroException();
        }
        private static void SingleDivide(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide, out ScottGarland.BigInteger quotient, out ScottGarland.BigInteger remainder)
        {
            uint val_27;
            int val_28;
            int val_29;
            if(mem[1152921512571594720].IsZero != true)
            {
                    if(null != 0)
            {
                    ResetDataUsed();
            }
            else
            {
                    ResetDataUsed();
            }
            
                int val_26 = DataUsed;
                int val_4 = val_26 - 1;
                uint val_5 = mem[1152921512571594720].Item[0];
                uint val_6 = Item[val_4];
                val_27 = rightSide.m_digits.Count;
                rightSide.m_digits.CopyTo(array:  null, offset:  0, length:  System.UInt32[].__il2cppRuntimeField_namespaze);
                val_28 = 0;
                if(val_6 >= val_5)
            {
                    typeof(System.UInt32[]).__il2cppRuntimeField_20 = val_6 / val_5;
                set_Item(index:  val_4, value:  val_6 - ((val_6 / val_5) * val_5));
                val_28 = 1;
            }
            
                val_29 = val_26 - 2;
                if((val_29 & 2147483648) == 0)
            {
                    int val_11 = val_26 + val_28;
                val_11 = val_11 - 1;
                do
            {
                val_26 = val_29 + 1;
                var val_28 = Item[val_26];
                var val_27 = val_28;
                val_27 = val_27 << (ScottGarland.DigitsArray.DataSizeBits & 63);
                val_28 = val_27 + Item[val_29];
                val_27 = val_28 / val_5;
                val_28 = val_28 + 1;
                mem[1152921505078061108] = val_27;
                if(null != 0)
            {
                    set_Item(index:  val_26, value:  0);
            }
            else
            {
                    set_Item(index:  val_26, value:  0);
            }
            
                int val_17 = val_29 - 1;
                set_Item(index:  val_29, value:  val_28 - (val_27 * val_5));
                val_29 = val_17;
            }
            while(val_17 != 1);
            
                val_28 = val_11;
            }
            
                mem2[0] = new ScottGarland.BigInteger(digits:  new ScottGarland.DigitsArray(copyFrom:  rightSide.m_digits));
                int val_21 = DataUsed;
                int val_22 = val_21 - 1;
                if((val_22 & 2147483648) == 0)
            {
                    do
            {
                var val_23 = null + (((long)(int)((val_21 - 1))) << 2);
                set_Item(index:  0, value:  (null + ((long)(int)((val_21 - 1))) << 2) + 32);
                val_28 = 0 + 1;
                val_29 = (long)val_22 - 1;
            }
            while(val_21 != val_28);
            
            }
            
                remainder = new ScottGarland.BigInteger(digits:  new ScottGarland.DigitsArray(size:  val_28 + 1, used:  val_28));
                return;
            }
            
            System.DivideByZeroException val_25 = new System.DivideByZeroException();
        }
        public static ScottGarland.BigInteger op_Modulus(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide)
        {
            ScottGarland.BigInteger val_14;
            System.ArgumentNullException val_15;
            string val_16;
            var val_17;
            bool val_1 = ScottGarland.BigInteger.op_Equality(leftSide:  3577, rightSide:  rightSide);
            if(val_1 == true)
            {
                goto label_1;
            }
            
            if((ScottGarland.BigInteger.op_Equality(leftSide:  val_1, rightSide:  X2)) == true)
            {
                goto label_2;
            }
            
            if((X2 + 16.IsZero) == true)
            {
                goto label_5;
            }
            
            bool val_4 = rightSide.m_digits.IsNegative;
            ScottGarland.BigInteger val_5 = ScottGarland.BigInteger.Abs(leftSide:  val_4);
            val_14 = val_5;
            ScottGarland.BigInteger val_6 = ScottGarland.BigInteger.Abs(leftSide:  val_5);
            bool val_7 = ScottGarland.BigInteger.op_LessThan(leftSide:  val_6, rightSide:  val_14);
            if(val_7 == true)
            {
                    return (ScottGarland.BigInteger)val_14;
            }
            
            ScottGarland.BigInteger.Divide(leftSide:  val_7, rightSide:  val_14, quotient: out  val_6, remainder: out  0);
            val_14 = 0;
            if(val_4 == false)
            {
                    return (ScottGarland.BigInteger)val_14;
            }
            
            val_14 = ScottGarland.BigInteger.op_UnaryNegation(leftSide:  val_7);
            return (ScottGarland.BigInteger)val_14;
            label_1:
            val_15 = null;
            val_16 = "leftSide";
            goto label_10;
            label_2:
            val_15 = null;
            val_16 = "rightSide";
            label_10:
            val_17 = val_15;
            val_15 = new System.ArgumentNullException(paramName:  val_16);
            goto label_11;
            label_5:
            System.DivideByZeroException val_12 = null;
            val_17 = val_12;
            val_12 = new System.DivideByZeroException();
            label_11:
        }
        public static ScottGarland.BigInteger Modulus(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide)
        {
            return ScottGarland.BigInteger.op_Modulus(leftSide:  leftSide, rightSide:  rightSide);
        }
        public static ScottGarland.BigInteger op_BitwiseAnd(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide)
        {
            int val_2 = X2 + 16.DataUsed;
            int val_3 = System.Math.Max(val1:  0, val2:  rightSide.m_digits.DataUsed);
            if(val_3 < 1)
            {
                    return (ScottGarland.BigInteger)new ScottGarland.BigInteger(digits:  new ScottGarland.DigitsArray(size:  val_3, used:  val_3));
            }
            
            var val_9 = 0;
            do
            {
                set_Item(index:  0, value:  (X2 + 16.Item[0]) & rightSide.m_digits.Item[0]);
                val_9 = val_9 + 1;
            }
            while(val_3 != val_9);
            
            return (ScottGarland.BigInteger)new ScottGarland.BigInteger(digits:  new ScottGarland.DigitsArray(size:  val_3, used:  val_3));
        }
        public static ScottGarland.BigInteger BitwiseAnd(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide)
        {
            return ScottGarland.BigInteger.op_BitwiseAnd(leftSide:  leftSide, rightSide:  rightSide);
        }
        public static ScottGarland.BigInteger op_BitwiseOr(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide)
        {
            int val_2 = X2 + 16.DataUsed;
            int val_3 = System.Math.Max(val1:  0, val2:  rightSide.m_digits.DataUsed);
            if(val_3 < 1)
            {
                    return (ScottGarland.BigInteger)new ScottGarland.BigInteger(digits:  new ScottGarland.DigitsArray(size:  val_3, used:  val_3));
            }
            
            var val_9 = 0;
            do
            {
                set_Item(index:  0, value:  (X2 + 16.Item[0]) | rightSide.m_digits.Item[0]);
                val_9 = val_9 + 1;
            }
            while(val_3 != val_9);
            
            return (ScottGarland.BigInteger)new ScottGarland.BigInteger(digits:  new ScottGarland.DigitsArray(size:  val_3, used:  val_3));
        }
        public static ScottGarland.BigInteger BitwiseOr(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide)
        {
            return ScottGarland.BigInteger.op_BitwiseOr(leftSide:  leftSide, rightSide:  rightSide);
        }
        public static ScottGarland.BigInteger op_ExclusiveOr(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide)
        {
            int val_2 = X2 + 16.DataUsed;
            int val_3 = System.Math.Max(val1:  0, val2:  rightSide.m_digits.DataUsed);
            if(val_3 < 1)
            {
                    return (ScottGarland.BigInteger)new ScottGarland.BigInteger(digits:  new ScottGarland.DigitsArray(size:  val_3, used:  val_3));
            }
            
            var val_9 = 0;
            do
            {
                set_Item(index:  0, value:  (X2 + 16.Item[0]) ^ rightSide.m_digits.Item[0]);
                val_9 = val_9 + 1;
            }
            while(val_3 != val_9);
            
            return (ScottGarland.BigInteger)new ScottGarland.BigInteger(digits:  new ScottGarland.DigitsArray(size:  val_3, used:  val_3));
        }
        public static ScottGarland.BigInteger Xor(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide)
        {
            return ScottGarland.BigInteger.op_ExclusiveOr(leftSide:  leftSide, rightSide:  rightSide);
        }
        public static ScottGarland.BigInteger op_OnesComplement(ScottGarland.BigInteger leftSide)
        {
            goto label_3;
            label_9:
            set_Item(index:  0, value:  ~W22);
            0 = 1;
            label_3:
            if(0 >= Count)
            {
                    return (ScottGarland.BigInteger)new ScottGarland.BigInteger(digits:  new ScottGarland.DigitsArray(size:  X1 + 16.Count));
            }
            
            uint val_4 = X1 + 16.Item[1];
            if(null != 0)
            {
                goto label_9;
            }
            
            goto label_9;
        }
        public static ScottGarland.BigInteger OnesComplement(ScottGarland.BigInteger leftSide)
        {
            return ScottGarland.BigInteger.op_OnesComplement(leftSide:  leftSide);
        }
        public static ScottGarland.BigInteger op_LeftShift(ScottGarland.BigInteger leftSide, int shiftCount)
        {
            int val_7;
            if((ScottGarland.BigInteger.op_Equality(leftSide:  3574, rightSide:  shiftCount)) != true)
            {
                    if(null != 0)
            {
                    val_7 = ShiftLeftWithoutOverflow(shiftCount:  W2);
            }
            else
            {
                    val_7 = ShiftLeftWithoutOverflow(shiftCount:  W2);
            }
            
                DataUsed = val_7;
                return (ScottGarland.BigInteger)new ScottGarland.BigInteger(digits:  new ScottGarland.DigitsArray(copyFrom:  shiftCount + 16));
            }
            
            System.ArgumentNullException val_6 = new System.ArgumentNullException(paramName:  "leftSide");
        }
        public static ScottGarland.BigInteger LeftShift(ScottGarland.BigInteger leftSide, int shiftCount)
        {
            return ScottGarland.BigInteger.op_LeftShift(leftSide:  leftSide, shiftCount:  shiftCount);
        }
        public static ScottGarland.BigInteger op_RightShift(ScottGarland.BigInteger leftSide, int shiftCount)
        {
            int val_29;
            int val_30;
            var val_31;
            var val_32;
            var val_33;
            uint val_34;
            var val_35;
            var val_36;
            int val_37;
            if((ScottGarland.BigInteger.op_Equality(leftSide:  3585, rightSide:  shiftCount)) == true)
            {
                goto label_1;
            }
            
            if(null != 0)
            {
                    val_29 = ShiftRight(shiftCount:  W2);
            }
            else
            {
                    val_29 = ShiftRight(shiftCount:  W2);
            }
            
            DataUsed = val_29;
            if((shiftCount + 16.IsNegative) == false)
            {
                    return (ScottGarland.BigInteger)new ScottGarland.BigInteger(digits:  new ScottGarland.DigitsArray(copyFrom:  shiftCount + 16));
            }
            
            val_30 = Count - 1;
            goto label_8;
            label_14:
            set_Item(index:  val_30, value:  val_29);
            val_30 = val_30 - 1;
            label_8:
            val_31 = null;
            if(val_30 < DataUsed)
            {
                goto label_10;
            }
            
            val_32 = null;
            if(null != 0)
            {
                goto label_14;
            }
            
            goto label_14;
            label_10:
            val_33 = null;
            var val_28 = 0;
            val_34 = ScottGarland.DigitsArray.HiBitSet;
            goto label_17;
            label_28:
            set_Item(index:  val_30, value:  val_29 | val_34);
            val_33 = null;
            val_34 = val_34 >> 1;
            label_17:
            val_28 = val_28 + 1;
            if(val_28 >= ScottGarland.DigitsArray.DataSizeBits)
            {
                goto label_25;
            }
            
            if(null != 0)
            {
                    val_35 = DataUsed;
            }
            else
            {
                    val_35 = DataUsed;
            }
            
            val_36 = null;
            val_36 = null;
            if(((Item[val_35 - 1]) & val_34) == ScottGarland.DigitsArray.HiBitSet)
            {
                goto label_25;
            }
            
            if(null == 0)
            {
                goto label_26;
            }
            
            uint val_20 = Item[DataUsed - 1];
            goto label_28;
            label_26:
            uint val_23 = Item[DataUsed - 1];
            goto label_28;
            label_25:
            if(null != 0)
            {
                    val_37 = Count;
            }
            else
            {
                    val_37 = Count;
            }
            
            DataUsed = val_37;
            return (ScottGarland.BigInteger)new ScottGarland.BigInteger(digits:  new ScottGarland.DigitsArray(copyFrom:  shiftCount + 16));
            label_1:
            System.ArgumentNullException val_27 = new System.ArgumentNullException(paramName:  "leftSide");
        }
        public static ScottGarland.BigInteger RightShift(ScottGarland.BigInteger leftSide, int shiftCount)
        {
            bool val_1 = ScottGarland.BigInteger.op_Equality(leftSide:  3594, rightSide:  shiftCount);
            if(val_1 != true)
            {
                    return ScottGarland.BigInteger.op_RightShift(leftSide:  val_1, shiftCount:  shiftCount);
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  "leftSide");
        }
        public int CompareTo(ScottGarland.BigInteger value)
        {
            return ScottGarland.BigInteger.Compare(leftSide:  this, rightSide:  this);
        }
        public static int Compare(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide)
        {
            var val_9;
            System.ArgumentNullException val_10;
            string val_11;
            if((System.Object.ReferenceEquals(objA:  0, objB:  rightSide)) != false)
            {
                    val_9 = 0;
                return (int)val_9;
            }
            
            if((System.Object.ReferenceEquals(objA:  0, objB:  rightSide)) == true)
            {
                goto label_3;
            }
            
            bool val_4 = System.Object.ReferenceEquals(objA:  0, objB:  X2);
            if(val_4 == true)
            {
                goto label_4;
            }
            
            bool val_5 = ScottGarland.BigInteger.op_GreaterThan(leftSide:  val_4, rightSide:  rightSide);
            if(val_5 != false)
            {
                    val_9 = 1;
                return (int)val_9;
            }
            
            val_9 = (int)((~(ScottGarland.BigInteger.op_Equality(leftSide:  val_5, rightSide:  rightSide))) >> 0) & 1;
            return (int)val_9;
            label_3:
            val_10 = null;
            val_11 = "leftSide";
            goto label_7;
            label_4:
            val_10 = null;
            val_11 = "rightSide";
            label_7:
            val_10 = new System.ArgumentNullException(paramName:  val_11);
        }
        public static bool op_Equality(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide)
        {
            var val_11;
            if((System.Object.ReferenceEquals(objA:  0, objB:  rightSide)) != false)
            {
                    val_11 = 1;
                return (bool)val_11;
            }
            
            if((System.Object.ReferenceEquals(objA:  0, objB:  rightSide)) != true)
            {
                    if((System.Object.ReferenceEquals(objA:  0, objB:  X2)) != true)
            {
                    if((rightSide.m_digits.IsNegative ^ (X2 + 16.IsNegative)) == false)
            {
                goto label_8;
            }
            
            }
            
            }
            
            val_11 = 0;
            return (bool)val_11;
            label_8:
            if(rightSide == null)
            {
                
            }
        
        }
        public static bool op_Inequality(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide)
        {
            bool val_1 = ScottGarland.BigInteger.op_Equality(leftSide:  leftSide, rightSide:  rightSide);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        public static bool op_GreaterThan(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide)
        {
            object val_18;
            int val_19;
            var val_20;
            var val_21;
            System.ArgumentNullException val_22;
            string val_23;
            val_18 = X2;
            if((System.Object.ReferenceEquals(objA:  0, objB:  rightSide)) == true)
            {
                goto label_1;
            }
            
            if((System.Object.ReferenceEquals(objA:  0, objB:  val_18)) == true)
            {
                goto label_2;
            }
            
            if((rightSide.m_digits.IsNegative ^ (X2 + 16.IsNegative)) != false)
            {
                    if((X2 + 16) != 0)
            {
                    return X2 + 16.IsNegative;
            }
            
                return X2 + 16.IsNegative;
            }
            
            val_19 = rightSide.m_digits.DataUsed;
            val_20 = X2 + 16.DataUsed;
            int val_8 = rightSide.m_digits.DataUsed;
            if(val_19 != val_20)
            {
                goto label_16;
            }
            
            val_19 = val_8 - 1;
            label_22:
            if((val_19 & 2147483648) != 0)
            {
                goto label_17;
            }
            
            val_20 = mem[X2 + 16];
            val_20 = X2 + 16;
            val_19 = val_19 - 1;
            if(rightSide.m_digits.Item[val_19] == val_20.Item[val_19])
            {
                goto label_22;
            }
            
            val_19 = val_19 + 1;
            val_18 = mem[X2 + 16];
            val_18 = X2 + 16;
            var val_13 = (rightSide.m_digits.Item[val_19] > val_18.Item[val_19]) ? 1 : 0;
            return (bool)val_21;
            label_16:
            val_18 = mem[X2 + 16];
            val_18 = X2 + 16;
            var val_15 = (val_8 > val_18.DataUsed) ? 1 : 0;
            return (bool)val_21;
            label_17:
            val_21 = 0;
            return (bool)val_21;
            label_1:
            val_22 = null;
            val_23 = "leftSide";
            goto label_31;
            label_2:
            val_22 = null;
            val_23 = "rightSide";
            label_31:
            val_22 = new System.ArgumentNullException(paramName:  val_23);
        }
        public static bool op_LessThan(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide)
        {
            object val_17;
            int val_18;
            var val_19;
            var val_20;
            System.ArgumentNullException val_21;
            string val_22;
            val_17 = X2;
            if((System.Object.ReferenceEquals(objA:  0, objB:  rightSide)) == true)
            {
                goto label_1;
            }
            
            if((System.Object.ReferenceEquals(objA:  0, objB:  val_17)) == true)
            {
                goto label_2;
            }
            
            var val_15 = X2 + 16;
            val_15 = rightSide.m_digits.IsNegative ^ val_15.IsNegative;
            if(val_15 != false)
            {
                    if(rightSide.m_digits != null)
            {
                    return rightSide.m_digits.IsNegative;
            }
            
                return rightSide.m_digits.IsNegative;
            }
            
            val_18 = rightSide.m_digits.DataUsed;
            val_19 = X2 + 16.DataUsed;
            int val_7 = rightSide.m_digits.DataUsed;
            if(val_18 != val_19)
            {
                goto label_15;
            }
            
            val_18 = val_7 - 1;
            label_21:
            if((val_18 & 2147483648) != 0)
            {
                goto label_16;
            }
            
            val_19 = mem[X2 + 16];
            val_19 = X2 + 16;
            val_18 = val_18 - 1;
            if(rightSide.m_digits.Item[val_18] == val_19.Item[val_18])
            {
                goto label_21;
            }
            
            val_18 = val_18 + 1;
            val_17 = mem[X2 + 16];
            val_17 = X2 + 16;
            var val_12 = (rightSide.m_digits.Item[val_18] < val_17.Item[val_18]) ? 1 : 0;
            return (bool)val_20;
            label_15:
            val_17 = mem[X2 + 16];
            val_17 = X2 + 16;
            var val_14 = (val_7 < val_17.DataUsed) ? 1 : 0;
            return (bool)val_20;
            label_16:
            val_20 = 0;
            return (bool)val_20;
            label_1:
            val_21 = null;
            val_22 = "leftSide";
            goto label_30;
            label_2:
            val_21 = null;
            val_22 = "rightSide";
            label_30:
            val_21 = new System.ArgumentNullException(paramName:  val_22);
        }
        public static bool op_GreaterThanOrEqual(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide)
        {
            return (bool)((ScottGarland.BigInteger.Compare(leftSide:  leftSide, rightSide:  rightSide)) >= 0) ? 1 : 0;
        }
        public static bool op_LessThanOrEqual(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide)
        {
            return (bool)((ScottGarland.BigInteger.Compare(leftSide:  leftSide, rightSide:  rightSide)) < 1) ? 1 : 0;
        }
        public override bool Equals(object obj)
        {
            var val_12;
            object val_13;
            var val_14;
            val_13 = obj;
            if((System.Object.ReferenceEquals(objA:  0, objB:  val_13)) == true)
            {
                goto label_1;
            }
            
            if((System.Object.ReferenceEquals(objA:  0, objB:  this)) == true)
            {
                goto label_11;
            }
            
            val_13 = 0;
            val_12 = this.m_digits.DataUsed;
            val_14 = 0;
            if(val_12 != 11993091.DataUsed)
            {
                    return (bool)val_14;
            }
            
            val_12 = 0;
            label_15:
            if(val_12 >= this.m_digits.DataUsed)
            {
                goto label_11;
            }
            
            val_12 = val_12 + 1;
            if(this.m_digits.Item[0] == 11993091.Item[0])
            {
                goto label_15;
            }
            
            label_1:
            val_14 = 0;
            return (bool)val_14;
            label_11:
            val_14 = 1;
            return (bool)val_14;
        }
        public override int GetHashCode()
        {
            if(this.m_digits != null)
            {
                    return this.m_digits.GetHashCode();
            }
            
            return this.m_digits.GetHashCode();
        }
        public override string ToString()
        {
            return this.ToString(radix:  10);
        }
        public string ToString(int radix)
        {
            var val_19;
            ScottGarland.BigInteger val_20;
            var val_21;
            var val_22;
            System.Char[] val_23;
            ScottGarland.BigInteger val_11 = 0;
            if((radix - 2) >= 35)
            {
                goto label_1;
            }
            
            if(this.m_digits.IsZero != false)
            {
                    val_19 = "0";
                return (string)val_19;
            }
            
            bool val_3 = this.m_digits.IsNegative;
            val_20 = ScottGarland.BigInteger.Abs(leftSide:  val_3);
            goto label_7;
            label_21:
            val_20 = val_11;
            label_7:
            val_21 = 11993091;
            if(val_21.DataUsed > 1)
            {
                goto label_10;
            }
            
            if(11993091.DataUsed != 1)
            {
                goto label_16;
            }
            
            val_21 = 11993091;
            uint val_9 = val_21.Item[0];
            if(val_9 == 0)
            {
                goto label_16;
            }
            
            label_10:
            ScottGarland.BigInteger.Divide(leftSide:  val_9, rightSide:  val_20, quotient: out  new ScottGarland.BigInteger(number:  (long)radix), remainder: out  val_11);
            val_22 = "0123456789abcdefghijklmnopqrstuvwxyz";
            if("0123456789abcdefghijklmnopqrstuvwxyz" == null)
            {
                    val_22 = "0123456789abcdefghijklmnopqrstuvwxyz";
            }
            
            char val_13 = Chars[11993091.Item[0]];
            if(null != 0)
            {
                goto label_21;
            }
            
            goto label_21;
            label_16:
            System.Type val_14 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if(null == 0)
            {
                goto label_25;
            }
            
            val_23 = new System.Collections.ArrayList();
            if(null != 0)
            {
                goto label_26;
            }
            
            label_25:
            val_23 = 0;
            label_26:
            val_19 = 0.CreateString(val:  val_23);
            var val_16 = (radix == 10) ? 1 : 0;
            val_16 = val_16 & val_3;
            if(val_16 != true)
            {
                    return (string)val_19;
            }
            
            val_19 = 0 + "-"("-");
            return (string)val_19;
            label_1:
            System.ArgumentOutOfRangeException val_18 = new System.ArgumentOutOfRangeException(paramName:  "radix");
        }
        public string ToHexString()
        {
            var val_13;
            string val_14;
            if(this.m_digits != null)
            {
                    val_13 = this.m_digits.DataUsed;
            }
            else
            {
                    val_13 = 0.DataUsed;
            }
            
            System.Text.StringBuilder val_6 = AppendFormat(format:  "{0:X}", arg0:  this.m_digits.Item[val_13 - 1]);
            ScottGarland.DigitsArray val_13 = this.m_digits;
            val_14 = 0;
            val_13 = val_13.DataUsed - 2;
            if((val_13 & 2147483648) == 0)
            {
                    do
            {
                val_14 = 0 + "{0:X"("{0:X") + ScottGarland.DigitsArray.DataSizeOf << 1(ScottGarland.DigitsArray.DataSizeOf << 1);
                System.Text.StringBuilder val_12 = AppendFormat(format:  val_14, arg0:  this.m_digits.Item[val_13]);
                val_13 = val_13 - 1;
            }
            while((val_13 & 2147483648) == 0);
            
            }
            
            if(null != 0)
            {
                    return (string)new System.Text.StringBuilder();
            }
            
            return (string)new System.Text.StringBuilder();
        }
        public static int ToInt16(ScottGarland.BigInteger value)
        {
            if((System.Object.ReferenceEquals(objA:  0, objB:  X1)) != true)
            {
                    System.Globalization.CultureInfo val_2 = System.Globalization.CultureInfo.CurrentCulture;
                return (int)(int)(System.Int16.Parse(s:  0, style:  X1, provider:  7)) & 65535;
            }
            
            System.ArgumentNullException val_4 = new System.ArgumentNullException(paramName:  "value");
        }
        public static uint ToUInt16(ScottGarland.BigInteger value)
        {
            if((System.Object.ReferenceEquals(objA:  0, objB:  X1)) != true)
            {
                    System.Globalization.CultureInfo val_2 = System.Globalization.CultureInfo.CurrentCulture;
                ushort val_3 = System.UInt16.Parse(s:  0, style:  X1, provider:  7);
                val_3 = val_3 & 65535;
                return (uint)val_3;
            }
            
            System.ArgumentNullException val_4 = new System.ArgumentNullException(paramName:  "value");
        }
        public static int ToInt32(ScottGarland.BigInteger value)
        {
            if((System.Object.ReferenceEquals(objA:  0, objB:  X1)) != true)
            {
                    System.Globalization.CultureInfo val_2 = System.Globalization.CultureInfo.CurrentCulture;
                return System.Int32.Parse(s:  0, style:  X1, provider:  7);
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "value");
        }
        public static uint ToUInt32(ScottGarland.BigInteger value)
        {
            if((System.Object.ReferenceEquals(objA:  0, objB:  X1)) != true)
            {
                    System.Globalization.CultureInfo val_2 = System.Globalization.CultureInfo.CurrentCulture;
                return System.UInt32.Parse(s:  0, style:  X1, provider:  7);
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "value");
        }
        public static long ToInt64(ScottGarland.BigInteger value)
        {
            if((System.Object.ReferenceEquals(objA:  0, objB:  X1)) != true)
            {
                    System.Globalization.CultureInfo val_2 = System.Globalization.CultureInfo.CurrentCulture;
                return System.Int64.Parse(s:  0, style:  X1, provider:  7);
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "value");
        }
        public static ulong ToUInt64(ScottGarland.BigInteger value)
        {
            if((System.Object.ReferenceEquals(objA:  0, objB:  X1)) != true)
            {
                    System.Globalization.CultureInfo val_2 = System.Globalization.CultureInfo.CurrentCulture;
                return System.UInt64.Parse(s:  0, style:  X1, provider:  7);
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "value");
        }
    
    }

}
