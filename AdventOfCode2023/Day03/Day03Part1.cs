
//class Day03Part1
//{
//    static void Main()
//    {
//        string[] lines = File.ReadAllLines("C:\\Users\\AndreasDahlgren\\source\\repos\\AdventOfCode2023\\Day03\\day03input.txt");
//        int n = lines.Length;
//        int m = lines[0].Length;

//        bool IsSymbol(int i, int j)
//        {
//            if (!(0 <= i && i < n && 0 <= j && j < m))
//                return false;

//            return lines[i][j] != '.' && !char.IsDigit(lines[i][j]);
//        }

//        int ans = 0;

//        for (int i = 0; i < n; i++)
//        {
//            int start = 0;
//            int j = 0;

//            while (j < m)
//            {
//                start = j;
//                string num = "";
//                while (j < m && char.IsDigit(lines[i][j]))
//                {
//                    num += lines[i][j];
//                    j++;
//                }

//                if (num == "")
//                {
//                    j++;
//                    continue;
//                }

//                int parsedNum = int.Parse(num);

//                // Number ended, look around
//                if (IsSymbol(i, start - 1) || IsSymbol(i, j))
//                {
//                    ans += parsedNum;
//                    continue;
//                }

//                for (int k = start - 1; k <= j; k++)
//                {
//                    if (IsSymbol(i - 1, k) || IsSymbol(i + 1, k))
//                    {
//                        ans += parsedNum;
//                        break;
//                    }
//                }
//            }
//        }

//        Console.WriteLine(ans);
//    }
//}
