/*// See https://aka.ms/new-console-template for more information

int input = int.Parse(Console.ReadLine());
int num = Reverse(input);
Console.WriteLine(num);


///Reverse int number, if the number is outside of int min, max length, return 0
static int Reverse(int x)
{
    long num = Math.Abs((long)x);
    long result = 0;
    while (num != 0)
    {
        int temp = (int)num % 10;
        result = result * 10 + temp;
        num = num / 10;
    
    }

    if (x < 0) result = result * -1;
    if (result > int.MaxValue || result < int.MinValue) return 0;
    

    return (int)result;
}

static int NumberOfWeakCharacters(int[][] properties)
{
    int counter = 0;
    for (int i = 0; i < properties.Length - 1; i++)
    {
        int[] arr = properties[i];
        // int[] arr2 = properties[i + 1];

        for (int j = 0; j < properties.Length; j++)
        {
            int[] arr3 = properties[j];
            // int[]arr4 = properties[j + 1];
            if (arr[0] > arr3[0] && arr[1] > arr3[1] ||
               arr[0] < arr3[0] && arr[1] < arr3[1])
            {
                counter++;
                j=properties.Length;
            }
        }
    }
    return counter;
}
*/

using LeetCoteTests;
string[] array = new[] { "ab", "a" };
var solution = new LongestCommonPrefix().LongestCommonPrefixes(array);
Console.WriteLine(solution);
