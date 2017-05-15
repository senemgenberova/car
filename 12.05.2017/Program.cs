using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars;

namespace _12._05._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            int response = 0;
            string cavab = "";
            double fuel_litr, distance;

            Console.Write("Enter fuel Capacity: ");
            int fuel_capacity = int.Parse(Console.ReadLine());
            
            Console.Write("Enter Distance: ");
            distance = double.Parse(Console.ReadLine());

            Console.Write("Enter fuel usage: ");
            double fuel_usage = double.Parse(Console.ReadLine());

            Console.Write("Enter current fuel : ");
            double current_fuel = double.Parse(Console.ReadLine());

            Car car = new Car(fuel_capacity,fuel_usage,0,current_fuel);

            do
            {
                Console.WriteLine();
                Console.WriteLine("1. Masini sur");
                Console.WriteLine("2. Benzin doldur");
                Console.WriteLine("3. Local Distance");
                Console.WriteLine("4. Global Distance");
                Console.WriteLine("0. Exit");
                Console.WriteLine();

                response = int.Parse(Console.ReadLine());
                switch (response)
                {
                    case 0:
                        Console.WriteLine("Bye");
                        break;

                    case 1:
                        Console.Write("Enter distance you will drive: ");
                        distance = double.Parse(Console.ReadLine());
                        if (car.checkDistance(distance))
                        {
                            Console.WriteLine("Available");
                        }
                        else
                        {
                            Console.WriteLine("Unavailable");
                        }
                        break;

                    case 2:
                        Console.Write("Add fuel litr: ");
                        fuel_litr = double.Parse(Console.ReadLine());
                        if (car.checkFuelAviable(fuel_litr))
                        {
                            Console.WriteLine("Current fuel capacity: " + car.addFuel(fuel_litr).ToString());
                        }
                        else
                        {
                            Console.WriteLine("Capacity exceeded");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Setting local distance to zero?");
                        Console.WriteLine("yes? ----- no?");
                        cavab = Console.ReadLine();

                        if(cavab == "yes")
                        {
                            if (car.LocalDistance == 0)
                            {
                                Console.WriteLine("Already setted to 0");
                            }
                            else
                            {
                                car.LocalDistance = 0;
                                Console.WriteLine("Local distance: " + car.LocalDistance.ToString());
                            }                            
                        }
                        else if(cavab == "no")
                        {
                            car.ascLocalDistance(distance);
                            Console.WriteLine("Local distance: " + car.LocalDistance.ToString());
                        }
                        break;

                    case 4:
                        car.ascGlobalDistance(distance);
                        Console.WriteLine("Global distance: " + car.GlobalDistance.ToString());
                        break;

                    default:
                        Console.WriteLine("Please enter correct number");
                        break;
                }


            } while (response != 0);
            

            Console.ReadKey();
        }
    }
}
