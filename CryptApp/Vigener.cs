using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptApp
{
    class Vigener
    {
        public static int[] Encode(int[] words, int[] key)
        {
            int[] result = new int[words.Length];
            if (words.Length >= key.Length)
            {
                for (int i = 0, index = 0; i < words.Length; ++i, ++index)
                {
                    if (words[i] != 0)
                    {
                        result[i] = words[i] + key[index];
                    }
                    if (result[i] > 33)
                    {
                        result[i] -= 33;
                    }
                    if (words[i] == 0)
                    {
                        result[i] = 1000;
                        --index;
                    }
                    if (index == key.Length - 1)
                    {
                        index = -1;
                    }
                }
            }
            if (words.Length < key.Length)
            {
                for (int i = 0; i < words.Length; ++i)
                {
                    if (words[i] != 0)
                    {
                        result[i] = words[i] + key[i];
                    }
                    if (result[i] > 33)
                    {
                        result[i] -= 33;
                    }
                    if (words[i] == 0)
                    {
                        result[i] = -1;
                        --i;
                    }
                }
            }
            return (result);
        }
        public static int[] Decode(int[] words, int[] key)
        {
            int[] result = new int[words.Length];
            for (int i = 0, index = 0; i < words.Length; ++i, ++index)
            {
                if (words[i] != 0)
                {
                    result[i] = words[i] - key[index];
                }
                if (result[i] > 33)
                {
                    result[i] -= 33;
                }
                if (words[i] == 0)
                {
                    result[i] = 1000;
                    --index;
                }
                if (result[i] <= 0)
                {
                    result[i] += 33;
                }
                if (index == key.Length - 1)
                {
                    index = -1;
                }
            }
            return (result);
        }
    }
}