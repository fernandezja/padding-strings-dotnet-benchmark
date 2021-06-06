using BenchmarkDotNet.Running;
using System;

namespace StringPadding.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StringPadding benchmarks!");
            var summary = BenchmarkRunner.Run<StringPaddingBenchmarks>();

            Console.ReadKey();
        }
    }
}
