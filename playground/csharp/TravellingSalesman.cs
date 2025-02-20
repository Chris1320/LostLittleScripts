using System;
using System.Collections.Generic;

namespace TravellingSalesman
{
    class Program
    {
        static char[] city_names = {
            'A', 'B', 'C', 'D', 'E',
            'F', 'G', 'H', 'I', 'J',
            'K', 'L', 'M', 'N', 'O',
            'P', 'Q', 'R', 'S', 'T',
            'U', 'V', 'W', 'X', 'Y', 'Z'
        };

        static int[,] AskDistances(int cities)
        {
            int[,] distances = new int[cities, cities];  // Create a n*n matrix of distances

            for (int i = 0; i < cities; i++)
            {
                Console.WriteLine($"Enter distances from city {city_names[i]}:");
                for (int j = 0; j < cities; j++)
                {
                    if (i == j)
                        distances[i, j] = -1;  // -1 means it's the same city

                    else
                    {
                        while (true)
                        {
                            try
                            {
                                Console.Write($"Enter distance to city {city_names[j]}: ");
                                distances[i, j] = int.Parse(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid distance. Please enter a number.");
                                continue;
                            }

                            break;
                        }
                    }
                }
            }

            return distances;
        }

        static void PrintDistanceMatrix(int[] cities, int[,] distances)
        {
            Console.Write("  ");
            for (int i = 0; i < cities.Length; i++)
                Console.Write(city_names[i] + " ");

            Console.WriteLine();
            for (int i = 0; i < cities.Length; i++)
            {
                Console.Write(city_names[i] + " ");
                for (int j = 0; j < cities.Length; j++)
                    if (distances[i, j] == -1)
                        Console.Write("- ");
                    else
                        Console.Write(distances[i, j] + " ");

                Console.WriteLine();
            }
        }

        static int Main(string[] args)
        {
            Console.WriteLine("Travelling Salesman");

            // Ask user for number of cities, and create a matrix of distances
            Console.Write("Enter number of cities: ");
            int cities_q = int.Parse(Console.ReadLine());

            if (cities_q < 3 || cities_q > city_names.Length)
            {
                Console.WriteLine($"Invalid number of cities. Should be 3 to {city_names.Length}.");
                return 1;
            }

            int[,] distances = AskDistances(cities_q);

            // Create an array of cities
            int[] cities = new int[cities_q];
            for (int i = 0; i < cities.Length; i++)
                cities[i] = i;

            // Print distance matrix
            PrintDistanceMatrix(cities, distances);

            // Generate all possible permutations
            List<int[]> permutations = new List<int[]>();
            void GeneratePermutations(int[] cities, int n)
            {
                if (n == 1)
                {
                    int[] copy = new int[cities.Length + 1];
                    Array.Copy(cities, copy, cities.Length);
                    copy[cities.Length] = cities[0];
                    permutations.Add(copy);
                }
                else
                {
                    for (int i = 0; i < n - 1; i++)
                    {
                        GeneratePermutations(cities, n - 1);
                        if (n % 2 == 0)
                        {
                            int temp = cities[i];
                            cities[i] = cities[n - 1];
                            cities[n - 1] = temp;
                        }
                        else
                        {
                            int temp = cities[0];
                            cities[0] = cities[n - 1];
                            cities[n - 1] = temp;
                        }
                    }
                    GeneratePermutations(cities, n - 1);
                }
            }

            GeneratePermutations(cities, cities.Length);

            Console.WriteLine($"Total permutations: {permutations.Count}");

            // Calculate total distance for each permutation
            int min_distance = int.MaxValue;
            int[] min_path = new int[cities.Length];
            foreach (int[] permutation in permutations)
            {
                int distance = 0;
                for (int i = 0; i < permutation.Length - 1; i++)
                {
                    if (distances[permutation[i], permutation[i + 1]] == -1)
                    {
                        distance = int.MaxValue;
                        break;
                    }

                    distance += distances[permutation[i], permutation[i + 1]];
                }

                if (distance < min_distance)
                {
                    min_distance = distance;
                    min_path = permutation;
                }
            }

            // List all possible paths and their distances
            Console.WriteLine("All possible paths:");
            foreach (int[] permutation in permutations)
            {
                Console.Write(city_names[permutation[0]] + " ");
                int distance = 0;
                for (int i = 0; i < permutation.Length - 1; i++)
                {
                    if (distances[permutation[i], permutation[i + 1]] == -1)
                    {
                        distance = int.MaxValue;
                        break;
                    }

                    Console.Write(city_names[permutation[i + 1]] + " ");
                    distance += distances[permutation[i], permutation[i + 1]];
                }

                if (distance != int.MaxValue)
                    Console.WriteLine($"(Total distance: {distance})");
            }

            // Print the shortest path
            Console.Write("Shortest path: ");
            foreach (int city in min_path)
                Console.Write(city_names[city] + " ");

            Console.WriteLine($"(Total distance: {min_distance})");

            return 0;
        }
    }
}
