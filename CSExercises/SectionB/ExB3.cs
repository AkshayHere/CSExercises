using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //The ABC Company pays its employees salary plus benefits.  
    //The benefits are calculated as a percentage of the salary.  
    //The company pays every employee 10% housing allowance and 
    //3% transport allowance.  Write a program that takes the salary 
    //as input and prints the total income 
    //(salary + housing allowance + transport allowance) as output.  
    //Format the output in currency format.

    public class ExB3
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.WriteLine("Enter your salary");
            string enteredSalary = Console.ReadLine();
            string totalCalculated = CalculateIncome(enteredSalary);
            Console.WriteLine("Total salary: "+totalCalculated);
        }

        public static string CalculateIncome(string salaryStr)
        {
            //YOUR CODE HERE
            double salary = Convert.ToDouble(salaryStr);
            double houseAllwnce = 3 * (salary) / 100;
            double travelAllwnce = 10 * (salary) / 100;
            double totalSalary = salary + houseAllwnce + travelAllwnce;
            string total = string.Format("{0:0.00}",totalSalary);
            return total;
        }
    }
}
