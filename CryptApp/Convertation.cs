using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptApp
{
    class Convertation
    {
        static private string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        // Каждый символ строки в значеиние соответствующее номеру в алфавите
        public static int[] ToNumber(string str)
        {
            int[] result = new int[str.Length];
            for (int i = 0; i < str.Length; ++i)
            {
                for (int j = 0; j < alphabet.Length; ++j)
                {
                    if (str[i] == alphabet[j])
                    {
                        result[i] = j + 1;
                        if (j > 33)
                        {
                            result[i] = result[i] - 33;
                        }
                    }
                }
            }
            return (result);
        }
        // Номер элемента алфавита в его значение
        public static string ToStr(int[] mass)
        {
            string result = " ";
            for (int i = 0; i < mass.Length; ++i)
            {
                if (mass[i] > 900)
                {
                    string help_s = " ";
                    result = string.Concat(result, help_s);
                }
                for (int j = 0; j < alphabet.Length; ++j)
                {
                    if (mass[i] == j + 1)
                    {
                        char help_c = alphabet[j];
                        result = string.Concat(result, help_c);
                    }
                }
            }
            result = result.Trim();
            return (result);
        }
    }
}