using System;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace ToLowerBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ToLowerBenchmark>();
        }
    }

    public class ToLowerBenchmark
    {
        private readonly string Data;

        public ToLowerBenchmark()
        {
            var rand = new Random();
            var sb = new StringBuilder();
            for (int i = 0; i < 10000; i++)
            {
                sb.Append(rand.Next('A', 'z' + 1));
            }

            this.Data = sb.ToString();
        }

        [Benchmark]
        public string ToLower() => this.Data.ToLower();

        [Benchmark]
        public string ToLowerInvariant() => this.Data.ToLowerInvariant();

    }
}
