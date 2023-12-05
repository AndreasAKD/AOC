
//class Day05Part2
//{
//    static void Main()
//    {
//        string[] lines = File.ReadAllLines("C:\\Users\\AndreasDahlgren\\source\\repos\\AdventOfCode2023\\Day05\\day05input.txt");
//        List<long> rawSeeds = lines[0].Split(' ').Skip(1).Select(long.Parse).ToList();

//        List<(long, long)> seeds = rawSeeds.Where((x, i) => i % 2 == 0).Zip(rawSeeds.Where((x, i) => i % 2 != 0), (x, y) => (x, y)).ToList();

//        List<List<(long, long, long)>> maps = new List<List<(long, long, long)>>();

//        long i = 2;
//        while (i < lines.Length)
//        {
//            string[] catParts = lines[i].Split(' ')[0].Split('-');
//            maps.Add(new List<(long, long, long)>());

//            i++;
//            while (i < lines.Length && lines[i] != "")
//            {
//                string[] parts = lines[i].Split(' ');
//                long dstStart = long.Parse(parts[0]);
//                long srcStart = long.Parse(parts[1]);
//                long rangeLen = long.Parse(parts[2]);
//                maps[^1].Add((dstStart, srcStart, rangeLen));
//                i++;
//            }

//            maps[^1].Sort((x, y) => x.Item2.CompareTo(y.Item2));

//            i++;
//        }

//        foreach (var m in maps)
//        {
//            for (int j = 0; j < m.Count - 1; j++)
//            {
//                if (!(m[j].Item2 + m[j].Item3 <= m[j + 1].Item2))
//                {
//                    Console.WriteLine($"{m[j]} {m[j + 1]}");
//                }
//            }
//        }

//        IEnumerable<(long, long)> Remap(long lo, long hi, List<(long, long, long)> m)
//        {
//            List<(long, long, long)> ans = new List<(long, long, long)>();

//            foreach (var (dst, src, R) in m)
//            {
//                long end = src + R - 1;
//                long D = dst - src;

//                if (!(end < lo || src > hi))
//                {
//                    ans.Add((Math.Max(src, lo), Math.Min(end, hi), D));
//                }
//            }

//            foreach (var interval in ans.Select((x, i) => (x, i)).Where(x => x.i < ans.Count - 1))
//            {
//                (long l, long r, long D) = interval.x;
//                yield return (l + D, r + D);

//                if (interval.i < ans.Count - 1 && ans[interval.i + 1].Item1 > r + 1)
//                {
//                    yield return (r + 1, ans[interval.i + 1].Item1 - 1);
//                }
//            }

//            if (ans.Count == 0)
//            {
//                yield return (lo, hi);
//                yield break;
//            }

//            if (ans[0].Item1 != lo)
//            {
//                yield return (lo, ans[0].Item1 - 1);
//            }
//            if (ans[^1].Item2 != hi)
//            {
//                yield return (ans[^1].Item2 + 1, hi);
//            }
//        }

//        List<long> locs = new List<long>();
//        long ans = 1L << 60;

//        foreach (var (start, R) in seeds)
//        {
//            List<(long, long)> curIntervals = new List<(long, long)> { (start, start + R - 1) };
//            List<(long, long)> newIntervals = new List<(long, long)>();

//            foreach (var m in maps)
//            {
//                foreach (var (lo, hi) in curIntervals)
//                {
//                    foreach (var newInterval in Remap(lo, hi, m))
//                    {
//                        newIntervals.Add(newInterval);
//                    }
//                }

//                curIntervals = newIntervals.ToList();
//                newIntervals.Clear();
//            }

//            foreach (var (lo, hi) in curIntervals)
//            {
//                ans = Math.Min(ans, lo);
//            }
//        }

//        Console.WriteLine(ans);
//    }
//}
