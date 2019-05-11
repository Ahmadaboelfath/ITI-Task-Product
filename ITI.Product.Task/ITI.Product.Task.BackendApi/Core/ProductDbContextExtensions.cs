using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITI.Product.Task.BackendApi.Core
{
    public static class ProductDbContextExtensions
    {
        public static void EnsureSeedDataForContext(this ProductDbContext context)
        {
            //first clear the database
            context.Products.RemoveRange(context.Products);
            context.SaveChanges();

            //init seed data
            var products  = new List<Domain.Product>()
            {
                new Domain.Product()
                {
                    Id = new Guid("9A2170C7-79C6-4D9E-9A07-9BD5A238ECF2"),
                    ProductName = "Laptop",
                    CompanyName = "HP",
                    Price = 2500,
                    ImageUrl = "~/Images/laptop.png"
                },

                new Domain.Product()
                {
                    Id = new Guid("0C40D6D4-DD75-49D3-9DE0-E158EB4519CA"),
                    ProductName = "Mobile",
                    CompanyName = "LG",
                    Price = 3000,
                    ImageUrl = "~/Images/Mobile.png"
                },

                new Domain.Product()
                {
                    Id = new Guid("EFDF41FB-7021-4F12-A3AF-089A6FD9B168"),
                    ProductName = "LCD",
                    CompanyName = "Samsung",
                    Price = 5000,
                    ImageUrl = "~/Images/LCD.png"
                },

                new Domain.Product()
                {
                    Id = new Guid("039247E1-FB0E-48D3-B9B1-3B8E872F4903"),
                    ProductName = "LED",
                    CompanyName = "Sony",
                    Price = 7000,
                    ImageUrl = "~/Images/LEDTV.png"
                },

                new Domain.Product()
                {
                    Id = new Guid("B6D497D2-2C40-4B63-AF18-074F0E885080"),
                    ProductName = "PS4",
                    CompanyName = "Sony",
                    Price = 2500,
                    ImageUrl = "~/Images/PS4.png"
                },

                new Domain.Product()
                {
                    Id = new Guid("3886EE88-D69D-42DF-B1D9-C02BAD03FA0D"),
                    ProductName = "LEDLamp",
                    CompanyName = "Venus",
                    Price = 25.5,
                    ImageUrl = "~/Images/LEDLamp.png"
                },

                new Domain.Product()
                {
                    Id = new Guid("D58267E3-5505-40D4-B24A-0D60F8F44057"),
                    ProductName = "Pen",
                    CompanyName = "barker",
                    Price = 100,
                    ImageUrl = "~/Images/Pen.png"
                },

                new Domain.Product()
                {
                    Id = new Guid("A30CA4BC-9143-48EC-8EFC-9FE518255FEE"),
                    ProductName = "Blue T-Shirt ",
                    CompanyName = "Addidas",
                    Price = 125,
                    ImageUrl = "~/Images/BlueTshirt.png"
                },

                new Domain.Product()
                {
                    Id = new Guid("13A7A464-24DE-433A-978F-B14AE67D5E6D"),
                    ProductName = "Shirt",
                    CompanyName = "BTM",
                    Price = 200,
                    ImageUrl = "~/Images/Shirt.png"
                },

                new Domain.Product()
                {
                    Id = new Guid("13B193BE-0A0F-4A6A-86BC-343FA6A7BF05"),
                    ProductName = "Key Chain",
                    CompanyName = "XYZ",
                    Price = 50,
                    ImageUrl = "~/Images/KeyChain.png"
                },

                new Domain.Product()
                {
                    Id = new Guid("747502FD-BA91-472A-B10E-C3996F896CF2"),
                    ProductName = "Bottle",
                    CompanyName = "TupperWare",
                    Price = 100,
                    ImageUrl = "~/Images/bottle.png"
                },

                new Domain.Product()
                {
                    Id = new Guid("840AC259-5E6D-46EF-8F35-657927E196EB"),
                    ProductName = "Comb",
                    CompanyName = "ABC",
                    Price = 10,
                    ImageUrl = "~/Images/comb.png"
                },

                new Domain.Product()
                {
                    Id = new Guid("67088324-E231-48C1-BAC5-14279021B791"),
                    ProductName = "Thermal Cup",
                    CompanyName = "ESA limited",
                    Price = 150,
                    ImageUrl = "~/Images/thermalcup.png"
                },

                new Domain.Product()
                {
                    Id = new Guid("18172B8D-3E32-4DF8-B18E-B0C599A9AAFC"),
                    ProductName = "Air Freshner",
                    CompanyName = "Glade",
                    Price = 250,
                    ImageUrl = "~/Images/AirFreshner.png"
                },

                new Domain.Product()
                {
                    Id = new Guid("932F8FD5-1F6F-4081-9702-93225489FE5E"),
                    ProductName = "Wallet",
                    CompanyName = "Calvin Klein",
                    Price = 600,
                    ImageUrl = "~/Images/Wallet.png"
                },

                new Domain.Product()
                {
                    Id = new Guid("4A197E85-D459-4182-B026-6A95FAA3F36D"),
                    ProductName = "Socks",
                    CompanyName = "Cottonil",
                    Price = 30,
                    ImageUrl = "~/Images/Socks.png"
                },

                new Domain.Product()
                {
                    Id = new Guid("94109011-E054-4CA5-904D-4531FE277F8C"),
                    ProductName = "Shoes",
                    CompanyName = "Clark",
                    Price = 1200,
                    ImageUrl = "~/Images/Shoes.png"
                },

                new Domain.Product()
                {
                    Id = new Guid("52BAD898-BC6D-450C-A159-B7AAD38D62CC"),
                    ProductName = "Sports Shoes",
                    CompanyName = "Nike",
                    Price =1050,
                    ImageUrl = "~/Images/SportsShoes.png"
                },

                new Domain.Product()
                {
                    Id = new Guid("6E0DACAD-FA21-4B86-AE4A-1E1A4DFB2D47"),
                    ProductName = "Book",
                    CompanyName = "ttt",
                    Price = 2000,
                    ImageUrl = "~/Images/Book.png"
                },

                new Domain.Product()
                {
                    Id = new Guid("BA81AEB0-C9E6-43DE-90B5-ED400AA2D0BA"),
                    ProductName = "Headphones",
                    CompanyName = "Jabra",
                    Price = 550,
                    ImageUrl = "~/Images/Headphone.png"
                }
            };

            context.Products.AddRange(products);
            context.SaveChanges();
        }
        
    }
}
