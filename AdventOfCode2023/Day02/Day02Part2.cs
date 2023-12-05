
//class Day02Part2
//{
//    static void Main()
//    {
//        string[] lines = File.ReadAllLines("C:\\Users\\AndreasDahlgren\\source\\repos\\AdventOfCode2023\\Day02\\day02input.txt");
//        int ans = 0;

//        foreach (string line in lines)
//        {
//            string[] parts = line.Trim().Split(": ");
//            int r = 0, g = 0, b = 0;

//            foreach (string part in parts[1].Split("; "))
//            {
//                foreach (string cubes in part.Split(", "))
//                {
//                    string[] cubeData = cubes.Split(' ');
//                    int num = int.Parse(cubeData[0]);
//                    string color = cubeData[1];

//                    if (color == "red")
//                    {
//                        r = Math.Max(r, num);
//                    }
//                    else if (color == "blue")
//                    {
//                        b = Math.Max(b, num);
//                    }
//                    else if (color == "green")
//                    {
//                        g = Math.Max(g, num);
//                    }
//                }
//            }

//            ans += r * g * b;
//        }

//        Console.WriteLine(ans);
//    }
//}
