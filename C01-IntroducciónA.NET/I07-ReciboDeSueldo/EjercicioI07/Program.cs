using System;
using System.Linq;
using System.Globalization;

namespace EjercicioI07
{
    internal class Program
    {
        const int salaryPerAge = 130;
        const decimal wageDeductions = 0.13M;
        static void Main()
        {
            string employeeName = "";
            decimal hourlyRate = 0.0M;
            byte laborSeniority = 0;
            short hoursWorked = 0;
            bool continueLoadingData = true;
            bool validData = true;
            byte count = 0;
            byte option = 0;

            while (continueLoadingData)
            {
                validData = false;
                while (!validData)
                {
                    Console.WriteLine("Enter employee´s name: ");
                    employeeName = Console.ReadLine();
                    if (employeeName.Any(char.IsLetter) || employeeName.Any(char.IsWhiteSpace))
                    {
                        employeeName.ToLower();
                        validData = true;
                    }
                    else
                    {
                        Console.WriteLine("ERROR. The data entered is invalid for the field.");
                    }
                }

                validData = false;
                while (!validData)
                {
                    Console.WriteLine("Enter employee´s hourly rate salary: ");
                    if (decimal.TryParse(Console.ReadLine(), out hourlyRate))
                    {
                        validData = true;
                    }
                    else
                    {
                        Console.WriteLine("ERROR. The data entered is invalid for the field.");
                    }
                }

                validData = false;
                while (!validData)
                {
                    Console.WriteLine("Enter employee´s labor seniority: ");
                    if (byte.TryParse(Console.ReadLine(), out laborSeniority))
                    {
                        validData = true;
                    }
                    else
                    {
                        Console.WriteLine("ERROR. The data entered is invalid for the field.");
                    }
                }

                validData = false;
                while (!validData)
                {
                    Console.WriteLine("Enter hours worked by the employee: ");
                    if (short.TryParse(Console.ReadLine(), out hoursWorked))
                    {
                        validData = true;
                    }
                    else
                    {
                        Console.WriteLine("ERROR. The data entered is invalid for the field.");
                    }
                }
                //TODO 4_ Mostrar el recibo del empleado con totales a cobrar (bruto y neto)
                count ++;

                decimal grossSalary = (hourlyRate) * hoursWorked;
                decimal wageSalary = grossSalary + (laborSeniority * salaryPerAge);
                decimal netSalary = wageSalary - (wageSalary * wageDeductions);

                employeeName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(employeeName);

                Console.Clear();
                Console.Write($"********** SALARY RECEIPT #{count:0000 0000} **********\n" +
                              $"Beneficiary: {employeeName}\n" +
                              $"Seniority: {laborSeniority} year/s. - Hourly Rate: {hourlyRate:C2}.-\n" +
                              $"Gross salary: {grossSalary:C2}.-\n" +
                              $"Net salary: {netSalary:C2}.-\n\n");

                
                validData = false;
                while (!validData)
                {
                    Console.WriteLine("Would you like to entry more employees?\n\t\t1_ Yes - 2_No");
                    if (byte.TryParse(Console.ReadLine(), out option) && option == 1 || option == 2)
                    {
                        if (option == 1)
                        {
                            continueLoadingData = true;
                            validData = true;
                            Console.Clear();
                        }
                        else if (option == 2)
                        {
                            continueLoadingData = false;
                            validData = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("ERROR. Invalid option.");
                    }
                }
            }
        }
    }
}
