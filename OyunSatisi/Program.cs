using System;

namespace OyunSatisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                CustomerId = 1,
                NationalId = "123154846341",
                FirstName = "Ali",
                LastName = "Veli",
                DateOfBirth = new DateTime(1993, 06, 10)
            };
            SpecialOffer offer = new SpecialOffer 
            {
                OfferId = 1, 
                OfferName = "Hoşgeldin İndirimi", 
                Description = "Her üründe %15 indirim" 
            };
            Game game = new Game
            // Product game = new Game{...}; saleManager.Sell(game, customer, offer) => game parametresinin
            //product olması gerekli. Instance oluştururken sol tarafa product verdiğimde game in altını 
            //çiziyor. Ama Yukarıdaki gibi instance oluşturunca sıkıntı çıkmıyor, bir türlü anlayamadım.
            //Product ile Game'in referansını tutuyorum, propertylerine erişebiliyorum, ama saleManager'da 
            //parametre olarak gönderdiğimde sadece Game içinde tanımlanmış olan Genre propertysine erişe-
            //miyorum. Referansı IProduct ile tutmaya çalıştığımda da aynı hatayı aldım. Product can not
            //convert to Game diye bir hata veriyor.
            {
                Id = 1,
                Category = "oyun",
                ProductName = "Reklamsız Oyun",
                Genre = "Ütopik",
                UnitPrice = 500
            };
            
            Sale sale = new Sale
            {
                SaleId = 5,
                Category = "oyun",
                CustomerBought = customer,
                TotalPrice = 960,
                SaleDate = new DateTime(2021, 01, 26)
            };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);

            SpecialOffer offer2 = new SpecialOffer
            {
                OfferId = 6,
                OfferName = "5. Yıl Özel İndirim",
                Description = "Tüm ürünlerde %30 indirim"
            };
            SpecialOfferManager offerManager = new SpecialOfferManager();
            offerManager.Add(offer2);

            ISaleService<Game> saleManager = new GameSaleServiceCash();
            saleManager.Sell(game, customer, offer);
            ISaleService<Game> saleManager2 = new GameSaleServiceCard();
            saleManager2.Sell(game, customer, offer);

        }
    }
}
