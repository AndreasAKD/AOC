//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text.RegularExpressions;

//class Day04Part2
//{
//    static void Main()
//    {
//        string[] lines = File.ReadAllLines("C:\\Users\\AndreasDahlgren\\source\\repos\\AdventOfCode2023\\Day04\\day04input.txt");

//        int n = lines.Length;
//        List<List<int>> copies = new List<List<int>>();
//        for (int i = 0; i < n; i++)
//        {
//            copies.Add(new List<int>());
//        }

//        for (int i = 0; i < n; i++)
//        {
//            string[] parts = Regex.Split(lines[i], @"\s+");
//            int idx = Array.IndexOf(parts, "|");
//            List<int> winning = parts.Skip(2).Take(idx - 2).Select(int.Parse).ToList();
//            List<int> ours = parts.Skip(idx + 1).Select(int.Parse).ToList();

//            int score = 0;
//            foreach (int num in ours)
//            {
//                if (winning.Contains(num))
//                {
//                    score++;
//                }
//            }

//            for (int j = i + 1; j < i + score + 1; j++)
//            {
//                copies[i].Add(j);
//            }
//        }

//        List<int> scoreList = Enumerable.Repeat(1, n).ToList();

//        for (int i = n - 1; i >= 0; i--)
//        {
//            foreach (int j in copies[i])
//            {
//                scoreList[i] += scoreList[j];
//            }
//        }

//        Console.WriteLine(scoreList.Sum());
//    }
//}