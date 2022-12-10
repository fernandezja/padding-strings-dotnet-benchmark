# padding-strings-dotnet-benchmark
Some methods to padding string (Benchmark in c#)

[![.NET](https://github.com/fernandezja/padding-strings-dotnet-benchmark/actions/workflows/CI-dotnet.yml/badge.svg)](https://github.com/fernandezja/padding-strings-dotnet-benchmark/actions/workflows/CI-dotnet.yml)

 ### Benchmark Results 

Data Test

 - inputText: **"The Force will be with you always"**
 - totalWidth: **10000**
 - paddingChar: **!**

#### .NET 7.0.0

BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22000.1281/21H2)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]   : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  .NET 7.0 : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


|                                    Method |      Mean |     Error |     StdDev |    Median |    Gen0 |   Gen1 | Allocated |
|------------------------------------------ |----------:|----------:|-----------:|----------:|--------:|-------:|----------:|
|                                  PadRight |  1.185 us | 0.0203 us |  0.0428 us |  1.180 us |  4.7607 |      - |   20024 B |
|                        PadRightWithConcat |  2.736 us | 0.0686 us |  0.1968 us |  2.710 us |  9.5215 | 0.0038 |   39984 B |
|                 PadRightWithInterpolation |  2.950 us | 0.1390 us |  0.3875 us |  2.797 us |  9.5215 | 0.0038 |   39984 B |
|        PadRightWithConcatEnumerableRepeat | 78.411 us | 4.2690 us | 11.8293 us | 75.109 us |  9.2773 | 0.4883 |   40016 B |
| PadRightWithInterpolationEnumerableRepeat | 71.330 us | 2.9889 us |  8.0295 us | 68.072 us |  9.5215 | 0.1221 |   40016 B |
|                     PadRightWithCharArray |  6.447 us | 0.5721 us |  1.6688 us |  5.978 us | 14.3433 | 0.0305 |   60136 B |
|                 PadRightWithStringBuilder | 22.555 us | 0.6701 us |  1.8790 us | 22.018 us | 12.8174 |      - |   53656 B |
|           PadRightWithStringBuilderInsert | 78.901 us | 2.0609 us |  5.8129 us | 76.772 us |  9.5215 |      - |   40200 B |
|                  PadRightWithReadOnlySpan |  3.249 us | 0.2359 us |  0.6767 us |  2.958 us |  9.5215 | 0.0038 |   39984 B |
|                 PadRightWithZStringConcat |  3.723 us | 0.1570 us |  0.4454 us |  3.587 us |  9.5215 |      - |   39984 B |
| PadRightWithZStringStringBuilderForAppend | 31.276 us | 1.0593 us |  3.0222 us | 30.515 us | 20.3857 |      - |   85584 B |
| PadRightWithZStringStringBuilderNewString |  4.839 us | 0.1630 us |  0.4730 us |  4.699 us | 24.9939 | 0.0076 |  105544 B |


 #### NET 5 (5.0.6)

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.985 (20H2/October2020Update)
Intel Core i7-8550U CPU 1.80GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100-preview.1.21103.13

 -  [Host]     : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
  - DefaultJob : .NET 5.0.6 (5.0.621.22011), X64 RyuJIT



|                                    Method |      Mean |     Error |    StdDev | Ratio | RatioSD |   Gen 0 |  Gen 1 | Allocated |
|------------------------------------------ |----------:|----------:|----------:|------:|--------:|--------:|-------:|----------:|
|                                  PadRight |  5.513 us | 0.1097 us | 0.2086 us |  1.00 |    0.00 |  4.7607 |      - |     20 KB |
|                        PadRightWithConcat |  3.363 us | 0.0668 us | 0.1625 us |  0.61 |    0.03 |  9.5215 |      - |     39 KB |
|                 PadRightWithInterpolation |  3.361 us | 0.0654 us | 0.1791 us |  0.62 |    0.05 |  9.5215 |      - |     39 KB |
|        PadRightWithConcatEnumerableRepeat | 52.138 us | 1.0076 us | 1.4451 us |  9.48 |    0.51 |  9.5215 |      - |     39 KB |
| PadRightWithInterpolationEnumerableRepeat | 54.770 us | 1.0897 us | 1.6310 us |  9.92 |    0.49 |  9.5215 |      - |     39 KB |
|                     PadRightWithCharArray |  3.637 us | 0.0391 us | 0.0326 us |  0.67 |    0.02 | 14.3509 |      - |     59 KB |
|                 PadRightWithStringBuilder | 23.810 us | 0.4667 us | 0.5188 us |  4.38 |    0.20 | 12.8174 | 1.4038 |     52 KB |
|           PadRightWithStringBuilderInsert | 94.825 us | 1.8471 us | 2.8758 us | 17.17 |    0.85 |  9.5215 |      - |     39 KB |
|                  PadRightWithReadOnlySpan |  3.161 us | 0.0469 us | 0.0416 us |  0.58 |    0.02 |  9.5215 |      - |     39 KB |
|                 PadRightWithZStringConcat |  3.637 us | 0.0454 us | 0.0591 us |  0.67 |    0.03 |  9.5215 |      - |     39 KB |
| PadRightWithZStringStringBuilderForAppend | 18.337 us | 0.3593 us | 0.6837 us |  3.33 |    0.18 | 20.3857 |      - |     84 KB |
| PadRightWithZStringStringBuilderNewString |  4.522 us | 0.0608 us | 0.0539 us |  0.83 |    0.03 | 24.9939 | 0.0076 |    103 KB |