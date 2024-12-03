using System;

public delegate void StockPriceChangedHandler(string message);

public class Stock
{
    public event StockPriceChangedHandler OnStockPriceChanged;
    private decimal price;
    public decimal Price
    {
        get { return price; }
        set
        {
            price = value;
            if (price < Threshold)
            {
                RaiseStockPriceChangedEvent("Stock price is below threshold!");
            }
        }
    }
    private decimal _threshold;
    public decimal Threshold
    {
        get { return _threshold; }
        set
        {
            _threshold = value;
        }
    }
    protected virtual void RaiseStockPriceChangedEvent(string message)
    {
        OnStockPriceChanged?.Invoke(message);
    }
}
public class StockAlert
{
    public void OnStockPriceChanged(string message)
    {
        Console.WriteLine("Stock Alert: " + message);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Stock stock = new Stock();
        StockAlert stockalert = new StockAlert();

        stock.OnStockPriceChanged += stockalert.OnStockPriceChanged;

        stock.Threshold = 120m;

        stock.Price = 150m;
        stock.Price = 130m;
        stock.Price = 110m;

        Console.ReadKey();
    }
}