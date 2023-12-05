
//class Day05Part1
//{
//    static void Main()
//    {
//        string[] lines = File.ReadAllLines("C:\\Users\\AndreasDahlgren\\source\\repos\\AdventOfCode2023\\Day05\\day05input.txt");
//        List<long> seeds = lines[0].Split(' ').Skip(1).Select(long.Parse).ToList();

//        List<List<(long, long, long)>> maps = new List<List<(long, long, long)>>();

//        long i = 2;
//        while (i < lines.Length)
//        {
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

//            i++;
//        }

//        long FindLoc(long seed)
//        {
//            long curNum = seed;

//            foreach (var m in maps)
//            {
//                foreach (var (dstStart, srcStart, rangeLen) in m)
//                {
//                    if (srcStart <= curNum && curNum < srcStart + rangeLen)
//                    {
//                        curNum = dstStart + (curNum - srcStart);
//                        break;
//                    }
//                }
//            }

//            return curNum;
//        }

//        List<long> locs = new List<long>();
//        foreach (var seed in seeds)
//        {
//            long loc = FindLoc(seed);
//            locs.Add(loc);
//        }

//        Console.WriteLine(locs.Min());
//    }
//}
