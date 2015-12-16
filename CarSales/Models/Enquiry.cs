using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarSales.Models
{
	public class Enquiry
	{
		public Enquiry ()
		{
		}

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EnquiryID { get; set; }

        public string Name { get; set; }
		public string Email { get; set; }
		public string Recipient { get; set; }
	}
}

