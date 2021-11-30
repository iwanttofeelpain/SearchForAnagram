Run project with benchmark: `dotnet run -c release -p SearchForAnagram`

|                         Method |            wordOne |            wordTwo |       Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 |  Gen 1 | Allocated |
|------------------------------- |------------------- |------------------- |-----------:|---------:|---------:|------:|--------:|-------:|-------:|----------:|
|     SortCharArraySequenceEqual | лесопромышленность |             скелет |   137.3 ns |  1.60 ns |  1.50 ns |  1.00 |    0.00 | 0.0165 |      - |     104 B |
| DictionaryAllContainsAndEquals | лесопромышленность |             скелет | 1,739.1 ns | 11.82 ns | 10.47 ns | 12.67 |    0.15 | 0.5856 | 0.0019 |   3,680 B |
|                                |                    |                    |            |          |          |       |         |        |        |           |
|     SortCharArraySequenceEqual | лесопромышленность | солепромышленность |   331.4 ns |  3.31 ns |  3.10 ns |  1.00 |    0.00 | 0.0200 |      - |     128 B |
| DictionaryAllContainsAndEquals | лесопромышленность | солепромышленность | 2,683.2 ns | 38.53 ns | 34.16 ns |  8.10 |    0.13 | 0.7935 | 0.0038 |   4,992 B |
|                                |                    |                    |            |          |          |       |         |        |        |           |
|     SortCharArraySequenceEqual |             телекс |             скелет |   129.1 ns |  1.53 ns |  1.36 ns |  1.00 |    0.00 | 0.0126 |      - |      80 B |
| DictionaryAllContainsAndEquals |             телекс |             скелет | 1,044.7 ns |  9.07 ns |  7.58 ns |  8.09 |    0.12 | 0.3757 |      - |   2,368 B |
|                                |                    |                    |            |          |          |       |         |        |        |           |
|     SortCharArraySequenceEqual |             телекс | солепромышленность |   136.9 ns |  1.80 ns |  1.68 ns |  1.00 |    0.00 | 0.0165 |      - |     104 B |
| DictionaryAllContainsAndEquals |             телекс | солепромышленность | 1,745.4 ns | 16.03 ns | 14.21 ns | 12.75 |    0.19 | 0.5856 | 0.0019 |   3,680 B |
