using CarSales.Models;
using System;
using System.Collections.Generic;

namespace CarSales.DAL
{
    public class CarInitializer : System.Data.Entity.DropCreateDatabaseAlways<CarContext>
    {
        protected override void Seed(CarContext context)
        {
            var cars = new List<Car>
            {
                new Car () {
                    IsPrivate = true,
                    Make = "Porsche",
                    Model = "911",
                    Year = 2014,
                    PriceType = CarPriceType.DAP,
                    DapPrice = 349000,
                    ContactName = "ABC",
                    Email = "ABC@carsales.com.au",
                    Comments = "2014 911 Turbo PDK Coupe, Absolutely Stunning in White with Black Leather Interior. Factory Optioned with Adaptive Cruise Control, Seat Ventilation, Light Design Package, Park Assist with Reverse Camera, Sport Chrono Package PDK, Electric Glass Sunroof and Electric Folding Mirrors. Very low kms and immaculate condition Throughout. New Porsche Warranty till April 2017 and can be extended till 9 years of age. Buy with Confidence from Western Australias Only Authorised Porsche Dealer."
                },
                new Car () {
                    IsPrivate = false,
                    Make = "Porsche",
                    Model = "Cayman",
                    Year = 2011,
                    PriceType = CarPriceType.EGC,
                    EgcPrice = 69999,
                    Phone = "0412345678",
                    DealerABN = "2312312312",
                    Email = "dealer@carsales.com.au",
                    Comments = "ORIGINAL WHEELS ARE AVAILABLE! GER, BETTER, CHEAPER !!! ENQUIRE ONLINE TODAY to secure this 2011 PORSCHE CAYMAN at the SPECIAL INTERNET PRICE (DISCOUNTS HAVE ALREADY BEEN APPLIED)"
                },
                new Car () {
                    IsPrivate = false,
                    Make = "Porsche",
                    Model = "911",
                    Year = 1969 ,
                    PriceType = CarPriceType.POA,
                    Phone = "0412345678",
                    DealerABN = "2312312312",
                    Email = "dealer@carsales.com.au",
                    Comments = "Porsche 911T 1969 2.0L Australian delivered matching numbers 5 speed manual factory right hand drive finished in factory ivory white with red interior. "
                }
            };
            cars.ForEach(s => context.Cars.Add(s));
            context.SaveChanges();
        }
    }
}