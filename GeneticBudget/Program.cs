using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticBudget
{
    class Program
    {
        static List<Expense> expenses = new List<Expense>();
        
        /// <summary>
        /// Goal of this genetic algorithm is to is create a purchase plan that will enable users to better plan their future expenses.  
        /// The algorithm will take as input the price of various planned purchases, the level of urgency for each item to be purchased, and the total amount that can be allocated to 
        /// each month to these purchases.  May need to factor in possible due dates for each purchase (will likely tie in 
        /// with the level of urgency value).  The result that the algorithm should produce is the amount that the user will need to invest for each expense, each month,
        /// in order to afford all of the planned purchases provided as the input in accordance to the level of urgency associated with each expense.  
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            RunAlgorithm();
        }

        static void RunAlgorithm()
        {
            // Create some expenses
            Expense graphicsCard = new Expense("Graphics Card", "Computer", 10000, 2, new DateTime(2019, 6, 1));
            Expense engagementRing = new Expense("Engagement Ring", "Gift", 17500, 4, new DateTime(2019, 8, 1));
            Expense LGSmartphone = new Expense("LG G9", "Cellphone", 15000, 2, new DateTime(2020, 1, 1));
            Expense golfTrip = new Expense("Wedgewood Golf Game", "Golf", 400, 5, new DateTime(2018, 8, 25));
            Expense NikonD610 = new Expense("Nikon D610 Body", "Photography", 18000, 2, new DateTime(2019, 6, 1));

            // Add expenses to list
            expenses.Add(graphicsCard);
            expenses.Add(engagementRing);
            expenses.Add(LGSmartphone);
            expenses.Add(golfTrip);
            expenses.Add(NikonD610);

            // Initialise and run new genetics algorithm
            Stopwatch SW = new Stopwatch();

            SW.Start();
            GeneticCode GC = new GeneticCode(expenses);
            SW.Stop();

            // Display results


        }
    }
}
