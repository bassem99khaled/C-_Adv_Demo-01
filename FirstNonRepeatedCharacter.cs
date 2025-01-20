using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Adv_Demo_01
{
    internal class FirstNonRepeatedCharacter
    {
        public static int FindNonRepeatedCharacter(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return -1;
            }


            Dictionary<char, int> charCount = new Dictionary<char, int>();


            foreach (char c in input)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }


            for (int i = 0; i < input.Length; i++)
            {
                if (charCount[input[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
__________