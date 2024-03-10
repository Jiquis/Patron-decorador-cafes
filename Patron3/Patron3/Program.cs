using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron3
{
    internal class Program
    {
        static void PrintTicket(List<Beverage> order)
        {
            double costoTotalSinIVA = 0;
            Console.WriteLine("TU ORDEN:");
            foreach (var beverage in order)
            {
                costoTotalSinIVA += beverage.Cost();
                Console.WriteLine(beverage.Description + " $" + beverage.Cost());
            }
            Console.WriteLine("SUB TOTAL: $" + costoTotalSinIVA);
            double iva = costoTotalSinIVA * 0.16;
            double costoTotalConIVA = costoTotalSinIVA + iva;
            Console.WriteLine("IVA: $" + iva);
            Console.WriteLine("TOTAL: $" + costoTotalConIVA);
            Console.WriteLine("\nGracias por su compra!");
            Console.WriteLine("\nPatrón decorador hecho por: Covarrubias Rosales Luis Humberto-20212393");
        }
        static void Main(string[] args)
        {
            List<Beverage> order = new List<Beverage>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("MENU:");
                Console.WriteLine("1. House Blend Coffee");
                Console.WriteLine("2. Dark Roast Coffee");
                Console.WriteLine("3. Espresso Coffee");
                Console.WriteLine("4. Agregar condimentos");
                Console.WriteLine("5. Completa tu orden e imprime tu ticket");

                Console.Write("Elige una bebida: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        order.Add(new HouseBlend());
                        Console.WriteLine("HouseBlend agregado a la cuenta");
                        break;
                    case "2":
                        order.Add(new DarkRoast());
                        Console.WriteLine("DarkRoast agregado a la cuenta");
                        break;
                    case "3":
                        order.Add(new Expresso());
                        Console.WriteLine("Expresso agregado a la cuenta");
                        break;
                    case "4":
                        if (order.Count == 0)
                        {
                            Console.WriteLine("Por favor agrega una bebida primero.");
                            break;
                        }
                        Console.WriteLine("CONDIMENTOS:");
                        Console.WriteLine("a. Mocha");
                        Console.WriteLine("b. Soy");
                        Console.WriteLine("c. Whip");
                        Console.Write("Elige un condimento: ");
                        string condimentChoice = Console.ReadLine();
                        switch (condimentChoice)
                        {
                            case "a":
                                order[order.Count - 1] = new Mocha(order[order.Count - 1]);
                                Console.WriteLine("Condimento Mocha agregado a la cuenta");
                                break;
                            case "b":
                                order[order.Count - 1] = new Soy(order[order.Count - 1]);
                                Console.WriteLine("Condimento Soy agregado a la cuenta");
                                break;
                            case "c":
                                order[order.Count - 1] = new Whip(order[order.Count - 1]);
                                Console.WriteLine("Condimento Whip agregado a la cuenta");
                                break;
                            default:
                                Console.WriteLine("condimento invalido.");
                                break;
                        }
                        break;
                    case "5":
                        PrintTicket(order);
                        return;
                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
