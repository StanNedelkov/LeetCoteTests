using System.Text;

namespace LeetCoteTests
{
    public class LongestCommonPrefix
    {
        public string LongestCommonPrefixes(string[] strs)
        {
            if (strs.Count() == 1)  return strs[0];
            if (strs.Any(x => string.IsNullOrEmpty(x))) return "";

            string reference= strs[0]!;

            int small = strs.Min(x => x.Length);

            StringBuilder stringBuilder= new StringBuilder();

            bool isSame = true;

            for (int i = 0; i < small; i++)
            {
                for (int t = 0; t < strs.Count()-1; t++)
                {
                    string first = strs[t];
                    string second = strs[t+1];

                    if (first[i] != second[i]) 
                    { 
                        isSame = false; 
                        break; 
                    }
                }
                if (!isSame) break;
                stringBuilder.Append(reference[i].ToString());
            }
            return stringBuilder.ToString().TrimEnd();
        }
    }
}
