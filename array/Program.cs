using System;
using System.Linq;

namespace array
{  
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 15, 8, 6, 9 };
            int[] vs = { 8, 6 };
            LINq(source, vs);
            Method(source, vs);
            Clean(source, vs);

        }
        static int[] LINq(int[] source, int[] vs)
        {
            int[] result = { };
            result = source.Where(p => !vs.Contains(p)).ToArray();
            return result;
        }

        static int[] Method(int[] source, int[] vs)
        {
            int[] result = { };
            foreach (var i in source)
            {
                if (Array.IndexOf(vs, i) == -1)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = i;
                    Console.WriteLine(i);
                }
            }
            return result;
        }

        static int[] Clean(int[] source, int[] vs)
        {
            int[] result = { };
            int[] iCoin = new int[source.Length];
            int exc = 0;
            for (int i = 0; i < vs.Length; i++)
            {
                int index = 0;
                for (int y = 0; y < source.Length; y++)
                {
                    if (vs[i] == source[y])
                    {
                        exc++;
                        continue;
                    }
                    iCoin[index] = source[y];
                    index++;
                }
                source = iCoin;
            }
            result = new int[source.Length - exc];

            for (int t = 0; t <= source.Length - exc - 1; t++)
            {
                result[t] = iCoin[t];
            }
            return result;
        }

        
    }
}
 