
//class Day01Part2
//{
//    static void Main()
//    {
//        string data = File.ReadAllText("C:\\Users\\AndreasDahlgren\\source\\repos\\AdventOfCode2023\\Day01\\day01input.txt");
//        int ans = 0;

//        string[] nums = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

//        string[] words = data.Trim().Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

//        foreach (string line in words)
//        {
//            int? first = null;
//            int? last = null;

//            for (int i = 0; i < line.Length; i++)
//            {
//                int? cur = null;
//                char c = line[i];

//                if (char.IsDigit(c))
//                {
//                    cur = int.Parse(c.ToString());
//                }

//                for (int j = 0; j < nums.Length; j++)
//                {
//                    if (i + nums[j].Length <= line.Length && line.Substring(i, nums[j].Length) == nums[j])
//                    {
//                        cur = j + 1;
//                        break;
//                    }
//                }

//                if (cur != null)
//                {
//                    if (first == null)
//                    {
//                        first = cur;
//                    }
//                    last = cur;
//                }
//            }

//            if (first != null && last != null)
//            {
//                ans += (int)first * 10 + (int)last;
//            }
//        }

//        Console.WriteLine(ans);
//    }
//}