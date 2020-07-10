using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exercise Begins at the bottom!

            //string[] dogs = { "K 9", "Brian Griffin", "Scooby Doo" };

            //var dogSpaces = from dog in dogs
            //                where dog.Contains(" ")
            //                orderby dog ascending
            //                select dog;

            //foreach (var dog in dogSpaces)
            //{
            //    Console.WriteLine(dog);
            //}


            //List<int> numbers = new List<int>() { 1, 1, 1, 1, 1, 2, 3, 4, 5, 6 };

            //var noOnes = numbers.RemoveAll(x => x == 1);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] arr = new int[] { 1, 2, 3, 4, };

            //Console.WriteLine(arr[2]);

            //int[] arr1 = { 1, 2, 3, 4, 5 };

            //Console.WriteLine(arr1[3]);

            //int[] arr2 = new int[6];

            //arr2[0] = 1;
            //arr2[1] = 2;
            //arr2[2] = 3;
            //arr2[3] = 4;
            //arr2[4] = 5;
            //arr2[5] = 6;

            //foreach (var item in arr2)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.WriteLine(arr2[i]);
            //}

            // Exercise Begins Here!!

            string[] cars = { "Honda", "Acura", "Mustang", "Charger", "BMW" };

            var carSpaces = from car in cars
                            where car.Contains("a")
                            orderby car ascending
                            select car;

            foreach (var car in carSpaces)
            {
                Console.WriteLine(car);
            }

            List<string> videoGames = new List<string>() { "DOOM", "WoW", "Diablo", "Mortal Kombat", "Final Fantasy" };

            IEnumerable<string> moreVideoGames = videoGames.OrderByDescending(name => name.Length);

            foreach (var i in moreVideoGames)
            {
                Console.WriteLine(i);
            }




            

        }

    }
}
