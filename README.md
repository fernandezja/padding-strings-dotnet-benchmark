# padding-strings-dotnet-benchmark
Some methods to padding string (Benchmark in c#)

 ### Benchmark Results 

Data Test

 - inputText: **"The Force will be with you always"**
 - totalWidth: **10000**
 - paddingChar: **!**

 ##### NET 5 (5.0.6)

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.985 (20H2/October2020Update)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100-preview.1.21103.13

 -  [Host]     : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
  - DefaultJob : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT



|                                    Method |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|------------------------------------------ |----------:|----------:|----------:|----------:|------:|--------:|--------:|-------:|------:|----------:|
|                                  PadRight |  5.348 us | 0.1060 us | 0.1486 us |  5.321 us |  1.00 |    0.00 |  4.7607 |      - |     - |     20 KB |
|                        PadRightWithConcat |  3.221 us | 0.0366 us | 0.0306 us |  3.220 us |  0.60 |    0.02 |  9.5215 |      - |     - |     39 KB |
|                 PadRightWithInterpolation |  3.361 us | 0.0666 us | 0.1461 us |  3.290 us |  0.63 |    0.03 |  9.5215 |      - |     - |     39 KB |
|        PadRightWithConcatEnumerableRepeat | 56.097 us | 1.1144 us | 1.9517 us | 55.761 us | 10.55 |    0.52 |  9.5215 |      - |     - |     39 KB |
| PadRightWithInterpolationEnumerableRepeat | 57.420 us | 1.1123 us | 1.0924 us | 57.181 us | 10.77 |    0.36 |  9.5215 |      - |     - |     39 KB |
|                     PadRightWithCharArray |  3.902 us | 0.0755 us | 0.1977 us |  3.848 us |  0.74 |    0.05 | 14.3509 |      - |     - |     59 KB |
|                 PadRightWithStringBuilder | 26.313 us | 0.7737 us | 2.1950 us | 25.629 us |  4.96 |    0.43 | 12.8174 | 1.4038 |     - |     52 KB |
|           PadRightWithStringBuilderInsert | 99.290 us | 1.9656 us | 1.9305 us | 99.194 us | 18.63 |    0.68 |  9.5215 |      - |     - |     39 KB |