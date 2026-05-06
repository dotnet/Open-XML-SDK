```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8328/25H2/2025Update/HudsonValley2)
AMD Ryzen 9 5900X 3.70GHz, 1 CPU, 24 logical and 12 physical cores
.NET SDK 10.0.203
  [Host]     : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3


```
| Method                      | Mean         | Error      | StdDev     | Gen0   | Gen1   | Allocated |
|---------------------------- |-------------:|-----------:|-----------:|-------:|-------:|----------:|
| Text_Shallow                |     21.79 ns |   0.134 ns |   0.126 ns | 0.0057 |      - |      96 B |
| Text_Deep                   |     24.13 ns |   0.103 ns |   0.091 ns | 0.0057 |      - |      96 B |
| Run_Shallow                 |     21.15 ns |   0.077 ns |   0.065 ns | 0.0052 |      - |      88 B |
| Run_Deep                    |    327.61 ns |   1.624 ns |   1.356 ns | 0.0567 |      - |     952 B |
| Paragraph_Simple_Deep       |    264.34 ns |   2.735 ns |   2.425 ns | 0.0496 |      - |     832 B |
| Paragraph_Formatted_Deep    |    785.85 ns |   5.807 ns |   4.849 ns | 0.1297 |      - |    2176 B |
| Body_TenParagraphs_Deep     |  4,411.23 ns |  19.925 ns |  16.638 ns | 0.6638 | 0.0153 |   11129 B |
| Body_HundredParagraphs_Deep | 44,062.40 ns | 131.925 ns | 110.164 ns | 6.5918 | 1.6479 |  110495 B |
