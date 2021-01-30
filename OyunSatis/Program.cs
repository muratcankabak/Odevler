using System;

namespace OyunSatis
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer gamer = new Gamer
            {
                Id = 1,
                FirstName = "Ali",
                LastName = "Veli",
                NationalIdenity = "12345",
                YearOfBirth = 1993,
                Platform = "Play Station 5" 
            };
            Product game = new Game
            {
                Id = 8,
                ProductName = "Reklamsız Oyun",
                Category = "Oyun",
                Genre = "Ütopik",
                UnitsInStock = 50,
                UnitPrice = 300
            };
            SpecialOffer offer = new SpecialOffer()
            {
                OfferId = 1,
                OfferName = "Nakit İndirimi",
                Description = "Nakit alış verişte %15 indirim",
            };

            ICustomerService gamerService = new CustomerManager(gamer, new CustomerValidationManager());
            gamerService.Add(gamer);

            IOrderService<Product> orderGameService = new OrderGameManagerCash();
            orderGameService.Sell(game, gamer, offer);
        }
    }
}
