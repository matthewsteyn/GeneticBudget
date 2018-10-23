using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticBudget
{
    class Expense
    {
        private string expenseName;
        private string expenseCategory;
        private double costPrice;
        private int levelUrgency;
        private DateTime paidBy;

        public Expense(string expenseName, string expenseCategory, double costPrice, int levelUrgency, DateTime paidBy)
        {
            this.expenseName = expenseName;
            this.expenseCategory = expenseCategory;
            this.costPrice = costPrice;
            this.levelUrgency = levelUrgency;
            this.paidBy = paidBy;
        }

        public String GetExpenseName()
        {
            return expenseName;
        }

        public void SetExpenseName(String expenseName)
        {
            this.expenseName = expenseName;
        }

        public String GetExpenseCategory()
        {
            return expenseCategory;
        }

        public void SetExpenseCategory(String expenseCategory)
        {
            this.expenseCategory = expenseCategory;
        }

        public double GetCostPrice()
        {
            return costPrice;
        }

        public void SetCostPrice(double costPrice)
        {
            this.costPrice = costPrice;
        }

        public int GetLevelUrgency()
        {
            return levelUrgency;
        }

        public void SetLevelUrgency(int levelUrgency)
        {
            this.levelUrgency = levelUrgency;
        }

        public DateTime GetPaidBy()
        {
            return paidBy;
        }

        public void SetPaidBy(DateTime paidBy)
        {
            this.paidBy = paidBy;
        }
    }
}
