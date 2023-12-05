
//class Day02Part1
//{
//    static void Main()
//    {
//        string[] lines = File.ReadAllLines("C:\\Users\\AndreasDahlgren\\source\\repos\\AdventOfCode2023\\Day02\\day02input.txt");
//        int ans = 0;

//        foreach (string line in lines)
//        {
//            string[] parts = line.Trim().Split(": ");
//            int _id = int.Parse(parts[0].Split(' ')[1]);

//            bool good = true;
//            string[] gameParts = parts[1].Split("; ");

//            foreach (string part in gameParts)
//            {
//                string[] cubes = part.Split(", ");

//                foreach (string cube in cubes)
//                {
//                    string[] cubeData = cube.Split(' ');
//                    int num = int.Parse(cubeData[0]);
//                    string color = cubeData[1];

//                    if ((color == "red" && num > 12) || (color == "blue" && num > 14) || (color == "green" && num > 13))
//                    {
//                        good = false;
//                        break;
//                    }
//                }

//                if (!good)
//                {
//                    break;
//                }
//            }

//            if (good)
//            {
//                ans += _id;
//            }
//        }

//        Console.WriteLine(ans);
//    }
//}
