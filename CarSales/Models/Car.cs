using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSales.Models
{
	public class Car
	{
		public Car ()
		{
			PriceType = CarPriceType.POA;
			IsPrivate = true;
		}

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarID { get; set; }

        public bool IsPrivate { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public CarPriceType PriceType { get; set; }
		public double EgcPrice { get; set; }
		public double DapPrice { get; set; }
		public string Email { get; set; }
		public string ContactName { get; set; }
		public string Phone { get; set; }
		public string DealerABN { get; set; }
		public string Comments { get; set; }
	}

	public enum CarPriceType {
		POA,
		DAP,
		EGC
	}
}

