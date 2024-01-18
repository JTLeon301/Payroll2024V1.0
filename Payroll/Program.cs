using System.Transactions;
using static System.Console;
namespace Payroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //output header
            WriteLine("**********************");
            WriteLine("    Payroll V1.0");
            WriteLine("**********************");

            //enter employee's name
            Write("\nEnter employee's name: ");
            string name = ReadLine();

            //enter employee's hours worked
            Write("Enter your hours worked: ");
            double hoursWorked;
            string entry;
            entry = ReadLine();
            try {
                hoursWorked = double.Parse(entry);
                }
            catch (FormatException){
                WriteLine("You need to enter a number.\nSetting it to 0.");
                hoursWorked = 0;
            }

            //enter employee's hourly rate
            Write("Enter your hourly rate: ");
            entry = ReadLine();
            double payRate;
            try
            {
                payRate = Convert.ToDouble(entry);
            }
            catch (FormatException)
            {
                WriteLine("You need to enter a number.\nSetting it to 0.");
                payRate = 0;
            }

            //final calculations
            double grossPay = hoursWorked * payRate;
            const double TAXRATE = 0.1;
            double taxes = TAXRATE * grossPay;
            double netPay = grossPay - taxes;

            //print output
            WriteLine($"{"\nEmployee name:",-25}{name,20}");
            WriteLine($"{"Gross pay:",-25}{grossPay,20:C}");
            WriteLine($"{"Taxes:",-25}{taxes,20:C}");
            WriteLine($"{"Net pay:",-25}{netPay,20:C}");

            WriteLine("\nThank you for using this program");

        }
    }
}
