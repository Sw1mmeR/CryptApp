using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptApp
{
    class Caesar
    {
        public static int[] Encode(int[] words, int key)
        {
            int[] result = new int[words.Length];
            for (int i = 0; i < words.Length; ++i)
            {
                if (words[i] != 0)
                {
                    result[i] = words[i] + key;
                }
                if (result[i] > 33)
                {
                    result[i] -= 33;
                }
                if (words[i] == 0)
                {
                    result[i] = 1000;
                }
            }
            return (result);
        }
        public static int[] Decode(int[] words, int key)
        {
            int[] result = new int[words.Length];
            for (int i = 0; i < words.Length; ++i)
            {
                if (words[i] != 0)
                {
                    result[i] = words[i] - key;
                }
                if (result[i] > 33)
                {
                    result[i] -= 33;
                }
                if (words[i] == 0)
                {
                    result[i] = 1000;
                }
                if (result[i] <= 0)
                {
                    result[i] += 33;
                }
            }
            return (result);
        }
    }
}