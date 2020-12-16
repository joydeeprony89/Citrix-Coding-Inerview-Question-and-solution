using System;

namespace Citrix_Programmer_Problem
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetIndices("programmerxxxprozmerqgram"));
        }

        static int GetIndices(string s)
        {
            const string programmer = "programmer";
            int start = 0;
            int inputLength = s.Length;
            int fistOccurancelatCharacterIndex = 0;
            int secondOccuranceFirstCharacterIndex = 0;
            for (int j  = start + programmer.Length; j < inputLength; j++)
            {
                if(j < inputLength && ContainsAllCharacters(s.Substring(start,j), programmer))
                {
                    fistOccurancelatCharacterIndex = j;
                    break;
                }
            }

            string str = s.Substring(fistOccurancelatCharacterIndex);
            if (ContainsAllCharacters(str, programmer))
            {
                secondOccuranceFirstCharacterIndex = str.IndexOf("pr") + fistOccurancelatCharacterIndex;
            }
            int difference = secondOccuranceFirstCharacterIndex - fistOccurancelatCharacterIndex;
            return difference > 0 ? difference : 0;
        }

        static bool ContainsAllCharacters(string source, string destination)
        {
            int[] arr = new int[52];
            for(int i = 0 ; i < source.Length; i++)
            {
                arr[source[i] - 'a']++;
            }

            for(int i = 0; i < destination.Length; i++)
            {
                arr[destination[i] - 'a']--;
                if (arr[destination[i] - 'a'] < 0) return false;
            }

            return true;
        }
    }
}
