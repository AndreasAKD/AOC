
//class Day01Part1
//{
//    static void Main()
//    {
//        string[] lines = File.ReadAllLines("C:\\Users\\AndreasDahlgren\\source\\repos\\AdventOfCode2023\\Day01\\day01input.txt");
//        int ans = 0;

//        foreach (string line in lines)
//        {
//            string trimmedLine = line.Trim();
//            if (!string.IsNullOrEmpty(trimmedLine))
//            {
//                char? first = null;
//                char? last = null;

//                foreach (char c in trimmedLine)
//                {
//                    if (char.IsDigit(c) && first == null)
//                    {
//                        first = c;
//                    }
//                    if (char.IsDigit(c))
//                    {
//                        last = c;
//                    }
//                }

//                if (first != null && last != null)
//                {
//                    int num = int.Parse(first.ToString() + last.ToString());
//                    ans += num;
//                }
//            }
//        }

//        Console.WriteLine(ans);
//    }
//}
