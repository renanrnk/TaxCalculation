using ExercioFix.Entities;
using System;
using System.Globalization;

namespace ExercicioFix
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i') 
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PrivateIndividual(name, annualIncome, health));
                }
                else 
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new LegalPerson(name, annualIncome, employees));
                }
            }
            
            double sum = 0.0;
            
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach (Person person in list) 
            {
                Console.WriteLine(person.Name + ": $ " + person.Tax().ToString("F2", CultureInfo.InvariantCulture));
                sum += person.Tax();
            }
            
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}