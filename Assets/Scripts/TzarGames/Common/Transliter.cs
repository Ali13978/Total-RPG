using UnityEngine;

namespace TzarGames.Common
{
    public static class Transliter
    {
        // Fields
        private static System.Collections.Generic.Dictionary<string, string> transliter;
        
        // Methods
        private static void prepareTranslit()
        {
            TzarGames.Common.Transliter.transliter = new System.Collections.Generic.Dictionary<System.String, System.String>();
            Add(key:  "а", value:  "a");
            Add(key:  "б", value:  "b");
            Add(key:  "в", value:  "v");
            Add(key:  "г", value:  "g");
            Add(key:  "д", value:  "d");
            Add(key:  "е", value:  "e");
            Add(key:  "ё", value:  "yo");
            Add(key:  "ж", value:  "zh");
            Add(key:  "з", value:  "z");
            Add(key:  "и", value:  "i");
            Add(key:  "й", value:  "j");
            Add(key:  "к", value:  "k");
            Add(key:  "л", value:  "l");
            Add(key:  "м", value:  "m");
            Add(key:  "н", value:  "n");
            Add(key:  "о", value:  "o");
            Add(key:  "п", value:  "p");
            Add(key:  "р", value:  "r");
            Add(key:  "с", value:  "s");
            Add(key:  "т", value:  "t");
            Add(key:  "у", value:  "u");
            Add(key:  "ф", value:  "f");
            Add(key:  "х", value:  "h");
            Add(key:  "ц", value:  "c");
            Add(key:  "ч", value:  "ch");
            Add(key:  "ш", value:  "sh");
            Add(key:  "щ", value:  "sch");
            Add(key:  "ъ", value:  "j");
            Add(key:  "ы", value:  "i");
            Add(key:  "ь", value:  "j");
            Add(key:  "э", value:  "e");
            Add(key:  "ю", value:  "yu");
            Add(key:  "я", value:  "ya");
            Add(key:  "А", value:  "A");
            Add(key:  "Б", value:  "B");
            Add(key:  "В", value:  "V");
            Add(key:  "Г", value:  "G");
            Add(key:  "Д", value:  "D");
            Add(key:  "Е", value:  "E");
            Add(key:  "Ё", value:  "Yo");
            Add(key:  "Ж", value:  "Zh");
            Add(key:  "З", value:  "Z");
            Add(key:  "И", value:  "I");
            Add(key:  "Й", value:  "J");
            Add(key:  "К", value:  "K");
            Add(key:  "Л", value:  "L");
            Add(key:  "М", value:  "M");
            Add(key:  "Н", value:  "N");
            Add(key:  "О", value:  "O");
            Add(key:  "П", value:  "P");
            Add(key:  "Р", value:  "R");
            Add(key:  "С", value:  "S");
            Add(key:  "Т", value:  "T");
            Add(key:  "У", value:  "U");
            Add(key:  "Ф", value:  "F");
            Add(key:  "Х", value:  "H");
            Add(key:  "Ц", value:  "C");
            Add(key:  "Ч", value:  "Ch");
            Add(key:  "Ш", value:  "Sh");
            Add(key:  "Щ", value:  "Sch");
            Add(key:  "Ъ", value:  "J");
            Add(key:  "Ы", value:  "I");
            Add(key:  "Ь", value:  "J");
            Add(key:  "Э", value:  "E");
            Add(key:  "Ю", value:  "Yu");
            Add(key:  "Я", value:  "Ya");
        }
        public static string GetTranslit(string sourceText)
        {
            var val_12;
            if(TzarGames.Common.Transliter.transliter == null)
            {
                    TzarGames.Common.Transliter.prepareTranslit();
            }
            
            val_12 = 0;
            goto label_2;
            label_13:
            System.Text.StringBuilder val_2 = Append(value:  X22);
            val_12 = 1;
            label_2:
            if(val_12 >= X1.Length)
            {
                goto label_4;
            }
            
            if((TzarGames.Common.Transliter.transliter.ContainsKey(key:  X1.Chars[1].ToString(provider:  0))) != false)
            {
                    string val_9 = TzarGames.Common.Transliter.transliter.Item[X1.Chars[1].ToString(provider:  0)];
            }
            else
            {
                    string val_11 = X1.Chars[1].ToString(provider:  0);
            }
            
            if(null != 0)
            {
                goto label_13;
            }
            
            goto label_13;
            label_4:
            if(null != 0)
            {
                    return (string)new System.Text.StringBuilder();
            }
            
            return (string)new System.Text.StringBuilder();
        }
    
    }

}
