using System;

namespace test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte eggs = byte.Parse(Console.ReadLine());
            byte comparing = 0;
            string maxEggsPerColour = null;
            byte maxEggs = 0;


            byte blue = 0;
            byte red = 0;
            byte orange = 0;
            byte green = 0;


            while (comparing < eggs)
            {
                string colour = Console.ReadLine();
                if (colour == "blue")
                {
                    blue += 1;
                    comparing += 1;

                }
                if (colour == "green")
                {
                    green += 1;
                    comparing += 1;

                }
                if (colour == "red")
                {
                    red += 1;
                    comparing += 1;
                }
                if (colour == "orange")
                {
                    orange += 1;
                    comparing += 1;
                }

            }
            if (green > blue && green > red && green > orange)
            {
                maxEggsPerColour = "green";
                maxEggs = green;
            }
            if (orange > blue && orange > red && orange > green)
            {
                maxEggsPerColour = "orange";
                maxEggs = orange;
            }
            if (blue > green && blue > red && blue > orange)
            {
                maxEggsPerColour = "blue";
                maxEggs = blue;
            }
            if (red > blue && red > green && red > orange)
            {
                maxEggsPerColour = "red";
                maxEggs = red;
            }

            Console.WriteLine("Red eggs:{0}", red);
            Console.WriteLine("Orange eggs:{0}", orange);
            Console.WriteLine("Blue eggs:{0}", blue);
            Console.WriteLine("Green eggs:{0}", green);
            Console.WriteLine("Max eggs:{0} -> {1}", maxEggs, maxEggsPerColour);
        }
    }
}
