using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Querying
    {
        public static void Notes()
        {
            #region NumbersGreaterThanTen
            List<int> numbers = new List<int> { 2, 4, 8, 16, 32, 64 };

            List<int> numbersGreaterThanTen = new List<int>();

            foreach (int number in numbers)
            {
                if (number > 10)
                {
                    numbersGreaterThanTen.Add(number);
                }
            }

            numbersGreaterThanTen.ForEach(Console.WriteLine);

            var hat = (from number in numbers where number > 10 select number);

            hat.ToList().ForEach(Console.WriteLine);

            IEnumerable<int> numbersGreaterThanTen2 = from n in numbers where n > 10 select n;
            Console.WriteLine(numbersGreaterThanTen2.Count());
            #endregion
        }

        public static void BirdNotes()
        {
            List<Bird> birds = new List<Bird>
            {
                new Bird { Name = "Cardinal", Color = "Red", Sightings = 3 },
                new Bird { Name = "Dove", Color = "White", Sightings = 2 }
            };

            birds.Add(new Bird { Name = "Cardinal", Color = "Red", Sightings = 5 });

            var canary = new Bird { Name = "Canary", Color = "Yellow", Sightings = 0 };

            var print = (from b in birds where b.Color == "Red" select b);

            foreach( Bird b in print)
            {
                Console.WriteLine(b.Name);
            }
        }
    }

    public class Bird
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Sightings { get; set; }
    }
}