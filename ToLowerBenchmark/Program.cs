using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace ToLowerBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            //var summary = BenchmarkRunner.Run<ToLowerBenchmark>();
            var summary = BenchmarkRunner.Run<ThreadSleepBenchmark>();
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

    public class ThreadSleepBenchmark
    {
        private int delayDuration;

        public ThreadSleepBenchmark()
        {
            this.delayDuration = 1;
        }

        [Benchmark]
        public void ThreadSleep() => Thread.Sleep(this.delayDuration);

        [Benchmark]
        public void TaskDelay() => Task.Delay(this.delayDuration).Wait();

    }
}
