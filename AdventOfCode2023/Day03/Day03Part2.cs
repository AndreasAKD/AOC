
//class Day03Part2
//{
//    static void Main()
//    {
//        string[] lines = File.ReadAllLines("C:\\Users\\AndreasDahlgren\\source\\repos\\AdventOfCode2023\\Day03\\day03input.txt");
//        int n = lines.Length;
//        int m = lines[0].Length;

//        int[][][] goods = new int[n][][];

//        for (int i = 0; i < n; i++)
//        {
//            goods[i] = new int[m][];
//            for (int j = 0; j < m; j++)
//            {
//                goods[i][j] = new int[0];
//            }
//        }

//        bool IsSymbol(int i, int j, int num)
//        {
//            if (!(0 <= i && i < n && 0 <= j && j < m))
//                return false;

//            if (lines[i][j] == '*')
//            {
//                int[] currentGoods = goods[i][j];
//                Array.Resize(ref currentGoods, currentGoods.Length + 1);
//                currentGoods[currentGoods.Length - 1] = num;
//                goods[i][j] = currentGoods;
//            }

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
//                string numStr = "";
//                while (j < m && char.IsDigit(lines[i][j]))
//                {
//                    numStr += lines[i][j];
//                    j++;
//                }

//                if (numStr == "")
//                {
//                    j++;
//                    continue;
//                }

//                int parsedNum = int.Parse(numStr);

//                // Number ended, take a look around
//                IsSymbol(i, start - 1, parsedNum);
//                IsSymbol(i, j, parsedNum);

//                for (int k = start - 1; k <= j; k++)
//                {
//                    IsSymbol(i - 1, k, parsedNum);
//                    IsSymbol(i + 1, k, parsedNum);
//                }
//            }
//        }

//        for (int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < m; j++)
//            {
//                int[] nums = goods[i][j];
//                if (lines[i][j] == '*' && nums.Length == 2)
//                {
//                    ans += nums[0] * nums[1];
//                }
//            }
//        }

//        Console.WriteLine(ans);
//    }
//}
