using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillSplitter
{
    public class Calculation
    {
        decimal bill;
        int tip_percent;
        int persons;

        

        public decimal GetBill()
        {
            return bill;
        }
        
        public void SetBill(decimal num)
        {
            bill = num;
        }

        public decimal GetTipPercentage()
        {
            return tip_percent;
        }

        public void SetTipPercentage(int num)
        {
            tip_percent = num;
        }

        public decimal GetPersons()
        {
            return persons;
        }

        public void SetPersons(int num)
        {
            persons = num;
        }

        public decimal CalculateTip()
        {
            decimal tip = decimal.Round(bill * tip_percent / 100 / persons, 2);
            return tip;
        }

        public decimal CalculateShare()
        {
            decimal share = decimal.Round(bill / persons, 2);
            return share;            
        }

        public decimal CalculateTotal()
        {
            decimal total = decimal.Round(CalculateShare() + CalculateTip(), 2);
            return total;
        }
    }
}
