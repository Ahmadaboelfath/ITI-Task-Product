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
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/iti-task-e7004.appspot.com/o/Images%2Flaptop.png?alt=media&token=99e9584a-a146-4e8e-ba32-3aaab9cdfa7f"
                },

                new Domain.Product()
                {
                    Id = new Guid("0C40D6D4-DD75-49D3-9DE0-E158EB4519CA"),
                    ProductName = "Mobile",
                    CompanyName = "LG",
                    Price = 3000,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/iti-task-e7004.appspot.com/o/Images%2FMobile.png?alt=media&token=d8f5a398-89f3-4c1b-bab7-61ab190c7e72"
                },

                new Domain.Product()
                {
                    Id = new Guid("EFDF41FB-7021-4F12-A3AF-089A6FD9B168"),
                    ProductName = "LCD",
                    CompanyName = "Samsung",
                    Price = 5000,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/iti-task-e7004.appspot.com/o/Images%2FLCD.png?alt=media&token=7bc33933-d09d-4b7f-9167-0020d7f1b583"
                },

                new Domain.Product()
                {
                    Id = new Guid("039247E1-FB0E-48D3-B9B1-3B8E872F4903"),
                    ProductName = "LED",
                    CompanyName = "Sony",
                    Price = 7000,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/iti-task-e7004.appspot.com/o/Images%2FLEDTV.png?alt=media&token=d1347b16-0e80-408e-87e8-db05815e417b"
                },

                new Domain.Product()
                {
                    Id = new Guid("B6D497D2-2C40-4B63-AF18-074F0E885080"),
                    ProductName = "PS4",
                    CompanyName = "Sony",
                    Price = 2500,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/iti-task-e7004.appspot.com/o/Images%2FLEDTV.png?alt=media&token=d1347b16-0e80-408e-87e8-db05815e417b"
                },

                new Domain.Product()
                {
                    Id = new Guid("3886EE88-D69D-42DF-B1D9-C02BAD03FA0D"),
                    ProductName = "LEDLamp",
                    CompanyName = "Venus",
                    Price = 25.5,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/iti-task-e7004.appspot.com/o/Images%2FLEDLamp.png?alt=media&token=2dff1a3d-670c-4e9b-94a1-2f9c43aa4292"
                },

                new Domain.Product()
                {
                    Id = new Guid("D58267E3-5505-40D4-B24A-0D60F8F44057"),
                    ProductName = "Pen",
                    CompanyName = "barker",
                    Price = 100,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/iti-task-e7004.appspot.com/o/Images%2FPen.png?alt=media&token=c51d9e21-1263-4009-9e43-1df5ce73b3e0"
                },

                new Domain.Product()
                {
                    Id = new Guid("A30CA4BC-9143-48EC-8EFC-9FE518255FEE"),
                    ProductName = "Blue T-Shirt ",
                    CompanyName = "Addidas",
                    Price = 125,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/iti-task-e7004.appspot.com/o/Images%2FBlueTshirt.png?alt=media&token=f70af11f-781b-484a-90b8-7c93616f46f1"
                },

                new Domain.Product()
                {
                    Id = new Guid("13A7A464-24DE-433A-978F-B14AE67D5E6D"),
                    ProductName = "Shirt",
                    CompanyName = "BTM",
                    Price = 200,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/iti-task-e7004.appspot.com/o/Images%2FShirt.png?alt=media&token=37e6e017-5280-4dad-bb23-c5c381b9327e"
                },

                new Domain.Product()
                {
                    Id = new Guid("13B193BE-0A0F-4A6A-86BC-343FA6A7BF05"),
                    ProductName = "Key Chain",
                    CompanyName = "XYZ",
                    Price = 50,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/iti-task-e7004.appspot.com/o/Images%2FKeyChain.png?alt=media&token=665cb5f1-093e-4efc-a3fa-31139acd53db"
                },

                new Domain.Product()
                {
                    Id = new Guid("747502FD-BA91-472A-B10E-C3996F896CF2"),
                    ProductName = "Bottle",
                    CompanyName = "TupperWare",
                    Price = 100,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/iti-task-e7004.appspot.com/o/Images%2Fbottle.png?alt=media&token=bd4daa25-4ac6-4343-80c8-3ff68f4d4752"
                },

                new Domain.Product()
                {
                    Id = new Guid("840AC259-5E6D-46EF-8F35-657927E196EB"),
                    ProductName = "Comb",
                    CompanyName = "ABC",
                    Price = 10,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/iti-task-e7004.appspot.com/o/Images%2Fcomb.png?alt=media&token=5eeff068-2467-49b7-9898-7ede52f2ae23"
                },

                new Domain.Product()
                {
                    Id = new Guid("67088324-E231-48C1-BAC5-14279021B791"),
                    ProductName = "Thermal Cup",
                    CompanyName = "ESA limited",
                    Price = 150,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/iti-task-e7004.appspot.com/o/Images%2Fthermalcup.png?alt=media&token=5333fd06-efba-402d-9e52-548840c41ca9"
                },

                new Domain.Product()
                {
                    Id = new Guid("18172B8D-3E32-4DF8-B18E-B0C599A9AAFC"),
                    ProductName = "Air Freshner",
                    CompanyName = "Glade",
                    Price = 250,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/iti-task-e7004.appspot.com/o/Images%2FAirFreshner.png?alt=media&token=beceec4d-d3ca-45e5-a9ae-a7a793e6a061"
                },

                new Domain.Product()
                {
                    Id = new Guid("932F8FD5-1F6F-4081-9702-93225489FE5E"),
                    ProductName = "Wallet",
                    CompanyName = "Calvin Klein",
                    Price = 600,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/iti-task-e7004.appspot.com/o/Images%2FWallet.png?alt=media&token=b49c9121-60b7-4b19-a95f-3ce52c635b9b"
                },

                new Domain.Product()
                {
                    Id = new Guid("4A197E85-D459-4182-B026-6A95FAA3F36D"),
                    ProductName = "Socks",
                    CompanyName = "Cottonil",
                    Price = 30,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/iti-task-e7004.appspot.com/o/Images%2FSocks.png?alt=media&token=47077a41-12ad-4c13-9c46-cdfaf7f32b7d"
                },

                new Domain.Product()
                {
                    Id = new Guid("94109011-E054-4CA5-904D-4531FE277F8C"),
                    ProductName = "Shoes",
                    CompanyName = "Clark",
                    Price = 1200,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/iti-task-e7004.appspot.com/o/Images%2FShoes.png?alt=media&token=9788e485-c353-4735-8e00-b381aa2d3448"
                },

                new Domain.Product()
                {
                    Id = new Guid("52BAD898-BC6D-450C-A159-B7AAD38D62CC"),
                    ProductName = "Sports Shoes",
                    CompanyName = "Nike",
                    Price =1050,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/iti-task-e7004.appspot.com/o/Images%2FSportsShoes.png?alt=media&token=69e09c61-b74e-4a3d-8ef8-aef391034739"
                },

                new Domain.Product()
                {
                    Id = new Guid("6E0DACAD-FA21-4B86-AE4A-1E1A4DFB2D47"),
                    ProductName = "Book",
                    CompanyName = "ttt",
                    Price = 2000,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/iti-task-e7004.appspot.com/o/Images%2FBook.png?alt=media&token=20d675da-1656-4bf3-b657-949f7904399d"
                },

                new Domain.Product()
                {
                    Id = new Guid("BA81AEB0-C9E6-43DE-90B5-ED400AA2D0BA"),
                    ProductName = "Headphones",
                    CompanyName = "Jabra",
                    Price = 550,
                    ImageUrl = "https://firebasestorage.googleapis.com/v0/b/iti-task-e7004.appspot.com/o/Images%2FHeadphone.png?alt=media&token=86713a0a-47ed-4d3d-8687-2b7a331e678f"
                }
            };

            context.Products.AddRange(products);
            context.SaveChanges();
        }
        
    }
}
