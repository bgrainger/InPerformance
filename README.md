# InPerformance

Benchmarks `in` parameters (new C# 7.2 feature) against `ref` parameters with `struct` and `readonly struct`
arguments.

### Results

``` ini

BenchmarkDotNet=v0.10.11, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.64)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410070 Hz, Resolution=293.2491 ns, Timer=TSC
.NET Core SDK=2.1.2
  [Host]     : .NET Core 2.0.3 (Framework 4.6.25815.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.3 (Framework 4.6.25815.02), 64bit RyuJIT
```

|               Method |     Mean |     Error |    StdDev |
|--------------------- |---------:|----------:|----------:|
|         PointByValue | 25.09 ns | 0.0648 ns | 0.0607 ns |
|           PointByRef | 21.77 ns | 0.1213 ns | 0.1075 ns |
|            PointByIn | 34.59 ns | 0.3107 ns | 0.2754 ns |
| ReadOnlyPointByValue | 25.29 ns | 0.2019 ns | 0.1889 ns |
|   ReadOnlyPointByRef | 21.78 ns | 0.1030 ns | 0.0964 ns |
|    ReadOnlyPointByIn | 21.79 ns | 0.1211 ns | 0.1074 ns |
