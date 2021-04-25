using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailySharePrice.Models
{
    public class InMemoryStockDb : IInMemoryStockDb
    {
        public static List<DailyStockDetails> dailyStockDetails = new List<DailyStockDetails> {
            new DailyStockDetails { StockId = 1, StockName = "Bajaj Finance",StockValue=100},
            new DailyStockDetails { StockId = 2, StockName = "Asian Paints", StockValue = 200 },
            new DailyStockDetails { StockId = 3, StockName = "Adani Ports", StockValue = 300 },
            new DailyStockDetails { StockId = 4, StockName = "Bajaj Automobiles", StockValue = 400 },
            new DailyStockDetails { StockId = 5, StockName = "Havells India", StockValue = 500 }
            };

        public DailyStockDetails DailySharePrice(string stockName)
        {
            return dailyStockDetails.FirstOrDefault(c=>c.StockName.ToLower()==stockName.ToLower());
        }

        


    }
}
