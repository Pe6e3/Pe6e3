using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Choose height of triangles (better will from 80 to 200. Make full-screen if more 110)");
            int height = int.Parse(Console.ReadLine());


            for (int repeats = 0; repeats < 5; repeats++) // count of repeating traingles
            {

                // First triangle: ( L )
                for (int rows = 0; rows <= height; rows++)
                {
                    for (int columns = 0; columns < rows; columns++) Console.Write("#");
                    Console.WriteLine();
                }

                // Second triangle: ( Г )
                for (int rows = height; rows >= 0; rows--)
                {
                    for (int columns = 0; columns < rows; columns++) Console.Write("#");
                    Console.WriteLine();
                }

                // Third triangle: ( J )
                for (int rows = height; rows >= 0; rows--)
                {
                    for (int columns_space = 0; columns_space < rows; columns_space++)
                    {
                        Console.Write(" ");
                        count++;
                    }
                    for (int columns = count; columns < height; columns++) Console.Write("#");
                    count = 0;
                    Console.WriteLine();
                }


                // Fourth triangle: ( 7 )
                for (int rows = 0; rows <= height; rows++)
                {
                    for (int colums_space = 0; colums_space < rows; colums_space++)
                    {
                        Console.Write(" ");
                        count++;
                    }
                    for (int columns = count; columns < height; columns++) Console.Write("#");
                    count = 0;
                    Console.WriteLine();
                }
            }
        }
    }
}
