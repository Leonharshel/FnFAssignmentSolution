using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSolutions
{
    public delegate void ChangePrice(object sender, PriceChangedEve events);

   
    public class PriceChangedEve : EventArgs
    {
        public int Nav { get; set; }

        public PriceChangedEve(int rate)
        {
            Nav = rate;
        }

    }

    //  source class
    public class MutualFunds
    {
        public event ChangePrice PriceChanged;

        private int rate;

        public MutualFunds(int initialPrice)
        {
            rate = initialPrice;
        }

        public int Price
        {
            get { return rate; }
            set
            {
                rate = value;
                OnPriceChanged(new PriceChangedEve(rate));
            }
        }

        protected virtual void OnPriceChanged(PriceChangedEve events)
        {
            PriceChanged.Invoke(this, events);
        }
    }

    // command class
    public class MarketInsights
    {
        private Random random = new Random();

        public void VaryPrice(MutualFunds stock)
        {
            int newPrice = random.Next(0, 1001);
            stock.Price = newPrice;
        }
    }

    //  observer class
    public class Dashboard
    {
        public void DisplayPriceStatus(object sender, PriceChangedEve events)
        {
            if (events.Nav < 40)
            {
                Console.ForegroundColor = ConsoleColor.Red;//console color changing
                Console.WriteLine("The rate  is: " + events.Nav + " Less than 40");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;//console color changing
                Console.WriteLine("The rate is: " + events.Nav + " Greater than or equal to 40");
            }
            Console.ResetColor();
        }
    }

    
  internal  class Stockmarket
    {
        static void Main(string[] args)
        {
            
            MutualFunds stock = new MutualFunds(40);
            MarketInsights marketinsights = new MarketInsights();
            Dashboard dashboard = new Dashboard();
            stock.PriceChanged += dashboard.DisplayPriceStatus;

            // Changing  the  price randomly 
            for (int i = 0; i < 100; i++)
            {
                marketinsights.VaryPrice(stock);
               
            }
        }
    }
}
