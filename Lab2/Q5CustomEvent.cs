using System;

namespace Lab2
{
    // Custom EventArgs to pass stock data
    public class StockPriceChangedEventArgs : EventArgs
    {
        public string Symbol { get; }
        public double OldPrice { get; }
        public double NewPrice { get; }
        public double ChangePercent => Math.Round((NewPrice - OldPrice) / OldPrice * 100, 2);

        public StockPriceChangedEventArgs(string symbol, double oldPrice, double newPrice)
        {
            Symbol = symbol;
            OldPrice = oldPrice;
            NewPrice = newPrice;
        }
    }

    class Stock
    {
        // Custom event using EventHandler<T> with custom EventArgs
        public event EventHandler<StockPriceChangedEventArgs> PriceChanged;

        private double _price;
        public string Symbol { get; }

        public Stock(string symbol, double initialPrice)
        {
            Symbol = symbol;
            _price = initialPrice;
        }

        public double Price
        {
            get => _price;
            set
            {
                if (_price != value)
                {
                    double oldPrice = _price;
                    _price = value;
                    // Raise custom event with custom data
                    PriceChanged?.Invoke(this, new StockPriceChangedEventArgs(Symbol, oldPrice, _price));
                }
            }
        }

        public void SimulatePriceChange()
        {
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                double change = (rand.NextDouble() * 10) - 5; // -5 to +5
                Price = Math.Round(_price + change, 2);
                System.Threading.Thread.Sleep(500);
            }
        }
    }

    class Trader
    {
        public string Name { get; }

        public Trader(string name)
        {
            Name = name;
        }

        public void OnPriceChanged(object sender, StockPriceChangedEventArgs e)
        {
            string action = e.ChangePercent > 0 ? "BUY" : "SELL";
            Console.WriteLine($"  [Trader {Name}] {action} {e.Symbol} | " +
                $"${e.OldPrice} -> ${e.NewPrice} ({e.ChangePercent}%)");
        }
    }

    class MarketAnalyst
    {
        public void OnPriceChanged(object sender, StockPriceChangedEventArgs e)
        {
            string trend = e.ChangePercent switch
            {
                > 5 => "SURGING!",
                > 0 => "increasing",
                0 => "stable",
                < -5 => "PLUMMETING!",
                _ => "decreasing"
            };
            Console.WriteLine($"  [Analyst] {e.Symbol} is {trend} | Change: {e.ChangePercent}%");
        }
    }

    internal class CustomEventDemo
    {
        /*
        static void Main(string[] args)
        {
           

            // Create stock
            Stock apple = new Stock("AAPL", 150.00);

            // Create subscribers
            Trader trader1 = new Trader("Alice");
            Trader trader2 = new Trader("Bob");
            MarketAnalyst analyst = new MarketAnalyst();

            // Subscribe to custom event
            apple.PriceChanged += trader1.OnPriceChanged;
            apple.PriceChanged += trader2.OnPriceChanged;
            apple.PriceChanged += analyst.OnPriceChanged;

            Console.WriteLine($"Starting price of {apple.Symbol}: ${apple.Price}\n");
            Console.WriteLine("Simulating market activity...\n");

            apple.SimulatePriceChange();

            Console.WriteLine($"\nFinal price of {apple.Symbol}: ${apple.Price}");
        }
        */
    }
}
