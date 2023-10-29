```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22000.2538/21H2/SunValley)
12th Gen Intel Core i9-12900H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.100-rc.2.23502.2
  [Host]     : .NET 8.0.0 (8.0.23.47906), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 8.0.0 (8.0.23.47906), X64 RyuJIT AVX2


```
| Method | Mean      | Error     | StdDev   | Median    |
|------- |----------:|----------:|---------:|----------:|
| Sha256 |  5.064 μs | 0.3603 μs | 1.039 μs |  4.569 μs |
| Md5    | 17.125 μs | 0.4440 μs | 1.252 μs | 17.319 μs |
