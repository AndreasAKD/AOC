//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text.RegularExpressions;

//class Day04Part1
//{
//    static void Main()
//    {
//        string[] lines = File.ReadAllLines("C:\\Users\\AndreasDahlgren\\source\\repos\\NCValidatorVersion2\\NCValidatorVersion2\\day04input.txt");
//        int ans = 0;

//        foreach (string line in lines)
//        {
//            string[] parts = Regex.Split(line.Trim(), @"\s+");
//            List<int> winning = parts.Skip(2).Take(10).Select(int.Parse).ToList();
//            List<int> ours = parts.Skip(13).Select(int.Parse).ToList();

//            int score = 0;
//            foreach (int num in ours)
//            {
//                if (winning.Contains(num))
//                {
//                    score++;
//                }
//            }

//            if (score > 0)
//            {
//                ans += Convert.ToInt32(Math.Pow(2, score - 1));
//            }
//        }

//        Console.WriteLine(ans);
//    }
//}
