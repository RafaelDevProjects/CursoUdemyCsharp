using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy
{
    internal class Calculator
    {
        public static int Sum(params int[] numbers) // usando modificador de parametros
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static void TripleRef(ref int x) // usando ref
        {
            x = x * 3;
        }

        public static void TripleOut(int origin, out int result) // usando o out
        {
            result = origin * 3;
        }
    }
}
