
namespace LaptopShop
{
    using System;
    public class StartUp
    {
       public static void Main(string[] args)
        {
            var laptopMake = "Asus";
            var laptopModel = "Hjk45";
            var laptopDiplaySize = 15.4;
            var laptopPrice = 333;
            var laptopRam = 8;
            var laptopSsd = 15;

            var laptop = new Laptop(laptopMake,laptopModel,laptopDiplaySize,laptopPrice,laptopRam, laptopSsd);

            //var laptopInfo = laptop.FullInfo();

            //Console.WriteLine(laptopInfo);

            var shop = new Shop();

            shop.AddLaptop(laptop);

            shop.PrintAllLaptops(x => Console.WriteLine(x.FullInfo()));

            
        }
    }
}
