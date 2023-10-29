```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22000.2538/21H2/SunValley)
12th Gen Intel Core i9-12900H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.100-rc.2.23502.2
  [Host]     : .NET 8.0.0 (8.0.23.47906), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.47906), X64 RyuJIT AVX2


```
| Method           | Mean      | Error     | StdDev    | Gen0   | Allocated |
|----------------- |----------:|----------:|----------:|-------:|----------:|
| ArrayFiler       |  8.500 ns | 0.1879 ns | 0.4815 ns | 0.0083 |     104 B |
| ListFiler        | 21.112 ns | 0.5156 ns | 1.4958 ns | 0.0127 |     160 B |
| IEnumerableFiler |  8.970 ns | 0.2498 ns | 0.7209 ns | 0.0083 |     104 B |
