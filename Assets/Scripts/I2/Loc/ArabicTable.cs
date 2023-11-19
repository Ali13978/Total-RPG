using UnityEngine;

namespace I2.Loc
{
    internal class ArabicTable
    {
        // Fields
        private static System.Collections.Generic.List<I2.Loc.ArabicMapping> mapList;
        private static I2.Loc.ArabicTable arabicMapper;
        
        // Properties
        internal static I2.Loc.ArabicTable ArabicMapper { get; }
        
        // Methods
        private ArabicTable()
        {
            I2.Loc.ArabicTable.mapList = new System.Collections.Generic.List<I2.Loc.ArabicMapping>();
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1569;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1575;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1571;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1572;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1573;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1609;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1574;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1576;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1578;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1579;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1580;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1581;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1582;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1583;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1584;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1585;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1586;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1587;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1588;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1589;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1590;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1591;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1592;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1593;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1594;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1601;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1602;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1603;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1604;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1605;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1606;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1607;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1608;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1610;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1570;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1577;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1662;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1670;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1688;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1711;
            Add(item:  new System.Object());
            typeof(I2.Loc.ArabicMapping).__il2cppRuntimeField_10 = 1705;
            Add(item:  new System.Object());
        }
        internal static I2.Loc.ArabicTable get_ArabicMapper()
        {
            I2.Loc.ArabicTable val_2;
            I2.Loc.ArabicTable val_3;
            I2.Loc.ArabicTable val_1 = null;
            val_3 = I2.Loc.ArabicTable.arabicMapper;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            val_2 = val_1;
            val_1 = new I2.Loc.ArabicTable();
            I2.Loc.ArabicTable.arabicMapper = val_2;
            val_3 = I2.Loc.ArabicTable.arabicMapper;
            return val_3;
        }
        internal int Convert(int toBeConverted)
        {
            var val_3;
            var val_4;
            val_3 = toBeConverted;
            List.Enumerator<T> val_1 = I2.Loc.ArabicTable.mapList.GetEnumerator();
            label_4:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_2 = 0.InitializationCallback;
            if(0 != val_3)
            {
                goto label_4;
            }
            
            val_3 = 0;
            val_4 = public System.Void List.Enumerator<I2.Loc.ArabicMapping>::Dispose();
            goto label_5;
            label_2:
            val_4 = public System.Void List.Enumerator<I2.Loc.ArabicMapping>::Dispose();
            label_5:
            0.Dispose();
            return (int)val_3;
        }
    
    }

}
