using System;

namespace PadawansTask12
{
    public static class StringExtension
    {
        public static bool AllCharactersAreUnique(string source)
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }
            if (source == "")
            {
                throw new ArgumentException();
            }
            for (int i = 0; i < source.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (source[j] == source[i])
                        return false;
                }
            }
            return true;
        }
    }
}