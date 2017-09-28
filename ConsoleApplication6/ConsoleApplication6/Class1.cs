using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication6
{
    class Result
    {
        public static void Main(string[] args)
        {
            var cars = ProcessCars("fuel.csv");
            var manufacturers = ProcessManufacturers("manufacturers.csv");
            //projection method
            var query1 =
                from car in cars
                where car.Manufacturer == "BMW" && car.Year == 2016
                orderby car.Combined descending, car.Name ascending
                select new
                {
                    car.Manufacturer,
                    car.Name,
                    car.Combined
                };
            foreach (var c in query1.Take(10))
            {
                Console.WriteLine($"{c.Manufacturer}{c.Name}:{c.Combined}");
            }
            //join method
            var query = cars.Join(manufacturers,
                                    c => c.Manufacturer,
                                    m => m.Name, (c, m) => new
                                    {
                                        m.Headquarters,
                                        m.Name,
                                        c.Combined

                                    })
                                .OrderByDescending(c => c.Combined)
                                .ThenBy(c => c.Name);

            foreach (var car in query.Take(10))
            {
                Console.WriteLine($"{car.Headquarters} {car.Name} : {car.Combined}");
                Console.ReadKey();


            }
            
            //group method
            var q3 = from car in cars
                     group car by car.Manufacturer;
                   foreach(var result in q3)
            {
                Console.WriteLine($"{result.Key} has {result.Count()} cars");
                Console.ReadLine();
            }

        }

        private static List<Car> ProcessCars(string path)
        {

            var query =

               File.ReadAllLines(@"c:\users\neha deori\documents\visual studio 2015\Projects\ConsoleApplication6\ConsoleApplication6\fuel.csv")


                   .Skip(1)
                   .Where(l => l.Length > 1)
                   .Select(l =>
                   {
                       var columns = l.Split(',');
                       return new Car
                       {
                           Year = int.Parse(columns[0]),
                           Manufacturer = columns[1],
                           Name = columns[2],
                           Displacement = double.Parse(columns[3]),
                           Cylinders = int.Parse(columns[4]),
                           City = int.Parse(columns[5]),
                           Highway = int.Parse(columns[6]),
                           Combined = int.Parse(columns[7])
                       };
                   });


            return query.ToList();

        }
        private static List<Manufacturer> ProcessManufacturers(string path)
        {
            var query =
                     File.ReadAllLines(@"c:\users\neha deori\documents\visual studio 2015\Projects\ConsoleApplication6\ConsoleApplication6\manufacturers.csv")
                    .Where(l => l.Length > 1)
                    .Select(l =>
                    {
                        var columns = l.Split(',');
                        return new Manufacturer
                        {
                            Name = columns[0],
                            Headquarters = columns[1],

                        };
                    });
            return query.ToList();
        }
    }

   

    

    public class Car
    {

        public int Year { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Displacement { get; set; }
        public int Cylinders { get; set; }
        public int City { get; set; }
        public int Highway { get; set; }
        public int Combined { get; set; }

    }
    public class Manufacturer
    {
        public string Name;
        public string Headquarters;

    }
}

