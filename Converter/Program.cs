using System;
using System.Linq;

namespace Converter
{
    public class Program
    {
        static void StringToDouble(string arg)
        {
            int[] integerValues = { 48, 49, 50, 51, 52, 53, 54, 55, 56, 57 };
            double[] numeric = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int indexer = 0;
            double divider = 1;
            double result = 0;
            double resultAfterDot = 0;
            foreach (var item in arg)
            {
                if (item == '.')
                {
                    arg = arg.Remove(0, arg.IndexOf('.')+1);
                    break;
                }
                for (int i = 0; i <integerValues.Length; i++)
                {
                    if (integerValues[i] == item)
                    {
                        if (indexer >= 1) result *= 10;
                        result += numeric[i];
                        indexer++;
                        break;
                    }
                }
            }
            indexer = 0;
            foreach (var item in arg)
            {
                for (int i = 0; i < integerValues.Length; i++)
                {
                    if (integerValues[i] == item)
                    {
                        if (indexer >= 1) resultAfterDot *= 10;
                        resultAfterDot += numeric[i];
                        indexer++;
                        break;
                    }
                }
            }
            for (int i = 0; i < indexer; i++)
            {
                divider *= 10;
            }
            result = result + resultAfterDot/ divider;
            Console.WriteLine($"double: {result}");
        }

        static void Main(string[] args)
        {
            StringToDouble("145.15");
            StringToDouble("236556.881293213864");
            StringToDouble("89735478.11111111");
            StringToDouble("200.0015");
            StringToDouble("800.888");
        }
    }
}
