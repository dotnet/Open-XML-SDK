```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8328/25H2/2025Update/HudsonValley2)
AMD Ryzen 9 5900X 3.70GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3


```
| Method                      | Mean         | Error      | StdDev     | Median       | Gen0   | Gen1   | Allocated |
|---------------------------- |-------------:|-----------:|-----------:|-------------:|-------:|-------:|----------:|
| Text_Shallow                |     22.55 ns |   0.495 ns |   0.741 ns |     22.25 ns | 0.0057 |      - |      96 B |
| Text_Deep                   |     24.79 ns |   0.592 ns |   1.744 ns |     23.90 ns | 0.0057 |      - |      96 B |
| Run_Shallow                 |     20.65 ns |   0.251 ns |   0.210 ns |     20.52 ns | 0.0052 |      - |      88 B |
| Run_Deep                    |    327.11 ns |   3.001 ns |   2.506 ns |    326.52 ns | 0.0472 |      - |     792 B |
| Paragraph_Simple_Deep       |    259.56 ns |   2.594 ns |   2.300 ns |    258.96 ns | 0.0381 |      - |     640 B |
| Paragraph_Formatted_Deep    |    757.03 ns |   3.812 ns |   3.183 ns |    757.82 ns | 0.1030 |      - |    1728 B |
| Body_TenParagraphs_Deep     |  4,292.36 ns |  13.933 ns |  11.635 ns |  4,293.24 ns | 0.5264 | 0.0153 |    8889 B |
| Body_HundredParagraphs_Deep | 40,634.01 ns | 237.623 ns | 198.426 ns | 40,635.65 ns | 5.2490 | 1.2817 |   88094 B |
