using System;

namespace TestSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[10];
            for (int i = 0; i < 10; i++)
            {
                a[i] = i;
            }

            ReadOnlySpan<int> span = a.AsSpan();
            //var slice = span.Slice(0, 3);
            //slice[0] = 100; will error

            foreach (var item in span)
            {
                Console.WriteLine(item);
            }
        }
    }
}
