using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCoteTests
{
    public  class RomanToInteger_13
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int> 
            {
                ['I']= 1,
                ['V'] =5,
                ['X'] = 10,
                ['L'] = 50,
                ['C'] =100,
                ['D'] = 500,
                ['M'] = 1000
            };

            int sum = 0;
           

            for (int i = 0; i < s.Length; i++)
            {
                int numb = dictionary[s[i]];

                if (i < s.Length - 1)
                {
                    if (numb == 1 && s[i+1] == 'V' || numb == 1 && s[i + 1] == 'X')
                    {
                        sum += dictionary[s[i + 1]] - numb;
                        i++;
                        continue;
                    }

                    if (numb == 10 && s[i + 1] == 'L' || numb == 10 && s[i + 1] == 'C')
                    {
                        sum +=  dictionary[s[i + 1]] - numb;
                        i++;
                        continue;
                    }

                    if (numb == 100 && s[i + 1] == 'D' || numb == 100 && s[i + 1] == 'M')
                    {
                        sum +=  dictionary[s[i + 1]] - numb;
                        i++;
                        continue;
                    }
                }

                sum += numb;
            }

            return sum;
        }
    }
}
