namespace LaptopShop
{
   public class Laptop
    {
        public Laptop(
            string make,
            string model,
            double displaySize,
            decimal price,
            int ram,
            int? ssd = null)
        {
            Make = make;
            Model = model;
            DisplaySize = displaySize;
            Price = price;
            Ram = ram;
            Ssd = ssd;
        }
        public string Make { get; private set; }
        public string Model { get; private set; }
        public double DisplaySize { get; private set; }
        public decimal Price { get; private set; }
        public int Ram { get; private set; }
        public int? Ssd { get; private set ; }
        public string FullInfo()
        {
            return $@"Make: {this.Make}
Model: {this.Model}
DisplaySize: {this.DisplaySize}
Price: {this.Price:f2}
Ram: {this.Ram}
Ssd: {this.Ssd}";
        }
    }
}
