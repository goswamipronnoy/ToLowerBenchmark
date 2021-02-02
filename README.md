# ToLowerBenchmark
Benchmarking .NET implementations of ToLower and ToLowerInvariant for a discussion at work

Run without debugging in "Release" mode. 'ctrl' + 'F5' in Visual Studio.

Results from my machine:
```
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Xeon CPU E5-1650 v4 3.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.102
  [Host]     : .NET Core 3.1.11 (CoreCLR 4.700.20.56602, CoreFX 4.700.20.56604), X64 RyuJIT
  DefaultJob : .NET Core 3.1.11 (CoreCLR 4.700.20.56602, CoreFX 4.700.20.56604), X64 RyuJIT
```

|           Method |     Mean |    Error |   StdDev |
|----------------- |---------:|---------:|---------:|
|          ToLower | 10.63 us | 0.084 us | 0.070 us |
| ToLowerInvariant | 10.59 us | 0.102 us | 0.091 us |
